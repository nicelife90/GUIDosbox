' [--> GUIDosbox <--]
' Créé par : Nice-Life90
' http://www.guidosbox.com
' Copyright (C) 2010 - 2013 GUIDosbox - Montréal 
' Tous droits réservés

' [--> Contenue du fichhier <-] 
' frmBatEdit --> Ceci est un éditeur pour le batch file

Option Strict On
Option Explicit On

Imports System.IO
Imports System.Text
Imports System.Runtime.InteropServices
Imports Fireball.CodeEditor.SyntaxFiles
Imports System.Drawing.Printing

Public Class frmBatEdit

    ''' <summary>
    ''' Variable qui indique l'état des modification dans le textbox.
    ''' </summary>
    ''' <remarks></remarks>
    Private NeedSave As Boolean = False
    Private Sub txtEditor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEditor.KeyPress
        NeedSave = True
    End Sub

#Region " Loading - Closing "

    Private Sub frmBatEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Format de l'éditeur
        CodeEditorSyntaxLoader.SetSyntax(txtEditor, SyntaxLanguage.DOSBatch)

        'Application des paramètres d'utilisateur
        With My.Settings
            PanelMain.BackColor = .EditorBGColor
            txtEditor.BackColor = .EditorBGColor
            txtEditor.FontName = .EditorFont.Name
            txtEditor.FontSize = .EditorFont.SizeInPoints
            txtEditor.HighLightActiveLine = .EditorHightLightLine
            txtEditor.HighLightedLineColor = .EditorLineColor
        End With

        'Loading du Flash Header
        LoadHeader(flashHeader, "bateditor")

        'Affichage du batch file
        Try
            If File.Exists(TempBatch) Then
                txtEditor.Document.Text = File.ReadAllText(TempBatch, Encoding.UTF8)
            End If
        Catch ex As Exception
            MsgBox("Impossible de charger le Batch File." & vbNewLine & vbNewLine & ex.Message, _
                   MsgBoxStyle.Exclamation, "GUIDosbox - Erreur de chargement")
        End Try

        'Mise en page par défaut
        Dim PageSetup As New PageSettings
        With PageSetup
            .Margins.Left = 50
            .Margins.Right = 50
            .Margins.Top = 50
            .Margins.Bottom = 50
            .Landscape = False
        End With
        PrintDoc.DefaultPageSettings = PageSetup


    End Sub

    Private Sub frmBatEdit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Message si fichier modifier et enregistrement
        If NeedSave = True Then
            If MsgBox("Le fichier à été modifié!" & vbCrLf & vbCrLf _
                      & "Voulez-vous le sauvegarder avant de fermer l'éditeur?", _
                      MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                'Enregistrement des modifications.
                Try
                    File.WriteAllText(TempBatch, txtEditor.Document.Text, Encoding.UTF8)
                Catch ex As Exception
                    MsgBox("Une erreur c'est produite lors de l'enregistrement", _
                           MsgBoxStyle.Exclamation, "GUI Dosbox - Erreur d'enregistrement")
                Finally
                    NeedSave = False
                End Try
                CP.Show()
            Else
                CP.Show()
            End If
        Else
            CP.Show()
        End If
    End Sub

#End Region

#Region " Barre de menu "
    Private Sub OuvrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirToolStripMenuItem.Click
        batchFileOpen()
    End Sub

    Private Sub EnregistrerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerToolStripMenuItem.Click
        'Enregistrement des modifications.
        Try
            File.WriteAllText(TempBatch, txtEditor.Document.Text, Encoding.UTF8)
        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors de l'enregistrement", _
                   MsgBoxStyle.Exclamation, "GUI Dosbox - Erreur d'enregistrement")
        Finally
            NeedSave = False
        End Try
    End Sub

    Private Sub EnregistrerSousToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerSousToolStripMenuItem.Click
        'Affichage de la boite d'enregistrement
        batchFileSave()
    End Sub

    Private Sub MiseEnPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MiseEnPageToolStripMenuItem.Click
        'Mise en page
        PageSetupDialog.Document = PrintDoc
        PageSetupDialog.ShowDialog()
    End Sub

    Private Sub AperçuAvantImpressionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AperçuAvantImpressionToolStripMenuItem.Click
        'Aperçu avant impression
        PrintPreviewDialog.Document = PrintDoc
        If (PrintPreviewDialog.ShowDialog = Windows.Forms.DialogResult.OK) Then
            PrintDoc.Print()
        End If
    End Sub

    Private Sub ImprimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimerToolStripMenuItem.Click
        'Impression
        PrintDialog.PrinterSettings = PrintDoc.PrinterSettings
        If PrintDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PrintDoc.PrinterSettings = PrintDialog.PrinterSettings
            PrintDoc.Print()
        End If
    End Sub

    Private Sub QuiterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuiterToolStripMenuItem.Click
        'Quiter
        Me.Close()
    End Sub

    Private Sub CouperToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CouperToolStripMenuItem1.Click
        'Couper
        txtEditor.Cut()
    End Sub

    Private Sub CopierToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CopierToolStripMenuItem1.Click
        'Copier
        txtEditor.Copy()
    End Sub

    Private Sub CollerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CollerToolStripMenuItem1.Click
        'Coller
        txtEditor.Paste()
    End Sub

    Private Sub CompillerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompillerToolStripMenuItem.Click
        'Enregistrement des modifications et affichage du compilateur.
        Try
            File.WriteAllText(TempBatch, txtEditor.Document.Text, Encoding.UTF8)
            NeedSave = False
        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors de l'enregistrement", _
                   MsgBoxStyle.Exclamation, "GUI Dosbox - Erreur d'enregistrement")
        End Try
        BuildFromTempBatch = True
        frmBatToExe.Show()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        'Options
        If frmApplicationSettings.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Application des paramètres d'utilisateur
            With My.Settings
                PanelMain.BackColor = .EditorBGColor
                txtEditor.BackColor = .EditorBGColor
                txtEditor.FontName = .EditorFont.Name
                txtEditor.FontSize = .EditorFont.SizeInPoints
                txtEditor.HighLightActiveLine = .EditorHightLightLine
                txtEditor.HighLightedLineColor = .EditorLineColor
            End With
        End If
    End Sub
