Option Strict On
Option Explicit On

Imports System.IO

Public Class frmMessageBox

    Private Sub btnOui_Click(sender As Object, e As EventArgs) Handles btnOui.Click  
        'Lancement de l'utilitaire en mode utilisateur
        Try
            RunAsUserNow()
            CP.Close()
            Me.Close()
        Catch ex As Exception
            MsgBox("Impossible de lancer l'utilitaire, " & ex.Message, _
                MsgBoxStyle.Information, My.Application.GetType.Name)
        End Try
    End Sub

    Private Sub btnNon_Click(sender As Object, e As EventArgs) Handles btnNon.Click
        'Supression des fichiers temporaires et lancement du tools en mode limité
        Try
            If File.Exists(Path.GetTempPath & "\stf.guidb") Then
                Dim FormToShow As String
                FormToShow = System.IO.File.ReadAllText(Path.GetTempPath & "\stf.guidb")
                File.Delete(Path.GetTempPath & "\stf.guidb")
                OpenCloseGUIDosboxForm(FormToShow)
            End If
            'Fermeture.
            Me.Close()
        Catch ex As Exception
            MsgBox("Impossible de supprimer les fichiers temporaires, " & ex.Message, _
                 MsgBoxStyle.Information, My.Application.GetType.Name)
        End Try
    End Sub

End Class