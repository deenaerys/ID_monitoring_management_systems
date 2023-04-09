Module Network

    Public Function PingMe(ByVal IPaddress As String) As Boolean
        On Error Resume Next
        ErrMSG = vbNullString

        If My.Computer.Network.IsAvailable = False Then
            ErrMSG = "There is no Network Available"
            Return False

        End If

        If My.Computer.Network.Ping(IPaddress, 5) = False Then
            ' ErrMSG = "Ping Test Fail @ " & IPaddress
            Return False
        Else
            Return True
        End If
    End Function

    Public Function GetLocalIP() As String

        Dim _IP As String = Nothing
        Dim _IPHostEntry As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName())

        For Each _IPAddress As System.Net.IPAddress In _IPHostEntry.AddressList

            If _IPAddress.AddressFamily.ToString() = "InterNetwork" Then

                _IP = _IPAddress.ToString()

            End If

        Next _IPAddress

        Return _IP

    End Function

End Module
