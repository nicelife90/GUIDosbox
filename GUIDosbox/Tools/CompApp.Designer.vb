<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CompApp))
        Me.flashHeader = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.gbNbLigne = New GUIDosbox.GUIDosbox_Groupbox()
        Me.optNArgs = New System.Windows.Forms.NumericUpDown()
        Me.optN = New GUIDosbox.GUIDosbox_Checkbox()
        Me.gbOptions = New GUIDosbox.GUIDosbox_Groupbox()
        Me.optOff = New GUIDosbox.GUIDosbox_Checkbox()
        Me.optC = New GUIDosbox.GUIDosbox_Checkbox()
        Me.optL = New GUIDosbox.GUIDosbox_Checkbox()
        Me.optA = New GUIDosbox.GUIDosbox_Checkbox()
        Me.optD = New GUIDosbox.GUIDosbox_Checkbox()
        Me.gbFileCompare = New GUIDosbox.GUIDosbox_Groupbox()
        Me.btnFile2 = New GUIDosbox.GUIDosbox_Button()
        Me.btnFile1 = New GUIDosbox.GUIDosbox_Button()
        Me.txtFile1 = New GUIDosbox.GUIDosbox_Textbox()
        Me.txtFile2 = New GUIDosbox.GUIDosbox_Textbox()
        Me.btnSend = New GUIDosbox.GUIDosbox_Button()
        Me.btnApply = New GUIDosbox.GUIDosbox_Button()
        Me.btnBack = New GUIDosbox.GUIDosbox_Button()
        Me.btnClear = New GUIDosbox.GUIDosbox_Button()
        Me.optAdvanceMode = New GUIDosbox.GUIDosbox_Checkbox()
        Me.btnHelp = New GUIDosbox.GUIDosbox_Button()
        Me.txtCmdExec = New GUIDosbox.GUIDosbox_Textbox()
        Me.lblCmdExec = New GUIDosbox.GUIDosbox_Label()
        Me.myConsole = New GUIDosbox.GUIDosbox_Console()
        Me.footer = New GUIDosbox.GUIDosbox_StatusStrip()
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbNbLigne.SuspendLayout()
        CType(Me.optNArgs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOptions.SuspendLayout()
        Me.gbFileCompare.SuspendLayout()
        Me.SuspendLayout()
        '
        'flashHeader
        '
        Me.flashHeader.Enabled = True
        Me.flashHeader.Location = New System.Drawing.Point(0, -1)
        Me.flashHeader.Name = "flashHeader"
        Me.flashHeader.OcxState = CType(resources.GetObject("flashHeader.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flashHeader.Size = New System.Drawing.Size(678, 40)
        Me.flashHeader.TabIndex = 33
        '
        'gbNbLigne
        '
        Me.gbNbLigne.BackColor = System.Drawing.Color.Black
        Me.gbNbLigne.BorderColor = System.Drawing.Color.LightBlue
        Me.gbNbLigne.Controls.Add(Me.optNArgs)
        Me.gbNbLigne.Controls.Add(Me.optN)
        Me.gbNbLigne.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.gbNbLigne.ForeColor = System.Drawing.Color.LightBlue
        Me.gbNbLigne.Location = New System.Drawing.Point(425, 43)
        Me.gbNbLigne.Name = "gbNbLigne"
        Me.gbNbLigne.Size = New System.Drawing.Size(138, 74)
        Me.gbNbLigne.TabIndex = 44
        Me.gbNbLigne.TabStop = False
        Me.gbNbLigne.Text = " Nombre de ligne"
        '
        'optNArgs
        '
        Me.optNArgs.BackColor = System.Drawing.Color.Black
        Me.optNArgs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.optNArgs.ForeColor = System.Drawing.Color.LightBlue
        Me.optNArgs.Location = New System.Drawing.Point(6, 45)
        Me.optNArgs.Name = "optNArgs"
        Me.optNArgs.Size = New System.Drawing.Size(126, 18)
        Me.optNArgs.TabIndex = 2
        '
        'optN
        '
        Me.optN.AutoSize = True
        Me.optN.BackColor = System.Drawing.Color.Black
        Me.optN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optN.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optN.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optN.Location = New System.Drawing.Point(6, 19)
        Me.optN.Name = "optN"
        Me.optN.Size = New System.Drawing.Size(35, 15)
        Me.optN.TabIndex = 0
        Me.optN.Text = "/N"
        Me.optN.UseVisualStyleBackColor = False
        '
        'gbOptions
        '
        Me.gbOptions.BackColor = System.Drawing.Color.Black
        Me.gbOptions.BorderColor = System.Drawing.Color.LightBlue
        Me.gbOptions.Controls.Add(Me.optOff)
        Me.gbOptions.Controls.Add(Me.optC)
        Me.gbOptions.Controls.Add(Me.optL)
        Me.gbOptions.Controls.Add(Me.optA)
        Me.gbOptions.Controls.Add(Me.optD)
        Me.gbOptions.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.gbOptions.ForeColor = System.Drawing.Color.LightBlue
        Me.gbOptions.Location = New System.Drawing.Point(569, 43)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(98, 74)
        Me.gbOptions.TabIndex = 43
        Me.gbOptions.TabStop = False
        Me.gbOptions.Text = " Options"
        '
        'optOff
        '
        Me.optOff.AutoSize = True
        Me.optOff.BackColor = System.Drawing.Color.Black
        Me.optOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optOff.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optOff.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optOff.Location = New System.Drawing.Point(14, 52)
        Me.optOff.Name = "optOff"
        Me.optOff.Size = New System.Drawing.Size(49, 15)
        Me.optOff.TabIndex = 48
        Me.optOff.Text = "/OFF"
        Me.optOff.UseVisualStyleBackColor = False
        '
        'optC
        '
        Me.optC.AutoSize = True
        Me.optC.BackColor = System.Drawing.Color.Black
        Me.optC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optC.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optC.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optC.Location = New System.Drawing.Point(60, 33)
        Me.optC.Name = "optC"
        Me.optC.Size = New System.Drawing.Size(35, 15)
        Me.optC.TabIndex = 44
        Me.optC.Text = "/C"
        Me.optC.UseVisualStyleBackColor = False
        '
        'optL
        '
        Me.optL.AutoSize = True
        Me.optL.BackColor = System.Drawing.Color.Black
        Me.optL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optL.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optL.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optL.Location = New System.Drawing.Point(14, 33)
        Me.optL.Name = "optL"
        Me.optL.Size = New System.Drawing.Size(35, 15)
        Me.optL.TabIndex = 45
        Me.optL.Text = "/L"
        Me.optL.UseVisualStyleBackColor = False
        '
        'optA
        '
        Me.optA.AutoSize = True
        Me.optA.BackColor = System.Drawing.Color.Black
        Me.optA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optA.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optA.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optA.Location = New System.Drawing.Point(60, 14)
        Me.optA.Name = "optA"
        Me.optA.Size = New System.Drawing.Size(35, 15)
        Me.optA.TabIndex = 46
        Me.optA.Text = "/A"
        Me.optA.UseVisualStyleBackColor = False
        '
        'optD
        '
        Me.optD.AutoSize = True
        Me.optD.BackColor = System.Drawing.Color.Black
        Me.optD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optD.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optD.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optD.Location = New System.Drawing.Point(14, 14)
        Me.optD.Name = "optD"
        Me.optD.Size = New System.Drawing.Size(35, 15)
        Me.optD.TabIndex = 47
        Me.optD.Text = "/D"
        Me.optD.UseVisualStyleBackColor = False
        '
        'gbFileCompare
        '
        Me.gbFileCompare.BackColor = System.Drawing.Color.Black
        Me.gbFileCompare.BorderColor = System.Drawing.Color.LightBlue
        Me.gbFileCompare.Controls.Add(Me.btnFile2)
        Me.gbFileCompare.Controls.Add(Me.btnFile1)
        Me.gbFileCompare.Controls.Add(Me.txtFile1)
        Me.gbFileCompare.Controls.Add(Me.txtFile2)
        Me.gbFileCompare.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.gbFileCompare.ForeColor = System.Drawing.Color.LightBlue
        Me.gbFileCompare.Location = New System.Drawing.Point(7, 43)
        Me.gbFileCompare.Name = "gbFileCompare"
        Me.gbFileCompare.Size = New System.Drawing.Size(412, 74)
        Me.gbFileCompare.TabIndex = 42
        Me.gbFileCompare.TabStop = False
        Me.gbFileCompare.Text = " Fichier à comparer"
        '
        'btnFile2
        '
        Me.btnFile2.BackColor = System.Drawing.Color.Black
        Me.btnFile2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFile2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnFile2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFile2.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnFile2.ForeColor = System.Drawing.Color.LightBlue
        Me.btnFile2.Location = New System.Drawing.Point(6, 42)
        Me.btnFile2.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnFile2.Name = "btnFile2"
        Me.btnFile2.Size = New System.Drawing.Size(82, 23)
        Me.btnFile2.TabIndex = 27
        Me.btnFile2.Text = "Fichier 2"
        Me.btnFile2.UseVisualStyleBackColor = False
        '
        'btnFile1
        '
        Me.btnFile1.BackColor = System.Drawing.Color.Black
        Me.btnFile1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFile1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnFile1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFile1.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnFile1.ForeColor = System.Drawing.Color.LightBlue
        Me.btnFile1.Location = New System.Drawing.Point(6, 15)
        Me.btnFile1.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnFile1.Name = "btnFile1"
        Me.btnFile1.Size = New System.Drawing.Size(82, 23)
        Me.btnFile1.TabIndex = 26
        Me.btnFile1.Text = "Fichier 1"
        Me.btnFile1.UseVisualStyleBackColor = False
        '
        'txtFile1
        '
        Me.txtFile1.BackColor = System.Drawing.Color.Black
        Me.txtFile1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFile1.Enabled = False
        Me.txtFile1.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtFile1.ForeColor = System.Drawing.Color.LightBlue
        Me.txtFile1.Location = New System.Drawing.Point(94, 18)
        Me.txtFile1.Name = "txtFile1"
        Me.txtFile1.Size = New System.Drawing.Size(311, 18)
        Me.txtFile1.TabIndex = 24
        '
        'txtFile2
        '
        Me.txtFile2.BackColor = System.Drawing.Color.Black
        Me.txtFile2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFile2.Enabled = False
        Me.txtFile2.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtFile2.ForeColor = System.Drawing.Color.LightBlue
        Me.txtFile2.Location = New System.Drawing.Point(94, 45)
        Me.txtFile2.Name = "txtFile2"
        Me.txtFile2.Size = New System.Drawing.Size(311, 18)
        Me.txtFile2.TabIndex = 25
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.Black
        Me.btnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnSend.ForeColor = System.Drawing.Color.LightBlue
        Me.btnSend.Location = New System.Drawing.Point(295, 428)
        Me.btnSend.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(82, 23)
        Me.btnSend.TabIndex = 41
        Me.btnSend.Text = "Envoyer"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'btnApply
        '
        Me.btnApply.BackColor = System.Drawing.Color.Black
        Me.btnApply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApply.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnApply.ForeColor = System.Drawing.Color.LightBlue
        Me.btnApply.Location = New System.Drawing.Point(497, 458)
        Me.btnApply.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(82, 23)
        Me.btnApply.TabIndex = 40
        Me.btnApply.Text = "Appliquer"
        Me.btnApply.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnBack.ForeColor = System.Drawing.Color.LightBlue
        Me.btnBack.Location = New System.Drawing.Point(585, 458)
        Me.btnBack.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(82, 23)
        Me.btnBack.TabIndex = 39
        Me.btnBack.Text = "Retour"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Black
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnClear.ForeColor = System.Drawing.Color.LightBlue
        Me.btnClear.Location = New System.Drawing.Point(585, 428)
        Me.btnClear.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(82, 23)
        Me.btnClear.TabIndex = 38
        Me.btnClear.Text = "Effacer"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'optAdvanceMode
        '
        Me.optAdvanceMode.AutoSize = True
        Me.optAdvanceMode.BackColor = System.Drawing.Color.Black
        Me.optAdvanceMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optAdvanceMode.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optAdvanceMode.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optAdvanceMode.Location = New System.Drawing.Point(95, 466)
        Me.optAdvanceMode.Name = "optAdvanceMode"
        Me.optAdvanceMode.Size = New System.Drawing.Size(98, 15)
        Me.optAdvanceMode.TabIndex = 37
        Me.optAdvanceMode.Text = "Mode Avancé"
        Me.optAdvanceMode.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Black
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnHelp.ForeColor = System.Drawing.Color.LightBlue
        Me.btnHelp.Location = New System.Drawing.Point(7, 458)
        Me.btnHelp.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(82, 23)
        Me.btnHelp.TabIndex = 36
        Me.btnHelp.Text = "Aide"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'txtCmdExec
        '
        Me.txtCmdExec.BackColor = System.Drawing.Color.Black
        Me.txtCmdExec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCmdExec.Enabled = False
        Me.txtCmdExec.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtCmdExec.ForeColor = System.Drawing.Color.LightBlue
        Me.txtCmdExec.Location = New System.Drawing.Point(142, 404)
        Me.txtCmdExec.Name = "txtCmdExec"
        Me.txtCmdExec.Size = New System.Drawing.Size(525, 18)
        Me.txtCmdExec.TabIndex = 35
        '
        'lblCmdExec
        '
        Me.lblCmdExec.AutoSize = True
        Me.lblCmdExec.BackColor = System.Drawing.Color.Transparent
        Me.lblCmdExec.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.lblCmdExec.ForeColor = System.Drawing.Color.LightBlue
        Me.lblCmdExec.Location = New System.Drawing.Point(5, 406)
        Me.lblCmdExec.Name = "lblCmdExec"
        Me.lblCmdExec.Size = New System.Drawing.Size(131, 11)
        Me.lblCmdExec.TabIndex = 34
        Me.lblCmdExec.Text = "Commande exécuté :"
        '
        'myConsole
        '
        Me.myConsole.Location = New System.Drawing.Point(7, 123)
        Me.myConsole.myConsole = Nothing
        Me.myConsole.Name = "myConsole"
        Me.myConsole.Size = New System.Drawing.Size(660, 275)
        Me.myConsole.TabIndex = 32
        '
        'footer
        '
        Me.footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.footer.Location = New System.Drawing.Point(0, 483)
        Me.footer.Name = "footer"
        Me.footer.Size = New System.Drawing.Size(673, 22)
        Me.footer.TabIndex = 45
        '
        'CompApp
        '
        Me.AcceptButton = Me.btnSend
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(673, 505)
        Me.ControlBox = False
        Me.Controls.Add(Me.footer)
        Me.Controls.Add(Me.gbNbLigne)
        Me.Controls.Add(Me.gbOptions)
        Me.Controls.Add(Me.gbFileCompare)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.optAdvanceMode)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.txtCmdExec)
        Me.Controls.Add(Me.lblCmdExec)
        Me.Controls.Add(Me.flashHeader)
        Me.Controls.Add(Me.myConsole)
        Me.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.LightBlue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CompApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GUI DosBox - COMP"
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbNbLigne.ResumeLayout(False)
        Me.gbNbLigne.PerformLayout()
        CType(Me.optNArgs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        Me.gbFileCompare.ResumeLayout(False)
        Me.gbFileCompare.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents myConsole As GUIDosbox.GUIDosbox_Console
    Friend WithEvents flashHeader As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents lblCmdExec As GUIDosbox.GUIDosbox_Label
    Friend WithEvents txtCmdExec As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents btnHelp As GUIDosbox.GUIDosbox_Button
    Friend WithEvents optAdvanceMode As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents btnClear As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnBack As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnApply As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnSend As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnFile2 As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnFile1 As GUIDosbox.GUIDosbox_Button
    Friend WithEvents txtFile2 As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents txtFile1 As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents gbFileCompare As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents gbOptions As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents optC As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents optL As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents optA As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents optD As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents gbNbLigne As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents optN As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents optNArgs As System.Windows.Forms.NumericUpDown
    Friend WithEvents footer As GUIDosbox.GUIDosbox_StatusStrip
    Friend WithEvents optOff As GUIDosbox.GUIDosbox_Checkbox
End Class
