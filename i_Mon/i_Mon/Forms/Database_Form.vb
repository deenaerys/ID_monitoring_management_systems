Imports ADODB

Public Class Database_Form
    Private isclose As Boolean

    Private Sub Get_ServerDBnames()

    End Sub
    Private Sub Get_DBnames()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        isclose = True
        Me.Close()

    End Sub

    Private Sub Database_Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If isclose = True Then
            e.Cancel = False

        Else
            e.Cancel = True

        End If
    End Sub

    Private Sub btnServerSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnServerSave.Click
        Dim x As New ini(IniFile)
        x.WriteString("SERVER CONFIG", "IPADDRESS", Me.txtServerIP.Text)
        x.WriteString("SERVER CONFIG", "DBNAME", Me.txtServerDB.Text)
        x.WriteString("SERVER CONFIG", "PORT", Me.txtServerPort.Value)
        x.WriteString("SERVER CONFIG", "USERNAME", Me.txtServerUser.Text)
        x.WriteString("SERVER CONFIG", "PASSWORD", Me.txtServerPassword.Text)

        server_ip = Me.txtServerIP.Text
        server_db = Me.txtServerDB.Text
        server_port = Me.txtServerPort.Value
        server_username = Me.txtServerUser.Text
        server_password = Me.txtServerPassword.Text

        Server_ConnStr = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=" _
                            & Me.txtServerIP.Text & ";Port=" _
                            & Me.txtServerPort.Value & ";UID=" _
                            & Me.txtServerUser.Text & ";PWD=" _
                            & Me.txtServerPassword.Text & ";Database=" _
                            & Me.txtServerDB.Text & ""


        MsgBox("Settings Saved Successfully", MsgBoxStyle.Information, "Prompt")

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim x As New ini(IniFile)

        x.WriteString("LOCAL CONFIG", "IPADDRESS", Me.txtIP.Text)
        x.WriteString("LOCAL CONFIG", "DBNAME", Me.txtDB.Text)
        x.WriteString("LOCAL CONFIG", "PORT", Me.txtPort.Value)
        x.WriteString("LOCAL CONFIG", "USERNAME", Me.txtUser.Text)
        x.WriteString("LOCAL CONFIG", "PASSWORD", Me.txtPassword.Text)


        local_ip = Me.txtIP.Text
        local_db = Me.txtDB.Text
        local_port = Me.txtPort.Value
        local_username = Me.txtUser.Text
        local_password = Me.txtPassword.Text
        Local_ConnStr = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=" _
                             & Me.txtIP.Text & ";Port=" _
                             & Me.txtPort.Value & ";UID=" _
                             & Me.txtUser.Text & ";PWD=" _
                             & Me.txtPassword.Text & ";Database=" _
                             & Me.txtDB.Text & ""


        MsgBox("Settings Saved Successfully", MsgBoxStyle.Information, "Prompt")

    End Sub

    Private Sub Database_Form_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim svr As New Server_Config
        svr = Get_Server_Config()
        Me.txtServerDB.Text = svr.dbname
        Me.txtServerIP.Text = svr.ipaddress
        Me.txtServerPassword.Text = svr.password
        Me.txtServerPort.Value = CInt(svr.port)
        Me.txtServerUser.Text = svr.username

        Dim loc As New Local_Config
        loc = Get_Local_Config()
        Me.txtDB.Text = loc.DBname
        Me.txtIP.Text = loc.ipaddress
        Me.txtPassword.Text = loc.Password
        Me.txtPort.Value = CInt(loc.Port)
        Me.txtUser.Text = loc.Username

    End Sub
End Class