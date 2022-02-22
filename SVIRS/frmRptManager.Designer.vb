<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptManager))
        Me.rvReport = New SVIRS.RecordNavigator()
        Me.txtDesc = New DevExpress.XtraEditors.TextEdit()
        Me.txtFile = New DevExpress.XtraEditors.TextEdit()
        Me.dgUList = New DevExpress.XtraGrid.GridControl()
        Me.gvUList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dgAlist = New DevExpress.XtraGrid.GridControl()
        Me.gvAList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colACode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRem = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.swSage = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.txtDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgUList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvUList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgAlist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvAList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.swSage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rvReport
        '
        Me.rvReport.CurrentValue = Nothing
        Me.rvReport.DataViewList = "Report"
        Me.rvReport.DeleteButtonHide = False
        Me.rvReport.DeleteButtonToolTip = "Delete"
        Me.rvReport.FilsterString = ""
        Me.rvReport.FindButtonToolTip = "Search"
        Me.rvReport.FinderCaption = ""
        Me.rvReport.FirstButtonToolTip = "First"
        Me.rvReport.LastButtonToolTip = "Last"
        Me.rvReport.Location = New System.Drawing.Point(126, 36)
        Me.rvReport.MaxLength = 0
        Me.rvReport.Name = "rvReport"
        Me.rvReport.NavigatorHide = False
        Me.rvReport.NewButtonHide = False
        Me.rvReport.NewButtonToolTip = "Create New"
        Me.rvReport.NextButtonToolTip = "Next"
        Me.rvReport.PreviousButtonToolTip = "Previous"
        Me.rvReport.PrintButtonHide = True
        Me.rvReport.PrintButtonToolTip = "Print"
        Me.rvReport.ReportDirectPrint = False
        Me.rvReport.ReportName = ""
        Me.rvReport.ReturnField = "RPTCODE"
        Me.rvReport.SaveButtonHide = False
        Me.rvReport.SaveButtonToolTip = "Save"
        Me.rvReport.Size = New System.Drawing.Size(369, 22)
        Me.rvReport.SourceType = 0
        Me.rvReport.TabIndex = 0
        Me.rvReport.ViewID = "Report"
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(126, 64)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(494, 20)
        Me.txtDesc.TabIndex = 1
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(126, 90)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(184, 20)
        Me.txtFile.TabIndex = 2
        '
        'dgUList
        '
        Me.dgUList.Location = New System.Drawing.Point(126, 196)
        Me.dgUList.MainView = Me.gvUList
        Me.dgUList.Name = "dgUList"
        Me.dgUList.Size = New System.Drawing.Size(392, 335)
        Me.dgUList.TabIndex = 3
        Me.dgUList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvUList})
        '
        'gvUList
        '
        Me.gvUList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUCode, Me.colUName})
        Me.gvUList.GridControl = Me.dgUList
        Me.gvUList.Name = "gvUList"
        Me.gvUList.OptionsBehavior.Editable = False
        Me.gvUList.OptionsBehavior.ReadOnly = True
        Me.gvUList.OptionsView.ShowGroupPanel = False
        Me.gvUList.OptionsView.ShowIndicator = False
        '
        'colUCode
        '
        Me.colUCode.Caption = "User ID"
        Me.colUCode.FieldName = "userid"
        Me.colUCode.Name = "colUCode"
        Me.colUCode.Visible = True
        Me.colUCode.VisibleIndex = 0
        '
        'colUName
        '
        Me.colUName.Caption = "User Name"
        Me.colUName.FieldName = "username"
        Me.colUName.Name = "colUName"
        Me.colUName.Visible = True
        Me.colUName.VisibleIndex = 1
        '
        'dgAlist
        '
        Me.dgAlist.Location = New System.Drawing.Point(605, 196)
        Me.dgAlist.MainView = Me.gvAList
        Me.dgAlist.Name = "dgAlist"
        Me.dgAlist.Size = New System.Drawing.Size(396, 335)
        Me.dgAlist.TabIndex = 4
        Me.dgAlist.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvAList})
        '
        'gvAList
        '
        Me.gvAList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colACode, Me.colAName})
        Me.gvAList.GridControl = Me.dgAlist
        Me.gvAList.Name = "gvAList"
        Me.gvAList.OptionsBehavior.Editable = False
        Me.gvAList.OptionsBehavior.ReadOnly = True
        Me.gvAList.OptionsView.ShowGroupPanel = False
        Me.gvAList.OptionsView.ShowIndicator = False
        '
        'colACode
        '
        Me.colACode.Caption = "User ID"
        Me.colACode.FieldName = "userid"
        Me.colACode.Name = "colACode"
        Me.colACode.Visible = True
        Me.colACode.VisibleIndex = 0
        '
        'colAName
        '
        Me.colAName.Caption = "User Name"
        Me.colAName.FieldName = "username"
        Me.colAName.Name = "colAName"
        Me.colAName.Visible = True
        Me.colAName.VisibleIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAdd.Location = New System.Drawing.Point(524, 219)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 5
        '
        'btnRem
        '
        Me.btnRem.Image = CType(resources.GetObject("btnRem.Image"), System.Drawing.Image)
        Me.btnRem.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRem.Location = New System.Drawing.Point(524, 248)
        Me.btnRem.Name = "btnRem"
        Me.btnRem.Size = New System.Drawing.Size(75, 23)
        Me.btnRem.TabIndex = 6
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 45)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Report Code"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 71)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "Description"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 97)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl3.TabIndex = 9
        Me.LabelControl3.Text = "File Name"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.LabelControl4.Location = New System.Drawing.Point(334, 97)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(118, 13)
        Me.LabelControl4.TabIndex = 10
        Me.LabelControl4.Text = "(Example: myreport.rpt)"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(126, 177)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl5.TabIndex = 11
        Me.LabelControl5.Text = "Unassigned Users"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(605, 177)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl6.TabIndex = 12
        Me.LabelControl6.Text = "Assigned Users"
        '
        'swSage
        '
        Me.swSage.Location = New System.Drawing.Point(126, 126)
        Me.swSage.Name = "swSage"
        Me.swSage.Properties.Caption = "This report is for Sage 300 ERP"
        Me.swSage.Size = New System.Drawing.Size(494, 20)
        Me.swSage.TabIndex = 13
        '
        'frmRptManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1187, 688)
        Me.Controls.Add(Me.swSage)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnRem)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgAlist)
        Me.Controls.Add(Me.dgUList)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.rvReport)
        Me.Name = "frmRptManager"
        Me.Text = "Report Manager"
        CType(Me.txtDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgUList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvUList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgAlist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvAList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.swSage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rvReport As SVIRS.RecordNavigator
    Friend WithEvents txtDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFile As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dgUList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvUList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dgAlist As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvAList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents swSage As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colUCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAName As DevExpress.XtraGrid.Columns.GridColumn
End Class
