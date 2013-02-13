''' <summary>
''' ToolStrip Personnalisé GUIDosbox
''' </summary>
Public Class GUIDosbox_StatusStrip

    Public Sub GUIDosbox_StatusStrip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If RunAsAdmin() Then
            lblPrivilegesStatus.ForeColor = Color.MediumPurple
            lblPrivilegesStatus.Text = "Administrateur"
            lblFonctionanliteStatus.ForeColor = Color.MediumPurple
            lblFonctionanliteStatus.Text = "Complètes"
        Else
            lblPrivilegesStatus.ForeColor = Color.LightBlue
            lblPrivilegesStatus.Text = "Utilisateur"
            lblFonctionanliteStatus.ForeColor = Color.Maroon
            lblFonctionanliteStatus.Text = "Limité"
        End If
    End Sub

    ''' <summary>
    ''' Active ou désactive l'affichage du mode avancé dans le status strip
    ''' </summary>
    ''' <param name="State">True --> ON, False --> OFF</param>
    Public Sub AdvanceMode(ByVal State As Boolean)
        If State = True Then
            lblModeStatus.ForeColor = Color.MediumPurple
            lblModeStatus.Text = "Avancé"
        Else
            lblModeStatus.ForeColor = Color.LightBlue
            lblModeStatus.Text = "Normal"
        End If
    End Sub

End Class
