Option Strict On
Option Explicit On

''' <summary>
''' Textbox personnalisé GUIDosbox.
''' </summary>
Public Class GUIDosbox_Textbox
    Inherits System.Windows.Forms.TextBox

    Public Sub New()
        Me.BackColor = Color.Black
        Me.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        Me.Font = New Font("Lucida Console", 8, FontStyle.Regular)
        Me.ForeColor = Color.LightBlue
    End Sub

    Public Sub on_Focus() Handles Me.GotFocus
        Me.BackColor = Color.FromArgb(25, 25, 25)
        Me.Text = Nothing
    End Sub

    Public Sub on_lostFocus() Handles Me.LostFocus
        Me.BackColor = Color.Black
    End Sub

End Class
