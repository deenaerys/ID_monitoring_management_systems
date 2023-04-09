Imports ADODB
Module Structure_Functions

    Public entryid As String
    Public posid As String
    Public xgrace As String = 15
    Public crid As String


    Public saveSuc As Boolean = True
    Public isReg As Boolean = False
    Public ta As Double
    Public discTotal As Boolean = False
    Public ovstart As Date
    '#################################### ADD BEG #########################
    Public IniLocation As String = Application.StartupPath & "\i.mon" 'Environment.SystemDirectory & "\i.mon"
    Public IniFile As String = IniLocation
    '######################################################################
    Public INI As New ini(IniFile)



#Region "Server Config"
    Public server_driver As String
    Public Server_ConnStr As String
    Public server_ip As String
    Public server_port As Long
    Public server_username As String
    Public server_password As String
    Public server_db As String
    Public server_ok As Boolean
    Public Structure Server_Config
        Public ipaddress As String
        Public port As Long
        Public username As String
        Public password As String
        Public dbname As String
        Public driver As String
        Public iSok As Boolean
    End Structure
    Public Function Get_Server_Config() As Server_Config
        Dim x As New Server_Config
        x.ipaddress = INI.GetString("SERVER CONFIG", "IPADDRESS", vbNullString)
        x.dbname = INI.GetString("SERVER CONFIG", "DBNAME", "idb")
        x.port = INI.GetInteger("SERVER CONFIG", "PORT", 3306)
        x.username = INI.GetString("SERVER CONFIG", "USERNAME", "root")
        x.password = INI.GetString("SERVER CONFIG", "PASSWORD", vbNullString)
        x.driver = INI.GetString("SERVER CONFIG", "DRIVER", "Driver={MySQL ODBC 8.0 Unicode Driver}")
        x.iSok = True
        Return x
    End Function
#End Region

#Region "Local Config"
    Public Local_ConnStr As String
    Public local_driver As String
    Public local_ip As String
    Public local_port As Long
    Public local_username As String
    Public local_password As String
    Public local_db As String
    Public local_ok As Boolean

    Public Structure Local_Config
        Public ipaddress As String
        Public Port As Long
        Public Username As String
        Public Password As String
        Public DBname As String
        Public driver As String
        Public IsOk As Boolean
    End Structure

    Public Function Get_Local_Config() As Local_Config
        Dim x As New Local_Config
        x.ipaddress = INI.GetString("LOCAL CONFIG", "IPADDRESS", "127.0.0.1")
        x.DBname = INI.GetString("LOCAL CONFIG", "DBNAME", "idb")
        x.Port = INI.GetInteger("LOCAL CONFIG", "PORT", 3306)
        x.Username = INI.GetString("LOCAL CONFIG", "USERNAME", "root")
        x.Password = INI.GetString("LOCAL CONFIG", "PASSWORD", vbNullString)
        x.driver = INI.GetString("LOCAL CONFIG", "DRIVER", "Driver={MySQL ODBC 8.0 Unicode Driver}")
        x.IsOk = True
        Return x
    End Function

#End Region
#Region "Logo Config"
    Public Structure Logo_Config
        Public logo_posX As Integer
        Public logo_posY As Integer
        Public logo_width As Integer
        Public logo_height As Integer
        Public logo_SizeMode As Integer
        Public logo_Visible As Boolean
        Public logo_Location As String
        Public logo_A As Integer
        Public logo_R As Integer
        Public logo_G As Integer
        Public logo_B As Integer
        Public logo_transparent As Boolean

    End Structure
    Public Function Get_Logo_Config() As Logo_Config
        Dim x As New Logo_Config
        x.logo_height = INI.GetInteger("LOGO", "H", 100)
        x.logo_width = INI.GetInteger("LOGO", "W", 100)
        x.logo_posX = INI.GetInteger("LOGO", "X", 100)
        x.logo_posY = INI.GetInteger("LOGO", "Y", 100)
        x.logo_SizeMode = INI.GetInteger("LOGO", "S", 4)
        x.logo_Visible = INI.GetBoolean("LOGO", "V", True)
        x.logo_Location = INI.GetString("LOGO", "L", Application.StartupPath & "\Logo\Logo.png")
        x.logo_A = INI.GetInteger("LOGO", "A", 255)
        x.logo_R = INI.GetInteger("LOGO", "R", 255)
        x.logo_G = INI.GetInteger("LOGO", "G", 255)
        x.logo_B = INI.GetInteger("LOGO", "B", 255)
        x.logo_transparent = INI.GetBoolean("LOGO", "TR", True)
        Return x

    End Function
