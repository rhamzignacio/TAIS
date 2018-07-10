Public Class ClassPNR

    Dim strTemp As String = Nothing
    Dim strCode() As String
    Dim result As String

    '================================================
    '=======Pre Booking Entry
    '================================================


    Property sendFares() As String
        Get
            Return result
        End Get
        Set(ByVal CoD_lowFare As String)
            If Trim(CoD_lowFare) <> "" Or Trim(CoD_lowFare) <> Nothing Then
                Session.Send(Trim(CoD_lowFare))
            End If
        End Set
    End Property


    Property sendFaresAddtl() As String
        Get
            Return result
        End Get
        Set(ByVal CoD_lowFareAddtl As String)
            If Trim(CoD_lowFareAddtl) <> "" Or Trim(CoD_lowFareAddtl) <> Nothing Then
                Session.Send(Trim(CoD_lowFareAddtl))
            End If
        End Set
    End Property



    Property sendReasonCodeDen() As String
        Get
            Return result
        End Get
        Set(ByVal CoD_RCodeDenied As String)
            If Trim(CoD_RCodeDenied) <> "" Or Trim(CoD_RCodeDenied) <> Nothing Then
                Session.Send(CoD_RCodeDenied)
            End If
        End Set
    End Property


    Property sendCurrCode() As String
        Get
            Return result
        End Get
        Set(ByVal CoD_CurrCode As String)
            If Trim(CoD_CurrCode) <> "" Or Trim(CoD_CurrCode) <> Nothing Then
                Session.Send(Trim(CoD_CurrCode))
            End If
        End Set
    End Property



    Property SendPNR_CClientNo() As String

        Get
            Return result
        End Get

        Set(ByVal ClientNo As String)
            If Trim(ClientNo) <> "" Or Trim(ClientNo) <> Nothing Then
                Session.Send(Trim(ClientNo))
            End If
        End Set

    End Property


    Property SendPNR_CDivNumber() As String

        Get
            Return result
        End Get

        Set(ByVal DivNumber As String)
            If Trim(DivNumber) <> "" Or Trim(DivNumber) <> Nothing Then
                Session.Send(Trim(DivNumber))
            End If
        End Set

    End Property


    Property SendPNR_CBookingAgent() As String

        Get
            Return result
        End Get

        Set(ByVal BAgent As String)
            If Trim(BAgent) <> "" Or Trim(BAgent) <> Nothing Then
                Session.Send(Trim(BAgent))
            End If
        End Set

    End Property



    Property SendPNR_CVesselName() As String

        Get
            Return result
        End Get

        Set(ByVal Vname As String)
            If Trim(Vname) <> "" Or Trim(Vname) <> Nothing Then
                Session.Send(Trim(Vname))
            End If
        End Set

    End Property


    Property SendPNR_CReceivedFrom() As String

        Get
            Return result
        End Get

        Set(ByVal ReceiveFrm As String)
            If Trim(ReceiveFrm) <> "" Or Trim(ReceiveFrm) <> Nothing Then
                Session.Send("RF" & Trim(ReceiveFrm))
            End If
        End Set

    End Property


    Property SendPNR_CTicketTL() As String

        Get
            Return result
        End Get

        Set(ByVal TicketTL As String)
            If Trim(TicketTL) <> "" Or Trim(TicketTL) <> Nothing Then
                Session.Send(Trim(TicketTL))
            End If
        End Set

    End Property


    '==================End Pre Booking Entry =================
    '=========================================================


    ''====================================
    ''=== Setting calling Property of  ===
    ''===         BCD DeptNO           ===
    ''====================================

    'Property SendPNR_BCDDeptNo() As String

    '    Get
    '        Return result
    '    End Get

    '    Set(ByVal B_DeptNo As String)
    '        If Trim(B_DeptNo) <> "" Or Trim(B_DeptNo) <> Nothing Then
    '            Session.Send(Trim(B_DeptNo))
    '        End If
    '    End Set

    'End Property



    ''====================================
    ''=== Setting calling Property of  ===
    ''=====       BCD Cost Center      ===
    ''====================================

    'Property SendPNR_BCDCostCenter() As String

    '    Get
    '        Return result
    '    End Get

    '    Set(ByVal B_CostCenter As String)
    '        If Trim(B_CostCenter) <> "" Or Trim(B_CostCenter) <> Nothing Then
    '            Session.Send(Trim(B_CostCenter))
    '        End If
    '    End Set


    'End Property


    ''====================================
    ''=== Setting calling Property of  ===
    ''=====         BCD EmpNo          ===
    ''====================================

    'Property SendPNR_BCDEmpNo() As String

    '    Get
    '        Return result
    '    End Get

    '    Set(ByVal B_EmpNo As String)
    '        If Trim(B_EmpNo) <> "" Or Trim(B_EmpNo) <> Nothing Then
    '            Session.Send(Trim(B_EmpNo))
    '        End If
    '    End Set


    'End Property



    ''====================================
    ''=== Setting calling Property of  ===
    ''=====         Project NO         ===
    ''====================================

    'Property SendPNR_BCDProjNo() As String

    '    Get
    '        Return result
    '    End Get

    '    Set(ByVal B_ProjNo As String)
    '        If Trim(B_ProjNo) <> "" Or Trim(B_ProjNo) <> Nothing Then
    '            Session.Send(Trim(B_ProjNo))
    '        End If
    '    End Set

    'End Property




    ''====================================
    ''=== Setting calling Property of  ===
    ''=====   Order Reference          ===
    ''====================================

    'Property SendPNR_BCDOrderRef() As String

    '    Get
    '        Return result
    '    End Get

    '    Set(ByVal B_OrderRef As String)
    '        If Trim(B_OrderRef) <> "" Or Trim(B_OrderRef) <> Nothing Then
    '            Session.Send(Trim(B_OrderRef))
    '        End If
    '    End Set

    'End Property




    ''====================================
    ''=== Setting calling Property of  ===
    ''=====      ReasonofTrip          ===
    ''====================================

    'Property SendPNR_BCDReason_Trip() As String

    '    Get
    '        Return result
    '    End Get

    '    Set(ByVal B_ReasonOfTrip As String)
    '        If Trim(B_ReasonOfTrip) <> "" Or Trim(B_ReasonOfTrip) <> Nothing Then
    '            Session.Send(Trim(B_ReasonOfTrip))
    '        End If
    '    End Set


    'End Property




    ''==================================================
    ''=== Setting calling Property of                ===
    ''=====      Air No Accomodation Reason Code     ===
    ''==================================================

    'Property SendPNR_BCD_AirNoReasonCode() As String

    '    Get
    '        Return result
    '    End Get

    '    Set(ByVal B_AirNoReasonCode As String)
    '        If Trim(B_AirNoReasonCode) <> "" Or Trim(B_AirNoReasonCode) <> Nothing Then
    '            Session.Send(Trim(B_AirNoReasonCode))
    '        End If
    '    End Set


    'End Property



    ''==================================================
    ''===       Setting calling Property of          ===
    ''=====                Approver                  ===
    ''==================================================

    'Property SendPNR_BCD_Approver() As String

    '    Get
    '        Return result
    '    End Get

    '    Set(ByVal B_Approver As String)
    '        If Trim(B_Approver) <> "" Or Trim(B_Approver) <> Nothing Then
    '            Session.Send(Trim(B_Approver))
    '        End If
    '    End Set


    'End Property



    ''==================================================
    ''===       Setting calling Property of          ===
    ''=====                Approval Code             ===
    ''==================================================

    'Property SendPNR_BCD_ApprovalCode() As String

    '    Get
    '        Return result
    '    End Get

    '    Set(ByVal B_ApprovalCode As String)
    '        If Trim(B_ApprovalCode) <> "" Or Trim(B_ApprovalCode) <> Nothing Then
    '            Session.Send(Trim(B_ApprovalCode))
    '        End If
    '    End Set

    'End Property


    ''==================================================
    ''===       Setting calling Property of          ===
    ''=====              Trav Status                 ===
    ''==================================================

    'Property SendPNR_BCD_TravStatus() As String

    '    Get
    '        Return result
    '    End Get

    '    Set(ByVal B_TravStatus As String)
    '        If Trim(B_TravStatus) <> "" Or Trim(B_TravStatus) <> Nothing Then
    '            Session.Send(Trim(B_TravStatus))
    '        End If
    '    End Set


    'End Property



    ''==================================================
    ''===       Setting calling Property of          ===
    ''===               Trav Status                  ===
    ''==================================================

    'Property SendPNR_BCD_MgrSup() As String
    '    Get
    '        Return result
    '    End Get

    '    Set(ByVal B_MgrSup As String)
    '        If Trim(B_MgrSup) <> "" Or Trim(B_MgrSup) <> Nothing Then
    '            Session.Send(Trim(B_MgrSup))
    '        End If
    '    End Set
    'End Property




    ''==================================================
    ''===    Setting calling Property of             ===
    ''===         Client Data1                       ===
    ''==================================================

    'Property SendPNR_BCD_ClientData1() As String
    '    Get
    '        Return result
    '    End Get

    '    Set(ByVal B_C_Data1 As String)
    '        If Trim(B_C_Data1) <> "" Or Trim(B_C_Data1) <> Nothing Then
    '            Session.Send(Trim(B_C_Data1))
    '        End If
    '    End Set
    'End Property


    ''==================================================
    ''===    Setting calling Property of             ===
    ''===         Client Data2                       ===
    ''==================================================

    'Property SendPNR_BCD_ClientData2() As String
    '    Get
    '        Return result
    '    End Get

    '    Set(ByVal B_C_Data2 As String)
    '        If Trim(B_C_Data2) <> "" Or Trim(B_C_Data2) <> Nothing Then
    '            Session.Send(Trim(B_C_Data2))
    '        End If
    '    End Set
    'End Property



    ''==================================================
    ''===    Setting calling Property of             ===
    ''===         Client Data3                       ===
    ''==================================================

    'Property SendPNR_BCD_ClientData3() As String
    '    Get
    '        Return result
    '    End Get

    '    Set(ByVal B_C_Data3 As String)
    '        If Trim(B_C_Data3) <> "" Or Trim(B_C_Data3) <> Nothing Then
    '            Session.Send(Trim(B_C_Data3))
    '        End If
    '    End Set


    'End Property





    ''==================================================
    ''===    Setting calling Property of             ===
    ''===         Client Data4                       ===
    ''==================================================

    'Property SendPNR_BCD_ClientData4() As String

    '    Get
    '        Return result
    '    End Get

    '    Set(ByVal B_C_Data4 As String)
    '        If Trim(B_C_Data4) <> "" Or Trim(B_C_Data4) <> Nothing Then
    '            Session.Send(Trim(B_C_Data4))
    '        End If
    '    End Set


    'End Property




    ''==================================================
    ''===    Setting calling Property of             ===
    ''===         Client Data12                       ===
    ''==================================================

    'Property SendPNR_BCD_ClientData12() As String

    '    Get
    '        Return result
    '    End Get

    '    Set(ByVal B_C_Data12 As String)
    '        If Trim(B_C_Data12) <> "" Or Trim(B_C_Data12) <> Nothing Then
    '            Session.Send(Trim(B_C_Data12))
    '        End If
    '    End Set


    'End Property

    '====================================
    '=== Setting calling Property of  ===
    '=====       Publish Fare         ===
    '====================================

    Property SendPNR_PF() As String

        Get
            Return result
        End Get

        Set(ByVal B_PF As String)

            If Trim(B_PF) <> "" Or Trim(B_PF) <> Nothing Then

                Session.Send(Trim("RM*PF/" & B_PF))

            End If

        End Set


    End Property


    '====================================
    '=== Setting calling Property of  ===
    '=====       Selling Fare         ===
    '====================================

    Property SendPNR_SF() As String

        Get
            Return result
        End Get

        Set(ByVal B_SF As String)

            If Trim(B_SF) <> "" Or Trim(B_SF) <> Nothing Then

                Session.Send(Trim("RM*SF/" & B_SF))

            End If

        End Set


    End Property


    Property SendPNR_BSF() As String

        Get
            Return result
        End Get

        Set(ByVal BF_SF As String)


            If Trim(BF_SF) <> "" Or Trim(BF_SF) <> Nothing Then

                Session.Send(Trim("RM*SF/" & BF_SF))
               
            End If

        End Set

    End Property

    Property SendPNR_BNF() As String
        Get
            Return result
        End Get

        Set(ByVal BF_NF As String)


            If Trim(BF_NF) <> "" Or Trim(BF_NF) <> Nothing Then

                Session.Send(Trim("RM*NF/" & BF_NF))

            End If

        End Set
    End Property


    Property SendPNR_Ftypes() As String

        Get
            Return result
        End Get

        Set(ByVal BF_FTypes As String)


            If Trim(BF_FTypes) <> "" Or Trim(BF_FTypes) <> Nothing Then

                Session.Send(Trim("RM*" & BF_FTypes))

            End If

        End Set

    End Property




    Property SendPNR_ETCK() As String

        Get
            Return result
        End Get

        Set(ByVal ETCK As String)

            If Trim(ETCK) <> "" Or Trim(ETCK) <> Nothing Then
                Session.Send(Trim("RM*ETCK" & ETCK))
            End If

        End Set

    End Property


    Property SendPNR_NonBSP() As String

        Get
            Return result
        End Get

        Set(ByVal NonBSP As String)

            If Trim(NonBSP) <> "" Or Trim(NonBSP) <> Nothing Then
                Session.Send(Trim("RM*NA/" & NonBSP))
            End If

        End Set

    End Property



    '====================================
    '===          Pre Trip            ===
    '=====     Reference Fare         ===
    '====================================
    Property SendPNR_strAccomCode() As String

        Get
            Return result
        End Get

        Set(ByVal strAccomRCode As String)

            If Trim(strAccomRCode) <> "" Or Trim(strAccomRCode) <> Nothing Then
                Session.Send(Trim(strAccomRCode))
            End If

        End Set

    End Property


    Property SendPNR_ApprovalCode() As String

        Get
            Return result
        End Get

        Set(ByVal strApprvlCode As String)

            If Trim(strApprvlCode) <> "" Or Trim(strApprvlCode) <> Nothing Then
                Session.Send(Trim(strApprvlCode))
            End If

        End Set

    End Property



    Property SendPNR_Approver() As String

        Get
            Return result
        End Get

        Set(ByVal strApprv As String)

            If Trim(strApprv) <> "" Or Trim(strApprv) <> Nothing Then
                Session.Send(Trim(strApprv))
            End If

        End Set

    End Property


    Property SendPNR_CODData1() As String

        Get
            Return result
        End Get

        Set(ByVal CoD_CSData1 As String)

            If Trim(CoD_CSData1) <> "" Or Trim(CoD_CSData1) <> Nothing Then
                Session.Send(Trim(CoD_CSData1))
            End If

        End Set

    End Property


    Property SendPNR_CODData2() As String

        Get
            Return result
        End Get

        Set(ByVal CoD_CSData2 As String)

            If Trim(CoD_CSData2) <> "" Or Trim(CoD_CSData2) <> Nothing Then
                Session.Send(Trim(CoD_CSData2))
            End If

        End Set

    End Property

    Property SendPNR_CODData3() As String

        Get
            Return result
        End Get

        Set(ByVal CoD_CSData3 As String)

            If Trim(CoD_CSData3) <> "" Or Trim(CoD_CSData3) <> Nothing Then
                Session.Send(Trim(CoD_CSData3))
            End If

        End Set

    End Property


    Property SendPNR_CODData4() As String

        Get
            Return result
        End Get

        Set(ByVal CoD_CSData4 As String)

            If Trim(CoD_CSData4) <> "" Or Trim(CoD_CSData4) <> Nothing Then
                Session.Send(Trim(CoD_CSData4))
            End If

        End Set

    End Property


    Property SendPNR_CODData5() As String

        Get
            Return result
        End Get

        Set(ByVal CoD_CSData5 As String)

            If Trim(CoD_CSData5) <> "" Or Trim(CoD_CSData5) <> Nothing Then
                Session.Send(Trim(CoD_CSData5))
            End If

        End Set

    End Property

    Property SendPNR_CODData6() As String

        Get
            Return result
        End Get

        Set(ByVal CoD_CSData6 As String)

            If Trim(CoD_CSData6) <> "" Or Trim(CoD_CSData6) <> Nothing Then
                Session.Send(Trim(CoD_CSData6))
            End If

        End Set

    End Property


    Property SendPNR_CODData7() As String

        Get
            Return result
        End Get

        Set(ByVal CoD_CSData7 As String)

            If Trim(CoD_CSData7) <> "" Or Trim(CoD_CSData7) <> Nothing Then
                Session.Send(Trim(CoD_CSData7))
            End If

        End Set

    End Property

    Property SendPNR_CODData8() As String

        Get
            Return result
        End Get

        Set(ByVal CoD_CSData8 As String)

            If Trim(CoD_CSData8) <> "" Or Trim(CoD_CSData8) <> Nothing Then
                Session.Send(Trim(CoD_CSData8))
            End If

        End Set

    End Property

    Property SendPNR_CODData12() As String

        Get
            Return result
        End Get

        Set(ByVal CoD_CSData12 As String)

            If Trim(CoD_CSData12) <> "" Or Trim(CoD_CSData12) <> Nothing Then
                Session.Send(Trim(CoD_CSData12))
            End If

        End Set

    End Property



    Property SendPNR_CODCCGL() As String

        Get
            Return result
        End Get

        Set(ByVal CoD_CCGL As String)

            If Trim(CoD_CCGL) <> "" Or Trim(CoD_CCGL) <> Nothing Then
                Session.Send(Trim(CoD_CCGL))
            End If

        End Set

    End Property


    Property SendPNR_DeptNo() As String

        Get
            Return result
        End Get

        Set(ByVal CoD_DepNo As String)

            If Trim(CoD_DepNo) <> "" Or Trim(CoD_DepNo) <> Nothing Then
                Session.Send(Trim(CoD_DepNo))
            End If

        End Set

    End Property




    Property SendPNR_EmptNo() As String

        Get
            Return result
        End Get

        Set(ByVal CoD_EmpNo As String)

            If Trim(CoD_EmpNo) <> "" Or Trim(CoD_EmpNo) <> Nothing Then
                Session.Send(Trim(CoD_EmpNo))
            End If

        End Set

    End Property






    Property SendPNR_MgrSup() As String

        Get
            Return result
        End Get

        Set(ByVal CoD_MgrSup As String)

            If Trim(CoD_MgrSup) <> "" Or Trim(CoD_MgrSup) <> Nothing Then
                Session.Send(Trim(CoD_MgrSup))
            End If

        End Set

    End Property




    Property SendPNR_Ordr() As String

        Get
            Return result
        End Get

        Set(ByVal CoD_OrderRef As String)

            If Trim(CoD_OrderRef) <> "" Or Trim(CoD_OrderRef) <> Nothing Then
                Session.Send(Trim(CoD_OrderRef))
            End If

        End Set

    End Property




    Property SendPNR_ProjNo() As String

        Get
            Return result
        End Get

        Set(ByVal CoD_ProjNumber As String)

            If Trim(CoD_ProjNumber) <> "" Or Trim(CoD_ProjNumber) <> Nothing Then
                Session.Send(Trim(CoD_ProjNumber))
            End If

        End Set

    End Property


    Property SendPNR_ReasonTrip() As String

        Get
            Return result
        End Get

        Set(ByVal CoD_RTrip As String)

            If Trim(CoD_RTrip) <> "" Or Trim(CoD_RTrip) <> Nothing Then
                Session.Send(Trim(CoD_RTrip))
            End If

        End Set

    End Property





    '====================================
    '=== Setting calling Property of  ===
    '=====     Reference Fare         ===
    '====================================

    Property SendPNR_RF() As String
        Get
            Return result
        End Get

        Set(ByVal B_RF As String)

            If Trim(B_RF) <> "" Or Trim(B_RF) <> Nothing Then
                Session.Send(Trim("RM*RF/" & B_RF))
            End If

        End Set


    End Property


    '====================================
    '=== Setting calling Property of  ===
    '=====       Lowest Fare          ===
    '====================================

    Property SendPNR_LF() As String

        Get
            Return result
        End Get

        Set(ByVal B_LF As String)

            If Trim(B_LF) <> "" Or Trim(B_LF) <> Nothing Then
                Session.Send(Trim("RM*LF/" & B_LF))
            End If
        End Set

    End Property


    '====================================
    '=== Setting calling Property of  ===
    '=====     Exception Code         ===
    '====================================

    Property sendPNR_EC() As String
        Get
            Return result
        End Get
        Set(ByVal B_EC As String)

            Session.Send(Trim("RM*EC/" & B_EC))

        End Set
    End Property


    '====================================
    '=== Setting calling Property of  ===
    '=====     Commission Amount      ===
    '====================================

    Property sendPNR_CA() As String
        Get
            Return result
        End Get
        Set(ByVal Com_A As String)

            Session.Send(Trim("RM*CM/" & Com_A))

        End Set
    End Property


    '====================================
    '=== Setting calling Property of  ===
    '=====     Commission Percentage  ===
    '====================================

    Property sendPNR_CP() As String
        Get
            Return result
        End Get
        Set(ByVal Com_P As String)

            Session.Send(Trim("RM*CP/" & Com_P))

        End Set
    End Property


    '====================================
    '=== Setting calling Property of  ===
    '=====      Booker Name           ===
    '====================================

    Property sendPNR_BName() As String

        Get
            Return result
        End Get

        Set(ByVal Bookname As String)
            Session.Send(Trim("RM*CD/" & Bookname))
        End Set

    End Property


    '====================================
    '=== Setting calling Property of  ===
    '=====     Authorizer Number      ===
    '====================================

    Property sendPNR_AuthoName() As String

        Get
            Return result
        End Get
        Set(ByVal Autho As String)
            Session.Send(Trim("RM*PO/" & Autho))
        End Set

    End Property


    '====================================
    '=== Setting calling Property of  ===
    '=====     Cost Center GL         ===
    '====================================

    Property sendPNR_CCGL() As String

        Get
            Return result
        End Get
        Set(ByVal CCGL As String)

            Session.Send(Trim("RM*GSA/" & CCGL))

        End Set

    End Property


    '====================================
    '=== Setting calling Property of  ===
    '=====       Flag Segment         ===
    '====================================

    Property sendPNR_Tkt() As String
        Get
            Return result
        End Get
        Set(ByVal tkt As String)
            Session.Send(Trim("RM*FF1/" & tkt))
        End Set

    End Property


    '====================================
    '=== Setting calling Property of  ===
    '=====       Travel Type          ===
    '====================================

    Property sendPNR_NonTkt() As String
        Get
            Return result
        End Get
        Set(ByVal FSegmentType As String)

            Session.Send(Trim("RM*FF2/" & FSegmentType))

        End Set
    End Property


    'FSegmentRes.sendPNR_SegmentTypeName = FSegmentType
  

    '====================================
    '=== Setting calling Property of  ===
    '=====        TBS Number          ===
    '====================================

    Property sendPNR_TBS() As String

        Get
            Return result
        End Get
        Set(ByVal TBS As String)
            Session.Send(Trim("RM*FF3/" & TBS))
        End Set


    End Property


    '====================================
    '=== Setting calling Property of  ===
    '=====      Employee ID           ===
    '====================================
    Property sendPNR_EMP() As String

        Get
            Return result
        End Get
        Set(ByVal EmpNo As String)
            Session.Send(Trim("RM*FF4/" & EmpNo))
        End Set

    End Property


    '====================================
    '=== Setting calling Property of  ===
    '=====   Product Type Name        ===
    '====================================

    Property sendPNR_ProTypeName() As String

        Get
            Return result
        End Get
        Set(ByVal protype As String)

            Session.Send(Trim("RM*FF5/" & protype))

        End Set
    End Property



    '====================================
    '=== Setting calling Property of  ===
    '=====       Flag Segment         ===
    '====================================

    Property sendPNR_FlagS() As String

        Get
            Return result
        End Get
        Set(ByVal FlagS As String)
            Session.Send(Trim("RM*FF6/" & Trim(FlagS)))
        End Set
    End Property


    '====================================
    '=== Setting calling Property of  ===
    '=====     Convention Name        ===
    '====================================
    Property sendPNR_CName() As String

        Get
            Return result
        End Get
        Set(ByVal ConName As String)
            Session.Send(Trim("RM*FF7/" & ConName))
        End Set
    End Property


    '====================================
    '=== Setting calling Property of  ===
    '=====       Hotel Name           ===
    '====================================
    Property sendPNR_hName() As String
        Get
            Return result
        End Get
        Set(ByVal HotelName As String)

            Session.Send(Trim("RM*FF18/" & HotelName))

        End Set
    End Property


    '====================================
    '=== Setting calling Property of  ===
    '=====     Convention Place       ===
    '====================================
    Property sendPNR_ConPlace() As String
        Get
            Return result
        End Get
        Set(ByVal ConPlace As String)

            Session.Send(Trim("RM*FF19/" & ConPlace))

        End Set
    End Property


    '====================================
    '=== Setting calling Property of  ===
    '=====     Convention Date       ===
    '====================================
    Property sendPNR_ConDate() As String
        Get
            Return result
        End Get
        Set(ByVal ConDate As String)

            Session.Send(Trim("RM*FF20/" & ConDate))

        End Set
    End Property




    '====================================
    '=== Setting calling Property of  ===
    '=====          Line No           ===
    '====================================
    Property sendPNR_lineNo() As String

        Get
            Return result
        End Get
        Set(ByVal linNo As String)

            Session.Send(Trim("RM*GRP/" & linNo))

        End Set

    End Property



    '====================================
    '=== Setting calling Property of  ===
    '=====    Credit Card Remarks     ===
    '====================================
    Property sendPNR_CDetails() As String

        Get
            Return result
        End Get
        Set(ByVal ccDetails As String)

            Session.Send(Trim("RM*FF22/" & ccDetailsNew))

        End Set

    End Property


    '=====================================
    '           Send TOEG entry          =
    '=====================================
    Property sendTOEG() As String

        Get
            Return result
        End Get
        Set(ByVal TOEG As String)
            Session.Send(Trim("RMY/TOEG-" & TOEG))
        End Set

    End Property










    '====================================
    '=== Setting calling Property of  ===
    '=====          Ticketing Agent   ===
    '====================================
    Property sendPNR_TA() As String

        Get
            Return result
        End Get
        Set(ByVal TA As String)

            Session.Send(Trim("RM*TA/" & TA))

        End Set


    End Property




    '====================================
    '=== Setting calling Property of  ===
    '=====    Retain PNR Segment      ===
    '====================================
    Property sendPNR_PNRDate() As String

        Get
            Return result
        End Get
        Set(ByVal PNRSegment As String)

            Session.Send(Trim(PNRSegment))

        End Set

    End Property


    '====================================
    '=== Setting calling Property of  ===
    '=====     Transaction Fees       ===
    '====================================
    Property sendPNR_TFs() As String
        Get
            Return result
        End Get

        Set(ByVal TF As String)

            Session.Send(Trim("RM*MS/" & TF))
            'strTemp = objResponse.GetLineFromBuffer(2)
            'strCode = strTemp.Split(" ")

            'If Trim(UCase(strCode(0).ToString)) = "INACTIVITY" Or Trim(UCase(strCode(0).ToString)) = "SIGN" Or Trim(UCase(strCode(0).ToString)) = "SECURED" Or Trim(UCase(strCode(0).ToString)) = "INVALID" Or Trim(UCase(strCode(0).ToString)) = "IGNORED" Or Trim(UCase(strCode(0).ToString)) = "NO" Or Trim(UCase(strCode(0).ToString)) = "TRANSACTION" Or Trim(UCase(strCode(0).ToString)) = "ENTRY" Then
            '    objResponse = objSession.Send("IG")
            '    sendpnrError = 1
            'End If

        End Set

    End Property





    '====================================
    '=== Setting calling Property of  ===
    '=====         BCD MIS            ===
    '====================================

    Property SendPNR_MIS_GC() As String
        Get
            Return result
        End Get

        Set(ByVal M_GC As String)

            If Trim(M_GC) <> "" Or Trim(M_GC) <> Nothing Then
                Session.Send(Trim("RM*FF30/" & M_GC))
            End If
        End Set

    End Property



    Property SendPNR_MIS_LC() As String
        Get
            Return result
        End Get

        Set(ByVal M_LCNo As String)

            If Trim(M_LCNo) <> "" Or Trim(M_LCNo) <> Nothing Then
                Session.Send(Trim("RM*FF31/" & M_LCNo))
            End If
        End Set

    End Property


    Property SendPNR_MIS_EN() As String
        Get
            Return result
        End Get

        Set(ByVal M_EmpNo As String)

            If Trim(M_EmpNo) <> "" Or Trim(M_EmpNo) <> Nothing Then
                Session.Send(Trim("RM*FF32/" & M_EmpNo))
            End If
        End Set

    End Property


    Property SendPNR_MIS_TVS() As String
        Get
            Return result
        End Get

        Set(ByVal M_TravStat As String)

            If Trim(M_TravStat) <> "" Or Trim(M_TravStat) <> Nothing Then
                Session.Send(Trim("RM*FF33/" & M_TravStat))
            End If
        End Set

    End Property


    Property SendPNR_MIS_CCC() As String
        Get
            Return result
        End Get

        Set(ByVal M_CCC As String)

            If Trim(M_CCC) <> "" Or Trim(M_CCC) <> Nothing Then
                Session.Send(Trim("RM*FF34/" & M_CCC))
            End If
        End Set
    End Property


    Property SendPNR_MIS_ProjNo() As String
        Get
            Return result
        End Get

        Set(ByVal M_ProjNo As String)

            If Trim(M_ProjNo) <> "" Or Trim(M_ProjNo) <> Nothing Then
                Session.Send(Trim("RM*FF35/" & M_ProjNo))
            End If
        End Set
    End Property



    Property SendPNR_MIS_DeptNo() As String
        Get
            Return result
        End Get

        Set(ByVal M_DeptNo As String)

            If Trim(M_DeptNo) <> "" Or Trim(M_DeptNo) <> Nothing Then
                Session.Send(Trim("RM*FF36/" & M_DeptNo))
            End If

        End Set

    End Property



    Property SendPNR_MIS_OrderRef() As String
        Get
            Return result
        End Get

        Set(ByVal M_OrderRed As String)
            If Trim(M_OrderRed) <> "" Or Trim(M_OrderRed) <> Nothing Then
                Session.Send(Trim("RM*FF37/" & M_OrderRed))
            End If
        End Set

    End Property




    Property SendPNR_MIS_Approver() As String
        Get
            Return result
        End Get

        Set(ByVal M_Approver As String)

            If Trim(M_Approver) <> "" Or Trim(M_Approver) <> Nothing Then
                Session.Send(Trim("RM*FF38/" & M_Approver))
            End If

        End Set

    End Property


    Property SendPNR_MIS_ApproverCode() As String
        Get
            Return result
        End Get

        Set(ByVal M_ApproverCode As String)

            If Trim(M_ApproverCode) <> "" Or Trim(M_ApproverCode) <> Nothing Then
                Session.Send(Trim("RM*FF39/" & M_ApproverCode))
            End If

        End Set

    End Property


    Property SendPNR_MIS_MgrSup() As String
        Get
            Return result
        End Get

        Set(ByVal M_MgrSup As String)

            If Trim(M_MgrSup) <> "" Or Trim(M_MgrSup) <> Nothing Then
                Session.Send(Trim("RM*FF40/" & M_MgrSup))
            End If

        End Set

    End Property


    Property SendPNR_MIS_RTrip() As String
        Get
            Return result
        End Get

        Set(ByVal M_RTrip As String)

            If Trim(M_RTrip) <> "" Or Trim(M_RTrip) <> Nothing Then
                Session.Send(Trim("RM*FF41/" & M_RTrip))
            End If

        End Set

    End Property




    Property SendPNR_MIS_MClass() As String
        Get
            Return result
        End Get

        Set(ByVal M_MClass As String)
            If Trim(M_MClass) <> "" Or Trim(M_MClass) <> Nothing Then
                Session.Send(Trim("RM*FF42/" & M_MClass))
            End If
        End Set

    End Property



    Property SendPNR_MIS_SOT() As String
        Get
            Return result
        End Get

        Set(ByVal M_SOT As String)

            If Trim(M_SOT) <> "" Or Trim(M_SOT) <> Nothing Then
                Session.Send(Trim("RM*FF43/" & M_SOT))
            End If

        End Set

    End Property



    Property SendPNR_MIS_TCode() As String
        Get
            Return result
        End Get

        Set(ByVal M_TourCode As String)

            If Trim(M_TourCode) <> "" Or Trim(M_TourCode) <> Nothing Then
                Session.Send(Trim("RM*FF44/" & M_TourCode))
            End If
        End Set

    End Property




    Property SendPNR_MIS_RCode() As String
        Get
            Return result
        End Get

        Set(ByVal M_RCode As String)

            If Trim(M_RCode) <> "" Or Trim(M_RCode) <> Nothing Then
                Session.Send(Trim("RM*FF45/" & M_RCode))
            End If

        End Set

    End Property


    Property SendPNR_MIS_RCodeDen() As String
        Get
            Return result
        End Get

        Set(ByVal M_RCodeDenied As String)
            If Trim(M_RCodeDenied) <> "" Or Trim(M_RCodeDenied) <> Nothing Then
                Session.Send(Trim("RM*FF46/" & M_RCodeDenied))
            End If
        End Set

    End Property


    Property SendPNR_MIS_FFLyr() As String
        Get
            Return result
        End Get

        Set(ByVal M_FFlyr As String)

            If Trim(M_FFlyr) <> "" Or Trim(M_FFlyr) <> Nothing Then
                Session.Send(Trim("RM*FF47/" & M_FFlyr))
            End If

        End Set

    End Property


    Property SendPNR_MIS_HB() As String
        Get
            Return result
        End Get

        Set(ByVal M_HotelBookedF As String)

            If Trim(M_HotelBookedF) <> "" Or Trim(M_HotelBookedF) <> Nothing Then
                Session.Send(Trim("RM*FF48/" & M_HotelBookedF))
            End If

        End Set

    End Property


    Property SendPNR_MIS_ANRC() As String
        Get
            Return result
        End Get

        Set(ByVal M_AirNoReasonCode As String)

            If Trim(M_AirNoReasonCode) <> "" Or Trim(M_AirNoReasonCode) <> Nothing Then
                Session.Send(Trim("RM*FF49/" & M_AirNoReasonCode))
            End If

        End Set

    End Property


    Property SendPNR_MIS_HotelRC() As String
        Get
            Return result
        End Get

        Set(ByVal M_HotelReasonCode As String)

            If Trim(M_HotelReasonCode) <> "" Or Trim(M_HotelReasonCode) <> Nothing Then
                Session.Send(Trim("RM*FF50/" & M_HotelReasonCode))
            End If

        End Set

    End Property


    Property SendPNR_MIS_CBF() As String
        Get
            Return result
        End Get

        Set(ByVal M_CarBookedFlag As String)

            If Trim(M_CarBookedFlag) <> "" Or Trim(M_CarBookedFlag) <> Nothing Then
                Session.Send(Trim("RM*FF51/" & M_CarBookedFlag))
            End If

        End Set

    End Property


    Property SendPNR_MIS_SC() As String
        Get
            Return result
        End Get

        Set(ByVal M_SalesChannel As String)

            If Trim(M_SalesChannel) <> "" Or Trim(M_SalesChannel) <> Nothing Then
                Session.Send(Trim("RM*FF52/" & M_SalesChannel))
            End If

        End Set

    End Property

    Property SendPNR_MIS_RT() As String
        Get
            Return result
        End Get

        Set(ByVal M_RecordType As String)
            If Trim(M_RecordType) <> "" Or Trim(M_RecordType) <> Nothing Then
                Session.Send(Trim("RM*FF53/" & M_RecordType))
            End If
        End Set

    End Property

    Property SendPNR_MIS_CS1() As String
        Get
            Return result
        End Get

        Set(ByVal M_CSData1 As String)
            If Trim(M_CSData1) <> "" Or Trim(M_CSData1) <> Nothing Then
                Session.Send(Trim("RM*FF54/" & M_CSData1))
            End If
        End Set

    End Property


    Property SendPNR_MIS_CS2() As String
        Get
            Return result
        End Get

        Set(ByVal M_CSData2 As String)
            If Trim(M_CSData2) <> "" Or Trim(M_CSData2) <> Nothing Then
                Session.Send(Trim("RM*FF55/" & M_CSData2))
            End If
        End Set

    End Property


    Property SendPNR_MIS_CS3() As String
        Get
            Return result
        End Get

        Set(ByVal M_CSData3 As String)
            If Trim(M_CSData3) <> "" Or Trim(M_CSData3) <> Nothing Then
                Session.Send(Trim("RM*FF56/" & M_CSData3))
            End If
        End Set

    End Property



    Property SendPNR_MIS_CS4() As String
        Get
            Return result
        End Get

        Set(ByVal M_CSData4 As String)
            If Trim(M_CSData4) <> "" Or Trim(M_CSData4) <> Nothing Then
                Session.Send(Trim("RM*FF57/" & M_CSData4))
            End If
        End Set

    End Property



    Property SendPNR_MIS_CS5() As String
        Get
            Return result
        End Get

        Set(ByVal M_CSData5 As String)
            If Trim(M_CSData5) <> "" Or Trim(M_CSData5) <> Nothing Then
                Session.Send(Trim("RM*FF62/" & M_CSData5))
            End If
        End Set

    End Property

    Property SendPNR_MIS_CS6() As String
        Get
            Return result
        End Get

        Set(ByVal M_CSData6 As String)
            If Trim(M_CSData6) <> "" Or Trim(M_CSData6) <> Nothing Then
                Session.Send(Trim("RM*FF61/" & M_CSData6))
            End If
        End Set

    End Property

    Property SendPNR_MIS_CS7() As String
        Get
            Return result
        End Get

        Set(ByVal M_CSData7 As String)
            If Trim(M_CSData7) <> "" Or Trim(M_CSData7) <> Nothing Then
                Session.Send(Trim("RM*FF59/" & M_CSData7))
            End If
        End Set

    End Property


    Property SendPNR_MIS_CS8() As String
        Get
            Return result
        End Get

        Set(ByVal M_CSData8 As String)
            If Trim(M_CSData8) <> "" Or Trim(M_CSData8) <> Nothing Then
                Session.Send(Trim("RM*FF60/" & M_CSData8))
            End If
        End Set

    End Property





    Property SendPNR_MIS_CS12() As String

        Get
            Return result
        End Get

        Set(ByVal M_CSData12 As String)

            If Trim(M_CSData12) <> "" Or Trim(M_CSData12) <> Nothing Then
                Session.Send(Trim("RM*FF58/" & M_CSData12))
            End If
        End Set

    End Property


    '====================================
    '=== Setting calling Property of  ===
    '===== Trip Type     ===
    '====================================

    Property sendPNR_TripType() As String
        Get
            Return result
        End Get
        Set(ByVal TripType As String)
            Session.Send(Trim("RM*FF80/" & TripType))
        End Set
    End Property


    '====================================
    '=== Setting calling Property of  ===
    '===== Customer Spec Low Fare     ===
    '====================================

    Property sendPNR_NetTicket() As String
        Get
            Return result
        End Get
        Set(ByVal NetTicket As String)

            Session.Send(Trim("RM*FF85/" & NetTicket))

        End Set

    End Property

    '====================================
    '=== Setting calling Property of  ===
    '===== Customer Spec Low Fare     ===
    '====================================

    Property sendPNR_custSLowFare() As String
        Get
            Return result
        End Get
        Set(ByVal custSpecLowFare As String)

            Session.Send(Trim("RM*FF86/" & custSpecLowFare))

        End Set

    End Property


    '====================================
    '=== Setting calling Property of  ===
    '===== Customer Spec High Fare     ===
    '====================================

    Property sendPNR_custSHighFare() As String
        Get
            Return result
        End Get
        Set(ByVal custSpecHighFare As String)

            Session.Send(Trim("RM*FF87/" & custSpecHighFare))

        End Set

    End Property


    '====================================
    '=== Setting calling Property of  ===
    '=====       Travel Type          ===
    '====================================

    Property sendPNR_eticket() As String
        Get
            Return result
        End Get
        Set(ByVal eticket As String)

            Session.Send(Trim("RM*FF88/" & eticket))

        End Set
    End Property




End Class
