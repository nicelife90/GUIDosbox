' [--> GUIDosbox <--]
' Créé par : Nice-Life90
' http://www.kobixxe.com
' Copyright (C) 2010 - 2013 Kobixxe - Montréal 
' Tous droits réservés

' [--> Contenue du fichhier <-] 
' frmBatEdit --> Ceci est un éditeur pour le batch file

Option Strict On
Option Explicit On

Imports System.IO
Imports System.Runtime.InteropServices

Public Class frmBatEdit

#Region " Load "
    Private Sub frmBatEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Lancement du formulaire de loading
        BackgroundWorker1.RunWorkerAsync()

        'Loading du Flash Header
        LoadHeader(flashHeader, "bateditor")

        'Affichage du batch file
        Try
            If File.Exists(TempBatch) Then
                txtEditor.Text = My.Computer.FileSystem.ReadAllText(TempBatch)
            End If
        Catch ex As Exception
            MsgBox("Impossible de charger le Batch File." & vbNewLine & vbNewLine & ex.Message, _
                   MsgBoxStyle.Exclamation, "GUIDosbox - Erreur de chargement")
        End Try

        'Coloration Syntaxique --> GUIDosboxColorationSyntaxique.
        ColorationSyntaxique(txtEditor)
    End Sub

    Private Sub frmBatEdit_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Variable pour le loader --> frmBatLoader
        loaded = True
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'Démarrage du loader 
        Dim frm As Windows.Forms.Form = New frmBatEditLoader
        loaded = False
        frm.ShowDialog()
    End Sub
#End Region

#Region " Barre de menu "
    Private Sub EnregistrerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerToolStripMenuItem.Click
        'Enregistrement des modifications.
        Try
            My.Computer.FileSystem.WriteAllText(TempBatch, txtEditor.Text, False)
        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors de l'enregistrement", _
                   MsgBoxStyle.Exclamation, "GUI Dosbox - Erreur d'enregistrement")
        End Try
    End Sub

    Private Sub EnregistrerSousToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerSousToolStripMenuItem.Click
        'Affichage de la boite d'enregistrement
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
                My.Computer.FileSystem.WriteAllText(opFD.FileName, txtEditor.Text, False)
            End If
        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors de l'enregistrement", _
                  MsgBoxStyle.Exclamation, "GUI Dosbox - Erreur d'enregistrement")
        End Try
    End Sub

    Private Sub MiseEnPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MiseEnPageToolStripMenuItem.Click
        'Mise en page
        PageSetupDialog1.Document = PrintDocument1
        PageSetupDialog1.ShowDialog()
    End Sub

    Private Sub AperçuAvantImpressionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AperçuAvantImpressionToolStripMenuItem.Click
        'Aperçu avant impression
        PrintPreviewDialog1.Document = PrintDocument1
        If (PrintPreviewDialog1.ShowDialog = DialogResult.OK) Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub ImprimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimerToolStripMenuItem.Click
        'Impression
        PrintDocument1.Print()
    End Sub

    Private Sub QuiterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuiterToolStripMenuItem.Click
        CP.Show()
        Me.Close()
    End Sub
#End Region

#Region " Right-Click Context Menu "

    Private Sub EnregistrerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EnregistrerToolStripMenuItem1.Click
        'Enregistrement des modifications.
        Try
            My.Computer.FileSystem.WriteAllText(TempBatch, txtEditor.Text, False)
        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors de l'enregistrement", _
                   MsgBoxStyle.Exclamation, "GUI Dosbox - Erreur d'enregistrement")
        End Try
    End Sub

    Private Sub EnregistrerSousToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EnregistrerSousToolStripMenuItem1.Click
        'Affichage de la boite d'enregistrement
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
                My.Computer.FileSystem.WriteAllText(opFD.FileName, txtEditor.Text, False)
            End If
        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors de l'enregistrement", _
                  MsgBoxStyle.Exclamation, "GUI Dosbox - Erreur d'enregistrement")
        End Try
    End Sub

    Private Sub MiseEnPageToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MiseEnPageToolStripMenuItem1.Click
        'Mise en page
        PageSetupDialog1.Document = PrintDocument1
        PageSetupDialog1.ShowDialog()
    End Sub

    Private Sub AperçuDimpressionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AperçuDimpressionToolStripMenuItem.Click
        'Arperçu avant impression
        PrintPreviewDialog1.Document = PrintDocument1
        If (PrintPreviewDialog1.ShowDialog = DialogResult.OK) Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub ImprimerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ImprimerToolStripMenuItem1.Click
        'impression
        PrintDocument1.Print()
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
        CP.Show()
        Me.Close()
    End Sub
#End Region

    Private Sub frmBatEdit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Retour au cp
        CP.Show()
    End Sub

#Region " Options d'impression ajouté "

    'Initialisation des options d'impression ajouté --> GUIDosbox_RichTextBox
    'Ce code à `été créé par Microsoft.

    Private m_nFirstCharOnPage As Integer

    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        ' Start at the beginning of the text
        m_nFirstCharOnPage = 0
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' To print the boundaries of the current page margins
        ' uncomment the next line:
        'e.Graphics.DrawRectangle(System.Drawing.Pens.Blue, e.MarginBounds)


        ' make the RichTextBoxEx calculate and render as much text as will
        ' fit on the page and remember the last character printed for the
        ' beginning of the next page
        m_nFirstCharOnPage = txtEditor.FormatRange(False, _
                                                e, _
                                                m_nFirstCharOnPage, _
                                                txtEditor.TextLength)

        ' check if there are more pages to print
        If (m_nFirstCharOnPage < txtEditor.TextLength) Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If
    End Sub

    Private Sub PrintDocument1_EndPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.EndPrint
        ' Clean up cached information
        txtEditor.FormatRangeDone()
    End Sub

#End Region

   
End Class