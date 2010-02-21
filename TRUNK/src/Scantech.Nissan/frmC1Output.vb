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

        'ENABLE/DISABLE FRMMAIN MENU STATE
        ENABLE_STATE_FOR_MENUS(False, True, True, True, True, True, True, False, False, False, False, True, True, True, True)

        'ENABLE/DISABLE LOG INSPECTOR
        ENABLE_STATE_FOR_INSPECTOR(False, False, False, False, False, False)
    End Sub
    Private Sub frmC1Output_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LOAD FORM POSITION
        LOAD_WINDOW_FORM_STATE(Me, 10, 10, 483, 254)

        'ENABLE/DISABLE FRMMAIN MENU STATE
        ENABLE_STATE_FOR_MENUS(False, True, False, False, False, False, False, False, False, False, False, True, False, False, False)

        'ENABLE/DISABLE LOG INSPECTOR
        ENABLE_STATE_FOR_INSPECTOR(True, False, False, False, False, False)
    End Sub
End Class