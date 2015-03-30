Public Class frmC1ActiveTest

    Private Sub frmC1ActiveTest_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'MAKE SURE QUERY IS STOPPED BEFORE EXITING
        If LOOP_IN_PROGRESS = True Then
            USER_REQUEST_STOP = True
            e.Cancel = True
            Exit Sub
        End If

        'SAVE FORM POSITION
        SAVE_WINDOW_FORM_STATE(Me)
    End Sub
    Private Sub frmC1ActiveTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LOAD FORM POSITION
        LOAD_WINDOW_FORM_STATE(Me, 10, 10, 493, 268)
    End Sub
    Private Sub Grid2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid2.CellClick
        'GET VALUES STORED IN BINDING SOURCE WHICH WAS LOADED FROM INI FILE
        ComboBox1.DataSource = CBO_ACTIVE_BINDING(CByte("&H" & Me.Grid2.Item(1, e.RowIndex).Tag))
    End Sub
    Private Sub DataGridView1_DataError(ByVal sender As Object, _
                                        ByVal e As DataGridViewDataErrorEventArgs) _
                                        Handles Grid2.DataError
    End Sub
    Public Sub cmdGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGo.Click
        cmdGo.Enabled = False : cmdStop.Enabled = True
    End Sub

    Private Sub cmdStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStop.Click
        cmdGo.Enabled = True : cmdStop.Enabled = False

        'TRIGGER ACTIVE TEST STOP COMMAND
        BLN_ACTIVE_TEST_COMMAND_REQUEST(1) = True
        Dim J As Integer
        For J = 0 To frmC1Output.Grid2.RowCount - 1
            frmC1Output.Grid2.Item(1, J).Style.BackColor = Color.White
        Next
        For J = 0 To frmC1Sensors.Grid1.RowCount - 1
            frmC1Sensors.Grid1.Item(1, J).Style.BackColor = Color.White
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        'DO ONLY IF USER SET THE GO ON. DETERMINED BY ENABLE STATE
        If cmdGo.Enabled = True Then Exit Sub

        'TRIGGER ACTIVE TEST COMMAND (SEE IN CONSULT1SCAN.VB)
        BLN_ACTIVE_TEST_COMMAND_REQUEST(0) = True

        'HIGHLIGHT IT (NAME AT ACTIVE TEST MUST BE SIMILIAR NAME TO SENSOR OR OUTPUT NAMES FOR THIS TO WORK)
        Dim GridName As String
        GridName = Me.Grid2.Item(1, Me.Grid2.CurrentCell.RowIndex).Value
        Dim J As Integer
        For J = 0 To frmC1Output.Grid2.RowCount - 1
            If GridName = frmC1Output.Grid2.Item(1, J).Value Then
                frmC1Output.Grid2.Item(1, J).Style.BackColor = Color.LightGreen
            Else
                frmC1Output.Grid2.Item(1, J).Style.BackColor = Color.White
            End If
        Next

        For J = 0 To frmC1Sensors.Grid1.RowCount - 1
            If GridName = frmC1Sensors.Grid1.Item(1, J).Value Then
                frmC1Sensors.Grid1.Item(1, J).Style.BackColor = Color.LightGreen
            Else
                frmC1Sensors.Grid1.Item(1, J).Style.BackColor = Color.White
            End If
        Next
    End Sub
    Private Sub Grid2_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid2.SelectionChanged
        If cmdGo.Enabled = True Then Exit Sub
        'STOP ACTIVE TEST BY SENDING STOP COMMAND.  DO THIS IF SELECTION IS CHANGED
        cmdStop_Click(1, e)
    End Sub
End Class