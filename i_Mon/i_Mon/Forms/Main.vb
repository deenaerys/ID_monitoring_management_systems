Imports ADODB
Imports System.Threading

Public Class Main
    Private Lock_Controls As Boolean = True


    Private Sub Main_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Control = True And e.KeyCode = Keys.Insert Then
            Lock_Controls = Not (Lock_Controls)

            Exit Sub
        End If
        If e.Control = True And e.KeyCode = Keys.B Then
            Dim x As Integer = Me.pnlTop.Width
            Dim y As Integer = Me.pnlTop.Height
            Dim w As Integer = Me.FLP.Width
            Dim h As Integer = Me.FLP.Height
            MsgBox("Banner Size is " & x.ToString & " x " & y.ToString & vbCrLf & "Main Panel is " & w.ToString & " x " & h.ToString, MsgBoxStyle.Information, "")

            Exit Sub

        End If
        If e.KeyCode = Keys.F5 Then
            Show_Devices()

            Exit Sub

        End If
    End Sub
#Region "Date Time"
    Private mytmrDateTime As Threading.Timer
    Private mytmrDateTimeDelegate As TimerCallback = AddressOf mytmrDateTimeTick
    Private Sub mytmrDateTimeTick()
        Me.BeginInvoke(New MethodInvoker(AddressOf UpdatemytmrDateTime))

    End Sub
    Private Sub UpdatemytmrDateTime()
        Try
            If Me.InvokeRequired = True Then
                Me.Invoke(New MethodInvoker(AddressOf UpdatemytmrDateTime))
            Else
                'Me.txtDateTime.Text = Now.ToLongDateString & "   " & Now.ToLongTimeString
                Me.txtDateTime.Text = Format(Now, dtformat)

            End If
        Catch ex As Exception
            Exit Sub

        End Try
    End Sub


    Private DateTimerc As ResizeableControl
    Public Sub Set_DateTime()
        Dim d As New DateTime_Config
        d = Get_DateTime_Config()

        Me.txtDateTime.Visible = d.dt_visible
        If d.dt_transparent = True Then
            Me.txtDateTime.BackColor = Color.Transparent

        Else
            Me.txtDateTime.BackColor = Color.FromArgb(d.dt_BA, d.dt_BR, d.dt_BG, d.dt_BB)

        End If

        Me.txtDateTime.Font = FontFromString(d.dt_Font)
        Me.txtDateTime.ForeColor = Color.FromArgb(d.dt_FA, d.dt_FR, d.dt_FG, d.dt_FB)
        dtformat = d.dt_format




        Me.txtDateTime.Left = d.dt_x
        Me.txtDateTime.Top = d.dt_y

    End Sub
    Private Sub txtDateTime_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtDateTime.MouseDown
        If Lock_Controls = True Then Exit Sub

        StartPoint = Me.txtDateTime.PointToScreen(New Point(e.X, e.Y))
        IsDragging = True
    End Sub

    Private Sub txtDateTime_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtDateTime.MouseMove
        If Lock_Controls = True Then Exit Sub
        If IsDragging = True Then
            Dim EndPoint As Point = Me.txtDateTime.PointToScreen(New Point(e.X, e.Y))
            Me.txtDateTime.Left += (EndPoint.X - StartPoint.X)
            Me.txtDateTime.Top += (EndPoint.Y - StartPoint.Y)
            StartPoint = EndPoint
        End If
    End Sub

    Private Sub txtDateTime_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtDateTime.MouseUp
        If Lock_Controls = True Then Exit Sub
        IsDragging = False
        Me.Invoke(New del_SaveDateTimePos(AddressOf SaveDateTimePos))
    End Sub
    Private Delegate Sub del_SaveDateTimePos()
    Private Sub SaveDateTimePos()
        Dim x As New ini(IniFile)
        x.WriteInteger("DATETIME", "X", Me.txtDateTime.Left)
        x.WriteInteger("DATETIME", "Y", Me.txtDateTime.Top)

    End Sub
