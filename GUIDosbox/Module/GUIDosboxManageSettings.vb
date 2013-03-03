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
    ''' Structure pour stocker les paramètres temporraire de l'onglet coloration syntaxique avant l'application des paramètres
    ''' </summary>
    ''' <remarks>Cette structure est utiliser par frmApplicationSettings</remarks>
    Public Structure ParamColorationSyntaxique
        Public ArobasColor As Color
        Public AnchorColor As Color
        Public CommandsColor As Color
        Public CommentColor As Color
        Public IntegerColor As Color
        Public KeywordColor As Color
        Public OperatorColor As Color
        Public VariableColor As Color
        Public ArobasState As Boolean
        Public AnchorState As Boolean
        Public CommandsState As Boolean
        Public CommentsState As Boolean
        Public IntegerState As Boolean
        Public KeywordsState As Boolean
        Public OperatorState As Boolean
        Public VariableState As Boolean
    End Structure

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
    End Structure

    ''' <summary>
    ''' Reset les paramètres de l'application en partie ou en entier.
    ''' </summary>
    ''' <param name="ResetMetode">1 --> Onglet Général, 2 --> Onglet Coloration syntaxique, 3 --> Onglet éditeur, -1 --> Tous les paramètres</param>
    Public Sub ResetGUIDosboxSettings(ByVal ResetMetode As Integer)
        Select Case ResetMetode

            Case 1 '-->  'Reset de l'onglet Général
                With My.Settings
                    .ColororationState = True
                    .UpdateState = True
                End With
                My.Settings.Save()
                My.Settings.Reload()

            Case 2 '-->  'Reset de l'onglet Coloration Syntaxique
                With My.Settings
                    .ArobasColor = Color.DeepPink
                    .AnchorColor = Color.Brown
                    .CommandsColor = Color.DeepSkyBlue
                    .CommentColor = Color.Green
                    .IntegerColor = Color.Maroon
                    .KeywordColor = Color.Blue
                    .OperatorColor = Color.Red
                    .VariableColor = Color.Purple
                    .ArobasState = True
                    .AnchorState = True
                    .CommandsState = True
                    .CommentsState = True
                    .IntegerState = False
                    .KeywordsState = True
                    .OperatorState = True
                    .VariableState = True
                End With
                My.Settings.Save()
                My.Settings.Reload()

            Case 3 '-->  'Reset de l'onglet Éditeur
                With My.Settings
                    .EditorFont = New Font("Lucida Console", 9, FontStyle.Regular, GraphicsUnit.Point)
                    .EditorBGColor = Color.Gainsboro
                End With
                My.Settings.Save()
                My.Settings.Reload()

            Case -1 '-->  'Reset de tous les paramètres
                With My.Settings
                    .ColororationState = True
                    .UpdateState = True
                    .ArobasColor = Color.DeepPink
                    .AnchorColor = Color.Brown
                    .CommandsColor = Color.DeepSkyBlue
                    .CommentColor = Color.Green
                    .IntegerColor = Color.Maroon
                    .KeywordColor = Color.Blue
                    .OperatorColor = Color.Red
                    .VariableColor = Color.Purple
                    .ArobasState = True
                    .AnchorState = True
                    .CommandsState = True
                    .CommentsState = True
                    .IntegerState = False
                    .KeywordsState = True
                    .OperatorState = True
                    .VariableState = True
                    .EditorFont = New Font("Lucida Console", 9, FontStyle.Regular, GraphicsUnit.Point)
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
                    .ColororationState = newSettings.ColorationState
                    .UpdateState = newSettings.UpdateState
                End With

                'Enregistrement des paramètres
                My.Settings.Save()
                My.Settings.Reload()


            Case 2 '--> Onglet Coloration Syntaxique
                'Définition des nouveaux paramètres
                Dim newSettings As ParamColorationSyntaxique = CType(mySettings, ParamColorationSyntaxique)
                With My.Settings
                    'Couleur
                    .ArobasColor = newSettings.ArobasColor
                    .AnchorColor = newSettings.AnchorColor
                    .CommandsColor = newSettings.CommandsColor
                    .CommentColor = newSettings.CommentColor
                    .IntegerColor = newSettings.IntegerColor
                    .KeywordColor = newSettings.KeywordColor
                    .OperatorColor = newSettings.OperatorColor
                    .VariableColor = newSettings.VariableColor
                    'États
                    .ArobasState = newSettings.ArobasState
                    .AnchorState = newSettings.AnchorState
                    .CommandsState = newSettings.CommandsState
                    .CommentsState = newSettings.CommentsState
                    .IntegerState = newSettings.IntegerState
                    .KeywordsState = newSettings.KeywordsState
                    .OperatorState = newSettings.OperatorState
                    .VariableState = newSettings.VariableState
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
