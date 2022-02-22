Public Class frmComment 

    Private Sub frmComment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtComment.EditValue = ""
        txtComment.Focus()
        txtComment.Select(0, 0)
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If txtComment.EditValue.ToString.Trim.Length > 0 Then
            Try
                Dim a As String = frmInvRequest.rvReq.CurrentValue
                AddComment(a, txtComment.EditValue.ToString.Trim)
                frmInvRequest.rvReq.CurrentValue = ""
                frmInvRequest.rvReq.CurrentValue = a
                Me.Close()
            Catch ex As Exception

            End Try

        End If
    End Sub
End Class