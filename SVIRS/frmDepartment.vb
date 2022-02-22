Public Class frmDepartment 

    Private Sub btnLocAdd_Click(sender As Object, e As EventArgs) Handles btnLocAdd.Click
        If rvDepCode.CurrentValue <> "" Then
            gvLoc.AddNewRow()
            gvLoc.AddNewRow()
            gvLoc.DeleteRow(gvLoc.FocusedRowHandle)
        End If
    End Sub

    Private Sub frmDepartment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgLoc.DataSource = IRSDBConnection.SelectFields("select location, locdesc from tbl_deplocation where 0=1")
        dgEmployee.DataSource = IRSDBConnection.SelectFields("select userid, username from tbl_depemployee where 0=1")
        dgInvCtrl.DataSource = IRSDBConnection.SelectFields("select userid, username from tbl_depinvcontroler where 0=1")
        dgReqAppv.DataSource = IRSDBConnection.SelectFields("select userid, username from tbl_depreqapprover where 0=1")
        dgInvAppv.DataSource = IRSDBConnection.SelectFields("select userid, username from tbl_depinvapprover where 0=1")
        txtDesc.EditValue = ""
        txtIAMail.EditValue = ""
        txtICMail.EditValue = ""
        txtRAMail.EditValue = ""
        swInvCtrl.EditValue = False
    End Sub

    Private Sub dgLoc_DoubleClick(sender As Object, e As EventArgs) Handles dgLoc.DoubleClick
        Try
            Dim i As Integer = gvLoc.FocusedRowHandle
            If gvLoc.FocusedColumn.Name = "colLocId" Then
                Dim fm As New fmFinder
                fm.Caption = "Find Location"
                fm.SetViewID("Location", 1)
                fm.ReturnField = "LOCATION"
                fm.TargetGridView = gvLoc
                fm.ShowFinder()

            Else

                Dim loc As String = gvLoc.GetRowCellValue(i, colLocId).ToString.Trim
                Dim desc As String = SageDBConnection.SelectField("select [desc] from icloc where location='" + loc + "'").ToString.Trim
                gvLoc.SetRowCellValue(i, colLocDesc, desc)


            End If
        Catch ex As Exception

        End Try
    End Sub


    
    Private Sub btnEmpAdd_Click(sender As Object, e As EventArgs) Handles btnEmpAdd.Click
        If rvDepCode.CurrentValue <> "" Then
            gvEmployee.AddNewRow()
            gvEmployee.AddNewRow()
            gvEmployee.DeleteRow(gvEmployee.FocusedRowHandle)
        End If
    End Sub

    Private Sub dgEmployee_DoubleClick(sender As Object, e As EventArgs) Handles dgEmployee.DoubleClick
        Try
            Dim i As Integer = gvEmployee.FocusedRowHandle
            If gvEmployee.FocusedColumn.Name = "colEmpCode" Then
                Dim fm As New fmFinder
                fm.Caption = "Find User"
                fm.SetViewID("SystemUser", 0)
                fm.ReturnField = "USERID"
                fm.TargetGridView = gvEmployee
                fm.ShowFinder()

            Else

                Dim userid As String = gvEmployee.GetRowCellValue(i, colEmpCode).ToString.Trim
                Dim name As String = IRSDBConnection.SelectField("select rtrim(fname) + ' ' + rtrim(lname) as 'name' from sys_users where userid='" + userid + "'").ToString.Trim
                gvEmployee.SetRowCellValue(i, colEmpName, name)


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnICAdd_Click(sender As Object, e As EventArgs) Handles btnICAdd.Click
        If rvDepCode.CurrentValue <> "" Then
            gvInvCtrl.AddNewRow()
            gvInvCtrl.AddNewRow()
            gvInvCtrl.DeleteRow(gvInvCtrl.FocusedRowHandle)
        End If
    End Sub

    Private Sub dgInvCtrl_DoubleClick(sender As Object, e As EventArgs) Handles dgInvCtrl.DoubleClick
        Try
            Dim i As Integer = gvInvCtrl.FocusedRowHandle
            If gvInvCtrl.FocusedColumn.Name = "colICCode" Then
                Dim fm As New fmFinder
                fm.Caption = "Find User"
                fm.SetViewID("SystemUser", 0)
                fm.ReturnField = "USERID"
                fm.AddFilterFields("UTYPE", 2)
                fm.TargetGridView = gvInvCtrl
                fm.ShowFinder()

            Else

                Dim userid As String = gvInvCtrl.GetRowCellValue(i, colICCode).ToString.Trim
                Dim name As String = IRSDBConnection.SelectField("select rtrim(fname) + ' ' + rtrim(lname) as 'name' from sys_users where userid='" + userid + "'").ToString.Trim
                gvInvCtrl.SetRowCellValue(i, colICName, name)


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRAAdd_Click(sender As Object, e As EventArgs) Handles btnRAAdd.Click
        If rvDepCode.CurrentValue <> "" Then
            gvReqAppv.AddNewRow()
            gvReqAppv.AddNewRow()
            gvReqAppv.DeleteRow(gvReqAppv.FocusedRowHandle)
        End If
    End Sub

    Private Sub dgReqAppv_DoubleClick(sender As Object, e As EventArgs) Handles dgReqAppv.DoubleClick
        Try
            Dim i As Integer = gvReqAppv.FocusedRowHandle
            If gvReqAppv.FocusedColumn.Name = "colRACode" Then
                Dim fm As New fmFinder
                fm.Caption = "Find User"
                fm.SetViewID("SystemUser", 0)
                fm.ReturnField = "USERID"
                fm.AddFilterFields("UTYPE", 1)
                fm.TargetGridView = gvReqAppv
                fm.ShowFinder()

            Else

                Dim userid As String = gvReqAppv.GetRowCellValue(i, colRACode).ToString.Trim
                Dim name As String = IRSDBConnection.SelectField("select rtrim(fname) + ' ' + rtrim(lname) as 'name' from sys_users where userid='" + userid + "'").ToString.Trim
                gvReqAppv.SetRowCellValue(i, colRAName, name)


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnIAAdd_Click(sender As Object, e As EventArgs) Handles btnIAAdd.Click
        If rvDepCode.CurrentValue <> "" Then
            gvInvAppv.AddNewRow()
            gvInvAppv.AddNewRow()
            gvInvAppv.DeleteRow(gvInvAppv.FocusedRowHandle)
        End If
    End Sub

    Private Sub dgInvAppv_DoubleClick(sender As Object, e As EventArgs) Handles dgInvAppv.DoubleClick
        Try
            Dim i As Integer = gvInvAppv.FocusedRowHandle
            If gvInvAppv.FocusedColumn.Name = "colIACode" Then
                Dim fm As New fmFinder
                fm.Caption = "Find User"
                fm.SetViewID("SystemUser", 0)
                fm.ReturnField = "USERID"
                fm.AddFilterFields("UTYPE", 1)
                fm.TargetGridView = gvInvAppv
                fm.ShowFinder()

            Else

                Dim userid As String = gvInvAppv.GetRowCellValue(i, colIACode).ToString.Trim
                Dim name As String = IRSDBConnection.SelectField("select rtrim(fname) + ' ' + rtrim(lname) as 'name' from sys_users where userid='" + userid + "'").ToString.Trim
                gvInvAppv.SetRowCellValue(i, colIAName, name)


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rvDepCode_SaveRecordFired(sender As Object, e As EventArgs) Handles rvDepCode.SaveRecordFired
        If rvDepCode.IsNewItem Then
            IRSDBConnection.StartInsertCommand("tbl_departments")
            IRSDBConnection.InsertField("depcode", rvDepCode.CurrentValue)
            IRSDBConnection.InsertField("depdesc", txtDesc.EditValue.ToString.Trim)
            IRSDBConnection.InsertField("swinvctrl", swInvCtrl.EditValue)
            IRSDBConnection.InsertField("icgrpmail", txtICMail.EditValue.ToString.Trim)
            IRSDBConnection.InsertField("ragrpmail", txtRAMail.EditValue.ToString.Trim)
            IRSDBConnection.InsertField("iagrpmail", txtIAMail.EditValue.ToString.Trim)
            IRSDBConnection.ExecuteInsertCommand()

            For i As Integer = 0 To gvLoc.RowCount - 1
                IRSDBConnection.StartInsertCommand("tbl_deplocation")
                IRSDBConnection.InsertField("depcode", rvDepCode.CurrentValue)
                IRSDBConnection.InsertField("location", gvLoc.GetRowCellValue(i, colLocId).ToString.Trim)
                IRSDBConnection.InsertField("locdesc", gvLoc.GetRowCellValue(i, colLocDesc).ToString.Trim)
                IRSDBConnection.ExecuteInsertCommand()
            Next

            For i As Integer = 0 To gvEmployee.RowCount - 1
                IRSDBConnection.StartInsertCommand("tbl_depemployee")
                IRSDBConnection.InsertField("depcode", rvDepCode.CurrentValue)
                IRSDBConnection.InsertField("userid", gvEmployee.GetRowCellValue(i, colEmpCode).ToString.Trim)
                IRSDBConnection.InsertField("username", gvEmployee.GetRowCellValue(i, colEmpName).ToString.Trim)
                IRSDBConnection.ExecuteInsertCommand()
            Next

            For i As Integer = 0 To gvInvCtrl.RowCount - 1
                IRSDBConnection.StartInsertCommand("tbl_depinvcontroler")
                IRSDBConnection.InsertField("depcode", rvDepCode.CurrentValue)
                IRSDBConnection.InsertField("userid", gvInvCtrl.GetRowCellValue(i, colICCode).ToString.Trim)
                IRSDBConnection.InsertField("username", gvInvCtrl.GetRowCellValue(i, colICName).ToString.Trim)
                IRSDBConnection.ExecuteInsertCommand()
            Next

            For i As Integer = 0 To gvReqAppv.RowCount - 1
                IRSDBConnection.StartInsertCommand("tbl_depreqapprover")
                IRSDBConnection.InsertField("depcode", rvDepCode.CurrentValue)
                IRSDBConnection.InsertField("userid", gvReqAppv.GetRowCellValue(i, colRACode).ToString.Trim)
                IRSDBConnection.InsertField("username", gvReqAppv.GetRowCellValue(i, colRAName).ToString.Trim)
                IRSDBConnection.ExecuteInsertCommand()
            Next

            For i As Integer = 0 To gvInvAppv.RowCount - 1
                IRSDBConnection.StartInsertCommand("tbl_depinvapprover")
                IRSDBConnection.InsertField("depcode", rvDepCode.CurrentValue)
                IRSDBConnection.InsertField("userid", gvInvAppv.GetRowCellValue(i, colIACode).ToString.Trim)
                IRSDBConnection.InsertField("username", gvInvAppv.GetRowCellValue(i, colIAName).ToString.Trim)
                IRSDBConnection.ExecuteInsertCommand()
            Next

            MsgBox("New department is created successfully.", MsgBoxStyle.OkOnly, ProgName)


        Else

            Dim res As MsgBoxResult = MsgBox("Are you sure to edit this department?", MsgBoxStyle.YesNo, ProgName)
            If res = MsgBoxResult.Yes Then

                IRSDBConnection.StartUpdateCommand("tbl_departments")
                IRSDBConnection.SetWhereField("depcode", rvDepCode.CurrentValue)
                IRSDBConnection.SetUpdateField("depdesc", txtDesc.EditValue.ToString.Trim)
                IRSDBConnection.SetUpdateField("swinvctrl", swInvCtrl.EditValue)
                IRSDBConnection.SetUpdateField("icgrpmail", txtICMail.EditValue.ToString.Trim)
                IRSDBConnection.SetUpdateField("ragrpmail", txtRAMail.EditValue.ToString.Trim)
                IRSDBConnection.SetUpdateField("iagrpmail", txtIAMail.EditValue.ToString.Trim)
                IRSDBConnection.ExecuteUpdateCommand()

                IRSDBConnection.StartDeleteCommand("tbl_deplocation")
                IRSDBConnection.SetWhereField("depcode", rvDepCode.CurrentValue)
                IRSDBConnection.ExecuteDeleteCommand()
                For i As Integer = 0 To gvLoc.RowCount - 1
                    IRSDBConnection.StartInsertCommand("tbl_deplocation")
                    IRSDBConnection.InsertField("depcode", rvDepCode.CurrentValue)
                    IRSDBConnection.InsertField("location", gvLoc.GetRowCellValue(i, colLocId).ToString.Trim)
                    IRSDBConnection.InsertField("locdesc", gvLoc.GetRowCellValue(i, colLocDesc).ToString.Trim)
                    IRSDBConnection.ExecuteInsertCommand()
                Next

                IRSDBConnection.StartDeleteCommand("tbl_depemployee")
                IRSDBConnection.SetWhereField("depcode", rvDepCode.CurrentValue)
                IRSDBConnection.ExecuteDeleteCommand()
                For i As Integer = 0 To gvEmployee.RowCount - 1
                    IRSDBConnection.StartInsertCommand("tbl_depemployee")
                    IRSDBConnection.InsertField("depcode", rvDepCode.CurrentValue)
                    IRSDBConnection.InsertField("userid", gvEmployee.GetRowCellValue(i, colEmpCode).ToString.Trim)
                    IRSDBConnection.InsertField("username", gvEmployee.GetRowCellValue(i, colEmpName).ToString.Trim)
                    IRSDBConnection.ExecuteInsertCommand()
                Next

                IRSDBConnection.StartDeleteCommand("tbl_depinvcontroler")
                IRSDBConnection.SetWhereField("depcode", rvDepCode.CurrentValue)
                IRSDBConnection.ExecuteDeleteCommand()
                For i As Integer = 0 To gvInvCtrl.RowCount - 1
                    IRSDBConnection.StartInsertCommand("tbl_depinvcontroler")
                    IRSDBConnection.InsertField("depcode", rvDepCode.CurrentValue)
                    IRSDBConnection.InsertField("userid", gvInvCtrl.GetRowCellValue(i, colICCode).ToString.Trim)
                    IRSDBConnection.InsertField("username", gvInvCtrl.GetRowCellValue(i, colICName).ToString.Trim)
                    IRSDBConnection.ExecuteInsertCommand()
                Next

                IRSDBConnection.StartDeleteCommand("tbl_depreqapprover")
                IRSDBConnection.SetWhereField("depcode", rvDepCode.CurrentValue)
                IRSDBConnection.ExecuteDeleteCommand()
                For i As Integer = 0 To gvReqAppv.RowCount - 1
                    IRSDBConnection.StartInsertCommand("tbl_depreqapprover")
                    IRSDBConnection.InsertField("depcode", rvDepCode.CurrentValue)
                    IRSDBConnection.InsertField("userid", gvReqAppv.GetRowCellValue(i, colRACode).ToString.Trim)
                    IRSDBConnection.InsertField("username", gvReqAppv.GetRowCellValue(i, colRAName).ToString.Trim)
                    IRSDBConnection.ExecuteInsertCommand()
                Next

                IRSDBConnection.StartDeleteCommand("tbl_depinvapprover")
                IRSDBConnection.SetWhereField("depcode", rvDepCode.CurrentValue)
                IRSDBConnection.ExecuteDeleteCommand()
                For i As Integer = 0 To gvInvAppv.RowCount - 1
                    IRSDBConnection.StartInsertCommand("tbl_depinvapprover")
                    IRSDBConnection.InsertField("depcode", rvDepCode.CurrentValue)
                    IRSDBConnection.InsertField("userid", gvInvAppv.GetRowCellValue(i, colIACode).ToString.Trim)
                    IRSDBConnection.InsertField("username", gvInvAppv.GetRowCellValue(i, colIAName).ToString.Trim)
                    IRSDBConnection.ExecuteInsertCommand()
                Next

                MsgBox("The department is updated successfully.", MsgBoxStyle.OkOnly, ProgName)

            End If

        End If
    End Sub

    Private Sub rvDepCode_RecordIndexChanged(sender As Object, e As EventArgs) Handles rvDepCode.RecordIndexChanged
        txtDesc.EditValue = rvDepCode.CurrentView.GetFieldValueByID("DEPDESC").ToString.Trim()
        swInvCtrl.EditValue = rvDepCode.CurrentView.GetFieldValueByID("SWINVCTRL")
        txtICMail.EditValue = rvDepCode.CurrentView.GetFieldValueByID("ICGRPMAIL").ToString.Trim
        txtRAMail.EditValue = rvDepCode.CurrentView.GetFieldValueByID("RAGRPMAIL").ToString.Trim
        txtIAMail.EditValue = rvDepCode.CurrentView.GetFieldValueByID("IAGRPMAIL").ToString.Trim

        dgLoc.DataSource = IRSDBConnection.SelectFields("select location,locdesc from tbl_deplocation where depcode='" + rvDepCode.CurrentValue + "'")
        dgEmployee.DataSource = IRSDBConnection.SelectFields("select userid, username from tbl_depemployee where depcode='" + rvDepCode.CurrentValue + "'")
        dgInvCtrl.DataSource = IRSDBConnection.SelectFields("select userid, username from tbl_depinvcontroler where depcode='" + rvDepCode.CurrentValue + "'")
        dgReqAppv.DataSource = IRSDBConnection.SelectFields("select userid, username from tbl_depreqapprover where depcode='" + rvDepCode.CurrentValue + "'")
        dgInvAppv.DataSource = IRSDBConnection.SelectFields("select userid, username from tbl_depinvapprover where depcode='" + rvDepCode.CurrentValue + "'")

    End Sub

    Private Sub btnLocRem_Click(sender As Object, e As EventArgs) Handles btnLocRem.Click
        Try
            gvLoc.DeleteRow(gvLoc.FocusedRowHandle)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEmpRem_Click(sender As Object, e As EventArgs) Handles btnEmpRem.Click
        Try
            gvEmployee.DeleteRow(gvEmployee.FocusedRowHandle)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnICRem_Click(sender As Object, e As EventArgs) Handles btnICRem.Click
        Try
            gvInvCtrl.DeleteRow(gvInvCtrl.FocusedRowHandle)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRARem_Click(sender As Object, e As EventArgs) Handles btnRARem.Click
        Try
            gvReqAppv.DeleteRow(gvReqAppv.FocusedRowHandle)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnIARem_Click(sender As Object, e As EventArgs) Handles btnIARem.Click
        gvInvAppv.DeleteRow(gvInvAppv.FocusedRowHandle)
    End Sub

    Private Sub rvDepCode_NewRecordFired(sender As Object, e As EventArgs) Handles rvDepCode.NewRecordFired
        dgLoc.DataSource = IRSDBConnection.SelectFields("select location, locdesc from tbl_deplocation where 0=1")
        dgEmployee.DataSource = IRSDBConnection.SelectFields("select userid, username from tbl_depemployee where 0=1")
        dgInvCtrl.DataSource = IRSDBConnection.SelectFields("select userid, username from tbl_depinvcontroler where 0=1")
        dgReqAppv.DataSource = IRSDBConnection.SelectFields("select userid, username from tbl_depreqapprover where 0=1")
        dgInvAppv.DataSource = IRSDBConnection.SelectFields("select userid, username from tbl_depinvapprover where 0=1")
        txtDesc.EditValue = ""
        txtIAMail.EditValue = ""
        txtICMail.EditValue = ""
        txtRAMail.EditValue = ""
        swInvCtrl.EditValue = False
    End Sub

    Private Sub rvDepCode_EditValueChanged(sender As Object, e As EventArgs) Handles rvDepCode.EditValueChanged
        txtDesc.EditValue = rvDepCode.CurrentView.GetFieldValueByID("DEPDESC").ToString.Trim()
        swInvCtrl.EditValue = rvDepCode.CurrentView.GetFieldValueByID("SWINVCTRL")
        txtICMail.EditValue = rvDepCode.CurrentView.GetFieldValueByID("ICGRPMAIL").ToString.Trim
        txtRAMail.EditValue = rvDepCode.CurrentView.GetFieldValueByID("RAGRPMAIL").ToString.Trim
        txtIAMail.EditValue = rvDepCode.CurrentView.GetFieldValueByID("IAGRPMAIL").ToString.Trim

        dgLoc.DataSource = IRSDBConnection.SelectFields("select location,locdesc from tbl_deplocation where depcode='" + rvDepCode.CurrentValue + "'")
        dgEmployee.DataSource = IRSDBConnection.SelectFields("select userid, username from tbl_depemployee where depcode='" + rvDepCode.CurrentValue + "'")
        dgInvCtrl.DataSource = IRSDBConnection.SelectFields("select userid, username from tbl_depinvcontroler where depcode='" + rvDepCode.CurrentValue + "'")
        dgReqAppv.DataSource = IRSDBConnection.SelectFields("select userid, username from tbl_depreqapprover where depcode='" + rvDepCode.CurrentValue + "'")
        dgInvAppv.DataSource = IRSDBConnection.SelectFields("select userid, username from tbl_depinvapprover where depcode='" + rvDepCode.CurrentValue + "'")
    End Sub

    Private Sub rvDepCode_DeleteRecordFired(sender As Object, e As EventArgs) Handles rvDepCode.DeleteRecordFired
        If rvDepCode.IsNewItem = False Then
            Dim res As MsgBoxResult = MsgBox("Are you sure to delete this department?", MsgBoxStyle.YesNo, ProgName)
            If res = MsgBoxResult.Yes Then
                IRSDBConnection.StartDeleteCommand("tbl_departments")
                IRSDBConnection.SetWhereField("depcode", rvDepCode.CurrentValue)
                IRSDBConnection.ExecuteDeleteCommand()
                IRSDBConnection.StartDeleteCommand("tbl_deplocation")
                IRSDBConnection.SetWhereField("depcode", rvDepCode.CurrentValue)
                IRSDBConnection.ExecuteDeleteCommand()
                IRSDBConnection.StartDeleteCommand("tbl_depemployee")
                IRSDBConnection.SetWhereField("depcode", rvDepCode.CurrentValue)
                IRSDBConnection.ExecuteDeleteCommand()
                IRSDBConnection.StartDeleteCommand("tbl_depinvcontroler")
                IRSDBConnection.SetWhereField("depcode", rvDepCode.CurrentValue)
                IRSDBConnection.ExecuteDeleteCommand()
                IRSDBConnection.StartDeleteCommand("tbl_depreqapprover")
                IRSDBConnection.SetWhereField("depcode", rvDepCode.CurrentValue)
                IRSDBConnection.ExecuteDeleteCommand()
                IRSDBConnection.StartDeleteCommand("tbl_depinvapprover")
                IRSDBConnection.SetWhereField("depcode", rvDepCode.CurrentValue)
                IRSDBConnection.ExecuteDeleteCommand()

                MsgBox("Department is deleted.", MsgBoxStyle.Information, ProgName)
                rvDepCode.CurrentValue = ""

            End If
        End If
    End Sub
End Class