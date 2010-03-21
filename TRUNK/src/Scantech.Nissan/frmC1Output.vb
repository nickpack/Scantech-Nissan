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

        If LOG_BUTTONS_STATUS = "" Then
            'ENABLE/DISABLE FRMMAIN MENU STATE
            ENABLE_STATE_FOR_MENUS(0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 0)

            'ENABLE/DISABLE LOG INSPECTOR
            ENABLE_STATE_FOR_INSPECTOR(0, 0, 0, 0, 0, 0, 0)
        Else
            'ENABLE/DISABLE FRMMAIN MENU STATE
            ENABLE_STATE_FOR_MENUS(1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1)

            'ENABLE/DISABLE LOG INSPECTOR
            ENABLE_STATE_FOR_INSPECTOR(0, 0, 0, 0, 0, 0, 0)
        End If
    End Sub
    Private Sub frmC1Output_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LOAD FORM POSITION
        LOAD_WINDOW_FORM_STATE(Me, 10, 10, 483, 254)

        If LOG_BUTTONS_STATUS = "" Then
            'ENABLE/DISABLE FRMMAIN MENU STATE
            ENABLE_STATE_FOR_MENUS(0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0)

            'ENABLE/DISABLE LOG INSPECTOR
            ENABLE_STATE_FOR_INSPECTOR(1, 0, 0, 0, 0, 0, 0)
        Else
            'ENABLE/DISABLE FRMMAIN MENU STATE
            ENABLE_STATE_FOR_MENUS(1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0)

            'ENABLE/DISABLE LOG INSPECTOR
            ENABLE_STATE_FOR_INSPECTOR(0, 0, 1, 0, 0, 0, 1)
        End If
    End Sub
End Class