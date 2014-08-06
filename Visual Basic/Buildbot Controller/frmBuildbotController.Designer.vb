<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuildbotController
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuildbotController))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.statusStrip = New System.Windows.Forms.StatusStrip()
        Me.lblConnection = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDataSent = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.grbConnection = New System.Windows.Forms.GroupBox()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.lblIp = New System.Windows.Forms.Label()
        Me.txtIPAddress = New System.Windows.Forms.TextBox()
        Me.numPort = New System.Windows.Forms.NumericUpDown()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.tblControl = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnGCW = New System.Windows.Forms.Button()
        Me.btnGCCW = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnRotCW = New System.Windows.Forms.Button()
        Me.btnForw = New System.Windows.Forms.Button()
        Me.btnRotCCW = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSet1 = New System.Windows.Forms.Button()
        Me.btnSet2 = New System.Windows.Forms.Button()
        Me.grbTesting = New System.Windows.Forms.GroupBox()
        Me.lblData = New System.Windows.Forms.Label()
        Me.txtTest = New System.Windows.Forms.TextBox()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.lblControlPanel = New System.Windows.Forms.Label()
        Me.grbControllingZone = New System.Windows.Forms.GroupBox()
        Me.txtControlZone = New System.Windows.Forms.TextBox()
        Me.pnlController = New System.Windows.Forms.Panel()
        Me.WebBrowserX = New System.Windows.Forms.WebBrowser()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnWebBack = New System.Windows.Forms.Button()
        Me.btnWebForward = New System.Windows.Forms.Button()
        Me.picLoading = New System.Windows.Forms.PictureBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.tmrCombineKeys = New System.Windows.Forms.Timer(Me.components)
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.statusStrip.SuspendLayout()
        Me.grbConnection.SuspendLayout()
        CType(Me.numPort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblControl.SuspendLayout()
        Me.grbTesting.SuspendLayout()
        Me.grbControllingZone.SuspendLayout()
        Me.pnlController.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.statusStrip)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblCopyright)
        Me.SplitContainer1.Panel1.Controls.Add(Me.grbConnection)
        Me.SplitContainer1.Panel1.Controls.Add(Me.tblControl)
        Me.SplitContainer1.Panel1.Controls.Add(Me.grbTesting)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblControlPanel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.grbControllingZone)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlController)
        Me.SplitContainer1.Size = New System.Drawing.Size(1038, 683)
        Me.SplitContainer1.SplitterDistance = 786
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 0
        '
        'statusStrip
        '
        Me.statusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblConnection, Me.lblDataSent})
        Me.statusStrip.Location = New System.Drawing.Point(0, 657)
        Me.statusStrip.Name = "statusStrip"
        Me.statusStrip.Size = New System.Drawing.Size(784, 24)
        Me.statusStrip.TabIndex = 20
        Me.statusStrip.Text = "StatusStrip1"
        '
        'lblConnection
        '
        Me.lblConnection.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.lblConnection.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.lblConnection.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnection.ForeColor = System.Drawing.Color.Red
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(95, 19)
        Me.lblConnection.Text = "Not Connected"
        '
        'lblDataSent
        '
        Me.lblDataSent.Name = "lblDataSent"
        Me.lblDataSent.Size = New System.Drawing.Size(60, 19)
        Me.lblDataSent.Text = "Data Sent:"
        '
        'lblCopyright
        '
        Me.lblCopyright.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.lblCopyright.Location = New System.Drawing.Point(349, 630)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(86, 17)
        Me.lblCopyright.TabIndex = 16
        Me.lblCopyright.Text = "NDTC © 2013"
        '
        'grbConnection
        '
        Me.grbConnection.Controls.Add(Me.lblPort)
        Me.grbConnection.Controls.Add(Me.lblIp)
        Me.grbConnection.Controls.Add(Me.txtIPAddress)
        Me.grbConnection.Controls.Add(Me.numPort)
        Me.grbConnection.Controls.Add(Me.btnConnect)
        Me.grbConnection.Dock = System.Windows.Forms.DockStyle.Top
        Me.grbConnection.Location = New System.Drawing.Point(0, 0)
        Me.grbConnection.Name = "grbConnection"
        Me.grbConnection.Size = New System.Drawing.Size(784, 138)
        Me.grbConnection.TabIndex = 0
        Me.grbConnection.TabStop = False
        Me.grbConnection.Text = "Connection"
        '
        'lblPort
        '
        Me.lblPort.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(459, 27)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(26, 13)
        Me.lblPort.TabIndex = 4
        Me.lblPort.Text = "Port"
        '
        'lblIp
        '
        Me.lblIp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblIp.AutoSize = True
        Me.lblIp.Location = New System.Drawing.Point(240, 27)
        Me.lblIp.Name = "lblIp"
        Me.lblIp.Size = New System.Drawing.Size(58, 13)
        Me.lblIp.TabIndex = 3
        Me.lblIp.Text = "IP Address"
        '
        'txtIPAddress
        '
        Me.txtIPAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtIPAddress.Location = New System.Drawing.Point(243, 43)
        Me.txtIPAddress.Name = "txtIPAddress"
        Me.txtIPAddress.Size = New System.Drawing.Size(213, 20)
        Me.txtIPAddress.TabIndex = 2
        '
        'numPort
        '
        Me.numPort.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.numPort.Location = New System.Drawing.Point(462, 43)
        Me.numPort.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.numPort.Name = "numPort"
        Me.numPort.Size = New System.Drawing.Size(83, 20)
        Me.numPort.TabIndex = 1
        Me.numPort.Value = New Decimal(New Integer() {8888, 0, 0, 0})
        '
        'btnConnect
        '
        Me.btnConnect.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnConnect.Location = New System.Drawing.Point(304, 81)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(152, 31)
        Me.btnConnect.TabIndex = 0
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'tblControl
        '
        Me.tblControl.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tblControl.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tblControl.ColumnCount = 7
        Me.tblControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78947!))
        Me.tblControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78947!))
        Me.tblControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78947!))
        Me.tblControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.263158!))
        Me.tblControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78947!))
        Me.tblControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78947!))
        Me.tblControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78947!))
        Me.tblControl.Controls.Add(Me.btnDown, 4, 1)
        Me.tblControl.Controls.Add(Me.btnRight, 2, 1)
        Me.tblControl.Controls.Add(Me.btnLeft, 0, 1)
        Me.tblControl.Controls.Add(Me.btnGCW, 6, 0)
        Me.tblControl.Controls.Add(Me.btnGCCW, 5, 0)
        Me.tblControl.Controls.Add(Me.btnUp, 4, 0)
        Me.tblControl.Controls.Add(Me.btnRotCW, 2, 0)
        Me.tblControl.Controls.Add(Me.btnForw, 1, 0)
        Me.tblControl.Controls.Add(Me.btnRotCCW, 0, 0)
        Me.tblControl.Controls.Add(Me.btnBack, 1, 2)
        Me.tblControl.Controls.Add(Me.btnOpen, 5, 1)
        Me.tblControl.Controls.Add(Me.btnClose, 6, 1)
        Me.tblControl.Controls.Add(Me.btnSet1, 4, 2)
        Me.tblControl.Controls.Add(Me.btnSet2, 5, 2)
        Me.tblControl.Location = New System.Drawing.Point(107, 169)
        Me.tblControl.Name = "tblControl"
        Me.tblControl.RowCount = 3
        Me.tblControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tblControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblControl.Size = New System.Drawing.Size(570, 228)
        Me.tblControl.TabIndex = 0
        '
        'btnDown
        '
        Me.btnDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnDown.Location = New System.Drawing.Point(301, 79)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(82, 68)
        Me.btnDown.TabIndex = 11
        Me.btnDown.Tag = "14"
        Me.btnDown.Text = "K"
        Me.toolTip.SetToolTip(Me.btnDown, "Lower")
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnRight.Location = New System.Drawing.Point(182, 79)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(82, 68)
        Me.btnRight.TabIndex = 9
        Me.btnRight.Tag = "5"
        Me.btnRight.Text = "D"
        Me.toolTip.SetToolTip(Me.btnRight, "Go Right")
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnLeft
        '
        Me.btnLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnLeft.Location = New System.Drawing.Point(4, 79)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(82, 68)
        Me.btnLeft.TabIndex = 7
        Me.btnLeft.Tag = "7"
        Me.btnLeft.Text = "A"
        Me.toolTip.SetToolTip(Me.btnLeft, "Go Left")
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'btnGCW
        '
        Me.btnGCW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnGCW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnGCW.Location = New System.Drawing.Point(479, 4)
        Me.btnGCW.Name = "btnGCW"
        Me.btnGCW.Size = New System.Drawing.Size(87, 68)
        Me.btnGCW.TabIndex = 6
        Me.btnGCW.Tag = "11"
        Me.btnGCW.Text = "O"
        Me.toolTip.SetToolTip(Me.btnGCW, "Turn Crane Clockwise")
        Me.btnGCW.UseVisualStyleBackColor = True
        '
        'btnGCCW
        '
        Me.btnGCCW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnGCCW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnGCCW.Location = New System.Drawing.Point(390, 4)
        Me.btnGCCW.Name = "btnGCCW"
        Me.btnGCCW.Size = New System.Drawing.Size(82, 68)
        Me.btnGCCW.TabIndex = 5
        Me.btnGCCW.Tag = "10"
        Me.btnGCCW.Text = "U"
        Me.toolTip.SetToolTip(Me.btnGCCW, "Turn Crane Counterclockwise")
        Me.btnGCCW.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnUp.Location = New System.Drawing.Point(301, 4)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(82, 68)
        Me.btnUp.TabIndex = 4
        Me.btnUp.Tag = "12"
        Me.btnUp.Text = "I"
        Me.toolTip.SetToolTip(Me.btnUp, "Lift")
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnRotCW
        '
        Me.btnRotCW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRotCW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnRotCW.Location = New System.Drawing.Point(182, 4)
        Me.btnRotCW.Name = "btnRotCW"
        Me.btnRotCW.Size = New System.Drawing.Size(82, 68)
        Me.btnRotCW.TabIndex = 2
        Me.btnRotCW.Tag = "9"
        Me.btnRotCW.Text = "E"
        Me.toolTip.SetToolTip(Me.btnRotCW, "Turn Clockwise")
        Me.btnRotCW.UseVisualStyleBackColor = True
        '
        'btnForw
        '
        Me.btnForw.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnForw.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnForw.Location = New System.Drawing.Point(93, 4)
        Me.btnForw.Name = "btnForw"
        Me.btnForw.Size = New System.Drawing.Size(82, 68)
        Me.btnForw.TabIndex = 1
        Me.btnForw.Tag = "6"
        Me.btnForw.Text = "W"
        Me.toolTip.SetToolTip(Me.btnForw, "Go Forward")
        Me.btnForw.UseVisualStyleBackColor = True
        '
        'btnRotCCW
        '
        Me.btnRotCCW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRotCCW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnRotCCW.Location = New System.Drawing.Point(4, 4)
        Me.btnRotCCW.Name = "btnRotCCW"
        Me.btnRotCCW.Size = New System.Drawing.Size(82, 68)
        Me.btnRotCCW.TabIndex = 0
        Me.btnRotCCW.Tag = "8"
        Me.btnRotCCW.Text = "Q"
        Me.toolTip.SetToolTip(Me.btnRotCCW, "Turn Counterclockwise")
        Me.btnRotCCW.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnBack.Location = New System.Drawing.Point(93, 154)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(82, 70)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Tag = "4"
        Me.btnBack.Text = "S"
        Me.toolTip.SetToolTip(Me.btnBack, "Go Backward")
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnOpen.Location = New System.Drawing.Point(390, 79)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(82, 68)
        Me.btnOpen.TabIndex = 10
        Me.btnOpen.Tag = "15"
        Me.btnOpen.Text = "J"
        Me.toolTip.SetToolTip(Me.btnOpen, "Open Crane")
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnClose.Location = New System.Drawing.Point(479, 79)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(87, 68)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Tag = "13"
        Me.btnClose.Text = "L"
        Me.toolTip.SetToolTip(Me.btnClose, "Close Crane")
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSet1
        '
        Me.btnSet1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnSet1.Location = New System.Drawing.Point(301, 154)
        Me.btnSet1.Name = "btnSet1"
        Me.btnSet1.Size = New System.Drawing.Size(82, 68)
        Me.btnSet1.TabIndex = 12
        Me.btnSet1.Tag = "0"
        Me.btnSet1.Text = "Z"
        Me.toolTip.SetToolTip(Me.btnSet1, "Set Speed 1")
        Me.btnSet1.UseVisualStyleBackColor = True
        '
        'btnSet2
        '
        Me.btnSet2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSet2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnSet2.Location = New System.Drawing.Point(390, 155)
        Me.btnSet2.Name = "btnSet2"
        Me.btnSet2.Size = New System.Drawing.Size(82, 68)
        Me.btnSet2.TabIndex = 13
        Me.btnSet2.Tag = "3"
        Me.btnSet2.Text = "X"
        Me.toolTip.SetToolTip(Me.btnSet2, "Set Speed 2")
        Me.btnSet2.UseVisualStyleBackColor = True
        '
        'grbTesting
        '
        Me.grbTesting.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grbTesting.Controls.Add(Me.lblData)
        Me.grbTesting.Controls.Add(Me.txtTest)
        Me.grbTesting.Controls.Add(Me.btnTest)
        Me.grbTesting.Enabled = False
        Me.grbTesting.Location = New System.Drawing.Point(185, 500)
        Me.grbTesting.Name = "grbTesting"
        Me.grbTesting.Size = New System.Drawing.Size(418, 83)
        Me.grbTesting.TabIndex = 18
        Me.grbTesting.TabStop = False
        Me.grbTesting.Text = "Testing"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(51, 28)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(33, 13)
        Me.lblData.TabIndex = 12
        Me.lblData.Text = "Data "
        '
        'txtTest
        '
        Me.txtTest.Location = New System.Drawing.Point(54, 44)
        Me.txtTest.Name = "txtTest"
        Me.txtTest.Size = New System.Drawing.Size(235, 20)
        Me.txtTest.TabIndex = 0
        '
        'btnTest
        '
        Me.btnTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnTest.Location = New System.Drawing.Point(295, 41)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(70, 23)
        Me.btnTest.TabIndex = 11
        Me.btnTest.Text = "Send"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'lblControlPanel
        '
        Me.lblControlPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblControlPanel.AutoSize = True
        Me.lblControlPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblControlPanel.Location = New System.Drawing.Point(357, 146)
        Me.lblControlPanel.Name = "lblControlPanel"
        Me.lblControlPanel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblControlPanel.Size = New System.Drawing.Size(70, 23)
        Me.lblControlPanel.TabIndex = 1
        Me.lblControlPanel.Text = "Control Panel"
        '
        'grbControllingZone
        '
        Me.grbControllingZone.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grbControllingZone.Controls.Add(Me.txtControlZone)
        Me.grbControllingZone.Enabled = False
        Me.grbControllingZone.Location = New System.Drawing.Point(185, 417)
        Me.grbControllingZone.Name = "grbControllingZone"
        Me.grbControllingZone.Size = New System.Drawing.Size(418, 77)
        Me.grbControllingZone.TabIndex = 17
        Me.grbControllingZone.TabStop = False
        Me.grbControllingZone.Text = "Controlling Zone"
        '
        'txtControlZone
        '
        Me.txtControlZone.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtControlZone.BackColor = System.Drawing.Color.White
        Me.txtControlZone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtControlZone.Location = New System.Drawing.Point(16, 32)
        Me.txtControlZone.Name = "txtControlZone"
        Me.txtControlZone.ReadOnly = True
        Me.txtControlZone.Size = New System.Drawing.Size(392, 20)
        Me.txtControlZone.TabIndex = 14
        '
        'pnlController
        '
        Me.pnlController.AutoScroll = True
        Me.pnlController.Controls.Add(Me.WebBrowserX)
        Me.pnlController.Controls.Add(Me.Panel1)
        Me.pnlController.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlController.Location = New System.Drawing.Point(0, 0)
        Me.pnlController.Name = "pnlController"
        Me.pnlController.Size = New System.Drawing.Size(244, 681)
        Me.pnlController.TabIndex = 1
        '
        'WebBrowserX
        '
        Me.WebBrowserX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowserX.Location = New System.Drawing.Point(0, 50)
        Me.WebBrowserX.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserX.Name = "WebBrowserX"
        Me.WebBrowserX.Size = New System.Drawing.Size(244, 631)
        Me.WebBrowserX.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnWebBack)
        Me.Panel1.Controls.Add(Me.btnWebForward)
        Me.Panel1.Controls.Add(Me.picLoading)
        Me.Panel1.Controls.Add(Me.btnGo)
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(244, 50)
        Me.Panel1.TabIndex = 0
        '
        'btnWebBack
        '
        Me.btnWebBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnWebBack.Location = New System.Drawing.Point(158, 9)
        Me.btnWebBack.Name = "btnWebBack"
        Me.btnWebBack.Size = New System.Drawing.Size(40, 23)
        Me.btnWebBack.TabIndex = 3
        Me.btnWebBack.Text = "Back"
        Me.btnWebBack.UseVisualStyleBackColor = True
        '
        'btnWebForward
        '
        Me.btnWebForward.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnWebForward.Location = New System.Drawing.Point(201, 9)
        Me.btnWebForward.Name = "btnWebForward"
        Me.btnWebForward.Size = New System.Drawing.Size(40, 23)
        Me.btnWebForward.TabIndex = 4
        Me.btnWebForward.Text = "Forward"
        Me.btnWebForward.UseVisualStyleBackColor = True
        '
        'picLoading
        '
        Me.picLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picLoading.Image = CType(resources.GetObject("picLoading.Image"), System.Drawing.Image)
        Me.picLoading.Location = New System.Drawing.Point(11, 5)
        Me.picLoading.Name = "picLoading"
        Me.picLoading.Size = New System.Drawing.Size(35, 35)
        Me.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picLoading.TabIndex = 2
        Me.picLoading.TabStop = False
        '
        'btnGo
        '
        Me.btnGo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGo.Location = New System.Drawing.Point(112, 9)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(40, 23)
        Me.btnGo.TabIndex = 1
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddress.Location = New System.Drawing.Point(55, 12)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(51, 20)
        Me.txtAddress.TabIndex = 0
        '
        'tmrCombineKeys
        '
        '
        'toolTip
        '
        Me.toolTip.AutomaticDelay = 20
        Me.toolTip.AutoPopDelay = 5000
        Me.toolTip.InitialDelay = 20
        Me.toolTip.ReshowDelay = 4
        '
        'frmBuildbotController
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 683)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBuildbotController"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YCC Buildbot Controller "
        Me.toolTip.SetToolTip(Me, "Turn Counterclosewise")
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.statusStrip.ResumeLayout(False)
        Me.statusStrip.PerformLayout()
        Me.grbConnection.ResumeLayout(False)
        Me.grbConnection.PerformLayout()
        CType(Me.numPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblControl.ResumeLayout(False)
        Me.grbTesting.ResumeLayout(False)
        Me.grbTesting.PerformLayout()
        Me.grbControllingZone.ResumeLayout(False)
        Me.grbControllingZone.PerformLayout()
        Me.pnlController.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents WebBrowserX As System.Windows.Forms.WebBrowser
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents grbConnection As System.Windows.Forms.GroupBox
    Friend WithEvents pnlController As System.Windows.Forms.Panel
    Friend WithEvents lblPort As System.Windows.Forms.Label
    Friend WithEvents lblIp As System.Windows.Forms.Label
    Friend WithEvents txtIPAddress As System.Windows.Forms.TextBox
    Friend WithEvents numPort As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents picLoading As System.Windows.Forms.PictureBox
    Friend WithEvents btnWebForward As System.Windows.Forms.Button
    Friend WithEvents btnWebBack As System.Windows.Forms.Button
    Friend WithEvents tblControl As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents lblControlPanel As System.Windows.Forms.Label
    Friend WithEvents txtControlZone As System.Windows.Forms.TextBox
    Friend WithEvents tmrCombineKeys As System.Windows.Forms.Timer
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents btnLeft As System.Windows.Forms.Button
    Friend WithEvents btnGCW As System.Windows.Forms.Button
    Friend WithEvents btnGCCW As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnRotCW As System.Windows.Forms.Button
    Friend WithEvents btnForw As System.Windows.Forms.Button
    Friend WithEvents btnRotCCW As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSet1 As System.Windows.Forms.Button
    Friend WithEvents btnSet2 As System.Windows.Forms.Button
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents grbControllingZone As System.Windows.Forms.GroupBox
    Friend WithEvents grbTesting As System.Windows.Forms.GroupBox
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents txtTest As System.Windows.Forms.TextBox
    Friend WithEvents statusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents lblConnection As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblDataSent As System.Windows.Forms.ToolStripStatusLabel

End Class