#End Region

#Region "Header 1 Config"
    Public Structure Header1_Config
        Public h1_text As String
        Public h1_Font As String
        Public h1_x As Integer
        Public h1_y As Integer
        Public h1_FA As Integer
        Public h1_FR As Integer
        Public h1_FG As Integer
        Public h1_FB As Integer
        Public h1_BA As Integer
        Public h1_BR As Integer
        Public h1_BG As Integer
        Public h1_BB As Integer
        Public h1_visible As Boolean
        Public h1_transparent As Boolean

    End Structure
    Public Function Get_Header1_Config()
        Dim x As New Header1_Config
        x.h1_text = INI.GetString("HEADER1", "TEXT", "Header Text")
        x.h1_x = INI.GetInteger("HEADER1", "X", 0)
        x.h1_y = INI.GetInteger("HEADER1", "Y", 0)
        x.h1_FA = INI.GetInteger("HEADER1", "FA", 255)
        x.h1_FR = INI.GetInteger("HEADER1", "FR", 255)
        x.h1_FG = INI.GetInteger("HEADER1", "FG", 255)
        x.h1_FB = INI.GetInteger("HEADER1", "FB", 255)
        x.h1_Font = INI.GetString("HEADER1", "FONT", "[Font: Name=Berlin Sans FB, Size=24, Units=3, GdiCharSet=0, GdiVerticalFont=False]")
        x.h1_BA = INI.GetInteger("HEADER1", "BA", 255)
        x.h1_BR = INI.GetInteger("HEADER1", "BR", 255)
        x.h1_BG = INI.GetInteger("HEADER1", "BG", 255)
        x.h1_BB = INI.GetInteger("HEADER1", "BB", 255)
        x.h1_visible = INI.GetBoolean("HEADER1", "V", True)
        x.h1_transparent = INI.GetBoolean("HEADER1", "TR", True)
        Return x
    End Function
    
#End Region


#Region "Header 2 Config"
    Public Structure Header2_Config
        Public h2_text As String
        Public h2_Font As String
        Public h2_x As Integer
        Public h2_y As Integer
        Public h2_FA As Integer
        Public h2_FR As Integer
        Public h2_FG As Integer
        Public h2_FB As Integer
        Public h2_BA As Integer
        Public h2_BR As Integer
        Public h2_BG As Integer
        Public h2_BB As Integer
        Public h2_visible As Boolean
        Public h2_transparent As Boolean

    End Structure
    Public Function Get_Header2_Config()
        Dim x As New Header2_Config
        x.h2_text = INI.GetString("HEADER2", "TEXT", "Header Text")
        x.h2_x = INI.GetInteger("HEADER2", "X", 0)
        x.h2_y = INI.GetInteger("HEADER2", "Y", 0)
        x.h2_FA = INI.GetInteger("HEADER2", "FA", 255)
        x.h2_FR = INI.GetInteger("HEADER2", "FR", 255)
        x.h2_FG = INI.GetInteger("HEADER2", "FG", 255)
        x.h2_FB = INI.GetInteger("HEADER2", "FB", 255)
        x.h2_Font = INI.GetString("HEADER2", "FONT", "[Font: Name=Berlin Sans FB, Size=24, Units=3, GdiCharSet=0, GdiVerticalFont=False]")
        x.h2_BA = INI.GetInteger("HEADER2", "BA", 255)
        x.h2_BR = INI.GetInteger("HEADER2", "BR", 255)
        x.h2_BG = INI.GetInteger("HEADER2", "BG", 255)
        x.h2_BB = INI.GetInteger("HEADER2", "BB", 255)
        x.h2_visible = INI.GetBoolean("HEADER2", "V", True)
        x.h2_transparent = INI.GetBoolean("HEADER2", "TR", True)
        Return x
    End Function

