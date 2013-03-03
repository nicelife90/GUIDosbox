' [--> GUIDosbox <--]
' Créé par : Nice-Life90
' http://www.guidosbox.com
' Copyright (C) 2010 - 2013 GUIDosbox - Montréal 
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
    ''' Ce sub est situé dans GUIDosboxColorationSyntaxique
    ''' </summary>
    ''' <param name="TextBox">Nom de GUIDosbox_RichTextBox</param>
    Public Sub ColorationSyntaxique(ByVal TextBox As GUIDosbox_RichTextBox)

        ' Ajout des mots clé à la coloration syntaxique
        Dim Keywords() As String = _
            {"CLS", "ECHO", "ECHO.", "IF", "NOT", "SET", "GOTO", "PAUSE", "CON", "IN", _
             "DO", "CHOICE", "EXIST", "CALL", "SHIFT", "ERRORLEVEL", "EXIT", "NUL", _
             "FOR", "BREAK"}

        For Each Keyword As String In Keywords
            TextBox.Settings.Keywords.Add(Keyword)
        Next

        ' Ajout des commande à la coloration syntaxique
        Dim Commands() As String = _
            {"ASSOC", "ATTRIB", "BCDEDIT", "CACLS", "CD", "CHCP", "CHDIR", "CHKDSK", "CHKNTFS", "CMD", _
             "COLOR", "COMP", "COMPACT", "CONVERT", "COPY", "DATE", "DEL", "DIR", "DISKCOMP", "DISKCOPY", _
             "DISKPART", "DOSKEY", "DRIVERQUERY", "ENDLOCAL", "ERASE", "FC", "FIND", "FINDSTR", "FORMAT", _
             "FSUTIL", "FTYPE", "GPRESULT", "GRAFTABL", "HELP", "ICACLS", "LABEL", "MD", "MKDIR", "MKLINK", _
             "MODE", "MORE", "MOVE", "NET", "OPENFILES", "PATH", "POPD", "PRINT", "PROMPT", "PUSHD", "RD", _
             "RECOVER", "REN", "RENAME", "REPLACE", "RMDIR", "ROBOCOPY", "SETLOCAL", "SC", "SCHTASKS", "SHIFT", _
             "SHUTDOWN", "SLMGR", "SORT", "START", "SUBST", "SYSTEMINFO", "TASKLIST", "TASKKILL", "TIME", "TITLE", _
             "TREE", "TYPE", "VER", "VERIFY ", "VOL", "XCOPY" _
            }

        For Each Command As String In Commands
            TextBox.Settings.KeywordsCommands.Add(Command)
        Next

        'Caractères qui identifie une ligne de commentaire.
        TextBox.Settings.Comment = "REM"

        ' Préparation de tous les mot clés
        TextBox.CompileKeywords()

        With My.Settings
            ' Couleur de la coloration Syntaxique.
            TextBox.Settings.ArobasColor = .ArobasColor
            TextBox.Settings.KeywordColor = .KeywordColor
            TextBox.Settings.KeywordCommandsColor = .CommandsColor
            TextBox.Settings.AnchorColor = .AnchorColor
            TextBox.Settings.VariableColor = .VariableColor
            TextBox.Settings.OperatorColor = .OperatorColor
            TextBox.Settings.CommentColor = .CommentColor
            TextBox.Settings.IntegerColor = .IntegerColor

            'Activation / Désactivation de la colorations 
            TextBox.Settings.EnableArobas = .ArobasState
            TextBox.Settings.EnableKeywords = .KeywordsState
            TextBox.Settings.EnableCommands = .CommandsState
            TextBox.Settings.EnableComments = .CommentsState
            TextBox.Settings.EnableAnchors = .AnchorState
            TextBox.Settings.EnableVariables = .VariableState
            TextBox.Settings.EnableOperators = .OperatorState
            TextBox.Settings.EnableIntegers = .IntegerState
        End With

        ' Coloration du texte
        TextBox.ProcessAllLines()
    End Sub
End Module
