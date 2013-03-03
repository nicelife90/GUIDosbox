' [--> GUIDosbox <--]
' Créé par : Nice-Life90
' http://www.guidosbox.com
' Copyright (C) 2010 - 2013 GUIDosbox - Montréal 
' Tous droits réservés

' [--> Contenue du fichhier <-] 
' Ce code est un CComboBox personalisé.

Option Strict On
Option Explicit On

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
