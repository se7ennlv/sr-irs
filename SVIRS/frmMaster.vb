Public Class frmMaster 

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()

    End Sub

    Private Sub nvConfigure_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nvConfigure.LinkClicked
        ShowForm(frmConfigure)
    End Sub

    Private Sub frmMaster_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmLogin.Show()
    End Sub

    Private Sub frmMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Savan Legend Resort - Inventory Request System (" + IRSession.UserID + ")"

        If IRSession.UserType = 3 Then
            NavBarGroup1.Visible = True
            NavBarGroup2.Visible = False
            nvMyApproval.Visible = False
            nvMyRequest.Visible = False
        ElseIf IRSession.UserType = 0 Then 'Requestor
            nvBalance.Visible = True
            nvPRLookup.Visible = False
            nvMyApproval.Visible = False
            nvMyRequest.Visible = True
            NavBarGroup1.Visible = False
            NavBarGroup2.Visible = True
        ElseIf IRSession.UserType = 1 Then 'Approver
            nvBalance.Visible = True
            nvPRLookup.Visible = False
            nvMyApproval.Visible = True
            nvMyRequest.Visible = False
            NavBarGroup1.Visible = False
            NavBarGroup2.Visible = True
        Else 'Inventory Controler
            nvBalance.Visible = True
            nvPRLookup.Visible = True
            nvMyApproval.Visible = True
            nvMyRequest.Visible = False

            NavBarGroup1.Visible = False
            NavBarGroup2.Visible = True
        End If






    End Sub

    Private Sub nvUsers_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nvUsers.LinkClicked
        ShowForm(frmUser)
    End Sub

    Private Sub nvDepartment_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nvDepartment.LinkClicked
        ShowForm(frmDepartment)
    End Sub

    Private Sub nvRptMgr_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nvRptMgr.LinkClicked
        ShowForm(frmRptManager)
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click
        Dim fm As New frmCustomRpt
        fm.ShowDialog()
    End Sub

    Private Sub nvRequest_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nvRequest.LinkClicked
        ShowForm(frmInvRequest)
    End Sub

    Private Sub ProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfileToolStripMenuItem.Click
        If IRSession.UserID <> "ADMIN" Then
            Dim fm As New frmUsrProfile
            fm.ShowDialog()
        End If
    End Sub

    Private Sub nvMyRequest_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nvMyRequest.LinkClicked
        ShowForm(frmMyRequest)
    End Sub

    Private Sub nvMyApproval_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nvMyApproval.LinkClicked
        If IRSession.UserType > 0 Then
            ShowForm(frmMyApproval)
        End If
    End Sub

    Private Sub nvBalance_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nvBalance.LinkClicked

        ShowForm(frmStockBalance)


    End Sub

    Private Sub nvPRLookup_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nvPRLookup.LinkClicked
        If IRSession.UserType >= 2 Then
            ShowForm(frmPurchaseQue)
        End If
    End Sub
End Class