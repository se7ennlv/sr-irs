Imports System.Net.Mail

Public Class DBMailService

    Private _smtpserver As String
    Private _smtpport As Integer
    Private _smtpssl As Boolean
    Private _smtpuser As String
    Private _smtppwd As String

    Dim mailclient As SmtpClient
    Dim email As MailMessage
    Sub New()


        _smtpserver = IRSDBConnection.SelectField("select smtpsvr from sys_config").ToString.Trim
        _smtpport = CInt(IRSDBConnection.SelectField("select smtpport from sys_config").ToString.Trim)
        _smtpuser = IRSDBConnection.SelectField("select smtpusr from sys_config").ToString.Trim
        _smtppwd = DecryptText(IRSDBConnection.SelectField("select smtppwd from sys_config").ToString.Trim)
        _smtpssl = CBool(IRSDBConnection.SelectField("select smtpssl from sys_config"))

        mailclient = New SmtpClient
        mailclient.UseDefaultCredentials = False
        mailclient.Credentials = New Net.NetworkCredential(_smtpuser, _smtppwd)
        mailclient.Port = _smtpport
        mailclient.EnableSsl = _smtpssl
        mailclient.Host = _smtpserver



    End Sub

    Sub SendMail(ByVal Subject As String, ByVal ToEmail As String, ByVal EmailBody As String)
        email = New MailMessage
        email.From = New MailAddress(_smtpuser, "Sage Administrator")
        email.To.Add(ToEmail)
        email.Subject = Subject
        email.IsBodyHtml = True
        email.Body = EmailBody
        mailclient.Send(email)
    End Sub
    Sub SendTest(ByVal ToEmail As String)
        Try
            email = New MailMessage
            email.From = New MailAddress(_smtpuser)
            email.To.Add(ToEmail)
            email.Subject = "Testing Mail From Inventory Request System"
            email.IsBodyHtml = True
            email.Body = "You have received a test mail sending and it is safe.<br><br><br>"
            mailclient.Send(email)
            MsgBox("Mail sending is success.", MsgBoxStyle.OkOnly, ProgName)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, ProgName)
        End Try


    End Sub


    Sub SendSubmitNotify(ByVal RequestNo As String)

        Try
            email = New MailMessage
            email.From = New MailAddress(_smtpuser, "Sage Administrator")
            email.IsBodyHtml = True
            Dim tbreq As DataTable = IRSDBConnection.SelectFields("select * from tbl_request where reqno='" + RequestNo + "'")
            Dim reqdepcode As String = tbreq.Rows(0)("reqdep").ToString.Trim
            Dim invdepcode As String = tbreq.Rows(0)("invdep").ToString.Trim()
            Dim reqpersonid As String = tbreq.Rows(0)("reqperson").ToString.Trim()
            Dim reqdate As Date = tbreq.Rows(0)("reqdate")
            Dim reason As String = tbreq.Rows(0)("reason").ToString.Trim
            Dim reference As String = tbreq.Rows(0)("reference").ToString.Trim

            Dim reqdep As New DBDepartment(reqdepcode)
            Dim invdep As New DBDepartment(invdepcode)
            Dim reqperson As New DBUser(reqpersonid)

            For i As Integer = 0 To reqdep.RequestApprovers.Count - 1
                Dim ea As New MailAddress(reqdep.RequestApprovers(i).Email, reqdep.RequestApprovers(i).FirstName + " " + reqdep.RequestApprovers(i).LastName)
                email.To.Add(ea)
            Next

            email.CC.Add(New MailAddress(reqperson.Email, reqperson.FirstName + " " + reqperson.LastName))

            Dim body As String = "Dear Approvers!<br><br>The request with the following information need your approval.<br>"
            body += "  - Request No: " + RequestNo + "<br>"
            body += "  - Requestor : " + reqperson.FirstName + " " + reqperson.LastName + " (" + reqpersonid + ")<br>"
            body += "  - Department: " + reqdep.Name + "<br>"
            body += "  - Reason    : " + reason + "<br>"
            body += "  - Reference : " + reference + "<br>"

            body += "Please login to IRS for checking and approve accordingly.<br><br>"

            Dim cnt As Integer = CInt(IRSDBConnection.SelectField("select count(*) from tbl_requestitem where reqno='" + RequestNo + "'"))
            If cnt = 0 Then
                body += "Dear "
                For i As Integer = 0 To invdep.InventoryControllers.Count - 1
                    Dim ea As New MailAddress(invdep.InventoryControllers(i).Email, invdep.InventoryControllers(i).FirstName + " " + invdep.InventoryControllers(i).LastName)
                    email.CC.Add(ea)
                    body += invdep.InventoryControllers(i).LastName + "/"
                Next
                body = body.Substring(0, body.Length - 1) + ",<br>"

                body += "This request doesn't have item yet, Please check and add items accordingly.<br><br>"

            End If

            body += "Best Reguards,<br>Sage Admin"

            email.Subject = "SUBMITTED Request #:" + RequestNo
            email.Body = body
            mailclient.Send(email)
        Catch ex As Exception

        End Try

    End Sub

    Sub SendBackNotify(ByVal RequestNo As String)
        email = New MailMessage
        email.From = New MailAddress(_smtpuser, "Sage Administrator")
        email.IsBodyHtml = True
        Dim tbreq As DataTable = IRSDBConnection.SelectFields("select * from tbl_request where reqno='" + RequestNo + "'")
        Dim reqdepcode As String = tbreq.Rows(0)("reqdep").ToString.Trim
        Dim invdepcode As String = tbreq.Rows(0)("invdep").ToString.Trim()
        Dim reqpersonid As String = tbreq.Rows(0)("reqperson").ToString.Trim()
        Dim reqdate As Date = tbreq.Rows(0)("reqdate")
        Dim reason As String = tbreq.Rows(0)("reason").ToString.Trim
        Dim reference As String = tbreq.Rows(0)("reference").ToString.Trim

        Dim reqdep As New DBDepartment(reqdepcode)
        Dim invdep As New DBDepartment(invdepcode)
        Dim reqperson As New DBUser(reqpersonid)


        email.To.Add(New MailAddress(reqperson.Email, reqperson.FirstName + " " + reqperson.LastName))
        Dim body As String = "Dear " + reqperson.FirstName + " " + reqperson.LastName + "<br><br>"
        body += "You request number " + RequestNo + " is requsted to review again by " + IRSession.UserID + "(" + IRSession.LoginName + "). <br><br>"
        body += "Best Reguards,<br>Sage Admin"
        email.Subject = "SENDBACK Request #:" + RequestNo
        email.Body = body
        mailclient.Send(email)

    End Sub

    Sub FirstApproveNotify(ByVal RequestNo As String)
        email = New MailMessage
        email.From = New MailAddress(_smtpuser, "Sage Administrator")
        email.IsBodyHtml = True
        Dim tbreq As DataTable = IRSDBConnection.SelectFields("select * from tbl_request where reqno='" + RequestNo + "'")
        Dim reqdepcode As String = tbreq.Rows(0)("reqdep").ToString.Trim
        Dim invdepcode As String = tbreq.Rows(0)("invdep").ToString.Trim()
        Dim reqpersonid As String = tbreq.Rows(0)("reqperson").ToString.Trim()
        Dim reqdate As Date = tbreq.Rows(0)("reqdate")
        Dim reason As String = tbreq.Rows(0)("reason").ToString.Trim
        Dim reference As String = tbreq.Rows(0)("reference").ToString.Trim

        Dim reqdep As New DBDepartment(reqdepcode)
        Dim invdep As New DBDepartment(invdepcode)
        Dim reqperson As New DBUser(reqpersonid)

        For i As Integer = 0 To invdep.InventoryApprovers.Count - 1
            Dim ea As New MailAddress(invdep.InventoryApprovers(i).Email, invdep.InventoryApprovers(i).FirstName + " " + invdep.InventoryApprovers(i).LastName)
            email.To.Add(ea)
        Next


        Dim body As String = "Dear Approvers!<br><br>The request with the following information need your approval.<br>"
        body += "  - Request No: " + RequestNo + "<br>"
        body += "  - Requestor : " + reqperson.FirstName + " " + reqperson.LastName + " (" + reqpersonid + ")<br>"
        body += "  - Department: " + reqdep.Name + "<br>"
        body += "  - Reason    : " + reason + "<br>"
        body += "  - Reference : " + reference + "<br>"
        body += "Please login to IRS for checking and approve accordingly.<br><br>"
        body += "Best Reguards,<br>Sage Admin"
        email.Subject = "SUBMITTED Request #:" + RequestNo
        email.Body = body
        mailclient.Send(email)

        email = New MailMessage
        email.From = New MailAddress(_smtpuser, "Sage Administrator")
        email.To.Add(New MailAddress(reqperson.Email, reqperson.FirstName + " " + reqperson.LastName))
        email.Subject = "APPROVED Request #:" + RequestNo
        email.Body = "Dear " + reqperson.FirstName + "<br>Your Request is partially approved and waiting for the final approval<br><br>Best Regards,<br>Sage Admin<br>"
        mailclient.Send(email)

    End Sub

    Sub FinalApproveNotify(ByVal RequestNo As String)
        email = New MailMessage
        email.From = New MailAddress(_smtpuser, "Sage Administrator")
        email.IsBodyHtml = True
        Dim tbreq As DataTable = IRSDBConnection.SelectFields("select * from tbl_request where reqno='" + RequestNo + "'")
        Dim reqdepcode As String = tbreq.Rows(0)("reqdep").ToString.Trim
        Dim invdepcode As String = tbreq.Rows(0)("invdep").ToString.Trim()
        Dim reqpersonid As String = tbreq.Rows(0)("reqperson").ToString.Trim()
        Dim reqdate As Date = tbreq.Rows(0)("reqdate")
        Dim reason As String = tbreq.Rows(0)("reason").ToString.Trim
        Dim reference As String = tbreq.Rows(0)("reference").ToString.Trim

        Dim reqdep As New DBDepartment(reqdepcode)
        Dim invdep As New DBDepartment(invdepcode)
        Dim reqperson As New DBUser(reqpersonid)

        For i As Integer = 0 To invdep.InventoryControllers.Count - 1
            Dim ea As New MailAddress(invdep.InventoryControllers(i).Email, invdep.InventoryControllers(i).FirstName + " " + invdep.InventoryControllers(i).LastName)
            email.To.Add(ea)
        Next

        Dim body As String = "Dear Inventory Controllers!<br><br>The request with the following information need your attentions.<br>"
        body += "  - Request No: " + RequestNo + "<br>"
        body += "  - Requestor : " + reqperson.FirstName + " " + reqperson.LastName + " (" + reqpersonid + ")<br>"
        body += "  - Department: " + reqdep.Name + "<br>"
        body += "  - Reason    : " + reason + "<br>"
        body += "  - Reference : " + reference + "<br>"
        body += "Please login to IRS for checking and processing accordingly.<br><br>"
        body += "Best Reguards,<br>Sage Admin"
        email.Subject = "SUBMITTED Request #:" + RequestNo
        email.Body = body
        mailclient.Send(email)

        email = New MailMessage
        email.From = New MailAddress(_smtpuser, "Sage Administrator")
        email.To.Add(New MailAddress(reqperson.Email, reqperson.FirstName + " " + reqperson.LastName))
        email.Subject = "APPROVED Request #:" + RequestNo
        email.Body = "Dear " + reqperson.FirstName + "<br>Your Request is finally approved and waiting for the final approval<br><br>Best Regards,<br>Sage Admin<br>"
        mailclient.Send(email)

    End Sub




End Class
