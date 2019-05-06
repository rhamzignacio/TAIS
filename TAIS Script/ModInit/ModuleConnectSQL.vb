Module ModuleConnectSQL

    Public path As String
    Public sSetting As String

    Public CNN As New ADODB.Connection          ' Declare CNN as New ADO Connection object to create an open connection to a data source
    Public RS As New ADODB.Recordset
    Public RS1 As New ADODB.Recordset
    Public RS2 As New ADODB.Recordset
    Public RS3 As New ADODB.Recordset

    Public RS4 As New ADODB.Recordset
    Public RS5 As New ADODB.Recordset
    Public RS6 As New ADODB.Recordset
    Public RS7 As New ADODB.Recordset
    Public RS8 As New ADODB.Recordset
    Public RS9 As New ADODB.Recordset
    Public RS10 As New ADODB.Recordset
    Public RS11 As New ADODB.Recordset
    Public RS12 As New ADODB.Recordset
    Public RS13 As New ADODB.Recordset
    Public RS14 As New ADODB.Recordset
    Public RS15 As New ADODB.Recordset
    Public RS_TravEmail As New ADODB.Recordset




    Public RSAccom As New ADODB.Recordset
    Public RC_Accom As New ADODB.Recordset

    Public RSApprval As New ADODB.Recordset
    Public RC_Apprval As New ADODB.Recordset

    Public RSApprver As New ADODB.Recordset
    Public RC_Apprver As New ADODB.Recordset


    Public RC_ApprverCode As New ADODB.Recordset
    Public RC_ApprvalCode As New ADODB.Recordset


    Public RSCSData1 As New ADODB.Recordset
    Public RSC_SData1 As New ADODB.Recordset

    Public RSCSData2 As New ADODB.Recordset
    Public RSC_SData2 As New ADODB.Recordset

    Public RSCSData3 As New ADODB.Recordset
    Public RSC_SData3 As New ADODB.Recordset

    Public RSCSData4 As New ADODB.Recordset
    Public RSC_SData4 As New ADODB.Recordset

    Public RSCSData5 As New ADODB.Recordset
    Public RSC_SData5 As New ADODB.Recordset


    Public RSCSData6 As New ADODB.Recordset
    Public RSC_SData6 As New ADODB.Recordset



    Public RSCSData7 As New ADODB.Recordset
    Public RSC_SData7 As New ADODB.Recordset


    Public RSCSData8 As New ADODB.Recordset
    Public RSC_SData8 As New ADODB.Recordset


    Public RSCCGL As New ADODB.Recordset
    Public RSC_CCGL As New ADODB.Recordset

    Public RSDeptNo As New ADODB.Recordset
    Public RSC_DeptNo As New ADODB.Recordset

    Public RSEmpNo As New ADODB.Recordset
    Public RSC_RSEmpNo As New ADODB.Recordset

    Public RSMgr As New ADODB.Recordset
    Public RSC_Mgr As New ADODB.Recordset

    Public RSOrdrRef As New ADODB.Recordset
    Public RSC_OrdrRef As New ADODB.Recordset

    Public RSProjNum As New ADODB.Recordset
    Public RSC_ProjNum As New ADODB.Recordset

    Public RSReasnTrip As New ADODB.Recordset
    Public RSC_ReasnTrip As New ADODB.Recordset

    Public RSTravStat As New ADODB.Recordset
    Public RSC_TravStat As New ADODB.Recordset

    Public RSMajorClass As New ADODB.Recordset
    Public RSCMajorClass As New ADODB.Recordset

    Public RSfares As New ADODB.Recordset
    Public RSfaresDenied As New ADODB.Recordset


    Public RS_AReasonCode As New ADODB.Recordset
    Public RS_AppovalCode As New ADODB.Recordset
    Public RS_Approver As New ADODB.Recordset
    Public RS_CarbookedFlag As New ADODB.Recordset
    Public RS_CSData1 As New ADODB.Recordset
    Public RS_CSData2 As New ADODB.Recordset
    Public RS_CSData3 As New ADODB.Recordset
    Public RS_CSData4 As New ADODB.Recordset
    Public RS_CSData5 As New ADODB.Recordset
    Public RS_CSData6 As New ADODB.Recordset
    Public RS_CSData7 As New ADODB.Recordset
    Public RS_CSData8 As New ADODB.Recordset
    Public RS_CSData12 As New ADODB.Recordset
    Public RS_CCGL As New ADODB.Recordset
    Public RS_DeptNo As New ADODB.Recordset
    Public RS_EmpNo As New ADODB.Recordset
    Public RS_FflyNo As New ADODB.Recordset
    Public RS_GlobalCustNo As New ADODB.Recordset
    Public RS_HBookedFlag As New ADODB.Recordset
    Public RS_HReasonCode As New ADODB.Recordset
    Public RS_LocalCustNo As New ADODB.Recordset
    Public RS_MClass As New ADODB.Recordset
    Public RS_MgrSup As New ADODB.Recordset
    Public RS_OrdrRef As New ADODB.Recordset
    Public RS_ProjNo As New ADODB.Recordset
    Public RS_ReasnCode As New ADODB.Recordset
    Public RS_ReasnCodeDen As New ADODB.Recordset
    Public RS_ReasnofTrip As New ADODB.Recordset
    Public RS_RcordType As New ADODB.Recordset
    Public RS_SalesChan As New ADODB.Recordset
    Public RS_StopOvrFlag As New ADODB.Recordset
    Public RS_TourCde As New ADODB.Recordset
    Public RS_TravName As New ADODB.Recordset
    Public RS_TravStat As New ADODB.Recordset
    Public RS_LowFare As New ADODB.Recordset
    Public RS_Rcode As New ADODB.Recordset
    Public RS_CurrCode As New ADODB.Recordset


    ' 5J Access
    Public RS_CAPI As New ADODB.Recordset



    Public SQL_QUERY As String
    Public INS_QUERY As String                  ' To insert record in a table
    Public UPD_QUERY As String                  ' To update record in a table
    Public DEL_QUERY As String                  ' To Delete record in a table


    Public ConnectToSQL As Boolean


    Public Class IniFile
        ' API functions
        Private Declare Ansi Function GetPrivateProfileString _
          Lib "kernel32.dll" Alias "GetPrivateProfileStringA" _
          (ByVal lpApplicationName As String, _
          ByVal lpKeyName As String, ByVal lpDefault As String, _
          ByVal lpReturnedString As System.Text.StringBuilder, _
          ByVal nSize As Integer, ByVal lpFileName As String) _
          As Integer
        Private Declare Ansi Function WritePrivateProfileString _
          Lib "kernel32.dll" Alias "WritePrivateProfileStringA" _
          (ByVal lpApplicationName As String, _
          ByVal lpKeyName As String, ByVal lpString As String, _
          ByVal lpFileName As String) As Integer
        Private Declare Ansi Function GetPrivateProfileInt _
          Lib "kernel32.dll" Alias "GetPrivateProfileIntA" _
          (ByVal lpApplicationName As String, _
          ByVal lpKeyName As String, ByVal nDefault As Integer, _
          ByVal lpFileName As String) As Integer
        Private Declare Ansi Function FlushPrivateProfileString _
          Lib "kernel32.dll" Alias "WritePrivateProfileStringA" _
          (ByVal lpApplicationName As Integer, _
          ByVal lpKeyName As Integer, ByVal lpString As Integer, _
          ByVal lpFileName As String) As Integer
        Dim strFilename As String

        ' Constructor, accepting a filename
        Public Sub New(ByVal Filename As String)
            strFilename = Filename
        End Sub

        ' Read-only filename property
        ReadOnly Property FileName() As String
            Get
                Return strFilename
            End Get
        End Property

        Public Function GetString(ByVal Section As String, ByVal Key As String, ByVal [Default] As String) As String
            ' Returns a string from your INI file
            Dim intCharCount As Integer
            Dim objResult As New System.Text.StringBuilder(1024)
            intCharCount = GetPrivateProfileString(Section, Key, _
               [Default], objResult, objResult.Capacity, strFilename)

            If intCharCount > 0 Then
                GetString = Left(objResult.ToString, intCharCount)
            Else
                Return Nothing
            End If

        End Function


        Public Function GetInteger(ByVal Section As String, _
          ByVal Key As String, ByVal [Default] As Integer) As Integer
            ' Returns an integer from your INI file
            Return GetPrivateProfileInt(Section, Key, _
               [Default], strFilename)
        End Function

        Public Function GetBoolean(ByVal Section As String, _
          ByVal Key As String, ByVal [Default] As Boolean) As Boolean
            ' Returns a boolean from your INI file
            Return (GetPrivateProfileInt(Section, Key, _
               CInt([Default]), strFilename) = 1)
        End Function

        Public Sub WriteString(ByVal Section As String, _
          ByVal Key As String, ByVal Value As String)
            ' Writes a string to your INI file
            WritePrivateProfileString(Section, Key, Value, strFilename)
            Flush()
        End Sub

        Public Sub WriteInteger(ByVal Section As String, _
          ByVal Key As String, ByVal Value As Integer)
            ' Writes an integer to your INI file
            WriteString(Section, Key, CStr(Value))
            Flush()
        End Sub

        Public Sub WriteBoolean(ByVal Section As String, _
          ByVal Key As String, ByVal Value As Boolean)
            ' Writes a boolean to your INI file
            WriteString(Section, Key, CStr(CInt(Value)))
            Flush()
        End Sub

        Private Sub Flush()
            ' Stores all the cached changes to your INI file
            FlushPrivateProfileString(0, 0, 0, strFilename)
        End Sub

    End Class

    Public Function App_Path() As String
        ' Return System.AppDomain.CurrentDomain.BaseDirectory() & "\" & "settings.ini"

        Return "Provider=SQLOLEDB.1;Persist Security Info=False;Initial Catalog=TAIS_SERVER;Trusted_Connection=True;User ID=aUserDB;Password=password123;Data Source=awsdbdata.chlhp7ltxo0j.ap-southeast-1.rds.amazonaws.com,1433"
        'Return "Provider=SQLOLEDB.1;Persist Security Info=False;Initial Catalog=TRAVCOM;Trusted_Connection=True;User ID=sa;Password=password123;Data Source=192.168.0.6,1433"
    End Function


    Public Function CONNECTDB() As Boolean

        'Dim AppPath As String
        'AppPath = System.AppDomain.CurrentDomain.BaseDirectory() & "Settings.ini"
        'Dim objIniFile As New IniFile(AppPath)

        ConnectToSQL = False

        CHECK_RS()
        'Reads a INI File (SETTINGS.INI) which has SECTION (SQLSERVER) and HEADING (SERVER) in It
        'sSetting = objIniFile.GetString("SQLSERVER", "ConnectionString", "\SETTINGS.INI")

        '========SQL Connection=========
        CNN.Open("Provider=SQLOLEDB.1;Persist Security Info=False;Initial Catalog=TAIS_SERVER;Trusted_Connection=True;User ID=aUserDB;Password=password123;Data Source=awsdbdata.chlhp7ltxo0j.ap-southeast-1.rds.amazonaws.com,1433")
        'CNN.Open("Provider=SQLOLEDB.1;Persist Security Info=False;Initial Catalog=TRAVCOM;Trusted_Connection=True;User ID=sa;Password=password123;Data Source=192.168.0.6,1433")

        CNN.Close()

        ConnectToSQL = True

        CONNECTDB = ConnectToSQL

        Return CONNECTDB

        Exit Function

    End Function


    Public Sub CHECK_RS()
        If RS.State = 1 Then RS.Close()
    End Sub

    Public Sub CHECK_RS1()
        If RS1.State = 1 Then RS1.Close()
    End Sub

    Public Sub CHECK_RS2()
        If RS2.State = 1 Then RS2.Close()
    End Sub

    Public Sub CHECK_RS3()
        If RS3.State = 1 Then RS3.Close()
    End Sub

    Public Sub CHECK_RS4()
        If RS4.State = 1 Then RS4.Close()
    End Sub

    Public Sub CHECK_RS5()
        If RS5.State = 1 Then RS5.Close()
    End Sub

    Public Sub CHECK_RS6()
        If RS6.State = 1 Then RS6.Close()
    End Sub

    Public Sub CHECK_RS7()
        If RS7.State = 1 Then RS7.Close()
    End Sub

    Public Sub CHECK_RS8()
        If RS8.State = 1 Then RS8.Close()
    End Sub

    Public Sub CHECK_RS9()
        If RS9.State = 1 Then RS9.Close()
    End Sub

    Public Sub CHECK_RS10()
        If RS10.State = 1 Then RS10.Close()
    End Sub

    Public Sub CHECK_RS11()
        If RS11.State = 1 Then RS11.Close()
    End Sub

    Public Sub CHECK_RS12()
        If RS12.State = 1 Then RS12.Close()
    End Sub

    Public Sub CHECK_RS13()
        If RS13.State = 1 Then RS13.Close()
    End Sub


    Public Sub CHECK_RS14()
        If RS14.State = 1 Then RS14.Close()
    End Sub


    Public Sub CHECK_RS15()
        If RS15.State = 1 Then RS15.Close()
    End Sub

    Public Sub Check_RS_TravEmail()
        If RS_TravEmail.State = 1 Then RS_TravEmail.Close()
    End Sub

    Public Sub CHECK_RSAccom()
        If RSAccom.State = 1 Then RSAccom.Close()
    End Sub

    Public Sub CHECK_RC_Accom()
        If RC_Accom.State = 1 Then RC_Accom.Close()
    End Sub


    Public Sub CHECK_RSApprval()
        If RSApprval.State = 1 Then RSApprval.Close()
    End Sub


    Public Sub CHECK_RC_Apprval()
        If RC_Apprval.State = 1 Then RC_Apprval.Close()
    End Sub


    Public Sub CHECK_RSApprver()
        If RSApprver.State = 1 Then RSApprver.Close()
    End Sub

    Public Sub CHECK_RC_Apprver()
        If RC_Apprver.State = 1 Then RC_Apprver.Close()
    End Sub


    Public Sub CHECK_RSCSData1()
        If RSCSData1.State = 1 Then RSCSData1.Close()
    End Sub


    Public Sub CHECK_RSC_SData1()
        If RSC_SData1.State = 1 Then RSC_SData1.Close()
    End Sub


    Public Sub CHECK_RSCSData2()
        If RSCSData2.State = 1 Then RSCSData2.Close()
    End Sub

    Public Sub CHECK_RSC_SData2()
        If RSC_SData2.State = 1 Then RSC_SData2.Close()
    End Sub


    Public Sub CHECK_RSCSData3()
        If RSCSData3.State = 1 Then RSCSData3.Close()
    End Sub


    Public Sub CHECK_RSC_SData3()
        If RSC_SData3.State = 1 Then RSC_SData3.Close()
    End Sub


    Public Sub CHECK_RSCSData4()
        If RSCSData4.State = 1 Then RSCSData4.Close()
    End Sub


    Public Sub CHECK_RSC_SData4()
        If RSC_SData4.State = 1 Then RSC_SData4.Close()
    End Sub


    Public Sub CHECK_RSCSData5()
        If RSCSData5.State = 1 Then RSCSData5.Close()
    End Sub


    Public Sub CHECK_RSC_SData5()
        If RSC_SData5.State = 1 Then RSC_SData5.Close()
    End Sub


    Public Sub CHECK_RSCSData6()
        If RSCSData6.State = 1 Then RSCSData6.Close()
    End Sub


    Public Sub CHECK_RSC_SData6()
        If RSC_SData6.State = 1 Then RSC_SData6.Close()
    End Sub


    Public Sub CHECK_RSCSData7()
        If RSCSData7.State = 1 Then RSCSData7.Close()
    End Sub


    Public Sub CHECK_RSC_SData7()
        If RSC_SData7.State = 1 Then RSC_SData7.Close()
    End Sub

    Public Sub CHECK_RSCSData8()
        If RSCSData8.State = 1 Then RSCSData8.Close()
    End Sub


    Public Sub CHECK_RSC_SData8()
        If RSC_SData8.State = 1 Then RSC_SData8.Close()
    End Sub


    Public Sub CHECK_RSCCGL()
        If RSCCGL.State = 1 Then RSCCGL.Close()
    End Sub


    Public Sub CHECK_RSC_CCGL()
        If RSC_CCGL.State = 1 Then RSC_CCGL.Close()
    End Sub


    Public Sub CHECK_RSDeptNo()
        If RSDeptNo.State = 1 Then RSDeptNo.Close()
    End Sub


    Public Sub CHECK_RSC_DeptNo()
        If RSC_DeptNo.State = 1 Then RSC_DeptNo.Close()
    End Sub



    Public Sub CHECK_RSEmpNo()
        If RSEmpNo.State = 1 Then RSEmpNo.Close()
    End Sub

    Public Sub CHECK_RSC_RSEmpNo()
        If RSC_RSEmpNo.State = 1 Then RSC_RSEmpNo.Close()
    End Sub

    Public Sub CHECK_RSMgr()
        If RSMgr.State = 1 Then RSMgr.Close()
    End Sub


    Public Sub CHECK_RSC_Mgr()
        If RSC_Mgr.State = 1 Then RSC_Mgr.Close()
    End Sub


    Public Sub CHECK_RSOrdrRef()
        If RSOrdrRef.State = 1 Then RSOrdrRef.Close()
    End Sub

    Public Sub CHECK_RSC_OrdrRef()
        If RSC_OrdrRef.State = 1 Then RSC_OrdrRef.Close()
    End Sub


    Public Sub CHECK_RSProjNum()
        If RSProjNum.State = 1 Then RSProjNum.Close()
    End Sub

    Public Sub CHECK_RSC_ProjNum()
        If RSC_ProjNum.State = 1 Then RSC_ProjNum.Close()
    End Sub

    Public Sub CHECK_RSReasnTrip()
        If RSReasnTrip.State = 1 Then RSReasnTrip.Close()
    End Sub

    Public Sub CHECK_RSC_ReasnTrip()
        If RSC_ReasnTrip.State = 1 Then RSC_ReasnTrip.Close()
    End Sub

    Public Sub CHECK_RSTravStat()
        If RSTravStat.State = 1 Then RSTravStat.Close()
    End Sub


    Public Sub CHECK_RSC_TravStat()
        If RSC_TravStat.State = 1 Then RSC_TravStat.Close()
    End Sub


    Public Sub CHECK_RC_ApprverCode()
        If RC_ApprverCode.State = 1 Then RC_ApprverCode.Close()
    End Sub

    Public Sub CHECK_RC_ApprvalCode()
        If RC_ApprvalCode.State = 1 Then RC_ApprvalCode.Close()
    End Sub


    Public Sub CHECK_RSMajorClass()
        If RSMajorClass.State = 1 Then RSMajorClass.Close()
    End Sub

    Public Sub CHECK_RSCMajorClass()
        If RSCMajorClass.State = 1 Then RSCMajorClass.Close()
    End Sub


    Public Sub CHECK_RSfares()
        If RSfares.State = 1 Then RSfares.Close()
    End Sub

    Public Sub CHECK_RSfaresDenied()
        If RSfaresDenied.State = 1 Then RSfaresDenied.Close()
    End Sub

    Public Sub Check_RS_AReasonCode()
        If RS_AReasonCode.State = 1 Then RS_AReasonCode.Close()
    End Sub

    Public Sub check_RS_AppovalCode()
        If RS_AppovalCode.State = 1 Then RS_AppovalCode.Close()
    End Sub

    Public Sub check_RS_Approver()
        If RS_Approver.State = 1 Then RS_Approver.Close()
    End Sub

    Public Sub check_RS_CarbookedFlag()
        If RS_CarbookedFlag.State = 1 Then RS_CarbookedFlag.Close()
    End Sub

    Public Sub check_RS_CSData1()
        If RS_CSData1.State = 1 Then RS_CSData1.Close()
    End Sub

    Public Sub check_RS_CSData2()
        If RS_CSData2.State = 1 Then RS_CSData2.Close()
    End Sub

    Public Sub check_RS_CSData3()
        If RS_CSData3.State = 1 Then RS_CSData3.Close()
    End Sub

    Public Sub check_RS_CSData4()
        If RS_CSData4.State = 1 Then RS_CSData4.Close()
    End Sub


    Public Sub check_RS_CSData5()
        If RS_CSData5.State = 1 Then RS_CSData5.Close()
    End Sub


    Public Sub check_RS_CSData6()
        If RS_CSData6.State = 1 Then RS_CSData6.Close()
    End Sub


    Public Sub check_RS_CSData7()
        If RS_CSData7.State = 1 Then RS_CSData7.Close()
    End Sub


    Public Sub check_RS_CSData8()
        If RS_CSData8.State = 1 Then RS_CSData8.Close()
    End Sub

    Public Sub check_RS_CSData12()
        If RS_CSData12.State = 1 Then RS_CSData12.Close()
    End Sub

    Public Sub check_RS_CCGL()
        If RS_CCGL.State = 1 Then RS_CCGL.Close()
    End Sub

    Public Sub check_RS_DeptNo()
        If RS_DeptNo.State = 1 Then RS_DeptNo.Close()
    End Sub

    Public Sub check_RS_EmpNo()
        If RS_EmpNo.State = 1 Then RS_EmpNo.Close()
    End Sub

    Public Sub check_RS_FflyNo()
        If RS_FflyNo.State = 1 Then RS_FflyNo.Close()
    End Sub

    Public Sub check_RS_GlobalCustNo()
        If RS_GlobalCustNo.State = 1 Then RS_GlobalCustNo.Close()
    End Sub

    Public Sub check_RS_HBookedFlag()
        If RS_HBookedFlag.State = 1 Then RS_HBookedFlag.Close()
    End Sub

    Public Sub check_RS_HReasonCode()
        If RS_HReasonCode.State = 1 Then RS_HReasonCode.Close()
    End Sub


    Public Sub check_RS_LocalCustNo()
        If RS_LocalCustNo.State = 1 Then RS_LocalCustNo.Close()
    End Sub

    Public Sub check_rs_mclass()
        If RS_MClass.State = 1 Then RS_MClass.Close()
    End Sub

    Public Sub check_rs_mgrsup()
        If RS_MgrSup.State = 1 Then RS_MgrSup.Close()
    End Sub

    Public Sub check_RS_ProjNo()
        If RS_ProjNo.State = 1 Then RS_ProjNo.Close()
    End Sub

    Public Sub check_RS_OrdrRef()
        If RS_OrdrRef.State = 1 Then RS_OrdrRef.Close()
    End Sub

    Public Sub check_RS_ReasnCode()
        If RS_ReasnCode.State = 1 Then RS_ReasnCode.Close()
    End Sub

    Public Sub check_RS_ReasnCodeDen()
        If RS_ReasnCodeDen.State = 1 Then RS_ReasnCodeDen.Close()
    End Sub

    Public Sub check_RS_ReasnofTrip()
        If RS_ReasnofTrip.State = 1 Then RS_ReasnofTrip.Close()
    End Sub

    Public Sub check_RS_RcordType()
        If RS_RcordType.State = 1 Then RS_RcordType.Close()
    End Sub

    Public Sub check_RS_SalesChan()
        If RS_SalesChan.State = 1 Then RS_SalesChan.Close()
    End Sub

    Public Sub check_RS_StopOvrFlag()
        If RS_StopOvrFlag.State = 1 Then RS_StopOvrFlag.Close()
    End Sub

    Public Sub check_RS_TourCde()
        If RS_TourCde.State = 1 Then RS_TourCde.Close()
    End Sub

    Public Sub check_RS_TravName()
        If RS_TravName.State = 1 Then RS_TravName.Close()
    End Sub

    Public Sub check_RS_TravStat()
        If RS_TravStat.State = 1 Then RS_TravStat.Close()
    End Sub

    Public Sub check_RS_LowFare()
        If RS_LowFare.State = 1 Then RS_LowFare.Close()
    End Sub

    Public Sub check_RS_Rcode()
        If RS_Rcode.State = 1 Then RS_Rcode.Close()
    End Sub

    Public Sub check_RS_CurrCode()
        If RS_CurrCode.State = 1 Then RS_CurrCode.Close()
    End Sub

    Public Sub check_RS_CAPI()
        If RS_CAPI.State = 1 Then RS_CAPI.Close()
    End Sub

End Module
