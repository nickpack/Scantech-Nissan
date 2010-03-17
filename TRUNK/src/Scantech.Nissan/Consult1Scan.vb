Module Consult1Scan
    Public SUPPORTED_REGISTERS(255, 1, 2) As Boolean            'FIRST ARRAY REGISTER SUPPORTED, SECOND ARRAY 1 = TRUE THEN BOTH MSB/LSB TYPE : 1 = FALSE THEN LSB ONLY, THIRD ARRAY "0 = TRUE THEN ANALOG SENSOR REGISTER, 1 = TRUE THEN DIGITAL OUPUT(ON/OFF), 2 = TRUE THEN ACTIVE TEST REGISTER"
    Public REGISTERS_NAME(255, 8) As String                     'FIRST ARRAY REGISTER NAME (X,0), SECOND ARRAY BITMAPPED NAME FOR DIGITAL OUTPUT (1-8)(0 IS USED TO IDENTIFY REGISTER NAME)
    Public REGISTERS_SCALE_TYPE(255, 7) As String               'FIRST ARRAY SENSORS UNITS, SECOND IS DIGITAL OUTPUT UNITS (BITMAPPED)
    Public REGISTERS_UNIT_TYPE(255) As String                   'UNIT TYPE
    Public SELECTED_REGISTERS(255) As Boolean                   'SELECTED REGISTERS VARIABLE

    Public CBO_ACTIVE_BINDING(255) As BindingSource
    Public BLN_ACTIVE_TEST_COMMAND_REQUEST(1) As Boolean        '(0)=TRUE THEN INITIATE ACTIVE COMMAND, (1)=TRUE THEN STOP

    Public AUTOSCAN As Boolean                                  'FROM INI FILE (FOR VALIDATION)
    Public START_BYTE_FOR_SENSOR As Integer                     'FROM INI FILE (SENSOR AUTOSCAN START BYTE)
    Public END_BYTE_FOR_SENSOR As Integer                       'FROM INI FILE (SENSOR AUTOSCAN END BYTE)
    Public START_BYTE_FOR_ACTIVETEST As Integer                 'FROM INI FILE (ACTIVE TEST AUTOSCAN START BYTE)
    Public END_BYTE_FOR_ACTIVETEST As Integer                   'FROM INI FILE (ACTIVE TEST AUTOSCAN END BYTE)
    Public MAX_PIDS_ALLOWED As Integer                          'FROM INI FILE (20 MOST COMMON)
    Public INTERBYTE_DELAY As Integer                           'FROM INI FILE (DELAY IN BETWEEN BYTES)
    Public SEND_CHECK_FAULTS_BYTE As String                     'FROM INI FILE 
    Public SEND_CLEAR_FAULTS_BYTE As String                     'FROM INI FILE
    Public SEND_ECU_INFO_BYTE As String                         'FROM INI FILE
    Public SEND_STREAM_AVAILABLE_SENSOR_BYTE As String          'FROM INI FILE

    Public USER_FORM_SELECT As Integer                          '1=GRIDSTYLE, 2=GAUGES, 3=GRAPHING, 4=REGISTER DECODER
    Public TOTAL_SELECTED_REGISTERS As Integer                  'TOTAL REGISTERS SELECTED BY USER

    Public LST_VEHICLE_FILE As String                           'INI FILE NAME USED FOR CONNECTING
    Public LOOP_IN_PROGRESS As Boolean                          'QUERYING DATA WILL FLAG THIS TRUE
    Public USER_REQUEST_STOP As Boolean                         'EXITS THE DO LOOPS

    Public ECU_ID_1 As Byte = &HFF                              'ALWAYS 0XFF
    Public ECU_ID_2 As Byte = &HFF                              'ALWAYS 0XFF
    Public ECU_ID_3 As Byte                                     'ADDRESS VARIES ACCORDING TO ECU TYPE

    Public VEHICLE_YEAR As String                               'VEHICLE INFO VARIABLES
    Public VEHICLE_MAKE As String
    Public VEHICLE_MODEL As String
    Public VEHICLE_CYLINDERS As String
    Public VEHICLE_ENGINE_LITER As String
    Public VEHICLE_MODULE As String

    Public IN_BUFFER_BYTE As String                             'INBUFFER DATA VARIABLE
    Public DATA_FILTERED_RECEIVED As String                     'USED FOR DECODING
    Public FF_BYTE_DETECTOR As Boolean                          '0XFF BYTE DETECTOR
    Public REGISTER_DATA_ONLY As Boolean                        'IF TRUE THEN STORE REGISTERS DATA IN DATAFILTEREDRECEIVED
    Public REGISTER_LENGTH_BYTE As Integer                      'LENGTH OF DATA VARIABLE (2ND BYTE)

    Public SEND_5A_BYTE() As Byte = {&H5A}                      'REGISTERS REQUEST COMMAND
    Public SEND_30_BYTE() As Byte = {&H30}                      'STOP COMMAND
    Public SEND_F0_BYTE() As Byte = {&HF0}                      'START COMMAND (STREAMING)
    Public SEND_0A_BYTE() As Byte = {&HA}                       'ACTIVE TEST REQUEST COMMAND

    Public KeyName(0) As String
    Public KeyValues(0) As String

    Public FileName As String                                   'INI FILE NAME FOR ECU PROFILE

    Public TIME_OUT As Integer
    Public LOG_BUTTONS_STATUS As String                         'LOG INSPECTOR STATUS
    Public RECORD_NUMBER As VariantType                         'FRAME RECORD COUNTER
    Public TOTAL_RECORD_FRAME As VariantType                    'TOTAL FRAME RECORDS FOR LOG PLAYING
    Public X_RATE_SAMPLE As Long                                'FRAME PER SECOND STATUS COUNTER

    Private Declare Unicode Function GetPrivateProfileString Lib "kernel32.dll" _
                            Alias "GetPrivateProfileStringW" (ByVal lpApplicationName As String, _
                            ByVal lpKeyName As String, ByVal lpDefault As String, _
                            ByVal lpReturnedString As String, ByVal nSize As Int32, _
                            ByVal lpFileName As String) As Int32
    Private Declare Ansi Function WritePrivateProfileString Lib "kernel32.dll" _
                            Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, _
                            ByVal lpKeyName As String, ByVal lpString As String, _
                            ByVal lpFileName As String) As Int32
    Function SCAN_REGISTERS(ByVal StartReg As Integer, ByVal EndReg As Integer) As Boolean
        'THIS IS TO VALIDATE THE INI FILE TO ECU.  VALID REGISTER ADDRESS IS RELIED ON THE INI FILE
        Dim xCounter As Integer
        Dim InData As Byte

        'CONFIGURE PROGRESS BAR
        frmMain.tsProgress.Visible = True : frmMain.tsProgress.Minimum = StartReg
        frmMain.tsProgress.Value = StartReg : frmMain.tsProgress.Maximum = EndReg

        'FOR VALIDATION ONLY
        For xCounter = StartReg To EndReg
            Dim Buffer As Byte() = {xCounter}

            'SET PROGRESS BAR VALUE
            frmMain.tsProgress.Value = xCounter

            'STOP COMMAND
            frmMain.SerialPort1.Write(SEND_30_BYTE, 0, 1) : System.Threading.Thread.Sleep(INTERBYTE_DELAY)

            'SENSOR REQUEST COMMAND
            frmMain.SerialPort1.Write(SEND_5A_BYTE, 0, 1) : System.Threading.Thread.Sleep(INTERBYTE_DELAY)

            'DOEVENTS
            System.Windows.Forms.Application.DoEvents()

            'CLEAR BUFFER (DISREGARD THOSE BYTES)
            frmMain.SerialPort1.DiscardInBuffer()

            'REGISTER BYTE ADDRESS
            frmMain.SerialPort1.Write(Buffer, 0, 1) : System.Threading.Thread.Sleep(INTERBYTE_DELAY)
            InData = frmMain.SerialPort1.ReadByte

            'REGISTERS IN FILE IS INVALID TO ECU REGISTERS
            If xCounter <> InData Then
                If SUPPORTED_REGISTERS(xCounter, 0, 0) = True Then
                    SCAN_REGISTERS = False
                    frmMain.tsProgress.Visible = False
                    Exit Function
                End If
            End If
        Next xCounter

        'FILE TO ECM IS VALID
        SCAN_REGISTERS = True : frmMain.tsProgress.Visible = False
    End Function

    Function INITIALIZE_ECU(ByVal Addr As Byte, ByVal Msg As Boolean) As Boolean
