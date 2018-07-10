Imports k1aHostToolKit
Imports s1aPNR


Module ModuleInit

    Public WithEvents objSession As HostSession
    Public objResponse As HostResponse
    Public objPnr As PNR
    Public Session As HostSession
    Public objSessions As HostSessions
    Public Host As Hosts
    Public objHosts As Host
    Public connectToHost As Boolean

    Public Connected As Boolean


    Public Function Connect() As Boolean

        Connected = True
        objSessions = New HostSessions

        If objSessions.Count <> 0 Then
            Session = objSessions.UIActiveSession
        Else
            Host = New Hosts
            objHosts = Host.Item(1)

            If Host.Count <> 0 Then

                Session = objHosts.ConnectSyncNewSession
                objSession = New k1aHostToolKit.HostSession
                objPnr = New s1aPNR.PNR


            Else
                MsgBox("Amadeus Selling Platform is not Started.", vbCritical, "Warning")
                objSessions = Nothing
                Host = Nothing
                Connected = False

            End If

        End If

        Connect = Connected
        Return Connect


    End Function


End Module
