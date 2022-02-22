Public Class frmStockBalance 

    Private Sub rvItem_RecordIndexChanged(sender As Object, e As EventArgs) Handles rvItem.RecordIndexChanged
        txtDesc.EditValue = rvItem.CurrentView.GetFieldValueByID("DESC").ToString.Trim
        dgStock.DataSource = SageDBConnection.SelectFields("select a.LOCATION,b.[DESC],a.QTYONHAND,a.COSTUNIT from ICILOC a inner join ICLOC b on a.LOCATION = b.LOCATION where a.ITEMNO='" + rvItem.CurrentValue + "'")
    End Sub

    Private Sub rvItem_EditValueChanged(sender As Object, e As EventArgs) Handles rvItem.EditValueChanged
        txtDesc.EditValue = rvItem.CurrentView.GetFieldValueByID("DESC").ToString.Trim
        dgStock.DataSource = SageDBConnection.SelectFields("select a.LOCATION,b.[DESC],a.QTYONHAND,a.COSTUNIT from ICILOC a inner join ICLOC b on a.LOCATION = b.LOCATION where a.ITEMNO='" + rvItem.CurrentValue + "'")
    End Sub
End Class