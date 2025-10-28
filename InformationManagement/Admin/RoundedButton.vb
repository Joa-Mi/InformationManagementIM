Imports System.Drawing.Drawing2D

Public Class RoundedButton
    Inherits Button

    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)

        ' Create rounded rectangle path
        Dim path As New GraphicsPath()
        Dim radius As Integer = 13
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(Me.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(Me.Width - radius, Me.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, Me.Height - radius, radius, radius, 90, 90)
        path.CloseAllFigures()

        ' Apply rounded region
        Me.Region = New Region(path)

        ' Optional: Draw border
        Using pen As New Pen(Color.FromArgb(44, 62, 80), 2)
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias
            pevent.Graphics.DrawPath(pen, path)
        End Using
    End Sub
End Class
