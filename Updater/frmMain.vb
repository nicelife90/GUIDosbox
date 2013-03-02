' [--> GUIDosbox Updater <--]
' Créé par : Nice-Life90
' http://www.guidosbox.com
' Copyright (C) 2010 - 2013 Kobixxe - Montréal 
' Tous droits réservés

' [--> Contenue du fichhier <-] 
' frmMain --> Form qui fais la mise la jour de GUIDosbox.

Option Strict On
Option Explicit On

Imports System.IO
Imports System.Environment

Public Class frmMain

    'Déffinition des variables
    Private extractionPath As String = Nothing
    Private OldName As String = Nothing
    Private file_path As String = Path.GetTempPath

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Affectation des variables pour la mise à jour.
        If File.Exists(file_path + "GUIDB_Start_Path") And File.Exists(file_path + "GUIDB_Name") Then
            extractionPath = ReadFileText(file_path + "GUIDB_Start_Path")
            OldName = ReadFileText(file_path + "GUIDB_Name")
        Else
            'Message d'erreur --> Impossible de localiser les fichiers requis.
            MsgBox("Une erreur inattendue c'est produite avec le système de mise à jour, réessayez de lancer la mise à jour de nouveau.", _
                   MsgBoxStyle.Critical, "Mise à jour")
            Me.Close()
        End If

        'Gestion de l'interface
        GuiDosbox_ProgressBar1.OutputText = "Prêt!"
        btnTerminer.Text = "Annuler"

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            'Premier affichage
            btnUpdate.Enabled = False
            GuiDosbox_ProgressBar1.OutputText = "Début de la mise à jour."
            GuiDosbox_ProgressBar1.FillProgress = 15
            Delay(1)

            'On supprime le fichier de version
            GuiDosbox_ProgressBar1.OutputText = "Supression de l'ancienne version du Launcher."
            If My.Computer.FileSystem.FileExists(OldName) Then
                My.Computer.FileSystem.DeleteFile(OldName)
            End If
            GuiDosbox_ProgressBar1.FillProgress = 35
            Delay(1)

            Try
                'Extraction de la mise à jour
                GuiDosbox_ProgressBar1.OutputText = "Extraction de la mise à jour."
                SaveToDisk("update.zip", My.Application.Info.DirectoryPath + "\update.zip")
                ExtractArchive(My.Application.Info.DirectoryPath + "\update.zip", extractionPath + "\")
                GuiDosbox_ProgressBar1.FillProgress = 60
                Delay(2)
            Catch ex As Exception
                GuiDosbox_ProgressBar1.OutputText = "Une erreur c'est produite avec l'extraction des fichiers, veuillez recommencer."
            End Try

            'Supression des fichiers temporaires
            GuiDosbox_ProgressBar1.OutputText = "Supression des fichiers temporaires."
            If System.IO.File.Exists(My.Application.Info.DirectoryPath + "\update.zip") Then
                System.IO.File.Delete(My.Application.Info.DirectoryPath + "\update.zip")
            End If
            If System.IO.File.Exists(My.Application.Info.DirectoryPath + "\version") Then
                System.IO.File.Delete(My.Application.Info.DirectoryPath + "\version")
            End If
            GuiDosbox_ProgressBar1.FillProgress = 80
            Delay(1)

            'Mise à jour terminé
            GuiDosbox_ProgressBar1.OutputText = "Mise à jour terminé!"
            GuiDosbox_ProgressBar1.FillProgress = 100
            btnUpdate.Enabled = False
            btnTerminer.Text = "Terminer"

        Catch ex As Exception
            GuiDosbox_ProgressBar1.OutputText = "Une erreur c'est produite, veuillez recommencer."
        End Try
    End Sub

    Private Sub btnTerminer_Click(sender As Object, e As EventArgs) Handles btnTerminer.Click
        Try
            If btnTerminer.Text = "Terminer" Then
                If My.Computer.FileSystem.FileExists(extractionPath + "\GUIDosbox.exe") Then
                    Process.Start(extractionPath + "\GUIDosbox.exe")
                End If
                Me.Close()
            Else
                Me.Close()
            End If
        Catch ex As Exception
            'Rien l'utilisateur a surement fermer la fenetre UAC
        End Try
    End Sub

End Class
