Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class CrReport

    Private rpt As ReportDocument
    Dim txt As String
    Sub New(ByVal FileName As String, ByVal ReportSource As Integer)
        txt = My.Application.Info.DirectoryPath + "\Report\" + If(ReportSource = 0, "IRS\", "Sage\") + FileName + ".rpt"
        rpt = New ReportDocument
        'rpt.FileName = ".\Report\" + If(ReportSource = 0, "IRS\", "Sage\") + FileName + ".rpt"
        'rpt.FileName = txt

        rpt.Load(txt)

        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo
        Dim CrTables As Tables
        Dim CrTable As Table

        'ReportSoruce: 0 = IRS, 1 = Sage

        With crConnectionInfo
            .ServerName = If(ReportSource = 0, IRSDBConnection.DBServer, SageDBConnection.DBServer)
            .DatabaseName = If(ReportSource = 0, IRSDBConnection.DBName, SageDBConnection.DBName)
            .UserID = If(ReportSource = 0, IRSDBConnection.DBLogin, SageDBConnection.DBLogin)
            .Password = If(ReportSource = 0, IRSDBConnection.DBPassword, SageDBConnection.DBPassword)
        End With


        'rpt.SetDatabaseLogon(crConnectionInfo.UserID, crConnectionInfo.Password, crConnectionInfo.ServerName, crConnectionInfo.DatabaseName)

        CrTables = rpt.Database.Tables
        For Each CrTable In CrTables
            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)
        Next

        For i As Integer = 0 To rpt.Subreports.Count - 1
            CrTables = rpt.Subreports(i).Database.Tables
            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo = crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
            Next

            'rpt.Subreports(i).SetDatabaseLogon(crConnectionInfo.UserID, crConnectionInfo.Password, crConnectionInfo.ServerName, crConnectionInfo.DatabaseName)

        Next
        rpt.Refresh()


    End Sub

   


    Sub SetParameter(ByVal Name As String, ByVal Value As Object)
        rpt.SetParameterValue(Name, Value)
    End Sub


    Sub AddFilter(ByVal FilterString As String)
        rpt.RecordSelectionFormula = rpt.RecordSelectionFormula + FilterString
    End Sub

    Sub Preview()
        Dim fm As New frmReportViewer
        fm.rptViewer.ReportSource = rpt
        fm.Text = txt
        fm.Show()
    End Sub
    

End Class