#End Region

#Region " Right-Click Context Menu "
    Private Sub EnregistrerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EnregistrerToolStripMenuItem1.Click
        'Enregistrement des modifications.
        Try
            File.WriteAllText(TempBatch, txtEditor.Document.Text, Encoding.UTF8)
        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors de l'enregistrement", _
                   MsgBoxStyle.Exclamation, "GUI Dosbox - Erreur d'enregistrement")
        Finally
            NeedSave = False
        End Try
    End Sub

    Private Sub EnregistrerSousToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EnregistrerSousToolStripMenuItem1.Click
        'Affichage de la boite d'enregistrement
        batchFileSave()
    End Sub

    Private Sub MiseEnPageToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MiseEnPageToolStripMenuItem1.Click
        'Mise en page
        PageSetupDialog.Document = PrintDoc
        PageSetupDialog.ShowDialog()
    End Sub

    Private Sub AperçuDimpressionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AperçuDimpressionToolStripMenuItem.Click
        'Arperçu avant impression
        PrintPreviewDialog.Document = PrintDoc
        If (PrintPreviewDialog.ShowDialog = DialogResult.OK) Then
            PrintDoc.Print()
        End If
    End Sub

    Private Sub ImprimerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ImprimerToolStripMenuItem1.Click
        'Impression
        PrintDialog.PrinterSettings = PrintDoc.PrinterSettings
        If PrintDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PrintDoc.PrinterSettings = PrintDialog.PrinterSettings
            PrintDoc.Print()
        End If
    End Sub

    Private Sub CompillerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CompillerToolStripMenuItem1.Click
        'Enregistrement des modifications et affichage du compilateur.
        Try
            File.WriteAllText(TempBatch, txtEditor.Document.Text, Encoding.UTF8)
            NeedSave = False
        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors de l'enregistrement", _
                   MsgBoxStyle.Exclamation, "GUI Dosbox - Erreur d'enregistrement")
        End Try
        BuildFromTempBatch = True
        frmBatToExe.Show()
    End Sub

    Private Sub CollerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CollerToolStripMenuItem.Click
        'Coller
        txtEditor.Paste()
    End Sub

    Private Sub CouperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CouperToolStripMenuItem.Click
        'Couper
        txtEditor.Cut()
    End Sub

    Private Sub CopierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopierToolStripMenuItem.Click
        'Copier
        txtEditor.Copy()
    End Sub

    Private Sub QuiterToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles QuiterToolStripMenuItem1.Click
        'Retour au cp
        Me.Close()
    End Sub
#End Region

