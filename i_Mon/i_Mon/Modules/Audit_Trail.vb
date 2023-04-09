Imports System.IO

Module Audit_Trail
    Public current_PR As String

    Public serveripaddress As String

    Public isreprint As Boolean
    Public reprint_cashier As String
    Public reprint_POS As String


    Public isManualOR As Boolean
    Public LastOR As Long
    Public DataPush As Boolean
    Public NoCam As Boolean

    Public AP_Action As String = vbNullString
    Public ManualTicket_Number As String = vbNullString

    Public remarksTXN_str As String = vbNullString
    Public remarksTXN As String = vbNullString
    Public remarksOB As String = vbNullString

    Public LCDetails_str As String = vbNullString
    Public iscancelled As Boolean = False

    Public Succ_Amount As Double

    Public isGracePeriod As Boolean
    Public lastcard As String
    Public card_Timein As Date
    Public Has_DBTimein As Boolean


    Public myChange As Double
    Public Current_ORNumber As String

    Public ErrMSG As String
    Public LostCard_Manual As Boolean
    Public Operator_Name As String
    Public FullName As String
    Public Admin_Name As String
    Public IsBIR As Boolean
    Public IsEmp_Verification As Boolean
    Public IsXonly As Boolean
    Public Relivr_Name As String
    Public loc As String = Application.StartupPath & "\System Logs"
    Public Operator_Loc As String = Application.StartupPath & "\Operators Logs"
    Public IsRelivr As Boolean
    Public CashFund As Double
    Public CashInDrawer As Double
    Public PartialCashOut As Double
    Public Time_Login As String
    Public Time_Logout As String
    Public Relivr_Login As String
    Public Relivr_Logout As String
    Public Relivr_CashFund As Double
    Public Relivr_CashInDrawer As Double
    Public Relivr_PartialCashOut As Double
    Public LPTD As LPTDATA

    Public ejournalPath As String


    Public Structure LPTDATA
        Public name As String
        Public card As String
        Public isok As Boolean
    End Structure

    Private Sub Create_Folder()
        If Directory.Exists(loc) Then Exit Sub
        Directory.CreateDirectory(loc)
    End Sub

    Private Sub Create_Operator_Directory(ByVal Oname As String)
        On Error Resume Next

        If Directory.Exists(Operator_Loc & "\" & Oname) Then Exit Sub
        Directory.CreateDirectory(Operator_Loc & "\" & Oname)
    End Sub

    Public Sub Save_Logs(ByVal Message As String)

        ' On Error Resume Next

        Create_Folder()
        Dim DT_Logs As String = Format(Now, "MM.dd.yyyy")
        Dim TM_logs As String = Now.ToShortTimeString
        Dim Log_Loc As String = loc & "\" & DT_Logs & ".txt"
        Dim Data As StreamWriter

        If File.Exists(Log_Loc) Then
            Data = New StreamWriter(Log_Loc, True)
        Else
            Data = New StreamWriter(Log_Loc, False)
        End If

        Data.WriteLine(TM_logs & " =====> " & Message)
        Data.Dispose()

    End Sub

    Public Sub Save_OLogs(ByVal Message As String, ByVal OName As String)

        Create_Operator_Directory(OName)

        Dim DT_Logs As String = Format(Now, "MM.dd.yyyy")
        Dim TM_logs As String = Now.ToShortTimeString
        Dim Log_Loc As String = Operator_Loc & "\" & OName & "\" & DT_Logs & ".txt"
        Dim Data As StreamWriter

        If File.Exists(Log_Loc) Then
            Data = New StreamWriter(Log_Loc, True)
        Else
            Data = New StreamWriter(Log_Loc, False)
        End If

        Data.WriteLine(TM_logs & " =====> " & Message)
        Data.Dispose()

    End Sub
    Public Function Count_Occurrence(ByVal CharToCount As String, ByVal FromString As String) As Integer
        Dim ex As New System.Text.RegularExpressions.Regex(CharToCount)
        Dim m As System.Text.RegularExpressions.MatchCollection
        m = ex.Matches(FromString)
        Return m.Count
    End Function

    'Public Sub Save_UserTrack(ByVal user As String, ByVal modd As String, ByVal msg As String)
    '    If Usertrack_Enabled = False Then Exit Sub

    '    Try
    '        Create_Folder_UserTrack()
    '        Dim DT_Logs As String = Format(Now, "MM.dd.yyyy")
    '        Dim TM_logs As String = Format(Now, "HH:mm:ss")
    '        Dim Log_Loc As String = loc_usertrack & "\" & DT_Logs & ".txt"
    '        Dim Data As StreamWriter

    '        If File.Exists(Log_Loc) Then
    '            Data = New StreamWriter(Log_Loc, True)
    '        Else
    '            Data = New StreamWriter(Log_Loc, False)
    '        End If

    '        Data.WriteLine(TM_logs & "~" & user & "~" & modd & "~" & msg)
    '        Data.Dispose()
    '    Catch ex As Exception
    '        Exit Sub

    '    End Try
    'End Sub
    'Public loc_usertrack As String = Application.StartupPath & "\" & POS_REF.Station
    'Public Sub Create_Folder_UserTrack()
    '    If Directory.Exists(loc_usertrack) Then Exit Sub
    '    Directory.CreateDirectory(loc_usertrack)
    'End Sub
    'Public Sub Create_File_Runaway()
    '    Create_Folder_UserTrack()
    '    If File.Exists(loc_usertrack & "\Runaway.txt") = True Then Exit Sub
    '    File.CreateText(loc_usertrack & "\Runaway.txt")
    'End Sub

    
End Module
