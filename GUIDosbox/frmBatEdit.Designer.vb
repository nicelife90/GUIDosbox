<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBatEdit
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBatEdit))
        Dim LineMarginRender1 As Fireball.Windows.Forms.LineMarginRender = New Fireball.Windows.Forms.LineMarginRender()
        Me.flashHeader = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.EnregistrerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnregistrerSousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.MiseEnPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AperçuAvantImpressionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuiterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CouperToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopierToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CollerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutilsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompillerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RightClickMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EnregistrerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnregistrerSousToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MiseEnPageToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AperçuDimpressionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.CopierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CouperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CollerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CompillerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuiterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.txtEditor = New Fireball.Windows.Forms.CodeEditorControl()
        Me.SyntaxDocument = New Fireball.Syntax.SyntaxDocument(Me.components)
        Me.PageSetupDialog = New System.Windows.Forms.PageSetupDialog()
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.RightClickMenu.SuspendLayout()
        Me.PanelMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'flashHeader
        '
        Me.flashHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.flashHeader.Enabled = True
        Me.flashHeader.Location = New System.Drawing.Point(0, 0)
        Me.flashHeader.Name = "flashHeader"
        Me.flashHeader.OcxState = CType(resources.GetObject("flashHeader.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flashHeader.Size = New System.Drawing.Size(921, 50)
        Me.flashHeader.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.WindowText
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.EditionToolStripMenuItem, Me.OutilsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 53)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip1.Size = New System.Drawing.Size(926, 28)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowText
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OuvrirToolStripMenuItem, Me.ToolStripSeparator7, Me.EnregistrerToolStripMenuItem, Me.EnregistrerSousToolStripMenuItem, Me.ToolStripSeparator4, Me.MiseEnPageToolStripMenuItem, Me.AperçuAvantImpressionToolStripMenuItem, Me.ImprimerToolStripMenuItem, Me.ToolStripSeparator5, Me.QuiterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FichierToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(56, 24)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'OuvrirToolStripMenuItem
        '
        Me.OuvrirToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.OuvrirToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.OuvrirToolStripMenuItem.Image = Global.GUIDosbox.My.Resources.Resources.folder_open_icon_16
        Me.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        Me.OuvrirToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.OuvrirToolStripMenuItem.Text = "Ouvrir"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(208, 6)
        '
        'EnregistrerToolStripMenuItem
        '
        Me.EnregistrerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.EnregistrerToolStripMenuItem.Image = Global.GUIDosbox.My.Resources.Resources.save_icon_16
        Me.EnregistrerToolStripMenuItem.Name = "EnregistrerToolStripMenuItem"
        Me.EnregistrerToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.EnregistrerToolStripMenuItem.Text = "Enregistrer"
        '
        'EnregistrerSousToolStripMenuItem
        '
        Me.EnregistrerSousToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.EnregistrerSousToolStripMenuItem.Name = "EnregistrerSousToolStripMenuItem"
        Me.EnregistrerSousToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.EnregistrerSousToolStripMenuItem.Text = "Enregistrer sous..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(208, 6)
        '
        'MiseEnPageToolStripMenuItem
        '
        Me.MiseEnPageToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.MiseEnPageToolStripMenuItem.Image = Global.GUIDosbox.My.Resources.Resources.doc_lines_stright_icon_16
        Me.MiseEnPageToolStripMenuItem.Name = "MiseEnPageToolStripMenuItem"
        Me.MiseEnPageToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.MiseEnPageToolStripMenuItem.Text = "Mise en page"
        '
        'AperçuAvantImpressionToolStripMenuItem
        '
        Me.AperçuAvantImpressionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.AperçuAvantImpressionToolStripMenuItem.Image = Global.GUIDosbox.My.Resources.Resources.eye_icon_16
        Me.AperçuAvantImpressionToolStripMenuItem.Name = "AperçuAvantImpressionToolStripMenuItem"
        Me.AperçuAvantImpressionToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.AperçuAvantImpressionToolStripMenuItem.Text = "Aperçu avant impression"
        '
        'ImprimerToolStripMenuItem
        '
        Me.ImprimerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ImprimerToolStripMenuItem.Image = Global.GUIDosbox.My.Resources.Resources.print_icon_16
        Me.ImprimerToolStripMenuItem.Name = "ImprimerToolStripMenuItem"
        Me.ImprimerToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.ImprimerToolStripMenuItem.Text = "Imprimer"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(208, 6)
        '
        'QuiterToolStripMenuItem
        '
        Me.QuiterToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowText
        Me.QuiterToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.QuiterToolStripMenuItem.Image = Global.GUIDosbox.My.Resources.Resources.delete_icon_16
        Me.QuiterToolStripMenuItem.Name = "QuiterToolStripMenuItem"
        Me.QuiterToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.QuiterToolStripMenuItem.Text = "Quitter"
        '
        'EditionToolStripMenuItem
        '
        Me.EditionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CouperToolStripMenuItem1, Me.CopierToolStripMenuItem1, Me.CollerToolStripMenuItem1})
        Me.EditionToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditionToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue
        Me.EditionToolStripMenuItem.Name = "EditionToolStripMenuItem"
        Me.EditionToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.EditionToolStripMenuItem.Text = "Edition"
        '
        'CouperToolStripMenuItem1
        '
        Me.CouperToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CouperToolStripMenuItem1.Image = Global.GUIDosbox.My.Resources.Resources.clipboard_cut_icon_16
        Me.CouperToolStripMenuItem1.Name = "CouperToolStripMenuItem1"
        Me.CouperToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.CouperToolStripMenuItem1.Text = "Couper"
        '
        'CopierToolStripMenuItem1
        '
        Me.CopierToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CopierToolStripMenuItem1.Image = Global.GUIDosbox.My.Resources.Resources.clipboard_copy_icon_16
        Me.CopierToolStripMenuItem1.Name = "CopierToolStripMenuItem1"
        Me.CopierToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.CopierToolStripMenuItem1.Text = "Copier"
        '
        'CollerToolStripMenuItem1
        '
        Me.CollerToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CollerToolStripMenuItem1.Image = Global.GUIDosbox.My.Resources.Resources.clipboard_past_icon_16
        Me.CollerToolStripMenuItem1.Name = "CollerToolStripMenuItem1"
        Me.CollerToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.CollerToolStripMenuItem1.Text = "Coller"
        '
        'OutilsToolStripMenuItem
        '
        Me.OutilsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompillerToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.OutilsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutilsToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue
        Me.OutilsToolStripMenuItem.Name = "OutilsToolStripMenuItem"
        Me.OutilsToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.OutilsToolStripMenuItem.Text = "Outils"
        '
        'CompillerToolStripMenuItem
        '
        Me.CompillerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CompillerToolStripMenuItem.Image = Global.GUIDosbox.My.Resources.Resources.cog_icon_16
        Me.CompillerToolStripMenuItem.Name = "CompillerToolStripMenuItem"
        Me.CompillerToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.CompillerToolStripMenuItem.Text = ".bat To .exe"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.OptionsToolStripMenuItem.Image = Global.GUIDosbox.My.Resources.Resources.wrench_icon_16
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'RightClickMenu
        '
        Me.RightClickMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnregistrerToolStripMenuItem1, Me.EnregistrerSousToolStripMenuItem1, Me.ToolStripSeparator2, Me.MiseEnPageToolStripMenuItem1, Me.AperçuDimpressionToolStripMenuItem, Me.ImprimerToolStripMenuItem1, Me.ToolStripSeparator6, Me.CopierToolStripMenuItem, Me.CouperToolStripMenuItem, Me.CollerToolStripMenuItem, Me.ToolStripSeparator1, Me.CompillerToolStripMenuItem1, Me.ToolStripSeparator3, Me.QuiterToolStripMenuItem1})
        Me.RightClickMenu.Name = "RightClickMenu"
        Me.RightClickMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.RightClickMenu.Size = New System.Drawing.Size(208, 248)
        '
        'EnregistrerToolStripMenuItem1
        '
        Me.EnregistrerToolStripMenuItem1.Font = New System.Drawing.Font("Consolas", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnregistrerToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.EnregistrerToolStripMenuItem1.Image = Global.GUIDosbox.My.Resources.Resources.save_icon_16
        Me.EnregistrerToolStripMenuItem1.Name = "EnregistrerToolStripMenuItem1"
        Me.EnregistrerToolStripMenuItem1.Size = New System.Drawing.Size(207, 22)
        Me.EnregistrerToolStripMenuItem1.Text = "Enregistrer"
        '
        'EnregistrerSousToolStripMenuItem1
        '
        Me.EnregistrerSousToolStripMenuItem1.Font = New System.Drawing.Font("Consolas", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnregistrerSousToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.EnregistrerSousToolStripMenuItem1.Name = "EnregistrerSousToolStripMenuItem1"
        Me.EnregistrerSousToolStripMenuItem1.Size = New System.Drawing.Size(207, 22)
        Me.EnregistrerSousToolStripMenuItem1.Text = "Enregistrer Sous..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(204, 6)
        '
        'MiseEnPageToolStripMenuItem1
        '
        Me.MiseEnPageToolStripMenuItem1.Font = New System.Drawing.Font("Consolas", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiseEnPageToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.MiseEnPageToolStripMenuItem1.Image = Global.GUIDosbox.My.Resources.Resources.doc_lines_stright_icon_16
        Me.MiseEnPageToolStripMenuItem1.Name = "MiseEnPageToolStripMenuItem1"
        Me.MiseEnPageToolStripMenuItem1.Size = New System.Drawing.Size(207, 22)
        Me.MiseEnPageToolStripMenuItem1.Text = "Mise en page"
        '
        'AperçuDimpressionToolStripMenuItem
        '
        Me.AperçuDimpressionToolStripMenuItem.Font = New System.Drawing.Font("Consolas", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AperçuDimpressionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.AperçuDimpressionToolStripMenuItem.Image = Global.GUIDosbox.My.Resources.Resources.eye_icon_16
        Me.AperçuDimpressionToolStripMenuItem.Name = "AperçuDimpressionToolStripMenuItem"
        Me.AperçuDimpressionToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.AperçuDimpressionToolStripMenuItem.Text = "Aperçu d'impression"
        '
        'ImprimerToolStripMenuItem1
        '
        Me.ImprimerToolStripMenuItem1.Font = New System.Drawing.Font("Consolas", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImprimerToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ImprimerToolStripMenuItem1.Image = Global.GUIDosbox.My.Resources.Resources.print_icon_16
        Me.ImprimerToolStripMenuItem1.Name = "ImprimerToolStripMenuItem1"
        Me.ImprimerToolStripMenuItem1.Size = New System.Drawing.Size(207, 22)
        Me.ImprimerToolStripMenuItem1.Text = "Imprimer"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(204, 6)
        '
        'CopierToolStripMenuItem
        '
        Me.CopierToolStripMenuItem.Font = New System.Drawing.Font("Consolas", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopierToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CopierToolStripMenuItem.Image = Global.GUIDosbox.My.Resources.Resources.clipboard_copy_icon_16
        Me.CopierToolStripMenuItem.Name = "CopierToolStripMenuItem"
        Me.CopierToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.CopierToolStripMenuItem.Text = "Copier"
        '
        'CouperToolStripMenuItem
        '
        Me.CouperToolStripMenuItem.Font = New System.Drawing.Font("Consolas", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CouperToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CouperToolStripMenuItem.Image = Global.GUIDosbox.My.Resources.Resources.clipboard_cut_icon_16
        Me.CouperToolStripMenuItem.Name = "CouperToolStripMenuItem"
        Me.CouperToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.CouperToolStripMenuItem.Text = "Couper"
        '
        'CollerToolStripMenuItem
        '
        Me.CollerToolStripMenuItem.Font = New System.Drawing.Font("Consolas", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CollerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CollerToolStripMenuItem.Image = Global.GUIDosbox.My.Resources.Resources.clipboard_past_icon_16
        Me.CollerToolStripMenuItem.Name = "CollerToolStripMenuItem"
        Me.CollerToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.CollerToolStripMenuItem.Text = "Coller"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(204, 6)
        '
        'CompillerToolStripMenuItem1
        '
        Me.CompillerToolStripMenuItem1.Font = New System.Drawing.Font("Consolas", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompillerToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CompillerToolStripMenuItem1.Image = Global.GUIDosbox.My.Resources.Resources.cog_icon_16
        Me.CompillerToolStripMenuItem1.Name = "CompillerToolStripMenuItem1"
        Me.CompillerToolStripMenuItem1.Size = New System.Drawing.Size(207, 22)
        Me.CompillerToolStripMenuItem1.Text = "Compiller"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(204, 6)
        '
        'QuiterToolStripMenuItem1
        '
        Me.QuiterToolStripMenuItem1.Font = New System.Drawing.Font("Consolas", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuiterToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.QuiterToolStripMenuItem1.Image = Global.GUIDosbox.My.Resources.Resources.delete_icon_16
        Me.QuiterToolStripMenuItem1.Name = "QuiterToolStripMenuItem1"
        Me.QuiterToolStripMenuItem1.Size = New System.Drawing.Size(207, 22)
        Me.QuiterToolStripMenuItem1.Text = "Quiter"
        '
        'PrintDoc
        '
        '
        'PrintDialog
        '
        Me.PrintDialog.UseEXDialog = True
        '
        'PrintPreviewDialog
        '
        Me.PrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog.Enabled = True
        Me.PrintPreviewDialog.Icon = CType(resources.GetObject("PrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog.ShowIcon = False
        Me.PrintPreviewDialog.Visible = False
        '
        'PanelMain
        '
        Me.PanelMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelMain.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelMain.Controls.Add(Me.txtEditor)
        Me.PanelMain.Location = New System.Drawing.Point(0, 82)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Padding = New System.Windows.Forms.Padding(8)
        Me.PanelMain.Size = New System.Drawing.Size(921, 619)
        Me.PanelMain.TabIndex = 6
        '
        'txtEditor
        '
        Me.txtEditor.ActiveView = Fireball.Windows.Forms.CodeEditor.ActiveView.BottomRight
        Me.txtEditor.AutoListPosition = Nothing
        Me.txtEditor.AutoListSelectedText = "a123"
        Me.txtEditor.AutoListVisible = False
        Me.txtEditor.CopyAsRTF = False
        Me.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEditor.Document = Me.SyntaxDocument
        Me.txtEditor.HighLightActiveLine = True
        Me.txtEditor.HighLightedLineColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtEditor.InfoTipCount = 1
        Me.txtEditor.InfoTipPosition = Nothing
        Me.txtEditor.InfoTipSelectedIndex = 1
        Me.txtEditor.InfoTipVisible = False
        LineMarginRender1.Bounds = New System.Drawing.Rectangle(0, 0, 19, 16)
        Me.txtEditor.LineMarginRender = LineMarginRender1
        Me.txtEditor.Location = New System.Drawing.Point(8, 8)
        Me.txtEditor.LockCursorUpdate = False
        Me.txtEditor.Name = "txtEditor"
        Me.txtEditor.Saved = False
        Me.txtEditor.ShowGutterMargin = False
        Me.txtEditor.ShowScopeIndicator = False
        Me.txtEditor.Size = New System.Drawing.Size(905, 603)
        Me.txtEditor.SmoothScroll = False
        Me.txtEditor.SplitView = False
        Me.txtEditor.SplitviewH = -4
        Me.txtEditor.SplitviewV = -4
        Me.txtEditor.TabGuideColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtEditor.TabIndex = 1
        Me.txtEditor.WhitespaceColor = System.Drawing.SystemColors.ControlDark
        '
        'SyntaxDocument
        '
        Me.SyntaxDocument.Lines = New String() {""}
        Me.SyntaxDocument.MaxUndoBufferSize = 1000
        Me.SyntaxDocument.Modified = False
        Me.SyntaxDocument.UndoStep = 0
        '
        'PageSetupDialog
        '
        Me.PageSetupDialog.Document = Me.PrintDoc
        Me.PageSetupDialog.EnableMetric = True
        '
        'frmBatEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(921, 701)
        Me.ContextMenuStrip = Me.RightClickMenu
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.flashHeader)
        Me.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.ForeColor = System.Drawing.Color.LightBlue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBatEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GUI Dosbox - Batch File Editor"
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.RightClickMenu.ResumeLayout(False)
        Me.PanelMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents flashHeader As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuiterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnregistrerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnregistrerSousToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AperçuAvantImpressionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RightClickMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EnregistrerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnregistrerSousToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CopierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CouperToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CollerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents QuiterToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDoc As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents ImprimerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AperçuDimpressionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MiseEnPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanelMain As System.Windows.Forms.Panel
    Friend WithEvents MiseEnPageToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CouperToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopierToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CollerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutilsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompillerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OuvrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtEditor As Fireball.Windows.Forms.CodeEditorControl
    Friend WithEvents SyntaxDocument As Fireball.Syntax.SyntaxDocument
    Friend WithEvents PageSetupDialog As System.Windows.Forms.PageSetupDialog
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CompillerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
