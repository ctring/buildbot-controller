Public Class frmSetButtons

    Dim but As Windows.Forms.Button

    Public Sub New(ByVal but As Windows.Forms.Button, ByVal name As String)
        InitializeComponent()
        Me.but = but
        lblInstruction.Text = "Press a key to set button for command: " + name
    End Sub

    Private Sub frmSetButtons_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Dim k As Char = e.KeyChar
        If ("a" <= k And k <= "z") Or ("0" <= k And k <= "9") Then
            but.Text = Char.ToUpper(e.KeyChar)
            Me.Close()
        End If
    End Sub

End Class