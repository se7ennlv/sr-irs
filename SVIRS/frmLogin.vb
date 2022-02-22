Imports System.ComponentModel
Imports System.Text

Public Class frmLogin
    Inherits DevExpress.XtraEditors.XtraForm
    Public Sub New()
        InitializeComponent()
    End Sub

   
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DevExpress.UserSkins.BonusSkins.Register()
            DevExpress.Skins.SkinManager.EnableFormSkins()

            dtSession.EditValue = Now.Date()
            txtUser.EditValue = ""
            txtPwd.EditValue = ""
            txtUser.Enabled = False
            txtPwd.Enabled = False

            txtUser.Focus()
            txtUser.Select(0, 0)
        Catch ex As Exception

        End Try

        'MsgBox(DecryptText("GzBfxnoaIjOrvCrBsfUeBg=="))
    End Sub



    Private Sub frmLogin_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            If ConfigFileValid() = False Then
                Dim frm As New frmDbsetup
                frm.ShowDialog()
            Else
                txtUser.Enabled = True
                txtPwd.Enabled = True
                RefreshConnection()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        Dim uid As String = txtUser.EditValue.ToString.Trim()
        Dim pwd As String = EncryptText(txtPwd.EditValue.ToString.Trim).Trim()

        IRSession.Open(uid, pwd, dtSession.EditValue)
        If IRSession.Connected = True Then
            frmMaster.Show()
            Me.Hide()
            txtUser.EditValue = ""
            txtPwd.EditValue = ""
        Else
            MsgBox("Invalid ID or Password, Please again!", MsgBoxStyle.OkOnly, ProgName)
        End If

    End Sub
End Class
