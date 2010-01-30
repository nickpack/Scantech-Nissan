<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmC1Sensors
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Grid1 = New System.Windows.Forms.DataGridView
        Me.CheckBox = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Sensors = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Unit1Value = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Unit1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Unit2Value = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Unit2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Min = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Max = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.AllowUserToAddRows = False
        Me.Grid1.AllowUserToDeleteRows = False
        Me.Grid1.AllowUserToResizeRows = False
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Grid1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CheckBox, Me.Sensors, Me.Unit1Value, Me.Unit1, Me.Unit2Value, Me.Unit2, Me.Min, Me.Column1, Me.Max, Me.Column2})
        Me.Grid1.Location = New System.Drawing.Point(12, 12)
        Me.Grid1.MinimumSize = New System.Drawing.Size(300, 180)
        Me.Grid1.MultiSelect = False
        Me.Grid1.Name = "Grid1"
        Me.Grid1.ReadOnly = True
        Me.Grid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid1.Size = New System.Drawing.Size(742, 180)
        Me.Grid1.TabIndex = 16
        '
        'CheckBox
        '
        Me.CheckBox.FillWeight = 76.14214!
        Me.CheckBox.HeaderText = ""
        Me.CheckBox.MinimumWidth = 40
        Me.CheckBox.Name = "CheckBox"
        Me.CheckBox.ReadOnly = True
        Me.CheckBox.Visible = False
        '
        'Sensors
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sensors.DefaultCellStyle = DataGridViewCellStyle2
        Me.Sensors.FillWeight = 104.7716!
        Me.Sensors.HeaderText = "SENSOR NAME"
        Me.Sensors.MinimumWidth = 150
        Me.Sensors.Name = "Sensors"
        Me.Sensors.ReadOnly = True
        Me.Sensors.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Unit1Value
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unit1Value.DefaultCellStyle = DataGridViewCellStyle3
        Me.Unit1Value.HeaderText = ""
        Me.Unit1Value.MinimumWidth = 40
        Me.Unit1Value.Name = "Unit1Value"
        Me.Unit1Value.ReadOnly = True
        Me.Unit1Value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Unit1
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unit1.DefaultCellStyle = DataGridViewCellStyle4
        Me.Unit1.FillWeight = 104.7716!
        Me.Unit1.HeaderText = "UNITS"
        Me.Unit1.MinimumWidth = 25
        Me.Unit1.Name = "Unit1"
        Me.Unit1.ReadOnly = True
        Me.Unit1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Unit2Value
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unit2Value.DefaultCellStyle = DataGridViewCellStyle5
        Me.Unit2Value.HeaderText = ""
        Me.Unit2Value.MinimumWidth = 40
        Me.Unit2Value.Name = "Unit2Value"
        Me.Unit2Value.ReadOnly = True
        Me.Unit2Value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Unit2
        '
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unit2.DefaultCellStyle = DataGridViewCellStyle6
        Me.Unit2.FillWeight = 104.7716!
        Me.Unit2.HeaderText = "UNITS"
        Me.Unit2.MinimumWidth = 25
        Me.Unit2.Name = "Unit2"
        Me.Unit2.ReadOnly = True
        Me.Unit2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Min
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Min.DefaultCellStyle = DataGridViewCellStyle7
        Me.Min.FillWeight = 104.7716!
        Me.Min.HeaderText = "MIN"
        Me.Min.MinimumWidth = 40
        Me.Min.Name = "Min"
        Me.Min.ReadOnly = True
        Me.Min.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column1
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column1.HeaderText = "UNITS"
        Me.Column1.MinimumWidth = 25
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Max
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Max.DefaultCellStyle = DataGridViewCellStyle9
        Me.Max.FillWeight = 104.7716!
        Me.Max.HeaderText = "MAX"
        Me.Max.MinimumWidth = 40
        Me.Max.Name = "Max"
        Me.Max.ReadOnly = True
        Me.Max.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column2
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle10
        Me.Column2.HeaderText = "UNITS"
        Me.Column2.MinimumWidth = 25
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'frmC1Sensors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 201)
        Me.Controls.Add(Me.Grid1)
        Me.MinimumSize = New System.Drawing.Size(444, 180)
        Me.Name = "frmC1Sensors"
        Me.Text = "SENSORS"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grid1 As System.Windows.Forms.DataGridView
    Friend WithEvents CheckBox As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Sensors As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unit1Value As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unit1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unit2Value As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unit2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Min As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Max As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
