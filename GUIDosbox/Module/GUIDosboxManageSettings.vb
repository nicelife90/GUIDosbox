' [--> GUIDosbox <--]
' Créé par : Nice-Life90
' http://www.kobixxe.com
' Copyright (C) 2010 - 2013 Kobixxe - Montréal 
' Tous droits réservés

' [--> Contenue du fichhier <-] 
' Ce module contient toutes les paramètres par défaut de l'application et certaine procédure 
' pour reset les valeur par défaut de l'application en entier ou en partie.

Option Strict On
Option Explicit On

Module GUIDosboxManageSettings

    ''' <summary>
    ''' Structure pour stocker les paramètres temporraire de l'onglet coloration syntaxique avant l'application
    ''' </summary>
    ''' <remarks>Cette structure est utiliser par frmApplicationSettings</remarks>
    Public Structure ParamColorationSyntaxique
        Public AnchorColor As Color
        Public CommandsColor As Color
        Public CommentColor As Color
        Public IntegerColor As Color
        Public KeywordColor As Color
        Public OperatorColor As Color
        Public VariableColor As Color
        Public AnchorState As Boolean
        Public CommandsState As Boolean
        Public CommentsState As Boolean
        Public IntegerState As Boolean
        Public KeywordsState As Boolean
        Public OperatorState As Boolean
        Public VariableState As Boolean
    End Structure

    ''' <summary>
    ''' Reset les paramètres de l'application en partie ou en entier.
    ''' </summary>
    ''' <param name="ResetMetode">1 --> Onglet Général, 2 --> Onglet Coloration syntaxique, 3 --> Onglet éditeur, -1 --> Tous les paramêtres</param>
    Public Sub ResetGUIDosboxSettings(ByVal ResetMetode As Integer)
        Select Case ResetMetode

            Case 1 '-->  'Reset de l'onglet Général

            Case 2 '-->  'Reset de l'onglet Coloration Syntaxique
                'Reset des paramêtres
                With My.Settings
                    .AnchorColor = Color.Brown
                    .CommandsColor = Color.DeepSkyBlue
                    .CommentColor = Color.Green
                    .IntegerColor = Color.Maroon
                    .KeywordColor = Color.Blue
                    .OperatorColor = Color.Red
                    .VariableColor = Color.Purple
                    .AnchorState = True
                    .CommandsState = True
                    .CommentsState = True
                    .IntegerState = False
                    .KeywordsState = True
                    .OperatorState = True
                    .VariableState = True
                End With

                'Enregistrement de nouveau paramêtres.
                My.Settings.Save()
                My.Settings.Reload()

            Case 3 '-->  'Reset de l'onglet Éditeur

            Case -1 '-->  'Reset de tous les paramêtres

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
              

            Case 2 '--> Onglet Coloration Syntaxique
                'Définition des nouveaux paramètres
                Dim newSettings As ParamColorationSyntaxique = CType(mySettings, ParamColorationSyntaxique)
                With My.Settings
                    If (newSettings.AnchorColor = Nothing) Then
                        .AnchorColor = newSettings.AnchorColor
                    End If
                    .CommandsColor = newSettings.CommandsColor
                    .CommentColor = newSettings.CommentColor
                    .IntegerColor = newSettings.IntegerColor
                    .KeywordColor = newSettings.KeywordColor
                    .OperatorColor = newSettings.OperatorColor
                    .VariableColor = newSettings.VariableColor
                    .AnchorState = newSettings.AnchorState
                    .CommandsState = newSettings.AnchorState
                    .CommentsState = newSettings.CommentsState
                    .IntegerState = newSettings.IntegerState
                    .KeywordsState = newSettings.OperatorState
                    .OperatorState = newSettings.OperatorState
                    .VariableState = newSettings.VariableState
                End With

                'Enregistrement des paramètres
                My.Settings.Save()
                My.Settings.Reload()

        End Select

    End Sub

End Module
