Option Strict On
''' <summary>
''' Groupbox personnalisé GUIDosbox.
''' </summary>
Public Class GUIDosbox_Groupbox
    Inherits System.Windows.Forms.GroupBox

    Private _borderColor As Color = Color.LightBlue

    Public Sub New()
        Me.BackColor = Color.Black
        Me.ForeColor = Color.LightBlue
        Me.Font = New Font("Lucida Console", 8, FontStyle.Regular)
    End Sub

    Public Property BorderColor() As Color
        Get
            Return Me._borderColor
        End Get
        Set(ByVal value As Color)
            Me._borderColor = value
        End Set
    End Property

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim tSize As Size = TextRenderer.MeasureText(Me.Text, Me.Font)
        Dim borderRect As Rectangle = e.ClipRectangle
        borderRect.Y = CInt((borderRect.Y + (tSize.Height / 2)))
        borderRect.Height = CInt((borderRect.Height - (tSize.Height / 2)))
        ControlPaint.DrawBorder(e.Graphics, borderRect, Me._borderColor, ButtonBorderStyle.Solid)
        Dim textRect As Rectangle = e.ClipRectangle
        textRect.X = (textRect.X + 6)
        textRect.Width = tSize.Width
        textRect.Height = tSize.Height
        e.Graphics.FillRectangle(New SolidBrush(Me.BackColor), textRect)
        e.Graphics.DrawString(Me.Text, Me.Font, New SolidBrush(Me.ForeColor), textRect)
    End Sub

End Class

    