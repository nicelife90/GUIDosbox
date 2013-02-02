<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XCopyApp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XCopyApp))
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OptM = New System.Windows.Forms.RadioButton()
        Me.OptA = New System.Windows.Forms.RadioButton()
        Me.invOptY = New System.Windows.Forms.RadioButton()
        Me.OptY = New System.Windows.Forms.RadioButton()
        Me.OptS = New System.Windows.Forms.RadioButton()
        Me.PathSource = New System.Windows.Forms.TextBox()
        Me.PathDestination = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GBDate = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateSelected = New System.Windows.Forms.TextBox()
        Me.OptD = New System.Windows.Forms.CheckBox()
        Me.btnFichier = New System.Windows.Forms.Button()
        Me.btnDossierSource = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.OptE = New System.Windows.Forms.RadioButton()
        Me.GBPrompt = New System.Windows.Forms.GroupBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnDossierDest = New System.Windows.Forms.Button()
        Me.TextReturns = New System.Windows.Forms.TextBox()
        Me.OptK = New System.Windows.Forms.CheckBox()
        Me.OptX = New System.Windows.Forms.CheckBox()
        Me.OptO = New System.Windows.Forms.CheckBox()
        Me.OptT = New System.Windows.Forms.CheckBox()
        Me.OptU = New System.Windows.Forms.CheckBox()
        Me.OptN = New System.Windows.Forms.CheckBox()
        Me.OptJ = New System.Windows.Forms.CheckBox()
        Me.OptR = New System.Windows.Forms.CheckBox()
        Me.OptH = New System.Windows.Forms.CheckBox()
        Me.OptG = New System.Windows.Forms.CheckBox()
        Me.OptI = New System.Windows.Forms.CheckBox()
        Me.OptC = New System.Windows.Forms.CheckBox()
        Me.OptV = New System.Windows.Forms.CheckBox()
        Me.GBRecomande = New System.Windows.Forms.GroupBox()
        Me.Options = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.lblResultatCmd = New System.Windows.Forms.Label()
        Me.CommandReturn = New System.Windows.Forms.TextBox()
        Me.lblCommande = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.chkbxLangue = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GBDate.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GBPrompt.SuspendLayout()
        Me.GBRecomande.SuspendLayout()
        Me.Options.SuspendLayout()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(424, 438)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 0
        Me.btnApply.Text = "Appliquer"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(505, 438)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Retour"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OptM)
        Me.GroupBox1.Controls.Add(Me.OptA)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(50, 49)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'OptM
        '
        Me.OptM.AutoSize = True
        Me.OptM.Location = New System.Drawing.Point(6, 27)
        Me.OptM.Name = "OptM"
        Me.OptM.Size = New System.Drawing.Size(39, 17)
        Me.OptM.TabIndex = 1
        Me.OptM.TabStop = True
        Me.OptM.Text = "/M"
        Me.OptM.UseVisualStyleBackColor = True
        '
        'OptA
        '
        Me.OptA.AutoSize = True
        Me.OptA.Location = New System.Drawing.Point(6, 10)
        Me.OptA.Name = "OptA"
        Me.OptA.Size = New System.Drawing.Size(37, 17)
        Me.OptA.TabIndex = 0
        Me.OptA.TabStop = True
        Me.OptA.Text = "/A"
        Me.OptA.UseVisualStyleBackColor = True
        '
        'invOptY
        '
        Me.invOptY.AutoSize = True
        Me.invOptY.Location = New System.Drawing.Point(5, 18)
        Me.invOptY.Name = "invOptY"
        Me.invOptY.Size = New System.Drawing.Size(40, 17)
        Me.invOptY.TabIndex = 17
        Me.invOptY.TabStop = True
        Me.invOptY.Text = "/-Y"
        Me.invOptY.UseVisualStyleBackColor = True
        '
        'OptY
        '
        Me.OptY.AutoSize = True
        Me.OptY.Location = New System.Drawing.Point(5, 40)
        Me.OptY.Name = "OptY"
        Me.OptY.Size = New System.Drawing.Size(37, 17)
        Me.OptY.TabIndex = 16
        Me.OptY.TabStop = True
        Me.OptY.Text = "/Y"
        Me.OptY.UseVisualStyleBackColor = True
        '
        'OptS
        '
        Me.OptS.AutoSize = True
        Me.OptS.Location = New System.Drawing.Point(6, 9)
        Me.OptS.Name = "OptS"
        Me.OptS.Size = New System.Drawing.Size(40, 17)
        Me.OptS.TabIndex = 3
        Me.OptS.TabStop = True
        Me.OptS.Text = "/ S"
        Me.OptS.UseVisualStyleBackColor = True
        '
        'PathSource
        '
        Me.PathSource.Location = New System.Drawing.Point(267, 49)
        Me.PathSource.Name = "PathSource"
        Me.PathSource.Size = New System.Drawing.Size(313, 20)
        Me.PathSource.TabIndex = 3
        '
        'PathDestination
        '
        Me.PathDestination.Location = New System.Drawing.Point(267, 75)
        Me.PathDestination.Name = "PathDestination"
        Me.PathDestination.Size = New System.Drawing.Size(313, 20)
        Me.PathDestination.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(113, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Destination :"
        '
        'GBDate
        '
        Me.GBDate.Controls.Add(Me.Label5)
        Me.GBDate.Controls.Add(Me.DateSelected)
        Me.GBDate.Controls.Add(Me.OptD)
        Me.GBDate.Location = New System.Drawing.Point(6, 342)
        Me.GBDate.Name = "GBDate"
        Me.GBDate.Size = New System.Drawing.Size(174, 65)
        Me.GBDate.TabIndex = 7
        Me.GBDate.TabStop = False
        Me.GBDate.Text = "Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Format: j-m-a  Ex: 02-05-11"
        '
        'DateSelected
        '
        Me.DateSelected.Location = New System.Drawing.Point(6, 41)
        Me.DateSelected.Name = "DateSelected"
        Me.DateSelected.Size = New System.Drawing.Size(158, 20)
        Me.DateSelected.TabIndex = 3
        '
        'OptD
        '
        Me.OptD.AutoSize = True
        Me.OptD.Location = New System.Drawing.Point(7, 19)
        Me.OptD.Name = "OptD"
        Me.OptD.Size = New System.Drawing.Size(39, 17)
        Me.OptD.TabIndex = 2
        Me.OptD.Text = "/D"
        Me.OptD.UseVisualStyleBackColor = True
        '
        'btnFichier
        '
        Me.btnFichier.Location = New System.Drawing.Point(106, 47)
        Me.btnFichier.Name = "btnFichier"
        Me.btnFichier.Size = New System.Drawing.Size(75, 23)
        Me.btnFichier.TabIndex = 9
        Me.btnFichier.Text = "Fichier"
        Me.btnFichier.UseVisualStyleBackColor = True
        '
        'btnDossierSource
        '
        Me.btnDossierSource.Location = New System.Drawing.Point(186, 47)
        Me.btnDossierSource.Name = "btnDossierSource"
        Me.btnDossierSource.Size = New System.Drawing.Size(75, 23)
        Me.btnDossierSource.TabIndex = 10
        Me.btnDossierSource.Text = "Dossier"
        Me.btnDossierSource.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.OptE)
        Me.GroupBox4.Controls.Add(Me.OptS)
        Me.GroupBox4.Location = New System.Drawing.Point(68, 13)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(49, 46)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        '
        'OptE
        '
        Me.OptE.AutoSize = True
        Me.OptE.Location = New System.Drawing.Point(6, 24)
        Me.OptE.Name = "OptE"
        Me.OptE.Size = New System.Drawing.Size(40, 17)
        Me.OptE.TabIndex = 4
        Me.OptE.TabStop = True
        Me.OptE.Text = "/ E"
        Me.OptE.UseVisualStyleBackColor = True
        '
        'GBPrompt
        '
        Me.GBPrompt.Controls.Add(Me.OptY)
        Me.GBPrompt.Controls.Add(Me.invOptY)
        Me.GBPrompt.Location = New System.Drawing.Point(10, 13)
        Me.GBPrompt.Name = "GBPrompt"
        Me.GBPrompt.Size = New System.Drawing.Size(56, 63)
        Me.GBPrompt.TabIndex = 20
        Me.GBPrompt.TabStop = False
        Me.GBPrompt.Text = "Prompt"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnDossierDest
        '
        Me.btnDossierDest.Location = New System.Drawing.Point(186, 75)
        Me.btnDossierDest.Name = "btnDossierDest"
        Me.btnDossierDest.Size = New System.Drawing.Size(75, 23)
        Me.btnDossierDest.TabIndex = 24
        Me.btnDossierDest.Text = "Dossier"
        Me.btnDossierDest.UseVisualStyleBackColor = True
        '
        'TextReturns
        '
        Me.TextReturns.BackColor = System.Drawing.SystemColors.WindowText
        Me.TextReturns.ForeColor = System.Drawing.SystemColors.Window
        Me.TextReturns.Location = New System.Drawing.Point(186, 120)
        Me.TextReturns.Multiline = True
        Me.TextReturns.Name = "TextReturns"
        Me.TextReturns.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextReturns.Size = New System.Drawing.Size(394, 288)
        Me.TextReturns.TabIndex = 25
        '
        'OptK
        '
        Me.OptK.AutoSize = True
        Me.OptK.Location = New System.Drawing.Point(10, 39)
        Me.OptK.Name = "OptK"
        Me.OptK.Size = New System.Drawing.Size(38, 17)
        Me.OptK.TabIndex = 26
        Me.OptK.Text = "/K"
        Me.OptK.UseVisualStyleBackColor = True
        '
        'OptX
        '
        Me.OptX.AutoSize = True
        Me.OptX.Location = New System.Drawing.Point(124, 81)
        Me.OptX.Name = "OptX"
        Me.OptX.Size = New System.Drawing.Size(38, 17)
        Me.OptX.TabIndex = 27
        Me.OptX.Text = "/X"
        Me.OptX.UseVisualStyleBackColor = True
        '
        'OptO
        '
        Me.OptO.AutoSize = True
        Me.OptO.Location = New System.Drawing.Point(87, 39)
        Me.OptO.Name = "OptO"
        Me.OptO.Size = New System.Drawing.Size(39, 17)
        Me.OptO.TabIndex = 28
        Me.OptO.Text = "/O"
        Me.OptO.UseVisualStyleBackColor = True
        '
        'OptT
        '
        Me.OptT.AutoSize = True
        Me.OptT.Location = New System.Drawing.Point(86, 60)
        Me.OptT.Name = "OptT"
        Me.OptT.Size = New System.Drawing.Size(38, 17)
        Me.OptT.TabIndex = 29
        Me.OptT.Text = "/T"
        Me.OptT.UseVisualStyleBackColor = True
        '
        'OptU
        '
        Me.OptU.AutoSize = True
        Me.OptU.Location = New System.Drawing.Point(123, 59)
        Me.OptU.Name = "OptU"
        Me.OptU.Size = New System.Drawing.Size(39, 17)
        Me.OptU.TabIndex = 30
        Me.OptU.Text = "/U"
        Me.OptU.UseVisualStyleBackColor = True
        '
        'OptN
        '
        Me.OptN.AutoSize = True
        Me.OptN.Location = New System.Drawing.Point(49, 37)
        Me.OptN.Name = "OptN"
        Me.OptN.Size = New System.Drawing.Size(39, 17)
        Me.OptN.TabIndex = 31
        Me.OptN.Text = "/N"
        Me.OptN.UseVisualStyleBackColor = True
        '
        'OptJ
        '
        Me.OptJ.AutoSize = True
        Me.OptJ.Location = New System.Drawing.Point(124, 16)
        Me.OptJ.Name = "OptJ"
        Me.OptJ.Size = New System.Drawing.Size(36, 17)
        Me.OptJ.TabIndex = 32
        Me.OptJ.Text = "/J"
        Me.OptJ.UseVisualStyleBackColor = True
        '
        'OptR
        '
        Me.OptR.AutoSize = True
        Me.OptR.Location = New System.Drawing.Point(123, 37)
        Me.OptR.Name = "OptR"
        Me.OptR.Size = New System.Drawing.Size(39, 17)
        Me.OptR.TabIndex = 33
        Me.OptR.Text = "/R"
        Me.OptR.UseVisualStyleBackColor = True
        '
        'OptH
        '
        Me.OptH.AutoSize = True
        Me.OptH.Location = New System.Drawing.Point(49, 16)
        Me.OptH.Name = "OptH"
        Me.OptH.Size = New System.Drawing.Size(39, 17)
        Me.OptH.TabIndex = 34
        Me.OptH.Text = "/H"
        Me.OptH.UseVisualStyleBackColor = True
        '
        'OptG
        '
        Me.OptG.AutoSize = True
        Me.OptG.Location = New System.Drawing.Point(10, 16)
        Me.OptG.Name = "OptG"
        Me.OptG.Size = New System.Drawing.Size(39, 17)
        Me.OptG.TabIndex = 35
        Me.OptG.Text = "/G"
        Me.OptG.UseVisualStyleBackColor = True
        '
        'OptI
        '
        Me.OptI.AutoSize = True
        Me.OptI.Location = New System.Drawing.Point(88, 16)
        Me.OptI.Name = "OptI"
        Me.OptI.Size = New System.Drawing.Size(34, 17)
        Me.OptI.TabIndex = 36
        Me.OptI.Text = "/I"
        Me.OptI.UseVisualStyleBackColor = True
        '
        'OptC
        '
        Me.OptC.AutoSize = True
        Me.OptC.Location = New System.Drawing.Point(71, 62)
        Me.OptC.Name = "OptC"
        Me.OptC.Size = New System.Drawing.Size(41, 17)
        Me.OptC.TabIndex = 37
        Me.OptC.Text = "/ C"
        Me.OptC.UseVisualStyleBackColor = True
        '
        'OptV
        '
        Me.OptV.AutoSize = True
        Me.OptV.Location = New System.Drawing.Point(86, 81)
        Me.OptV.Name = "OptV"
        Me.OptV.Size = New System.Drawing.Size(38, 17)
        Me.OptV.TabIndex = 38
        Me.OptV.Text = "/V"
        Me.OptV.UseVisualStyleBackColor = True
        '
        'GBRecomande
        '
        Me.GBRecomande.Controls.Add(Me.OptC)
        Me.GBRecomande.Controls.Add(Me.GBPrompt)
        Me.GBRecomande.Controls.Add(Me.GroupBox4)
        Me.GBRecomande.Location = New System.Drawing.Point(26, 242)
        Me.GBRecomande.Name = "GBRecomande"
        Me.GBRecomande.Size = New System.Drawing.Size(125, 83)
        Me.GBRecomande.TabIndex = 39
        Me.GBRecomande.TabStop = False
        Me.GBRecomande.Text = "Recommandés"
        '
        'Options
        '
        Me.Options.Controls.Add(Me.OptG)
        Me.Options.Controls.Add(Me.OptU)
        Me.Options.Controls.Add(Me.GroupBox1)
        Me.Options.Controls.Add(Me.OptT)
        Me.Options.Controls.Add(Me.OptR)
        Me.Options.Controls.Add(Me.OptV)
        Me.Options.Controls.Add(Me.OptH)
        Me.Options.Controls.Add(Me.OptX)
        Me.Options.Controls.Add(Me.OptO)
        Me.Options.Controls.Add(Me.OptI)
        Me.Options.Controls.Add(Me.OptK)
        Me.Options.Controls.Add(Me.OptJ)
        Me.Options.Controls.Add(Me.OptN)
        Me.Options.Location = New System.Drawing.Point(7, 116)
        Me.Options.Name = "Options"
        Me.Options.Size = New System.Drawing.Size(164, 111)
        Me.Options.TabIndex = 40
        Me.Options.TabStop = False
        Me.Options.Text = "Options"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Source :"
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(7, 438)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(75, 23)
        Me.btnHelp.TabIndex = 41
        Me.btnHelp.Text = "Aide"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'lblResultatCmd
        '
        Me.lblResultatCmd.AutoSize = True
        Me.lblResultatCmd.Location = New System.Drawing.Point(183, 104)
        Me.lblResultatCmd.Name = "lblResultatCmd"
        Me.lblResultatCmd.Size = New System.Drawing.Size(136, 13)
        Me.lblResultatCmd.TabIndex = 43
        Me.lblResultatCmd.Text = "Résultat de la commande : "
        '
        'CommandReturn
        '
        Me.CommandReturn.Location = New System.Drawing.Point(116, 415)
        Me.CommandReturn.Name = "CommandReturn"
        Me.CommandReturn.Size = New System.Drawing.Size(386, 20)
        Me.CommandReturn.TabIndex = 44
        '
        'lblCommande
        '
        Me.lblCommande.Location = New System.Drawing.Point(6, 418)
        Me.lblCommande.Name = "lblCommande"
        Me.lblCommande.Size = New System.Drawing.Size(110, 13)
        Me.lblCommande.TabIndex = 45
        Me.lblCommande.Text = "Commande éxécuter :"
        Me.lblCommande.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(505, 414)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 46
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(94, 444)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(320, 10)
        Me.ProgressBar1.TabIndex = 47
        '
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(0, -2)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(588, 43)
        Me.AxShockwaveFlash1.TabIndex = 48
        '
        'chkbxLangue
        '
        Me.chkbxLangue.AutoSize = True
        Me.chkbxLangue.Checked = True
        Me.chkbxLangue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbxLangue.Location = New System.Drawing.Point(6, 47)
        Me.chkbxLangue.Name = "chkbxLangue"
        Me.chkbxLangue.Size = New System.Drawing.Size(15, 14)
        Me.chkbxLangue.TabIndex = 49
        Me.chkbxLangue.UseVisualStyleBackColor = True
        Me.chkbxLangue.Visible = False
        '
        'XCopyApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(585, 465)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkbxLangue)
        Me.Controls.Add(Me.AxShockwaveFlash1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblCommande)
        Me.Controls.Add(Me.CommandReturn)
        Me.Controls.Add(Me.lblResultatCmd)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.Options)
        Me.Controls.Add(Me.GBRecomande)
        Me.Controls.Add(Me.TextReturns)
        Me.Controls.Add(Me.btnDossierDest)
        Me.Controls.Add(Me.btnDossierSource)
        Me.Controls.Add(Me.btnFichier)
        Me.Controls.Add(Me.GBDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PathDestination)
        Me.Controls.Add(Me.PathSource)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnApply)
        Me.MaximumSize = New System.Drawing.Size(601, 503)
        Me.MinimumSize = New System.Drawing.Size(601, 503)
        Me.Name = "XCopyApp"
        Me.ShowIcon = False
        Me.Text = "GUI DosBox - Xcopy"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBDate.ResumeLayout(False)
        Me.GBDate.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GBPrompt.ResumeLayout(False)
        Me.GBPrompt.PerformLayout()
        Me.GBRecomande.ResumeLayout(False)
        Me.GBRecomande.PerformLayout()
        Me.Options.ResumeLayout(False)
        Me.Options.PerformLayout()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PathSource As System.Windows.Forms.TextBox
    Friend WithEvents PathDestination As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OptS As System.Windows.Forms.RadioButton
    Friend WithEvents OptM As System.Windows.Forms.RadioButton
    Friend WithEvents OptA As System.Windows.Forms.RadioButton
    Friend WithEvents GBDate As System.Windows.Forms.GroupBox
    Friend WithEvents invOptY As System.Windows.Forms.RadioButton
    Friend WithEvents OptY As System.Windows.Forms.RadioButton
    Friend WithEvents btnFichier As System.Windows.Forms.Button
    Friend WithEvents btnDossierSource As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GBPrompt As System.Windows.Forms.GroupBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog2 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnDossierDest As System.Windows.Forms.Button
    Friend WithEvents TextReturns As System.Windows.Forms.TextBox
    Friend WithEvents OptK As System.Windows.Forms.CheckBox
    Friend WithEvents OptX As System.Windows.Forms.CheckBox
    Friend WithEvents OptO As System.Windows.Forms.CheckBox
    Friend WithEvents OptT As System.Windows.Forms.CheckBox
    Friend WithEvents OptU As System.Windows.Forms.CheckBox
    Friend WithEvents OptN As System.Windows.Forms.CheckBox
    Friend WithEvents OptJ As System.Windows.Forms.CheckBox
    Friend WithEvents OptR As System.Windows.Forms.CheckBox
    Friend WithEvents OptH As System.Windows.Forms.CheckBox
    Friend WithEvents OptG As System.Windows.Forms.CheckBox
    Friend WithEvents OptI As System.Windows.Forms.CheckBox
    Friend WithEvents OptC As System.Windows.Forms.CheckBox
    Friend WithEvents OptV As System.Windows.Forms.CheckBox
    Friend WithEvents GBRecomande As System.Windows.Forms.GroupBox
    Friend WithEvents OptE As System.Windows.Forms.RadioButton
    Friend WithEvents Options As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OptD As System.Windows.Forms.CheckBox
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents lblResultatCmd As System.Windows.Forms.Label
    Friend WithEvents CommandReturn As System.Windows.Forms.TextBox
    Friend WithEvents lblCommande As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents DateSelected As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents chkbxLangue As System.Windows.Forms.CheckBox
End Class
