' [--> GUIDosbox <--]
' Créé par : Nice-Life90
' http://www.kobixxe.com
' Copyright (C) 2010 - 2013 Kobixxe - Montréal 
' Tous droits réservés

' [--> Contenue du fichhier <-] 
' frmApplicationSettings --> Form qui permet de choisr les paramètres de l'application.
' Ce form dépend du module --> GUIDosboxManageSettings

Option Strict On
Option Explicit On

Public Class frmApplicationSettings

    ''' <summary>
    ''' Stoke les paramètres temporraire de l'onglet Général.
    ''' </summary>
    Dim tmpGeneral As New ParamGeneral

    ''' <summary>
    ''' Stoke les paramètres temporraire de l'onglet Coloration Syntaxique.
    ''' </summary>
    Dim tmpColorationSyntaxique As New ParamColorationSyntaxique

    ''' <summary>
    ''' Stoke les paramètres temporraire de l'onglet Editor.
    ''' </summary>
    Dim tmpEditor As New ParamEditor

#Region " TabControl Tweak "
    ''' <summary>
    ''' Tweek le tabControl pour avoir des onglets à gauche et un texte dans le bon sens.
    ''' --> Paramètres concepteur requis :
    '''     Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
    '''     Me.TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
    '''     Me.TabControl1.ItemSize = New System.Drawing.Size(30, 170)
    '''     Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
    ''' </summary>
    Private Sub TabControl1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles TabControlMain.DrawItem
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

#Region " Load GUIDOSBOX Settings "
    ''' <summary>
    ''' Paramètres l'interface d'utilisateur selon les setting choisi.
    ''' </summary>
    Public Sub LoadGUIDosboxSettings()

        ' =================================================================== '
        ' ========================== Onglet Général ========================= '
        ' =================================================================== '

        With My.Settings
            'Affichage des paramètres actuellement choisi.
            If .ColororationState Then
                optColorationOnOff.Checked = True
            Else
                optColorationOnOff.Checked = False
            End If

            If .UpdateState Then
                optAutoUpdate.Checked = True
            Else
                optAutoUpdate.Checked = False
            End If

            'Affectation des valeurs actuelle à la structure paramGeneral
            'Load les valeurs actuellement sauvegarder dans settings avant d'être modifier 
            tmpGeneral.ColorationState = .ColororationState
            tmpGeneral.UpdateState = .UpdateState

        End With

        ' =================================================================== '
        ' ================= Onglet Coloration Syntaxique ==================== '
        ' =================================================================== '

        With My.Settings
            'Affichage des couleur actuellement choisi.
            pbColorArobas.BackColor = .ArobasColor
            pbColorAnchors.BackColor = .AnchorColor
            pbColorCommands.BackColor = .CommandsColor
            pbColorComments.BackColor = .CommentColor
            pbColorIntegers.BackColor = .IntegerColor
            pbColorKeywords.BackColor = .KeywordColor
            pbColorOperators.BackColor = .OperatorColor
            pbColorVariables.BackColor = .VariableColor

            'Affichage des paramètres actuellement choisi.
            If .ArobasState Then
                optArobas.Checked = True
            Else
                optArobas.Checked = False
            End If

            If .AnchorState Then
                optAnchors.Checked = True
            Else
                optAnchors.Checked = False
            End If

            If .CommandsState Then
                optCommands.Checked = True
            Else
                optCommands.Checked = False
            End If

            If .CommentsState Then
                optComments.Checked = True
            Else
                optComments.Checked = False
            End If

            If .IntegerState Then
                optInteger.Checked = True
            Else
                optInteger.Checked = False
            End If

            If .KeywordsState Then
                optKeywords.Checked = True
            Else
                optKeywords.Checked = False
            End If

            If .OperatorState Then
                optOperators.Checked = True
            Else
                optOperators.Checked = False
            End If

            If .VariableState Then
                optVariables.Checked = True
            Else
                optVariables.Checked = False
            End If

            'Affectation des valeurs actuelle à la structure paramColorationSyntaxique
            'Load les valeurs actuellement sauvegarder dans settings avant d'être modifier 
            tmpColorationSyntaxique.ArobasColor = .ArobasColor
            tmpColorationSyntaxique.AnchorColor = .AnchorColor
            tmpColorationSyntaxique.CommandsColor = .CommandsColor
            tmpColorationSyntaxique.CommentColor = .CommentColor
            tmpColorationSyntaxique.IntegerColor = .IntegerColor
            tmpColorationSyntaxique.KeywordColor = .KeywordColor
            tmpColorationSyntaxique.OperatorColor = .OperatorColor
            tmpColorationSyntaxique.VariableColor = .VariableColor
            tmpColorationSyntaxique.ArobasState = .ArobasState
            tmpColorationSyntaxique.AnchorState = .AnchorState
            tmpColorationSyntaxique.CommandsState = .CommandsState
            tmpColorationSyntaxique.CommentsState = .CommentsState
            tmpColorationSyntaxique.IntegerState = .IntegerState
            tmpColorationSyntaxique.KeywordsState = .KeywordsState
            tmpColorationSyntaxique.OperatorState = .OperatorState
            tmpColorationSyntaxique.VariableState = .VariableState

            ' =================================================================== '
            ' ========================== Onglet Editeur ========================= '
            ' =================================================================== '

            'Affichage de la couleur actuellement choisi.
            pbEditorColor.BackColor = .EditorBGColor

            'Affichage de la police actuellement choisi.
            fpEditorFont.Value = .EditorFont

            'Affectation des valeurs actuelle à la structure paramEditor
            'Load les valeurs actuellement sauvegarder dans settings avant d'être modifier 
            tmpEditor.EditorBgColor = .EditorBGColor
            tmpEditor.EditorFont = .EditorFont

        End With

    End Sub
