<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvRequest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvRequest))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.dtRequest = New DevExpress.XtraEditors.DateEdit()
        Me.txtRef = New DevExpress.XtraEditors.TextEdit()
        Me.txtReason = New DevExpress.XtraEditors.TextEdit()
        Me.txtSmtCount = New DevExpress.XtraEditors.SpinEdit()
        Me.lstStatus = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.rvReq = New SVIRS.RecordNavigator()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.lblLoc1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblLoc = New DevExpress.XtraEditors.LabelControl()
        Me.lblUOM1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblUOM = New DevExpress.XtraEditors.LabelControl()
        Me.txtQtyNeed = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.txtQOH = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.btnUse = New DevExpress.XtraEditors.SimpleButton()
        Me.btnComment = New DevExpress.XtraEditors.SimpleButton()
        Me.btnVoid = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRelease = New DevExpress.XtraEditors.SimpleButton()
        Me.btnArrival = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPurchase = New DevExpress.XtraEditors.SimpleButton()
        Me.btnReject = New DevExpress.XtraEditors.SimpleButton()
        Me.btnApprove = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSendBack = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSubmit = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.optReqType = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.lstIAStat = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.dtIApprove = New DevExpress.XtraEditors.DateEdit()
        Me.txtIAName = New DevExpress.XtraEditors.TextEdit()
        Me.txtIAID = New DevExpress.XtraEditors.TextEdit()
        Me.txtTDepName = New DevExpress.XtraEditors.TextEdit()
        Me.btnTDepFind = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTDepCode = New DevExpress.XtraEditors.TextEdit()
        Me.lstRAStat = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.dtRApprove = New DevExpress.XtraEditors.DateEdit()
        Me.txtRAName = New DevExpress.XtraEditors.TextEdit()
        Me.txtRAID = New DevExpress.XtraEditors.TextEdit()
        Me.txtReqName = New DevExpress.XtraEditors.TextEdit()
        Me.txtReqID = New DevExpress.XtraEditors.TextEdit()
        Me.txtFDepName = New DevExpress.XtraEditors.TextEdit()
        Me.txtFDepCode = New DevExpress.XtraEditors.TextEdit()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.dgItem = New DevExpress.XtraGrid.GridControl()
        Me.gvItem = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItmReqno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLineNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReqQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReqUom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFLoc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTLoc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLineApprv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsuQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsuUOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLineCmt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnRemLine = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddLine = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.dgCmt = New DevExpress.XtraGrid.GridControl()
        Me.gvCmt = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCmtId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCmtReqNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCmtDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCmtUserID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCmtUName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.dgLog = New DevExpress.XtraGrid.GridControl()
        Me.gvLog = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLogId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogReqNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogUuserId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogUserName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogDetail = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.dtRequest.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtRequest.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReason.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSmtCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtQtyNeed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQOH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.optReqType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstIAStat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtIApprove.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtIApprove.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIAName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIAID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTDepName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTDepCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstRAStat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtRApprove.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtRApprove.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRAName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRAID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReqName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReqID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFDepName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFDepCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.dgItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.dgCmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCmt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.dgLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.dtRequest)
        Me.PanelControl1.Controls.Add(Me.txtRef)
        Me.PanelControl1.Controls.Add(Me.txtReason)
        Me.PanelControl1.Controls.Add(Me.txtSmtCount)
        Me.PanelControl1.Controls.Add(Me.lstStatus)
        Me.PanelControl1.Controls.Add(Me.rvReq)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1204, 97)
        Me.PanelControl1.TabIndex = 0
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(908, 17)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(96, 13)
        Me.LabelControl6.TabIndex = 10
        Me.LabelControl6.Text = "Counted Submission"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(908, 69)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl5.TabIndex = 9
        Me.LabelControl5.Text = "Requested Date"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(639, 17)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "Status"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 69)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "Reference"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 43)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Reason"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 17)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Request Number"
        '
        'dtRequest
        '
        Me.dtRequest.EditValue = Nothing
        Me.dtRequest.Location = New System.Drawing.Point(1008, 66)
        Me.dtRequest.Name = "dtRequest"
        Me.dtRequest.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtRequest.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtRequest.Size = New System.Drawing.Size(116, 20)
        Me.dtRequest.TabIndex = 4
        '
        'txtRef
        '
        Me.txtRef.Location = New System.Drawing.Point(160, 66)
        Me.txtRef.Name = "txtRef"
        Me.txtRef.Properties.MaxLength = 60
        Me.txtRef.Size = New System.Drawing.Size(696, 20)
        Me.txtRef.TabIndex = 3
        '
        'txtReason
        '
        Me.txtReason.Location = New System.Drawing.Point(160, 40)
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Properties.MaxLength = 60
        Me.txtReason.Size = New System.Drawing.Size(696, 20)
        Me.txtReason.TabIndex = 2
        '
        'txtSmtCount
        '
        Me.txtSmtCount.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSmtCount.Location = New System.Drawing.Point(1008, 14)
        Me.txtSmtCount.Name = "txtSmtCount"
        Me.txtSmtCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSmtCount.Properties.ReadOnly = True
        Me.txtSmtCount.Size = New System.Drawing.Size(59, 20)
        Me.txtSmtCount.TabIndex = 1
        '
        'lstStatus
        '
        Me.lstStatus.Location = New System.Drawing.Point(676, 14)
        Me.lstStatus.Name = "lstStatus"
        Me.lstStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lstStatus.Properties.Items.AddRange(New Object() {"New", "Submitted", "Partial Approved", "Editing Required", "Rejected", "Approved", "Waiting for Purchase", "Stock Available", "Item Released", "Voided", "Used", "Collected"})
        Me.lstStatus.Properties.ReadOnly = True
        Me.lstStatus.Size = New System.Drawing.Size(180, 20)
        Me.lstStatus.TabIndex = 1
        '
        'rvReq
        '
        Me.rvReq.CurrentValue = Nothing
        Me.rvReq.DataViewList = "Request"
        Me.rvReq.DeleteButtonHide = True
        Me.rvReq.DeleteButtonToolTip = "Delete"
        Me.rvReq.FilsterString = ""
        Me.rvReq.FindButtonToolTip = "Search"
        Me.rvReq.FinderCaption = "Find Request"
        Me.rvReq.FirstButtonToolTip = "First"
        Me.rvReq.LastButtonToolTip = "Last"
        Me.rvReq.Location = New System.Drawing.Point(160, 12)
        Me.rvReq.MaxLength = 0
        Me.rvReq.Name = "rvReq"
        Me.rvReq.NavigatorHide = False
        Me.rvReq.NewButtonHide = False
        Me.rvReq.NewButtonToolTip = "Create New"
        Me.rvReq.NextButtonToolTip = "Next"
        Me.rvReq.PreviousButtonToolTip = "Previous"
        Me.rvReq.PrintButtonHide = False
        Me.rvReq.PrintButtonToolTip = "Print"
        Me.rvReq.ReportDirectPrint = False
        Me.rvReq.ReportName = ""
        Me.rvReq.ReturnField = "REQNO"
        Me.rvReq.SaveButtonHide = False
        Me.rvReq.SaveButtonToolTip = "Save"
        Me.rvReq.Size = New System.Drawing.Size(426, 22)
        Me.rvReq.SourceType = 0
        Me.rvReq.TabIndex = 0
        Me.rvReq.ViewID = "Request"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Controls.Add(Me.lblLoc1)
        Me.PanelControl2.Controls.Add(Me.lblLoc)
        Me.PanelControl2.Controls.Add(Me.lblUOM1)
        Me.PanelControl2.Controls.Add(Me.lblUOM)
        Me.PanelControl2.Controls.Add(Me.txtQtyNeed)
        Me.PanelControl2.Controls.Add(Me.LabelControl17)
        Me.PanelControl2.Controls.Add(Me.txtQOH)
        Me.PanelControl2.Controls.Add(Me.LabelControl16)
        Me.PanelControl2.Controls.Add(Me.btnUse)
        Me.PanelControl2.Controls.Add(Me.btnComment)
        Me.PanelControl2.Controls.Add(Me.btnVoid)
        Me.PanelControl2.Controls.Add(Me.btnRelease)
        Me.PanelControl2.Controls.Add(Me.btnArrival)
        Me.PanelControl2.Controls.Add(Me.btnPurchase)
        Me.PanelControl2.Controls.Add(Me.btnReject)
        Me.PanelControl2.Controls.Add(Me.btnApprove)
        Me.PanelControl2.Controls.Add(Me.btnSendBack)
        Me.PanelControl2.Controls.Add(Me.btnSubmit)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 654)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1204, 124)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(1032, 24)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 17
        Me.SimpleButton1.Text = "SimpleButton1"
        Me.SimpleButton1.Visible = False
        '
        'lblLoc1
        '
        Me.lblLoc1.Location = New System.Drawing.Point(442, 12)
        Me.lblLoc1.Name = "lblLoc1"
        Me.lblLoc1.Size = New System.Drawing.Size(0, 13)
        Me.lblLoc1.TabIndex = 16
        '
        'lblLoc
        '
        Me.lblLoc.Location = New System.Drawing.Point(123, 13)
        Me.lblLoc.Name = "lblLoc"
        Me.lblLoc.Size = New System.Drawing.Size(0, 13)
        Me.lblLoc.TabIndex = 15
        '
        'lblUOM1
        '
        Me.lblUOM1.Location = New System.Drawing.Point(585, 17)
        Me.lblUOM1.Name = "lblUOM1"
        Me.lblUOM1.Size = New System.Drawing.Size(0, 13)
        Me.lblUOM1.TabIndex = 14
        '
        'lblUOM
        '
        Me.lblUOM.Location = New System.Drawing.Point(255, 17)
        Me.lblUOM.Name = "lblUOM"
        Me.lblUOM.Size = New System.Drawing.Size(0, 13)
        Me.lblUOM.TabIndex = 14
        '
        'txtQtyNeed
        '
        Me.txtQtyNeed.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtQtyNeed.Location = New System.Drawing.Point(442, 32)
        Me.txtQtyNeed.Name = "txtQtyNeed"
        Me.txtQtyNeed.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtQtyNeed.Properties.DisplayFormat.FormatString = "#0.000"
        Me.txtQtyNeed.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtQtyNeed.Properties.EditFormat.FormatString = "#0.000"
        Me.txtQtyNeed.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtQtyNeed.Properties.ReadOnly = True
        Me.txtQtyNeed.Size = New System.Drawing.Size(126, 20)
        Me.txtQtyNeed.TabIndex = 13
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(367, 35)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl17.TabIndex = 12
        Me.LabelControl17.Text = "Qty Needed"
        '
        'txtQOH
        '
        Me.txtQOH.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtQOH.Location = New System.Drawing.Point(123, 32)
        Me.txtQOH.Name = "txtQOH"
        Me.txtQOH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtQOH.Properties.DisplayFormat.FormatString = "#0.000"
        Me.txtQOH.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtQOH.Properties.EditFormat.FormatString = "#0.000"
        Me.txtQOH.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtQOH.Properties.ReadOnly = True
        Me.txtQOH.Size = New System.Drawing.Size(126, 20)
        Me.txtQOH.TabIndex = 11
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(20, 35)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl16.TabIndex = 10
        Me.LabelControl16.Text = "Qty On Hand:"
        '
        'btnUse
        '
        Me.btnUse.Enabled = False
        Me.btnUse.Location = New System.Drawing.Point(255, 89)
        Me.btnUse.Name = "btnUse"
        Me.btnUse.Size = New System.Drawing.Size(75, 23)
        Me.btnUse.TabIndex = 9
        Me.btnUse.Text = "Use"
        Me.btnUse.Visible = False
        '
        'btnComment
        '
        Me.btnComment.Enabled = False
        Me.btnComment.Location = New System.Drawing.Point(1093, 89)
        Me.btnComment.Name = "btnComment"
        Me.btnComment.Size = New System.Drawing.Size(94, 23)
        Me.btnComment.TabIndex = 8
        Me.btnComment.Text = "Add Comment"
        '
        'btnVoid
        '
        Me.btnVoid.Enabled = False
        Me.btnVoid.Location = New System.Drawing.Point(93, 89)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(75, 23)
        Me.btnVoid.TabIndex = 7
        Me.btnVoid.Text = "Void"
        '
        'btnRelease
        '
        Me.btnRelease.Enabled = False
        Me.btnRelease.Location = New System.Drawing.Point(915, 89)
        Me.btnRelease.Name = "btnRelease"
        Me.btnRelease.Size = New System.Drawing.Size(89, 23)
        Me.btnRelease.TabIndex = 6
        Me.btnRelease.Text = "Release"
        '
        'btnArrival
        '
        Me.btnArrival.Enabled = False
        Me.btnArrival.Location = New System.Drawing.Point(777, 89)
        Me.btnArrival.Name = "btnArrival"
        Me.btnArrival.Size = New System.Drawing.Size(132, 23)
        Me.btnArrival.TabIndex = 5
        Me.btnArrival.Text = "Stock Arrival/Available"
        '
        'btnPurchase
        '
        Me.btnPurchase.Enabled = False
        Me.btnPurchase.Location = New System.Drawing.Point(665, 89)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(106, 23)
        Me.btnPurchase.TabIndex = 4
        Me.btnPurchase.Text = "Send To Purchase"
        '
        'btnReject
        '
        Me.btnReject.Enabled = False
        Me.btnReject.Location = New System.Drawing.Point(537, 89)
        Me.btnReject.Name = "btnReject"
        Me.btnReject.Size = New System.Drawing.Size(75, 23)
        Me.btnReject.TabIndex = 3
        Me.btnReject.Text = "Reject"
        '
        'btnApprove
        '
        Me.btnApprove.Enabled = False
        Me.btnApprove.Location = New System.Drawing.Point(456, 89)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(75, 23)
        Me.btnApprove.TabIndex = 2
        Me.btnApprove.Text = "Approve"
        '
        'btnSendBack
        '
        Me.btnSendBack.Enabled = False
        Me.btnSendBack.Location = New System.Drawing.Point(375, 89)
        Me.btnSendBack.Name = "btnSendBack"
        Me.btnSendBack.Size = New System.Drawing.Size(75, 23)
        Me.btnSendBack.TabIndex = 1
        Me.btnSendBack.Text = "Send Back"
        '
        'btnSubmit
        '
        Me.btnSubmit.Enabled = False
        Me.btnSubmit.Location = New System.Drawing.Point(12, 89)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 97)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1204, 557)
        Me.XtraTabControl1.TabIndex = 2
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage4, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.optReqType)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl13)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl12)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl15)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl11)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl14)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl10)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl9)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl8)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl7)
        Me.XtraTabPage1.Controls.Add(Me.lstIAStat)
        Me.XtraTabPage1.Controls.Add(Me.dtIApprove)
        Me.XtraTabPage1.Controls.Add(Me.txtIAName)
        Me.XtraTabPage1.Controls.Add(Me.txtIAID)
        Me.XtraTabPage1.Controls.Add(Me.txtTDepName)
        Me.XtraTabPage1.Controls.Add(Me.btnTDepFind)
        Me.XtraTabPage1.Controls.Add(Me.txtTDepCode)
        Me.XtraTabPage1.Controls.Add(Me.lstRAStat)
        Me.XtraTabPage1.Controls.Add(Me.dtRApprove)
        Me.XtraTabPage1.Controls.Add(Me.txtRAName)
        Me.XtraTabPage1.Controls.Add(Me.txtRAID)
        Me.XtraTabPage1.Controls.Add(Me.txtReqName)
        Me.XtraTabPage1.Controls.Add(Me.txtReqID)
        Me.XtraTabPage1.Controls.Add(Me.txtFDepName)
        Me.XtraTabPage1.Controls.Add(Me.txtFDepCode)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1198, 529)
        Me.XtraTabPage1.Text = "Approval"
        '
        'optReqType
        '
        Me.optReqType.Location = New System.Drawing.Point(159, 283)
        Me.optReqType.Name = "optReqType"
        Me.optReqType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "For Internal Use"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "For Selling to Customer")})
        Me.optReqType.Size = New System.Drawing.Size(523, 64)
        Me.optReqType.TabIndex = 22
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(25, 244)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(96, 13)
        Me.LabelControl13.TabIndex = 21
        Me.LabelControl13.Text = "Inventory Approver"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(25, 198)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl12.TabIndex = 20
        Me.LabelControl12.Text = "To Department"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(1007, 222)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl15.TabIndex = 19
        Me.LabelControl15.Text = "Approved/Rejected"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(1007, 113)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl11.TabIndex = 19
        Me.LabelControl11.Text = "Approved/Rejected"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(791, 222)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl14.TabIndex = 18
        Me.LabelControl14.Text = "Approved On"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(791, 113)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl10.TabIndex = 18
        Me.LabelControl10.Text = "Approved On"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(25, 139)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl9.TabIndex = 17
        Me.LabelControl9.Text = "Request Approver"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(25, 75)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl8.TabIndex = 16
        Me.LabelControl8.Text = "Requested By"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(25, 49)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl7.TabIndex = 15
        Me.LabelControl7.Text = "From Department"
        '
        'lstIAStat
        '
        Me.lstIAStat.Location = New System.Drawing.Point(1007, 241)
        Me.lstIAStat.Name = "lstIAStat"
        Me.lstIAStat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lstIAStat.Properties.Items.AddRange(New Object() {"Approved", "Rejected"})
        Me.lstIAStat.Properties.ReadOnly = True
        Me.lstIAStat.Size = New System.Drawing.Size(113, 20)
        Me.lstIAStat.TabIndex = 14
        '
        'dtIApprove
        '
        Me.dtIApprove.EditValue = Nothing
        Me.dtIApprove.Location = New System.Drawing.Point(791, 241)
        Me.dtIApprove.Name = "dtIApprove"
        Me.dtIApprove.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtIApprove.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtIApprove.Properties.ReadOnly = True
        Me.dtIApprove.Size = New System.Drawing.Size(146, 20)
        Me.dtIApprove.TabIndex = 13
        '
        'txtIAName
        '
        Me.txtIAName.Location = New System.Drawing.Point(353, 241)
        Me.txtIAName.Name = "txtIAName"
        Me.txtIAName.Properties.ReadOnly = True
        Me.txtIAName.Size = New System.Drawing.Size(329, 20)
        Me.txtIAName.TabIndex = 12
        '
        'txtIAID
        '
        Me.txtIAID.Location = New System.Drawing.Point(159, 241)
        Me.txtIAID.Name = "txtIAID"
        Me.txtIAID.Properties.ReadOnly = True
        Me.txtIAID.Size = New System.Drawing.Size(153, 20)
        Me.txtIAID.TabIndex = 11
        '
        'txtTDepName
        '
        Me.txtTDepName.Location = New System.Drawing.Point(353, 195)
        Me.txtTDepName.Name = "txtTDepName"
        Me.txtTDepName.Properties.ReadOnly = True
        Me.txtTDepName.Size = New System.Drawing.Size(329, 20)
        Me.txtTDepName.TabIndex = 10
        '
        'btnTDepFind
        '
        Me.btnTDepFind.Image = CType(resources.GetObject("btnTDepFind.Image"), System.Drawing.Image)
        Me.btnTDepFind.Location = New System.Drawing.Point(318, 193)
        Me.btnTDepFind.Name = "btnTDepFind"
        Me.btnTDepFind.Size = New System.Drawing.Size(24, 23)
        Me.btnTDepFind.TabIndex = 9
        '
        'txtTDepCode
        '
        Me.txtTDepCode.Location = New System.Drawing.Point(159, 195)
        Me.txtTDepCode.Name = "txtTDepCode"
        Me.txtTDepCode.Properties.ReadOnly = True
        Me.txtTDepCode.Size = New System.Drawing.Size(153, 20)
        Me.txtTDepCode.TabIndex = 8
        '
        'lstRAStat
        '
        Me.lstRAStat.Location = New System.Drawing.Point(1007, 132)
        Me.lstRAStat.Name = "lstRAStat"
        Me.lstRAStat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lstRAStat.Properties.Items.AddRange(New Object() {"Approved", "Rejected"})
        Me.lstRAStat.Properties.ReadOnly = True
        Me.lstRAStat.Size = New System.Drawing.Size(113, 20)
        Me.lstRAStat.TabIndex = 7
        '
        'dtRApprove
        '
        Me.dtRApprove.EditValue = Nothing
        Me.dtRApprove.Location = New System.Drawing.Point(791, 132)
        Me.dtRApprove.Name = "dtRApprove"
        Me.dtRApprove.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtRApprove.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtRApprove.Properties.ReadOnly = True
        Me.dtRApprove.Size = New System.Drawing.Size(146, 20)
        Me.dtRApprove.TabIndex = 6
        '
        'txtRAName
        '
        Me.txtRAName.Location = New System.Drawing.Point(353, 132)
        Me.txtRAName.Name = "txtRAName"
        Me.txtRAName.Properties.ReadOnly = True
        Me.txtRAName.Size = New System.Drawing.Size(329, 20)
        Me.txtRAName.TabIndex = 5
        '
        'txtRAID
        '
        Me.txtRAID.Location = New System.Drawing.Point(159, 132)
        Me.txtRAID.Name = "txtRAID"
        Me.txtRAID.Properties.ReadOnly = True
        Me.txtRAID.Size = New System.Drawing.Size(153, 20)
        Me.txtRAID.TabIndex = 4
        '
        'txtReqName
        '
        Me.txtReqName.Location = New System.Drawing.Point(353, 72)
        Me.txtReqName.Name = "txtReqName"
        Me.txtReqName.Properties.ReadOnly = True
        Me.txtReqName.Size = New System.Drawing.Size(329, 20)
        Me.txtReqName.TabIndex = 3
        '
        'txtReqID
        '
        Me.txtReqID.Location = New System.Drawing.Point(159, 72)
        Me.txtReqID.Name = "txtReqID"
        Me.txtReqID.Properties.ReadOnly = True
        Me.txtReqID.Size = New System.Drawing.Size(153, 20)
        Me.txtReqID.TabIndex = 2
        '
        'txtFDepName
        '
        Me.txtFDepName.Location = New System.Drawing.Point(353, 46)
        Me.txtFDepName.Name = "txtFDepName"
        Me.txtFDepName.Properties.ReadOnly = True
        Me.txtFDepName.Size = New System.Drawing.Size(329, 20)
        Me.txtFDepName.TabIndex = 1
        '
        'txtFDepCode
        '
        Me.txtFDepCode.Location = New System.Drawing.Point(159, 46)
        Me.txtFDepCode.Name = "txtFDepCode"
        Me.txtFDepCode.Properties.ReadOnly = True
        Me.txtFDepCode.Size = New System.Drawing.Size(153, 20)
        Me.txtFDepCode.TabIndex = 0
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.dgItem)
        Me.XtraTabPage2.Controls.Add(Me.PanelControl3)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1198, 529)
        Me.XtraTabPage2.Text = "Items"
        '
        'dgItem
        '
        Me.dgItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgItem.Location = New System.Drawing.Point(0, 53)
        Me.dgItem.MainView = Me.gvItem
        Me.dgItem.Name = "dgItem"
        Me.dgItem.Size = New System.Drawing.Size(1198, 476)
        Me.dgItem.TabIndex = 1
        Me.dgItem.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvItem})
        '
        'gvItem
        '
        Me.gvItem.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItmReqno, Me.colLineNo, Me.colItemNo, Me.colItemDesc, Me.colReqQty, Me.colReqUom, Me.colFLoc, Me.colTLoc, Me.colLineApprv, Me.colIsuQty, Me.colIsuUOM, Me.colLineCmt})
        Me.gvItem.GridControl = Me.dgItem
        Me.gvItem.Name = "gvItem"
        Me.gvItem.OptionsView.RowAutoHeight = True
        Me.gvItem.OptionsView.ShowGroupPanel = False
        Me.gvItem.OptionsView.ShowIndicator = False
        '
        'colItmReqno
        '
        Me.colItmReqno.Caption = "Request No"
        Me.colItmReqno.FieldName = "reqno"
        Me.colItmReqno.Name = "colItmReqno"
        '
        'colLineNo
        '
        Me.colLineNo.Caption = "Line No"
        Me.colLineNo.FieldName = "linenum"
        Me.colLineNo.Name = "colLineNo"
        Me.colLineNo.OptionsColumn.AllowEdit = False
        Me.colLineNo.OptionsColumn.FixedWidth = True
        Me.colLineNo.Visible = True
        Me.colLineNo.VisibleIndex = 0
        Me.colLineNo.Width = 50
        '
        'colItemNo
        '
        Me.colItemNo.Caption = "Item No"
        Me.colItemNo.FieldName = "itemno"
        Me.colItemNo.Name = "colItemNo"
        Me.colItemNo.OptionsColumn.AllowEdit = False
        Me.colItemNo.OptionsColumn.FixedWidth = True
        Me.colItemNo.Visible = True
        Me.colItemNo.VisibleIndex = 1
        Me.colItemNo.Width = 120
        '
        'colItemDesc
        '
        Me.colItemDesc.Caption = "Description"
        Me.colItemDesc.FieldName = "itemdesc"
        Me.colItemDesc.Name = "colItemDesc"
        Me.colItemDesc.OptionsColumn.FixedWidth = True
        Me.colItemDesc.Visible = True
        Me.colItemDesc.VisibleIndex = 2
        Me.colItemDesc.Width = 300
        '
        'colReqQty
        '
        Me.colReqQty.Caption = "Request Qty"
        Me.colReqQty.FieldName = "reqqty"
        Me.colReqQty.Name = "colReqQty"
        Me.colReqQty.OptionsColumn.FixedWidth = True
        Me.colReqQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "reqqty", "SUM={0:0.##}")})
        Me.colReqQty.Visible = True
        Me.colReqQty.VisibleIndex = 3
        Me.colReqQty.Width = 100
        '
        'colReqUom
        '
        Me.colReqUom.Caption = "Request UOM"
        Me.colReqUom.FieldName = "requom"
        Me.colReqUom.Name = "colReqUom"
        Me.colReqUom.OptionsColumn.AllowEdit = False
        Me.colReqUom.OptionsColumn.FixedWidth = True
        Me.colReqUom.Visible = True
        Me.colReqUom.VisibleIndex = 4
        '
        'colFLoc
        '
        Me.colFLoc.Caption = "From Location"
        Me.colFLoc.FieldName = "fromloc"
        Me.colFLoc.Name = "colFLoc"
        Me.colFLoc.OptionsColumn.AllowEdit = False
        Me.colFLoc.OptionsColumn.FixedWidth = True
        Me.colFLoc.Visible = True
        Me.colFLoc.VisibleIndex = 5
        Me.colFLoc.Width = 100
        '
        'colTLoc
        '
        Me.colTLoc.Caption = "To Location"
        Me.colTLoc.FieldName = "toloc"
        Me.colTLoc.Name = "colTLoc"
        Me.colTLoc.OptionsColumn.AllowEdit = False
        Me.colTLoc.OptionsColumn.FixedWidth = True
        Me.colTLoc.Visible = True
        Me.colTLoc.VisibleIndex = 6
        Me.colTLoc.Width = 100
        '
        'colLineApprv
        '
        Me.colLineApprv.Caption = "Approved"
        Me.colLineApprv.FieldName = "lineapprove"
        Me.colLineApprv.Name = "colLineApprv"
        Me.colLineApprv.OptionsColumn.AllowEdit = False
        Me.colLineApprv.OptionsColumn.FixedWidth = True
        Me.colLineApprv.Width = 100
        '
        'colIsuQty
        '
        Me.colIsuQty.Caption = "Issue Qty"
        Me.colIsuQty.FieldName = "isuqty"
        Me.colIsuQty.Name = "colIsuQty"
        Me.colIsuQty.OptionsColumn.FixedWidth = True
        Me.colIsuQty.Visible = True
        Me.colIsuQty.VisibleIndex = 7
        Me.colIsuQty.Width = 100
        '
        'colIsuUOM
        '
        Me.colIsuUOM.Caption = "Issue UOM"
        Me.colIsuUOM.FieldName = "isuuom"
        Me.colIsuUOM.Name = "colIsuUOM"
        Me.colIsuUOM.OptionsColumn.AllowEdit = False
        Me.colIsuUOM.OptionsColumn.FixedWidth = True
        Me.colIsuUOM.Visible = True
        Me.colIsuUOM.VisibleIndex = 8
        Me.colIsuUOM.Width = 100
        '
        'colLineCmt
        '
        Me.colLineCmt.Caption = "Comment"
        Me.colLineCmt.FieldName = "linecmt"
        Me.colLineCmt.Name = "colLineCmt"
        Me.colLineCmt.Visible = True
        Me.colLineCmt.VisibleIndex = 9
        Me.colLineCmt.Width = 300
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.btnRemLine)
        Me.PanelControl3.Controls.Add(Me.btnAddLine)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1198, 53)
        Me.PanelControl3.TabIndex = 0
        '
        'btnRemLine
        '
        Me.btnRemLine.Location = New System.Drawing.Point(115, 14)
        Me.btnRemLine.Name = "btnRemLine"
        Me.btnRemLine.Size = New System.Drawing.Size(104, 23)
        Me.btnRemLine.TabIndex = 1
        Me.btnRemLine.Text = "Remove Line"
        '
        'btnAddLine
        '
        Me.btnAddLine.Location = New System.Drawing.Point(11, 14)
        Me.btnAddLine.Name = "btnAddLine"
        Me.btnAddLine.Size = New System.Drawing.Size(98, 23)
        Me.btnAddLine.TabIndex = 0
        Me.btnAddLine.Text = "Add New Line"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.dgCmt)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(1198, 529)
        Me.XtraTabPage4.Text = "Comments"
        '
        'dgCmt
        '
        Me.dgCmt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCmt.Location = New System.Drawing.Point(0, 0)
        Me.dgCmt.MainView = Me.gvCmt
        Me.dgCmt.Name = "dgCmt"
        Me.dgCmt.Size = New System.Drawing.Size(1198, 529)
        Me.dgCmt.TabIndex = 0
        Me.dgCmt.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCmt})
        '
        'gvCmt
        '
        Me.gvCmt.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCmtId, Me.colCmtReqNo, Me.colCmtDate, Me.colCmtUserID, Me.colCmtUName, Me.colComment})
        Me.gvCmt.GridControl = Me.dgCmt
        Me.gvCmt.Name = "gvCmt"
        Me.gvCmt.OptionsBehavior.Editable = False
        Me.gvCmt.OptionsView.ShowGroupPanel = False
        Me.gvCmt.OptionsView.ShowIndicator = False
        '
        'colCmtId
        '
        Me.colCmtId.Caption = "ID"
        Me.colCmtId.FieldName = "cmtid"
        Me.colCmtId.Name = "colCmtId"
        Me.colCmtId.OptionsColumn.FixedWidth = True
        Me.colCmtId.Visible = True
        Me.colCmtId.VisibleIndex = 0
        '
        'colCmtReqNo
        '
        Me.colCmtReqNo.Caption = "Request No"
        Me.colCmtReqNo.FieldName = "reqno"
        Me.colCmtReqNo.Name = "colCmtReqNo"
        '
        'colCmtDate
        '
        Me.colCmtDate.Caption = "Date & Time"
        Me.colCmtDate.DisplayFormat.FormatString = "d"
        Me.colCmtDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colCmtDate.FieldName = "cmtdate"
        Me.colCmtDate.Name = "colCmtDate"
        Me.colCmtDate.OptionsColumn.FixedWidth = True
        Me.colCmtDate.Visible = True
        Me.colCmtDate.VisibleIndex = 1
        Me.colCmtDate.Width = 100
        '
        'colCmtUserID
        '
        Me.colCmtUserID.Caption = "User ID"
        Me.colCmtUserID.FieldName = "cmtuserid"
        Me.colCmtUserID.Name = "colCmtUserID"
        Me.colCmtUserID.OptionsColumn.FixedWidth = True
        Me.colCmtUserID.Visible = True
        Me.colCmtUserID.VisibleIndex = 2
        Me.colCmtUserID.Width = 100
        '
        'colCmtUName
        '
        Me.colCmtUName.Caption = "User Name"
        Me.colCmtUName.FieldName = "cmtusername"
        Me.colCmtUName.Name = "colCmtUName"
        Me.colCmtUName.OptionsColumn.FixedWidth = True
        Me.colCmtUName.Visible = True
        Me.colCmtUName.VisibleIndex = 3
        Me.colCmtUName.Width = 200
        '
        'colComment
        '
        Me.colComment.Caption = "Comment"
        Me.colComment.FieldName = "cmtdetail"
        Me.colComment.Name = "colComment"
        Me.colComment.Visible = True
        Me.colComment.VisibleIndex = 4
        Me.colComment.Width = 704
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.dgLog)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1198, 529)
        Me.XtraTabPage3.Text = "Activity Log"
        '
        'dgLog
        '
        Me.dgLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgLog.Location = New System.Drawing.Point(0, 0)
        Me.dgLog.MainView = Me.gvLog
        Me.dgLog.Name = "dgLog"
        Me.dgLog.Size = New System.Drawing.Size(1198, 529)
        Me.dgLog.TabIndex = 0
        Me.dgLog.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvLog})
        '
        'gvLog
        '
        Me.gvLog.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLogId, Me.colLogDate, Me.colLogReqNo, Me.colLogType, Me.colLogUuserId, Me.colLogUserName, Me.colLogDetail})
        Me.gvLog.GridControl = Me.dgLog
        Me.gvLog.Name = "gvLog"
        Me.gvLog.OptionsBehavior.Editable = False
        Me.gvLog.OptionsView.ShowGroupPanel = False
        Me.gvLog.OptionsView.ShowIndicator = False
        '
        'colLogId
        '
        Me.colLogId.Caption = "ID"
        Me.colLogId.FieldName = "logid"
        Me.colLogId.Name = "colLogId"
        Me.colLogId.OptionsColumn.FixedWidth = True
        Me.colLogId.Visible = True
        Me.colLogId.VisibleIndex = 0
        '
        'colLogDate
        '
        Me.colLogDate.Caption = "Date & Time"
        Me.colLogDate.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.colLogDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colLogDate.FieldName = "logdate"
        Me.colLogDate.Name = "colLogDate"
        Me.colLogDate.OptionsColumn.FixedWidth = True
        Me.colLogDate.Visible = True
        Me.colLogDate.VisibleIndex = 1
        Me.colLogDate.Width = 111
        '
        'colLogReqNo
        '
        Me.colLogReqNo.Caption = "Request No"
        Me.colLogReqNo.FieldName = "reqno"
        Me.colLogReqNo.Name = "colLogReqNo"
        '
        'colLogType
        '
        Me.colLogType.Caption = "Action Type"
        Me.colLogType.FieldName = "logtype"
        Me.colLogType.Name = "colLogType"
        Me.colLogType.OptionsColumn.FixedWidth = True
        Me.colLogType.Visible = True
        Me.colLogType.VisibleIndex = 2
        Me.colLogType.Width = 150
        '
        'colLogUuserId
        '
        Me.colLogUuserId.Caption = "User ID"
        Me.colLogUuserId.FieldName = "loguserid"
        Me.colLogUuserId.Name = "colLogUuserId"
        Me.colLogUuserId.OptionsColumn.FixedWidth = True
        Me.colLogUuserId.Visible = True
        Me.colLogUuserId.VisibleIndex = 3
        Me.colLogUuserId.Width = 100
        '
        'colLogUserName
        '
        Me.colLogUserName.Caption = "User Name"
        Me.colLogUserName.FieldName = "logusername"
        Me.colLogUserName.Name = "colLogUserName"
        Me.colLogUserName.OptionsColumn.FixedWidth = True
        Me.colLogUserName.Visible = True
        Me.colLogUserName.VisibleIndex = 4
        Me.colLogUserName.Width = 200
        '
        'colLogDetail
        '
        Me.colLogDetail.Caption = "Activity Detail"
        Me.colLogDetail.FieldName = "logdetail"
        Me.colLogDetail.Name = "colLogDetail"
        Me.colLogDetail.Visible = True
        Me.colLogDetail.VisibleIndex = 5
        Me.colLogDetail.Width = 560
        '
        'frmInvRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1204, 778)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmInvRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Request"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.dtRequest.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtRequest.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReason.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSmtCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtQtyNeed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQOH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.optReqType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstIAStat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtIApprove.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtIApprove.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIAName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIAID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTDepName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTDepCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstRAStat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtRApprove.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtRApprove.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRAName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRAID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReqName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReqID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFDepName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFDepCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.dgItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.dgCmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCmt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.dgLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents rvReq As SVIRS.RecordNavigator
    Friend WithEvents lstStatus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtRequest As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtRef As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtReason As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSmtCount As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnVoid As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRelease As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnArrival As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPurchase As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnReject As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnApprove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSendBack As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSubmit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lstIAStat As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents dtIApprove As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtIAName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIAID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTDepName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnTDepFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTDepCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lstRAStat As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents dtRApprove As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtRAName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRAID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtReqName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtReqID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFDepName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFDepCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents dgItem As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvItem As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnRemLine As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddLine As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents dgLog As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvLog As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents dgCmt As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCmt As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnComment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colItmReqno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLineNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReqQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReqUom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFLoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTLoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLineApprv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsuQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsuUOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLineCmt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCmtId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCmtReqNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCmtDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCmtUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCmtUName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogReqNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogUuserId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogDetail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnUse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtQtyNeed As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQOH As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblUOM1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblUOM As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLoc1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLoc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents optReqType As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