#End Region
#Region "Logo"
    Private Logorc As ResizeableControl
    Private IsDragging As Boolean = False
    Private StartPoint As Point
    Public Sub Set_Logo()
        Dim l As New Logo_Config
        l = Get_Logo_Config()
        Me.picLogo.Visible = l.logo_Visible
        Me.picLogo.Height = l.logo_height
        Me.picLogo.Width = l.logo_width
        Dim logoposition As New Point(l.logo_posX, l.logo_posY)
        Me.picLogo.Location = logoposition
        Me.picLogo.ImageLocation = l.logo_Location
        Me.picLogo.SizeMode = l.logo_SizeMode
        If l.logo_transparent = True Then
            Me.picLogo.BackColor = Color.Transparent

        Else
            Me.picLogo.BackColor = Color.FromArgb(l.logo_A, l.logo_R, l.logo_G, l.logo_B)

        End If

    End Sub

    Private Sub picLogo_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picLogo.MouseDown
        If Lock_Controls = True Then Exit Sub

        StartPoint = Me.picLogo.PointToScreen(New Point(e.X, e.Y))
        IsDragging = True
    End Sub

    Private Sub picLogo_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picLogo.MouseMove
        If Lock_Controls = True Then Exit Sub
        If IsDragging = True Then
            Dim EndPoint As Point = Me.picLogo.PointToScreen(New Point(e.X, e.Y))
            Me.picLogo.Left += (EndPoint.X - StartPoint.X)
            Me.picLogo.Top += (EndPoint.Y - StartPoint.Y)
            StartPoint = EndPoint
        End If
    End Sub

    Private Sub picLogo_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picLogo.MouseUp
        If Lock_Controls = True Then Exit Sub
        IsDragging = False
        Me.Invoke(New del_SaveLogoPos(AddressOf SaveLogoPOS))

    End Sub
    Private Delegate Sub del_SaveLogoPos()
    Private Sub SaveLogoPOS()
        Dim x As New ini(IniFile)
        x.WriteInteger("LOGO", "X", Me.picLogo.Left)
        x.WriteInteger("LOGO", "Y", Me.picLogo.Top)

    End Sub
#End Region

#Region "Header 1"
    Private Header1rc As ResizeableControl
    Public Sub Set_Header1()
        Dim h As New Header1_Config
        h = Get_Header1_Config()

        Me.txtHeader1.Visible = h.h1_visible
        If h.h1_transparent = True Then
            Me.txtHeader1.BackColor = Color.Transparent

        Else
            Me.txtHeader1.BackColor = Color.FromArgb(h.h1_BA, h.h1_BR, h.h1_BG, h.h1_BB)

        End If

        Me.txtHeader1.Font = FontFromString(h.h1_Font)
        Me.txtHeader1.ForeColor = Color.FromArgb(h.h1_FA, h.h1_FR, h.h1_FG, h.h1_FB)
        Me.txtHeader1.Text = h.h1_text
       
        Me.txtHeader1.Left = h.h1_x
        Me.txtHeader1.Top = h.h1_y

    End Sub
    Private Sub txtHeader1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtHeader1.MouseDown
        If Lock_Controls = True Then Exit Sub

        StartPoint = Me.txtHeader1.PointToScreen(New Point(e.X, e.Y))
        IsDragging = True
    End Sub
    Private Sub txtHeader1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtHeader1.MouseMove
        If Lock_Controls = True Then Exit Sub
        If IsDragging = True Then
            Dim EndPoint As Point = Me.txtHeader1.PointToScreen(New Point(e.X, e.Y))
            Me.txtHeader1.Left += (EndPoint.X - StartPoint.X)
            Me.txtHeader1.Top += (EndPoint.Y - StartPoint.Y)
            StartPoint = EndPoint
        End If
    End Sub
    Private Sub txtHeader1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtHeader1.MouseUp
        If Lock_Controls = True Then Exit Sub
        IsDragging = False
        Me.Invoke(New del_SaveHeader1Pos(AddressOf SaveHeader1POS))
    End Sub
    Private Delegate Sub del_SaveHeader1Pos()
    Private Sub SaveHeader1POS()
        Dim x As New ini(IniFile)
        x.WriteInteger("HEADER1", "X", Me.txtHeader1.Left)
        x.WriteInteger("HEADER1", "Y", Me.txtHeader1.Top)

    End Sub
#End Region

