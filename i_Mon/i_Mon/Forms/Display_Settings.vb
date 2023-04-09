Public Class Display_Settings

    Private Sub Display_Settings_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Main.Show_Devices()

    End Sub

    Private Sub Display_Settings_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim x As New ini(IniFile)
        x.WriteInteger("ID", "W", Me.txtW.Value)
        x.WriteInteger("ID", "H", Me.txtH.Value)
        x.WriteInteger("ID", "P", Me.txtPhoto.Value)
        x.WriteString("ID", "F", Me.txtFolder.Text)
        x.WriteInteger("ID", "M", Me.txtPad.Value)
        x.WriteInteger("LANE", "H", Me.txtLaneH.Value)
        x.WriteInteger("NAME", "H", Me.txtNameH.Value)
        x.WriteInteger("ACC", "H", Me.txtAccH.Value)
        x.WriteBoolean("ID", "CC", CBool(Me.cbShowcardcode.Checked))

    End Sub

    Private Sub Display_Settings_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim x As New ID_Config
        x = Get_ID_Config()
        Me.txtW.Value = x.id_width
        Me.txtH.Value = x.id_height
        Me.txtPhoto.Value = x.id_photo
        Me.txtFolder.Text = x.id_folder
        Me.txtPad.Value = x.id_pad
        Me.cbShowcardcode.Checked = CBool(x.show_cardcode)


        Dim la As New Lane_Config
        la = Get_Lane_Config()
        Me.txtLaneFont.Font = FontFromString(la.lane_font)
        Me.txtLaneF.BackColor = Color.FromArgb(la.lane_FA, la.lane_FR, la.lane_FG, la.lane_FB)
        Me.txtLaneB.BackColor = Color.FromArgb(la.lane_BA, la.lane_BR, la.lane_BG, la.lane_BB)
        Me.txtLaneH.Value = la.lane_H


        Dim na As New Name_Config
        na = Get_Name_Config()
        Me.txtNameFont.Font = FontFromString(na.name_font)
        Me.txtNameF.BackColor = Color.FromArgb(na.name_FA, na.name_FR, na.name_FG, na.name_FB)
        Me.txtNameB.BackColor = Color.FromArgb(na.name_BA, na.name_BR, na.name_BG, na.name_BB)
        Me.txtNameH.Value = na.name_H


        Dim ac As New AccessLabel_Config
        ac = Get_AccessLabel_Config()
        Me.txtAccFont.Font = FontFromString(ac.acc_font)
        Me.txtaccF.BackColor = Color.FromArgb(ac.acc_FA, ac.acc_FR, ac.acc_FG, ac.acc_FB)
        Me.txtAccH.Value = ac.acc_H


    End Sub

 

    Private Sub btnChangeLaneFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeLaneFont.Click
        FD.ShowColor = False
        If FD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim x As New ini(IniFile)
            x.WriteString("LANE", "FONT", FD.Font.ToString)
            Me.txtLaneFont.Font = FD.Font
            Exit Sub

        End If
    End Sub

    Private Sub btnChangeLaneF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeLaneF.Click
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
        x.WriteInteger("LANE", "FA", A)
        x.WriteInteger("LANE", "FR", R)
        x.WriteInteger("LANE", "FG", G)
        x.WriteInteger("LANE", "FB", B)
        Dim y As New Lane_Config
        y = Get_Lane_Config()
        Me.txtLaneF.BackColor = Color.FromArgb(y.lane_FA, y.lane_FR, y.lane_FG, y.lane_FB)
        dlg.Dispose()
    End Sub

    Private Sub btnChangeLaneB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeLaneB.Click
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
        x.WriteInteger("LANE", "BA", A)
        x.WriteInteger("LANE", "BR", R)
        x.WriteInteger("LANE", "BG", G)
        x.WriteInteger("LANE", "BB", B)
        Dim y As New Lane_Config
        y = Get_Lane_Config()
        Me.txtLaneB.BackColor = Color.FromArgb(y.lane_BA, y.lane_BR, y.lane_BG, y.lane_BB)
        dlg.Dispose()
    End Sub

    Private Sub btnChangeNameF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeNameF.Click
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
        x.WriteInteger("NAME", "FA", A)
        x.WriteInteger("NAME", "FR", R)
        x.WriteInteger("NAME", "FG", G)
        x.WriteInteger("NAME", "FB", B)
        Dim y As New Name_Config
        y = Get_Name_Config()
        Me.txtNameF.BackColor = Color.FromArgb(y.name_FA, y.name_FR, y.name_FG, y.name_FB)
        dlg.Dispose()
    End Sub

    Private Sub btnChangeNameB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeNameB.Click
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
        x.WriteInteger("NAME", "BA", A)
        x.WriteInteger("NAME", "BR", R)
        x.WriteInteger("NAME", "BG", G)
        x.WriteInteger("NAME", "BB", B)
        Dim y As New Name_Config
        y = Get_Name_Config()
        Me.txtNameB.BackColor = Color.FromArgb(y.name_BA, y.name_BR, y.name_BG, y.name_BB)
        dlg.Dispose()
    End Sub

    Private Sub btnChangeNameFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeNameFont.Click
        FD.ShowColor = False
        If FD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim x As New ini(IniFile)
            x.WriteString("NAME", "FONT", FD.Font.ToString)
            Me.txtNameFont.Font = FD.Font
            Exit Sub

        End If
    End Sub

    Private Sub btnChangeAccFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeAccFont.Click
        FD.ShowColor = False
        If FD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim x As New ini(IniFile)
            x.WriteString("ACC", "FONT", FD.Font.ToString)
            Me.txtAccFont.Font = FD.Font
            Exit Sub

        End If
    End Sub

    Private Sub btnChangeAccF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeAccF.Click
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
        x.WriteInteger("ACC", "FA", A)
        x.WriteInteger("ACC", "FR", R)
        x.WriteInteger("ACC", "FG", G)
        x.WriteInteger("ACC", "FB", B)
        Dim y As New AccessLabel_Config
        y = Get_AccessLabel_Config()
        Me.txtaccF.BackColor = Color.FromArgb(y.acc_FA, y.acc_FR, y.acc_FG, y.acc_FB)
        dlg.Dispose()
    End Sub
End Class