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
        Me.statusRx = New System.Windows.Forms.ToolStripStatusLabel
        Me.tsFrameTrack = New System.Windows.Forms.ToolStripStatusLabel
        Me.tsProgress = New System.Windows.Forms.ToolStripProgressBar
        Me.tsStatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.tsStatus2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.tsStatus3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.tsStatus4 = New System.Windows.Forms.ToolStripStatusLabel
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.tmrPortStatus = New System.Windows.Forms.Timer(Me.components)
        Me.tbConnect = New System.Windows.Forms.ToolStripButton
        Me.tsComPort = New System.Windows.Forms.ToolStripComboBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tbDisconnect = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.tsRecord = New System.Windows.Forms.ToolStripButton
        Me.tsPause = New System.Windows.Forms.ToolStripButton
        Me.tsStop = New System.Windows.Forms.ToolStripButton
        Me.tsFastBackward = New System.Windows.Forms.ToolStripButton
        Me.tsPlay = New System.Windows.Forms.ToolStripButton
        Me.tsFastForward = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.tsOpen = New System.Windows.Forms.ToolStripButton
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
        Me.GridStyleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GaugesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GraphingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
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
        Me.tmrLogStatus = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLogImage = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRateSample = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.TrackBar1 = New System.Windows.Forms.TrackBar
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.StatusStrip.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusPort, Me.statusRx, Me.tsFrameTrack, Me.tsProgress, Me.tsStatus, Me.tsStatus2, Me.tsStatus3, Me.tsStatus4})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 478)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1094, 26)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'statusPort
        '
        Me.statusPort.Image = Global.Scantech.Nissan.My.Resources.Resources.LedBlack
        Me.statusPort.Name = "statusPort"
        Me.statusPort.Size = New System.Drawing.Size(62, 21)
        Me.statusPort.Text = "COM"
        Me.statusPort.ToolTipText = "COM PORT STATUS"
        '
        'statusRx
        '
        Me.statusRx.Image = Global.Scantech.Nissan.My.Resources.Resources.LedBlack
        Me.statusRx.Name = "statusRx"
        Me.statusRx.Size = New System.Drawing.Size(43, 21)
        Me.statusRx.Text = "Rx"
        Me.statusRx.ToolTipText = "IN BUFFER STATUS"
        '
        'tsFrameTrack
        '
        Me.tsFrameTrack.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.tsFrameTrack.Name = "tsFrameTrack"
        Me.tsFrameTrack.Size = New System.Drawing.Size(4, 21)
        '
        'tsProgress
        '
        Me.tsProgress.Maximum = 32
        Me.tsProgress.Name = "tsProgress"
        Me.tsProgress.Size = New System.Drawing.Size(100, 22)
        Me.tsProgress.Visible = False
        '
        'tsStatus
        '
        Me.tsStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.tsStatus.Name = "tsStatus"
        Me.tsStatus.Size = New System.Drawing.Size(4, 21)
        '
        'tsStatus2
        '
        Me.tsStatus2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.tsStatus2.Name = "tsStatus2"
        Me.tsStatus2.Size = New System.Drawing.Size(4, 21)
        '
        'tsStatus3
        '
        Me.tsStatus3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.tsStatus3.Name = "tsStatus3"
        Me.tsStatus3.Size = New System.Drawing.Size(4, 21)
        '
        'tsStatus4
        '
        Me.tsStatus4.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.tsStatus4.Name = "tsStatus4"
        Me.tsStatus4.Size = New System.Drawing.Size(4, 21)
        '
        'tmrPortStatus
        '
        Me.tmrPortStatus.Enabled = True
        Me.tmrPortStatus.Interval = 50
        '
        'tbConnect
        '
        Me.tbConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbConnect.Image = Global.Scantech.Nissan.My.Resources.Resources.ConnectIcon
        Me.tbConnect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbConnect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbConnect.Name = "tbConnect"
        Me.tbConnect.Size = New System.Drawing.Size(36, 36)
        Me.tbConnect.ToolTipText = "CONNECT TO NISSAN CONSULT"
        '
        'tsComPort
        '
        Me.tsComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tsComPort.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsComPort.Name = "tsComPort"
        Me.tsComPort.Size = New System.Drawing.Size(121, 39)
        Me.tsComPort.ToolTipText = "SERIAL COM PORT"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbConnect, Me.tbDisconnect, Me.ToolStripSeparator9, Me.tsComPort, Me.ToolStripSeparator6, Me.tsRecord, Me.tsPause, Me.tsStop, Me.tsFastBackward, Me.tsPlay, Me.tsFastForward, Me.ToolStripSeparator7, Me.tsOpen, Me.ToolStripSeparator8})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 29)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1094, 39)
        Me.ToolStrip1.TabIndex = 19
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tbDisconnect
        '
        Me.tbDisconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbDisconnect.Enabled = False
        Me.tbDisconnect.Image = Global.Scantech.Nissan.My.Resources.Resources.DisconnectIcon
        Me.tbDisconnect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbDisconnect.Name = "tbDisconnect"
        Me.tbDisconnect.Size = New System.Drawing.Size(36, 36)
        Me.tbDisconnect.ToolTipText = "DISCONNECT"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 39)
        '
        'tsRecord
        '
        Me.tsRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsRecord.Enabled = False
        Me.tsRecord.Image = Global.Scantech.Nissan.My.Resources.Resources.RecordNormal
        Me.tsRecord.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsRecord.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsRecord.Name = "tsRecord"
        Me.tsRecord.Size = New System.Drawing.Size(36, 36)
        Me.tsRecord.ToolTipText = "RECORD"
        '
        'tsPause
        '
        Me.tsPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsPause.Enabled = False
        Me.tsPause.Image = CType(resources.GetObject("tsPause.Image"), System.Drawing.Image)
        Me.tsPause.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsPause.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsPause.Name = "tsPause"
        Me.tsPause.Size = New System.Drawing.Size(36, 36)
        Me.tsPause.ToolTipText = "PAUSE"
        '
        'tsStop
        '
        Me.tsStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsStop.Enabled = False
        Me.tsStop.Image = Global.Scantech.Nissan.My.Resources.Resources.StopNormalBlue
        Me.tsStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsStop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsStop.Name = "tsStop"
        Me.tsStop.Size = New System.Drawing.Size(36, 36)
        Me.tsStop.ToolTipText = "STOP"
        '
        'tsFastBackward
        '
        Me.tsFastBackward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsFastBackward.Enabled = False
        Me.tsFastBackward.Image = Global.Scantech.Nissan.My.Resources.Resources.StepBackwardNormalBlue
        Me.tsFastBackward.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsFastBackward.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsFastBackward.Name = "tsFastBackward"
        Me.tsFastBackward.Size = New System.Drawing.Size(36, 36)
        Me.tsFastBackward.ToolTipText = "FAST BACKWARD"
        '
        'tsPlay
        '
        Me.tsPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsPlay.Enabled = False
        Me.tsPlay.Image = Global.Scantech.Nissan.My.Resources.Resources.PlayNormal
        Me.tsPlay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsPlay.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsPlay.Name = "tsPlay"
        Me.tsPlay.Size = New System.Drawing.Size(36, 36)
        Me.tsPlay.ToolTipText = "PLAY"
        '
        'tsFastForward
        '
        Me.tsFastForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsFastForward.Enabled = False
        Me.tsFastForward.Image = CType(resources.GetObject("tsFastForward.Image"), System.Drawing.Image)
        Me.tsFastForward.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsFastForward.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsFastForward.Name = "tsFastForward"
        Me.tsFastForward.Size = New System.Drawing.Size(36, 36)
        Me.tsFastForward.ToolTipText = "FAST FORWARD"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 39)
        '
        'tsOpen
        '
        Me.tsOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsOpen.Enabled = False
        Me.tsOpen.Image = Global.Scantech.Nissan.My.Resources.Resources.EjectNormal
        Me.tsOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsOpen.Name = "tsOpen"
        Me.tsOpen.Size = New System.Drawing.Size(36, 36)
        Me.tsOpen.ToolTipText = "OPEN LOG FILE"
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
        Me.ConnectToolStripMenuItem.Image = Global.Scantech.Nissan.My.Resources.Resources.ConnectIcon
        Me.ConnectToolStripMenuItem.Name = "ConnectToolStripMenuItem"
        Me.ConnectToolStripMenuItem.Size = New System.Drawing.Size(172, 26)
        Me.ConnectToolStripMenuItem.Text = "&Connect"
        '
        'DisconnectToolStripMenuItem
        '
        Me.DisconnectToolStripMenuItem.Enabled = False
        Me.DisconnectToolStripMenuItem.Image = Global.Scantech.Nissan.My.Resources.Resources.DisconnectIcon
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
        Me.DiagnosticFaultsToolStripMenuItem.Enabled = False
        Me.DiagnosticFaultsToolStripMenuItem.Name = "DiagnosticFaultsToolStripMenuItem"
        Me.DiagnosticFaultsToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.DiagnosticFaultsToolStripMenuItem.Text = "ECU Self Diagnostic"
        '
        'AlertMonitoringSystemToolStripMenuItem
        '
        Me.AlertMonitoringSystemToolStripMenuItem.Enabled = False
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
        Me.SpeedTrialToolStripMenuItem.Enabled = False
        Me.SpeedTrialToolStripMenuItem.Name = "SpeedTrialToolStripMenuItem"
        Me.SpeedTrialToolStripMenuItem.Size = New System.Drawing.Size(157, 26)
        Me.SpeedTrialToolStripMenuItem.Text = "Speed Trial"
        '
        'RoadDynoToolStripMenuItem
        '
        Me.RoadDynoToolStripMenuItem.Enabled = False
        Me.RoadDynoToolStripMenuItem.Name = "RoadDynoToolStripMenuItem"
        Me.RoadDynoToolStripMenuItem.Size = New System.Drawing.Size(157, 26)
        Me.RoadDynoToolStripMenuItem.Text = "Road Dyno"
        '
        'EngineData
        '
        Me.EngineData.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GridStyleToolStripMenuItem, Me.GaugesToolStripMenuItem, Me.GraphingToolStripMenuItem, Me.ToolStripMenuItem4, Me.MonitorManagerToolStripMenuItem})
        Me.EngineData.Name = "EngineData"
        Me.EngineData.Size = New System.Drawing.Size(78, 25)
        Me.EngineData.Text = "&Monitor"
        '
        'GridStyleToolStripMenuItem
        '
        Me.GridStyleToolStripMenuItem.Enabled = False
        Me.GridStyleToolStripMenuItem.Name = "GridStyleToolStripMenuItem"
        Me.GridStyleToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.GridStyleToolStripMenuItem.Text = "Grid"
        '
        'GaugesToolStripMenuItem
        '
        Me.GaugesToolStripMenuItem.Enabled = False
        Me.GaugesToolStripMenuItem.Name = "GaugesToolStripMenuItem"
        Me.GaugesToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.GaugesToolStripMenuItem.Text = "Gauges"
        '
        'GraphingToolStripMenuItem
        '
        Me.GraphingToolStripMenuItem.Enabled = False
        Me.GraphingToolStripMenuItem.Name = "GraphingToolStripMenuItem"
        Me.GraphingToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.GraphingToolStripMenuItem.Text = "Graph"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(199, 6)
        '
        'MonitorManagerToolStripMenuItem
        '
        Me.MonitorManagerToolStripMenuItem.Enabled = False
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
        Me.RegisterTest.Size = New System.Drawing.Size(200, 26)
        Me.RegisterTest.Text = "Detect Registers"
        '
        'ConductECUTestToolStripMenuItem
        '
        Me.ConductECUTestToolStripMenuItem.Name = "ConductECUTestToolStripMenuItem"
        Me.ConductECUTestToolStripMenuItem.Size = New System.Drawing.Size(200, 26)
        Me.ConductECUTestToolStripMenuItem.Text = "Detect ECU"
        '
        'RegisterDecoderToolStripMenuItem
        '
        Me.RegisterDecoderToolStripMenuItem.Name = "RegisterDecoderToolStripMenuItem"
        Me.RegisterDecoderToolStripMenuItem.Size = New System.Drawing.Size(200, 26)
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
        'tmrLogStatus
        '
        Me.tmrLogStatus.Enabled = True
        '
        'tmrLogImage
        '
        Me.tmrLogImage.Enabled = True
        Me.tmrLogImage.Interval = 500
        '
        'tmrRateSample
        '
        Me.tmrRateSample.Enabled = True
        Me.tmrRateSample.Interval = 1000
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TrackBar1
        '
        Me.TrackBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBar1.AutoSize = False
        Me.TrackBar1.Location = New System.Drawing.Point(0, 71)
        Me.TrackBar1.Maximum = 0
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(1094, 23)
        Me.TrackBar1.TabIndex = 21
        Me.TrackBar1.TabStop = False
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TrackBar1.Visible = False
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 39)
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Scantech.Nissan.My.Resources.Resources.nissanlogo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1094, 504)
        Me.Controls.Add(Me.TrackBar1)
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
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents tsProgress As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents tmrPortStatus As System.Windows.Forms.Timer
    Friend WithEvents statusPort As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tbConnect As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsComPort As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tmrTimeout As System.Windows.Forms.Timer
    Friend WithEvents statusRx As System.Windows.Forms.ToolStripStatusLabel
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
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MonitorManagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdvancedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterTest As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConductECUTestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterDecoderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridStyleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GaugesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GraphingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsPause As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsPlay As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsFastBackward As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsRecord As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsFastForward As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsStop As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbDisconnect As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tmrLogStatus As System.Windows.Forms.Timer
    Friend WithEvents tsStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tmrLogImage As System.Windows.Forms.Timer
    Friend WithEvents tsStatus2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsStatus3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tmrRateSample As System.Windows.Forms.Timer
    Friend WithEvents tsFrameTrack As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents tsOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tsStatus4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator

End Class
