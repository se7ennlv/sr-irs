<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigure
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
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.btnSageSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnTest = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSageDb = New DevExpress.XtraEditors.TextEdit()
        Me.txtSagePwd = New DevExpress.XtraEditors.TextEdit()
        Me.txtSageUsr = New DevExpress.XtraEditors.TextEdit()
        Me.txtSageSvr = New DevExpress.XtraEditors.TextEdit()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.swSSL = New DevExpress.XtraEditors.CheckEdit()
        Me.btnSmtpSend = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSmtpSave = New DevExpress.XtraEditors.SimpleButton()
        Me.txtSendTo = New DevExpress.XtraEditors.TextEdit()
        Me.txtSmtpPwd = New DevExpress.XtraEditors.TextEdit()
        Me.txtSmtpUsr = New DevExpress.XtraEditors.TextEdit()
        Me.txtSmtpPort = New DevExpress.XtraEditors.SpinEdit()
        Me.txtSmtpSvr = New DevExpress.XtraEditors.TextEdit()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.btnNumSave = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.dtPref = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSample = New DevExpress.XtraEditors.TextEdit()
        Me.txtNxtNum = New DevExpress.XtraEditors.SpinEdit()
        Me.txtMaxLen = New DevExpress.XtraEditors.SpinEdit()
        Me.swDate = New DevExpress.XtraEditors.CheckEdit()
        Me.txtPref = New DevExpress.XtraEditors.TextEdit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.txtSageDb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSagePwd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSageUsr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSageSvr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.swSSL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSendTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSmtpPwd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSmtpUsr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSmtpPort.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSmtpSvr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.dtPref.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSample.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNxtNum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaxLen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.swDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPref.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(825, 578)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.btnSageSave)
        Me.XtraTabPage1.Controls.Add(Me.btnTest)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage1.Controls.Add(Me.txtSageDb)
        Me.XtraTabPage1.Controls.Add(Me.txtSagePwd)
        Me.XtraTabPage1.Controls.Add(Me.txtSageUsr)
        Me.XtraTabPage1.Controls.Add(Me.txtSageSvr)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(817, 548)
        Me.XtraTabPage1.Text = "Sage Integration"
        '
        'btnSageSave
        '
        Me.btnSageSave.Location = New System.Drawing.Point(331, 66)
        Me.btnSageSave.Name = "btnSageSave"
        Me.btnSageSave.Size = New System.Drawing.Size(99, 23)
        Me.btnSageSave.TabIndex = 9
        Me.btnSageSave.Text = "Save"
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(331, 40)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(99, 23)
        Me.btnTest.TabIndex = 8
        Me.btnTest.Text = "Test Connection"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(11, 123)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "Database"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(11, 97)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Password"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(11, 71)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Login"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(11, 45)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Server Name"
        '
        'txtSageDb
        '
        Me.txtSageDb.Location = New System.Drawing.Point(144, 120)
        Me.txtSageDb.Name = "txtSageDb"
        Me.txtSageDb.Size = New System.Drawing.Size(160, 20)
        Me.txtSageDb.TabIndex = 3
        '
        'txtSagePwd
        '
        Me.txtSagePwd.Location = New System.Drawing.Point(144, 94)
        Me.txtSagePwd.Name = "txtSagePwd"
        Me.txtSagePwd.Properties.UseSystemPasswordChar = True
        Me.txtSagePwd.Size = New System.Drawing.Size(160, 20)
        Me.txtSagePwd.TabIndex = 2
        '
        'txtSageUsr
        '
        Me.txtSageUsr.Location = New System.Drawing.Point(144, 68)
        Me.txtSageUsr.Name = "txtSageUsr"
        Me.txtSageUsr.Size = New System.Drawing.Size(160, 20)
        Me.txtSageUsr.TabIndex = 1
        '
        'txtSageSvr
        '
        Me.txtSageSvr.Location = New System.Drawing.Point(144, 42)
        Me.txtSageSvr.Name = "txtSageSvr"
        Me.txtSageSvr.Size = New System.Drawing.Size(160, 20)
        Me.txtSageSvr.TabIndex = 0
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.LabelControl9)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl8)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl7)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl6)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage2.Controls.Add(Me.swSSL)
        Me.XtraTabPage2.Controls.Add(Me.btnSmtpSend)
        Me.XtraTabPage2.Controls.Add(Me.btnSmtpSave)
        Me.XtraTabPage2.Controls.Add(Me.txtSendTo)
        Me.XtraTabPage2.Controls.Add(Me.txtSmtpPwd)
        Me.XtraTabPage2.Controls.Add(Me.txtSmtpUsr)
        Me.XtraTabPage2.Controls.Add(Me.txtSmtpPort)
        Me.XtraTabPage2.Controls.Add(Me.txtSmtpSvr)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(817, 548)
        Me.XtraTabPage2.Text = "Email"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(11, 227)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(108, 13)
        Me.LabelControl9.TabIndex = 12
        Me.LabelControl9.Text = "Send Test Message To"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(11, 129)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl8.TabIndex = 11
        Me.LabelControl8.Text = "Password"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(11, 103)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl7.TabIndex = 10
        Me.LabelControl7.Text = "User ID"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(11, 77)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl6.TabIndex = 9
        Me.LabelControl6.Text = "Port Number"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(11, 51)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "SMTP Server"
        '
        'swSSL
        '
        Me.swSSL.Location = New System.Drawing.Point(226, 74)
        Me.swSSL.Name = "swSSL"
        Me.swSSL.Properties.Caption = "Use SSL"
        Me.swSSL.Size = New System.Drawing.Size(75, 20)
        Me.swSSL.TabIndex = 7
        '
        'btnSmtpSend
        '
        Me.btnSmtpSend.Location = New System.Drawing.Point(440, 222)
        Me.btnSmtpSend.Name = "btnSmtpSend"
        Me.btnSmtpSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSmtpSend.TabIndex = 6
        Me.btnSmtpSend.Text = "Send"
        '
        'btnSmtpSave
        '
        Me.btnSmtpSave.Location = New System.Drawing.Point(440, 124)
        Me.btnSmtpSave.Name = "btnSmtpSave"
        Me.btnSmtpSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSmtpSave.TabIndex = 5
        Me.btnSmtpSave.Text = "Save"
        '
        'txtSendTo
        '
        Me.txtSendTo.Location = New System.Drawing.Point(152, 224)
        Me.txtSendTo.Name = "txtSendTo"
        Me.txtSendTo.Size = New System.Drawing.Size(272, 20)
        Me.txtSendTo.TabIndex = 4
        '
        'txtSmtpPwd
        '
        Me.txtSmtpPwd.Location = New System.Drawing.Point(152, 126)
        Me.txtSmtpPwd.Name = "txtSmtpPwd"
        Me.txtSmtpPwd.Properties.UseSystemPasswordChar = True
        Me.txtSmtpPwd.Size = New System.Drawing.Size(272, 20)
        Me.txtSmtpPwd.TabIndex = 3
        '
        'txtSmtpUsr
        '
        Me.txtSmtpUsr.Location = New System.Drawing.Point(152, 100)
        Me.txtSmtpUsr.Name = "txtSmtpUsr"
        Me.txtSmtpUsr.Size = New System.Drawing.Size(272, 20)
        Me.txtSmtpUsr.TabIndex = 2
        '
        'txtSmtpPort
        '
        Me.txtSmtpPort.EditValue = New Decimal(New Integer() {587, 0, 0, 0})
        Me.txtSmtpPort.Location = New System.Drawing.Point(152, 74)
        Me.txtSmtpPort.Name = "txtSmtpPort"
        Me.txtSmtpPort.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSmtpPort.Size = New System.Drawing.Size(68, 20)
        Me.txtSmtpPort.TabIndex = 1
        '
        'txtSmtpSvr
        '
        Me.txtSmtpSvr.Location = New System.Drawing.Point(152, 48)
        Me.txtSmtpSvr.Name = "txtSmtpSvr"
        Me.txtSmtpSvr.Size = New System.Drawing.Size(272, 20)
        Me.txtSmtpSvr.TabIndex = 0
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.btnNumSave)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl14)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl13)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl12)
        Me.XtraTabPage3.Controls.Add(Me.dtPref)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl11)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl10)
        Me.XtraTabPage3.Controls.Add(Me.txtSample)
        Me.XtraTabPage3.Controls.Add(Me.txtNxtNum)
        Me.XtraTabPage3.Controls.Add(Me.txtMaxLen)
        Me.XtraTabPage3.Controls.Add(Me.swDate)
        Me.XtraTabPage3.Controls.Add(Me.txtPref)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(817, 548)
        Me.XtraTabPage3.Text = "Numbering"
        '
        'btnNumSave
        '
        Me.btnNumSave.Location = New System.Drawing.Point(149, 171)
        Me.btnNumSave.Name = "btnNumSave"
        Me.btnNumSave.Size = New System.Drawing.Size(120, 23)
        Me.btnNumSave.TabIndex = 12
        Me.btnNumSave.Text = "Save"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(311, 102)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl14.TabIndex = 11
        Me.LabelControl14.Text = "Sample Request #"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(35, 134)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl13.TabIndex = 10
        Me.LabelControl13.Text = "Next Number"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(35, 102)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl12.TabIndex = 9
        Me.LabelControl12.Text = "Max. Length"
        '
        'dtPref
        '
        Me.dtPref.Location = New System.Drawing.Point(148, 69)
        Me.dtPref.Name = "dtPref"
        Me.dtPref.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtPref.Properties.Items.AddRange(New Object() {"MM", "yy", "MMyy", "ddMM", "MMdd", "yyMM", "ddMMyy", "yyMMdd", "yMd"})
        Me.dtPref.Size = New System.Drawing.Size(121, 20)
        Me.dtPref.TabIndex = 8
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(35, 71)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl11.TabIndex = 7
        Me.LabelControl11.Text = "Date Prefix"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(35, 46)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl10.TabIndex = 6
        Me.LabelControl10.Text = "Request Prefix"
        '
        'txtSample
        '
        Me.txtSample.Location = New System.Drawing.Point(311, 115)
        Me.txtSample.Name = "txtSample"
        Me.txtSample.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSample.Properties.Appearance.Options.UseFont = True
        Me.txtSample.Properties.ReadOnly = True
        Me.txtSample.Size = New System.Drawing.Size(274, 32)
        Me.txtSample.TabIndex = 5
        '
        'txtNxtNum
        '
        Me.txtNxtNum.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtNxtNum.Location = New System.Drawing.Point(149, 127)
        Me.txtNxtNum.Name = "txtNxtNum"
        Me.txtNxtNum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNxtNum.Properties.MaxValue = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.txtNxtNum.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtNxtNum.Size = New System.Drawing.Size(120, 20)
        Me.txtNxtNum.TabIndex = 4
        '
        'txtMaxLen
        '
        Me.txtMaxLen.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMaxLen.Location = New System.Drawing.Point(149, 95)
        Me.txtMaxLen.Name = "txtMaxLen"
        Me.txtMaxLen.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtMaxLen.Size = New System.Drawing.Size(120, 20)
        Me.txtMaxLen.TabIndex = 3
        '
        'swDate
        '
        Me.swDate.Location = New System.Drawing.Point(311, 43)
        Me.swDate.Name = "swDate"
        Me.swDate.Properties.Caption = "Use Date Prefix"
        Me.swDate.Size = New System.Drawing.Size(103, 20)
        Me.swDate.TabIndex = 1
        '
        'txtPref
        '
        Me.txtPref.Location = New System.Drawing.Point(148, 43)
        Me.txtPref.Name = "txtPref"
        Me.txtPref.Properties.MaxLength = 6
        Me.txtPref.Size = New System.Drawing.Size(121, 20)
        Me.txtPref.TabIndex = 0
        '
        'frmConfigure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 578)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmConfigure"
        Me.Text = "Configuration"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.txtSageDb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSagePwd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSageUsr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSageSvr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.swSSL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSendTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSmtpPwd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSmtpUsr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSmtpPort.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSmtpSvr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        CType(Me.dtPref.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSample.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNxtNum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaxLen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.swDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPref.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnSageSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTest As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSageDb As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSagePwd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSageUsr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSageSvr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents swSSL As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnSmtpSend As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSmtpSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSendTo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSmtpPwd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSmtpUsr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSmtpPort As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtSmtpSvr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtPref As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSample As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNxtNum As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtMaxLen As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents swDate As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtPref As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnNumSave As DevExpress.XtraEditors.SimpleButton
End Class
