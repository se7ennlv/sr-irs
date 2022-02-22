

Public Class frmPurchaseQue

    Private Sub frmPurchaseQue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IRSession.UserType = 2 Then
            btnCreatePR.Enabled = True
        Else
            btnCreatePR.Enabled = False
        End If
        If IRSession.DepartmentCode.Length > 0 Then
            dgItem.DataSource = IRSDBConnection.SelectFields("select * from tbl_requestpr where invdep='" + IRSession.DepartmentCode + "' and haspr='False'")
        Else
            dgItem.DataSource = IRSDBConnection.SelectFields("select * from tbl_requestpr where invdep=' and haspr='False'")
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        If IRSession.UserType = 2 Then
            btnCreatePR.Enabled = True
        Else
            btnCreatePR.Enabled = False
        End If
        If IRSession.DepartmentCode.Length > 0 Then
            dgItem.DataSource = IRSDBConnection.SelectFields("select * from tbl_requestpr where invdep='" + IRSession.DepartmentCode + "' and haspr='False'")
        Else
            dgItem.DataSource = IRSDBConnection.SelectFields("select * from tbl_requestpr where invdep=' and haspr='False'")
        End If
    End Sub

    Private Sub btnCreatePR_Click(sender As Object, e As EventArgs) Handles btnCreatePR.Click
        If gvItem.RowCount > 0 Then
            Dim SageSession As ACCPAC.Advantage.Session = New ACCPAC.Advantage.Session()
            SageSession.Init("", "CS", "CS0000", Sage300.Version)
            Dim a As String = DecryptText(IRSession.SagePwd)
            SageSession.Open(IRSession.SageLogin, DecryptText(IRSession.SagePwd).ToUpper, Sage300.OrgID, IRSession.SessionDate, 0)
            Dim dBLink As ACCPAC.Advantage.DBLink = SageSession.OpenDBLink(ACCPAC.Advantage.DBLinkType.Company, ACCPAC.Advantage.DBLinkFlags.ReadWrite)

            Dim PORQN1header As ACCPAC.Advantage.View = dBLink.OpenView("PO0760")
            Dim PORQN1detail1 As ACCPAC.Advantage.View = dBLink.OpenView("PO0770")
            Dim PORQN1detail2 As ACCPAC.Advantage.View = dBLink.OpenView("PO0750")
            Dim PORQN1detail3 As ACCPAC.Advantage.View = dBLink.OpenView("PO0759")
            Dim PORQN1detail4 As ACCPAC.Advantage.View = dBLink.OpenView("PO0763")
            Dim PORQN1detail5 As ACCPAC.Advantage.View = dBLink.OpenView("PO0773")
            Dim PORQN1detail6 As ACCPAC.Advantage.View = dBLink.OpenView("PO0777")

            PORQN1header.Compose(New ACCPAC.Advantage.View() {PORQN1detail2, PORQN1detail1, PORQN1detail3, PORQN1detail4, PORQN1detail6})
            PORQN1detail1.Compose(New ACCPAC.Advantage.View() {PORQN1header, PORQN1detail2, PORQN1detail3, PORQN1detail5, PORQN1detail6})
            PORQN1detail2.Compose(New ACCPAC.Advantage.View() {PORQN1header, PORQN1detail1})
            PORQN1detail3.Compose(New ACCPAC.Advantage.View() {PORQN1header, PORQN1detail2, PORQN1detail1, PORQN1detail6})
            PORQN1detail4.Compose(New ACCPAC.Advantage.View() {PORQN1header})
            PORQN1detail5.Compose(New ACCPAC.Advantage.View() {PORQN1detail1})
            PORQN1detail6.Compose(New ACCPAC.Advantage.View() {PORQN1header, PORQN1detail3, PORQN1detail1})

            PORQN1header.Init()
            PORQN1header.Fields.FieldByName("DATE").SetValue(IRSession.SessionDate, True)
            PORQN1header.Fields.FieldByName("PROCESSCMD").SetValue(1, False)
            PORQN1header.Process()
            PORQN1header.Fields.FieldByName("REQUESTBY").SetValue(IRSession.UserID + " : " + IRSession.LoginName, True)
            PORQN1header.Fields.FieldByName("DESCRIPTIO").SetValue("Autogenereated Request from IRS", True)
            PORQN1header.Fields.FieldByName("REFERENCE").SetValue("Autogenereated Request from IRS", True)

            Dim cnt As Integer = 0

            For i As Integer = 0 To gvItem.RowCount - 1
                Dim reqno As String = gvItem.GetRowCellValue(i, colReqNo)
                Dim tick As Boolean = gvItem.GetRowCellValue(i, colPR)
                Dim lineno As Integer = CInt(gvItem.GetRowCellValue(i, colLineNo))
                Dim itemno As String = gvItem.GetRowCellValue(i, colItemNo).ToString.Trim
                Dim toloc As String = gvItem.GetRowCellValue(i, colLocation).ToString.Trim
                Dim qty As Double = Val(gvItem.GetRowCellValue(i, colQty))
                If tick = True Then
                    PORQN1detail1.RecordClear()
                    PORQN1detail1.RecordCreate(ACCPAC.Advantage.ViewRecordCreate.NoInsert)
                    PORQN1detail1.Fields.FieldByName("ITEMNO").SetValue(itemno, True)
                    PORQN1detail1.Fields.FieldByName("PROCESSCMD").SetValue(1, False)
                    PORQN1detail1.Process()
                    PORQN1detail1.Fields.FieldByName("LOCATION").SetValue(toloc, True)
                    PORQN1detail1.Fields.FieldByName("OQORDERED").SetValue(qty, True)


                    Try
                        PORQN1detail1.Insert()
                        IRSDBConnection.StartUpdateCommand("tbl_requestpr")
                        IRSDBConnection.SetWhereField("reqno", reqno)
                        IRSDBConnection.SetWhereField("linenum", lineno)
                        IRSDBConnection.SetUpdateField("haspr", True)
                        IRSDBConnection.ExecuteUpdateCommand()
                        cnt = cnt + 1
                    Catch ex As Exception

                    End Try

                End If
            Next

            If cnt > 0 Then
                PORQN1header.Insert()
            End If

            SageSession = Nothing
            dBLink = Nothing
            PORQN1header = Nothing
            PORQN1detail1 = Nothing
            PORQN1detail2 = Nothing
            PORQN1detail3 = Nothing
            PORQN1detail4 = Nothing
            PORQN1detail5 = Nothing
            PORQN1detail6 = Nothing

            Call btnRefresh_Click(Nothing, Nothing)

        End If
    End Sub
End Class