Restart:
        'OPEN PORT
        Try
            frmMain.SerialPort1.Close()
            frmMain.SerialPort1.PortName = frmMain.tsComPort.Text
            frmMain.SerialPort1.Open()
        Catch ex As Exception
            If Msg = True Then MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "EXCEPTION ON CONNECTING")
            Exit Function
        End Try

        'TRANSMIT 3 INTIALIZE ECU BYTES WITH INTERBYTE DELAY.  CLEAR BUFFER EXCEPT LAST SENT COMMAND.  JUST NEED TO LOOK FOR LAST BYTE
        Dim Buffer As Byte() = {ECU_ID_1, ECU_ID_2, Addr}

        frmMain.SerialPort1.Write(SEND_30_BYTE, 0, 1) : System.Threading.Thread.Sleep(INTERBYTE_DELAY)
        frmMain.SerialPort1.Write(Buffer, 0, 1) : System.Threading.Thread.Sleep(INTERBYTE_DELAY)
        frmMain.SerialPort1.Write(Buffer, 1, 1) : System.Threading.Thread.Sleep(INTERBYTE_DELAY) : frmMain.SerialPort1.DiscardInBuffer()
        frmMain.SerialPort1.Write(Buffer, 2, 1) : System.Threading.Thread.Sleep(INTERBYTE_DELAY)

        'DOEVENTS
        System.Windows.Forms.Application.DoEvents()

        'NO RESPONSE OR BYTES RETURNED THEN ALERT USER ONLY IF MSG = TRUE
        If frmMain.SerialPort1.BytesToRead = 0 Then
            If Msg = True Then
                If MsgBox("NO RESPONSE FROM ECU", MsgBoxStyle.RetryCancel + MsgBoxStyle.Exclamation, _
                          "UNABLE TO CONNECT") = MsgBoxResult.Retry Then
                    GoTo Restart
                End If
            End If
            Exit Function
        End If

        'ECU INVERTED ADDRESS BYTE RESPONSE IS VALID (CHECKS LAST BYTE)
        If Hex(Not (Addr)) = Hex(frmMain.SerialPort1.ReadByte) Then
            INITIALIZE_ECU = True
            Exit Function
        End If

        'NO SUCCESS OR INVALID ECU RESPONSE THEN ALERT USER ONLY IF MSG = TRUE
        If Msg = True Then
            If MsgBox("INVALID RESPONSE FROM ECU", MsgBoxStyle.RetryCancel + MsgBoxStyle.Exclamation, _
                      "UNKNOWN RESPONSE") = MsgBoxResult.Retry Then
                GoTo Restart
            End If
        End If
    End Function

    Public Function PROCESS_BUFFER_DATA(ByVal blnRegisterCheck As Boolean) As Boolean
        PROCESS_BUFFER_DATA = False

        System.Windows.Forms.Application.DoEvents()
        If frmMain.SerialPort1.BytesToRead >= frmMain.SerialPort1.ReadBufferSize Then       'BUFFER OVERFLOW (HARDLY EVER HAPPENS)
            frmMain.SerialPort1.DiscardInBuffer()                                           'CLEAR IT
            RESET_VARIABLES()                                                               'RESET
        End If

        If frmMain.SerialPort1.BytesToRead > 0 Then
            IN_BUFFER_BYTE = Hex(frmMain.SerialPort1.ReadByte)
            If Len(IN_BUFFER_BYTE) = 1 Then IN_BUFFER_BYTE = "0" & IN_BUFFER_BYTE '          HEX 2 CHAR FORMAT

            '--------------------------------------------------------------------------------------------------------------------------------
            'THIS PART IS FOR PID DATA  (THIRD BYTE)
            '--------------------------------------------------------------------------------------------------------------------------------
            If REGISTER_DATA_ONLY = True Then                                               'THIS IS TRIGGERED AFTER 2ND BYTE (LENGTH BYTE)
                DATA_FILTERED_RECEIVED = DATA_FILTERED_RECEIVED & IN_BUFFER_BYTE            'ONLY REGISTER DATA FOR DECODING
                If Len(DATA_FILTERED_RECEIVED) >= Val(REGISTER_LENGTH_BYTE) * 2 Then        'IS THE INBUFFER DATA = LENGTH (2ND BYTE) 
                    REGISTER_DATA_ONLY = False                                              'RESET
                    PROCESS_BUFFER_DATA = True                                              'COMPLETED DATA FILTERED WILL TRIGGER THIS TRUE
                    Exit Function
                End If

                '--------------------------------------------------------------------------------------------------------------------------------
                'THIS PART IS AFTER 0XFF DETECTED     (SECOND BYTE) OR (LENGTH BYTE)
                '--------------------------------------------------------------------------------------------------------------------------------
            ElseIf FF_BYTE_DETECTOR = True Then                                             'THIS IS TRIGGERED ONLY IF 1ST BYTE = 0XFF
                If IN_BUFFER_BYTE <> "FF" Then                                              'FOR SAFE PRECAUTION.  SHOULD NOT BE FF
                    REGISTER_LENGTH_BYTE = CByte("&H" & IN_BUFFER_BYTE)                     'DETERMINES RECEIVED LENGTH BYTE (2ND BYTE)
                    If blnRegisterCheck = True Then                                         'COMPARES SELECTED BYTES TO LENGTH BYTE.  GOOD FOR ERROR CHECKING
                        If TOTAL_SELECTED_REGISTERS = REGISTER_LENGTH_BYTE Then             'REGISTER_LENGTH_BYTE IS SECOND BYTE FROM ECU DATA FRAME.
                            REGISTER_DATA_ONLY = True                                       'FLAG REGISTER_DATA_ONLY RECEIVED
                        End If
                    Else
                        REGISTER_DATA_ONLY = True                                           'NO ERROR CHECKING (USED FOR FAULTS WHICH DOES NOT HAVE SELECTED BYTE TO VALIDATE)
                    End If
                End If
                FF_BYTE_DETECTOR = False                                                    'RESET
                DATA_FILTERED_RECEIVED = ""                                                 'CLEAR 

                '--------------------------------------------------------------------------------------------------------------------------------
                'THIS PART IS WHEN 0XFF DETECTED   (FIRST BYTE)
                '--------------------------------------------------------------------------------------------------------------------------------
            ElseIf FF_BYTE_DETECTOR = False And REGISTER_DATA_ONLY = False Then
                If IN_BUFFER_BYTE = "FF" Then                                               'FRAME START BYTE RECEIVED
                    FF_BYTE_DETECTOR = True                                                 'FLAG FF_BYTE_DETECTOR TO TRUE
                End If
            End If
        End If
    End Function
    Public Sub PRE_REQUEST_C1_SENSOR_TYPE_1()
        'REQUEST SUPPORTED REGISTERS.  NOTE:  MAX REGISTERS DEFINED IN INI FILE
        Dim x As Integer
        For x = START_BYTE_FOR_SENSOR To END_BYTE_FOR_SENSOR
            If SELECTED_REGISTERS(x) = True Then
                frmMain.SerialPort1.Write(SEND_5A_BYTE, 0, 1) : System.Threading.Thread.Sleep(INTERBYTE_DELAY)
                frmMain.SerialPort1.Write(Chr(x)) : System.Threading.Thread.Sleep(INTERBYTE_DELAY)
            End If
        Next

        '0XF0 = START COMMAND
        frmMain.SerialPort1.Write(SEND_F0_BYTE, 0, 1) : System.Threading.Thread.Sleep(INTERBYTE_DELAY)
    End Sub
    Public Sub PRE_REQUEST_C1_SENSOR_TYPE_2()
        'SOME ECU WILL NOT ALLOW PRE_REQUEST_C1_SENSOR_TYPE_1() ROUTINE.  
        'INSTEAD, IT REQUIRES 1 COMMAND BYTE REQUEST FOR STREAMING.

        Dim SEND_BYTE() As Byte = {SEND_STREAM_AVAILABLE_SENSOR_BYTE}

        'REQUEST ALL AVAILABLE SENSOR AND FIND THE LENGTH BYTE, SO WE CAN STORE THAT VALUE IN THE VARIABLE
        frmMain.SerialPort1.Write(SEND_BYTE, 0, 1) : System.Threading.Thread.Sleep(INTERBYTE_DELAY)         'REQUEST COMMAND
        frmMain.SerialPort1.DiscardInBuffer()                                                               'CLEAR BUFFER
        frmMain.SerialPort1.Write(SEND_F0_BYTE, 0, 1) : System.Threading.Thread.Sleep(INTERBYTE_DELAY)      'START COMMAND
        frmMain.SerialPort1.Write(SEND_30_BYTE, 0, 1) : System.Threading.Thread.Sleep(INTERBYTE_DELAY)      'STOP COMMAND

        'ASSIGN THE LENGTH BYTE TO TOTAL SELECTED REGISTER VARIABLE
        Dim InData As String
        InData = Hex(frmMain.SerialPort1.ReadByte)
        If InData = "FF" Then TOTAL_SELECTED_REGISTERS = frmMain.SerialPort1.ReadByte

        'REQUEST ALL AVAILABLE SENSOR
        frmMain.SerialPort1.Write(SEND_BYTE, 0, 1) : System.Threading.Thread.Sleep(INTERBYTE_DELAY)         'REQUEST COMMAND
        frmMain.SerialPort1.Write(SEND_F0_BYTE, 0, 1) : System.Threading.Thread.Sleep(INTERBYTE_DELAY)      'START COMMAND

    End Sub
    Public Sub REQUEST_C1_SENSOR_DATA()
        Static Retry As Integer = 1
