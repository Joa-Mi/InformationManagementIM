<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsersAccounts
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsersAccounts))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AllUsersbtn = New System.Windows.Forms.Button()
        Me.Staffbtn = New System.Windows.Forms.Button()
        Me.Employeesbtn = New System.Windows.Forms.Button()
        Me.Customerbtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UsersAccountData = New System.Windows.Forms.DataGridView()
        Me.Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRole = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colJoinDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colActions = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Adduserbtn = New InformationManagement.RoundedButton()
        Me.RoundedPane21 = New InformationManagement.RoundedPane2()
        Me.RoundedPane22 = New InformationManagement.RoundedPane2()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.RoundedPane23 = New InformationManagement.RoundedPane2()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.RoundedPane24 = New InformationManagement.RoundedPane2()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersAccountData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoundedPane21.SuspendLayout()
        Me.RoundedPane22.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoundedPane23.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoundedPane24.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Accounts"
        '
        'AllUsersbtn
        '
        Me.AllUsersbtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AllUsersbtn.Location = New System.Drawing.Point(28, 69)
        Me.AllUsersbtn.Name = "AllUsersbtn"
        Me.AllUsersbtn.Size = New System.Drawing.Size(130, 35)
        Me.AllUsersbtn.TabIndex = 1
        Me.AllUsersbtn.Text = "All Users"
        Me.AllUsersbtn.UseVisualStyleBackColor = True
        '
        'Staffbtn
        '
        Me.Staffbtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staffbtn.Location = New System.Drawing.Point(174, 69)
        Me.Staffbtn.Name = "Staffbtn"
        Me.Staffbtn.Size = New System.Drawing.Size(130, 35)
        Me.Staffbtn.TabIndex = 2
        Me.Staffbtn.Text = "Staff"
        Me.Staffbtn.UseVisualStyleBackColor = True
        '
        'Employeesbtn
        '
        Me.Employeesbtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Employeesbtn.Location = New System.Drawing.Point(325, 69)
        Me.Employeesbtn.Name = "Employeesbtn"
        Me.Employeesbtn.Size = New System.Drawing.Size(130, 35)
        Me.Employeesbtn.TabIndex = 3
        Me.Employeesbtn.Text = "Employees"
        Me.Employeesbtn.UseVisualStyleBackColor = True
        '
        'Customerbtn
        '
        Me.Customerbtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customerbtn.Location = New System.Drawing.Point(477, 69)
        Me.Customerbtn.Name = "Customerbtn"
        Me.Customerbtn.Size = New System.Drawing.Size(140, 35)
        Me.Customerbtn.TabIndex = 4
        Me.Customerbtn.Text = "Customers"
        Me.Customerbtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.InformationManagement.My.Resources.Resources.user__4_
        Me.PictureBox1.Location = New System.Drawing.Point(209, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 24)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(14, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Total Users"
        '
        'UsersAccountData
        '
        Me.UsersAccountData.BackgroundColor = System.Drawing.Color.White
        Me.UsersAccountData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UsersAccountData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.UsersAccountData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UsersAccountData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.UsersAccountData.ColumnHeadersHeight = 40
        Me.UsersAccountData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Name, Me.colEmail, Me.colPhone, Me.colRole, Me.colStatus, Me.colJoinDate, Me.colActions})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UsersAccountData.DefaultCellStyle = DataGridViewCellStyle7
        Me.UsersAccountData.EnableHeadersVisualStyles = False
        Me.UsersAccountData.GridColor = System.Drawing.Color.LightGray
        Me.UsersAccountData.Location = New System.Drawing.Point(28, 266)
        Me.UsersAccountData.Name = "UsersAccountData"
        Me.UsersAccountData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.UsersAccountData.RowHeadersVisible = False
        Me.UsersAccountData.RowHeadersWidth = 55
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        Me.UsersAccountData.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.UsersAccountData.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.UsersAccountData.RowTemplate.Height = 35
        Me.UsersAccountData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.UsersAccountData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UsersAccountData.Size = New System.Drawing.Size(1063, 219)
        Me.UsersAccountData.TabIndex = 9
        '
        'Name
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Name.DefaultCellStyle = DataGridViewCellStyle6
        Me.Name.HeaderText = "Name"
        Me.Name.Name = "Name"
        Me.Name.Width = 160
        '
        'colEmail
        '
        Me.colEmail.HeaderText = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.Width = 155
        '
        'colPhone
        '
        Me.colPhone.HeaderText = "Phone"
        Me.colPhone.Name = "colPhone"
        Me.colPhone.Width = 150
        '
        'colRole
        '
        Me.colRole.HeaderText = "Role"
        Me.colRole.Name = "colRole"
        Me.colRole.Width = 150
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Width = 150
        '
        'colJoinDate
        '
        Me.colJoinDate.HeaderText = "Join Date"
        Me.colJoinDate.Name = "colJoinDate"
        Me.colJoinDate.Width = 150
        '
        'colActions
        '
        Me.colActions.HeaderText = "Actions"
        Me.colActions.Name = "colActions"
        Me.colActions.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colActions.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colActions.Width = 150
        '
        'Adduserbtn
        '
        Me.Adduserbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Adduserbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Adduserbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Adduserbtn.ForeColor = System.Drawing.Color.White
        Me.Adduserbtn.Image = CType(resources.GetObject("Adduserbtn.Image"), System.Drawing.Image)
        Me.Adduserbtn.Location = New System.Drawing.Point(946, 18)
        Me.Adduserbtn.Name = "Adduserbtn"
        Me.Adduserbtn.Size = New System.Drawing.Size(145, 38)
        Me.Adduserbtn.TabIndex = 10
        Me.Adduserbtn.Text = "   Add User"
        Me.Adduserbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Adduserbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Adduserbtn.UseVisualStyleBackColor = False
        '
        'RoundedPane21
        '
        Me.RoundedPane21.BorderColor = System.Drawing.Color.LightGray
        Me.RoundedPane21.BorderThickness = 1
        Me.RoundedPane21.Controls.Add(Me.Label3)
        Me.RoundedPane21.Controls.Add(Me.Label2)
        Me.RoundedPane21.Controls.Add(Me.PictureBox1)
        Me.RoundedPane21.CornerRadius = 15
        Me.RoundedPane21.FillColor = System.Drawing.Color.White
        Me.RoundedPane21.Location = New System.Drawing.Point(28, 127)
        Me.RoundedPane21.Name = "RoundedPane21"
        Me.RoundedPane21.Size = New System.Drawing.Size(253, 105)
        Me.RoundedPane21.TabIndex = 11
        '
        'RoundedPane22
        '
        Me.RoundedPane22.BorderColor = System.Drawing.Color.LightGray
        Me.RoundedPane22.BorderThickness = 1
        Me.RoundedPane22.Controls.Add(Me.Label4)
        Me.RoundedPane22.Controls.Add(Me.Label6)
        Me.RoundedPane22.Controls.Add(Me.PictureBox5)
        Me.RoundedPane22.CornerRadius = 15
        Me.RoundedPane22.FillColor = System.Drawing.Color.White
        Me.RoundedPane22.Location = New System.Drawing.Point(294, 127)
        Me.RoundedPane22.Name = "RoundedPane22"
        Me.RoundedPane22.Size = New System.Drawing.Size(253, 105)
        Me.RoundedPane22.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Location = New System.Drawing.Point(14, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Staff Members"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.InformationManagement.My.Resources.Resources.user__4_
        Me.PictureBox5.Location = New System.Drawing.Point(209, 28)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(31, 24)
        Me.PictureBox5.TabIndex = 1
        Me.PictureBox5.TabStop = False
        '
        'RoundedPane23
        '
        Me.RoundedPane23.BorderColor = System.Drawing.Color.LightGray
        Me.RoundedPane23.BorderThickness = 1
        Me.RoundedPane23.Controls.Add(Me.Label5)
        Me.RoundedPane23.Controls.Add(Me.Label7)
        Me.RoundedPane23.Controls.Add(Me.PictureBox6)
        Me.RoundedPane23.CornerRadius = 15
        Me.RoundedPane23.FillColor = System.Drawing.Color.White
        Me.RoundedPane23.Location = New System.Drawing.Point(560, 127)
        Me.RoundedPane23.Name = "RoundedPane23"
        Me.RoundedPane23.Size = New System.Drawing.Size(253, 105)
        Me.RoundedPane23.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label7.Location = New System.Drawing.Point(14, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Employees"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = Global.InformationManagement.My.Resources.Resources.user__4_
        Me.PictureBox6.Location = New System.Drawing.Point(209, 28)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(31, 24)
        Me.PictureBox6.TabIndex = 1
        Me.PictureBox6.TabStop = False
        '
        'RoundedPane24
        '
        Me.RoundedPane24.BorderColor = System.Drawing.Color.LightGray
        Me.RoundedPane24.BorderThickness = 1
        Me.RoundedPane24.Controls.Add(Me.Label9)
        Me.RoundedPane24.Controls.Add(Me.Label8)
        Me.RoundedPane24.Controls.Add(Me.PictureBox7)
        Me.RoundedPane24.CornerRadius = 15
        Me.RoundedPane24.FillColor = System.Drawing.Color.White
        Me.RoundedPane24.Location = New System.Drawing.Point(826, 127)
        Me.RoundedPane24.Name = "RoundedPane24"
        Me.RoundedPane24.Size = New System.Drawing.Size(253, 105)
        Me.RoundedPane24.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label8.Location = New System.Drawing.Point(14, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 19)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Customers"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = Global.InformationManagement.My.Resources.Resources.user__4_
        Me.PictureBox7.Location = New System.Drawing.Point(209, 28)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(31, 24)
        Me.PictureBox7.TabIndex = 1
        Me.PictureBox7.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(26, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label5.Location = New System.Drawing.Point(31, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 30)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label9.Location = New System.Drawing.Point(25, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 30)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "2"
        '
        'UsersAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1121, 527)
        Me.Controls.Add(Me.RoundedPane24)
        Me.Controls.Add(Me.RoundedPane23)
        Me.Controls.Add(Me.RoundedPane22)
        Me.Controls.Add(Me.RoundedPane21)
        Me.Controls.Add(Me.Adduserbtn)
        Me.Controls.Add(Me.UsersAccountData)
        Me.Controls.Add(Me.Customerbtn)
        Me.Controls.Add(Me.Employeesbtn)
        Me.Controls.Add(Me.Staffbtn)
        Me.Controls.Add(Me.AllUsersbtn)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersAccountData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoundedPane21.ResumeLayout(False)
        Me.RoundedPane21.PerformLayout()
        Me.RoundedPane22.ResumeLayout(False)
        Me.RoundedPane22.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoundedPane23.ResumeLayout(False)
        Me.RoundedPane23.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoundedPane24.ResumeLayout(False)
        Me.RoundedPane24.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents AllUsersbtn As Button
    Friend WithEvents Staffbtn As Button
    Friend WithEvents Employeesbtn As Button
    Friend WithEvents Customerbtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents UsersAccountData As DataGridView
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents phone As DataGridViewTextBoxColumn
    Friend WithEvents role As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents joinDate As DataGridViewTextBoxColumn
    Friend WithEvents actions As DataGridViewTextBoxColumn
    Friend WithEvents Adduserbtn As RoundedButton
    Friend WithEvents Name As DataGridViewTextBoxColumn
    Friend WithEvents colEmail As DataGridViewTextBoxColumn
    Friend WithEvents colPhone As DataGridViewTextBoxColumn
    Friend WithEvents colRole As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colJoinDate As DataGridViewTextBoxColumn
    Friend WithEvents colActions As DataGridViewButtonColumn
    Friend WithEvents RoundedPane21 As RoundedPane2
    Friend WithEvents RoundedPane22 As RoundedPane2
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents RoundedPane23 As RoundedPane2
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents RoundedPane24 As RoundedPane2
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
End Class
