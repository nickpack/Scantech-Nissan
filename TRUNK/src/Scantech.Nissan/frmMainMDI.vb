Imports System.Windows.Forms
'CLEAN CLEAN

Public Class frmMain
    Dim ForwardSpeed As Integer = 320
    Dim BackwardSpeed As Integer = 320

    Dim PlaySpeed As Integer
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

        'ENABLE/DISABLE LOG INSPECTOR
        ENABLE_STATE_FOR_INSPECTOR(0, 0, 0, 0, 0, 0, 1)
    End Sub
    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip1.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub tsConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbConnect.Click, ConnectToolStripMenuItem.Click
        LOG_BUTTONS_STATUS = ""
        frmConnect.MdiParent = Me : frmConnect.Show()
    End Sub

    Private Sub tsComPort_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsComPort.Validated
        My.Settings.PreferredPort = tsComPort.Text
    End Sub

    Private Sub tmrPortStatus_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPortStatus.Tick
        'PORT OPEN STATUS
        If Me.SerialPort1.IsOpen = True Then
            statusPort.Image = My.Resources.LedGreen
        Else
            statusPort.Image = My.Resources.LedBlack
        End If

        'INBUFFER BYTES STATUS
        If Me.SerialPort1.IsOpen = True Then
            If Me.SerialPort1.BytesToRead > 0 Then
                statusRx.Image = My.Resources.LedGreen
            Else
                statusRx.Image = My.Resources.LedBlack
            End If
        End If
    End Sub
    Private Sub frmMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Refresh()
    End Sub
    Private Sub CreateECUProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateECUProfileToolStripMenuItem.Click
        frmECUProfile.Show()
    End Sub
    Private Sub tmrTimeout_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTimeout.Tick
        tmrTimeout.Enabled = False
    End Sub
    Private Sub Exit_Application(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        Application.Exit()
    End Sub
    Public Sub MonitorManagerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonitorManagerToolStripMenuItem.Click
        frmRegSelection.MdiParent = Me : frmRegSelection.Show()
    End Sub
    Private Sub GridStyleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridStyleToolStripMenuItem.Click
        'GRID STYLE
        USER_FORM_SELECT = 1

        If LOG_BUTTONS_STATUS = "" Then                                             'REAL CONSULT PORT FUNCTION (BYPASS LOGGING)
            RESET_GRID_STYLE_FOR_SENSORS() : RESET_GRID_STYLE_FOR_OUTPUT() : RESET_GRID_STYLE_FOR_ACTIVE()
            REQUEST_C1_SENSOR_DATA()
            Me.SerialPort1.Write(SEND_30_BYTE, 0, 1) : System.Threading.Thread.Sleep(INTERBYTE_DELAY) : frmMain.SerialPort1.DiscardInBuffer()
        ElseIf LOG_BUTTONS_STATUS = "Open" Then                                     'LOG FUNCTION
            RESET_GRID_STYLE_FOR_SENSORS() : RESET_GRID_STYLE_FOR_OUTPUT()
            LOG_REQUEST_C1_SENSOR_DATA()
        End If

        CLOSE_C1_FORMS()
    End Sub
    Private Sub RegisterTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterTest.Click
        frmScannerRegister.MdiParent = Me : frmScannerRegister.Show()
    End Sub
    Private Sub RegisterDecoderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterDecoderToolStripMenuItem.Click
        frmRegisterDecoder.MdiParent = Me : frmRegisterDecoder.Show()
    End Sub
    Private Sub ConductECUTestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConductECUTestToolStripMenuItem.Click
        frmScannerECU.MdiParent = Me : frmScannerECU.Show()
    End Sub
    Private Sub DiagnosticFaultsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiagnosticFaultsToolStripMenuItem.Click
        frmC1Faults.MdiParent = Me : frmC1Faults.Show()
    End Sub

    Private Sub tbComPort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsComPort.Click

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub tbDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbDisconnect.Click
        'MAKE SURE QUERY IS STOPPED BEFORE EXITING
        If LOOP_IN_PROGRESS = True Then USER_REQUEST_STOP = True
        Me.Tag = "Disconnect"
        CLOSE_C1_FORMS()
    End Sub

    Private Sub DisconnectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisconnectToolStripMenuItem.Click
        tbDisconnect_Click(1, e)
    End Sub

    Private Sub tsRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsRecord.Click
        ENABLE_STATE_FOR_INSPECTOR(2, 1, 0, 1, 0, 0, 0)

        Select Case LOG_BUTTONS_STATUS
            Case "Record"                                                                       'RECORDING IS RUNNING EXIT SUB
                Exit Sub
            Case "Pause"                                                                        'UNPAUSE AND CONTINUE RECORDING
                LOG_BUTTONS_STATUS = "Record"
                Exit Sub
            Case "Stop"                                                                         'ASK TO SAVE EXISTING UNTITLED LOG
                LOG_SAVE_FILE()
                LOG_BUTTONS_STATUS = ""                                                         'RESET
            Case Else                                                                           'FIRST TIME RUN: SET STATUS AS RECORD AND SET LOG BUTTONS ENABLE STATES ACCORDINGLY
                LOG_BUTTONS_STATUS = "Record"
                LOG_CREATE_FILE()                                                               'CREATE LOG FILE FOR INITIAL RECORD
                LOG_CREATE_SELECTED_REGISTERS_FILE(1)                                           'GET SELECTED REGISTER NAMES AND STORE IN FILE STARTING AT RECORD 1
        End Select

    End Sub

    Private Sub tsPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsPause.Click
        LOG_BUTTONS_STATUS = "Pause" : ENABLE_STATE_FOR_INSPECTOR(2, 1, 2, 2, 0, 0, 0)
    End Sub

    Private Sub tsStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsStop.Click
        LOG_BUTTONS_STATUS = "Stop" : ENABLE_STATE_FOR_INSPECTOR(2, 0, 2, 0, 0, 0, 0)
    End Sub

    Private Sub tsFastBackward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsFastBackward.Click
        LOG_BUTTONS_STATUS = "FastBackward" : ENABLE_STATE_FOR_INSPECTOR(0, 1, 1, 1, 1, 1, 0)

        If BackwardSpeed = 5 Then
            BackwardSpeed = 0
            PlaySpeed = 0
            Me.tsStatus3.Text = "Max Speed"
            Exit Sub
        End If

        If BackwardSpeed = 0 Then BackwardSpeed = 640
        BackwardSpeed = BackwardSpeed / 2
        PlaySpeed = BackwardSpeed
        Me.tsStatus3.Text = 320 / PlaySpeed & "x"
    End Sub

    Private Sub tsPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsPlay.Click
        If LOG_BUTTONS_STATUS = "Play" Then Exit Sub

        LOG_BUTTONS_STATUS = "Play"
        ENABLE_STATE_FOR_MENUS(0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0)
        ENABLE_STATE_FOR_INSPECTOR(0, 1, 1, 1, 1, 1, 0)
        PlaySpeed = 320 : ForwardSpeed = 320 : BackwardSpeed = 320 : Me.tsStatus3.Text = "1x"
    End Sub
    Private Sub LOG_REQUEST_C1_SENSOR_DATA()
        ENABLE_STATE_FOR_MENUS(0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0)

        'FLAG DO LOOP EVENT IN PROGRESS AND RESET USER_REQUEST_STOP
        LOOP_IN_PROGRESS = True : USER_REQUEST_STOP = False

        Do Until USER_REQUEST_STOP = True
            'PLAY SPEED ADJUSTED BY FORWARD OR BACKWARD BUTTON
            System.Threading.Thread.Sleep(PlaySpeed)
            System.Windows.Forms.Application.DoEvents()

            'DO THIS ONLY IF PLAYING
            If LOG_BUTTONS_STATUS = "Play" Or LOG_BUTTONS_STATUS = "FastForward" Or LOG_BUTTONS_STATUS = "FastBackward" Then
                FileGetObject(1, DATA_FILTERED_RECEIVED, RECORD_NUMBER * 100)                   'GET DATAFRAME FROM RECORD
                tsStatus2.Text = RECORD_NUMBER - 3000 & " of " & TOTAL_RECORD_FRAME             'STATUS CURRENT FRAME

                'GO FORWARD ON PLAYBACK
                If LOG_BUTTONS_STATUS = "FastForward" Or LOG_BUTTONS_STATUS = "Play" Then RECORD_NUMBER = RECORD_NUMBER + 1

                'GO BACKWARD ON PLAYBACK
                If LOG_BUTTONS_STATUS = "FastBackward" Then RECORD_NUMBER = RECORD_NUMBER - 1

                Select Case USER_FORM_SELECT                                                    'WHAT FORM SELECTED
                    Case 1 : RESULT_GRID_STYLE(DATA_FILTERED_RECEIVED)                          'SHOW DECODED DATA 
                End Select

                'STOP LOG PLAYING IF BEGINNING/END OF RECORD
                If RECORD_NUMBER - 3000 = TOTAL_RECORD_FRAME Or RECORD_NUMBER = 3000 Then
                    LOG_BUTTONS_STATUS = "Stop"
                    ENABLE_STATE_FOR_INSPECTOR(0, 0, 1, 0, 0, 0, 0)
                    RECORD_NUMBER = 3001
                End If
            End If

        Loop

        'RESET
        LOG_BUTTONS_STATUS = "" : Me.Tag = "Disconnect"
    End Sub
    Private Sub tsFastForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsFastForward.Click
        LOG_BUTTONS_STATUS = "FastForward" : ENABLE_STATE_FOR_INSPECTOR(0, 1, 1, 1, 1, 1, 0)

        If ForwardSpeed = 5 Then
            ForwardSpeed = 0
            PlaySpeed = 0
            Me.tsStatus3.Text = "Max Speed"
            Exit Sub
        End If

        If ForwardSpeed = 0 Then ForwardSpeed = 640
        ForwardSpeed = ForwardSpeed / 2
        PlaySpeed = ForwardSpeed
        Me.tsStatus3.Text = 320 / PlaySpeed & "x"
    End Sub

    Private Sub tmrLogStatus_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLogStatus.Tick
        'LOG STATUS AND SET TIMER INTERVALS FOR ANIMATED IMAGE
        Select Case LOG_BUTTONS_STATUS
            Case "Record" : tsStatus.Text = "Recording" : tmrLogImage.Interval = 500
            Case "Pause" : tsStatus.Text = "Paused" : tmrLogImage.Interval = 250
            Case "Stop" : tsStatus.Text = "Stop"
            Case "FastBackward" : tsStatus.Text = "Fast Backward" : tmrLogImage.Interval = 200
            Case "Play" : tsStatus.Text = "Playing"
            Case "FastForward" : tsStatus.Text = "Fast Forward" : tmrLogImage.Interval = 200
            Case Else : tsStatus.Text = ""
        End Select
    End Sub

    Private Sub tmrLogImage_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLogImage.Tick
        Static X As Boolean
        Static PrevStatus As String

        'SET ALL BUTTONS TO NORMAL IMAGE IF SELECTION HAS BEEN CHANGED
        If PrevStatus <> LOG_BUTTONS_STATUS Then
            tsRecord.Image = My.Resources.RecordNormal
            tsPause.Image = My.Resources.PauseNormal
            tsPlay.Image = My.Resources.PlayNormal
            tsFastBackward.Image = My.Resources.StepBackwardNormalBlue
            tsFastForward.Image = My.Resources.StepForwardNormalBlue
        End If

        'PREVIOUS BUTTON SELECTED
        PrevStatus = LOG_BUTTONS_STATUS

        'FLASH BUTTON IMAGE AT AN INTERVAL IF SELECTED
        Select Case LOG_BUTTONS_STATUS
            Case "Record"
                If X = True Then
                    tsRecord.Image = My.Resources.RecordHot
                Else
                    tsRecord.Image = My.Resources.RecordNormal
                End If
            Case "Pause"
                If X = True Then
                    tsPause.Image = My.Resources.PauseHot
                Else
                    tsPause.Image = My.Resources.PauseNormal
                End If
            Case "Stop"

            Case "Play" : tsPlay.Image = My.Resources.PlayHot
            Case "FastForward"
                If X = True Then
                    tsFastForward.Image = My.Resources.StepForwardHotBlue
                Else
                    tsFastForward.Image = My.Resources.StepForwardNormalBlue
                End If
            Case "FastBackward"
                If X = True Then
                    tsFastBackward.Image = My.Resources.StepBackwardHotBlue
                Else
                    tsFastBackward.Image = My.Resources.StepBackwardNormalBlue
                End If
        End Select

        X = Not X
    End Sub

    Private Sub tmrRateSample_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRateSample.Tick
        tsFrameTrack.Text = X_RATE_SAMPLE & " /Sec" : X_RATE_SAMPLE = 0
    End Sub

    Private Sub tsOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsOpen.Click
        LOG_BUTTONS_STATUS = "Open"
        LOG_OPEN_FILE()
    End Sub

End Class
