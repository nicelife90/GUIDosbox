' [--> GUIDosbox <--]
' Créé par : Nice-Life90
' http://www.guidosbox.com
' Copyright (C) 2010 - 2013 GUIDosbox - Montréal 
' Tous droits réservés

' [--> Contenue du fichhier <-] 
' Ce Module contient toutes le code nécessaire pour charger les élément flash de l'application.

Imports AxShockwaveFlashObjects

Module GUIDosboxFlashLoader

    ''' <summary>
    ''' Charge le menu Flash
    ''' </summary>
    ''' <remarks>Les partie commenter son pour le menu en anglais qui est actuellement désactivé.</remarks>
    Public Sub LoadFlashMenu()

        'Déclaration des chemins pour les nouveaux fichiers 
        ' Dim MovieENPath As String = System.IO.Path.GetTempPath & "\" & "Menu_EN_GuiDosBox.swf"
        Dim MovieFRPath As String = System.IO.Path.GetTempPath & "\" & "Menu_GuiDosBox.swf"
        Dim Xml1Path As String = System.IO.Path.GetTempPath & "\" & "page_1.xml"
        Dim Xml2Path As String = System.IO.Path.GetTempPath & "\" & "page_2.xml"
        Dim Xml3Path As String = System.IO.Path.GetTempPath & "\" & "page_3.xml"
        'Dim Xml10Path As String = System.IO.Path.GetTempPath & "\" & "page_10.xml"
        'Dim Xml20Path As String = System.IO.Path.GetTempPath & "\" & "page_20.xml"
        'Dim Xml30Path As String = System.IO.Path.GetTempPath & "\" & "page_30.xml"
        Dim StylePath As String = System.IO.Path.GetTempPath & "\" & "style.css"
        'Dim Style2Path As String = System.IO.Path.GetTempPath & "\" & "style2.css"
        Dim HeaderPath As String = System.IO.Path.GetTempPath & "\" & "headerGUIDOSBOX.swf"

        'Création des nouveaux fichiers à partir des resources
        'My.Computer.FileSystem.WriteAllBytes(MovieENPath, My.Resources.Menu_EN_GuiDosBox, False)
        My.Computer.FileSystem.WriteAllBytes(MovieFRPath, My.Resources.Menu_GuiDosBox, False)
        My.Computer.FileSystem.WriteAllText(Xml1Path, My.Resources.page_1, False)
        My.Computer.FileSystem.WriteAllText(Xml2Path, My.Resources.page_2, False)
        My.Computer.FileSystem.WriteAllText(Xml3Path, My.Resources.page_3, False)
        'My.Computer.FileSystem.WriteAllText(Xml10Path, My.Resources.page_10, False)
        'My.Computer.FileSystem.WriteAllText(Xml20Path, My.Resources.page_20, False)
        'My.Computer.FileSystem.WriteAllText(Xml30Path, My.Resources.page_30, False)
        My.Computer.FileSystem.WriteAllText(StylePath, My.Resources.style, False)
        'My.Computer.FileSystem.WriteAllText(Style2Path, My.Resources.style2, False)
        My.Computer.FileSystem.WriteAllBytes(HeaderPath, My.Resources.headerGUIDOSBOX, False)

        'Affichage du menu en francais
        CP.FlashCPFR.LoadMovie(0, MovieFRPath)
        CP.FlashCPFR.Menu = False
        CP.FlashCPFR.Play()

        'Affichage du menu en anglais
        'CP.FlashCPEN.LoadMovie(0, MovieENPath)
        'CP.FlashCPEN.Play()

        'Affichage du header
        CP.FlashHeader.LoadMovie(0, HeaderPath)
        CP.FlashHeader.Play()
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

End Module
