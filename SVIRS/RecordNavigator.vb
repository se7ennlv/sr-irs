Public Class RecordNavigator
    Private _newhide As Boolean = False
    Private _savehide As Boolean = False
    Private _deletehide As Boolean = False
    Private _printhide As Boolean = False
    Private _importhide As Boolean = False
    Private _exporthide As Boolean = False
    Private _displayviewid As String = ""
    Private _dataviewlist As String = ""
    Private _returnfiled As String = ""
    Private _filtercmd As String = ""
    Private _findertext As String = ""
    Private _curvalue As String
    Private v As View
    Private _isnew As Boolean = True
    Dim srcentry As Integer = -1
    Private _reportname As String = ""
    Private _directprint As Boolean = False
    Private _navhide As Boolean = False
    Private _sourcetype As Integer = 0

    Public Event RecordIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
    Public Event EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
    Public Event NewRecordFired(ByVal sender As Object, ByVal e As EventArgs)
    Public Event SaveRecordFired(ByVal sender As Object, ByVal e As EventArgs)
    Public Event DeleteRecordFired(ByVal sender As Object, ByVal e As EventArgs)
    Public Event PrintRecordFired(ByVal sender As Object, ByVal e As EventArgs)
    Public Event ImportRecordFired(ByVal sender As Object, ByVal e As EventArgs)
    Public Event ExportRecordFired(ByVal sender As Object, ByVal e As EventArgs)


    Public Sub RoleValidate()

    End Sub
    Public Sub RefreshView()
        v = OpenView(_displayviewid, _sourcetype)
    End Sub


    Public Property MaxLength As Integer
        Set(value As Integer)
            txtCode.Properties.MaxLength = value
        End Set
        Get
            Return txtCode.Properties.MaxLength
        End Get
    End Property

    Public Property SourceType As Integer
        Set(value As Integer)
            _sourcetype = value
        End Set
        Get
            Return _sourcetype
        End Get
    End Property
    Public ReadOnly Property IsNewItem As Boolean
        Get
            Return _isnew
        End Get
    End Property


    Public ReadOnly Property CurrentView As View
        Get
            Return v
        End Get
    End Property
    Public Property CurrentValue As String
        Set(value As String)
            _curvalue = value
            srcentry = 1
            txtCode.EditValue = value

        End Set
        Get
            Return _curvalue
        End Get
    End Property

    Public Property NavigatorHide As Boolean
        Get
            Return _navhide
        End Get
        Set(value As Boolean)
            _navhide = value
            If _navhide = True Then
                cmdFirst.Hide()
                cmdPrev.Hide()
                cmdNext.Hide()
                cmdLast.Hide()
            Else
                cmdFirst.Show()
                cmdPrev.Show()
                cmdNext.Show()
                cmdLast.Show()
            End If
        End Set
    End Property

    Public Property NewButtonHide As Boolean
        Set(value As Boolean)
            _newhide = value
            If value = True Then cmdNew.Hide() Else cmdNew.Show()
        End Set
        Get
            Return _newhide
        End Get
    End Property
    Public Property SaveButtonHide As Boolean
        Set(value As Boolean)
            _savehide = value
            If value = True Then cmdSave.Hide() Else cmdSave.Show()
        End Set
        Get
            Return _savehide
        End Get
    End Property

    Public Property ReportName As String
        Get
            Return _reportname
        End Get
        Set(value As String)
            _reportname = value
        End Set
    End Property

    Public Property ReportDirectPrint As Boolean
        Get
            Return _directprint
        End Get
        Set(value As Boolean)
            _directprint = value
        End Set
    End Property
    Public Property DeleteButtonHide As Boolean
        Set(value As Boolean)
            _deletehide = value
            If value = True Then cmdDelete.Hide() Else cmdDelete.Show()
        End Set
        Get
            Return _deletehide
        End Get
    End Property
    Public Property PrintButtonHide As Boolean
        Set(value As Boolean)
            _printhide = value
            If value = True Then cmdPrint.Hide() Else cmdPrint.Show()
        End Set
        Get
            Return _printhide
        End Get
    End Property


    Public Property FirstButtonToolTip As String
        Set(value As String)
            cmdFirst.ToolTip = value
        End Set
        Get
            Return cmdFirst.ToolTip
        End Get
    End Property
    Public Property PreviousButtonToolTip As String
        Set(value As String)
            cmdPrev.ToolTip = value
        End Set
        Get
            Return cmdPrev.ToolTip
        End Get
    End Property
    Public Property NextButtonToolTip As String
        Set(value As String)
            cmdNext.ToolTip = value
        End Set
        Get
            Return cmdNext.ToolTip
        End Get
    End Property
    Public Property LastButtonToolTip As String
        Set(value As String)
            cmdLast.ToolTip = value
        End Set
        Get
            Return cmdLast.ToolTip
        End Get
    End Property
    Public Property FindButtonToolTip As String
        Set(value As String)
            cmdFind.ToolTip = value
        End Set
        Get
            Return cmdFind.ToolTip
        End Get
    End Property
    Public Property NewButtonToolTip As String
        Set(value As String)
            cmdNew.ToolTip = value
        End Set
        Get
            Return cmdNew.ToolTip
        End Get
    End Property
    Public Property SaveButtonToolTip As String
        Set(value As String)
            cmdSave.ToolTip = value
        End Set
        Get
            Return cmdSave.ToolTip
        End Get
    End Property
    Public Property DeleteButtonToolTip As String
        Set(value As String)
            cmdDelete.ToolTip = value
        End Set
        Get
            Return cmdDelete.ToolTip
        End Get
    End Property
    Public Property PrintButtonToolTip As String
        Set(value As String)
            cmdPrint.ToolTip = value
        End Set
        Get
            Return cmdPrint.ToolTip
        End Get
    End Property


    Public Property ViewID As String
        Set(value As String)
            _displayviewid = value
        End Set
        Get
            Return _displayviewid
        End Get
    End Property

    Public Property ReturnField As String
        Set(value As String)
            _returnfiled = value
        End Set
        Get
            Return _returnfiled
        End Get
    End Property
    Public Property DataViewList As String
        Set(value As String)
            _dataviewlist = value
        End Set
        Get
            Return _dataviewlist
        End Get
    End Property
    Public Property FilsterString As String
        Set(value As String)
            _filtercmd = value
        End Set
        Get
            Return _filtercmd
        End Get
    End Property
    Public Property FinderCaption As String
        Set(value As String)
            _findertext = value
        End Set
        Get
            Return _findertext
        End Get
    End Property
    Private Sub cmdFirst_Click(sender As Object, e As EventArgs) Handles cmdFirst.Click
        srcentry = 0
        If IsNothing(v) = True Then
            v = OpenView(_displayviewid, _sourcetype)
            v.Init()
        End If

        If _filtercmd.Length > 0 Then
            v.InitFilter()
            v.Filter(_filtercmd)
            v.EndFilter()
        Else
            v.Read()
        End If
        If v.BoundData.Rows.Count > 0 Then
            v.MoveFirst()
            txtCode.EditValue = v.GetFieldValueByID(_returnfiled).ToString.Trim()
        End If
    End Sub

    Private Sub cmdPrev_Click(sender As Object, e As EventArgs) Handles cmdPrev.Click
        srcentry = 0
        If IsNothing(v) = True Then
            v = OpenView(_displayviewid, _sourcetype)
            v.Init()
        End If

        If _filtercmd.Length > 0 Then
            v.InitFilter()
            v.Filter(_filtercmd)
            v.EndFilter()
        Else
            v.Read()
        End If
        If v.BoundData.Rows.Count > 0 Then
            v.MovePrevious()
            txtCode.EditValue = v.GetFieldValueByID(_returnfiled).ToString.Trim()
        End If
    End Sub

    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        srcentry = 0
        If IsNothing(v) = True Then
            v = OpenView(_displayviewid, _sourcetype)
            v.Init()
        End If

        If _filtercmd.Length > 0 Then
            v.InitFilter()
            v.Filter(_filtercmd)
            v.EndFilter()
        Else
            v.Read()
        End If
        If v.BoundData.Rows.Count > 0 Then
            v.MoveNext()
            txtCode.EditValue = v.GetFieldValueByID(_returnfiled).ToString.Trim()
        End If
    End Sub

    Private Sub cmdLast_Click(sender As Object, e As EventArgs) Handles cmdLast.Click
        srcentry = 0
        If IsNothing(v) = True Then
            v = OpenView(_displayviewid, _sourcetype)
            v.Init()
        End If

        If _filtercmd.Length > 0 Then
            v.InitFilter()
            v.Filter(_filtercmd)
            v.EndFilter()
        Else
            v.Read()
        End If
        If v.BoundData.Rows.Count > 0 Then
            v.MoveLast()
            txtCode.EditValue = v.GetFieldValueByID(_returnfiled).ToString.Trim()
        End If
    End Sub

    Private Sub cmdFind_Click(sender As Object, e As EventArgs) Handles cmdFind.Click
        srcentry = 2
        If IsNothing(v) = True Then
            v = OpenView(_displayviewid, _sourcetype)
            v.Init()
        End If
        If _filtercmd.Length > 0 Then
            v.InitFilter()
            v.Filter(_filtercmd)
            v.EndFilter()
        Else
            v.Read()
        End If
        Dim fm As New fmFinder
        fm.Caption = _findertext
        
        fm.SetViewID(_displayviewid, _sourcetype)
        If _filtercmd.Length > 0 Then
            fm.SetFilter(_filtercmd)
        End If
        fm.ReturnField = _returnfiled
        fm.TargetTextEdit = txtCode
        fm.ShowFinder()
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        srcentry = 0
        If IsNothing(v) = True Then
            v = OpenView(_displayviewid, _sourcetype)

        End If
        v.Init()
        If _filtercmd.Length > 0 Then
            v.InitFilter()
            v.Filter(_filtercmd)
            v.EndFilter()
        Else
            v.Read()
        End If
        txtCode.EditValue = ""
        _isnew = True
        RaiseEvent NewRecordFired(sender, e)
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        RaiseEvent SaveRecordFired(sender, e)
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        RaiseEvent DeleteRecordFired(sender, e)
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        If _reportname.Length > 0 Then
            Dim rpt As New CrReport(_reportname, _sourcetype)
            rpt.Preview()
        Else
            RaiseEvent PrintRecordFired(sender, e)
        End If

    End Sub





    Private Sub txtCode_EditValueChanged(sender As Object, e As EventArgs) Handles txtCode.EditValueChanged
        _curvalue = txtCode.EditValue.ToString.Trim()
        If _curvalue = "" Or _curvalue = "***NEW***" Then
            _isnew = True
        Else
            If IsNothing(v) = True Then
                v = OpenView(_displayviewid, _sourcetype)
            End If
            v.Init()
            If _filtercmd.Length > 0 Then
                v.InitFilter()
                v.Filter(_filtercmd)
                v.EndFilter()
            Else
                v.Read()
            End If
            If srcentry = 1 Then 'User type manually
                If v.ValueIsExist(_returnfiled, txtCode.EditValue.ToString.Trim) = True Then
                    _isnew = False
                    RaiseEvent EditValueChanged(sender, e)
                Else
                    _isnew = True
                    RaiseEvent NewRecordFired(sender, e)
                End If
            ElseIf srcentry = 2 Then 'From Search Button
                If v.ValueIsExist(_returnfiled, txtCode.EditValue.ToString.Trim) = True Then
                    _isnew = False
                    RaiseEvent EditValueChanged(sender, e)
                End If

            Else 'From Navigation
                If txtCode.EditValue.ToString.Trim <> "" Then

                    _isnew = False
                    RaiseEvent RecordIndexChanged(sender, e)

                End If
            End If

        End If
        
    End Sub

    Private Sub txtCode_GotFocus(sender As Object, e As EventArgs) Handles txtCode.GotFocus
        srcentry = 1
    End Sub


    Private Sub txtCode_LostFocus(sender As Object, e As EventArgs) Handles txtCode.LostFocus
        srcentry = 0
    End Sub
End Class
