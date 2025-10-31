<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Staff1 = New System.Windows.Forms.Button()
        Me.AdminBot = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RoundedPanel1 = New InformationManagement.RoundedPanel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoundedPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(315, 26)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(296, 140)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Staff1
        '
        Me.Staff1.BackColor = System.Drawing.Color.White
        Me.Staff1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Staff1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff1.ForeColor = System.Drawing.Color.Red
        Me.Staff1.Location = New System.Drawing.Point(78, 42)
        Me.Staff1.Margin = New System.Windows.Forms.Padding(2)
        Me.Staff1.Name = "Staff1"
        Me.Staff1.Size = New System.Drawing.Size(148, 37)
        Me.Staff1.TabIndex = 5
        Me.Staff1.Text = "Staff"
        Me.Staff1.UseVisualStyleBackColor = False
        '
        'AdminBot
        '
        Me.AdminBot.BackColor = System.Drawing.Color.White
        Me.AdminBot.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AdminBot.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminBot.ForeColor = System.Drawing.Color.Red
        Me.AdminBot.Location = New System.Drawing.Point(78, 100)
        Me.AdminBot.Margin = New System.Windows.Forms.Padding(2)
        Me.AdminBot.Name = "AdminBot"
        Me.AdminBot.Size = New System.Drawing.Size(148, 33)
        Me.AdminBot.TabIndex = 6
        Me.AdminBot.Text = "Admin"
        Me.AdminBot.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(411, 147)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 46)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Login"
        '
        'RoundedPanel1
        '
        Me.RoundedPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RoundedPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RoundedPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.RoundedPanel1.Controls.Add(Me.AdminBot)
        Me.RoundedPanel1.Controls.Add(Me.Staff1)
        Me.RoundedPanel1.CornerRadius = 24
        Me.RoundedPanel1.Location = New System.Drawing.Point(315, 217)
        Me.RoundedPanel1.Name = "RoundedPanel1"
        Me.RoundedPanel1.Size = New System.Drawing.Size(298, 182)
        Me.RoundedPanel1.TabIndex = 8
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(898, 469)
        Me.Controls.Add(Me.RoundedPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoundedPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Staff1 As Button
    Friend WithEvents AdminBot As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents RoundedPanel1 As RoundedPanel
End Class
