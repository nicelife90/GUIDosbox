Option Strict On

''' <summary>
''' Label personnalisé GUIDosbox
''' </summary>
Public Class GUIDosboxLabel
    Inherits System.Windows.Forms.Label

    Public Sub New()
        Me.BackColor = Color.Transparent
        Me.ForeColor = Color.LightBlue
        Me.Font = New Font("Lucida Console", 8, FontStyle.Bold)
    End Sub
End Class
