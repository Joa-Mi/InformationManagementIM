<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuItems
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
        Dim MenuTables As System.Windows.Forms.DataGridView
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuItems))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Image = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Action = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddMenuItemsbtn = New InformationManagement.RoundedButton()
        MenuTables = New System.Windows.Forms.DataGridView()
        CType(MenuTables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuTables
        '
        MenuTables.BackgroundColor = System.Drawing.Color.White
        MenuTables.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        MenuTables.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        MenuTables.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        MenuTables.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        MenuTables.ColumnHeadersHeight = 40
        MenuTables.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Image, Me.Name, Me.Description, Me.Price, Me.Category, Me.Status, Me.Action})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        MenuTables.DefaultCellStyle = DataGridViewCellStyle6
        MenuTables.EnableHeadersVisualStyles = False
        MenuTables.Location = New System.Drawing.Point(30, 89)
        MenuTables.Name = "MenuTables"
        MenuTables.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        MenuTables.RowTemplate.Height = 50
        MenuTables.RowTemplate.ReadOnly = True
        MenuTables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        MenuTables.Size = New System.Drawing.Size(1090, 237)
        MenuTables.TabIndex = 0
        '
        'Image
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.NullValue = CType(resources.GetObject("DataGridViewCellStyle2.NullValue"), Object)
        Me.Image.DefaultCellStyle = DataGridViewCellStyle2
        Me.Image.HeaderText = "Image"
        Me.Image.Name = "Image"
        Me.Image.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Name
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name.DefaultCellStyle = DataGridViewCellStyle3
        Me.Name.HeaderText = "Name"
        Me.Name.Name = "Name"
        Me.Name.Width = 250
        '
        'Description
        '
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Description.DefaultCellStyle = DataGridViewCellStyle4
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.Width = 160
        '
        'Price
        '
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Price.DefaultCellStyle = DataGridViewCellStyle5
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.Width = 150
        '
        'Category
        '
        Me.Category.HeaderText = "Category"
        Me.Category.Name = "Category"
        Me.Category.Width = 120
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.Width = 120
        '
        'Action
        '
        Me.Action.HeaderText = "Action"
        Me.Action.Name = "Action"
        Me.Action.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Action.Text = "Edit/ Delete"
        Me.Action.Width = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menu Items"
        '
        'AddMenuItemsbtn
        '
        Me.AddMenuItemsbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AddMenuItemsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddMenuItemsbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.AddMenuItemsbtn.ForeColor = System.Drawing.Color.White
        Me.AddMenuItemsbtn.Image = CType(resources.GetObject("AddMenuItemsbtn.Image"), System.Drawing.Image)
        Me.AddMenuItemsbtn.Location = New System.Drawing.Point(932, 16)
        Me.AddMenuItemsbtn.Name = "AddMenuItemsbtn"
        Me.AddMenuItemsbtn.Size = New System.Drawing.Size(188, 39)
        Me.AddMenuItemsbtn.TabIndex = 4
        Me.AddMenuItemsbtn.Text = "   Add Menu Items"
        Me.AddMenuItemsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddMenuItemsbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AddMenuItemsbtn.UseVisualStyleBackColor = False
        '
        'MenuItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1166, 537)
        Me.Controls.Add(MenuTables)
        Me.Controls.Add(Me.AddMenuItemsbtn)
        Me.Controls.Add(Me.Label1)
        Me.Text = "MenuItems"
        CType(MenuTables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents AddMenuItemsbtn As RoundedButton
    Friend WithEvents Image As DataGridViewImageColumn
    Friend WithEvents Name As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Category As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Action As DataGridViewButtonColumn
End Class
