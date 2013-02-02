Option Strict On

''' <summary>
''' Groupbox personnalisé GUIDosbox
''' </summary>
Public Class GUIDosboxGroupbox
    Inherits System.Windows.Forms.GroupBox

    Public Sub New()
        Me.BackColor = Color.Black
        Me.ForeColor = Color.LightBlue
        Me.Font = New Font("Lucida Console", 8, FontStyle.Bold)
    End Sub

End Class
