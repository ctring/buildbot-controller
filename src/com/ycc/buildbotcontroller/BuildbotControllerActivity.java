package com.ycc.buildbotcontroller;

import java.net.InetAddress;
import java.net.NetworkInterface;
import java.net.SocketException;
import java.util.Enumeration;

import android.app.Activity;
import android.app.ActivityManager;
import android.app.ActivityManager.RunningServiceInfo;
import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class BuildbotControllerActivity extends Activity {

	Button toggle;
	TextView txtIP;
	String IP; 
	boolean serviceOn;
	
	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.connection);
	}
	
	@Override 
	public void onStart() {
		super.onStart();
		toggle = (Button) findViewById(R.id.btnToggle);
		txtIP = (TextView) findViewById(R.id.txtAddress);
		serviceOn = controllerIsRunning();
		if (serviceOn) {
			toggle.setBackgroundResource(R.drawable.stop_state);
			IP = GetLocalIpAddress() + ":8888";
			txtIP.setText("Connect to this IP Address: " + IP);
		}
		else {
			toggle.setBackgroundResource(R.drawable.start_state);
			txtIP.setText(R.string.txtIP);
		}
	}
	
	private boolean controllerIsRunning() {
	    ActivityManager manager = (ActivityManager) getSystemService(Context.ACTIVITY_SERVICE);
	    for (RunningServiceInfo service : manager.getRunningServices(Integer.MAX_VALUE)) {
	        if (ControllerService.class.getName().equals(service.service.getClassName())) {
	            return true;
	        }
	    }
	    return false;
	}
	
	public void serviceToggle(View view) {
		if (!serviceOn) {
			Intent i = new Intent(this, ControllerService.class);
			i.putExtra("PORT", 8888);
			startService(i);
			serviceOn = true;
			toggle.setBackgroundResource(R.drawable.stop_state);
			IP = GetLocalIpAddress() + ":8888";
			txtIP.setText("Connect to this IP Address: " + IP);
		}
		else {
			stopService(new Intent(this, ControllerService.class));
			serviceOn = false; 
			toggle.setBackgroundResource(R.drawable.start_state);
			txtIP.setText(R.string.txtIP);
		}
	}
	
	private String GetLocalIpAddress()
    {
        try {
            for (Enumeration<NetworkInterface> en = NetworkInterface.getNetworkInterfaces(); en.hasMoreElements();) {
                NetworkInterface intf = en.nextElement();
                for (Enumeration<InetAddress> enumIpAddr = intf.getInetAddresses(); enumIpAddr.hasMoreElements();) {
                    InetAddress inetAddress = enumIpAddr.nextElement();
                    if (!inetAddress.isLoopbackAddress()) {
                        return inetAddress.getHostAddress().toString();
                    }
                }
            }
        } catch (SocketException ex) {
            return "ERROR Obtaining IP";
        }
        return "No IP Available";   
    }
}
