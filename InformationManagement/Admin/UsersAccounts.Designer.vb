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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsersAccounts))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AllUsersbtn = New System.Windows.Forms.Button()
        Me.Staffbtn = New System.Windows.Forms.Button()
        Me.Employeesbtn = New System.Windows.Forms.Button()
        Me.Customerbtn = New System.Windows.Forms.Button()
        Me.RoundedPanel1 = New InformationManagement.RoundedPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RoundedPanel2 = New InformationManagement.RoundedPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RoundedPanel3 = New InformationManagement.RoundedPanel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RoundedPanel4 = New InformationManagement.RoundedPanel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UsersAccountData = New System.Windows.Forms.DataGridView()
        Me.Adduserbtn = New InformationManagement.RoundedButton()
        Me.Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRole = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colJoinDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colActions = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.RoundedPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoundedPanel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoundedPanel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoundedPanel4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersAccountData, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.AllUsersbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.AllUsersbtn.Location = New System.Drawing.Point(28, 69)
        Me.AllUsersbtn.Name = "AllUsersbtn"
        Me.AllUsersbtn.Size = New System.Drawing.Size(130, 30)
        Me.AllUsersbtn.TabIndex = 1
        Me.AllUsersbtn.Text = "All Users"
        Me.AllUsersbtn.UseVisualStyleBackColor = True
        '
        'Staffbtn
        '
        Me.Staffbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Staffbtn.Location = New System.Drawing.Point(174, 69)
        Me.Staffbtn.Name = "Staffbtn"
        Me.Staffbtn.Size = New System.Drawing.Size(130, 30)
        Me.Staffbtn.TabIndex = 2
        Me.Staffbtn.Text = "Staff"
        Me.Staffbtn.UseVisualStyleBackColor = True
        '
        'Employeesbtn
        '
        Me.Employeesbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Employeesbtn.Location = New System.Drawing.Point(325, 69)
        Me.Employeesbtn.Name = "Employeesbtn"
        Me.Employeesbtn.Size = New System.Drawing.Size(130, 30)
        Me.Employeesbtn.TabIndex = 3
        Me.Employeesbtn.Text = "Employees"
        Me.Employeesbtn.UseVisualStyleBackColor = True
        '
        'Customerbtn
        '
        Me.Customerbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Customerbtn.Location = New System.Drawing.Point(477, 69)
        Me.Customerbtn.Name = "Customerbtn"
        Me.Customerbtn.Size = New System.Drawing.Size(130, 30)
        Me.Customerbtn.TabIndex = 4
        Me.Customerbtn.Text = "Customers"
        Me.Customerbtn.UseVisualStyleBackColor = True
        '
        'RoundedPanel1
        '
        Me.RoundedPanel1.BackColor = System.Drawing.Color.White
        Me.RoundedPanel1.Controls.Add(Me.PictureBox1)
        Me.RoundedPanel1.Controls.Add(Me.Label2)
        Me.RoundedPanel1.CornerRadius = 20
        Me.RoundedPanel1.Location = New System.Drawing.Point(28, 117)
        Me.RoundedPanel1.Name = "RoundedPanel1"
        Me.RoundedPanel1.Size = New System.Drawing.Size(253, 105)
        Me.RoundedPanel1.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.InformationManagement.My.Resources.Resources.user__4_
        Me.PictureBox1.Location = New System.Drawing.Point(208, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 24)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(13, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Total Users"
        '
        'RoundedPanel2
        '
        Me.RoundedPanel2.BackColor = System.Drawing.Color.White
        Me.RoundedPanel2.Controls.Add(Me.PictureBox2)
        Me.RoundedPanel2.Controls.Add(Me.Label3)
        Me.RoundedPanel2.CornerRadius = 20
        Me.RoundedPanel2.Location = New System.Drawing.Point(297, 117)
        Me.RoundedPanel2.Name = "RoundedPanel2"
        Me.RoundedPanel2.Size = New System.Drawing.Size(253, 105)
        Me.RoundedPanel2.TabIndex = 7
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(206, 40)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 24)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(13, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Staff Members"
        '
        'RoundedPanel3
        '
        Me.RoundedPanel3.BackColor = System.Drawing.Color.White
        Me.RoundedPanel3.Controls.Add(Me.PictureBox3)
        Me.RoundedPanel3.Controls.Add(Me.Label4)
        Me.RoundedPanel3.CornerRadius = 20
        Me.RoundedPanel3.Location = New System.Drawing.Point(570, 117)
        Me.RoundedPanel3.Name = "RoundedPanel3"
        Me.RoundedPanel3.Size = New System.Drawing.Size(253, 105)
        Me.RoundedPanel3.TabIndex = 8
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.InformationManagement.My.Resources.Resources.user__4_
        Me.PictureBox3.Location = New System.Drawing.Point(207, 40)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(31, 24)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(13, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Employees"
        '
        'RoundedPanel4
        '
        Me.RoundedPanel4.BackColor = System.Drawing.Color.White
        Me.RoundedPanel4.Controls.Add(Me.PictureBox4)
        Me.RoundedPanel4.Controls.Add(Me.Label5)
        Me.RoundedPanel4.CornerRadius = 20
        Me.RoundedPanel4.Location = New System.Drawing.Point(838, 117)
        Me.RoundedPanel4.Name = "RoundedPanel4"
        Me.RoundedPanel4.Size = New System.Drawing.Size(253, 105)
        Me.RoundedPanel4.TabIndex = 7
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.InformationManagement.My.Resources.Resources.user__4_
        Me.PictureBox4.Location = New System.Drawing.Point(202, 40)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(31, 24)
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(13, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Customers"
        '
        'UsersAccountData
        '
        Me.UsersAccountData.BackgroundColor = System.Drawing.Color.White
        Me.UsersAccountData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UsersAccountData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.UsersAccountData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UsersAccountData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.UsersAccountData.ColumnHeadersHeight = 40
        Me.UsersAccountData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Name, Me.colEmail, Me.colPhone, Me.colRole, Me.colStatus, Me.colJoinDate, Me.colActions})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UsersAccountData.DefaultCellStyle = DataGridViewCellStyle3
        Me.UsersAccountData.EnableHeadersVisualStyles = False
        Me.UsersAccountData.GridColor = System.Drawing.Color.LightGray
        Me.UsersAccountData.Location = New System.Drawing.Point(28, 244)
        Me.UsersAccountData.Name = "UsersAccountData"
        Me.UsersAccountData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.UsersAccountData.RowHeadersVisible = False
        Me.UsersAccountData.RowHeadersWidth = 55
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.UsersAccountData.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.UsersAccountData.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.UsersAccountData.RowTemplate.Height = 35
        Me.UsersAccountData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.UsersAccountData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UsersAccountData.Size = New System.Drawing.Size(1063, 219)
        Me.UsersAccountData.TabIndex = 9
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
        'Name
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Name.DefaultCellStyle = DataGridViewCellStyle2
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
        'UsersAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1121, 527)
        Me.Controls.Add(Me.Adduserbtn)
        Me.Controls.Add(Me.UsersAccountData)
        Me.Controls.Add(Me.RoundedPanel4)
        Me.Controls.Add(Me.RoundedPanel3)
        Me.Controls.Add(Me.RoundedPanel2)
        Me.Controls.Add(Me.RoundedPanel1)
        Me.Controls.Add(Me.Customerbtn)
        Me.Controls.Add(Me.Employeesbtn)
        Me.Controls.Add(Me.Staffbtn)
        Me.Controls.Add(Me.AllUsersbtn)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.RoundedPanel1.ResumeLayout(False)
        Me.RoundedPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoundedPanel2.ResumeLayout(False)
        Me.RoundedPanel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoundedPanel3.ResumeLayout(False)
        Me.RoundedPanel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoundedPanel4.ResumeLayout(False)
        Me.RoundedPanel4.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersAccountData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents AllUsersbtn As Button
    Friend WithEvents Staffbtn As Button
    Friend WithEvents Employeesbtn As Button
    Friend WithEvents Customerbtn As Button
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents RoundedPanel3 As RoundedPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents RoundedPanel4 As RoundedPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents UsersAccountData As DataGridView
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents phone As DataGridViewTextBoxColumn
    Friend WithEvents role As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents joinDate As DataGridViewTextBoxColumn
    Friend WithEvents actions As DataGridViewTextBoxColumn
    Friend WithEvents Adduserbtn As RoundedButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Name As DataGridViewTextBoxColumn
    Friend WithEvents colEmail As DataGridViewTextBoxColumn
    Friend WithEvents colPhone As DataGridViewTextBoxColumn
    Friend WithEvents colRole As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colJoinDate As DataGridViewTextBoxColumn
    Friend WithEvents colActions As DataGridViewButtonColumn
End Class
