Public Class DBField
    Private _fieldindex As Integer
    Private _fieldid As String
    Private _fieldname As String
    Private _fielddatatype As String
    Private _fieldmaxlength As Integer
    Private _fieldisprimary As Boolean
    Private _fielddefaultvalue As Object
    Private _fieldvalue As Object
    Private _valueisnull As Boolean
    Private _fieldtype As String
    Private _fwidth As Integer
    Private _dropdata As DataTable
    Private _searchable As Boolean
    Public Property DataType As String
        Get
            Return _fielddatatype
        End Get
        Set(ByVal value As String)
            _fielddatatype = value
        End Set
    End Property
    Public Property DefaultValue As Object
        Get
            Return _fielddefaultvalue
        End Get
        Set(ByVal value As Object)
            _fielddefaultvalue = value
        End Set
    End Property
    Public Property Searchable As Boolean
        Set(value As Boolean)
            _searchable = value
        End Set
        Get
            Return _searchable
        End Get
    End Property
    Public Property FieldValue As Object
        Get
            Return Me._fieldvalue
        End Get
        Set(ByVal value As Object)
            Me._fieldvalue = value
        End Set
    End Property

    Public Property ID As String
        Get
            Return Me._fieldid
        End Get
        Set(ByVal value As String)
            Me._fieldid = value
        End Set
    End Property

    Public Property Index As Integer
        Get
            Return Me._fieldindex
        End Get
        Set(ByVal value As Integer)
            Me._fieldindex = value
        End Set
    End Property

    Public Property IsPrimary As Boolean
        Get
            Return Me._fieldisprimary
        End Get
        Set(ByVal value As Boolean)
            Me._fieldisprimary = value
        End Set
    End Property

    Public Property Length As Integer
        Get
            Return _fieldmaxlength
        End Get
        Set(ByVal value As Integer)
            Me._fieldmaxlength = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return Me._fieldname
        End Get
        Set(ByVal value As String)
            Me._fieldname = value
        End Set
    End Property
    Public Property ValueIsNull As Boolean
        Set(value As Boolean)
            _valueisnull = value
        End Set
        Get
            Return _valueisnull
        End Get
    End Property

    Public Property DropDownValue As DataTable
        Set(value As DataTable)
            _dropdata = value
        End Set
        Get
            Return _dropdata
        End Get
    End Property
    Public Property FieldType As String
        Set(value As String)
            _fieldtype = value
        End Set
        Get
            Return _fieldtype
        End Get
    End Property
    Public Property FieldWidth As Integer
        Set(value As Integer)
            _fwidth = value
        End Set
        Get
            Return _fwidth
        End Get
    End Property

    Public Sub New()
        MyBase.New()
        Me._valueisnull = False
    End Sub
End Class
