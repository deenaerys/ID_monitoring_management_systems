<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Display_Settings
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtPad = New System.Windows.Forms.NumericUpDown
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtPhoto = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtH = New System.Windows.Forms.NumericUpDown
        Me.txtW = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtLaneH = New System.Windows.Forms.NumericUpDown
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnChangeLaneFont = New System.Windows.Forms.Button
        Me.btnChangeLaneB = New System.Windows.Forms.Button
        Me.btnChangeLaneF = New System.Windows.Forms.Button
        Me.txtLaneFont = New System.Windows.Forms.Label
        Me.txtLaneB = New System.Windows.Forms.TextBox
        Me.txtLaneF = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtNameH = New System.Windows.Forms.NumericUpDown
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnChangeNameFont = New System.Windows.Forms.Button
        Me.btnChangeNameB = New System.Windows.Forms.Button
        Me.btnChangeNameF = New System.Windows.Forms.Button
        Me.txtNameFont = New System.Windows.Forms.Label
        Me.txtNameB = New System.Windows.Forms.TextBox
        Me.txtNameF = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtAccH = New System.Windows.Forms.NumericUpDown
        Me.Label12 = New System.Windows.Forms.Label
        Me.btnChangeAccFont = New System.Windows.Forms.Button
        Me.btnChangeAccF = New System.Windows.Forms.Button
        Me.txtAccFont = New System.Windows.Forms.Label
        Me.txtaccF = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.FD = New System.Windows.Forms.FontDialog
        Me.CD = New System.Windows.Forms.ColorDialog
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtFolder = New System.Windows.Forms.TextBox
        Me.cbShowcardcode = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtPad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtLaneH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.txtNameH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.txtAccH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPad)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtPhoto)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtH)
        Me.GroupBox1.Controls.Add(Me.txtW)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 149)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Size"
        '
        'txtPad
        '
        Me.txtPad.Location = New System.Drawing.Point(63, 112)
        Me.txtPad.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtPad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtPad.Name = "txtPad"
        Me.txtPad.Size = New System.Drawing.Size(150, 25)
        Me.txtPad.TabIndex = 7
        Me.txtPad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(24, 114)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(33, 17)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Pad:"
        '
        'txtPhoto
        '
        Me.txtPhoto.Location = New System.Drawing.Point(63, 81)
        Me.txtPhoto.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtPhoto.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtPhoto.Name = "txtPhoto"
        Me.txtPhoto.Size = New System.Drawing.Size(150, 25)
        Me.txtPhoto.TabIndex = 5
        Me.txtPhoto.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Photo:"
        '
        'txtH
        '
        Me.txtH.Location = New System.Drawing.Point(63, 48)
        Me.txtH.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtH.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtH.Name = "txtH"
        Me.txtH.Size = New System.Drawing.Size(150, 25)
        Me.txtH.TabIndex = 3
        Me.txtH.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtW
        '
        Me.txtW.Location = New System.Drawing.Point(63, 19)
        Me.txtW.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtW.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtW.Name = "txtW"
        Me.txtW.Size = New System.Drawing.Size(150, 25)
        Me.txtW.TabIndex = 2
        Me.txtW.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Height:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Width:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtLaneH)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btnChangeLaneFont)
        Me.GroupBox2.Controls.Add(Me.btnChangeLaneB)
        Me.GroupBox2.Controls.Add(Me.btnChangeLaneF)
        Me.GroupBox2.Controls.Add(Me.txtLaneFont)
        Me.GroupBox2.Controls.Add(Me.txtLaneB)
        Me.GroupBox2.Controls.Add(Me.txtLaneF)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 167)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(230, 159)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lane"
        '
        'txtLaneH
        '
        Me.txtLaneH.Location = New System.Drawing.Point(77, 27)
        Me.txtLaneH.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.txtLaneH.Name = "txtLaneH"
        Me.txtLaneH.Size = New System.Drawing.Size(55, 25)
        Me.txtLaneH.TabIndex = 10
        Me.txtLaneH.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Height"
        '
        'btnChangeLaneFont
        '
        Me.btnChangeLaneFont.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeLaneFont.Location = New System.Drawing.Point(138, 125)
        Me.btnChangeLaneFont.Name = "btnChangeLaneFont"
        Me.btnChangeLaneFont.Size = New System.Drawing.Size(75, 23)
        Me.btnChangeLaneFont.TabIndex = 8
        Me.btnChangeLaneFont.Text = "Change"
        Me.btnChangeLaneFont.UseVisualStyleBackColor = True
        '
        'btnChangeLaneB
        '
        Me.btnChangeLaneB.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeLaneB.Location = New System.Drawing.Point(138, 96)
        Me.btnChangeLaneB.Name = "btnChangeLaneB"
        Me.btnChangeLaneB.Size = New System.Drawing.Size(75, 23)
        Me.btnChangeLaneB.TabIndex = 7
        Me.btnChangeLaneB.Text = "Change"
        Me.btnChangeLaneB.UseVisualStyleBackColor = True
        '
        'btnChangeLaneF
        '
        Me.btnChangeLaneF.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeLaneF.Location = New System.Drawing.Point(138, 64)
        Me.btnChangeLaneF.Name = "btnChangeLaneF"
        Me.btnChangeLaneF.Size = New System.Drawing.Size(75, 23)
        Me.btnChangeLaneF.TabIndex = 6
        Me.btnChangeLaneF.Text = "Change"
        Me.btnChangeLaneF.UseVisualStyleBackColor = True
        '
        'txtLaneFont
        '
        Me.txtLaneFont.AutoSize = True
        Me.txtLaneFont.Location = New System.Drawing.Point(74, 127)
        Me.txtLaneFont.Name = "txtLaneFont"
        Me.txtLaneFont.Size = New System.Drawing.Size(30, 17)
        Me.txtLaneFont.TabIndex = 5
        Me.txtLaneFont.Text = "Abc"
        '
        'txtLaneB
        '
        Me.txtLaneB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLaneB.Location = New System.Drawing.Point(77, 94)
        Me.txtLaneB.Name = "txtLaneB"
        Me.txtLaneB.Size = New System.Drawing.Size(55, 25)
        Me.txtLaneB.TabIndex = 4
        '
        'txtLaneF
        '
        Me.txtLaneF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLaneF.Location = New System.Drawing.Point(77, 62)
        Me.txtLaneF.Name = "txtLaneF"
        Me.txtLaneF.Size = New System.Drawing.Size(55, 25)
        Me.txtLaneF.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Font"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Backcolor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Forecolor"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtNameH)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.btnChangeNameFont)
        Me.GroupBox3.Controls.Add(Me.btnChangeNameB)
        Me.GroupBox3.Controls.Add(Me.btnChangeNameF)
        Me.GroupBox3.Controls.Add(Me.txtNameFont)
        Me.GroupBox3.Controls.Add(Me.txtNameB)
        Me.GroupBox3.Controls.Add(Me.txtNameF)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(248, 167)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(230, 159)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Name"
        '
        'txtNameH
        '
        Me.txtNameH.Location = New System.Drawing.Point(81, 27)
        Me.txtNameH.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.txtNameH.Name = "txtNameH"
        Me.txtNameH.Size = New System.Drawing.Size(55, 25)
        Me.txtNameH.TabIndex = 12
        Me.txtNameH.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 17)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Height"
        '
        'btnChangeNameFont
        '
        Me.btnChangeNameFont.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeNameFont.Location = New System.Drawing.Point(142, 125)
        Me.btnChangeNameFont.Name = "btnChangeNameFont"
        Me.btnChangeNameFont.Size = New System.Drawing.Size(75, 23)
        Me.btnChangeNameFont.TabIndex = 8
        Me.btnChangeNameFont.Text = "Change"
        Me.btnChangeNameFont.UseVisualStyleBackColor = True
        '
        'btnChangeNameB
        '
        Me.btnChangeNameB.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeNameB.Location = New System.Drawing.Point(142, 96)
        Me.btnChangeNameB.Name = "btnChangeNameB"
        Me.btnChangeNameB.Size = New System.Drawing.Size(75, 23)
        Me.btnChangeNameB.TabIndex = 7
        Me.btnChangeNameB.Text = "Change"
        Me.btnChangeNameB.UseVisualStyleBackColor = True
        '
        'btnChangeNameF
        '
        Me.btnChangeNameF.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeNameF.Location = New System.Drawing.Point(142, 64)
        Me.btnChangeNameF.Name = "btnChangeNameF"
        Me.btnChangeNameF.Size = New System.Drawing.Size(75, 23)
        Me.btnChangeNameF.TabIndex = 6
        Me.btnChangeNameF.Text = "Change"
        Me.btnChangeNameF.UseVisualStyleBackColor = True
        '
        'txtNameFont
        '
        Me.txtNameFont.AutoSize = True
        Me.txtNameFont.Location = New System.Drawing.Point(78, 127)
        Me.txtNameFont.Name = "txtNameFont"
        Me.txtNameFont.Size = New System.Drawing.Size(30, 17)
        Me.txtNameFont.TabIndex = 5
        Me.txtNameFont.Text = "Abc"
        '
        'txtNameB
        '
        Me.txtNameB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNameB.Location = New System.Drawing.Point(81, 94)
        Me.txtNameB.Name = "txtNameB"
        Me.txtNameB.Size = New System.Drawing.Size(55, 25)
        Me.txtNameB.TabIndex = 4
        '
        'txtNameF
        '
        Me.txtNameF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNameF.Location = New System.Drawing.Point(81, 62)
        Me.txtNameF.Name = "txtNameF"
        Me.txtNameF.Size = New System.Drawing.Size(55, 25)
        Me.txtNameF.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 17)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Font"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 17)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Backcolor"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 17)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Forecolor"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtAccH)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.btnChangeAccFont)
        Me.GroupBox4.Controls.Add(Me.btnChangeAccF)
        Me.GroupBox4.Controls.Add(Me.txtAccFont)
        Me.GroupBox4.Controls.Add(Me.txtaccF)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Location = New System.Drawing.Point(248, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(230, 149)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Access Label"
        '
        'txtAccH
        '
        Me.txtAccH.Location = New System.Drawing.Point(81, 27)
        Me.txtAccH.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.txtAccH.Name = "txtAccH"
        Me.txtAccH.Size = New System.Drawing.Size(55, 25)
        Me.txtAccH.TabIndex = 14
        Me.txtAccH.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 17)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Height"
        '
        'btnChangeAccFont
        '
        Me.btnChangeAccFont.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeAccFont.Location = New System.Drawing.Point(142, 108)
        Me.btnChangeAccFont.Name = "btnChangeAccFont"
        Me.btnChangeAccFont.Size = New System.Drawing.Size(75, 23)
        Me.btnChangeAccFont.TabIndex = 8
        Me.btnChangeAccFont.Text = "Change"
        Me.btnChangeAccFont.UseVisualStyleBackColor = True
        '
        'btnChangeAccF
        '
        Me.btnChangeAccF.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeAccF.Location = New System.Drawing.Point(142, 66)
        Me.btnChangeAccF.Name = "btnChangeAccF"
        Me.btnChangeAccF.Size = New System.Drawing.Size(75, 23)
        Me.btnChangeAccF.TabIndex = 6
        Me.btnChangeAccF.Text = "Change"
        Me.btnChangeAccF.UseVisualStyleBackColor = True
        '
        'txtAccFont
        '
        Me.txtAccFont.AutoSize = True
        Me.txtAccFont.Location = New System.Drawing.Point(78, 110)
        Me.txtAccFont.Name = "txtAccFont"
        Me.txtAccFont.Size = New System.Drawing.Size(30, 17)
        Me.txtAccFont.TabIndex = 5
        Me.txtAccFont.Text = "Abc"
        '
        'txtaccF
        '
        Me.txtaccF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtaccF.Location = New System.Drawing.Point(81, 64)
        Me.txtaccF.Name = "txtaccF"
        Me.txtaccF.Size = New System.Drawing.Size(55, 25)
        Me.txtaccF.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 106)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 17)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Font"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 66)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 17)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Forecolor"
        '
        'CD
        '
        Me.CD.FullOpen = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 342)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 17)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Photo Folder "
        '
        'txtFolder
        '
        Me.txtFolder.Location = New System.Drawing.Point(105, 339)
        Me.txtFolder.Name = "txtFolder"
        Me.txtFolder.Size = New System.Drawing.Size(374, 25)
        Me.txtFolder.TabIndex = 7
        '
        'cbShowcardcode
        '
        Me.cbShowcardcode.AutoSize = True
        Me.cbShowcardcode.Location = New System.Drawing.Point(12, 370)
        Me.cbShowcardcode.Name = "cbShowcardcode"
        Me.cbShowcardcode.Size = New System.Drawing.Size(119, 21)
        Me.cbShowcardcode.TabIndex = 8
        Me.cbShowcardcode.Text = "Show Cardcode"
        Me.cbShowcardcode.UseVisualStyleBackColor = True
        '
        'Display_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(491, 399)
        Me.Controls.Add(Me.cbShowcardcode)
        Me.Controls.Add(Me.txtFolder)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Display_Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ID Display Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtPad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtLaneH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.txtNameH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.txtAccH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtH As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtW As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLaneFont As System.Windows.Forms.Label
    Friend WithEvents txtLaneB As System.Windows.Forms.TextBox
    Friend WithEvents txtLaneF As System.Windows.Forms.TextBox
    Friend WithEvents btnChangeLaneFont As System.Windows.Forms.Button
    Friend WithEvents btnChangeLaneB As System.Windows.Forms.Button
    Friend WithEvents btnChangeLaneF As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnChangeNameFont As System.Windows.Forms.Button
    Friend WithEvents btnChangeNameB As System.Windows.Forms.Button
    Friend WithEvents btnChangeNameF As System.Windows.Forms.Button
    Friend WithEvents txtNameFont As System.Windows.Forms.Label
    Friend WithEvents txtNameB As System.Windows.Forms.TextBox
    Friend WithEvents txtNameF As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnChangeAccFont As System.Windows.Forms.Button
    Friend WithEvents btnChangeAccF As System.Windows.Forms.Button
    Friend WithEvents txtAccFont As System.Windows.Forms.Label
    Friend WithEvents txtaccF As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents FD As System.Windows.Forms.FontDialog
    Friend WithEvents CD As System.Windows.Forms.ColorDialog
    Friend WithEvents txtLaneH As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNameH As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAccH As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPhoto As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtFolder As System.Windows.Forms.TextBox
    Friend WithEvents txtPad As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cbShowcardcode As System.Windows.Forms.CheckBox
End Class
