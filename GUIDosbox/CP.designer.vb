<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CP))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiseÀJourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParamètresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuiterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssocToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttribToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaclsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChkdskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CmdConsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubstToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TracertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhereToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhoamiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XcopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutilsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BatToexeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÉditerBatchFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.FrançaisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnglishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HeaderFlashFR = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.FlashCPFR = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.FlashHeader = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.FlashCPEN = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblMode = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GuiDosbox_ProgressBar1 = New GUIDosbox.GUIDosbox_ProgressBar()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.HeaderFlashFR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlashCPFR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlashHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlashCPEN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.WindowText
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.ToolStripMenuItem1, Me.OutilsToolStripMenuItem, Me.HelpToolStripMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(-2, 37)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip1.Size = New System.Drawing.Size(705, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowText
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MiseÀJourToolStripMenuItem, Me.ParamètresToolStripMenuItem, Me.ToolStripSeparator1, Me.QuiterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FichierToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(56, 24)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'MiseÀJourToolStripMenuItem
        '
        Me.MiseÀJourToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.MiseÀJourToolStripMenuItem.Image = Global.GUIDosbox.My.Resources.Resources.Media_Player
        Me.MiseÀJourToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MiseÀJourToolStripMenuItem.Name = "MiseÀJourToolStripMenuItem"
        Me.MiseÀJourToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MiseÀJourToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.MiseÀJourToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.MiseÀJourToolStripMenuItem.Size = New System.Drawing.Size(192, 38)
        Me.MiseÀJourToolStripMenuItem.Text = "Mise à jour"
        '
        'ParamètresToolStripMenuItem
        '
        Me.ParamètresToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ParamètresToolStripMenuItem.Image = CType(resources.GetObject("ParamètresToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ParamètresToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ParamètresToolStripMenuItem.Name = "ParamètresToolStripMenuItem"
        Me.ParamètresToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.ParamètresToolStripMenuItem.Size = New System.Drawing.Size(192, 38)
        Me.ParamètresToolStripMenuItem.Text = "Paramètres"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(189, 6)
        '
        'QuiterToolStripMenuItem
        '
        Me.QuiterToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowText
        Me.QuiterToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.QuiterToolStripMenuItem.Image = Global.GUIDosbox.My.Resources.Resources.Xion
        Me.QuiterToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.QuiterToolStripMenuItem.Name = "QuiterToolStripMenuItem"
        Me.QuiterToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.QuiterToolStripMenuItem.Size = New System.Drawing.Size(192, 38)
        Me.QuiterToolStripMenuItem.Text = "Quitter"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AssocToolStripMenuItem, Me.AttribToolStripMenuItem, Me.CaclsToolStripMenuItem, Me.ChkdskToolStripMenuItem, Me.CmdConsoleToolStripMenuItem, Me.CompactToolStripMenuItem, Me.CompToolStripMenuItem, Me.RdToolStripMenuItem, Me.SubstToolStripMenuItem, Me.SystemInfoToolStripMenuItem, Me.TracertToolStripMenuItem, Me.TypeToolStripMenuItem, Me.WhereToolStripMenuItem, Me.WhoamiToolStripMenuItem, Me.XcopyToolStripMenuItem})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(86, 24)
        Me.ToolStripMenuItem1.Text = "Applications"
        '
        'AssocToolStripMenuItem
        '
        Me.AssocToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowText
        Me.AssocToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.AssocToolStripMenuItem.Name = "AssocToolStripMenuItem"
        Me.AssocToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.AssocToolStripMenuItem.Text = "ASSOC"
        '
        'AttribToolStripMenuItem
        '
        Me.AttribToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowText
        Me.AttribToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.AttribToolStripMenuItem.Name = "AttribToolStripMenuItem"
        Me.AttribToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.AttribToolStripMenuItem.Text = "ATTRIB"
        '
        'CaclsToolStripMenuItem
        '
        Me.CaclsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CaclsToolStripMenuItem.Name = "CaclsToolStripMenuItem"
        Me.CaclsToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.CaclsToolStripMenuItem.Text = "CACLS"
        '
        'ChkdskToolStripMenuItem
        '
        Me.ChkdskToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowText
        Me.ChkdskToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ChkdskToolStripMenuItem.Name = "ChkdskToolStripMenuItem"
        Me.ChkdskToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ChkdskToolStripMenuItem.Text = "CHKDSK"
        '
        'CmdConsoleToolStripMenuItem
        '
        Me.CmdConsoleToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowText
        Me.CmdConsoleToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CmdConsoleToolStripMenuItem.Name = "CmdConsoleToolStripMenuItem"
        Me.CmdConsoleToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.CmdConsoleToolStripMenuItem.Text = "CMD CONSOLE"
        '
        'CompactToolStripMenuItem
        '
        Me.CompactToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowText
        Me.CompactToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CompactToolStripMenuItem.Name = "CompactToolStripMenuItem"
        Me.CompactToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.CompactToolStripMenuItem.Text = "COMPACT"
        '
        'CompToolStripMenuItem
        '
        Me.CompToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CompToolStripMenuItem.Name = "CompToolStripMenuItem"
        Me.CompToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.CompToolStripMenuItem.Text = "COMP"
        '
        'RdToolStripMenuItem
        '
        Me.RdToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.RdToolStripMenuItem.Name = "RdToolStripMenuItem"
        Me.RdToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.RdToolStripMenuItem.Text = "RD"
        '
        'SubstToolStripMenuItem
        '
        Me.SubstToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.SubstToolStripMenuItem.Name = "SubstToolStripMenuItem"
        Me.SubstToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.SubstToolStripMenuItem.Text = "SUBST"
        '
        'SystemInfoToolStripMenuItem
        '
        Me.SystemInfoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.SystemInfoToolStripMenuItem.Name = "SystemInfoToolStripMenuItem"
        Me.SystemInfoToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.SystemInfoToolStripMenuItem.Text = "SYSTEM INFO"
        '
        'TracertToolStripMenuItem
        '
        Me.TracertToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.TracertToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.TracertToolStripMenuItem.Name = "TracertToolStripMenuItem"
        Me.TracertToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.TracertToolStripMenuItem.Text = "TRACERT"
        '
        'TypeToolStripMenuItem
        '
        Me.TypeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.TypeToolStripMenuItem.Name = "TypeToolStripMenuItem"
        Me.TypeToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.TypeToolStripMenuItem.Text = "TYPE"
        '
        'WhereToolStripMenuItem
        '
        Me.WhereToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.WhereToolStripMenuItem.Name = "WhereToolStripMenuItem"
        Me.WhereToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.WhereToolStripMenuItem.Text = "WHERE"
        '
        'WhoamiToolStripMenuItem
        '
        Me.WhoamiToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowText
        Me.WhoamiToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.WhoamiToolStripMenuItem.Name = "WhoamiToolStripMenuItem"
        Me.WhoamiToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.WhoamiToolStripMenuItem.Text = "WHOAMI"
        '
        'XcopyToolStripMenuItem
        '
        Me.XcopyToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowText
        Me.XcopyToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.XcopyToolStripMenuItem.Name = "XcopyToolStripMenuItem"
        Me.XcopyToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.XcopyToolStripMenuItem.Text = "XCOPY"
        '
        'OutilsToolStripMenuItem
        '
        Me.OutilsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BatToexeToolStripMenuItem, Me.ÉditerBatchFileToolStripMenuItem})
        Me.OutilsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.OutilsToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue
        Me.OutilsToolStripMenuItem.Name = "OutilsToolStripMenuItem"
        Me.OutilsToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.OutilsToolStripMenuItem.Text = "Outils"
        '
        'BatToexeToolStripMenuItem
        '
        Me.BatToexeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BatToexeToolStripMenuItem.Image = Global.GUIDosbox.My.Resources.Resources.Gear
        Me.BatToexeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BatToexeToolStripMenuItem.Name = "BatToexeToolStripMenuItem"
        Me.BatToexeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.BatToexeToolStripMenuItem.Size = New System.Drawing.Size(217, 38)
        Me.BatToexeToolStripMenuItem.Text = ".bat To .exe"
        '
        'ÉditerBatchFileToolStripMenuItem
        '
        Me.ÉditerBatchFileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ÉditerBatchFileToolStripMenuItem.Image = Global.GUIDosbox.My.Resources.Resources.Writing
        Me.ÉditerBatchFileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ÉditerBatchFileToolStripMenuItem.Name = "ÉditerBatchFileToolStripMenuItem"
        Me.ÉditerBatchFileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ÉditerBatchFileToolStripMenuItem.Size = New System.Drawing.Size(217, 38)
        Me.ÉditerBatchFileToolStripMenuItem.Text = "Éditer Batch File"
        '
        'HelpToolStripMenu
        '
        Me.HelpToolStripMenu.BackColor = System.Drawing.SystemColors.WindowText
        Me.HelpToolStripMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.HelpToolStripMenu.ForeColor = System.Drawing.Color.RoyalBlue
        Me.HelpToolStripMenu.Name = "HelpToolStripMenu"
        Me.HelpToolStripMenu.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.HelpToolStripMenu.Size = New System.Drawing.Size(44, 24)
        Me.HelpToolStripMenu.Text = "Aide"
        '
        'FrançaisToolStripMenuItem
        '
        Me.FrançaisToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.FrançaisToolStripMenuItem.Image = Global.GUIDosbox.My.Resources.Resources.quebec
        Me.FrançaisToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FrançaisToolStripMenuItem.Name = "FrançaisToolStripMenuItem"
        Me.FrançaisToolStripMenuItem.Size = New System.Drawing.Size(205, 38)
        Me.FrançaisToolStripMenuItem.Text = "Français"
        '
        'EnglishToolStripMenuItem
        '
        Me.EnglishToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.EnglishToolStripMenuItem.Image = Global.GUIDosbox.My.Resources.Resources.anglais
        Me.EnglishToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EnglishToolStripMenuItem.Name = "EnglishToolStripMenuItem"
        Me.EnglishToolStripMenuItem.Size = New System.Drawing.Size(205, 38)
        Me.EnglishToolStripMenuItem.Text = "Anglais"
        '
        'HeaderFlashFR
        '
        Me.HeaderFlashFR.Enabled = True
        Me.HeaderFlashFR.Location = New System.Drawing.Point(-5, -3)
        Me.HeaderFlashFR.Name = "HeaderFlashFR"
        Me.HeaderFlashFR.OcxState = CType(resources.GetObject("HeaderFlashFR.OcxState"), System.Windows.Forms.AxHost.State)
        Me.HeaderFlashFR.Size = New System.Drawing.Size(0, 0)
        Me.HeaderFlashFR.TabIndex = 5
        '
        'FlashCPFR
        '
        Me.FlashCPFR.Enabled = True
        Me.FlashCPFR.Location = New System.Drawing.Point(-109, -89)
        Me.FlashCPFR.Name = "FlashCPFR"
        Me.FlashCPFR.OcxState = CType(resources.GetObject("FlashCPFR.OcxState"), System.Windows.Forms.AxHost.State)
        Me.FlashCPFR.Size = New System.Drawing.Size(918, 696)
        Me.FlashCPFR.TabIndex = 4
        '
        'FlashHeader
        '
        Me.FlashHeader.Enabled = True
        Me.FlashHeader.Location = New System.Drawing.Point(-5, -3)
        Me.FlashHeader.Name = "FlashHeader"
        Me.FlashHeader.OcxState = CType(resources.GetObject("FlashHeader.OcxState"), System.Windows.Forms.AxHost.State)
        Me.FlashHeader.Size = New System.Drawing.Size(728, 58)
        Me.FlashHeader.TabIndex = 8
        '
        'FlashCPEN
        '
        Me.FlashCPEN.Enabled = True
        Me.FlashCPEN.Location = New System.Drawing.Point(-109, -89)
        Me.FlashCPEN.Name = "FlashCPEN"
        Me.FlashCPEN.OcxState = CType(resources.GetObject("FlashCPEN.OcxState"), System.Windows.Forms.AxHost.State)
        Me.FlashCPEN.Size = New System.Drawing.Size(918, 696)
        Me.FlashCPEN.TabIndex = 9
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Black
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblMode, Me.lblUser})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 448)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(705, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblMode
        '
        Me.lblMode.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.lblMode.ForeColor = System.Drawing.Color.MediumPurple
        Me.lblMode.Name = "lblMode"
        Me.lblMode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMode.Size = New System.Drawing.Size(47, 17)
        Me.lblMode.Text = "{Mode}"
        '
        'lblUser
        '
        Me.lblUser.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.lblUser.ForeColor = System.Drawing.Color.LightBlue
        Me.lblUser.Name = "lblUser"
        Me.lblUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblUser.Size = New System.Drawing.Size(75, 17)
        Me.lblUser.Text = "{UserName}"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'GuiDosbox_ProgressBar1
        '
        Me.GuiDosbox_ProgressBar1.BackgroundImage = CType(resources.GetObject("GuiDosbox_ProgressBar1.BackgroundImage"), System.Drawing.Image)
        Me.GuiDosbox_ProgressBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GuiDosbox_ProgressBar1.FillProgress = 0
        Me.GuiDosbox_ProgressBar1.Location = New System.Drawing.Point(54, 195)
        Me.GuiDosbox_ProgressBar1.MaximumSize = New System.Drawing.Size(596, 80)
        Me.GuiDosbox_ProgressBar1.MinimumSize = New System.Drawing.Size(596, 80)
        Me.GuiDosbox_ProgressBar1.Name = "GuiDosbox_ProgressBar1"
        Me.GuiDosbox_ProgressBar1.OutputText = "Prêt"
        Me.GuiDosbox_ProgressBar1.Size = New System.Drawing.Size(596, 80)
        Me.GuiDosbox_ProgressBar1.TabIndex = 11
        Me.GuiDosbox_ProgressBar1.Visible = False
        '
        'CP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowText
        Me.BackgroundImage = Global.GUIDosbox.My.Resources.Resources.MainBG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(705, 470)
        Me.Controls.Add(Me.GuiDosbox_ProgressBar1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.FlashHeader)
        Me.Controls.Add(Me.HeaderFlashFR)
        Me.Controls.Add(Me.FlashCPFR)
        Me.Controls.Add(Me.FlashCPEN)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(721, 508)
        Me.MinimumSize = New System.Drawing.Size(721, 508)
        Me.Name = "CP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GUI DosBox"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.HeaderFlashFR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlashCPFR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlashHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlashCPEN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuiterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HeaderFlashFR As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents FlashCPFR As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents FrançaisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnglishToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FlashHeader As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents FlashCPEN As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AssocToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttribToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CaclsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChkdskToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CmdConsoleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompactToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RdToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TracertToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XcopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WhoamiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubstToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WhereToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblMode As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents OutilsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BatToexeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÉditerBatchFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParamètresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GuiDosbox_ProgressBar1 As GUIDosbox.GUIDosbox_ProgressBar
    Friend WithEvents MiseÀJourToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator

End Class