#Region "Header 2"
    Private Header2rc As ResizeableControl
    Public Sub Set_Header2()
        Dim h As New Header2_Config
        h = Get_Header2_Config()

        Me.txtHeader2.Visible = h.h2_visible
        If h.h2_transparent = True Then
            Me.txtHeader2.BackColor = Color.Transparent

        Else
            Me.txtHeader2.BackColor = Color.FromArgb(h.h2_BA, h.h2_BR, h.h2_BG, h.h2_BB)

        End If

        Me.txtHeader2.Font = FontFromString(h.h2_Font)
        Me.txtHeader2.ForeColor = Color.FromArgb(h.h2_FA, h.h2_FR, h.h2_FG, h.h2_FB)
        Me.txtHeader2.Text = h.h2_text

        Me.txtHeader2.Left = h.h2_x
        Me.txtHeader2.Top = h.h2_y

    End Sub
    Private Sub txtHeader2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtHeader2.MouseDown
        If Lock_Controls = True Then Exit Sub

        StartPoint = Me.txtHeader2.PointToScreen(New Point(e.X, e.Y))
        IsDragging = True
    End Sub

    Private Sub txtHeader2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtHeader2.MouseMove
        If Lock_Controls = True Then Exit Sub
        If IsDragging = True Then
            Dim EndPoint As Point = Me.txtHeader2.PointToScreen(New Point(e.X, e.Y))
            Me.txtHeader2.Left += (EndPoint.X - StartPoint.X)
            Me.txtHeader2.Top += (EndPoint.Y - StartPoint.Y)
            StartPoint = EndPoint
        End If
    End Sub

    Private Sub txtHeader2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtHeader2.MouseUp
        If Lock_Controls = True Then Exit Sub
        IsDragging = False
        Me.Invoke(New del_SaveHeader2Pos(AddressOf SaveHeader2POS))
    End Sub
    Private Delegate Sub del_SaveHeader2Pos()
    Private Sub SaveHeader2POS()
        Dim x As New ini(IniFile)
        x.WriteInteger("HEADER2", "X", Me.txtHeader2.Left)
        x.WriteInteger("HEADER2", "Y", Me.txtHeader2.Top)

    End Sub
#End Region

#Region "Banner"
    Private Bannerrc As ResizeableControl
    Public Sub Set_Banner()
        Dim b As New Banner_Config
        b = Get_Banner_Config()


        If b.banner_useimage = True Then
            Me.pnlTop.BackgroundImage = Image.FromFile(b.banner_image)
        Else
            Me.pnlTop.BackColor = Color.FromArgb(b.banner_BA, b.banner_BR, b.banner_BG, b.banner_BB)


        End If

        Me.pnlTop.Height = b.banner_height

    End Sub
  
    Private Delegate Sub del_SaveBannerPos()
    Private Sub SaveBannerPOS()
        Dim x As New ini(IniFile)
        x.WriteInteger("BANNER", "H", Me.pnlTop.Height)

    End Sub
#End Region

#Region "ID Display"

