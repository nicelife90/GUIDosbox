Option Strict On

''' <summary>
''' Checkbox personnalisé GUIDosbox
''' </summary>
Public Class GUIDosboxCheckbox
    Inherits System.Windows.Forms.CheckBox

    Public Sub New()
        Me.BackColor = Color.Transparent
        Me.ForeColor = Color.LightBlue
        Me.Font = New Font("Lucida Console", 8, FontStyle.Bold)
    End Sub

End Class