#End Region

#Region " Tab Général"

    Private Sub optColorationOnOff_CheckedChanged(sender As Object, e As EventArgs) Handles optColorationOnOff.CheckedChanged
        If optColorationOnOff.Checked Then
            tmpGeneral.ColorationState = True
        Else
            tmpGeneral.ColorationState = False
        End If
    End Sub

    Private Sub optAutoUpdate_CheckedChanged(sender As Object, e As EventArgs) Handles optAutoUpdate.CheckedChanged
        If optAutoUpdate.Checked Then
            tmpGeneral.UpdateState = True
        Else
            tmpGeneral.UpdateState = False
        End If
    End Sub

    Private Sub btnGenDefault_Click(sender As Object, e As EventArgs) Handles btnGenDefault.Click
        'btnEdtDefault --> Reset des settings de l'éditeur.
        ResetGUIDosboxSettings(1)
        LoadGUIDosboxSettings()
    End Sub

    Private Sub btnAllDefault_Click(sender As Object, e As EventArgs) Handles btnAllDefault.Click
        'btnEdtDefault --> Reset des settings de l'éditeur.
        ResetGUIDosboxSettings(-1)
        LoadGUIDosboxSettings()
    End Sub

    Private Sub btnGenApply_Click(sender As Object, e As EventArgs) Handles btnGenApply.Click
        'btnEdtApply --> Enregistrement et retour au cp
        SaveGUIDosboxSetting(tmpGeneral, 1)
        SaveGUIDosboxSetting(tmpColorationSyntaxique, 2)
        SaveGUIDosboxSetting(tmpEditor, 3)
        Me.Close()
        CP.Show()
    End Sub

    Private Sub btnGenCancel_Click(sender As Object, e As EventArgs) Handles btnGenCancel.Click
        ' Retour au cp.
        Me.Close()
        CP.Show()
    End Sub

#End Region

