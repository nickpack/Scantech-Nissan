Public Class frmScannerRegister

    Private Sub frmScannerRegister_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'MAKE SURE QUERY IS STOPPED BEFORE EXITING
        If LOOP_IN_PROGRESS = True Then
            USER_REQUEST_STOP = True
            e.Cancel = True
            Exit Sub
        End If

        'SAVE FORM POSITION
        SAVE_WINDOW_FORM_STATE(Me)

        'CLOSE PORT
        frmMain.SerialPort1.Close()

        'ENABLE/DISABLE FRMMAIN MENU STATE
        MENUENABLESTATE(True, False, False, False, False, False, False, True, True, True, True, False, False, False, False)
    End Sub

    Private Sub frmScannerRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LOAD FORM POSITION
        LOAD_WINDOW_FORM_STATE(Me, 10, 10, 250, 375)

        'ENABLE/DISABLE FRMMAIN MENU STATE
        MENUENABLESTATE(False, False, False, False, False, False, False, False, False, False, False, False, False, False, False)

        Dim X As Integer
        Dim D As String

        'FILL ECU ADDRESS 0X00-0XFF
        For X = 255 To 0 Step -1
            D = Hex(X) : If Len(D) = 1 Then D = "0" & D
            ComboBox1.Items.Add(D)
        Next

        'TYPE OF SCAN
        ComboBox2.Items.Add("Sensors")
        ComboBox2.Items.Add("Active Test")
        ComboBox2.Items.Add("Complete")
        ComboBox2.SelectedItem = ComboBox2.Items(2)
    End Sub

    Private Sub cmdScanEcu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdScanEcu.Click
        If cmdScanEcu.Text = "Scan Registers" Then
            LOOP_IN_PROGRESS = True
            USER_REQUEST_STOP = False

            'SET BUTTON FOR CANCEL
            cmdScanEcu.Text = "Cancel"

            'CONFIGURE TREEVIEW
            TreeView1.Nodes.Clear()
            TreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

            'CONFIGURE PROGRESS BAR
            frmMain.tsProgress.Visible = True : frmMain.tsProgress.Minimum = 0
            frmMain.tsProgress.Maximum = 255 : frmMain.tsProgress.Value = 0

            'USE AT LEAST 25 MILLISECOND INTERBYTE DELAY
            INTERBYTE_DELAY = 25


            'UPDATE TREEVIEW IF ADDRESS FOUND
            If INITIALIZE_ECU(CByte("&H" & ComboBox1.Text), True) = True Then
                TreeView1.Nodes.Add("ECU Address - " & ComboBox1.Text) : TreeView1.ExpandAll()
            Else
                GoTo reset
            End If

            'WHICH TYPE REGISTER TO SCAN
            Select Case ComboBox2.Text
                Case "Complete" : TreeView1.Nodes(0).Nodes.Add("Sensor Address Supported") : ScanRegisters(90, 0) : TreeView1.Nodes(0).Nodes.Add("Active Test Address Supported") : ScanRegisters(10, 1)
                Case "Sensors" : TreeView1.Nodes(0).Nodes.Add("Sensor Address Supported") : ScanRegisters(90, 0)
                Case "Active Test" : TreeView1.Nodes(0).Nodes.Add("Active Test Address Supported") : ScanRegisters(10, 0)
            End Select
        Else
            'USER CLICKED CANCEL
            USER_REQUEST_STOP = True : Exit Sub
        End If
Reset:

        'RESET
        cmdScanEcu.Text = "Scan Registers" : LOOP_IN_PROGRESS = False : frmMain.tsProgress.Visible = False : USER_REQUEST_STOP = False
    End Sub
    Private Sub ScanRegisters(ByVal CmdByte As Byte, ByVal NodeValue As Integer)
        For xCounter = 0 To 255
            'SKIP THIS.  0xFE = INVALID COMMAND RESPONSE
            If xCounter = 254 Then xCounter = 255
            Dim Buffer As Byte() = {CmdByte, xCounter}
            Dim InData As Byte
            Dim cvtData As String

            If USER_REQUEST_STOP = True Then Exit Sub

            'SET PROGRESS BAR INITIAL VALUE
            frmMain.tsProgress.Value = xCounter
            System.Windows.Forms.Application.DoEvents()

            'STOP COMMAND
            frmMain.SerialPort1.Write(SEND_30_BYTE, 0, 1) : System.Threading.Thread.Sleep(25)

            'SENSOR REQUEST COMMAND
            frmMain.SerialPort1.Write(Buffer, 0, 1) : System.Threading.Thread.Sleep(25)

            'CLEAR BUFFER (DISREGARD THOSE BYTES)
            frmMain.SerialPort1.DiscardInBuffer()

            'REGISTER BYTE ADDRESS
            frmMain.SerialPort1.Write(Buffer, 1, 1) : System.Threading.Thread.Sleep(25)
            InData = frmMain.SerialPort1.ReadByte

            'IF VALID THEN UPDATE TREEVIEW
            If InData = xCounter Then
                cvtData = Hex(InData)
                If Len(cvtData) = 1 Then cvtData = "0" & cvtData
                TreeView1.Nodes(0).Nodes(NodeValue).Nodes.Add(cvtData) : TreeView1.ExpandAll()
            End If
        Next

        frmMain.tsProgress.Value = 0
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedValueChanged
        cmdScanEcu.Enabled = True
    End Sub
End Class