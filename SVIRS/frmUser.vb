Public Class frmUser 

    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstUser.CurrentValue = ""
    End Sub

    Private Sub lstUser_EditValueChanged(sender As Object, e As EventArgs) Handles lstUser.EditValueChanged
        Try
            txtFName.EditValue = lstUser.CurrentView.GetFieldValueByID("FNAME").ToString.Trim
            txtLName.EditValue = lstUser.CurrentView.GetFieldValueByID("LNAME").ToString.Trim
            txtPwd.EditValue = DecryptText(lstUser.CurrentView.GetFieldValueByID("PWD").ToString.Trim)
            txtEmail.EditValue = lstUser.CurrentView.GetFieldValueByID("EMAIL").ToString.Trim
            txtSageId.EditValue = lstUser.CurrentView.GetFieldValueByID("SAGEUID").ToString.Trim
            txtSagePwd.EditValue = DecryptText(lstUser.CurrentView.GetFieldValueByID("SAGEPWD").ToString.Trim)
            lstUType.SelectedIndex = lstUser.CurrentView.GetFieldValueByID("UTYPE")
            swActive.EditValue = lstUser.CurrentView.GetFieldValueByID("SWACTIVE")
            txtJobTitle.EditValue = lstUser.CurrentView.GetFieldValueByID("JOBTITLE").ToString.Trim

            If lstUser.CurrentValue = "ADMIN" Then
                lstUType.ReadOnly = True
                swActive.Enabled = False
            Else
                lstUType.ReadOnly = False
                swActive.Enabled = True
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub lstUser_NewRecordFired(sender As Object, e As EventArgs) Handles lstUser.NewRecordFired
        txtFName.EditValue = ""
        txtLName.EditValue = ""
        txtPwd.EditValue = ""
        txtEmail.EditValue = ""
        txtSageId.EditValue = ""
        txtSagePwd.EditValue = ""
        lstUType.SelectedIndex = 0
        swActive.EditValue = True
        lstUType.ReadOnly = False
        txtJobTitle.EditValue = ""

    End Sub

    Private Sub lstUser_RecordIndexChanged(sender As Object, e As EventArgs) Handles lstUser.RecordIndexChanged
        Try
            txtFName.EditValue = lstUser.CurrentView.GetFieldValueByID("FNAME").ToString.Trim
            txtLName.EditValue = lstUser.CurrentView.GetFieldValueByID("LNAME").ToString.Trim
            txtPwd.EditValue = DecryptText(lstUser.CurrentView.GetFieldValueByID("PWD").ToString.Trim)
            txtEmail.EditValue = lstUser.CurrentView.GetFieldValueByID("EMAIL").ToString.Trim
            txtSageId.EditValue = lstUser.CurrentView.GetFieldValueByID("SAGEUID").ToString.Trim
            txtSagePwd.EditValue = DecryptText(lstUser.CurrentView.GetFieldValueByID("SAGEPWD").ToString.Trim)
            lstUType.SelectedIndex = lstUser.CurrentView.GetFieldValueByID("UTYPE")
            swActive.EditValue = lstUser.CurrentView.GetFieldValueByID("SWACTIVE")
            txtJobTitle.EditValue = lstUser.CurrentView.GetFieldValueByID("JOBTITLE").ToString.Trim

            If lstUser.CurrentValue = "ADMIN" Then
                lstUType.ReadOnly = True
                swActive.Enabled = False
            Else
                lstUType.ReadOnly = False
                swActive.Enabled = True
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub lstUser_SaveRecordFired(sender As Object, e As EventArgs) Handles lstUser.SaveRecordFired
        If lstUser.IsNewItem = True Then
            IRSDBConnection.StartInsertCommand("sys_users")
            IRSDBConnection.InsertField("USERID", lstUser.CurrentValue)
            IRSDBConnection.InsertField("FNAME", txtFName.EditValue.ToString.Trim)
            IRSDBConnection.InsertField("LNAME", txtLName.EditValue.ToString.Trim)
            IRSDBConnection.InsertField("PWD", EncryptText(txtPwd.EditValue.ToString.Trim))
            IRSDBConnection.InsertField("EMAIL", txtEmail.EditValue.ToString.Trim)
            IRSDBConnection.InsertField("SAGEUID", txtSageId.EditValue.ToString.Trim)
            IRSDBConnection.InsertField("SAGEPWD", EncryptText(txtSagePwd.EditValue.ToString.Trim.ToUpper))
            IRSDBConnection.InsertField("SWACTIVE", swActive.EditValue)
            IRSDBConnection.InsertField("UTYPE", lstUType.SelectedIndex)
            IRSDBConnection.InsertField("JOBTITLE", txtJobTitle.EditValue.ToString.Trim)
            IRSDBConnection.ExecuteInsertCommand()

            MsgBox("User is created.", MsgBoxStyle.Information, ProgName)

        Else
            Dim res As MsgBoxResult = MsgBox("Are you sure to update this user?", MsgBoxStyle.YesNo, ProgName)
            If res = MsgBoxResult.Yes Then
                IRSDBConnection.StartUpdateCommand("sys_users")
                IRSDBConnection.SetWhereField("USERID", lstUser.CurrentValue)
                IRSDBConnection.SetUpdateField("FNAME", txtFName.EditValue.ToString.Trim)
                IRSDBConnection.SetUpdateField("LNAME", txtLName.EditValue.ToString.Trim)
                IRSDBConnection.SetUpdateField("PWD", EncryptText(txtPwd.EditValue.ToString.Trim))
                IRSDBConnection.SetUpdateField("EMAIL", txtEmail.EditValue.ToString.Trim)
                IRSDBConnection.SetUpdateField("SAGEUID", txtSageId.EditValue.ToString.Trim)
                IRSDBConnection.SetUpdateField("SAGEPWD", EncryptText(txtSagePwd.EditValue.ToString.Trim.ToUpper))
                IRSDBConnection.SetUpdateField("SWACTIVE", swActive.EditValue)
                IRSDBConnection.SetUpdateField("UTYPE", lstUType.SelectedIndex)
                IRSDBConnection.SetUpdateField("JOBTITLE", txtJobTitle.EditValue.ToString.Trim)
                IRSDBConnection.ExecuteUpdateCommand()

                MsgBox("User is updated.", MsgBoxStyle.Information, ProgName)
            End If
        End If
    End Sub

    Private Sub lstUser_DeleteRecordFired(sender As Object, e As EventArgs) Handles lstUser.DeleteRecordFired
        If lstUser.IsNewItem = False And lstUser.CurrentValue <> "ADMIN" Then
            Dim res As MsgBoxResult = MsgBox("Are you sure to delete this user?", MsgBoxStyle.YesNo, ProgName)
            If res = MsgBoxResult.Yes Then
                IRSDBConnection.StartDeleteCommand("sys_users")
                IRSDBConnection.SetWhereField("userid", lstUser.CurrentValue)
                IRSDBConnection.ExecuteDeleteCommand()
                IRSDBConnection.StartDeleteCommand("tbl_depemployee")
                IRSDBConnection.SetWhereField("userid", lstUser.CurrentValue)
                IRSDBConnection.ExecuteDeleteCommand()
                IRSDBConnection.StartDeleteCommand("tbl_depinvcontroler")
                IRSDBConnection.SetWhereField("userid", lstUser.CurrentValue)
                IRSDBConnection.ExecuteDeleteCommand()
                IRSDBConnection.StartDeleteCommand("tbl_depreqapprover")
                IRSDBConnection.SetWhereField("userid", lstUser.CurrentValue)
                IRSDBConnection.ExecuteDeleteCommand()
                IRSDBConnection.StartDeleteCommand("tbl_depinvapprover")
                IRSDBConnection.SetWhereField("userid", lstUser.CurrentValue)
                IRSDBConnection.ExecuteDeleteCommand()

                MsgBox("User is delete.", MsgBoxStyle.Information, ProgName)
                lstUser.CurrentValue = ""
            End If
        Else
            MsgBox("ADMIN user cannot be deleted.", MsgBoxStyle.Information, ProgName)
        End If
    End Sub
End Class