#Region " Tab Coloration Syntaxique "

    Private Sub pbColorArobas_Click(sender As Object, e As EventArgs) Handles pbColorArobas.Click
        If cd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbColorArobas.BackColor = cd.Color
            tmpColorationSyntaxique.ArobasColor = cd.Color
        End If
    End Sub

    Private Sub pbColorKeywords_Click(sender As Object, e As EventArgs) Handles pbColorKeywords.Click
        If cd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbColorKeywords.BackColor = cd.Color
            tmpColorationSyntaxique.KeywordColor = cd.Color
        End If
    End Sub

    Private Sub pbColorCommands_Click(sender As Object, e As EventArgs) Handles pbColorCommands.Click
        If cd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbColorCommands.BackColor = cd.Color
            tmpColorationSyntaxique.CommandsColor = cd.Color
        End If
    End Sub

    Private Sub pbColorAnchors_Click(sender As Object, e As EventArgs) Handles pbColorAnchors.Click
        If cd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbColorAnchors.BackColor = cd.Color
            tmpColorationSyntaxique.AnchorColor = cd.Color
        End If
    End Sub

    Private Sub pbColorIntegers_Click(sender As Object, e As EventArgs) Handles pbColorIntegers.Click
        If cd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbColorIntegers.BackColor = cd.Color
            tmpColorationSyntaxique.IntegerColor = cd.Color
        End If
    End Sub

    Private Sub pbColorVariables_Click(sender As Object, e As EventArgs) Handles pbColorVariables.Click
        If cd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbColorVariables.BackColor = cd.Color
            tmpColorationSyntaxique.VariableColor = cd.Color
        End If
    End Sub

    Private Sub pbColorOperators_Click(sender As Object, e As EventArgs) Handles pbColorOperators.Click
        If cd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbColorOperators.BackColor = cd.Color
            tmpColorationSyntaxique.OperatorColor = cd.Color
        End If
    End Sub

    Private Sub pbColorComments_Click(sender As Object, e As EventArgs) Handles pbColorComments.Click
        If cd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbColorComments.BackColor = cd.Color
            tmpColorationSyntaxique.CommentColor = cd.Color
        End If
    End Sub

    Private Sub optArobas_CheckedChanged(sender As Object, e As EventArgs) Handles optArobas.CheckedChanged
        If optArobas.Checked Then
            tmpColorationSyntaxique.ArobasState = True
        Else
            tmpColorationSyntaxique.ArobasState = False
        End If
    End Sub

    Private Sub optKeywords_CheckedChanged(sender As Object, e As EventArgs) Handles optKeywords.CheckedChanged
        If optKeywords.Checked Then
            tmpColorationSyntaxique.KeywordsState = True
        Else
            tmpColorationSyntaxique.KeywordsState = False
        End If
    End Sub

    Private Sub optCommands_CheckedChanged(sender As Object, e As EventArgs) Handles optCommands.CheckedChanged
        If optCommands.Checked Then
            tmpColorationSyntaxique.CommandsState = True
        Else
            tmpColorationSyntaxique.CommandsState = False
        End If
    End Sub

    Private Sub optAnchors_CheckedChanged(sender As Object, e As EventArgs) Handles optAnchors.CheckedChanged
        If optAnchors.Checked Then
            tmpColorationSyntaxique.AnchorState = True
        Else
            tmpColorationSyntaxique.AnchorState = False
        End If
    End Sub

    Private Sub optInteger_CheckedChanged(sender As Object, e As EventArgs) Handles optInteger.CheckedChanged
        If optInteger.Checked Then
            tmpColorationSyntaxique.IntegerState = True
        Else
            tmpColorationSyntaxique.IntegerState = False
        End If
    End Sub

    Private Sub optVariables_CheckedChanged(sender As Object, e As EventArgs) Handles optVariables.CheckedChanged
        If optVariables.Checked Then
            tmpColorationSyntaxique.VariableState = True
        Else
            tmpColorationSyntaxique.VariableState = False
        End If
    End Sub

    Private Sub optOperators_CheckedChanged(sender As Object, e As EventArgs) Handles optOperators.CheckedChanged
        If optOperators.Checked Then
            tmpColorationSyntaxique.OperatorState = True
        Else
            tmpColorationSyntaxique.OperatorState = False
        End If
    End Sub

    Private Sub optComments_CheckedChanged(sender As Object, e As EventArgs) Handles optComments.CheckedChanged
        If optComments.Checked Then
            tmpColorationSyntaxique.CommentsState = True
        Else
            tmpColorationSyntaxique.CommentsState = False
        End If
    End Sub

    Private Sub btnCsDefault_Click(sender As Object, e As EventArgs) Handles btnCsDefault.Click
        'btnCsDefault --> Reset des settings de la coloration syntaxique.
        ResetGUIDosboxSettings(2)
        LoadGUIDosboxSettings()
    End Sub

    Private Sub btnCsApply_Click(sender As Object, e As EventArgs) Handles btnCsApply.Click
        'btnCsApply --> Enregistrement et retour au cp
        SaveGUIDosboxSetting(tmpGeneral, 1)
        SaveGUIDosboxSetting(tmpColorationSyntaxique, 2)
        SaveGUIDosboxSetting(tmpEditor, 3)
        Me.Close()
        CP.Show()
    End Sub

    Private Sub btnCsCancel_Click(sender As Object, e As EventArgs) Handles btnCsCancel.Click
        'btnCsCancel --> Retour au cp.
        Me.Close()
        CP.Show()
    End Sub
#End Region

#Region " Tab Éditeur "
    Private Sub pbEditorColor_Click(sender As Object, e As EventArgs) Handles pbEditorColor.Click
        If cd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbEditorColor.BackColor = cd.Color
            tmpEditor.EditorBgColor = cd.Color
        End If
    End Sub

    Private Sub fpEditorFont_ValueChanged(sender As Object, e As EventArgs) Handles fpEditorFont.ValueChanged
        tmpEditor.EditorFont = fpEditorFont.Value
    End Sub

    Private Sub btnEdtDefault_Click(sender As Object, e As EventArgs) Handles btnEdtDefault.Click
        'btnEdtDefault --> Reset des settings de l'éditeur.
        ResetGUIDosboxSettings(3)
        LoadGUIDosboxSettings()
    End Sub

    Private Sub btnEdtApply_Click(sender As Object, e As EventArgs) Handles btnEdtApply.Click
        'btnEdtApply --> Enregistrement et retour au cp
        SaveGUIDosboxSetting(tmpGeneral, 1)
        SaveGUIDosboxSetting(tmpColorationSyntaxique, 2)
        SaveGUIDosboxSetting(tmpEditor, 3)
        Me.Close()
        CP.Show()
    End Sub

    Private Sub btnEdtCancel_Click(sender As Object, e As EventArgs) Handles btnEdtCancel.Click
        ' Retour au cp.
        Me.Close()
        CP.Show()
    End Sub
#End Region

End Class