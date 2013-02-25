' [--> GUIDosbox <--]
' Créé par : Nice-Life90
' http://www.kobixxe.com
' Copyright (C) 2010 - 2013 Kobixxe - Montréal 
' Tous droits réservés

' [--> Contenue du fichhier <-] 
' frmBatEditLoader


Option Strict On
Option Explicit On

Public Class frmBatEditLoader

    Private Sub frmBatEditLoader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Timer start.
        Timer1.Interval = 1
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Affichage de l'avancement du loading
        ProgressBar1.Value = ColorationsProgresStatus
        Label2.Text = "Lignes traitées : " & CStr(ColorationProgressLine) & " " & ColorationProgressOutput
        'Fermeture si frmBatEdit est loader et afficher.
        If loaded = True Then
            Me.Close()
        End If
    End Sub
End Class