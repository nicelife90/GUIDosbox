' [--> GUIDosbox <--]
' Créé par : Nice-Life90
' http://www.kobixxe.com
' Copyright (C) 2010 - 2013 Kobixxe - Montréal 
' Tous droits réservés

' [--> Contenue du fichhier <-] 
' frmApplicationSettings --> Form qui permet de choisr les paramètres de l'application.

Option Strict On
Option Explicit On

Public Class frmApplicationSettings



#Region " TabControl Tweak "
    ''' <summary>
    ''' Tweek le tabControl pour avoir des onglets à gauche et un texte dans le bon sens.
    ''' --> Paramètres concepteur requis :
    '''     Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
    '''     Me.TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
    '''     Me.TabControl1.ItemSize = New System.Drawing.Size(30, 170)
    '''     Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
    ''' </summary>
    Private Sub TabControl1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles TabControl1.DrawItem
        Dim g As Graphics
        Dim sText As String
        Dim iX As Integer
        Dim iY As Integer
        Dim sizeText As SizeF
        Dim ctlTab As TabControl
        Dim r As New RectangleF(e.Bounds.X, e.Bounds.Y + 2, e.Bounds.Width, e.Bounds.Height - 2)
        ctlTab = CType(sender, TabControl)
        g = e.Graphics
        sText = ctlTab.TabPages(e.Index).Text
        sizeText = g.MeasureString(sText, ctlTab.Font)
        iX = e.Bounds.Left + 6
        iY = CInt(e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2)
        Dim color As Color = color.FromArgb(255, 11, 110, 140)
        Dim brush As New SolidBrush(color)
        g.DrawString(sText, ctlTab.Font, brush, iX, iY)
    End Sub
#End Region

    Private Sub frmApplicationSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Retour au cp
        CP.Show()
    End Sub

    Private Sub frmApplicationSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Mise à jour de l'interface d'utilisateur selon les bon paramètres
        LoadGUIDosboxSettings()
    End Sub

    ''' <summary>
    ''' Paramètres l'interface d'utilisateur selon les setting choisi.
    ''' </summary>
    Public Sub LoadGUIDosboxSettings()

        '------------->> Initialiser la structure ne meme temp qui l'interface.

        With My.Settings
            'Affichage des couleur choisi.
            pbColorAnchors.BackColor = .AnchorColor
            pbColorCommands.BackColor = .CommandsColor
            pbColorComments.BackColor = .CommentColor
            pbColorIntegers.BackColor = .IntegerColor
            pbColorKeywords.BackColor = .KeywordColor
            pbColorOperators.BackColor = .OperatorColor
            pbColorVariables.BackColor = .VariableColor

            'Affichage des paramètres choisi.
            If .AnchorState = True Then
                optAnchors.Checked = True
            End If
            If .CommandsState = True Then
                optCommands.Checked = True
            End If
            If .CommentsState = True Then
                optComments.Checked = True
            End If
            If .IntegerState = True Then
                optInteger.Checked = True
            End If
            If .KeywordsState = True Then
                optKeywords.Checked = True
            End If
            If .OperatorState Then
                optOperators.Checked = True
            End If
            If .VariableState Then
                optVariables.Checked = True
            End If
        End With
    End Sub


#Region " Tab Coloration Syntaxique "

    ''' <summary>
    ''' Stoke les paramètres temporraire.
    ''' </summary>
    Dim tmpColorationSyntaxque As New ParamColorationSyntaxique


    Private Sub pbColorKeywords_Click(sender As Object, e As EventArgs) Handles pbColorKeywords.Click
        If cd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbColorKeywords.BackColor = cd.Color
            tmpColorationSyntaxque.KeywordColor = cd.Color
        End If
    End Sub

    Private Sub pbColorCommands_Click(sender As Object, e As EventArgs) Handles pbColorCommands.Click
        If cd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbColorCommands.BackColor = cd.Color
            tmpColorationSyntaxque.CommandsColor = cd.Color
        End If
    End Sub

    Private Sub pbColorAnchors_Click(sender As Object, e As EventArgs) Handles pbColorAnchors.Click
        If cd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbColorAnchors.BackColor = cd.Color
            tmpColorationSyntaxque.AnchorColor = cd.Color
        End If
    End Sub

    Private Sub pbColorIntegers_Click(sender As Object, e As EventArgs) Handles pbColorIntegers.Click
        If cd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbColorIntegers.BackColor = cd.Color
            tmpColorationSyntaxque.IntegerColor = cd.Color
        End If
    End Sub

    Private Sub pbColorVariables_Click(sender As Object, e As EventArgs) Handles pbColorVariables.Click
        If cd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbColorVariables.BackColor = cd.Color
            tmpColorationSyntaxque.VariableColor = cd.Color
        End If
    End Sub

    Private Sub pbColorOperators_Click(sender As Object, e As EventArgs) Handles pbColorOperators.Click
        If cd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbColorOperators.BackColor = cd.Color
            tmpColorationSyntaxque.OperatorColor = cd.Color
        End If
    End Sub

    Private Sub pbColorComments_Click(sender As Object, e As EventArgs) Handles pbColorComments.Click
        If cd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbColorOperators.BackColor = cd.Color
            tmpColorationSyntaxque.OperatorColor = cd.Color
        End If
    End Sub

    Private Sub btnCsDefault_Click(sender As Object, e As EventArgs) Handles btnCsDefault.Click
        'Reset des settings de la coloration syntaxique.
        ResetGUIDosboxSettings(2)
        LoadGUIDosboxSettings()
    End Sub

    Private Sub btnCsApply_Click(sender As Object, e As EventArgs) Handles btnCsApply.Click
        'btnCsApply --> Enregistrement et retour au cp
        SaveGUIDosboxSetting(tmpColorationSyntaxque, 2)
        LoadGUIDosboxSettings()
        MsgBox(tmpColorationSyntaxque.AnchorState.ToString)
        Me.Close()
        CP.Show()
    End Sub

    Private Sub btnCsCancel_Click(sender As Object, e As EventArgs) Handles btnCsCancel.Click
        'btnCsCancel --> Retour au cp.
        Me.Close()
        CP.Show()
    End Sub
#End Region




End Class