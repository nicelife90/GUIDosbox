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
    ''' <remarks>Cette Variable sert a la procédure ShowLastCommand.</remarks>
    Public CommandIndex As Integer = 0

    ''' <summary>
    ''' Sauvegarde l'index maximum de la ligne à afficher
    ''' Permet de ne pas retourner plus haut que le nombre de ligne dans le fichier
    ''' ce qui entrainerais une erreur. 
    ''' </summary>
    ''' <remarks></remarks>
    Public CommandMaxIndex As Integer

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
            WriteBatch("REM [--> GUIDosbox <--]")
            WriteBatch("REM Créé par : Nice-Life90")
            WriteBatch("REM http://www.guidosbox.com")
            WriteBatch("REM Copyright (C) 2010 - 2013 GUI Dosbox - Montréal")
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
    ''' Affiche les commande éxécuter quand une flèche est appuyé sur le clavié.
    ''' </summary>
    ''' <param name="Textbox">Le textbox dans le quel afficher la commande</param>
    ''' <param name="Key">Le code de la touche appuyer</param>
    Public Sub ShowLastCommand(ByVal Textbox As GUIDosbox_Textbox, ByVal Key As Keys)

        'On efface le textbox
        Textbox.Text = Nothing

        'Lecture du fichier et création d'un tableau
        Dim lines() As String = File.ReadAllLines(TempBatch)
        Dim lineArray As New ArrayList()

        'Ajout des ligne au tableau
        For x As Integer = 0 To lines.GetUpperBound(0)
            lineArray.Add(lines(x))
        Next

        'Calcul du nombre de ligne maximum et affectation de la valeur
        CommandMaxIndex = lines.Count - 13 '--> -13 pour ne pas afficher les 13 premières lignes 

        'Si la flèche du haut
        If Key = Keys.Up Then
            If CommandMaxIndex > CommandIndex Then
                CommandIndex += 1
            End If
        End If

        'Si la flèche du bas
        If Key = Keys.Down Then
            If CommandIndex > 0 Then
                CommandIndex -= 1
            End If
        End If

        'Si Enter
        If Key = Keys.Enter Then
            CommandIndex = 0
        End If

        'Sélection de la ligne à afficher.
        Dim lineToShow As Integer = lineArray.Count - CommandIndex

        'Affichage de la ligne.
        If CommandIndex > 0 Then
            Textbox.Text = lineArray.Item(lineToShow).ToString
        End If
    End Sub

    ''' <summary>
    ''' Effecte la valeur de l'index maximum à la variable CommandMaxIndex 
    ''' Ce sub compte le nombre de ligne dans le fichier batch et enleve douze au total de ligne
    ''' pour empêcher d'afficher les 12 première ligne du fichier qui sont des commentaire.
    ''' </summary>
    Public Sub SetMaxIndex()
        'Calcul du nombre de ligne maximum
        Dim lines() As String = File.ReadAllLines(TempBatch)
        'Afectation de la valeur.
        CommandMaxIndex = lines.Count - 13
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
