﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsersAccounts
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UsersAccountData = New System.Windows.Forms.DataGridView()
        Me.RoundedPane21 = New InformationManagement.RoundedPane2()
        Me.lblTotalUsers = New System.Windows.Forms.Label()
        Me.RoundedPane22 = New InformationManagement.RoundedPane2()
        Me.lblStaffs = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RoundedPane23 = New InformationManagement.RoundedPane2()
        Me.lblEmployees = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RoundedPane24 = New InformationManagement.RoundedPane2()
        Me.lblCustomers = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRole = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colJoinDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Adduserbtn = New System.Windows.Forms.Button()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.colEdit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colDelete = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.UsersAccountData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoundedPane21.SuspendLayout()
        Me.RoundedPane22.SuspendLayout()
        Me.RoundedPane23.SuspendLayout()
        Me.RoundedPane24.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Accounts"
        '
        'AllUsersbtn
        '
        Me.AllUsersbtn.BackColor = System.Drawing.Color.White
        Me.AllUsersbtn.FlatAppearance.BorderSize = 0
        Me.AllUsersbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AllUsersbtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AllUsersbtn.Location = New System.Drawing.Point(28, 86)
        Me.AllUsersbtn.Name = "AllUsersbtn"
        Me.AllUsersbtn.Size = New System.Drawing.Size(130, 35)
        Me.AllUsersbtn.TabIndex = 1
        Me.AllUsersbtn.Text = "All Users"
        Me.AllUsersbtn.UseVisualStyleBackColor = False
        '
        'Staffbtn
        '
        Me.Staffbtn.BackColor = System.Drawing.Color.White
        Me.Staffbtn.FlatAppearance.BorderSize = 0
        Me.Staffbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Staffbtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staffbtn.Location = New System.Drawing.Point(175, 86)
        Me.Staffbtn.Name = "Staffbtn"
        Me.Staffbtn.Size = New System.Drawing.Size(130, 35)
        Me.Staffbtn.TabIndex = 2
        Me.Staffbtn.Text = "Staff"
        Me.Staffbtn.UseVisualStyleBackColor = False
        '
        'Employeesbtn
        '
        Me.Employeesbtn.BackColor = System.Drawing.Color.White
        Me.Employeesbtn.FlatAppearance.BorderSize = 0
        Me.Employeesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Employeesbtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Employeesbtn.Location = New System.Drawing.Point(325, 86)
        Me.Employeesbtn.Name = "Employeesbtn"
        Me.Employeesbtn.Size = New System.Drawing.Size(130, 35)
        Me.Employeesbtn.TabIndex = 3
        Me.Employeesbtn.Text = "Employees"
        Me.Employeesbtn.UseVisualStyleBackColor = False
        '
        'Customerbtn
        '
        Me.Customerbtn.BackColor = System.Drawing.Color.White
        Me.Customerbtn.FlatAppearance.BorderSize = 0
        Me.Customerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Customerbtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customerbtn.Location = New System.Drawing.Point(477, 86)
        Me.Customerbtn.Name = "Customerbtn"
        Me.Customerbtn.Size = New System.Drawing.Size(140, 35)
        Me.Customerbtn.TabIndex = 4
        Me.Customerbtn.Text = "Customers"
        Me.Customerbtn.UseVisualStyleBackColor = False
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
        Me.UsersAccountData.AllowUserToAddRows = False
        Me.UsersAccountData.AllowUserToDeleteRows = False
        Me.UsersAccountData.AllowUserToResizeColumns = False
        Me.UsersAccountData.AllowUserToResizeRows = False
        Me.UsersAccountData.BackgroundColor = System.Drawing.Color.White
        Me.UsersAccountData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UsersAccountData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.UsersAccountData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UsersAccountData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.UsersAccountData.ColumnHeadersHeight = 40
        Me.UsersAccountData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.UsersAccountData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Name, Me.colEmail, Me.colPhone, Me.colRole, Me.colStatus, Me.colJoinDate, Me.colEdit, Me.colDelete})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UsersAccountData.DefaultCellStyle = DataGridViewCellStyle7
        Me.UsersAccountData.EnableHeadersVisualStyles = False
        Me.UsersAccountData.GridColor = System.Drawing.Color.LightGray
        Me.UsersAccountData.Location = New System.Drawing.Point(28, 279)
        Me.UsersAccountData.Name = "UsersAccountData"
        Me.UsersAccountData.ReadOnly = True
        Me.UsersAccountData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.UsersAccountData.RowHeadersVisible = False
        Me.UsersAccountData.RowHeadersWidth = 55
        Me.UsersAccountData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        Me.UsersAccountData.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.UsersAccountData.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.UsersAccountData.RowTemplate.Height = 35
        Me.UsersAccountData.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.UsersAccountData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UsersAccountData.Size = New System.Drawing.Size(1051, 219)
        Me.UsersAccountData.TabIndex = 9
        '
        'RoundedPane21
        '
        Me.RoundedPane21.BorderColor = System.Drawing.Color.LightGray
        Me.RoundedPane21.BorderThickness = 1
        Me.RoundedPane21.Controls.Add(Me.PictureBox1)
        Me.RoundedPane21.Controls.Add(Me.lblTotalUsers)
        Me.RoundedPane21.Controls.Add(Me.Label2)
        Me.RoundedPane21.CornerRadius = 15
        Me.RoundedPane21.FillColor = System.Drawing.Color.White
        Me.RoundedPane21.Location = New System.Drawing.Point(28, 146)
        Me.RoundedPane21.Name = "RoundedPane21"
        Me.RoundedPane21.Size = New System.Drawing.Size(253, 105)
        Me.RoundedPane21.TabIndex = 11
        '
        'lblTotalUsers
        '
        Me.lblTotalUsers.AutoSize = True
        Me.lblTotalUsers.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalUsers.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalUsers.Location = New System.Drawing.Point(22, 52)
        Me.lblTotalUsers.Name = "lblTotalUsers"
        Me.lblTotalUsers.Size = New System.Drawing.Size(26, 30)
        Me.lblTotalUsers.TabIndex = 2
        Me.lblTotalUsers.Text = "5"
        '
        'RoundedPane22
        '
        Me.RoundedPane22.BorderColor = System.Drawing.Color.LightGray
        Me.RoundedPane22.BorderThickness = 1
        Me.RoundedPane22.Controls.Add(Me.lblStaffs)
        Me.RoundedPane22.Controls.Add(Me.Label6)
        Me.RoundedPane22.Controls.Add(Me.PictureBox5)
        Me.RoundedPane22.CornerRadius = 15
        Me.RoundedPane22.FillColor = System.Drawing.Color.White
        Me.RoundedPane22.Location = New System.Drawing.Point(294, 146)
        Me.RoundedPane22.Name = "RoundedPane22"
        Me.RoundedPane22.Size = New System.Drawing.Size(253, 105)
        Me.RoundedPane22.TabIndex = 12
        '
        'lblStaffs
        '
        Me.lblStaffs.AutoSize = True
        Me.lblStaffs.BackColor = System.Drawing.Color.Transparent
        Me.lblStaffs.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffs.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblStaffs.Location = New System.Drawing.Point(26, 52)
        Me.lblStaffs.Name = "lblStaffs"
        Me.lblStaffs.Size = New System.Drawing.Size(26, 30)
        Me.lblStaffs.TabIndex = 3
        Me.lblStaffs.Text = "2"
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
        'RoundedPane23
        '
        Me.RoundedPane23.BorderColor = System.Drawing.Color.LightGray
        Me.RoundedPane23.BorderThickness = 1
        Me.RoundedPane23.Controls.Add(Me.lblEmployees)
        Me.RoundedPane23.Controls.Add(Me.Label7)
        Me.RoundedPane23.Controls.Add(Me.PictureBox6)
        Me.RoundedPane23.CornerRadius = 15
        Me.RoundedPane23.FillColor = System.Drawing.Color.White
        Me.RoundedPane23.Location = New System.Drawing.Point(560, 146)
        Me.RoundedPane23.Name = "RoundedPane23"
        Me.RoundedPane23.Size = New System.Drawing.Size(253, 105)
        Me.RoundedPane23.TabIndex = 13
        '
        'lblEmployees
        '
        Me.lblEmployees.AutoSize = True
        Me.lblEmployees.BackColor = System.Drawing.Color.Transparent
        Me.lblEmployees.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployees.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblEmployees.Location = New System.Drawing.Point(31, 52)
        Me.lblEmployees.Name = "lblEmployees"
        Me.lblEmployees.Size = New System.Drawing.Size(26, 30)
        Me.lblEmployees.TabIndex = 3
        Me.lblEmployees.Text = "1"
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
        'RoundedPane24
        '
        Me.RoundedPane24.BorderColor = System.Drawing.Color.LightGray
        Me.RoundedPane24.BorderThickness = 1
        Me.RoundedPane24.Controls.Add(Me.lblCustomers)
        Me.RoundedPane24.Controls.Add(Me.Label8)
        Me.RoundedPane24.Controls.Add(Me.PictureBox7)
        Me.RoundedPane24.CornerRadius = 15
        Me.RoundedPane24.FillColor = System.Drawing.Color.White
        Me.RoundedPane24.Location = New System.Drawing.Point(826, 146)
        Me.RoundedPane24.Name = "RoundedPane24"
        Me.RoundedPane24.Size = New System.Drawing.Size(253, 105)
        Me.RoundedPane24.TabIndex = 12
        '
        'lblCustomers
        '
        Me.lblCustomers.AutoSize = True
        Me.lblCustomers.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomers.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomers.ForeColor = System.Drawing.Color.DarkViolet
        Me.lblCustomers.Location = New System.Drawing.Point(25, 52)
        Me.lblCustomers.Name = "lblCustomers"
        Me.lblCustomers.Size = New System.Drawing.Size(26, 30)
        Me.lblCustomers.TabIndex = 3
        Me.lblCustomers.Text = "2"
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
        'Name
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Name.DefaultCellStyle = DataGridViewCellStyle6
        Me.Name.HeaderText = "Name"
        Me.Name.Name = "Name"
        Me.Name.ReadOnly = True
        Me.Name.Width = 152
        '
        'colEmail
        '
        Me.colEmail.HeaderText = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.ReadOnly = True
        Me.colEmail.Width = 152
        '
        'colPhone
        '
        Me.colPhone.HeaderText = "Phone"
        Me.colPhone.Name = "colPhone"
        Me.colPhone.ReadOnly = True
        Me.colPhone.Width = 152
        '
        'colRole
        '
        Me.colRole.HeaderText = "Role"
        Me.colRole.Name = "colRole"
        Me.colRole.ReadOnly = True
        Me.colRole.Width = 151
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        Me.colStatus.Width = 152
        '
        'colJoinDate
        '
        Me.colJoinDate.HeaderText = "Join Date"
        Me.colJoinDate.Name = "colJoinDate"
        Me.colJoinDate.ReadOnly = True
        Me.colJoinDate.Width = 152
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Actions"
        Me.DataGridViewImageColumn1.Image = Global.InformationManagement.My.Resources.Resources.edit
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 80
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = Global.InformationManagement.My.Resources.Resources.delete
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn2.Width = 80
        '
        'Adduserbtn
        '
        Me.Adduserbtn.BackColor = System.Drawing.SystemColors.ControlText
        Me.Adduserbtn.FlatAppearance.BorderSize = 0
        Me.Adduserbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Adduserbtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Adduserbtn.ForeColor = System.Drawing.Color.White
        Me.Adduserbtn.Image = CType(resources.GetObject("Adduserbtn.Image"), System.Drawing.Image)
        Me.Adduserbtn.Location = New System.Drawing.Point(939, 17)
        Me.Adduserbtn.Name = "Adduserbtn"
        Me.Adduserbtn.Size = New System.Drawing.Size(140, 40)
        Me.Adduserbtn.TabIndex = 14
        Me.Adduserbtn.Text = "   Add User"
        Me.Adduserbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Adduserbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Adduserbtn.UseVisualStyleBackColor = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = Global.InformationManagement.My.Resources.Resources.user__6_
        Me.PictureBox7.Location = New System.Drawing.Point(209, 28)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(31, 24)
        Me.PictureBox7.TabIndex = 1
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = Global.InformationManagement.My.Resources.Resources.user__7_
        Me.PictureBox6.Location = New System.Drawing.Point(209, 28)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(31, 24)
        Me.PictureBox6.TabIndex = 1
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(209, 28)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(31, 24)
        Me.PictureBox5.TabIndex = 1
        Me.PictureBox5.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.InformationManagement.My.Resources.Resources.user__4_
        Me.PictureBox1.Location = New System.Drawing.Point(199, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 24)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'colEdit
        '
        Me.colEdit.HeaderText = "Actions"
        Me.colEdit.Image = Global.InformationManagement.My.Resources.Resources.edit
        Me.colEdit.Name = "colEdit"
        Me.colEdit.ReadOnly = True
        Me.colEdit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colEdit.Width = 80
        '
        'colDelete
        '
        Me.colDelete.HeaderText = ""
        Me.colDelete.Image = Global.InformationManagement.My.Resources.Resources.delete
        Me.colDelete.Name = "colDelete"
        Me.colDelete.ReadOnly = True
        Me.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colDelete.Width = 80
        '
        'UsersAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1121, 527)
        Me.Controls.Add(Me.Adduserbtn)
        Me.Controls.Add(Me.RoundedPane24)
        Me.Controls.Add(Me.RoundedPane23)
        Me.Controls.Add(Me.RoundedPane22)
        Me.Controls.Add(Me.RoundedPane21)
        Me.Controls.Add(Me.UsersAccountData)
        Me.Controls.Add(Me.Customerbtn)
        Me.Controls.Add(Me.Employeesbtn)
        Me.Controls.Add(Me.Staffbtn)
        Me.Controls.Add(Me.AllUsersbtn)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        CType(Me.UsersAccountData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoundedPane21.ResumeLayout(False)
        Me.RoundedPane21.PerformLayout()
        Me.RoundedPane22.ResumeLayout(False)
        Me.RoundedPane22.PerformLayout()
        Me.RoundedPane23.ResumeLayout(False)
        Me.RoundedPane23.PerformLayout()
        Me.RoundedPane24.ResumeLayout(False)
        Me.RoundedPane24.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblTotalUsers As Label
    Friend WithEvents lblStaffs As Label
    Friend WithEvents lblEmployees As Label
    Friend WithEvents lblCustomers As Label
    Friend WithEvents Adduserbtn As Button
    Friend WithEvents Name As DataGridViewTextBoxColumn
    Friend WithEvents colEmail As DataGridViewTextBoxColumn
    Friend WithEvents colPhone As DataGridViewTextBoxColumn
    Friend WithEvents colRole As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colJoinDate As DataGridViewTextBoxColumn
    Friend WithEvents colEdit As DataGridViewImageColumn
    Friend WithEvents colDelete As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
End Class
