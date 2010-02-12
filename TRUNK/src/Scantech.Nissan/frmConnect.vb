
Public Class frmConnect
    Private Sub cmdConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConnect.Click
        Me.Enabled = False

        'LOAD INI FILE AND SET THE VARIABLES
        LST_VEHICLE_FILE = Application.StartupPath & "\Vehicle Specific\" & lstVehicle.Text
        GET_FILE_REGISTERS_INFO(LST_VEHICLE_FILE)
        GET_FILE_REGISTER_PARAMETERS(LST_VEHICLE_FILE)

        'INITIALIZE ECU
        If INITIALIZE_ECU(ECU_ID_3, True) = True Then
            'SENSOR REGISTER AUTO SCAN  IF SELECTED (FOR VALIDATION)
            If chkAutoScan.Checked = True Then
                'IF INVALID SEND ERROR MESSAGE
                If SCAN_REGISTERS(START_BYTE_FOR_SENSOR, END_BYTE_FOR_SENSOR) = False Then
                    Me.Enabled = True
                    MsgBox("Invalid Auto Scan with Sensor Registers.  Registers In " & lstVehicle.Text & _
                           " File Does Not Match With Auto Scan", _
                           MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Error")
                    Exit Sub
                End If
            End If

            'ACTIVE TEST AUTO SCAN   IF SELECTED (FOR VALIDATION)
            If chkInclude.Checked = True Then
                'IF INVALID SEND ERROR MESSAGE
                If SCAN_REGISTERS(START_BYTE_FOR_ACTIVETEST, END_BYTE_FOR_ACTIVETEST) = False Then
                    Me.Enabled = True
                    MsgBox("Invalid Auto Scan with Active Test Registers.  Registers In " & lstVehicle.Text & _
                           " File Does Not Match With Auto Scan", _
                           MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Error")
                    Exit Sub
                End If
            End If

            'IF IT GETS HERE THEN CONNECTION IS SUCCESS
            frmMain.MonitorManagerToolStripMenuItem_Click(1, e)
            Me.Close()
            Exit Sub
        End If

        Me.Enabled = True
    End Sub

    Private Sub frmConnect_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'SAVE FORM POSITION
        SAVE_WINDOW_FORM_STATE(Me)
    End Sub
    Private Sub frmConnect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LOAD FORM POSITION
        LOAD_WINDOW_FORM_STATE(Me, 10, 10, 511, 461)

        'MAKE A REFERENCE TO A DIRECTORY
        Dim di As New IO.DirectoryInfo(Application.StartupPath & "\Vehicle Specific\")
        Dim diar1 As IO.FileInfo() = di.GetFiles()
        Dim dra As IO.FileInfo

        'CLEAR FIELDS
        trvVehicleInfo.Nodes.Clear()
        lstVehicle.Items.Clear()

        'DISABLE MENUS
        'DISABLE_MENUS()

        'LIST THE NAMES OF ALL FILES IN THE SPECIFIED DIRECTORY
        For Each dra In diar1
            lstVehicle.Items.Add(dra)
        Next
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub lstVehicle_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstVehicle.DoubleClick
        If lstVehicle.Text = "" Then Exit Sub
        Me.cmdConnect_Click(1, e)
    End Sub
    Private Sub lstVehicle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstVehicle.SelectedIndexChanged
        If lstVehicle.Text = "" Then Exit Sub
        cmdConnect.Enabled = True : cmdEdit.Enabled = True : trvVehicleInfo.Nodes.Clear()

        'LOAD VEHICLE INFO INI FROM SELECTED LISTBOX
        FileName = Application.StartupPath & "\Vehicle Specific\" & lstVehicle.Text
        GET_FILE_VEHICLE_INFO(FileName)

        chkAutoScan.Checked = AUTOSCAN
        trvVehicleInfo.ExpandAll()
    End Sub
    Private Sub chkAutoScan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutoScan.CheckedChanged
        If chkAutoScan.Checked = True Then
            chkInclude.Visible = True
        Else
            chkInclude.Visible = False
            chkInclude.Checked = False
        End If
    End Sub

    Public Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        frmECUProfile.Show() : frmECUProfile.Tag = 1
        frmECUProfile.OpenToolStripMenuItem_Click(3, e)
        Me.Close()
    End Sub
End Class