Public Class frmC1Output
    Private Sub frmC1Output_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'MAKE SURE QUERY IS STOPPED BEFORE EXITING
        If LOOP_IN_PROGRESS = True Then
            USER_REQUEST_STOP = True
            e.Cancel = True
            Exit Sub
        End If

        'SAVE FORM POSITION
        SAVE_WINDOW_FORM_STATE(Me)

        MenuEnableState(False, True, True, True, True, True, True, False, False, False, False, True, True)
    End Sub
    Private Sub frmC1Output_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LOAD FORM POSITION
        LOAD_WINDOW_FORM_STATE(Me, 10, 10, 483, 254)

        MenuEnableState(False, True, False, False, False, False, False, False, False, False, False, True, False)
    End Sub
End Class