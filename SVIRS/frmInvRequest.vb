Imports ACCPAC.Advantage
Public Class frmInvRequest
    Public chkDeptFrom As String

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


    Private Sub frmInvRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rvReq.CurrentValue = "***NEW***"
        lstStatus.SelectedIndex = 0
        txtSmtCount.EditValue = 0
        dtRequest.EditValue = IRSession.SessionDate
        txtReason.EditValue = ""
        txtRef.EditValue = ""
        lstStatus.SelectedIndex = 0
        optReqType.EditValue = 0

        If IRSession.UserID <> "ADMIN" Then
            txtFDepCode.EditValue = IRSession.DepartmentCode
            txtFDepName.EditValue = IRSession.DepartmentName
            txtReqID.EditValue = IRSession.UserID
            txtReqName.EditValue = IRSession.LoginName

        End If

        dgItem.DataSource = IRSDBConnection.SelectFields("select * from tbl_requestitem where 0=1")
        dgLog.DataSource = IRSDBConnection.SelectFields("select * from tbl_requestlog where 0=1")
        dgCmt.DataSource = IRSDBConnection.SelectFields("select * from tbl_requestcomment where 0=1")

        txtTDepCode.EditValue = ""
        txtTDepName.EditValue = ""
        txtRAID.EditValue = ""
        txtIAID.EditValue = ""

        '-- Jim code
        If IRSession.UserType = 3 Then 'User is Administrator
            rvReq.FilsterString = ""
        ElseIf IRSession.UserType = 2 Then
            rvReq.FilsterString = "INVDEP='" + IRSession.DepartmentCode + "'"
        ElseIf IRSession.UserType = 0 Then 'User is the requestor
            rvReq.FilsterString = "REQDEP='" + IRSession.DepartmentCode + "'"
        Else 'User is the approver
            If IRSession.InventoryApprover = True And IRSession.RequestApprover = False Then
                rvReq.FilsterString = "INVDEP='" + IRSession.DepartmentCode + "'"
            End If
            If IRSession.RequestApprover = True And IRSession.InventoryApprover = False Then
                rvReq.FilsterString = "REQDEP='" + IRSession.DepartmentCode + "'"
            End If
            If IRSession.RequestApprover = True And IRSession.InventoryApprover = True Then
                rvReq.FilsterString = "INVDEP='" + IRSession.DepartmentCode + "' or REQDEP='" + IRSession.DepartmentCode + "'"
            End If

        End If

    End Sub

    Sub CheckRequest()
        btnSubmit.Enabled = False
        btnVoid.Enabled = False
        'btnUse.Enabled = False
        btnSendBack.Enabled = False
        btnApprove.Enabled = False
        btnReject.Enabled = False
        btnPurchase.Enabled = False
        btnArrival.Enabled = False
        btnRelease.Enabled = False
        btnComment.Enabled = True
        colIsuQty.OptionsColumn.AllowEdit = False
        Dim stat As Integer = lstStatus.SelectedIndex

        If IRSession.UserID = txtReqID.EditValue.ToString.Trim Then 'The logged user is the requestor of the request.
            If stat = 0 Or stat = 3 Then 'the request is newly created or in Send Back mode, can be submitted or voided.
                btnSubmit.Enabled = True
                btnVoid.Enabled = True
            ElseIf stat = 5 Then  'The request is approved and the logged user is the requestor of the request, he/she can void before issuing.
                btnVoid.Enabled = True
            End If

        Else 'The logged user is another person.
            If stat = 1 Then
                If IRSession.RequestApprover = True Then
                    btnReject.Enabled = True
                    btnSendBack.Enabled = True
                    btnApprove.Enabled = True
                End If
            ElseIf stat = 2 Then
                If IRSession.InventoryApprover = True Then
                    btnReject.Enabled = True
                    btnSendBack.Enabled = True
                    btnApprove.Enabled = True
                End If
            ElseIf stat = 3 Then

            ElseIf stat = 4 Then

            ElseIf stat = 5 Then
                If IRSession.InventoryControler = True Then
                    btnArrival.Enabled = True
                    btnPurchase.Enabled = True
                End If
            ElseIf stat = 6 Then
                If IRSession.InventoryControler = True Then
                    btnArrival.Enabled = True
                End If
            ElseIf stat = 7 Then
                If IRSession.InventoryControler = True Then
                    btnRelease.Enabled = True
                End If
            ElseIf stat = 8 Then
                If IRSession.InventoryControler = True Then
                    btnRelease.Enabled = True
                End If
            Else

            End If
        End If

        If stat = 9 Or stat = 10 Or stat = 11 Then
            btnComment.Enabled = False
        End If

        '-- Begin updated by seven at 2018-09-13
        'If chkDeptFrom.ToString.Trim = IRSession.DepartmentCode Then
        '    PanelControl2.Enabled = True
        'Else
        '    If stat <= 1 Then
        '        PanelControl2.Enabled = False
        '    Else
        '        PanelControl2.Enabled = True
        '    End If
        'End If
        '-- End updated

        'If stat = 0 Or stat = 3 Then 'New request, can submit or void only.
        '    If IRSession.UserID = txtReqID.EditValue.ToString.Trim Then 'The Login user is the requestor, enable button submit and void
        '        btnSubmit.Enabled = True
        '        btnVoid.Enabled = True
        '        btnComment.Enabled = True
        '    End If
        'ElseIf stat = 1 Then 'The request is submitted, need the Request Approver to see and decide
        '    'This code will check if the login user is the Request Approver.
        '    If IRSession.RequestApprover = True Then
        '        btnApprove.Enabled = True
        '        btnReject.Enabled = True
        '        btnSendBack.Enabled = True
        '    End If
        '    If IRSession.UserID = txtReqID.EditValue.ToString.Trim Then
        '        btnVoid.Enabled = True
        '    End If
        '    btnComment.Enabled = True
        'ElseIf stat = 2 Then 'The request is approved by request approver and wait for inventory approver
        '    'This code will check if the login user is the Inventory Approver.
        '    If IRSession.InventoryApprover = True Then
        '        btnApprove.Enabled = True
        '        btnReject.Enabled = True
        '        btnSendBack.Enabled = True
        '    End If
        '    If IRSession.UserID = txtReqID.EditValue.ToString.Trim Then
        '        btnVoid.Enabled = True
        '    End If
        '    btnComment.Enabled = True
        'ElseIf stat = 5 Then 'The request is approved, it's time for inventory controller to work on.
        '    'This code will check if the login user is the Inventory Controler of the department
        '    If IRSession.InventoryControler = True Then
        '        btnPurchase.Enabled = True
        '        btnArrival.Enabled = True
        '        btnRelease.Enabled = True
        '    End If
        '    btnComment.Enabled = True
        '    If IRSession.UserID = txtReqID.EditValue.ToString.Trim Then
        '        btnVoid.Enabled = True
        '    End If
        'ElseIf stat = 6 Then 'Waiting for purchase
        '    'This code will check if the login user is the Inventory Controler of the department
        '    If IRSession.InventoryControler = True Then
        '        btnArrival.Enabled = True
        '        btnRelease.Enabled = True
        '    End If
        '    btnComment.Enabled = True
        '    If IRSession.UserID = txtReqID.EditValue.ToString.Trim Then
        '        btnVoid.Enabled = True
        '    End If
        'ElseIf stat = 7 Then 'Stock Availabe
        '    'This code will check if the login user is the Inventory Controler of the department
        '    If IRSession.InventoryControler = True Then
        '        btnRelease.Enabled = True
        '        colIsuQty.OptionsColumn.AllowEdit = True
        '    End If
        '    btnComment.Enabled = True
        '    If IRSession.UserID = txtReqID.EditValue.ToString.Trim Then
        '        btnVoid.Enabled = True
        '    End If
        'ElseIf stat = 8 Then 'request is release

        '    If IRSession.InventoryControler = True Then
        '        btnRelease.Enabled = True
        '    End If
        '    btnComment.Enabled = True
        'Else


        'End If


    End Sub
    Private Sub btnTDepFind_Click(sender As Object, e As EventArgs) Handles btnTDepFind.Click
        If IRSession.UserType = 0 And lstStatus.SelectedIndex = 0 Then
            Dim fm As New fmFinder
            fm.Caption = "Departmentn Finder"
            fm.SetViewID("Department", 0)
            fm.ReturnField = "DEPCODE"
            fm.AddFilterFields("SWINVCTRL", True)
            fm.TargetTextEdit = txtTDepCode
            fm.ShowFinder()
        Else
            MsgBox("Sorry! Your user account doesn't have autorization to make any change of the request.", MsgBoxStyle.Information, ProgName)
        End If




    End Sub

    Private Sub txtTDepCode_EditValueChanged(sender As Object, e As EventArgs) Handles txtTDepCode.EditValueChanged
        Try
            txtTDepName.EditValue = IRSDBConnection.SelectField("select depdesc from tbl_departments where depcode='" + txtTDepCode.EditValue.ToString.Trim + "'").ToString.Trim
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rvReq_EditValueChanged(sender As Object, e As EventArgs) Handles rvReq.EditValueChanged
        Try
            txtReason.EditValue = rvReq.CurrentView.GetFieldValueByID("REASON").ToString.Trim
            txtRef.EditValue = rvReq.CurrentView.GetFieldValueByID("REFERENCE").ToString.Trim
            lstStatus.SelectedIndex = rvReq.CurrentView.GetFieldValueByID("REQSTAT")
            dtRequest.EditValue = rvReq.CurrentView.GetFieldValueByID("REQDATE")
            txtSmtCount.EditValue = rvReq.CurrentView.GetFieldValueByID("CNTSUBMIT")
            txtFDepCode.EditValue = rvReq.CurrentView.GetFieldValueByID("REQDEP").ToString.Trim
            txtReqID.EditValue = rvReq.CurrentView.GetFieldValueByID("REQPERSON").ToString.Trim
            txtTDepCode.EditValue = rvReq.CurrentView.GetFieldValueByID("INVDEP").ToString.Trim
            optReqType.EditValue = CInt(rvReq.CurrentView.GetFieldValueByID("REQTYPE"))

            If Not IsNothing(rvReq.CurrentView.GetFieldValueByID("REQAPPROVER")) Then
                txtRAID.EditValue = rvReq.CurrentView.GetFieldValueByID("REQAPPROVER").ToString.Trim
                dtRApprove.EditValue = rvReq.CurrentView.GetFieldValueByID("REQAPPRVDATE")

                If Not IsDBNull(rvReq.CurrentView.GetFieldValueByID("REQAPPRVSTAT")) Then
                    lstRAStat.SelectedIndex = rvReq.CurrentView.GetFieldValueByID("REQAPPRVSTAT")
                End If

            End If

            If Not IsNothing(rvReq.CurrentView.GetFieldValueByID("INVAPPROVER")) Then
                txtIAID.EditValue = rvReq.CurrentView.GetFieldValueByID("INVAPPROVER").ToString.Trim
                dtIApprove.EditValue = rvReq.CurrentView.GetFieldValueByID("INVAPPRVDATE")

                If Not IsDBNull(rvReq.CurrentView.GetFieldValueByID("INVAPPRVSTAT")) Then
                    lstIAStat.SelectedIndex = rvReq.CurrentView.GetFieldValueByID("INVAPPRVSTAT")
                End If

            End If

            dgItem.DataSource = IRSDBConnection.SelectFields("select * from tbl_requestitem where reqno='" + rvReq.CurrentValue + "'")
            dgCmt.DataSource = IRSDBConnection.SelectFields("select * from tbl_requestcomment where reqno='" + rvReq.CurrentValue + "'")
            dgLog.DataSource = IRSDBConnection.SelectFields("select * from tbl_requestlog where reqno='" + rvReq.CurrentValue + "'")

            CheckRequest()

            dtRApprove.EditValue = rvReq.CurrentView.GetFieldValueByID("REQAPPRVDATE")
            lstRAStat.SelectedIndex = rvReq.CurrentView.GetFieldValueByID("REQAPPRVSTAT")

            gvItem.FocusedRowHandle = 0
            Call gvItem_Click(Nothing, Nothing)



        Catch ex As Exception

        End Try
    End Sub

    Private Sub rvReq_NewRecordFired(sender As Object, e As EventArgs) Handles rvReq.NewRecordFired
        If rvReq.CurrentValue = "" Then
            rvReq.CurrentValue = "***NEW***"

        End If

        lstStatus.SelectedIndex = 0
        txtSmtCount.EditValue = 0
        dtRequest.EditValue = IRSession.SessionDate
        txtReason.EditValue = ""
        txtRef.EditValue = ""
        lstStatus.SelectedIndex = 0
        optReqType.EditValue = 0

        If IRSession.UserID <> "ADMIN" Then
            txtFDepCode.EditValue = IRSession.DepartmentCode
            'txtFDepName.EditValue = IRSession.DepartmentName
            txtReqID.EditValue = IRSession.UserID
            txtReqName.EditValue = IRSession.LoginName
        End If

        dgItem.DataSource = IRSDBConnection.SelectFields("select * from tbl_requestitem where 0=1")
        dgLog.DataSource = IRSDBConnection.SelectFields("select * from tbl_requestlog where 0=1")
        dgCmt.DataSource = IRSDBConnection.SelectFields("select * from tbl_requestcomment where 0=1")


        lstIAStat.SelectedIndex = -1
        lstRAStat.SelectedIndex = -1
        txtTDepCode.EditValue = ""
        txtTDepName.EditValue = ""
        txtRAID.EditValue = ""
        txtRAName.EditValue = ""
        txtIAID.EditValue = ""
        txtIAName.EditValue = ""
        dtIApprove.EditValue = Nothing
        dtRApprove.EditValue = Nothing
        dtRequest.EditValue = Now.Date()

        btnSubmit.Enabled = False
        'btnUse.Enabled = False

        btnSendBack.Enabled = False
        btnApprove.Enabled = False
        btnReject.Enabled = False
        btnRelease.Enabled = False
        btnPurchase.Enabled = False
        btnArrival.Enabled = False
        btnRelease.Enabled = False
        btnVoid.Enabled = False
        btnComment.Enabled = False

    End Sub

    Private Sub btnAddLine_Click(sender As Object, e As EventArgs) Handles btnAddLine.Click
        Try
            '--If txtFDepCode.EditValue.ToString.Trim.Length > 0 And txtTDepCode.EditValue.ToString.Trim.Length > 0 And (lstStatus.SelectedIndex = 0 Or lstStatus.SelectedIndex = 1) Then '--Original
            If (txtFDepCode.EditValue.ToString.Trim.Length > 0 And txtTDepCode.EditValue.ToString.Trim.Length > 0 And (lstStatus.SelectedIndex = 0 Or lstStatus.SelectedIndex = 1)) Or lstStatus.SelectedIndex = 3 Then '--Modifield by Seven
                'gvItem.AddNewRow()
                'gvItem.AddNewRow()
                'gvItem.DeleteRow(gvItem.FocusedRowHandle)

                Dim fm As New frmItemScan
                fm.FromDepartment = txtFDepCode.EditValue.ToString.Trim
                fm.ToDepartment = txtTDepCode.EditValue.ToString.Trim
                fm.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("A designated department can't be blank.", MsgBoxStyle.Information, ProgName)
        End Try

    End Sub

    Private Sub dgItem_Click(sender As Object, e As EventArgs) Handles dgItem.Click
        Try
            If gvItem.RowCount > 0 Then
                For i As Integer = 0 To gvItem.RowCount - 1
                    If IsNothing(gvItem.GetRowCellValue(i, colItemNo)) Or gvItem.GetRowCellValue(i, colItemNo).ToString.Trim.Length = 0 Then
                        gvItem.DeleteRow(i)
                    End If

                Next

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRemLine_Click(sender As Object, e As EventArgs) Handles btnRemLine.Click
        '--If txtFDepCode.EditValue.ToString.Trim.Length > 0 And txtTDepCode.EditValue.ToString.Trim.Length > 0 And (lstStatus.SelectedIndex = 0 Or lstStatus.SelectedIndex = 1) Then '--Original
        If (txtFDepCode.EditValue.ToString.Trim.Length > 0 And txtTDepCode.EditValue.ToString.Trim.Length > 0 And (lstStatus.SelectedIndex = 0 Or lstStatus.SelectedIndex = 1)) Or lstStatus.SelectedIndex = 3 Then '--Modified by Seven
            Try
                gvItem.DeleteRow(gvItem.FocusedRowHandle)
                For i As Integer = 0 To gvItem.RowCount - 1
                    gvItem.SetRowCellValue(i, colLineNo, i + 1)
                Next
            Catch ex As Exception

            End Try
        End If

    End Sub


    Function ValidRequest() As Boolean
        Dim vr As Boolean = False
        Try
            Dim reqqty As Double = colReqQty.SummaryItem.SummaryValue
            If reqqty > 0 Then
                vr = True
            End If
        Catch ex As Exception

        End Try
        Return vr
    End Function

    Private Sub rvReq_SaveRecordFired(sender As Object, e As EventArgs) Handles rvReq.SaveRecordFired

        If lstStatus.SelectedIndex = 0 And rvReq.IsNewItem = True And IRSession.UserID = txtReqID.EditValue.ToString.Trim Then

            'New Request can be made by only requestor of the originated department.

            Dim res As MsgBoxResult = MsgBox("You are about to create a request for " + If(optReqType.EditValue = 0, "Internal Use", "Sales to Customer") + ". Is that correct?", MsgBoxStyle.YesNo, ProgName)

            If res = MsgBoxResult.Yes Then
                If ValidRequest() = True Then
                    Dim reqno As String = NewRequestNumber(True)
                    IRSDBConnection.StartInsertCommand("tbl_request")
                    IRSDBConnection.InsertField("reqno", reqno)
                    IRSDBConnection.InsertField("reason", txtReason.EditValue.ToString.Trim)
                    IRSDBConnection.InsertField("reference", txtRef.EditValue.ToString.Trim)
                    IRSDBConnection.InsertField("reqstat", lstStatus.SelectedIndex)
                    IRSDBConnection.InsertField("reqdate", dtRequest.EditValue)
                    IRSDBConnection.InsertField("cntsubmit", 0)
                    IRSDBConnection.InsertField("reqdep", txtFDepCode.EditValue.ToString.Trim)
                    IRSDBConnection.InsertField("reqperson", txtReqID.EditValue.ToString.Trim)
                    IRSDBConnection.InsertField("invdep", txtTDepCode.EditValue.ToString.Trim)
                    IRSDBConnection.InsertField("approvseq", 0)
                    IRSDBConnection.InsertField("reqtype", optReqType.EditValue)

                    IRSDBConnection.ExecuteInsertCommand()

                    If gvItem.RowCount > 0 Then
                        For i As Integer = 0 To gvItem.RowCount - 1
                            If gvItem.GetRowCellValue(i, colItemNo).ToString.Trim.Length > 0 Then
                                IRSDBConnection.StartInsertCommand("tbl_requestitem")
                                IRSDBConnection.InsertField("reqno", reqno)

                                IRSDBConnection.InsertField("linenum", gvItem.GetRowCellValue(i, colLineNo).ToString.Trim())

                                IRSDBConnection.InsertField("itemno", gvItem.GetRowCellValue(i, colItemNo).ToString.Trim)
                                IRSDBConnection.InsertField("itemdesc", gvItem.GetRowCellValue(i, colItemDesc).ToString.Trim)
                                IRSDBConnection.InsertField("reqqty", Val(gvItem.GetRowCellValue(i, colReqQty).ToString))
                                IRSDBConnection.InsertField("requom", gvItem.GetRowCellValue(i, colReqUom).ToString.Trim)
                                IRSDBConnection.InsertField("fromloc", gvItem.GetRowCellValue(i, colFLoc).ToString.Trim)
                                IRSDBConnection.InsertField("toloc", gvItem.GetRowCellValue(i, colTLoc).ToString.Trim)
                                IRSDBConnection.InsertField("lineapprove", False)
                                IRSDBConnection.InsertField("isuqty", 0)
                                IRSDBConnection.InsertField("isuuom", gvItem.GetRowCellValue(i, colReqUom).ToString.Trim)
                                IRSDBConnection.InsertField("linecmt", gvItem.GetRowCellValue(i, colLineCmt).ToString.Trim)
                                IRSDBConnection.ExecuteInsertCommand()
                            End If
                        Next
                    End If

                    UpdateActivityLog(reqno, "NEW", "New created the inventory request.")
                    MsgBox("New inventory request is created.", MsgBoxStyle.Information, ProgName)
                    rvReq.CurrentValue = reqno
                Else
                    MsgBox("You requested quantity can't be zero.", MsgBoxStyle.Critical, ProgName)
                End If

            End If


        ElseIf (lstStatus.SelectedIndex = 0 Or lstStatus.SelectedIndex = 1) And rvReq.IsNewItem = False And (IRSession.UserType = 0 Or IRSession.UserType = 2) And (IRSession.DepartmentCode = txtFDepCode.EditValue.ToString.Trim Or IRSession.DepartmentCode = txtTDepCode.EditValue.ToString.Trim) Then
            'New or submitted requested can be updated by the Requestor or Inventory Controler of the Department as long as the request is related to their department.
            Dim res As MsgBoxResult = MsgBox("You are about to edit your request for " + If(optReqType.EditValue = 0, "Internal Use", "Sales to Customer") + ". Are you sure?", MsgBoxStyle.YesNo, ProgName)
            If res = MsgBoxResult.Yes Then

                If ValidRequest() = True Then
                    IRSDBConnection.StartUpdateCommand("tbl_request")
                    IRSDBConnection.SetWhereField("reqno", rvReq.CurrentValue)
                    IRSDBConnection.SetUpdateField("reason", txtReason.EditValue.ToString.Trim)
                    IRSDBConnection.SetUpdateField("reference", txtRef.EditValue.ToString.Trim)
                    IRSDBConnection.SetUpdateField("reqdate", dtRequest.EditValue)
                    IRSDBConnection.SetUpdateField("invdep", txtTDepCode.EditValue.ToString.Trim)
                    IRSDBConnection.SetUpdateField("reqtype", optReqType.EditValue)
                    IRSDBConnection.ExecuteUpdateCommand()

                    IRSDBConnection.StartDeleteCommand("tbl_requestitem")
                    IRSDBConnection.SetWhereField("reqno", rvReq.CurrentValue)
                    IRSDBConnection.ExecuteDeleteCommand()

                    If gvItem.RowCount > 0 Then
                        For i As Integer = 0 To gvItem.RowCount - 1
                            IRSDBConnection.StartUpdateCommand("tbl_requestitem")
                            IRSDBConnection.InsertField("reqno", rvReq.CurrentValue)
                            IRSDBConnection.InsertField("linenum", gvItem.GetRowCellValue(i, colLineNo).ToString.Trim())
                            IRSDBConnection.InsertField("itemno", gvItem.GetRowCellValue(i, colItemNo).ToString.Trim)
                            IRSDBConnection.InsertField("itemdesc", gvItem.GetRowCellValue(i, colItemDesc).ToString.Trim)
                            IRSDBConnection.InsertField("reqqty", Val(gvItem.GetRowCellValue(i, colReqQty).ToString))
                            IRSDBConnection.InsertField("requom", gvItem.GetRowCellValue(i, colReqUom).ToString.Trim)
                            IRSDBConnection.InsertField("fromloc", gvItem.GetRowCellValue(i, colFLoc).ToString.Trim)
                            IRSDBConnection.InsertField("toloc", gvItem.GetRowCellValue(i, colTLoc).ToString.Trim)
                            IRSDBConnection.InsertField("lineapprove", False)
                            IRSDBConnection.InsertField("isuqty", 0)
                            IRSDBConnection.InsertField("isuuom", gvItem.GetRowCellValue(i, colReqUom).ToString.Trim)
                            IRSDBConnection.InsertField("linecmt", gvItem.GetRowCellValue(i, colLineCmt).ToString.Trim)
                            IRSDBConnection.ExecuteInsertCommand()
                        Next
                    End If

                    UpdateActivityLog(rvReq.CurrentValue, "UPDATE", "Update the request information.")
                    MsgBox("New inventory request is updated.", MsgBoxStyle.Information, ProgName)

                Else
                    MsgBox("You requested quantity can't be zero.", MsgBoxStyle.Critical, ProgName)

                End If

                
            End If



        ElseIf lstStatus.SelectedIndex = 3 Then '-- Added this condition by Seven
            IRSDBConnection.StartDeleteCommand("tbl_requestitem")
            IRSDBConnection.SetWhereField("reqno", rvReq.CurrentValue)
            IRSDBConnection.ExecuteDeleteCommand()

            If gvItem.RowCount > 0 Then
                For i As Integer = 0 To gvItem.RowCount - 1
                    IRSDBConnection.StartInsertCommand("tbl_requestitem")
                    IRSDBConnection.InsertField("reqno", rvReq.CurrentValue)
                    IRSDBConnection.InsertField("linenum", gvItem.GetRowCellValue(i, colLineNo).ToString.Trim())
                    IRSDBConnection.InsertField("itemno", gvItem.GetRowCellValue(i, colItemNo).ToString.Trim)
                    IRSDBConnection.InsertField("itemdesc", gvItem.GetRowCellValue(i, colItemDesc).ToString.Trim)
                    IRSDBConnection.InsertField("reqqty", Val(gvItem.GetRowCellValue(i, colReqQty).ToString))
                    IRSDBConnection.InsertField("requom", gvItem.GetRowCellValue(i, colReqUom).ToString.Trim)
                    IRSDBConnection.InsertField("fromloc", gvItem.GetRowCellValue(i, colFLoc).ToString.Trim)
                    IRSDBConnection.InsertField("toloc", gvItem.GetRowCellValue(i, colTLoc).ToString.Trim)
                    IRSDBConnection.InsertField("lineapprove", False)
                    IRSDBConnection.InsertField("isuqty", 0)
                    IRSDBConnection.InsertField("isuuom", gvItem.GetRowCellValue(i, colReqUom).ToString.Trim)
                    IRSDBConnection.InsertField("linecmt", gvItem.GetRowCellValue(i, colLineCmt).ToString.Trim)
                    IRSDBConnection.ExecuteInsertCommand()
                Next
            End If

            IRSDBConnection.StartUpdateCommand("tbl_request")
            IRSDBConnection.SetWhereField("reqno", rvReq.CurrentValue)
            IRSDBConnection.SetUpdateField("reqstat", 2)
            IRSDBConnection.ExecuteUpdateCommand()

            UpdateActivityLog(rvReq.CurrentValue, "UPDATE", "Update the request information.")
            MsgBox("Modified", MsgBoxStyle.Information, ProgName)

            IRSDBConnection.RunDML("DELTE FROM tbl_requestitem WHERE linenum = 0")

        Else
            MsgBox("Insufficient information or inappropriate attempt. Please check again", MsgBoxStyle.Information, ProgName)
        End If



    End Sub

    Private Sub rvReq_RecordIndexChanged(sender As Object, e As EventArgs) Handles rvReq.RecordIndexChanged
        Try
            txtReason.EditValue = rvReq.CurrentView.GetFieldValueByID("REASON").ToString.Trim
            txtRef.EditValue = rvReq.CurrentView.GetFieldValueByID("REFERENCE").ToString.Trim
            lstStatus.SelectedIndex = rvReq.CurrentView.GetFieldValueByID("REQSTAT")
            dtRequest.EditValue = rvReq.CurrentView.GetFieldValueByID("REQDATE")
            txtSmtCount.EditValue = rvReq.CurrentView.GetFieldValueByID("CNTSUBMIT")
            txtFDepCode.EditValue = rvReq.CurrentView.GetFieldValueByID("REQDEP").ToString.Trim
            txtReqID.EditValue = rvReq.CurrentView.GetFieldValueByID("REQPERSON").ToString.Trim
            txtTDepCode.EditValue = rvReq.CurrentView.GetFieldValueByID("INVDEP").ToString.Trim
            optReqType.EditValue = CInt(rvReq.CurrentView.GetFieldValueByID("REQTYPE"))
            If Not IsNothing(rvReq.CurrentView.GetFieldValueByID("REQAPPROVER")) Then
                txtRAID.EditValue = rvReq.CurrentView.GetFieldValueByID("REQAPPROVER").ToString.Trim
                dtRApprove.EditValue = rvReq.CurrentView.GetFieldValueByID("REQAPPRVDATE")
                If Not IsDBNull(rvReq.CurrentView.GetFieldValueByID("REQAPPRVSTAT")) Then
                    lstRAStat.SelectedIndex = rvReq.CurrentView.GetFieldValueByID("REQAPPRVSTAT")
                End If

            End If

            If Not IsNothing(rvReq.CurrentView.GetFieldValueByID("INVAPPROVER")) Then
                txtIAID.EditValue = rvReq.CurrentView.GetFieldValueByID("INVAPPROVER").ToString.Trim
                dtIApprove.EditValue = rvReq.CurrentView.GetFieldValueByID("INVAPPRVDATE")
                If Not IsDBNull(rvReq.CurrentView.GetFieldValueByID("INVAPPRVSTAT")) Then
                    lstIAStat.SelectedIndex = rvReq.CurrentView.GetFieldValueByID("INVAPPRVSTAT")
                End If
            End If

            dgItem.DataSource = IRSDBConnection.SelectFields("select * from tbl_requestitem where reqno='" + rvReq.CurrentValue + "'")
            dgCmt.DataSource = IRSDBConnection.SelectFields("select * from tbl_requestcomment where reqno='" + rvReq.CurrentValue + "'")
            dgLog.DataSource = IRSDBConnection.SelectFields("select * from tbl_requestlog where reqno='" + rvReq.CurrentValue + "'")

            CheckRequest()

            dtRApprove.EditValue = rvReq.CurrentView.GetFieldValueByID("REQAPPRVDATE")
            lstRAStat.SelectedIndex = rvReq.CurrentView.GetFieldValueByID("REQAPPRVSTAT")

            gvItem.FocusedRowHandle = 0
            Call gvItem_Click(Nothing, Nothing)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnComment_Click(sender As Object, e As EventArgs) Handles btnComment.Click
        If IRSession.DepartmentCode = txtTDepCode.EditValue.ToString Or IRSession.DepartmentCode = txtTDepCode.EditValue.ToString.Trim Then
            Dim fm As New frmComment
            fm.ShowDialog()
        End If
    End Sub

    Private Sub btnVoid_Click(sender As Object, e As EventArgs) Handles btnVoid.Click

        IRSDBConnection.StartUpdateCommand("tbl_request")
        IRSDBConnection.SetWhereField("reqno", rvReq.CurrentValue)
        IRSDBConnection.SetUpdateField("reqstat", 9)
        IRSDBConnection.ExecuteUpdateCommand()

        IRSDBConnection.StartDeleteCommand("tbl_approveroute")
        IRSDBConnection.SetWhereField("reqno", rvReq.CurrentValue)
        IRSDBConnection.SetWhereField("done", False)
        IRSDBConnection.ExecuteDeleteCommand()

        IRSDBConnection.StartDeleteCommand("tbl_requestpr")
        IRSDBConnection.SetWhereField("reqno", rvReq.CurrentValue)
        IRSDBConnection.SetWhereField("haspr", False)
        IRSDBConnection.ExecuteDeleteCommand()

        UpdateActivityLog(rvReq.CurrentValue, "UPDATE", "Set the status of the request to VOID")

        Dim requestor As New DBUser(txtReqID.EditValue.ToString.Trim)
        Dim mail As String = "Dear " + requestor.FirstName + " " + requestor.LastName + "<br>"
        mail += "You request number " + rvReq.CurrentValue + " is voided. <br><br>"
        mail += "Best Regards,<br>Sage Admin<br>"
        IRMail.SendMail("Request: " + rvReq.CurrentValue, requestor.Email, mail)

        Dim a As String = rvReq.CurrentValue
        rvReq.CurrentValue = ""
        rvReq.CurrentValue = a

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            IRSDBConnection.StartUpdateCommand("tbl_request")
            IRSDBConnection.SetWhereField("reqno", rvReq.CurrentValue)
            IRSDBConnection.SetUpdateField("reqstat", 1)
            IRSDBConnection.SetUpdateField("approvseq", 1)
            IRSDBConnection.SetUpdateField("cntsubmit", CInt(txtSmtCount.EditValue) + 1)
            IRSDBConnection.ExecuteUpdateCommand()

            Dim reqdep As New DBDepartment(txtFDepCode.EditValue.ToString.Trim)
            Dim invdep As New DBDepartment(txtTDepCode.EditValue.ToString.Trim)
            Dim mail As String = "Dear Approver!<br>"
            mail += "Inventory request #" + rvReq.CurrentValue + " from " + txtReqID.EditValue.ToString.Trim + " (" + txtReqName.EditValue.ToString.Trim + ") need your approval. Please login to the IRS for the process.<br><br>"

            'IRSDBConnection.StartInsertCommand("tbl_approveroute")
            'IRSDBConnection.InsertField("reqno", rvReq.CurrentValue)
            'IRSDBConnection.InsertField("fromdep", txtFDepCode.EditValue.ToString.Trim)
            'IRSDBConnection.InsertField("todep", txtTDepCode.EditValue.ToString.Trim)
            'IRSDBConnection.InsertField("reason", txtReason.EditValue.ToString.Trim)
            'IRSDBConnection.InsertField("approvseq", 1)
            'IRSDBConnection.InsertField("reqstat", 1)

            'IRSDBConnection.InsertField("done", False)

            'IRSDBConnection.ExecuteInsertCommand()

            IRMail.SendSubmitNotify(rvReq.CurrentValue)


            UpdateActivityLog(rvReq.CurrentValue, "UPDATE", "Set status of the request to SUBMITTED")

            Dim a As String = rvReq.CurrentValue

            rvReq.CurrentValue = ""
            rvReq.CurrentValue = a
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtReqID_EditValueChanged(sender As Object, e As EventArgs) Handles txtReqID.EditValueChanged
        Try
            txtReqName.EditValue = IRSDBConnection.SelectField("select rtrim(FNAME) + ' ' + rtrim(LNAME) as 'name' from sys_users where userid='" + txtReqID.EditValue.ToString.Trim + "'").ToString.Trim
        Catch ex As Exception
            txtReqName.EditValue = ""
        End Try
    End Sub

    Private Sub btnSendBack_Click(sender As Object, e As EventArgs) Handles btnSendBack.Click
        btnApprove.Enabled = False
        btnReject.Enabled = False
        btnSendBack.Enabled = False

        Dim stat As Integer = IRSDBConnection.SelectField("select reqstat from tbl_request where reqno='" + rvReq.CurrentValue + "'")
        If stat = lstStatus.SelectedIndex Then
            IRSDBConnection.StartUpdateCommand("tbl_request")
            IRSDBConnection.SetWhereField("reqno", rvReq.CurrentValue)
            IRSDBConnection.SetUpdateField("reqstat", 3)
            IRSDBConnection.ExecuteUpdateCommand()
            UpdateActivityLog(rvReq.CurrentValue, "UPDATE", "Set the status of the request to EDIT REQUIRED")

            'IRSDBConnection.StartUpdateCommand("tbl_approveroute")
            'IRSDBConnection.SetWhereField("reqno", rvReq.CurrentValue)
            'IRSDBConnection.SetWhereField("done", False)
            'IRSDBConnection.SetUpdateField("done", True)
            'IRSDBConnection.SetUpdateField("approvstat", 1)
            'IRSDBConnection.ExecuteUpdateCommand()

            IRMail.SendBackNotify(rvReq.CurrentValue)
        End If
        Dim a As String = rvReq.CurrentValue
        rvReq.CurrentValue = ""
        rvReq.CurrentValue = a
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        btnApprove.Enabled = False
        btnReject.Enabled = False
        btnSendBack.Enabled = False
        Dim stat As Integer = IRSDBConnection.SelectField("select reqstat from tbl_request where reqno='" + rvReq.CurrentValue + "'")

        If stat = lstStatus.SelectedIndex Then
            Dim approvseq As Integer = IRSDBConnection.SelectField("select approvseq from tbl_request where reqno='" + rvReq.CurrentValue + "'")

            IRSDBConnection.StartUpdateCommand("tbl_request")
            IRSDBConnection.SetWhereField("reqno", rvReq.CurrentValue)

            Dim todep As New DBDepartment(txtTDepCode.EditValue.ToString.Trim)

            If approvseq = 1 And IRSession.RequestApprover = True Then 'For Request Approver'
                IRSDBConnection.SetUpdateField("reqstat", 2) 'Set it the Pending Approval
                IRSDBConnection.SetUpdateField("approvseq", 2) 'Ready for Inventory Approval
                IRSDBConnection.SetUpdateField("reqapprover", IRSession.UserID) '
                IRSDBConnection.SetUpdateField("reqapprvdate", Now.Date())
                IRSDBConnection.SetUpdateField("reqapprvstat", 0)
                IRSDBConnection.ExecuteUpdateCommand()
                UpdateActivityLog(rvReq.CurrentValue, "UPDATE", "Set the status of the request to PARTIAL APPROVED")

                'IRSDBConnection.StartUpdateCommand("tbl_approveroute")
                'IRSDBConnection.SetWhereField("reqno", rvReq.CurrentValue)
                'IRSDBConnection.SetWhereField("approvseq", 1)
                'IRSDBConnection.SetWhereField("done", False)
                'IRSDBConnection.SetUpdateField("approvstat", 0)
                'IRSDBConnection.SetUpdateField("done", True)
                'IRSDBConnection.ExecuteUpdateCommand()

                'Create Route for Inventory Approver and Send Notification
                'IRSDBConnection.StartInsertCommand("tbl_approveroute")
                'IRSDBConnection.InsertField("reqno", rvReq.CurrentValue)
                'IRSDBConnection.InsertField("fromdep", txtFDepCode.EditValue.ToString.Trim)
                'IRSDBConnection.InsertField("todep", txtTDepCode.EditValue.ToString.Trim)
                'IRSDBConnection.InsertField("reason", txtReason.EditValue.ToString.Trim)
                'IRSDBConnection.InsertField("approvseq", 2)
                'IRSDBConnection.InsertField("reqstat", lstStatus.SelectedIndex)

                'IRSDBConnection.InsertField("done", False)

                'IRSDBConnection.ExecuteInsertCommand()

                IRMail.FirstApproveNotify(rvReq.CurrentValue)

            ElseIf approvseq = 2 And IRSession.InventoryApprover = True Then 'For Inventory Approver
                IRSDBConnection.SetUpdateField("reqstat", 5) 'Set it to Final Approved
                IRSDBConnection.SetUpdateField("approvseq", 3) 'Ready for Inventory Controller
                IRSDBConnection.SetUpdateField("invapprover", IRSession.UserID) '
                IRSDBConnection.SetUpdateField("invapprvdate", Now.Date())
                IRSDBConnection.SetUpdateField("invapprvstat", 0)
                IRSDBConnection.ExecuteUpdateCommand()
                UpdateActivityLog(rvReq.CurrentValue, "UPDATE", "Set the status of the request to APPROVED")

                IRSDBConnection.StartUpdateCommand("tbl_approveroute")
                IRSDBConnection.SetWhereField("reqno", rvReq.CurrentValue)
                IRSDBConnection.SetWhereField("approvseq", 2)
                IRSDBConnection.SetWhereField("done", False)
                IRSDBConnection.SetUpdateField("done", True)
                IRSDBConnection.SetUpdateField("approvstat", 0)
                IRSDBConnection.ExecuteUpdateCommand()

                'Send Notication to Inventory Controler
                IRMail.FinalApproveNotify(rvReq.CurrentValue)


            End If
        End If

        Dim a As String = rvReq.CurrentValue
        rvReq.CurrentValue = ""
        rvReq.CurrentValue = a

        'btnApprove.Enabled = True
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        btnApprove.Enabled = False
        btnReject.Enabled = False
        btnSendBack.Enabled = False
        Dim stat As Integer = IRSDBConnection.SelectField("select reqstat from tbl_request where reqno='" + rvReq.CurrentValue + "'")
        If stat = lstStatus.SelectedIndex Then
            Dim approvseq As Integer = IRSDBConnection.SelectField("select approvseq from tbl_request where reqno='" + rvReq.CurrentValue + "'")
            IRSDBConnection.StartUpdateCommand("tbl_request")
            IRSDBConnection.SetWhereField("reqno", rvReq.CurrentValue)

            If approvseq = 1 Then 'For Request Approver'
                IRSDBConnection.SetUpdateField("reqstat", 4) 'Set it the Pending Approval
                IRSDBConnection.SetUpdateField("approvseq", 9) 'Completely rejected
                IRSDBConnection.SetUpdateField("reqapprover", IRSession.UserID) '
                IRSDBConnection.SetUpdateField("reqapprvdate", Now.Date())
                IRSDBConnection.SetUpdateField("reqapprvstat", 1)
                IRSDBConnection.ExecuteUpdateCommand()
                UpdateActivityLog(rvReq.CurrentValue, "UPDATE", "Set the status of the request to REJECTED")


            ElseIf approvseq = 2 Then 'For Inventory Approver
                IRSDBConnection.SetUpdateField("reqstat", 4) 'Set it to Final Approved
                IRSDBConnection.SetUpdateField("approvseq", 9) 'Ready for Inventory Controller
                IRSDBConnection.SetUpdateField("invapprover", IRSession.UserID) '
                IRSDBConnection.SetUpdateField("invapprvdate", Now.Date())
                IRSDBConnection.SetUpdateField("invapprvstat", 1)
                IRSDBConnection.ExecuteUpdateCommand()
                UpdateActivityLog(rvReq.CurrentValue, "UPDATE", "Set the status of the request to REJECTED")
            End If

            IRSDBConnection.StartUpdateCommand("tbl_approveroute")
            IRSDBConnection.SetWhereField("reqno", rvReq.CurrentValue)
            IRSDBConnection.SetWhereField("done", False)
            IRSDBConnection.SetUpdateField("done", True)
            IRSDBConnection.SetUpdateField("approvstat", 1)
            IRSDBConnection.ExecuteUpdateCommand()

            Dim requestor As New DBUser(txtReqID.EditValue.ToString.Trim)
            Dim mail As String = "Dear " + requestor.FirstName + " " + requestor.LastName + "<br>"
            mail += "You request number " + rvReq.CurrentValue + " is rejected by " + IRSession.UserID + "(" + IRSession.LoginName + "). <br><br>"
            mail += "Best Regards,<br>Sage Admin<br>"
            IRMail.SendMail("Request: " + rvReq.CurrentValue, requestor.Email, mail)
        End If
        Dim a As String = rvReq.CurrentValue
        rvReq.CurrentValue = ""
        rvReq.CurrentValue = a
    End Sub

    Private Sub btnArrival_Click(sender As Object, e As EventArgs) Handles btnArrival.Click
        btnPurchase.Enabled = False
        btnArrival.Enabled = False
        btnRelease.Enabled = False
        Dim stat As Integer = IRSDBConnection.SelectField("select reqstat from tbl_request where reqno='" + rvReq.CurrentValue + "'")
        If stat = lstStatus.SelectedIndex Then
            IRSDBConnection.StartUpdateCommand("tbl_request")
            IRSDBConnection.SetWhereField("reqno", rvReq.CurrentValue)
            IRSDBConnection.SetUpdateField("reqstat", 7)
            IRSDBConnection.ExecuteUpdateCommand()

            UpdateActivityLog(rvReq.CurrentValue, "UPDATE", "Set the status of the request to STOCK AVAILABLE")

            Dim requestor As New DBUser(txtReqID.EditValue.ToString.Trim)
            Dim mail As String = "Dear " + requestor.FirstName + " " + requestor.LastName + "<br>"
            mail += "You request number " + rvReq.CurrentValue + " is ready to collect. <br><br>"
            mail += "Best Regards,<br>Sage Admin<br>"
            IRMail.SendMail("Request: " + rvReq.CurrentValue, requestor.Email, mail)
        End If
        Dim a As String = rvReq.CurrentValue
        rvReq.CurrentValue = ""
        rvReq.CurrentValue = a

    End Sub

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        btnPurchase.Enabled = False
        btnArrival.Enabled = False
        btnRelease.Enabled = False

        Dim stat As Integer = IRSDBConnection.SelectField("select reqstat from tbl_request where reqno='" + rvReq.CurrentValue + "'")
        If stat = lstStatus.SelectedIndex Then
            'Code to create PR Queue here
            If SendToPurchase(rvReq.CurrentValue) = True Then
                IRSDBConnection.StartUpdateCommand("tbl_request")
                IRSDBConnection.SetWhereField("reqno", rvReq.CurrentValue)
                IRSDBConnection.SetUpdateField("reqstat", 6)
                IRSDBConnection.ExecuteUpdateCommand()
                UpdateActivityLog(rvReq.CurrentValue, "UPDATE", "Set the status of the request to WAITING FOR PURCHASE")
                Dim requestor As New DBUser(txtReqID.EditValue.ToString.Trim)
                Dim mail As String = "Dear " + requestor.FirstName + " " + requestor.LastName + "<br>"
                mail += "You request number " + rvReq.CurrentValue + " is sent to Purchasing. <br><br>"
                mail += "Best Regards,<br>Sage Admin<br>"
                IRMail.SendMail("Request: " + rvReq.CurrentValue, requestor.Email, mail)
                
            End If
        End If

        Dim a As String = rvReq.CurrentValue
        rvReq.CurrentValue = ""
        rvReq.CurrentValue = a
    End Sub

    Function InternalRequest() As Boolean
        Dim cnt As Integer = 0



        For i As Integer = 0 To gvItem.RowCount - 1
            Dim fromloc As String = gvItem.GetRowCellValue(i, colFLoc).ToString.Trim
            Dim toloc As String = gvItem.GetRowCellValue(i, colTLoc).ToString.Trim
            If fromloc = toloc Then
                cnt = cnt + 1
            End If
        Next

        If cnt = gvItem.RowCount Then
            Return True
        Else
            Return False
        End If
    End Function





    Private Sub btnRelease_Click(sender As Object, e As EventArgs) Handles btnRelease.Click
        btnPurchase.Enabled = False
        btnArrival.Enabled = False
        btnRelease.Enabled = False
        Dim reqstat As Integer = IRSDBConnection.SelectField("select reqstat from tbl_request where reqno='" + rvReq.CurrentValue + "'")

        If reqstat = lstStatus.SelectedIndex And IRSession.InventoryControler = True Then 'if the status on the form and database are the same.

            If ReleaseRequest(rvReq.CurrentValue) = True Then 'Transfer is success
                'Update status of the request to RELEASED

                IRSDBConnection.StartUpdateCommand("tbl_request")
                IRSDBConnection.SetWhereField("reqno", rvReq.CurrentValue)
                IRSDBConnection.SetUpdateField("reqstat", 8)
                IRSDBConnection.ExecuteUpdateCommand()

                For i As Integer = 0 To gvItem.RowCount - 1
                    IRSDBConnection.StartUpdateCommand("tbl_requestitem")
                    IRSDBConnection.SetWhereField("reqno", rvReq.CurrentValue)
                    IRSDBConnection.SetWhereField("linenum", gvItem.GetRowCellValue(i, colLineNo).ToString.Trim)
                    IRSDBConnection.SetUpdateField("isuqty", Val(gvItem.GetRowCellValue(i, colReqQty)))
                    IRSDBConnection.ExecuteUpdateCommand()
                Next

                UpdateActivityLog(rvReq.CurrentValue, "UPDATE", "Set the status of the request to RELEASED")

                Dim completed As Boolean = False

                'Start the Internal Usage
                Dim reqtype As Integer = CInt(rvReq.CurrentView.GetFieldValueByID("REQTYPE"))
                If reqtype = 0 Then 'Request for use
                    If UsageRequest(rvReq.CurrentValue) = True Then 'Internal Usage is success.
                        IRSDBConnection.StartUpdateCommand("tbl_request")
                        IRSDBConnection.SetWhereField("reqno", rvReq.CurrentValue)
                        IRSDBConnection.SetUpdateField("reqstat", 10)
                        IRSDBConnection.ExecuteUpdateCommand()
                        UpdateActivityLog(rvReq.CurrentValue, "UPDATE", "Set the status of the request to USED")
                        completed = True



                    Else
                        MsgBox("The items are released but we cannot post the Internal Usage for unknown reason.", MsgBoxStyle.Information)
                    End If



                Else 'Request for sales ==> No posting of Internal Usage. only update status to COLLECTED.
                    IRSDBConnection.StartUpdateCommand("tbl_request")
                    IRSDBConnection.SetWhereField("reqno", rvReq.CurrentValue)
                    IRSDBConnection.SetUpdateField("reqstat", 11)
                    IRSDBConnection.ExecuteUpdateCommand()
                    UpdateActivityLog(rvReq.CurrentValue, "UPDATE", "Set the status of the request to COLLECTED")
                    completed = True


                End If

                If completed = True Then 'both Transfer and Usage posted

                    UpdateCost(rvReq.CurrentValue)

                    Dim requestor As New DBUser(txtReqID.EditValue.ToString.Trim)
                    Dim mail As String = "Dear " + requestor.FirstName + " " + requestor.LastName + "<br>"
                    mail += "You request number " + rvReq.CurrentValue + " is released. <br><br>"
                    mail += "Best Regards,<br>Sage Admin<br>"
                    IRMail.SendMail("Request: " + rvReq.CurrentValue, requestor.Email, mail)

                End If



                Dim a As String = rvReq.CurrentValue
                rvReq.CurrentValue = ""
                rvReq.CurrentValue = a

            Else
                MsgBox("Cannot process the release at this time. This may be caused by inadequate stock balance.", MsgBoxStyle.Information)
            End If
        End If

    End Sub
    Private Sub btnRelease_Click1(sender As Object, e As EventArgs)
        'Dim released As Boolean = False
        Dim stat As Integer = IRSDBConnection.SelectField("select reqstat from tbl_request where reqno='" + rvReq.CurrentValue + "'")

        If stat = lstStatus.SelectedIndex Then
            'Code to Make Stock Transfer Here.
            If InternalRequest() = True Then 'This is for request in the same department.
                IRSDBConnection.StartUpdateCommand("tbl_request")
                IRSDBConnection.SetWhereField("reqno", rvReq.CurrentValue)
                IRSDBConnection.SetUpdateField("reqstat", 8)
                IRSDBConnection.ExecuteUpdateCommand()

                For i As Integer = 0 To gvItem.RowCount - 1
                    IRSDBConnection.StartUpdateCommand("tbl_requestitem")
                    IRSDBConnection.SetWhereField("reqno", rvReq.CurrentValue)
                    IRSDBConnection.SetUpdateField("isuqty", Val(gvItem.GetRowCellValue(i, colReqQty)))
                    IRSDBConnection.SetUpdateField("isuuom", gvItem.GetRowCellValue(i, colReqUom).ToString.Trim)
                    IRSDBConnection.ExecuteUpdateCommand()
                Next
                UpdateActivityLog(rvReq.CurrentValue, "UPDATE", "Set the status of the request to RELEASED")

                ProcesUseRequest(CInt(rvReq.CurrentView.GetFieldValueByID("REQTYPE")))

                Dim requestor As New DBUser(txtReqID.EditValue.ToString.Trim)
                Dim mail As String = "Dear " + requestor.FirstName + " " + requestor.LastName + "<br>"
                mail += "You request number " + rvReq.CurrentValue + " is released. <br><br>"
                mail += "Best Regards,<br>Sage Admin<br>"
                IRMail.SendMail("Request: " + rvReq.CurrentValue, requestor.Email, mail)



            Else 'This is for request from other departments.
                If ReleaseRequest(rvReq.CurrentValue) = True Then
                    IRSDBConnection.StartUpdateCommand("tbl_request")
                    IRSDBConnection.SetWhereField("reqno", rvReq.CurrentValue)
                    IRSDBConnection.SetUpdateField("reqstat", 8)
                    IRSDBConnection.ExecuteUpdateCommand()

                    For i As Integer = 0 To gvItem.RowCount - 1
                        IRSDBConnection.StartUpdateCommand("tbl_requestitem")
                        IRSDBConnection.SetWhereField("reqno", rvReq.CurrentValue)
                        IRSDBConnection.SetUpdateField("isuqty", Val(gvItem.GetRowCellValue(i, colReqQty)))
                        IRSDBConnection.SetUpdateField("isuuom", gvItem.GetRowCellValue(i, colReqUom).ToString.Trim)
                        IRSDBConnection.ExecuteUpdateCommand()
                    Next
                    UpdateActivityLog(rvReq.CurrentValue, "UPDATE", "Set the status of the request to RELEASED")

                    ProcesUseRequest(CInt(rvReq.CurrentView.GetFieldValueByID("REQTYPE")))

                    Dim requestor As New DBUser(txtReqID.EditValue.ToString.Trim)
                    Dim mail As String = "Dear " + requestor.FirstName + " " + requestor.LastName + "<br>"
                    mail += "You request number " + rvReq.CurrentValue + " is released. <br><br>"
                    mail += "Best Regards,<br>Sage Admin<br>"
                    IRMail.SendMail("Request: " + rvReq.CurrentValue, requestor.Email, mail)
                Else
                    MsgBox("Sage posting is not success", MsgBoxStyle.Information)
                End If
            End If




        End If
        Dim a As String = rvReq.CurrentValue
        rvReq.CurrentValue = ""
        rvReq.CurrentValue = a
    End Sub

    Private Sub gvItem_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvItem.FocusedRowChanged
        Try

            Dim itemno As String = gvItem.GetRowCellValue(gvItem.FocusedRowHandle, colItemNo).ToString.Trim()
            Dim requom As String = gvItem.GetRowCellValue(gvItem.FocusedRowHandle, colReqUom).ToString.Trim()
            Dim conversion As Double = SageDBConnection.SelectField("select CONVERSION from ICUNIT where ITEMNO='" + itemno + "' and UNIT='" + requom + "'")
            Dim fromloc As String = gvItem.GetRowCellValue(gvItem.FocusedRowHandle, colFLoc).ToString.Trim

            lblUOM.Text = requom
            lblUOM1.Text = requom
            txtQtyNeed.EditValue = Val(gvItem.GetRowCellValue(gvItem.FocusedRowHandle, colReqQty).ToString)
            lblLoc.Text = "Location (" + fromloc + ")"
            lblLoc1.Text = "Location (" + gvItem.GetRowCellValue(gvItem.FocusedRowHandle, colTLoc).ToString.Trim + ")"

            Dim qoh As Double = SageDBConnection.SelectField("select sum(QTYONHAND) as 'QTY' from ICILOC where ITEMNO='" + itemno + "' and LOCATION='" + fromloc + "'")

            txtQOH.EditValue = If(qoh > 0, qoh / conversion, 0)

        Catch ex As Exception
            txtQOH.EditValue = 0


        End Try
    End Sub

    Private Sub gvItem_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvItem.RowClick
        'Try

        '    Dim itemno As String = gvItem.GetRowCellValue(gvItem.FocusedRowHandle, colItemNo).ToString.Trim()
        '    Dim requom As String = gvItem.GetRowCellValue(gvItem.FocusedRowHandle, colReqUom).ToString.Trim()
        '    Dim conversion As Double = SageDBConnection.SelectField("select CONVERSION from ICUNIT where ITEMNO='" + itemno + "' and UNIT='" + requom + "'")
        '    Dim fromloc As String = gvItem.GetRowCellValue(gvItem.FocusedRowHandle, colFLoc).ToString.Trim

        '    lblUOM.Text = requom
        '    lblUOM1.Text = requom
        '    txtQtyNeed.EditValue = Val(gvItem.GetRowCellValue(gvItem.FocusedRowHandle, colReqQty).ToString)
        '    lblLoc.Text = "Location (" + fromloc + ")"
        '    lblLoc1.Text = "Location (" + gvItem.GetRowCellValue(gvItem.FocusedRowHandle, colTLoc).ToString.Trim + ")"



        '    Dim qoh As Double = SageDBConnection.SelectField("select sum(QTYONHAND) as 'QTY' from ICILOC where ITEMNO='" + itemno + "' and LOCATION='" + fromloc + "'")


        '    txtQOH.EditValue = If(qoh > 0, qoh / conversion, 0)

        'Catch ex As Exception
        '    txtQOH.EditValue = 0


        'End Try
    End Sub

    Private Sub txtRAID_EditValueChanged(sender As Object, e As EventArgs) Handles txtRAID.EditValueChanged
        Try
            txtRAName.EditValue = IRSDBConnection.SelectField("select rtrim(FNAME) + ' ' + rtrim(LNAME) from sys_users where userid='" + txtRAID.EditValue.ToString.Trim + "'")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtIAID_EditValueChanged(sender As Object, e As EventArgs) Handles txtIAID.EditValueChanged
        Try
            txtIAName.EditValue = IRSDBConnection.SelectField("select rtrim(FNAME) + ' ' + rtrim(LNAME) from sys_users where userid='" + txtIAID.EditValue.ToString.Trim + "'")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ProcesUseRequest(ByVal RequestType As Integer)
        If RequestType = 0 Then 'Internal Use

            'Code to Make Stock Internal Use Here.
            If UsageRequest(rvReq.CurrentValue) = True Then
                IRSDBConnection.StartUpdateCommand("tbl_request")
                IRSDBConnection.SetWhereField("reqno", rvReq.CurrentValue)
                IRSDBConnection.SetUpdateField("reqstat", 10)
                IRSDBConnection.ExecuteUpdateCommand()
                UpdateActivityLog(rvReq.CurrentValue, "UPDATE", "Set the status of the request to USED")
                Dim a As String = rvReq.CurrentValue
                rvReq.CurrentValue = ""
                rvReq.CurrentValue = a
            Else
                MsgBox("I/C Internal Usage is not completed.")
            End If

        Else 'For Sale.
        Try
            IRSDBConnection.StartUpdateCommand("tbl_request")
            IRSDBConnection.SetWhereField("reqno", rvReq.CurrentValue)
            IRSDBConnection.SetUpdateField("reqstat", 11)
            IRSDBConnection.ExecuteUpdateCommand()
            UpdateActivityLog(rvReq.CurrentValue, "UPDATE", "Set the status of the request to USED")
            Dim a As String = rvReq.CurrentValue
            rvReq.CurrentValue = ""
            rvReq.CurrentValue = a
        Catch ex As Exception

        End Try

        End If
    End Sub

    Private Sub btnUse_Click(sender As Object, e As EventArgs) Handles btnUse.Click
        Dim res As MsgBoxResult = MsgBox("Are you selling the item(s) to the customer?", MsgBoxStyle.YesNo, ProgName)
        If res = MsgBoxResult.No Then 'They are using for themselves.
            Dim stat As Integer = IRSDBConnection.SelectField("select reqstat from tbl_request where reqno='" + rvReq.CurrentValue + "'")
            If stat = lstStatus.SelectedIndex Then
                'Code to Make Stock Internal Use Here.
                If UsageRequest(rvReq.CurrentValue) = True Then
                    IRSDBConnection.StartUpdateCommand("tbl_request")
                    IRSDBConnection.SetWhereField("reqno", rvReq.CurrentValue)
                    IRSDBConnection.SetUpdateField("reqstat", 10)
                    IRSDBConnection.ExecuteUpdateCommand()
                    UpdateActivityLog(rvReq.CurrentValue, "UPDATE", "Set the status of the request to USED")
                    Dim a As String = rvReq.CurrentValue
                    rvReq.CurrentValue = ""
                    rvReq.CurrentValue = a
                Else
                    MsgBox("Sage posting is not completed.")
                End If

            End If
        Else 'Yes, they are selling item to the customer.
            Try
                IRSDBConnection.StartUpdateCommand("tbl_request")
                IRSDBConnection.SetWhereField("reqno", rvReq.CurrentValue)
                IRSDBConnection.SetUpdateField("reqstat", 11)
                IRSDBConnection.ExecuteUpdateCommand()
                UpdateActivityLog(rvReq.CurrentValue, "UPDATE", "Set the status of the request to USED")
                Dim a As String = rvReq.CurrentValue
                rvReq.CurrentValue = ""
                rvReq.CurrentValue = a
            Catch ex As Exception

            End Try
        End If



       

    End Sub

    Private Sub rvReq_PrintRecordFired(sender As Object, e As EventArgs) Handles rvReq.PrintRecordFired
        If rvReq.IsNewItem = False Then
            Dim rpt As New CrReport("request", 0)
            rpt.SetParameter("reqno", rvReq.CurrentValue)
            rpt.Preview()
        End If
        

    End Sub

    Private Sub gvItem_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gvItem.RowCellClick
        'Try

        '    Dim itemno As String = gvItem.GetRowCellValue(gvItem.FocusedRowHandle, colItemNo).ToString.Trim()
        '    Dim requom As String = gvItem.GetRowCellValue(gvItem.FocusedRowHandle, colReqUom).ToString.Trim()
        '    Dim conversion As Double = SageDBConnection.SelectField("select CONVERSION from ICUNIT where ITEMNO='" + itemno + "' and UNIT='" + requom + "'")
        '    Dim fromloc As String = gvItem.GetRowCellValue(gvItem.FocusedRowHandle, colFLoc).ToString.Trim

        '    lblUOM.Text = requom
        '    lblUOM1.Text = requom
        '    txtQtyNeed.EditValue = Val(gvItem.GetRowCellValue(gvItem.FocusedRowHandle, colReqQty).ToString)
        '    lblLoc.Text = "Location (" + fromloc + ")"
        '    lblLoc1.Text = "Location (" + gvItem.GetRowCellValue(gvItem.FocusedRowHandle, colTLoc).ToString.Trim + ")"

        '    Dim qoh As Double = SageDBConnection.SelectField("select sum(QTYONHAND) as 'QTY' from ICILOC where ITEMNO='" + itemno + "' and LOCATION='" + fromloc + "'")


        '    txtQOH.EditValue = If(qoh > 0, qoh / conversion, 0)

        'Catch ex As Exception
        '    txtQOH.EditValue = 0


        'End Try
    End Sub

    Private Sub gvItem_Click(sender As Object, e As EventArgs) Handles gvItem.Click
        Try

            Dim itemno As String = gvItem.GetRowCellValue(gvItem.FocusedRowHandle, colItemNo).ToString.Trim()
            Dim requom As String = gvItem.GetRowCellValue(gvItem.FocusedRowHandle, colReqUom).ToString.Trim()
            Dim conversion As Double = SageDBConnection.SelectField("select CONVERSION from ICUNIT where ITEMNO='" + itemno + "' and UNIT='" + requom + "'")
            Dim fromloc As String = gvItem.GetRowCellValue(gvItem.FocusedRowHandle, colFLoc).ToString.Trim

            lblUOM.Text = requom
            lblUOM1.Text = requom
            txtQtyNeed.EditValue = Val(gvItem.GetRowCellValue(gvItem.FocusedRowHandle, colReqQty).ToString)
            lblLoc.Text = "Location (" + fromloc + ")"
            lblLoc1.Text = "Location (" + gvItem.GetRowCellValue(gvItem.FocusedRowHandle, colTLoc).ToString.Trim + ")"

            Dim qoh As Double = SageDBConnection.SelectField("select sum(QTYONHAND) as 'QTY' from ICILOC where ITEMNO='" + itemno + "' and LOCATION='" + fromloc + "'")


            txtQOH.EditValue = If(qoh > 0, qoh / conversion, 0)

        Catch ex As Exception
            txtQOH.EditValue = 0


        End Try
    End Sub

    Private Sub txtFDepCode_EditValueChanged(sender As Object, e As EventArgs) Handles txtFDepCode.EditValueChanged
        '-- Begin updated by seven at 2018-09-13
        Dim deptName As String = IRSDBConnection.SelectField("select depdesc from tbl_departments where depcode='" + txtFDepCode.EditValue + "'").ToString.Trim
        txtFDepName.EditValue = deptName
        '-- End updated
    End Sub

    Function SageDocumentNo(ByVal RequestType As Integer, ByRef RequestNo As String) As String
        Dim docnum As String = ""
        If RequestType = 0 Then ' For usage, check from Internal Usage
            docnum = SageDBConnection.SelectField("select DOCNUM from ICICEH where REFERENCE = '" + RequestNo + "'").ToString.Trim
        Else 'Sell to customer, Check from Transfer
            docnum = SageDBConnection.SelectField("select DOCNUM from ICTREH where REFERENCE = '" + RequestNo + "'").ToString.Trim
        End If
        Return docnum
    End Function

    Function InventoryAccount(ByVal ItemNo As String) As String
        Dim accset As String = SageDBConnection.SelectField("select CNTLACCT from ICITEM where ITEMNO='" + ItemNo + "'").ToString.Trim
        Dim acctno As String = SageDBConnection.SelectField("select INVACCT from ICACCT where CNTLACCT='" + accset + "'").ToString.Trim
    End Function

    Sub UpdateCost(ByVal RequestNo As String)
        Dim tblreq As DataTable = IRSDBConnection.SelectFields("select * from tbl_request where reqno='" + RequestNo + "'")
        If tblreq.Rows.Count > 0 Then
            Dim reqtype As Integer = tblreq.Rows(0)("reqtype")
            Dim sagedocnum As String = SageDocumentNo(reqtype, RequestNo)
            If sagedocnum.Trim <> "" And sagedocnum.Trim <> "Null" Then
                Dim tblItemReq As DataTable = IRSDBConnection.SelectFields("select * from tbl_requestitem where reqno='" + RequestNo + "' order by linenum asc")
                Dim tblIcIval As New DataTable
                Dim tblIcUsage As New DataTable
                Dim totalcost As Double = 0
                If reqtype = 0 Then 'Usage
                    tblIcIval = SageDBConnection.SelectFields("select * from ICIVAL where DOCNUM ='" + sagedocnum + "' order by [LINENO] desc")
                    tblIcUsage = SageDBConnection.SelectFields("select b.* from ICICEH a inner join ICICED b on a.SEQUENCENO = b.SEQUENCENO where a.REFERENCE = '" + RequestNo + "' order by [LINENO] desc")




                Else
                    tblIcIval = SageDBConnection.SelectFields("select * from ICIVAL where DOCNUM ='" + sagedocnum + "' and QUANTITY >0 order by [LINENO] desc")
                End If

                For i As Integer = 0 To tblItemReq.Rows.Count - 1
                    Dim itemno As String = tblItemReq.Rows(i)("itemno").ToString.Trim
                    Dim unitcost As Double = Math.Abs(tblIcIval.Rows(i)("RECENTCOST"))
                    Dim extcost As Double = Math.Abs(tblIcIval.Rows(i)("RECENTCOST")) * tblItemReq.Rows(i)("reqqty")
                    Dim accno As String = ""
                    Dim accname As String = ""
                    If reqtype = 0 Then
                        accno = tblIcUsage.Rows(i)("GLACCT").ToString.Trim.Replace("-", "")
                    Else
                        accno = InventoryAccount(itemno)
                    End If
                    accname = SageDBConnection.SelectField("select ACCTDESC from GLAMF where ACCTID='" + accno + "'").ToString.Trim
                    totalcost = totalcost + extcost
                    IRSDBConnection.StartUpdateCommand("tbl_requestitem")
                    IRSDBConnection.SetWhereField("reqno", RequestNo)
                    IRSDBConnection.SetWhereField("linenum", i + 1)
                    IRSDBConnection.SetUpdateField("unitcost", unitcost)
                    IRSDBConnection.SetUpdateField("extcost", extcost)
                    IRSDBConnection.SetUpdateField("accno", accno)
                    IRSDBConnection.SetUpdateField("accname", accname)
                    IRSDBConnection.ExecuteUpdateCommand()
                Next

                IRSDBConnection.StartUpdateCommand("tbl_request")
                IRSDBConnection.SetWhereField("reqno", RequestNo)
                IRSDBConnection.SetUpdateField("totalcost", totalcost)
                IRSDBConnection.ExecuteUpdateCommand()
            End If
            

        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        Try
            UpdateCost("IR190006593")
            MsgBox("Done")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Dim tblIRS As DataTable = IRSDBConnection.SelectFields("select reqno from tbl_request where reqstat = 10  and (totalcost = 0 or totalcost is null) order by reqno desc")
        'For i As Integer = 0 To tblIRS.Rows.Count - 1
        '    Try
        '        UpdateCost(tblIRS.Rows(i)("reqno").ToString.Trim)
        '    Catch ex As Exception

        '    End Try
        'Next


        ' Loop to update cost
        'Dim docnum = SageDocumentNo(optReqType.SelectedIndex, rvReq.CurrentValue)
        'Dim totalcost As Double = 0
        'Dim toloc As String = gvItem.GetRowCellValue(0, colTLoc).ToString.Trim
        'Dim tblVal As DataTable = SageDBConnection.SelectFields("select * from ICIVAL where DOCNUM ='" + docnum + "' and LOCATION='" + toloc + "' order by [LINENO] desc")
        'Dim tblIu As DataTable = SageDBConnection.SelectFields("select b.* from ICICEH a inner join ICICED b on a.SEQUENCENO = b.SEQUENCENO where a.REFERENCE = '" + rvReq.CurrentValue + "' order by [LINENO] desc")

        'For i As Integer = 0 To gvItem.RowCount - 1
        '    Dim itemno As String = gvItem.GetRowCellValue(i, colItemNo).ToString.Trim
        '    Dim unitcost As Double = Math.Abs(tblVal.Rows(i)("RECENTCOST"))
        '    Dim extcost As Double = Math.Abs(tblVal.Rows(i)("RECENTCOST")) * gvItem.GetRowCellValue(i, colReqQty)
        '    Dim accno As String = tblIu.Rows(i)("GLACCT").ToString.Trim.Replace("-", "")
        '    Dim accname As String = SageDBConnection.SelectField("select ACCTDESC from GLAMF where ACCTID='" + accno + "'").ToString.Trim
        '    totalcost = totalcost + extcost
        '    IRSDBConnection.StartUpdateCommand("tbl_requestitem")
        '    IRSDBConnection.SetWhereField("reqno", rvReq.CurrentValue)
        '    IRSDBConnection.SetWhereField("linenum", i + 1)
        '    IRSDBConnection.SetUpdateField("unitcost", unitcost)
        '    IRSDBConnection.SetUpdateField("extcost", extcost)
        '    IRSDBConnection.SetUpdateField("accno", accno)
        '    IRSDBConnection.SetUpdateField("accname", accname)
        '    IRSDBConnection.ExecuteUpdateCommand()
        'Next

        'IRSDBConnection.StartUpdateCommand("tbl_request")
        'IRSDBConnection.SetWhereField("reqno", rvReq.CurrentValue)
        'IRSDBConnection.SetUpdateField("totalcost", totalcost)
        'IRSDBConnection.ExecuteUpdateCommand()
        ' end the cost update


        'MsgBox("Success")

    End Sub
End Class