Public Class frmC1Sensors
    Private Sub frmC1Sensors_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'MAKE SURE QUERY IS STOPPED BEFORE EXITING
        If LOOP_IN_PROGRESS = True Then
            USER_REQUEST_STOP = True
            e.Cancel = True
            Exit Sub
        End If

        'SAVE FORM POSITION
        SAVE_WINDOW_FORM_STATE(Me)
    End Sub

    Private Sub frmC1Sensors_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LOAD FORM POSITION
        LOAD_WINDOW_FORM_STATE(Me, 10, 10, 684, 180)
    End Sub

    Private Sub frmC1Sensors_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        'ALIGN TOP LEFT (0,0)
        'If Me.Left < 10 And Me.Top < 10 Then
        ' Me.Top = 0 : Me.Left = 0
        ' End If
    End Sub
End Class