<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TypeApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TypeApp))
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtCmdExec = New System.Windows.Forms.TextBox()
        Me.lblCommandeExec = New System.Windows.Forms.Label()
        Me.chkbxLangue = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnFichier = New System.Windows.Forms.Button()
        Me.txtPathFichier = New System.Windows.Forms.TextBox()
        Me.lblFichier = New System.Windows.Forms.Label()
        Me.myConsole = New GUIDosbox.GUIDosbox_Console()
        Me.flashHeader = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.OptAdvanceMode = New GUIDosbox.GUIDosbox_Checkbox()
        Me.btnSend = New GUIDosbox.GUIDosbox_Button()
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
        Me.btnApply.Location = New System.Drawing.Point(459, 553)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 7
        Me.btnApply.Text = "Lire"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Location = New System.Drawing.Point(643, 530)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "Retour"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(643, 458)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtCmdExec
        '
        Me.txtCmdExec.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCmdExec.Location = New System.Drawing.Point(129, 460)
        Me.txtCmdExec.Name = "txtCmdExec"
        Me.txtCmdExec.Size = New System.Drawing.Size(476, 21)
        Me.txtCmdExec.TabIndex = 13
        '
        'lblCommandeExec
        '
        Me.lblCommandeExec.AutoSize = True
        Me.lblCommandeExec.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommandeExec.Location = New System.Drawing.Point(5, 466)
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
        Me.chkbxLangue.Location = New System.Drawing.Point(739, 12)
        Me.chkbxLangue.Name = "chkbxLangue"
        Me.chkbxLangue.Size = New System.Drawing.Size(15, 14)
        Me.chkbxLangue.TabIndex = 19
        Me.chkbxLangue.UseVisualStyleBackColor = True
        Me.chkbxLangue.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnFichier
        '
        Me.btnFichier.Location = New System.Drawing.Point(146, 500)
        Me.btnFichier.Name = "btnFichier"
        Me.btnFichier.Size = New System.Drawing.Size(75, 23)
        Me.btnFichier.TabIndex = 20
        Me.btnFichier.Text = "Fichier"
        Me.btnFichier.UseVisualStyleBackColor = True
        '
        'txtPathFichier
        '
        Me.txtPathFichier.Location = New System.Drawing.Point(227, 500)
        Me.txtPathFichier.Name = "txtPathFichier"
        Me.txtPathFichier.Size = New System.Drawing.Size(378, 20)
        Me.txtPathFichier.TabIndex = 21
        '
        'lblFichier
        '
        Me.lblFichier.AutoSize = True
        Me.lblFichier.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFichier.Location = New System.Drawing.Point(5, 500)
        Me.lblFichier.Name = "lblFichier"
        Me.lblFichier.Size = New System.Drawing.Size(76, 15)
        Me.lblFichier.TabIndex = 22
        Me.lblFichier.Text = "Fichier à lire"
        '
        'myConsole
        '
        Me.myConsole.Location = New System.Drawing.Point(8, 55)
        Me.myConsole.myConsole = Nothing
        Me.myConsole.Name = "myConsole"
        Me.myConsole.Size = New System.Drawing.Size(746, 399)
        Me.myConsole.TabIndex = 23
        '
        'flashHeader
        '
        Me.flashHeader.Enabled = True
        Me.flashHeader.Location = New System.Drawing.Point(0, -1)
        Me.flashHeader.Name = "flashHeader"
        Me.flashHeader.OcxState = CType(resources.GetObject("flashHeader.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flashHeader.Size = New System.Drawing.Size(763, 40)
        Me.flashHeader.TabIndex = 24
        '
        'OptAdvanceMode
        '
        Me.OptAdvanceMode.AutoSize = True
        Me.OptAdvanceMode.BackColor = System.Drawing.Color.Transparent
        Me.OptAdvanceMode.Font = New System.Drawing.Font("Lucida Console", 8.0!, System.Drawing.FontStyle.Regular)
        Me.OptAdvanceMode.ForeColor = System.Drawing.Color.LightBlue
        Me.OptAdvanceMode.Location = New System.Drawing.Point(26, 530)
        Me.OptAdvanceMode.Name = "OptAdvanceMode"
        Me.OptAdvanceMode.Size = New System.Drawing.Size(112, 15)
        Me.OptAdvanceMode.TabIndex = 25
        Me.OptAdvanceMode.Text = "Mode avancé"
        Me.OptAdvanceMode.UseVisualStyleBackColor = False
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.Black
        Me.btnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.Font = New System.Drawing.Font("Lucida Console", 8.0!, System.Drawing.FontStyle.Regular)
        Me.btnSend.ForeColor = System.Drawing.Color.LightBlue
        Me.btnSend.Location = New System.Drawing.Point(246, 531)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 26
        Me.btnSend.Text = "Envoyer"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'TypeApp
        '
        Me.AcceptButton = Me.btnApply
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(759, 584)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.OptAdvanceMode)
        Me.Controls.Add(Me.chkbxLangue)
        Me.Controls.Add(Me.flashHeader)
        Me.Controls.Add(Me.myConsole)
        Me.Controls.Add(Me.lblFichier)
        Me.Controls.Add(Me.txtPathFichier)
        Me.Controls.Add(Me.btnFichier)
        Me.Controls.Add(Me.lblCommandeExec)
        Me.Controls.Add(Me.txtCmdExec)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnHelp)
        Me.Name = "TypeApp"
        Me.Text = "GUI DosBox - Type"
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtCmdExec As System.Windows.Forms.TextBox
    Friend WithEvents lblCommandeExec As System.Windows.Forms.Label
    Friend WithEvents chkbxLangue As System.Windows.Forms.CheckBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnFichier As System.Windows.Forms.Button
    Friend WithEvents txtPathFichier As System.Windows.Forms.TextBox
    Friend WithEvents lblFichier As System.Windows.Forms.Label
    Friend WithEvents myConsole As GUIDosbox.GUIDosbox_Console
    Friend WithEvents flashHeader As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents OptAdvanceMode As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents btnSend As GUIDosbox.GUIDosbox_Button
End Class
