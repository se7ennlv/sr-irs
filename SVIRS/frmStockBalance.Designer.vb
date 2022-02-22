<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockBalance
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
        Me.rvItem = New SVIRS.RecordNavigator()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDesc = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.dgStock = New DevExpress.XtraGrid.GridControl()
        Me.gvStock = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUOM = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.txtDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.dgStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rvItem
        '
        Me.rvItem.CurrentValue = Nothing
        Me.rvItem.DataViewList = "Item"
        Me.rvItem.DeleteButtonHide = True
        Me.rvItem.DeleteButtonToolTip = "Delete"
        Me.rvItem.FilsterString = "INACTIVE = 0"
        Me.rvItem.FindButtonToolTip = "Search"
        Me.rvItem.FinderCaption = "Item Finder"
        Me.rvItem.FirstButtonToolTip = "First"
        Me.rvItem.LastButtonToolTip = "Last"
        Me.rvItem.Location = New System.Drawing.Point(89, 12)
        Me.rvItem.MaxLength = 0
        Me.rvItem.Name = "rvItem"
        Me.rvItem.NavigatorHide = False
        Me.rvItem.NewButtonHide = True
        Me.rvItem.NewButtonToolTip = "Create New"
        Me.rvItem.NextButtonToolTip = "Next"
        Me.rvItem.PreviousButtonToolTip = "Previous"
        Me.rvItem.PrintButtonHide = True
        Me.rvItem.PrintButtonToolTip = "Print"
        Me.rvItem.ReportDirectPrint = False
        Me.rvItem.ReportName = ""
        Me.rvItem.ReturnField = "ITEMNO"
        Me.rvItem.SaveButtonHide = True
        Me.rvItem.SaveButtonToolTip = "Save"
        Me.rvItem.Size = New System.Drawing.Size(259, 22)
        Me.rvItem.SourceType = 1
        Me.rvItem.TabIndex = 0
        Me.rvItem.ViewID = "Item"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(5, 17)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Item Number"
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(354, 14)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Properties.ReadOnly = True
        Me.txtDesc.Size = New System.Drawing.Size(462, 20)
        Me.txtDesc.TabIndex = 2
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.rvItem)
        Me.PanelControl1.Controls.Add(Me.txtDesc)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(971, 49)
        Me.PanelControl1.TabIndex = 3
        '
        'dgStock
        '
        Me.dgStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgStock.Location = New System.Drawing.Point(0, 49)
        Me.dgStock.MainView = Me.gvStock
        Me.dgStock.Name = "dgStock"
        Me.dgStock.Size = New System.Drawing.Size(971, 564)
        Me.dgStock.TabIndex = 4
        Me.dgStock.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvStock})
        '
        'gvStock
        '
        Me.gvStock.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLocation, Me.colDesc, Me.colQty, Me.colUOM})
        Me.gvStock.GridControl = Me.dgStock
        Me.gvStock.Name = "gvStock"
        Me.gvStock.OptionsView.ShowGroupPanel = False
        Me.gvStock.OptionsView.ShowIndicator = False
        '
        'colLocation
        '
        Me.colLocation.Caption = "Location"
        Me.colLocation.FieldName = "LOCATION"
        Me.colLocation.Name = "colLocation"
        Me.colLocation.OptionsColumn.AllowEdit = False
        Me.colLocation.OptionsColumn.FixedWidth = True
        Me.colLocation.OptionsColumn.ReadOnly = True
        Me.colLocation.Visible = True
        Me.colLocation.VisibleIndex = 0
        Me.colLocation.Width = 120
        '
        'colDesc
        '
        Me.colDesc.Caption = "Location Description"
        Me.colDesc.FieldName = "DESC"
        Me.colDesc.Name = "colDesc"
        Me.colDesc.OptionsColumn.AllowEdit = False
        Me.colDesc.OptionsColumn.ReadOnly = True
        Me.colDesc.Visible = True
        Me.colDesc.VisibleIndex = 1
        Me.colDesc.Width = 283
        '
        'colQty
        '
        Me.colQty.Caption = "Qty On Hand"
        Me.colQty.FieldName = "QTYONHAND"
        Me.colQty.Name = "colQty"
        Me.colQty.OptionsColumn.AllowEdit = False
        Me.colQty.OptionsColumn.FixedWidth = True
        Me.colQty.OptionsColumn.ReadOnly = True
        Me.colQty.Visible = True
        Me.colQty.VisibleIndex = 2
        Me.colQty.Width = 120
        '
        'colUOM
        '
        Me.colUOM.Caption = "Unit of Measure"
        Me.colUOM.FieldName = "COSTUNIT"
        Me.colUOM.Name = "colUOM"
        Me.colUOM.OptionsColumn.AllowEdit = False
        Me.colUOM.OptionsColumn.FixedWidth = True
        Me.colUOM.OptionsColumn.ReadOnly = True
        Me.colUOM.Visible = True
        Me.colUOM.VisibleIndex = 3
        Me.colUOM.Width = 150
        '
        'frmStockBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 613)
        Me.Controls.Add(Me.dgStock)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmStockBalance"
        Me.Text = "Stock Balance"
        CType(Me.txtDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.dgStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rvItem As SVIRS.RecordNavigator
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dgStock As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvStock As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colLocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUOM As DevExpress.XtraGrid.Columns.GridColumn
End Class
