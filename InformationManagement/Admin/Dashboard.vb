Imports System.Windows.Forms.DataVisualization.Charting

Public Class Dashboard

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorTranslator.FromHtml("#F7F8FA")
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New Size(0, 1200)


        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer Or
            ControlStyles.AllPaintingInWmPaint Or
            ControlStyles.UserPaint, True)
        Me.UpdateStyles()
        ' In Form_Load

    End Sub
    Public Class FlickerFreePanel
        Inherits Panel

        Public Sub New()
            Me.DoubleBuffered = True
            Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            Me.UpdateStyles()
        End Sub
    End Class


    Private Sub Dashboard_Resize(sender As Object, e As EventArgs) Handles Me.Resize


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PanelRecentReservations_Paint(sender As Object, e As PaintEventArgs)

    End Sub




    Private Sub RoundedPane28_Paint(sender As Object, e As PaintEventArgs) Handles RoundedPane28.Paint

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub
End Class