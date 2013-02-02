<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssocApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AssocApp))
        Me.ExtentionSet = New System.Windows.Forms.TextBox()
        Me.ExtentionFile = New System.Windows.Forms.TextBox()
        Me.lblExtension = New System.Windows.Forms.Label()
        Me.LSubTitle2 = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.TextReturn = New System.Windows.Forms.TextBox()
        Me.CommandReturn = New System.Windows.Forms.TextBox()
        Me.lblCommande = New System.Windows.Forms.Label()
        Me.lblTypeFichier = New System.Windows.Forms.Label()
        Me.LSubTitle3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnExtShow = New System.Windows.Forms.Button()
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.chkbxLangue = New System.Windows.Forms.CheckBox()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExtentionSet
        '
        Me.ExtentionSet.Location = New System.Drawing.Point(110, 49)
        Me.ExtentionSet.Name = "ExtentionSet"
        Me.ExtentionSet.Size = New System.Drawing.Size(76, 20)
        Me.ExtentionSet.TabIndex = 1
        '
        'ExtentionFile
        '
        Me.ExtentionFile.Location = New System.Drawing.Point(110, 72)
        Me.ExtentionFile.Name = "ExtentionFile"
        Me.ExtentionFile.Size = New System.Drawing.Size(302, 20)
        Me.ExtentionFile.TabIndex = 2
        '
        'lblExtension
        '
        Me.lblExtension.AutoSize = True
        Me.lblExtension.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExtension.Location = New System.Drawing.Point(7, 49)
        Me.lblExtension.Name = "lblExtension"
        Me.lblExtension.Size = New System.Drawing.Size(99, 13)
        Me.lblExtension.TabIndex = 3
        Me.lblExtension.Text = "Extension :  .ext"
        '
        'LSubTitle2
        '
        Me.LSubTitle2.AutoSize = True
        Me.LSubTitle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSubTitle2.Location = New System.Drawing.Point(210, 54)
        Me.LSubTitle2.Name = "LSubTitle2"
        Me.LSubTitle2.Size = New System.Drawing.Size(15, 15)
        Me.LSubTitle2.TabIndex = 4
        Me.LSubTitle2.Text = "="
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(6, 370)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(75, 23)
        Me.btnHelp.TabIndex = 5
        Me.btnHelp.Text = "Aide"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(274, 370)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 6
        Me.btnApply.Text = "Appliquer"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(355, 370)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "Retour"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(355, 341)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'TextReturn
        '
        Me.TextReturn.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextReturn.ForeColor = System.Drawing.SystemColors.Window
        Me.TextReturn.Location = New System.Drawing.Point(6, 98)
        Me.TextReturn.Multiline = True
        Me.TextReturn.Name = "TextReturn"
        Me.TextReturn.ReadOnly = True
        Me.TextReturn.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextReturn.Size = New System.Drawing.Size(424, 237)
        Me.TextReturn.TabIndex = 9
        '
        'CommandReturn
        '
        Me.CommandReturn.Location = New System.Drawing.Point(72, 341)
        Me.CommandReturn.Name = "CommandReturn"
        Me.CommandReturn.ReadOnly = True
        Me.CommandReturn.Size = New System.Drawing.Size(196, 20)
        Me.CommandReturn.TabIndex = 10
        '
        'lblCommande
        '
        Me.lblCommande.AutoSize = True
        Me.lblCommande.Location = New System.Drawing.Point(3, 344)
        Me.lblCommande.Name = "lblCommande"
        Me.lblCommande.Size = New System.Drawing.Size(63, 13)
        Me.lblCommande.TabIndex = 11
        Me.lblCommande.Text = "Commande:"
        '
        'lblTypeFichier
        '
        Me.lblTypeFichier.AutoSize = True
        Me.lblTypeFichier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypeFichier.Location = New System.Drawing.Point(6, 75)
        Me.lblTypeFichier.Name = "lblTypeFichier"
        Me.lblTypeFichier.Size = New System.Drawing.Size(100, 13)
        Me.lblTypeFichier.TabIndex = 12
        Me.lblTypeFichier.Text = "Type de fichier :"
        '
        'LSubTitle3
        '
        Me.LSubTitle3.AutoSize = True
        Me.LSubTitle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSubTitle3.ForeColor = System.Drawing.Color.Red
        Me.LSubTitle3.Location = New System.Drawing.Point(192, 54)
        Me.LSubTitle3.Name = "LSubTitle3"
        Me.LSubTitle3.Size = New System.Drawing.Size(12, 15)
        Me.LSubTitle3.TabIndex = 13
        Me.LSubTitle3.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(417, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "*"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(87, 373)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(181, 20)
        Me.ProgressBar1.TabIndex = 15
        '
        'btnExtShow
        '
        Me.btnExtShow.Location = New System.Drawing.Point(274, 341)
        Me.btnExtShow.Name = "btnExtShow"
        Me.btnExtShow.Size = New System.Drawing.Size(75, 23)
        Me.btnExtShow.TabIndex = 16
        Me.btnExtShow.Text = "Voir les .ext"
        Me.btnExtShow.UseVisualStyleBackColor = True
        '
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Dock = System.Windows.Forms.DockStyle.Top
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(0, 0)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(436, 35)
        Me.AxShockwaveFlash1.TabIndex = 17
        '
        'chkbxLangue
        '
        Me.chkbxLangue.AutoSize = True
        Me.chkbxLangue.Checked = True
        Me.chkbxLangue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbxLangue.Location = New System.Drawing.Point(414, 41)
        Me.chkbxLangue.Name = "chkbxLangue"
        Me.chkbxLangue.Size = New System.Drawing.Size(15, 14)
        Me.chkbxLangue.TabIndex = 18
        Me.chkbxLangue.UseVisualStyleBackColor = True
        Me.chkbxLangue.Visible = False
        '
        'AssocApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(436, 403)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkbxLangue)
        Me.Controls.Add(Me.AxShockwaveFlash1)
        Me.Controls.Add(Me.btnExtShow)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LSubTitle3)
        Me.Controls.Add(Me.lblTypeFichier)
        Me.Controls.Add(Me.lblCommande)
        Me.Controls.Add(Me.CommandReturn)
        Me.Controls.Add(Me.TextReturn)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.LSubTitle2)
        Me.Controls.Add(Me.lblExtension)
        Me.Controls.Add(Me.ExtentionFile)
        Me.Controls.Add(Me.ExtentionSet)
        Me.MaximumSize = New System.Drawing.Size(452, 441)
        Me.MinimumSize = New System.Drawing.Size(452, 441)
        Me.Name = "AssocApp"
        Me.Text = "GUI DosBox - Assoc"
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExtentionSet As System.Windows.Forms.TextBox
    Friend WithEvents ExtentionFile As System.Windows.Forms.TextBox
    Friend WithEvents lblExtension As System.Windows.Forms.Label
    Friend WithEvents LSubTitle2 As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents TextReturn As System.Windows.Forms.TextBox
    Friend WithEvents CommandReturn As System.Windows.Forms.TextBox
    Friend WithEvents lblCommande As System.Windows.Forms.Label
    Friend WithEvents lblTypeFichier As System.Windows.Forms.Label
    Friend WithEvents LSubTitle3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btnExtShow As System.Windows.Forms.Button
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents chkbxLangue As System.Windows.Forms.CheckBox
End Class
