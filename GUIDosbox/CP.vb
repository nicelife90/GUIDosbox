' [--> GUIDosbox <--]
' Créé par : Nice-Life90
' http://www.guidosbox.com
' Copyright (C) 2010 - 2013 GUIDosbox - Montréal 
' Tous droits réservés

'Pour une liste de toute les commandes cmd disponble et une description complette.
'http://technet.microsoft.com/en-us/library/bb490928.aspx

Option Strict On
Option Explicit On

Imports System.IO

Public Class CP

#Region " Barre de menu "

    Private Sub AssocToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssocToolStripMenuItem.Click
        'AssocApp (1)
        CheckPrivilegeLevelNeeded("assoc", 1)
    End Sub

    Private Sub AttribToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttribToolStripMenuItem.Click
        'AttribApp (-1)
        CheckPrivilegeLevelNeeded("attrib", -1)
    End Sub

    Private Sub CaclsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaclsToolStripMenuItem.Click
        'CaclsApp (-1)
        CheckPrivilegeLevelNeeded("cacls", -1)
    End Sub

    Private Sub ChkdskToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkdskToolStripMenuItem.Click
        'CHKDSKApp (1)
        CheckPrivilegeLevelNeeded("chkdsk", 1)
    End Sub

    Private Sub CmdConsoleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdConsoleToolStripMenuItem.Click
        'CMDConsole (1)
        CheckPrivilegeLevelNeeded("cmd", 1)
    End Sub

    Private Sub CompactToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompactToolStripMenuItem.Click
        'CompactApp (-1)
        CheckPrivilegeLevelNeeded("compact", -1)
    End Sub

    Private Sub CompToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompToolStripMenuItem.Click
        'CompApp (-1)
        CheckPrivilegeLevelNeeded("comp", -1)
    End Sub

    Private Sub HelpToolStripMenu_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenu.Click
        'HelpApp (-1)
        CheckPrivilegeLevelNeeded("help", -1)
    End Sub

    Private Sub RDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdToolStripMenuItem.Click
        'RDApp (-1)
        CheckPrivilegeLevelNeeded("rd", -1)
    End Sub

    Private Sub SUBSTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubstToolStripMenuItem.Click
        'SubstApp (2)
        CheckPrivilegeLevelNeeded("subst", 2)
    End Sub

    Private Sub SYSTEMINFOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemInfoToolStripMenuItem.Click
        'SystemInfo (-1)
        CheckPrivilegeLevelNeeded("systeminfo", -1)
    End Sub

    Private Sub TRACERTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TracertToolStripMenuItem.Click
        'TracertApp (-1)
        CheckPrivilegeLevelNeeded("tracert", -1)
    End Sub

    Private Sub TYPEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TypeToolStripMenuItem.Click
        'TypeApp (-1)
        CheckPrivilegeLevelNeeded("where", -1)
    End Sub

    Private Sub WhereToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WhereToolStripMenuItem.Click
        'WhereApp (-1)
        CheckPrivilegeLevelNeeded("where", -1)
    End Sub

    Private Sub WhoamiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WhoamiToolStripMenuItem.Click
        'WhoamiApp (-1)
        CheckPrivilegeLevelNeeded("whoami", -1)
    End Sub

    Private Sub XcopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XcopyToolStripMenuItem.Click
        'XcopyApp (1)
        CheckPrivilegeLevelNeeded("xcopy", 1)
    End Sub

    Private Sub BatToexeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BatToexeToolStripMenuItem.Click
        'frmBatToExe
        Me.Hide()
        frmBatToExe.Show()
    End Sub

    Private Sub ÉditerBatchFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÉditerBatchFileToolStripMenuItem.Click
        'frmBatEdit
        Me.Hide()
        frmBatEdit.Show()
    End Sub

    Private Sub ParamètresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParamètresToolStripMenuItem.Click
        'Paramètres
        frmApplicationSettings.ShowDialog()
    End Sub

    Private Sub MiseÀJourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MiseÀJourToolStripMenuItem.Click
        Try
            'On vérifie si une mise à jour est disponible           
            If connexionInternet() = True Then
                UpdateFromMenu = True
                bgworkerCheckVersion.RunWorkerAsync()
            Else
                MsgBox("Vous n'êtes pas connectés à internet!" & vbCrLf _
                & "Il est donc impossible de vérifier si une mise à jour de l'application est disponible.", _
                 MsgBoxStyle.Information, "Connexion internet indisponible")
            End If
        Catch ex As Exception
            MsgBox("La vérification des mise à jour est déjà en cours d'exécution.", _
                MsgBoxStyle.Information, "GUI Dosbox - Avertissement")
        End Try
    End Sub

    Private Sub EnregistrerSousToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerSousToolStripMenuItem.Click
        'Affichage de la boite d'enregistrement et enregistrement du fichier.
        Dim opFD As New SaveFileDialog
        opFD.AddExtension = True
        opFD.DefaultExt = ".bat"
        opFD.FileName = "GUIDosboxHistory"
        opFD.Filter = "Fichiers de commandes (*.bat)|*.bat|Tous les fichiers (*.*)|*.*"
        opFD.FilterIndex = 0
        opFD.OverwritePrompt = True

        opFD.Title = "Enregistrer Sous..."
        'sauvegarde du fichier
        Try
            If opFD.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'Spression de l'ancienne version du fichier si existe
                If File.Exists(opFD.FileName) Then
                    File.Delete(opFD.FileName)
                End If
                'Création du nouveau fichier.
                File.Copy(TempBatch, opFD.FileName)
            End If
        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors de l'enregistrement, " & ex.Message, _
                  MsgBoxStyle.Exclamation, "GUI Dosbox - Erreur d'enregistrement")
        End Try
    End Sub

    Private Sub QuiterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuiterToolStripMenuItem.Click
        'Quiter
        Me.Close()
    End Sub

