' [--> GUIDosbox <--]
' Créé par : Nice-Life90
' http://www.guidosbox.com
' Copyright (C) 2010 - 2013 GUIDosbox - Montréal 
' Tous droits réservés

' [--> Contenue du fichhier <-] 
' Ce Module contient toutes les fonctions et méthodes pour les outils reliés au Batch File.

Imports System.IO

Module GUIDosboxBatchFile

    ''' <summary>
    ''' Chemin pour le fichier batch temporraire.
    ''' </summary>
    ''' <remarks>Le fichier batch ce trouve dans le dossier temp de l'utilisateur.</remarks>
    Public TempBatch As String = Path.GetTempPath & "guidb.bat"

    ''' <summary>
    ''' Vérifie si la compillation du batch est appeler depuis l'éditeur.
    ''' </summary>
    ''' <remarks></remarks>
    Public BuildFromTempBatch As Boolean = False

    ''' <summary>
    ''' Sauvegarde l'index de la commande à afficher lors de l'appuis sur les flèches.
    ''' </summary>
    ''' <remarks>Cette Variable sert a la proc/dure ShowLastCommand.</remarks>
    Public CommandIndex As Integer = 0

    ''' <summary>
    ''' Prépare un fichier temporaire pour stocker les commandes exéctué par les utilitaires. 
    ''' Il formatte le fichier de façon à devenir un batch file au besoin.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub PrepareBatchFile()
        Try
            'Supression de l'ancien fichier temporaire.
            DeleteBatch()
            'Création du nouveau fichier temporaire
            CreateBatch()
            'Écriture des valeurs par défault dans le ficher
            WriteBatch("REM -- GUIDosbox --")
            WriteBatch("REM Créé par : Nice-Life90")
            WriteBatch("REM http://www.kobixxe.com")
            WriteBatch("REM Copyright (C) 2010 - 2013 Kobixxe - Montréal")
            WriteBatch("REM Tous droits réservés")
            LineSpace(1)
            WriteBatch("REM Ce fichier à été automatiquement créé par GUIDosbox.")
            WriteBatch("REM Vous pouvez modifier ce fichier à votre guise à tout moment.")
            WriteBatch("REM Il est aussi possible de le compiler en utilisant l'utilitaire Batch to Exe.")
            WriteBatch("REM Vous trouverez l'utilitaire dans le menu principal sous Outils > .bat To .exe.")
            WriteBatch("REM Vous trouverez sous cette ligne l'historique des commandes que vous avez effectuées avec GUIDosbox.")
            LineSpace(1)
            WriteBatch("@echo off")
        Catch ex As Exception
            'Message d'erreur
            MsgBox("Une erreur c'est produite avec la préparation du nouveau fichier batch temporraire." _
                   & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Exclamation, Application.ProductName & " - Erreur")
        End Try
    End Sub

    ''' <summary>
    ''' Affiche la derniere commande exécuter lorsque la flèche vers le haut est apuyer.
    ''' </summary>
    ''' <param name="Textbox">Textbox dans la quel afficher la commande.</param>
    Public Sub ShowLastCommand(ByVal Textbox As GUIDosbox_Textbox)

        'Reset du textbox
        Textbox.Text = Nothing

        'Lecture du fichier et création d'un tableau
        Dim lines() As String = File.ReadAllLines(TempBatch)
        Dim lineArray As New ArrayList()

        'Ajout des ligne au tableau
        For x As Integer = 0 To lines.GetUpperBound(0)
            lineArray.Add(lines(x))
        Next

        'Sélection de la ligne à afficher.
        Dim lineToShow As Integer
        lineToShow = lineArray.Count - CommandIndex

        'Affichage de la ligne.
        If CommandIndex > 0 Then
            Textbox.Text = lineArray.Item(lineToShow).ToString
        End If

    End Sub

    ''' <summary>
    ''' Créé le fichier batch temporraire GUIDosbox.
    ''' </summary>
    Public Sub CreateBatch()
        Try
            Dim fs As FileStream = Nothing
            fs = File.Create(TempBatch)
            fs.Close()
        Catch ex As Exception
            'Message d'erreur
            MsgBox("Une erreur c'est produite lors de la création du fichier batch temporraire." _
                   & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Exclamation, Application.ProductName & " - Erreur de création")
        End Try
    End Sub

    ''' <summary>
    ''' Supprime le fichier batch temporraire GUIDosbox.
    ''' </summary>
    Public Sub DeleteBatch()
        Try
            If File.Exists(TempBatch) Then
                File.Delete(TempBatch)
            End If
        Catch ex As Exception
            'Message d'erreur
            MsgBox("Une erreur c'est produite lors de la supression du fichier batch temporraire." _
                   & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Exclamation, Application.ProductName & " - Erreur de supression")
        End Try
    End Sub

    ''' <summary>
    ''' Ajoute la ligne de texte dans le fichier batch temporraire GUIDosbox.
    ''' </summary>
    ''' <param name="Text">Texte de la ligne à ajouter.</param>
    ''' <remarks></remarks>
    Public Sub WriteBatch(ByVal Text As String)
        Try
            If File.Exists(TempBatch) Then
                Using sw As StreamWriter = New StreamWriter(TempBatch, True)
                    sw.WriteLine(Text)
                    sw.Close()
                End Using
            End If
        Catch ex As Exception
            'Message d'erreur
            MsgBox("Une erreur c'est produite lors de l'écriture dans le fichier batch temporraire." _
                   & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Exclamation, Application.ProductName & " - Erreur d'écriture")
        End Try
    End Sub

    ' Read From a Text File
    Public Sub ReadBatch()
        If File.Exists(TempBatch) Then
            Using tr As TextReader = New StreamReader(TempBatch)
                MessageBox.Show(tr.ReadLine())
                tr.Close()
            End Using
        End If
    End Sub

    ''' <summary>
    ''' Ajoute x lignes vide dans le fichier.
    ''' </summary>
    ''' <param name="nombre">nombre de ligne</param>
    Public Sub LineSpace(ByVal nombre As Integer)
        Try
            If File.Exists(TempBatch) Then
                Using sw As StreamWriter = New StreamWriter(TempBatch, True)
                    For i = 0 To nombre - 1
                        sw.WriteLine("")
                        sw.Close()
                    Next
                End Using
            End If
        Catch ex As Exception
            'Message d'erreur
            MsgBox("Une erreur c'est produite lors d'un retour à la ligne dans le fichier batch temporraire." _
                   & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Exclamation, Application.ProductName & " - Erreur d'écriture")
        End Try
    End Sub

    ''' <summary>
    ''' Copie le fichier batch temporraire vers un destination choisi.
    ''' </summary>
    ''' <param name="Destination">Destination de la copie</param>
    Public Sub CopyBatch(ByVal Destination As String)
        Try
            If File.Exists(TempBatch) Then
                File.Copy(TempBatch, Destination)
            End If
        Catch ex As Exception
            'Message d'erreur
            MsgBox("Une erreur c'est produite lors de la copie du fichier batch temporraire." _
                   & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Exclamation, Application.ProductName & " - Erreur de copie")
        End Try
    End Sub

    ''' <summary>
    ''' Déplace le fichier batch temporraire vers un destination choisi.
    ''' </summary>
    ''' <param name="Destination"></param>
    Public Sub MoveBatch(ByVal Destination As String)
        Try
            If File.Exists(TempBatch) Then
                File.Move(TempBatch, Destination)
            End If
        Catch ex As Exception
            'Message d'erreur
            MsgBox("Une erreur c'est produite lors du déplacement du fichier batch temporraire." _
                   & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Exclamation, Application.ProductName & " - Erreur de déplacement")
        End Try
    End Sub

End Module
