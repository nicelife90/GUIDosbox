<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CMDConsole
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CMDConsole))
        Me.OutputTextBox = New System.Windows.Forms.TextBox()
        Me.InputTextBox = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.lblCommande = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.chkbxLangue = New System.Windows.Forms.CheckBox()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OutputTextBox
        '
        Me.OutputTextBox.BackColor = System.Drawing.SystemColors.WindowText
        Me.OutputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OutputTextBox.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputTextBox.ForeColor = System.Drawing.Color.LightBlue
        Me.OutputTextBox.Location = New System.Drawing.Point(12, 44)
        Me.OutputTextBox.Multiline = True
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.ReadOnly = True
        Me.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.OutputTextBox.Size = New System.Drawing.Size(645, 457)
        Me.OutputTextBox.TabIndex = 0
        '
        'InputTextBox
        '
        Me.InputTextBox.Location = New System.Drawing.Point(131, 506)
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.Size = New System.Drawing.Size(506, 20)
        Me.InputTextBox.TabIndex = 0
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(562, 533)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Retour"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(8, 533)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(75, 23)
        Me.btnHelp.TabIndex = 3
        Me.btnHelp.Text = "Aide"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'lblCommande
        '
        Me.lblCommande.AutoSize = True
        Me.lblCommande.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommande.ForeColor = System.Drawing.SystemColors.Window
        Me.lblCommande.Location = New System.Drawing.Point(7, 507)
        Me.lblCommande.Name = "lblCommande"
        Me.lblCommande.Size = New System.Drawing.Size(124, 15)
        Me.lblCommande.TabIndex = 4
        Me.lblCommande.Text = "Ligne de commande :  "
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(250, 533)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Effacer"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(0, 0)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(687, 46)
        Me.AxShockwaveFlash1.TabIndex = 6
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(159, 533)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 7
        Me.btnSend.Text = "Envoyer"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'chkbxLangue
        '
        Me.chkbxLangue.AutoSize = True
        Me.chkbxLangue.Checked = True
        Me.chkbxLangue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbxLangue.ForeColor = System.Drawing.SystemColors.Window
        Me.chkbxLangue.Location = New System.Drawing.Point(342, 538)
        Me.chkbxLangue.Name = "chkbxLangue"
        Me.chkbxLangue.Size = New System.Drawing.Size(15, 14)
        Me.chkbxLangue.TabIndex = 8
        Me.chkbxLangue.UseVisualStyleBackColor = True
        Me.chkbxLangue.Visible = False
        '
        'CMDConsole
        '
        Me.AcceptButton = Me.btnSend
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowText
        Me.ClientSize = New System.Drawing.Size(657, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkbxLangue)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.AxShockwaveFlash1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblCommande)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.InputTextBox)
        Me.Controls.Add(Me.OutputTextBox)
        Me.MaximumSize = New System.Drawing.Size(673, 600)
        Me.MinimumSize = New System.Drawing.Size(673, 600)
        Me.Name = "CMDConsole"
        Me.Text = "GUI DosBox - CMD Console"
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OutputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents lblCommande As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents chkbxLangue As System.Windows.Forms.CheckBox
End Class
