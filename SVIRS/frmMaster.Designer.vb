<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaster
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaster))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResourcesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.h = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.nvConfigure = New DevExpress.XtraNavBar.NavBarItem()
        Me.nvUsers = New DevExpress.XtraNavBar.NavBarItem()
        Me.nvDepartment = New DevExpress.XtraNavBar.NavBarItem()
        Me.nvRptMgr = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.nvRequest = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarGroup3 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.nvMyApproval = New DevExpress.XtraNavBar.NavBarItem()
        Me.nvMyRequest = New DevExpress.XtraNavBar.NavBarItem()
        Me.nvBalance = New DevExpress.XtraNavBar.NavBarItem()
        Me.nvPRLookup = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarGroup4 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.nvRorderLevel = New DevExpress.XtraNavBar.NavBarItem()
        Me.nvProcReorder = New DevExpress.XtraNavBar.NavBarItem()
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.h, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ResourcesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1181, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit, Me.ProfileToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(108, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.ProfileToolStripMenuItem.Text = "Profile"
        '
        'ResourcesToolStripMenuItem
        '
        Me.ResourcesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportsToolStripMenuItem})
        Me.ResourcesToolStripMenuItem.Name = "ResourcesToolStripMenuItem"
        Me.ResourcesToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.ResourcesToolStripMenuItem.Text = "Resources"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.h)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl1.Location = New System.Drawing.Point(0, 24)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(233, 738)
        Me.PanelControl1.TabIndex = 1
        '
        'h
        '
        Me.h.ActiveGroup = Me.NavBarGroup1
        Me.h.Dock = System.Windows.Forms.DockStyle.Fill
        Me.h.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup1, Me.NavBarGroup2, Me.NavBarGroup3, Me.NavBarGroup4})
        Me.h.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.nvConfigure, Me.nvUsers, Me.nvRptMgr, Me.nvDepartment, Me.nvRequest, Me.nvBalance, Me.nvPRLookup, Me.nvMyRequest, Me.nvMyApproval, Me.nvRorderLevel, Me.nvProcReorder})
        Me.h.Location = New System.Drawing.Point(2, 2)
        Me.h.Name = "h"
        Me.h.OptionsNavPane.ExpandedWidth = 229
        Me.h.Size = New System.Drawing.Size(229, 734)
        Me.h.TabIndex = 0
        Me.h.Text = "NavBarControl1"
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Caption = "System Management"
        Me.NavBarGroup1.Expanded = True
        Me.NavBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.nvConfigure), New DevExpress.XtraNavBar.NavBarItemLink(Me.nvUsers), New DevExpress.XtraNavBar.NavBarItemLink(Me.nvDepartment), New DevExpress.XtraNavBar.NavBarItemLink(Me.nvRptMgr)})
        Me.NavBarGroup1.Name = "NavBarGroup1"
        '
        'nvConfigure
        '
        Me.nvConfigure.Caption = "Configuration"
        Me.nvConfigure.Name = "nvConfigure"
        '
        'nvUsers
        '
        Me.nvUsers.Caption = "User Maintenance"
        Me.nvUsers.Name = "nvUsers"
        '
        'nvDepartment
        '
        Me.nvDepartment.Caption = "Department"
        Me.nvDepartment.Name = "nvDepartment"
        '
        'nvRptMgr
        '
        Me.nvRptMgr.Caption = "Report Manager"
        Me.nvRptMgr.Name = "nvRptMgr"
        '
        'NavBarGroup2
        '
        Me.NavBarGroup2.Caption = "Transaction"
        Me.NavBarGroup2.Expanded = True
        Me.NavBarGroup2.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.nvRequest)})
        Me.NavBarGroup2.Name = "NavBarGroup2"
        '
        'nvRequest
        '
        Me.nvRequest.Caption = "Inventory Request"
        Me.nvRequest.Name = "nvRequest"
        '
        'NavBarGroup3
        '
        Me.NavBarGroup3.Caption = "Inquiry"
        Me.NavBarGroup3.Expanded = True
        Me.NavBarGroup3.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.nvMyApproval), New DevExpress.XtraNavBar.NavBarItemLink(Me.nvMyRequest), New DevExpress.XtraNavBar.NavBarItemLink(Me.nvBalance), New DevExpress.XtraNavBar.NavBarItemLink(Me.nvPRLookup)})
        Me.NavBarGroup3.Name = "NavBarGroup3"
        '
        'nvMyApproval
        '
        Me.nvMyApproval.Caption = "My Approval"
        Me.nvMyApproval.Name = "nvMyApproval"
        '
        'nvMyRequest
        '
        Me.nvMyRequest.Caption = "My Request"
        Me.nvMyRequest.Name = "nvMyRequest"
        '
        'nvBalance
        '
        Me.nvBalance.Caption = "Stock Balance"
        Me.nvBalance.Name = "nvBalance"
        '
        'nvPRLookup
        '
        Me.nvPRLookup.Caption = "Purchase Request Lookup"
        Me.nvPRLookup.Name = "nvPRLookup"
        '
        'NavBarGroup4
        '
        Me.NavBarGroup4.Caption = "Inventory Control"
        Me.NavBarGroup4.Expanded = True
        Me.NavBarGroup4.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.nvRorderLevel), New DevExpress.XtraNavBar.NavBarItemLink(Me.nvProcReorder)})
        Me.NavBarGroup4.Name = "NavBarGroup4"
        Me.NavBarGroup4.Visible = False
        '
        'nvRorderLevel
        '
        Me.nvRorderLevel.Caption = "Reorder Level"
        Me.nvRorderLevel.Name = "nvRorderLevel"
        '
        'nvProcReorder
        '
        Me.nvProcReorder.Caption = "Process Reorder"
        Me.nvProcReorder.Name = "nvProcReorder"
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'frmMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 762)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Savan Legend Resort - Inventory Request System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.h, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents h As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents NavBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroup3 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents nvConfigure As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nvUsers As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nvRptMgr As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nvDepartment As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nvMyRequest As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nvBalance As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nvPRLookup As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nvRequest As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nvMyApproval As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents ResourcesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NavBarGroup4 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents nvRorderLevel As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nvProcReorder As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents ProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
