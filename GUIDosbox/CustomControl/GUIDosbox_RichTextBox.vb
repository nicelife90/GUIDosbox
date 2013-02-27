' [--> GUIDosbox <--]
' Créé par : Nice-Life90
' http://www.kobixxe.com
' Copyright (C) 2010 - 2013 Kobixxe - Montréal 
' Tous droits réservés

' [--> Contenue du fichhier <-] 
' Ce code est un RichTextBox au quel j'ai étendu des options d'impression et 
' de coloration syntaxique pour les Batch File. 

Option Strict On
Option Explicit On

Imports System
Imports System.IO
Imports System.Text
Imports System.Drawing
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Drawing.Printing
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions

Public Class GUIDosbox_RichTextBox
    Inherits RichTextBox



#Region " Paramètres du RichTextBox "
    ''' <summary>
    ''' Paramètres du RichTextBox par défaut
    ''' </summary>
    Public Sub New()
        Me.BackColor = Color.Gainsboro
        Me.ForeColor = Color.Black
        Me.Font = New Font("Lucida Console", 9, FontStyle.Regular, GraphicsUnit.Point)
        Me.BorderStyle = Windows.Forms.BorderStyle.None
        Me.DetectUrls = False
        Me.EnableAutoDragDrop = True
    End Sub
#End Region

#Region " Options d'impression ajouté "

    ' Fonction d'impression ajouté qui permètte de faire une mise en page du texte 
    ' à partir dun Richtextbox.

    ' Cette partie de code à été créé par Microsoft. 

    <StructLayout(LayoutKind.Sequential)> _
    Private Structure STRUCT_RECT
        Public left As Int32
        Public top As Int32
        Public right As Int32
        Public bottom As Int32
    End Structure

    <StructLayout(LayoutKind.Sequential)> _
    Private Structure STRUCT_CHARRANGE
        Public cpMin As Int32
        Public cpMax As Int32
    End Structure

    <StructLayout(LayoutKind.Sequential)> _
    Private Structure STRUCT_FORMATRANGE
        Public hdc As IntPtr
        Public hdcTarget As IntPtr
        Public rc As STRUCT_RECT
        Public rcPage As STRUCT_RECT
        Public chrg As STRUCT_CHARRANGE
    End Structure

    <StructLayout(LayoutKind.Sequential)> _
    Private Structure STRUCT_CHARFORMAT
        Public cbSize As Integer
        Public dwMask As UInt32
        Public dwEffects As UInt32
        Public yHeight As Int32
        Public yOffset As Int32
        Public crTextColor As Int32
        Public bCharSet As Byte
        Public bPitchAndFamily As Byte
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)> _
        Public szFaceName() As Char
    End Structure

    <DllImport("user32.dll")> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, _
                                        ByVal msg As Int32, _
                                        ByVal wParam As Int32, _
                                        ByVal lParam As IntPtr) As Int32
    End Function

    ' Windows Message defines
    Private Const WM_USER As Int32 = &H400&
    Private Const EM_FORMATRANGE As Int32 = WM_USER + 57
    Private Const EM_GETCHARFORMAT As Int32 = WM_USER + 58
    Private Const EM_SETCHARFORMAT As Int32 = WM_USER + 68

    ' Defines for EM_GETCHARFORMAT/EM_SETCHARFORMAT
    Private SCF_SELECTION As Int32 = &H1&
    Private SCF_WORD As Int32 = &H2&
    Private SCF_ALL As Int32 = &H4&

    ' Defines for STRUCT_CHARFORMAT member dwMask
    ' (Long because UInt32 is not an intrinsic type)
    Private Const CFM_BOLD As Long = &H1&
    Private Const CFM_ITALIC As Long = &H2&
    Private Const CFM_UNDERLINE As Long = &H4&
    Private Const CFM_STRIKEOUT As Long = &H8&
    Private Const CFM_PROTECTED As Long = &H10&
    Private Const CFM_LINK As Long = &H20&
    Private Const CFM_SIZE As Long = &H80000000&
    Private Const CFM_COLOR As Long = &H40000000&
    Private Const CFM_FACE As Long = &H20000000&
    Private Const CFM_OFFSET As Long = &H10000000&
    Private Const CFM_CHARSET As Long = &H8000000&

    ' Defines for STRUCT_CHARFORMAT member dwEffects
    Private Const CFE_BOLD As Long = &H1&
    Private Const CFE_ITALIC As Long = &H2&
    Private Const CFE_UNDERLINE As Long = &H4&
    Private Const CFE_STRIKEOUT As Long = &H8&
    Private Const CFE_PROTECTED As Long = &H10&
    Private Const CFE_LINK As Long = &H20&
    Private Const CFE_AUTOCOLOR As Long = &H40000000&

    ' Calculate or render the contents of our RichTextBox for printing
    '
    ' Parameter "measureOnly": If true, only the calculation is performed,
    '                          otherwise the text is rendered as well
    ' Parameter "e": The PrintPageEventArgs object from the PrintPage event
    ' Parameter "charFrom": Index of first character to be printed
    ' Parameter "charTo": Index of last character to be printed
    ' Return value: (Index of last character that fitted on the page) + 1
    Public Function FormatRange(ByVal measureOnly As Boolean, _
                                ByVal e As PrintPageEventArgs, _
                                ByVal charFrom As Integer, _
                                ByVal charTo As Integer) As Integer
        ' Specify which characters to print
        Dim cr As STRUCT_CHARRANGE
        cr.cpMin = charFrom
        cr.cpMax = charTo

        ' Specify the area inside page margins
        Dim rc As STRUCT_RECT
        rc.top = HundredthInchToTwips(e.MarginBounds.Top)
        rc.bottom = HundredthInchToTwips(e.MarginBounds.Bottom)
        rc.left = HundredthInchToTwips(e.MarginBounds.Left)
        rc.right = HundredthInchToTwips(e.MarginBounds.Right)

        ' Specify the page area
        Dim rcPage As STRUCT_RECT
        rcPage.top = HundredthInchToTwips(e.PageBounds.Top)
        rcPage.bottom = HundredthInchToTwips(e.PageBounds.Bottom)
        rcPage.left = HundredthInchToTwips(e.PageBounds.Left)
        rcPage.right = HundredthInchToTwips(e.PageBounds.Right)

        ' Get device context of output device
        Dim hdc As IntPtr
        hdc = e.Graphics.GetHdc()

        ' Fill in the FORMATRANGE structure
        Dim fr As STRUCT_FORMATRANGE
        fr.chrg = cr
        fr.hdc = hdc
        fr.hdcTarget = hdc
        fr.rc = rc
        fr.rcPage = rcPage

        ' Non-Zero wParam means render, Zero means measure
        Dim wParam As Int32
        If measureOnly Then
            wParam = 0
        Else
            wParam = 1
        End If

        ' Allocate memory for the FORMATRANGE struct and
        ' copy the contents of our struct to this memory
        Dim lParam As IntPtr
        lParam = Marshal.AllocCoTaskMem(Marshal.SizeOf(fr))
        Marshal.StructureToPtr(fr, lParam, False)

        ' Send the actual Win32 message
        Dim res As Integer
        res = SendMessage(Handle, EM_FORMATRANGE, wParam, lParam)

        ' Free allocated memory
        Marshal.FreeCoTaskMem(lParam)

        ' and release the device context
        e.Graphics.ReleaseHdc(hdc)

        Return res
    End Function

    ' Convert between 1/100 inch (unit used by the .NET framework)
    ' and twips (1/1440 inch, used by Win32 API calls)
    '
    ' Parameter "n": Value in 1/100 inch
    ' Return value: Value in twips
    Private Function HundredthInchToTwips(ByVal n As Integer) As Int32
        Return Convert.ToInt32(n * 14.4)
    End Function

    ' Free cached data from rich edit control after printing
    Public Sub FormatRangeDone()
        Dim lParam As New IntPtr(0)
        SendMessage(Handle, EM_FORMATRANGE, 0, lParam)
    End Sub

    ' Sets the font only for the selected part of the rich text box
    ' without modifying the other properties like size or style
    ' <param name="face">Name of the font to use</param>
    ' <returns>true on success, false on failure</returns>
    Public Function SetSelectionFont(ByVal face As String) As Boolean
        Dim cf As New STRUCT_CHARFORMAT()
        cf.cbSize = Marshal.SizeOf(cf)
        cf.dwMask = Convert.ToUInt32(CFM_FACE)

        ' ReDim face name to relevant size
        ReDim cf.szFaceName(32)
        face.CopyTo(0, cf.szFaceName, 0, Math.Min(31, face.Length))

        Dim lParam As IntPtr
        lParam = Marshal.AllocCoTaskMem(Marshal.SizeOf(cf))
        Marshal.StructureToPtr(cf, lParam, False)

        Dim res As Integer
        res = SendMessage(Handle, EM_SETCHARFORMAT, SCF_SELECTION, lParam)
        If (res = 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    ' Sets the font size only for the selected part of the rich text box
    ' without modifying the other properties like font or style
    ' <param name="size">new point size to use</param>
    ' <returns>true on success, false on failure</returns>
    Public Function SetSelectionSize(ByVal size As Integer) As Boolean
        Dim cf As New STRUCT_CHARFORMAT()
        cf.cbSize = Marshal.SizeOf(cf)
        cf.dwMask = Convert.ToUInt32(CFM_SIZE)
        ' yHeight is in 1/20 pt
        cf.yHeight = size * 20

        Dim lParam As IntPtr
        lParam = Marshal.AllocCoTaskMem(Marshal.SizeOf(cf))
        Marshal.StructureToPtr(cf, lParam, False)

        Dim res As Integer
        res = SendMessage(Handle, EM_SETCHARFORMAT, SCF_SELECTION, lParam)
        If (res = 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    ' Sets the bold style only for the selected part of the rich text box
    ' without modifying the other properties like font or size
    ' <param name="bold">make selection bold (true) or regular (false)</param>
    ' <returns>true on success, false on failure</returns>
    Public Function SetSelectionBold(ByVal bold As Boolean) As Boolean
        If (bold) Then
            Return SetSelectionStyle(CFM_BOLD, CFE_BOLD)
        Else
            Return SetSelectionStyle(CFM_BOLD, 0)
        End If
    End Function

    ' Sets the italic style only for the selected part of the rich text box
    ' without modifying the other properties like font or size
    ' <param name="italic">make selection italic (true) or regular (false)</param>
    ' <returns>true on success, false on failure</returns>
    Public Function SetSelectionItalic(ByVal italic As Boolean) As Boolean
        If (italic) Then
            Return SetSelectionStyle(CFM_ITALIC, CFE_ITALIC)
        Else
            Return SetSelectionStyle(CFM_ITALIC, 0)
        End If
    End Function

    ' Sets the underlined style only for the selected part of the rich text box
    ' without modifying the other properties like font or size
    ' <param name="underlined">make selection underlined (true) or regular (false)</param>
    ' <returns>true on success, false on failure</returns>
    Public Function SetSelectionUnderlined(ByVal underlined As Boolean) As Boolean
        If (underlined) Then
            Return SetSelectionStyle(CFM_UNDERLINE, CFE_UNDERLINE)
        Else
            Return SetSelectionStyle(CFM_UNDERLINE, 0)
        End If
    End Function

    ' Set the style only for the selected part of the rich text box
    ' with the possibility to mask out some styles that are not to be modified
    ' <param name="mask">modify which styles?</param>
    ' <param name="effect">new values for the styles</param>
    ' <returns>true on success, false on failure</returns>
    Private Function SetSelectionStyle(ByVal mask As Int32, ByVal effect As Int32) As Boolean
        Dim cf As New STRUCT_CHARFORMAT()
        cf.cbSize = Marshal.SizeOf(cf)
        cf.dwMask = Convert.ToUInt32(mask)
        cf.dwEffects = Convert.ToUInt32(effect)

        Dim lParam As IntPtr
        lParam = Marshal.AllocCoTaskMem(Marshal.SizeOf(cf))
        Marshal.StructureToPtr(cf, lParam, False)

        Dim res As Integer
        res = SendMessage(Handle, EM_SETCHARFORMAT, SCF_SELECTION, lParam)
        If (res = 0) Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

#Region "Options de coloration syntaxique ajouté "
    Private m_settings As New SyntaxSettings()
    Private Shared m_bPaint As Boolean = True
    Private m_strLine As String = ""
    Private m_nContentLength As Integer = 0
    Private m_nLineLength As Integer = 0
    Private m_nLineStart As Integer = 0
    Private m_nLineEnd As Integer = 0
    Private m_strKeywords As String = ""
    Private m_strKeywordsCommands As String = ""
    Private m_nCurSelection As Integer = 0

    ''' <summary>
    ''' Propriétés de la coloration syntaxique.
    ''' </summary>
    Public ReadOnly Property Settings() As SyntaxSettings
        Get
            Return m_settings
        End Get
    End Property

    ''' <summary>
    ''' WndProc
    ''' </summary>
    ''' <param name="m"></param>
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = &HF Then
            If m_bPaint Then
                MyBase.WndProc(m)
            Else
                m.Result = IntPtr.Zero
            End If
        Else
            MyBase.WndProc(m)
        End If
    End Sub

    ''' <summary>
    ''' Évenement --> OnTextChanged
    ''' </summary>
    Protected Overrides Sub OnTextChanged(ByVal e As EventArgs)

        ' Calcul de la longueur du texte
        m_nContentLength = Me.TextLength

        Dim nCurrentSelectionStart As Integer = SelectionStart
        Dim nCurrentSelectionLength As Integer = SelectionLength

        m_bPaint = False

        ' On trouve le début de la ligne.
        m_nLineStart = nCurrentSelectionStart
        Do While (m_nLineStart > 0) AndAlso (Text.Chars(m_nLineStart - 1) <> ControlChars.Lf)
            m_nLineStart -= 1
        Loop
        ' on trouve la fin de la ligne.
        m_nLineEnd = nCurrentSelectionStart
        Do While (m_nLineEnd < Text.Length) AndAlso (Text.Chars(m_nLineEnd) <> ControlChars.Lf)
            m_nLineEnd += 1
        Loop

        ' calcul de la longueur de la ligne.
        m_nLineLength = m_nLineEnd - m_nLineStart

        ' Affectation de la ligne actuelle.
        m_strLine = Text.Substring(m_nLineStart, m_nLineLength)

        ' Traitement de la ligne.
        ProcessLine()

        m_bPaint = True
    End Sub

    ''' <summary>
    ''' Coloration syntaxique d'une ligne.
    ''' </summary>
    Private Sub ProcessLine()

        ' Enregistrement de la position et couleur noir pour la ligne.
        Dim nPosition As Integer = SelectionStart
        SelectionStart = m_nLineStart
        SelectionLength = m_nLineLength
        SelectionColor = Color.Black

        ColorationsProgresStatus = 0

        ' Traitement du @
        ProcessRegex("@", Color.HotPink)
        ColorationsProgresStatus = 12
        ColorationProgressOutput = "Traitement des @"

        ' Traitement des mots clées
        If Settings.EnableKeywords Then
            ProcessRegex(m_strKeywords, Settings.KeywordColor)
            ColorationProgressOutput = "Traitement des mot clées"
            ColorationsProgresStatus = 25
        End If

        ' Traitement des commandes
        If Settings.EnableCommands Then
            ProcessRegex(m_strKeywordsCommands, Settings.KeywordCommandsColor)
            ColorationProgressOutput = "Traitement des commandes"
            ColorationsProgresStatus = 37
        End If

        'Traitement des opérateurs
        If Settings.EnableOperators Then
            ProcessRegex("\+|\*|=|<|>|>>|\||\?", Settings.OperatorColor)
            ColorationProgressOutput = "Traitement des opérateurs"
            ColorationsProgresStatus = 50
        End If

        'Traitement des variables
        If Settings.EnableVariables Then
            ProcessRegex("%+[a-zA-Z0-9]+%", Settings.VariableColor)
            ColorationProgressOutput = "Traitement des variables"
            ColorationsProgresStatus = 62
        End If

        'Traitement des encres
        If Settings.EnableAnchors Then
            ProcessRegex("^:[a-zA-Z0-9]*", Settings.AnchorColor)
            ColorationProgressOutput = "Traitement des ancres"
            ColorationsProgresStatus = 74
        End If

        ' Traitement des chiffres
        If Settings.EnableIntegers Then
            ProcessRegex("\b(?:[0-9]*\.)?[0-9]+\b", Settings.IntegerColor)
            ColorationProgressOutput = "Traitement des chiffres"
            ColorationsProgresStatus = 86
        End If

        ' Traitement des commentaires
        If Settings.EnableComments AndAlso (Not String.IsNullOrEmpty(Settings.Comment)) Then
            ProcessRegex(Settings.Comment & ".*$", Settings.CommentColor)
            ColorationsProgresStatus = 100
            ColorationProgressOutput = "Traitement des commentaires"
        End If
        
        SelectionStart = nPosition
        SelectionLength = 0
        SelectionColor = Color.Black

        m_nCurSelection = nPosition
    End Sub

    ''' <summary>
    ''' Colloration Syntaxique de toutes les lignes.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ProcessAllLines()

        m_bPaint = False
        Dim nStartPos As Integer = 0
        Dim i As Integer = 0
        Dim nOriginalPos As Integer = SelectionStart
        Do While i < Lines.Length
            m_strLine = Lines(i)
            m_nLineStart = nStartPos
            m_nLineEnd = m_nLineStart + m_strLine.Length

            ProcessLine()
            i += 1
            ColorationProgressLine = i

            nStartPos += m_strLine.Length + 1
        Loop
        m_bPaint = True
    End Sub

    ''' <summary>
    ''' Traitement de l'expression régulière.
    ''' </summary>
    ''' <param name="strRegex">Expression Régulières</param>
    ''' <param name="color">Couleur</param>
    Private Sub ProcessRegex(ByVal strRegex As String, ByVal color As Color)
        Dim regKeywords As New Regex(strRegex, RegexOptions.IgnoreCase Or RegexOptions.Compiled)
        Dim regMatch As Match

        regMatch = regKeywords.Match(m_strLine)
        Do While regMatch.Success
            ' Traitement du mot
            Dim nStart As Integer = m_nLineStart + regMatch.Index
            Dim nLenght As Integer = regMatch.Length
            SelectionStart = nStart
            SelectionLength = nLenght
            SelectionColor = color
            regMatch = regMatch.NextMatch()
        Loop
    End Sub

    ''' <summary>
    ''' Compillation des mots clés et des commande en expression régulières
    ''' </summary>
    Public Sub CompileKeywords()

        'Compillation des mots clées
        For i As Integer = 0 To Settings.Keywords.Count - 1
            Dim strKeyword As String = Settings.Keywords(i)

            If i = Settings.Keywords.Count - 1 Then
                m_strKeywords &= "\b" & strKeyword & "\b"
            Else
                m_strKeywords &= "\b" & strKeyword & "\b|"
            End If
        Next i

        'Compillations des commandes
        For i As Integer = 0 To Settings.KeywordsCommands.Count - 1
            Dim strKeywordCommands As String = Settings.KeywordsCommands(i)

            If i = Settings.KeywordsCommands.Count - 1 Then
                m_strKeywordsCommands &= "\b" & strKeywordCommands & "\b"
            Else
                m_strKeywordsCommands &= "\b" & strKeywordCommands & "\b|"
            End If
        Next i
    End Sub
