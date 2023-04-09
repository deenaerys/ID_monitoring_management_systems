Imports ADODB
Module ConnectionString
   
    Public ConnMS As Connection = New Connection
    Public Conn As Connection = New Connection

   
    Public Function Server_Connect() As Boolean

        Try
            ConnMS = New Connection

            ErrMSG = vbNullString


           

            Dim str As String = String.Empty

            If PingMe(server_ip) = False Then Return False
            str = "Driver=" & server_driver & ";Server=" _
                                & server_ip & ";Port=" _
                                & server_port & ";UID=" _
                                & server_username & ";PWD=" _
                                & server_password & ";Database=" & server_db & ";"

            If ConnMS.State = 1 Then ConnMS.Close()
            With ConnMS
                .CursorLocation = CursorLocationEnum.adUseServer
                .Open(str)
            End With

            ConnMS.Execute("SET GLOBAL Wait_Timeout=5000;")
            Return True

        Catch ex As Exception
            ErrMSG = "Fail to Connect in the Server (" & ex.Message & ")"
            Save_Logs(ex.Message.ToString)
            Return False
        End Try

    End Function

    Private Sub Close_CONNMS()
        On Error Resume Next
        ConnMS.Close()
        ConnMS = New Connection
    End Sub

   

    

   
    Public Function Local_Connect() As Boolean
        Try
            Conn = New Connection

            ErrMSG = vbNullString

            'If local_ok = False Then
            '    ErrMSG = "Config File not Set"
            '    Return False
            'End If

            If Conn.State = 1 Then Conn.Close()

            Dim str As String = String.Empty
            str = "Driver=" & local_driver & ";Server=" & local_ip & ";Port=" & local_port & ";UID=" & local_username & ";PWD=" & local_password & ";Database=" & local_db & ""
            With Conn
                .ConnectionTimeout = 0
                .CursorLocation = CursorLocationEnum.adUseClient
                .Open(str)
            End With

            ' Conn.Execute("SET GLOBAL Wait_Timeout=5000;")
            Return True

        Catch ex As Exception
            ErrMSG = "Local Database Error " & ex.Message
            Save_Logs(ex.Message.ToString)
            Return False
        End Try

    End Function

    Private Sub Close_CONN()
        On Error Resume Next
        Conn.Close()
        Conn = New Connection
    End Sub


  

End Module
