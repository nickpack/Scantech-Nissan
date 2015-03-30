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
        ENABLE_STATE_FOR_MENUS(1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frmScannerRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LOAD FORM POSITION
        LOAD_WINDOW_FORM_STATE(Me, 10, 10, 250, 375)

        'ENABLE/DISABLE FRMMAIN MENU STATE
        ENABLE_STATE_FOR_MENUS(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1)

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

            'ASK USER WOULD YOU LIKE TO IMPORT TO ECU PROFILE
            Dim Reply As Integer
            Reply = MsgBox("Would you like to import this to ECU Profile?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Import To ECU Profile")
            '6 YES            '7 NO 
            If Reply = 6 Then
                frmECUProfile.Show()
                frmECUProfile.NewToolStripMenuItem_Click(3, e)

                Dim X As Integer
                Dim Addr As String
                Dim Addr1 As String
                Dim StartSensor As String
                Dim StartActive As String

                For X = 0 To 255
                    'DOEVENTS
                    System.Windows.Forms.Application.DoEvents()

                    '2 CHAR FORMAT
                    Addr = Hex(X) : If Len(Addr) = 1 Then Addr = "0" & Addr
                    Addr1 = Hex(X)

                    'ANALOG SENSOR REGISTER ADDRESS
                    If SUPPORTED_REGISTERS(X, 0, 0) = True Then
                        'START ANALOG SENSOR REGISTER ADDRESS
                        If StartSensor = "" Then
                            StartSensor = X
                            frmECUProfile.DataGridView5.Item(1, 0).Value = StartSensor
                        End If
                        'END ANALOG SENSOR REGISTER ADDRESS
                        frmECUProfile.DataGridView5.Item(1, 1).Value = X

                        frmECUProfile.DataGridView1.RowCount = frmECUProfile.DataGridView1.RowCount + 1
                        frmECUProfile.DataGridView1.Item(0, frmECUProfile.DataGridView1.RowCount - 1).Tag = Addr1                'USED FOR SAVING INI.  ALWAYS IN HEX FORMAT WITH NO LEADING 0
                        frmECUProfile.DataGridView1.Item(0, frmECUProfile.DataGridView1.RowCount - 1).Value = "0x" & Addr        'ADDRESS
                        frmECUProfile.DataGridView1.Item(1, frmECUProfile.DataGridView1.RowCount - 1).Value = "-"
                    End If

                    'ACTIVE/OUTPUT REGISTER ADDRESS
                    If SUPPORTED_REGISTERS(X, 0, 2) = True Then
                        'START ACTIVE REGISTER ADDRESS
                        If StartActive = "" Then
                            StartActive = X
                            frmECUProfile.DataGridView5.Item(1, 2).Value = StartActive
                        End If
                        'END ACTIVE REGISTER ADDRESS
                        frmECUProfile.DataGridView5.Item(1, 3).Value = X

                        frmECUProfile.DataGridView3.RowCount = frmECUProfile.DataGridView3.RowCount + 1
                        frmECUProfile.DataGridView3.Item(0, frmECUProfile.DataGridView3.RowCount - 1).Tag = Addr1                'USED FOR SAVING INI.  ALWAYS IN HEX FORMAT WITH NO LEADING 0
                        frmECUProfile.DataGridView3.Item(0, frmECUProfile.DataGridView3.RowCount - 1).Value = "0x" & Addr        'ADDRESS
                        frmECUProfile.DataGridView3.Item(1, frmECUProfile.DataGridView3.RowCount - 1).Value = "-"
                    End If
                Next
                'ECU ID
                frmECUProfile.DataGridView4.Item(1, 5).Value = ComboBox1.Text
                'AUTO SCAN
                frmECUProfile.DataGridView4.Item(1, 7).Value = "True"

                'RESET
                cmdScanEcu.Text = "Scan Registers" : LOOP_IN_PROGRESS = False : frmMain.tsProgress.Visible = False : USER_REQUEST_STOP = False

                Me.Close()
                Exit Sub
            End If

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

            'STOP COMMAND
            frmMain.SerialPort1.Write(SEND_30_BYTE, 0, 1) : Wait(25)

            'SENSOR REQUEST COMMAND
            frmMain.SerialPort1.Write(Buffer, 0, 1) : Wait(25)

            'DOEVENTS
            System.Windows.Forms.Application.DoEvents()

            'CLEAR BUFFER (DISREGARD THOSE BYTES)
            frmMain.SerialPort1.DiscardInBuffer()

            'REGISTER BYTE ADDRESS
            frmMain.SerialPort1.Write(Buffer, 1, 1) : Wait(25)
            InData = frmMain.SerialPort1.ReadByte

            'IF VALID THEN UPDATE TREEVIEW
            If InData = xCounter Then
                cvtData = Hex(InData)
                If Len(cvtData) = 1 Then cvtData = "0" & cvtData
                TreeView1.Nodes(0).Nodes(NodeValue).Nodes.Add(cvtData) : TreeView1.ExpandAll()

                'USED FOR IMPORTING TO ECU PROFILE
                Select Case CmdByte
                    Case 90 : SUPPORTED_REGISTERS(xCounter, 0, 0) = True                        'ANALOG SENSOR ADDRESS
                    Case 10 : SUPPORTED_REGISTERS(xCounter, 0, 2) = True                        'ACTIVE/OUTPUT ADDRESS
                End Select
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