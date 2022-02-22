Public Class frmMyApproval 
    Private Sub frmMyApproval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IRSession.UserType = 0 Or IRSession.UserType = 3 Then
            MsgBox("You are not authorize to use this function.", MsgBoxStyle.Information, ProgName)
            Me.Close()
        Else

            Dim sqlstr As String = "select reqno, reqdep as 'fromdep', reason, approvseq, reqstat from tbl_request"

            If IRSession.RequestApprover = True And IRSession.InventoryApprover = True Then
                sqlstr = sqlstr + " where (invdep='" + IRSession.DepartmentCode + "' and reqstat=2) or (reqdep='" + IRSession.DepartmentCode + "' and reqstat=1)"
            Else
                If IRSession.RequestApprover = True Then
                    sqlstr = sqlstr + " where reqdep='" + IRSession.DepartmentCode + "' and reqstat = 1"
                ElseIf IRSession.InventoryApprover = True Then
                    sqlstr = sqlstr + " where invdep='" + IRSession.DepartmentCode + "' and reqstat = 2"
                ElseIf IRSession.InventoryControler = True Then
                    sqlstr = sqlstr + " where invdep='" + IRSession.DepartmentCode + "' and reqstat in (5,6,7)"
                Else

                End If
            End If

            Dim tb As DataTable = IRSDBConnection.SelectFields(sqlstr)

            dgApprove.DataSource = IRSDBConnection.SelectFields(sqlstr)

        End If

    End Sub


    Sub CheckRequest(ByVal stat As Integer)

        btnSendBack.Enabled = False
        btnApprove.Enabled = False
        btnReject.Enabled = False
        btnPurchase.Enabled = False
        btnArrival.Enabled = False
        btnRelease.Enabled = False

        If IRSession.RequestApprover = True Then
            If stat = 1 Then
                btnSendBack.Enabled = True
                btnApprove.Enabled = True
                btnReject.Enabled = True
            End If
        ElseIf IRSession.InventoryApprover = True Then
            If stat = 2 Then
                btnSendBack.Enabled = True
                btnApprove.Enabled = True
                btnReject.Enabled = True
            End If
        ElseIf IRSession.InventoryControler = True Then
            If stat = 5 Then
                btnPurchase.Enabled = True
                btnArrival.Enabled = True
            ElseIf stat = 7 Or stat = 8 Then
                btnRelease.Enabled = True
            Else

            End If
        Else

        End If

    End Sub

    Private Sub gvApprove_DoubleClick(sender As Object, e As EventArgs) Handles gvApprove.DoubleClick
        Try
            Dim reqno As String = gvApprove.GetRowCellValue(gvApprove.FocusedRowHandle, colReqNo).ToString.Trim()
            Dim fm As New frmInvRequest

            '--Begin modifield by seven on 2018-08-03
            'Dim deptFrom As String = gvApprove.GetRowCellValue(gvApprove.FocusedRowHandle, colFDep).ToString.Trim()
            'fm.chkDeptFrom = deptFrom
            '--End modifield by seven 

            fm.Show()
            fm.rvReq.CurrentValue = reqno

        Catch ex As Exception

        End Try
    End Sub

    Private Sub gvApprove_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvApprove.RowClick
        Try
            
            Dim stat As Integer = gvApprove.GetRowCellValue(gvApprove.FocusedRowHandle, colStatus)

            CheckRequest(stat)

        Catch ex As Exception
            MsgBox(ex.Message)
            btnApprove.Enabled = False
            btnReject.Enabled = False
            btnSendBack.Enabled = False

            btnPurchase.Enabled = False
            btnArrival.Enabled = False
            btnRelease.Enabled = False
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Call frmMyApproval_Load(Nothing, Nothing)
    End Sub

    Private Sub btnSendBack_Click(sender As Object, e As EventArgs) Handles btnSendBack.Click
        Try
            btnApprove.Enabled = False
            btnReject.Enabled = False
            btnSendBack.Enabled = False
            btnPurchase.Enabled = False
            btnArrival.Enabled = False
            btnRelease.Enabled = False

            Dim reqno As String = gvApprove.GetRowCellValue(gvApprove.FocusedRowHandle, colReqNo).ToString.Trim
            IRSDBConnection.StartUpdateCommand("tbl_request")
            IRSDBConnection.SetWhereField("reqno", reqno)
            IRSDBConnection.SetUpdateField("reqstat", 3)
            IRSDBConnection.ExecuteUpdateCommand()
            UpdateActivityLog(reqno, "UPDATE", "Set the status of the request to EDIT REQUIRED")

            IRSDBConnection.StartUpdateCommand("tbl_approveroute")
            IRSDBConnection.SetWhereField("reqno", reqno)
            IRSDBConnection.SetWhereField("done", False)
            IRSDBConnection.SetUpdateField("done", True)
            IRSDBConnection.SetUpdateField("approvstat", 1)
            IRSDBConnection.ExecuteUpdateCommand()

            IRMail.SendBackNotify(reqno)

            Call frmMyApproval_Load(Nothing, Nothing)

        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        Try

            btnApprove.Enabled = False
            btnReject.Enabled = False
            btnSendBack.Enabled = False
            btnPurchase.Enabled = False
            btnArrival.Enabled = False
            btnRelease.Enabled = False

            Dim reqno As String = gvApprove.GetRowCellValue(gvApprove.FocusedRowHandle, colReqNo).ToString.Trim

            Dim approvseq As Integer = IRSDBConnection.SelectField("select approvseq from tbl_request where reqno='" + reqno + "'")
            IRSDBConnection.StartUpdateCommand("tbl_request")
            IRSDBConnection.SetWhereField("reqno", reqno)

            Dim invdep As String = IRSDBConnection.SelectField("select invdep from tbl_request where reqno='" + reqno + "'").ToString.Trim
            Dim reqdep As String = IRSDBConnection.SelectField("select reqdep from tbl_request where reqno='" + reqno + "'").ToString.Trim
            Dim reason As String = IRSDBConnection.SelectField("select reason from tbl_request where reqno='" + reqno + "'").ToString.Trim
            Dim reqperson As String = IRSDBConnection.SelectField("select reqperson from tbl_request where reqno='" + reqno + "'").ToString.Trim
            Dim todep As New DBDepartment(invdep)

            If approvseq = 1 Then 'For Request Approver'
                IRSDBConnection.SetUpdateField("reqstat", 2) 'Set it the Pending Approval
                IRSDBConnection.SetUpdateField("approvseq", 2) 'Ready for Inventory Approval
                IRSDBConnection.SetUpdateField("reqapprover", IRSession.UserID) '
                IRSDBConnection.SetUpdateField("reqapprvdate", Now.Date())
                IRSDBConnection.SetUpdateField("reqapprvstat", 0)
                IRSDBConnection.ExecuteUpdateCommand()
                UpdateActivityLog(reqno, "UPDATE", "Set the status of the request to PARTIAL APPROVED")

                IRSDBConnection.StartUpdateCommand("tbl_approveroute")
                IRSDBConnection.SetWhereField("reqno", reqno)
                IRSDBConnection.SetWhereField("apprvseq", 1)
                IRSDBConnection.SetWhereField("done", False)
                IRSDBConnection.SetUpdateField("done", True)
                IRSDBConnection.SetUpdateField("approvstat", 0)
                IRSDBConnection.ExecuteUpdateCommand()

                'Create Route for Inventory Approver and Send Notification
                IRSDBConnection.StartInsertCommand("tbl_approveroute")
                IRSDBConnection.InsertField("reqno", reqno)
                IRSDBConnection.InsertField("fromdep", reqdep)
                IRSDBConnection.InsertField("todep", invdep)
                IRSDBConnection.InsertField("reason", reason)
                IRSDBConnection.InsertField("approvseq", 2)
                IRSDBConnection.InsertField("reqstat", 1)
                IRSDBConnection.InsertField("done", False)

                IRSDBConnection.ExecuteInsertCommand()

                IRMail.FirstApproveNotify(reqno)

            ElseIf approvseq = 2 Then 'For Inventory Approver
                IRSDBConnection.SetUpdateField("reqstat", 5) 'Set it to Final Approved
                IRSDBConnection.SetUpdateField("approvseq", 3) 'Ready for Inventory Controller
                IRSDBConnection.SetUpdateField("invapprover", IRSession.UserID) '
                IRSDBConnection.SetUpdateField("invapprvdate", Now.Date())
                IRSDBConnection.SetUpdateField("invapprvstat", 0)
                IRSDBConnection.ExecuteUpdateCommand()
                UpdateActivityLog(reqno, "UPDATE", "Set the status of the request to APPROVED")

                IRSDBConnection.StartUpdateCommand("tbl_approveroute")
                IRSDBConnection.SetWhereField("reqno", reqno)
                IRSDBConnection.SetWhereField("apprvseq", 2)
                IRSDBConnection.SetWhereField("done", False)
                IRSDBConnection.SetUpdateField("done", True)
                IRSDBConnection.SetUpdateField("approvstat", 0)
                IRSDBConnection.ExecuteUpdateCommand()

                'Send Notication to Inventory Controler
                IRMail.FinalApproveNotify(reqno)


            End If


            Call frmMyApproval_Load(Nothing, Nothing)

        Catch ex As Exception

        End Try

        
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        Try
            btnApprove.Enabled = False
            btnReject.Enabled = False
            btnSendBack.Enabled = False
            btnPurchase.Enabled = False
            btnArrival.Enabled = False
            btnRelease.Enabled = False

            Dim reqno As String = gvApprove.GetRowCellValue(gvApprove.FocusedRowHandle, colReqNo).ToString.Trim

            Dim approvseq As Integer = IRSDBConnection.SelectField("select approvseq from tbl_request where reqno='" + reqno + "'")
            IRSDBConnection.StartUpdateCommand("tbl_request")
            IRSDBConnection.SetWhereField("reqno", reqno)

            Dim reqperson As String = IRSDBConnection.SelectField("select reqperson from tbl_request where reqno='" + reqno + "'").ToString.Trim

            If approvseq = 1 Then 'For Request Approver'
                IRSDBConnection.SetUpdateField("reqstat", 4) 'Set it the Pending Approval
                IRSDBConnection.SetUpdateField("approvseq", 9) 'Completely rejected
                IRSDBConnection.SetUpdateField("reqapprover", IRSession.UserID) '
                IRSDBConnection.SetUpdateField("reqapprvdate", Now.Date())
                IRSDBConnection.SetUpdateField("reqapprvstat", 1)
                IRSDBConnection.ExecuteUpdateCommand()
                UpdateActivityLog(reqno, "UPDATE", "Set the status of the request to REJECTED")


            ElseIf approvseq = 2 Then 'For Inventory Approver
                IRSDBConnection.SetUpdateField("reqstat", 4) 'Set it to Final Approved
                IRSDBConnection.SetUpdateField("approvseq", 9) 'Ready for Inventory Controller
                IRSDBConnection.SetUpdateField("invapprover", IRSession.UserID) '
                IRSDBConnection.SetUpdateField("invapprvdate", Now.Date())
                IRSDBConnection.SetUpdateField("invapprvstat", 1)
                IRSDBConnection.ExecuteUpdateCommand()
                UpdateActivityLog(reqno, "UPDATE", "Set the status of the request to REJECTED")
            End If



            IRSDBConnection.StartUpdateCommand("tbl_approveroute")
            IRSDBConnection.SetWhereField("reqno", reqno)
            IRSDBConnection.SetWhereField("done", False)
            IRSDBConnection.SetUpdateField("done", True)
            IRSDBConnection.SetUpdateField("approvstat", 1)
            IRSDBConnection.ExecuteUpdateCommand()


            Dim requestor As New DBUser(reqperson)
            Dim mail As String = "Dear " + requestor.FirstName + " " + requestor.LastName + "<br>"
            mail += "You request number " + reqno + " is rejected by " + IRSession.UserID + "(" + IRSession.LoginName + "). <br><br>"
            mail += "Best Regards,<br>Sage Admin<br>"
            IRMail.SendMail("Request: " + reqno, requestor.Email, mail)


            Call frmMyApproval_Load(Nothing, Nothing)

        Catch ex As Exception

        End Try

       
    End Sub

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        Try
            btnApprove.Enabled = False
            btnReject.Enabled = False
            btnSendBack.Enabled = False
            btnPurchase.Enabled = False
            btnArrival.Enabled = False
            btnRelease.Enabled = False
            Dim reqno As String = gvApprove.GetRowCellValue(gvApprove.FocusedRowHandle, colReqNo).ToString.Trim
            'Code to create PR Queue here
            If SendToPurchase(reqno) = True Then
                IRSDBConnection.StartUpdateCommand("tbl_request")
                IRSDBConnection.SetWhereField("reqno", reqno)
                IRSDBConnection.SetUpdateField("reqstat", 6)
                IRSDBConnection.ExecuteUpdateCommand()
                UpdateActivityLog(reqno, "UPDATE", "Set the status of the request to WAITING FOR PURCHASE")
                Dim reqperson As String = IRSDBConnection.SelectField("select reqperson from tbl_request where reqno='" + reqno + "'").ToString.Trim

                Dim requestor As New DBUser(reqperson)
                Dim mail As String = "Dear " + requestor.FirstName + " " + requestor.LastName + "<br>"
                mail += "You request number " + reqno + " is sent to Purchasing. <br><br>"
                mail += "Best Regards,<br>Sage Admin<br>"
                IRMail.SendMail("Request: " + reqno, requestor.Email, mail)
            End If

            Call frmMyApproval_Load(Nothing, Nothing)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnArrival_Click(sender As Object, e As EventArgs) Handles btnArrival.Click
        Try
            btnApprove.Enabled = False
            btnReject.Enabled = False
            btnSendBack.Enabled = False
            btnPurchase.Enabled = False
            btnArrival.Enabled = False
            btnRelease.Enabled = False

            Dim reqno As String = gvApprove.GetRowCellValue(gvApprove.FocusedRowHandle, colReqNo).ToString.Trim
            IRSDBConnection.StartUpdateCommand("tbl_request")
            IRSDBConnection.SetWhereField("reqno", reqno)
            IRSDBConnection.SetUpdateField("reqstat", 7)
            IRSDBConnection.ExecuteUpdateCommand()

            UpdateActivityLog(reqno, "UPDATE", "Set the status of the request to STOCK AVAILABLE")
            Dim reqperson As String = IRSDBConnection.SelectField("select reqperson from tbl_request where reqno='" + reqno + "'").ToString.Trim


            Dim requestor As New DBUser(reqperson)
            Dim mail As String = "Dear " + requestor.FirstName + " " + requestor.LastName + "<br>"
            mail += "You request number " + reqno + " is ready to collect. <br><br>"
            mail += "Best Regards,<br>Sage Admin<br>"
            IRMail.SendMail("Request: " + reqno, requestor.Email, mail)

            Call frmMyApproval_Load(Nothing, Nothing)


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRelease_Click(sender As Object, e As EventArgs) Handles btnRelease.Click
        Try

            btnApprove.Enabled = False
            btnReject.Enabled = False
            btnSendBack.Enabled = False
            btnPurchase.Enabled = False
            btnArrival.Enabled = False
            btnRelease.Enabled = False

            Dim reqno As String = gvApprove.GetRowCellValue(gvApprove.FocusedRowHandle, colReqNo).ToString.Trim
            Dim reqperson As String = IRSDBConnection.SelectField("select reqperson from tbl_request where reqno='" + reqno + "'").ToString.Trim


            'Code to Make Stock Transfer Here.

            'ReleaseRequest(reqno)


            IRSDBConnection.StartUpdateCommand("tbl_request")
            IRSDBConnection.SetWhereField("reqno", reqno)
            IRSDBConnection.SetUpdateField("reqstat", 8)
            IRSDBConnection.ExecuteUpdateCommand()

            Dim tblitem As DataTable = IRSDBConnection.SelectFields("select * from tbl_requestitem where reqno='" + reqno + "'")

            For i As Integer = 0 To tblitem.Rows.Count - 1
                IRSDBConnection.StartUpdateCommand("tbl_requestitem")
                IRSDBConnection.SetWhereField("reqno", reqno)
                IRSDBConnection.SetUpdateField("isuqty", Val(tblitem.Rows(i)("reqqty")))
                IRSDBConnection.SetUpdateField("isuuom", tblitem.Rows(i)("requom").ToString.Trim)
                IRSDBConnection.ExecuteUpdateCommand()
            Next



            UpdateActivityLog(reqno, "UPDATE", "Set the status of the request to RELEASED")



            Dim requestor As New DBUser(reqperson)
            Dim mail As String = "Dear " + requestor.FirstName + " " + requestor.LastName + "<br>"
            mail += "You request number " + reqno + " is released. <br><br>"
            mail += "Best Regards,<br>Sage Admin<br>"
            IRMail.SendMail("Request: " + reqno, requestor.Email, mail)


            Call frmMyApproval_Load(Nothing, Nothing)

        Catch ex As Exception

        End Try
    End Sub
End Class