#End Region


#Region "DateTime Config"
    Public dtformat As String

    Public Structure DateTime_Config
        Public dt_format As String
        Public dt_Font As String
        Public dt_x As Integer
        Public dt_y As Integer
        Public dt_FA As Integer
        Public dt_FR As Integer
        Public dt_FG As Integer
        Public dt_FB As Integer
        Public dt_BA As Integer
        Public dt_BR As Integer
        Public dt_BG As Integer
        Public dt_BB As Integer
        Public dt_visible As Boolean
        Public dt_transparent As Boolean

    End Structure
    Public Function Get_DateTime_Config()
        Dim x As New DateTime_Config
        x.dt_format = INI.GetString("DATETIME", "FORMAT", "yyyy-MM-dd hh:mm:ss tt")
        x.dt_x = INI.GetInteger("DATETIME", "X", 0)
        x.dt_y = INI.GetInteger("DATETIME", "Y", 0)
        x.dt_FA = INI.GetInteger("DATETIME", "FA", 255)
        x.dt_FR = INI.GetInteger("DATETIME", "FR", 255)
        x.dt_FG = INI.GetInteger("DATETIME", "FG", 255)
        x.dt_FB = INI.GetInteger("DATETIME", "FB", 255)
        x.dt_Font = INI.GetString("DATETIME", "FONT", "[Font: Name=Berlin Sans FB, Size=24, Units=3, GdiCharSet=0, GdiVerticalFont=False]")
        x.dt_BA = INI.GetInteger("DATETIME", "BA", 255)
        x.dt_BR = INI.GetInteger("DATETIME", "BR", 255)
        x.dt_BG = INI.GetInteger("DATETIME", "BG", 255)
        x.dt_BB = INI.GetInteger("DATETIME", "BB", 255)
        x.dt_visible = INI.GetBoolean("DATETIME", "V", True)
        x.dt_transparent = INI.GetBoolean("DATETIME", "TR", True)
        Return x
    End Function

#End Region

#Region "Banner Config"
    Public Structure Banner_Config

        Public banner_height As Integer
        Public banner_image As String
        Public banner_BA As Integer
        Public banner_BR As Integer
        Public banner_BG As Integer
        Public banner_BB As Integer
        Public banner_useimage As Boolean
    End Structure
    Public Function Get_Banner_Config() As Banner_Config
        Dim x As New Banner_Config
        x.banner_height = INI.GetInteger("BANNER", "H", 100)
        x.banner_image = INI.GetString("BANNER", "I", Application.StartupPath & "\Banner\Banner.jpg")
        x.banner_BA = INI.GetInteger("BANNER", "BA", 255)
        x.banner_BR = INI.GetInteger("BANNER", "BR", 255)
        x.banner_BG = INI.GetInteger("BANNER", "BG", 255)
        x.banner_BB = INI.GetInteger("BANNER", "BB", 255)
        x.banner_useimage = INI.GetBoolean("BANNER", "U", False)
        Return x

    End Function
#End Region

#Region "ID Config"
    Public idfolder As String

    Public Structure ID_Config
        Public id_width As Integer
        Public id_height As Integer
        Public id_photo As Integer
        Public id_pad As Integer
        Public id_folder As String
        Public show_cardcode As Boolean
    End Structure

    Public Function Get_ID_Config() As ID_Config
        Dim x As New ID_Config
        x.id_width = INI.GetInteger("ID", "W", 250)
        x.id_height = INI.GetInteger("ID", "H", 250)
        x.id_photo = INI.GetInteger("ID", "P", 250)
        x.id_pad = INI.GetInteger("ID", "M", 100)
        x.id_folder = INI.GetString("ID", "F", Application.StartupPath & "\PICS")
        x.show_cardcode = INI.GetBoolean("ID", "CC", True)
        Return x
    End Function
