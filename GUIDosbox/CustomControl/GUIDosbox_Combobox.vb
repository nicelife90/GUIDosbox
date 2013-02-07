Option Strict On

''' <summary>
''' Combobox personnalisé GUIDosbox.
''' </summary>
Public Class GUIDosbox_Combobox
    Inherits System.Windows.Forms.ComboBox

    Public Sub New()

        Me.BackColor = Color.Black
        Me.FlatStyle = FlatStyle.Flat
        Me.ForeColor = Color.LightBlue
        Me.Font = New Font("Lucida Console", 8, FontStyle.Regular)

    End Sub

End Class
