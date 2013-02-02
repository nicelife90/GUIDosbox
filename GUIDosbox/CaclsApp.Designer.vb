<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CaclsApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CaclsApp))
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
        Me.optT = New System.Windows.Forms.CheckBox()
        Me.optM = New System.Windows.Forms.CheckBox()
        Me.optL = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optC = New System.Windows.Forms.CheckBox()
        Me.optE = New System.Windows.Forms.CheckBox()
        Me.gbFile = New System.Windows.Forms.GroupBox()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.gbP = New System.Windows.Forms.GroupBox()
        Me.lblUtili = New System.Windows.Forms.Label()
        Me.gbPPermission = New System.Windows.Forms.GroupBox()
        Me.optPAucun = New System.Windows.Forms.CheckBox()
        Me.optPControlT = New System.Windows.Forms.CheckBox()
        Me.optPModif = New System.Windows.Forms.CheckBox()
        Me.optPEcrire = New System.Windows.Forms.CheckBox()
        Me.optPLecture = New System.Windows.Forms.CheckBox()
        Me.txtUserP = New System.Windows.Forms.TextBox()
        Me.optP = New System.Windows.Forms.CheckBox()
        Me.gbOptD = New System.Windows.Forms.GroupBox()
        Me.lblUtili4 = New System.Windows.Forms.Label()
        Me.txtUserD = New System.Windows.Forms.TextBox()
        Me.optD = New System.Windows.Forms.CheckBox()
        Me.gbG = New System.Windows.Forms.GroupBox()
        Me.lblutili2 = New System.Windows.Forms.Label()
        Me.optG = New System.Windows.Forms.CheckBox()
        Me.txtUserG = New System.Windows.Forms.TextBox()
        Me.gbGPermission = New System.Windows.Forms.GroupBox()
        Me.optGControlT = New System.Windows.Forms.CheckBox()
        Me.optGModif = New System.Windows.Forms.CheckBox()
        Me.optGEcrire = New System.Windows.Forms.CheckBox()
        Me.optGLecture = New System.Windows.Forms.CheckBox()
        Me.gbOptR = New System.Windows.Forms.GroupBox()
        Me.lblUtili3 = New System.Windows.Forms.Label()
        Me.txtUserR = New System.Windows.Forms.TextBox()
        Me.optR = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.myConsole = New GUIDosbox.GUIDosboxConsole()
        Me.flashHeader = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.GroupBox1.SuspendLayout()
        Me.gbFile.SuspendLayout()
        Me.gbP.SuspendLayout()
        Me.gbPPermission.SuspendLayout()
        Me.gbOptD.SuspendLayout()
        Me.gbG.SuspendLayout()
        Me.gbGPermission.SuspendLayout()
        Me.gbOptR.SuspendLayout()
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(12, 556)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(75, 23)
        Me.btnHelp.TabIndex = 6
        Me.btnHelp.Text = "Aide"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(534, 556)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 7
        Me.btnApply.Text = "Appliquer"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(615, 556)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "Retour"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(615, 527)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'OptADV
        '
        Me.OptADV.AutoSize = True
        Me.OptADV.Location = New System.Drawing.Point(598, 504)
        Me.OptADV.Name = "OptADV"
        Me.OptADV.Size = New System.Drawing.Size(92, 17)
        Me.OptADV.TabIndex = 10
        Me.OptADV.Text = "Mode avancé"
        Me.OptADV.UseVisualStyleBackColor = True
        '
        'CommandReturn
        '
        Me.CommandReturn.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommandReturn.Location = New System.Drawing.Point(214, 478)
        Me.CommandReturn.Name = "CommandReturn"
        Me.CommandReturn.Size = New System.Drawing.Size(476, 21)
        Me.CommandReturn.TabIndex = 13
        '
        'ADVCommand
        '
        Me.ADVCommand.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADVCommand.Location = New System.Drawing.Point(214, 457)
        Me.ADVCommand.Name = "ADVCommand"
        Me.ADVCommand.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ADVCommand.Size = New System.Drawing.Size(476, 21)
        Me.ADVCommand.TabIndex = 14
        '
        'btnEnvoi
        '
        Me.btnEnvoi.Location = New System.Drawing.Point(400, 504)
        Me.btnEnvoi.Name = "btnEnvoi"
        Me.btnEnvoi.Size = New System.Drawing.Size(75, 23)
        Me.btnEnvoi.TabIndex = 0
        Me.btnEnvoi.Text = "Envoi"
        Me.btnEnvoi.UseVisualStyleBackColor = True
        '
        'lblLigneCommande
        '
        Me.lblLigneCommande.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLigneCommande.Location = New System.Drawing.Point(90, 463)
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
        Me.lblCommandeExec.Location = New System.Drawing.Point(88, 484)
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
        Me.chkbxLangue.Location = New System.Drawing.Point(17, 527)
        Me.chkbxLangue.Name = "chkbxLangue"
        Me.chkbxLangue.Size = New System.Drawing.Size(15, 14)
        Me.chkbxLangue.TabIndex = 19
        Me.chkbxLangue.UseVisualStyleBackColor = True
        Me.chkbxLangue.Visible = False
        '
        'optT
        '
        Me.optT.AutoSize = True
        Me.optT.Location = New System.Drawing.Point(7, 16)
        Me.optT.Name = "optT"
        Me.optT.Size = New System.Drawing.Size(41, 17)
        Me.optT.TabIndex = 21
        Me.optT.Text = "/ T"
        Me.optT.UseVisualStyleBackColor = True
        '
        'optM
        '
        Me.optM.AutoSize = True
        Me.optM.Location = New System.Drawing.Point(7, 33)
        Me.optM.Name = "optM"
        Me.optM.Size = New System.Drawing.Size(43, 17)
        Me.optM.TabIndex = 22
        Me.optM.Text = "/ M"
        Me.optM.UseVisualStyleBackColor = True
        '
        'optL
        '
        Me.optL.AutoSize = True
        Me.optL.Location = New System.Drawing.Point(7, 50)
        Me.optL.Name = "optL"
        Me.optL.Size = New System.Drawing.Size(40, 17)
        Me.optL.TabIndex = 23
        Me.optL.Text = "/ L"
        Me.optL.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optC)
        Me.GroupBox1.Controls.Add(Me.optE)
        Me.GroupBox1.Controls.Add(Me.optT)
        Me.GroupBox1.Controls.Add(Me.optL)
        Me.GroupBox1.Controls.Add(Me.optM)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(92, 72)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        '
        'optC
        '
        Me.optC.AutoSize = True
        Me.optC.Location = New System.Drawing.Point(46, 33)
        Me.optC.Name = "optC"
        Me.optC.Size = New System.Drawing.Size(41, 17)
        Me.optC.TabIndex = 25
        Me.optC.Text = "/ C"
        Me.optC.UseVisualStyleBackColor = True
        '
        'optE
        '
        Me.optE.AutoSize = True
        Me.optE.Location = New System.Drawing.Point(46, 16)
        Me.optE.Name = "optE"
        Me.optE.Size = New System.Drawing.Size(41, 17)
        Me.optE.TabIndex = 24
        Me.optE.Text = "/ E"
        Me.optE.UseVisualStyleBackColor = True
        '
        'gbFile
        '
        Me.gbFile.Controls.Add(Me.btnOpenFile)
        Me.gbFile.Controls.Add(Me.txtFile)
        Me.gbFile.Location = New System.Drawing.Point(387, 46)
        Me.gbFile.Name = "gbFile"
        Me.gbFile.Size = New System.Drawing.Size(303, 72)
        Me.gbFile.TabIndex = 25
        Me.gbFile.TabStop = False
        Me.gbFile.Text = " Fichier "
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(6, 17)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(91, 21)
        Me.btnOpenFile.TabIndex = 2
        Me.btnOpenFile.Text = "Parcourir"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(6, 43)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(291, 20)
        Me.txtFile.TabIndex = 0
        '
        'gbP
        '
        Me.gbP.Controls.Add(Me.lblUtili)
        Me.gbP.Controls.Add(Me.gbPPermission)
        Me.gbP.Controls.Add(Me.txtUserP)
        Me.gbP.Controls.Add(Me.optP)
        Me.gbP.Location = New System.Drawing.Point(6, 124)
        Me.gbP.Name = "gbP"
        Me.gbP.Size = New System.Drawing.Size(204, 141)
        Me.gbP.TabIndex = 26
        Me.gbP.TabStop = False
        Me.gbP.Text = " Option /G "
        '
        'lblUtili
        '
        Me.lblUtili.AutoSize = True
        Me.lblUtili.Location = New System.Drawing.Point(8, 16)
        Me.lblUtili.Name = "lblUtili"
        Me.lblUtili.Size = New System.Drawing.Size(56, 13)
        Me.lblUtili.TabIndex = 3
        Me.lblUtili.Text = "Utilisateur:"
        '
        'gbPPermission
        '
        Me.gbPPermission.Controls.Add(Me.optPAucun)
        Me.gbPPermission.Controls.Add(Me.optPControlT)
        Me.gbPPermission.Controls.Add(Me.optPModif)
        Me.gbPPermission.Controls.Add(Me.optPEcrire)
        Me.gbPPermission.Controls.Add(Me.optPLecture)
        Me.gbPPermission.Location = New System.Drawing.Point(6, 58)
        Me.gbPPermission.Name = "gbPPermission"
        Me.gbPPermission.Size = New System.Drawing.Size(191, 76)
        Me.gbPPermission.TabIndex = 2
        Me.gbPPermission.TabStop = False
        Me.gbPPermission.Text = "Permission"
        '
        'optPAucun
        '
        Me.optPAucun.AutoSize = True
        Me.optPAucun.Location = New System.Drawing.Point(5, 54)
        Me.optPAucun.Name = "optPAucun"
        Me.optPAucun.Size = New System.Drawing.Size(74, 17)
        Me.optPAucun.TabIndex = 4
        Me.optPAucun.Text = "Aucun (N)"
        Me.optPAucun.UseVisualStyleBackColor = True
        '
        'optPControlT
        '
        Me.optPControlT.AutoSize = True
        Me.optPControlT.Location = New System.Drawing.Point(86, 37)
        Me.optPControlT.Name = "optPControlT"
        Me.optPControlT.Size = New System.Drawing.Size(101, 17)
        Me.optPControlT.TabIndex = 3
        Me.optPControlT.Text = "Control Total (F)"
        Me.optPControlT.UseVisualStyleBackColor = True
        '
        'optPModif
        '
        Me.optPModif.AutoSize = True
        Me.optPModif.Location = New System.Drawing.Point(86, 20)
        Me.optPModif.Name = "optPModif"
        Me.optPModif.Size = New System.Drawing.Size(99, 17)
        Me.optPModif.TabIndex = 2
        Me.optPModif.Text = "Modification (C)"
        Me.optPModif.UseVisualStyleBackColor = True
        '
        'optPEcrire
        '
        Me.optPEcrire.AutoSize = True
        Me.optPEcrire.Location = New System.Drawing.Point(5, 37)
        Me.optPEcrire.Name = "optPEcrire"
        Me.optPEcrire.Size = New System.Drawing.Size(82, 17)
        Me.optPEcrire.TabIndex = 1
        Me.optPEcrire.Text = "Écriture (W)"
        Me.optPEcrire.UseVisualStyleBackColor = True
        '
        'optPLecture
        '
        Me.optPLecture.AutoSize = True
        Me.optPLecture.Location = New System.Drawing.Point(5, 20)
        Me.optPLecture.Name = "optPLecture"
        Me.optPLecture.Size = New System.Drawing.Size(79, 17)
        Me.optPLecture.TabIndex = 0
        Me.optPLecture.Text = "Lecture (R)"
        Me.optPLecture.UseVisualStyleBackColor = True
        '
        'txtUserP
        '
        Me.txtUserP.Location = New System.Drawing.Point(11, 32)
        Me.txtUserP.Name = "txtUserP"
        Me.txtUserP.Size = New System.Drawing.Size(186, 20)
        Me.txtUserP.TabIndex = 1
        '
        'optP
        '
        Me.optP.AutoSize = True
        Me.optP.Location = New System.Drawing.Point(156, 12)
        Me.optP.Name = "optP"
        Me.optP.Size = New System.Drawing.Size(41, 17)
        Me.optP.TabIndex = 0
        Me.optP.Text = "/ P"
        Me.optP.UseVisualStyleBackColor = True
        '
        'gbOptD
        '
        Me.gbOptD.Controls.Add(Me.lblUtili4)
        Me.gbOptD.Controls.Add(Me.txtUserD)
        Me.gbOptD.Controls.Add(Me.optD)
        Me.gbOptD.Location = New System.Drawing.Point(240, 46)
        Me.gbOptD.Name = "gbOptD"
        Me.gbOptD.Size = New System.Drawing.Size(141, 71)
        Me.gbOptD.TabIndex = 27
        Me.gbOptD.TabStop = False
        Me.gbOptD.Text = "Option /D"
        '
        'lblUtili4
        '
        Me.lblUtili4.AutoSize = True
        Me.lblUtili4.Location = New System.Drawing.Point(6, 20)
        Me.lblUtili4.Name = "lblUtili4"
        Me.lblUtili4.Size = New System.Drawing.Size(56, 13)
        Me.lblUtili4.TabIndex = 2
        Me.lblUtili4.Text = "Utilisateur:"
        '
        'txtUserD
        '
        Me.txtUserD.Location = New System.Drawing.Point(4, 41)
        Me.txtUserD.Name = "txtUserD"
        Me.txtUserD.Size = New System.Drawing.Size(131, 20)
        Me.txtUserD.TabIndex = 1
        '
        'optD
        '
        Me.optD.AutoSize = True
        Me.optD.Location = New System.Drawing.Point(93, 18)
        Me.optD.Name = "optD"
        Me.optD.Size = New System.Drawing.Size(42, 17)
        Me.optD.TabIndex = 0
        Me.optD.Text = "/ D"
        Me.optD.UseVisualStyleBackColor = True
        '
        'gbG
        '
        Me.gbG.Controls.Add(Me.lblutili2)
        Me.gbG.Controls.Add(Me.optG)
        Me.gbG.Controls.Add(Me.txtUserG)
        Me.gbG.Controls.Add(Me.gbGPermission)
        Me.gbG.Location = New System.Drawing.Point(6, 271)
        Me.gbG.Name = "gbG"
        Me.gbG.Size = New System.Drawing.Size(204, 129)
        Me.gbG.TabIndex = 28
        Me.gbG.TabStop = False
        Me.gbG.Text = " Option / G "
        '
        'lblutili2
        '
        Me.lblutili2.AutoSize = True
        Me.lblutili2.Location = New System.Drawing.Point(6, 16)
        Me.lblutili2.Name = "lblutili2"
        Me.lblutili2.Size = New System.Drawing.Size(56, 13)
        Me.lblutili2.TabIndex = 3
        Me.lblutili2.Text = "Utilisateur:"
        '
        'optG
        '
        Me.optG.AutoSize = True
        Me.optG.Location = New System.Drawing.Point(157, 12)
        Me.optG.Name = "optG"
        Me.optG.Size = New System.Drawing.Size(42, 17)
        Me.optG.TabIndex = 2
        Me.optG.Text = "/ G"
        Me.optG.UseVisualStyleBackColor = True
        '
        'txtUserG
        '
        Me.txtUserG.Location = New System.Drawing.Point(6, 32)
        Me.txtUserG.Name = "txtUserG"
        Me.txtUserG.Size = New System.Drawing.Size(187, 20)
        Me.txtUserG.TabIndex = 1
        '
        'gbGPermission
        '
        Me.gbGPermission.Controls.Add(Me.optGControlT)
        Me.gbGPermission.Controls.Add(Me.optGModif)
        Me.gbGPermission.Controls.Add(Me.optGEcrire)
        Me.gbGPermission.Controls.Add(Me.optGLecture)
        Me.gbGPermission.Location = New System.Drawing.Point(6, 55)
        Me.gbGPermission.Name = "gbGPermission"
        Me.gbGPermission.Size = New System.Drawing.Size(191, 66)
        Me.gbGPermission.TabIndex = 0
        Me.gbGPermission.TabStop = False
        Me.gbGPermission.Text = "Permission"
        '
        'optGControlT
        '
        Me.optGControlT.AutoSize = True
        Me.optGControlT.Location = New System.Drawing.Point(88, 43)
        Me.optGControlT.Name = "optGControlT"
        Me.optGControlT.Size = New System.Drawing.Size(101, 17)
        Me.optGControlT.TabIndex = 3
        Me.optGControlT.Text = "Control Total (F)"
        Me.optGControlT.UseVisualStyleBackColor = True
        '
        'optGModif
        '
        Me.optGModif.AutoSize = True
        Me.optGModif.Location = New System.Drawing.Point(88, 20)
        Me.optGModif.Name = "optGModif"
        Me.optGModif.Size = New System.Drawing.Size(99, 17)
        Me.optGModif.TabIndex = 2
        Me.optGModif.Text = "Modification (C)"
        Me.optGModif.UseVisualStyleBackColor = True
        '
        'optGEcrire
        '
        Me.optGEcrire.AutoSize = True
        Me.optGEcrire.Location = New System.Drawing.Point(7, 43)
        Me.optGEcrire.Name = "optGEcrire"
        Me.optGEcrire.Size = New System.Drawing.Size(82, 17)
        Me.optGEcrire.TabIndex = 1
        Me.optGEcrire.Text = "Écriture (W)"
        Me.optGEcrire.UseVisualStyleBackColor = True
        '
        'optGLecture
        '
        Me.optGLecture.AutoSize = True
        Me.optGLecture.Location = New System.Drawing.Point(7, 20)
        Me.optGLecture.Name = "optGLecture"
        Me.optGLecture.Size = New System.Drawing.Size(79, 17)
        Me.optGLecture.TabIndex = 0
        Me.optGLecture.Text = "Lecture (R)"
        Me.optGLecture.UseVisualStyleBackColor = True
        '
        'gbOptR
        '
        Me.gbOptR.Controls.Add(Me.lblUtili3)
        Me.gbOptR.Controls.Add(Me.txtUserR)
        Me.gbOptR.Controls.Add(Me.optR)
        Me.gbOptR.Location = New System.Drawing.Point(104, 45)
        Me.gbOptR.Name = "gbOptR"
        Me.gbOptR.Size = New System.Drawing.Size(130, 72)
        Me.gbOptR.TabIndex = 29
        Me.gbOptR.TabStop = False
        Me.gbOptR.Text = "Option /R"
        '
        'lblUtili3
        '
        Me.lblUtili3.AutoSize = True
        Me.lblUtili3.Location = New System.Drawing.Point(6, 21)
        Me.lblUtili3.Name = "lblUtili3"
        Me.lblUtili3.Size = New System.Drawing.Size(56, 13)
        Me.lblUtili3.TabIndex = 2
        Me.lblUtili3.Text = "Utilisateur:"
        '
        'txtUserR
        '
        Me.txtUserR.Location = New System.Drawing.Point(6, 42)
        Me.txtUserR.Name = "txtUserR"
        Me.txtUserR.Size = New System.Drawing.Size(117, 20)
        Me.txtUserR.TabIndex = 1
        '
        'optR
        '
        Me.optR.AutoSize = True
        Me.optR.Location = New System.Drawing.Point(81, 20)
        Me.optR.Name = "optR"
        Me.optR.Size = New System.Drawing.Size(42, 17)
        Me.optR.TabIndex = 0
        Me.optR.Text = "/ R"
        Me.optR.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'myConsole
        '
        Me.myConsole.Location = New System.Drawing.Point(214, 124)
        Me.myConsole.myConsole = Nothing
        Me.myConsole.Name = "myConsole"
        Me.myConsole.Size = New System.Drawing.Size(476, 327)
        Me.myConsole.TabIndex = 31
        '
        'flashHeader
        '
        Me.flashHeader.Enabled = True
        Me.flashHeader.Location = New System.Drawing.Point(1, 0)
        Me.flashHeader.Name = "flashHeader"
        Me.flashHeader.OcxState = CType(resources.GetObject("flashHeader.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flashHeader.Size = New System.Drawing.Size(700, 40)
        Me.flashHeader.TabIndex = 32
        '
        'CaclsApp
        '
        Me.AcceptButton = Me.btnEnvoi
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(698, 589)
        Me.ControlBox = False
        Me.Controls.Add(Me.flashHeader)
        Me.Controls.Add(Me.myConsole)
        Me.Controls.Add(Me.gbOptR)
        Me.Controls.Add(Me.gbG)
        Me.Controls.Add(Me.gbOptD)
        Me.Controls.Add(Me.gbP)
        Me.Controls.Add(Me.gbFile)
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
        Me.Name = "CaclsApp"
        Me.Text = "GUI DosBox - CACLS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbFile.ResumeLayout(False)
        Me.gbFile.PerformLayout()
        Me.gbP.ResumeLayout(False)
        Me.gbP.PerformLayout()
        Me.gbPPermission.ResumeLayout(False)
        Me.gbPPermission.PerformLayout()
        Me.gbOptD.ResumeLayout(False)
        Me.gbOptD.PerformLayout()
        Me.gbG.ResumeLayout(False)
        Me.gbG.PerformLayout()
        Me.gbGPermission.ResumeLayout(False)
        Me.gbGPermission.PerformLayout()
        Me.gbOptR.ResumeLayout(False)
        Me.gbOptR.PerformLayout()
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
    Friend WithEvents optT As System.Windows.Forms.CheckBox
    Friend WithEvents optM As System.Windows.Forms.CheckBox
    Friend WithEvents optL As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optC As System.Windows.Forms.CheckBox
    Friend WithEvents optE As System.Windows.Forms.CheckBox
    Friend WithEvents gbFile As System.Windows.Forms.GroupBox
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents gbP As System.Windows.Forms.GroupBox
    Friend WithEvents txtUserP As System.Windows.Forms.TextBox
    Friend WithEvents optP As System.Windows.Forms.CheckBox
    Friend WithEvents gbPPermission As System.Windows.Forms.GroupBox
    Friend WithEvents optPControlT As System.Windows.Forms.CheckBox
    Friend WithEvents optPModif As System.Windows.Forms.CheckBox
    Friend WithEvents optPEcrire As System.Windows.Forms.CheckBox
    Friend WithEvents optPLecture As System.Windows.Forms.CheckBox
    Friend WithEvents gbOptD As System.Windows.Forms.GroupBox
    Friend WithEvents txtUserD As System.Windows.Forms.TextBox
    Friend WithEvents optD As System.Windows.Forms.CheckBox
    Friend WithEvents gbG As System.Windows.Forms.GroupBox
    Friend WithEvents optG As System.Windows.Forms.CheckBox
    Friend WithEvents txtUserG As System.Windows.Forms.TextBox
    Friend WithEvents gbGPermission As System.Windows.Forms.GroupBox
    Friend WithEvents optGControlT As System.Windows.Forms.CheckBox
    Friend WithEvents optGModif As System.Windows.Forms.CheckBox
    Friend WithEvents optGEcrire As System.Windows.Forms.CheckBox
    Friend WithEvents optGLecture As System.Windows.Forms.CheckBox
    Friend WithEvents gbOptR As System.Windows.Forms.GroupBox
    Friend WithEvents txtUserR As System.Windows.Forms.TextBox
    Friend WithEvents optR As System.Windows.Forms.CheckBox
    Friend WithEvents lblutili2 As System.Windows.Forms.Label
    Friend WithEvents lblUtili As System.Windows.Forms.Label
    Friend WithEvents optPAucun As System.Windows.Forms.CheckBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnOpenFile As System.Windows.Forms.Button
    Friend WithEvents lblUtili3 As System.Windows.Forms.Label
    Friend WithEvents lblUtili4 As System.Windows.Forms.Label
    Friend WithEvents myConsole As GUIDosbox.GUIDosboxConsole
    Friend WithEvents flashHeader As AxShockwaveFlashObjects.AxShockwaveFlash
End Class
