' [--> GUIDosbox <--]
' Créé par : Nice-Life90
' http://www.guidosbox.com
' Copyright (C) 2010 - 2013 GUIDosbox - Montréal 
' Tous droits réservés

' [--> Contenue du fichhier <-] 
' Ce module contient toutes les paramètres par défaut de l'application et certaine procédure 
' pour reset les valeur par défaut de l'application en entier ou en partie.

Option Strict On
Option Explicit On

Module GUIDosboxManageSettings

    ''' <summary>
    ''' Structure pour stocker les paramètres temporraire de l'onglet éditeur avant l'application des paramètres
    ''' </summary>
    ''' <remarks>Cette structure est utiliser par frmApplicationSettings</remarks>
    Public Structure ParamEditor
        Public EditorFont As Font
        Public EditorBgColor As Color
    End Structure

    ''' <summary>
    ''' Structure pour stocker les paramètres temporraire de l'onglet général avant l'application des paramètres
    ''' </summary>
    ''' <remarks>Cette structure est utiliser par frmApplicationSettings</remarks>
    Public Structure ParamGeneral
        Public ColorationState As Boolean
        Public UpdateState As Boolean
        Public WarningState As Boolean
    End Structure

    ''' <summary>
    ''' Reset les paramètres de l'application en partie ou en entier.
    ''' </summary>
    ''' <param name="ResetMetode">1 --> Onglet Général, 2 --> Onglet Coloration syntaxique, 3 --> Onglet éditeur, -1 --> Tous les paramètres</param>
    Public Sub ResetGUIDosboxSettings(ByVal ResetMetode As Integer)
        Select Case ResetMetode

            Case 1 '-->  'Reset de l'onglet Général
                With My.Settings
                    .UpdateState = True
                    .WarningState = True
                End With
                My.Settings.Save()
                My.Settings.Reload()

            Case 3 '-->  'Reset de l'onglet Éditeur
                With My.Settings
                    .EditorFont = New Font("Consolas", 10, FontStyle.Regular, GraphicsUnit.Point)
                    .EditorBGColor = Color.Gainsboro
                End With
                My.Settings.Save()
                My.Settings.Reload()

            Case -1 '-->  'Reset de tous les paramètres
                With My.Settings
                    .UpdateState = True
                    .WarningState = True
                    .EditorFont = New Font("Consolas", 10, FontStyle.Regular, GraphicsUnit.Point)
                    .EditorBGColor = Color.Gainsboro
                End With
                My.Settings.Save()
                My.Settings.Reload()
        End Select

    End Sub

    ''' <summary>
    ''' Enregistre les modification apporter aux paramètres de l'application.
    ''' </summary>
    ''' <param name="mySettings">Les nouveaux paramètres</param>
    ''' <param name="onglet">1 --> Onglet Général, 2 --> Onglet Coloration syntaxique, 3 --> Onglet éditeur</param>
    Public Sub SaveGUIDosboxSetting(ByVal mySettings As Object, ByVal onglet As Integer)
        Select Case onglet

            Case 1 '--> Onglet général
                'Définition des nouveaux paramètres
                Dim newSettings As ParamGeneral = CType(mySettings, ParamGeneral)
                With My.Settings
                    .UpdateState = newSettings.UpdateState
                    .WarningState = newSettings.WarningState
                End With

                'Enregistrement des paramètres
                My.Settings.Save()
                My.Settings.Reload()


            Case 3 '--> Onglet Éditeur
                'Définition des nouveaux paramètres
                Dim newSettings As ParamEditor = CType(mySettings, ParamEditor)
                With My.Settings
                    'Couleur
                    .EditorBGColor = newSettings.EditorBgColor
                    'Police de caractères
                    .EditorFont = newSettings.EditorFont
                End With

                'Enregistrement des paramètres
                My.Settings.Save()
                My.Settings.Reload()

        End Select

    End Sub

End Module