#End Region

    Private Sub Show_SysMsg(ByVal msg As String)
        Me.txtsysmsg.Text = msg
    End Sub
    Private Sub init()
        Dim sv As Server_Config
        sv = Get_Server_Config()
        server_ip = sv.ipaddress
        server_db = sv.port
        server_password = sv.password
        server_username = sv.username
        server_db = sv.dbname
        server_driver = sv.driver

        Dim lc As Local_Config
        lc = Get_Local_Config()
        local_ip = lc.ipaddress
        local_port = lc.Port
        local_username = lc.Username
        local_password = lc.Password
        local_db = lc.DBname
        local_driver = lc.driver

        Set_DateTime()
        Set_Logo()
        Set_Header1()
        Set_Header2()

        Set_Banner()

    End Sub

    Private Sub Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        init()

    End Sub
    Private Sub Main_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If Local_Connect() = False Then
            Show_SysMsg("Can't Connect To Local DB")
        End If
        If Server_Connect() = False Then
            Show_SysMsg("Can't Connect To Server DB")
        End If
        Show_Devices()

        Me.mytmrDateTime = New Threading.Timer(mytmrDateTimeDelegate, Nothing, 1000, 1000)
    End Sub
    Private devcnt As Integer = 0
    Public Function Count_Devices()
        If Local_Connect() = False Then
            Return 0
        End If
        Dim rs As New Recordset
        Try
            rs = Conn.Execute("SELECT COUNT(id) AS CNT FROM lane")
            If rs.EOF = False Then
                Return rs("CNT").Value
            Else
                Return 0
            End If
        Catch ex As Exception
            Save_Logs("Count_Devices(): " & ex.Message.ToString)
            Return 0
        End Try
    End Function
    Public Sub Show_Devices()
        Dim i As New ID_Config
        i = Get_ID_Config()

        If Me.InvokeRequired = True Then
            Me.BeginInvoke(New MethodInvoker(AddressOf Show_Devices))
        Else
            If Local_Connect() = False Then
                Me.FLP.Controls.Clear()
                Exit Sub
            End If
            Dim rs As New Recordset
            Try
                rs = Conn.Execute("SELECT * FROM lane ORDER BY ID ASC")
                If rs.EOF = False Then
                    Me.FLP.Controls.Clear()
                    Do
                        Dim x As New Device_Config
                        With x
                            .device_ip = rs("ip").Value.ToString
                            .device_lane = rs("lane_name").Value.ToString
                            .device_machinenumber = rs("machine_number").Value.ToString
                            .device_port = rs("port").Value.ToString
                            .device_status = rs("status").Value.ToString
                            .device_delay = rs("delay").Value.ToString
                        End With

                        Dim a As New Device
                        With a
                            .txtip.Text = x.device_ip
                            .txtlane.Text = x.device_lane
                            .txtmachinenumber.Text = x.device_machinenumber
                            .txtport.Text = x.device_port
                            .txtstatus.Text = x.device_status
                            .txtDelay.Text = x.device_delay
                            .Width = i.id_width '(Me.FLP.Width / Count_Devices()) - 145
                            .Height = i.id_height 'Me.FLP.Height - Me.StatusStrip1.Height - 200
                            idfolder = i.id_folder
                            .txtCardcode.Visible = i.show_cardcode

                            Me.FLP.Padding = New Padding(i.id_pad, 0, i.id_pad, 0)

                        End With
                        a.Device_Property = x
                        Me.FLP.Controls.Add(a)
                        devcnt += 1
                        rs.MoveNext()

                    Loop While rs.EOF = False


                Else
                    Me.FLP.Controls.Clear()
                    Exit Sub

                End If
            Catch ex As Exception
                Save_Logs("Show_Devices(): " & ex.Message.ToString)
                Me.FLP.Controls.Clear()
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub LogoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoToolStripMenuItem.Click
        Dim a As New Logo_Settings
        a.ShowDialog()

    End Sub

   
  
    
    Private Sub Header1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Header1ToolStripMenuItem.Click
        Dim a As New Header2_Settings

        a.ShowDialog()

    End Sub

    Private Sub Header2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Header2ToolStripMenuItem.Click
        Dim a As New H2_Settings
        a.ShowDialog()

    End Sub

   
    Private Sub DateTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimeToolStripMenuItem.Click
        Dim a As New DateTime_Settings
        a.ShowDialog()

    End Sub

   
   
    Private Sub pnlTop_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlTop.MouseDown
        If Lock_Controls = True Then Exit Sub

        StartPoint = Me.pnlTop.PointToScreen(New Point(e.X, e.Y))
        IsDragging = True
    End Sub

    Private Sub pnlTop_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlTop.MouseMove
        If Lock_Controls = True Then Exit Sub
        If IsDragging = True Then
            Dim EndPoint As Point = Me.pnlTop.PointToScreen(New Point(e.X, e.Y))
            Me.pnlTop.Left += (EndPoint.X - StartPoint.X)
            Me.pnlTop.Top += (EndPoint.Y - StartPoint.Y)
            StartPoint = EndPoint
        End If
    End Sub

    Private Sub pnlTop_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlTop.MouseUp
        If Lock_Controls = True Then Exit Sub
        IsDragging = False
        Me.Invoke(New del_SaveBannerPos(AddressOf SaveBannerPOS))
    End Sub

    Private Sub BannerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BannerToolStripMenuItem.Click
        Dim a As New Banner_Settings
        a.ShowDialog()

    End Sub

    Private Sub DatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatabaseToolStripMenuItem.Click
        Dim a As New Database_Form
        a.ShowDialog()

    End Sub

    Private Sub IDDisplayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IDDisplayToolStripMenuItem.Click
        Dim a As New Display_Settings
        a.ShowDialog()

    End Sub
End Class
