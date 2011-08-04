<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnect
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.chkInclude = New System.Windows.Forms.CheckBox
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.trvVehicleInfo = New System.Windows.Forms.TreeView
        Me.chkAutoScan = New System.Windows.Forms.CheckBox
        Me.lstVehicle = New System.Windows.Forms.ListBox
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdConnect = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'chkInclude
        '
        Me.chkInclude.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkInclude.AutoSize = True
        Me.chkInclude.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInclude.Location = New System.Drawing.Point(26, 56)
        Me.chkInclude.Name = "chkInclude"
        Me.chkInclude.Size = New System.Drawing.Size(234, 24)
        Me.chkInclude.TabIndex = 15
        Me.chkInclude.Text = "Include Active Test Registers"
        Me.chkInclude.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEdit.Enabled = False
        Me.cmdEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Location = New System.Drawing.Point(228, 366)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(117, 38)
        Me.cmdEdit.TabIndex = 14
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'trvVehicleInfo
        '
        Me.trvVehicleInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.trvVehicleInfo.BackColor = System.Drawing.Color.White
        Me.trvVehicleInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trvVehicleInfo.Location = New System.Drawing.Point(228, 94)
        Me.trvVehicleInfo.Name = "trvVehicleInfo"
        Me.trvVehicleInfo.Size = New System.Drawing.Size(241, 244)
        Me.trvVehicleInfo.TabIndex = 13
        '
        'chkAutoScan
        '
        Me.chkAutoScan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAutoScan.AutoSize = True
        Me.chkAutoScan.Checked = True
        Me.chkAutoScan.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutoScan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAutoScan.Location = New System.Drawing.Point(26, 26)
        Me.chkAutoScan.Name = "chkAutoScan"
        Me.chkAutoScan.Size = New System.Drawing.Size(328, 24)
        Me.chkAutoScan.TabIndex = 12
        Me.chkAutoScan.Text = "Auto Scan (Recommended For Validation)"
        Me.chkAutoScan.UseVisualStyleBackColor = True
        '
        'lstVehicle
        '
        Me.lstVehicle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstVehicle.BackColor = System.Drawing.Color.White
        Me.lstVehicle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstVehicle.FormattingEnabled = True
        Me.lstVehicle.ItemHeight = 16
        Me.lstVehicle.Location = New System.Drawing.Point(26, 94)
        Me.lstVehicle.Name = "lstVehicle"
        Me.lstVehicle.Size = New System.Drawing.Size(196, 244)
        Me.lstVehicle.Sorted = True
        Me.lstVehicle.TabIndex = 11
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(352, 366)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(117, 38)
        Me.cmdClose.TabIndex = 10
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdConnect
        '
        Me.cmdConnect.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdConnect.Enabled = False
        Me.cmdConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConnect.Location = New System.Drawing.Point(26, 366)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(196, 38)
        Me.cmdConnect.TabIndex = 9
        Me.cmdConnect.Text = "Connect"
        Me.cmdConnect.UseVisualStyleBackColor = True
        '
        'frmConnect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 425)
        Me.Controls.Add(Me.chkInclude)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.trvVehicleInfo)
        Me.Controls.Add(Me.chkAutoScan)
        Me.Controls.Add(Me.lstVehicle)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdConnect)
        Me.MinimumSize = New System.Drawing.Size(511, 461)
        Me.Name = "frmConnect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VEHICLE SELECTION"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkInclude As System.Windows.Forms.CheckBox
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents trvVehicleInfo As System.Windows.Forms.TreeView
    Friend WithEvents chkAutoScan As System.Windows.Forms.CheckBox
    Friend WithEvents lstVehicle As System.Windows.Forms.ListBox
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdConnect As System.Windows.Forms.Button
End Class
