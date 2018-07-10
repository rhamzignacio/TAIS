Module ModDeclaration

    Public strCommand As String     ' Public global initialization
    Public strCmdVessel As String
    Public strInputText As String   ' Variable for Line no inpu

    Public listclient As String = ""    '====== Get the value of Combo box

    Public strClientNumber As String
    Public strClientGlobalCustNo As String

    Public input As Integer

    Public strErrorCheck As String
    Public strVesseCheck As String
    Public strErrorCheckNew As String
    Public strErrorSim As String

    Public strSplit() As String
    Public strStatus() As String
    Public strVess() As String
    Public strStatusNew() As String
    Public strStatusSim() As String

    Public ctrCheck As String
    Public ctrPaxNo() As String
    Public ctrStat() As String

    Public CltDivCode As String

    Public tryN As String
    Public ilen As Integer
    Public temp As String

    Public ctrErrorChecking As Integer   '====== Counter Check for Error Checking
    Public TOEGCheck As Integer

    Public ClientNo As String
    Public BAgent As String
    Public VName As String
    Public ReceiveFrm As String
    Public TicketTL As String
    Public DivNumber As String
    Public eticket As String
    Public NetTicket As String
    Public TripType As String
    Public custSpecLowFare As String
    Public custSpecHighFare As String

    '===Profile
    Public FirstName As String
    Public ComName As String
    Public ContactNo As String
    Public QueueNo As String
    Public TeamGroup As String
    Public APEle As String
    Public Level As String
    Public DivGroup As String
    Public DivNumberPer As String
    Public BA As String
    Public strAccess As Integer


    '=====List of CODs=====
    Public COD1 As Integer
    Public COD2 As Integer
    Public COD3 As Integer
    Public COD4 As Integer
    Public COD5 As Integer
    Public COD6 As Integer
    Public COD7 As Integer
    Public COD8 As Integer
    Public COD9 As Integer
    Public COD10 As Integer
    Public COD11 As Integer
    Public COD12 As Integer
    Public COD13 As Integer
    Public COD14 As Integer
    Public COD15 As Integer
    Public COD16 As Integer
    Public COD17 As Integer
    Public COD18 As Integer
    Public COD19 As Integer
    Public COD20 As Integer

    Public COD21 As Integer
    Public COD22 As Integer
    Public COD23 As Integer
    Public COD24 As Integer
    Public COD25 As Integer
    Public COD26 As Integer
    Public COD27 As Integer
    Public COD28 As Integer
    Public COD29 As Integer
    Public COD30 As Integer
    Public COD31 As Integer
    Public COD32 As Integer
    Public COD33 As Integer
    Public COD34 As Integer
    Public COD35 As Integer
    Public COD36 As Integer
    Public COD37 As Integer
    Public COD38 As Integer
    Public COD39 As Integer
    Public COD40 As Integer

    Public COD41 As Integer
    Public COD42 As Integer
    Public COD43 As Integer
    Public COD44 As Integer
    Public COD45 As Integer
    Public COD46 As Integer
    Public COD47 As Integer
    Public COD48 As Integer
    Public COD49 As Integer
    Public COD50 As Integer


    Public strCOD1 As String
    Public strCOD2 As String
    Public strCOD3 As String
    Public strCOD4 As String
    Public strCOD5 As String
    Public strCOD6 As String
    Public strCOD7 As String
    Public strCOD8 As String
    Public strCOD9 As String
    Public strCOD10 As String
    Public strCOD11 As String
    Public strCOD12 As String
    Public strCOD13 As String
    Public strCOD14 As String
    Public strCOD15 As String
    Public strCOD16 As String
    Public strCOD17 As String
    Public strCOD18 As String
    Public strCOD19 As String
    Public strCOD20 As String

    Public strCOD21 As String
    Public strCOD22 As String
    Public strCOD23 As String
    Public strCOD24 As String
    Public strCOD25 As String
    Public strCOD26 As String
    Public strCOD27 As String
    Public strCOD28 As String
    Public strCOD29 As String
    Public strCOD30 As String

    Public strCOD31 As String
    Public strCOD32 As String
    Public strCOD33 As String
    Public strCOD34 As String
    Public strCOD35 As String
    Public strCOD36 As String
    Public strCOD37 As String
    Public strCOD38 As String
    Public strCOD39 As String
    Public strCOD40 As String

    Public strCOD41 As String
    Public strCOD42 As String
    Public strCOD43 As String
    Public strCOD44 As String
    Public strCOD45 As String
    Public strCOD46 As String
    Public strCOD47 As String
    Public strCOD48 As String
    Public strCOD49 As String
    Public strCOD50 As String


    '===== Assign Variable for Transaction Fee ==========

    Public PCode As String
    Public VCode As String
    Public C_Curr As String
    Public BCODE As String
    Public ctr As Integer = 0
    Public SendMsg As Integer
    Public SendMsgMIS As Integer


    '==== Declarations for Sending Entry to ASP =========

    Public TFPCode As String = Nothing
    Public TFVCode As String = Nothing
    Public TFCPercentage As String = Nothing
    Public TFCurr As String = Nothing
    Public TFCostAmt As String = Nothing
    Public TFSFAmt As String = Nothing
    Public DIn As String = Nothing
    Public Dout As String = Nothing
    Public DTvl As String = Nothing
    Public MSRf As String = Nothing
    Public MSLf As String = Nothing
    Public MSEc As String = Nothing

    Public Segment As New ArrayList
    Public SegmentFareCode As New ArrayList
    Public TicketSegment As New ArrayList
    Public NetFareSegment As New ArrayList
    Public COD As String = Nothing
    Public NonBSP As String

    Public CtrlListType As Integer
    Public CtrlFieldEquivalent As Integer


    '=====Public Initialization of Variables in BCD & NON-BCD Transactions

    Public B_SF As String       ' Selling Fare
    Public B_PF As String       ' Publish Fare
    Public BF_SF As String      ' Selling Fare
    Public BF_FTypes As String      ' Selling Fare
    Public ETCK As String       ' Ticket Number
    Public BF_NF As String       'Net Fare

    Public B_RF As String       ' Reference Fare
    Public B_LF As String       ' Lowest Fare
    Public B_EC As String       ' Exception Code
    Public Com_A As String
    Public Com_P As String

    Public Tkt As String        ' Int, dom or reg ticket
    Public Non_Tkt As String    ' Int, dom or reg ticket
    Public SupCode As String    ' Supplier Code
    Public AirCode As String    ' Airline Code
    Public TktCode As String    '  Ticketing Agent


    Public ConName As String    ' Convention Name
    Public ConPlace As String   ' Convention Name
    Public ConDate As String    ' Convention Date
    Public HotelName As String  ' Hotel Name

    Public BookName As String   ' Booker Name
    Public Autho As String      ' Authorizer Name
    Public EmpNo As String      ' Employee Number
    Public TBS As String        ' TBS number
    Public CCGL As String       ' Cost center GL number
    Public LinNo As String      ' Line Number
    Public TF As String         ' Transaction Fees
    Public proType As String    ' Product Type
    Public NoPax As String      ' No of Pax
    Public ccDetailsNew As String  ' Remarks CC Details
    Public FSegmentType As String
    Public TOEG As String

    Public MSRefFare As String  ' Misc Reference Fare
    Public MSLowFare As String  ' Misc Lowest Fare
    Public MSExpCode As String  ' Misc Exp Code

    Public PNRDate As String    ' Retain PNR Segment 
    Public PNRNoPax As String   ' No of Pax Retain in Date Segment
    Public PNRSegment As String ' No of Pax Retain in Date Segment
    Public FlagS As String      ' Flag Segment for On & Off Signer
    Public TA As String         ' Ticketing Agent
    Public sendpnrError As Integer
    Public sendMsgErrorPre As Integer
    Public GlobalCustNO As String
    Public GlobalClientNo As String

    Public CompFares As String
    Public CompAirCode As String

    Public B_DeptNo As String
    Public B_CostCenter As String
    Public B_EmpNo As String
    Public B_ProjNo As String
    Public B_OrderRef As String
    Public B_ReasonOfTrip As String
    Public B_AirNoReasonCode As String
    Public B_C_Data1 As String
    Public B_C_Data2 As String
    Public B_C_Data3 As String
    Public B_C_Data4 As String
    Public B_C_Data12 As String
    Public B_Approver As String
    Public B_ApprovalCode As String
    Public B_TravStatus As String
    Public B_MgrSup As String

    Public M_GC As String
    Public M_LCNo As String
    Public M_EmpNo As String
    Public M_TravName As String
    Public M_TravStat As String
    Public M_CCC As String
    Public M_ProjNo As String
    Public M_DeptNo As String
    Public M_OrderRed As String
    Public M_Approver As String
    Public M_ApproverCode As String
    Public M_MgrSup As String
    Public M_RTrip As String
    Public M_MClass As String
    Public M_SOT As String
    Public M_TourCode As String
    Public M_RCode As String
    Public M_RCodeDenied As String
    Public M_FFlyr As String
    Public M_HotelReasonCode As String
    Public M_HotelBookedF As String
    Public M_AirNoReasonCode As String
    Public M_CarBookedFlag As String
    Public M_SalesChannel As String
    Public M_RecordType As String
    Public M_CSData1 As String
    Public M_CSData2 As String
    Public M_CSData3 As String
    Public M_CSData4 As String
    Public M_CSData5 As String
    Public M_CSData6 As String
    Public M_CSData7 As String
    Public M_CSData8 As String
    Public M_CSData12 As String


    '=======Field Mapping =====
    Public strtravName As String
    Public strLowFare As String
    Public strCurrCode As String
    Public strReasonCode As String
    Public strtravStatus As String
    Public strCostCenter As String
    Public strProjectNo As String
    Public strDeptNo As String
    Public strOrderRef As String
    Public strApprover As String
    Public strApproverCode As String
    Public strMgrSup As String
    Public strReasonOfTrip As String
    Public strMajorClass As String
    Public strReasCode As String
    Public strReasCodeDen As String
    Public strFFLYNo As String
    Public strHotelReasonCode As String
    Public strHotelBookedFlag As String
    Public strAirNoAccom As String
    Public strStopOverFlag As String
    Public strTourCode As String
    Public strEmpNo As String
    Public strCarBookedFlag As String
    Public strSalesChannel As String
    Public strRecordType As String
    Public strCSData1 As String
    Public strCSData2 As String
    Public strCSData3 As String
    Public strCSData4 As String
    Public strCSData5 As String
    Public strCSData6 As String
    Public strCSData7 As String
    Public strCSData8 As String
    Public strCSData12 As String
    Public strFPCard As String
    Public strFpName As String

  

End Module
