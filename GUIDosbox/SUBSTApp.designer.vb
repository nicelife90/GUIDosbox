<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SUBSTApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SUBSTApp))
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.OptADV = New System.Windows.Forms.CheckBox()
        Me.CommandReturn = New System.Windows.Forms.TextBox()
        Me.ADVCommand = New System.Windows.Forms.TextBox()
        Me.btnEnvoi = New System.Windows.Forms.Button()
        Me.lblLigneCommande = New System.Windows.Forms.Label()
        Me.lblCommandeExec = New System.Windows.Forms.Label()
        Me.chkbxLangue = New System.Windows.Forms.CheckBox()
        Me.txtLecteur = New System.Windows.Forms.ComboBox()
        Me.GBCreer = New System.Windows.Forms.GroupBox()
        Me.BtnDossier = New System.Windows.Forms.Button()
        Me.txtDossier = New System.Windows.Forms.TextBox()
        Me.lblLecteur = New System.Windows.Forms.Label()
        Me.OptSUBST = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GBSupprimmer = New System.Windows.Forms.GroupBox()
        Me.txtDelete = New System.Windows.Forms.ComboBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.myConsole = New GUIDosbox.GUIDosboxConsole()
        Me.flashHeader = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.GBCreer.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GBSupprimmer.SuspendLayout()
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(13, 553)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(75, 23)
        Me.btnHelp.TabIndex = 6
        Me.btnHelp.Text = "Aide"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(449, 553)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 7
        Me.btnApply.Text = "Appliquer"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(530, 553)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "Retour"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(530, 524)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'OptADV
        '
        Me.OptADV.AutoSize = True
        Me.OptADV.Location = New System.Drawing.Point(513, 501)
        Me.OptADV.Name = "OptADV"
        Me.OptADV.Size = New System.Drawing.Size(92, 17)
        Me.OptADV.TabIndex = 10
        Me.OptADV.Text = "Mode avancé"
        Me.OptADV.UseVisualStyleBackColor = True
        '
        'CommandReturn
        '
        Me.CommandReturn.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommandReturn.Location = New System.Drawing.Point(129, 475)
        Me.CommandReturn.Name = "CommandReturn"
        Me.CommandReturn.Size = New System.Drawing.Size(476, 21)
        Me.CommandReturn.TabIndex = 13
        '
        'ADVCommand
        '
        Me.ADVCommand.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADVCommand.Location = New System.Drawing.Point(129, 454)
        Me.ADVCommand.Name = "ADVCommand"
        Me.ADVCommand.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ADVCommand.Size = New System.Drawing.Size(476, 21)
        Me.ADVCommand.TabIndex = 14
        '
        'btnEnvoi
        '
        Me.btnEnvoi.Location = New System.Drawing.Point(315, 501)
        Me.btnEnvoi.Name = "btnEnvoi"
        Me.btnEnvoi.Size = New System.Drawing.Size(75, 23)
        Me.btnEnvoi.TabIndex = 0
        Me.btnEnvoi.Text = "Envoi"
        Me.btnEnvoi.UseVisualStyleBackColor = True
        '
        'lblLigneCommande
        '
        Me.lblLigneCommande.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLigneCommande.Location = New System.Drawing.Point(5, 460)
        Me.lblLigneCommande.Name = "lblLigneCommande"
        Me.lblLigneCommande.Size = New System.Drawing.Size(118, 15)
        Me.lblLigneCommande.TabIndex = 16
        Me.lblLigneCommande.Text = "Ligne de commande :"
        Me.lblLigneCommande.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCommandeExec
        '
        Me.lblCommandeExec.AutoSize = True
        Me.lblCommandeExec.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommandeExec.Location = New System.Drawing.Point(3, 481)
        Me.lblCommandeExec.Name = "lblCommandeExec"
        Me.lblCommandeExec.Size = New System.Drawing.Size(120, 15)
        Me.lblCommandeExec.TabIndex = 17
        Me.lblCommandeExec.Text = "Commande exécutée:"
        Me.lblCommandeExec.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chkbxLangue
        '
        Me.chkbxLangue.AutoSize = True
        Me.chkbxLangue.Checked = True
        Me.chkbxLangue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbxLangue.Location = New System.Drawing.Point(-1, 572)
        Me.chkbxLangue.Name = "chkbxLangue"
        Me.chkbxLangue.Size = New System.Drawing.Size(15, 14)
        Me.chkbxLangue.TabIndex = 19
        Me.chkbxLangue.UseVisualStyleBackColor = True
        Me.chkbxLangue.Visible = False
        '
        'txtLecteur
        '
        Me.txtLecteur.FormattingEnabled = True
        Me.txtLecteur.Location = New System.Drawing.Point(41, 38)
        Me.txtLecteur.Name = "txtLecteur"
        Me.txtLecteur.Size = New System.Drawing.Size(69, 21)
        Me.txtLecteur.TabIndex = 20
        '
        'GBCreer
        '
        Me.GBCreer.Controls.Add(Me.BtnDossier)
        Me.GBCreer.Controls.Add(Me.txtDossier)
        Me.GBCreer.Controls.Add(Me.lblLecteur)
        Me.GBCreer.Controls.Add(Me.txtLecteur)
        Me.GBCreer.Location = New System.Drawing.Point(6, 97)
        Me.GBCreer.Name = "GBCreer"
        Me.GBCreer.Size = New System.Drawing.Size(117, 149)
        Me.GBCreer.TabIndex = 22
        Me.GBCreer.TabStop = False
        Me.GBCreer.Text = "Créer"
        '
        'BtnDossier
        '
        Me.BtnDossier.Location = New System.Drawing.Point(6, 94)
        Me.BtnDossier.Name = "BtnDossier"
        Me.BtnDossier.Size = New System.Drawing.Size(72, 23)
        Me.BtnDossier.TabIndex = 23
        Me.BtnDossier.Text = "Dossier"
        Me.BtnDossier.UseVisualStyleBackColor = True
        '
        'txtDossier
        '
        Me.txtDossier.Location = New System.Drawing.Point(6, 123)
        Me.txtDossier.Name = "txtDossier"
        Me.txtDossier.Size = New System.Drawing.Size(100, 20)
        Me.txtDossier.TabIndex = 22
        '
        'lblLecteur
        '
        Me.lblLecteur.AutoSize = True
        Me.lblLecteur.Location = New System.Drawing.Point(7, 20)
        Me.lblLecteur.Name = "lblLecteur"
        Me.lblLecteur.Size = New System.Drawing.Size(49, 13)
        Me.lblLecteur.TabIndex = 21
        Me.lblLecteur.Text = "Lecteur :"
        '
        'OptSUBST
        '
        Me.OptSUBST.AutoSize = True
        Me.OptSUBST.ForeColor = System.Drawing.Color.Maroon
        Me.OptSUBST.Location = New System.Drawing.Point(6, 19)
        Me.OptSUBST.Name = "OptSUBST"
        Me.OptSUBST.Size = New System.Drawing.Size(104, 17)
        Me.OptSUBST.TabIndex = 23
        Me.OptSUBST.Text = "Lister Seulement"
        Me.OptSUBST.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.OptSUBST)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 252)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(117, 52)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        '
        'GBSupprimmer
        '
        Me.GBSupprimmer.Controls.Add(Me.txtDelete)
        Me.GBSupprimmer.Location = New System.Drawing.Point(6, 351)
        Me.GBSupprimmer.Name = "GBSupprimmer"
        Me.GBSupprimmer.Size = New System.Drawing.Size(117, 49)
        Me.GBSupprimmer.TabIndex = 25
        Me.GBSupprimmer.TabStop = False
        Me.GBSupprimmer.Text = "Supprimer"
        '
        'txtDelete
        '
        Me.txtDelete.FormattingEnabled = True
        Me.txtDelete.Location = New System.Drawing.Point(42, 20)
        Me.txtDelete.Name = "txtDelete"
        Me.txtDelete.Size = New System.Drawing.Size(68, 21)
        Me.txtDelete.TabIndex = 0
        '
        'myConsole
        '
        Me.myConsole.Location = New System.Drawing.Point(129, 54)
        Me.myConsole.myConsole = Nothing
        Me.myConsole.Name = "myConsole"
        Me.myConsole.Size = New System.Drawing.Size(476, 394)
        Me.myConsole.TabIndex = 26
        '
        'flashHeader
        '
        Me.flashHeader.Enabled = True
        Me.flashHeader.Location = New System.Drawing.Point(0, 0)
        Me.flashHeader.Name = "flashHeader"
        Me.flashHeader.OcxState = CType(resources.GetObject("flashHeader.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flashHeader.Size = New System.Drawing.Size(619, 40)
        Me.flashHeader.TabIndex = 27
        '
        'SUBSTApp
        '
        Me.AcceptButton = Me.btnEnvoi
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(617, 584)
        Me.ControlBox = False
        Me.Controls.Add(Me.flashHeader)
        Me.Controls.Add(Me.myConsole)
        Me.Controls.Add(Me.GBSupprimmer)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GBCreer)
        Me.Controls.Add(Me.chkbxLangue)
        Me.Controls.Add(Me.lblCommandeExec)
        Me.Controls.Add(Me.lblLigneCommande)
        Me.Controls.Add(Me.btnEnvoi)
        Me.Controls.Add(Me.ADVCommand)
        Me.Controls.Add(Me.CommandReturn)
        Me.Controls.Add(Me.OptADV)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnHelp)
        Me.Name = "SUBSTApp"
        Me.Text = "GUI DosBox - SUBST"
        Me.GBCreer.ResumeLayout(False)
        Me.GBCreer.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GBSupprimmer.ResumeLayout(False)
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents OptADV As System.Windows.Forms.CheckBox
    Friend WithEvents CommandReturn As System.Windows.Forms.TextBox
    Friend WithEvents ADVCommand As System.Windows.Forms.TextBox
    Friend WithEvents btnEnvoi As System.Windows.Forms.Button
    Friend WithEvents lblLigneCommande As System.Windows.Forms.Label
    Friend WithEvents lblCommandeExec As System.Windows.Forms.Label
    Friend WithEvents chkbxLangue As System.Windows.Forms.CheckBox
    Friend WithEvents txtLecteur As System.Windows.Forms.ComboBox
    Friend WithEvents GBCreer As System.Windows.Forms.GroupBox
    Friend WithEvents BtnDossier As System.Windows.Forms.Button
    Friend WithEvents txtDossier As System.Windows.Forms.TextBox
    Friend WithEvents lblLecteur As System.Windows.Forms.Label
    Friend WithEvents OptSUBST As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GBSupprimmer As System.Windows.Forms.GroupBox
    Friend WithEvents txtDelete As System.Windows.Forms.ComboBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents myConsole As GUIDosbox.GUIDosboxConsole
    Friend WithEvents flashHeader As AxShockwaveFlashObjects.AxShockwaveFlash
End Class
