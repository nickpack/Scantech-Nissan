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
        SEARCH_SERIAL_PORTS()
        DISABLE_MENUS()

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
    Private Sub tbConnect_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbConnect.Click
        frmConnect.MdiParent = Me : frmConnect.Show()
    End Sub
    Private Sub tbComPort_Validated1(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbComPort.Validated
        SaveSetting("Consult1", "Settings", "Port", tbComPort.Text)
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
    Private Sub GridStyleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If LOOP_IN_PROGRESS = True Then Exit Sub
        DISABLE_MENUS()
        USER_FORM_SELECT = 1 'GRID STYLE
        frmRegSelection.MdiParent = Me : frmRegSelection.Show()
    End Sub

    Private Sub frmMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Refresh()
    End Sub

    Private Sub DiagnosticFaultsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DISABLE_MENUS()
        frmC1Faults.MdiParent = Me : frmC1Faults.Show()
    End Sub

    Private Sub CreateECUProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateECUProfileToolStripMenuItem.Click
        frmECUProfile.Show()
    End Sub
    Private Sub RegisterTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmScannerRegister.MdiParent = Me : frmScannerRegister.Show()
    End Sub

    Private Sub ConductECUTestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmScannerECU.MdiParent = Me : frmScannerECU.Show()
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

    Private Sub RegisterDecoderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmRegisterDecoder.MdiParent = Me : frmRegisterDecoder.Show()
    End Sub

    Private Sub tmrTimeout_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTimeout.Tick
        tmrTimeout.Enabled = False
    End Sub
End Class