#End Region
End Class

''' <summary>
''' Class pour enregistrers les objets de syntaxe 
''' </summary>
Public Class SyntaxList
    Public m_rgList As New List(Of String)()
    Public m_color As New Color()
End Class

''' <summary>
''' Propriétés et parramètres - Coloration Syntaxique
''' </summary>
Public Class SyntaxSettings
#Region " Propriétés ajouté - Coloration Syntaxique "

    'Variable mots clés 
    Private m_rgKeywords As New SyntaxList()
    Private m_rgKeywordsCommands As New SyntaxList()
    Private m_strComment As String = ""

    'Variable couleur
    Private m_colorComment As Color = Color.Green
    Private m_colorInteger As Color = Color.Red
    Private m_colorAnchor As Color = Color.Brown
    Private m_colorOperator As Color = Color.Red
    Private m_colorVariable As Color = Color.Purple

    'Variable ON/OFF
    Private m_bEnableKeywords As Boolean = True
    Private m_bEnableCommands As Boolean = True
    Private m_bEnableComments As Boolean = True
    Private m_bEnableIntegers As Boolean = True
    Private m_bEnableAnchors As Boolean = True
    Private m_bEnableOperators As Boolean = True
    Private m_bEnableVariables As Boolean = True

    ' -------------------  Mot clés  ----------------------------

    ''' <summary>
    ''' Liste contenant tous les mots clés.
    ''' </summary>
    Public ReadOnly Property Keywords() As List(Of String)
        Get
            Return m_rgKeywords.m_rgList
        End Get
    End Property

    ''' <summary>
    ''' Liste contenant toutes les commandes.
    ''' </summary>
    Public ReadOnly Property KeywordsCommands() As List(Of String)
        Get
            Return m_rgKeywordsCommands.m_rgList
        End Get
    End Property

    ''' <summary>
    ''' Le Symbole qui identifie une ligne de commentaires.
    ''' </summary>
    Public Property Comment() As String
        Get
            Return m_strComment
        End Get
        Set(ByVal value As String)
            m_strComment = value
        End Set
    End Property

    ' ------------------- ON/OFF ---------------------------

    ''' <summary>
    ''' Activation/Désactivation de la coloration des mots clées.
    ''' </summary>
    Public Property EnableKeywords() As Boolean
        Get
            Return m_bEnableKeywords
        End Get
        Set(ByVal value As Boolean)
            m_bEnableKeywords = value
        End Set
    End Property

    ''' <summary>
    ''' Activation/Désactivation de la coloration des commandes.
    ''' </summary>
    Public Property EnableCommands() As Boolean
        Get
            Return m_bEnableCommands
        End Get
        Set(ByVal value As Boolean)
            m_bEnableCommands = value
        End Set
    End Property

    ''' <summary>
    ''' Activation/Désactivation de la coloration des commentaires.
    ''' </summary>
    Public Property EnableComments() As Boolean
        Get
            Return m_bEnableComments
        End Get
        Set(ByVal value As Boolean)
            m_bEnableComments = value
        End Set
    End Property

    ''' <summary>
    ''' Activation/Désactivation de la coloration des chiffres.
    ''' </summary>
    Public Property EnableIntegers() As Boolean
        Get
            Return m_bEnableIntegers
        End Get
        Set(ByVal value As Boolean)
            m_bEnableIntegers = value
        End Set
    End Property

    ''' <summary>
    ''' Activation/Désactivation de la coloration des ancres.
    ''' </summary>
    Public Property EnableAnchors() As Boolean
        Get
            Return m_bEnableAnchors
        End Get
        Set(ByVal value As Boolean)
            m_bEnableAnchors = value
        End Set
    End Property

    ''' <summary>
    ''' Activation/Désactivation de la coloration des variables.
    ''' </summary>
    Public Property EnableVariables() As Boolean
        Get
            Return m_bEnableVariables
        End Get
        Set(ByVal value As Boolean)
            m_bEnableVariables = value
        End Set
    End Property

    ''' <summary>
    ''' Activation/Désactivation de la coloration des opérateurs.
    ''' </summary>
    Public Property EnableOperators() As Boolean
        Get
            Return m_bEnableOperators
        End Get
        Set(ByVal value As Boolean)
            m_bEnableOperators = value
        End Set
    End Property

    ' -------------------  Couleurs  ---------------------------

    ''' <summary>
    ''' Couleur des mots clés.
    ''' </summary>
    Public Property KeywordColor() As Color
        Get
            Return m_rgKeywords.m_color
        End Get
        Set(ByVal value As Color)
            m_rgKeywords.m_color = value
        End Set
    End Property

    ''' <summary>
    ''' Couleur des commandes.
    ''' </summary>
    Public Property KeywordCommandsColor() As Color
        Get
            Return m_rgKeywordsCommands.m_color
        End Get
        Set(ByVal value As Color)
            m_rgKeywordsCommands.m_color = value
        End Set
    End Property

    ''' <summary>
    ''' Couleur des commentaires.
    ''' </summary>
    Public Property CommentColor() As Color
        Get
            Return m_colorComment
        End Get
        Set(ByVal value As Color)
            m_colorComment = value
        End Set
    End Property

    ''' <summary>
    ''' Couleur des ancres.
    ''' </summary>
    Public Property AnchorColor() As Color
        Get
            Return m_colorAnchor
        End Get
        Set(ByVal value As Color)
            m_colorAnchor = value
        End Set
    End Property

    ''' <summary>
    ''' Couleur des opérateurs.
    ''' </summary>
    Public Property OperatorColor() As Color
        Get
            Return m_colorOperator
        End Get
        Set(ByVal value As Color)
            m_colorOperator = value
        End Set
    End Property

    ''' <summary>
    ''' Couleurs des variable.
    ''' </summary>
    Public Property VariableColor() As Color
        Get
            Return m_colorVariable
        End Get
        Set(ByVal value As Color)
            m_colorVariable = value
        End Set
    End Property

    ''' <summary>
    ''' Couleur des chiffres.
    ''' </summary>
    Public Property IntegerColor() As Color
        Get
            Return m_colorInteger
        End Get
        Set(ByVal value As Color)
            m_colorInteger = value
        End Set
    End Property

#End Region
End Class
