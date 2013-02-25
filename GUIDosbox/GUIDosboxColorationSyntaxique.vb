' [--> GUIDosbox <--]
' Créé par : Nice-Life90
' http://www.kobixxe.com
' Copyright (C) 2010 - 2013 Kobixxe - Montréal 
' Tous droits réservés

' [--> Contenue du fichhier <-] 
' Ce module contient toute le système d'initialisation de la coloration syntaxique.
' Nous ajoutons les mots clés, les commandes, les couleurs ici.
' Le traitement de la coloration ce fais dans --> GUIDosbox_RichTextBox

Option Strict On
Option Explicit On

Module GUIDosboxColorationSyntaxique

    ''' <summary>
    ''' Variable pour le Loading du formulaire frmBatEdit
    ''' </summary>
    Public ColorationsProgresStatus As Integer = 0
    Public ColorationProgressOutput As String = Nothing
    Public ColorationProgressLine As Integer = 0
    Public loaded As Boolean = False

    ''' <summary>
    ''' Fais la coloration syntaxique d'un batch file dans le GUIDosbox_RichTextBox.
    ''' </summary>
    ''' <param name="TextBox">Nom de GUIDosbox_RichTextBox</param>
    Public Sub ColorationSyntaxique(ByVal TextBox As GUIDosbox_RichTextBox)

        ' Ajout des mots clé à la coloration syntaxique
        Dim Keywords() As String = _
            {"cls", "echo", "echo.", "if", "not", "set", "goto", "pause", "con"}

        For Each Keyword As String In Keywords
            TextBox.Settings.Keywords.Add(Keyword)
        Next

        ' Ajout des commande à la coloration syntaxique
        Dim Commands() As String = _
            {"title", "color", "mode", "ping"}

        For Each Command As String In Commands
            TextBox.Settings.KeywordsCommands.Add(Command)
        Next

        'Caractères qui identifie une ligne de commentaire.
        TextBox.Settings.Comment = "REM"

        ' Préparation de tous les mot clés
        TextBox.CompileKeywords()

        ' Couleur de la coloration Syntaxique.
        TextBox.Settings.KeywordColor = Color.Blue
        TextBox.Settings.KeywordCommandsColor = Color.DeepSkyBlue
        TextBox.Settings.AnchorColor = Color.Brown
        TextBox.Settings.VariableColor = Color.Purple
        TextBox.Settings.OperatorColor = Color.Red
        TextBox.Settings.CommentColor = Color.Green
        TextBox.Settings.IntegerColor = Color.Maroon

        'Activation / Désactivation de la colorations 
        TextBox.Settings.EnableKeywords = True
        TextBox.Settings.EnableCommands = True
        TextBox.Settings.EnableComments = True
        TextBox.Settings.EnableAnchors = True
        TextBox.Settings.EnableVariables = True
        TextBox.Settings.EnableOperators = True
        TextBox.Settings.EnableIntegers = False

        ' Coloration du texte
        TextBox.ProcessAllLines()
    End Sub
End Module
