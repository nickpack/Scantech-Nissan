Imports System.Windows.Forms

Public Class frmMain
    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'DOES NOT EXIT IF DATA IS QUERYING
        If LOOP_IN_PROGRESS = True Then
            USER_REQUEST_STOP = True
            e.Cancel = True
            Exit Sub
        End If

        'CLOSE SERIAL PORT IF OPEN
        If SerialPort1.IsOpen = True Then SerialPort1.Close()

        'SAVE FORM POSITION
        SAVE_WINDOW_FORM_STATE(Me)
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LOAD ALL AVAILABLE COM PORTS TO COMBOX
        SEARCH_SERIAL_PORTS()

        'LOAD FORM POSITION
        LOAD_WINDOW_FORM_STATE(Me, 10, 10, 700, 500)
    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs)

    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip1.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub tbConnect_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbConnect.Click, ConnectToolStripMenuItem.Click
        frmConnect.MdiParent = Me : frmConnect.Show()
    End Sub

    Private Sub tbComPort_Validated1(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbComPort.Validated
        My.Settings.PreferredPort = tbComPort.Text
    End Sub

    Private Sub tmrPortStatus_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPortStatus.Tick
        'PORT OPEN STATUS
        If Me.SerialPort1.IsOpen = True Then
            statusPort.Image = My.Resources.LedGreen
        Else
            statusPort.Image = My.Resources.LedBlack
        End If

        'BYTES STATUS
        If Me.SerialPort1.IsOpen = True Then
            If Me.SerialPort1.BytesToRead > 0 Then
                StatusTimout.Image = My.Resources.LedGreen
            Else
                StatusTimout.Image = My.Resources.LedBlack
            End If
        End If

        'TIMEOUT STATUS
        If Me.tmrTimeout.Enabled = False Then
            'StatusTimout.Image = My.Resources.CommentHS
        End If
    End Sub
    Private Sub frmMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Refresh()
    End Sub
    Private Sub DiagnosticFaultsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'DISABLE_MENUS()
        frmC1Faults.MdiParent = Me : frmC1Faults.Show()
    End Sub

    Private Sub CreateECUProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateECUProfileToolStripMenuItem.Click
        frmECUProfile.Show()
    End Sub
    Private Sub GaugesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Not Implemented at this time")
    End Sub

    Private Sub GraphingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Not Implemented at this time")
    End Sub

    Private Sub AlertMonitoringSystemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Not Implemented at this time")
    End Sub
    Private Sub tmrTimeout_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTimeout.Tick
        tmrTimeout.Enabled = False
    End Sub

    Private Sub Exit_Application(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        Application.Exit()
    End Sub
    Public Sub MonitorManagerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonitorManagerToolStripMenuItem.Click
        'DO NOT OPEN FORM IF LOOP IN PROGRESS
        If LOOP_IN_PROGRESS = True Then Exit Sub
        'DISABLE_MENUS()

        frmRegSelection.MdiParent = Me : frmRegSelection.Show()
    End Sub
    Private Sub GridStyleToolStripMenuItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridStyleToolStripMenuItem.Click
        'GRID STYLE
        USER_FORM_SELECT = 1
        'RESET GRIDS
        RESET_GRID_STYLE_FOR_SENSORS() : RESET_GRID_STYLE_FOR_OUTPUT() : RESET_GRID_STYLE_FOR_ACTIVE()
        'START COMMUNICATION WITH ECM AND REQUEST DATA AND PROCESS THEM
        REQUEST_C1_SENSOR_DATA()
        'CLOSE ALL FORM RELATED
        CLOSE_C1_FORMS()
    End Sub
    Private Sub RegisterTest_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterTest.Click
        frmScannerRegister.MdiParent = Me : frmScannerRegister.Show()
    End Sub
    Private Sub RegisterDecoderToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterDecoderToolStripMenuItem.Click
        frmRegisterDecoder.MdiParent = Me : frmRegisterDecoder.Show()
    End Sub
    Private Sub ConductECUTestToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConductECUTestToolStripMenuItem.Click
        frmScannerECU.MdiParent = Me : frmScannerECU.Show()
    End Sub
End Class
