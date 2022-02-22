Public Class DBUser
    Private _userid As String
    Private _fname As String
    Private _lname As String
    Private _pwd As String
    Private _email As String
    Private _sageid As String
    Private _sagepwd As String
    Private _active As Boolean
    Private _utype As Integer
    Private _isinvctrl As Boolean
    Private _isreqapprov As Boolean
    Private _isinvapprov As Boolean
    Private _jobtitle As String
    Sub New(ByVal UserID As String)
        _userid = UserID
        Dim tb As DataTable = IRSDBConnection.SelectFields("select * from sys_users where userid='" + UserID + "'")
        If tb.Rows.Count = 1 Then
            _userid = tb.Rows(0)("USERID").ToString.Trim
            _fname = tb.Rows(0)("FNAME").ToString.Trim
            _lname = tb.Rows(0)("LNAME").ToString.Trim
            _pwd = tb.Rows(0)("PWD").ToString.Trim
            _email = tb.Rows(0)("EMAIL").ToString.Trim
            _sageid = tb.Rows(0)("SAGEUID").ToString.Trim
            _sagepwd = tb.Rows(0)("SAGEPWD").ToString.Trim
            _active = tb.Rows(0)("SWACTIVE")
            _utype = tb.Rows(0)("UTYPE")
            _jobtitle = tb.Rows(0)("JOBTITLE").ToString.Trim

            Dim cnt As Integer = IRSDBConnection.SelectField("select count(*) from tbl_depinvcontroler where userid='" + UserID + "'")
            If cnt = 1 Then
                _isinvctrl = True
            End If
            cnt = IRSDBConnection.SelectField("select count(*) from tbl_depreqapprover where userid='" + UserID + "'")
            If cnt = 1 Then
                _isreqapprov = True
            End If
            cnt = IRSDBConnection.SelectField("select count(*) from tbl_depinvapprover where userid='" + UserID + "'")
            If cnt = 1 Then
                _isinvapprov = True
            End If

        Else
            _userid = ""
            _fname = ""
            _lname = ""
            _pwd = ""
            _email = ""
            _sageid = ""
            _sagepwd = ""
            _active = False
            _utype = -1
            _isinvctrl = False
            _isreqapprov = False
            _isinvapprov = False
            _jobtitle = ""
        End If

    End Sub

    ReadOnly Property JobTitle As String
        Get
            Return _jobtitle
        End Get
    End Property
    ReadOnly Property IsInventoryControler As Boolean
        Get
            Return _isinvctrl
        End Get
    End Property

    ReadOnly Property IsRequestApprover As Boolean
        Get
            Return _isreqapprov
        End Get
    End Property

    ReadOnly Property IsInventoryApprover As Boolean
        Get
            Return _isinvapprov
        End Get
    End Property
    ReadOnly Property ID As String
        Get
            Return _userid
        End Get
    End Property

    ReadOnly Property FirstName As String
        Get
            Return _fname
        End Get
    End Property

    ReadOnly Property LastName As String
        Get
            Return _lname
        End Get
    End Property


    ReadOnly Property Password As String
        Get
            Return _pwd
        End Get
    End Property
    ReadOnly Property Email As String
        Get
            Return _email
        End Get
    End Property

    ReadOnly Property SageID As String
        Get
            Return _sageid
        End Get
    End Property

    ReadOnly Property SagePwd As String
        Get
            Return _sagepwd
        End Get
    End Property

    ReadOnly Property Active As Boolean
        Get
            Return _active
        End Get
    End Property
End Class
