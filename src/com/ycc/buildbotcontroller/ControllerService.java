package com.ycc.buildbotcontroller;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.ServerSocket;
import java.net.Socket;

import com.ycc.usbcontroller.IUsbConnectionHandler;
import com.ycc.usbcontroller.UsbController;
import com.ycc.usbcontroller.L;

import android.app.Service;
import android.content.Intent;
import android.os.Handler;
import android.os.IBinder;
import android.util.Log;
import android.widget.Toast;

public class ControllerService extends Service {
	private static final String TAG = "ControllerService";
	
	private int serverPort;
	private ServerSocket svr;
	private boolean closed;
	
	private Handler handler;
	
	private static final int VID = 0x2341;
	private static final int PID = 0x0043;//I believe it is 0x0000 for the Arduino Megas
	private static UsbController sUsbController;
	
	@Override
	public IBinder onBind(Intent intent) {
		return null;
	}
	
	@Override
	public void onCreate() {
//		Toast.makeText(this, "Service created", Toast.LENGTH_SHORT).show();
		closed = false; 
		handler = new Handler();
		Log.d(TAG, "onCreate");
	}

	@Override
	public void onDestroy() {
//		Toast.makeText(this, "Service destroyed", Toast.LENGTH_SHORT).show();
		try {
			sUsbController.stop();
			sUsbController = null;
			svr.close();
		} catch (IOException e) {
			e.printStackTrace();
		}
		closed = true; 
		Log.d(TAG, "onDestroy");
	}
	
	@Override
	public int onStartCommand(Intent intent, int flags, int startId) {
		Log.d(TAG, "onStart");
		
		serverPort = intent.getIntExtra("PORT", 8888);
		
		ConnectionThread conThread = new ConnectionThread(); 
		new Thread(conThread).start();
		
		if(sUsbController == null){
			mes("Start Initializing USB");
	        sUsbController = new UsbController(this, mConnectionHandler, VID, PID);
        }
		else {
	        mes("sUsbController is not null");
		}
		
		return Service.START_NOT_STICKY; 
	}
		
	class ConnectionThread implements Runnable {
		public void run() {
			Socket cli = null; 
			try {
				 svr = new ServerSocket(serverPort);
			} catch (IOException e) {
				e.printStackTrace();
			}
			while (!closed) {
				try {
//					Log.d(TAG, ">---< Connected 1 >---<");
					cli = svr.accept();
//					Log.d(TAG, ">---< Connected 2 >---<");
					//Toast.makeText(ControllerService.this, "Connected to " + cli.getLocalAddress().toString(), Toast.LENGTH_SHORT).show();
					CommunicationThread commThread = new CommunicationThread(cli);
					new Thread(commThread).start();
				} catch (IOException e) {
					e.printStackTrace();
				}
			}
		}
	}
	
	//COMMUNICATION 
	
	class CommunicationThread implements Runnable {
		private Socket clientSocket;
		private BufferedReader input; 
		public CommunicationThread(Socket clientSocket) {
			this.clientSocket = clientSocket;
			try {
				this.input = new BufferedReader(new InputStreamReader(this.clientSocket.getInputStream()));
			} catch (IOException e) {
				e.printStackTrace();
			}
		}
		public void run() {
			while (!closed) {
				try {
					Log.d(TAG, "PASSED 1");
					String data = this.input.readLine();
					if (data == null) break; 
					Log.d(TAG, "Data: " + data);
					if (data.charAt(data.length() - 1) 	== '!') {
						data = data.substring(0, data.length() - 1);
						final String fdata = data;
						handler.post(new Runnable() {
							@Override
							public void run() {
								mes(fdata);
							}
						});
					}
					else {
						long B = Long.parseLong(data);		
						final long b1 = B & 0xFF;
						final long b2 = (B >> 8) & 0xFF;
						
//						handler.post(new Runnable() {
//							@Override
//							public void run() {
//								mes(String.valueOf(b1) + " " + String.valueOf(b2));
//							}
//						});
						if (sUsbController != null) {
							sUsbController.send((byte)b1);
							Thread.sleep(50);
							sUsbController.send((byte)b2);
							L.d("Sent: " + String.valueOf(B));
						}
					}
				} catch (IOException e) {
					e.printStackTrace(); 
					break; 
				} catch (NumberFormatException e) {
					e.printStackTrace();
					break; 
				} catch (IndexOutOfBoundsException e) {
					e.printStackTrace();
					break; 
				} catch (InterruptedException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
			}
		}
	}
	
	private final IUsbConnectionHandler mConnectionHandler = new IUsbConnectionHandler() {
		@Override
		public void onUsbStopped() {
			L.e("Usb stopped!");
		}
		
		@Override
		public void onErrorLooperRunningAlready() {
			L.e("Looper already running!");
		}
		
		@Override
		public void onDeviceNotFound() {
			L.e("Device not found");
			if(sUsbController != null){
				sUsbController.stop();
				sUsbController = null;
			}
		}
	};
	
	private void mes(String msg) {
		Toast.makeText(ControllerService.this, msg, Toast.LENGTH_SHORT).show();
	}
}