#End Region

#Region "Lane Config"
    Public Structure Lane_Config
        Public lane_FA As Integer
        Public lane_FR As Integer
        Public lane_FG As Integer
        Public lane_FB As Integer
        Public lane_BA As Integer
        Public lane_BR As Integer
        Public lane_BG As Integer
        Public lane_BB As Integer
        Public lane_font As String
        Public lane_H As Integer

    End Structure
    Public Function Get_Lane_Config()
        Dim x As New Lane_Config
        x.lane_FA = INI.GetInteger("LANE", "FA", 255)
        x.lane_FR = INI.GetInteger("LANE", "FR", 255)
        x.lane_FG = INI.GetInteger("LANE", "FG", 255)
        x.lane_FB = INI.GetInteger("LANE", "FB", 255)
        x.lane_BA = INI.GetInteger("LANE", "BA", 255)
        x.lane_BR = INI.GetInteger("LANE", "BR", 255)
        x.lane_BG = INI.GetInteger("LANE", "BG", 255)
        x.lane_BB = INI.GetInteger("LANE", "BB", 255)
        x.lane_font = INI.GetString("LANE", "FONT", "[Font: Name=Berlin Sans FB, Size=24, Units=3, GdiCharSet=0, GdiVerticalFont=False]")
        x.lane_H = INI.GetInteger("LANE", "H", 150)
        Return x

    End Function
#End Region
#Region "Name Config"
    Public Structure Name_Config
        Public name_FA As Integer
        Public name_FR As Integer
        Public name_FG As Integer
        Public name_FB As Integer
        Public name_BA As Integer
        Public name_BR As Integer
        Public name_BG As Integer
        Public name_BB As Integer
        Public name_font As String
        Public name_H As Integer

    End Structure
    Public Function Get_Name_Config()
        Dim x As New Name_Config
        x.name_FA = INI.GetInteger("NAME", "FA", 255)
        x.name_FR = INI.GetInteger("NAME", "FR", 255)
        x.name_FG = INI.GetInteger("NAME", "FG", 255)
        x.name_FB = INI.GetInteger("NAME", "FB", 255)
        x.name_BA = INI.GetInteger("NAME", "BA", 255)
        x.name_BR = INI.GetInteger("NAME", "BR", 255)
        x.name_BG = INI.GetInteger("NAME", "BG", 255)
        x.name_BB = INI.GetInteger("NAME", "BB", 255)
        x.name_font = INI.GetString("NAME", "FONT", "[Font: Name=Berlin Sans FB, Size=24, Units=3, GdiCharSet=0, GdiVerticalFont=False]")
        x.name_H = INI.GetInteger("NAME", "H", 150)
        Return x

    End Function
#End Region

#Region "AccessLabel Config"
    Public Structure AccessLabel_Config
        Public acc_FA As Integer
        Public acc_FR As Integer
        Public acc_FG As Integer
        Public acc_FB As Integer
        Public acc_font As String
        Public acc_H As Integer
    End Structure
    Public Function Get_AccessLabel_Config()
        Dim x As New AccessLabel_Config
        x.acc_FA = INI.GetInteger("ACC", "FA", 255)
        x.acc_FR = INI.GetInteger("ACC", "FR", 255)
        x.acc_FG = INI.GetInteger("ACC", "FG", 255)
        x.acc_FB = INI.GetInteger("ACC", "FB", 255)
        x.acc_font = INI.GetString("ACC", "FONT", "[Font: Name=Berlin Sans FB, Size=24, Units=3, GdiCharSet=0, GdiVerticalFont=False]")
        x.acc_H = INI.GetInteger("ACC", "H", 150)
        Return x

    End Function
#End Region

End Module

