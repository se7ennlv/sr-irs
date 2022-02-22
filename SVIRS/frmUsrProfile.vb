Public Class frmUsrProfile 

    Private Sub frmUsrProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUID.EditValue = IRSession.UserID
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim res As MsgBoxResult = MsgBox("Are you sure to update your profile?", MsgBoxStyle.YesNo, ProgName)
        If res = MsgBoxResult.Yes Then
            IRSDBConnection.StartUpdateCommand("sys_users")
            IRSDBConnection.SetWhereField("USERID", txtUID.EditValue.ToString.Trim)
            IRSDBConnection.SetUpdateField("FNAME", txtFName.EditValue.ToString.Trim)
            IRSDBConnection.SetUpdateField("LNAME", txtLName.EditValue.ToString.Trim)
            IRSDBConnection.SetUpdateField("PWD", EncryptText(txtPwd.EditValue.ToString.Trim))
            IRSDBConnection.SetUpdateField("EMAIL", txtEmail.EditValue.ToString.Trim)
            IRSDBConnection.SetUpdateField("SAGEUID", txtSageId.EditValue.ToString.Trim)
            IRSDBConnection.SetUpdateField("SAGEPWD", EncryptText(txtSagePwd.EditValue.ToString.Trim))
            IRSDBConnection.ExecuteUpdateCommand()

        End If

        Me.Close()

    End Sub

    Private Sub txtUID_EditValueChanged(sender As Object, e As EventArgs) Handles txtUID.EditValueChanged
        If txtUID.EditValue.ToString.Trim <> "" Then
            Dim v As New View()
            v = OpenView("SystemUser", 0)
            v.Init()
            v.Filter("userid='" + txtUID.EditValue.ToString.Trim() + "'")
            v.EndFilter()

            txtFName.EditValue = v.GetFieldValueByID("FNAME").ToString.Trim
            txtLName.EditValue = v.GetFieldValueByID("LNAME").ToString.Trim
            txtPwd.EditValue = DecryptText(v.GetFieldValueByID("PWD").ToString.Trim)
            txtEmail.EditValue = v.GetFieldValueByID("EMAIL").ToString.Trim
            txtSageId.EditValue = v.GetFieldValueByID("SAGEUID").ToString.Trim
            txtSagePwd.EditValue = DecryptText(v.GetFieldValueByID("SAGEPWD").ToString.Trim)
            lstUType.SelectedIndex = v.GetFieldValueByID("UTYPE")
            swActive.EditValue = v.GetFieldValueByID("SWACTIVE")
        End If
        
    End Sub
End Class