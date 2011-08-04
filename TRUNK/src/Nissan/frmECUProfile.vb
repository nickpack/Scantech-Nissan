Public Class frmECUProfile
    Dim blnIsCellDirty As Boolean
    Dim blnNewFile As Boolean
    'CLEAN CLEAN CLEAN 
    Private Sub frmECUProfile_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If blnIsCellDirty = True Then
            '6 YES            '7 NO            '2 CANCEL
            Dim Response As Integer
            Response = MsgBox("Do you want to save?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel, "Save File")
            Select Case Response
                Case 6
                    If blnNewFile = True Then
                        SaveAsToolStripMenuItem_Click(3, e)
                        e.Cancel = True
                        Exit Sub
                    Else
                        SaveIniSettings(FileName)
                    End If
                    'CANCEL SAVE AND DO NOT EXIT
                Case 2 : e.Cancel = True
            End Select
        End If

        ENABLE_STATE_FOR_MENUS(1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1)

        'SAVE FORM POSITION
        SAVE_WINDOW_FORM_STATE(Me)
    End Sub
    Private Sub frmECUProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TreeView1.ExpandAll()
        blnIsCellDirty = False

        'OPEN FILE DIALOG DEFAULTS
        OpenFileDialog1.InitialDirectory = Application.StartupPath & "\Vehicle Specific"
        OpenFileDialog1.Filter = "ini files (*.ini)|*.ini|All files (*.*)|*.*"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.RestoreDirectory = True

        'SAVE FILE DIALOG DEFAULTS
        SaveFileDialog1.InitialDirectory = Application.StartupPath & "\Vehicle Specific"
        SaveFileDialog1.Filter = "ini files (*.ini)|*.ini|All files (*.*)|*.*"
        SaveFileDialog1.FilterIndex = 1
        SaveFileDialog1.RestoreDirectory = True

        ENABLE_STATE_FOR_MENUS(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1)

        'LOAD FORM POSITION
        LOAD_WINDOW_FORM_STATE(Me, 10, 10, 849, 517)
    End Sub
    Public Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        If blnIsCellDirty = True Then
            '6 YES            '7 NO            '2 CANCEL
            Dim Response As Integer
            Response = MsgBox("Do you want to save?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel, "Save File")
            Select Case Response
                Case 6
                    If blnNewFile = True Then
                        'CALL SAVE AS DIALOG
                        SaveAsToolStripMenuItem_Click(3, e)
                        Exit Sub
                    Else
                        'SAVE IT
                        SaveIniSettings(FileName)
                    End If
                Case 2 : Exit Sub
            End Select
        End If

        'PART OF FRMCONNECT.  WHEN EDIT BUTTON PRESSED
        If Me.Tag = 1 Then
            Me.Tag = 0
            OpenFileDialog1.FileName = FileName
            GoTo Skip
        End If

        'CALL OPEN DIALOG
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
Skip:
            Try
                FileName = OpenFileDialog1.FileName
                KeyName(0) = "SOFTWARE"
                ReadINIFile(FileName, "FILE IDENTIFICATION", KeyName, KeyValues)

                If KeyValues(0) = "Scantech Nissan" Then
                    FillGridForOpen()
                Else
                    MsgBox("This is not a Scantech Nissan type file", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Wrong File Type")
                    Exit Sub
                End If

            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
            End Try

            'RESET
            blnIsCellDirty = False
        End If

    End Sub
    Private Sub FillGridForNew()
        'CLEAR ALL GRIDS AND TREEVIEW1
        DataGridView1.Rows.Clear()
        DataGridView2.Rows.Clear()
        DataGridView3.Rows.Clear()
        DataGridView4.Rows.Clear()
        DataGridView5.Rows.Clear()

        'VEHICLE INFO
        DataGridView4.RowCount = 8
        DataGridView4.Item(0, 0).Value = "YEAR"
        DataGridView4.Item(0, 1).Value = "MAKE"
        DataGridView4.Item(0, 2).Value = "MODEL"
        DataGridView4.Item(0, 3).Value = "NUMBER OF CYLINDERS"
        DataGridView4.Item(0, 4).Value = "ENGINE SIZE LITERS"
        DataGridView4.Item(0, 5).Value = "ECU ID"
        DataGridView4.Item(0, 6).Value = "MODULE"
        DataGridView4.Item(0, 7).Value = "AUTOSCAN"

        'REGISTER INFO
        DataGridView5.RowCount = 11
        DataGridView5.Item(0, 0).Value = "START BYTE FOR SENSOR"
        DataGridView5.Item(0, 1).Value = "END BYTE FOR SENSOR"
        DataGridView5.Item(0, 2).Value = "START BYTE FOR ACTIVE TEST"
        DataGridView5.Item(0, 3).Value = "END BYTE FOR ACTIVE TEST"
        DataGridView5.Item(0, 4).Value = "MAX REGISTERS ALLOWED"
        DataGridView5.Item(0, 5).Value = "CHECK FAULT COMMAND"
        DataGridView5.Item(0, 6).Value = "CLEAR FAULT COMMAND"
        DataGridView5.Item(0, 7).Value = "ECU INFO COMMAND"
        DataGridView5.Item(0, 8).Value = "STREAM AVAILABLE SENSOR COMMAND"
        DataGridView5.Item(0, 9).Value = "INTERBYTE DELAY"
        DataGridView5.Item(0, 10).Value = "TIMEOUT"

        TreeView1.Visible = True
        TreeView2.Visible = True
        TreeView1.Nodes(0).Text = "Untitled Name"
        TreeView1.ExpandAll()
        TreeView1.SelectedNode = TreeView1.Nodes(0).Nodes(0)
        blnIsCellDirty = False
        blnNewFile = True
        SaveAsToolStripMenuItem.Enabled = True
        SaveToolStripMenuItem.Enabled = True

    End Sub
    Private Sub FillGridForOpen()
        'CLEAR ALL GRIDS AND TREEVIEW1
        DataGridView1.Rows.Clear()
        DataGridView2.Rows.Clear()
        DataGridView3.Rows.Clear()
        DataGridView4.Rows.Clear()
        DataGridView5.Rows.Clear()


        Dim X As Integer
        Dim KeyValues1(10) As String
        Dim keyname1(10) As String

        '--------------------------------------------------------------------------------------------------------------------------------
        'VEHICLE INFORMATION
        '--------------------------------------------------------------------------------------------------------------------------------
        keyname1(0) = "YEAR"
        keyname1(1) = "MAKE"
        keyname1(2) = "MODEL"
        keyname1(3) = "NUMBER OF CYLINDERS"
        keyname1(4) = "ENGINE SIZE LITERS"
        keyname1(5) = "ECU ID"
        keyname1(6) = "MODULE"
        keyname1(7) = "AUTOSCAN"

        ReadINIFile(OpenFileDialog1.FileName, "VEHICLE INFO", keyname1, KeyValues1)

        For X = 0 To 7
            DataGridView4.RowCount = DataGridView4.RowCount + 1
            DataGridView4.Item(0, X).Value = keyname1(X)
            DataGridView4.Item(1, X).Value = KeyValues1(X)
        Next

        '--------------------------------------------------------------------------------------------------------------------------------
        'REGISTER INFORMATION
        '--------------------------------------------------------------------------------------------------------------------------------
        keyname1(0) = "START BYTE FOR SENSOR"
        keyname1(1) = "END BYTE FOR SENSOR"
        keyname1(2) = "START BYTE FOR ACTIVE TEST"
        keyname1(3) = "END BYTE FOR ACTIVE TEST"
        keyname1(4) = "MAX REGISTERS ALLOWED"
        keyname1(5) = "CHECK FAULT COMMAND"
        keyname1(6) = "CLEAR FAULT COMMAND"
        keyname1(7) = "ECU INFO COMMAND"
        keyname1(8) = "STREAM AVAILABLE SENSOR COMMAND"
        keyname1(9) = "INTERBYTE DELAY"
        keyname1(10) = "TIMEOUT"

        ReadINIFile(OpenFileDialog1.FileName, "REGISTERS INFO", keyname1, KeyValues1)

        For X = 0 To 10
            DataGridView5.RowCount = DataGridView5.RowCount + 1
            DataGridView5.Item(0, X).Value = keyname1(X)
            DataGridView5.Item(1, X).Value = KeyValues1(X)
        Next

        '--------------------------------------------------------------------------------------------------------------------------------
        'SENSOR REGISTER
        '--------------------------------------------------------------------------------------------------------------------------------
        For X = 0 To 255    'CYCLE THROUGH 255 BYTE ADDRESS
            Dim CvtValue As String
            Dim CurrentByteIsValid As Boolean
            CurrentByteIsValid = False
            KeyName(0) = Hex(X)
            CvtValue = KeyName(0) : If Len(CvtValue) = 1 Then CvtValue = "0" & CvtValue
            KeyValues(0) = ""
            ReadINIFile(OpenFileDialog1.FileName, "SENSOR REGISTERS SUPPORTED NAMES", KeyName, KeyValues)
            If KeyValues(0) <> "" Then
                'ADDRESS AND SENSOR NAME
                CurrentByteIsValid = True
                DataGridView1.RowCount = DataGridView1.RowCount + 1
                DataGridView1.Item(0, DataGridView1.RowCount - 1).Tag = KeyName(0)
                DataGridView1.Item(0, DataGridView1.RowCount - 1).Value = "0x" & CvtValue
                DataGridView1.Item(1, DataGridView1.RowCount - 1).Value = KeyValues(0)
                System.Windows.Forms.Application.DoEvents()

                'SENSOR SCALE TYPE
                KeyValues(0) = ""
                ReadINIFile(OpenFileDialog1.FileName, "SENSORS REGISTERS SCALE TYPE", KeyName, KeyValues)
                If KeyValues(0) <> "" Then
                    DataGridView1.Item(2, DataGridView1.RowCount - 1).Value = KeyValues(0)
                End If

                'SENSOR UNIT TYPE
                KeyValues(0) = ""
                ReadINIFile(OpenFileDialog1.FileName, "SENSORS REGISTERS UNIT TYPE", KeyName, KeyValues)
                If KeyValues(0) <> "" Then
                    DataGridView1.Item(3, DataGridView1.RowCount - 1).Value = KeyValues(0)
                End If
            End If

            '--------------------------------------------------------------------------------------------------------------------------------
            'ACTIVE TEST REGISTER
            '--------------------------------------------------------------------------------------------------------------------------------
            KeyValues(0) = ""
            ReadINIFile(OpenFileDialog1.FileName, "ACTIVE TEST SUPPORTED NAMES", KeyName, KeyValues)
            If KeyValues(0) <> "" Then
                'ADDRESS AND ACTIVE TEST NAME
                DataGridView3.RowCount = DataGridView3.RowCount + 1
                DataGridView3.Item(0, DataGridView3.RowCount - 1).Tag = KeyName(0)
                DataGridView3.Item(0, DataGridView3.RowCount - 1).Value = "0x" & CvtValue
                DataGridView3.Item(1, DataGridView3.RowCount - 1).Value = KeyValues(0)

                'ACTIVE TEST SCALE TYPE
                KeyValues(0) = ""
                ReadINIFile(OpenFileDialog1.FileName, "ACTIVE TEST REGISTER SCALE TYPE", KeyName, KeyValues)
                If KeyValues(0) <> "" Then
                    DataGridView3.Item(2, DataGridView3.RowCount - 1).Value = KeyValues(0)
                End If
            End If

            '--------------------------------------------------------------------------------------------------------------------------------
            'DIGITAL OUTPUT REGISTER
            '--------------------------------------------------------------------------------------------------------------------------------
            Dim J As Integer
            For J = 0 To 7
                KeyName(0) = Hex(X) & "b" & J       'FORMAT EXAMPLE (13b1) 13=REGISTER ADDRESS BYTE b1=BIT TO SELECT
                KeyValues(0) = ""
                ReadINIFile(OpenFileDialog1.FileName, "DIGITAL OUTPUT NAMES", KeyName, KeyValues)
                If UCase(KeyValues(0)) <> "" Then
                    'READ DIGITAL OUTPUT NAMES
                    DataGridView2.RowCount = DataGridView2.RowCount + 1
                    DataGridView2.Item(0, DataGridView2.RowCount - 1).Tag = KeyName(0)
                    If CurrentByteIsValid = False Then
                        DataGridView2.Item(0, DataGridView2.RowCount - 1).Style.BackColor = Color.Red
                        DataGridView2.Item(0, DataGridView2.RowCount - 1).Value = "0x" & CvtValue & " b" & J & " ?"
                    Else
                        DataGridView2.Item(0, DataGridView2.RowCount - 1).Style.BackColor = Color.White
                        DataGridView2.Item(0, DataGridView2.RowCount - 1).Value = "0x" & CvtValue & " b" & J
                    End If
                    DataGridView2.Item(1, DataGridView2.RowCount - 1).Value = KeyValues(0)

                    'DIGITAL SCALE TYPE
                    KeyValues(0) = ""
                    ReadINIFile(OpenFileDialog1.FileName, "DIGITAL OUTPUT SCALE TYPE", KeyName, KeyValues)
                    If UCase(KeyValues(0)) <> "" Then
                        DataGridView2.Item(2, DataGridView2.RowCount - 1).Value = KeyValues(0)
                    End If
                End If

            Next J
        Next

        TreeView1.Visible = True
        TreeView2.Visible = True
        TreeView1.Nodes(0).Text = OpenFileDialog1.FileName.Substring(OpenFileDialog1.FileName.LastIndexOf("\") + 1)
        TreeView1.ExpandAll()
        TreeView1.SelectedNode = TreeView1.Nodes(0).Nodes(0)
        blnIsCellDirty = False
        blnNewFile = False
        SaveAsToolStripMenuItem.Enabled = True
        SaveToolStripMenuItem.Enabled = True

    End Sub
    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        DataGridView1.Visible = False
        DataGridView2.Visible = False
        DataGridView3.Visible = False
        DataGridView4.Visible = False
        DataGridView5.Visible = False
        cmdAdd.Visible = False : cmdDelete.Visible = False

        Select Case e.Node.Text
            Case "Sensor Registers" : DataGridView1.Visible = True : cmdAdd.Tag = 1 : cmdDelete.Tag = 1 : cmdAdd.Visible = True : cmdDelete.Visible = True
            Case "Digital Output Registers" : DataGridView2.Visible = True : cmdAdd.Tag = 2 : cmdDelete.Tag = 2 : cmdAdd.Visible = True : cmdDelete.Visible = True
            Case "Active Test Registers" : DataGridView3.Visible = True : cmdAdd.Tag = 3 : cmdDelete.Tag = 3 : cmdAdd.Visible = True : cmdDelete.Visible = True
            Case "Vehicle Information" : DataGridView4.Visible = True
            Case "Register Information" : DataGridView5.Visible = True
        End Select
    End Sub

    Public Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        If blnIsCellDirty = True Then
            '6 YES            '7 NO            '2 CANCEL
            Dim Response As Integer
            Response = MsgBox("Do you want to save?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel, "Save File")
            Select Case Response
                Case 6
                    If blnNewFile = True Then
                        SaveAsToolStripMenuItem_Click(3, e)
                        Exit Sub
                    Else
                        SaveIniSettings(FileName)
                    End If
                Case 2 : Exit Sub
            End Select
        End If

        'CONTINUE HERE IF NO
        FillGridForNew()

    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        If blnNewFile = False Then
            SaveIniSettings(FileName)                   'SAVE IT NO DIALOG
        Else
            SaveAsToolStripMenuItem_Click(3, e)         'SHOW SAVE DIALOG (NEW FILE)
        End If
    End Sub
    Function SaveIniSettings(ByVal FileName As String) As Boolean
        SaveIniSettings = False

        'DELETE IT THEN REWRITE.  DOING IT THIS WAY ELIMINATES UNWANTED SECTIONS
        System.IO.File.Delete(FileName)

        Dim X As Integer
        'FILE IDENTIFICATION
        WriteINIFile(FileName, "FILE IDENTIFICATION", "SOFTWARE", "Scantech Nissan")
        WriteINIFile(FileName, "FILE IDENTIFICATION", "VERSION", "1")

        'VEHICLE INFO
        For X = 0 To 7
            WriteINIFile(FileName, "VEHICLE INFO", DataGridView4.Item(0, X).Value, DataGridView4.Item(1, X).Value)
        Next

        'REGISTER INFO
        For X = 0 To 10
            WRITEINIFILE(FileName, "REGISTERS INFO", DataGridView5.Item(0, X).Value, DataGridView5.Item(1, X).Value)
        Next

        'SENSOR REGISTERS NAME, SCALE TYPE, UNIT TYPE
        For X = 0 To DataGridView1.RowCount - 1
            WriteINIFile(FileName, "SENSOR REGISTERS SUPPORTED NAMES", DataGridView1.Item(0, X).Tag, DataGridView1.Item(1, X).Value)
            WriteINIFile(FileName, "SENSORS REGISTERS SCALE TYPE", DataGridView1.Item(0, X).Tag, DataGridView1.Item(2, X).Value)
            WriteINIFile(FileName, "SENSORS REGISTERS UNIT TYPE", DataGridView1.Item(0, X).Tag, DataGridView1.Item(3, X).Value)
        Next

        'DIGITAL OUTPUT NAME, SCALE TYPE
        For X = 0 To DataGridView2.RowCount - 1
            WriteINIFile(FileName, "DIGITAL OUTPUT NAMES", DataGridView2.Item(0, X).Tag, DataGridView2.Item(1, X).Value)
            WriteINIFile(FileName, "DIGITAL OUTPUT SCALE TYPE", DataGridView2.Item(0, X).Tag, DataGridView2.Item(2, X).Value)
        Next

        'ACTIVE TEST NAME, SCALE TYPE
        For X = 0 To DataGridView3.RowCount - 1
            WriteINIFile(FileName, "ACTIVE TEST SUPPORTED NAMES", DataGridView3.Item(0, X).Tag, DataGridView3.Item(1, X).Value)
            WriteINIFile(FileName, "ACTIVE TEST REGISTER SCALE TYPE", DataGridView3.Item(0, X).Tag, DataGridView3.Item(2, X).Value)
        Next

        SaveIniSettings = True
        blnIsCellDirty = False
        blnNewFile = False
        MsgBox("File Saved", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INI File")

    End Function
    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            FileName = SaveFileDialog1.FileName
            TreeView1.Nodes(0).Text = SaveFileDialog1.FileName.Substring(OpenFileDialog1.FileName.LastIndexOf("\") + 1)
            SaveIniSettings(FileName)
        End If
    End Sub
    Private Sub DataGridView5_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView5.CellValueChanged
        blnIsCellDirty = True
    End Sub
    Private Sub DataGridView4_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.CellValueChanged
        blnIsCellDirty = True
    End Sub
    Private Sub DataGridView3_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellValueChanged
        blnIsCellDirty = True
    End Sub
    Private Sub DataGridView1_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        blnIsCellDirty = True
    End Sub
    Private Sub DataGridView2_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellValueChanged
        blnIsCellDirty = True
    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Select Case cmdAdd.Tag
            Case 1 : AddRowFor(DataGridView1)
            Case 2 : AddRowForDigital()
            Case 3 : AddRowFor(DataGridView3)
        End Select
    End Sub
    Private Sub AddRowFor(ByVal WhatGrid As Object)
        Dim Value As String
        Value = InputBox("Enter Register Byte to add" & vbNewLine & "DECIMAL FORMAT ONLY (0-255)", "Register Byte")
        If (Val(Value) > 0 And Val(Value) <= 255) Or Value = "0" Then

            'CHECK FOR DUPLICATION
            If CheckIfExist(Hex(Value), WhatGrid) = True Then
                MsgBox("Register Byte already exist", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                Exit Sub
            End If

            Value = Hex(Value)

            WhatGrid.RowCount = WhatGrid.RowCount + 1
            WhatGrid.Item(0, WhatGrid.RowCount - 1).Tag = Value                 'USED FOR SAVING INI.  ALWAYS IN HEX FORMAT WITH NO LEADING 0
            If Len(Value) = 1 Then Value = "0" & Value
            WhatGrid.Item(0, WhatGrid.RowCount - 1).Value = "0x" & Value        'ADDRESS
            blnIsCellDirty = True

            Value = InputBox("Enter Register Name to add", "Register Name")
            WhatGrid.Item(1, WhatGrid.RowCount - 1).Value = Value               'REGISTER NAME
        Else
            MsgBox("Input Error", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End If
    End Sub
    Private Sub AddRowForDigital()
        Dim Value As String
        Dim Value2 As String

        Value = InputBox("Enter Register Byte to add" & vbNewLine & "DECIMAL FORMAT ONLY (0-255)", "Register Byte")
        If (Val(Value) > 0 And Val(Value) <= 255) Or Value = "0" Then
            Value2 = InputBox("Which Bit?" & vbNewLine & "Type numbers from 0 to 7 only!", "Register Bit")
            If (Val(Value2) > 0 And Val(Value2) <= 7) Or Value2 = "0" Then
                'CHECK FOR DUPLICATION
                If CheckIfExist(Hex(Value) & "b" & Val(Value2), DataGridView2) = True Then
                    MsgBox("Register Byte already exist", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                    Exit Sub
                End If

                'ADD INPUTS TO DATAGRIDVIEW
                Value = Hex(Value)
                DataGridView2.RowCount = DataGridView2.RowCount + 1
                DataGridView2.Item(0, DataGridView2.RowCount - 1).Tag = Value & "b" & Value2
                If Len(Value) = 1 Then Value = "0" & Value
                DataGridView2.Item(0, DataGridView2.RowCount - 1).Value = "0x" & Value & " b" & Value2

                'IF SENSOR REGISTER DOES NOT CONTAIN THIS BYTE THEN ASK TO ADD
                If CheckSensorGrid(Value) = False Then AskAddDigitalOutputByte(Value)

                Value = InputBox("Enter Register Name to add", "Register Name")
                DataGridView2.Item(1, DataGridView2.RowCount - 1).Value = Value               'REGISTER NAME
            Else
                MsgBox("Input Error", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                Exit Sub
            End If
        Else
            MsgBox("Input Error", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End If
    End Sub
    Function CheckIfExist(ByVal Value As String, ByVal Whatgrid As Object) As Boolean
        CheckIfExist = False
        Dim x As Integer
        For x = 0 To Whatgrid.RowCount - 1
            If Whatgrid.Item(0, x).Tag = Value Then CheckIfExist = True
        Next
    End Function
    Private Sub AskAddDigitalOutputByte(ByVal Value As String)
        Dim Response As Integer
        Response = MsgBox("Byte 0x" & Value & " is not available in Sensor Registers" & vbNewLine & "Do you want to add?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel, "Add Digital Output Byte")
        Select Case Response
            Case 6
                DataGridView1.RowCount = DataGridView1.RowCount + 1
                DataGridView1.Item(0, DataGridView1.RowCount - 1).Tag = Value
                If Len(Value) = 1 Then Value = "0" & Value
                DataGridView1.Item(0, DataGridView1.RowCount - 1).Value = "0x" & Value
                DataGridView1.Item(1, DataGridView1.RowCount - 1).Value = "Digital Output"
        End Select
    End Sub
    Function CheckSensorGrid(ByVal Value As String) As Boolean
        CheckSensorGrid = False
        Dim X As Integer
        For X = 0 To DataGridView1.RowCount - 1
            If CByte("&H" & DataGridView1.Item(0, X).Tag) = CByte("&H" & Value) Then
                CheckSensorGrid = True
                Exit Function
            End If
        Next
    End Function
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Select Case cmdAdd.Tag
            Case 1 : DeleteRowFor(DataGridView1)
            Case 2 : DeleteRowFor(DataGridView2)
            Case 3 : DeleteRowFor(DataGridView3)
        End Select
    End Sub
    Private Sub DeleteRowFor(ByVal WhichGrid As Object)
        Dim Response As Integer
        Response = MsgBox("Are you sure you want to delete?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel, "Delete Row")
        Select Case Response
            Case 6
                For Each row As DataGridViewRow In WhichGrid.SelectedRows
                    WhichGrid.Rows.Remove(row)
                Next
                blnIsCellDirty = True
        End Select
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class