<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.pnlTop = New System.Windows.Forms.Panel
        Me.CM = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Header1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Header2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DateTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BannerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IDDisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.txtDateTime = New System.Windows.Forms.Label
        Me.txtHeader2 = New System.Windows.Forms.Label
        Me.txtHeader1 = New System.Windows.Forms.Label
        Me.picLogo = New System.Windows.Forms.PictureBox
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.txtsysmsg = New System.Windows.Forms.ToolStripStatusLabel
        Me.FLP = New System.Windows.Forms.FlowLayoutPanel
        Me.pnlTop.SuspendLayout()
        Me.CM.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.Black
        Me.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlTop.ContextMenuStrip = Me.CM
        Me.pnlTop.Controls.Add(Me.txtDateTime)
        Me.pnlTop.Controls.Add(Me.txtHeader2)
        Me.pnlTop.Controls.Add(Me.txtHeader1)
        Me.pnlTop.Controls.Add(Me.picLogo)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1370, 200)
        Me.pnlTop.TabIndex = 0
        '
        'CM
        '
        Me.CM.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoToolStripMenuItem, Me.Header1ToolStripMenuItem, Me.Header2ToolStripMenuItem, Me.DateTimeToolStripMenuItem, Me.BannerToolStripMenuItem, Me.IDDisplayToolStripMenuItem, Me.DatabaseToolStripMenuItem})
        Me.CM.Name = "CM"
        Me.CM.Size = New System.Drawing.Size(130, 158)
        '
        'LogoToolStripMenuItem
        '
        Me.LogoToolStripMenuItem.Name = "LogoToolStripMenuItem"
        Me.LogoToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.LogoToolStripMenuItem.Text = "Logo"
        '
        'Header1ToolStripMenuItem
        '
        Me.Header1ToolStripMenuItem.Name = "Header1ToolStripMenuItem"
        Me.Header1ToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.Header1ToolStripMenuItem.Text = "Header 1"
        '
        'Header2ToolStripMenuItem
        '
        Me.Header2ToolStripMenuItem.Name = "Header2ToolStripMenuItem"
        Me.Header2ToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.Header2ToolStripMenuItem.Text = "Header 2"
        '
        'DateTimeToolStripMenuItem
        '
        Me.DateTimeToolStripMenuItem.Name = "DateTimeToolStripMenuItem"
        Me.DateTimeToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.DateTimeToolStripMenuItem.Text = "Date/Time"
        '
        'BannerToolStripMenuItem
        '
        Me.BannerToolStripMenuItem.Name = "BannerToolStripMenuItem"
        Me.BannerToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.BannerToolStripMenuItem.Text = "Banner"
        '
        'IDDisplayToolStripMenuItem
        '
        Me.IDDisplayToolStripMenuItem.Name = "IDDisplayToolStripMenuItem"
        Me.IDDisplayToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.IDDisplayToolStripMenuItem.Text = "ID Display"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.DatabaseToolStripMenuItem.Text = "Database"
        '
        'txtDateTime
        '
        Me.txtDateTime.AutoSize = True
        Me.txtDateTime.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateTime.ForeColor = System.Drawing.Color.Teal
        Me.txtDateTime.Location = New System.Drawing.Point(688, 134)
        Me.txtDateTime.Name = "txtDateTime"
        Me.txtDateTime.Size = New System.Drawing.Size(150, 40)
        Me.txtDateTime.TabIndex = 3
        Me.txtDateTime.Text = "Date/Time"
        '
        'txtHeader2
        '
        Me.txtHeader2.AutoSize = True
        Me.txtHeader2.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeader2.ForeColor = System.Drawing.Color.Teal
        Me.txtHeader2.Location = New System.Drawing.Point(581, 74)
        Me.txtHeader2.Name = "txtHeader2"
        Me.txtHeader2.Size = New System.Drawing.Size(339, 47)
        Me.txtHeader2.TabIndex = 2
        Me.txtHeader2.Text = "Another Header Text"
        '
        'txtHeader1
        '
        Me.txtHeader1.AutoSize = True
        Me.txtHeader1.BackColor = System.Drawing.Color.Transparent
        Me.txtHeader1.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeader1.ForeColor = System.Drawing.Color.Teal
        Me.txtHeader1.Location = New System.Drawing.Point(609, 9)
        Me.txtHeader1.Name = "txtHeader1"
        Me.txtHeader1.Size = New System.Drawing.Size(277, 65)
        Me.txtHeader1.TabIndex = 1
        Me.txtHeader1.Text = "Header Text"
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(246, 63)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(100, 83)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.txtsysmsg})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 750)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1370, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(97, 17)
        Me.ToolStripStatusLabel1.Text = "System Message:"
        '
        'txtsysmsg
        '
        Me.txtsysmsg.Name = "txtsysmsg"
        Me.txtsysmsg.Size = New System.Drawing.Size(16, 17)
        Me.txtsysmsg.Text = "..."
        '
        'FLP
        '
        Me.FLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP.Location = New System.Drawing.Point(0, 200)
        Me.FLP.Name = "FLP"
        Me.FLP.Size = New System.Drawing.Size(1370, 550)
        Me.FLP.TabIndex = 2
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1370, 772)
        Me.ControlBox = False
        Me.Controls.Add(Me.FLP)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.CM.ResumeLayout(False)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents FLP As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents txtHeader2 As System.Windows.Forms.Label
    Friend WithEvents txtHeader1 As System.Windows.Forms.Label
    Friend WithEvents txtDateTime As System.Windows.Forms.Label
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtsysmsg As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents CM As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LogoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Header1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Header2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateTimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BannerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IDDisplayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
