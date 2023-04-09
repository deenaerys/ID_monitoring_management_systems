Public Class DateTime_Settings

    Private Sub DateTime_Settings_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Main.Set_DateTime()

    End Sub

    Private Sub DateTime_Settings_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim x As New ini(IniFile)

        x.WriteString("DATETIME", "FORMAT", Me.txtFormat.Text)
        x.WriteInteger("DATETIME", "X", Me.txtX.Value)
        x.WriteInteger("DATETIME", "Y", Me.txtY.Value)
        x.WriteBoolean("DATETIME", "V", CBool(Me.cbVisible.Checked))
        x.WriteBoolean("DATETIME", "TR", CBool(Me.cbTransparent.Checked))
    End Sub



    Private Sub DateTime_Settings_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim d As New DateTime_Config
        d = Get_DateTime_Config()
        Me.txtFormat.Text = d.dt_format
        Me.cbVisible.Checked = CBool(d.dt_visible)
        Me.txtX.Value = d.dt_x
        Me.txtY.Value = d.dt_y
        Me.cbTransparent.Checked = CBool(d.dt_transparent)
        Me.txtFont.Font = FontFromString(d.dt_Font)
        Me.txtFontColor.BackColor = Color.FromArgb(d.dt_FA, d.dt_FR, d.dt_FG, d.dt_FB)
        Me.txtBG.BackColor = Color.FromArgb(d.dt_BA, d.dt_BR, d.dt_BG, d.dt_BB)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Dim dlg As New ColorDialog
        'dlg.AnyColor = True

        'dlg.ShowDialog()
        Dim dlg = Me.CD
        dlg.FullOpen = True
        'dlg.ShowDialog()

        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
        Dim A, R, G, B As Integer
        A = dlg.Color.A
        R = dlg.Color.R
        G = dlg.Color.G
        B = dlg.Color.B
        Dim x As New ini(IniFile)
        x.WriteInteger("DATETIME", "BA", A)
        x.WriteInteger("DATETIME", "BR", R)
        x.WriteInteger("DATETIME", "BG", G)
        x.WriteInteger("DATETIME", "BB", B)
        Dim y As New DateTime_Config
        y = Get_DateTime_Config()
        Me.txtBG.BackColor = Color.FromArgb(y.dt_BA, y.dt_BR, y.dt_BG, y.dt_BB)
        dlg.Dispose()
    End Sub

    Private Sub btnChangeFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeFont.Click
        FD.ShowColor = False
        If FD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim x As New ini(IniFile)
            x.WriteString("DATETIME", "FONT", FD.Font.ToString)
            Me.txtFont.Font = FD.Font
            Exit Sub

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim A, R, G, B As Integer
            A = CD.Color.A
            R = CD.Color.R
            G = CD.Color.G
            B = CD.Color.B
            Dim x As New ini(IniFile)
            x.WriteInteger("DATETIME", "FA", A)
            x.WriteInteger("DATETIME", "FR", R)
            x.WriteInteger("DATETIME", "FG", G)
            x.WriteInteger("DATETIME", "FB", B)
            Dim y As New DateTime_Config

            y = Get_DateTime_Config()
            Me.txtFontColor.BackColor = Color.FromArgb(y.dt_FA, y.dt_FR, y.dt_FG, y.dt_FB)

        End If
    End Sub
End Class