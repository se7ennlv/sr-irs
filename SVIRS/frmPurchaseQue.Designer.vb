<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchaseQue
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
        Me.btnCreatePR = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.dgItem = New DevExpress.XtraGrid.GridControl()
        Me.gvItem = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLineNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFDep = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReqNo = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.dgItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnCreatePR)
        Me.PanelControl1.Controls.Add(Me.btnRefresh)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1176, 67)
        Me.PanelControl1.TabIndex = 0
        '
        'btnCreatePR
        '
        Me.btnCreatePR.Enabled = False
        Me.btnCreatePR.Location = New System.Drawing.Point(138, 23)
        Me.btnCreatePR.Name = "btnCreatePR"
        Me.btnCreatePR.Size = New System.Drawing.Size(75, 23)
        Me.btnCreatePR.TabIndex = 1
        Me.btnCreatePR.Text = "Creat a PR"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(12, 23)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 0
        Me.btnRefresh.Text = "Refresh"
        '
        'dgItem
        '
        Me.dgItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgItem.Location = New System.Drawing.Point(0, 67)
        Me.dgItem.MainView = Me.gvItem
        Me.dgItem.Name = "dgItem"
        Me.dgItem.Size = New System.Drawing.Size(1176, 655)
        Me.dgItem.TabIndex = 1
        Me.dgItem.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvItem})
        '
        'gvItem
        '
        Me.gvItem.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLineNo, Me.colItemNo, Me.colDesc, Me.colQty, Me.colUOM, Me.colDate, Me.colLocation, Me.colFDep, Me.colPR, Me.colReqNo})
        Me.gvItem.GridControl = Me.dgItem
        Me.gvItem.Name = "gvItem"
        Me.gvItem.OptionsView.ShowGroupPanel = False
        Me.gvItem.OptionsView.ShowIndicator = False
        '
        'colLineNo
        '
        Me.colLineNo.Caption = "No."
        Me.colLineNo.FieldName = "linenum"
        Me.colLineNo.Name = "colLineNo"
        Me.colLineNo.OptionsColumn.AllowEdit = False
        Me.colLineNo.OptionsColumn.FixedWidth = True
        Me.colLineNo.OptionsColumn.ReadOnly = True
        Me.colLineNo.Visible = True
        Me.colLineNo.VisibleIndex = 0
        Me.colLineNo.Width = 100
        '
        'colItemNo
        '
        Me.colItemNo.Caption = "Item No"
        Me.colItemNo.FieldName = "itemno"
        Me.colItemNo.Name = "colItemNo"
        Me.colItemNo.OptionsColumn.AllowEdit = False
        Me.colItemNo.OptionsColumn.FixedWidth = True
        Me.colItemNo.OptionsColumn.ReadOnly = True
        Me.colItemNo.Visible = True
        Me.colItemNo.VisibleIndex = 1
        Me.colItemNo.Width = 120
        '
        'colDesc
        '
        Me.colDesc.Caption = "Description"
        Me.colDesc.FieldName = "itemdesc"
        Me.colDesc.Name = "colDesc"
        Me.colDesc.Visible = True
        Me.colDesc.VisibleIndex = 2
        Me.colDesc.Width = 102
        '
        'colQty
        '
        Me.colQty.Caption = "Qty"
        Me.colQty.FieldName = "reqqty"
        Me.colQty.Name = "colQty"
        Me.colQty.OptionsColumn.AllowEdit = False
        Me.colQty.OptionsColumn.FixedWidth = True
        Me.colQty.OptionsColumn.ReadOnly = True
        Me.colQty.Visible = True
        Me.colQty.VisibleIndex = 3
        Me.colQty.Width = 110
        '
        'colUOM
        '
        Me.colUOM.Caption = "UOM"
        Me.colUOM.FieldName = "requom"
        Me.colUOM.Name = "colUOM"
        Me.colUOM.OptionsColumn.AllowEdit = False
        Me.colUOM.OptionsColumn.FixedWidth = True
        Me.colUOM.OptionsColumn.ReadOnly = True
        Me.colUOM.Visible = True
        Me.colUOM.VisibleIndex = 4
        Me.colUOM.Width = 100
        '
        'colDate
        '
        Me.colDate.Caption = "Requested On"
        Me.colDate.FieldName = "reqdate"
        Me.colDate.Name = "colDate"
        Me.colDate.OptionsColumn.AllowEdit = False
        Me.colDate.OptionsColumn.FixedWidth = True
        Me.colDate.OptionsColumn.ReadOnly = True
        Me.colDate.Visible = True
        Me.colDate.VisibleIndex = 5
        Me.colDate.Width = 100
        '
        'colLocation
        '
        Me.colLocation.Caption = "Location"
        Me.colLocation.FieldName = "location"
        Me.colLocation.Name = "colLocation"
        Me.colLocation.OptionsColumn.AllowEdit = False
        Me.colLocation.OptionsColumn.FixedWidth = True
        Me.colLocation.OptionsColumn.ReadOnly = True
        Me.colLocation.Visible = True
        Me.colLocation.VisibleIndex = 6
        Me.colLocation.Width = 100
        '
        'colFDep
        '
        Me.colFDep.Caption = "From Department"
        Me.colFDep.FieldName = "reqdep"
        Me.colFDep.Name = "colFDep"
        Me.colFDep.OptionsColumn.AllowEdit = False
        Me.colFDep.OptionsColumn.FixedWidth = True
        Me.colFDep.OptionsColumn.ReadOnly = True
        Me.colFDep.Visible = True
        Me.colFDep.VisibleIndex = 7
        Me.colFDep.Width = 100
        '
        'colPR
        '
        Me.colPR.Caption = "PR"
        Me.colPR.FieldName = "haspr"
        Me.colPR.Name = "colPR"
        Me.colPR.OptionsColumn.FixedWidth = True
        Me.colPR.Visible = True
        Me.colPR.VisibleIndex = 8
        Me.colPR.Width = 100
        '
        'colReqNo
        '
        Me.colReqNo.Caption = "GridColumn1"
        Me.colReqNo.FieldName = "reqno"
        Me.colReqNo.Name = "colReqNo"
        '
        'frmPurchaseQue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1176, 722)
        Me.Controls.Add(Me.dgItem)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmPurchaseQue"
        Me.Text = "Purchase Queue"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.dgItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dgItem As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvItem As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnCreatePR As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colLineNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFDep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReqNo As DevExpress.XtraGrid.Columns.GridColumn
End Class
