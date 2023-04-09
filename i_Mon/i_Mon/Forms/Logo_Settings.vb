Public Class Logo_Settings

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OFD.Title = "Select Photo"
        If OFD.ShowDialog = DialogResult.OK Then
            Main.picLogo.Image = Image.FromFile(OFD.FileName)
            Me.TextBox1.Text = OFD.FileName
        End If
    End Sub

    Private Sub Logo_Settings_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Dim x As New Logo_Config
        x = Get_Logo_Config()
        Me.TextBox2.BackColor = Color.FromArgb(x.logo_A, x.logo_R, x.logo_G, x.logo_B)
    End Sub

    Private Sub Logo_Settings_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Main.Set_Logo()

    End Sub

    Private Sub Logo_Settings_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim x As New ini(IniFile)
        x.WriteBoolean("LOGO", "V", CBool(Me.CheckBox1.Checked))
        x.WriteInteger("LOGO", "W", Me.txtW.Value)
        x.WriteInteger("LOGO", "H", Me.txtH.Value)
        x.WriteInteger("LOGO", "X", Me.txtX.Value)
        x.WriteInteger("LOGO", "Y", Me.txtY.Value)
        x.WriteString("LOGO", "L", Me.TextBox1.Text)
        x.WriteInteger("LOGO", "S", Me.txtM.SelectedIndex)
        x.WriteBoolean("LOGO", "TR", CBool(Me.cbTransparent.Checked))

    End Sub

    Private Sub Logo_Settings_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FormColor(Me)
        Dim x As New Logo_Config
        x = Get_Logo_Config()
        Me.TextBox1.Text = x.logo_Location
        Me.txtH.Value = x.logo_height
        Me.txtW.Value = x.logo_width
        Me.txtX.Value = x.logo_posX
        Me.txtY.Value = x.logo_posY
        Me.txtM.SelectedIndex = x.logo_SizeMode
        Me.CheckBox1.Checked = x.logo_Visible
        Me.cbTransparent.Checked = x.logo_transparent

    End Sub

    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Dim dlg As New ColorDialog
        'dlg.AnyColor = True

        'dlg.ShowDialog()
        Dim dlg = Me.CD
        dlg.FullOpen = True
        'dlg.ShowDialog()

        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim A, R, G, B As Integer
            A = dlg.Color.A
            R = dlg.Color.R
            G = dlg.Color.G
            B = dlg.Color.B
            Dim x As New ini(IniFile)
            x.WriteInteger("LOGO", "A", A)
            x.WriteInteger("LOGO", "R", R)
            x.WriteInteger("LOGO", "G", G)
            x.WriteInteger("LOGO", "B", B)
            Dim y As New Logo_Config
            y = Get_Logo_Config()
            Me.TextBox2.BackColor = Color.FromArgb(y.logo_A, y.logo_R, y.logo_G, y.logo_B)
            dlg.Dispose()

        End If

    End Sub

   
    
End Class