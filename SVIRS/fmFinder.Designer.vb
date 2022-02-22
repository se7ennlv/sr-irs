<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmFinder
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
        Me.cmbtruefalse = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.dtcriteria = New DevExpress.XtraEditors.DateEdit()
        Me.spincriteria = New DevExpress.XtraEditors.SpinEdit()
        Me.txtcriteria = New DevExpress.XtraEditors.TextEdit()
        Me.cmdFind = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSelect = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbOption = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lstFields = New DevExpress.XtraEditors.LookUpEdit()
        Me.swAuto = New DevExpress.XtraEditors.CheckEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lstdropdown = New DevExpress.XtraEditors.LookUpEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.dgFind = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.cmbtruefalse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtcriteria.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtcriteria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spincriteria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcriteria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbOption.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstFields.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.swAuto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.lstdropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.dgFind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbtruefalse
        '
        Me.cmbtruefalse.Location = New System.Drawing.Point(530, 197)
        Me.cmbtruefalse.Name = "cmbtruefalse"
        Me.cmbtruefalse.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtruefalse.Properties.Appearance.Options.UseFont = True
        Me.cmbtruefalse.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbtruefalse.Size = New System.Drawing.Size(161, 20)
        Me.cmbtruefalse.TabIndex = 58
        Me.cmbtruefalse.Visible = False
        '
        'dtcriteria
        '
        Me.dtcriteria.EditValue = Nothing
        Me.dtcriteria.Location = New System.Drawing.Point(530, 165)
        Me.dtcriteria.Name = "dtcriteria"
        Me.dtcriteria.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtcriteria.Properties.Appearance.Options.UseFont = True
        Me.dtcriteria.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtcriteria.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtcriteria.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.dtcriteria.Size = New System.Drawing.Size(161, 20)
        Me.dtcriteria.TabIndex = 57
        Me.dtcriteria.Visible = False
        '
        'spincriteria
        '
        Me.spincriteria.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spincriteria.Location = New System.Drawing.Point(353, 197)
        Me.spincriteria.Name = "spincriteria"
        Me.spincriteria.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spincriteria.Properties.Appearance.Options.UseFont = True
        Me.spincriteria.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.spincriteria.Size = New System.Drawing.Size(161, 20)
        Me.spincriteria.TabIndex = 56
        Me.spincriteria.Visible = False
        '
        'txtcriteria
        '
        Me.txtcriteria.Location = New System.Drawing.Point(126, 81)
        Me.txtcriteria.Name = "txtcriteria"
        Me.txtcriteria.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcriteria.Properties.Appearance.Options.UseFont = True
        Me.txtcriteria.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtcriteria.Size = New System.Drawing.Size(565, 20)
        Me.txtcriteria.TabIndex = 55
        Me.txtcriteria.Visible = False
        '
        'cmdFind
        '
        Me.cmdFind.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.cmdFind.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Appearance.Options.UseBackColor = True
        Me.cmdFind.Appearance.Options.UseFont = True
        Me.cmdFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdFind.Location = New System.Drawing.Point(374, 45)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(114, 23)
        Me.cmdFind.TabIndex = 54
        Me.cmdFind.Text = "Find"
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.cmdCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Appearance.Options.UseBackColor = True
        Me.cmdCancel.Appearance.Options.UseFont = True
        Me.cmdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdCancel.Location = New System.Drawing.Point(724, 0)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(114, 33)
        Me.cmdCancel.TabIndex = 53
        Me.cmdCancel.Text = "CANCEL"
        '
        'cmdSelect
        '
        Me.cmdSelect.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSelect.Appearance.Options.UseFont = True
        Me.cmdSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdSelect.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdSelect.Location = New System.Drawing.Point(0, 0)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.Size = New System.Drawing.Size(111, 33)
        Me.cmdSelect.TabIndex = 52
        Me.cmdSelect.Text = "OK"
        '
        'cmbOption
        '
        Me.cmbOption.Location = New System.Drawing.Point(126, 48)
        Me.cmbOption.Name = "cmbOption"
        Me.cmbOption.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOption.Properties.Appearance.Options.UseFont = True
        Me.cmbOption.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOption.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cmbOption.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbOption.Size = New System.Drawing.Size(230, 20)
        Me.cmbOption.TabIndex = 50
        '
        'lstFields
        '
        Me.lstFields.Location = New System.Drawing.Point(126, 12)
        Me.lstFields.Name = "lstFields"
        Me.lstFields.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFields.Properties.Appearance.Options.UseFont = True
        Me.lstFields.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFields.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lstFields.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lstFields.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Description")})
        Me.lstFields.Properties.DisplayMember = "NAME"
        Me.lstFields.Properties.NullText = ""
        Me.lstFields.Properties.ShowFooter = False
        Me.lstFields.Properties.ShowHeader = False
        Me.lstFields.Properties.ValueMember = "ID"
        Me.lstFields.Size = New System.Drawing.Size(230, 20)
        Me.lstFields.TabIndex = 49
        '
        'swAuto
        '
        Me.swAuto.EditValue = True
        Me.swAuto.Location = New System.Drawing.Point(374, 13)
        Me.swAuto.Name = "swAuto"
        Me.swAuto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.swAuto.Properties.Appearance.Options.UseFont = True
        Me.swAuto.Properties.Caption = "Auto Find"
        Me.swAuto.Size = New System.Drawing.Size(209, 20)
        Me.swAuto.TabIndex = 48
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.lstdropdown)
        Me.PanelControl1.Controls.Add(Me.lstFields)
        Me.PanelControl1.Controls.Add(Me.cmbtruefalse)
        Me.PanelControl1.Controls.Add(Me.dtcriteria)
        Me.PanelControl1.Controls.Add(Me.swAuto)
        Me.PanelControl1.Controls.Add(Me.txtcriteria)
        Me.PanelControl1.Controls.Add(Me.spincriteria)
        Me.PanelControl1.Controls.Add(Me.cmdFind)
        Me.PanelControl1.Controls.Add(Me.cmbOption)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(838, 117)
        Me.PanelControl1.TabIndex = 59
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(12, 84)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl3.TabIndex = 60
        Me.LabelControl3.Text = "Criteria"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(12, 51)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl2.TabIndex = 60
        Me.LabelControl2.Text = "Where"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(12, 20)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl1.TabIndex = 60
        Me.LabelControl1.Text = "Find By"
        '
        'lstdropdown
        '
        Me.lstdropdown.Location = New System.Drawing.Point(353, 165)
        Me.lstdropdown.Name = "lstdropdown"
        Me.lstdropdown.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstdropdown.Properties.Appearance.Options.UseFont = True
        Me.lstdropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lstdropdown.Properties.DisplayMember = "NAME"
        Me.lstdropdown.Properties.ShowFooter = False
        Me.lstdropdown.Properties.ShowHeader = False
        Me.lstdropdown.Properties.ShowLines = False
        Me.lstdropdown.Properties.ValueMember = "CODE"
        Me.lstdropdown.Size = New System.Drawing.Size(161, 20)
        Me.lstdropdown.TabIndex = 59
        Me.lstdropdown.Visible = False
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.cmdCancel)
        Me.PanelControl2.Controls.Add(Me.cmdSelect)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 510)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(838, 33)
        Me.PanelControl2.TabIndex = 60
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.dgFind)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 117)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(838, 393)
        Me.PanelControl3.TabIndex = 61
        '
        'dgFind
        '
        Me.dgFind.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgFind.Location = New System.Drawing.Point(2, 2)
        Me.dgFind.MainView = Me.GridView1
        Me.dgFind.Name = "dgFind"
        Me.dgFind.Size = New System.Drawing.Size(834, 389)
        Me.dgFind.TabIndex = 0
        Me.dgFind.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.dgFind
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'fmFinder
        '
        Me.AcceptButton = Me.cmdSelect
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(838, 543)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "fmFinder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.cmbtruefalse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtcriteria.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtcriteria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spincriteria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcriteria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbOption.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstFields.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.swAuto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.lstdropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.dgFind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbtruefalse As New DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents dtcriteria As New DevExpress.XtraEditors.DateEdit
    Friend WithEvents spincriteria As New DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtcriteria As New DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdFind As New DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancel As New DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSelect As New DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbOption As New DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lstFields As New DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents swAuto As New DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lstdropdown As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dgFind As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
