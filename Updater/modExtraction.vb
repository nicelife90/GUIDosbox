' [--> GUIDosbox Updater <--]
' Créé par : Nice-Life90
' http://www.guidosbox.com
' Copyright (C) 2010 - 2013 Kobixxe - Montréal 
' Tous droits réservés

' [--> Contenue du fichhier <-] 
' Ce module contient toutes les fonctions et procédures requis par l'updater

Option Strict On
Option Explicit On

Imports System.IO
Imports System.Reflection
Imports ICSharpCode.SharpZipLib.Zip

Module modExtraction

    ''' <summary>
    ''' fonction qui lit un fichier texte
    ''' </summary>
    ''' <param name="FullPath">chemin du fichier a lire</param>
    ''' <returns>le contenue du fichier</returns>
    ''' <remarks></remarks>
    Public Function ReadFileText(ByVal FullPath As String) As String
        Dim strContents As String
        Dim objReader As StreamReader
        objReader = New StreamReader(FullPath)
        strContents = objReader.ReadToEnd()
        objReader.Close()
        Return strContents
    End Function

    ''' <summary>
    ''' Enregistre une resource incorporé à un endroit spécifié.
    ''' </summary>
    ''' <param name="resourceName">Le nom de la resource à extraire.</param>
    ''' <param name="fileName">Le chemin et le nom du fichier pour enregistrer.</param>
    Public Sub SaveToDisk(ByVal resourceName As String, ByVal fileName As String)
        'Get a reference to the running application.
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

    ''' <summary>
    ''' Extrait l'archive .zip à l'endroit spécifié.
    ''' </summary>
    ''' <param name="zipFilename">Le chemin et le nom du fichier à extraire.</param>
    ''' <param name="ExtractDir">Le chemin pour la destination du fichier extrait.</param>
    ''' <remarks>Cette procédure dépend de ICSharpCode.SharpZipLib.Zip.dll</remarks>
    Public Sub ExtractArchive(ByVal zipFilename As String, ByVal ExtractDir As String)
        Dim Redo As Integer = 1
        Dim MyZipInputStream As ZipInputStream
        Dim MyFileStream As FileStream = Nothing
        MyZipInputStream = New ZipInputStream(New FileStream(zipFilename, FileMode.Open, FileAccess.Read))
        Dim MyZipEntry As ZipEntry = MyZipInputStream.GetNextEntry
        Directory.CreateDirectory(ExtractDir)
        While Not MyZipEntry Is Nothing
            If (MyZipEntry.IsDirectory) Then
                Directory.CreateDirectory(ExtractDir & "\" & MyZipEntry.Name)
            Else
                If Not Directory.Exists(ExtractDir & "\" & _
                Path.GetDirectoryName(MyZipEntry.Name)) Then
                    Directory.CreateDirectory(ExtractDir & "\" & _
                    Path.GetDirectoryName(MyZipEntry.Name))
                End If
                MyFileStream = New FileStream(ExtractDir & "\" & _
                  MyZipEntry.Name, FileMode.OpenOrCreate, FileAccess.Write)
                Dim count As Integer
                Dim buffer(4096) As Byte
                count = MyZipInputStream.Read(buffer, 0, 4096)
                While count > 0
                    MyFileStream.Write(buffer, 0, count)
                    count = MyZipInputStream.Read(buffer, 0, 4096)
                End While
                MyFileStream.Close()
            End If

            Try
                MyZipEntry = MyZipInputStream.GetNextEntry
            Catch ex As Exception
                MyZipEntry = Nothing
            End Try
        End While
        If Not (MyZipInputStream Is Nothing) Then MyZipInputStream.Close()
        If Not (MyFileStream Is Nothing) Then MyFileStream.Close()
    End Sub

    ''' <summary>
    ''' Permet d'appeler une pause de l'exécution de l'instruction.
    ''' </summary>
    ''' <param name="dblSecs">Le nombre de seconde pour la pause.</param>
    Public Sub Delay(ByVal dblSecs As Double)
        Const OneSec As Double = 1.0# / (1440.0# * 60.0#)
        Dim dblWaitTil As Date
        Now.AddSeconds(OneSec)
        dblWaitTil = Now.AddSeconds(OneSec).AddSeconds(dblSecs)
        Do Until Now > dblWaitTil
            Application.DoEvents()
        Loop
    End Sub

End Module
