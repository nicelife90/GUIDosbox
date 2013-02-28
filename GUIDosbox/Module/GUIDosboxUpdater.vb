' [--> GUIDosbox <--]
' Créé par : Nice-Life90
' http://www.kobixxe.com
' Copyright (C) 2010 - 2013 Kobixxe - Montréal 
' Tous droits réservés

' [--> Contenue du fichhier <-] 
' Ce module contient le système de mise à jour de GUIDosbox. 

Option Strict On
Option Explicit On

Imports System.IO
Imports System.ComponentModel

Module GUIDosboxUpdater

    ''' <summary>
    ''' Définition des variable pour le système de mise à jour.
    ''' </summary>
    ''' <remarks></remarks>
    Public file_path As String = Path.GetTempPath
    Private application_name As String = My.Application.Info.ProductName
    Public WithEvents bgworkerCheckVersion As BackgroundWorker = New BackgroundWorker

    ''' <summary>
    ''' Affectation des paramètres au backgroundWorker
    ''' </summary>
    ''' <remarks></remarks>
    Sub New()
        bgworkerCheckVersion.WorkerReportsProgress = True
        bgworkerCheckVersion.WorkerSupportsCancellation = True
    End Sub

    ''' <summary>
    ''' Vérification de la version du programme.
    ''' </summary>
    ''' <remarks>
    ''' Définition des constante de cette méthode :
    ''' 
    ''' CheckVersionURL = L'adresse du fichier version situé sur un serveur.
    ''' ActualVersion   = La version courante du programme ex: 3.2.0
    ''' </remarks>
    Private Sub bgworkerCheckVersion_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgworkerCheckVersion.DoWork
        Try
            'Constante pour la vérification de`la version du programme
            Const CheckVersionURL As String = "https://dl.dropbox.com/u/68710014/Launcher335/version"
            Const ActualVersion As String = "4.0.9" '-> ici pour changer la version du programme

            'Supression de l'ancien fichier de version.
            If My.Computer.FileSystem.FileExists(file_path + "version") Then
                My.Computer.FileSystem.DeleteFile(file_path + "version")
            End If

            'Téléchargement du nouveau fichier de version.
            My.Computer.Network.DownloadFile(CheckVersionURL, file_path + "version")

            'Lecture du nouveau fichier version.
            If My.Computer.FileSystem.FileExists(file_path + "version") Then

                'Création d'un reader pour le fichier de version.
                Dim reader As New System.IO.StreamReader(file_path + "version")
                Dim read As String = reader.ReadToEnd
                reader.Close()

                'Vérification de la version 
                If read <> ActualVersion Then

                    'Avertissement d'une nouvelle version disponible.
                    If MsgBox("Une nouvelle version est maintenant disponible pour " + application_name + "." + vbCrLf + vbCrLf + _
                            "Vous utilisé actuellement la version " + ActualVersion + " de cette application." + vbCrLf + _
                            "La version la plus récente de " + application_name + " est la version " + read + "." + _
                            vbCrLf + vbCrLf + "La programme de mise à jour sera automatiquement lancé à la fermeture de cette fenêtre." + _
                            vbCrLf + vbCrLf + "Appuyez sur OK pour lancé la mise à jour ou sur Annuler pour continuer d'utiliser cette version.", _
                            MsgBoxStyle.OkCancel, application_name + " - Mise à jour disponible") = MsgBoxResult.Ok Then

                        'Lancement de la mise à jour -> Voir bgworkerCheckVersion_ProgressChanged
                        bgworkerCheckVersion.ReportProgress(0)
                        bgworkerCheckVersion.CancelAsync()
                    Else
                        'On supprime le fichier de version.
                        If My.Computer.FileSystem.FileExists(file_path + "\version") Then
                            My.Computer.FileSystem.DeleteFile(file_path + "\version")
                        End If
                        'On cancel le lancement de la mise à jour.
                        bgworkerCheckVersion.CancelAsync()
                    End If

                Else '-> Si l'utilisateur tente de vérifier les mise à jour à partir du menu.
                    'If UpdateFromMenu = True Then
                    '    MsgBox("Aucune mise à jour disponible actuellement.", MsgBoxStyle.Information, application_name & " - Mise à jour")
                    'End If
                End If

            Else
                MsgBox("Une erreur c'est produite lors de la vérification de la version du programme.", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception
            MsgBox("Une erreur inattendue c’est produite avec le système de mise à jour, " & ex.Message & _
                   vbCrLf & vbCrLf & "Vous pouvez réessayer la mise à jour via le bouton « Menu ».", _
                   MsgBoxStyle.Critical, application_name & " - Mise à jour")
        End Try
    End Sub

    Private Sub bgworkerCheckVersion_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgworkerCheckVersion.ProgressChanged
        'Gestion des contrôles d'utilisateurs
        CP.GuiDosbox_ProgressBar1.Visible = True
        CP.MenuStrip1.Enabled = False
        CP.FlashCPEN.Visible = False
        CP.FlashCPFR.Visible = False

        'Début du téléchargement de la mise à jour
        DownloadUpdate()
    End Sub

    ''' <summary>
    ''' Téléchargement de la mise à jour.
    ''' </summary>
    ''' <remarks>
    ''' Cette instruction utilise WebClient() et nécissite l'importation de System.Net pour le téléchargement de la mise à jour.
    ''' Pour utiliser WebClient() avec un ftp : 
    ''' 'wc.DownloadFileAsync(New Uri("ftp://UserName:Password@Host/Directory/File:Port"), file_path + "\update.exe")
    ''' </remarks>
    Private Sub DownloadUpdate()
        Try
            'On supprime le fichier de version.
            If My.Computer.FileSystem.FileExists(file_path + "\version") Then
                My.Computer.FileSystem.DeleteFile(file_path + "\version")
            End If

            'On supprime l'ancien fichier de mise à jour.
            If My.Computer.FileSystem.FileExists(file_path + "\update.exe") Then
                My.Computer.FileSystem.DeleteFile(file_path + "\update.exe")
            End If

            'On télécharge la mise à jour.
            Dim wc As System.Net.WebClient
            wc = New System.Net.WebClient()
            AddHandler wc.DownloadProgressChanged, AddressOf OnDownloadProgressChanged
            AddHandler wc.DownloadFileCompleted, AddressOf OnFileDownloadCompleted
            wc.DownloadFileAsync(New Uri("https://dl.dropbox.com/u/68710014/Launcher335/update.exe"), file_path + "\update.exe")

        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors du téléchargement de la mise à jour, " + ex.Message, MsgBoxStyle.Critical, application_name & " - Mise à jour")
        End Try
    End Sub

    ''' <summary>
    ''' Évenement qui ce produit tous au long du téléchargement de la mise à jours
    ''' </summary>
    ''' <remarks>Cette instruction affiche l'état du téléchargement</remarks>
    Private Sub OnDownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs)
        Dim downloadedBytes As Long = e.BytesReceived
        Dim percentage As Integer = e.ProgressPercentage
        CP.GuiDosbox_ProgressBar1.FillProgress = percentage
        CP.GuiDosbox_ProgressBar1.OutputText = CStr(Math.Round(downloadedBytes / 1024 / 1024, 2, MidpointRounding.AwayFromZero)) _
            & " / " & CStr(Math.Round(e.TotalBytesToReceive / 1024 / 1024, 2, MidpointRounding.AwayFromZero)) & " Mo Téléchargé"
    End Sub

    ''' <summary>
    ''' Évenement qui ce produit à la fin du téléchargement
    ''' </summary>
    ''' <remarks>Cette instruction affiche la fin du téléchargement et le lancement de la mise à jour</remarks>
    Private Sub OnFileDownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        CP.GuiDosbox_ProgressBar1.OutputText = "Téléchargement terminé, lancement du programme de mise à jour."
        Delay(1)
        Try
            'Création de fichiers d'information pour l'udater
            File.WriteAllText(file_path + "GUIDB_Start_Path", My.Application.Info.DirectoryPath)
            File.WriteAllText(file_path + "GUIDB_Name", System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName)

            'Démmarage de la mise à jour
            Process.Start(file_path + "\update.exe")
        Catch ex As Exception
            MsgBox("Une erreur c'est produite avec le lancement de la mise à jour, " & ex.Message)
        End Try
        Application.Exit()
    End Sub

End Module
