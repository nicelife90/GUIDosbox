' [--> GUIDosbox <--]
' Créé par : Nice-Life90
' http://www.guidosbox.com
' Copyright (C) 2010 - 2013 GUIDosbox - Montréal 
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

            'Mise à jour auto
            If .UpdateState Then
                optAutoUpdate.Checked = True
            Else
                optAutoUpdate.Checked = False
            End If

            'Closing Warning
            If .WarningState Then
                optSaveWarning.Checked = True
            Else
                optSaveWarning.Checked = False
            End If

            'Affectation des valeurs actuelle à la structure paramGeneral
            'Load les valeurs actuellement sauvegarder dans settings avant d'être modifier 
            tmpGeneral.UpdateState = .UpdateState
            tmpGeneral.WarningState = .WarningState
        End With

        ' =================================================================== '
        ' ========================== Onglet Editeur ========================= '
        ' =================================================================== '

        With My.Settings

            'Affichage de la couleur actuellement choisi.
            pbEditorColor.BackColor = .EditorBGColor

            'Affichage de la police actuellement choisi.
            fpEditorFont.Value = .EditorFont

            'HightLight Line
            If .EditorHightLightLine Then
                cbHighLightLine.Checked = True
            Else
                cbHighLightLine.Checked = False
            End If

            'Affectation des valeurs actuelle à la structure paramEditor
            'Load les valeurs actuellement sauvegarder dans settings avant d'être modifier 
            tmpEditor.EditorBgColor = .EditorBGColor
            tmpEditor.EditorFont = .EditorFont
            tmpEditor.EditorHightLightLine = .EditorHightLightLine
        End With

    End Sub
#End Region

#Region " Tab Général"

    Private Sub optAutoUpdate_CheckedChanged(sender As Object, e As EventArgs) Handles optAutoUpdate.CheckedChanged
        If optAutoUpdate.Checked Then
            tmpGeneral.UpdateState = True
        Else
            tmpGeneral.UpdateState = False
        End If
    End Sub

    Private Sub optSaveWarning_CheckedChanged(sender As Object, e As EventArgs) Handles optSaveWarning.CheckedChanged
        If optSaveWarning.Checked Then
            tmpGeneral.WarningState = True
        Else
            tmpGeneral.WarningState = False
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
        SaveGUIDosboxSetting(tmpEditor, 3)
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnGenCancel_Click(sender As Object, e As EventArgs) Handles btnGenCancel.Click
        ' Retour au cp.
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
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

    Private Sub cbHighLightLine_CheckedChanged(sender As Object, e As EventArgs) Handles cbHighLightLine.CheckedChanged
        If cbHighLightLine.Checked Then
            tmpEditor.EditorHightLightLine = True
        Else
            tmpEditor.EditorHightLightLine = False
        End If
    End Sub

    Private Sub btnEdtDefault_Click(sender As Object, e As EventArgs) Handles btnEdtDefault.Click
        'btnEdtDefault --> Reset des settings de l'éditeur.
        ResetGUIDosboxSettings(3)
        LoadGUIDosboxSettings()
    End Sub

    Private Sub btnEdtApply_Click(sender As Object, e As EventArgs) Handles btnEdtApply.Click
        'btnEdtApply --> Enregistrement et retour au cp
        SaveGUIDosboxSetting(tmpGeneral, 1)
        SaveGUIDosboxSetting(tmpEditor, 3)
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnEdtCancel_Click(sender As Object, e As EventArgs) Handles btnEdtCancel.Click
        ' Retour au cp.
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
#End Region
End Class