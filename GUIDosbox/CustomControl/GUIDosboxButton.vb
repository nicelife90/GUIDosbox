Option Strict On

''' <summary>
''' Bouton personnalisé GUIDosbox
''' </summary>
Public Class GUIDosboxButton
    Inherits System.Windows.Forms.Button
    Friend WithEvents GuiDosboxGroupbox1 As GUIDosbox.GUIDosboxGroupbox

    Public Sub New()


        Me.BackColor = Color.Black
        Me.Cursor = Cursors.Hand
        Me.FlatStyle = Windows.Forms.FlatStyle.Flat
        Me.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40)
        Me.Font = New Font("Lucida Console", 8, FontStyle.Bold)
        Me.ForeColor = Color.LightBlue

    End Sub

End Class
