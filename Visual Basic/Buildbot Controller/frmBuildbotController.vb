Imports System.Net.Sockets
Imports System.Threading
Imports System.Net.NetworkInformation
Imports System.IO

Public Class frmBuildbotController


#Region "Connect"
    Dim connectionState As Integer = 0
    Dim clientSocket As New System.Net.Sockets.TcpClient()
    Dim serverStream As NetworkStream


    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        WebBrowserX.Navigate(txtAddress.Text)
        picLoading.Image = My.Resources.iconLoading
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        If connectionState = 0 Then
            Dim info(2) As Object
            info(0) = txtIPAddress.Text
            info(1) = numPort.Value
            Dim connectThread As New Thread(AddressOf connectProc)
            connectThread.Start(info)
        ElseIf connectionState = 2 Then
            clientSocket.Close()
        End If
    End Sub

    Private Sub ChangeState()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ChangeState))
        End If

        Select Case connectionState
            Case 0
                btnConnect.Enabled = True
                btnConnect.Text = "Connect"
                lblConnection.ForeColor = Color.Red
                lblConnection.Text = "Not Connected"
                txtIPAddress.Enabled = True
                numPort.Enabled = True
                grbControllingZone.Enabled = False
                grbTesting.Enabled = False
                tmrCombineKeys.Enabled = False
            Case 1
                btnConnect.Enabled = False
                lblConnection.ForeColor = Color.YellowGreen
                lblConnection.Text = "Connecting..."
                txtIPAddress.Enabled = False
                numPort.Enabled = False
                grbControllingZone.Enabled = False
                grbTesting.Enabled = False
                tmrCombineKeys.Enabled = False
            Case 2
                btnConnect.Enabled = True
                btnConnect.Text = "Disconnect"
                lblConnection.ForeColor = Color.Green
                lblConnection.Text = "Connected"
                txtIPAddress.Enabled = False
                numPort.Enabled = False
                grbControllingZone.Enabled = True
                grbTesting.Enabled = True
                tmrCombineKeys.Enabled = True
        End Select

    End Sub

    Private Sub connectProc(ByVal info As Object)
        Dim ip As String = info(0)
        Dim port As UInteger = info(1)
        Do
            Try
                connectionState = 1
                ChangeState()
                clientSocket = New TcpClient
                clientSocket.Connect(ip, port)
                serverStream = clientSocket.GetStream
                connectionState = 2
                ChangeState()
                Exit Do
            Catch ex As Exception
                If MessageBox.Show("Connection error!" + vbCrLf + vbCrLf + ex.Message.ToString, Application.ProductName,
                   MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) = Windows.Forms.DialogResult.Cancel Then
                    connectionState = 0
                    ChangeState()
                    Exit Sub
                End If
            End Try
        Loop While True
        Dim p As New Ping
        Do
            Try
                'Dim repP = p.Send(ip, port)
                'If repP.Status <> IPStatus.Success Then
                If clientSocket.Connected = False Then
                    connectionState = 0
                    ChangeState()
                    Exit Sub
                End If
                Thread.Sleep(500)
            Catch ex As Exception
                connectionState = 0
                ChangeState()
                Exit Sub
            End Try

        Loop While True
    End Sub


    Private Sub WebBrowserX_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowserX.DocumentCompleted
        Dim iconURL = "http://" & WebBrowserX.Url.Host & "/favicon.ico"
        Dim request As System.Net.WebRequest = System.Net.HttpWebRequest.Create(iconURL)
        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim stream As System.IO.Stream = response.GetResponseStream()
        Dim favicon = New Bitmap(Image.FromStream(stream), picLoading.Size())
        If stream.WriteTimeout Then
            picLoading.Image = favicon
        Else
            picLoading.Image = My.Resources.iconLoading1
        End If

    End Sub

    Private Sub btnWebBack_Click(sender As Object, e As EventArgs) Handles btnWebBack.Click
        WebBrowserX.GoBack()
    End Sub

    Private Sub btnWebForward_Click(sender As Object, e As EventArgs) Handles btnWebForward.Click
        WebBrowserX.GoForward()
    End Sub

