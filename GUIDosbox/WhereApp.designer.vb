<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WhereApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WhereApp))
        Me.OptT = New System.Windows.Forms.CheckBox()
        Me.OptR = New System.Windows.Forms.CheckBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.lblModele = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnDossier = New System.Windows.Forms.Button()
        Me.gbOptions = New System.Windows.Forms.GroupBox()
        Me.lblSillencieux = New System.Windows.Forms.Label()
        Me.OptQ = New System.Windows.Forms.CheckBox()
        Me.lblAfficheName = New System.Windows.Forms.Label()
        Me.OptF = New System.Windows.Forms.CheckBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblSubFolder = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtModele = New System.Windows.Forms.TextBox()
        Me.txtComandLine = New System.Windows.Forms.TextBox()
        Me.txtComandExecuter = New System.Windows.Forms.TextBox()
        Me.lblComandLine = New System.Windows.Forms.Label()
        Me.lblComandExecuter = New System.Windows.Forms.Label()
        Me.gbRecherche = New System.Windows.Forms.GroupBox()
        Me.lblExemple = New System.Windows.Forms.Label()
        Me.OptAdvance = New System.Windows.Forms.CheckBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.myConsole = New GUIDosbox.GUIDosboxConsole()
        Me.flashHeader = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.gbOptions.SuspendLayout()
        Me.gbRecherche.SuspendLayout()
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OptT
        '
        Me.OptT.AutoSize = True
        Me.OptT.Location = New System.Drawing.Point(5, 22)
        Me.OptT.Name = "OptT"
        Me.OptT.Size = New System.Drawing.Size(38, 17)
        Me.OptT.TabIndex = 0
        Me.OptT.Text = "/T"
        Me.OptT.UseVisualStyleBackColor = True
        '
        'OptR
        '
        Me.OptR.AutoSize = True
        Me.OptR.Location = New System.Drawing.Point(169, 41)
        Me.OptR.Name = "OptR"
        Me.OptR.Size = New System.Drawing.Size(39, 17)
        Me.OptR.TabIndex = 1
        Me.OptR.Text = "/R"
        Me.OptR.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(356, 467)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 2
        Me.btnApply.Text = "Appliquer"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(4, 467)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(75, 23)
        Me.btnHelp.TabIndex = 3
        Me.btnHelp.Text = "Aide"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'txtSource
        '
        Me.txtSource.Location = New System.Drawing.Point(63, 17)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(260, 20)
        Me.txtSource.TabIndex = 4
        '
        'lblModele
        '
        Me.lblModele.AutoSize = True
        Me.lblModele.Location = New System.Drawing.Point(10, 42)
        Me.lblModele.Name = "lblModele"
        Me.lblModele.Size = New System.Drawing.Size(51, 13)
        Me.lblModele.TabIndex = 7
        Me.lblModele.Text = "Modèle : "
        '
        'btnDossier
        '
        Me.btnDossier.Location = New System.Drawing.Point(5, 16)
        Me.btnDossier.Name = "btnDossier"
        Me.btnDossier.Size = New System.Drawing.Size(54, 23)
        Me.btnDossier.TabIndex = 8
        Me.btnDossier.Text = "Dossier"
        Me.btnDossier.UseVisualStyleBackColor = True
        '
        'gbOptions
        '
        Me.gbOptions.Controls.Add(Me.lblSillencieux)
        Me.gbOptions.Controls.Add(Me.OptQ)
        Me.gbOptions.Controls.Add(Me.lblAfficheName)
        Me.gbOptions.Controls.Add(Me.OptF)
        Me.gbOptions.Controls.Add(Me.lblInfo)
        Me.gbOptions.Controls.Add(Me.OptT)
        Me.gbOptions.Location = New System.Drawing.Point(349, 48)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(159, 86)
        Me.gbOptions.TabIndex = 10
        Me.gbOptions.TabStop = False
        Me.gbOptions.Text = "Options"
        '
        'lblSillencieux
        '
        Me.lblSillencieux.AutoSize = True
        Me.lblSillencieux.Location = New System.Drawing.Point(44, 58)
        Me.lblSillencieux.Name = "lblSillencieux"
        Me.lblSillencieux.Size = New System.Drawing.Size(111, 13)
        Me.lblSillencieux.TabIndex = 7
        Me.lblSillencieux.Text = "Code sortie seulement"
        '
        'OptQ
        '
        Me.OptQ.AutoSize = True
        Me.OptQ.Location = New System.Drawing.Point(5, 57)
        Me.OptQ.Name = "OptQ"
        Me.OptQ.Size = New System.Drawing.Size(42, 17)
        Me.OptQ.TabIndex = 6
        Me.OptQ.Text = "/ Q"
        Me.OptQ.UseVisualStyleBackColor = True
        '
        'lblAfficheName
        '
        Me.lblAfficheName.AutoSize = True
        Me.lblAfficheName.Location = New System.Drawing.Point(44, 42)
        Me.lblAfficheName.Name = "lblAfficheName"
        Me.lblAfficheName.Size = New System.Drawing.Size(90, 13)
        Me.lblAfficheName.TabIndex = 5
        Me.lblAfficheName.Text = "Affichage du nom"
        '
        'OptF
        '
        Me.OptF.AutoSize = True
        Me.OptF.Location = New System.Drawing.Point(5, 41)
        Me.OptF.Name = "OptF"
        Me.OptF.Size = New System.Drawing.Size(40, 17)
        Me.OptF.TabIndex = 4
        Me.OptF.Text = "/ F"
        Me.OptF.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(44, 23)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(30, 13)
        Me.lblInfo.TabIndex = 3
        Me.lblInfo.Text = "Infos"
        '
        'lblSubFolder
        '
        Me.lblSubFolder.AutoSize = True
        Me.lblSubFolder.Location = New System.Drawing.Point(203, 42)
        Me.lblSubFolder.Name = "lblSubFolder"
        Me.lblSubFolder.Size = New System.Drawing.Size(119, 13)
        Me.lblSubFolder.TabIndex = 2
        Me.lblSubFolder.Text = "Dossier + Sous dossiers"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(433, 467)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Retour"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtModele
        '
        Me.txtModele.Location = New System.Drawing.Point(63, 39)
        Me.txtModele.Name = "txtModele"
        Me.txtModele.Size = New System.Drawing.Size(103, 20)
        Me.txtModele.TabIndex = 12
        '
        'txtComandLine
        '
        Me.txtComandLine.Location = New System.Drawing.Point(123, 401)
        Me.txtComandLine.Name = "txtComandLine"
        Me.txtComandLine.Size = New System.Drawing.Size(385, 20)
        Me.txtComandLine.TabIndex = 14
        '
        'txtComandExecuter
        '
        Me.txtComandExecuter.Location = New System.Drawing.Point(123, 420)
        Me.txtComandExecuter.Name = "txtComandExecuter"
        Me.txtComandExecuter.Size = New System.Drawing.Size(385, 20)
        Me.txtComandExecuter.TabIndex = 15
        '
        'lblComandLine
        '
        Me.lblComandLine.AutoSize = True
        Me.lblComandLine.Location = New System.Drawing.Point(9, 404)
        Me.lblComandLine.Name = "lblComandLine"
        Me.lblComandLine.Size = New System.Drawing.Size(109, 13)
        Me.lblComandLine.TabIndex = 16
        Me.lblComandLine.Text = "Ligne de commande :"
        '
        'lblComandExecuter
        '
        Me.lblComandExecuter.AutoSize = True
        Me.lblComandExecuter.Location = New System.Drawing.Point(9, 423)
        Me.lblComandExecuter.Name = "lblComandExecuter"
        Me.lblComandExecuter.Size = New System.Drawing.Size(113, 13)
        Me.lblComandExecuter.TabIndex = 17
        Me.lblComandExecuter.Text = "Commande exécutée :"
        '
        'gbRecherche
        '
        Me.gbRecherche.Controls.Add(Me.lblExemple)
        Me.gbRecherche.Controls.Add(Me.btnDossier)
        Me.gbRecherche.Controls.Add(Me.lblModele)
        Me.gbRecherche.Controls.Add(Me.lblSubFolder)
        Me.gbRecherche.Controls.Add(Me.txtSource)
        Me.gbRecherche.Controls.Add(Me.txtModele)
        Me.gbRecherche.Controls.Add(Me.OptR)
        Me.gbRecherche.Location = New System.Drawing.Point(9, 48)
        Me.gbRecherche.Name = "gbRecherche"
        Me.gbRecherche.Size = New System.Drawing.Size(339, 86)
        Me.gbRecherche.TabIndex = 18
        Me.gbRecherche.TabStop = False
        Me.gbRecherche.Text = " Rechercher dans : "
        '
        'lblExemple
        '
        Me.lblExemple.AutoSize = True
        Me.lblExemple.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExemple.Location = New System.Drawing.Point(3, 62)
        Me.lblExemple.Name = "lblExemple"
        Me.lblExemple.Size = New System.Drawing.Size(331, 13)
        Me.lblExemple.TabIndex = 13
        Me.lblExemple.Text = "Exemple de Modèles : *.txt , *.dll, *.exe ou nom de fichier"
        '
        'OptAdvance
        '
        Me.OptAdvance.AutoSize = True
        Me.OptAdvance.Location = New System.Drawing.Point(9, 443)
        Me.OptAdvance.Name = "OptAdvance"
        Me.OptAdvance.Size = New System.Drawing.Size(93, 17)
        Me.OptAdvance.TabIndex = 19
        Me.OptAdvance.Text = "Mode Avancé"
        Me.OptAdvance.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(356, 443)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 21
        Me.btnSend.Text = "Envoi"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(433, 443)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'myConsole
        '
        Me.myConsole.Location = New System.Drawing.Point(9, 140)
        Me.myConsole.myConsole = Nothing
        Me.myConsole.Name = "myConsole"
        Me.myConsole.Size = New System.Drawing.Size(499, 255)
        Me.myConsole.TabIndex = 24
        '
        'flashHeader
        '
        Me.flashHeader.Enabled = True
        Me.flashHeader.Location = New System.Drawing.Point(-1, 0)
        Me.flashHeader.Name = "flashHeader"
        Me.flashHeader.OcxState = CType(resources.GetObject("flashHeader.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flashHeader.Size = New System.Drawing.Size(523, 40)
        Me.flashHeader.TabIndex = 25
        '
        'WhereApp
        '
        Me.AcceptButton = Me.btnSend
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(520, 496)
        Me.ControlBox = False
        Me.Controls.Add(Me.flashHeader)
        Me.Controls.Add(Me.myConsole)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.OptAdvance)
        Me.Controls.Add(Me.gbRecherche)
        Me.Controls.Add(Me.lblComandExecuter)
        Me.Controls.Add(Me.lblComandLine)
        Me.Controls.Add(Me.txtComandExecuter)
        Me.Controls.Add(Me.txtComandLine)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.gbOptions)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnApply)
        Me.Name = "WhereApp"
        Me.Text = "WhereApp"
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        Me.gbRecherche.ResumeLayout(False)
        Me.gbRecherche.PerformLayout()
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OptT As System.Windows.Forms.CheckBox
    Friend WithEvents OptR As System.Windows.Forms.CheckBox
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents txtSource As System.Windows.Forms.TextBox
    Friend WithEvents lblModele As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnDossier As System.Windows.Forms.Button
    Friend WithEvents gbOptions As System.Windows.Forms.GroupBox
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents lblSubFolder As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents txtModele As System.Windows.Forms.TextBox
    Friend WithEvents OptF As System.Windows.Forms.CheckBox
    Friend WithEvents txtComandLine As System.Windows.Forms.TextBox
    Friend WithEvents txtComandExecuter As System.Windows.Forms.TextBox
    Friend WithEvents lblComandLine As System.Windows.Forms.Label
    Friend WithEvents lblComandExecuter As System.Windows.Forms.Label
    Friend WithEvents lblAfficheName As System.Windows.Forms.Label
    Friend WithEvents gbRecherche As System.Windows.Forms.GroupBox
    Friend WithEvents lblExemple As System.Windows.Forms.Label
    Friend WithEvents OptAdvance As System.Windows.Forms.CheckBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblSillencieux As System.Windows.Forms.Label
    Friend WithEvents OptQ As System.Windows.Forms.CheckBox
    Friend WithEvents myConsole As GUIDosbox.GUIDosboxConsole
    Friend WithEvents flashHeader As AxShockwaveFlashObjects.AxShockwaveFlash
End Class
