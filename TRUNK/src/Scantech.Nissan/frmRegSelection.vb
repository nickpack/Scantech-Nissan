Public Class frmRegSelection

    Private Sub frmRegSelection_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'ENABLE/DISABLE FRMMAIN MENU STATE
        ENABLE_STATE_FOR_MENUS(False, True, True, True, True, True, True, False, False, False, False, True, True, True, True, False)
    End Sub
    Private Sub frmRegSelection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ALL SENSORS AVAILABLE REQUEST COMMAND DOES NOT ALLOW SELECTIONS BEING MADE.  SET CHECK MARKS VISIBILITY FALSE
        If SEND_STREAM_AVAILABLE_SENSOR_BYTE <> "N/A" Then Me.Grid1.Columns(0).Visible = False

        'CHECK REGISTERS THAT ARE SUPPORTED
        CHECK_SUPPORTED_REGISTERS()

        'ENABLE/DISABLE FRMMAIN MENU STATE
        ENABLE_STATE_FOR_MENUS(False, True, False, False, False, False, False, False, False, False, False, True, False, False, False, False)
    End Sub

    Private Sub cmdApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdApply.Click
        'MONITOR MANAGER IS USABLE FOR SINGLE/MULTI BYTE COMMAND
        'MONITOR MANAGER IS NOT USABLE FOR AVAILABLE SENSOR REQUEST COMMAND.  TOTAL REGISTER WILL BE IGNORED FOR THIS TYPE
        Dim X As Integer

        'RESET
        For X = 0 To 255
            SELECTED_REGISTERS(X) = False
        Next
        TOTAL_SELECTED_REGISTERS = 0

        'FLAG THE SELECTED SENSOR REGISTERS
        For X = 0 To Me.Grid1.RowCount - 1
            If Me.Grid1.Item(0, X).Value = True Or SEND_STREAM_AVAILABLE_SENSOR_BYTE <> "N/A" Then  'IF CHECKED
                Dim WhatTagValue As String
                WhatTagValue = Me.Grid1.Item(1, X).Tag                                              'IDENTIFIES WHAT REGISTER BYTE IS IT
                TOTAL_SELECTED_REGISTERS = TOTAL_SELECTED_REGISTERS + 1                             'INCREASE SELECTED REGISTER COUNTER
                SELECTED_REGISTERS(WhatTagValue) = True
                If SUPPORTED_REGISTERS(WhatTagValue + 1, 1, 0) = True Then                          'IF BOTH TYPE (MSB/LSB)
                    SELECTED_REGISTERS(WhatTagValue + 1) = True
                    TOTAL_SELECTED_REGISTERS = TOTAL_SELECTED_REGISTERS + 1                         'INCREASE COUNTER AGAIN FOR BOTH TYPE
                End If
            End If
        Next

        'FLAG THE SELECTED ACTIVE TEST REGISTERS
        For X = 0 To Me.Grid2.RowCount - 1
            If Me.Grid2.Item(0, X).Value = True Or SEND_STREAM_AVAILABLE_SENSOR_BYTE <> "N/A" Then  'IF CHECKED
                Dim WhatTagValue1 As String
                WhatTagValue1 = Me.Grid2.Item(1, X).Tag                                             'IDENTIFIES WHAT REGISTER BYTE IS IT
                SELECTED_REGISTERS(WhatTagValue1) = True
            End If
        Next

        'WARN USER TOTAL REGISTERS SELECTED IS OVER LIMIT FOR SINGLE/MULTI BYTE REQUEST ONLY
        If SEND_STREAM_AVAILABLE_SENSOR_BYTE = "N/A" Then
            If TOTAL_SELECTED_REGISTERS > MAX_PIDS_ALLOWED Then
                MsgBox("Total Sensor Registers has exceeded the total limit", MsgBoxStyle.Exclamation + _
                       MsgBoxStyle.OkOnly, "Maximum Registers Exceeded")
                Exit Sub
            ElseIf TOTAL_SELECTED_REGISTERS = 0 Then
                MsgBox("1 Minimun Sensor Registers has to be selected", MsgBoxStyle.Exclamation + _
                       MsgBoxStyle.OkOnly, "Minimun Register Required")
                Exit Sub
            End If
        End If

        'MAKE SURE CONSULT 1 DATA QUERYING IS STOPPED
        frmMain.SerialPort1.Write(SEND_30_BYTE, 0, 1) : System.Threading.Thread.Sleep(INTERBYTE_DELAY)

        'CLEAR ANY BUFFER
        frmMain.SerialPort1.DiscardInBuffer()

        Me.Close()
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub CHECK_SUPPORTED_REGISTERS()
        Dim X As Integer

        'FILL IN GRID WITH AVAILABLE SENSOR SUPPORTED REGISTERS
        Me.Grid1.Rows.Clear()                                                                       'CLEAR SENSOR REGISTERS GRID
        For X = START_BYTE_FOR_SENSOR To END_BYTE_FOR_SENSOR
            If SUPPORTED_REGISTERS(X, 0, 0) = True Then                                             'SENSOR REGISTER SUPPORTED
                If SUPPORTED_REGISTERS(X, 1, 0) = False Then                                        'DOES NOT ADD DUPLICATE NAME (IF MSB/LSB TYPE)
                    Me.Grid1.RowCount = Me.Grid1.RowCount + 1
                    Me.Grid1.Item(1, Me.Grid1.RowCount - 1).Value = REGISTERS_NAME(X, 0)            '2 BYTE REGISTERS (LSB)
                    Me.Grid1.Item(1, Me.Grid1.RowCount - 1).Tag = X                                 '1 BYTE IDENTIFIER
                    If SELECTED_REGISTERS(X) = True Then                                            'LOAD SELECTED REGISTERS
                        Me.Grid1.Item(0, Me.Grid1.RowCount - 1).Value = True
                    End If
                End If
            End If
        Next

        'FILL IN GRID WITH AVAILABLE ACTIVE TEST SUPPORTED REGISTERS
        Me.Grid2.Rows.Clear()                                                                       'CLEAR ACTIVE TEST GRID
        For X = START_BYTE_FOR_ACTIVETEST To END_BYTE_FOR_ACTIVETEST
            If SUPPORTED_REGISTERS(X, 0, 2) = True Then                                             'ACTIVE TEST SUPPORTED
                Me.Grid2.RowCount = Me.Grid2.RowCount + 1
                Me.Grid2.Item(1, Me.Grid2.RowCount - 1).Value = REGISTERS_NAME(X, 0)
                Me.Grid2.Item(1, Me.Grid2.RowCount - 1).Tag = X
                If SELECTED_REGISTERS(X) = True Then                                                'LOAD SELECTED REGISTERS
                    Me.Grid2.Item(0, Me.Grid2.RowCount - 1).Value = True
                End If
            End If
        Next

    End Sub
    Private Sub Grid1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid1.CellClick
        '------------------------
        'ANALOG SENSOR SELECTIONS
        '------------------------
        'CHECK ALL
        If e.ColumnIndex = 0 And e.RowIndex = -1 Then
            Dim X As Integer
            For X = 0 To Me.Grid1.RowCount - 1
                Me.Grid1.Item(0, X).Value = True
            Next
            Exit Sub
        End If

        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub

        'CHECK/UNCHECK INDIVIDUALLY
        Me.Grid1.Item(0, e.RowIndex).Value = Not Me.Grid1.Item(0, e.RowIndex).Value
    End Sub
    Private Sub Grid2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid2.CellClick
        '-----------------------------
        'ACTIVE/OUTPUT TEST SELECTIONS
        '-----------------------------
        'CHECK ALL
        If e.ColumnIndex = 0 And e.RowIndex = -1 Then
            Dim X As Integer
            For X = 0 To Me.Grid2.RowCount - 1
                Me.Grid2.Item(0, X).Value = True
            Next
            Exit Sub
        End If

        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub

        'CHECK/UNCHECK INDIVIDUALLY
        Me.Grid2.Item(0, e.RowIndex).Value = Not Me.Grid2.Item(0, e.RowIndex).Value
    End Sub
End Class