Public Class frmScannerECU

    Private Sub cmdScanEcu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdScanEcu.Click
        If cmdScanEcu.Text = "Scan ECU" Then
            LOOP_IN_PROGRESS = True
            USER_REQUEST_STOP = False

            'SET BUTTON FOR CANCEL
            cmdScanEcu.Text = "Cancel"

            'CONFIGURE TREEVIEW
            TreeView1.Nodes.Clear()
            TreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            TreeView1.Nodes.Add("Available ECU Address")

            'CONFIGURE PROGRESS BAR
            frmMain.tsProgress.Visible = True : frmMain.tsProgress.Minimum = 0
            frmMain.tsProgress.Maximum = 255 : frmMain.tsProgress.Value = 0

            'USE AT LEAST 25 MILLISECOND INTERBYTE DELAY
            INTERBYTE_DELAY = 25

            'SCAN THROUGH ALL 256 ECU ADDRESS. STARTING FROM 0XFF AND DOWN 0X00.  
            'BECAUSE MOST OF THE ECU ADDRESS IN HIGH AREA BYTES
            Dim X As Integer
            For X = 255 To 0 Step -1
                System.Windows.Forms.Application.DoEvents()
                frmMain.tsProgress.Value = 255 - X

                'UPDATE TREEVIEW IF ADDRESS FOUND
                If INITIALIZE_ECU(CByte(X), False) = True Then
                    TreeView1.Nodes(0).Nodes.Add(Hex(X)) : TreeView1.ExpandAll()
                End If

                'USER CANCELED OR TRYING TO EXIT
                If USER_REQUEST_STOP = True Then Exit For
            Next
        Else
            'USER CLICKED CANCEL
            USER_REQUEST_STOP = True : Exit Sub
        End If

        'RESET
        cmdScanEcu.Text = "Scan ECU" : LOOP_IN_PROGRESS = False : frmMain.tsProgress.Visible = False : USER_REQUEST_STOP = False
    End Sub

    Private Sub frmScannerECU_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'MAKE SURE QUERY IS STOPPED BEFORE EXITING
        If LOOP_IN_PROGRESS = True Then
            USER_REQUEST_STOP = True
            e.Cancel = True
            Exit Sub
        End If

        'SAVE FORM POSITION
        SAVE_WINDOW_FORM_STATE(Me)

        'CLOSE PORT
        frmMain.SerialPort1.Close()

        'ENABLE/DISABLE FRMMAIN MENU STATE
        MENUENABLESTATE(True, False, False, False, False, False, False, True, True, True, True, False, False, False, False)
    End Sub

    Private Sub frmScannerECU_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LOAD FORM POSITION
        LOAD_WINDOW_FORM_STATE(Me, 10, 10, 250, 375)

        'ENABLE/DISABLE FRMMAIN MENU STATE
        MENUENABLESTATE(False, False, False, False, False, False, False, False, False, False, False, False, False, False, False)
    End Sub
End Class