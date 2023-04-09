<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Database_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Database_Form))
        Me.btnClose = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txt = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.btnServerSave = New System.Windows.Forms.Button
        Me.txtServerDB = New System.Windows.Forms.ComboBox
        Me.txtServerPort = New System.Windows.Forms.NumericUpDown
        Me.txtServerPassword = New System.Windows.Forms.TextBox
        Me.txtServerUser = New System.Windows.Forms.TextBox
        Me.txtServerIP = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.btnSave = New System.Windows.Forms.Button
        Me.txtDB = New System.Windows.Forms.ComboBox
        Me.txtPort = New System.Windows.Forms.NumericUpDown
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtUser = New System.Windows.Forms.TextBox
        Me.txtIP = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.txtServerPort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.txtPort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Marlett", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(277, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(25, 25)
        Me.btnClose.TabIndex = 20
        Me.btnClose.Text = "r"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.txt)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(301, 35)
        Me.Panel1.TabIndex = 2
        '
        'txt
        '
        Me.txt.Dock = System.Windows.Forms.DockStyle.Left
        Me.txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt.ForeColor = System.Drawing.Color.White
        Me.txt.Location = New System.Drawing.Point(0, 0)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(100, 35)
        Me.txt.TabIndex = 0
        Me.txt.Text = "Database"
        Me.txt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 35)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(301, 252)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnServerSave)
        Me.TabPage1.Controls.Add(Me.txtServerDB)
        Me.TabPage1.Controls.Add(Me.txtServerPort)
        Me.TabPage1.Controls.Add(Me.txtServerPassword)
        Me.TabPage1.Controls.Add(Me.txtServerUser)
        Me.TabPage1.Controls.Add(Me.txtServerIP)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(293, 222)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "SERVER"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnServerSave
        '
        Me.btnServerSave.BackColor = System.Drawing.Color.Teal
        Me.btnServerSave.FlatAppearance.BorderSize = 0
        Me.btnServerSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnServerSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.btnServerSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnServerSave.ForeColor = System.Drawing.Color.White
        Me.btnServerSave.Location = New System.Drawing.Point(93, 174)
        Me.btnServerSave.Name = "btnServerSave"
        Me.btnServerSave.Size = New System.Drawing.Size(175, 29)
        Me.btnServerSave.TabIndex = 24
        Me.btnServerSave.Text = "SAVE"
        Me.btnServerSave.UseVisualStyleBackColor = False
        '
        'txtServerDB
        '
        Me.txtServerDB.FormattingEnabled = True
        Me.txtServerDB.Location = New System.Drawing.Point(93, 143)
        Me.txtServerDB.Name = "txtServerDB"
        Me.txtServerDB.Size = New System.Drawing.Size(175, 25)
        Me.txtServerDB.TabIndex = 9
        '
        'txtServerPort
        '
        Me.txtServerPort.Location = New System.Drawing.Point(93, 112)
        Me.txtServerPort.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtServerPort.Name = "txtServerPort"
        Me.txtServerPort.Size = New System.Drawing.Size(175, 25)
        Me.txtServerPort.TabIndex = 8
        Me.txtServerPort.Value = New Decimal(New Integer() {3306, 0, 0, 0})
        '
        'txtServerPassword
        '
        Me.txtServerPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtServerPassword.Location = New System.Drawing.Point(93, 81)
        Me.txtServerPassword.Name = "txtServerPassword"
        Me.txtServerPassword.Size = New System.Drawing.Size(175, 25)
        Me.txtServerPassword.TabIndex = 7
        Me.txtServerPassword.UseSystemPasswordChar = True
        '
        'txtServerUser
        '
        Me.txtServerUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtServerUser.Location = New System.Drawing.Point(93, 50)
        Me.txtServerUser.Name = "txtServerUser"
        Me.txtServerUser.Size = New System.Drawing.Size(175, 25)
        Me.txtServerUser.TabIndex = 6
        '
        'txtServerIP
        '
        Me.txtServerIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtServerIP.Location = New System.Drawing.Point(93, 18)
        Me.txtServerIP.Name = "txtServerIP"
        Me.txtServerIP.Size = New System.Drawing.Size(175, 25)
        Me.txtServerIP.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Database"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Port"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "User Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IP"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnSave)
        Me.TabPage2.Controls.Add(Me.txtDB)
        Me.TabPage2.Controls.Add(Me.txtPort)
        Me.TabPage2.Controls.Add(Me.txtPassword)
        Me.TabPage2.Controls.Add(Me.txtUser)
        Me.TabPage2.Controls.Add(Me.txtIP)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(293, 222)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "LOCAL"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Teal
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(93, 174)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(175, 29)
        Me.btnSave.TabIndex = 25
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtDB
        '
        Me.txtDB.FormattingEnabled = True
        Me.txtDB.Location = New System.Drawing.Point(93, 143)
        Me.txtDB.Name = "txtDB"
        Me.txtDB.Size = New System.Drawing.Size(175, 25)
        Me.txtDB.TabIndex = 19
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(93, 112)
        Me.txtPort.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(175, 25)
        Me.txtPort.TabIndex = 18
        Me.txtPort.Value = New Decimal(New Integer() {3306, 0, 0, 0})
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Location = New System.Drawing.Point(93, 81)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(175, 25)
        Me.txtPassword.TabIndex = 17
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUser
        '
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUser.Location = New System.Drawing.Point(93, 50)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(175, 25)
        Me.txtUser.TabIndex = 16
        '
        'txtIP
        '
        Me.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIP.Location = New System.Drawing.Point(93, 18)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(175, 25)
        Me.txtIP.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Database"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Port"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Password"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 17)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "User Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "IP"
        '
        'Database_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(301, 287)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Teal
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Database_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.txtServerPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.txtPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtServerDB As System.Windows.Forms.ComboBox
    Friend WithEvents txtServerPort As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtServerPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtServerUser As System.Windows.Forms.TextBox
    Friend WithEvents txtServerIP As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDB As System.Windows.Forms.ComboBox
    Friend WithEvents txtPort As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnServerSave As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
