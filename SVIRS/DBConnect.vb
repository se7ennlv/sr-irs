Imports System.Data.OleDb
Imports System.Collections

Public Class DBConnect
    Private _conn As OleDbConnection
    Private _trans As OleDbTransaction
    Private _inscmd As OleDbCommand
    Private _instbl As String
    Private _arrField As ArrayList
    Private _arrValue As ArrayList
    Private _arrFieldWhere As ArrayList
    Private _arrValueWhere As ArrayList
    Private _server, _login, _password, _database As String
    'Private _server1, _login1, _password1, _database1 As String
    Private _dataset As System.Data.DataSet
    Private _connected As Boolean

    Sub New()
        _conn = New OleDbConnection
        _trans = Nothing
        _server = ""
        _login = ""
        _password = ""
        _database = ""
    End Sub


    Sub Open(ByVal ServerName As String, ByVal Login As String, ByVal Password As String, ByVal Database As String)
        _server = ServerName
        _login = Login
        _password = Password
        _database = Database
        Try
            _conn = New OleDbConnection("Provider=SQLOledb.1; Data Source=" + _server + "; User ID=" + _login + "; Password=" + _password + "; Initial Catalog=" + _database)
            _conn.Open()
            _connected = True
        Catch ex As Exception
            _connected = False
        End Try
    End Sub

    ReadOnly Property Connected As Boolean
        Get
            Return _connected
        End Get
    End Property
    ReadOnly Property DBServer As String
        Get
            Return _server
        End Get
    End Property

    ReadOnly Property DBLogin As String
        Get
            Return _login
        End Get
    End Property

    ReadOnly Property DBPassword As String
        Get
            Return _password
        End Get
    End Property

    ReadOnly Property DBName As String
        Get
            Return _database
        End Get
    End Property

    Function ClientConnectionString() As String
        Return "Data Source=" + _server + ";Initial Catalog=" + _database + ";User Id=" + _login + ";Password=" + _password + ";"
    End Function
    Function SqlConnectionString() As String
        Return "Server=" + _server + ";Database=" + _database + ";User Id=" + _login + ";Password=" + _password + ";"
    End Function
    Function ConnectionString() As String
        Return "DRIVER={SQL Native Client}; SERVER=" + _server + "; UID=" + _login + "; PWD=" + _password + "; DATABASE=" + _database
    End Function

    Function OledbConnectionString() As String
        Return "Provider=SQLOledb.1; Data Source=" + _server + "; User ID=" + _login + "; Password=" + _password + "; Initial Catalog=" + _database
    End Function

    Function SelectField(ByVal SqlString As String) As Object
        If _conn.State = ConnectionState.Broken Or _conn.State = ConnectionState.Closed Then
            _conn.Open()
        End If
        Dim dap As New OleDbDataAdapter(SqlString, _conn)
        Dim tbl As New Data.DataTable
        dap.Fill(tbl)
        If tbl.Rows.Count > 0 Then Return tbl.Rows(0)(0) Else Return vbNull
    End Function
    Function SelectField(ByVal Cmd As OleDbCommand) As Object
        If _conn.State = ConnectionState.Broken Or _conn.State = ConnectionState.Closed Then
            _conn.Open()
        End If
        Cmd.Connection = _conn
        Dim dap As New OleDbDataAdapter(Cmd)
        Dim tbl As New Data.DataTable
        dap.Fill(tbl)
        If tbl.Rows.Count > 0 Then Return tbl.Rows(0)(0) Else Return vbNull
    End Function
    Function SelectFields(ByVal SqlString As String) As Data.DataTable
        If _conn.State = ConnectionState.Broken Or _conn.State = ConnectionState.Closed Then
            _conn.Open()
        End If
        Dim dap As New OleDbDataAdapter(SqlString, _conn)
        Dim tbl As New Data.DataTable
        dap.Fill(tbl)
        Return tbl
    End Function
    Function SelectFields(ByVal Cmd As OleDbCommand) As Data.DataTable
        If _conn.State = ConnectionState.Broken Or _conn.State = ConnectionState.Closed Then
            _conn.Open()
        End If
        Cmd.Connection = _conn
        Dim dap As New OleDbDataAdapter(Cmd)
        Dim tbl As New Data.DataTable
        dap.Fill(tbl)
        Return tbl
    End Function
    Sub RunDML(ByVal SqlString As String)
        If _conn.State = ConnectionState.Broken Or _conn.State = ConnectionState.Closed Then
            _conn.Open()
        End If
        Dim cmd As New OleDbCommand(SqlString, _conn)
        Dim i As Integer = cmd.ExecuteNonQuery()
    End Sub
    Sub RunDML(ByVal Cmd As OleDbCommand)
        If _conn.State = ConnectionState.Broken Or _conn.State = ConnectionState.Closed Then
            _conn.Open()
        End If
        Cmd.Connection = _conn
        Cmd.Transaction = _trans
        Dim i As Integer = Cmd.ExecuteNonQuery()
    End Sub
    Sub Close()
        _conn.Close()
    End Sub

    Sub BeginTransaction()
        _trans = _conn.BeginTransaction()
    End Sub
    Sub Commit()
        _trans.Commit()
    End Sub
    Sub RollBack()
        _trans.Rollback()
    End Sub


    Sub StartInsertCommand(ByVal TableName As String)
        If _conn.State = ConnectionState.Broken Or _conn.State = ConnectionState.Closed Then
            _conn.Open()
        End If
        _inscmd = New OleDbCommand
        _inscmd.Connection = _conn
        _instbl = TableName
        _arrField = New ArrayList
        _arrValue = New ArrayList
    End Sub
    Sub InsertField(ByVal FieldName As String, ByVal FieldValue As Object)
        _arrField.Add(FieldName)
        _arrValue.Add(FieldValue)
    End Sub
    Sub ExecuteInsertCommand()
        If _conn.State = ConnectionState.Broken Or _conn.State = ConnectionState.Closed Then
            _conn.Open()
        End If

        Dim strfield As String = ""
        Dim strvalue As String = ""
        For i As Integer = 0 To _arrField.Count - 1
            strfield = strfield + _arrField(i).ToString() + ", "
            strvalue = strvalue + "?, "
        Next
        strfield = strfield.Substring(0, strfield.Length - 2)
        strvalue = strvalue.Substring(0, strvalue.Length - 2)
        Dim sqlstring As String = "insert into " + _instbl + " (" + strfield + ") values (" + strvalue + ")"
        _inscmd.CommandText = sqlstring
        For i As Integer = 0 To _arrField.Count - 1
            _inscmd.Parameters.AddWithValue("@" + _arrField(i).ToString(), _arrValue(i))
        Next
        Dim k As Integer = _inscmd.ExecuteNonQuery()
    End Sub

    Sub StartUpdateCommand(ByVal TableName As String)
        If _conn.State = ConnectionState.Broken Or _conn.State = ConnectionState.Closed Then
            _conn.Open()
        End If
        _inscmd = New OleDbCommand
        _inscmd.Connection = _conn
        _instbl = TableName
        _arrField = New ArrayList
        _arrValue = New ArrayList
        _arrFieldWhere = New ArrayList
        _arrValueWhere = New ArrayList
    End Sub
    Sub SetUpdateField(ByVal FieldName As String, ByVal FieldValue As Object)
        _arrField.Add(FieldName)
        _arrValue.Add(FieldValue)
    End Sub
    Sub SetWhereField(ByVal FieldName As String, ByVal FieldValue As Object)
        _arrFieldWhere.Add(FieldName)
        _arrValueWhere.Add(FieldValue)
    End Sub
    Sub ExecuteUpdateCommand()
        If _conn.State = ConnectionState.Broken Or _conn.State = ConnectionState.Closed Then
            _conn.Open()
        End If

        Dim strset As String = ""
        For i As Integer = 0 To _arrField.Count - 1
            strset = strset + _arrField(i).ToString() + "=?, "
        Next
        strset = strset.Substring(0, strset.Length - 2)
        Dim strwhere As String = ""
        If _arrFieldWhere.Count > 0 Then
            For i As Integer = 0 To _arrFieldWhere.Count - 1
                strwhere = strwhere + _arrFieldWhere(i).ToString() + "=? and "
            Next
            strwhere = " where " + strwhere.Substring(0, strwhere.Length - 5)
        End If
        Dim sqlstring As String = "update " + _instbl + " set " + strset + strwhere
        _inscmd.CommandText = sqlstring
        For i As Integer = 0 To _arrField.Count - 1
            _inscmd.Parameters.AddWithValue("@" + _arrField(i).ToString(), _arrValue(i))
        Next
        If _arrFieldWhere.Count > 0 Then
            For i As Integer = 0 To _arrFieldWhere.Count - 1
                _inscmd.Parameters.AddWithValue("@" + _arrFieldWhere(i).ToString(), _arrValueWhere(i))
            Next
        End If
        Dim k As Integer = _inscmd.ExecuteNonQuery()
    End Sub

    Sub StartDeleteCommand(ByVal TableName As String)
        If _conn.State = ConnectionState.Broken Or _conn.State = ConnectionState.Closed Then
            _conn.Open()
        End If

        _inscmd = New OleDbCommand
        _inscmd.Connection = _conn
        _instbl = TableName
        _arrFieldWhere = New ArrayList
        _arrValueWhere = New ArrayList
    End Sub

    Sub ExecuteDeleteCommand()
        If _conn.State = ConnectionState.Broken Or _conn.State = ConnectionState.Closed Then
            _conn.Open()
        End If

        Dim strwhere As String = ""
        If _arrFieldWhere.Count > 0 Then
            For i As Integer = 0 To _arrFieldWhere.Count - 1
                strwhere = strwhere + _arrFieldWhere(i).ToString() + "=? and "
            Next
            strwhere = " where " + strwhere.Substring(0, strwhere.Length - 5)
            Dim sqlstring As String = "delete from " + _instbl + strwhere
            _inscmd.CommandText = sqlstring

            For i As Integer = 0 To _arrFieldWhere.Count - 1
                _inscmd.Parameters.AddWithValue("@" + _arrFieldWhere(i).ToString(), _arrValueWhere(i))
            Next
            Dim k As Integer = _inscmd.ExecuteNonQuery()
        End If
    End Sub
End Class
