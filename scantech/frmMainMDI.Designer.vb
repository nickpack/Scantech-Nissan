<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.statusPort = New System.Windows.Forms.ToolStripStatusLabel
        Me.StatusTimout = New System.Windows.Forms.ToolStripStatusLabel
        Me.tsProgress = New System.Windows.Forms.ToolStripProgressBar
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.tmrPortStatus = New System.Windows.Forms.Timer(Me.components)
        Me.tbConnect = New System.Windows.Forms.ToolStripButton
        Me.tbComPort = New System.Windows.Forms.ToolStripComboBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.StartMonitoringECU = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ConductStationaryTestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EngineData = New System.Windows.Forms.ToolStripMenuItem
        Me.GridStyleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GaugesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GraphingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DiagnosticFaultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AlertMonitoringSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.ConductRoadTestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SpeedTrialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RoadDynoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Settings = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.tbEcuProfile = New System.Windows.Forms.ToolStripMenuItem
        Me.RegisterTest = New System.Windows.Forms.ToolStripMenuItem
        Me.ConductECUTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RegisterDecoderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator
        Me.CreateECUProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ShareUploadECUProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Inspector = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.tmrTimeout = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusPort, Me.StatusTimout, Me.tsProgress})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 482)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(766, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'statusPort
        '
        Me.statusPort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.statusPort.Image = Global.ScantechNissan.My.Resources.Resources.LedBlack
        Me.statusPort.Name = "statusPort"
        Me.statusPort.Size = New System.Drawing.Size(16, 17)
        Me.statusPort.ToolTipText = "Com Port Status"
        '
        'StatusTimout
        '
        Me.StatusTimout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StatusTimout.Image = Global.ScantechNissan.My.Resources.Resources.LedBlack
        Me.StatusTimout.Name = "StatusTimout"
        Me.StatusTimout.Size = New System.Drawing.Size(16, 17)
        Me.StatusTimout.ToolTipText = "InBuffer Status"
        '
        'tsProgress
        '
        Me.tsProgress.Maximum = 32
        Me.tsProgress.Name = "tsProgress"
        Me.tsProgress.Size = New System.Drawing.Size(100, 22)
        Me.tsProgress.Visible = False
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.Tag = ""
        '
        'tmrPortStatus
        '
        Me.tmrPortStatus.Enabled = True
        Me.tmrPortStatus.Interval = 50
        '
        'tbConnect
        '
        Me.tbConnect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbConnect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbConnect.Name = "tbConnect"
        Me.tbConnect.Size = New System.Drawing.Size(67, 26)
        Me.tbConnect.Text = "CONNECT"
        '
        'tbComPort
        '
        Me.tbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tbComPort.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbComPort.Name = "tbComPort"
        Me.tbComPort.Size = New System.Drawing.Size(121, 29)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbConnect, Me.tbComPort})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 29)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(766, 29)
        Me.ToolStrip1.TabIndex = 19
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'StartMonitoringECU
        '
        Me.StartMonitoringECU.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator5, Me.ConductStationaryTestsToolStripMenuItem, Me.SToolStripMenuItem1, Me.ConductRoadTestsToolStripMenuItem})
        Me.StartMonitoringECU.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.StartMonitoringECU.Name = "StartMonitoringECU"
        Me.StartMonitoringECU.Size = New System.Drawing.Size(170, 25)
        Me.StartMonitoringECU.Text = "&Start Monitoring ECU"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(214, 6)
        '
        'ConductStationaryTestsToolStripMenuItem
        '
        Me.ConductStationaryTestsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EngineData, Me.DiagnosticFaultsToolStripMenuItem, Me.AlertMonitoringSystemToolStripMenuItem})
        Me.ConductStationaryTestsToolStripMenuItem.Name = "ConductStationaryTestsToolStripMenuItem"
        Me.ConductStationaryTestsToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.ConductStationaryTestsToolStripMenuItem.Text = "Conduct Tests"
        '
        'EngineData
        '
        Me.EngineData.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GridStyleToolStripMenuItem, Me.GaugesToolStripMenuItem, Me.GraphingToolStripMenuItem})
        Me.EngineData.Name = "EngineData"
        Me.EngineData.Size = New System.Drawing.Size(273, 26)
        Me.EngineData.Text = "Data Monitoring"
        '
        'GridStyleToolStripMenuItem
        '
        Me.GridStyleToolStripMenuItem.Name = "GridStyleToolStripMenuItem"
        Me.GridStyleToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.GridStyleToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.GridStyleToolStripMenuItem.Text = "Grid Style..."
        '
        'GaugesToolStripMenuItem
        '
        Me.GaugesToolStripMenuItem.Name = "GaugesToolStripMenuItem"
        Me.GaugesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.GaugesToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.GaugesToolStripMenuItem.Text = "Gauges..."
        '
        'GraphingToolStripMenuItem
        '
        Me.GraphingToolStripMenuItem.Name = "GraphingToolStripMenuItem"
        Me.GraphingToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.GraphingToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.GraphingToolStripMenuItem.Text = "Graphing..."
        '
        'DiagnosticFaultsToolStripMenuItem
        '
        Me.DiagnosticFaultsToolStripMenuItem.Name = "DiagnosticFaultsToolStripMenuItem"
        Me.DiagnosticFaultsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.DiagnosticFaultsToolStripMenuItem.Size = New System.Drawing.Size(273, 26)
        Me.DiagnosticFaultsToolStripMenuItem.Text = "Self Diagnostic Results..."
        '
        'AlertMonitoringSystemToolStripMenuItem
        '
        Me.AlertMonitoringSystemToolStripMenuItem.Name = "AlertMonitoringSystemToolStripMenuItem"
        Me.AlertMonitoringSystemToolStripMenuItem.Size = New System.Drawing.Size(273, 26)
        Me.AlertMonitoringSystemToolStripMenuItem.Text = "Alert Monitoring System..."
        '
        'SToolStripMenuItem1
        '
        Me.SToolStripMenuItem1.Name = "SToolStripMenuItem1"
        Me.SToolStripMenuItem1.Size = New System.Drawing.Size(214, 6)
        '
        'ConductRoadTestsToolStripMenuItem
        '
        Me.ConductRoadTestsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SpeedTrialToolStripMenuItem, Me.RoadDynoToolStripMenuItem})
        Me.ConductRoadTestsToolStripMenuItem.Enabled = False
        Me.ConductRoadTestsToolStripMenuItem.Name = "ConductRoadTestsToolStripMenuItem"
        Me.ConductRoadTestsToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.ConductRoadTestsToolStripMenuItem.Text = "Conduct Road Tests"
        '
        'SpeedTrialToolStripMenuItem
        '
        Me.SpeedTrialToolStripMenuItem.Name = "SpeedTrialToolStripMenuItem"
        Me.SpeedTrialToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.SpeedTrialToolStripMenuItem.Text = "Speed Trial..."
        '
        'RoadDynoToolStripMenuItem
        '
        Me.RoadDynoToolStripMenuItem.Name = "RoadDynoToolStripMenuItem"
        Me.RoadDynoToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.RoadDynoToolStripMenuItem.Text = "Road Dyno..."
        '
        'Settings
        '
        Me.Settings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolBarToolStripMenuItem, Me.StatusBarToolStripMenuItem, Me.SToolStripMenuItem2})
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(204, 25)
        Me.Settings.Text = "&Program Settings/Options"
        '
        'ToolBarToolStripMenuItem
        '
        Me.ToolBarToolStripMenuItem.Checked = True
        Me.ToolBarToolStripMenuItem.CheckOnClick = True
        Me.ToolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolBarToolStripMenuItem.Name = "ToolBarToolStripMenuItem"
        Me.ToolBarToolStripMenuItem.Size = New System.Drawing.Size(150, 26)
        Me.ToolBarToolStripMenuItem.Text = "&Toolbar"
        '
        'StatusBarToolStripMenuItem
        '
        Me.StatusBarToolStripMenuItem.Checked = True
        Me.StatusBarToolStripMenuItem.CheckOnClick = True
        Me.StatusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        Me.StatusBarToolStripMenuItem.Size = New System.Drawing.Size(150, 26)
        Me.StatusBarToolStripMenuItem.Text = "&Status Bar"
        '
        'SToolStripMenuItem2
        '
        Me.SToolStripMenuItem2.Name = "SToolStripMenuItem2"
        Me.SToolStripMenuItem2.Size = New System.Drawing.Size(147, 6)
        '
        'tbEcuProfile
        '
        Me.tbEcuProfile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisterTest, Me.ConductECUTestToolStripMenuItem, Me.RegisterDecoderToolStripMenuItem, Me.SToolStripMenuItem, Me.CreateECUProfileToolStripMenuItem, Me.ShareUploadECUProfileToolStripMenuItem})
        Me.tbEcuProfile.Name = "tbEcuProfile"
        Me.tbEcuProfile.Size = New System.Drawing.Size(100, 25)
        Me.tbEcuProfile.Text = "&ECU Profile"
        '
        'RegisterTest
        '
        Me.RegisterTest.Name = "RegisterTest"
        Me.RegisterTest.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.RegisterTest.Size = New System.Drawing.Size(275, 26)
        Me.RegisterTest.Text = "Register Scanner..."
        '
        'ConductECUTestToolStripMenuItem
        '
        Me.ConductECUTestToolStripMenuItem.Name = "ConductECUTestToolStripMenuItem"
        Me.ConductECUTestToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.ConductECUTestToolStripMenuItem.Size = New System.Drawing.Size(275, 26)
        Me.ConductECUTestToolStripMenuItem.Text = "ECU Scanner..."
        '
        'RegisterDecoderToolStripMenuItem
        '
        Me.RegisterDecoderToolStripMenuItem.Name = "RegisterDecoderToolStripMenuItem"
        Me.RegisterDecoderToolStripMenuItem.Size = New System.Drawing.Size(275, 26)
        Me.RegisterDecoderToolStripMenuItem.Text = "Register Decoder..."
        '
        'SToolStripMenuItem
        '
        Me.SToolStripMenuItem.Name = "SToolStripMenuItem"
        Me.SToolStripMenuItem.Size = New System.Drawing.Size(272, 6)
        '
        'CreateECUProfileToolStripMenuItem
        '
        Me.CreateECUProfileToolStripMenuItem.Image = Global.ScantechNissan.My.Resources.Resources.CommentHS
        Me.CreateECUProfileToolStripMenuItem.Name = "CreateECUProfileToolStripMenuItem"
        Me.CreateECUProfileToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9
        Me.CreateECUProfileToolStripMenuItem.Size = New System.Drawing.Size(275, 26)
        Me.CreateECUProfileToolStripMenuItem.Text = "Create/Edit ECU Profile..."
        '
        'ShareUploadECUProfileToolStripMenuItem
        '
        Me.ShareUploadECUProfileToolStripMenuItem.Image = Global.ScantechNissan.My.Resources.Resources.PageUpHS
        Me.ShareUploadECUProfileToolStripMenuItem.Name = "ShareUploadECUProfileToolStripMenuItem"
        Me.ShareUploadECUProfileToolStripMenuItem.Size = New System.Drawing.Size(275, 26)
        Me.ShareUploadECUProfileToolStripMenuItem.Text = "Share/Upload ECU Profile..."
        '
        'Inspector
        '
        Me.Inspector.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator8})
        Me.Inspector.Name = "Inspector"
        Me.Inspector.Size = New System.Drawing.Size(116, 25)
        Me.Inspector.Text = "&Log Inspector"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(57, 6)
        '
        'MenuStrip
        '
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartMonitoringECU, Me.tbEcuProfile, Me.Inspector, Me.Settings, Me.ToolStripMenuItem1})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(766, 29)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 25)
        '
        'tmrTimeout
        '
        Me.tmrTimeout.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.ScantechNissan.My.Resources.Resources.nissanlogo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(766, 504)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MinimumSize = New System.Drawing.Size(700, 500)
        Me.Name = "frmMain"
        Me.Text = "NISSAN CONSULT 1 DIAGNOSTIC SOFTWARE"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents tsProgress As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents tmrPortStatus As System.Windows.Forms.Timer
    Friend WithEvents statusPort As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tbConnect As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbComPort As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents StartMonitoringECU As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ConductStationaryTestsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Settings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbEcuProfile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterTest As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Inspector As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents EngineData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridStyleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GaugesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GraphingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConductRoadTestsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpeedTrialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoadDynoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConductECUTestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateECUProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShareUploadECUProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DiagnosticFaultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AlertMonitoringSystemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterDecoderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrTimeout As System.Windows.Forms.Timer
    Friend WithEvents StatusTimout As System.Windows.Forms.ToolStripStatusLabel

End Class