#End Region

#Region "Control"

    Dim b, lastb As Integer
    Dim setButtons(300) As Integer

    Private Sub SendData(str As String)
        Try
            Dim data As Byte() = System.Text.Encoding.ASCII.GetBytes(str + vbCrLf)
            serverStream.Write(data, 0, data.Length)
            serverStream.Flush()
        Catch ex As Exception
            MessageBox.Show("Error while sending data: " + vbCrLf + vbCrLf + ex.Message.ToString, Application.ProductName,
                               MessageBoxButtons.OK, MessageBoxIcon.Error)
            connectionState = 0
            ChangeState()
            Exit Sub
        End Try
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        SendData(txtTest.Text + "!")
    End Sub

    Dim mark(300) As Boolean

    Private Sub txtControlZone_KeyDown(sender As Object, e As KeyEventArgs) Handles txtControlZone.KeyDown
        mark(e.KeyValue) = True
    End Sub

    Private Sub txtControlZone_KeyUp(sender As Object, e As KeyEventArgs) Handles txtControlZone.KeyUp
        mark(e.KeyValue) = False
    End Sub

    Dim con As Windows.Forms.KeysConverter = New Windows.Forms.KeysConverter
    Private Sub tmrCombineKeys_Tick(sender As Object, e As EventArgs) Handles tmrCombineKeys.Tick
        b = 0
        txtControlZone.Text = ""
        For i As Integer = 0 To 299
            If mark(i) And setButtons(i) <> -1 Then
                txtControlZone.Text += con.ConvertToString(i) + " "
                b = b Or (1 << setButtons(i))
            End If
        Next
        b = Not b
        Dim sb1, sb2 As String
        sb1 = ""
        sb2 = ""
        For i As Integer = 0 To 7
            sb1 = CStr((b >> i) And 1) + sb1
            sb2 = CStr((b >> (i + 8)) And 1) + sb2
        Next

        If lastb <> b Then
            lblDataSent.Text = "Data sent: " & sb2 & " " & sb1
            SendData(CStr(b))
            lastb = b
        End If
    End Sub

#End Region

#Region "Handling Controlling Buttons"

    Dim buttonNames As New List(Of String)(New String() {"btnForw", "btnBack", "btnLeft", "btnRight", "btnGCCW",
                                                         "btnRotCCW", "btnSet1", "btnSet2", "btnGCW", "btnRotCW",
                                                         "btnUp", "btnDown", "btnOpen", "btnClose"})
    Dim controlButtons As New List(Of Windows.Forms.Button)

    Private Sub RefreshButtons()
        For i As Integer = 0 To setButtons.Length - 1
            setButtons(i) = -1
        Next
        For Each ctrl As Control In controlButtons
            Dim btn As Button = DirectCast(ctrl, Button)
            setButtons(con.ConvertFromString(btn.Text)) = btn.Tag
        Next
    End Sub

    Private Sub frmBuildbotController_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        For i As Integer = 0 To setButtons.Length - 1
            setButtons(i) = -1
        Next
        For Each ctrl As Control In Me.tblControl.Controls
            If buttonNames.Contains(ctrl.Name.ToString) Then
                controlButtons.Add(ctrl)
                Dim btn As Button = DirectCast(ctrl, Button)
                setButtons(con.ConvertFromString(btn.Text)) = btn.Tag
                AddHandler btn.Click, AddressOf control_click
            End If
        Next
    End Sub

    Private Sub control_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim but As Windows.Forms.Button = DirectCast(sender, Button)
        Dim fsb As Windows.Forms.Form = New frmSetButtons(but, toolTip.GetToolTip(but))
        fsb.ShowDialog()
        RefreshButtons()
    End Sub

#End Region

End Class
