<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SystemInfoApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SystemInfoApp))
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
        Me.OptS = New System.Windows.Forms.CheckBox()
        Me.OptU = New System.Windows.Forms.CheckBox()
        Me.OptP = New System.Windows.Forms.CheckBox()
        Me.OptFO = New System.Windows.Forms.CheckBox()
        Me.OptNH = New System.Windows.Forms.CheckBox()
        Me.txtOptS = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtOptU = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtOptP = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtOptFO = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.myConsole = New GUIDosbox.GUIDosboxConsole()
        Me.flashHeader = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
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
        Me.chkbxLangue.Location = New System.Drawing.Point(13, 416)
        Me.chkbxLangue.Name = "chkbxLangue"
        Me.chkbxLangue.Size = New System.Drawing.Size(15, 14)
        Me.chkbxLangue.TabIndex = 19
        Me.chkbxLangue.UseVisualStyleBackColor = True
        Me.chkbxLangue.Visible = False
        '
        'OptS
        '
        Me.OptS.AutoSize = True
        Me.OptS.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptS.Location = New System.Drawing.Point(6, 13)
        Me.OptS.Name = "OptS"
        Me.OptS.Size = New System.Drawing.Size(37, 19)
        Me.OptS.TabIndex = 20
        Me.OptS.Text = "/S"
        Me.OptS.UseVisualStyleBackColor = True
        '
        'OptU
        '
        Me.OptU.AutoSize = True
        Me.OptU.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptU.Location = New System.Drawing.Point(6, 10)
        Me.OptU.Name = "OptU"
        Me.OptU.Size = New System.Drawing.Size(37, 19)
        Me.OptU.TabIndex = 21
        Me.OptU.Text = "/U"
        Me.OptU.UseVisualStyleBackColor = True
        '
        'OptP
        '
        Me.OptP.AutoSize = True
        Me.OptP.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptP.Location = New System.Drawing.Point(6, 10)
        Me.OptP.Name = "OptP"
        Me.OptP.Size = New System.Drawing.Size(36, 19)
        Me.OptP.TabIndex = 22
        Me.OptP.Text = "/P"
        Me.OptP.UseVisualStyleBackColor = True
        '
        'OptFO
        '
        Me.OptFO.AutoSize = True
        Me.OptFO.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptFO.Location = New System.Drawing.Point(6, 10)
        Me.OptFO.Name = "OptFO"
        Me.OptFO.Size = New System.Drawing.Size(46, 19)
        Me.OptFO.TabIndex = 23
        Me.OptFO.Text = "/FO"
        Me.OptFO.UseVisualStyleBackColor = True
        '
        'OptNH
        '
        Me.OptNH.AutoSize = True
        Me.OptNH.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptNH.Location = New System.Drawing.Point(7, 13)
        Me.OptNH.Name = "OptNH"
        Me.OptNH.Size = New System.Drawing.Size(47, 19)
        Me.OptNH.TabIndex = 24
        Me.OptNH.Text = "/NH"
        Me.OptNH.UseVisualStyleBackColor = True
        '
        'txtOptS
        '
        Me.txtOptS.Location = New System.Drawing.Point(6, 36)
        Me.txtOptS.Name = "txtOptS"
        Me.txtOptS.Size = New System.Drawing.Size(100, 20)
        Me.txtOptS.TabIndex = 25
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OptS)
        Me.GroupBox1.Controls.Add(Me.txtOptS)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(121, 66)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtOptU)
        Me.GroupBox2.Controls.Add(Me.OptU)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 117)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(121, 62)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        '
        'txtOptU
        '
        Me.txtOptU.Location = New System.Drawing.Point(6, 33)
        Me.txtOptU.Name = "txtOptU"
        Me.txtOptU.Size = New System.Drawing.Size(100, 20)
        Me.txtOptU.TabIndex = 22
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtOptP)
        Me.GroupBox3.Controls.Add(Me.OptP)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 185)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(121, 62)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        '
        'txtOptP
        '
        Me.txtOptP.Location = New System.Drawing.Point(6, 33)
        Me.txtOptP.Name = "txtOptP"
        Me.txtOptP.Size = New System.Drawing.Size(100, 20)
        Me.txtOptP.TabIndex = 23
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtOptFO)
        Me.GroupBox4.Controls.Add(Me.OptFO)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 254)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(121, 62)
        Me.GroupBox4.TabIndex = 29
        Me.GroupBox4.TabStop = False
        '
        'txtOptFO
        '
        Me.txtOptFO.FormattingEnabled = True
        Me.txtOptFO.Items.AddRange(New Object() {"TABLE", "LIST", "CSV"})
        Me.txtOptFO.Location = New System.Drawing.Point(6, 35)
        Me.txtOptFO.Name = "txtOptFO"
        Me.txtOptFO.Size = New System.Drawing.Size(100, 21)
        Me.txtOptFO.TabIndex = 24
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.OptNH)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 322)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(62, 38)
        Me.GroupBox5.TabIndex = 30
        Me.GroupBox5.TabStop = False
        '
        'myConsole
        '
        Me.myConsole.Location = New System.Drawing.Point(129, 54)
        Me.myConsole.myConsole = Nothing
        Me.myConsole.Name = "myConsole"
        Me.myConsole.Size = New System.Drawing.Size(476, 394)
        Me.myConsole.TabIndex = 31
        '
        'flashHeader
        '
        Me.flashHeader.Enabled = True
        Me.flashHeader.Location = New System.Drawing.Point(0, 0)
        Me.flashHeader.Name = "flashHeader"
        Me.flashHeader.OcxState = CType(resources.GetObject("flashHeader.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flashHeader.Size = New System.Drawing.Size(620, 40)
        Me.flashHeader.TabIndex = 32
        '
        'SystemInfoApp
        '
        Me.AcceptButton = Me.btnEnvoi
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(617, 584)
        Me.ControlBox = False
        Me.Controls.Add(Me.flashHeader)
        Me.Controls.Add(Me.myConsole)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "SystemInfoApp"
        Me.Text = "GUI DosBox - SYSTEMINFO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
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
    Friend WithEvents OptS As System.Windows.Forms.CheckBox
    Friend WithEvents OptU As System.Windows.Forms.CheckBox
    Friend WithEvents OptP As System.Windows.Forms.CheckBox
    Friend WithEvents OptFO As System.Windows.Forms.CheckBox
    Friend WithEvents OptNH As System.Windows.Forms.CheckBox
    Friend WithEvents txtOptS As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOptU As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOptP As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOptFO As System.Windows.Forms.ComboBox
    Friend WithEvents myConsole As GUIDosbox.GUIDosboxConsole
    Friend WithEvents flashHeader As AxShockwaveFlashObjects.AxShockwaveFlash
End Class
