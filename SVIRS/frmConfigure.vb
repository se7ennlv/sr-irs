Public Class frmConfigure 

    Private Sub btnSmtpSend_Click(sender As Object, e As EventArgs) Handles btnSmtpSend.Click
        IRMail = New DBMailService
        IRMail.SendTest(txtSendTo.EditValue.ToString.Trim)
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Dim svr As String = txtSageSvr.EditValue.ToString.Trim
        Dim uid As String = txtSageUsr.EditValue.ToString.Trim
        Dim pwd As String = txtSagePwd.EditValue.ToString.Trim
        Dim dbn As String = txtSageDb.EditValue.ToString.Trim

        Dim con As New OleDb.OleDbConnection("Provider=SQLOledb.1; Data Source=" + svr + "; User ID=" + uid + "; Password=" + pwd + "; Initial Catalog=" + dbn)
        Try
            con.Open()
            con.Close()
            MsgBox("Connection Success!", MsgBoxStyle.OkOnly, ProgName)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, ProgName)
        End Try


    End Sub

    Private Sub btnSageSave_Click(sender As Object, e As EventArgs) Handles btnSageSave.Click
        IRSDBConnection.StartUpdateCommand("sys_config")
        IRSDBConnection.SetWhereField("checksum", "A")
        IRSDBConnection.SetUpdateField("sagesvr", txtSageSvr.EditValue.ToString.Trim)
        IRSDBConnection.SetUpdateField("sagelogin", txtSageUsr.EditValue.ToString.Trim)
        IRSDBConnection.SetUpdateField("sagepwd", EncryptText(txtSagePwd.EditValue.ToString.Trim))
        IRSDBConnection.SetUpdateField("sagedb", txtSageDb.EditValue.ToString.Trim)
        IRSDBConnection.ExecuteUpdateCommand()

        MsgBox("Sage Connection is updated.", MsgBoxStyle.OkOnly, ProgName)

    End Sub

    Private Sub btnSmtpSave_Click(sender As Object, e As EventArgs) Handles btnSmtpSave.Click
        IRSDBConnection.StartUpdateCommand("sys_config")
        IRSDBConnection.SetWhereField("checksum", "A")
        IRSDBConnection.SetUpdateField("smtpsvr", txtSmtpSvr.EditValue.ToString.Trim)
        IRSDBConnection.SetUpdateField("smtpport", txtSmtpPort.EditValue)
        IRSDBConnection.SetUpdateField("smtpusr", txtSmtpUsr.EditValue.ToString.Trim.Trim)
        IRSDBConnection.SetUpdateField("smtppwd", EncryptText(txtSmtpPwd.EditValue.ToString.Trim))
        IRSDBConnection.SetUpdateField("smtpssl", swSSL.EditValue)

        IRSDBConnection.ExecuteUpdateCommand()

        MsgBox("Email setup is updated.", MsgBoxStyle.OkOnly, ProgName)
    End Sub

    Private Sub frmConfigure_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim tb As DataTable = IRSDBConnection.SelectFields("select * from sys_config where checksum='A'")
            txtSageSvr.EditValue = tb.Rows(0)("sagesvr").ToString.Trim
            txtSageUsr.EditValue = tb.Rows(0)("sagelogin").ToString.Trim
            txtSagePwd.EditValue = DecryptText(tb.Rows(0)("sagepwd").ToString.Trim)
            txtSageDb.EditValue = tb.Rows(0)("sagedb").ToString.Trim

            txtSmtpSvr.EditValue = tb.Rows(0)("smtpsvr").ToString.Trim
            txtSmtpPort.EditValue = tb.Rows(0)("smtpport")
            txtSmtpUsr.EditValue = tb.Rows(0)("smtpusr").ToString.Trim
            txtSmtpPwd.EditValue = DecryptText(tb.Rows(0)("smtppwd").ToString.Trim)
            swSSL.EditValue = tb.Rows(0)("smtpssl")

            txtPref.EditValue = tb.Rows(0)("docprefix").ToString.Trim
            swDate.EditValue = tb.Rows(0)("usedateprefix")
            If swDate.EditValue = True Then
                dtPref.ReadOnly = False
            Else
                dtPref.ReadOnly = True
            End If

            dtPref.Text = tb.Rows(0)("dateprefix").ToString.Trim
            txtMaxLen.EditValue = tb.Rows(0)("maxlength")
            txtNxtNum.EditValue = tb.Rows(0)("nextnum")

            txtSample.EditValue = NewRequestNumber(False)

        Catch ex As Exception

        End Try
        

    End Sub

    Private Sub txtPref_EditValueChanged(sender As Object, e As EventArgs) Handles txtPref.EditValueChanged
        Try
            Dim docpref As String = txtPref.EditValue.ToString
            Dim usedate As Boolean = CBool(swDate.EditValue)
            Dim datpref As String = dtPref.Text.Trim
            Dim maxlen As Integer = CInt(txtMaxLen.EditValue)
            Dim nextnum As Integer = CInt(txtNxtNum.EditValue)

            Dim curlen As Integer = docpref.Length + If(usedate = True, datpref.Length, 0) + nextnum.ToString.Length
            Dim zerolen As Integer = maxlen - curlen

            Dim zerostr As String = ""
            For i As Integer = 0 To zerolen - 1
                zerostr = zerostr + "0"
            Next

            txtSample.EditValue = docpref + If(usedate = True, Format(Now.Date, datpref.ToLower), "") + zerostr + nextnum.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtPref_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dtPref.SelectedIndexChanged
        Try
            Dim docpref As String = txtPref.EditValue.ToString
            Dim usedate As Boolean = CBool(swDate.EditValue)
            Dim datpref As String = dtPref.Text.Trim
            Dim maxlen As Integer = CInt(txtMaxLen.EditValue)
            Dim nextnum As Integer = CInt(txtNxtNum.EditValue)

            Dim curlen As Integer = docpref.Length + If(usedate = True, datpref.Length, 0) + nextnum.ToString.Length
            Dim zerolen As Integer = maxlen - curlen

            Dim zerostr As String = ""
            For i As Integer = 0 To zerolen - 1
                zerostr = zerostr + "0"
            Next

            txtSample.EditValue = docpref + If(usedate = True, Format(Now.Date, datpref), "") + zerostr + nextnum.ToString
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub dtPref_TextChanged(sender As Object, e As EventArgs) Handles dtPref.TextChanged
        Try
            Dim docpref As String = txtPref.EditValue.ToString
            Dim usedate As Boolean = CBool(swDate.EditValue)
            Dim datpref As String = dtPref.Text.Trim
            Dim maxlen As Integer = CInt(txtMaxLen.EditValue)
            Dim nextnum As Integer = CInt(txtNxtNum.EditValue)

            Dim curlen As Integer = docpref.Length + If(usedate = True, datpref.Length, 0) + nextnum.ToString.Length
            Dim zerolen As Integer = maxlen - curlen

            Dim zerostr As String = ""
            For i As Integer = 0 To zerolen - 1
                zerostr = zerostr + "0"
            Next

            txtSample.EditValue = docpref + If(usedate = True, Format(Now.Date, datpref), "") + zerostr + nextnum.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtMaxLen_EditValueChanged(sender As Object, e As EventArgs) Handles txtMaxLen.EditValueChanged
        Try
            Dim docpref As String = txtPref.EditValue.ToString
            Dim usedate As Boolean = CBool(swDate.EditValue)
            Dim datpref As String = dtPref.Text.Trim
            Dim maxlen As Integer = CInt(txtMaxLen.EditValue)
            Dim nextnum As Integer = CInt(txtNxtNum.EditValue)

            Dim curlen As Integer = docpref.Length + If(usedate = True, datpref.Length, 0) + nextnum.ToString.Length
            Dim zerolen As Integer = maxlen - curlen

            Dim zerostr As String = ""
            For i As Integer = 0 To zerolen - 1
                zerostr = zerostr + "0"
            Next

            txtSample.EditValue = docpref + If(usedate = True, Format(Now.Date, datpref), "") + zerostr + nextnum.ToString
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub btnNumSave_Click(sender As Object, e As EventArgs) Handles btnNumSave.Click
        IRSDBConnection.StartUpdateCommand("sys_config")
        IRSDBConnection.SetWhereField("checksum", "A")
        IRSDBConnection.SetUpdateField("docprefix", txtPref.EditValue.ToString.Trim)
        IRSDBConnection.SetUpdateField("usedateprefix", swDate.EditValue)
        IRSDBConnection.SetUpdateField("dateprefix", dtPref.Text.Trim)
        IRSDBConnection.SetUpdateField("maxlength", txtMaxLen.EditValue)
        IRSDBConnection.SetUpdateField("nextnum", txtNxtNum.EditValue)

        IRSDBConnection.ExecuteUpdateCommand()

        MsgBox("Numbering setup is updated.", MsgBoxStyle.OkOnly, ProgName)
    End Sub

    
End Class