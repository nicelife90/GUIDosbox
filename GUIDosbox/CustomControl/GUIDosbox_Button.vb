' [--> GUIDosbox <--]
' Créé par : Nice-Life90
' http://www.guidosbox.com
' Copyright (C) 2010 - 2013 GUIDosbox - Montréal 
' Tous droits réservés

' [--> Contenue du fichhier <-] 
' Ce code est un Bouton personalisé.

Option Strict On
Option Explicit On

''' <summary>
''' Bouton personnalisé GUIDosbox
''' </summary>
Public Class GUIDosbox_Button
    Inherits System.Windows.Forms.Button
    Friend WithEvents GuiDosboxGroupbox1 As GUIDosbox.GUIDosbox_Groupbox

    Public Sub New()
        Me.BackColor = Color.Black
        Me.Cursor = Cursors.Hand
        Me.FlatStyle = Windows.Forms.FlatStyle.Flat
        Me.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40)
        Me.Font = New Font("Lucida Console", 8, FontStyle.Regular)
        Me.ForeColor = Color.LightBlue
        Me.MinimumSize = New Size(0, 23)
        Me.Size = New Size(82, 23)
    End Sub

End Class
