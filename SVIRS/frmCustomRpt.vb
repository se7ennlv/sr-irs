Public Class frmCustomRpt 

    Private Sub frmCustomRpt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IRSession.UserID <> "ADMIN" Then
            Try
                lstReport.Properties.DataSource = IRSDBConnection.SelectFields("select rptcode, rptdesc from tbl_reports where rptcode in(select rptcode from tbl_reportuser where userid='" + IRSession.UserID + "')")
                lstReport.ItemIndex = 0
            Catch ex As Exception

            End Try
        Else
            Try
                lstReport.Properties.DataSource = IRSDBConnection.SelectFields("select rptcode, rptdesc from tbl_reports")
                lstReport.ItemIndex = 0
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Try
            Dim rpt As New DBReport(lstReport.EditValue.ToString.Trim)
            rpt.Preview()
        Catch ex As Exception

        End Try
    End Sub
End Class