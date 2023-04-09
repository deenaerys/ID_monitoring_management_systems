<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Device
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Device))
        Me.zk = New Axzkemkeeper.AxCZKEM
        Me.pic = New System.Windows.Forms.PictureBox
        Me.txtlane = New System.Windows.Forms.Label
        Me.txtip = New System.Windows.Forms.Label
        Me.txtport = New System.Windows.Forms.Label
        Me.txtmachinenumber = New System.Windows.Forms.Label
        Me.txtstatus = New System.Windows.Forms.Label
        Me.bw_Conn = New System.ComponentModel.BackgroundWorker
        Me.txtAccess = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.Label
        Me.tmr = New System.Windows.Forms.Timer(Me.components)
        Me.txtCardcode = New System.Windows.Forms.Label
        Me.txtDelay = New System.Windows.Forms.Label
        CType(Me.zk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'zk
        '
        Me.zk.Enabled = True
        Me.zk.Location = New System.Drawing.Point(3, 278)
        Me.zk.Name = "zk"
        Me.zk.OcxState = CType(resources.GetObject("zk.OcxState"), System.Windows.Forms.AxHost.State)
        Me.zk.Size = New System.Drawing.Size(192, 192)
        Me.zk.TabIndex = 0
        Me.zk.Visible = False
        '
        'pic
        '
        Me.pic.Dock = System.Windows.Forms.DockStyle.Top
        Me.pic.ErrorImage = CType(resources.GetObject("pic.ErrorImage"), System.Drawing.Image)
        Me.pic.Image = CType(resources.GetObject("pic.Image"), System.Drawing.Image)
        Me.pic.Location = New System.Drawing.Point(0, 29)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(400, 219)
        Me.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic.TabIndex = 1
        Me.pic.TabStop = False
        '
        'txtlane
        '
        Me.txtlane.AutoEllipsis = True
        Me.txtlane.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtlane.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlane.Location = New System.Drawing.Point(0, 0)
        Me.txtlane.Name = "txtlane"
        Me.txtlane.Size = New System.Drawing.Size(400, 29)
        Me.txtlane.TabIndex = 2
        Me.txtlane.Text = "Lane"
        Me.txtlane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtip
        '
        Me.txtip.AutoSize = True
        Me.txtip.Location = New System.Drawing.Point(14, 29)
        Me.txtip.Name = "txtip"
        Me.txtip.Size = New System.Drawing.Size(17, 13)
        Me.txtip.TabIndex = 3
        Me.txtip.Text = "IP"
        Me.txtip.Visible = False
        '
        'txtport
        '
        Me.txtport.AutoSize = True
        Me.txtport.Location = New System.Drawing.Point(14, 42)
        Me.txtport.Name = "txtport"
        Me.txtport.Size = New System.Drawing.Size(26, 13)
        Me.txtport.TabIndex = 4
        Me.txtport.Text = "Port"
        Me.txtport.Visible = False
        '
        'txtmachinenumber
        '
        Me.txtmachinenumber.AutoSize = True
        Me.txtmachinenumber.Location = New System.Drawing.Point(14, 65)
        Me.txtmachinenumber.Name = "txtmachinenumber"
        Me.txtmachinenumber.Size = New System.Drawing.Size(88, 13)
        Me.txtmachinenumber.TabIndex = 5
        Me.txtmachinenumber.Text = "Machine Number"
        Me.txtmachinenumber.Visible = False
        '
        'txtstatus
        '
        Me.txtstatus.AutoSize = True
        Me.txtstatus.Location = New System.Drawing.Point(14, 89)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(37, 13)
        Me.txtstatus.TabIndex = 6
        Me.txtstatus.Text = "Status"
        Me.txtstatus.Visible = False
        '
        'bw_Conn
        '
        '
        'txtAccess
        '
        Me.txtAccess.AutoEllipsis = True
        Me.txtAccess.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtAccess.Location = New System.Drawing.Point(0, 377)
        Me.txtAccess.Name = "txtAccess"
        Me.txtAccess.Size = New System.Drawing.Size(400, 23)
        Me.txtAccess.TabIndex = 7
        Me.txtAccess.Text = "Access"
        Me.txtAccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtName
        '
        Me.txtName.AutoEllipsis = True
        Me.txtName.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtName.Location = New System.Drawing.Point(0, 354)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(400, 23)
        Me.txtName.TabIndex = 8
        Me.txtName.Text = "Name"
        Me.txtName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmr
        '
        Me.tmr.Interval = 3000
        '
        'txtCardcode
        '
        Me.txtCardcode.AutoSize = True
        Me.txtCardcode.BackColor = System.Drawing.Color.Transparent
        Me.txtCardcode.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardcode.Location = New System.Drawing.Point(5, 5)
        Me.txtCardcode.Name = "txtCardcode"
        Me.txtCardcode.Size = New System.Drawing.Size(13, 17)
        Me.txtCardcode.TabIndex = 9
        Me.txtCardcode.Text = "-"
        '
        'txtDelay
        '
        Me.txtDelay.AutoSize = True
        Me.txtDelay.Location = New System.Drawing.Point(384, 5)
        Me.txtDelay.Name = "txtDelay"
        Me.txtDelay.Size = New System.Drawing.Size(13, 13)
        Me.txtDelay.TabIndex = 10
        Me.txtDelay.Text = "0"
        Me.txtDelay.Visible = False
        '
        'Device
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.txtDelay)
        Me.Controls.Add(Me.txtCardcode)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtAccess)
        Me.Controls.Add(Me.pic)
        Me.Controls.Add(Me.txtlane)
        Me.Controls.Add(Me.txtstatus)
        Me.Controls.Add(Me.txtmachinenumber)
        Me.Controls.Add(Me.txtport)
        Me.Controls.Add(Me.txtip)
        Me.Controls.Add(Me.zk)
        Me.DoubleBuffered = True
        Me.Name = "Device"
        Me.Size = New System.Drawing.Size(400, 400)
        CType(Me.zk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents zk As Axzkemkeeper.AxCZKEM
    Friend WithEvents pic As System.Windows.Forms.PictureBox
    Friend WithEvents txtlane As System.Windows.Forms.Label
    Friend WithEvents txtip As System.Windows.Forms.Label
    Friend WithEvents txtport As System.Windows.Forms.Label
    Friend WithEvents txtmachinenumber As System.Windows.Forms.Label
    Friend WithEvents txtstatus As System.Windows.Forms.Label
    Friend WithEvents bw_Conn As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtAccess As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.Label
    Friend WithEvents tmr As System.Windows.Forms.Timer
    Friend WithEvents txtCardcode As System.Windows.Forms.Label
    Friend WithEvents txtDelay As System.Windows.Forms.Label

End Class
