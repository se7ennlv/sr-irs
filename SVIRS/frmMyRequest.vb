Public Class frmMyRequest 
    '***************Request Status*********************
    '0=New
    '1=Submitted
    '2=Pending Approved
    '3=Editing Required
    '4=Rejected
    '5=Approved
    '6=Waiting for Purchase
    '7=Stock Available
    '8=Item Released
    '9=Voided
    '10 = Used
    Private Sub frmMyRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgRequest.DataSource = IRSDBConnection.SelectFields("select reqno, reqdate, reason, invdep, reqstat from tbl_request where reqperson='" + IRSession.UserID + "'")
        txtSearch.EditValue = ""
        lstStatus.SelectedIndex = 0
    End Sub

    Private Sub txtSearch_EditValueChanged(sender As Object, e As EventArgs) Handles txtSearch.EditValueChanged
        If txtSearch.EditValue.ToString.Trim.Length > 0 Then
            dgRequest.DataSource = IRSDBConnection.SelectFields("select reqno, reqdate, reason, invdep, reqstat from tbl_request where reqperson='" + IRSession.UserID + "' and (reqno like '%" + txtSearch.EditValue.ToString.Trim + "%' or reason like '%" + txtSearch.EditValue.ToString.Trim + "%' or invdep like '%" + txtSearch.EditValue.ToString.Trim + "%' ) and reqstat=" + lstStatus.SelectedIndex.ToString)
        Else
            dgRequest.DataSource = IRSDBConnection.SelectFields("select reqno, reqdate, reason, invdep, reqstat from tbl_request where reqperson='" + IRSession.UserID + "' and reqstat = " + lstStatus.SelectedIndex.ToString)
        End If
    End Sub

    Private Sub lstStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStatus.SelectedIndexChanged
        Call txtSearch_EditValueChanged(Nothing, Nothing)
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            Dim reqno As String = gvRequest.GetRowCellValue(gvRequest.FocusedRowHandle, colReqNo).ToString.Trim
            Dim tbreq As DataTable = IRSDBConnection.SelectFields("select * from tbl_request where reqno='" + reqno + "'")

            IRSDBConnection.StartUpdateCommand("tbl_request")
            IRSDBConnection.SetWhereField("reqno", reqno)
            IRSDBConnection.SetUpdateField("reqstat", 1)
            IRSDBConnection.SetUpdateField("cntsubmit", CInt(tbreq.Rows(0)("cntsubmit")) + 1)
            IRSDBConnection.ExecuteUpdateCommand()
            Dim reqdep As New DBDepartment(tbreq.Rows(0)("reqdep").ToString.Trim)
            Dim invdep As New DBDepartment(tbreq.Rows(0)("invdep").ToString.Trim)
            Dim mail As String = "Dear Approver!<br>"
            Dim reqperson As New DBUser(tbreq.Rows(0)("reqpersion").ToString.Trim)
            mail += "Inventory request #" + reqno + " from " + reqperson.ID + " (" + reqperson.FirstName + " " + reqperson.LastName + ") need your approval. Please login to the IRS for the process.<br><br>"

            'IRSDBConnection.StartInsertCommand("tbl_approveroute")
            'IRSDBConnection.InsertField("reqno", reqno)
            'IRSDBConnection.InsertField("fromdep", reqdep.Code)
            'IRSDBConnection.InsertField("todep", tbreq.Rows(0)("invdep").ToString.Trim)
            'IRSDBConnection.InsertField("approvseq", 1)
            'IRSDBConnection.InsertField("reqstat", 1)

            'IRSDBConnection.InsertField("done", False)

            'IRSDBConnection.ExecuteInsertCommand()

            IRMail.SendSubmitNotify(reqno)

            UpdateActivityLog(reqno, "UPDATE", "Set status of the request to SUBMITTED")

            Call frmMyRequest_Load(Nothing, Nothing)

        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub btnVoid_Click(sender As Object, e As EventArgs) Handles btnVoid.Click
        Try
            Dim reqno As String = gvRequest.GetRowCellValue(gvRequest.FocusedRowHandle, colReqNo).ToString.Trim
            Dim tbreq As DataTable = IRSDBConnection.SelectFields("select * from tbl_request where reqno='" + reqno + "'")
            IRSDBConnection.StartUpdateCommand("tbl_request")
            IRSDBConnection.SetWhereField("reqno", reqno)
            IRSDBConnection.SetUpdateField("reqstat", 9)
            IRSDBConnection.ExecuteUpdateCommand()

            IRSDBConnection.StartDeleteCommand("tbl_approveroute")
            IRSDBConnection.SetWhereField("reqno", reqno)
            IRSDBConnection.SetWhereField("done", False)
            IRSDBConnection.ExecuteDeleteCommand()

            IRSDBConnection.StartDeleteCommand("tbl_requestpr")
            IRSDBConnection.SetWhereField("reqno", reqno)
            IRSDBConnection.SetWhereField("haspr", False)
            IRSDBConnection.ExecuteDeleteCommand()


            UpdateActivityLog(reqno, "UPDATE", "Set the status of the request to VOID")

            Dim requestor As New DBUser(tbreq.Rows(0)("reqperson").ToString.Trim)
            Dim mail As String = "Dear " + requestor.FirstName + " " + requestor.LastName + "<br>"
            mail += "You request number " + reqno + " is voided. <br><br>"
            mail += "Best Regards,<br>Sage Admin<br>"
            IRMail.SendMail("Request: " + reqno, requestor.Email, mail)

            Call frmMyRequest_Load(Nothing, Nothing)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub gvRequest_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gvRequest.RowCellClick
        Try
            Dim stat As Integer = gvRequest.GetRowCellValue(gvRequest.FocusedRowHandle, colStatus)
            If stat = 0 Then
                btnSubmit.Enabled = True
                btnVoid.Enabled = True
                btnUse.Enabled = False
            ElseIf stat = 8 Then
                btnSubmit.Enabled = False
                btnVoid.Enabled = False
                btnUse.Enabled = True
            Else
                btnSubmit.Enabled = False
                btnVoid.Enabled = False
                btnUse.Enabled = False
            End If
        Catch ex As Exception
            btnSubmit.Enabled = False
            btnVoid.Enabled = False
            btnUse.Enabled = False
        End Try
    End Sub

    Private Sub gvRequest_DoubleClick(sender As Object, e As EventArgs) Handles gvRequest.DoubleClick
        Try
            Dim reqno As String = gvRequest.GetRowCellValue(gvRequest.FocusedRowHandle, colReqNo).ToString.Trim
            Dim fm As New frmInvRequest

            fm.Show()
            fm.rvReq.CurrentValue = reqno

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnUse_Click(sender As Object, e As EventArgs) Handles btnUse.Click
        Try
            Dim reqno As String = gvRequest.GetRowCellValue(gvRequest.FocusedRowHandle, colReqNo).ToString.Trim
            'Code to Make Stock Internal Use Here.
            'UsageRequest(reqno)
            IRSDBConnection.StartUpdateCommand("tbl_request")
            IRSDBConnection.SetWhereField("reqno", reqno)
            IRSDBConnection.SetUpdateField("reqstat", 10)
            IRSDBConnection.ExecuteUpdateCommand()
            UpdateActivityLog(reqno, "UPDATE", "Set the status of the request to USED")

            
        Catch ex As Exception

        End Try
    End Sub
End Class