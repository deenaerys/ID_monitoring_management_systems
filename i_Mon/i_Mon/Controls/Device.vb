Imports ADODB

Public Class Device
    '4294967296.0#
    Dim dv As New Device_Config
    Public Property Device_Property()
        Get
            Return dv
        End Get
        Set(ByVal value)
            dv = value

        End Set
    End Property
    Private is_connected As Boolean = False

    Private Sub bw_Conn_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bw_Conn.DoWork
        If My.Computer.Network.Ping(Me.txtip.Text.Trim()) = True Then
            Me.zk.BeginInit()
            Me.zk.Connect_Net(Me.txtip.Text.Trim, Convert.ToInt32(Me.txtport.Text.Trim))
            Me.zk.RegEvent(1, 32767)

            'Me.zk.EnableDevice(1, True)

            is_connected = True

        Else
            is_connected = False


        End If
    End Sub
    Private Sub Init_()
        Dim n As New Name_Config
        n = Get_Name_Config()
        Dim ac As New AccessLabel_Config
        ac = Get_AccessLabel_Config()
        Dim l As New Lane_Config
        l = Get_Lane_Config()
        Dim i As New ID_Config
        i = Get_ID_Config()

        With Me
            .txtlane.ForeColor = Color.FromArgb(l.lane_FA, l.lane_FR, l.lane_FG, l.lane_FB)
            .txtlane.BackColor = Color.FromArgb(l.lane_BA, l.lane_BR, l.lane_BG, l.lane_BB)
            .txtAccess.ForeColor = Color.FromArgb(ac.acc_FA, ac.acc_FR, ac.acc_FG, ac.acc_FB)
            .txtName.ForeColor = Color.FromArgb(n.name_FA, n.name_FR, n.name_FG, n.name_FB)
            .txtName.BackColor = Color.FromArgb(n.name_BA, n.name_BR, n.name_BG, n.name_BB)
            .txtlane.Font = FontFromString(l.lane_font)
            .txtAccess.Font = FontFromString(ac.acc_font)
            .txtName.Font = FontFromString(n.name_font)
            .txtlane.Height = l.lane_H
            .txtName.Height = n.name_H
            .txtAccess.Height = ac.acc_H
            .pic.Height = i.id_photo
            idfolder = i.id_folder
            .txtAccess.Text = ""
            .txtName.Text = ""
            .pic.Image = Nothing
            .pic.Invalidate()
            .txtCardcode.ForeColor = .txtlane.ForeColor
            .txtCardcode.BackColor = .txtlane.BackColor

        End With

    End Sub
    Sub controller_disconnected()
        txtstatus.Text = "Disconnected"
        ' Me.BackColor = Color.Maroon
        'btnStart.Enabled = True
    End Sub
    Sub controller_connected()
        txtstatus.Text = "Connected"
        Me.BackColor = Color.White
        ' btnStart.Enabled = False
    End Sub
    Private Sub bw_Conn_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bw_Conn.RunWorkerCompleted
        If is_connected = True Then
            controller_connected()

        Else
            controller_disconnected()

        End If
    End Sub

    Private Sub Device_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Init_()
        isexpired = False

        If Me.bw_Conn.IsBusy = False Then
            Me.bw_Conn.RunWorkerAsync()

        End If
    End Sub



    Private Sub zk_OnConnected(ByVal sender As Object, ByVal e As System.EventArgs) Handles zk.OnConnected
        controller_connected()

    End Sub

    Private Sub zk_OnDisConnected(ByVal sender As Object, ByVal e As System.EventArgs) Handles zk.OnDisConnected
        controller_disconnected()

    End Sub
    Private cc As String = ""
    Private isexpired As Boolean

    Private Sub zk_OnHIDNum(ByVal sender As Object, ByVal e As Axzkemkeeper._IZKEMEvents_OnHIDNumEvent) Handles zk.OnHIDNum
        Me.txtCardcode.Text = e.cardNumber.ToString

        If e.cardNumber.ToString.Length <= 2 Then Exit Sub
        If e.cardNumber < 0 Then
            cc = e.cardNumber + 4294967296
        Else
            cc = e.cardNumber

        End If
        If Show_Access(cc) = True Then

            Me.txtAccess.Text = "ACCESS AUTHORIZED"

        Else
            If isexpired = True Then
                Me.txtAccess.Text = "ACCESS EXPIRED"
                GoTo here
            End If

            Me.txtName.Text = ""
            Me.txtAccess.Text = "ACCESS DENIED"
        End If
