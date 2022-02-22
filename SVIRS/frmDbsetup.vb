Imports System.Data.OleDb
Public Class frmDbsetup

    Dim success As Boolean = False

    Private Sub frmDbsetup_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If success = True Then
            frmLogin.txtUser.Enabled = True
            frmLogin.txtPwd.Enabled = True

        End If
    End Sub
    Private Sub frmDbsetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtServer.EditValue = ""
        txtLogin.EditValue = ""
        txtPassword.EditValue = ""
        txtDatabase.EditValue = ""
    End Sub

    Private Sub cmdTest_Click(sender As Object, e As EventArgs) Handles cmdTest.Click
        Try
            Dim _conn As New OleDbConnection("Provider=SQLOledb.1; Data Source=" + txtServer.EditValue.ToString.Trim + "; User ID=" + txtLogin.EditValue.ToString.Trim + "; Password=" + txtPassword.EditValue.ToString.Trim + "; Initial Catalog=" + txtDatabase.EditValue.ToString.Trim)
            _conn.Open()
            _conn.Close()
            success = True
            MsgBox("Connection is successful!", MsgBoxStyle.Information, ProgName)

        Catch ex As Exception
            success = False
            MsgBox("Connection is failed!", MsgBoxStyle.Critical, ProgName)
        End Try


    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If success = True Then
            Try
                Dim wr As New System.IO.StreamWriter(".\config.ini", False)
                wr.WriteLine(EncryptText(txtServer.EditValue.ToString.Trim))
                wr.WriteLine(EncryptText(txtLogin.EditValue.ToString.Trim))
                wr.WriteLine(EncryptText(txtPassword.EditValue.ToString.Trim))
                wr.WriteLine(EncryptText(txtDatabase.EditValue.ToString.Trim))
                wr.Close()
                MsgBox("Database setup is updated successfully!", MsgBoxStyle.Information, ProgName)
                IRSDBConnection = New DBConnect()
                IRSDBConnection.Open(txtServer.EditValue.ToString.Trim, txtLogin.EditValue.ToString.Trim, txtPassword.EditValue.ToString.Trim, txtDatabase.EditValue.ToString.Trim)
                Me.Close()
            Catch ex As Exception
                success = False
                MsgBox(ex.Message, MsgBoxStyle.Critical, ProgName)
            End Try
            
        End If
    End Sub
End Class