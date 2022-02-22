Imports System.Data.OleDb
Imports System.Collections

Public Class View
    Private _vDataSourceType As Integer
    Private _vDataSourceName As String
    Private _vFields As List(Of DBField)
    Private _tblRecords As DataTable
    Private _selectedRecordIndex As Integer
    Private _commandtype As Integer '0=Insert, 1=Update, 2=Delete, 3=Read
    Private _posterror As Integer
    Private _PrimaryFields As List(Of DBField)
    Private _AddedFields As List(Of DBField)
    Private _MasterFields As List(Of DBField)
    Private _ToBeUpdatedFields As List(Of DBField)
    Private _ToFilterByFields As List(Of DBField)
    Private _tblPrePost As DataTable
    Private _tblPreAdd As DataTable
    Private _addedrequiredcount As Integer
    Private _statusrecordadd As Integer
    Private _statusready As Integer
    Private _secondSourceNames As ArrayList
    Private _secondSourceDatas As ArrayList
    Private _arrCombinedFields As ArrayList
    Private _description As String
    Private DBAccess As DBConnect

    Sub New()
        ' TODO: Complete member initialization 
    End Sub

    Public Property Description As String
        Set(value As String)
            _description = value
        End Set
        Get
            Return _description
        End Get
    End Property
    Public ReadOnly Property BoundData As DataTable
        Get
            Return Me._tblRecords
        End Get
    End Property

    Public ReadOnly Property CommandType As Integer
        Get
            Return Me._commandtype
        End Get
    End Property

    Public Property DataSourceName As String
        Get
            Return Me._vDataSourceName
        End Get
        Set(ByVal value As String)
            Me._vDataSourceName = value
        End Set
    End Property

    Public Property DataSourceType As Integer
        Get
            Return Me._vDataSourceType
        End Get
        Set(ByVal value As Integer)
            Me._vDataSourceType = value
        End Set
    End Property

    Public Property Fields As List(Of DBField)
        Get
            Return Me._vFields
        End Get
        Set(ByVal value As List(Of DBField))
            Me._vFields = value
        End Set
    End Property

    Public ReadOnly Property MasterFields As List(Of DBField)
        Get
            Return Me._MasterFields
        End Get
    End Property

    Public ReadOnly Property PostErrorCode As Integer
        Get
            Return Me._posterror
        End Get
    End Property

    Public ReadOnly Property PrePostData As DataTable
        Get
            Return Me._tblPrePost
        End Get
    End Property

    Public ReadOnly Property RecordCount As Integer
        Get
            Return Me._tblRecords.Rows.Count
        End Get
    End Property

    Public ReadOnly Property StatusRecordAdd As Integer
        Get
            Return Me._statusrecordadd
        End Get
    End Property

    Public Sub New(ByVal DataType As Integer)
        MyBase.New()
        Me._selectedRecordIndex = 0
        Me._commandtype = 0
        Me._posterror = 1
        Me._PrimaryFields = New List(Of DBField)()
        Me._AddedFields = New List(Of DBField)()
        Me._MasterFields = New List(Of DBField)()
        Me._ToBeUpdatedFields = New List(Of DBField)()
        Me._ToFilterByFields = New List(Of DBField)()
        Me._addedrequiredcount = 0
        Me._statusrecordadd = 0
        Me._statusready = 0
        Me._secondSourceNames = New ArrayList()
        Me._secondSourceDatas = New ArrayList()
        Me._arrCombinedFields = New ArrayList()
        _vDataSourceType = DataType
        If DataType = 0 Then '0 = IRS Connection, 1= Sage Connection
            DBAccess = IRSDBConnection
        Else
            DBAccess = SageDBConnection
        End If
    End Sub

    Public Sub AddPrimaryField(ByVal vField As DBField)
        _PrimaryFields.Add(vField)
    End Sub


    Public Sub Combine(ByVal nView1 As View, ByVal nView2 As View, ByVal nView3 As View, ByVal nView4 As View, ByVal nView5 As View, ByVal nView6 As View, ByVal nView7 As View)
        If (nView1 IsNot Nothing) Then
            Me._secondSourceNames.Add(nView1.DataSourceName)
            Me._secondSourceDatas.Add(nView1.PrePostData)
            Me._arrCombinedFields.Add(nView1.Fields)
            If (nView1.StatusRecordAdd = 1) Then
                Me._statusready = 1
            End If
        End If
        If (nView2 IsNot Nothing) Then
            Me._secondSourceNames.Add(nView2.DataSourceName)
            Me._secondSourceDatas.Add(nView2.PrePostData)
            Me._arrCombinedFields.Add(nView2.Fields)
            If (nView2.StatusRecordAdd = 1) Then
                Me._statusready = 1
            End If
        End If
        If (nView3 IsNot Nothing) Then
            Me._secondSourceNames.Add(nView3.DataSourceName)
            Me._secondSourceDatas.Add(nView3.PrePostData)
            Me._arrCombinedFields.Add(nView3.Fields)
            If (nView3.StatusRecordAdd = 1) Then
                Me._statusready = 1
            End If
        End If
        If (nView4 IsNot Nothing) Then
            Me._secondSourceNames.Add(nView4.DataSourceName)
            Me._secondSourceDatas.Add(nView4.PrePostData)
            Me._arrCombinedFields.Add(nView4.Fields)
            If (nView4.StatusRecordAdd = 1) Then
                Me._statusready = 1
            End If
        End If
        If (nView5 IsNot Nothing) Then
            Me._secondSourceNames.Add(nView5.DataSourceName)
            Me._secondSourceDatas.Add(nView5.PrePostData)
            Me._arrCombinedFields.Add(nView5.Fields)
            If (nView5.StatusRecordAdd = 1) Then
                Me._statusready = 1
            End If
        End If
        If (nView6 IsNot Nothing) Then
            Me._secondSourceNames.Add(nView6.DataSourceName)
            Me._secondSourceDatas.Add(nView6.PrePostData)
            Me._arrCombinedFields.Add(nView6.Fields)
            If (nView6.StatusRecordAdd = 1) Then
                Me._statusready = 1
            End If
        End If
        If (nView7 IsNot Nothing) Then
            Me._secondSourceNames.Add(nView7.DataSourceName)
            Me._secondSourceDatas.Add(nView7.PrePostData)
            Me._arrCombinedFields.Add(nView7.Fields)
            If (nView7.StatusRecordAdd = 1) Then
                Me._statusready = 1
            End If
        End If
    End Sub

    Public Sub Delete()
        If (Me.DataSourceType = 0) Then
            If (Me._statusready = 0) Then
                Try
                    DBAccess.BeginTransaction()
                    For i As Integer = 0 To _secondSourceNames.Count - 1
                        Dim tblname As String = _secondSourceNames(i).ToString()
                        Dim item As DataTable = _secondSourceDatas(i)
                        Dim mFields As List(Of DBField) = _arrCombinedFields(i)
                        If (item.Rows.Count > 0) Then
                            For j As Integer = 0 To item.Rows.Count - 1
                                Dim wherestatement As String = ""
                                For k As Integer = 0 To item.Columns.Count - 1
                                    If mFields(k).IsPrimary = True Then
                                        wherestatement = wherestatement + item.Columns(k).ColumnName.ToUpper() + "=? and "
                                    End If
                                Next


                                wherestatement = wherestatement.Substring(0, wherestatement.Length - 5)
                                Dim cmd As New OleDbCommand With
                                {
                                    .CommandText = "DELETE FROM " + tblname + " where " + wherestatement
                                }
                                For k As Integer = 0 To item.Columns.Count - 1
                                    If mFields(k).IsPrimary = True Then
                                        cmd.Parameters.AddWithValue("@" + mFields(k).ID.ToUpper(), item.Rows(j)(k))
                                    End If
                                Next
                                DBAccess.RunDML(cmd)
                            Next

                        End If
                    Next
                    DBAccess.Commit()
                    Me._posterror = 0
                Catch exception As System.Exception
                    DBAccess.RollBack()
                    Me._posterror = 1
                End Try
            End If
        End If
    End Sub

    Public Sub EndDelete()
        Me._commandtype = 4
    End Sub

    Public Sub EndFilter()
        Me._commandtype = 4
    End Sub

    Public Sub EndInsert()
        Me._commandtype = 4
    End Sub

    Public Sub EndUpdate()
        Me._commandtype = 4
    End Sub

    Public Sub Filter()
        Dim d As String()
        Dim str As String = ""
        Dim count As Integer = Me._ToFilterByFields.Count - 1
        Dim num As Integer = 0

        Do
            d = New String() {str, Me._ToFilterByFields(num).ID, "='", Me._ToFilterByFields(num).FieldValue.ToString().Trim(), "' AND "}
            str = String.Concat(d)
            num = num + 1
        Loop While num <= count
        str = str.Substring(0, str.Length - 5)
        Dim str1 As String = ""
        Me._tblRecords = New DataTable()
        Dim count1 As Integer = Me.Fields.Count - 1
        Dim num1 As Integer = 0
        Do
            str1 = If(Not (Me.Fields(num1).ID.Contains("DESC") Or Fields(num1).ID.Contains("VALUES") Or Fields(num1).ID.Contains("LOCATION")), String.Concat(str1, Me.Fields(num1).ID, ", "), String.Concat(str1, "[", Me.Fields(num1).ID, "], "))
            Me._tblRecords.Columns.Add(Me.Fields(num1).ID)
            num1 = num1 + 1
        Loop While num1 <= count1
        str1 = str1.Substring(0, str1.Length - 2)
        d = New String() {"select ", str1, " from ", Me.DataSourceName, " where ", str}
        Dim str2 As String = String.Concat(d)
        Me._tblRecords = DBAccess.SelectFields(str2)

        If _tblRecords.Rows.Count - 1 < _selectedRecordIndex Then
            _selectedRecordIndex = 0
        End If
    End Sub

    Public Sub Filter(ByVal FilterString As String)
        Dim str As String = ""
        Me._tblRecords = New DataTable()
        Dim count As Integer = Me.Fields.Count - 1
        Dim num As Integer = 0
        Do
            str = If(Not (Me.Fields(num).ID.Contains("DESC") Or Fields(num).ID.Contains("VALUES") Or Fields(num).ID.Contains("LOCATION")), String.Concat(str, Me.Fields(num).ID, ", "), String.Concat(str, "[", Me.Fields(num).ID, "], "))
            Me._tblRecords.Columns.Add(Me.Fields(num).ID)
            num = num + 1
        Loop While num <= count
        str = str.Substring(0, str.Length - 2)
        Dim str1 As String = ""
        If (FilterString.Trim().Length <= 0) Then
            str1 = String.Concat("select ", str, " from ", Me.DataSourceName)
        Else
            Dim dataSourceName() As String = {"select ", str, " from ", Me.DataSourceName, " where ", FilterString}
            str1 = String.Concat(dataSourceName)
        End If
        Me._tblRecords = DBAccess.SelectFields(str1)

        If _tblRecords.Rows.Count - 1 < _selectedRecordIndex Then
            _selectedRecordIndex = 0
        End If
    End Sub

    Public Function GetFieldByID(ByVal vFieldID As String) As DBField
        Dim field As New DBField
        For i As Integer = 0 To _vFields.Count - 1
            If _vFields(i).ID = vFieldID Then
                field = _vFields(i)
                Exit For
            End If
        Next
        Return field
    End Function

    Public Function GetFieldTypeByID(ByVal vFieldID As String) As String
        Dim str As String
        Dim num As Integer = 0
        If (Me._tblRecords.Rows.Count <= 0) Then
            str = "1"
        Else
            Dim count As Integer = Me.Fields.Count - 1
            Dim num1 As Integer = 0
            While num1 <= count
                If (vFieldID <> Fields(num1).ID) Then
                    num1 = num1 + 1
                Else
                    num = num1
                    Exit While
                End If
            End While
            str = Me.Fields(num).DataType
        End If
        Return str
    End Function

    Public Function GetFieldValueByID(ByVal vFieldID As String) As Object
        Dim item As Object
        Dim num As Integer = 0
        Dim bitmap As Image
        If (Me._tblRecords.Rows.Count <= 0) Then
            item = VariantType.Null
        Else
            Dim count As Integer = Me.Fields.Count - 1
            Dim num1 As Integer = 0
            While num1 <= count
                If (vFieldID <> Me.Fields(num1).ID) Then
                    num1 = num1 + 1
                Else
                    num = num1
                    Exit While
                End If
            End While
            If (Fields(num).DataType = "Image") Then
                Dim numArray As Byte() = DirectCast(Me._tblRecords.Rows(Me._selectedRecordIndex)(num), Byte())
                Using memoryStream As System.IO.MemoryStream = New System.IO.MemoryStream(numArray, 0, CInt(numArray.Length))
                    memoryStream.Write(numArray, 0, CInt(numArray.Length))
                    bitmap = New System.Drawing.Bitmap(Image.FromStream(memoryStream, True))
                End Using
                item = bitmap
            ElseIf (Not (Fields(num).DataType = "char" Or Fields(num).DataType = "nchar" Or Fields(num).DataType = "nvarchar")) Then
                item = Me._tblRecords.Rows(Me._selectedRecordIndex)(num)
            Else
                item = Me._tblRecords.Rows(Me._selectedRecordIndex)(num).ToString().Trim()
            End If
        End If
        Return item
    End Function

    Public Sub Init()
        Me._statusready = 0
        Me._statusrecordadd = 0
        Me._tblPrePost = New DataTable
        Me._tblPreAdd = New DataTable
        Dim str As String = ""
        For i As Integer = 0 To Fields.Count - 1
            If Fields(i).ID = "DESC" Or Fields(i).ID = "VALUES" Or Fields(i).ID = "LOCATION" Or Fields(i).ID = "LINENO" Then
                str = str + "[" + Fields(i).ID + "], "
            Else
                str = str + Fields(i).ID + ", "
            End If
        Next
        str = str.Substring(0, str.Length - 2)
        _tblPreAdd = DBAccess.SelectFields("select " + str + " from " + DataSourceName + " where 0=1")
        _tblPrePost = DBAccess.SelectFields("select " + str + " from " + DataSourceName + " where 0=1")
        _tblRecords = DBAccess.SelectFields("select " + str + " from " + DataSourceName + " where 0=1")

        Me._ToFilterByFields.Clear()
        Me._ToBeUpdatedFields.Clear()
        Me._MasterFields.Clear()
        Me._AddedFields.Clear()
        Me._addedrequiredcount = 0
        Me._secondSourceDatas.Clear()
        Me._secondSourceNames.Clear()
        Me._arrCombinedFields.Clear()
    End Sub

    Public Sub InitDelete()
        Me._commandtype = 2
    End Sub

    Public Sub InitFilter()
        Me._commandtype = 3
    End Sub

    Public Sub InitInsert()
        Me._commandtype = 0
    End Sub

    Public Sub InitUpdate()
        Me._commandtype = 1
    End Sub

    Public Sub Insert()
        If (Me.DataSourceType = 0) Then
            If (Me._statusready = 0) Then
                Try
                    DBAccess.BeginTransaction()
                    For i As Integer = 0 To _secondSourceNames.Count - 1
                        Dim tblname As String = _secondSourceNames(i).ToString.Trim()
                        Dim item As DataTable = _secondSourceDatas(i)
                        Dim mFields As List(Of DBField) = _arrCombinedFields(i)
                        Dim fiellist As String = ""
                        Dim valuelist As String = ""
                        If item.Rows.Count > 0 Then

                            For j As Integer = 0 To mFields.Count - 1
                                If mFields(j).ValueIsNull = False Then
                                    fiellist = fiellist + mFields(j).ID.ToUpper() + ", "
                                    valuelist = valuelist + "?, "
                                End If
                            Next

                            fiellist = fiellist.Substring(0, fiellist.Length - 2)
                            valuelist = valuelist.Substring(0, valuelist.Length - 2)


                            For j As Integer = 0 To item.Rows.Count - 1
                                Dim sqlstatement As String = "INSERT INTO " + tblname + " (" + fiellist + ") values (" + valuelist + ")"
                                Dim cmd As New OleDbCommand(sqlstatement)

                                For k As Integer = 0 To mFields.Count - 1
                                    If mFields(k).ValueIsNull = False Then
                                        cmd.Parameters.AddWithValue("@" + mFields(k).ID.ToUpper(), item(j)(k))
                                    End If

                                Next

                                DBAccess.RunDML(cmd)
                                cmd.Parameters.Clear()
                                cmd = Nothing
                            Next
                        End If
                    Next
                    DBAccess.Commit()
                    Me._posterror = 0
                Catch exception As System.Exception
                    DBAccess.RollBack()
                    Me._posterror = 1
                End Try
            End If
        End If
    End Sub

    Public Sub MoveFirst()
        If (Me._tblRecords.Rows.Count > 0) Then
            Me._selectedRecordIndex = 0
        End If
    End Sub

    Public Sub MoveLast()
        If (Me._tblRecords.Rows.Count > 0) Then
            Me._selectedRecordIndex = Me._tblRecords.Rows.Count - 1
        End If
    End Sub


    Public Sub MoveNext()
        If (Me._tblRecords.Rows.Count > 0) Then
            If (Me._selectedRecordIndex < Me._tblRecords.Rows.Count - 1) Then
                Me._selectedRecordIndex = Me._selectedRecordIndex + 1
            End If
        End If
    End Sub

    Public Sub MovePrevious()
        If (Me._tblRecords.Rows.Count > 0) Then
            If (Me._selectedRecordIndex > 0) Then
                Me._selectedRecordIndex = Me._selectedRecordIndex - 1
            End If
        End If
    End Sub

    Public Sub Read()
        Dim str As String = ""
        For i As Integer = 0 To Fields.Count - 1
            If Fields(i).ID = "DESC" Or Fields(i).ID = "VALUES" Or Fields(i).ID = "LOCATION" Or Fields(i).ID = "LINENO" Then
                str = str + "[" + Fields(i).ID + "], "
            Else
                str = str + Fields(i).ID + ", "
            End If
        Next



        str = str.Substring(0, str.Length - 2)
        Dim str1 As String = String.Concat("select ", str, " from ", Me._vDataSourceName)
        Me._tblRecords = DBAccess.SelectFields(str1)

        If (Me._selectedRecordIndex > Me._tblRecords.Rows.Count - 1) Then
            Me._selectedRecordIndex = Me._tblRecords.Rows.Count - 1
        End If
        Me._commandtype = 4
    End Sub

    Public Sub RecordAdd()
        Dim d As String()
        If (Me._commandtype = 0) Then
            If (_MasterFields.Count <> _PrimaryFields.Count) Then
                Interaction.MsgBox("Required fields are missing! This will make your record failed.", MsgBoxStyle.OkOnly, Nothing)
                Me._statusrecordadd = 1
            Else
                Me._tblPreAdd.Rows.Add(New Object(0) {})
                For i As Integer = 0 To _AddedFields.Count - 1
                    'Dim ind As Integer = _AddedFields(i).Index
                    'Dim ind As Integer = GetFieldByI
                    Dim colnam As String = _AddedFields(i).ID
                    _tblPreAdd.Rows(0)(colnam) = _AddedFields(i).FieldValue
                Next
                Me._tblPrePost.Rows.Add(New Object(0) {})
                Dim objectValue1 As Integer = Me._tblPrePost.Rows.Count - 1
                Dim count3 As Integer = Me._tblPrePost.Columns.Count - 1
                For i As Integer = 0 To count3
                    Me._tblPrePost.Rows(objectValue1)(i) = Me._tblPreAdd.Rows(0)(i)
                Next

            End If
        End If



        If (Me._commandtype = 1) Then
            If (Me._MasterFields.Count <> Me._PrimaryFields.Count) Then
                Me._statusrecordadd = 1
            Else
                Dim str As String = ""
                Dim num3 As Integer = Me._MasterFields.Count - 1
                Dim num4 As Integer = 0
                Do
                    d = New String() {str, Me._MasterFields(num4).ID, "='", Me._MasterFields(num4).FieldValue.ToString().Trim(), "' AND "}
                    str = String.Concat(d)
                    num4 = num4 + 1
                Loop While num4 <= num3
                str = str.Substring(0, str.Length - 5)
                Dim str1 As String = ""
                Dim count4 As Integer = Me.Fields.Count - 1
                Dim num5 As Integer = 0
                Do
                    str1 = String.Concat(str1, Me.Fields(num5).ID, ", ")
                    num5 = num5 + 1
                Loop While num5 <= count4
                str1 = str1.Substring(0, str1.Length - 2)
                d = New String() {"SELECT ", str1, " FROM ", Me.DataSourceName, " WHERE ", str}
                Dim str2 As String = String.Concat(d)
                Me._tblPreAdd = DBAccess.SelectFields(str2)




                Dim count6 As Integer = Me._ToBeUpdatedFields.Count - 1
                Dim objectValue2 As Integer = 0
                Do
                    Me._tblPreAdd.Rows(0)(Me._ToBeUpdatedFields(objectValue2).Index) = Me._ToBeUpdatedFields(objectValue2).FieldValue
                    objectValue2 = objectValue2 + 1
                Loop While objectValue2 <= count6
                Dim count7 As Integer = Me._MasterFields.Count - 1
                Dim objectValue3 As Integer = 0
                Do
                    Me._tblPreAdd.Rows(0)(Me._MasterFields(objectValue3).Index) = Me._MasterFields(objectValue3).FieldValue
                    objectValue3 = objectValue3 + 1
                Loop While objectValue3 <= count7
                Me._tblPrePost.Rows.Add(New Object(0) {})
                Dim objectValue4 As Integer = Me._tblPrePost.Rows.Count - 1
                Dim num7 As Integer = Me._tblPrePost.Columns.Count - 1
                For j As Integer = 0 To num7
                    Me._tblPrePost.Rows(objectValue4)(j) = Me._tblPreAdd.Rows(0)(j)
                Next

            End If
        End If
        If (Me._commandtype = 2) Then
            Dim str3 As String = ""
            Dim count8 As Integer = Me._MasterFields.Count - 1
            Dim num8 As Integer = 0
            Do
                d = New String() {str3, Me._MasterFields(num8).ID, "='", Me._MasterFields(num8).FieldValue.ToString().Trim(), "' AND "}
                str3 = String.Concat(d)
                num8 = num8 + 1
            Loop While num8 <= count8
            str3 = str3.Substring(0, str3.Length - 5)
            Dim str4 As String = ""
            Dim count9 As Integer = Me.Fields.Count - 1
            Dim num9 As Integer = 0
            Do
                str4 = String.Concat(str4, Me.Fields(num9).ID, ", ")
                num9 = num9 + 1
            Loop While num9 <= count9
            str4 = str4.Substring(0, str4.Length - 2)
            d = New String() {"SELECT ", str4, " FROM ", Me.DataSourceName, " WHERE ", str3}
            Dim str5 As String = String.Concat(d)
            Me._tblPreAdd = DBAccess.SelectFields(str5)
            If (Me._tblPreAdd.Rows.Count > 0) Then
                Dim count10 As Integer = Me._MasterFields.Count - 1
                Dim objectValue5 As Integer = 0
                Do
                    Me._tblPreAdd.Rows(0)(Me._MasterFields(objectValue5).Index) = Me._MasterFields(objectValue5).FieldValue
                    objectValue5 = objectValue5 + 1
                Loop While objectValue5 <= count10
                Me._tblPrePost.Rows.Add(New Object(0) {})
                Dim objectValue6 As Integer = Me._tblPrePost.Rows.Count - 1
                Dim num10 As Integer = Me._tblPrePost.Columns.Count - 1
                For k As Integer = 0 To num10
                    Me._tblPrePost.Rows(objectValue6)(k) = Me._tblPreAdd.Rows(0)(k)
                Next

            End If
        End If
        If (Me._commandtype = 3) Then
            If (Me._MasterFields.Count <> Me._PrimaryFields.Count) Then
                Me._statusrecordadd = 1
            Else
                Dim str6 As String = ""
                Dim count11 As Integer = Me.Fields.Count - 1
                Dim num11 As Integer = 0
                Do
                    str6 = String.Concat(str6, Me.Fields(num11).ID, ", ")
                    num11 = num11 + 1
                Loop While num11 <= count11
                str6 = str6.Substring(0, str6.Length - 2)
                Dim str7 As String = ""
                Dim count12 As Integer = Me._ToFilterByFields.Count - 1
                Dim num12 As Integer = 0
                Do
                    d = New String() {str7, Me._ToFilterByFields(num12).ID, "='", Me._ToFilterByFields(num12).FieldValue.ToString().Trim(), "' AND "}
                    str7 = String.Concat(d)
                    num12 = num12 + 1
                Loop While num12 <= count12
                str7 = str7.Substring(0, str7.Length - 5)
                d = New String() {"select ", str6, " from ", Me.DataSourceName, " where ", str7}
                Dim str8 As String = String.Concat(d)
                Me._tblPreAdd = DBAccess.SelectFields(str8)
                Dim count13 As Integer = Me._ToFilterByFields.Count - 1
                Dim objectValue7 As Integer = 0
                Do
                    Me._tblPreAdd.Rows(0)(Me._ToFilterByFields(objectValue7).Index) = Me._ToFilterByFields(objectValue7).FieldValue
                    objectValue7 = objectValue7 + 1
                Loop While objectValue7 <= count13
                Me._tblPrePost.Rows.Add(New Object(0) {})
                Dim objectValue8 As Integer = Me._tblPrePost.Rows.Count - 1
                Dim num13 As Integer = Me._tblPrePost.Columns.Count - 1
                For l As Integer = 0 To num13
                    Me._tblPrePost.Rows(objectValue8)(l) = Me._tblPreAdd.Rows(0)(l)
                Next

            End If
        End If
    End Sub

    Public Sub RecordClear()
        Me._tblPreAdd.Rows.Clear()
        Me._ToFilterByFields.Clear()
        Me._ToBeUpdatedFields.Clear()
        Me._MasterFields.Clear()
        Me._AddedFields.Clear()
        Me._addedrequiredcount = 0
    End Sub

    Public Sub SetFieldValue(ByVal vFieldID As String, ByVal vFieldValue As Object)
        Dim field As DBField = New DBField()
        field = Me.GetFieldByID(vFieldID)
        field.FieldValue = vFieldValue
        Me._AddedFields.Add(field)
        If (Not field.IsPrimary) Then
            Me._ToBeUpdatedFields.Add(field)
        Else
            Me._MasterFields.Add(field)
        End If
        Me._ToFilterByFields.Add(field)
        Fields(field.Index).ValueIsNull = False


    End Sub

    Public Sub Update()
        If (Me.DataSourceType = 0) Then
            If (Me._statusready = 0) Then
                Try
                    DBAccess.BeginTransaction()

                    For i As Integer = 0 To _secondSourceNames.Count - 1
                        Dim tblname As String = _secondSourceNames(i).ToString()
                        Dim item As DataTable = DirectCast(Me._secondSourceDatas(i), DataTable)
                        Dim mFields As List(Of DBField) = DirectCast(Me._arrCombinedFields(i), List(Of DBField))
                        If (item.Rows.Count > 0) Then
                            For j As Integer = 0 To item.Rows.Count - 1
                                Dim wherestatement As String = ""
                                Dim cmd As New OleDbCommand
                                For k As Integer = 0 To mFields.Count - 1
                                    If mFields(k).IsPrimary = True Then
                                        wherestatement = wherestatement + mFields(k).ID + "=? and "
                                    End If
                                Next
                                wherestatement = wherestatement.Substring(0, wherestatement.Length - 5)

                                Dim setstatement As String = ""

                                For k As Integer = 0 To mFields.Count - 1
                                    If mFields(k).IsPrimary = False And mFields(k).ValueIsNull = False Then
                                        setstatement = setstatement + item.Columns(k).ColumnName.ToUpper() + "=?, "
                                    End If
                                Next
                                setstatement = setstatement.Substring(0, setstatement.Length - 2)
                                cmd.CommandText = "UPDATE " + tblname + " SET " + setstatement + " WHERE " + wherestatement
                                For k As Integer = 0 To mFields.Count - 1
                                    If mFields(k).IsPrimary = False And mFields(k).ValueIsNull = False Then
                                        cmd.Parameters.AddWithValue(String.Concat("@", mFields(k).ID), item.Rows(j)(k))
                                    End If
                                Next


                                For k As Integer = 0 To mFields.Count - 1
                                    If (mFields(k).IsPrimary) Then
                                        cmd.Parameters.AddWithValue(String.Concat("@", mFields(k).ID), item.Rows(j)(k))
                                    End If
                                Next
                                DBAccess.RunDML(cmd)
                            Next
                        End If
                    Next




                    DBAccess.Commit()
                    Me._posterror = 0
                Catch exception As System.Exception

                    DBAccess.RollBack()
                    Me._posterror = 1
                End Try
            End If
        End If
    End Sub


    Public Function ValueIsExist(ByVal fieldname As String, ByVal fieldvalue As String) As Boolean
        Dim exist As Boolean = False
        If _tblRecords.Rows.Count > 0 Then
            For i As Integer = 0 To _tblRecords.Rows.Count - 1
                If _tblRecords.Rows(i)(fieldname).ToString.Trim() = fieldvalue Then
                    _selectedRecordIndex = i
                    exist = True
                    Exit For
                End If
            Next
        End If

        Return exist
    End Function
End Class
