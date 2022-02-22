<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMyApproval
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
        Me.btnRelease = New DevExpress.XtraEditors.SimpleButton()
        Me.btnArrival = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPurchase = New DevExpress.XtraEditors.SimpleButton()
        Me.btnReject = New DevExpress.XtraEditors.SimpleButton()
        Me.btnApprove = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSendBack = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.dgApprove = New DevExpress.XtraGrid.GridControl()
        Me.gvApprove = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRoutID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReqNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFDep = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReason = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApprvSeq = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.dgApprove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvApprove, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnRelease)
        Me.PanelControl1.Controls.Add(Me.btnArrival)
        Me.PanelControl1.Controls.Add(Me.btnPurchase)
        Me.PanelControl1.Controls.Add(Me.btnReject)
        Me.PanelControl1.Controls.Add(Me.btnApprove)
        Me.PanelControl1.Controls.Add(Me.btnSendBack)
        Me.PanelControl1.Controls.Add(Me.SimpleButton1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1075, 66)
        Me.PanelControl1.TabIndex = 0
        '
        'btnRelease
        '
        Me.btnRelease.Enabled = False
        Me.btnRelease.Location = New System.Drawing.Point(716, 22)
        Me.btnRelease.Name = "btnRelease"
        Me.btnRelease.Size = New System.Drawing.Size(75, 23)
        Me.btnRelease.TabIndex = 9
        Me.btnRelease.Text = "Release"
        '
        'btnArrival
        '
        Me.btnArrival.Enabled = False
        Me.btnArrival.Location = New System.Drawing.Point(635, 22)
        Me.btnArrival.Name = "btnArrival"
        Me.btnArrival.Size = New System.Drawing.Size(75, 23)
        Me.btnArrival.TabIndex = 8
        Me.btnArrival.Text = "Stock Arrival"
        '
        'btnPurchase
        '
        Me.btnPurchase.Enabled = False
        Me.btnPurchase.Location = New System.Drawing.Point(523, 22)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(106, 23)
        Me.btnPurchase.TabIndex = 7
        Me.btnPurchase.Text = "Send To Purchase"
        '
        'btnReject
        '
        Me.btnReject.Enabled = False
        Me.btnReject.Location = New System.Drawing.Point(373, 22)
        Me.btnReject.Name = "btnReject"
        Me.btnReject.Size = New System.Drawing.Size(75, 23)
        Me.btnReject.TabIndex = 6
        Me.btnReject.Text = "Reject"
        '
        'btnApprove
        '
        Me.btnApprove.Enabled = False
        Me.btnApprove.Location = New System.Drawing.Point(292, 22)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(75, 23)
        Me.btnApprove.TabIndex = 5
        Me.btnApprove.Text = "Approve"
        '
        'btnSendBack
        '
        Me.btnSendBack.Enabled = False
        Me.btnSendBack.Location = New System.Drawing.Point(211, 22)
        Me.btnSendBack.Name = "btnSendBack"
        Me.btnSendBack.Size = New System.Drawing.Size(75, 23)
        Me.btnSendBack.TabIndex = 4
        Me.btnSendBack.Text = "Send Back"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(28, 22)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(113, 23)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "Refresh"
        '
        'dgApprove
        '
        Me.dgApprove.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgApprove.Location = New System.Drawing.Point(0, 66)
        Me.dgApprove.MainView = Me.gvApprove
        Me.dgApprove.Name = "dgApprove"
        Me.dgApprove.Size = New System.Drawing.Size(1075, 599)
        Me.dgApprove.TabIndex = 1
        Me.dgApprove.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvApprove})
        '
        'gvApprove
        '
        Me.gvApprove.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRoutID, Me.colReqNo, Me.colFDep, Me.colReason, Me.colApprvSeq, Me.colStatus})
        Me.gvApprove.GridControl = Me.dgApprove
        Me.gvApprove.Name = "gvApprove"
        Me.gvApprove.OptionsBehavior.Editable = False
        Me.gvApprove.OptionsBehavior.ReadOnly = True
        Me.gvApprove.OptionsView.ShowGroupPanel = False
        Me.gvApprove.OptionsView.ShowIndicator = False
        '
        'colRoutID
        '
        Me.colRoutID.Caption = "routid"
        Me.colRoutID.FieldName = "routid"
        Me.colRoutID.Name = "colRoutID"
        '
        'colReqNo
        '
        Me.colReqNo.Caption = "Requst No"
        Me.colReqNo.FieldName = "reqno"
        Me.colReqNo.Name = "colReqNo"
        Me.colReqNo.OptionsColumn.AllowEdit = False
        Me.colReqNo.OptionsColumn.FixedWidth = True
        Me.colReqNo.Visible = True
        Me.colReqNo.VisibleIndex = 0
        Me.colReqNo.Width = 120
        '
        'colFDep
        '
        Me.colFDep.Caption = "From Department"
        Me.colFDep.FieldName = "fromdep"
        Me.colFDep.Name = "colFDep"
        Me.colFDep.OptionsColumn.AllowEdit = False
        Me.colFDep.OptionsColumn.FixedWidth = True
        Me.colFDep.Visible = True
        Me.colFDep.VisibleIndex = 1
        Me.colFDep.Width = 120
        '
        'colReason
        '
        Me.colReason.Caption = "Reason"
        Me.colReason.FieldName = "reason"
        Me.colReason.Name = "colReason"
        Me.colReason.Visible = True
        Me.colReason.VisibleIndex = 2
        Me.colReason.Width = 831
        '
        'colApprvSeq
        '
        Me.colApprvSeq.Caption = "approvseq"
        Me.colApprvSeq.FieldName = "approvseq"
        Me.colApprvSeq.Name = "colApprvSeq"
        '
        'colStatus
        '
        Me.colStatus.Caption = "status"
        Me.colStatus.FieldName = "reqstat"
        Me.colStatus.Name = "colStatus"
        '
        'frmMyApproval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 665)
        Me.Controls.Add(Me.dgApprove)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmMyApproval"
        Me.Text = "My Approval"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.dgApprove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvApprove, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgApprove As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvApprove As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRoutID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReqNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFDep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReason As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnReject As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnApprove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSendBack As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRelease As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnArrival As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPurchase As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colApprvSeq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
End Class
