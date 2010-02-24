<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmECUProfile
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sensor Registers")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Digital Output Registers")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Active Test Registers")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Vehicle Information")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Register Information")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("0 = (MSB * 256 + LSB) * 12.5")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("1 = (MSB * 256 + LSB) * 8")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2 = (MSB * 256 + LSB) * 0.005")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("3 = LSB - 50 ")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("4 = LSB * 0.01")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("5 = LSB * 0.08")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("6 = LSB * 0.02")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("7 = (MSB * 256 + LSB) * 0.02")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("8 = LSB * 0.05")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("9 = LSB")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("10 = LSB * 2")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("11 = 110 - LSB")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("12 = 80 - LSB")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("13 = 70 - LSB")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("14 = LSB * 0.5")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("15 = LSB * 0.04")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Available Sensor Scale Type", New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode8, TreeNode9, TreeNode10, TreeNode11, TreeNode12, TreeNode13, TreeNode14, TreeNode15, TreeNode16, TreeNode17, TreeNode18, TreeNode19, TreeNode20, TreeNode21, TreeNode22})
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("0 = N/A")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("1 = Volts")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2 = mS")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("3 = %")
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("4 = °")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("5 = °C + °F")
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("6 = KM/H + MPH")
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Available Sensor Unit Type", New System.Windows.Forms.TreeNode() {TreeNode24, TreeNode25, TreeNode26, TreeNode27, TreeNode28, TreeNode29, TreeNode30})
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("0 = (bit 1 = ON, bit 0 = OFF)")
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("1 = (bit 0 = ON, bit 1 = OFF)")
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2 = (bit 1 = RICH, bit 0 = LEAN)")
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("3 = (bit 1 = LEAN, bit 0 = RICH)")
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Available Digital Output Scale Type", New System.Windows.Forms.TreeNode() {TreeNode32, TreeNode33, TreeNode34, TreeNode35})
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("X-Y = Lowest Byte to Highest Byte")
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("1,2,3,4... Comma In Between")
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Available Active Test Scale Byte", New System.Windows.Forms.TreeNode() {TreeNode37, TreeNode38})
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.TreeView2 = New System.Windows.Forms.TreeView
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridView3 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridView4 = New System.Windows.Forms.DataGridView
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridView5 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(833, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 25)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(143, 26)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(143, 26)
        Me.OpenToolStripMenuItem.Text = "Open..."
        '
        'SToolStripMenuItem
        '
        Me.SToolStripMenuItem.Name = "SToolStripMenuItem"
        Me.SToolStripMenuItem.Size = New System.Drawing.Size(140, 6)
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Enabled = False
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(143, 26)
        Me.SaveAsToolStripMenuItem.Text = "Save As..."
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Enabled = False
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(143, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(285, 41)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(505, 364)
        Me.DataGridView1.TabIndex = 3
        Me.DataGridView1.Visible = False
        '
        'Column4
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column4.HeaderText = "Address"
        Me.Column4.MinimumWidth = 75
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 75
        '
        'Column1
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column1.HeaderText = "Sensor Name"
        Me.Column1.MinimumWidth = 180
        Me.Column1.Name = "Column1"
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column1.Width = 180
        '
        'Column2
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Blue
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column2.HeaderText = "Scale Type"
        Me.Column2.MinimumWidth = 100
        Me.Column2.Name = "Column2"
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column3
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Blue
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column3.HeaderText = "Unit Type"
        Me.Column3.MinimumWidth = 100
        Me.Column3.Name = "Column3"
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.Color.White
        Me.TreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(21, 41)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Node1"
        TreeNode1.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode1.Text = "Sensor Registers"
        TreeNode2.Name = "Node2"
        TreeNode2.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode2.Text = "Digital Output Registers"
        TreeNode3.Name = "Node3"
        TreeNode3.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode3.Text = "Active Test Registers"
        TreeNode4.Name = "Node4"
        TreeNode4.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode4.Text = "Vehicle Information"
        TreeNode5.Name = "Node5"
        TreeNode5.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode5.Text = "Register Information"
        TreeNode6.Name = "Node0"
        TreeNode6.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode6.Text = ""
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode6})
        Me.TreeView1.Size = New System.Drawing.Size(251, 115)
        Me.TreeView1.TabIndex = 2
        Me.TreeView1.Visible = False
        '
        'TreeView2
        '
        Me.TreeView2.Location = New System.Drawing.Point(21, 173)
        Me.TreeView2.Name = "TreeView2"
        TreeNode7.ForeColor = System.Drawing.Color.Blue
        TreeNode7.Name = "Node14"
        TreeNode7.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode7.Text = "0 = (MSB * 256 + LSB) * 12.5"
        TreeNode8.ForeColor = System.Drawing.Color.Blue
        TreeNode8.Name = "Node15"
        TreeNode8.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        TreeNode8.Text = "1 = (MSB * 256 + LSB) * 8"
        TreeNode9.ForeColor = System.Drawing.Color.Blue
        TreeNode9.Name = "Node16"
        TreeNode9.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        TreeNode9.Text = "2 = (MSB * 256 + LSB) * 0.005"
        TreeNode10.ForeColor = System.Drawing.Color.Blue
        TreeNode10.Name = "Node17"
        TreeNode10.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        TreeNode10.Text = "3 = LSB - 50 "
        TreeNode11.ForeColor = System.Drawing.Color.Blue
        TreeNode11.Name = "Node0"
        TreeNode11.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        TreeNode11.Text = "4 = LSB * 0.01"
        TreeNode12.ForeColor = System.Drawing.Color.Blue
        TreeNode12.Name = "Node1"
        TreeNode12.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        TreeNode12.Text = "5 = LSB * 0.08"
        TreeNode13.ForeColor = System.Drawing.Color.Blue
        TreeNode13.Name = "Node2"
        TreeNode13.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        TreeNode13.Text = "6 = LSB * 0.02"
        TreeNode14.ForeColor = System.Drawing.Color.Blue
        TreeNode14.Name = "Node3"
        TreeNode14.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        TreeNode14.Text = "7 = (MSB * 256 + LSB) * 0.02"
        TreeNode15.ForeColor = System.Drawing.Color.Blue
        TreeNode15.Name = "Node4"
        TreeNode15.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        TreeNode15.Text = "8 = LSB * 0.05"
        TreeNode16.ForeColor = System.Drawing.Color.Blue
        TreeNode16.Name = "Node5"
        TreeNode16.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        TreeNode16.Text = "9 = LSB"
        TreeNode17.ForeColor = System.Drawing.Color.Blue
        TreeNode17.Name = "Node6"
        TreeNode17.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        TreeNode17.Text = "10 = LSB * 2"
        TreeNode18.ForeColor = System.Drawing.Color.Blue
        TreeNode18.Name = "Node7"
        TreeNode18.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        TreeNode18.Text = "11 = 110 - LSB"
        TreeNode19.ForeColor = System.Drawing.Color.Blue
        TreeNode19.Name = "Node8"
        TreeNode19.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        TreeNode19.Text = "12 = 80 - LSB"
        TreeNode20.ForeColor = System.Drawing.Color.Blue
        TreeNode20.Name = "Node9"
        TreeNode20.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        TreeNode20.Text = "13 = 70 - LSB"
        TreeNode21.ForeColor = System.Drawing.Color.Blue
        TreeNode21.Name = "Node10"
        TreeNode21.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        TreeNode21.Text = "14 = LSB * 0.5"
        TreeNode22.ForeColor = System.Drawing.Color.Blue
        TreeNode22.Name = "Node1"
        TreeNode22.Text = "15 = LSB * 0.04"
        TreeNode23.Name = "Node0"
        TreeNode23.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode23.Text = "Available Sensor Scale Type"
        TreeNode24.ForeColor = System.Drawing.Color.Blue
        TreeNode24.Name = "Node2"
        TreeNode24.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        TreeNode24.Text = "0 = N/A"
        TreeNode25.ForeColor = System.Drawing.Color.Blue
        TreeNode25.Name = "Node5"
        TreeNode25.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        TreeNode25.Text = "1 = Volts"
        TreeNode26.ForeColor = System.Drawing.Color.Blue
        TreeNode26.Name = "Node6"
        TreeNode26.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        TreeNode26.Text = "2 = mS"
        TreeNode27.ForeColor = System.Drawing.Color.Blue
        TreeNode27.Name = "Node7"
        TreeNode27.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        TreeNode27.Text = "3 = %"
        TreeNode28.ForeColor = System.Drawing.Color.Blue
        TreeNode28.Name = "Node9"
        TreeNode28.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        TreeNode28.Text = "4 = °"
        TreeNode29.ForeColor = System.Drawing.Color.Blue
        TreeNode29.Name = "Node12"
        TreeNode29.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        TreeNode29.Text = "5 = °C + °F"
        TreeNode30.ForeColor = System.Drawing.Color.Blue
        TreeNode30.Name = "Node13"
        TreeNode30.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        TreeNode30.Text = "6 = KM/H + MPH"
        TreeNode31.Name = "Node1"
        TreeNode31.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode31.Text = "Available Sensor Unit Type"
        TreeNode32.ForeColor = System.Drawing.Color.Blue
        TreeNode32.Name = "Node1"
        TreeNode32.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        TreeNode32.Text = "0 = (bit 1 = ON, bit 0 = OFF)"
        TreeNode33.ForeColor = System.Drawing.Color.Blue
        TreeNode33.Name = "Node2"
        TreeNode33.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        TreeNode33.Text = "1 = (bit 0 = ON, bit 1 = OFF)"
        TreeNode34.ForeColor = System.Drawing.Color.Blue
        TreeNode34.Name = "Node3"
        TreeNode34.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        TreeNode34.Text = "2 = (bit 1 = RICH, bit 0 = LEAN)"
        TreeNode35.ForeColor = System.Drawing.Color.Blue
        TreeNode35.Name = "Node4"
        TreeNode35.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        TreeNode35.Text = "3 = (bit 1 = LEAN, bit 0 = RICH)"
        TreeNode36.Name = "Node0"
        TreeNode36.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode36.Text = "Available Digital Output Scale Type"
        TreeNode37.ForeColor = System.Drawing.Color.Blue
        TreeNode37.Name = "Node2"
        TreeNode37.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        TreeNode37.Text = "X-Y = Lowest Byte to Highest Byte"
        TreeNode38.ForeColor = System.Drawing.Color.Blue
        TreeNode38.Name = "Node3"
        TreeNode38.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        TreeNode38.Text = "1,2,3,4... Comma In Between"
        TreeNode39.Name = "Node0"
        TreeNode39.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode39.Text = "Available Active Test Scale Byte"
        TreeNode39.ToolTipText = "1,2,3,4.... Use Comma In between"
        Me.TreeView2.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode23, TreeNode31, TreeNode36, TreeNode39})
        Me.TreeView2.Size = New System.Drawing.Size(251, 276)
        Me.TreeView2.TabIndex = 4
        Me.TreeView2.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 466)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(833, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DataGridView2.Location = New System.Drawing.Point(285, 41)
        Me.DataGridView2.Name = "DataGridView2"
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(400, 364)
        Me.DataGridView2.TabIndex = 6
        Me.DataGridView2.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn1.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 75
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 75
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn2.HeaderText = "Sensor Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 180
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 180
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Blue
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn3.HeaderText = "Scale Type"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AllowUserToResizeRows = False
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DataGridView3.Location = New System.Drawing.Point(285, 41)
        Me.DataGridView3.Name = "DataGridView3"
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView3.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(450, 364)
        Me.DataGridView3.TabIndex = 7
        Me.DataGridView3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn4.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 75
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 75
        '
        'DataGridViewTextBoxColumn5
        '
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn5.HeaderText = "Sensor Name"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 180
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn5.Width = 180
        '
        'DataGridViewTextBoxColumn6
        '
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Blue
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn6.HeaderText = "Scale Byte (In Decimal)"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 150
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridView4
        '
        Me.DataGridView4.AllowUserToAddRows = False
        Me.DataGridView4.AllowUserToDeleteRows = False
        Me.DataGridView4.AllowUserToResizeRows = False
        Me.DataGridView4.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView4.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column6})
        Me.DataGridView4.Location = New System.Drawing.Point(285, 41)
        Me.DataGridView4.Name = "DataGridView4"
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView4.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView4.Size = New System.Drawing.Size(450, 364)
        Me.DataGridView4.TabIndex = 8
        Me.DataGridView4.Visible = False
        '
        'Column5
        '
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle18
        Me.Column5.HeaderText = ""
        Me.Column5.MinimumWidth = 200
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column5.Width = 200
        '
        'Column6
        '
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle19
        Me.Column6.HeaderText = "Value"
        Me.Column6.MinimumWidth = 200
        Me.Column6.Name = "Column6"
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column6.Width = 200
        '
        'DataGridView5
        '
        Me.DataGridView5.AllowUserToAddRows = False
        Me.DataGridView5.AllowUserToDeleteRows = False
        Me.DataGridView5.AllowUserToResizeRows = False
        Me.DataGridView5.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView5.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.DataGridView5.Location = New System.Drawing.Point(285, 41)
        Me.DataGridView5.Name = "DataGridView5"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView5.RowHeadersDefaultCellStyle = DataGridViewCellStyle24
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView5.RowsDefaultCellStyle = DataGridViewCellStyle25
        Me.DataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView5.Size = New System.Drawing.Size(450, 364)
        Me.DataGridView5.TabIndex = 9
        Me.DataGridView5.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle22
        Me.DataGridViewTextBoxColumn7.HeaderText = ""
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 200
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn7.Width = 200
        '
        'DataGridViewTextBoxColumn8
        '
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle23
        Me.DataGridViewTextBoxColumn8.HeaderText = "Value"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 200
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn8.Width = 200
        '
        'cmdAdd
        '
        Me.cmdAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Location = New System.Drawing.Point(285, 411)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(152, 38)
        Me.cmdAdd.TabIndex = 23
        Me.cmdAdd.Text = "Add Row"
        Me.cmdAdd.UseVisualStyleBackColor = True
        Me.cmdAdd.Visible = False
        '
        'cmdDelete
        '
        Me.cmdDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Location = New System.Drawing.Point(443, 411)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(152, 38)
        Me.cmdDelete.TabIndex = 24
        Me.cmdDelete.Text = "Delete Row"
        Me.cmdDelete.UseVisualStyleBackColor = True
        Me.cmdDelete.Visible = False
        '
        'frmECUProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(833, 488)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.DataGridView5)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TreeView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmECUProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ECU PROFILE"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents TreeView2 As System.Windows.Forms.TreeView
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents SToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView5 As System.Windows.Forms.DataGridView
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
