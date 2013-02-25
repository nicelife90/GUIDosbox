'Créé par : Nice-Life90
'http://www.kobixxe.com
'Copyright (C) 2010 - 2013 Kobixxe - Montréal 
'Tous droits réservés

' Ce Module contient toutes les fonctions et méthodes simple utilisées par le projet.

Option Strict On
Option Explicit On

Imports System.IO
Imports System.Reflection
Imports AxShockwaveFlashObjects
Imports System.Collections.ObjectModel
Imports System.Collections.Specialized

Module GUIDosboxFunction

    ''' <summary>
    ''' Crée un nouveau OpenFileDialogs et retourne le chemin du fichier sélectionné.
    ''' </summary>
    ''' <returns>Le chemin du fichier sélectionné</returns>
    Public Function ofd() As String
        Dim opFD As New OpenFileDialog
        opFD.Title = "GUI Dosbox"
        opFD.CheckFileExists = True
        opFD.CheckPathExists = True
        opFD.Multiselect = False
        opFD.FileName = Nothing
        opFD.ShowDialog()
        Return opFD.FileName
    End Function

    ''' <summary>
    ''' Crée un nouveau FolderBrowserDialog et retourne le chemin du dossier sélectionné.
    ''' </summary>
    ''' <returns>Le chemin du dossier sélectionné</returns>
    Public Function fbd() As String
        Dim opFD As New FolderBrowserDialog
        opFD.RootFolder = Environment.SpecialFolder.MyComputer
        opFD.ShowDialog()
        Return opFD.SelectedPath
    End Function


    ''' <summary>
    ''' Retourne les compte d'utilisateurs sur l'ordinateur spécifié.
    ''' </summary>
    ''' <param name="MachineName">The computer to get user accounts from</param>
    Public Function GetLocalUsers(ByVal MachineName As String) As List(Of String)
        Dim WinNt As New DirectoryServices.DirectoryEntry("WinNT://" & MachineName)
        Dim UserList As New List(Of String)
        For Each User As DirectoryServices.DirectoryEntry In WinNt.Children
            If User.SchemaClassName = "User" Then
                UserList.Add(User.Name)
            End If
        Next
        Return UserList
    End Function

    ''' <summary>
    ''' Retourne les groupes actif sur l'ordinateur spécifié.
    ''' </summary>
    ''' <param name="MachineName">The computer to get user accounts from</param>
    Public Function GetLocalGroup(ByVal MachineName As String) As List(Of String)
        Dim WinNt As New DirectoryServices.DirectoryEntry("WinNT://" & MachineName)
        Dim GroupList As New List(Of String)
        For Each Group As DirectoryServices.DirectoryEntry In WinNt.Children
            If Group.SchemaClassName = "Group" Then
                GroupList.Add(Group.Name)
            End If
        Next
        Return GroupList
    End Function

    ''' <summary>
    ''' Renvoi la liste des lettres utilisées par les lecteurs (Drive) 
    ''' </summary>
    Public Function UsedDrive() As StringCollection
        Dim lecteurs As New StringCollection
        Dim drives As ReadOnlyCollection(Of DriveInfo) = My.Computer.FileSystem.Drives
        For Each drive As DriveInfo In drives
            Dim lecteur As String = drive.ToString.Substring(0, drive.ToString.Length - 1)
            lecteurs.Add(lecteur.ToString)
        Next
        Return lecteurs
    End Function

    ''' <summary>
    ''' Renvoi une liste de lettre disponible pour un lecteur
    ''' </summary>
    Public Function AvailableDrive() As StringCollection
        'Création d'un StringCollection avec les lettre de l'alphabet
        Dim alphabet As New StringCollection()
        Dim lowerBound As Integer = Convert.ToInt16("a"c)
        Dim upperBound As Integer = Convert.ToInt16("z"c)
        For i As Integer = lowerBound To upperBound - 1
            Dim driveLetter As Char = ChrW(i)
            alphabet.Add(driveLetter.ToString())
        Next

        'Supprime les lettre déja utiliser par un lecteur
        For Each drive In UsedDrive()
            alphabet.Remove(drive.Substring(0, 1).ToLower())
        Next

        If alphabet.Count > 0 Then
            Return alphabet
        Else
            Throw New ApplicationException("No drives available.")
        End If
    End Function

    ''' <summary>
    ''' Vérifie si GUIDosbox est lancé avec des arguments.
    ''' Ex: GUIDosbox.exe /cmdc
    ''' </summary>
    ''' <returns>Avec arguments --> True, Sans arguments --> False</returns>
    Public Function OpenWithCmdArgs() As Boolean
        If My.Application.CommandLineArgs.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Permet de supprimer le texte contenue dans chacun des textbox du form.
    ''' </summary>
    ''' <param name="root">Form name généralement « Me »</param>
    Public Sub ClearTextBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            ClearTextBox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl
    End Sub

    ''' <summary>
    ''' Charge le Header (Flash Movie) à partir des ressources incorporées.
    ''' </summary>
    ''' <param name="header">Nom du composant AxShockwaveFlash</param>
    ''' <param name="tools">Nom de la ressource (Flash Movie)</param>
    Public Sub LoadHeader(ByVal header As AxShockwaveFlash, ByVal tools As String)
        Try
            Dim MoviePath As String = System.IO.Path.GetTempPath & "\" & tools & ".swf"
            My.Computer.FileSystem.WriteAllBytes(MoviePath, CType(My.Resources.ResourceManager.GetObject(tools), Byte()), False)
            header.LoadMovie(0, System.IO.Path.GetTempPath & "\" & tools & ".swf")
            header.Play()
        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors du chargement de cette fenêtre, " & ex.Message & vbCrLf & vbCrLf & _
                   "Cette erreur n'empèche pas le bon fonctionnement de l'application.", _
                   MsgBoxStyle.Information, My.Application.GetType.Name)
        End Try
    End Sub

    ''' <summary>
    ''' Enregistre une ressource incorporé au projet sur le disque dur.
    ''' </summary>
    ''' <param name="resourceName">Nom de la ressource.</param>
    ''' <param name="fileName">Chemin d'enregistrement.</param>
    Public Sub SaveToDisk(ByVal resourceName As String, ByVal fileName As String)
        ' Get a reference to the running application.
        Dim assy As [Assembly] = [Assembly].GetExecutingAssembly()
        ' Loop through each resource, looking for the image name (case-insensitive).
        For Each resource As String In assy.GetManifestResourceNames()
            If resource.ToLower().IndexOf(resourceName.ToLower) <> -1 Then
                ' Get the embedded file from the assembly as a MemoryStream.
                Using resourceStream As System.IO.Stream = assy.GetManifestResourceStream(resource)
                    If resourceStream IsNot Nothing Then
                        Using reader As New BinaryReader(resourceStream)
                            ' Read the bytes from the input stream.
                            Dim buffer() As Byte = reader.ReadBytes(CInt(resourceStream.Length))
                            Using outputStream As New FileStream(fileName, FileMode.Create)
                                Using writer As New BinaryWriter(outputStream)
                                    ' Write the bytes to the output stream.
                                    writer.Write(buffer)
                                End Using
                            End Using
                        End Using
                    End If
                End Using
                Exit For
            End If
        Next resource
    End Sub

   

   
    'Public Function FormCount(ByVal frmname As String) As Long
    '    Dim counter As Integer = 0
    '    Dim frm As Form
    '    For Each frm In Application.OpenForms
    '        If StrComp(frm.Name, frmname, CompareMethod.Text) = 0 Then
    '            counter += 1
    '        End If
    '    Next frm
    '    Return counter
    'End Function

    Public Function FormCount(ByVal frmname As String) As Long
        Dim counter As Integer = 0
        Dim frm As Form
        For Each frm In Application.OpenForms
            If StrComp(frm.Name, frmname, CompareMethod.Text) = 0 Then
                counter += 1
            End If
        Next frm
        Return counter
    End Function


    ' return True if a form is loaded
    Public Function IsLoaded(ByVal frmname As String) As Boolean
        If FormCount(frmname) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    

End Module
