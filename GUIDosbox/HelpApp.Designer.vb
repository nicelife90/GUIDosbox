<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HelpApp))
        Me.chkbxLangue = New System.Windows.Forms.CheckBox()
        Me.lblAdvanceMode = New GUIDosbox.GUIDosboxLabel()
        Me.txtAdvanceCommand = New GUIDosbox.GUIDosboxTextbox()
        Me.myConsole = New GUIDosbox.GUIDosboxConsole()
        Me.optAdvanceMode = New GUIDosbox.GUIDosboxCheckbox()
        Me.btnAide = New GUIDosbox.GUIDosboxButton()
        Me.btnSend = New GUIDosbox.GUIDosboxButton()
        Me.btnBack = New GUIDosbox.GUIDosboxButton()
        Me.btnClaer = New GUIDosbox.GUIDosboxButton()
        Me.flashHeader = New AxShockwaveFlashObjects.AxShockwaveFlash()
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkbxLangue
        '
        Me.chkbxLangue.AutoSize = True
        Me.chkbxLangue.Checked = True
        Me.chkbxLangue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbxLangue.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.chkbxLangue.Location = New System.Drawing.Point(621, 12)
        Me.chkbxLangue.Name = "chkbxLangue"
        Me.chkbxLangue.Size = New System.Drawing.Size(15, 14)
        Me.chkbxLangue.TabIndex = 5
        Me.chkbxLangue.UseVisualStyleBackColor = True
        Me.chkbxLangue.Visible = False
        '
        'lblAdvanceMode
        '
        Me.lblAdvanceMode.AutoSize = True
        Me.lblAdvanceMode.BackColor = System.Drawing.Color.Transparent
        Me.lblAdvanceMode.Font = New System.Drawing.Font("Lucida Console", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblAdvanceMode.ForeColor = System.Drawing.Color.LightBlue
        Me.lblAdvanceMode.Location = New System.Drawing.Point(1, 476)
        Me.lblAdvanceMode.Name = "lblAdvanceMode"
        Me.lblAdvanceMode.Size = New System.Drawing.Size(157, 11)
        Me.lblAdvanceMode.TabIndex = 8
        Me.lblAdvanceMode.Text = "Ligne de commande :"
        '
        'txtAdvanceCommand
        '
        Me.txtAdvanceCommand.BackColor = System.Drawing.Color.Black
        Me.txtAdvanceCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdvanceCommand.Font = New System.Drawing.Font("Lucida Console", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtAdvanceCommand.ForeColor = System.Drawing.Color.LightBlue
        Me.txtAdvanceCommand.Location = New System.Drawing.Point(164, 474)
        Me.txtAdvanceCommand.Name = "txtAdvanceCommand"
        Me.txtAdvanceCommand.Size = New System.Drawing.Size(482, 18)
        Me.txtAdvanceCommand.TabIndex = 0
        '
        'myConsole
        '
        Me.myConsole.Location = New System.Drawing.Point(3, 40)
        Me.myConsole.myConsole = Nothing
        Me.myConsole.Name = "myConsole"
        Me.myConsole.Size = New System.Drawing.Size(643, 428)
        Me.myConsole.TabIndex = 6
        '
        'optAdvanceMode
        '
        Me.optAdvanceMode.AutoSize = True
        Me.optAdvanceMode.BackColor = System.Drawing.Color.Transparent
        Me.optAdvanceMode.Font = New System.Drawing.Font("Lucida Console", 8.0!, System.Drawing.FontStyle.Bold)
        Me.optAdvanceMode.ForeColor = System.Drawing.Color.LightBlue
        Me.optAdvanceMode.Location = New System.Drawing.Point(3, 507)
        Me.optAdvanceMode.Name = "optAdvanceMode"
        Me.optAdvanceMode.Size = New System.Drawing.Size(112, 15)
        Me.optAdvanceMode.TabIndex = 9
        Me.optAdvanceMode.Text = "Mode avancé"
        Me.optAdvanceMode.UseVisualStyleBackColor = False
        '
        'btnAide
        '
        Me.btnAide.BackColor = System.Drawing.Color.Black
        Me.btnAide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAide.Font = New System.Drawing.Font("Lucida Console", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnAide.ForeColor = System.Drawing.Color.LightBlue
        Me.btnAide.Location = New System.Drawing.Point(455, 498)
        Me.btnAide.Name = "btnAide"
        Me.btnAide.Size = New System.Drawing.Size(110, 23)
        Me.btnAide.TabIndex = 10
        Me.btnAide.Text = "Voir l'aide"
        Me.btnAide.UseVisualStyleBackColor = False
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.Black
        Me.btnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.Font = New System.Drawing.Font("Lucida Console", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnSend.ForeColor = System.Drawing.Color.LightBlue
        Me.btnSend.Location = New System.Drawing.Point(164, 498)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 11
        Me.btnSend.Text = "Envoyer"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Lucida Console", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.Color.LightBlue
        Me.btnBack.Location = New System.Drawing.Point(571, 498)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 12
        Me.btnBack.Text = "Retour"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnClaer
        '
        Me.btnClaer.BackColor = System.Drawing.Color.Black
        Me.btnClaer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClaer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnClaer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClaer.Font = New System.Drawing.Font("Lucida Console", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnClaer.ForeColor = System.Drawing.Color.LightBlue
        Me.btnClaer.Location = New System.Drawing.Point(245, 498)
        Me.btnClaer.Name = "btnClaer"
        Me.btnClaer.Size = New System.Drawing.Size(75, 23)
        Me.btnClaer.TabIndex = 13
        Me.btnClaer.Text = "Effacer"
        Me.btnClaer.UseVisualStyleBackColor = False
        '
        'flashHeader
        '
        Me.flashHeader.Enabled = True
        Me.flashHeader.Location = New System.Drawing.Point(-1, 0)
        Me.flashHeader.Name = "flashHeader"
        Me.flashHeader.OcxState = CType(resources.GetObject("flashHeader.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flashHeader.Size = New System.Drawing.Size(655, 40)
        Me.flashHeader.TabIndex = 14
        '
        'HelpApp
        '
        Me.AcceptButton = Me.btnSend
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowText
        Me.ClientSize = New System.Drawing.Size(648, 525)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkbxLangue)
        Me.Controls.Add(Me.flashHeader)
        Me.Controls.Add(Me.btnClaer)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.btnAide)
        Me.Controls.Add(Me.optAdvanceMode)
        Me.Controls.Add(Me.lblAdvanceMode)
        Me.Controls.Add(Me.txtAdvanceCommand)
        Me.Controls.Add(Me.myConsole)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Name = "HelpApp"
        Me.Text = "GUI DosBox - Aide"
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkbxLangue As System.Windows.Forms.CheckBox
    Friend WithEvents myConsole As GUIDosbox.GUIDosboxConsole
    Friend WithEvents txtAdvanceCommand As GUIDosbox.GUIDosboxTextbox
    Friend WithEvents lblAdvanceMode As GUIDosbox.GUIDosboxLabel
    Friend WithEvents optAdvanceMode As GUIDosbox.GUIDosboxCheckbox
    Friend WithEvents btnAide As GUIDosbox.GUIDosboxButton
    Friend WithEvents btnSend As GUIDosbox.GUIDosboxButton
    Friend WithEvents btnBack As GUIDosbox.GUIDosboxButton
    Friend WithEvents btnClaer As GUIDosbox.GUIDosboxButton
    Friend WithEvents flashHeader As AxShockwaveFlashObjects.AxShockwaveFlash
End Class
