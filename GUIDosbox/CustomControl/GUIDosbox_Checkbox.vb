Option Strict On

''' <summary>
''' Checkbox personnalisé GUIDosbox.
''' </summary>
Public Class GUIDosbox_Checkbox
    Inherits System.Windows.Forms.CheckBox

    Public Sub New()
        Me.BackColor = Color.Black
        Me.ForeColor = Color.RoyalBlue
        Me.Font = New Font("Lucida Console", 8, FontStyle.Regular)
        Me.FlatStyle = Windows.Forms.FlatStyle.Flat
    End Sub

End Class
