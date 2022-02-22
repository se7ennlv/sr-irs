Public Class SageInfo

    Private _orgid As String
    Private _version As String
    Private _homcur As String
    Sub New()
        _orgid = SageDBConnection.SelectField("select ORGID from CSCOM").ToString.Trim
        _homcur = SageDBConnection.SelectField("select HOMECUR from CSCOM").ToString.Trim
        _version = SageDBConnection.SelectField("select PGMVER from CSAPP where SELECTOR='CS'").ToString.Trim
    End Sub
    ReadOnly Property OrgID As String
        Get
            Return _orgid
        End Get
    End Property
    ReadOnly Property Version As String
        Get
            Return _version
        End Get
    End Property
    ReadOnly Property HomeCurrency As String
        Get
            Return _homcur
        End Get
    End Property



End Class
