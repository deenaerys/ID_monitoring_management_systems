<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DateTime_Settings
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
        Me.CD = New System.Windows.Forms.ColorDialog
        Me.txtFontColor = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnChangeFont = New System.Windows.Forms.Button
        Me.cbTransparent = New System.Windows.Forms.CheckBox
        Me.txtFont = New System.Windows.Forms.Label
        Me.cbVisible = New System.Windows.Forms.CheckBox
        Me.FD = New System.Windows.Forms.FontDialog
        Me.Button2 = New System.Windows.Forms.Button
        Me.txtY = New System.Windows.Forms.NumericUpDown
        Me.txtBG = New System.Windows.Forms.TextBox
        Me.txtX = New System.Windows.Forms.NumericUpDown
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txtFormat = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.txtY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'CD
        '
        Me.CD.FullOpen = True
        '
        'txtFontColor
        '
        Me.txtFontColor.AutoSize = True
        Me.txtFontColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFontColor.Location = New System.Drawing.Point(178, 320)
        Me.txtFontColor.Name = "txtFontColor"
        Me.txtFontColor.Size = New System.Drawing.Size(34, 19)
        Me.txtFontColor.TabIndex = 18
        Me.txtFontColor.Text = "      "
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(12, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 30)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Change font color"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnChangeFont
        '
        Me.btnChangeFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangeFont.Location = New System.Drawing.Point(12, 255)
        Me.btnChangeFont.Name = "btnChangeFont"
        Me.btnChangeFont.Size = New System.Drawing.Size(148, 30)
        Me.btnChangeFont.TabIndex = 16
        Me.btnChangeFont.Text = "Change font"
        Me.btnChangeFont.UseVisualStyleBackColor = True
        '
        'cbTransparent
        '
        Me.cbTransparent.AutoSize = True
        Me.cbTransparent.Location = New System.Drawing.Point(6, 60)
        Me.cbTransparent.Name = "cbTransparent"
        Me.cbTransparent.Size = New System.Drawing.Size(96, 21)
        Me.cbTransparent.TabIndex = 2
        Me.cbTransparent.Text = "Transparent"
        Me.cbTransparent.UseVisualStyleBackColor = True
        '
        'txtFont
        '
        Me.txtFont.AutoSize = True
        Me.txtFont.Location = New System.Drawing.Point(175, 260)
        Me.txtFont.Name = "txtFont"
        Me.txtFont.Size = New System.Drawing.Size(33, 17)
        Me.txtFont.TabIndex = 15
        Me.txtFont.Text = "Font"
        '
        'cbVisible
        '
        Me.cbVisible.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbVisible.Location = New System.Drawing.Point(0, 0)
        Me.cbVisible.Name = "cbVisible"
        Me.cbVisible.Size = New System.Drawing.Size(331, 25)
        Me.cbVisible.TabIndex = 12
        Me.cbVisible.Text = "Visible"
        Me.cbVisible.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(149, 55)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 29)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "CHANGE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtY
        '
        Me.txtY.Location = New System.Drawing.Point(63, 48)
        Me.txtY.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txtY.Minimum = New Decimal(New Integer() {1000000, 0, 0, -2147483648})
        Me.txtY.Name = "txtY"
        Me.txtY.Size = New System.Drawing.Size(150, 25)
        Me.txtY.TabIndex = 3
        Me.txtY.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtBG
        '
        Me.txtBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBG.Location = New System.Drawing.Point(6, 24)
        Me.txtBG.Name = "txtBG"
        Me.txtBG.Size = New System.Drawing.Size(218, 25)
        Me.txtBG.TabIndex = 0
        '
        'txtX
        '
        Me.txtX.Location = New System.Drawing.Point(63, 19)
        Me.txtX.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txtX.Minimum = New Decimal(New Integer() {1000000, 0, 0, -2147483648})
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(150, 25)
        Me.txtX.TabIndex = 2
        Me.txtX.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtY)
        Me.GroupBox2.Controls.Add(Me.txtX)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(230, 87)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Position"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Top:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Left:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cbTransparent)
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Controls.Add(Me.txtBG)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 159)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(230, 90)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Background Color"
        '
        'txtFormat
        '
        Me.txtFormat.Location = New System.Drawing.Point(71, 31)
        Me.txtFormat.Name = "txtFormat"
        Me.txtFormat.Size = New System.Drawing.Size(248, 25)
        Me.txtFormat.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Format"
        '
        'DateTime_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(331, 410)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFontColor)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnChangeFont)
        Me.Controls.Add(Me.txtFont)
        Me.Controls.Add(Me.cbVisible)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.txtFormat)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "DateTime_Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Date/Time Settings"
        CType(Me.txtY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CD As System.Windows.Forms.ColorDialog
    Friend WithEvents txtFontColor As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnChangeFont As System.Windows.Forms.Button
    Friend WithEvents cbTransparent As System.Windows.Forms.CheckBox
    Friend WithEvents txtFont As System.Windows.Forms.Label
    Friend WithEvents cbVisible As System.Windows.Forms.CheckBox
    Friend WithEvents FD As System.Windows.Forms.FontDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtY As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtBG As System.Windows.Forms.TextBox
    Friend WithEvents txtX As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFormat As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
