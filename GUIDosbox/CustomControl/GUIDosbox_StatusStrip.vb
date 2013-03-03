' [--> GUIDosbox <--]
' Créé par : Nice-Life90
' http://www.guidosbox.com
' Copyright (C) 2010 - 2013 GUIDosbox - Montréal 
' Tous droits réservés

' [--> Contenue du fichhier <-] 
' Ce code est un StatusStrip personalisé.

Option Strict On
Option Explicit On

''' <summary>
''' ToolStrip Personnalisé GUIDosbox
''' </summary>
Public Class GUIDosbox_StatusStrip

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

    ''' <summary>
    ''' Gère l'affichage dans le StatusStrip en fonction des privilèges requis par l'utilitaire.
    ''' </summary>
    ''' <param name="level">1 --> Requis Administrateur, 2 --> Requis Utilisateur, -1 --> Rien de requis</param>
    Public Sub PrivilegeLevelNeeded(ByVal level As Integer)
        Select Case level
            'Require Administrateur
            Case 1
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
                'Require User
            Case 2
                If Not RunAsAdmin() Then
                    lblPrivilegesStatus.ForeColor = Color.LightBlue
                    lblPrivilegesStatus.Text = "Utilisateur"
                    lblFonctionanliteStatus.ForeColor = Color.MediumPurple
                    lblFonctionanliteStatus.Text = "Complètes"
                Else
                    lblPrivilegesStatus.ForeColor = Color.MediumPurple
                    lblPrivilegesStatus.Text = "Administrateur"
                    lblFonctionanliteStatus.ForeColor = Color.Maroon
                    lblFonctionanliteStatus.Text = "Limité"
                End If
                'Nothing Required
            Case -1
                If RunAsAdmin() Then
                    lblPrivilegesStatus.ForeColor = Color.MediumPurple
                    lblPrivilegesStatus.Text = "Administrateur"
                    lblFonctionanliteStatus.ForeColor = Color.MediumPurple
                    lblFonctionanliteStatus.Text = "Complètes"
                Else
                    lblPrivilegesStatus.ForeColor = Color.LightBlue
                    lblPrivilegesStatus.Text = "Utilisateur"
                    lblFonctionanliteStatus.ForeColor = Color.MediumPurple
                    lblFonctionanliteStatus.Text = "Complètes"
                End If
            Case Else

        End Select
    End Sub

End Class
