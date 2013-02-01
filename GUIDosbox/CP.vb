Public Class CP

    Private Sub AttribToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttribToolStripMenuItem.Click
        Me.Hide()
        AttribApp.Show()
    End Sub

    Private Sub ChkdskToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkdskToolStripMenuItem.Click
        Me.Hide()
        CHKDSkApp.Show()
    End Sub

    Private Sub CmdConsoleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdConsoleToolStripMenuItem.Click
        Me.Hide()
        CMDConsole.Show()
    End Sub

    Private Sub CompactToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompactToolStripMenuItem.Click
        Me.Hide()
        CompactApp.Show()
    End Sub

    Private Sub XcopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XcopyToolStripMenuItem.Click
        Me.Hide()
        XCopyApp.Show()
    End Sub

    Private Sub COmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssocToolStripMenuItem.Click
        Me.Hide()
        AssocApp.Show()
    End Sub

    Private Sub AideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AideToolStripMenuItem.Click
        HelpApp.Show()
        Me.Hide()
    End Sub

    Private Sub QuiterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuiterToolStripMenuItem.Click
        End
    End Sub

    Private Sub WhoamiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WhoamiToolStripMenuItem.Click
        Me.Hide()
        WhoamiApp.Show()
    End Sub

    Private Sub COMPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COMPToolStripMenuItem.Click
        Me.Hide()
        CompApp.Show()
    End Sub

    Private Sub TRACERTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TRACERTToolStripMenuItem.Click
        Me.Hide()
        TracertApp.Show()
    End Sub

    Private Sub TYPEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TYPEToolStripMenuItem.Click
        Me.Hide()
        TypeApp.Show()
    End Sub

    Private Sub RToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RToolStripMenuItem.Click
        Me.Hide()
        CaclsApp.Show()
    End Sub

    Private Sub RDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDToolStripMenuItem.Click
        Me.Hide()
        RDApp.Show()
    End Sub

    Private Sub SUBSTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUBSTToolStripMenuItem.Click
        Me.Hide()
        SUBSTApp.Show()
    End Sub

    Private Sub SYSTEMINFOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SYSTEMINFOToolStripMenuItem.Click
        Me.Hide()
        SystemInfoApp.Show()
    End Sub

    Private Sub RToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RToolStripMenuItem1.Click
        Me.Hide()
        WhereApp.Show()
    End Sub

    Private Sub CONVERTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CONVERTToolStripMenuItem.Click

    End Sub

    Private Sub chkbxLangue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxLangue.CheckedChanged

        'Changement de langue des mot du menus

        If chkbxLangue.Checked = True Then ' boite cochée=FR donc, default pour la checkbox est checked

            chkbxLangue.Text = "Français"
            FichierToolStripMenuItem.Text = "Fichier"
            ToolStripMenuItem2.Text = "Aide"
            AideToolStripMenuItem.Text = "Ouvrir l'aide"
            QuiterToolStripMenuItem.Text = "Quitter"
            EnglishToolStripMenuItem.Text = "Anglais"
            FrançaisToolStripMenuItem.Text = "Français"
            LangueToolStripMenuItem.Text = "Langue"


        Else
            chkbxLangue.Text = "English" ' boite PAS cochée=EN 
            FichierToolStripMenuItem.Text = "File"
            ToolStripMenuItem2.Text = "Help"
            AideToolStripMenuItem.Text = "Open Help"
            QuiterToolStripMenuItem.Text = "Quit"
            FrançaisToolStripMenuItem.Text = "French"
            EnglishToolStripMenuItem.Text = "English"
            LangueToolStripMenuItem.Text = "Language"


        End If
    End Sub

    Private Sub FrançaisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrançaisToolStripMenuItem.Click

        'langue selectionner Francais
        Me.chkbxLangue.Checked = True
        AssocApp.chkbxLangue.Checked = True
        AttribApp.chkbxLangue.Checked = True
        CHKDSkApp.chkbxLangue.Checked = True             'changement de la langue
        CMDConsole.chkbxLangue.Checked = True
        CompactApp.chkbxLangue.Checked = True
        HelpApp.chkbxLangue.Checked = True
        WhoamiApp.chkbxLangue.Checked = True
        XCopyApp.chkbxLangue.Checked = True
        WhoamiApp.chkbxLangue.Checked = True
        TracertApp.chkbxLangue.Checked = True
        TypeApp.chkbxLangue.Checked = True

        'changemement du menu flash selon la langue
        FlashCPFR.Show()
        FlashCPEN.Hide()


    End Sub

    Private Sub EnglishToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnglishToolStripMenuItem.Click

        'langue selectionner anglais
        Me.chkbxLangue.Checked = False
        AssocApp.chkbxLangue.Checked = False
        AttribApp.chkbxLangue.Checked = False
        CHKDSkApp.chkbxLangue.Checked = False                'changement de langue
        CMDConsole.chkbxLangue.Checked = False
        CompactApp.chkbxLangue.Checked = False
        HelpApp.chkbxLangue.Checked = False
        WhoamiApp.chkbxLangue.Checked = False
        XCopyApp.chkbxLangue.Checked = False
        WhoamiApp.chkbxLangue.Checked = False
        TracertApp.chkbxLangue.Checked = False
        TypeApp.chkbxLangue.Checked = False

        'changement du menu selon la langue
        FlashCPFR.Hide()
        FlashCPEN.Show()


    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub CP_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
