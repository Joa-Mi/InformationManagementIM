<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAddNewmenuItem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddNewmenuItem))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtImageUrl = New System.Windows.Forms.TextBox()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.comboStatus = New System.Windows.Forms.ComboBox()
        Me.comboCategory = New System.Windows.Forms.ComboBox()
        Me.numericPrice = New System.Windows.Forms.NumericUpDown()
        CType(Me.numericPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Add New Menu Item"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Item Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(216, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 17)
        Me.Label3.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Description"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Price"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Category"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 345)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Image URL"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 417)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 17)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Status"
        '
        'txtItemName
        '
        Me.txtItemName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtItemName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemName.Location = New System.Drawing.Point(26, 77)
        Me.txtItemName.MinimumSize = New System.Drawing.Size(0, 35)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(432, 16)
        Me.txtItemName.TabIndex = 11
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(26, 148)
        Me.txtDescription.MinimumSize = New System.Drawing.Size(0, 35)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(432, 35)
        Me.txtDescription.TabIndex = 12
        '
        'txtImageUrl
        '
        Me.txtImageUrl.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtImageUrl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtImageUrl.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImageUrl.Location = New System.Drawing.Point(29, 367)
        Me.txtImageUrl.MinimumSize = New System.Drawing.Size(0, 35)
        Me.txtImageUrl.Name = "txtImageUrl"
        Me.txtImageUrl.Size = New System.Drawing.Size(432, 16)
        Me.txtImageUrl.TabIndex = 15
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.ForeColor = System.Drawing.Color.White
        Me.btnAddItem.Location = New System.Drawing.Point(29, 496)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(432, 42)
        Me.btnAddItem.TabIndex = 17
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(442, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(29, 27)
        Me.btnClose.TabIndex = 25
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'comboStatus
        '
        Me.comboStatus.BackColor = System.Drawing.Color.WhiteSmoke
        Me.comboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboStatus.FormattingEnabled = True
        Me.comboStatus.Items.AddRange(New Object() {"Available", "Unvailable"})
        Me.comboStatus.Location = New System.Drawing.Point(29, 448)
        Me.comboStatus.Name = "comboStatus"
        Me.comboStatus.Size = New System.Drawing.Size(432, 21)
        Me.comboStatus.TabIndex = 26
        '
        'comboCategory
        '
        Me.comboCategory.BackColor = System.Drawing.Color.WhiteSmoke
        Me.comboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboCategory.FormattingEnabled = True
        Me.comboCategory.Items.AddRange(New Object() {"Appetizer", "Main Course", "Dessert", "Beverage"})
        Me.comboCategory.Location = New System.Drawing.Point(29, 309)
        Me.comboCategory.Name = "comboCategory"
        Me.comboCategory.Size = New System.Drawing.Size(432, 21)
        Me.comboCategory.TabIndex = 27
        '
        'numericPrice
        '
        Me.numericPrice.Location = New System.Drawing.Point(26, 230)
        Me.numericPrice.Name = "numericPrice"
        Me.numericPrice.Size = New System.Drawing.Size(435, 22)
        Me.numericPrice.TabIndex = 28
        '
        'FormAddNewmenuItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(485, 545)
        Me.ControlBox = False
        Me.Controls.Add(Me.numericPrice)
        Me.Controls.Add(Me.comboCategory)
        Me.Controls.Add(Me.comboStatus)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.txtImageUrl)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormAddNewmenuItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAddNewmenuItembtn"
        CType(Me.numericPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtImageUrl As TextBox
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents comboStatus As ComboBox
    Friend WithEvents comboCategory As ComboBox
    Friend WithEvents numericPrice As NumericUpDown
End Class
