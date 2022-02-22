<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartment
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDepartment))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDesc = New DevExpress.XtraEditors.TextEdit()
        Me.rvDepCode = New SVIRS.RecordNavigator()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.btnLocRem = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLocAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.dgLoc = New DevExpress.XtraGrid.GridControl()
        Me.gvLoc = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLocId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.swInvCtrl = New DevExpress.XtraEditors.CheckEdit()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.btnEmpRem = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEmpAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.dgEmployee = New DevExpress.XtraGrid.GridControl()
        Me.gvEmployee = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEmpCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmpName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtICMail = New DevExpress.XtraEditors.TextEdit()
        Me.btnICRem = New DevExpress.XtraEditors.SimpleButton()
        Me.btnICAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.dgInvCtrl = New DevExpress.XtraGrid.GridControl()
        Me.gvInvCtrl = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colICCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colICName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRAMail = New DevExpress.XtraEditors.TextEdit()
        Me.btnRARem = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRAAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.dgReqAppv = New DevExpress.XtraGrid.GridControl()
        Me.gvReqAppv = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRACode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRAName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIAMail = New DevExpress.XtraEditors.TextEdit()
        Me.btnIARem = New DevExpress.XtraEditors.SimpleButton()
        Me.btnIAAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.dgInvAppv = New DevExpress.XtraGrid.GridControl()
        Me.gvInvAppv = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIACode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIAName = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage5.SuspendLayout()
        CType(Me.dgLoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvLoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.swInvCtrl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.dgEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.txtICMail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgInvCtrl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvInvCtrl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.txtRAMail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgReqAppv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvReqAppv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.txtIAMail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgInvAppv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvInvAppv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.txtDesc)
        Me.PanelControl1.Controls.Add(Me.rvDepCode)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1171, 85)
        Me.PanelControl1.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(28, 47)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Department Name"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(28, 21)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Department Code"
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(203, 40)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(534, 20)
        Me.txtDesc.TabIndex = 1
        '
        'rvDepCode
        '
        Me.rvDepCode.CurrentValue = Nothing
        Me.rvDepCode.DataViewList = "Department"
        Me.rvDepCode.DeleteButtonHide = False
        Me.rvDepCode.DeleteButtonToolTip = "Delete"
        Me.rvDepCode.FilsterString = ""
        Me.rvDepCode.FindButtonToolTip = "Search"
        Me.rvDepCode.FinderCaption = ""
        Me.rvDepCode.FirstButtonToolTip = "First"
        Me.rvDepCode.LastButtonToolTip = "Last"
        Me.rvDepCode.Location = New System.Drawing.Point(203, 12)
        Me.rvDepCode.MaxLength = 0
        Me.rvDepCode.Name = "rvDepCode"
        Me.rvDepCode.NavigatorHide = False
        Me.rvDepCode.NewButtonHide = False
        Me.rvDepCode.NewButtonToolTip = "Create New"
        Me.rvDepCode.NextButtonToolTip = "Next"
        Me.rvDepCode.PreviousButtonToolTip = "Previous"
        Me.rvDepCode.PrintButtonHide = False
        Me.rvDepCode.PrintButtonToolTip = "Print"
        Me.rvDepCode.ReportDirectPrint = False
        Me.rvDepCode.ReportName = "departments"
        Me.rvDepCode.ReturnField = "DEPCODE"
        Me.rvDepCode.SaveButtonHide = False
        Me.rvDepCode.SaveButtonToolTip = "Save"
        Me.rvDepCode.Size = New System.Drawing.Size(373, 22)
        Me.rvDepCode.SourceType = 0
        Me.rvDepCode.TabIndex = 0
        Me.rvDepCode.ViewID = "Department"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 85)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage5
        Me.XtraTabControl1.Size = New System.Drawing.Size(1171, 503)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage5, Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4})
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.btnLocRem)
        Me.XtraTabPage5.Controls.Add(Me.btnLocAdd)
        Me.XtraTabPage5.Controls.Add(Me.dgLoc)
        Me.XtraTabPage5.Controls.Add(Me.swInvCtrl)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(1165, 475)
        Me.XtraTabPage5.Text = "Location"
        '
        'btnLocRem
        '
        Me.btnLocRem.Image = CType(resources.GetObject("btnLocRem.Image"), System.Drawing.Image)
        Me.btnLocRem.Location = New System.Drawing.Point(536, 63)
        Me.btnLocRem.Name = "btnLocRem"
        Me.btnLocRem.Size = New System.Drawing.Size(96, 23)
        Me.btnLocRem.TabIndex = 4
        Me.btnLocRem.Text = "Remove"
        '
        'btnLocAdd
        '
        Me.btnLocAdd.Image = CType(resources.GetObject("btnLocAdd.Image"), System.Drawing.Image)
        Me.btnLocAdd.Location = New System.Drawing.Point(536, 34)
        Me.btnLocAdd.Name = "btnLocAdd"
        Me.btnLocAdd.Size = New System.Drawing.Size(96, 23)
        Me.btnLocAdd.TabIndex = 3
        Me.btnLocAdd.Text = "Add"
        '
        'dgLoc
        '
        Me.dgLoc.Location = New System.Drawing.Point(27, 34)
        Me.dgLoc.MainView = Me.gvLoc
        Me.dgLoc.Name = "dgLoc"
        Me.dgLoc.Size = New System.Drawing.Size(488, 329)
        Me.dgLoc.TabIndex = 0
        Me.dgLoc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvLoc})
        '
        'gvLoc
        '
        Me.gvLoc.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLocId, Me.colLocDesc})
        Me.gvLoc.GridControl = Me.dgLoc
        Me.gvLoc.Name = "gvLoc"
        Me.gvLoc.OptionsBehavior.Editable = False
        Me.gvLoc.OptionsBehavior.ReadOnly = True
        Me.gvLoc.OptionsView.ShowGroupPanel = False
        Me.gvLoc.OptionsView.ShowIndicator = False
        '
        'colLocId
        '
        Me.colLocId.Caption = "Location"
        Me.colLocId.FieldName = "location"
        Me.colLocId.Name = "colLocId"
        Me.colLocId.Visible = True
        Me.colLocId.VisibleIndex = 0
        '
        'colLocDesc
        '
        Me.colLocDesc.Caption = "Description"
        Me.colLocDesc.FieldName = "locdesc"
        Me.colLocDesc.Name = "colLocDesc"
        Me.colLocDesc.Visible = True
        Me.colLocDesc.VisibleIndex = 1
        '
        'swInvCtrl
        '
        Me.swInvCtrl.Location = New System.Drawing.Point(27, 8)
        Me.swInvCtrl.Name = "swInvCtrl"
        Me.swInvCtrl.Properties.Caption = "The department is controlling the inventory"
        Me.swInvCtrl.Size = New System.Drawing.Size(347, 19)
        Me.swInvCtrl.TabIndex = 0
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.btnEmpRem)
        Me.XtraTabPage1.Controls.Add(Me.btnEmpAdd)
        Me.XtraTabPage1.Controls.Add(Me.dgEmployee)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1165, 475)
        Me.XtraTabPage1.Text = "Employees"
        '
        'btnEmpRem
        '
        Me.btnEmpRem.Image = CType(resources.GetObject("btnEmpRem.Image"), System.Drawing.Image)
        Me.btnEmpRem.Location = New System.Drawing.Point(610, 75)
        Me.btnEmpRem.Name = "btnEmpRem"
        Me.btnEmpRem.Size = New System.Drawing.Size(96, 23)
        Me.btnEmpRem.TabIndex = 2
        Me.btnEmpRem.Text = "Remove"
        '
        'btnEmpAdd
        '
        Me.btnEmpAdd.Image = CType(resources.GetObject("btnEmpAdd.Image"), System.Drawing.Image)
        Me.btnEmpAdd.Location = New System.Drawing.Point(610, 46)
        Me.btnEmpAdd.Name = "btnEmpAdd"
        Me.btnEmpAdd.Size = New System.Drawing.Size(96, 23)
        Me.btnEmpAdd.TabIndex = 1
        Me.btnEmpAdd.Text = "Add"
        '
        'dgEmployee
        '
        Me.dgEmployee.Location = New System.Drawing.Point(27, 46)
        Me.dgEmployee.MainView = Me.gvEmployee
        Me.dgEmployee.Name = "dgEmployee"
        Me.dgEmployee.Size = New System.Drawing.Size(565, 331)
        Me.dgEmployee.TabIndex = 0
        Me.dgEmployee.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvEmployee})
        '
        'gvEmployee
        '
        Me.gvEmployee.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEmpCode, Me.colEmpName})
        Me.gvEmployee.GridControl = Me.dgEmployee
        Me.gvEmployee.Name = "gvEmployee"
        Me.gvEmployee.OptionsBehavior.Editable = False
        Me.gvEmployee.OptionsBehavior.ReadOnly = True
        Me.gvEmployee.OptionsView.ShowGroupPanel = False
        Me.gvEmployee.OptionsView.ShowIndicator = False
        '
        'colEmpCode
        '
        Me.colEmpCode.Caption = "User ID"
        Me.colEmpCode.FieldName = "userid"
        Me.colEmpCode.Name = "colEmpCode"
        Me.colEmpCode.Visible = True
        Me.colEmpCode.VisibleIndex = 0
        '
        'colEmpName
        '
        Me.colEmpName.Caption = "User Name"
        Me.colEmpName.FieldName = "username"
        Me.colEmpName.Name = "colEmpName"
        Me.colEmpName.Visible = True
        Me.colEmpName.VisibleIndex = 1
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage2.Controls.Add(Me.txtICMail)
        Me.XtraTabPage2.Controls.Add(Me.btnICRem)
        Me.XtraTabPage2.Controls.Add(Me.btnICAdd)
        Me.XtraTabPage2.Controls.Add(Me.dgInvCtrl)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1165, 475)
        Me.XtraTabPage2.Text = "Inventory Controller"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(11, 50)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Group Email"
        '
        'txtICMail
        '
        Me.txtICMail.Location = New System.Drawing.Point(120, 47)
        Me.txtICMail.Name = "txtICMail"
        Me.txtICMail.Size = New System.Drawing.Size(314, 20)
        Me.txtICMail.TabIndex = 4
        '
        'btnICRem
        '
        Me.btnICRem.Image = CType(resources.GetObject("btnICRem.Image"), System.Drawing.Image)
        Me.btnICRem.Location = New System.Drawing.Point(631, 102)
        Me.btnICRem.Name = "btnICRem"
        Me.btnICRem.Size = New System.Drawing.Size(97, 23)
        Me.btnICRem.TabIndex = 3
        Me.btnICRem.Text = "Remove"
        '
        'btnICAdd
        '
        Me.btnICAdd.Image = CType(resources.GetObject("btnICAdd.Image"), System.Drawing.Image)
        Me.btnICAdd.Location = New System.Drawing.Point(631, 73)
        Me.btnICAdd.Name = "btnICAdd"
        Me.btnICAdd.Size = New System.Drawing.Size(97, 23)
        Me.btnICAdd.TabIndex = 2
        Me.btnICAdd.Text = "Add"
        '
        'dgInvCtrl
        '
        Me.dgInvCtrl.Location = New System.Drawing.Point(120, 73)
        Me.dgInvCtrl.MainView = Me.gvInvCtrl
        Me.dgInvCtrl.Name = "dgInvCtrl"
        Me.dgInvCtrl.Size = New System.Drawing.Size(505, 268)
        Me.dgInvCtrl.TabIndex = 1
        Me.dgInvCtrl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvInvCtrl})
        '
        'gvInvCtrl
        '
        Me.gvInvCtrl.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colICCode, Me.colICName})
        Me.gvInvCtrl.GridControl = Me.dgInvCtrl
        Me.gvInvCtrl.Name = "gvInvCtrl"
        Me.gvInvCtrl.OptionsBehavior.Editable = False
        Me.gvInvCtrl.OptionsBehavior.ReadOnly = True
        Me.gvInvCtrl.OptionsView.ShowGroupPanel = False
        Me.gvInvCtrl.OptionsView.ShowIndicator = False
        '
        'colICCode
        '
        Me.colICCode.Caption = "User ID"
        Me.colICCode.FieldName = "userid"
        Me.colICCode.Name = "colICCode"
        Me.colICCode.Visible = True
        Me.colICCode.VisibleIndex = 0
        '
        'colICName
        '
        Me.colICName.Caption = "User Name"
        Me.colICName.FieldName = "username"
        Me.colICName.Name = "colICName"
        Me.colICName.Visible = True
        Me.colICName.VisibleIndex = 1
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage3.Controls.Add(Me.txtRAMail)
        Me.XtraTabPage3.Controls.Add(Me.btnRARem)
        Me.XtraTabPage3.Controls.Add(Me.btnRAAdd)
        Me.XtraTabPage3.Controls.Add(Me.dgReqAppv)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1165, 475)
        Me.XtraTabPage3.Text = "Request Approvers"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(27, 40)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "Group Email"
        '
        'txtRAMail
        '
        Me.txtRAMail.Location = New System.Drawing.Point(132, 37)
        Me.txtRAMail.Name = "txtRAMail"
        Me.txtRAMail.Size = New System.Drawing.Size(308, 20)
        Me.txtRAMail.TabIndex = 3
        '
        'btnRARem
        '
        Me.btnRARem.Image = CType(resources.GetObject("btnRARem.Image"), System.Drawing.Image)
        Me.btnRARem.Location = New System.Drawing.Point(673, 101)
        Me.btnRARem.Name = "btnRARem"
        Me.btnRARem.Size = New System.Drawing.Size(96, 23)
        Me.btnRARem.TabIndex = 2
        Me.btnRARem.Text = "Remove"
        '
        'btnRAAdd
        '
        Me.btnRAAdd.Image = CType(resources.GetObject("btnRAAdd.Image"), System.Drawing.Image)
        Me.btnRAAdd.Location = New System.Drawing.Point(673, 72)
        Me.btnRAAdd.Name = "btnRAAdd"
        Me.btnRAAdd.Size = New System.Drawing.Size(96, 23)
        Me.btnRAAdd.TabIndex = 1
        Me.btnRAAdd.Text = "Add"
        '
        'dgReqAppv
        '
        Me.dgReqAppv.Location = New System.Drawing.Point(132, 72)
        Me.dgReqAppv.MainView = Me.gvReqAppv
        Me.dgReqAppv.Name = "dgReqAppv"
        Me.dgReqAppv.Size = New System.Drawing.Size(521, 277)
        Me.dgReqAppv.TabIndex = 0
        Me.dgReqAppv.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvReqAppv})
        '
        'gvReqAppv
        '
        Me.gvReqAppv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRACode, Me.colRAName})
        Me.gvReqAppv.GridControl = Me.dgReqAppv
        Me.gvReqAppv.Name = "gvReqAppv"
        Me.gvReqAppv.OptionsBehavior.Editable = False
        Me.gvReqAppv.OptionsBehavior.ReadOnly = True
        Me.gvReqAppv.OptionsView.ShowGroupPanel = False
        Me.gvReqAppv.OptionsView.ShowIndicator = False
        '
        'colRACode
        '
        Me.colRACode.Caption = "User ID"
        Me.colRACode.FieldName = "userid"
        Me.colRACode.Name = "colRACode"
        Me.colRACode.Visible = True
        Me.colRACode.VisibleIndex = 0
        '
        'colRAName
        '
        Me.colRAName.Caption = "User Name"
        Me.colRAName.FieldName = "username"
        Me.colRAName.Name = "colRAName"
        Me.colRAName.Visible = True
        Me.colRAName.VisibleIndex = 1
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage4.Controls.Add(Me.txtIAMail)
        Me.XtraTabPage4.Controls.Add(Me.btnIARem)
        Me.XtraTabPage4.Controls.Add(Me.btnIAAdd)
        Me.XtraTabPage4.Controls.Add(Me.dgInvAppv)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(1165, 475)
        Me.XtraTabPage4.Text = "Inventory Approvers"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(11, 22)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl5.TabIndex = 6
        Me.LabelControl5.Text = "Group Email"
        '
        'txtIAMail
        '
        Me.txtIAMail.Location = New System.Drawing.Point(118, 19)
        Me.txtIAMail.Name = "txtIAMail"
        Me.txtIAMail.Size = New System.Drawing.Size(308, 20)
        Me.txtIAMail.TabIndex = 5
        '
        'btnIARem
        '
        Me.btnIARem.Image = CType(resources.GetObject("btnIARem.Image"), System.Drawing.Image)
        Me.btnIARem.Location = New System.Drawing.Point(658, 84)
        Me.btnIARem.Name = "btnIARem"
        Me.btnIARem.Size = New System.Drawing.Size(90, 23)
        Me.btnIARem.TabIndex = 2
        Me.btnIARem.Text = "Remove"
        '
        'btnIAAdd
        '
        Me.btnIAAdd.Image = CType(resources.GetObject("btnIAAdd.Image"), System.Drawing.Image)
        Me.btnIAAdd.Location = New System.Drawing.Point(658, 55)
        Me.btnIAAdd.Name = "btnIAAdd"
        Me.btnIAAdd.Size = New System.Drawing.Size(90, 23)
        Me.btnIAAdd.TabIndex = 1
        Me.btnIAAdd.Text = "Add"
        '
        'dgInvAppv
        '
        Me.dgInvAppv.Location = New System.Drawing.Point(118, 55)
        Me.dgInvAppv.MainView = Me.gvInvAppv
        Me.dgInvAppv.Name = "dgInvAppv"
        Me.dgInvAppv.Size = New System.Drawing.Size(534, 303)
        Me.dgInvAppv.TabIndex = 0
        Me.dgInvAppv.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvInvAppv})
        '
        'gvInvAppv
        '
        Me.gvInvAppv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIACode, Me.colIAName})
        Me.gvInvAppv.GridControl = Me.dgInvAppv
        Me.gvInvAppv.Name = "gvInvAppv"
        Me.gvInvAppv.OptionsBehavior.Editable = False
        Me.gvInvAppv.OptionsBehavior.ReadOnly = True
        Me.gvInvAppv.OptionsView.ShowGroupPanel = False
        Me.gvInvAppv.OptionsView.ShowIndicator = False
        '
        'colIACode
        '
        Me.colIACode.Caption = "User ID"
        Me.colIACode.FieldName = "userid"
        Me.colIACode.Name = "colIACode"
        Me.colIACode.Visible = True
        Me.colIACode.VisibleIndex = 0
        '
        'colIAName
        '
        Me.colIAName.Caption = "User Name"
        Me.colIAName.FieldName = "username"
        Me.colIAName.Name = "colIAName"
        Me.colIAName.Visible = True
        Me.colIAName.VisibleIndex = 1
        '
        'frmDepartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1171, 588)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmDepartment"
        Me.Text = "Department Maintenance"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage5.ResumeLayout(False)
        CType(Me.dgLoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvLoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.swInvCtrl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.dgEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.txtICMail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgInvCtrl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvInvCtrl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        CType(Me.txtRAMail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgReqAppv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvReqAppv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        Me.XtraTabPage4.PerformLayout()
        CType(Me.txtIAMail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgInvAppv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvInvAppv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rvDepCode As SVIRS.RecordNavigator
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnEmpRem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEmpAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgEmployee As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvEmployee As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents swInvCtrl As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnRARem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRAAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgReqAppv As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvReqAppv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnIARem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnIAAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgInvAppv As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvInvAppv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnICRem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnICAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgInvCtrl As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvInvCtrl As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colEmpCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmpName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colICCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colICName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRACode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRAName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIACode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIAName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents dgLoc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvLoc As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colLocId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnLocRem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLocAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtICMail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRAMail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIAMail As DevExpress.XtraEditors.TextEdit
End Class
