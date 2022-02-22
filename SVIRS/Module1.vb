Imports System
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting
'Imports ACCPAC.Advantage
Module Module1
    Public ProgName As String = "Savan Legend Resorts - Inventory Request System"
    Dim fsInput As System.IO.FileStream
    Dim fsOutput As System.IO.FileStream
    Dim syspwd As String = "s0ph3@k@pr0n0mt3ch"
    Dim syskey As String = "sc0tt@s@vanl3g3nd"
    Public SageDBConnection As New DBConnect
    Public IRSDBConnection As New DBConnect
    Public IRSession As New DBSession
    Public IRMail As DBMailService
    Public Sage300 As SageInfo
    Sub UpdateActivityLog(ByVal RequestNo As String, ByVal LogType As String, ByVal LogDetail As String)
        Dim i As Integer = IRSDBConnection.SelectField("select count(*) from tbl_request where reqno='" + RequestNo + "'")
        If i = 1 Then
            IRSDBConnection.StartInsertCommand("tbl_requestlog")
            IRSDBConnection.InsertField("reqno", RequestNo)
            IRSDBConnection.InsertField("logtype", LogType)
            IRSDBConnection.InsertField("logdate", Now())
            IRSDBConnection.InsertField("loguserid", IRSession.UserID)
            IRSDBConnection.InsertField("logusername", IRSession.LoginName)
            IRSDBConnection.InsertField("logdetail", LogDetail)
            IRSDBConnection.ExecuteInsertCommand()
        End If
    End Sub

    Sub AddComment(ByVal RequestNo As String, ByVal Comment As String)
        Dim i As Integer = IRSDBConnection.SelectField("select count(*) from tbl_request where reqno='" + RequestNo + "'")
        If i = 1 Then
            IRSDBConnection.StartInsertCommand("tbl_requestcomment")
            IRSDBConnection.InsertField("reqno", RequestNo)
            IRSDBConnection.InsertField("cmtdate", Now())
            IRSDBConnection.InsertField("cmtuserid", IRSession.UserID)
            IRSDBConnection.InsertField("cmtusername", IRSession.LoginName)
            IRSDBConnection.InsertField("cmtdetail", Comment)
            IRSDBConnection.ExecuteInsertCommand()
        End If
    End Sub
    Function NewRequestNumber(ByVal UpdateNextNumber As Boolean) As String

        Dim tb As DataTable = IRSDBConnection.SelectFields("select * from sys_config where checksum='A'")
        Dim docpref As String = tb.Rows(0)("docprefix").ToString.Trim
        Dim usedate As Boolean = tb.Rows(0)("usedateprefix")
        Dim datpref As String = tb.Rows(0)("dateprefix").ToString.Trim
        Dim maxlen As Integer = tb.Rows(0)("maxlength")
        Dim nextnum As Integer = tb.Rows(0)("nextnum")

        Dim curlen As Integer = docpref.Length + If(usedate = True, datpref.Length, 0) + nextnum.ToString.Length
        Dim zerolen As Integer = maxlen - curlen

        Dim zerostr As String = ""
        For i As Integer = 0 To zerolen - 1
            zerostr = zerostr + "0"
        Next

        Dim reqnum As String = docpref + If(usedate = True, Format(Now.Date, datpref), "") + zerostr + nextnum.ToString


        If UpdateNextNumber = True Then
            IRSDBConnection.StartUpdateCommand("sys_config")
            IRSDBConnection.SetWhereField("checksum", "A")
            IRSDBConnection.SetUpdateField("nextnum", nextnum + 1)
            IRSDBConnection.ExecuteUpdateCommand()
        End If

        Return reqnum

    End Function

    Function SendToPurchase(ByVal RequestNumber As String) As Boolean

        Dim chk As Boolean = False

        Dim tbreq As DataTable = IRSDBConnection.SelectFields("select * from tbl_request where reqno='" + RequestNumber + "'")
        Dim reqdate As Date = tbreq.Rows(0)("reqdate")
        Dim reqdep As String = tbreq.Rows(0)("reqdep").ToString.Trim
        Dim invdep As String = tbreq.Rows(0)("invdep").ToString.Trim

        Dim tbitem As DataTable = IRSDBConnection.SelectFields("select * from tbl_requestitem where reqno='" + RequestNumber + "'")
        Dim cnt As Integer = 0
        For i As Integer = 0 To tbitem.Rows.Count - 1
            Dim linenum As Integer = CInt(tbitem.Rows(i)("linenum"))
            Dim itemno As String = tbitem.Rows(i)("itemno").ToString.Trim
            Dim itemdesc As String = tbitem.Rows(i)("itemdesc").ToString.Trim
            Dim reqqty As Double = tbitem.Rows(i)("reqqty")
            Dim requom As String = tbitem.Rows(i)("requom").ToString.Trim
            Dim fromloc As String = tbitem.Rows(i)("fromloc").ToString.Trim
            Dim conversion As Double = Val(SageDBConnection.SelectField("select CONVERSION from ICUNIT where ITEMNO='" + itemno + "' and UNIT='" + requom + "'"))
            Dim qoh As Double = 0
            Try
                qoh = Val(SageDBConnection.SelectField("select sum(QTYONHAND) as 'QTY' from ICILOC where ITEMNO='" + itemno + "' and LOCATION='" + fromloc + "'"))
            Catch ex As Exception

            End Try


            'Dim qtyneed As Double = reqqty - If(qoh > 0, qoh / conversion, 0)
            'If qtyneed > 0 Then
            Try
                IRSDBConnection.StartInsertCommand("tbl_requestpr")
                IRSDBConnection.InsertField("reqno", RequestNumber)
                IRSDBConnection.InsertField("linenum", linenum)
                IRSDBConnection.InsertField("itemno", itemno)
                IRSDBConnection.InsertField("itemdesc", itemdesc)
                IRSDBConnection.InsertField("reqqty", reqqty)
                IRSDBConnection.InsertField("requom", requom)
                IRSDBConnection.InsertField("reqdate", reqdate)
                IRSDBConnection.InsertField("location", fromloc)
                IRSDBConnection.InsertField("reqdep", reqdep)
                IRSDBConnection.InsertField("invdep", invdep)
                IRSDBConnection.InsertField("haspr", False)
                IRSDBConnection.InsertField("prnum", "")
                IRSDBConnection.ExecuteInsertCommand()
                cnt = cnt + 1
            Catch ex As Exception

            End Try

            'End If


        Next
        If cnt > 0 Then
            chk = True
        End If


        Return chk

    End Function

    Function FormatItemNo(ByVal ItemNo As String) As String
        Dim str As String = ""
        Try
            str = SageDBConnection.SelectField("select FMTITEMNO from ICITEM where ITEMNO='" + ItemNo + "'").ToString.Trim
        Catch ex As Exception

        End Try

        Return str
    End Function

    Function ConvertReqQty(ByVal ItemNo As String, ByVal Qty As Double, ByVal UoM As String) As Double
        Dim conv As Double = SageDBConnection.SelectField("select CONVERSION from ICUNIT where ITEMNO='" + ItemNo + "' and UNIT='" + UoM + "'")
        Return Qty * conv
    End Function
    Function UsageRequest(ByVal RequestNumber As String) As Boolean
        Dim chk As Boolean = False
        Dim trncnt As Integer = SageDBConnection.SelectField("select count(*) from ICICEH where REFERENCE='" + RequestNumber + "'")


        If trncnt = 0 Then
            Dim SageSession As ACCPAC.Advantage.Session = New ACCPAC.Advantage.Session()
            SageSession.Init("", "CS", "CS0000", Sage300.Version)
            SageSession.Open(IRSession.SageLogin, DecryptText(IRSession.SagePwd).ToUpper, Sage300.OrgID, IRSession.SessionDate, 0)

            Dim dBLink As ACCPAC.Advantage.DBLink = SageSession.OpenDBLink(ACCPAC.Advantage.DBLinkType.Company, ACCPAC.Advantage.DBLinkFlags.ReadWrite)

            Dim ICICE1header As ACCPAC.Advantage.View = dBLink.OpenView("IC0288")
            Dim ICICE1detail1 As ACCPAC.Advantage.View = dBLink.OpenView("IC0286")
            Dim ICICE1detail2 As ACCPAC.Advantage.View = dBLink.OpenView("IC0289")
            Dim ICICE1detail3 As ACCPAC.Advantage.View = dBLink.OpenView("IC0287")
            Dim ICICE1detail4 As ACCPAC.Advantage.View = dBLink.OpenView("IC0282")
            Dim ICICE1detail5 As ACCPAC.Advantage.View = dBLink.OpenView("IC0284")

            ICICE1header.Compose(New ACCPAC.Advantage.View() {ICICE1detail1, ICICE1detail2})
            ICICE1detail1.Compose(New ACCPAC.Advantage.View() {ICICE1header, ICICE1detail3, ICICE1detail5, Nothing, Nothing, Nothing, Nothing, Nothing, ICICE1detail4})
            ICICE1detail2.Compose(New ACCPAC.Advantage.View() {ICICE1header})
            ICICE1detail3.Compose(New ACCPAC.Advantage.View() {ICICE1detail1})
            ICICE1detail4.Compose(New ACCPAC.Advantage.View() {ICICE1detail1})
            ICICE1detail5.Compose(New ACCPAC.Advantage.View() {ICICE1detail1})

            Dim tbreq As DataTable = IRSDBConnection.SelectFields("select * from tbl_request where reqno='" + RequestNumber + "'")
            Dim tbitm As DataTable = IRSDBConnection.SelectFields("select * from tbl_requestitem where reqno='" + RequestNumber + "'")



            ICICE1header.Init()
            ICICE1header.Fields.FieldByName("TRANSDATE").SetValue(IRSession.SessionDate, True)
            ICICE1header.Fields.FieldByName("PROCESSCMD").SetValue(1, False)
            ICICE1header.Process()
            ICICE1header.Fields.FieldByName("HDRDESC").SetValue(tbreq.Rows(0)("reason").ToString.Trim, False)
            ICICE1header.Fields.FieldByName("REFERENCE").SetValue(RequestNumber, False)
            ICICE1header.Fields.FieldByName("EMPLOYEENO").SetValue(tbreq.Rows(0)("reqdep").ToString.Trim, False)

            Dim cnt As Integer = 0
            Dim itemadded As Integer = 0

            For i As Integer = 0 To tbitm.Rows.Count - 1
                Dim itemno As String = tbitm.Rows(i)("itemno").ToString.Trim()
                Dim toloc As String = tbitm.Rows(i)("toloc").ToString.Trim()
                Dim uom As String = tbitm.Rows(i)("isuuom").ToString.Trim()
                Dim isuqty As Double = tbitm.Rows(i)("isuqty")
                If isuqty > 0 Then
                    Try
                        ICICE1detail1.Init()
                        ICICE1detail1.RecordClear()
                        ICICE1detail1.RecordCreate(ACCPAC.Advantage.ViewRecordCreate.NoInsert)
                        ICICE1detail1.Fields.FieldByName("ITEMNO").SetValue(itemno, True)
                        ICICE1detail1.Fields.FieldByName("PROCESSCMD").SetValue(1, False)
                        ICICE1detail1.Process()
                        ICICE1detail1.Fields.FieldByName("LOCATION").SetValue(toloc, True)
                        ICICE1detail1.Fields.FieldByName("QUANTITY").SetValue(isuqty, True)
                        ICICE1detail1.Fields.FieldByName("UNIT").SetValue(uom, True)
                        ICICE1detail1.Fields.FieldByName("FUNCTION").SetValue(100, True)
                        ICICE1detail1.Process()
                        ICICE1detail1.Insert()
                        itemadded = itemadded + 1
                    Catch ex As Exception
                        '--MsgBox(ex.Message)
                    End Try
                End If
                
            Next
            ICICE1header.Fields.FieldByName("STATUS").SetValue(2, True)
            If itemadded = tbitm.Rows.Count Then
                Try
                    ICICE1header.Insert()
                    chk = True
                Catch ex As Exception
                    chk = False
                End Try
            Else
                chk = False
            End If
            


            SageSession = Nothing
            dBLink = Nothing
            ICICE1header = Nothing
            ICICE1detail1 = Nothing
            ICICE1detail2 = Nothing
            ICICE1detail3 = Nothing
            ICICE1detail4 = Nothing
            ICICE1detail5 = Nothing
        Else 'if the request is exist in Internal Usage

            Dim totalqty As Double = SageDBConnection.SelectField("select sum(QUANTITY) from ICICED where SEQUENCENO in (select SEQUENCENO from ICICEH where REFERENCE='" + RequestNumber + "')")
            If totalqty = 0 Then 'detect posted internal usage with zero qty
                Dim SageSession As ACCPAC.Advantage.Session = New ACCPAC.Advantage.Session()
                SageSession.Init("", "CS", "CS0000", Sage300.Version)
                SageSession.Open(IRSession.SageLogin, DecryptText(IRSession.SagePwd).ToUpper, Sage300.OrgID, IRSession.SessionDate, 0)

                Dim dBLink As ACCPAC.Advantage.DBLink = SageSession.OpenDBLink(ACCPAC.Advantage.DBLinkType.Company, ACCPAC.Advantage.DBLinkFlags.ReadWrite)

                Dim ICICE1header As ACCPAC.Advantage.View = dBLink.OpenView("IC0288")
                Dim ICICE1detail1 As ACCPAC.Advantage.View = dBLink.OpenView("IC0286")
                Dim ICICE1detail2 As ACCPAC.Advantage.View = dBLink.OpenView("IC0289")
                Dim ICICE1detail3 As ACCPAC.Advantage.View = dBLink.OpenView("IC0287")
                Dim ICICE1detail4 As ACCPAC.Advantage.View = dBLink.OpenView("IC0282")
                Dim ICICE1detail5 As ACCPAC.Advantage.View = dBLink.OpenView("IC0284")

                ICICE1header.Compose(New ACCPAC.Advantage.View() {ICICE1detail1, ICICE1detail2})
                ICICE1detail1.Compose(New ACCPAC.Advantage.View() {ICICE1header, ICICE1detail3, ICICE1detail5, Nothing, Nothing, Nothing, Nothing, Nothing, ICICE1detail4})
                ICICE1detail2.Compose(New ACCPAC.Advantage.View() {ICICE1header})
                ICICE1detail3.Compose(New ACCPAC.Advantage.View() {ICICE1detail1})
                ICICE1detail4.Compose(New ACCPAC.Advantage.View() {ICICE1detail1})
                ICICE1detail5.Compose(New ACCPAC.Advantage.View() {ICICE1detail1})

                Dim tbreq As DataTable = IRSDBConnection.SelectFields("select * from tbl_request where reqno='" + RequestNumber + "'")
                Dim tbitm As DataTable = IRSDBConnection.SelectFields("select * from tbl_requestitem where reqno='" + RequestNumber + "'")



                ICICE1header.Init()
                ICICE1header.Fields.FieldByName("TRANSDATE").SetValue(IRSession.SessionDate, True)
                ICICE1header.Fields.FieldByName("PROCESSCMD").SetValue(1, False)
                ICICE1header.Process()
                ICICE1header.Fields.FieldByName("HDRDESC").SetValue(tbreq.Rows(0)("reason").ToString.Trim, False)
                ICICE1header.Fields.FieldByName("REFERENCE").SetValue(RequestNumber, False)
                ICICE1header.Fields.FieldByName("EMPLOYEENO").SetValue(tbreq.Rows(0)("reqdep").ToString.Trim, False)

                Dim cnt As Integer = 0
                Dim itemadded As Integer = 0

                For i As Integer = 0 To tbitm.Rows.Count - 1
                    Dim itemno As String = tbitm.Rows(i)("itemno").ToString.Trim()
                    Dim toloc As String = tbitm.Rows(i)("toloc").ToString.Trim()
                    Dim uom As String = tbitm.Rows(i)("isuuom").ToString.Trim()
                    Dim isuqty As Double = tbitm.Rows(i)("isuqty")
                    If isuqty > 0 Then
                        Try
                            ICICE1detail1.Init()
                            ICICE1detail1.RecordClear()
                            ICICE1detail1.RecordCreate(ACCPAC.Advantage.ViewRecordCreate.NoInsert)
                            ICICE1detail1.Fields.FieldByName("ITEMNO").SetValue(itemno, True)
                            ICICE1detail1.Fields.FieldByName("PROCESSCMD").SetValue(1, False)
                            ICICE1detail1.Process()
                            ICICE1detail1.Fields.FieldByName("LOCATION").SetValue(toloc, True)
                            ICICE1detail1.Fields.FieldByName("QUANTITY").SetValue(isuqty, True)
                            ICICE1detail1.Fields.FieldByName("UNIT").SetValue(uom, True)
                            ICICE1detail1.Fields.FieldByName("FUNCTION").SetValue(100, True)
                            ICICE1detail1.Process()
                            ICICE1detail1.Insert()
                            itemadded = itemadded + 1
                        Catch ex As Exception

                        End Try
                    End If

                Next
                ICICE1header.Fields.FieldByName("STATUS").SetValue(2, True)
                If itemadded = tbitm.Rows.Count Then
                    Try
                        ICICE1header.Insert()
                        chk = True
                    Catch ex As Exception
                        chk = False
                    End Try
                Else
                    chk = False
                End If



                SageSession = Nothing
                dBLink = Nothing
                ICICE1header = Nothing
                ICICE1detail1 = Nothing
                ICICE1detail2 = Nothing
                ICICE1detail3 = Nothing
                ICICE1detail4 = Nothing
                ICICE1detail5 = Nothing
            Else
                chk = True

                IRSDBConnection.StartUpdateCommand("tbl_request")
                IRSDBConnection.SetWhereField("reqno", RequestNumber)
                IRSDBConnection.SetUpdateField("reqstat", 10)
                IRSDBConnection.ExecuteUpdateCommand()
                UpdateActivityLog(RequestNumber, "UPDATE", "Set the status of the request to USED")


            End If

        End If
        
        Return chk

    End Function
    Function ReleaseRequest(ByVal RequestNumber As String) As Boolean
        Dim chk As Boolean = False
        Dim trncnt As Integer = SageDBConnection.SelectField("select count(*) from ICTREH where REFERENCE='" + RequestNumber + "'")
        If trncnt = 0 Then
            Dim SageSession As ACCPAC.Advantage.Session = New ACCPAC.Advantage.Session()

            SageSession.Init("", "CS", "CS0000", Sage300.Version)
            SageSession.Open(IRSession.SageLogin, DecryptText(IRSession.SagePwd).ToUpper, Sage300.OrgID, IRSession.SessionDate, 0)
            Dim dBLink As ACCPAC.Advantage.DBLink = SageSession.OpenDBLink(ACCPAC.Advantage.DBLinkType.Company, ACCPAC.Advantage.DBLinkFlags.ReadWrite)

            Dim ICTRE1header As ACCPAC.Advantage.View = dBLink.OpenView("IC0740") ' dBLink.OpenIView("IC0740")
            Dim ICTRE1detail1 As ACCPAC.Advantage.View = dBLink.OpenView("IC0730") ' dBLink.OpenIView("IC0730")
            Dim ICTRE1detail2 As ACCPAC.Advantage.View = dBLink.OpenView("IC0741") ' dBLink.OpenIView("IC0741")
            Dim ICTRE1detail3 As ACCPAC.Advantage.View = dBLink.OpenView("IC0735") ' dBLink.OpenIView("IC0735")
            Dim ICTRE1detail4 As ACCPAC.Advantage.View = dBLink.OpenView("IC0733") ' dBLink.OpenIView("IC0733")
            Dim ICTRE1detail5 As ACCPAC.Advantage.View = dBLink.OpenView("IC0738") ' dBLink.OpenIView("IC0738")

            ICTRE1header.Compose(New ACCPAC.Advantage.View() {ICTRE1detail1, ICTRE1detail2})
            ICTRE1detail1.Compose(New ACCPAC.Advantage.View() {ICTRE1header, Nothing, Nothing, Nothing, Nothing, Nothing, ICTRE1detail3, ICTRE1detail5, ICTRE1detail4})
            ICTRE1detail2.Compose(New ACCPAC.Advantage.View() {ICTRE1header})
            ICTRE1detail3.Compose(New ACCPAC.Advantage.View() {ICTRE1detail1})
            ICTRE1detail4.Compose(New ACCPAC.Advantage.View() {ICTRE1detail1})
            ICTRE1detail5.Compose(New ACCPAC.Advantage.View() {ICTRE1detail1})

            Dim tbreq As DataTable = IRSDBConnection.SelectFields("select * from tbl_request where reqno='" + RequestNumber + "'")
            Dim tbitm As DataTable = IRSDBConnection.SelectFields("select * from tbl_requestitem where reqno='" + RequestNumber + "'")

            ICTRE1header.Init()
            ICTRE1header.Fields.FieldByName("TRANSDATE").SetValue(IRSession.SessionDate, True)
            ICTRE1header.Fields.FieldByName("PROCESSCMD").SetValue(1, False)
            ICTRE1header.Process()
            ICTRE1header.Fields.FieldByName("HDRDESC").SetValue("Released Items From Inventory Request System", True)
            ICTRE1header.Fields.FieldByName("REFERENCE").SetValue(RequestNumber, True)


            Dim itemadded As Integer = 0
            Dim itemtodo As Integer = 0
            Dim itemnotdo As Integer = 0


            For i As Integer = 0 To tbitm.Rows.Count - 1
                Dim itemno As String = tbitm.Rows(i)("itemno").ToString.Trim()
                Dim fromloc As String = tbitm.Rows(i)("fromloc").ToString.Trim()
                Dim toloc As String = tbitm.Rows(i)("toloc").ToString.Trim()
                Dim requom As String = tbitm.Rows(i)("requom").ToString.Trim()
                Dim reqqty As Double = tbitm.Rows(i)("reqqty")
                If fromloc = toloc Then
                    itemnotdo = itemnotdo + 1
                Else
                    itemtodo = itemtodo + 1
                    Try
                        ICTRE1detail1.RecordClear()
                        ICTRE1detail1.RecordCreate(ACCPAC.Advantage.ViewRecordCreate.NoInsert)
                        ICTRE1detail1.Fields.FieldByName("ITEMNO").SetValue(itemno, True)
                        ICTRE1detail1.Fields.FieldByName("PROCESSCMD").SetValue(1, False)
                        ICTRE1detail1.Process()
                        ICTRE1detail1.Fields.FieldByName("FROMLOC").SetValue(fromloc, True)
                        ICTRE1detail1.Fields.FieldByName("TOLOC").SetValue(toloc, True)
                        ICTRE1detail1.Fields.FieldByName("QTYREQ").SetValue(reqqty, True)
                        ICTRE1detail1.Fields.FieldByName("UNITREQ").SetValue(requom, True)
                        'ICTRE1detail1.Fields.FieldByName("PROCESSCMD").SetValue(1, False)
                        'ICTRE1detail1.Process()
                        ICTRE1detail1.Fields.FieldByName("FUNCTION").SetValue(100, False)
                        ICTRE1detail1.Process()
                        ICTRE1detail1.Insert()
                        itemadded = itemadded + 1
                    Catch ex As Exception

                    End Try
                End If
            Next

            ICTRE1header.Fields.FieldByName("STATUS").SetValue(2, True)

            If itemnotdo = tbitm.Rows.Count Then 'Just an internal request
                chk = True
            Else
                If itemadded > 0 And itemadded = itemtodo Then 'No failed item adding for post to sage transfer.
                    Try
                        ICTRE1header.Insert()
                        chk = True
                    Catch ex As Exception
                        chk = False
                    End Try
                Else
                    chk = False
                End If
            End If



            SageSession = Nothing
            dBLink = Nothing
            ICTRE1header = Nothing
            ICTRE1detail1 = Nothing
            ICTRE1detail2 = Nothing
            ICTRE1detail3 = Nothing
            ICTRE1detail4 = Nothing
            ICTRE1detail5 = Nothing
        Else
            chk = True
        End If




        Return chk

    End Function

    Private Function CreateKey(ByVal strPassword As String, ByVal strVerifyKey As String) As Byte()
        Dim bytKey As Byte()
        Dim bytSalt As Byte() = System.Text.Encoding.ASCII.GetBytes(strVerifyKey)
        Dim pdb As New PasswordDeriveBytes(strPassword, bytSalt)
        bytKey = pdb.GetBytes(32)
        Return bytKey
    End Function
    Private Function CreateIV(ByVal strPassword As String, ByVal strVerifyKey As String) As Byte()
        Dim bytIV As Byte()
        Dim bytSalt As Byte() = System.Text.Encoding.ASCII.GetBytes(strVerifyKey)
        Dim pdb As New PasswordDeriveBytes(strPassword, bytSalt)
        bytIV = pdb.GetBytes(16)
        Return bytIV
    End Function

    Public Function EncryptText(ByVal TextToEncrypt As String) As String
        Dim Results As Byte()
        Dim UTF8 As New System.Text.UTF8Encoding
        Dim HashProvider As New MD5CryptoServiceProvider
        Dim TDESKey As Byte() = HashProvider.ComputeHash(UTF8.GetBytes(syspwd))
        Dim TDESAlgorithm As New TripleDESCryptoServiceProvider
        TDESAlgorithm.Key = TDESKey
        TDESAlgorithm.Mode = CipherMode.ECB
        TDESAlgorithm.Padding = PaddingMode.PKCS7
        Dim DataToEncrypt As Byte() = UTF8.GetBytes(TextToEncrypt)
        Try
            Dim Encryptor As ICryptoTransform = TDESAlgorithm.CreateEncryptor()
            Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length)
        Catch ex As Exception
            TDESAlgorithm.Clear()
            HashProvider.Clear()
        End Try
        Return Convert.ToBase64String(Results)
    End Function
    Public Function DecryptText(ByVal TextToDecrypt As String) As String
        Dim res As Byte()
        Dim UTF8 As New System.Text.UTF8Encoding
        Dim HashProvider As New MD5CryptoServiceProvider
        Dim TDESKey As Byte() = HashProvider.ComputeHash(UTF8.GetBytes(syspwd))
        Dim TDESAlgorithm As New TripleDESCryptoServiceProvider
        TDESAlgorithm.Key = TDESKey
        TDESAlgorithm.Mode = CipherMode.ECB
        TDESAlgorithm.Padding = PaddingMode.PKCS7
        Dim DataToDecrypt As Byte() = Convert.FromBase64String(TextToDecrypt)
        Try
            Dim Decryptor As ICryptoTransform = TDESAlgorithm.CreateDecryptor()
            res = Decryptor.TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length)
        Catch ex As Exception
            TDESAlgorithm.Clear()
            HashProvider.Clear()
        End Try
        Return UTF8.GetString(res)


    End Function

    Public Sub EncryptFile(ByVal strInputFile As String, ByVal strOutputFile As String)
        Try
            fsInput = New System.IO.FileStream(strInputFile, FileMode.Open, FileAccess.Read)
            fsOutput = New System.IO.FileStream(strOutputFile, FileMode.OpenOrCreate, FileAccess.Write)
            fsOutput.SetLength(0)
            Dim bytBuffer(4096) As Byte
            Dim lngBytesProcessed As Long = 0
            Dim lngFileLength As Long = fsInput.Length
            Dim intBytesInCurrentBlock As Integer
            Dim csCryptoStream As CryptoStream
            Dim cspRijndael As New System.Security.Cryptography.RijndaelManaged
            Dim bytKey As Byte() = CreateKey(syspwd, syskey)
            Dim bytIV As Byte() = CreateIV(syspwd, syskey)
            csCryptoStream = New CryptoStream(fsOutput, cspRijndael.CreateEncryptor(bytKey, bytIV), CryptoStreamMode.Write)
            While lngBytesProcessed < lngFileLength
                intBytesInCurrentBlock = fsInput.Read(bytBuffer, 0, 4096)
                csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)
                lngBytesProcessed = lngBytesProcessed + CLng(intBytesInCurrentBlock)
            End While
            csCryptoStream.Close()
            fsInput.Close()
            fsOutput.Close()
            Dim fileOriginal As New FileInfo(strInputFile)
            fileOriginal.Delete()
        Catch When Err.Number = 53
            MsgBox("Please check to make sure the path and filename" + "are correct and if the file exists.", MsgBoxStyle.Exclamation, "Invalid Path or Filename")
        Catch
            fsInput.Close()
            fsOutput.Close()
            Dim fileDelete As New FileInfo(strOutputFile)
            fileDelete.Delete()
        End Try
    End Sub

    Public Sub DecryptFile(ByVal strInputFile As String, ByVal strOutputFile As String)
        Try
            fsInput = New System.IO.FileStream(strInputFile, FileMode.Open, FileAccess.Read)
            fsOutput = New System.IO.FileStream(strOutputFile, FileMode.OpenOrCreate, FileAccess.Write)
            fsOutput.SetLength(0)
            Dim bytBuffer(4096) As Byte
            Dim lngBytesProcessed As Long = 0
            Dim lngFileLength As Long = fsInput.Length
            Dim intBytesInCurrentBlock As Integer
            Dim csCryptoStream As CryptoStream
            Dim bytKey As Byte() = CreateKey(syspwd, syskey)
            Dim bytIV As Byte() = CreateIV(syspwd, syskey)
            Dim cspRijndael As New System.Security.Cryptography.RijndaelManaged
            csCryptoStream = New CryptoStream(fsOutput, cspRijndael.CreateDecryptor(bytKey, bytIV), CryptoStreamMode.Write)
            While lngBytesProcessed < lngFileLength
                intBytesInCurrentBlock = fsInput.Read(bytBuffer, 0, 4096)
                csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)
                lngBytesProcessed = lngBytesProcessed + CLng(intBytesInCurrentBlock)
            End While
            csCryptoStream.Close()
            fsInput.Close()
            fsOutput.Close()
            Dim fileEncrypted As New FileInfo(strInputFile)
            fileEncrypted.Delete()
        Catch When Err.Number = 53
            MsgBox("Please check to make sure the path and filename" + "are correct and if the file exists.", MsgBoxStyle.Exclamation, "Invalid Path or Filename")
        Catch
            fsInput.Close()
            fsOutput.Close()
            Dim fileDelete As New FileInfo(strOutputFile)
            fileDelete.Delete()
            MsgBox("Please check to make sure that you entered the correct" + "password.", MsgBoxStyle.Exclamation, "Invalid Password")
        End Try
    End Sub
    Public Function DateToNum(ByVal mDate As DateTime) As String
        Dim year As Integer = mDate.Year
        Dim str As String = year.ToString()
        year = mDate.Month
        Dim str1 As String = year.ToString("0#")
        year = mDate.Day
        Dim str2 As String = year.ToString("0#")
        Return String.Concat(str, str1, str2)
    End Function


    Function ConfigFileValid() As Boolean
        Dim valid As Boolean
        Dim i As Integer = 0
        Try
            Dim reader As New System.IO.StreamReader(".\config.ini")
            Do Until reader.EndOfStream
                reader.ReadLine()
                i = i + 1
            Loop
            reader.Close()
            If i <> 4 Then
                valid = False
            Else
                valid = True
            End If

        Catch ex As Exception
            valid = False
        End Try
        Return valid
    End Function


    Sub RefreshConnection()
        Dim reader As New System.IO.StreamReader(".\config.ini")
        Dim svr As String = DecryptText(reader.ReadLine().Trim)
        Dim login As String = DecryptText(reader.ReadLine().Trim)
        Dim pwd As String = DecryptText(reader.ReadLine().Trim)
        Dim db As String = DecryptText(reader.ReadLine().Trim)
        reader.Close()

        IRSDBConnection = New DBConnect()
        IRSDBConnection.Open(svr, login, pwd, db)

        Dim cnt As Integer = CInt(IRSDBConnection.SelectField("select count(*) from sys_config").ToString.Trim)
        If cnt = 0 Then
            IRSDBConnection.RunDML("insert into sys_config (checksum) values ('A')")
        End If
        If cnt > 1 Then
            IRSDBConnection.RunDML("delete from sys_config where checksum != 'A'")
        End If

        Dim tb As DataTable = IRSDBConnection.SelectFields("select * from sys_config where checksum='A'")

        Dim sagesvr, sagelogin, sagepwd, sagedb As String
        sagesvr = tb.Rows(0)("sagesvr").ToString.Trim
        sagelogin = tb.Rows(0)("sagelogin").ToString.Trim
        sagepwd = DecryptText(tb.Rows(0)("sagepwd").ToString.Trim)
        sagedb = tb.Rows(0)("sagedb").ToString.Trim

        SageDBConnection = New DBConnect
        SageDBConnection.Open(sagesvr, sagelogin, sagepwd, sagedb)

        IRMail = New DBMailService

        Sage300 = New SageInfo

    End Sub

    Function OpenView(ByVal ViewID As String, ByVal Source As Integer) As View
        Dim view As View = New View(Source)
        Dim fields As List(Of DBField) = New List(Of DBField)()
        Dim streamReader As System.IO.StreamReader = New System.IO.StreamReader(String.Concat(".\View\", ViewID, ".dll"))
        While Not streamReader.EndOfStream
            Dim strArrays As String() = streamReader.ReadLine().Split(New Char() {Strings.ChrW(9)})

            Dim field As DBField = New DBField()
            view.DataSourceName = strArrays(0).Trim()
            view.DataSourceType = CInt(strArrays(1).Trim())
            field.Index = CInt(strArrays(2).Trim())
            field.ID = strArrays(3).Trim()
            field.Name = strArrays(4).Trim()
            field.DataType = strArrays(5).Trim()
            field.Length = CInt(strArrays(6).Trim())
            If CInt(strArrays(8).Trim()) = 1 Then
                field.IsPrimary = True
            Else
                field.IsPrimary = False
            End If
            field.DefaultValue = strArrays(9).Trim()
            field.ValueIsNull = True
            fields.Add(field)
            If (field.IsPrimary) Then
                view.AddPrimaryField(field)
            End If
            field.FieldWidth = CInt(strArrays(11).Trim())
            field.FieldType = strArrays(12).Trim()
            If strArrays(13).Trim.Length > 0 Then
                Dim tb As New DataTable
                tb.Columns.Add("CODE")
                tb.Columns.Add("NAME")

                If strArrays(13).Trim.Contains(";") = False Then

                    tb.Rows.Add({strArrays(13).Trim.Split("=")(0), strArrays(13).Trim.Split("=")(1)})

                Else

                    Dim liststr() As String = strArrays(13).Trim.Split(";")
                    For i As Integer = 0 To liststr.Count - 1
                        tb.Rows.Add({liststr(i).Split("=")(0), liststr(i).Split("=")(1)})
                    Next



                End If
                field.DropDownValue = tb

            End If
            field.Searchable = If(strArrays(14).Trim() = "Yes", True, False)



        End While
        streamReader.Close()
        view.Fields = fields

        Return view
    End Function

    Sub ShowForm(ByVal frm As DevExpress.XtraEditors.XtraForm)
        frm.MdiParent = frmMaster
        frm.Show()
    End Sub
End Module
