<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecordNavigator
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecordNavigator))
        Me.txtCode = New DevExpress.XtraEditors.TextEdit()
        Me.cmdNext = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdLast = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdFind = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNew = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdPrev = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdFirst = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCode
        '
        Me.txtCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCode.Location = New System.Drawing.Point(54, 0)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Properties.Appearance.Options.UseFont = True
        Me.txtCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Size = New System.Drawing.Size(183, 20)
        Me.txtCode.TabIndex = 2
        '
        'cmdNext
        '
        Me.cmdNext.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.cmdNext.Appearance.Options.UseBackColor = True
        Me.cmdNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdNext.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdNext.Image = CType(resources.GetObject("cmdNext.Image"), System.Drawing.Image)
        Me.cmdNext.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdNext.Location = New System.Drawing.Point(237, 0)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(27, 22)
        Me.cmdNext.TabIndex = 3
        Me.cmdNext.ToolTip = "Next"
        '
        'cmdLast
        '
        Me.cmdLast.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.cmdLast.Appearance.Options.UseBackColor = True
        Me.cmdLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdLast.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdLast.Image = CType(resources.GetObject("cmdLast.Image"), System.Drawing.Image)
        Me.cmdLast.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdLast.Location = New System.Drawing.Point(264, 0)
        Me.cmdLast.Name = "cmdLast"
        Me.cmdLast.Size = New System.Drawing.Size(27, 22)
        Me.cmdLast.TabIndex = 4
        Me.cmdLast.ToolTip = "Last"
        '
        'cmdFind
        '
        Me.cmdFind.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.cmdFind.Appearance.Options.UseBackColor = True
        Me.cmdFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdFind.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Image)
        Me.cmdFind.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdFind.Location = New System.Drawing.Point(291, 0)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(27, 22)
        Me.cmdFind.TabIndex = 5
        Me.cmdFind.ToolTip = "Search"
        '
        'cmdNew
        '
        Me.cmdNew.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.cmdNew.Appearance.Options.UseBackColor = True
        Me.cmdNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdNew.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdNew.Image = CType(resources.GetObject("cmdNew.Image"), System.Drawing.Image)
        Me.cmdNew.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdNew.Location = New System.Drawing.Point(318, 0)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(27, 22)
        Me.cmdNew.TabIndex = 6
        Me.cmdNew.ToolTip = "Create New"
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.cmdSave.Appearance.Options.UseBackColor = True
        Me.cmdSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdSave.Location = New System.Drawing.Point(345, 0)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(27, 22)
        Me.cmdSave.TabIndex = 7
        Me.cmdSave.ToolTip = "Save"
        '
        'cmdDelete
        '
        Me.cmdDelete.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.cmdDelete.Appearance.Options.UseBackColor = True
        Me.cmdDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdDelete.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdDelete.Location = New System.Drawing.Point(372, 0)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(27, 22)
        Me.cmdDelete.TabIndex = 8
        Me.cmdDelete.ToolTip = "Delete"
        '
        'cmdPrint
        '
        Me.cmdPrint.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.cmdPrint.Appearance.Options.UseBackColor = True
        Me.cmdPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdPrint.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdPrint.Location = New System.Drawing.Point(399, 0)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(27, 22)
        Me.cmdPrint.TabIndex = 9
        Me.cmdPrint.ToolTip = "Print"
        '
        'cmdPrev
        '
        Me.cmdPrev.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.cmdPrev.Appearance.Options.UseBackColor = True
        Me.cmdPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdPrev.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdPrev.Image = CType(resources.GetObject("cmdPrev.Image"), System.Drawing.Image)
        Me.cmdPrev.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdPrev.Location = New System.Drawing.Point(27, 0)
        Me.cmdPrev.Name = "cmdPrev"
        Me.cmdPrev.Size = New System.Drawing.Size(27, 22)
        Me.cmdPrev.TabIndex = 1
        Me.cmdPrev.ToolTip = "Previous"
        '
        'cmdFirst
        '
        Me.cmdFirst.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.cmdFirst.Appearance.Options.UseBackColor = True
        Me.cmdFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdFirst.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdFirst.Image = CType(resources.GetObject("cmdFirst.Image"), System.Drawing.Image)
        Me.cmdFirst.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdFirst.Location = New System.Drawing.Point(0, 0)
        Me.cmdFirst.Name = "cmdFirst"
        Me.cmdFirst.Size = New System.Drawing.Size(27, 22)
        Me.cmdFirst.TabIndex = 0
        Me.cmdFirst.ToolTip = "First"
        '
        'RecordNavigator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.cmdLast)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdPrev)
        Me.Controls.Add(Me.cmdFirst)
        Me.Name = "RecordNavigator"
        Me.Size = New System.Drawing.Size(426, 22)
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdNext As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdLast As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrev As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdFirst As DevExpress.XtraEditors.SimpleButton

End Class
