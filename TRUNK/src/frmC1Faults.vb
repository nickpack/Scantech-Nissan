Public Class frmC1Faults

    Private Sub frmC1Faults_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SaveSetting("Consult1", "C1Faults", "Top Position", Me.Top)
        SaveSetting("Consult1", "C1Faults", "Left Position", Me.Left)
        SaveSetting("Consult1", "C1Faults", "Form Width", Me.Width)
        SaveSetting("Consult1", "C1Faults", "Form Height", Me.Height)
        SaveSetting("Consult1", "C1Faults", "Window State", Me.WindowState)
        ENABLE_MENUS()

    End Sub
    Private Sub frmC1Faults_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = GetSetting("Consult1", "C1Faults", "Top Position", 10)
        Me.Left = GetSetting("Consult1", "C1Faults", "Left Position", 10)
        Me.Width = GetSetting("Consult1", "C1Faults", "Form Width", 100)
        Me.Height = GetSetting("Consult1", "C1Faults", "Form Height", 100)
        Me.WindowState = GetSetting("Consult1", "C1Faults", "Window State", 0)
    End Sub

    Private Sub cmdCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCheck.Click
        Dim FaultData As String
        Me.TreeView1.Nodes.Clear()
        FaultData = REQUEST_C1_FAULTS()

        If Len(FaultData) > 0 Then
            'DISPLAY ON TREEVIEW (CODE NUMBER + START TIMES)
            Dim X As Integer
            Dim D1 As String
            Dim D2 As String
            Dim DResult As String
            For X = 1 To Len(FaultData) Step 4
                D1 = Mid(FaultData, X, 1)           'CONVERT HIGH NIBBLE BYTE TO DECIMAL
                D2 = Mid(FaultData, X + 1, 1)       'CONVERT LOW NIBBLE BYTE TO DECIMAL
                D1 = CByte("&H" & D1)
                D2 = CByte("&H" & D2)
                DResult = D1 & D2                   'EXAMPLE 0xA0 = CODE 100, 0x55 = CODE 55
                Me.TreeView1.Nodes.Add("Code: " & DResult).Nodes.Add("Description: Not available at this time").Nodes.Add("Starts: " & CByte("&H" & Mid(DATA_FILTERED_RECEIVED, X + 2, 2)))
                Me.TreeView1.ExpandAll()
            Next
        Else
            Me.TreeView1.Nodes.Add("Timeout - No Data or Response")
        End If
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        REQUEST_C1_CLEAR_FAULTS()                   'CLEAR FAULT
        cmdCheck_Click(3, e)                        'CHECK FAULT
    End Sub
End Class