#End Region

#Region " Parramètres de démarrage "

    Private Sub CP_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        'Permet d'accepter les arguments de démarrage
        If OpenWithCmdArgs() Then
            Dim CmdArg As String = My.Application.CommandLineArgs(0)
            Select Case CmdArg
                Case "/cmdc"
                    CMDConsole.Show()
                    Me.Close()

                Case "/test"
                    MsgBox("salut")

            End Select

        End If

        'Ouverture du form (tools) après avoir été lancé en mode utilisateur.
        Try
            If File.Exists(Path.GetTempPath & "\stf.guidb") Then
                Dim FormToShow As String
                FormToShow = System.IO.File.ReadAllText(Path.GetTempPath & "\stf.guidb")
                File.Delete(Path.GetTempPath & "\stf.guidb")
                OpenCloseGUIDosboxForm(FormToShow)
            End If
        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors du démmarage de l'application en mode administrateur, " & ex.Message, _
                 MsgBoxStyle.Information, My.Application.GetType.Name)
        End Try

    End Sub
#End Region

#Region " Parramètres de fermeture "

    Private Sub CP_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Message avertissement - Enregistrer
        If My.Settings.WarningState = True Then
            If MsgBox("Vous êtes sur le point de fermer GUIDosbox." & vbCrLf & _
                  "Voulez-vous enregistrer le Batch File créé lors de cette utilisation de GUIDosbox.", _
               MsgBoxStyle.YesNo, "GUI Dosbox - Message") = MsgBoxResult.Yes Then
                'Appel de EnregistrerSousToolStripMenuItem
                Call EnregistrerSousToolStripMenuItem_Click(sender, e)
            End If
        End If
    End Sub

#End Region

    Private Sub CP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Supression des vieux fichiers de mise à jour
        Try
            If File.Exists(file_path + "update.exe") Then
                File.Delete(file_path + "update.exe")
            End If
        Catch ex As Exception
            MsgBox("Impossible de supprimer les anciens fichiers de mise à jour." _
                   + vbCrLf + vbCrLf + ex.Message, MsgBoxStyle.Information, _
                   "GUI Dosbox - Avertissement")
        End Try

        'On vérifie si une mise à jour est disponible  
        Try
            If My.Settings.UpdateState Then '--> Paramètres GUIDOSBOX
                If connexionInternet() = True Then
                    bgworkerCheckVersion.RunWorkerAsync()
                Else
                    MsgBox("Vous n'êtes pas connectés à internet!" & vbCrLf _
                    & "Il est donc impossible de vérifier si une mise à jour de l'application est disponible.", _
                     MsgBoxStyle.Information, "Connexion internet indisponible")
                End If
            End If
        Catch ex As Exception
            MsgBox("Impossible de vérifier la mise à jour, " & vbCrLf & vbCrLf & ex.Message, _
                MsgBoxStyle.Information, "GUI Dosbox - Avertissement")
        End Try

        'Préparation de l'interface d'utilisateur
        Try
            'Création du Batch File
            PrepareBatchFile()

            'Affichage dans le StatusStrip
            lblUser.Text = "Bienvenue, " & Environment.UserName & " : "
            lblMode.ForeColor = If(RunAsAdmin, Color.MediumPurple, Color.RoyalBlue)
            lblMode.Text = If(RunAsAdmin(), "Mode Administrateur", "Mode Utilisateur")

            'Chargement du menu Flash
            LoadFlashMenu()

        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors de l'ouverture de cette application, " & ex.Message, _
                   MsgBoxStyle.Information, My.Application.GetType.Name)
        End Try
    End Sub

End Class
