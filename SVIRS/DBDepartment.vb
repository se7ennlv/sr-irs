Public Class DBDepartment
    Private _depcode As String
    Private _depname As String
    Private _ctrlinv As Boolean
    Private _icgrpmail As String
    Private _ragrpmail As String
    Private _iagrpmail As String

    Private _employee As List(Of DBUser)
    Private _invctrl As List(Of DBUser)
    Private _rapprover As List(Of DBUser)
    Private _iapprover As List(Of DBUser)


    Sub New(ByVal Code As String)
        Dim tb As DataTable = IRSDBConnection.SelectFields("select * from tbl_departments where depcode='" + Code + "'")
        If tb.Rows.Count = 1 Then
            _depcode = Code
            _depname = tb.Rows(0)("depdesc").ToString.Trim
            _ctrlinv = tb.Rows(0)("swinvctrl")
            _icgrpmail = tb.Rows(0)("icgrpmail").ToString.Trim
            _ragrpmail = tb.Rows(0)("ragrpmail").ToString.Trim
            _iagrpmail = tb.Rows(0)("iagrpmail").ToString.Trim

            _employee = New List(Of DBUser)
            _invctrl = New List(Of DBUser)
            _rapprover = New List(Of DBUser)
            _iapprover = New List(Of DBUser)

            Dim tbemp As DataTable = IRSDBConnection.SelectFields("select userid from tbl_depemployee where depcode='" + Code + "'")
            For i As Integer = 0 To tbemp.Rows.Count - 1
                _employee.Add(New DBUser(tbemp.Rows(i)(0).ToString.Trim))
            Next

            tbemp = IRSDBConnection.SelectFields("select userid from tbl_depinvcontroler where depcode='" + Code + "'")
            For i As Integer = 0 To tbemp.Rows.Count - 1
                _invctrl.Add(New DBUser(tbemp.Rows(i)(0).ToString.Trim))
            Next

            tbemp = IRSDBConnection.SelectFields("select userid from tbl_depreqapprover where depcode='" + Code + "'")
            For i As Integer = 0 To tbemp.Rows.Count - 1
                _rapprover.Add(New DBUser(tbemp.Rows(i)(0).ToString.Trim))
            Next

            tbemp = IRSDBConnection.SelectFields("select userid from tbl_depinvapprover where depcode='" + Code + "'")
            For i As Integer = 0 To tbemp.Rows.Count - 1
                _iapprover.Add(New DBUser(tbemp.Rows(i)(0).ToString.Trim))
            Next


        Else
            _depcode = ""
            _depname = ""
            _ctrlinv = False
            _icgrpmail = ""
            _ragrpmail = ""
            _iagrpmail = ""

            _employee = New List(Of DBUser)
            _invctrl = New List(Of DBUser)
            _rapprover = New List(Of DBUser)
            _iapprover = New List(Of DBUser)
        End If



    End Sub

    ReadOnly Property Code As String
        Get
            Return _depcode
        End Get
    End Property
    ReadOnly Property Name As String
        Get
            Return _depname
        End Get
    End Property

    ReadOnly Property HasControlInventory As Boolean
        Get
            Return _ctrlinv
        End Get
    End Property

    ReadOnly Property InventoryControlGroupEmail As String
        Get
            Return _icgrpmail
        End Get
    End Property

    ReadOnly Property RequestApproverGroupMail As String
        Get
            Return _ragrpmail
        End Get
    End Property
    ReadOnly Property InventoryApproverGroupMail As String
        Get
            Return _iagrpmail
        End Get
    End Property

    ReadOnly Property Employess As List(Of DBUser)
        Get
            Return _employee
        End Get
    End Property

    ReadOnly Property InventoryControllers As List(Of DBUser)
        Get
            Return _invctrl
        End Get
    End Property

    ReadOnly Property RequestApprovers As List(Of DBUser)
        Get
            Return _rapprover
        End Get
    End Property
    ReadOnly Property InventoryApprovers As List(Of DBUser)
        Get
            Return _iapprover
        End Get
    End Property

End Class
