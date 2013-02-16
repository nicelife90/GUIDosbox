Option Strict On
Option Explicit On

''' <summary>
''' Radio Bouton personnalisé GUIDosbox.
''' </summary>
Public Class GUIDosbox_RadioButton
    Inherits System.Windows.Forms.RadioButton

    Public Sub New()
        Me.BackColor = Color.Black
        Me.ForeColor = Color.RoyalBlue
        Me.Font = New Font("Lucida Console", 8, FontStyle.Regular)
        Me.FlatStyle = Windows.Forms.FlatStyle.Flat
    End Sub

End Class
