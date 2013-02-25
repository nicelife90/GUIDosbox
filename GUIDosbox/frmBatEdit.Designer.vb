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
        Me.flashHeader = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.RightClickMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
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
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuiterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtEditor = New GUIDosbox.GUIDosbox_RichTextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GuiDosbox_LineNumber1 = New GUIDosbox.GUIDosbox_LineNumber()
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.RightClickMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnregistrerToolStripMenuItem, Me.EnregistrerSousToolStripMenuItem, Me.ToolStripSeparator4, Me.MiseEnPageToolStripMenuItem, Me.AperçuAvantImpressionToolStripMenuItem, Me.ImprimerToolStripMenuItem, Me.ToolStripSeparator5, Me.QuiterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FichierToolStripMenuItem.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(56, 24)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'EnregistrerToolStripMenuItem
        '
        Me.EnregistrerToolStripMenuItem.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.EnregistrerToolStripMenuItem.Name = "EnregistrerToolStripMenuItem"
        Me.EnregistrerToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.EnregistrerToolStripMenuItem.Text = "Enregistrer"
        '
        'EnregistrerSousToolStripMenuItem
        '
        Me.EnregistrerSousToolStripMenuItem.ForeColor = System.Drawing.Color.LightSkyBlue
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
        Me.MiseEnPageToolStripMenuItem.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.MiseEnPageToolStripMenuItem.Name = "MiseEnPageToolStripMenuItem"
        Me.MiseEnPageToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.MiseEnPageToolStripMenuItem.Text = "Mise en page"
        '
        'AperçuAvantImpressionToolStripMenuItem
        '
        Me.AperçuAvantImpressionToolStripMenuItem.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.AperçuAvantImpressionToolStripMenuItem.Name = "AperçuAvantImpressionToolStripMenuItem"
        Me.AperçuAvantImpressionToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.AperçuAvantImpressionToolStripMenuItem.Text = "Aperçu avant impression"
        '
        'ImprimerToolStripMenuItem
        '
        Me.ImprimerToolStripMenuItem.ForeColor = System.Drawing.Color.LightSkyBlue
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
        Me.QuiterToolStripMenuItem.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.QuiterToolStripMenuItem.Name = "QuiterToolStripMenuItem"
        Me.QuiterToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.QuiterToolStripMenuItem.Text = "Quitter"
        '
        'EditionToolStripMenuItem
        '
        Me.EditionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CouperToolStripMenuItem1, Me.CopierToolStripMenuItem1, Me.CollerToolStripMenuItem1})
        Me.EditionToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditionToolStripMenuItem.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.EditionToolStripMenuItem.Name = "EditionToolStripMenuItem"
        Me.EditionToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.EditionToolStripMenuItem.Text = "Edition"
        '
        'CouperToolStripMenuItem1
        '
        Me.CouperToolStripMenuItem1.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.CouperToolStripMenuItem1.Name = "CouperToolStripMenuItem1"
        Me.CouperToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.CouperToolStripMenuItem1.Text = "Couper"
        '
        'CopierToolStripMenuItem1
        '
        Me.CopierToolStripMenuItem1.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.CopierToolStripMenuItem1.Name = "CopierToolStripMenuItem1"
        Me.CopierToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.CopierToolStripMenuItem1.Text = "Copier"
        '
        'CollerToolStripMenuItem1
        '
        Me.CollerToolStripMenuItem1.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.CollerToolStripMenuItem1.Name = "CollerToolStripMenuItem1"
        Me.CollerToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.CollerToolStripMenuItem1.Text = "Coller"
        '
        'OutilsToolStripMenuItem
        '
        Me.OutilsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompillerToolStripMenuItem})
        Me.OutilsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutilsToolStripMenuItem.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.OutilsToolStripMenuItem.Name = "OutilsToolStripMenuItem"
        Me.OutilsToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.OutilsToolStripMenuItem.Text = "Outils"
        '
        'CompillerToolStripMenuItem
        '
        Me.CompillerToolStripMenuItem.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.CompillerToolStripMenuItem.Name = "CompillerToolStripMenuItem"
        Me.CompillerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CompillerToolStripMenuItem.Text = ".bat To .exe"
        '
        'RightClickMenu
        '
        Me.RightClickMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.EnregistrerToolStripMenuItem1, Me.EnregistrerSousToolStripMenuItem1, Me.ToolStripSeparator2, Me.MiseEnPageToolStripMenuItem1, Me.AperçuDimpressionToolStripMenuItem, Me.ImprimerToolStripMenuItem1, Me.ToolStripSeparator6, Me.CopierToolStripMenuItem, Me.CouperToolStripMenuItem, Me.CollerToolStripMenuItem, Me.ToolStripSeparator3, Me.QuiterToolStripMenuItem1})
        Me.RightClickMenu.Name = "RightClickMenu"
        Me.RightClickMenu.Size = New System.Drawing.Size(184, 226)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(180, 6)
        '
        'EnregistrerToolStripMenuItem1
        '
        Me.EnregistrerToolStripMenuItem1.Name = "EnregistrerToolStripMenuItem1"
        Me.EnregistrerToolStripMenuItem1.Size = New System.Drawing.Size(183, 22)
        Me.EnregistrerToolStripMenuItem1.Text = "Enregistrer"
        '
        'EnregistrerSousToolStripMenuItem1
        '
        Me.EnregistrerSousToolStripMenuItem1.Name = "EnregistrerSousToolStripMenuItem1"
        Me.EnregistrerSousToolStripMenuItem1.Size = New System.Drawing.Size(183, 22)
        Me.EnregistrerSousToolStripMenuItem1.Text = "Enregistrer Sous..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(180, 6)
        '
        'MiseEnPageToolStripMenuItem1
        '
        Me.MiseEnPageToolStripMenuItem1.Name = "MiseEnPageToolStripMenuItem1"
        Me.MiseEnPageToolStripMenuItem1.Size = New System.Drawing.Size(183, 22)
        Me.MiseEnPageToolStripMenuItem1.Text = "Mise en page"
        '
        'AperçuDimpressionToolStripMenuItem
        '
        Me.AperçuDimpressionToolStripMenuItem.Name = "AperçuDimpressionToolStripMenuItem"
        Me.AperçuDimpressionToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.AperçuDimpressionToolStripMenuItem.Text = "Aperçu d'impression"
        '
        'ImprimerToolStripMenuItem1
        '
        Me.ImprimerToolStripMenuItem1.Name = "ImprimerToolStripMenuItem1"
        Me.ImprimerToolStripMenuItem1.Size = New System.Drawing.Size(183, 22)
        Me.ImprimerToolStripMenuItem1.Text = "Imprimer"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(180, 6)
        '
        'CopierToolStripMenuItem
        '
        Me.CopierToolStripMenuItem.Name = "CopierToolStripMenuItem"
        Me.CopierToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.CopierToolStripMenuItem.Text = "Copier"
        '
        'CouperToolStripMenuItem
        '
        Me.CouperToolStripMenuItem.Name = "CouperToolStripMenuItem"
        Me.CouperToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.CouperToolStripMenuItem.Text = "Couper"
        '
        'CollerToolStripMenuItem
        '
        Me.CollerToolStripMenuItem.Name = "CollerToolStripMenuItem"
        Me.CollerToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.CollerToolStripMenuItem.Text = "Coller"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(180, 6)
        '
        'QuiterToolStripMenuItem1
        '
        Me.QuiterToolStripMenuItem1.Name = "QuiterToolStripMenuItem1"
        Me.QuiterToolStripMenuItem1.Size = New System.Drawing.Size(183, 22)
        Me.QuiterToolStripMenuItem1.Text = "Quiter"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.txtEditor)
        Me.Panel1.Location = New System.Drawing.Point(27, 82)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel1.Size = New System.Drawing.Size(894, 619)
        Me.Panel1.TabIndex = 6
        '
        'txtEditor
        '
        Me.txtEditor.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEditor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEditor.ContextMenuStrip = Me.RightClickMenu
        Me.txtEditor.DetectUrls = False
        Me.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEditor.EnableAutoDragDrop = True
        Me.txtEditor.Font = New System.Drawing.Font("Lucida Console", 9.0!)
        Me.txtEditor.ForeColor = System.Drawing.Color.Black
        Me.txtEditor.Location = New System.Drawing.Point(8, 8)
        Me.txtEditor.Name = "txtEditor"
        Me.txtEditor.Size = New System.Drawing.Size(878, 603)
        Me.txtEditor.TabIndex = 0
        Me.txtEditor.Text = ""
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'GuiDosbox_LineNumber1
        '
        Me.GuiDosbox_LineNumber1._SeeThroughMode_ = False
        Me.GuiDosbox_LineNumber1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GuiDosbox_LineNumber1.AutoSizing = False
        Me.GuiDosbox_LineNumber1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GuiDosbox_LineNumber1.BackgroundGradient_AlphaColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GuiDosbox_LineNumber1.BackgroundGradient_BetaColor = System.Drawing.Color.LightSteelBlue
        Me.GuiDosbox_LineNumber1.BackgroundGradient_Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GuiDosbox_LineNumber1.BorderLines_Color = System.Drawing.Color.SlateGray
        Me.GuiDosbox_LineNumber1.BorderLines_Style = System.Drawing.Drawing2D.DashStyle.Dot
        Me.GuiDosbox_LineNumber1.BorderLines_Thickness = 1.0!
        Me.GuiDosbox_LineNumber1.DockSide = GUIDosbox.GUIDosbox_LineNumber.LineNumberDockSide.None
        Me.GuiDosbox_LineNumber1.ForeColor = System.Drawing.Color.Black
        Me.GuiDosbox_LineNumber1.GridLines_Color = System.Drawing.Color.SlateGray
        Me.GuiDosbox_LineNumber1.GridLines_Style = System.Drawing.Drawing2D.DashStyle.Dot
        Me.GuiDosbox_LineNumber1.GridLines_Thickness = 1.0!
        Me.GuiDosbox_LineNumber1.LineNrs_Alignment = System.Drawing.ContentAlignment.MiddleRight
        Me.GuiDosbox_LineNumber1.LineNrs_AntiAlias = True
        Me.GuiDosbox_LineNumber1.LineNrs_AsHexadecimal = False
        Me.GuiDosbox_LineNumber1.LineNrs_ClippedByItemRectangle = True
        Me.GuiDosbox_LineNumber1.LineNrs_LeadingZeroes = True
        Me.GuiDosbox_LineNumber1.LineNrs_Offset = New System.Drawing.Size(0, 0)
        Me.GuiDosbox_LineNumber1.Location = New System.Drawing.Point(0, 81)
        Me.GuiDosbox_LineNumber1.Margin = New System.Windows.Forms.Padding(0)
        Me.GuiDosbox_LineNumber1.MarginLines_Color = System.Drawing.Color.SlateGray
        Me.GuiDosbox_LineNumber1.MarginLines_Side = GUIDosbox.GUIDosbox_LineNumber.LineNumberDockSide.Right
        Me.GuiDosbox_LineNumber1.MarginLines_Style = System.Drawing.Drawing2D.DashStyle.Solid
        Me.GuiDosbox_LineNumber1.MarginLines_Thickness = 1.0!
        Me.GuiDosbox_LineNumber1.Name = "GuiDosbox_LineNumber1"
        Me.GuiDosbox_LineNumber1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.GuiDosbox_LineNumber1.ParentRichTextBox = Me.txtEditor
        Me.GuiDosbox_LineNumber1.Show_BackgroundGradient = False
        Me.GuiDosbox_LineNumber1.Show_BorderLines = False
        Me.GuiDosbox_LineNumber1.Show_GridLines = False
        Me.GuiDosbox_LineNumber1.Show_LineNrs = True
        Me.GuiDosbox_LineNumber1.Show_MarginLines = True
        Me.GuiDosbox_LineNumber1.Size = New System.Drawing.Size(30, 620)
        Me.GuiDosbox_LineNumber1.TabIndex = 6
        '
        'frmBatEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(921, 701)
        Me.ContextMenuStrip = Me.RightClickMenu
        Me.Controls.Add(Me.GuiDosbox_LineNumber1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
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
        Me.Panel1.ResumeLayout(False)
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
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
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
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents ImprimerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AperçuDimpressionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MiseEnPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GuiDosbox_LineNumber1 As GUIDosbox.GUIDosbox_LineNumber
    Friend WithEvents txtEditor As GUIDosbox.GUIDosbox_RichTextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents MiseEnPageToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CouperToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopierToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CollerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutilsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompillerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
