﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.chkbxLangue = New System.Windows.Forms.CheckBox()
        Me.flashHeader = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.btnSend = New GUIDosbox.GUIDosboxButton()
        Me.OptAdvanceMode = New GUIDosbox.GUIDosboxCheckbox()
        Me.lblTypeFichier = New GUIDosbox.GUIDosboxLabel()
        Me.lblExtention = New GUIDosbox.GUIDosboxLabel()
        Me.lblCommande = New GUIDosbox.GUIDosboxLabel()
        Me.txtCmdExec = New GUIDosbox.GUIDosboxTextbox()
        Me.btnHelp = New GUIDosbox.GUIDosboxButton()
        Me.btnApply = New GUIDosbox.GUIDosboxButton()
        Me.btnBack = New GUIDosbox.GUIDosboxButton()
        Me.btnClear = New GUIDosbox.GUIDosboxButton()
        Me.btnExtShow = New GUIDosbox.GUIDosboxButton()
        Me.txtExtSet = New GUIDosbox.GUIDosboxTextbox()
        Me.txtExtFile = New GUIDosbox.GUIDosboxTextbox()
        Me.myConsole = New GUIDosbox.GUIDosboxConsole()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkbxLangue
        '
        Me.chkbxLangue.AutoSize = True
        Me.chkbxLangue.Checked = True
        Me.chkbxLangue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbxLangue.Location = New System.Drawing.Point(527, 46)
        Me.chkbxLangue.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkbxLangue.Name = "chkbxLangue"
        Me.chkbxLangue.Size = New System.Drawing.Size(15, 14)
        Me.chkbxLangue.TabIndex = 18
        Me.chkbxLangue.UseVisualStyleBackColor = True
        Me.chkbxLangue.Visible = False
        '
        'flashHeader
        '
        Me.flashHeader.Enabled = True
        Me.flashHeader.Location = New System.Drawing.Point(1, 0)
        Me.flashHeader.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.flashHeader.Name = "flashHeader"
        Me.flashHeader.OcxState = CType(resources.GetObject("flashHeader.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flashHeader.Size = New System.Drawing.Size(576, 40)
        Me.flashHeader.TabIndex = 20
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.Black
        Me.btnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.Font = New System.Drawing.Font("Lucida Console", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnSend.ForeColor = System.Drawing.Color.LightBlue
        Me.btnSend.Location = New System.Drawing.Point(296, 487)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 33
        Me.btnSend.Text = "Envoyer"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'OptAdvanceMode
        '
        Me.OptAdvanceMode.AutoSize = True
        Me.OptAdvanceMode.BackColor = System.Drawing.Color.Transparent
        Me.OptAdvanceMode.Font = New System.Drawing.Font("Lucida Console", 8.0!, System.Drawing.FontStyle.Bold)
        Me.OptAdvanceMode.ForeColor = System.Drawing.Color.LightBlue
        Me.OptAdvanceMode.Location = New System.Drawing.Point(87, 514)
        Me.OptAdvanceMode.Name = "OptAdvanceMode"
        Me.OptAdvanceMode.Size = New System.Drawing.Size(112, 15)
        Me.OptAdvanceMode.TabIndex = 32
        Me.OptAdvanceMode.Text = "Mode avancé"
        Me.OptAdvanceMode.UseVisualStyleBackColor = False
        '
        'lblTypeFichier
        '
        Me.lblTypeFichier.AutoSize = True
        Me.lblTypeFichier.BackColor = System.Drawing.Color.Transparent
        Me.lblTypeFichier.Font = New System.Drawing.Font("Lucida Console", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblTypeFichier.ForeColor = System.Drawing.Color.LightBlue
        Me.lblTypeFichier.Location = New System.Drawing.Point(18, 101)
        Me.lblTypeFichier.Name = "lblTypeFichier"
        Me.lblTypeFichier.Size = New System.Drawing.Size(141, 11)
        Me.lblTypeFichier.TabIndex = 31
        Me.lblTypeFichier.Text = "Type de fichier :"
        '
        'lblExtention
        '
        Me.lblExtention.AutoSize = True
        Me.lblExtention.BackColor = System.Drawing.Color.Transparent
        Me.lblExtention.Font = New System.Drawing.Font("Lucida Console", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblExtention.ForeColor = System.Drawing.Color.LightBlue
        Me.lblExtention.Location = New System.Drawing.Point(18, 77)
        Me.lblExtention.Name = "lblExtention"
        Me.lblExtention.Size = New System.Drawing.Size(93, 11)
        Me.lblExtention.TabIndex = 30
        Me.lblExtention.Text = "Extension :"
        '
        'lblCommande
        '
        Me.lblCommande.AutoSize = True
        Me.lblCommande.BackColor = System.Drawing.Color.Transparent
        Me.lblCommande.Font = New System.Drawing.Font("Lucida Console", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblCommande.ForeColor = System.Drawing.Color.LightBlue
        Me.lblCommande.Location = New System.Drawing.Point(4, 454)
        Me.lblCommande.Name = "lblCommande"
        Me.lblCommande.Size = New System.Drawing.Size(149, 11)
        Me.lblCommande.TabIndex = 29
        Me.lblCommande.Text = "Commande exécuté :"
        '
        'txtCmdExec
        '
        Me.txtCmdExec.BackColor = System.Drawing.Color.Black
        Me.txtCmdExec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCmdExec.Enabled = False
        Me.txtCmdExec.Font = New System.Drawing.Font("Lucida Console", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtCmdExec.ForeColor = System.Drawing.Color.LightBlue
        Me.txtCmdExec.Location = New System.Drawing.Point(159, 452)
        Me.txtCmdExec.Name = "txtCmdExec"
        Me.txtCmdExec.Size = New System.Drawing.Size(404, 18)
        Me.txtCmdExec.TabIndex = 28
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Black
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Lucida Console", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnHelp.ForeColor = System.Drawing.Color.LightBlue
        Me.btnHelp.Location = New System.Drawing.Point(5, 507)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(75, 23)
        Me.btnHelp.TabIndex = 27
        Me.btnHelp.Text = "Aide"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'btnApply
        '
        Me.btnApply.BackColor = System.Drawing.Color.Black
        Me.btnApply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApply.Font = New System.Drawing.Font("Lucida Console", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnApply.ForeColor = System.Drawing.Color.LightBlue
        Me.btnApply.Location = New System.Drawing.Point(377, 507)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(90, 23)
        Me.btnApply.TabIndex = 26
        Me.btnApply.Text = "Appliquer"
        Me.btnApply.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Lucida Console", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.Color.LightBlue
        Me.btnBack.Location = New System.Drawing.Point(473, 507)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(90, 23)
        Me.btnBack.TabIndex = 25
        Me.btnBack.Text = "Retour"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Black
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Lucida Console", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.LightBlue
        Me.btnClear.Location = New System.Drawing.Point(473, 478)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 23)
        Me.btnClear.TabIndex = 24
        Me.btnClear.Text = "Effacer"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExtShow
        '
        Me.btnExtShow.BackColor = System.Drawing.Color.Black
        Me.btnExtShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExtShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnExtShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExtShow.Font = New System.Drawing.Font("Lucida Console", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnExtShow.ForeColor = System.Drawing.Color.LightBlue
        Me.btnExtShow.Location = New System.Drawing.Point(377, 478)
        Me.btnExtShow.Name = "btnExtShow"
        Me.btnExtShow.Size = New System.Drawing.Size(90, 23)
        Me.btnExtShow.TabIndex = 23
        Me.btnExtShow.Text = "Extension"
        Me.btnExtShow.UseVisualStyleBackColor = False
        '
        'txtExtSet
        '
        Me.txtExtSet.BackColor = System.Drawing.Color.Black
        Me.txtExtSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExtSet.Font = New System.Drawing.Font("Lucida Console", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtExtSet.ForeColor = System.Drawing.Color.LightBlue
        Me.txtExtSet.Location = New System.Drawing.Point(165, 75)
        Me.txtExtSet.Name = "txtExtSet"
        Me.txtExtSet.Size = New System.Drawing.Size(79, 18)
        Me.txtExtSet.TabIndex = 22
        '
        'txtExtFile
        '
        Me.txtExtFile.BackColor = System.Drawing.Color.Black
        Me.txtExtFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExtFile.Font = New System.Drawing.Font("Lucida Console", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtExtFile.ForeColor = System.Drawing.Color.LightBlue
        Me.txtExtFile.Location = New System.Drawing.Point(165, 99)
        Me.txtExtFile.Name = "txtExtFile"
        Me.txtExtFile.Size = New System.Drawing.Size(151, 18)
        Me.txtExtFile.TabIndex = 21
        '
        'myConsole
        '
        Me.myConsole.BackColor = System.Drawing.Color.Gainsboro
        Me.myConsole.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold)
        Me.myConsole.Location = New System.Drawing.Point(5, 140)
        Me.myConsole.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.myConsole.myConsole = Nothing
        Me.myConsole.Name = "myConsole"
        Me.myConsole.Size = New System.Drawing.Size(557, 306)
        Me.myConsole.TabIndex = 19
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(568, 536)
        Me.ShapeContainer1.TabIndex = 34
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.Black
        Me.RectangleShape1.BorderColor = System.Drawing.Color.LightBlue
        Me.RectangleShape1.BorderWidth = 2
        Me.RectangleShape1.CornerRadius = 5
        Me.RectangleShape1.Cursor = System.Windows.Forms.Cursors.Default
        Me.RectangleShape1.FillColor = System.Drawing.Color.LightBlue
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal
        Me.RectangleShape1.Location = New System.Drawing.Point(5, 55)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.Size = New System.Drawing.Size(328, 78)
        '
        'AssocApp
        '
        Me.AcceptButton = Me.btnSend
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(568, 536)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.OptAdvanceMode)
        Me.Controls.Add(Me.lblTypeFichier)
        Me.Controls.Add(Me.lblExtention)
        Me.Controls.Add(Me.lblCommande)
        Me.Controls.Add(Me.txtCmdExec)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExtShow)
        Me.Controls.Add(Me.txtExtSet)
        Me.Controls.Add(Me.txtExtFile)
        Me.Controls.Add(Me.flashHeader)
        Me.Controls.Add(Me.myConsole)
        Me.Controls.Add(Me.chkbxLangue)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AssocApp"
        Me.Text = "GUI Dosbox - Assoc"
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkbxLangue As System.Windows.Forms.CheckBox
    Friend WithEvents myConsole As GUIDosbox.GUIDosboxConsole
    Friend WithEvents flashHeader As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents txtExtFile As GUIDosbox.GUIDosboxTextbox
    Friend WithEvents txtExtSet As GUIDosbox.GUIDosboxTextbox
    Friend WithEvents btnExtShow As GUIDosbox.GUIDosboxButton
    Friend WithEvents btnClear As GUIDosbox.GUIDosboxButton
    Friend WithEvents btnBack As GUIDosbox.GUIDosboxButton
    Friend WithEvents btnApply As GUIDosbox.GUIDosboxButton
    Friend WithEvents btnHelp As GUIDosbox.GUIDosboxButton
    Friend WithEvents txtCmdExec As GUIDosbox.GUIDosboxTextbox
    Friend WithEvents lblCommande As GUIDosbox.GUIDosboxLabel
    Friend WithEvents lblExtention As GUIDosbox.GUIDosboxLabel
    Friend WithEvents lblTypeFichier As GUIDosbox.GUIDosboxLabel
    Friend WithEvents OptAdvanceMode As GUIDosbox.GUIDosboxCheckbox
    Friend WithEvents btnSend As GUIDosbox.GUIDosboxButton
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
End Class
