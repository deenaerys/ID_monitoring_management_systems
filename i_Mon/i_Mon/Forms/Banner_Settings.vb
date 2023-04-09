Public Class Banner_Settings

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OFD.Title = "Select Photo"
        If OFD.ShowDialog = DialogResult.OK Then
            Main.pnlTop.BackgroundImage = Image.FromFile(OFD.FileName)
            Me.TextBox1.Text = OFD.FileName
        End If
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
            x.WriteInteger("BANNER", "BA", A)
            x.WriteInteger("BANNER", "BR", R)
            x.WriteInteger("BANNER", "BG", G)
            x.WriteInteger("BANNER", "BB", B)
            Dim y As New Banner_Config
            y = Get_Banner_Config()
            Me.TextBox2.BackColor = Color.FromArgb(y.banner_BA, y.banner_BR, y.banner_BG, y.banner_BB)
            dlg.Dispose()

        End If
    End Sub

    Private Sub Banner_Settings_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Main.Set_Banner()

    End Sub

    Private Sub Banner_Settings_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim x As New ini(IniFile)
        x.WriteInteger("BANNER", "H", Me.txtH.Value)
        x.WriteBoolean("BANNER", "U", CBool(Me.cbUseImage.Checked))
       
    End Sub

    Private Sub Banner_Settings_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FormColor(Me)
        Dim x As New Banner_Config
        x = Get_Banner_Config()
        Me.TextBox1.Text = x.banner_image
        Me.txtH.Value = x.banner_height

        Me.cbUseImage.Checked = x.banner_useimage
        Dim y As New Banner_Config
        y = Get_Banner_Config()
        Me.TextBox2.BackColor = Color.FromArgb(y.banner_BA, y.banner_BR, y.banner_BG, y.banner_BB)

    End Sub
End Class