resend:
        RESET_VARIABLES()

        'I HAVE CAME ACROSS WITH 2 DIFFERENT WAYS REQUESTING DATA SENSORS
        If SEND_STREAM_AVAILABLE_SENSOR_BYTE = "N/A" Then
            PRE_REQUEST_C1_SENSOR_TYPE_1()                          'MOST COMMON TYPE
        Else
            PRE_REQUEST_C1_SENSOR_TYPE_2()                          'COMMON ON TRANS MODULE
        End If

        'FLAG DO LOOP EVENT IN PROGRESS AND RESET USER_REQUEST_STOP
        LOOP_IN_PROGRESS = True : USER_REQUEST_STOP = False

        'SET TIMEOUT
        frmMain.tmrTimeout.Interval = TIME_OUT : frmMain.tmrTimeout.Enabled = True

        'LOOP UNTIL DATAFILTERED IS FULLFILLED AND SET TRUE IN PROCESS_BUFFER_DATA FUNCTION
        Do Until USER_REQUEST_STOP = True
            'IF TIMEOUT THEN RETRY CONNECTING (QUIET MODE)
            If frmMain.tmrTimeout.Enabled = False Then
                If INITIALIZE_ECU(ECU_ID_3, False) = True Then GoTo resend
            End If

            If PROCESS_BUFFER_DATA(True) = True Then
                X_RATE_SAMPLE = X_RATE_SAMPLE + 1                                       'TRACK FRAME RATE PER SECOND

                'LOG RECORDING
                If LOG_BUTTONS_STATUS = "Record" Then
                    RECORD_NUMBER = RECORD_NUMBER + 1                                   'UPDATE COUNTER
                    FilePutObject(1, DATA_FILTERED_RECEIVED, (RECORD_NUMBER) * 100)     'WRITE REGISTER FRAME DATA
                    frmMain.tsStatus2.Text = "Frame # " & RECORD_NUMBER - 3000          'FRAME RECORD NUMBER
                End If

                'RESET TIMEOUT
                frmMain.tmrTimeout.Enabled = False : frmMain.tmrTimeout.Enabled = True

                'WHAT FORM USER SELECTED
                Select Case USER_FORM_SELECT
                    Case 1 : RESULT_GRID_STYLE(DATA_FILTERED_RECEIVED)
                    Case 4 : RESULT_REGISTER_DECODER(DATA_FILTERED_RECEIVED)
                End Select
            End If

            'SEND ACTIVE TEST (TRIGGERED BY COMMAND BUTTON IN FRMC1ACTIVE)
            If BLN_ACTIVE_TEST_COMMAND_REQUEST(0) = True Then
                BLN_ACTIVE_TEST_COMMAND_REQUEST(0) = False
                REQUEST_ACTIVE_TEST_COMMANDS()
                GoTo Resend
            ElseIf BLN_ACTIVE_TEST_COMMAND_REQUEST(1) = True Then
                BLN_ACTIVE_TEST_COMMAND_REQUEST(1) = False
                frmMain.SerialPort1.Write(SEND_30_BYTE, 0, 1) : System.Threading.Thread.Sleep(INTERBYTE_DELAY)
                GoTo Resend
            End If
        Loop
    End Sub

    Public Sub REQUEST_ACTIVE_TEST_COMMANDS()
        'SEND ACTIVE TEST COMMAND.  NOTE:  QUERYING SENSOR DATA MUST BE STOPPED BEFORE SENDING ACTIVE TEST COMMANDS
        Dim SelectedRow As Integer = frmC1ActiveTest.Grid2.CurrentCell.RowIndex
        Dim ACTIVE_BYTE As Byte = CByte("&H" & frmC1ActiveTest.Grid2.Item(1, SelectedRow).Tag)              'ACTIVE REGISTER ADDRESS (STORED IN TAG)
        Dim SCALE_BYTE As Byte = Val(frmC1ActiveTest.ComboBox1.Text)                                        'SCALE BYTE..DEFINED BY USER FROM INI FILE
        Dim DATA_BYTE() As Byte = {ACTIVE_BYTE, SCALE_BYTE}

        frmMain.SerialPort1.Write(SEND_30_BYTE, 0, 1) : System.Threading.Thread.Sleep(INTERBYTE_DELAY)      'STOP COMMAND
        frmMain.SerialPort1.Write(SEND_0A_BYTE, 0, 1) : System.Threading.Thread.Sleep(INTERBYTE_DELAY)      'ACTIVE TEST COMMAND
        frmMain.SerialPort1.Write(DATA_BYTE, 0, 1) : System.Threading.Thread.Sleep(INTERBYTE_DELAY)         'REGISTER BYTE
        frmMain.SerialPort1.Write(DATA_BYTE, 1, 1) : System.Threading.Thread.Sleep(INTERBYTE_DELAY)         'COMBOBOX (SCALE BYTE)

        frmMain.SerialPort1.DiscardInBuffer()                                                               'CLEAR ANY BUFFER
    End Sub

    Public Sub REQUEST_C1_CLEAR_FAULTS()
        Dim SEND_BYTE() As Byte = {SEND_CLEAR_FAULTS_BYTE}
        RESET_VARIABLES()

        frmMain.SerialPort1.Write(SEND_30_BYTE, 0, 1) : System.Threading.Thread.Sleep(INTERBYTE_DELAY)      '0X30 = STOP COMMAND
        frmMain.SerialPort1.DiscardInBuffer()                                                               'CLEAR BUFFER
        frmMain.SerialPort1.Write(SEND_BYTE, 0, 1) : System.Threading.Thread.Sleep(INTERBYTE_DELAY)         'CLEAR FAULT COMMAND FROM INI FILE
        frmMain.SerialPort1.Write(SEND_F0_BYTE, 0, 1) : System.Threading.Thread.Sleep(INTERBYTE_DELAY)      '0XFO = START COMMAND
        frmMain.SerialPort1.Write(SEND_30_BYTE, 0, 1) : System.Threading.Thread.Sleep(INTERBYTE_DELAY)      '0X30 = STOP COMMAND
        frmMain.SerialPort1.DiscardInBuffer()                                                               'CLEAR BUFFER
    End Sub

    Public Function REQUEST_C1_FAULTS() As String
        'NOTE:  AVOID CHECK FAULTS ROUTINE FOR THE TCM INI FILE
        'SOME TCM ARE DECODED DIFFERENTLY THEN ECM.  TCM CAN BE BITMAPPED ENCODED.  I HAVE NOT FIGURED IT OUT AT THIS TIME

        Dim SEND_BYTE() As Byte = {SEND_CHECK_FAULTS_BYTE}
        RESET_VARIABLES()

        frmMain.SerialPort1.Write(SEND_30_BYTE, 0, 1) : System.Threading.Thread.Sleep(INTERBYTE_DELAY)      '0X30 = STOP COMMAND
        frmMain.SerialPort1.DiscardInBuffer()                                                               'CLEAR BUFFER
        frmMain.SerialPort1.Write(SEND_BYTE, 0, 1) : System.Threading.Thread.Sleep(INTERBYTE_DELAY)         'FAULT COMMAND FROM INI FILE
        frmMain.SerialPort1.Write(SEND_F0_BYTE, 0, 1) : System.Threading.Thread.Sleep(INTERBYTE_DELAY)      '0XFO = START COMMAND
        frmMain.tmrTimeout.Enabled = True                                                                   'SET TIMEOUT

        'FRAME DATA WILL BE IN DATAFILTERED VARIABLE AND FULLFILLED WHEN SET TRUE
        Do Until frmMain.tmrTimeout.Enabled = False
            If PROCESS_BUFFER_DATA(False) = True Then Exit Do
        Loop

        REQUEST_C1_FAULTS = DATA_FILTERED_RECEIVED                                                          'ADD PROCESSED DATA
        frmMain.SerialPort1.Write(SEND_30_BYTE, 0, 1) : System.Threading.Thread.Sleep(INTERBYTE_DELAY)      '0X30 = STOP COMMAND
        frmMain.SerialPort1.DiscardInBuffer()                                                               'CLEAR BUFFER
    End Function

    Public Sub RESULT_REGISTER_DECODER(ByVal DataFrame As String)
        'SCALE (MSB/LSB OR LSB)
        If Len(DataFrame) = 2 Then
            '2 BYTES
            frmRegisterDecoder.lblScale.Text = DECODE_DATA_C1_SENSORS(frmRegisterDecoder.ComboBox2.Text, 0, "&H" & Left(DataFrame, 2), 0)
        ElseIf Len(DATA_FILTERED_RECEIVED) = 4 Then
            '4 BYTES
            frmRegisterDecoder.lblScale.Text = DECODE_DATA_C1_SENSORS(frmRegisterDecoder.ComboBox2.Text, "&H" & Left(DataFrame, 2), "&H" & Mid(DataFrame, 3, 2), 0)
        End If

        'UNIT
        frmRegisterDecoder.lblUnit.Text = DECODE_DATA_C1_SENSORS_UNIT_TYPE(frmRegisterDecoder.ComboBox3.Text, 0)

        'CLEAR
        DataFrame = ""

    End Sub

    Public Sub RESULT_GRID_STYLE(ByVal DataFrame As String)
        Dim K As Integer
        Dim WhatRowSensors As Integer
        WhatRowSensors = 0

        '--------------------------------------------------------------------------------------------------------------------------------
        'FOR GRIDVIEW
        '--------------------------------------------------------------------------------------------------------------------------------
        'CYCLE THROUGH ALL SUPPORTED AND SELECTED REGISTERS THEN DECODE DATA ON THE GRID
        'NOTE: SORTABLE IS NOT ALLOWED BECAUSE THE WAY IT DECODES IN ORDER
        'DATAFILTERED VARIABLE VALUE IS ORDERED FROM LEFT TO RIGHT WITH LOWEST REGISTER STARTS AT LEFT
        For K = START_BYTE_FOR_SENSOR To END_BYTE_FOR_SENSOR
            System.Windows.Forms.Application.DoEvents()
            '--------------------------------------------------------------------------------------------------------------------------------
            'THIS IS DIGITAL OUTPUT (ON/OFF)
            '--------------------------------------------------------------------------------------------------------------------------------
            If SUPPORTED_REGISTERS(K, 0, 1) = True And SELECTED_REGISTERS(K) = True Then
                Dim G As Integer
                For G = 0 To frmC1Output.Grid2.RowCount - 1
                    'IF BYTE IDENTIFIER = REGISTER BYTE
                    If CByte("&H" & Left(frmC1Output.Grid2.Item(0, G).Tag, 2)) = K Then
                        Dim BitValue As Integer
                        Dim WhatBit As Integer

                        'WHAT IS THE BIT ON THE SUPPORTED DIGITAL REGISTER
                        WhatBit = Val(Right(frmC1Output.Grid2.Item(0, G).Tag, 1))
                        Select Case WhatBit
                            Case 0 : BitValue = 1
                            Case 1 : BitValue = 2
                            Case 2 : BitValue = 4
                            Case 3 : BitValue = 8
                            Case 4 : BitValue = 16
                            Case 5 : BitValue = 32
                            Case 6 : BitValue = 64
                            Case 7 : BitValue = 128
                        End Select

                        Dim Value As Integer
                        Value = CByte("&H" & Left(DataFrame, 2))
                        If Value And BitValue Then
                            frmC1Output.Grid2.Item(2, G).Value = DECODE_DATA_C1_DIGITAL(REGISTERS_SCALE_TYPE(K, WhatBit), True)
                        Else
                            frmC1Output.Grid2.Item(2, G).Value = DECODE_DATA_C1_DIGITAL(REGISTERS_SCALE_TYPE(K, WhatBit), False)
                        End If
                    End If
                Next G
                DATA_FILTERED_RECEIVED = Mid(DATA_FILTERED_RECEIVED, 3)
            Else
                '--------------------------------------------------------------------------------------------------------------------------------
                'THIS IS ANALOG SENSOR DATA
                '--------------------------------------------------------------------------------------------------------------------------------
                Dim Value As String
                If SELECTED_REGISTERS(K) = True And SUPPORTED_REGISTERS(K, 1, 0) = False Then
                    If SUPPORTED_REGISTERS(K + 1, 1, 0) = True Then
                        '4 BYTE REGISTER TYPE
                        frmC1Sensors.Grid1.Item(2, WhatRowSensors).Value = _
                            DECODE_DATA_C1_SENSORS(REGISTERS_SCALE_TYPE(K, 0), "&H" & _
                            Left(DATA_FILTERED_RECEIVED, 2), "&H" & Mid(DATA_FILTERED_RECEIVED, 3, 2), 0)       'SCALE 1
                        frmC1Sensors.Grid1.Item(3, WhatRowSensors).Value = _
                            DECODE_DATA_C1_SENSORS_UNIT_TYPE(REGISTERS_UNIT_TYPE(K), 0)                         'UNIT 1
                        frmC1Sensors.Grid1.Item(4, WhatRowSensors).Value = _
                            DECODE_DATA_C1_SENSORS(REGISTERS_SCALE_TYPE(K, 0), "&H" & _
                            Left(DATA_FILTERED_RECEIVED, 2), "&H" & Mid(DATA_FILTERED_RECEIVED, 3, 2), 1)       'SCALE 2
                        frmC1Sensors.Grid1.Item(5, WhatRowSensors).Value = _
                            DECODE_DATA_C1_SENSORS_UNIT_TYPE(REGISTERS_UNIT_TYPE(K), 1)                         'UNIT 2

                        Value = DECODE_DATA_C1_SENSORS(REGISTERS_SCALE_TYPE(K, 0), "&H" & _
                            Left(DATA_FILTERED_RECEIVED, 2), "&H" & Mid(DATA_FILTERED_RECEIVED, 3, 2), 0)       'MIN SCALE 1
                        If frmC1Sensors.Grid1.Item(6, WhatRowSensors).Value <> "" Then
                            If Val(Value) < Val(frmC1Sensors.Grid1.Item(6, WhatRowSensors).Value) Then
                                frmC1Sensors.Grid1.Item(6, WhatRowSensors).Value = Value
                                frmC1Sensors.Grid1.Item(7, WhatRowSensors).Value = _
                                    DECODE_DATA_C1_SENSORS_UNIT_TYPE(REGISTERS_UNIT_TYPE(K), 0)                 'MIN UNIT 1
                            End If
                        Else
                            frmC1Sensors.Grid1.Item(6, WhatRowSensors).Value = Value
                            frmC1Sensors.Grid1.Item(7, WhatRowSensors).Value = _
                                DECODE_DATA_C1_SENSORS_UNIT_TYPE(REGISTERS_UNIT_TYPE(K), 0)                     'MIN UNIT 1
                        End If

                        If frmC1Sensors.Grid1.Item(8, WhatRowSensors).Value <> "" Then
                            If Val(Value) > Val(frmC1Sensors.Grid1.Item(8, WhatRowSensors).Value) Then          'MAX SCALE 1
                                frmC1Sensors.Grid1.Item(8, WhatRowSensors).Value = Value
                                frmC1Sensors.Grid1.Item(9, WhatRowSensors).Value = _
                                    DECODE_DATA_C1_SENSORS_UNIT_TYPE(REGISTERS_UNIT_TYPE(K), 0)                 'MAX UNIT 1
                            End If
                        Else
                            frmC1Sensors.Grid1.Item(8, WhatRowSensors).Value = Value
                            frmC1Sensors.Grid1.Item(9, WhatRowSensors).Value = _
                                DECODE_DATA_C1_SENSORS_UNIT_TYPE(REGISTERS_UNIT_TYPE(K), 0)                     'MAX UNIT 1
                        End If

                        'CLEAR FIRST 4 DATA BYTES FROM VARIABLE
                        DATA_FILTERED_RECEIVED = Mid(DATA_FILTERED_RECEIVED, 5)
                        WhatRowSensors = WhatRowSensors + 1
                    Else
                        '2 BYTE REGISTER TYPE
                        frmC1Sensors.Grid1.Item(2, WhatRowSensors).Value = _
                            DECODE_DATA_C1_SENSORS(REGISTERS_SCALE_TYPE(K, 0), 0, "&H" & _
                            Left(DATA_FILTERED_RECEIVED, 2), 0)                                                 'SCALE 1
                        frmC1Sensors.Grid1.Item(3, WhatRowSensors).Value = _
                            DECODE_DATA_C1_SENSORS_UNIT_TYPE(REGISTERS_UNIT_TYPE(K), 0)                         'UNIT 1
                        frmC1Sensors.Grid1.Item(4, WhatRowSensors).Value = _
                            DECODE_DATA_C1_SENSORS(REGISTERS_SCALE_TYPE(K, 0), 0, "&H" & _
                            Left(DATA_FILTERED_RECEIVED, 2), 1)                                                 'SCALE 2
                        frmC1Sensors.Grid1.Item(5, WhatRowSensors).Value = _
                            DECODE_DATA_C1_SENSORS_UNIT_TYPE(REGISTERS_UNIT_TYPE(K), 1)                         'UNIT 2

                        Value = DECODE_DATA_C1_SENSORS(REGISTERS_SCALE_TYPE(K, 0), 0, "&H" & _
                            Left(DATA_FILTERED_RECEIVED, 2), 0)                                                 'SCALE 1 MIN
                        If frmC1Sensors.Grid1.Item(6, WhatRowSensors).Value <> "" Then
                            If Val(Value) < Val(frmC1Sensors.Grid1.Item(6, WhatRowSensors).Value) Then
                                frmC1Sensors.Grid1.Item(6, WhatRowSensors).Value = Value
                                frmC1Sensors.Grid1.Item(7, WhatRowSensors).Value = _
                                    DECODE_DATA_C1_SENSORS_UNIT_TYPE(REGISTERS_UNIT_TYPE(K), 0)                 'UNIT 1
                            End If
                        Else
                            frmC1Sensors.Grid1.Item(6, WhatRowSensors).Value = Value
                            frmC1Sensors.Grid1.Item(7, WhatRowSensors).Value = _
                                DECODE_DATA_C1_SENSORS_UNIT_TYPE(REGISTERS_UNIT_TYPE(K), 0)                     'UNIT 1
                        End If

                        If frmC1Sensors.Grid1.Item(8, WhatRowSensors).Value <> "" Then
                            If Val(Value) > Val(frmC1Sensors.Grid1.Item(8, WhatRowSensors).Value) Then          'SCALE 1 MAX
                                frmC1Sensors.Grid1.Item(8, WhatRowSensors).Value = Value
                                frmC1Sensors.Grid1.Item(9, WhatRowSensors).Value = _
                                    DECODE_DATA_C1_SENSORS_UNIT_TYPE(REGISTERS_UNIT_TYPE(K), 0)                 'UNIT 1
                            End If
                        Else
                            frmC1Sensors.Grid1.Item(8, WhatRowSensors).Value = Value
                            frmC1Sensors.Grid1.Item(9, WhatRowSensors).Value = _
                                DECODE_DATA_C1_SENSORS_UNIT_TYPE(REGISTERS_UNIT_TYPE(K), 0)                     'UNIT 1
                        End If

                        'CLEAR FIRST 2 DATA BYTES FROM VARIABLE
                        DATA_FILTERED_RECEIVED = Mid(DATA_FILTERED_RECEIVED, 3)
                        WhatRowSensors = WhatRowSensors + 1
                    End If
                End If
            End If
        Next K
    End Sub

    Function DECODE_DATA_C1_DIGITAL(ByVal ScaleType As Integer, ByVal BitIsTrue As Boolean) As String
        DECODE_DATA_C1_DIGITAL = ""
        Select Case ScaleType
            Case 0
                If BitIsTrue Then
                    DECODE_DATA_C1_DIGITAL = "ON"                                         'BIT 1 = ON 
                Else
                    DECODE_DATA_C1_DIGITAL = "OFF"                                        'BIT 0 = OFF
                End If
            Case 1
                If BitIsTrue Then
                    DECODE_DATA_C1_DIGITAL = "OFF"                                        'BIT 1 = OFF 
                Else
                    DECODE_DATA_C1_DIGITAL = "ON"                                         'BIT 0 = ON
                End If
            Case 2
                If BitIsTrue Then
                    DECODE_DATA_C1_DIGITAL = "RICH"                                       'BIT 1 = RICH
                Else
                    DECODE_DATA_C1_DIGITAL = "LEAN"                                       'BIT 0 = LEAN
                End If
            Case 3
                If BitIsTrue Then
                    DECODE_DATA_C1_DIGITAL = "LEAN"                                       'BIT 1 = LEAN 
                Else
                    DECODE_DATA_C1_DIGITAL = "RICH"                                       'BIT 0 = RICH
                End If

        End Select
    End Function

    Function DECODE_DATA_C1_SENSORS_UNIT_TYPE(ByVal ScaleType As Integer, ByVal Units As Integer) As String
        DECODE_DATA_C1_SENSORS_UNIT_TYPE = ""
        Select Case ScaleType
            Case 0 : If Units = 0 Then DECODE_DATA_C1_SENSORS_UNIT_TYPE = ""
            Case 1 : If Units = 0 Then DECODE_DATA_C1_SENSORS_UNIT_TYPE = "V"
            Case 2 : If Units = 0 Then DECODE_DATA_C1_SENSORS_UNIT_TYPE = "mS"
            Case 3 : If Units = 0 Then DECODE_DATA_C1_SENSORS_UNIT_TYPE = "%"
            Case 4 : If Units = 0 Then DECODE_DATA_C1_SENSORS_UNIT_TYPE = "°"
            Case 5
                If Units = 0 Then
                    DECODE_DATA_C1_SENSORS_UNIT_TYPE = "°C"
                Else
                    DECODE_DATA_C1_SENSORS_UNIT_TYPE = "°F"
                End If
            Case 6
                If Units = 0 Then
                    DECODE_DATA_C1_SENSORS_UNIT_TYPE = "KM/H"
                Else
                    DECODE_DATA_C1_SENSORS_UNIT_TYPE = "MPH"
                End If
            Case 7 : If Units = 0 Then DECODE_DATA_C1_SENSORS_UNIT_TYPE = "Steps"
        End Select
    End Function

    Function DECODE_DATA_C1_SENSORS(ByVal ScaleType As Integer, ByVal MSB As Byte, ByVal LSB As Byte, ByVal Units As Integer) As String
        DECODE_DATA_C1_SENSORS = ""
        Select Case ScaleType                                                                           '---THESE ARE MOST COMMON TYPES---
            Case 0 : If Units = 0 Then DECODE_DATA_C1_SENSORS = Format((MSB * 256 + LSB) * 12.5, "0") '.........RPM
            Case 1 : If Units = 0 Then DECODE_DATA_C1_SENSORS = Format((MSB * 256 + LSB) * 8, "0") '............CAS RPM
            Case 2 : If Units = 0 Then DECODE_DATA_C1_SENSORS = Format((MSB * 256 + LSB) * 0.005, "0.00") '......MAF VOLTAGE Volts
            Case 3
                If Units = 0 Then
                    DECODE_DATA_C1_SENSORS = Format(LSB - 50, "0")                                             'COOLANT,FUEL,INTAKE CELCIUS
                Else
                    DECODE_DATA_C1_SENSORS = Format((LSB - 50) * 1.8 + 32, "0")                                'COOLANT,FUEL,INTAKE CELCIUS
                End If
            Case 4 : If Units = 0 Then DECODE_DATA_C1_SENSORS = Format(LSB * 0.01, "0.000") '...................O2 SENSOR Volts
            Case 5 : If Units = 0 Then DECODE_DATA_C1_SENSORS = Format(LSB * 0.08, "0.00") '....................BATTERY Volts
            Case 6 : If Units = 0 Then DECODE_DATA_C1_SENSORS = Format(LSB * 0.02, "0.00") '....................TPS, EXHAUST GAS Volts
            Case 7 : If Units = 0 Then DECODE_DATA_C1_SENSORS = Format((MSB * 256 + LSB) * 0.02, "0.00") '......FUEL INJECTION mS
            Case 8 : If Units = 0 Then DECODE_DATA_C1_SENSORS = Format(LSB * 0.05, "0.0") '.....................AAC %
            Case 9 : If Units = 0 Then DECODE_DATA_C1_SENSORS = Format(LSB, "0") '..............................ALPHA SELF LEARN
            Case 10
                If Units = 0 Then
                    DECODE_DATA_C1_SENSORS = Format(LSB * 2, "0")                                               'SPEED
                Else
                    DECODE_DATA_C1_SENSORS = Format((LSB * 2) * 0.621, "0")                                     'SPEED
                End If

            Case 11 : If Units = 0 Then DECODE_DATA_C1_SENSORS = Format(110 - LSB, "0") '.......................IGNITION TIMING
            Case 12 : If Units = 0 Then DECODE_DATA_C1_SENSORS = Format(80 - LSB, "0") '........................IGNITION TIMING
            Case 13 : If Units = 0 Then DECODE_DATA_C1_SENSORS = Format(70 - LSB, "0") '........................IGNITION TIMING
            Case 14 : If Units = 0 Then DECODE_DATA_C1_SENSORS = Format(LSB * 0.5, "0.0") '.....................AAC VALVE %
            Case 15 : If Units = 0 Then DECODE_DATA_C1_SENSORS = Format(LSB * 0.04, "0.00")

            Case 16 : If Units = 0 Then DECODE_DATA_C1_SENSORS = Format(LSB * 32, "0")
            Case 17 : If Units = 0 Then DECODE_DATA_C1_SENSORS = Format(LSB * 0.64, "0.0")
            Case 18 : If Units = 0 Then DECODE_DATA_C1_SENSORS = Format(LSB / 2.55, "0.0")
            Case 19
                If Units = 0 Then
                    Select Case LSB
                        Case 128 : DECODE_DATA_C1_SENSORS = "D"
                        Case 129 : DECODE_DATA_C1_SENSORS = "2"
                        Case 130 : DECODE_DATA_C1_SENSORS = "1"
                        Case 131 : DECODE_DATA_C1_SENSORS = "P/N"
                        Case 135 : DECODE_DATA_C1_SENSORS = "R"
                    End Select
                End If
            Case 20
                If Units = 0 Then
                    DECODE_DATA_C1_SENSORS = Format(LSB, "0")
                Else
                    DECODE_DATA_C1_SENSORS = Format((LSB) * 0.621, "0")
                End If
            Case 21 : If Units = 0 Then DECODE_DATA_C1_SENSORS = Format(LSB + 1, "0")
        End Select
    End Function

    Public Sub RESET_GRID_STYLE_FOR_SENSORS()
        frmC1Sensors.MdiParent = frmMain : frmC1Sensors.Show() : frmC1Sensors.Grid1.Rows.Clear()

        Dim X As Integer
        For X = START_BYTE_FOR_SENSOR To END_BYTE_FOR_SENSOR
            Dim D As String : D = Hex(X) : If Len(D) = 1 Then D = "0" & D
            If SELECTED_REGISTERS(X) = True Then
                If SUPPORTED_REGISTERS(X, 0, 1) = False Then
                    'ANALOG SENSORS
                    'NO MSB/LSB TYPE, WHICH WILL DUPLICATE NAME
                    If SUPPORTED_REGISTERS(X, 1, 0) = False Then
                        frmC1Sensors.Grid1.RowCount = frmC1Sensors.Grid1.RowCount + 1
                        frmC1Sensors.Grid1.Item(1, frmC1Sensors.Grid1.RowCount - 1).Value = REGISTERS_NAME(X, 0)
                        frmC1Sensors.Grid1.Item(1, frmC1Sensors.Grid1.RowCount - 1).Tag = D
                    End If
                End If
            End If
        Next
    End Sub

    Public Sub RESET_GRID_STYLE_FOR_OUTPUT()
        frmC1Output.MdiParent = frmMain : frmC1Output.Show() : frmC1Output.Grid2.Rows.Clear()

        Dim X As Integer
        For X = START_BYTE_FOR_SENSOR To END_BYTE_FOR_SENSOR
            Dim D As String : D = Hex(X) : If Len(D) = 1 Then D = "0" & D
            'DIGITAL OUPUT
            If SELECTED_REGISTERS(X) = True Then
                If SUPPORTED_REGISTERS(X, 0, 1) = True Then
                    Dim J As Integer
                    For J = 0 To 7
                        If REGISTERS_NAME(X, J + 1) <> "" Then
                            frmC1Output.Grid2.RowCount = frmC1Output.Grid2.RowCount + 1
                            frmC1Output.Grid2.Item(1, frmC1Output.Grid2.RowCount - 1).Value = REGISTERS_NAME(X, J + 1)
                            frmC1Output.Grid2.Item(0, frmC1Output.Grid2.RowCount - 1).Tag = D & J
                        End If
                    Next J
                End If
            End If
        Next
    End Sub

    Public Sub RESET_GRID_STYLE_FOR_ACTIVE()
        Dim X As Integer
        For X = START_BYTE_FOR_ACTIVETEST To END_BYTE_FOR_ACTIVETEST
            CBO_ACTIVE_BINDING(X) = New BindingSource
        Next

        frmC1ActiveTest.MdiParent = frmMain : frmC1ActiveTest.Show() : frmC1ActiveTest.Grid2.Rows.Clear()

        For X = START_BYTE_FOR_ACTIVETEST To END_BYTE_FOR_ACTIVETEST
            Dim D As String : D = Hex(X) : If Len(D) = 1 Then D = "0" & D
            'ACTIVE TEST
            If SELECTED_REGISTERS(X) = True Then
                If SUPPORTED_REGISTERS(X, 0, 2) = True Then
                    frmC1ActiveTest.Grid2.RowCount = frmC1ActiveTest.Grid2.RowCount + 1
                    frmC1ActiveTest.Grid2.Item(1, frmC1ActiveTest.Grid2.RowCount - 1).Value = REGISTERS_NAME(X, 0)
                    frmC1ActiveTest.Grid2.Item(1, frmC1ActiveTest.Grid2.RowCount - 1).Tag = D
                    KeyName(0) = D
                    KeyValues(0) = ""
                    READINIFILE(LST_VEHICLE_FILE, "ACTIVE TEST REGISTER SCALE TYPE", KeyName, KeyValues)

                    Dim G As Integer
                    Dim StoreData As String = ""
                    Dim Data As String = ""
                    For G = 1 To Len(KeyValues(0))
                        Data = Mid(KeyValues(0), G, 1)
                        'RETRIEVES SCALE BYTES SEPERATED BY COMMA
                        If Data = "," Then
                            CBO_ACTIVE_BINDING(X).Add(StoreData)
                            StoreData = ""
                        ElseIf Data = "-" Then
                            'RETRIEVES SCALE BYTES SPECIFIED BY MINIMUM TO MAXIMUM
                            Dim StartValue As String
                            Dim EndValue As String
                            StartValue = StoreData
                            EndValue = Mid(KeyValues(0), G + 1)
                            Dim J As Integer
                            For J = Val(StartValue) To Val(EndValue)
                                CBO_ACTIVE_BINDING(X).Add(J)
                            Next
                        Else
                            StoreData = StoreData & Data
                        End If
                    Next
                End If
            End If
        Next X

        'ENABLE/DISBLE BUTTONS THAT ARE NECESSARY
        If frmC1ActiveTest.Grid2.RowCount > 0 Then
            frmC1ActiveTest.cmdGo.Enabled = True : frmC1ActiveTest.cmdStop.Enabled = False
        Else
            frmC1ActiveTest.cmdGo.Enabled = False : frmC1ActiveTest.cmdStop.Enabled = False
        End If
    End Sub

    Public Sub GET_FILE_VEHICLE_INFO(ByVal FileName As String)
        Dim KeyValues1(7) As String
        Dim keyname1(7) As String

        'VEHICLE INFO VARIABLES
        keyname1(0) = "YEAR"
        keyname1(1) = "MAKE"
        keyname1(2) = "MODEL"
        keyname1(3) = "NUMBER OF CYLINDERS"
        keyname1(4) = "ENGINE SIZE LITERS"
        keyname1(5) = "ECU ID"
        keyname1(6) = "MODULE"
        keyname1(7) = "AUTOSCAN"
        READINIFILE(FileName, "VEHICLE INFO", keyname1, KeyValues1)

        'ADD VEHICLE INFO VALUES AT THE TREEVIEW
        Dim X As Integer
        For X = 0 To 7
            frmConnect.trvVehicleInfo.Nodes.Add(keyname1(X)).Nodes.Add(KeyValues1(X)).ForeColor = Color.Blue
        Next X

        'STORE VEHICLE INFO IN VARIABLES
        VEHICLE_YEAR = KeyValues1(0)
        VEHICLE_MAKE = KeyValues1(1)
        VEHICLE_MODEL = KeyValues1(2)
        VEHICLE_CYLINDERS = KeyValues1(3)
        VEHICLE_ENGINE_LITER = KeyValues1(4)
        ECU_ID_3 = "&H" & KeyValues1(5)
        VEHICLE_MODULE = KeyValues1(6)
        AUTOSCAN = KeyValues1(7)
    End Sub

    Public Sub GET_FILE_REGISTERS_INFO(ByVal FileName As String)
        Dim KeyValues1(10) As String
        Dim keyname1(10) As String

        'REGISTER INFO VARIABLES
        keyname1(0) = "START BYTE FOR SENSOR"                               'LOWEST REGISTER BYTE SUPPORTED FOR SENSOR
        keyname1(1) = "END BYTE FOR SENSOR"                                 'HIGHEST REGISTER BYTE SUPPORTED FOR SENSOR
        keyname1(2) = "START BYTE FOR ACTIVE TEST"                          'LOWEST REGISTER BYTE SUPPORTED FOR ACTIVE TEST
        keyname1(3) = "END BYTE FOR ACTIVE TEST"                            'HIGHEST REGISTER BYTE SUPPORTED FOR ACTIVE TEST
        keyname1(4) = "MAX REGISTERS ALLOWED"
        keyname1(5) = "CHECK FAULT COMMAND"
        keyname1(6) = "CLEAR FAULT COMMAND"
        keyname1(7) = "ECU INFO COMMAND"
        keyname1(8) = "STREAM AVAILABLE SENSOR COMMAND"
        keyname1(9) = "INTERBYTE DELAY"
        keyname1(10) = "TIMEOUT"
        READINIFILE(FileName, "REGISTERS INFO", keyname1, KeyValues1)

        START_BYTE_FOR_SENSOR = KeyValues1(0)
        END_BYTE_FOR_SENSOR = KeyValues1(1)
        START_BYTE_FOR_ACTIVETEST = KeyValues1(2)
        END_BYTE_FOR_ACTIVETEST = KeyValues1(3)
        MAX_PIDS_ALLOWED = Val(KeyValues1(4))
        SEND_CHECK_FAULTS_BYTE = KeyValues1(5)
        SEND_CLEAR_FAULTS_BYTE = KeyValues1(6)
        SEND_ECU_INFO_BYTE = KeyValues1(7)
        SEND_STREAM_AVAILABLE_SENSOR_BYTE = KeyValues1(8)
        INTERBYTE_DELAY = Val(KeyValues1(9))
        TIME_OUT = Val(KeyValues1(10))
    End Sub

    Public Sub GET_FILE_REGISTER_PARAMETERS(ByVal FileName As String)
        'THIS IS WHERE WE FLAG THE SUPPORTED REGISTERS BY USING THE FILE (INI FORMAT AT THIS MOMENT.  SUBJECT TO CHANGE IN FUTURE.  MAYBE XML)
        Dim J As Integer
        Dim x As Integer

        'RESET
        For x = 0 To 255
            SELECTED_REGISTERS(X) = False                                                               'RESET SELECTED REGISTERS
            SUPPORTED_REGISTERS(x, 0, 0) = False                                                        'RESET REGISTER SUPPORTED ARRAYS
            SUPPORTED_REGISTERS(x, 0, 1) = False                                                        'RESET DIGITAL OUTPUT SUPPORTED ARRAY
            SUPPORTED_REGISTERS(x, 1, 0) = False                                                        'RESET LSB ARRAY
            SUPPORTED_REGISTERS(x, 0, 2) = False                                                        'RESET ACTIVE TEST ARRAY
        Next

        'SENSOR REGISTER AND SCALE TYPES (INCLUDING DIGITAL OUTPUT(ON/OFF) (0X00 TO 0X32 MOST COMMON, SOME ABOVE 0X32 ON LATE MODELS)
        For x = START_BYTE_FOR_SENSOR To END_BYTE_FOR_SENSOR
            KeyName(0) = Hex(x)
            KeyValues(0) = ""
            READINIFILE(FileName, "SENSOR REGISTERS SUPPORTED NAMES", KeyName, KeyValues)               'READ SENSOR REGISTER NAMES
            Select Case UCase(KeyValues(0))
                Case ""
                Case "DIGITAL OUTPUT"                                                                   'DIGITAL OUTPUT(ON/OFF) TYPE
                    REGISTERS_NAME(x, 0) = KeyValues(0)                                                 'REGISTER NAME
                    SUPPORTED_REGISTERS(x, 0, 1) = True                                                 'FLAG DIGITAL OUTPUT TYPE SUPPORTED
                    SUPPORTED_REGISTERS(x, 0, 0) = True                                                 'FLAG REGISTER SUPPORTED
                    For J = 0 To 7
                        KeyName(0) = Hex(x) & "b" & J
                        KeyValues(0) = ""
                        READINIFILE(FileName, "DIGITAL OUTPUT NAMES", KeyName, KeyValues)               'READ DIGITAL OUTPUT NAMES
                        If UCase(KeyValues(0)) <> "" Then
                            REGISTERS_NAME(x, J + 1) = KeyValues(0)
                        End If
                    Next J
                    For J = 0 To 7
                        KeyName(0) = Hex(x) & "b" & J
                        KeyValues(0) = ""

                        READINIFILE(FileName, "DIGITAL OUTPUT SCALE TYPE", KeyName, KeyValues)          'READ DIGITAL OUTPUT SCALE TYPE
                        If UCase(KeyValues(0)) <> "" Then
                            REGISTERS_SCALE_TYPE(x, J) = KeyValues(0)
                        End If
                    Next J
                Case "<>"                                                                               'SENSOR REGISTER TYPE (4 BYTE TYPE MSB AND LSB)
                    SUPPORTED_REGISTERS(x, 0, 0) = True                                                 'FLAG REGISTER SUPPORTED
                    SUPPORTED_REGISTERS(x, 1, 0) = True                                                 'FLAG MSB/LSB TYPE
                Case Else                                                                               'SENSOR REGISTER TYPE (2 BYTE)
                    REGISTERS_NAME(x, 0) = KeyValues(0)
                    SUPPORTED_REGISTERS(x, 0, 0) = True                                                 'FLAG SENSOR REGISTER SUPPORTED
                    KeyValues(0) = ""
                    READINIFILE(FileName, "SENSORS REGISTERS SCALE TYPE", KeyName, KeyValues)           'READ SENSOR SCALE TYPE
                    If KeyValues(0) <> "" Then
                        REGISTERS_SCALE_TYPE(x, 0) = KeyValues(0)
                    End If
                    KeyValues(0) = ""
                    READINIFILE(FileName, "SENSORS REGISTERS UNIT TYPE", KeyName, KeyValues)            'READ SENSOR UNIT TYPE
                    If KeyValues(0) <> "" Then
                        REGISTERS_UNIT_TYPE(x) = KeyValues(0)
                    End If
            End Select

        Next x

        'ACTIVE TEST AND SCALE TYPES (ABOVE 0X80 MOST COMMON)
        For x = START_BYTE_FOR_ACTIVETEST To END_BYTE_FOR_ACTIVETEST
            KeyName(0) = Hex(x)
            KeyValues(0) = ""
            READINIFILE(FileName, "ACTIVE TEST SUPPORTED NAMES", KeyName, KeyValues)                    'READ ACTIVE TEST
            Select Case UCase(KeyValues(0))
                Case ""
                Case Else
                    REGISTERS_NAME(x, 0) = KeyValues(0)
                    SUPPORTED_REGISTERS(x, 0, 2) = True                                                 'FLAG ACTIVE TEST TYPE
                    SUPPORTED_REGISTERS(x, 0, 0) = True                                                 'FLAG REGISTER SUPPORTED
                    KeyValues(0) = ""
                    READINIFILE(FileName, "ACTIVE TEST REGISTER SCALE TYPE", KeyName, KeyValues)        'READ ACTIVE TEST UNIT TYPE
                    If KeyValues(0) <> "" Then
                        REGISTERS_SCALE_TYPE(x, 0) = KeyValues(0)
                    End If
            End Select
        Next
    End Sub

    Public Sub READINIFILE(ByVal INIPath As String, _
                             ByVal SectionName As String, ByVal KeyName As String(), _
                             ByRef KeyValue As String())
        Dim Length As Integer
        Dim strData As String
        strData = Space$(1024)

        For i As Integer = 0 To KeyName.Length - 1
            If KeyName(i) <> "" Then
                Length = GetPrivateProfileString(SectionName, KeyName(i), KeyValue(i), _
                                                 strData, strData.Length, LTrim(RTrim((INIPath))))
                If Length > 0 Then
                    KeyValue(i) = strData.Substring(0, Length)
                Else
                    KeyValue(i) = ""
                End If
            End If
        Next
    End Sub

    Public Sub WRITEINIFILE(ByVal INIPath As String, _
                              ByVal SectionName As String, ByVal KeyName As String, _
                              ByVal KeyValue As String)

        WritePrivateProfileString(SectionName, KeyName, KeyValue, INIPath)
    End Sub

    Public Sub SEARCH_SERIAL_PORTS()
        Dim comPorts As Array = IO.Ports.SerialPort.GetPortNames()

        'SEARCH PORT AND FILL COMBOBOX
        For i = 0 To UBound(comPorts)
            frmMain.tsComPort.Items.Add(comPorts(i))
        Next

        'GET PORT FROM REGISTRY
        frmMain.tsComPort.Text = My.Settings.PreferredPort
    End Sub

    Public Sub RESET_VARIABLES()
        DATA_FILTERED_RECEIVED = "" : IN_BUFFER_BYTE = "" : FF_BYTE_DETECTOR = False : REGISTER_DATA_ONLY = False
    End Sub
    Public Sub CLOSE_C1_FORMS()
        'RESET 
        USER_REQUEST_STOP = True : LOOP_IN_PROGRESS = False : frmMain.tmrTimeout.Enabled = False

        'IF NOT "" THEN LOG RECORDING WAS PERFORMED.  ASK SAVE FILE
        If LOG_BUTTONS_STATUS <> "" Then LOG_SAVE_FILE()

        'RESET 
        LOG_BUTTONS_STATUS = "" : frmMain.tsStatus.Text = "" : frmMain.tsStatus2.Text = "" : frmMain.tsStatus3.Text = ""

        'CLOSE THE FORMS
        frmC1Output.Close() : frmC1Sensors.Close() : frmC1ActiveTest.Close() : frmRegSelection.Close() : frmC1Faults.Close()

        'DO THIS ONLY IF DISCONNECT BUTTON CLICKED
        If frmMain.Tag = "Disconnect" Then
            ENABLE_STATE_FOR_MENUS(1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1)
            ENABLE_STATE_FOR_INSPECTOR(0, 0, 0, 0, 0, 0, 1)
            frmMain.Tag = ""
        End If
    End Sub

    Public Sub SAVE_WINDOW_FORM_STATE(ByVal Form As Object)
        'SAVE FORM POSITION
        SaveSetting("Consult1", Form.Name, "Top Position", Form.Top)
        SaveSetting("Consult1", Form.Name, "Left Position", Form.Left)
        SaveSetting("Consult1", Form.Name, "Form Width", Form.Width)
        SaveSetting("Consult1", Form.Name, "Form Height", Form.Height)
        SaveSetting("Consult1", Form.Name, "Window State", Form.WindowState)
    End Sub

    Public Sub LOAD_WINDOW_FORM_STATE(ByVal Form As Object, ByVal TopDefault As Integer, ByVal LeftDefault As Integer, ByVal WidthDefault As Integer, ByVal HeightDefault As Integer)
        'LOAD FORM POSITION
        Form.Top = GetSetting("Consult1", Form.Name, "Top Position", TopDefault)
        Form.Left = GetSetting("Consult1", Form.Name, "Left Position", LeftDefault)
        Form.Width = GetSetting("Consult1", Form.Name, "Form Width", WidthDefault)
        Form.Height = GetSetting("Consult1", Form.Name, "Form Height", HeightDefault)
        Form.WindowState = GetSetting("Consult1", Form.Name, "Window State", 0)
    End Sub
    Public Sub ENABLE_STATE_FOR_INSPECTOR(ByVal LogRecord As Integer, ByVal LogPause As Integer, ByVal LogPlay As Integer, ByVal LogStop As Integer, ByVal LogBackward As Integer, ByVal LogForward As Integer, ByVal LogOpen As Integer)
        '0=FALSE: 1=TRUE: 2=SKIP
        If LogRecord <> 2 Then frmMain.tsRecord.Enabled = LogRecord
        If LogPause <> 2 Then frmMain.tsPause.Enabled = LogPause
        If LogPlay <> 2 Then frmMain.tsPlay.Enabled = LogPlay
        If LogStop <> 2 Then frmMain.tsStop.Enabled = LogStop
        If LogBackward <> 2 Then frmMain.tsFastBackward.Enabled = LogBackward
        If LogForward <> 2 Then frmMain.tsFastForward.Enabled = LogForward
        If LogForward <> 2 Then frmMain.tsOpen.Enabled = LogOpen
    End Sub
    Public Sub ENABLE_STATE_FOR_MENUS(ByVal MenuConnect As Boolean, ByVal MenuDisconnect As Boolean, ByVal MenuSelfDiag As Boolean, _
                    ByVal MenuAlert As Boolean, ByVal MenuGrid As Boolean, ByVal MenuGauges As Boolean, _
                    ByVal MenuGraphing As Boolean, ByVal MenuDetectReg As Boolean, ByVal MenuDetectECU As Boolean, _
                    ByVal MenuDecodeReg As Boolean, ByVal tbConnect As Boolean, ByVal tbDisconnect As Boolean, _
                    ByVal MenuMonitorManager As Boolean, ByVal MenuSpeedTrial As Boolean, ByVal MenuDyno As Boolean, ByVal MenuProfile As Boolean)

        frmMain.ConnectToolStripMenuItem.Enabled = MenuConnect
        frmMain.DisconnectToolStripMenuItem.Enabled = MenuDisconnect
        frmMain.DiagnosticFaultsToolStripMenuItem.Enabled = MenuSelfDiag
        frmMain.AlertMonitoringSystemToolStripMenuItem.Enabled = MenuAlert
        frmMain.GridStyleToolStripMenuItem.Enabled = MenuGrid
        frmMain.GaugesToolStripMenuItem.Enabled = MenuGauges
        frmMain.GraphingToolStripMenuItem.Enabled = MenuGraphing
        frmMain.RegisterTest.Enabled = MenuDetectReg
        frmMain.ConductECUTestToolStripMenuItem.Enabled = MenuDetectECU
        frmMain.RegisterDecoderToolStripMenuItem.Enabled = MenuDecodeReg
        frmMain.tbConnect.Enabled = tbConnect
        frmMain.tbDisconnect.Enabled = tbDisconnect
        frmMain.MonitorManagerToolStripMenuItem.Enabled = MenuMonitorManager
        frmMain.SpeedTrialToolStripMenuItem.Enabled = MenuSpeedTrial
        frmMain.RoadDynoToolStripMenuItem.Enabled = MenuDyno
        frmMain.CreateECUProfileToolStripMenuItem.Enabled = MenuProfile
    End Sub
    Public Sub LOG_OPEN_FILE()
        'OPEN FILE DIALOG DEFAULTS
        frmMain.OpenFileDialog1.InitialDirectory = Application.StartupPath & "\Logs"
        frmMain.OpenFileDialog1.Filter = "C1 log files (*.c1log)|*.c1log|All files (*.*)|*.*"
        frmMain.OpenFileDialog1.FilterIndex = 1
        frmMain.OpenFileDialog1.RestoreDirectory = True
        FileClose(1)

        If frmMain.OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            FileOpen(1, frmMain.OpenFileDialog1.FileName, OpenMode.Binary)
            FileGetObject(1, TOTAL_RECORD_FRAME, 2502 * 100)
            FileGetObject(1, START_BYTE_FOR_SENSOR, 2510 * 100)
            FileGetObject(1, END_BYTE_FOR_SENSOR, 2511 * 100)
            frmMain.tsStatus2.Text = "0 of " & TOTAL_RECORD_FRAME
            RECORD_NUMBER = 3001
            LOG_GET_SUPPORTED_REGISTERS()
        End If
    End Sub
    Public Sub LOG_GET_SUPPORTED_REGISTERS()
        Dim x As Integer

        'RESET
        For x = 0 To 255
            SELECTED_REGISTERS(x) = False                                                               'RESET SELECTED REGISTERS
            SUPPORTED_REGISTERS(x, 0, 0) = False                                                        'RESET REGISTER SUPPORTED ARRAYS
            SUPPORTED_REGISTERS(x, 0, 1) = False                                                        'RESET DIGITAL OUTPUT SUPPORTED ARRAY
            SUPPORTED_REGISTERS(x, 1, 0) = False                                                        'RESET LSB ARRAY
            SUPPORTED_REGISTERS(x, 0, 2) = False                                                        'RESET ACTIVE TEST ARRAY
        Next

        Dim Value As String
        For x = 1 To 2000

            FileGetObject(1, Value, x * 100)
            If Value <> "" Then

                Dim RegAddr As String = CByte("&H" & Left(Value, 2))
                Dim LSBMSB As String = Mid(Value, 3, 2)
                Dim BitValue As String = Mid(Value, 5, 2)
                Dim ScaleValue As String = Mid(Value, 7, 2)
                Dim UnitValue As String = Mid(Value, 9, 2)

                If Value <> "" Then
                    REGISTERS_NAME(RegAddr, 0) = Mid(Value, 12)                                                     'REGISTER NAME
                    SUPPORTED_REGISTERS(RegAddr, 0, 0) = True                                                       'REGISTER SUPPORTED
                    SELECTED_REGISTERS(RegAddr) = True
                    REGISTERS_SCALE_TYPE(RegAddr, 0) = ScaleValue
                    REGISTERS_UNIT_TYPE(RegAddr) = UnitValue

                    If LSBMSB = "11" Then
                        SUPPORTED_REGISTERS(RegAddr + 1, 0, 0) = True                                               'REGISTER SUPPORTED
                        SUPPORTED_REGISTERS(RegAddr + 1, 1, 0) = True '..............................................REGISTER LSB/MSB TYPE
                    ElseIf Left(BitValue, 1) = "b" Then
                        SUPPORTED_REGISTERS(RegAddr, 0, 1) = True                                                   'DIGITAL OUTPUT TYPE
                        REGISTERS_NAME(RegAddr, Right(BitValue, 1)) = Mid(Value, 12)
                        REGISTERS_SCALE_TYPE(RegAddr, Right(BitValue, 1)) = ScaleValue
                    End If
                End If
            End If
        Next
    End Sub
    Public Sub LOG_SAVE_FILE()
        Dim Value As String

        'WRITE THE FRAME RECORD COUNTER
        Value = RECORD_NUMBER - 3000
        FilePutObject(1, Value, 2502 * 100)         'FILE INFO: TOTAL FRAME RECORDS

        'CLOSE LOG FILE
        FileClose(1)

        'ASK USER SAVE LOG FILE
        Value = MsgBox("Do you want to save Untitled Log?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Save Log File")
        If Val(Value) = 6 Then
            'SAVE FILE DIALOG DEFAULTS
            frmMain.SaveFileDialog1.InitialDirectory = Application.StartupPath & "\Logs"
            frmMain.SaveFileDialog1.Filter = "C1 log files (*.c1log)|*.c1log|All files (*.*)|*.*"
            frmMain.SaveFileDialog1.FilterIndex = 1
            frmMain.SaveFileDialog1.RestoreDirectory = True

            'COPY UNTITLED FILE TO USER SPECIFIED LOCATION AND FILE NAME
            If frmMain.SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                FileIO.FileSystem.CopyFile(Application.StartupPath & "\Logs\Untitled.tmp", frmMain.SaveFileDialog1.FileName, True)
            End If
        End If
    End Sub

    Public Sub LOG_CREATE_FILE()
        'RECORD NUMBERS IN FILE
        '0001-2000 = REGISTER NAME SELECTED
        '2001-2500 = FUTURE RESERVED
        '2501-2600 = FILE INFO
        '2601-3000 = FUTURE RESERVED
        '3001-OVER = REGISTER DATA RESULT

        'DELETE UNTITLED FILE IF EXIST
        FileClose(1)
        If FileIO.FileSystem.FileExists(Application.StartupPath & "\Logs\Untitled.tmp") Then
            FileIO.FileSystem.DeleteFile(Application.StartupPath & "\Logs\Untitled.tmp")
        End If

        'WRITE FILE INFO TO THE RECORDS
        FileOpen(1, Application.StartupPath & "\Logs\Untitled.tmp", OpenMode.Binary)        'CREATE FILE UNTITLED.C1LOG
        FilePutObject(1, "ScantechNissanLogs", 2501 * 100)                                  'FILE INFO: FILE TYPE
        FilePutObject(1, VEHICLE_YEAR, 2503 * 100)                                          'FILE INFO: VEHICLE YEAR
        FilePutObject(1, VEHICLE_MAKE, 2504 * 100)                                          'FILE INFO: VEHICLE MAKE
        FilePutObject(1, VEHICLE_MODEL, 2505 * 100)                                         'FILE INFO: VEHICLE MODEL
        FilePutObject(1, VEHICLE_CYLINDERS, 2506 * 100)                                     'FILE INFO: # OF CYLINDERS
        FilePutObject(1, VEHICLE_ENGINE_LITER, 2507 * 100)                                  'FILE INFO: ENGINE LITERS
        FilePutObject(1, VEHICLE_MODULE, 2508 * 100)                                        'FILE INFO: ECU TYPE
        FilePutObject(1, "1.0", 2509 * 100)                                                 'FILE INFO: LOG VERSION
        FilePutObject(1, Str(START_BYTE_FOR_SENSOR), 2510 * 100)                            'START BYTE SENSOR
        FilePutObject(1, Str(END_BYTE_FOR_SENSOR), 2511 * 100)                              'END BYTE SENSOR
        FilePutObject(1, Str(START_BYTE_FOR_ACTIVETEST), 2512 * 100)                        'START BYTE ACTIVE
        FilePutObject(1, Str(END_BYTE_FOR_ACTIVETEST), 2513 * 100)                          'END BYTE ACTIVE
        RECORD_NUMBER = 3000                                                                'SET START RECORD NUMBER
        frmMain.tsStatus3.Text = "Untitled Log"                                             'TEMP FILE NAME

    End Sub
    Public Sub LOG_CREATE_SELECTED_REGISTERS_FILE(ByVal Record As Integer)
        'BYTE 1 TO 5 IDENTIFIERS
        'FIRST BYTE  - REGISTER BYTE ADDRESS
        'SECOND BYTE - LSB/MSB = 11 : LSB ONLY = XX
        'THIRD BYTE  - BITMAPPED = b? : NOT BITMAPPED = XX
        'FOURTH BYTE - SCALE TYPE
        'FIFTH BYTE  - UNIT TYPE
        'AFTER "SPACE" REGISTER NAME

        Dim ScaleValue As String
        Dim UnitValue As String
        Dim X As Integer
        For X = START_BYTE_FOR_SENSOR To END_BYTE_FOR_SENSOR
            Dim D As String : D = Hex(X) : If Len(D) = 1 Then D = "0" & D
            If SELECTED_REGISTERS(X) = True Then
                If SUPPORTED_REGISTERS(X, 0, 1) = False Then
                    'ANALOG SENSORS
                    If SUPPORTED_REGISTERS(X, 1, 0) = False Then
                        ScaleValue = REGISTERS_SCALE_TYPE(X, 0) : If Len(ScaleValue) = 1 Then ScaleValue = "0" & ScaleValue
                        UnitValue = REGISTERS_UNIT_TYPE(X) : If Len(UnitValue) = 1 Then UnitValue = "0" & UnitValue
                        If SUPPORTED_REGISTERS(X + 1, 1, 0) = True Then
                            FilePutObject(1, D & "11XX" & ScaleValue & UnitValue & " " & REGISTERS_NAME(X, 0), Record * 100) : Record = Record + 1 'LSB/MSB
                        Else
                            FilePutObject(1, D & "XXXX" & ScaleValue & UnitValue & " " & REGISTERS_NAME(X, 0), Record * 100) : Record = Record + 1 'LSB ONLY
                        End If
                    End If
                Else
                    'DIGITAL OUTPUT
                    Dim J As Integer
                    For J = 0 To 7
                        If REGISTERS_NAME(X, J + 1) <> "" Then
                            ScaleValue = REGISTERS_SCALE_TYPE(X, J) : If Len(ScaleValue) = 1 Then ScaleValue = "0" & ScaleValue
                            FilePutObject(1, D & "XXb" & J & ScaleValue & "XX " & REGISTERS_NAME(X, J + 1), Record * 100) : Record = Record + 1
                        End If
                    Next J
                End If
            End If
        Next
    End Sub
End Module
