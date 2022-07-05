<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class homepage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(homepage))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMyCartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BillingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyBillsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ElectronicsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccessoriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem, Me.InventoryToolStripMenuItem, Me.BillingsToolStripMenuItem, Me.CategoriesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1496, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewCustomerToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(78, 29)
        Me.CustomerToolStripMenuItem.Text = "Profile"
        '
        'NewCustomerToolStripMenuItem
        '
        Me.NewCustomerToolStripMenuItem.Name = "NewCustomerToolStripMenuItem"
        Me.NewCustomerToolStripMenuItem.Size = New System.Drawing.Size(234, 34)
        Me.NewCustomerToolStripMenuItem.Text = "Edit my Profile "
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(234, 34)
        Me.ReportToolStripMenuItem.Text = "Logout"
        '
        'InventoryToolStripMenuItem
        '
        Me.InventoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditMyCartToolStripMenuItem})
        Me.InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        Me.InventoryToolStripMenuItem.Size = New System.Drawing.Size(60, 29)
        Me.InventoryToolStripMenuItem.Text = "Cart"
        '
        'EditMyCartToolStripMenuItem
        '
        Me.EditMyCartToolStripMenuItem.Name = "EditMyCartToolStripMenuItem"
        Me.EditMyCartToolStripMenuItem.Size = New System.Drawing.Size(218, 34)
        Me.EditMyCartToolStripMenuItem.Text = "View my Cart"
        '
        'BillingsToolStripMenuItem
        '
        Me.BillingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MyBillsToolStripMenuItem})
        Me.BillingsToolStripMenuItem.Name = "BillingsToolStripMenuItem"
        Me.BillingsToolStripMenuItem.Size = New System.Drawing.Size(83, 29)
        Me.BillingsToolStripMenuItem.Text = "Billings"
        '
        'MyBillsToolStripMenuItem
        '
        Me.MyBillsToolStripMenuItem.Name = "MyBillsToolStripMenuItem"
        Me.MyBillsToolStripMenuItem.Size = New System.Drawing.Size(174, 34)
        Me.MyBillsToolStripMenuItem.Text = "My Bills"
        '
        'CategoriesToolStripMenuItem
        '
        Me.CategoriesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ElectronicsToolStripMenuItem, Me.AccessoriesToolStripMenuItem})
        Me.CategoriesToolStripMenuItem.Name = "CategoriesToolStripMenuItem"
        Me.CategoriesToolStripMenuItem.Size = New System.Drawing.Size(112, 29)
        Me.CategoriesToolStripMenuItem.Text = "Categories"
        '
        'ElectronicsToolStripMenuItem
        '
        Me.ElectronicsToolStripMenuItem.Name = "ElectronicsToolStripMenuItem"
        Me.ElectronicsToolStripMenuItem.Size = New System.Drawing.Size(197, 34)
        Me.ElectronicsToolStripMenuItem.Text = "Electronics"
        '
        'AccessoriesToolStripMenuItem
        '
        Me.AccessoriesToolStripMenuItem.Name = "AccessoriesToolStripMenuItem"
        Me.AccessoriesToolStripMenuItem.Size = New System.Drawing.Size(197, 34)
        Me.AccessoriesToolStripMenuItem.Text = "Clothings"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 33)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1496, 678)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1496, 678)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MySqlCommand1
        '
        Me.MySqlCommand1.CacheAge = 0
        Me.MySqlCommand1.Connection = Nothing
        Me.MySqlCommand1.EnableCaching = False
        Me.MySqlCommand1.Transaction = Nothing
        '
        'homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1496, 711)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "homepage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "homepage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents EditMyCartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BillingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MyBillsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents CategoriesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ElectronicsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccessoriesToolStripMenuItem As ToolStripMenuItem
End Class
