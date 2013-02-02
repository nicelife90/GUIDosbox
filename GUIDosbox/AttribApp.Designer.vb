<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttribApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AttribApp))
        Me.RBox = New System.Windows.Forms.GroupBox()
        Me.Null = New System.Windows.Forms.RadioButton()
        Me.RMoin = New System.Windows.Forms.RadioButton()
        Me.RPlus = New System.Windows.Forms.RadioButton()
        Me.ABox = New System.Windows.Forms.GroupBox()
        Me.Null1 = New System.Windows.Forms.RadioButton()
        Me.AMoin = New System.Windows.Forms.RadioButton()
        Me.Aplus = New System.Windows.Forms.RadioButton()
        Me.SBox = New System.Windows.Forms.GroupBox()
        Me.Null2 = New System.Windows.Forms.RadioButton()
        Me.SMoin = New System.Windows.Forms.RadioButton()
        Me.SPlus = New System.Windows.Forms.RadioButton()
        Me.HBox = New System.Windows.Forms.GroupBox()
        Me.Null3 = New System.Windows.Forms.RadioButton()
        Me.HMoin = New System.Windows.Forms.RadioButton()
        Me.HPlus = New System.Windows.Forms.RadioButton()
        Me.IBox = New System.Windows.Forms.GroupBox()
        Me.Null4 = New System.Windows.Forms.RadioButton()
        Me.IMoin = New System.Windows.Forms.RadioButton()
        Me.IPlus = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.OptL = New System.Windows.Forms.CheckBox()
        Me.OptD = New System.Windows.Forms.CheckBox()
        Me.OptS = New System.Windows.Forms.CheckBox()
        Me.btnAide = New System.Windows.Forms.Button()
        Me.btnFiles = New System.Windows.Forms.Button()
        Me.PathReturn = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnFolders = New System.Windows.Forms.Button()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.lblDescription1 = New System.Windows.Forms.Label()
        Me.lblDescription2 = New System.Windows.Forms.Label()
        Me.chkbxLangue = New System.Windows.Forms.CheckBox()
        Me.txtCmdExec = New System.Windows.Forms.TextBox()
        Me.lblCmdExec = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.myConsole = New GUIDosbox.GUIDosboxConsole()
        Me.flashHeader = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.RBox.SuspendLayout()
        Me.ABox.SuspendLayout()
        Me.SBox.SuspendLayout()
        Me.HBox.SuspendLayout()
        Me.IBox.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RBox
        '
        Me.RBox.Controls.Add(Me.Null)
        Me.RBox.Controls.Add(Me.RMoin)
        Me.RBox.Controls.Add(Me.RPlus)
        Me.RBox.Location = New System.Drawing.Point(143, 52)
        Me.RBox.Name = "RBox"
        Me.RBox.Size = New System.Drawing.Size(58, 89)
        Me.RBox.TabIndex = 5
        Me.RBox.TabStop = False
        Me.RBox.Text = "R"
        '
        'Null
        '
        Me.Null.AutoSize = True
        Me.Null.Location = New System.Drawing.Point(6, 65)
        Me.Null.Name = "Null"
        Me.Null.Size = New System.Drawing.Size(43, 17)
        Me.Null.TabIndex = 2
        Me.Null.TabStop = True
        Me.Null.Text = "Null"
        Me.Null.UseVisualStyleBackColor = True
        '
        'RMoin
        '
        Me.RMoin.AutoSize = True
        Me.RMoin.Location = New System.Drawing.Point(6, 44)
        Me.RMoin.Name = "RMoin"
        Me.RMoin.Size = New System.Drawing.Size(42, 17)
        Me.RMoin.TabIndex = 1
        Me.RMoin.TabStop = True
        Me.RMoin.Text = "-  R"
        Me.RMoin.UseVisualStyleBackColor = True
        '
        'RPlus
        '
        Me.RPlus.AutoSize = True
        Me.RPlus.Location = New System.Drawing.Point(7, 20)
        Me.RPlus.Name = "RPlus"
        Me.RPlus.Size = New System.Drawing.Size(42, 17)
        Me.RPlus.TabIndex = 0
        Me.RPlus.TabStop = True
        Me.RPlus.Text = "+ R"
        Me.RPlus.UseVisualStyleBackColor = True
        '
        'ABox
        '
        Me.ABox.Controls.Add(Me.Null1)
        Me.ABox.Controls.Add(Me.AMoin)
        Me.ABox.Controls.Add(Me.Aplus)
        Me.ABox.Location = New System.Drawing.Point(208, 52)
        Me.ABox.Name = "ABox"
        Me.ABox.Size = New System.Drawing.Size(58, 89)
        Me.ABox.TabIndex = 6
        Me.ABox.TabStop = False
        Me.ABox.Text = "A"
        '
        'Null1
        '
        Me.Null1.AutoSize = True
        Me.Null1.Location = New System.Drawing.Point(7, 65)
        Me.Null1.Name = "Null1"
        Me.Null1.Size = New System.Drawing.Size(43, 17)
        Me.Null1.TabIndex = 2
        Me.Null1.TabStop = True
        Me.Null1.Text = "Null"
        Me.Null1.UseVisualStyleBackColor = True
        '
        'AMoin
        '
        Me.AMoin.AutoSize = True
        Me.AMoin.Location = New System.Drawing.Point(7, 44)
        Me.AMoin.Name = "AMoin"
        Me.AMoin.Size = New System.Drawing.Size(41, 17)
        Me.AMoin.TabIndex = 1
        Me.AMoin.TabStop = True
        Me.AMoin.Text = "-  A"
        Me.AMoin.UseVisualStyleBackColor = True
        '
        'Aplus
        '
        Me.Aplus.AutoSize = True
        Me.Aplus.Location = New System.Drawing.Point(7, 20)
        Me.Aplus.Name = "Aplus"
        Me.Aplus.Size = New System.Drawing.Size(41, 17)
        Me.Aplus.TabIndex = 0
        Me.Aplus.TabStop = True
        Me.Aplus.Text = "+ A"
        Me.Aplus.UseVisualStyleBackColor = True
        '
        'SBox
        '
        Me.SBox.Controls.Add(Me.Null2)
        Me.SBox.Controls.Add(Me.SMoin)
        Me.SBox.Controls.Add(Me.SPlus)
        Me.SBox.Location = New System.Drawing.Point(272, 52)
        Me.SBox.Name = "SBox"
        Me.SBox.Size = New System.Drawing.Size(58, 89)
        Me.SBox.TabIndex = 7
        Me.SBox.TabStop = False
        Me.SBox.Text = "S"
        '
        'Null2
        '
        Me.Null2.AutoSize = True
        Me.Null2.Location = New System.Drawing.Point(6, 65)
        Me.Null2.Name = "Null2"
        Me.Null2.Size = New System.Drawing.Size(43, 17)
        Me.Null2.TabIndex = 2
        Me.Null2.TabStop = True
        Me.Null2.Text = "Null"
        Me.Null2.UseVisualStyleBackColor = True
        '
        'SMoin
        '
        Me.SMoin.AutoSize = True
        Me.SMoin.Location = New System.Drawing.Point(6, 44)
        Me.SMoin.Name = "SMoin"
        Me.SMoin.Size = New System.Drawing.Size(41, 17)
        Me.SMoin.TabIndex = 1
        Me.SMoin.TabStop = True
        Me.SMoin.Text = "-  S"
        Me.SMoin.UseVisualStyleBackColor = True
        '
        'SPlus
        '
        Me.SPlus.AutoSize = True
        Me.SPlus.Location = New System.Drawing.Point(7, 20)
        Me.SPlus.Name = "SPlus"
        Me.SPlus.Size = New System.Drawing.Size(41, 17)
        Me.SPlus.TabIndex = 0
        Me.SPlus.TabStop = True
        Me.SPlus.Text = "+ S"
        Me.SPlus.UseVisualStyleBackColor = True
        '
        'HBox
        '
        Me.HBox.Controls.Add(Me.Null3)
        Me.HBox.Controls.Add(Me.HMoin)
        Me.HBox.Controls.Add(Me.HPlus)
        Me.HBox.Location = New System.Drawing.Point(336, 52)
        Me.HBox.Name = "HBox"
        Me.HBox.Size = New System.Drawing.Size(58, 89)
        Me.HBox.TabIndex = 8
        Me.HBox.TabStop = False
        Me.HBox.Text = "H"
        '
        'Null3
        '
        Me.Null3.AutoSize = True
        Me.Null3.Location = New System.Drawing.Point(7, 65)
        Me.Null3.Name = "Null3"
        Me.Null3.Size = New System.Drawing.Size(43, 17)
        Me.Null3.TabIndex = 2
        Me.Null3.TabStop = True
        Me.Null3.Text = "Null"
        Me.Null3.UseVisualStyleBackColor = True
        '
        'HMoin
        '
        Me.HMoin.AutoSize = True
        Me.HMoin.Location = New System.Drawing.Point(7, 42)
        Me.HMoin.Name = "HMoin"
        Me.HMoin.Size = New System.Drawing.Size(42, 17)
        Me.HMoin.TabIndex = 1
        Me.HMoin.TabStop = True
        Me.HMoin.Text = "-  H"
        Me.HMoin.UseVisualStyleBackColor = True
        '
        'HPlus
        '
        Me.HPlus.AutoSize = True
        Me.HPlus.Location = New System.Drawing.Point(7, 19)
        Me.HPlus.Name = "HPlus"
        Me.HPlus.Size = New System.Drawing.Size(42, 17)
        Me.HPlus.TabIndex = 0
        Me.HPlus.TabStop = True
        Me.HPlus.Text = "+ H"
        Me.HPlus.UseVisualStyleBackColor = True
        '
        'IBox
        '
        Me.IBox.Controls.Add(Me.Null4)
        Me.IBox.Controls.Add(Me.IMoin)
        Me.IBox.Controls.Add(Me.IPlus)
        Me.IBox.Location = New System.Drawing.Point(400, 52)
        Me.IBox.Name = "IBox"
        Me.IBox.Size = New System.Drawing.Size(58, 89)
        Me.IBox.TabIndex = 9
        Me.IBox.TabStop = False
        Me.IBox.Text = "I"
        '
        'Null4
        '
        Me.Null4.AutoSize = True
        Me.Null4.Location = New System.Drawing.Point(7, 65)
        Me.Null4.Name = "Null4"
        Me.Null4.Size = New System.Drawing.Size(43, 17)
        Me.Null4.TabIndex = 2
        Me.Null4.TabStop = True
        Me.Null4.Text = "Null"
        Me.Null4.UseVisualStyleBackColor = True
        '
        'IMoin
        '
        Me.IMoin.AutoSize = True
        Me.IMoin.Location = New System.Drawing.Point(6, 42)
        Me.IMoin.Name = "IMoin"
        Me.IMoin.Size = New System.Drawing.Size(37, 17)
        Me.IMoin.TabIndex = 1
        Me.IMoin.TabStop = True
        Me.IMoin.Text = "-  I"
        Me.IMoin.UseVisualStyleBackColor = True
        '
        'IPlus
        '
        Me.IPlus.AutoSize = True
        Me.IPlus.Location = New System.Drawing.Point(7, 19)
        Me.IPlus.Name = "IPlus"
        Me.IPlus.Size = New System.Drawing.Size(37, 17)
        Me.IPlus.TabIndex = 0
        Me.IPlus.TabStop = True
        Me.IPlus.Text = "+ I"
        Me.IPlus.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.OptL)
        Me.GroupBox6.Controls.Add(Me.OptD)
        Me.GroupBox6.Controls.Add(Me.OptS)
        Me.GroupBox6.Location = New System.Drawing.Point(272, 147)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(144, 51)
        Me.GroupBox6.TabIndex = 10
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = " / Options"
        '
        'OptL
        '
        Me.OptL.AutoSize = True
        Me.OptL.Location = New System.Drawing.Point(102, 20)
        Me.OptL.Name = "OptL"
        Me.OptL.Size = New System.Drawing.Size(40, 17)
        Me.OptL.TabIndex = 2
        Me.OptL.Text = "/ L"
        Me.OptL.UseVisualStyleBackColor = True
        '
        'OptD
        '
        Me.OptD.AutoSize = True
        Me.OptD.Location = New System.Drawing.Point(54, 20)
        Me.OptD.Name = "OptD"
        Me.OptD.Size = New System.Drawing.Size(42, 17)
        Me.OptD.TabIndex = 1
        Me.OptD.Text = "/ D"
        Me.OptD.UseVisualStyleBackColor = True
        '
        'OptS
        '
        Me.OptS.AutoSize = True
        Me.OptS.Location = New System.Drawing.Point(7, 20)
        Me.OptS.Name = "OptS"
        Me.OptS.Size = New System.Drawing.Size(41, 17)
        Me.OptS.TabIndex = 0
        Me.OptS.Text = "/ S"
        Me.OptS.UseVisualStyleBackColor = True
        '
        'btnAide
        '
        Me.btnAide.Location = New System.Drawing.Point(12, 558)
        Me.btnAide.Name = "btnAide"
        Me.btnAide.Size = New System.Drawing.Size(72, 23)
        Me.btnAide.TabIndex = 11
        Me.btnAide.Text = "Aide"
        Me.btnAide.UseVisualStyleBackColor = True
        '
        'btnFiles
        '
        Me.btnFiles.Location = New System.Drawing.Point(12, 225)
        Me.btnFiles.Name = "btnFiles"
        Me.btnFiles.Size = New System.Drawing.Size(75, 23)
        Me.btnFiles.TabIndex = 14
        Me.btnFiles.Text = "Fichier"
        Me.btnFiles.UseVisualStyleBackColor = True
        '
        'PathReturn
        '
        Me.PathReturn.Location = New System.Drawing.Point(174, 227)
        Me.PathReturn.Name = "PathReturn"
        Me.PathReturn.Size = New System.Drawing.Size(411, 20)
        Me.PathReturn.TabIndex = 15
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnFolders
        '
        Me.btnFolders.Location = New System.Drawing.Point(93, 225)
        Me.btnFolders.Name = "btnFolders"
        Me.btnFolders.Size = New System.Drawing.Size(75, 23)
        Me.btnFolders.TabIndex = 16
        Me.btnFolders.Text = "Dossier"
        Me.btnFolders.UseVisualStyleBackColor = True
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Location = New System.Drawing.Point(174, 211)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(315, 13)
        Me.lblPath.TabIndex = 17
        Me.lblPath.Text = "Pour quel fichier ou dossier souhaitez-vous modiffier les attributs : "
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Location = New System.Drawing.Point(510, 558)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 18
        Me.btnBack.Text = "Retour"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(348, 558)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 19
        Me.btnApply.Text = "Appliquer"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'lblDescription1
        '
        Me.lblDescription1.Location = New System.Drawing.Point(17, 156)
        Me.lblDescription1.Name = "lblDescription1"
        Me.lblDescription1.Size = New System.Drawing.Size(231, 39)
        Me.lblDescription1.TabIndex = 20
        Me.lblDescription1.Text = "Ces options peuvent prendres plus de temps" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sur certaint ordinateur. Soyer patien" & _
    "t, même si" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "la fenêtre semble plus bouger. (J'usqua 30 sec)."
        Me.lblDescription1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescription2
        '
        Me.lblDescription2.Location = New System.Drawing.Point(464, 47)
        Me.lblDescription2.Name = "lblDescription2"
        Me.lblDescription2.Size = New System.Drawing.Size(119, 103)
        Me.lblDescription2.TabIndex = 21
        Me.lblDescription2.Text = "Vous devez choisir les " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "attributs içi. Pour en " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "connaitre la description" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "vous " & _
    "pouvez cliquer sur" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "le bouton aide plus bas."
        Me.lblDescription2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkbxLangue
        '
        Me.chkbxLangue.AutoSize = True
        Me.chkbxLangue.Checked = True
        Me.chkbxLangue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbxLangue.Location = New System.Drawing.Point(12, 66)
        Me.chkbxLangue.Name = "chkbxLangue"
        Me.chkbxLangue.Size = New System.Drawing.Size(15, 14)
        Me.chkbxLangue.TabIndex = 24
        Me.chkbxLangue.UseVisualStyleBackColor = True
        Me.chkbxLangue.Visible = False
        '
        'txtCmdExec
        '
        Me.txtCmdExec.Location = New System.Drawing.Point(135, 532)
        Me.txtCmdExec.Name = "txtCmdExec"
        Me.txtCmdExec.Size = New System.Drawing.Size(450, 20)
        Me.txtCmdExec.TabIndex = 26
        '
        'lblCmdExec
        '
        Me.lblCmdExec.AutoSize = True
        Me.lblCmdExec.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCmdExec.Location = New System.Drawing.Point(9, 534)
        Me.lblCmdExec.Name = "lblCmdExec"
        Me.lblCmdExec.Size = New System.Drawing.Size(120, 15)
        Me.lblCmdExec.TabIndex = 27
        Me.lblCmdExec.Text = "Commande exécutée:"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(429, 558)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 28
        Me.btnClear.Text = "Clear (cls)"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'myConsole
        '
        Me.myConsole.Location = New System.Drawing.Point(12, 265)
        Me.myConsole.myConsole = Nothing
        Me.myConsole.Name = "myConsole"
        Me.myConsole.Size = New System.Drawing.Size(573, 261)
        Me.myConsole.TabIndex = 29
        '
        'flashHeader
        '
        Me.flashHeader.Enabled = True
        Me.flashHeader.Location = New System.Drawing.Point(-1, 1)
        Me.flashHeader.Name = "flashHeader"
        Me.flashHeader.OcxState = CType(resources.GetObject("flashHeader.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flashHeader.Size = New System.Drawing.Size(596, 40)
        Me.flashHeader.TabIndex = 30
        '
        'AttribApp
        '
        Me.AcceptButton = Me.btnApply
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(592, 586)
        Me.ControlBox = False
        Me.Controls.Add(Me.flashHeader)
        Me.Controls.Add(Me.myConsole)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblCmdExec)
        Me.Controls.Add(Me.txtCmdExec)
        Me.Controls.Add(Me.chkbxLangue)
        Me.Controls.Add(Me.lblDescription2)
        Me.Controls.Add(Me.lblDescription1)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblPath)
        Me.Controls.Add(Me.btnFolders)
        Me.Controls.Add(Me.PathReturn)
        Me.Controls.Add(Me.btnFiles)
        Me.Controls.Add(Me.btnAide)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.IBox)
        Me.Controls.Add(Me.HBox)
        Me.Controls.Add(Me.SBox)
        Me.Controls.Add(Me.ABox)
        Me.Controls.Add(Me.RBox)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AttribApp"
        Me.Text = "GUI DosBox - Attrib"
        Me.RBox.ResumeLayout(False)
        Me.RBox.PerformLayout()
        Me.ABox.ResumeLayout(False)
        Me.ABox.PerformLayout()
        Me.SBox.ResumeLayout(False)
        Me.SBox.PerformLayout()
        Me.HBox.ResumeLayout(False)
        Me.HBox.PerformLayout()
        Me.IBox.ResumeLayout(False)
        Me.IBox.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RBox As System.Windows.Forms.GroupBox
    Friend WithEvents ABox As System.Windows.Forms.GroupBox
    Friend WithEvents SBox As System.Windows.Forms.GroupBox
    Friend WithEvents HBox As System.Windows.Forms.GroupBox
    Friend WithEvents IBox As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents OptL As System.Windows.Forms.CheckBox
    Friend WithEvents OptD As System.Windows.Forms.CheckBox
    Friend WithEvents OptS As System.Windows.Forms.CheckBox
    Friend WithEvents RMoin As System.Windows.Forms.RadioButton
    Friend WithEvents RPlus As System.Windows.Forms.RadioButton
    Friend WithEvents AMoin As System.Windows.Forms.RadioButton
    Friend WithEvents Aplus As System.Windows.Forms.RadioButton
    Friend WithEvents SMoin As System.Windows.Forms.RadioButton
    Friend WithEvents SPlus As System.Windows.Forms.RadioButton
    Friend WithEvents HMoin As System.Windows.Forms.RadioButton
    Friend WithEvents HPlus As System.Windows.Forms.RadioButton
    Friend WithEvents IMoin As System.Windows.Forms.RadioButton
    Friend WithEvents IPlus As System.Windows.Forms.RadioButton
    Friend WithEvents btnAide As System.Windows.Forms.Button
    Friend WithEvents btnFiles As System.Windows.Forms.Button
    Friend WithEvents PathReturn As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnFolders As System.Windows.Forms.Button
    Friend WithEvents lblPath As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents Null As System.Windows.Forms.RadioButton
    Friend WithEvents Null1 As System.Windows.Forms.RadioButton
    Friend WithEvents Null2 As System.Windows.Forms.RadioButton
    Friend WithEvents Null3 As System.Windows.Forms.RadioButton
    Friend WithEvents Null4 As System.Windows.Forms.RadioButton
    Friend WithEvents lblDescription1 As System.Windows.Forms.Label
    Friend WithEvents lblDescription2 As System.Windows.Forms.Label
    Friend WithEvents chkbxLangue As System.Windows.Forms.CheckBox
    Friend WithEvents txtCmdExec As System.Windows.Forms.TextBox
    Friend WithEvents lblCmdExec As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents myConsole As GUIDosbox.GUIDosboxConsole
    Friend WithEvents flashHeader As AxShockwaveFlashObjects.AxShockwaveFlash
End Class
