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
        Me.optAdvanceMode = New System.Windows.Forms.CheckBox()
        Me.txtCmdExec = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.lblCommandeExec = New System.Windows.Forms.Label()
        Me.chkbxLangue = New System.Windows.Forms.CheckBox()
        Me.cbLecteur = New System.Windows.Forms.ComboBox()
        Me.GBCreer = New System.Windows.Forms.GroupBox()
        Me.BtnDossier = New System.Windows.Forms.Button()
        Me.txtDossier = New System.Windows.Forms.TextBox()
        Me.lblLecteur = New System.Windows.Forms.Label()
        Me.optLister = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.gbDelete = New System.Windows.Forms.GroupBox()
        Me.cbDelete = New System.Windows.Forms.ComboBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.flashHeader = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.optD = New GUIDosbox.GUIDosbox_Checkbox()
        Me.myConsole = New GUIDosbox.GUIDosbox_Console()
        Me.GBCreer.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbDelete.SuspendLayout()
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
        'optAdvanceMode
        '
        Me.optAdvanceMode.AutoSize = True
        Me.optAdvanceMode.Location = New System.Drawing.Point(513, 501)
        Me.optAdvanceMode.Name = "optAdvanceMode"
        Me.optAdvanceMode.Size = New System.Drawing.Size(92, 17)
        Me.optAdvanceMode.TabIndex = 10
        Me.optAdvanceMode.Text = "Mode avancé"
        Me.optAdvanceMode.UseVisualStyleBackColor = True
        '
        'txtCmdExec
        '
        Me.txtCmdExec.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCmdExec.Location = New System.Drawing.Point(129, 475)
        Me.txtCmdExec.Name = "txtCmdExec"
        Me.txtCmdExec.Size = New System.Drawing.Size(476, 21)
        Me.txtCmdExec.TabIndex = 13
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(315, 501)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 0
        Me.btnSend.Text = "Envoyer"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'lblCommandeExec
        '
        Me.lblCommandeExec.AutoSize = True
        Me.lblCommandeExec.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommandeExec.Location = New System.Drawing.Point(3, 481)
        Me.lblCommandeExec.Name = "lblCommandeExec"
        Me.lblCommandeExec.Size = New System.Drawing.Size(107, 15)
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
        'cbLecteur
        '
        Me.cbLecteur.FormattingEnabled = True
        Me.cbLecteur.Location = New System.Drawing.Point(13, 36)
        Me.cbLecteur.Name = "cbLecteur"
        Me.cbLecteur.Size = New System.Drawing.Size(69, 21)
        Me.cbLecteur.TabIndex = 20
        '
        'GBCreer
        '
        Me.GBCreer.Controls.Add(Me.BtnDossier)
        Me.GBCreer.Controls.Add(Me.txtDossier)
        Me.GBCreer.Controls.Add(Me.lblLecteur)
        Me.GBCreer.Controls.Add(Me.cbLecteur)
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
        'optLister
        '
        Me.optLister.AutoSize = True
        Me.optLister.ForeColor = System.Drawing.Color.Maroon
        Me.optLister.Location = New System.Drawing.Point(6, 19)
        Me.optLister.Name = "optLister"
        Me.optLister.Size = New System.Drawing.Size(104, 17)
        Me.optLister.TabIndex = 23
        Me.optLister.Text = "Lister Seulement"
        Me.optLister.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optLister)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 252)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(117, 52)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        '
        'gbDelete
        '
        Me.gbDelete.Controls.Add(Me.cbDelete)
        Me.gbDelete.Location = New System.Drawing.Point(6, 351)
        Me.gbDelete.Name = "gbDelete"
        Me.gbDelete.Size = New System.Drawing.Size(117, 49)
        Me.gbDelete.TabIndex = 25
        Me.gbDelete.TabStop = False
        Me.gbDelete.Text = "Supprimer"
        '
        'cbDelete
        '
        Me.cbDelete.FormattingEnabled = True
        Me.cbDelete.Location = New System.Drawing.Point(13, 22)
        Me.cbDelete.Name = "cbDelete"
        Me.cbDelete.Size = New System.Drawing.Size(68, 21)
        Me.cbDelete.TabIndex = 0
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
        'optD
        '
        Me.optD.AutoSize = True
        Me.optD.BackColor = System.Drawing.Color.Black
        Me.optD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optD.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optD.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optD.Location = New System.Drawing.Point(40, 433)
        Me.optD.Name = "optD"
        Me.optD.Size = New System.Drawing.Size(35, 15)
        Me.optD.TabIndex = 28
        Me.optD.Text = "/D"
        Me.optD.UseVisualStyleBackColor = False
        '
        'myConsole
        '
        Me.myConsole.Location = New System.Drawing.Point(129, 54)
        Me.myConsole.myConsole = Nothing
        Me.myConsole.Name = "myConsole"
        Me.myConsole.Size = New System.Drawing.Size(476, 394)
        Me.myConsole.TabIndex = 26
        '
        'SUBSTApp
        '
        Me.AcceptButton = Me.btnSend
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(617, 584)
        Me.ControlBox = False
        Me.Controls.Add(Me.optD)
        Me.Controls.Add(Me.flashHeader)
        Me.Controls.Add(Me.myConsole)
        Me.Controls.Add(Me.gbDelete)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GBCreer)
        Me.Controls.Add(Me.chkbxLangue)
        Me.Controls.Add(Me.lblCommandeExec)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txtCmdExec)
        Me.Controls.Add(Me.optAdvanceMode)
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
        Me.gbDelete.ResumeLayout(False)
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents optAdvanceMode As System.Windows.Forms.CheckBox
    Friend WithEvents txtCmdExec As System.Windows.Forms.TextBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents lblCommandeExec As System.Windows.Forms.Label
    Friend WithEvents chkbxLangue As System.Windows.Forms.CheckBox
    Friend WithEvents cbLecteur As System.Windows.Forms.ComboBox
    Friend WithEvents GBCreer As System.Windows.Forms.GroupBox
    Friend WithEvents BtnDossier As System.Windows.Forms.Button
    Friend WithEvents txtDossier As System.Windows.Forms.TextBox
    Friend WithEvents lblLecteur As System.Windows.Forms.Label
    Friend WithEvents optLister As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents gbDelete As System.Windows.Forms.GroupBox
    Friend WithEvents cbDelete As System.Windows.Forms.ComboBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents myConsole As GUIDosbox.GUIDosbox_Console
    Friend WithEvents flashHeader As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents optD As GUIDosbox.GUIDosbox_Checkbox
End Class
