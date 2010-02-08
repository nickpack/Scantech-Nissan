﻿Public Class frmRegSelection

    Private Sub frmRegSelection_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then ENABLE_MENUS()
    End Sub
    Private Sub frmRegSelection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CHECK_SUPPORTED_REGISTERS()
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Dim X As Integer

        'RESET
        For X = 0 To 255
            SELECTED_REGISTERS(X) = False
        Next
        TOTAL_SELECTED_REGISTERS = 0

        'FLAG THE SELECTED SENSOR REGISTERS
        For X = 0 To Me.Grid1.RowCount - 1
            If Me.Grid1.Item(0, X).Value = True Then                                                'IF CHECKED
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
            If Me.Grid2.Item(0, X).Value = True Then                                                'IF CHECKED
                Dim WhatTagValue1 As String
                WhatTagValue1 = Me.Grid2.Item(1, X).Tag                                             'IDENTIFIES WHAT REGISTER BYTE IS IT
                SELECTED_REGISTERS(WhatTagValue1) = True
            End If
        Next

        'WARN USER TOTAL REGISTERS SELECTED IS OVER LIMIT
        If TOTAL_SELECTED_REGISTERS >= MAX_PIDS_ALLOWED Then
            MsgBox("Total Sensor Registers has exceeded the total limit", MsgBoxStyle.Exclamation + _
                   MsgBoxStyle.OkOnly, "Maximum Registers Exceeded")
            Exit Sub
        ElseIf TOTAL_SELECTED_REGISTERS = 0 Then
            MsgBox("1 Minimun Sensor Registers has to be selected", MsgBoxStyle.Exclamation + _
                   MsgBoxStyle.OkOnly, "Minimun Register Required")
            Exit Sub
        End If

        Me.Hide()

        'MAKE SURE CONSULT 1 DATA QUERYING IS STOPPED
        frmMain.SerialPort1.Write(SEND_30_BYTE, 0, 1) : System.Threading.Thread.Sleep(INTERBYTE_DELAY)

        'CLEAR ANY BUFFER
        frmMain.SerialPort1.DiscardInBuffer()

        'WHICH FORM DID USER CLICK
        Select Case USER_FORM_SELECT
            Case 1 : RESET_GRID_STYLE_FOR_SENSORS() : RESET_GRID_STYLE_FOR_OUTPUT() : RESET_GRID_STYLE_FOR_ACTIVE()
        End Select

        'DISABLE MENU
        frmMain.tbEcuProfile.Enabled = False

        'START COMMUNICATION WITH ECM AND REQUEST DATA AND PROCESS THEM
        REQUEST_C1_SENSOR_DATA()

        'CLOSE ALL FORM RELATED
        CLOSE_C1_FORMS()

        'ENABLE NECESSARY MENUS
        ENABLE_MENUS()
        frmMain.tbEcuProfile.Enabled = True

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
            End If
        Next

    End Sub
    Private Sub Grid1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid1.CellClick
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