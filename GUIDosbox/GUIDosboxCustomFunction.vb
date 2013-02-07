Option Strict On

Imports System.Collections.Specialized
Imports System.IO

Module GUIDosboxCustomFunction
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
    ''' A voir pour subst
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function AvailableDrive() As StringCollection
        ' build a string collection representing the alphabet
        Dim alphabet As New StringCollection()

        Dim lowerBound As Integer = Convert.ToInt16("a"c)
        Dim upperBound As Integer = Convert.ToInt16("z"c)
        For i As Integer = lowerBound To upperBound - 1
            Dim driveLetter As Char = ChrW(i)
            alphabet.Add(driveLetter.ToString())
        Next

        ' get all current drives
        Dim drives As DriveInfo() = DriveInfo.GetDrives()
        For Each drive As DriveInfo In drives
            alphabet.Remove(drive.Name.Substring(0, 1).ToLower())
        Next

        If alphabet.Count > 0 Then
            Return alphabet
        Else
            Throw New ApplicationException("No drives available.")
        End If
    End Function

End Module
