Public Class H2_Settings

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
        x.WriteInteger("HEADER2", "BA", A)
        x.WriteInteger("HEADER2", "BR", R)
        x.WriteInteger("HEADER2", "BG", G)
        x.WriteInteger("HEADER2", "BB", B)
        Dim y As New Header2_Config
        y = Get_Header2_Config()
        Me.txtBG.BackColor = Color.FromArgb(y.h2_BA, y.h2_BR, y.h2_BG, y.h2_BB)
        dlg.Dispose()

    End Sub

    Private Sub btnChangeFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeFont.Click
        FD.ShowColor = False
        If FD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim x As New ini(IniFile)
            x.WriteString("HEADER2", "FONT", FD.Font.ToString)
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
            x.WriteInteger("HEADER2", "FA", A)
            x.WriteInteger("HEADER2", "FR", R)
            x.WriteInteger("HEADER2", "FG", G)
            x.WriteInteger("HEADER2", "FB", B)
            Dim y As New Header2_Config

            y = Get_Header2_Config()
            Me.txtFontColor.BackColor = Color.FromArgb(y.h2_FA, y.h2_FR, y.h2_FG, y.h2_FB)

        End If
    End Sub

    Private Sub H2_Settings_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Main.Set_Header2()

    End Sub

    Private Sub H2_Settings_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim x As New ini(IniFile)

        x.WriteString("HEADER2", "TEXT", Me.txtHeader2Text.Text)
        x.WriteInteger("HEADER2", "X", Me.txtX.Value)
        x.WriteInteger("HEADER2", "Y", Me.txtY.Value)
        x.WriteBoolean("HEADER2", "V", CBool(Me.cbVisible.Checked))
        x.WriteBoolean("HEADER2", "TR", CBool(Me.cbTransparent.Checked))
    End Sub


    Private Sub H2_Settings_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim h As New Header2_Config
        h = Get_Header2_Config()
        Me.txtHeader2Text.Text = h.h2_text
        Me.cbVisible.Checked = CBool(h.h2_visible)
        Me.txtX.Value = h.h2_x
        Me.txtY.Value = h.h2_y
        Me.cbTransparent.Checked = CBool(h.h2_transparent)
        Me.txtFont.Font = FontFromString(h.h2_Font)
        Me.txtFontColor.BackColor = Color.FromArgb(h.h2_FA, h.h2_FR, h.h2_FG, h.h2_FB)
        Me.txtBG.BackColor = Color.FromArgb(h.h2_BA, h.h2_BR, h.h2_BG, h.h2_BB)
    End Sub
End Class