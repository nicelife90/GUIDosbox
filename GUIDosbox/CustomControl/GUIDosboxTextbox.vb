Option Strict On

''' <summary>
''' Textbox personnalisé GUIDosbox
''' </summary>
Public Class GUIDosboxTextbox
    Inherits System.Windows.Forms.TextBox

    Public Sub New()
        Me.BackColor = Color.Black
        Me.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        Me.Font = New Font("Lucida Console", 8, FontStyle.Bold)
        Me.ForeColor = Color.LightBlue
    End Sub

End Class
