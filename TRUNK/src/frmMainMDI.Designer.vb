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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
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
        Me.tmrTimeout = New System.Windows.Forms.Timer(Me.components)
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DisconnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConductStationaryTestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DiagnosticFaultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AlertMonitoringSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConductRoadTestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SpeedTrialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RoadDynoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EngineData = New System.Windows.Forms.ToolStripMenuItem
        Me.BasicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GridStyleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GaugesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GraphingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdvancedToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.MonitorManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tbEcuProfile = New System.Windows.Forms.ToolStripMenuItem
        Me.CreateECUProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator
        Me.AdvancedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RegisterTest = New System.Windows.Forms.ToolStripMenuItem
        Me.ConductECUTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RegisterDecoderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Inspector = New System.Windows.Forms.ToolStripMenuItem
        Me.LogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Settings = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
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
        Me.StatusStrip.Size = New System.Drawing.Size(1094, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'statusPort
        '
        Me.statusPort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.statusPort.Image = Global.Scantech.Consult.OBD1.Nissan.My.Resources.Resources.LedBlack
        Me.statusPort.Name = "statusPort"
        Me.statusPort.Size = New System.Drawing.Size(16, 17)
        Me.statusPort.ToolTipText = "Com Port Status"
        '
        'StatusTimout
        '
        Me.StatusTimout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StatusTimout.Image = Global.Scantech.Consult.OBD1.Nissan.My.Resources.Resources.LedBlack
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
        Me.ToolStrip1.Size = New System.Drawing.Size(1094, 29)
        Me.ToolStrip1.TabIndex = 19
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tmrTimeout
        '
        Me.tmrTimeout.Interval = 1000
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectToolStripMenuItem, Me.DisconnectToolStripMenuItem, Me.ToolStripMenuItem2, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.toolStripSeparator1, Me.PrintToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.toolStripSeparator2, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 25)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ConnectToolStripMenuItem
        '
        Me.ConnectToolStripMenuItem.Name = "ConnectToolStripMenuItem"
        Me.ConnectToolStripMenuItem.Size = New System.Drawing.Size(172, 26)
        Me.ConnectToolStripMenuItem.Text = "&Connect"
        '
        'DisconnectToolStripMenuItem
        '
        Me.DisconnectToolStripMenuItem.Name = "DisconnectToolStripMenuItem"
        Me.DisconnectToolStripMenuItem.Size = New System.Drawing.Size(172, 26)
        Me.DisconnectToolStripMenuItem.Text = "&Disconnect"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(169, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(172, 26)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(172, 26)
        Me.SaveAsToolStripMenuItem.Text = "Save &As"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(169, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(172, 26)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(172, 26)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Pre&view"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(169, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(172, 26)
        Me.ExitToolStripMenuItem1.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.toolStripSeparator3, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.toolStripSeparator4, Me.SelectAllToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(48, 25)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(173, 26)
        Me.UndoToolStripMenuItem.Text = "&Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(173, 26)
        Me.RedoToolStripMenuItem.Text = "&Redo"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(170, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(173, 26)
        Me.CutToolStripMenuItem.Text = "Cu&t"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(173, 26)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(173, 26)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(170, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(173, 26)
        Me.SelectAllToolStripMenuItem.Text = "Select &All"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConductStationaryTestsToolStripMenuItem, Me.ConductRoadTestsToolStripMenuItem})
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(50, 25)
        Me.TestToolStripMenuItem.Text = "&Test"
        '
        'ConductStationaryTestsToolStripMenuItem
        '
        Me.ConductStationaryTestsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DiagnosticFaultsToolStripMenuItem, Me.AlertMonitoringSystemToolStripMenuItem})
        Me.ConductStationaryTestsToolStripMenuItem.Name = "ConductStationaryTestsToolStripMenuItem"
        Me.ConductStationaryTestsToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.ConductStationaryTestsToolStripMenuItem.Text = "&Stationary Tests"
        '
        'DiagnosticFaultsToolStripMenuItem
        '
        Me.DiagnosticFaultsToolStripMenuItem.Name = "DiagnosticFaultsToolStripMenuItem"
        Me.DiagnosticFaultsToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.DiagnosticFaultsToolStripMenuItem.Text = "ECU Self Diagnostic"
        '
        'AlertMonitoringSystemToolStripMenuItem
        '
        Me.AlertMonitoringSystemToolStripMenuItem.Name = "AlertMonitoringSystemToolStripMenuItem"
        Me.AlertMonitoringSystemToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.AlertMonitoringSystemToolStripMenuItem.Text = "Alert Monitor"
        '
        'ConductRoadTestsToolStripMenuItem
        '
        Me.ConductRoadTestsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SpeedTrialToolStripMenuItem, Me.RoadDynoToolStripMenuItem})
        Me.ConductRoadTestsToolStripMenuItem.Name = "ConductRoadTestsToolStripMenuItem"
        Me.ConductRoadTestsToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.ConductRoadTestsToolStripMenuItem.Text = "&Road Tests"
        '
        'SpeedTrialToolStripMenuItem
        '
        Me.SpeedTrialToolStripMenuItem.Name = "SpeedTrialToolStripMenuItem"
        Me.SpeedTrialToolStripMenuItem.Size = New System.Drawing.Size(157, 26)
        Me.SpeedTrialToolStripMenuItem.Text = "Speed Trial"
        '
        'RoadDynoToolStripMenuItem
        '
        Me.RoadDynoToolStripMenuItem.Name = "RoadDynoToolStripMenuItem"
        Me.RoadDynoToolStripMenuItem.Size = New System.Drawing.Size(157, 26)
        Me.RoadDynoToolStripMenuItem.Text = "Road Dyno"
        '
        'EngineData
        '
        Me.EngineData.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BasicToolStripMenuItem, Me.AdvancedToolStripMenuItem1, Me.ToolStripMenuItem4, Me.MonitorManagerToolStripMenuItem})
        Me.EngineData.Name = "EngineData"
        Me.EngineData.Size = New System.Drawing.Size(78, 25)
        Me.EngineData.Text = "&Monitor"
        '
        'BasicToolStripMenuItem
        '
        Me.BasicToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GridStyleToolStripMenuItem, Me.GaugesToolStripMenuItem, Me.GraphingToolStripMenuItem})
        Me.BasicToolStripMenuItem.Name = "BasicToolStripMenuItem"
        Me.BasicToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.BasicToolStripMenuItem.Text = "Basic"
        '
        'GridStyleToolStripMenuItem
        '
        Me.GridStyleToolStripMenuItem.Name = "GridStyleToolStripMenuItem"
        Me.GridStyleToolStripMenuItem.Size = New System.Drawing.Size(132, 26)
        Me.GridStyleToolStripMenuItem.Text = "Grid"
        '
        'GaugesToolStripMenuItem
        '
        Me.GaugesToolStripMenuItem.Name = "GaugesToolStripMenuItem"
        Me.GaugesToolStripMenuItem.Size = New System.Drawing.Size(132, 26)
        Me.GaugesToolStripMenuItem.Text = "Gauges"
        '
        'GraphingToolStripMenuItem
        '
        Me.GraphingToolStripMenuItem.Name = "GraphingToolStripMenuItem"
        Me.GraphingToolStripMenuItem.Size = New System.Drawing.Size(132, 26)
        Me.GraphingToolStripMenuItem.Text = "Graph"
        '
        'AdvancedToolStripMenuItem1
        '
        Me.AdvancedToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripMenuItem7})
        Me.AdvancedToolStripMenuItem1.Name = "AdvancedToolStripMenuItem1"
        Me.AdvancedToolStripMenuItem1.Size = New System.Drawing.Size(202, 26)
        Me.AdvancedToolStripMenuItem1.Text = "Advanced"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(132, 26)
        Me.ToolStripMenuItem5.Text = "Grid"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(132, 26)
        Me.ToolStripMenuItem6.Text = "Gauges"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(132, 26)
        Me.ToolStripMenuItem7.Text = "Graph"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(199, 6)
        '
        'MonitorManagerToolStripMenuItem
        '
        Me.MonitorManagerToolStripMenuItem.Name = "MonitorManagerToolStripMenuItem"
        Me.MonitorManagerToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.MonitorManagerToolStripMenuItem.Text = "Monitor Manager"
        '
        'tbEcuProfile
        '
        Me.tbEcuProfile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateECUProfileToolStripMenuItem, Me.SToolStripMenuItem, Me.AdvancedToolStripMenuItem})
        Me.tbEcuProfile.Name = "tbEcuProfile"
        Me.tbEcuProfile.Size = New System.Drawing.Size(67, 25)
        Me.tbEcuProfile.Text = "&Profile"
        '
        'CreateECUProfileToolStripMenuItem
        '
        Me.CreateECUProfileToolStripMenuItem.Name = "CreateECUProfileToolStripMenuItem"
        Me.CreateECUProfileToolStripMenuItem.Size = New System.Drawing.Size(191, 26)
        Me.CreateECUProfileToolStripMenuItem.Text = "Profile Manager"
        '
        'SToolStripMenuItem
        '
        Me.SToolStripMenuItem.Name = "SToolStripMenuItem"
        Me.SToolStripMenuItem.Size = New System.Drawing.Size(188, 6)
        '
        'AdvancedToolStripMenuItem
        '
        Me.AdvancedToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisterTest, Me.ConductECUTestToolStripMenuItem, Me.RegisterDecoderToolStripMenuItem})
        Me.AdvancedToolStripMenuItem.Name = "AdvancedToolStripMenuItem"
        Me.AdvancedToolStripMenuItem.Size = New System.Drawing.Size(191, 26)
        Me.AdvancedToolStripMenuItem.Text = "Advanced"
        '
        'RegisterTest
        '
        Me.RegisterTest.Name = "RegisterTest"
        Me.RegisterTest.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.RegisterTest.Size = New System.Drawing.Size(219, 26)
        Me.RegisterTest.Text = "Detect Registers"
        '
        'ConductECUTestToolStripMenuItem
        '
        Me.ConductECUTestToolStripMenuItem.Name = "ConductECUTestToolStripMenuItem"
        Me.ConductECUTestToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.ConductECUTestToolStripMenuItem.Size = New System.Drawing.Size(219, 26)
        Me.ConductECUTestToolStripMenuItem.Text = "Detect ECU"
        '
        'RegisterDecoderToolStripMenuItem
        '
        Me.RegisterDecoderToolStripMenuItem.Name = "RegisterDecoderToolStripMenuItem"
        Me.RegisterDecoderToolStripMenuItem.Size = New System.Drawing.Size(219, 26)
        Me.RegisterDecoderToolStripMenuItem.Text = "Decode Registers"
        '
        'Inspector
        '
        Me.Inspector.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogsToolStripMenuItem, Me.ToolStripMenuItem3})
        Me.Inspector.Name = "Inspector"
        Me.Inspector.Size = New System.Drawing.Size(71, 25)
        Me.Inspector.Text = "&Inspect"
        '
        'LogsToolStripMenuItem
        '
        Me.LogsToolStripMenuItem.Name = "LogsToolStripMenuItem"
        Me.LogsToolStripMenuItem.Size = New System.Drawing.Size(113, 26)
        Me.LogsToolStripMenuItem.Text = "Logs"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(110, 6)
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizeToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(59, 25)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'CustomizeToolStripMenuItem
        '
        Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
        Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.CustomizeToolStripMenuItem.Text = "&Customize"
        '
        'Settings
        '
        Me.Settings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolBarToolStripMenuItem, Me.StatusBarToolStripMenuItem, Me.SToolStripMenuItem2, Me.OptionsToolStripMenuItem})
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(80, 25)
        Me.Settings.Text = "&Window"
        '
        'ToolBarToolStripMenuItem
        '
        Me.ToolBarToolStripMenuItem.Checked = True
        Me.ToolBarToolStripMenuItem.CheckOnClick = True
        Me.ToolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolBarToolStripMenuItem.Name = "ToolBarToolStripMenuItem"
        Me.ToolBarToolStripMenuItem.Size = New System.Drawing.Size(161, 26)
        Me.ToolBarToolStripMenuItem.Text = "&Toolbar"
        '
        'StatusBarToolStripMenuItem
        '
        Me.StatusBarToolStripMenuItem.Checked = True
        Me.StatusBarToolStripMenuItem.CheckOnClick = True
        Me.StatusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        Me.StatusBarToolStripMenuItem.Size = New System.Drawing.Size(161, 26)
        Me.StatusBarToolStripMenuItem.Text = "&Status Bar"
        '
        'SToolStripMenuItem2
        '
        Me.SToolStripMenuItem2.Name = "SToolStripMenuItem2"
        Me.SToolStripMenuItem2.Size = New System.Drawing.Size(158, 6)
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(161, 26)
        Me.OptionsToolStripMenuItem.Text = "P&references"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 25)
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.toolStripSeparator5, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(54, 25)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(139, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'MenuStrip
        '
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.TestToolStripMenuItem, Me.EngineData, Me.Inspector, Me.tbEcuProfile, Me.ToolsToolStripMenuItem, Me.Settings, Me.ToolStripMenuItem1, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1094, 29)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Scantech.Consult.OBD1.Nissan.My.Resources.Resources.nissanlogo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1094, 504)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MinimumSize = New System.Drawing.Size(700, 500)
        Me.Name = "frmMain"
        Me.Text = "ScanTech Consult for Nissan"
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
    Friend WithEvents tmrTimeout As System.Windows.Forms.Timer
    Friend WithEvents StatusTimout As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConnectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisconnectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConductStationaryTestsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DiagnosticFaultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlertMonitoringSystemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConductRoadTestsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpeedTrialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoadDynoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EngineData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbEcuProfile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CreateECUProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Inspector As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Settings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents LogsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BasicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridStyleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GaugesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GraphingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdvancedToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MonitorManagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdvancedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterTest As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConductECUTestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterDecoderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