#Region " Function d'impression "
    Dim lstLinesToPrint As New List(Of String)

    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDoc.BeginPrint
        Dim cFont As Font = New Font(txtEditor.FontName, txtEditor.FontSize)
        Dim fntText As Font = cFont
        Dim txtWidth As Integer = PrintDoc.DefaultPageSettings.PaperSize.Width - PrintDoc.DefaultPageSettings.Margins.Left - PrintDoc.DefaultPageSettings.Margins.Right
        Dim stringSize As New SizeF

        Dim g = Me.CreateGraphics

        lstLinesToPrint.Clear()


        For intCounter = 0 To txtEditor.Document.Lines.Count - 1
            stringSize = g.MeasureString(txtEditor.Document.Lines(intCounter), fntText)
            If stringSize.Width < txtWidth Then
                '-- The line fits so just go ahead and add it to the list of things to print.
                lstLinesToPrint.Add(txtEditor.Document.Lines(intCounter))
            Else
                '-- Otherwise the line is too long so we need to break it up, and rebuild it to fit.
                Dim LeftMargin As Integer = PrintDoc.DefaultPageSettings.Margins.Left
                Dim TopMargin As Integer = PrintDoc.DefaultPageSettings.Margins.Top
                Dim sfBuffer As SizeF = g.MeasureString("M", fntText)
                Dim layOutRec As New RectangleF(LeftMargin, TopMargin, txtWidth - sfBuffer.Width, fntText.Height)
                Dim string_format As New StringFormat
                string_format.Trimming = StringTrimming.Word
                Dim CharactersFitted As Integer = 0
                Dim LinesFilled As Integer = 0 '-- Not using this for example but need to pass it into the method.

                For intFittedChar = 0 To txtEditor.Document.Lines(intCounter).Length - 1
                    '-- See how many characters will fit on one line in the page margins
                    g.MeasureString(txtEditor.Document.Lines(intCounter).Substring(intFittedChar), fntText, New SizeF(layOutRec.Width, layOutRec.Height) _
                                    , string_format, CharactersFitted, LinesFilled)

                    lstLinesToPrint.Add(txtEditor.Document.Lines(intCounter).Substring(intFittedChar, CharactersFitted))

                    intFittedChar += CharactersFitted - 1
                Next
            End If
        Next
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDoc.PrintPage
        Static intStart As Integer
        Dim cFont As Font = New Font(txtEditor.FontName, txtEditor.FontSize)
        Dim fntText As Font = cFont
        Dim txtHeight As Integer
        Dim LeftMargin As Integer = PrintDoc.DefaultPageSettings.Margins.Left
        Dim TopMargin As Integer = PrintDoc.DefaultPageSettings.Margins.Top
        txtHeight = PrintDoc.DefaultPageSettings.PaperSize.Height - PrintDoc.DefaultPageSettings.Margins.Top - PrintDoc.DefaultPageSettings.Margins.Bottom
        Dim LinesPerPage As Integer = CInt(Math.Round(txtHeight / (fntText.Height + 0.025)))
        'e.Graphics.DrawRectangle(Pens.Red, e.MarginBounds)
        Dim intLineNumber As Integer
        For intCounter = intStart To lstLinesToPrint.Count - 1
            e.Graphics.DrawString(lstLinesToPrint(intCounter), fntText, Brushes.Black, LeftMargin, fntText.Height * intLineNumber + TopMargin)
            intLineNumber += 1
            If intLineNumber > LinesPerPage - 1 Then
                intStart = intCounter
                e.HasMorePages = True '-- This is recursive. It will call the Print Page Sub again when it's set to true.
                Exit For
            End If
        Next
    End Sub
#End Region

    ''' <summary>
    ''' Affichage de la boite d'enregistrement et enregistrement du fichier.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub batchFileOpen()
        'Création du Browser
        Dim opFD As New OpenFileDialog
        opFD.AddExtension = True
        opFD.DefaultExt = ".bat"
        opFD.FileName = "GUIDosboxHistory"
        opFD.Filter = "Fichiers de commandes (*.bat)|*.bat|Tous les fichiers (*.*)|*.*"
        opFD.FilterIndex = 0
        opFD.Title = "Ouvrir un fichier .bat"

        Try
            If opFD.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'Lecture du contenue
                If File.Exists(opFD.FileName) Then
                    txtEditor.Document.Text = Nothing
                    txtEditor.Document.Text = File.ReadAllText(opFD.FileName, Encoding.UTF8)
                End If
            End If
        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors de l'enregistrement", _
                  MsgBoxStyle.Exclamation, "GUI Dosbox - Erreur d'enregistrement")
        Finally
            NeedSave = False
        End Try
    End Sub

    ''' <summary>
    ''' Affichage de la boite d'enregistrement et enregistrement du fichier.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub batchFileSave()
        Dim opFD As New SaveFileDialog
        opFD.AddExtension = True
        opFD.DefaultExt = ".bat"
        opFD.FileName = "GUIDosboxHistory"
        opFD.Filter = "Fichiers de commandes (*.bat)|*.bat|Tous les fichiers (*.*)|*.*"
        opFD.FilterIndex = 0
        opFD.OverwritePrompt = True
        opFD.Title = "Enregistrer Sous..."
        'sauvegarde du fichier
        Try
            If opFD.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'Supression de l'anciene version du fichier si existe
                If File.Exists(opFD.FileName) Then
                    File.Delete(opFD.FileName)
                End If
                'Création du nouveau fichier.
                File.WriteAllText(opFD.FileName, txtEditor.Document.Text, Encoding.UTF8)
            End If
        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors de l'enregistrement", _
                  MsgBoxStyle.Exclamation, "GUI Dosbox - Erreur d'enregistrement")
        Finally
            NeedSave = False
        End Try
    End Sub
End Class