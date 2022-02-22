<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsrProfile
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
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.lstUType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtSagePwd = New DevExpress.XtraEditors.TextEdit()
        Me.txtSageId = New DevExpress.XtraEditors.TextEdit()
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.swActive = New DevExpress.XtraEditors.CheckEdit()
        Me.txtPwd = New DevExpress.XtraEditors.TextEdit()
        Me.txtLName = New DevExpress.XtraEditors.TextEdit()
        Me.txtFName = New DevExpress.XtraEditors.TextEdit()
        Me.txtUID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnUpdate = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.lstUType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSagePwd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSageId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.swActive.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPwd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(18, 229)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl8.TabIndex = 31
        Me.LabelControl8.Text = "Sage Password"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(18, 203)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl7.TabIndex = 30
        Me.LabelControl7.Text = "Sage User"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(18, 177)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl6.TabIndex = 29
        Me.LabelControl6.Text = "Email Address"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(18, 151)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl5.TabIndex = 28
        Me.LabelControl5.Text = "Password"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(18, 107)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl4.TabIndex = 27
        Me.LabelControl4.Text = "User Type"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(18, 81)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl3.TabIndex = 26
        Me.LabelControl3.Text = "Last Name"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(18, 55)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl2.TabIndex = 25
        Me.LabelControl2.Text = "First Name"
        '
        'lstUType
        '
        Me.lstUType.Location = New System.Drawing.Point(148, 104)
        Me.lstUType.Name = "lstUType"
        Me.lstUType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lstUType.Properties.Items.AddRange(New Object() {"Requestor", "Approver", "Inventory Controller", "System Admin"})
        Me.lstUType.Properties.ReadOnly = True
        Me.lstUType.Size = New System.Drawing.Size(225, 20)
        Me.lstUType.TabIndex = 24
        '
        'txtSagePwd
        '
        Me.txtSagePwd.Location = New System.Drawing.Point(148, 226)
        Me.txtSagePwd.Name = "txtSagePwd"
        Me.txtSagePwd.Properties.UseSystemPasswordChar = True
        Me.txtSagePwd.Size = New System.Drawing.Size(225, 20)
        Me.txtSagePwd.TabIndex = 23
        '
        'txtSageId
        '
        Me.txtSageId.Location = New System.Drawing.Point(148, 200)
        Me.txtSageId.Name = "txtSageId"
        Me.txtSageId.Size = New System.Drawing.Size(225, 20)
        Me.txtSageId.TabIndex = 22
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(148, 174)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(424, 20)
        Me.txtEmail.TabIndex = 21
        '
        'swActive
        '
        Me.swActive.Location = New System.Drawing.Point(426, 147)
        Me.swActive.Name = "swActive"
        Me.swActive.Properties.Caption = "Active"
        Me.swActive.Properties.ReadOnly = True
        Me.swActive.Size = New System.Drawing.Size(75, 20)
        Me.swActive.TabIndex = 20
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(148, 148)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Properties.UseSystemPasswordChar = True
        Me.txtPwd.Size = New System.Drawing.Size(225, 20)
        Me.txtPwd.TabIndex = 19
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(148, 78)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(424, 20)
        Me.txtLName.TabIndex = 18
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(148, 52)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(424, 20)
        Me.txtFName.TabIndex = 17
        '
        'txtUID
        '
        Me.txtUID.Location = New System.Drawing.Point(148, 12)
        Me.txtUID.Name = "txtUID"
        Me.txtUID.Properties.ReadOnly = True
        Me.txtUID.Size = New System.Drawing.Size(225, 20)
        Me.txtUID.TabIndex = 32
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(18, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl1.TabIndex = 33
        Me.LabelControl1.Text = "User ID"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(148, 252)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 34
        Me.btnUpdate.Text = "Update"
        '
        'frmUsrProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 302)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtUID)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.lstUType)
        Me.Controls.Add(Me.txtSagePwd)
        Me.Controls.Add(Me.txtSageId)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.swActive)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.txtFName)
        Me.Name = "frmUsrProfile"
        Me.Text = "My Profile"
        CType(Me.lstUType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSagePwd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSageId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.swActive.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPwd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lstUType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtSagePwd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSageId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents swActive As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtPwd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnUpdate As DevExpress.XtraEditors.SimpleButton
End Class