here:   Me.tmr.Enabled = False 'True


    End Sub
    Public Sub Save_AccessLogs(ByVal dt As String, ByVal cardcode As String, ByVal name As String, ByVal ptype As String, ByVal lane As String, ByVal tapstatus As String)
        If PingMe(server_ip) = False Then
            Save_Logs("Can't ping " & server_ip & ". Saving Locally...")
            Save_AccessLogs_Local(dt, cardcode, name, ptype, lane, tapstatus)
            Exit Sub
        End If
        Try
            Dim con As New Connection
            If con.State = 1 Then con.Close()
            Dim str As String = String.Empty
            str = "Driver=" & server_driver & ";Server=" & server_ip & ";Port=" & server_port & ";UID=" & server_username & ";PWD=" & server_password & ";Database=" & server_db & ""
            With con
                .ConnectionTimeout = 0
                .CursorLocation = CursorLocationEnum.adUseClient
                .Open(str)
            End With
            con.Execute("INSERT INTO logs(dt,cardcode,personnel_name,personnel_type,lane,tapstatus) VALUES ('" & dt & "','" & cardcode & "','" & name & "','" & ptype & "','" & lane & "','" & tapstatus & "')")
            con.Close()



        Catch ex As Exception
            Save_Logs("Save_AccessLogs: " & ex.Message.ToString)

        End Try
    End Sub
    Public Sub Save_AccessLogs_Local(ByVal dt As String, ByVal cardcode As String, ByVal name As String, ByVal ptype As String, ByVal lane As String, ByVal tapstatus As String)
        Try
            Dim con As New Connection
            If con.State = 1 Then con.Close()
            Dim str As String = String.Empty
            str = "Driver=" & local_driver & ";Server=" & local_ip & ";Port=" & local_port & ";UID=" & local_username & ";PWD=" & local_password & ";Database=" & local_db & ""
            With con
                .ConnectionTimeout = 0
                .CursorLocation = CursorLocationEnum.adUseClient
                .Open(str)
            End With
            con.Execute("INSERT INTO logs(dt,cardcode,personnel_name,personnel_type,lane,tapstatus) VALUES ('" & dt & "','" & cardcode & "','" & name & "','" & ptype & "','" & lane & "','" & tapstatus & "')")
            con.Close()



        Catch ex As Exception
            Save_Logs("Save_AccessLogs_Local: " & ex.Message.ToString)

        End Try
    End Sub
    Public Function Show_Access(ByVal cardcode As String) As Boolean
        isexpired = False
        Try
            Dim con As New Connection
            If con.State = 1 Then con.Close()
            Dim str As String = String.Empty
            str = "Driver=" & local_driver & ";Server=" & local_ip & ";Port=" & local_port & ";UID=" & local_username & ";PWD=" & local_password & ";Database=" & local_db & ""
            With con
                .ConnectionTimeout = 0
                .CursorLocation = CursorLocationEnum.adUseClient
                .Open(str)
            End With

            Dim rs As New Recordset
            rs = con.Execute("SELECT * FROM personnel WHERE smartcardno='" & cardcode & "' LIMIT 1")
            If rs.EOF = False Then
                Dim name As String = rs("firstname").Value.ToString & " " & rs("middleinitial").Value.ToString & " " & rs("lastname").Value.ToString
                Dim ptype As String = rs("personneltype").Value.ToString
                Me.txtName.Text = name & vbCrLf & ptype

                If Format(Now, "yyyy-MM-dd HH:mm:ss") > Format(rs("expiration").Value, "yyyy-MM-dd HH:mm:ss") Then
                    isexpired = True
                    Try
                        Dim fp As String = idfolder & "\" & rs("photo").Value.ToString
                        Me.pic.Image = Image.FromFile(fp)
                    Catch ex As Exception
                        Me.pic.Image = Me.pic.ErrorImage

                    End Try
                    Save_AccessLogs(Format(Now, "yyyy-MM-dd HH:mm:ss"), cardcode, name, ptype, Me.txtlane.Text, "Access Expired")
                    Return False


                End If

                Me.zk.ACUnlock(1, CInt(Me.txtDelay.Text))

                Try
                    Dim fp As String = idfolder & "\" & rs("photo").Value.ToString
                    Me.pic.Image = Image.FromFile(fp)
                Catch ex As Exception
                    Me.pic.Image = Me.pic.ErrorImage

                End Try
                Save_AccessLogs(Format(Now, "yyyy-MM-dd HH:mm:ss"), cardcode, name, ptype, Me.txtlane.Text, "Access Authorized")
                Return True

            Else
                Save_AccessLogs(Format(Now, "yyyy-MM-dd HH:mm:ss"), cardcode, "", "", Me.txtlane.Text, "Access Denied")
                Return False
            End If


            con.Close()



        Catch ex As Exception

            Save_Logs("Show_Access: " & ex.Message.ToString)
            Return False
        End Try
    End Function

    Private Sub tmr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr.Tick


        Me.txtAccess.Text = ""
        Me.txtName.Text = ""
        Me.pic.Image = Nothing

        Me.pic.Invalidate()
        Me.pic.Refresh()
        Me.Refresh()

        Me.tmr.Enabled = False




    End Sub

    Private Sub txtAccess_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAccess.TextChanged
        If Me.txtAccess.Text = "" Then
            Me.txtAccess.BackColor = Color.Transparent

            Exit Sub
        End If

        If Me.txtAccess.Text = "ACCESS DENIED" Then
            Me.txtAccess.BackColor = Color.Maroon
            Exit Sub
        End If
        If Me.txtAccess.Text = "ACCESS AUTHORIZED" Then
            Me.txtAccess.BackColor = Color.Green
            Exit Sub
        End If
        If Me.txtAccess.Text = "ACCESS EXPIRED" Then
            Me.txtAccess.BackColor = Color.Silver
            Exit Sub
        End If
    End Sub
   
    
End Class
