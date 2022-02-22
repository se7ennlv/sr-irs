Public Class DBSession


    Private _conencted As Boolean
    Private _userid As String
    Private _loginname As String
    Private _sagelogin As String
    Private _sagepwd As String
    Private _sessdate As Date
    Private _email As String
    Private _depcode As String
    Private _depdesc As String
    Private _utype As Integer
    Private _invapprover As Boolean
    Private _reqapprover As Boolean
    Private _invcontorl As Boolean

    Sub New()
        _conencted = False
        _userid = ""
        _loginname = ""
        _sagelogin = ""
        _sagepwd = ""
        _email = ""
        _sessdate = New Date
        _depcode = ""
        _depdesc = ""
        _utype = 0
        _reqapprover = False
        _invapprover = False
        _invcontorl = False
    End Sub


    Sub Open(ByVal UserID As String, ByVal Password As String, ByVal SessionDate As Date)
        Dim tbuser As DataTable = IRSDBConnection.SelectFields("select * from sys_users where USERID='" + UserID + "' and PWD='" + Password + "' and SWACTIVE='True'")
        If tbuser.Rows.Count = 1 Then
            _conencted = True
            _userid = UserID

            _loginname = tbuser.Rows(0)("FNAME").ToString.Trim + " " + tbuser.Rows(0)("LNAME").ToString.Trim
            _sagelogin = tbuser.Rows(0)("SAGEUID").ToString.Trim
            _sagepwd = tbuser.Rows(0)("SAGEPWD").ToString.Trim
            _email = tbuser.Rows(0)("EMAIL").ToString.Trim
            _sessdate = SessionDate
            _depcode = IRSDBConnection.SelectField("select depcode from tbl_depemployee where userid='" + UserID + "'").ToString.Trim()
            _depdesc = IRSDBConnection.SelectField("select depdesc from tbl_departments where depcode='" + _depcode + "'").ToString.Trim
            _utype = tbuser.Rows(0)("UTYPE")

            Dim test As String = "select count(*) from tbl_depreqapprover where userid='" + UserID + "' and depcode='" + _depcode + "'"

            Dim cnt As Integer = IRSDBConnection.SelectField("select count(*) from tbl_depreqapprover where userid='" + UserID + "' and depcode='" + _depcode + "'")
            _reqapprover = If(cnt = 1, True, False)
            Dim cnt1 As Integer = IRSDBConnection.SelectField("select count(*) from tbl_depinvapprover where userid='" + UserID + "' and depcode='" + _depcode + "'")
            _invapprover = If(cnt1 = 1, True, False)

            Dim cnt2 As Integer = IRSDBConnection.SelectField("select count(*) from tbl_depinvcontroler where userid='" + UserID + "' and depcode='" + _depcode + "'")
            _invcontorl = If(cnt2 = 1, True, False)
        Else
            _conencted = False
            _userid = ""
            _loginname = ""
            _sagelogin = ""
            _sagepwd = ""
            _email = ""
            _sessdate = New Date
            _depcode = ""
            _depdesc = ""
            _utype = 0
            _reqapprover = False
            _invapprover = False
            _invcontorl = False
        End If
    End Sub
    ReadOnly Property InventoryControler As Boolean
        Get
            Return _invcontorl
        End Get
    End Property
    ReadOnly Property RequestApprover As Boolean
        Get
            Return _reqapprover
        End Get
    End Property
    ReadOnly Property InventoryApprover As Boolean
        Get
            Return _invapprover
        End Get
    End Property
    ReadOnly Property UserType As Integer
        Get
            Return _utype
        End Get
    End Property

    ReadOnly Property Connected As Boolean
        Get
            Return _conencted
        End Get
    End Property
    ReadOnly Property SessionDate As Date
        Get
            Return _sessdate
        End Get
    End Property
    ReadOnly Property UserID As String
        Get
            Return _userid
        End Get
    End Property


    ReadOnly Property LoginName As String
        Get
            Return _loginname
        End Get
    End Property

    ReadOnly Property SageLogin As String
        Get
            Return _sagelogin
        End Get
    End Property
    ReadOnly Property SagePwd As String
        Get
            Return _sagepwd
        End Get
    End Property

    ReadOnly Property Email As String
        Get
            Return _email
        End Get
    End Property

    ReadOnly Property DepartmentCode As String
        Get
            Return _depcode
        End Get
    End Property

    ReadOnly Property DepartmentName As String
        Get
            Return _depdesc
        End Get
    End Property

End Class
