Public Class frmRegisterDecoder
    Private Sub cmdScanEcu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdScanEcu.Click
        If cmdScanEcu.Text = "Scan Registers" Then
            LOOP_IN_PROGRESS = True : cmdGo.Enabled = False : cmdStop.Enabled = False : USER_REQUEST_STOP = False

            'SET BUTTON FOR CANCEL
            cmdScanEcu.Text = "Cancel"

            'CLEAR COMBOBOX
            ComboBox1.Items.Clear()
            ComboBox4.Items.Clear()
            ComboBox1.Items.Add("N/A")
            ComboBox4.Items.Add("N/A")

            'CONFIGURE PROGRESS BAR
            frmMain.tsProgress.Visible = True : frmMain.tsProgress.Minimum = 0
            frmMain.tsProgress.Maximum = 255 : frmMain.tsProgress.Value = 0

            'USE AT LEAST 25 MILLISECOND INTERBYTE DELAY
            INTERBYTE_DELAY = 25

            'IF SUCCESS THEN CONTINUE TO SCANREGISTERS
            If INITIALIZE_ECU(CByte("&H" & ComboBox5.Text), True) = True Then

            Else
                GoTo reset
            End If

            'WHICH TYPE REGISTER TO SCAN
            If ScanRegisters(90) = True Then
                cmdGo.Enabled = True
                ComboBox1.SelectedItem = ComboBox1.Items(0)
                ComboBox4.SelectedItem = ComboBox4.Items(0)
            End If
        Else
            'USER CLICKED CANCEL
            USER_REQUEST_STOP = True
            Exit Sub
        End If
Reset:

        'RESET
        cmdScanEcu.Text = "Scan Registers" : LOOP_IN_PROGRESS = False : frmMain.tsProgress.Visible = False : USER_REQUEST_STOP = False
    End Sub
    Function ScanRegisters(ByVal CmdByte As Byte) As Boolean
        ScanRegisters = False
        For xCounter = 0 To 255
            'SKIP THIS.  0xFE = INVALID COMMAND RESPONSE
            If xCounter = 254 Then xCounter = 255

            Dim Buffer As Byte() = {CmdByte, xCounter}
            Dim InData As Byte
            Dim cvtData As String

            If USER_REQUEST_STOP = True Then Exit Function

            'SET PROGRESS BAR INITIAL VALUE
            frmMain.tsProgress.Value = xCounter
            System.Windows.Forms.Application.DoEvents()

            'STOP COMMAND
            frmMain.SerialPort1.Write(SEND_30_BYTE, 0, 1) : Wait(25)

            'SENSOR REQUEST COMMAND
            frmMain.SerialPort1.Write(Buffer, 0, 1) : Wait(25)

            'CLEAR BUFFER (DISREGARD THOSE BYTES)
            frmMain.SerialPort1.DiscardInBuffer()

            'REGISTER BYTE ADDRESS
            frmMain.SerialPort1.Write(Buffer, 1, 1) : Wait(25)
            InData = frmMain.SerialPort1.ReadByte

            'IF VALID THEN UPDATE TREEVIEW
            If InData = xCounter Then
                cvtData = Hex(InData) : If Len(cvtData) = 1 Then cvtData = "0" & cvtData
                ComboBox1.Items.Add(cvtData) : ComboBox4.Items.Add(cvtData)
                ScanRegisters = True
            End If
        Next

        frmMain.tsProgress.Value = 0
    End Function
    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged

    End Sub

    Private Sub frmRegisterDecoder_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'MAKE SURE QUERY IS STOPPED BEFORE EXITING
        If LOOP_IN_PROGRESS = True Then
            USER_REQUEST_STOP = True
            e.Cancel = True
            Exit Sub
        End If

        'CLOSE PORT
        frmMain.SerialPort1.Close()

        'ENABLE/DISABLE FRMMAIN MENU STATE
        ENABLE_STATE_FOR_MENUS(1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frmRegisterDecoder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim X As Integer
        Dim D As String

        'ENABLE/DISABLE FRMMAIN MENU STATE
        ENABLE_STATE_FOR_MENUS(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)

        'FILL ECU ADDRESS 0X00-0XFF
        For X = 255 To 0 Step -1
            D = Hex(X) : If Len(D) = 1 Then D = "0" & D
            ComboBox5.Items.Add(D)
        Next

        'SCALE TYPE
        For X = 0 To 15
            ComboBox2.Items.Add(X)
        Next

        'UNIT TYPE
        For X = 0 To 6
            ComboBox3.Items.Add(X)
        Next

        'SET DEFAULT SELECTION
        ComboBox2.SelectedItem = ComboBox2.Items(0)
        ComboBox3.SelectedItem = ComboBox3.Items(0)
    End Sub

    Private Sub ComboBox5_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedValueChanged
        cmdScanEcu.Enabled = True
    End Sub

    Private Sub cmdGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGo.Click
        'BOTH N/A THEN ERROR
        If ComboBox1.Text = "N/A" And ComboBox4.Text = "N/A" Then
            MsgBox("Must Select Register", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End If

        'BOTH "" THEN ERROR
        If ComboBox1.Text = "" And ComboBox4.Text = "" Then
            MsgBox("Must Select Register", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End If

        'BOTH SAME THEN ERROR
        If ComboBox1.Text = ComboBox4.Text Then
            MsgBox("MSB and LSB cannot be same", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End If

        'RESET
        Dim X As Integer
        For X = 0 To 255
            SELECTED_REGISTERS(X) = False
        Next

        If ComboBox1.Text <> "N/A" And ComboBox4.Text = "N/A" Then
            TOTAL_SELECTED_REGISTERS = 1
            SELECTED_REGISTERS(CByte("&H" & ComboBox1.Text)) = True
        End If

        If ComboBox1.Text = "N/A" And ComboBox4.Text <> "N/A" Then
            TOTAL_SELECTED_REGISTERS = 1
            SELECTED_REGISTERS(CByte("&H" & ComboBox4.Text)) = True
        End If

        If ComboBox1.Text <> "N/A" And ComboBox4.Text <> "N/A" Then
            TOTAL_SELECTED_REGISTERS = 2
            SELECTED_REGISTERS(CByte("&H" & ComboBox1.Text)) = True
            SELECTED_REGISTERS(CByte("&H" & ComboBox4.Text)) = True
        End If

        START_BYTE_FOR_SENSOR = 0 : END_BYTE_FOR_SENSOR = 255 : USER_FORM_SELECT = 4

        'DISABLE
        ComboBox1.Enabled = False : ComboBox4.Enabled = False : ComboBox5.Enabled = False : cmdScanEcu.Enabled = False : cmdGo.Enabled = False : cmdStop.Enabled = True

        'MAKE SURE CONSULT 1 DATA QUERY IS STOPPED
        frmMain.SerialPort1.Write(SEND_30_BYTE, 0, 1) : Wait(INTERBYTE_DELAY)

        'CLEAR ANY BUFFER
        frmMain.SerialPort1.DiscardInBuffer()

        'SET TIMEOUT
        TIME_OUT = 5000

        'START COMMUNICATION WITH ECM AND REQUEST DATA AND PROCESS THEM
        REQUEST_C1_SENSOR_DATA()

        'RESET
        RESET_C1_FORMS()

        'ENABLE
        ComboBox1.Enabled = True : ComboBox4.Enabled = True : ComboBox5.Enabled = True : cmdGo.Enabled = True : cmdScanEcu.Enabled = True : cmdStop.Enabled = False
    End Sub

    Private Sub cmdStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStop.Click
        USER_REQUEST_STOP = True
    End Sub
End Class