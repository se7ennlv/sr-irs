Public Class frmRptManager 

    Private Sub rvReport_NewRecordFired(sender As Object, e As EventArgs) Handles rvReport.NewRecordFired
        txtDesc.EditValue = ""
        txtFile.EditValue = ""
        swSage.EditValue = False
        dgUList.DataSource = IRSDBConnection.SelectFields("select userid, fname + ' ' + lname as 'username' from sys_users")
        dgAlist.DataSource = IRSDBConnection.SelectFields("select userid, username from tbl_reportuser where 0=1")
    End Sub

    Private Sub rvReport_SaveRecordFired(sender As Object, e As EventArgs) Handles rvReport.SaveRecordFired
        If rvReport.IsNewItem = True Then
            IRSDBConnection.StartInsertCommand("tbl_reports")
            IRSDBConnection.InsertField("rptcode", rvReport.CurrentValue)
            IRSDBConnection.InsertField("rptdesc", txtDesc.EditValue.ToString.Trim)
            IRSDBConnection.InsertField("rptfile", txtFile.EditValue.ToString.Trim)
            IRSDBConnection.InsertField("rptsage", swSage.EditValue)
            IRSDBConnection.ExecuteInsertCommand()

            For i As Integer = 0 To gvAList.RowCount - 1
                IRSDBConnection.StartInsertCommand("tbl_reportuser")
                IRSDBConnection.InsertField("rptcode", rvReport.CurrentValue)
                IRSDBConnection.InsertField("userid", gvAList.GetRowCellValue(i, colACode).ToString.Trim)
                IRSDBConnection.InsertField("username", gvAList.GetRowCellValue(i, colAName).ToString.Trim)
                IRSDBConnection.ExecuteInsertCommand()
            Next
            MsgBox("Custom report is created.", MsgBoxStyle.Information, ProgName)

        Else
            Dim res As MsgBoxResult = MsgBox("Are you sure to update this report?", MsgBoxStyle.YesNo, ProgName)
            If res = MsgBoxResult.Yes Then
                IRSDBConnection.StartUpdateCommand("tbl_reports")
                IRSDBConnection.SetWhereField("rptcode", rvReport.CurrentValue)
                IRSDBConnection.SetUpdateField("rptdesc", txtDesc.EditValue.ToString.Trim)
                IRSDBConnection.SetUpdateField("rptfile", txtFile.EditValue.ToString.Trim)
                IRSDBConnection.SetUpdateField("rptsage", swSage.EditValue)
                IRSDBConnection.ExecuteUpdateCommand()

                IRSDBConnection.StartDeleteCommand("tbl_reportuser")
                IRSDBConnection.SetWhereField("rptcode", rvReport.CurrentValue)
                IRSDBConnection.ExecuteDeleteCommand()

                For i As Integer = 0 To gvAList.RowCount - 1
                    IRSDBConnection.StartInsertCommand("tbl_reportuser")
                    IRSDBConnection.InsertField("rptcode", rvReport.CurrentValue)
                    IRSDBConnection.InsertField("userid", gvAList.GetRowCellValue(i, colACode).ToString.Trim)
                    IRSDBConnection.InsertField("username", gvAList.GetRowCellValue(i, colAName).ToString.Trim)
                    IRSDBConnection.ExecuteInsertCommand()
                Next
                MsgBox("Custom report is deleted.", MsgBoxStyle.Information, ProgName)



            End If

        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim uid As String = gvUList.GetRowCellValue(gvUList.FocusedRowHandle, colUCode).ToString.Trim
            Dim name As String = gvUList.GetRowCellValue(gvUList.FocusedRowHandle, colUName).ToString.Trim

            gvUList.DeleteRow(gvUList.FocusedRowHandle)

            gvAList.AddNewRow()
            gvAList.AddNewRow()
            gvAList.DeleteRow(gvAList.FocusedRowHandle)

            gvAList.SetRowCellValue(gvAList.FocusedRowHandle, colACode, uid)
            gvAList.SetRowCellValue(gvAList.FocusedRowHandle, colAName, name)




        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRem_Click(sender As Object, e As EventArgs) Handles btnRem.Click
        Try
            Dim uid As String = gvAList.GetRowCellValue(gvAList.FocusedRowHandle, colACode).ToString.Trim
            Dim name As String = gvAList.GetRowCellValue(gvAList.FocusedRowHandle, colAName).ToString.Trim

            gvAList.DeleteRow(gvAList.FocusedRowHandle)

            gvUList.AddNewRow()
            gvUList.AddNewRow()
            gvUList.DeleteRow(gvUList.FocusedRowHandle)

            gvUList.SetRowCellValue(gvUList.FocusedRowHandle, colUCode, uid)
            gvUList.SetRowCellValue(gvUList.FocusedRowHandle, colUName, name)




        Catch ex As Exception

        End Try
    End Sub

    Private Sub rvReport_RecordIndexChanged(sender As Object, e As EventArgs) Handles rvReport.RecordIndexChanged
        txtDesc.EditValue = rvReport.CurrentView.GetFieldValueByID("RPTDESC").ToString.Trim
        txtFile.EditValue = rvReport.CurrentView.GetFieldValueByID("RPTFILE").ToString.Trim
        swSage.EditValue = rvReport.CurrentView.GetFieldValueByID("RPTSAGE")
        dgAlist.DataSource = IRSDBConnection.SelectFields("select userid, username from tbl_reportuser where rptcode='" + rvReport.CurrentValue + "'")
        dgUList.DataSource = IRSDBConnection.SelectFields("select userid, fname + ' ' + lname as 'username' from sys_users where userid not in (select userid from tbl_reportuser where rptcode='" + rvReport.CurrentValue + "')")

    End Sub

    Private Sub rvReport_EditValueChanged(sender As Object, e As EventArgs) Handles rvReport.EditValueChanged
        txtDesc.EditValue = rvReport.CurrentView.GetFieldValueByID("RPTDESC").ToString.Trim
        txtFile.EditValue = rvReport.CurrentView.GetFieldValueByID("RPTFILE").ToString.Trim
        swSage.EditValue = rvReport.CurrentView.GetFieldValueByID("RPTSAGE")
        dgAlist.DataSource = IRSDBConnection.SelectFields("select userid, username from tbl_reportuser where rptcode='" + rvReport.CurrentValue + "'")
        dgUList.DataSource = IRSDBConnection.SelectFields("select userid, fname + ' ' + lname as 'username' from sys_users where userid not in (select userid from tbl_reportuser where rptcode='" + rvReport.CurrentValue + "')")

    End Sub

    Private Sub rvReport_DeleteRecordFired(sender As Object, e As EventArgs) Handles rvReport.DeleteRecordFired
        If rvReport.IsNewItem = False Then
            Dim res As MsgBoxResult = MsgBox("Are you sure to delete this custom report?", MsgBoxStyle.YesNo, ProgName)
            If res = MsgBoxResult.Yes Then

                IRSDBConnection.StartDeleteCommand("tbl_reports")
                IRSDBConnection.SetWhereField("rptcode", rvReport.CurrentValue)
                IRSDBConnection.ExecuteDeleteCommand()

                IRSDBConnection.StartDeleteCommand("tbl_reportuser")
                IRSDBConnection.SetWhereField("rptcode", rvReport.CurrentValue)
                IRSDBConnection.ExecuteDeleteCommand()

                MsgBox("The report is deleted.", MsgBoxStyle.Information, ProgName)

                rvReport.CurrentValue = ""

            End If


        End If
    End Sub
End Class