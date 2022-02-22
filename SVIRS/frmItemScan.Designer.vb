<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemScan
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
        Me.txtSearch = New DevExpress.XtraEditors.TextEdit()
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.txtItemNo = New DevExpress.XtraEditors.TextEdit()
        Me.txtItemDesc = New DevExpress.XtraEditors.TextEdit()
        Me.lstUOM = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtReqQty = New DevExpress.XtraEditors.SpinEdit()
        Me.lstToLocation = New DevExpress.XtraEditors.LookUpEdit()
        Me.lstFromLocation = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtComment = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstUOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReqQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstToLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstFromLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(40, 42)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(248, 20)
        Me.txtSearch.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(294, 40)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        '
        'txtItemNo
        '
        Me.txtItemNo.Location = New System.Drawing.Point(40, 107)
        Me.txtItemNo.Name = "txtItemNo"
        Me.txtItemNo.Properties.ReadOnly = True
        Me.txtItemNo.Size = New System.Drawing.Size(125, 20)
        Me.txtItemNo.TabIndex = 2
        '
        'txtItemDesc
        '
        Me.txtItemDesc.Location = New System.Drawing.Point(171, 107)
        Me.txtItemDesc.Name = "txtItemDesc"
        Me.txtItemDesc.Properties.ReadOnly = True
        Me.txtItemDesc.Size = New System.Drawing.Size(372, 20)
        Me.txtItemDesc.TabIndex = 3
        '
        'lstUOM
        '
        Me.lstUOM.Location = New System.Drawing.Point(40, 158)
        Me.lstUOM.Name = "lstUOM"
        Me.lstUOM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lstUOM.Properties.DisplayMember = "UNIT"
        Me.lstUOM.Properties.ShowFooter = False
        Me.lstUOM.Properties.ShowHeader = False
        Me.lstUOM.Properties.ValueMember = "UNIT"
        Me.lstUOM.Size = New System.Drawing.Size(125, 20)
        Me.lstUOM.TabIndex = 4
        '
        'txtReqQty
        '
        Me.txtReqQty.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtReqQty.Location = New System.Drawing.Point(171, 158)
        Me.txtReqQty.Name = "txtReqQty"
        Me.txtReqQty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtReqQty.Size = New System.Drawing.Size(117, 20)
        Me.txtReqQty.TabIndex = 5
        '
        'lstToLocation
        '
        Me.lstToLocation.Location = New System.Drawing.Point(40, 211)
        Me.lstToLocation.Name = "lstToLocation"
        Me.lstToLocation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lstToLocation.Properties.DisplayMember = "locdesc"
        Me.lstToLocation.Properties.ShowFooter = False
        Me.lstToLocation.Properties.ShowHeader = False
        Me.lstToLocation.Properties.ValueMember = "location"
        Me.lstToLocation.Size = New System.Drawing.Size(329, 20)
        Me.lstToLocation.TabIndex = 6
        '
        'lstFromLocation
        '
        Me.lstFromLocation.Location = New System.Drawing.Point(40, 265)
        Me.lstFromLocation.Name = "lstFromLocation"
        Me.lstFromLocation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lstFromLocation.Properties.DisplayMember = "locdesc"
        Me.lstFromLocation.Properties.ShowFooter = False
        Me.lstFromLocation.Properties.ShowHeader = False
        Me.lstFromLocation.Properties.ValueMember = "location"
        Me.lstFromLocation.Size = New System.Drawing.Size(329, 20)
        Me.lstFromLocation.TabIndex = 7
        '
        'txtComment
        '
        Me.txtComment.Location = New System.Drawing.Point(40, 329)
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(503, 20)
        Me.txtComment.TabIndex = 8
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(40, 23)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(111, 13)
        Me.LabelControl1.TabIndex = 9
        Me.LabelControl1.Text = "Item Number / Barcode"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(40, 88)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl2.TabIndex = 10
        Me.LabelControl2.Text = "Item #"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(171, 88)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "Item Description"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(40, 139)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl4.TabIndex = 12
        Me.LabelControl4.Text = "UOM"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(171, 139)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl5.TabIndex = 13
        Me.LabelControl5.Text = "Request Qty"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(40, 192)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl6.TabIndex = 14
        Me.LabelControl6.Text = "To My Location"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(40, 246)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl7.TabIndex = 15
        Me.LabelControl7.Text = "From Location"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(40, 310)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl8.TabIndex = 16
        Me.LabelControl8.Text = "Comments"
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.Location = New System.Drawing.Point(40, 374)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "Add"
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(135, 374)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "Cancel"
        '
        'frmItemScan
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(763, 421)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.lstFromLocation)
        Me.Controls.Add(Me.lstToLocation)
        Me.Controls.Add(Me.txtReqQty)
        Me.Controls.Add(Me.lstUOM)
        Me.Controls.Add(Me.txtItemDesc)
        Me.Controls.Add(Me.txtItemNo)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmItemScan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Request"
        CType(Me.txtSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstUOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReqQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstToLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstFromLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtItemNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtItemDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lstUOM As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtReqQty As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lstToLocation As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lstFromLocation As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtComment As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
End Class
