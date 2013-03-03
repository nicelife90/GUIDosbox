' [--> GUIDosbox <--]
' Créé par : Nice-Life90
' http://www.guidosbox.com
' Copyright (C) 2010 - 2013 GUIDosbox - Montréal 
' Tous droits réservés

' [--> Contenue du fichhier <-] 
' Ce fichier est un control d'utilisateur personalisé.
' Il contient une bare de progression.

Option Strict On
Option Explicit On

Imports System.Drawing
Imports System.IO
Imports System.ComponentModel
Imports System.Drawing.Color

''' <summary>
''' ProgressBar Personalicé.
''' </summary>
''' <remarks></remarks>
Public Class GUIDosbox_ProgressBar

    Dim pgbWidth As Integer = 0
    Dim pgbPercent As Integer = 0
    Dim lbl2Text As String = "Prêt"

    Public Property FillProgress() As Integer
        Get
            Return pgbPercent
        End Get
        Set(ByVal value As Integer)
            pgbPercent = value
            pgbWidth = CInt(value * 568 / 100)
            PictureBox1.Width = pgbWidth
        End Set
    End Property

    Public Property OutputText() As String
        Get
            Return lbl2Text
        End Get
        Set(ByVal value As String)
            lbl2Text = value
            Label2.Text = value
        End Set
    End Property

    Private Sub WowProgressBar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Width = pgbWidth
        Label2.Text = lbl2Text
    End Sub

End Class
