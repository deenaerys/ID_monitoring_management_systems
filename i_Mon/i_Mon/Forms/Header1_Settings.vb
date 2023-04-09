Public Class Header2_Settings

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
        x.WriteInteger("HEADER1", "BA", A)
        x.WriteInteger("HEADER1", "BR", R)
        x.WriteInteger("HEADER1", "BG", G)
        x.WriteInteger("HEADER1", "BB", B)
        Dim y As New Header1_Config
        y = Get_Header1_Config()
        Me.txtBG.BackColor = Color.FromArgb(y.h1_BA, y.h1_BR, y.h1_BG, y.h1_BB)
        dlg.Dispose()

    End Sub

    Private Sub btnChangeFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeFont.Click
        FD.ShowColor = False
        If FD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim x As New ini(IniFile)
            x.WriteString("HEADER1", "FONT", FD.Font.ToString)
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
            x.WriteInteger("HEADER1", "FA", A)
            x.WriteInteger("HEADER1", "FR", R)
            x.WriteInteger("HEADER1", "FG", G)
            x.WriteInteger("HEADER1", "FB", B)
            Dim y As New Header1_Config

            y = Get_Header1_Config()
            Me.txtFontColor.BackColor = Color.FromArgb(y.h1_FA, y.h1_FR, y.h1_FG, y.h1_FB)

        End If
    End Sub

    Private Sub Header1_Settings_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Main.Set_Header1()

    End Sub

    Private Sub Header1_Settings_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim x As New ini(IniFile)

        x.WriteString("HEADER1", "TEXT", Me.txtHeader1Text.Text)
        x.WriteInteger("HEADER1", "X", Me.txtX.Value)
        x.WriteInteger("HEADER1", "Y", Me.txtY.Value)
        x.WriteBoolean("HEADER1", "V", CBool(Me.cbVisible.Checked))
        x.WriteBoolean("HEADER1", "TR", CBool(Me.cbTransparent.Checked))
    End Sub



    Private Sub Header1_Settings_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim h As New Header1_Config
        h = Get_Header1_Config()
        Me.txtHeader1Text.Text = h.h1_text
        Me.cbVisible.Checked = CBool(h.h1_visible)
        Me.txtX.Value = h.h1_x
        Me.txtY.Value = h.h1_y
        Me.cbTransparent.Checked = CBool(h.h1_transparent)
        Me.txtFont.Font = FontFromString(h.h1_Font)
        Me.txtFontColor.BackColor = Color.FromArgb(h.h1_FA, h.h1_FR, h.h1_FG, h.h1_FB)
        Me.txtBG.BackColor = Color.FromArgb(h.h1_BA, h.h1_BR, h.h1_BG, h.h1_BB)

    End Sub
End Class