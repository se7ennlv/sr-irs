<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMyRequest
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnUse = New DevExpress.XtraEditors.SimpleButton()
        Me.btnVoid = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSubmit = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.lstStatus = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSearch = New DevExpress.XtraEditors.TextEdit()
        Me.dgRequest = New DevExpress.XtraGrid.GridControl()
        Me.gvRequest = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colReqNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReason = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colToDep = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.lstStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnUse)
        Me.PanelControl1.Controls.Add(Me.btnVoid)
        Me.PanelControl1.Controls.Add(Me.btnSubmit)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.lstStatus)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.txtSearch)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(964, 93)
        Me.PanelControl1.TabIndex = 0
        '
        'btnUse
        '
        Me.btnUse.Enabled = False
        Me.btnUse.Location = New System.Drawing.Point(622, 51)
        Me.btnUse.Name = "btnUse"
        Me.btnUse.Size = New System.Drawing.Size(75, 23)
        Me.btnUse.TabIndex = 12
        Me.btnUse.Text = "Use"
        Me.btnUse.Visible = False
        '
        'btnVoid
        '
        Me.btnVoid.Enabled = False
        Me.btnVoid.Location = New System.Drawing.Point(703, 51)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(75, 23)
        Me.btnVoid.TabIndex = 11
        Me.btnVoid.Text = "Void"
        '
        'btnSubmit
        '
        Me.btnSubmit.Enabled = False
        Me.btnSubmit.Location = New System.Drawing.Point(541, 51)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 10
        Me.btnSubmit.Text = "Submit"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(22, 56)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Status"
        '
        'lstStatus
        '
        Me.lstStatus.Location = New System.Drawing.Point(105, 53)
        Me.lstStatus.Name = "lstStatus"
        Me.lstStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lstStatus.Properties.Items.AddRange(New Object() {"New", "Submitted", "Pending Approved", "Editing Required", "Rejected", "Approved", "Waiting for Purchase", "Stock Arrival", "Item Released", "Voided", "Used"})
        Me.lstStatus.Size = New System.Drawing.Size(159, 20)
        Me.lstStatus.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(22, 30)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Search For"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(105, 27)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(311, 20)
        Me.txtSearch.TabIndex = 0
        '
        'dgRequest
        '
        Me.dgRequest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgRequest.Location = New System.Drawing.Point(0, 93)
        Me.dgRequest.MainView = Me.gvRequest
        Me.dgRequest.Name = "dgRequest"
        Me.dgRequest.Size = New System.Drawing.Size(964, 636)
        Me.dgRequest.TabIndex = 1
        Me.dgRequest.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvRequest})
        '
        'gvRequest
        '
        Me.gvRequest.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colReqNo, Me.colDate, Me.colReason, Me.colToDep, Me.colStatus})
        Me.gvRequest.GridControl = Me.dgRequest
        Me.gvRequest.Name = "gvRequest"
        Me.gvRequest.OptionsBehavior.Editable = False
        Me.gvRequest.OptionsBehavior.ReadOnly = True
        Me.gvRequest.OptionsView.ShowGroupPanel = False
        Me.gvRequest.OptionsView.ShowIndicator = False
        '
        'colReqNo
        '
        Me.colReqNo.Caption = "Request No"
        Me.colReqNo.FieldName = "reqno"
        Me.colReqNo.Name = "colReqNo"
        Me.colReqNo.OptionsColumn.AllowEdit = False
        Me.colReqNo.OptionsColumn.FixedWidth = True
        Me.colReqNo.Visible = True
        Me.colReqNo.VisibleIndex = 0
        Me.colReqNo.Width = 120
        '
        'colDate
        '
        Me.colDate.Caption = "Request Date"
        Me.colDate.FieldName = "reqdate"
        Me.colDate.Name = "colDate"
        Me.colDate.OptionsColumn.AllowEdit = False
        Me.colDate.Visible = True
        Me.colDate.VisibleIndex = 1
        Me.colDate.Width = 396
        '
        'colReason
        '
        Me.colReason.Caption = "Reason"
        Me.colReason.FieldName = "reason"
        Me.colReason.Name = "colReason"
        Me.colReason.Visible = True
        Me.colReason.VisibleIndex = 2
        Me.colReason.Width = 249
        '
        'colToDep
        '
        Me.colToDep.Caption = "To Department"
        Me.colToDep.FieldName = "invdep"
        Me.colToDep.Name = "colToDep"
        Me.colToDep.OptionsColumn.AllowEdit = False
        Me.colToDep.OptionsColumn.FixedWidth = True
        Me.colToDep.Visible = True
        Me.colToDep.VisibleIndex = 3
        Me.colToDep.Width = 120
        '
        'colStatus
        '
        Me.colStatus.Caption = "Status"
        Me.colStatus.FieldName = "reqstat"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.OptionsColumn.AllowEdit = False
        Me.colStatus.OptionsColumn.FixedWidth = True
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 4
        Me.colStatus.Width = 100
        '
        'frmMyRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 729)
        Me.Controls.Add(Me.dgRequest)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmMyRequest"
        Me.Text = "My Requests"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.lstStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgRequest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRequest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dgRequest As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvRequest As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colReqNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReason As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colToDep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lstStatus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnUse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnVoid As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSubmit As DevExpress.XtraEditors.SimpleButton
End Class
