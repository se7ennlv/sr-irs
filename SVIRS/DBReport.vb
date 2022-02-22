Public Class DBReport
    Private _id As String = ""
    Private _desc As String = ""
    Private _file As String = ""
    Private _sage As Boolean = False

    Sub New(ByVal ReportID As String)
        Dim tb As DataTable = IRSDBConnection.SelectFields("select * from tbl_reports where rptcode='" + ReportID + "'")
        If tb.Rows.Count = 1 Then
            _id = ReportID
            _desc = tb.Rows(0)("rptdesc").ToString.Trim
            _file = tb.Rows(0)("rptfile").ToString.Trim
            _sage = tb.Rows(0)("rptsage")
        End If
    End Sub
    ReadOnly Property ID As String
        Get
            Return _id
        End Get
    End Property

    ReadOnly Property Description As String
        Get
            Return _desc
        End Get
    End Property

    ReadOnly Property FileName As String
        Get
            Return _file
        End Get
    End Property

    ReadOnly Property ForSage As Boolean
        Get
            Return _sage
        End Get
    End Property

    Sub Preview()

        If _file <> "" Then
            Dim rpt As New CrReport(_file.Replace(".rpt", ""), If(_sage = True, 1, 0))
            rpt.Preview()
        End If

    End Sub


End Class
