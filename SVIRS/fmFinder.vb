Imports System.Collections

Public Class fmFinder

    Private _view As View
    Private _tblFields As DataTable
    Private _targettextedit As DevExpress.XtraEditors.TextEdit
    Private _targetgridview As DevExpress.XtraGrid.Views.Grid.GridView
    Private _targettype As Integer
    Private _arrFilterFiels As New ArrayList
    Private _arrFilterValues As New ArrayList
    Private _filterstr As String
    Private symbolic As Array
    Private _returnfield As String = ""



    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _targettextedit = New DevExpress.XtraEditors.TextEdit()
        _targetgridview = New DevExpress.XtraGrid.Views.Grid.GridView()
        _arrFilterFiels = New ArrayList()
        _arrFilterValues = New ArrayList()
        _tblFields = New DataTable()
        _tblFields.Columns.Add("ID")
        _tblFields.Columns.Add("NAME")
        _tblFields.Columns.Add("SIZE")
        _tblFields.Columns.Add("TYPE")
        _view = New View()
        _arrFilterFiels = New ArrayList()
        _arrFilterValues = New ArrayList()
        cmbtruefalse.Properties.Items.Clear()
        _filterstr = ""

    End Sub


    Public Enum Type
        DateAndTime
        Number
        Text
        TrueFalse
    End Enum

    Public WriteOnly Property Caption As String
        Set(ByVal value As String)
            Text = value
        End Set
    End Property
    Public WriteOnly Property TargetGridView As DevExpress.XtraGrid.Views.Grid.GridView
        Set(ByVal value As DevExpress.XtraGrid.Views.Grid.GridView)
            _targetgridview = value
            _targettype = 1
        End Set
    End Property

    Public WriteOnly Property TargetTextEdit As DevExpress.XtraEditors.TextEdit
        Set(ByVal value As DevExpress.XtraEditors.TextEdit)
            _targettextedit = value
            _targettype = 0
        End Set
    End Property

    Public Property ReturnField As String
        Set(value As String)
            _returnfield = value
        End Set
        Get
            Return _returnfield
        End Get
    End Property
    Public Sub SetViewID(ByVal Id As String, ByVal SourceType As Integer)

        _view = OpenView(Id, SourceType)


        For i As Integer = 0 To _view.Fields.Count - 1
            If _view.Fields(i).Searchable = True Then
                Dim rows As DataRowCollection = _tblFields.Rows
                Dim objArray() As Object = {_view.Fields(i).ID, _view.Fields(i).Name, _view.Fields(i).FieldWidth, _view.Fields(i).FieldType}
                rows.Add(objArray)

            End If

        Next
        lstFields.Properties.DataSource = _tblFields

    End Sub

    Public Sub AddFields(ByVal FieldID As String, ByVal FieldName As String, ByVal FieldSize As Integer, ByVal FieldType As fmFinder.Type)
        Dim rows As DataRowCollection = _tblFields.Rows
        Dim objArray() As Object = {FieldID, FieldName, FieldSize, FieldType}
        rows.Add(objArray)
        lstFields.Properties.DataSource = _tblFields
    End Sub

    Public Sub AddFilterFields(ByVal FieldID As String, ByVal FieldValue As Object)
        _arrFilterFiels.Add(FieldID)
        _arrFilterValues.Add(FieldValue)
    End Sub
    Public Sub SetFilter(ByVal FilterString As String)
        _filterstr = FilterString
    End Sub
    Public Sub ShowFinder()

        GridView1.Columns.Clear()

        For i As Integer = 0 To _view.Fields.Count - 1

            Dim mycol As New DevExpress.XtraGrid.Columns.GridColumn()

            mycol.FieldName = _view.Fields(i).ID
            mycol.Name = "col" + _view.Fields(i).ID
            mycol.Width = _view.Fields(i).FieldWidth
            mycol.OptionsColumn.AllowEdit = False
            mycol.Visible = _view.Fields(i).Searchable
            mycol.Caption = _view.Fields(i).Name

            GridView1.Columns.Add(mycol)


            'GridView1.Columns(i).Visible = _view.Fields(i).Searchable


        Next

        Dim filterstring As String = ""
        For i As Integer = 0 To _arrFilterFiels.Count - 1
            filterstring = filterstring + _arrFilterFiels(i).ToString.Trim() + "='" + _arrFilterValues(i).ToString.Trim() + "' and "
        Next
        Try
            filterstring = filterstring.Substring(0, filterstring.Length - 5)
        Catch ex As Exception

        End Try

        If _filterstr.Length > 0 Then
            filterstring = filterstring + If(filterstring.Length > 0, " and ", "") + _filterstr
        End If
        If filterstring.Length > 0 Then
            _view.Init()
            _view.InitFilter()
            _view.Filter(filterstring)
            _view.EndFilter()
        Else
            _view.Init()
            _view.Read()
        End If



        dgFind.DataSource = _view.BoundData
        Try
            If IsNothing(_targettextedit) = False Then
                For i As Integer = 0 To GridView1.RowCount - 1

                    If GridView1.GetRowCellValue(i, _returnfield).ToString.Trim().StartsWith(_targettextedit.EditValue.ToString.Trim()) Then
                        GridView1.FocusedRowHandle = i
                        GridView1.TopRowIndex = i
                        Exit For
                    End If
                Next
            End If

            If IsNothing(_targetgridview) = False Then
                For i As Integer = 0 To GridView1.RowCount - 1
                    If GridView1.GetRowCellValue(i, _returnfield).ToString.Trim().StartsWith(_targetgridview.GetRowCellValue(_targetgridview.FocusedRowHandle, _targetgridview.FocusedColumn.FieldName)) Then
                        GridView1.FocusedRowHandle = i
                        GridView1.TopRowIndex = i
                        Exit For
                    End If
                Next
            End If
        Catch ex As Exception

        End Try





        ShowDialog()
    End Sub


    Private Sub frmFinder_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lstFields.EditValue = _view.Fields(0).ID
    End Sub


    Private Sub lstFields_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles lstFields.EditValueChanged
        Dim point As System.Drawing.Point
        Dim itemIndex As Integer = lstFields.ItemIndex
        Dim fieldtype As String = _tblFields.Rows(itemIndex)(3).ToString()
        Dim fieldname As String = _tblFields.Rows(itemIndex)(0).ToString.Trim()
        Dim f As DBField = _view.GetFieldByID(fieldname)

        If IsNothing(f.DropDownValue) = False Then
            lstdropdown.Location = New System.Drawing.Point(126, 76)
            spincriteria.Visible = False
            txtcriteria.Visible = False
            dtcriteria.Visible = False
            cmbtruefalse.Visible = False
            lstdropdown.Visible = True
            Try
                lstdropdown.Properties.DataSource = f.DropDownValue
                lstdropdown.EditValue = f.DropDownValue.Rows(0)(0).ToString.Trim
            Catch ex As Exception

            End Try
            cmbtruefalse.SelectedIndex = 0
            cmbOption.Properties.Items.Clear()
            cmbOption.Properties.Items.Add("=")
            cmbOption.Properties.Items.Add("!=")
            cmbOption.SelectedIndex = 0
            symbolic = {"=", "!="}
        Else
            If f.FieldType = "Date" Then
                dtcriteria.Location = New System.Drawing.Point(126, 76)
                dtcriteria.Visible = True
                txtcriteria.Visible = False
                spincriteria.Visible = False
                cmbtruefalse.Visible = False
                lstdropdown.Visible = False
                cmbOption.Properties.Items.Clear()
                cmbOption.Properties.Items.Add("After")
                cmbOption.Properties.Items.Add("After/On")
                cmbOption.Properties.Items.Add("Before")
                cmbOption.Properties.Items.Add("Before/On")
                cmbOption.Properties.Items.Add("On")
                cmbOption.Properties.Items.Add("Not On")
                cmbOption.SelectedIndex = 4
                symbolic = {">", ">=", "<", "<=", "=", "!="}
            ElseIf f.FieldType = "Number" Then
                Dim spinEdit As DevExpress.XtraEditors.SpinEdit = spincriteria
                point = New System.Drawing.Point(126, 76)
                spinEdit.Location = point
                spincriteria.Visible = True
                txtcriteria.Visible = False
                dtcriteria.Visible = False
                cmbtruefalse.Visible = False
                lstdropdown.Visible = False
                cmbOption.Properties.Items.Clear()
                cmbOption.Properties.Items.Add("Bigger than")
                cmbOption.Properties.Items.Add("Bigger than or equal")
                cmbOption.Properties.Items.Add("Less than")
                cmbOption.Properties.Items.Add("Less than or equal")
                cmbOption.Properties.Items.Add("Equal")
                cmbOption.Properties.Items.Add("Not equal")
                cmbOption.SelectedIndex = 4
                symbolic = {">", ">=", "<", "<=", "=", "!="}
            ElseIf f.FieldType = "Text" Then
                Dim textEdit As DevExpress.XtraEditors.TextEdit = txtcriteria
                point = New System.Drawing.Point(126, 76)
                textEdit.Location = point
                spincriteria.Visible = False
                txtcriteria.Visible = True
                dtcriteria.Visible = False
                cmbtruefalse.Visible = False
                lstdropdown.Visible = False
                cmbOption.Properties.Items.Clear()
                cmbOption.Properties.Items.Add("Starting with")
                cmbOption.Properties.Items.Add("Ending with")
                cmbOption.Properties.Items.Add("Containing")
                cmbOption.Properties.Items.Add("Is exactly")
                cmbOption.Properties.Items.Add("Is not")
                cmbOption.SelectedIndex = 0

            
            Else
                cmbtruefalse.Location = New System.Drawing.Point(126, 76)
                spincriteria.Visible = False
                txtcriteria.Visible = False
                dtcriteria.Visible = False
                lstdropdown.Visible = False
                cmbtruefalse.Visible = True
                cmbtruefalse.Properties.Items.Clear()
                cmbtruefalse.Properties.Items.Add(True)
                cmbtruefalse.Properties.Items.Add(False)
                cmbtruefalse.SelectedIndex = 0
                cmbOption.Properties.Items.Clear()
                cmbOption.Properties.Items.Add("=")
                cmbOption.SelectedIndex = 0
                symbolic = {"="}

            End If

        End If


    End Sub


    Private Sub cmbOption_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbOption.SelectedIndexChanged
        Try
            Dim fieltype As String = _tblFields.Rows(lstFields.ItemIndex)(3).ToString()
            If fieltype = "Date" Then
                Call dtcriteria_EditValueChanged(Nothing, Nothing)
            ElseIf fieltype = "Number" Then
                Call spincriteria_EditValueChanged(Nothing, Nothing)
            ElseIf fieltype = "Text" Then
                Call txtcriteria_EditValueChanged(Nothing, Nothing)
            ElseIf fieltype = "Boolean" Then
                cmbtruefalse_SelectedIndexChanged(Nothing, Nothing)
            Else
                lstdropdown_EditValueChanged(Nothing, Nothing)
            End If
        Catch ex As Exception

        End Try

    End Sub


    Private Sub cmdFind_Click(sender As System.Object, e As System.EventArgs) Handles cmdFind.Click
        Dim fieltype As String = _tblFields.Rows(lstFields.ItemIndex)(3).ToString()
        If fieltype = "Date" Then
            Try
                Dim filterstring As String = ""
                Dim fieldname As String = _tblFields.Rows(lstFields.ItemIndex)(0).ToString()
                Dim fieldvalue As String = If(_view.DataSourceType = 1, dtcriteria.DateTime.Date.ToString, dtcriteria.DateTime.Date.ToString("yyyyMMdd"))
                If cmbOption.SelectedIndex = 0 Then
                    filterstring = fieldname + ">'" + fieldvalue + "'"
                ElseIf cmbOption.SelectedIndex = 1 Then
                    filterstring = fieldname + ">='" + fieldvalue + "'"
                ElseIf cmbOption.SelectedIndex = 2 Then
                    filterstring = fieldname + "<'" + fieldvalue + "'"
                ElseIf cmbOption.SelectedIndex = 3 Then
                    filterstring = fieldname + "<='" + fieldvalue + "'"
                ElseIf cmbOption.SelectedIndex = 4 Then
                    filterstring = fieldname + "='" + fieldvalue + "'"
                Else
                    filterstring = fieldname + "!='" + fieldvalue + "'"
                End If

                For i As Integer = 0 To _arrFilterFiels.Count - 1
                    filterstring = " and " + _arrFilterFiels(i).ToString().Trim() + "='" + _arrFilterValues(i).ToString().Trim() + "'"
                Next

                If _filterstr.Length > 0 Then
                    filterstring = " and " + _filterstr
                End If
                _view.Init()
                _view.InitFilter()
                _view.Filter(filterstring)
                _view.EndFilter()
                dgFind.DataSource = _view.BoundData
            Catch ex As Exception

            End Try
        ElseIf fieltype = "Number" Then
            Dim str As String = ""
            If (_arrFilterFiels.Count > 0) Then
                Dim count As Integer = _arrFilterFiels.Count - 1
                Dim num As Integer = 0
                Do
                    str = str + _arrFilterFiels(num) + "='" + _arrFilterValues(num).ToString() + "' and "
                    num = num + 1
                Loop While num <= count
                str = String.Concat(" and ", str.Substring(0, str.Length - 5))
            End If
            Dim str1 As String = ""
            If (_filterstr.Trim().Length > 0) Then
                str1 = String.Concat(" and ", _filterstr)
            End If
            Dim strArrays() As String = {lstFields.EditValue.ToString().Trim(), " ", cmbOption.Text.Trim(), " ", Nothing, Nothing, Nothing}
            strArrays(4) = spincriteria.Value.ToString()
            strArrays(5) = str1
            strArrays(6) = str
            Dim str2 As String = String.Concat(strArrays)
            _view.Init()
            _view.InitFilter()
            _view.Filter(str2)
            _view.EndFilter()
            dgFind.DataSource = _view.BoundData
        ElseIf fieltype = "Text" Then
            Try
                Dim filterstring As String = ""
                Dim fieldname As String = _tblFields.Rows(lstFields.ItemIndex)(0).ToString()
                If fieldname = "DESC" Or fieldname = "LOCATION" Or fieldname = "VALUES" Or fieldname = "STATUS" Then
                    fieldname = "[" + fieldname + "]"
                End If
                If cmbOption.SelectedIndex = 0 Then
                    filterstring = fieldname + " LIKE '" + txtcriteria.EditValue.ToString().Trim() + "%'"
                ElseIf cmbOption.SelectedIndex = 1 Then
                    filterstring = fieldname + " LIKE '%" + txtcriteria.EditValue.ToString().Trim() + "'"
                ElseIf cmbOption.SelectedIndex = 2 Then
                    filterstring = fieldname + " LIKE '%" + txtcriteria.EditValue.ToString().Trim() + "%'"
                ElseIf cmbOption.SelectedIndex = 3 Then
                    filterstring = fieldname + " = '" + txtcriteria.EditValue.ToString().Trim() + "'"
                Else
                    filterstring = fieldname + " != '" + txtcriteria.EditValue.ToString().Trim() + "'"
                End If
                For i As Integer = 0 To _arrFilterFiels.Count - 1
                    filterstring = " and " + _arrFilterFiels(i).ToString().Trim() + "='" + _arrFilterValues(i).ToString().Trim() + "'"
                Next

                If _filterstr.Length > 0 Then
                    filterstring = " and " + _filterstr
                End If
                _view.Init()
                _view.InitFilter()
                _view.Filter(filterstring)
                _view.EndFilter()
                dgFind.DataSource = _view.BoundData

            Catch ex As Exception

            End Try
        ElseIf fieltype = "Boolean" Then
            Dim filterstring As String = ""
            If swAuto.Checked = True Then
                filterstring = lstFields.EditValue.ToString().Trim() + "='" + If(cmbtruefalse.SelectedIndex <> 0, "0", "1") + "' and "
                For i As Integer = 0 To _arrFilterFiels.Count - 1
                    filterstring = filterstring + _arrFilterFiels(i) + "='" + _arrFilterValues(i).ToString() + "' and "
                Next
                filterstring = filterstring.Substring(0, filterstring.Length - 5)
                If (_filterstr.Trim().Length > 0) Then
                    filterstring = filterstring + " and " + _filterstr
                End If
                _view.Init()
                _view.InitFilter()
                _view.Filter(filterstring)
                _view.EndFilter()
                dgFind.DataSource = _view.BoundData
            End If
        Else
            Try
                Dim filterstring As String = ""
                filterstring = lstFields.EditValue.ToString().Trim() + "='" + lstdropdown.EditValue.ToString.Trim() + "'"
                For i As Integer = 0 To _arrFilterFiels.Count - 1
                    filterstring = filterstring + " and " + _arrFilterFiels(i) + "='" + _arrFilterValues(i).ToString() + "'"
                Next

                If (_filterstr.Trim().Length > 0) Then
                    filterstring = filterstring + " and " + _filterstr
                End If
                _view.Init()
                _view.InitFilter()
                _view.Filter(filterstring)
                _view.EndFilter()
                dgFind.DataSource = _view.BoundData
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancel.Click
        Close()
    End Sub

    Private Sub cmdSelect_Click(sender As System.Object, e As System.EventArgs) Handles cmdSelect.Click
        Dim focusedRowHandle As Integer = GridView1.FocusedRowHandle
        If (_targettype <> 0) Then
            _targetgridview.SetRowCellValue(_targetgridview.FocusedRowHandle, _targetgridview.FocusedColumn, GridView1.GetRowCellValue(focusedRowHandle, _returnfield))
        Else
            Dim code As String = GridView1.GetRowCellValue(focusedRowHandle, _returnfield).ToString().Trim()
            _targettextedit.EditValue = code
        End If
        Close()
    End Sub

    Private Sub dgFind_DoubleClick(sender As System.Object, e As System.EventArgs) Handles dgFind.DoubleClick
        cmdSelect_Click(Nothing, Nothing)
    End Sub


    Private Sub spincriteria_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles spincriteria.EditValueChanged
        If (swAuto.Checked) Then
            Dim str As String = ""
            If (_arrFilterFiels.Count > 0) Then
                Dim count As Integer = _arrFilterFiels.Count - 1
                Dim num As Integer = 0
                Do
                    str = str + _arrFilterFiels(num) + "='" + _arrFilterValues(num).ToString() + "' and "
                    num = num + 1
                Loop While num <= count
                str = String.Concat(" and ", str.Substring(0, str.Length - 5))
            End If
            Dim str1 As String = ""
            If (_filterstr.Trim().Length > 0) Then
                str1 = String.Concat(" and ", _filterstr)
            End If
            Dim strArrays() As String = {lstFields.EditValue.ToString().Trim(), " ", symbolic(cmbOption.SelectedIndex), " ", Nothing, Nothing, Nothing}
            strArrays(4) = spincriteria.Value.ToString()
            strArrays(5) = str1
            strArrays(6) = str
            Dim str2 As String = String.Concat(strArrays)
            _view.Init()
            _view.InitFilter()
            _view.Filter(str2)
            _view.EndFilter()
            dgFind.DataSource = _view.BoundData
        End If
    End Sub

    Private Sub txtcriteria_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtcriteria.EditValueChanged
        If swAuto.Checked = True Then
            Try
                Dim filterstring As String = ""
                Dim fieldname As String = _tblFields.Rows(lstFields.ItemIndex)(0).ToString()
                If fieldname = "DESC" Or fieldname = "LOCATION" Or fieldname = "VALUES" Or fieldname = "STATUS" Then
                    fieldname = "[" + fieldname + "]"
                End If
                If cmbOption.SelectedIndex = 0 Then
                    filterstring = fieldname + " LIKE '" + txtcriteria.EditValue.ToString().Trim() + "%'"
                ElseIf cmbOption.SelectedIndex = 1 Then
                    filterstring = fieldname + " LIKE '%" + txtcriteria.EditValue.ToString().Trim() + "'"
                ElseIf cmbOption.SelectedIndex = 2 Then
                    filterstring = fieldname + " LIKE '%" + txtcriteria.EditValue.ToString().Trim() + "%'"
                ElseIf cmbOption.SelectedIndex = 3 Then
                    filterstring = fieldname + " = '" + txtcriteria.EditValue.ToString().Trim() + "'"
                Else
                    filterstring = fieldname + " != '" + txtcriteria.EditValue.ToString().Trim() + "'"
                End If
                For i As Integer = 0 To _arrFilterFiels.Count - 1
                    filterstring = filterstring + " and " + _arrFilterFiels(i).ToString().Trim() + "='" + _arrFilterValues(i).ToString().Trim() + "'"
                Next

                If _filterstr.Length > 0 Then
                    filterstring = filterstring + " and " + _filterstr
                End If
                _view.Init()
                _view.InitFilter()
                _view.Filter(filterstring)
                _view.EndFilter()
                dgFind.DataSource = _view.BoundData

            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub lstdropdown_EditValueChanged(sender As Object, e As EventArgs) Handles lstdropdown.EditValueChanged

        If swAuto.Checked = True Then
            Try
                Dim filterstring As String = ""

                Dim a As String = symbolic(0)

                filterstring = lstFields.EditValue.ToString().Trim() + symbolic(cmbOption.SelectedIndex) + "'" + lstdropdown.EditValue.ToString.Trim() + "'"
                For i As Integer = 0 To _arrFilterFiels.Count - 1
                    filterstring = filterstring + " and " + _arrFilterFiels(i) + "='" + _arrFilterValues(i).ToString() + "'"
                Next

                If (_filterstr.Trim().Length > 0) Then
                    filterstring = filterstring + " and " + _filterstr
                End If
                _view.Init()
                _view.InitFilter()
                _view.Filter(filterstring)
                _view.EndFilter()
                dgFind.DataSource = _view.BoundData
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub cmbtruefalse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtruefalse.SelectedIndexChanged
        Dim filterstring As String = ""
        If swAuto.Checked = True Then
            filterstring = lstFields.EditValue.ToString().Trim() + "='" + If(cmbtruefalse.SelectedIndex <> 0, "0", "1") + "' and "
            For i As Integer = 0 To _arrFilterFiels.Count - 1
                filterstring = filterstring + _arrFilterFiels(i) + "='" + _arrFilterValues(i).ToString() + "' and "
            Next
            filterstring = filterstring.Substring(0, filterstring.Length - 5)
            If (_filterstr.Trim().Length > 0) Then
                filterstring = filterstring + " and " + _filterstr
            End If
            _view.Init()
            _view.InitFilter()
            _view.Filter(filterstring)
            _view.EndFilter()
            dgFind.DataSource = _view.BoundData
        End If
    End Sub

    Private Sub dtcriteria_EditValueChanged(sender As Object, e As EventArgs) Handles dtcriteria.EditValueChanged
        If swAuto.Checked = True Then
            Try
                Dim filterstring As String = ""
                Dim fieldname As String = _tblFields.Rows(lstFields.ItemIndex)(0).ToString()
                Dim fieldvalue As String = If(_view.DataSourceType = 1, dtcriteria.DateTime.Date.ToString, dtcriteria.DateTime.Date.ToString("yyyyMMdd"))
                If cmbOption.SelectedIndex = 0 Then
                    filterstring = fieldname + ">'" + fieldvalue + "'"
                ElseIf cmbOption.SelectedIndex = 1 Then
                    filterstring = fieldname + ">='" + fieldvalue + "'"
                ElseIf cmbOption.SelectedIndex = 2 Then
                    filterstring = fieldname + "<'" + fieldvalue + "'"
                ElseIf cmbOption.SelectedIndex = 3 Then
                    filterstring = fieldname + "<='" + fieldvalue + "'"
                ElseIf cmbOption.SelectedIndex = 4 Then
                    filterstring = fieldname + "='" + fieldvalue + "'"
                Else
                    filterstring = fieldname + "!='" + fieldvalue + "'"
                End If

                For i As Integer = 0 To _arrFilterFiels.Count - 1
                    filterstring = filterstring + " and " + _arrFilterFiels(i).ToString().Trim() + "='" + _arrFilterValues(i).ToString().Trim() + "'"
                Next

                If _filterstr.Length > 0 Then
                    filterstring = " and " + _filterstr
                End If
                _view.Init()
                _view.InitFilter()
                _view.Filter(filterstring)
                _view.EndFilter()
                dgFind.DataSource = _view.BoundData




            Catch ex As Exception

            End Try
        End If
    End Sub
End Class