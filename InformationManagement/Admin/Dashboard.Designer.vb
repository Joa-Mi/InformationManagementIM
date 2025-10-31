<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lblTotalRevenue = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.RoundedPane21 = New InformationManagement.RoundedPane2()
        Me.RoundedPane22 = New InformationManagement.RoundedPane2()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.RoundedPane23 = New InformationManagement.RoundedPane2()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel5 = New InformationManagement.RoundedPane2()
        Me.RoundedPane25 = New InformationManagement.RoundedPane2()
        Me.RoundedPane26 = New InformationManagement.RoundedPane2()
        Me.RoundedPane27 = New InformationManagement.RoundedPane2()
        Me.RoundedPane24 = New InformationManagement.RoundedPane2()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoundedPane21.SuspendLayout()
        Me.RoundedPane22.SuspendLayout()
        Me.RoundedPane23.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.RoundedPane25.SuspendLayout()
        Me.RoundedPane26.SuspendLayout()
        Me.RoundedPane27.SuspendLayout()
        Me.RoundedPane24.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dashboard Overview"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label11.Location = New System.Drawing.Point(74, 150)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 16)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Tables Available"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label10.Location = New System.Drawing.Point(74, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 16)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Menu Items"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Quick Stats"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label9.Location = New System.Drawing.Point(74, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 16)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Active Staff"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(28, 55)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(20, 24)
        Me.PictureBox6.TabIndex = 14
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(8, 12)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(25, 18)
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Pending Orders"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Recent Reservations"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Top Menu Items"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(285, 15)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(21, 20)
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(280, 15)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'lblTotalRevenue
        '
        Me.lblTotalRevenue.AutoSize = True
        Me.lblTotalRevenue.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalRevenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.lblTotalRevenue.Location = New System.Drawing.Point(50, 76)
        Me.lblTotalRevenue.Name = "lblTotalRevenue"
        Me.lblTotalRevenue.Size = New System.Drawing.Size(139, 22)
        Me.lblTotalRevenue.TabIndex = 3
        Me.lblTotalRevenue.Text = "16, 400, 00.00"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 76)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(17, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Total Revenue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(286, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'RoundedPane21
        '
        Me.RoundedPane21.BorderColor = System.Drawing.Color.LightGray
        Me.RoundedPane21.BorderThickness = 1
        Me.RoundedPane21.Controls.Add(Me.PictureBox4)
        Me.RoundedPane21.Controls.Add(Me.Label2)
        Me.RoundedPane21.Controls.Add(Me.PictureBox1)
        Me.RoundedPane21.Controls.Add(Me.lblTotalRevenue)
        Me.RoundedPane21.CornerRadius = 15
        Me.RoundedPane21.FillColor = System.Drawing.Color.White
        Me.RoundedPane21.Location = New System.Drawing.Point(31, 72)
        Me.RoundedPane21.Name = "RoundedPane21"
        Me.RoundedPane21.Size = New System.Drawing.Size(330, 120)
        Me.RoundedPane21.TabIndex = 15
        '
        'RoundedPane22
        '
        Me.RoundedPane22.BorderColor = System.Drawing.Color.LightGray
        Me.RoundedPane22.BorderThickness = 1
        Me.RoundedPane22.Controls.Add(Me.PictureBox2)
        Me.RoundedPane22.Controls.Add(Me.Label13)
        Me.RoundedPane22.Controls.Add(Me.Label14)
        Me.RoundedPane22.CornerRadius = 15
        Me.RoundedPane22.FillColor = System.Drawing.Color.White
        Me.RoundedPane22.Location = New System.Drawing.Point(384, 72)
        Me.RoundedPane22.Name = "RoundedPane22"
        Me.RoundedPane22.Size = New System.Drawing.Size(330, 120)
        Me.RoundedPane22.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label13.Location = New System.Drawing.Point(17, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 16)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Total Orders"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 76)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 22)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "2,340"
        '
        'RoundedPane23
        '
        Me.RoundedPane23.BorderColor = System.Drawing.Color.LightGray
        Me.RoundedPane23.BorderThickness = 1
        Me.RoundedPane23.Controls.Add(Me.PictureBox3)
        Me.RoundedPane23.Controls.Add(Me.Label15)
        Me.RoundedPane23.Controls.Add(Me.Label16)
        Me.RoundedPane23.CornerRadius = 15
        Me.RoundedPane23.FillColor = System.Drawing.Color.White
        Me.RoundedPane23.Location = New System.Drawing.Point(737, 72)
        Me.RoundedPane23.Name = "RoundedPane23"
        Me.RoundedPane23.Size = New System.Drawing.Size(330, 120)
        Me.RoundedPane23.TabIndex = 17
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label15.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label15.Location = New System.Drawing.Point(17, 21)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(146, 16)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Active Reservations"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label16.Location = New System.Drawing.Point(16, 74)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 22)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "28"
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(20, 20)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(984, 312)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'Panel5
        '
        Me.Panel5.BorderColor = System.Drawing.Color.LightGray
        Me.Panel5.BorderThickness = 1
        Me.Panel5.Controls.Add(Me.Chart1)
        Me.Panel5.CornerRadius = 15
        Me.Panel5.FillColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(31, 222)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1034, 366)
        Me.Panel5.TabIndex = 18
        '
        'RoundedPane25
        '
        Me.RoundedPane25.BorderColor = System.Drawing.Color.LightGray
        Me.RoundedPane25.BorderThickness = 1
        Me.RoundedPane25.Controls.Add(Me.Label6)
        Me.RoundedPane25.CornerRadius = 15
        Me.RoundedPane25.FillColor = System.Drawing.Color.White
        Me.RoundedPane25.Location = New System.Drawing.Point(31, 634)
        Me.RoundedPane25.Name = "RoundedPane25"
        Me.RoundedPane25.Size = New System.Drawing.Size(505, 62)
        Me.RoundedPane25.TabIndex = 19
        '
        'RoundedPane26
        '
        Me.RoundedPane26.BorderColor = System.Drawing.Color.LightGray
        Me.RoundedPane26.BorderThickness = 1
        Me.RoundedPane26.Controls.Add(Me.PictureBox5)
        Me.RoundedPane26.Controls.Add(Me.Label5)
        Me.RoundedPane26.CornerRadius = 15
        Me.RoundedPane26.FillColor = System.Drawing.Color.White
        Me.RoundedPane26.Location = New System.Drawing.Point(31, 716)
        Me.RoundedPane26.Name = "RoundedPane26"
        Me.RoundedPane26.Size = New System.Drawing.Size(505, 62)
        Me.RoundedPane26.TabIndex = 20
        '
        'RoundedPane27
        '
        Me.RoundedPane27.BorderColor = System.Drawing.Color.LightGray
        Me.RoundedPane27.BorderThickness = 1
        Me.RoundedPane27.Controls.Add(Me.Label7)
        Me.RoundedPane27.CornerRadius = 15
        Me.RoundedPane27.FillColor = System.Drawing.Color.White
        Me.RoundedPane27.Location = New System.Drawing.Point(560, 634)
        Me.RoundedPane27.Name = "RoundedPane27"
        Me.RoundedPane27.Size = New System.Drawing.Size(505, 62)
        Me.RoundedPane27.TabIndex = 21
        '
        'RoundedPane24
        '
        Me.RoundedPane24.BorderColor = System.Drawing.Color.LightGray
        Me.RoundedPane24.BorderThickness = 1
        Me.RoundedPane24.Controls.Add(Me.Label8)
        Me.RoundedPane24.Controls.Add(Me.Label11)
        Me.RoundedPane24.Controls.Add(Me.PictureBox6)
        Me.RoundedPane24.Controls.Add(Me.Label10)
        Me.RoundedPane24.Controls.Add(Me.Label9)
        Me.RoundedPane24.CornerRadius = 15
        Me.RoundedPane24.FillColor = System.Drawing.Color.White
        Me.RoundedPane24.Location = New System.Drawing.Point(562, 716)
        Me.RoundedPane24.Name = "RoundedPane24"
        Me.RoundedPane24.Size = New System.Drawing.Size(505, 222)
        Me.RoundedPane24.TabIndex = 15
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1123, 749)
        Me.Controls.Add(Me.RoundedPane24)
        Me.Controls.Add(Me.RoundedPane27)
        Me.Controls.Add(Me.RoundedPane26)
        Me.Controls.Add(Me.RoundedPane25)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.RoundedPane23)
        Me.Controls.Add(Me.RoundedPane22)
        Me.Controls.Add(Me.RoundedPane21)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoundedPane21.ResumeLayout(False)
        Me.RoundedPane21.PerformLayout()
        Me.RoundedPane22.ResumeLayout(False)
        Me.RoundedPane22.PerformLayout()
        Me.RoundedPane23.ResumeLayout(False)
        Me.RoundedPane23.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.RoundedPane25.ResumeLayout(False)
        Me.RoundedPane25.PerformLayout()
        Me.RoundedPane26.ResumeLayout(False)
        Me.RoundedPane26.PerformLayout()
        Me.RoundedPane27.ResumeLayout(False)
        Me.RoundedPane27.PerformLayout()
        Me.RoundedPane24.ResumeLayout(False)
        Me.RoundedPane24.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblTotalRevenue As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents RoundedPane21 As RoundedPane2
    Friend WithEvents RoundedPane22 As RoundedPane2
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents RoundedPane23 As RoundedPane2
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Panel5 As RoundedPane2
    Friend WithEvents RoundedPane25 As RoundedPane2
    Friend WithEvents RoundedPane26 As RoundedPane2
    Friend WithEvents RoundedPane27 As RoundedPane2
    Friend WithEvents RoundedPane24 As RoundedPane2
End Class
