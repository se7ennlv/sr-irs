<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
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
        Me.txtFName = New DevExpress.XtraEditors.TextEdit()
        Me.txtLName = New DevExpress.XtraEditors.TextEdit()
        Me.txtPwd = New DevExpress.XtraEditors.TextEdit()
        Me.swActive = New DevExpress.XtraEditors.CheckEdit()
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.txtSageId = New DevExpress.XtraEditors.TextEdit()
        Me.txtSagePwd = New DevExpress.XtraEditors.TextEdit()
        Me.lstUType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.lstUser = New SVIRS.RecordNavigator()
        Me.txtJobTitle = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtFName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPwd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.swActive.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSageId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSagePwd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstUType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJobTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(142, 55)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(353, 20)
        Me.txtFName.TabIndex = 1
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(142, 81)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(353, 20)
        Me.txtLName.TabIndex = 2
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(142, 230)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Properties.UseSystemPasswordChar = True
        Me.txtPwd.Size = New System.Drawing.Size(225, 20)
        Me.txtPwd.TabIndex = 3
        '
        'swActive
        '
        Me.swActive.Location = New System.Drawing.Point(420, 229)
        Me.swActive.Name = "swActive"
        Me.swActive.Properties.Caption = "Active"
        Me.swActive.Size = New System.Drawing.Size(75, 20)
        Me.swActive.TabIndex = 4
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(142, 256)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(353, 20)
        Me.txtEmail.TabIndex = 5
        '
        'txtSageId
        '
        Me.txtSageId.Location = New System.Drawing.Point(142, 282)
        Me.txtSageId.Name = "txtSageId"
        Me.txtSageId.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSageId.Size = New System.Drawing.Size(120, 20)
        Me.txtSageId.TabIndex = 6
        '
        'txtSagePwd
        '
        Me.txtSagePwd.Location = New System.Drawing.Point(142, 308)
        Me.txtSagePwd.Name = "txtSagePwd"
        Me.txtSagePwd.Properties.UseSystemPasswordChar = True
        Me.txtSagePwd.Size = New System.Drawing.Size(225, 20)
        Me.txtSagePwd.TabIndex = 7
        '
        'lstUType
        '
        Me.lstUType.Location = New System.Drawing.Point(142, 107)
        Me.lstUType.Name = "lstUType"
        Me.lstUType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lstUType.Properties.Items.AddRange(New Object() {"Requestor", "Approver", "Inventory Controller", "System Admin"})
        Me.lstUType.Size = New System.Drawing.Size(225, 20)
        Me.lstUType.TabIndex = 8
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 26)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl1.TabIndex = 9
        Me.LabelControl1.Text = "User ID"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 58)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl2.TabIndex = 10
        Me.LabelControl2.Text = "First Name"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 84)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "Last Name"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 110)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl4.TabIndex = 12
        Me.LabelControl4.Text = "User Type"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 233)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl5.TabIndex = 13
        Me.LabelControl5.Text = "Password"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(12, 259)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl6.TabIndex = 14
        Me.LabelControl6.Text = "Email Address"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(12, 285)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl7.TabIndex = 15
        Me.LabelControl7.Text = "Sage User"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(12, 311)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl8.TabIndex = 16
        Me.LabelControl8.Text = "Sage Password"
        '
        'lstUser
        '
        Me.lstUser.CurrentValue = Nothing
        Me.lstUser.DataViewList = "SystemUser"
        Me.lstUser.DeleteButtonHide = False
        Me.lstUser.DeleteButtonToolTip = "Delete"
        Me.lstUser.FilsterString = ""
        Me.lstUser.FindButtonToolTip = "Search"
        Me.lstUser.FinderCaption = "User Find"
        Me.lstUser.FirstButtonToolTip = "First"
        Me.lstUser.LastButtonToolTip = "Last"
        Me.lstUser.Location = New System.Drawing.Point(142, 17)
        Me.lstUser.MaxLength = 0
        Me.lstUser.Name = "lstUser"
        Me.lstUser.NavigatorHide = False
        Me.lstUser.NewButtonHide = False
        Me.lstUser.NewButtonToolTip = "Create New"
        Me.lstUser.NextButtonToolTip = "Next"
        Me.lstUser.PreviousButtonToolTip = "Previous"
        Me.lstUser.PrintButtonHide = False
        Me.lstUser.PrintButtonToolTip = "Print"
        Me.lstUser.ReportDirectPrint = False
        Me.lstUser.ReportName = "userlist"
        Me.lstUser.ReturnField = "USERID"
        Me.lstUser.SaveButtonHide = False
        Me.lstUser.SaveButtonToolTip = "Save"
        Me.lstUser.Size = New System.Drawing.Size(353, 22)
        Me.lstUser.SourceType = 0
        Me.lstUser.TabIndex = 17
        Me.lstUser.ViewID = "SystemUser"
        '
        'txtJobTitle
        '
        Me.txtJobTitle.Location = New System.Drawing.Point(142, 133)
        Me.txtJobTitle.Name = "txtJobTitle"
        Me.txtJobTitle.Size = New System.Drawing.Size(353, 20)
        Me.txtJobTitle.TabIndex = 18
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(12, 140)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl9.TabIndex = 19
        Me.LabelControl9.Text = "Job Title"
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 508)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txtJobTitle)
        Me.Controls.Add(Me.lstUser)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.lstUType)
        Me.Controls.Add(Me.txtSagePwd)
        Me.Controls.Add(Me.txtSageId)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.swActive)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.txtFName)
        Me.Name = "frmUser"
        Me.Text = "User Maintenance"
        CType(Me.txtFName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPwd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.swActive.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSageId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSagePwd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstUType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJobTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPwd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents swActive As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSageId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSagePwd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lstUType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lstUser As SVIRS.RecordNavigator
    Friend WithEvents txtJobTitle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
End Class
