Public Class frmItemScan 

    Private _fromdep As String
    Private _todep As String

    WriteOnly Property FromDepartment As String
        Set(value As String)
            _fromdep = value
        End Set
    End Property
    WriteOnly Property ToDepartment As String
        Set(value As String)
            _todep = value
        End Set
    End Property
    Private Sub frmItemScan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSearch.EditValue = ""
        txtSearch.Focus()
        txtSearch.Select(0, 0)
        txtItemNo.EditValue = ""
        txtComment.EditValue = ""
        txtItemDesc.EditValue = ""
        txtReqQty.EditValue = 1

        lstFromLocation.Properties.DataSource = IRSDBConnection.SelectFields("select location,locdesc from tbl_deplocation where depcode='" + _todep + "'")
        lstToLocation.Properties.DataSource = IRSDBConnection.SelectFields("select location,locdesc from tbl_deplocation where depcode='" + _fromdep + "'")

        lstFromLocation.ItemIndex = 0
        lstToLocation.ItemIndex = 0


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.EditValue.ToString.Trim.Length = 0 Then
            Dim fm As New fmFinder
            fm.Caption = "Item Finder"
            fm.SetViewID("Item", 1)
            fm.AddFilterFields("INACTIVE", "0")
            fm.ReturnField = "ITEMNO"
            fm.TargetTextEdit = txtSearch
            fm.ShowFinder()
            btnAdd.Enabled = False
        Else
            Dim tb As DataTable = SageDBConnection.SelectFields("select itemno, [desc] from icitem where itemno='" + txtSearch.EditValue.ToString.Trim + "' or comment4='" + txtSearch.EditValue.ToString.Trim + "'")
            If tb.Rows.Count = 1 Then
                txtItemNo.EditValue = tb.Rows(0)("itemno").ToString.Trim
                txtItemDesc.EditValue = tb.Rows(0)("desc").ToString.Trim
            End If
            lstUOM.Properties.DataSource = SageDBConnection.SelectFields("select UNIT from ICUNIT where ITEMNO='" + txtItemNo.EditValue.ToString.Trim + "'")
            lstUOM.ItemIndex = 0
            btnAdd.Enabled = True
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtItemNo.EditValue.ToString.Trim.Length > 0 And Val(txtReqQty.EditValue) > 0 Then
            

            With frmInvRequest
                .gvItem.AddNewRow()
                .gvItem.AddNewRow()
                .gvItem.DeleteRow(.gvItem.FocusedRowHandle) 'Activate the DevXpress grid control


                .gvItem.SetRowCellValue(.gvItem.FocusedRowHandle, .colLineNo, .gvItem.FocusedRowHandle + 1)
                .gvItem.SetRowCellValue(.gvItem.FocusedRowHandle, .colItemNo, txtItemNo.EditValue.ToString.Trim)
                .gvItem.SetRowCellValue(.gvItem.FocusedRowHandle, .colItemDesc, txtItemDesc.EditValue.ToString.Trim)
                .gvItem.SetRowCellValue(.gvItem.FocusedRowHandle, .colReqQty, txtReqQty.EditValue)
                .gvItem.SetRowCellValue(.gvItem.FocusedRowHandle, .colReqUom, lstUOM.EditValue.ToString.Trim)
                .gvItem.SetRowCellValue(.gvItem.FocusedRowHandle, .colFLoc, lstFromLocation.EditValue.ToString.Trim)
                .gvItem.SetRowCellValue(.gvItem.FocusedRowHandle, .colTLoc, lstToLocation.EditValue.ToString.Trim)
                .gvItem.SetRowCellValue(.gvItem.FocusedRowHandle, .colLineApprv, False)
                .gvItem.SetRowCellValue(.gvItem.FocusedRowHandle, .colIsuQty, 0)
                .gvItem.SetRowCellValue(.gvItem.FocusedRowHandle, .colIsuUOM, lstUOM.EditValue.ToString.Trim)
                .gvItem.SetRowCellValue(.gvItem.FocusedRowHandle, .colLineCmt, txtComment.EditValue.ToString.Trim)

                .gvItem.AddNewRow()
                .gvItem.DeleteRow(.gvItem.FocusedRowHandle) 'Recalculate and reactivate the grid control

            End With

            Me.Close()

        End If
    End Sub


End Class