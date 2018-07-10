Public Class FrmMISSettings


    Dim ClientSpecCD As New AutoCompleteStringCollection

    Dim res As MsgBoxResult


    Public Sub FrmMISSettings_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call InitBCDSet()
        Call load_ClientListMIS()

    End Sub


    ' ====Get all the Client Spec from Travcom database
    Public Sub load_ClientListMIS()


        CHECK_RS1()

        SQL_QUERY = "Select * from BCDMIS..ClientSpecific where clientid<>0 "
        RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        With RS1

            Do While Not RS1.EOF
                ClientSpecCD.Add(RS1.Fields("ClientName").Value)
                RS1.MoveNext()
            Loop

        End With

        RS1.Close()

        cboC_Name.AutoCompleteSource = AutoCompleteSource.CustomSource
        cboC_Name.AutoCompleteCustomSource = ClientSpecCD
        cboC_Name.AutoCompleteMode = AutoCompleteMode.Suggest


    End Sub


    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        If Trim(cboGlobalCust.Text) <> "" Then
            Call New_EditClientInit()
        Else
            MsgBox("Nothing to edit..", vbCritical + vbOKOnly, "Settings")
        End If

    End Sub


    Private Sub MIDFields()

        DGW_COD.Rows.Clear()
        DGW_COD.Columns.Clear()

        Dim i As Integer = 0

        SQL_QUERY = " Select * from BCDMIS..MIDFields where ClientGCN = '" & Trim(cboGlobalCust.Text) & "'"
        RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        With RS1

            If Not RS1.EOF Then

                Call createGridViewHeader_COD()

                While Not RS1.EOF
                    DGW_COD.Rows.Add()
                    i = DGW_COD.Rows.Count - 1
                    DGW_COD.Rows.Item(i).Cells(0).Value = (RS1.Fields("GEMS").Value).ToString()
                    RS1.MoveNext()
                    i = i + 1

                End While
            End If
            RS1.Close()
        End With

    End Sub




    Private Sub createGridViewHeader_COD()

        DGW_COD.ColumnCount = 1
        DGW_COD.ColumnHeadersVisible = True

        ' Set the column header style.
        Dim columnHeaderStyle As New DataGridViewCellStyle()

        columnHeaderStyle.BackColor = Color.CadetBlue

        columnHeaderStyle.Font = New Font("Arial", 7, FontStyle.Regular)

        DGW_COD.ColumnHeadersDefaultCellStyle = columnHeaderStyle
        DGW_COD.RowTemplate.Height = 20
        DGW_COD.RowsDefaultCellStyle.Font = New Font("Arial", 7, FontStyle.Regular)

        ' Set the column header names.
        DGW_COD.Columns(0).Name = "GEMS"
        DGW_COD.Columns(0).Width = 150


    End Sub




    Public Sub InitBCDSet()

        txtSMDID.Text = Nothing
        txtSMDID.Enabled = False
        txtSMDID.BackColor = Color.LightGray

        txtTSPID.Text = Nothing
        txtTSPID.Enabled = False
        txtTSPID.BackColor = Color.LightGray

        cboGlobalCust.Text = Nothing
        cboGlobalCust.Enabled = False
        cboGlobalCust.BackColor = Color.LightGray

        cboLocalCust.Text = Nothing
        cboLocalCust.Enabled = False
        cboLocalCust.BackColor = Color.LightGray

        cboEmployeeNo.Text = Nothing
        cboEmployeeNo.Enabled = False
        cboEmployeeNo.BackColor = Color.LightGray

        cboTravellerName.Text = Nothing
        cboTravellerName.Enabled = False
        cboTravellerName.BackColor = Color.LightGray

        cboTravellerStatus.Text = Nothing
        cboTravellerStatus.Enabled = False
        cboTravellerStatus.BackColor = Color.LightGray

        cboCostCenter.Text = Nothing
        cboCostCenter.Enabled = False
        cboCostCenter.BackColor = Color.LightGray

        cboProjectNo.Text = Nothing
        cboProjectNo.Enabled = False
        cboProjectNo.BackColor = Color.LightGray

        cboDeptNo.Text = Nothing
        cboDeptNo.Enabled = False
        cboDeptNo.BackColor = Color.LightGray

        cboOrderRed.Text = Nothing
        cboOrderRed.Enabled = False
        cboOrderRed.BackColor = Color.LightGray

        cboApprover.Text = Nothing
        cboApprover.Enabled = False
        cboApprover.BackColor = Color.LightGray

        cboApproverCode.Text = Nothing
        cboApproverCode.Enabled = False
        cboApproverCode.BackColor = Color.LightGray

        cboMgrSup.Text = Nothing
        cboMgrSup.Enabled = False
        cboMgrSup.BackColor = Color.LightGray

        cboReasonTrip.Text = Nothing
        cboReasonTrip.Enabled = False
        cboReasonTrip.BackColor = Color.LightGray

        cboMajorClass.Text = Nothing
        cboMajorClass.Enabled = False
        cboMajorClass.BackColor = Color.LightGray

        cboStopOverFlag.Text = Nothing
        cboStopOverFlag.Enabled = False
        cboStopOverFlag.BackColor = Color.LightGray

        cboTourCode.Text = Nothing
        cboTourCode.Enabled = False
        cboTourCode.BackColor = Color.LightGray

        cboReasonCode.Text = Nothing
        cboReasonCode.Enabled = False
        cboReasonCode.BackColor = Color.LightGray

        cboReasonCodeDen.Text = Nothing
        cboReasonCodeDen.Enabled = False
        cboReasonCodeDen.BackColor = Color.LightGray

        cboFFLYRNo.Text = Nothing
        cboFFLYRNo.Enabled = False
        cboFFLYRNo.BackColor = Color.LightGray

        cboHotelReasonCode.Text = Nothing
        cboHotelReasonCode.Enabled = False
        cboHotelReasonCode.BackColor = Color.LightGray

        cboHotelBookedFlag.Text = Nothing
        cboHotelBookedFlag.Enabled = False
        cboHotelBookedFlag.BackColor = Color.LightGray

        cboAirNoAccom.Text = Nothing
        cboAirNoAccom.Enabled = False
        cboAirNoAccom.BackColor = Color.LightGray

        cboCarBookedFlag.Text = Nothing
        cboCarBookedFlag.Enabled = False
        cboCarBookedFlag.BackColor = Color.LightGray

        cboSalesChannel.Text = Nothing
        cboSalesChannel.Enabled = False
        cboSalesChannel.BackColor = Color.LightGray

        cboRecordType.Text = Nothing
        cboRecordType.Enabled = False
        cboRecordType.BackColor = Color.LightGray

        cboCSData1.Text = Nothing
        cboCSData1.Enabled = False
        cboCSData1.BackColor = Color.LightGray

        cboCSData2.Text = Nothing
        cboCSData2.Enabled = False
        cboCSData2.BackColor = Color.LightGray

        cboCSData3.Text = Nothing
        cboCSData3.Enabled = False
        cboCSData3.BackColor = Color.LightGray

        cboCSData4.Text = Nothing
        cboCSData4.Enabled = False
        cboCSData4.BackColor = Color.LightGray


        cboCSData5.Text = Nothing
        cboCSData5.Enabled = False
        cboCSData5.BackColor = Color.LightGray

        cboCSData6.Text = Nothing
        cboCSData6.Enabled = False
        cboCSData6.BackColor = Color.LightGray

        cboCSData7.Text = Nothing
        cboCSData7.Enabled = False
        cboCSData7.BackColor = Color.LightGray

        cboCSData8.Text = Nothing
        cboCSData8.Enabled = False
        cboCSData8.BackColor = Color.LightGray

        cboCSData12.Text = Nothing
        cboCSData12.Enabled = False
        cboCSData12.BackColor = Color.LightGray

        txtClientID.Text = Nothing
        txtClientID.Enabled = False
        txtClientID.BackColor = Color.LightGray

        txtClientName.Text = Nothing
        txtClientName.Enabled = False
        txtClientName.BackColor = Color.LightGray

        txtCusSpecLF.Text = Nothing
        txtCusSpecLF.Enabled = False
        txtCusSpecLF.BackColor = Color.LightGray

        txtCustSpecRFA.Text = Nothing
        txtCustSpecRFA.Enabled = False
        txtCustSpecRFA.BackColor = Color.LightGray

        txtLowFareAmount.Text = Nothing
        txtLowFareAmount.Enabled = False
        txtLowFareAmount.BackColor = Color.LightGray

        txtRefFareAmount.Text = Nothing
        txtRefFareAmount.Enabled = False
        txtRefFareAmount.BackColor = Color.LightGray


    End Sub



    Private Sub New_EditClientInit()

        txtSMDID.Enabled = True
        txtSMDID.BackColor = Color.White

        txtTSPID.Enabled = True
        txtTSPID.BackColor = Color.White

        cboGlobalCust.Enabled = True
        cboGlobalCust.BackColor = Color.White

        cboLocalCust.Enabled = True
        cboLocalCust.BackColor = Color.White

        cboEmployeeNo.Enabled = True
        cboEmployeeNo.BackColor = Color.White

        cboTravellerName.Enabled = True
        cboTravellerName.BackColor = Color.White

        cboTravellerStatus.Enabled = True
        cboTravellerStatus.BackColor = Color.White

        cboCostCenter.Enabled = True
        cboCostCenter.BackColor = Color.White

        cboProjectNo.Enabled = True
        cboProjectNo.BackColor = Color.White

        cboDeptNo.Enabled = True
        cboDeptNo.BackColor = Color.White

        cboOrderRed.Enabled = True
        cboOrderRed.BackColor = Color.White

        cboApprover.Enabled = True
        cboApprover.BackColor = Color.White

        cboApproverCode.Enabled = True
        cboApproverCode.BackColor = Color.White

        cboMgrSup.Enabled = True
        cboMgrSup.BackColor = Color.White

        cboReasonTrip.Enabled = True
        cboReasonTrip.BackColor = Color.White

        cboMajorClass.Enabled = True
        cboMajorClass.BackColor = Color.White

        cboStopOverFlag.Enabled = True
        cboStopOverFlag.BackColor = Color.White

        cboTourCode.Enabled = True
        cboTourCode.BackColor = Color.White

        cboReasonCode.Enabled = True
        cboReasonCode.BackColor = Color.White

        cboReasonCodeDen.Enabled = True
        cboReasonCodeDen.BackColor = Color.White

        cboFFLYRNo.Enabled = True
        cboFFLYRNo.BackColor = Color.White

        cboHotelReasonCode.Enabled = True
        cboHotelReasonCode.BackColor = Color.White

        cboHotelBookedFlag.Enabled = True
        cboHotelBookedFlag.BackColor = Color.White

        cboAirNoAccom.Enabled = True
        cboAirNoAccom.BackColor = Color.White

        cboCarBookedFlag.Enabled = True
        cboCarBookedFlag.BackColor = Color.White

        cboSalesChannel.Enabled = True
        cboSalesChannel.BackColor = Color.White

        cboRecordType.Enabled = True
        cboRecordType.BackColor = Color.White

        cboCSData1.Enabled = True
        cboCSData1.BackColor = Color.White

        cboCSData2.Enabled = True
        cboCSData2.BackColor = Color.White

        cboCSData3.Enabled = True
        cboCSData3.BackColor = Color.White

        cboCSData4.Enabled = True
        cboCSData4.BackColor = Color.White


        cboCSData5.Enabled = True
        cboCSData5.BackColor = Color.White

        cboCSData6.Enabled = True
        cboCSData6.BackColor = Color.White

        cboCSData7.Enabled = True
        cboCSData7.BackColor = Color.White

        cboCSData8.Enabled = True
        cboCSData8.BackColor = Color.White


        cboCSData12.Enabled = True
        cboCSData12.BackColor = Color.White

        txtClientName.Enabled = True
        txtClientName.BackColor = Color.White

        txtCusSpecLF.Enabled = True
        txtCusSpecLF.BackColor = Color.White

        txtCustSpecRFA.Enabled = True
        txtCustSpecRFA.BackColor = Color.White

        txtLowFareAmount.Enabled = True
        txtLowFareAmount.BackColor = Color.White

        txtRefFareAmount.Enabled = True
        txtRefFareAmount.BackColor = Color.White



    End Sub


    Private Sub novalue()

        cboGlobalCust.Text = Nothing
        cboLocalCust.Text = Nothing
        cboEmployeeNo.Text = Nothing
        cboTravellerName.Text = Nothing
        cboTravellerStatus.Text = Nothing
        cboCostCenter.Text = Nothing
        cboProjectNo.Text = Nothing
        cboDeptNo.Text = Nothing
        cboOrderRed.Text = Nothing
        cboApprover.Text = Nothing
        cboApproverCode.Text = Nothing
        cboMgrSup.Text = Nothing
        cboReasonTrip.Text = Nothing
        cboMajorClass.Text = Nothing
        cboStopOverFlag.Text = Nothing
        cboTourCode.Text = Nothing
        cboReasonCode.Text = Nothing
        cboReasonCodeDen.Text = Nothing
        cboFFLYRNo.Text = Nothing
        cboHotelReasonCode.Text = Nothing
        cboHotelBookedFlag.Text = Nothing
        cboAirNoAccom.Text = Nothing
        cboCarBookedFlag.Text = Nothing
        cboSalesChannel.Text = Nothing
        cboRecordType.Text = Nothing
        cboCSData1.Text = Nothing
        cboCSData2.Text = Nothing
        cboCSData3.Text = Nothing
        cboCSData4.Text = Nothing
        cboCSData5.Text = Nothing
        cboCSData6.Text = Nothing
        cboCSData7.Text = Nothing
        cboCSData8.Text = Nothing

        cboCSData12.Text = Nothing
        txtClientID.Text = Nothing
        txtClientName.Text = Nothing
        txtCusSpecLF.Text = Nothing
        txtCustSpecRFA.Text = Nothing
        txtLowFareAmount.Text = Nothing
        txtRefFareAmount.Text = Nothing
        txtSMDID.Text = Nothing
        txtTSPID.Text = Nothing



    End Sub


    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click

        Call InitBCDSet()
        cboC_Name.Text = Nothing
        cboC_Name.Enabled = True

        FrmGeneral.Show()
        FrmPasswordMIS.buttonFalse()

        Hide()

    End Sub


    Public Sub cboC_Name_keydown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboC_Name.KeyDown

        Call InitBCDSet()
        Call MIDFieldsInit()

        DGW_COD.Rows.Clear()
        DGW_COD.Columns.Clear()

        If e.KeyCode = 13 Then

            CHECK_RS()

            SQL_QUERY = "Select * from BCDMIS..ClientSpecific where clientname  = '" & cboC_Name.Text & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then


                    If Not IsDBNull(Trim((RS.Fields("GlobalCustNo").Value).ToString())) Then

                        cboGlobalCust.Enabled = True
                        cboGlobalCust.Text = (RS.Fields("GlobalCustNo").Value).ToString()
                        cboGlobalCust.BackColor = Color.White
                    Else
                        cboGlobalCust.Enabled = False
                        cboGlobalCust.Text = Nothing
                        cboGlobalCust.BackColor = Color.Silver
                    End If



                    If Not IsDBNull(Trim((RS.Fields("ClientID").Value).ToString())) Then
                        txtClientID.Text = (RS.Fields("ClientID").Value).ToString()
                    Else
                        txtClientID.Enabled = False
                        txtClientID.Text = Nothing
                    End If



                    '====SM ID
                    If Not IsDBNull(Trim((RS.Fields("SMDID").Value).ToString())) And (UCase(Trim((RS.Fields("SMDID").Value).ToString()))) <> "TRUE" Then
                        txtSMDID.Enabled = True
                        txtSMDID.Text = (RS.Fields("SMDID").Value).ToString()
                        txtSMDID.BackColor = Color.White
                    End If

                    If (Trim((RS.Fields("SMDID").Value).ToString())) = "TRUE" Then
                        txtSMDID.Enabled = True
                        txtSMDID.Text = (RS.Fields("SMDID").Value).ToString()
                        txtSMDID.BackColor = Color.White
                    End If

                    If IsDBNull(Trim((RS.Fields("SMDID").Value).ToString())) Or (Trim((RS.Fields("SMDID").Value).ToString())) = "" Or (Trim((RS.Fields("SMDID").Value).ToString())) Is Nothing Then
                        txtSMDID.Enabled = False
                        txtSMDID.Text = Nothing
                        txtSMDID.BackColor = Color.Silver

                    End If
                    '=====End


                    '====TSP ID
                    If Not IsDBNull(Trim((RS.Fields("TSPID").Value).ToString())) And (UCase(Trim((RS.Fields("TSPID").Value).ToString()))) <> "TRUE" Then
                        txtTSPID.Enabled = True
                        txtTSPID.Text = (RS.Fields("TSPID").Value).ToString()
                        txtTSPID.BackColor = Color.White
                    End If

                    If (Trim((RS.Fields("TSPID").Value).ToString())) = "TRUE" Then
                        txtTSPID.Enabled = True
                        txtTSPID.Text = (RS.Fields("TSPID").Value).ToString()
                        txtTSPID.BackColor = Color.White
                    End If

                    If IsDBNull(Trim((RS.Fields("TSPID").Value).ToString())) Or (Trim((RS.Fields("TSPID").Value).ToString())) = "" Or (Trim((RS.Fields("TSPID").Value).ToString())) Is Nothing Then
                        txtTSPID.Enabled = False
                        txtTSPID.Text = Nothing
                        txtTSPID.BackColor = Color.Silver

                    End If
                    '=====End



                    '====Local Customer Number
                    If Not IsDBNull(Trim((RS.Fields("ClientName").Value).ToString())) And (UCase(Trim((RS.Fields("ClientName").Value).ToString()))) <> "TRUE" Then
                        txtClientName.Enabled = True
                        txtClientName.Text = (RS.Fields("ClientName").Value).ToString()
                        txtClientName.BackColor = Color.White
                    End If

                    If (Trim((RS.Fields("ClientName").Value).ToString())) = "TRUE" Then
                        txtClientName.Enabled = True
                        txtClientName.Text = (RS.Fields("ClientName").Value).ToString()
                        txtClientName.BackColor = Color.White
                    End If

                    If IsDBNull(Trim((RS.Fields("ClientName").Value).ToString())) Or (Trim((RS.Fields("ClientName").Value).ToString())) = "" Or (Trim((RS.Fields("ClientName").Value).ToString())) Is Nothing Then
                        txtClientName.Enabled = False
                        txtClientName.Text = Nothing
                        txtClientName.BackColor = Color.Silver

                    End If
                    '=====End


                    '=====Low Fare

                    If (UCase(Trim((RS.Fields("lowFare").Value).ToString()))) = "TRUE" Then
                        txtLowFareAmount.Enabled = True
                        txtLowFareAmount.Text = (RS.Fields("LowFare").Value).ToString()
                        txtLowFareAmount.BackColor = Color.White
                    End If

                    If Not IsDBNull(Trim((RS.Fields("lowFare").Value).ToString())) And (UCase(Trim((RS.Fields("LowFare").Value).ToString()))) <> "TRUE" Then
                        txtLowFareAmount.Text = (RS.Fields("LowFare").Value).ToString()
                        txtLowFareAmount.Enabled = True
                        txtLowFareAmount.BackColor = Color.White
                    End If

                    If (UCase(Trim((RS.Fields("LowFare").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("LowFare").Value).ToString())) Or (Trim((RS.Fields("LowFare").Value).ToString())) Is Nothing Then
                        txtLowFareAmount.Enabled = False
                        txtLowFareAmount.Text = Nothing
                        txtLowFareAmount.BackColor = Color.Silver
                    End If


                    '=====Full Fare
                    If (UCase(Trim((RS.Fields("FullFare").Value).ToString()))) = "TRUE" Then
                        txtRefFareAmount.Enabled = True
                        txtRefFareAmount.Text = (RS.Fields("FullFare").Value).ToString()
                        txtRefFareAmount.BackColor = Color.White
                    End If

                    If Not IsDBNull(Trim((RS.Fields("FullFare").Value).ToString())) And (UCase(Trim((RS.Fields("FullFare").Value).ToString()))) <> "TRUE" Then
                        txtRefFareAmount.Text = (RS.Fields("FullFare").Value).ToString()
                        txtRefFareAmount.Enabled = True
                        txtRefFareAmount.BackColor = Color.White
                    End If

                    If (UCase(Trim((RS.Fields("FullFare").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("FullFare").Value).ToString())) Or (Trim((RS.Fields("FullFare").Value).ToString())) Is Nothing Then
                        txtRefFareAmount.Enabled = False
                        txtRefFareAmount.Text = Nothing
                        txtRefFareAmount.BackColor = Color.Silver
                    End If


                    '====Local Customer Number
                    If Not IsDBNull(Trim((RS.Fields("localCustNo").Value).ToString())) And (UCase(Trim((RS.Fields("localCustNo").Value).ToString()))) <> "TRUE" Then
                        cboLocalCust.Enabled = True
                        cboLocalCust.Text = (RS.Fields("localCustNo").Value).ToString()
                        cboLocalCust.BackColor = Color.White
                    End If

                    If (Trim((RS.Fields("localCustNo").Value).ToString())) = "TRUE" Then
                        cboLocalCust.Enabled = True
                        cboLocalCust.Text = (RS.Fields("localCustNo").Value).ToString()
                        cboLocalCust.BackColor = Color.White
                    End If

                    If IsDBNull(Trim((RS.Fields("localCustNo").Value).ToString())) Or (Trim((RS.Fields("localCustNo").Value).ToString())) = "" Or (Trim((RS.Fields("localCustNo").Value).ToString())) Is Nothing Then
                        cboLocalCust.Enabled = False
                        cboLocalCust.Text = Nothing
                        cboLocalCust.BackColor = Color.Silver
                    End If
                    '=====End


                    '===Employee Number

                    If (UCase(Trim((RS.Fields("EmployeeNo").Value).ToString()))) = "TRUE" Then
                        cboEmployeeNo.Text = (RS.Fields("EmployeeNo").Value).ToString()
                        cboEmployeeNo.Enabled = True
                        cboEmployeeNo.BackColor = Color.White
                    End If


                    If Not IsDBNull(Trim((RS.Fields("EmployeeNo").Value).ToString())) And (UCase(Trim((RS.Fields("EmployeeNo").Value).ToString()))) <> "TRUE" Then
                        cboEmployeeNo.Text = (RS.Fields("EmployeeNo").Value).ToString()
                        cboEmployeeNo.Enabled = True
                        cboEmployeeNo.BackColor = Color.White
                    End If


                    If (UCase(Trim((RS.Fields("EmployeeNo").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("EmployeeNo").Value).ToString())) Or (Trim((RS.Fields("EmployeeNo").Value).ToString())) Is Nothing Then
                        cboEmployeeNo.Enabled = False
                        cboEmployeeNo.Text = Nothing
                        cboEmployeeNo.BackColor = Color.Silver
                    End If

                    '===End


                    '=====Traveller Name

                    If (UCase(Trim((RS.Fields("TravellerName").Value).ToString()))) = "TRUE" Then
                        cboTravellerName.Enabled = True
                        cboTravellerName.Text = (RS.Fields("TravellerName").Value).ToString()
                        cboTravellerName.BackColor = Color.White
                    End If

                    If Not IsDBNull(Trim((RS.Fields("TravellerName").Value).ToString())) And (UCase(Trim((RS.Fields("TravellerName").Value).ToString()))) <> "TRUE" Then
                        cboTravellerName.Text = (RS.Fields("TravellerName").Value).ToString()
                        cboTravellerName.Enabled = True
                        cboTravellerName.BackColor = Color.White
                    End If

                    If (UCase(Trim((RS.Fields("TravellerName").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("TravellerName").Value).ToString())) Or (Trim((RS.Fields("TravellerName").Value).ToString())) Is Nothing Then
                        cboTravellerName.Enabled = False
                        cboTravellerName.Text = Nothing
                        cboTravellerName.BackColor = Color.Silver
                    End If

                    '===End


                    '===Traveller Status

                    If (UCase(Trim((RS.Fields("TravellerStatus").Value).ToString()))) = "TRUE" Then
                        cboTravellerStatus.Enabled = True
                        cboTravellerStatus.Text = (RS.Fields("TravellerStatus").Value).ToString()
                        cboTravellerStatus.BackColor = Color.White
                    End If

                    If Not IsDBNull(Trim((RS.Fields("TravellerStatus").Value).ToString())) And (UCase(Trim((RS.Fields("TravellerStatus").Value).ToString()))) <> "TRUE" Then
                        cboTravellerStatus.Text = (RS.Fields("TravellerStatus").Value).ToString()
                        cboTravellerStatus.Enabled = True
                        cboTravellerStatus.BackColor = Color.White
                    End If

                    If (UCase(Trim((RS.Fields("TravellerStatus").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("TravellerStatus").Value).ToString())) Or (Trim((RS.Fields("TravellerStatus").Value).ToString())) Is Nothing Then
                        cboTravellerStatus.Enabled = False
                        cboTravellerStatus.Text = Nothing
                        cboTravellerStatus.BackColor = Color.Silver
                    End If

                    '===End



                    '====Cost Center Code

                    If (UCase(Trim((RS.Fields("CostCenterCode").Value).ToString()))) = "TRUE" Then
                        cboCostCenter.Enabled = True
                        cboCostCenter.Text = (RS.Fields("CostCenterCode").Value).ToString()
                        cboCostCenter.BackColor = Color.White
                    End If


                    If Not IsDBNull(Trim((RS.Fields("CostCenterCode").Value).ToString())) And (UCase(Trim((RS.Fields("CostCenterCode").Value).ToString()))) <> "TRUE" Then
                        cboCostCenter.Text = (RS.Fields("CostCenterCode").Value).ToString()
                        cboCostCenter.Enabled = True
                        cboCostCenter.BackColor = Color.White
                    End If


                    If (UCase(Trim((RS.Fields("CostCenterCode").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("CostCenterCode").Value).ToString())) Or (Trim((RS.Fields("CostCenterCode").Value).ToString())) Is Nothing Then
                        cboCostCenter.Enabled = False
                        cboCostCenter.Text = Nothing
                        cboCostCenter.BackColor = Color.Silver
                    End If

                    '=====End



                    '===Project NO

                    If (UCase(Trim((RS.Fields("ProjectNo").Value).ToString()))) = "TRUE" Then
                        cboProjectNo.Enabled = True
                        cboProjectNo.Text = (RS.Fields("ProjectNo").Value).ToString()
                        cboProjectNo.BackColor = Color.White
                    End If


                    If Not IsDBNull(Trim((RS.Fields("ProjectNo").Value).ToString())) And (UCase(Trim((RS.Fields("ProjectNo").Value).ToString()))) <> "TRUE" Then
                        cboProjectNo.Text = (RS.Fields("ProjectNo").Value).ToString()
                        cboProjectNo.Enabled = True
                        cboProjectNo.BackColor = Color.White
                    End If


                    If (UCase(Trim((RS.Fields("ProjectNo").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("ProjectNo").Value).ToString())) Or (Trim((RS.Fields("ProjectNo").Value).ToString())) Is Nothing Then
                        cboProjectNo.Enabled = False
                        cboProjectNo.Text = Nothing
                        cboProjectNo.BackColor = Color.Silver
                    End If
                    '==End


                    '===Department No

                    If (UCase(Trim((RS.Fields("DepartmentNo").Value).ToString()))) = "TRUE" Then
                        cboDeptNo.Enabled = True
                        cboDeptNo.Text = (RS.Fields("DepartmentNo").Value).ToString()
                        cboDeptNo.BackColor = Color.White
                    End If



                    If Not IsDBNull(Trim((RS.Fields("DepartmentNo").Value).ToString())) And (UCase(Trim((RS.Fields("DepartmentNo").Value).ToString()))) <> "TRUE" Then
                        cboDeptNo.Text = (RS.Fields("DepartmentNo").Value).ToString()
                        cboDeptNo.Enabled = True
                        cboDeptNo.BackColor = Color.White
                    End If


                    If (UCase(Trim((RS.Fields("DepartmentNo").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("DepartmentNo").Value).ToString())) Or (Trim((RS.Fields("DepartmentNo").Value).ToString())) Is Nothing Then
                        cboDeptNo.Enabled = False
                        cboDeptNo.Text = Nothing
                        cboDeptNo.BackColor = Color.Silver
                    End If
                    '==End


                    '===Order Reference

                    If (UCase(Trim((RS.Fields("OrderRef").Value).ToString()))) = "TRUE" Then
                        cboOrderRed.Text = (RS.Fields("OrderRef").Value).ToString()
                        cboOrderRed.Enabled = True
                        cboOrderRed.BackColor = Color.White
                    End If

                    If Not IsDBNull(Trim((RS.Fields("OrderRef").Value).ToString())) And (UCase(Trim((RS.Fields("OrderRef").Value).ToString()))) <> "TRUE" Then
                        cboOrderRed.Text = (RS.Fields("OrderRef").Value).ToString()
                        cboOrderRed.Enabled = True
                        cboOrderRed.BackColor = Color.White
                    End If

                    If (UCase(Trim((RS.Fields("OrderRef").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("OrderRef").Value).ToString())) Or (Trim((RS.Fields("OrderRef").Value).ToString())) Is Nothing Then
                        cboOrderRed.Enabled = False
                        cboOrderRed.Text = Nothing
                        cboOrderRed.BackColor = Color.Silver
                    End If
                    '===End


                    '===Approver
                    If (UCase(Trim((RS.Fields("Approver").Value).ToString()))) = "TRUE" Then
                        cboApprover.Enabled = True
                        cboApprover.Text = (RS.Fields("Approver").Value).ToString()
                        cboApprover.BackColor = Color.White

                    End If

                    If Not IsDBNull(Trim((RS.Fields("Approver").Value).ToString())) And (UCase(Trim((RS.Fields("Approver").Value).ToString()))) <> "TRUE" Then

                        cboApprover.Text = (RS.Fields("Approver").Value).ToString()
                        cboApprover.Enabled = True
                        cboApprover.BackColor = Color.White

                    End If

                    If (UCase(Trim((RS.Fields("Approver").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("Approver").Value).ToString())) Or (Trim((RS.Fields("Approver").Value).ToString())) Is Nothing Then
                        cboApprover.Enabled = False
                        cboApprover.Text = Nothing
                        cboApprover.BackColor = Color.Silver
                    End If
                    '==End


                    '===Approval Code
                    If (UCase(Trim((RS.Fields("ApprovalCode").Value).ToString()))) = "TRUE" Then
                        cboApproverCode.Enabled = True
                        cboApproverCode.Text = (RS.Fields("ApprovalCode").Value).ToString()
                        cboApproverCode.BackColor = Color.White
                    End If

                    If Not IsDBNull(Trim((RS.Fields("ApprovalCode").Value).ToString())) And (UCase(Trim((RS.Fields("ApprovalCode").Value).ToString()))) <> "TRUE" Then
                        cboApproverCode.Text = (RS.Fields("ApprovalCode").Value).ToString()
                        cboApproverCode.Enabled = True
                        cboApproverCode.BackColor = Color.White
                    End If

                    If (UCase(Trim((RS.Fields("ApprovalCode").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("ApprovalCode").Value).ToString())) Or (Trim((RS.Fields("ApprovalCode").Value).ToString())) Is Nothing Then
                        cboApproverCode.Enabled = False
                        cboApproverCode.Text = Nothing
                        cboApproverCode.BackColor = Color.Silver
                    End If
                    '==End


                    '===MgrSuperior

                    If (UCase(Trim((RS.Fields("MgrSuperior").Value).ToString()))) = "TRUE" Then
                        cboMgrSup.Enabled = True
                        cboMgrSup.Text = (RS.Fields("MgrSuperior").Value).ToString()
                        cboMgrSup.BackColor = Color.White
                    End If

                    If Not IsDBNull(Trim((RS.Fields("MgrSuperior").Value).ToString())) And (UCase(Trim((RS.Fields("MgrSuperior").Value).ToString()))) <> "TRUE" Then
                        cboMgrSup.Text = (RS.Fields("MgrSuperior").Value).ToString()
                        cboMgrSup.Enabled = True
                        cboMgrSup.BackColor = Color.White
                    End If

                    If (UCase(Trim((RS.Fields("MgrSuperior").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("MgrSuperior").Value).ToString())) Or (Trim((RS.Fields("MgrSuperior").Value).ToString())) Is Nothing Then
                        cboMgrSup.Enabled = False
                        cboMgrSup.Text = Nothing
                        cboMgrSup.BackColor = Color.Silver

                    End If

                    '==End



                    ''===Reason of Trip
                    If (UCase(Trim((RS.Fields("ReasonofTrip").Value).ToString()))) = "TRUE" Then
                        cboReasonTrip.Text = (RS.Fields("ReasonofTrip").Value).ToString()
                        cboReasonTrip.Enabled = True
                        cboReasonTrip.BackColor = Color.White
                    End If


                    If Not IsDBNull(Trim((RS.Fields("ReasonofTrip").Value).ToString())) And (UCase(Trim((RS.Fields("ReasonofTrip").Value).ToString()))) <> "TRUE" Then
                        cboReasonTrip.Text = (RS.Fields("ReasonofTrip").Value).ToString()
                        cboReasonTrip.Enabled = True
                        cboReasonTrip.BackColor = Color.White
                    End If


                    If (UCase(Trim((RS.Fields("ReasonofTrip").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("ReasonofTrip").Value).ToString())) Or (Trim((RS.Fields("ReasonofTrip").Value).ToString())) Is Nothing Then
                        cboReasonTrip.Enabled = False
                        cboReasonTrip.Text = Nothing
                        cboReasonTrip.BackColor = Color.Silver

                    End If

                    '====End 


                    '===Major Class

                    If (UCase(Trim((RS.Fields("MajorClass").Value).ToString()))) = "TRUE" Then
                        cboMajorClass.Text = (RS.Fields("MajorClass").Value).ToString()
                        cboMajorClass.Enabled = True
                        cboMajorClass.BackColor = Color.White
                    End If

                    If Not IsDBNull(Trim((RS.Fields("MajorClass").Value).ToString())) And (UCase(Trim((RS.Fields("MajorClass").Value).ToString()))) <> "TRUE" Then
                        cboMajorClass.Text = (RS.Fields("MajorClass").Value).ToString()
                        cboMajorClass.Enabled = True
                        cboMajorClass.BackColor = Color.White
                    End If

                    If (UCase(Trim((RS.Fields("MajorClass").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("MajorClass").Value).ToString())) Or (Trim((RS.Fields("MajorClass").Value).ToString())) Is Nothing Then
                        cboMajorClass.Enabled = False
                        cboMajorClass.Text = Nothing
                        cboMajorClass.BackColor = Color.Silver
                    End If

                    '==End


                    '====Stop Over Flag

                    If (UCase(Trim((RS.Fields("StopOvrFlag").Value).ToString()))) = "TRUE" Then
                        cboStopOverFlag.Text = (RS.Fields("StopOvrFlag").Value).ToString()
                        cboStopOverFlag.Enabled = True
                        cboStopOverFlag.BackColor = Color.White
                    End If

                    If Not IsDBNull(Trim((RS.Fields("StopOvrFlag").Value).ToString())) And (UCase(Trim((RS.Fields("StopOvrFlag").Value).ToString()))) <> "TRUE" Then
                        cboStopOverFlag.Text = (RS.Fields("StopOvrFlag").Value).ToString()
                        cboStopOverFlag.Enabled = True
                        cboStopOverFlag.BackColor = Color.White
                    End If

                    If (UCase(Trim((RS.Fields("StopOvrFlag").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("StopOvrFlag").Value).ToString())) Or (Trim((RS.Fields("StopOvrFlag").Value).ToString())) Is Nothing Then
                        cboStopOverFlag.Enabled = False
                        cboStopOverFlag.Text = Nothing
                        cboStopOverFlag.BackColor = Color.Silver
                    End If

                    '==End


                    '==Tour Code
                    If (UCase(Trim((RS.Fields("TourCode").Value).ToString()))) = "TRUE" Then
                        cboTourCode.Text = (RS.Fields("TourCode").Value).ToString()
                        cboTourCode.Enabled = True
                        cboTourCode.BackColor = Color.White
                    End If

                    If Not IsDBNull(Trim((RS.Fields("TourCode").Value).ToString())) And (UCase(Trim((RS.Fields("TourCode").Value).ToString()))) <> "TRUE" Then
                        cboTourCode.Text = (RS.Fields("TourCode").Value).ToString()
                        cboTourCode.Enabled = True
                        cboTourCode.BackColor = Color.White
                    End If

                    If (UCase(Trim((RS.Fields("TourCode").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("TourCode").Value).ToString())) Or (Trim((RS.Fields("TourCode").Value).ToString())) Is Nothing Then
                        cboTourCode.Enabled = False
                        cboTourCode.Text = Nothing
                        cboTourCode.BackColor = Color.Silver

                    End If
                    '==End


                    '==Reason Code

                    If (UCase(Trim((RS.Fields("ReasonCode").Value).ToString()))) = "TRUE" Then
                        cboReasonCode.Text = (RS.Fields("ReasonCode").Value).ToString()
                        cboReasonCode.BackColor = Color.White
                        cboReasonCode.Enabled = True
                    End If

                    If Not IsDBNull(Trim((RS.Fields("ReasonCode").Value).ToString())) And (UCase(Trim((RS.Fields("ReasonCode").Value).ToString()))) <> "TRUE" Then
                        cboReasonCode.Text = (RS.Fields("ReasonCode").Value).ToString()
                        cboReasonCode.Enabled = True
                        cboReasonCode.BackColor = Color.White
                    End If

                    If (UCase(Trim((RS.Fields("ReasonCode").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("ReasonCode").Value).ToString())) Or (Trim((RS.Fields("ReasonCode").Value).ToString())) Is Nothing Then
                        cboReasonCode.Enabled = False
                        cboReasonCode.Text = Nothing
                        cboReasonCode.BackColor = Color.Silver
                    End If

                    '==End


                    '===Reason Code Denied
                    If (UCase(Trim((RS.Fields("ReasonCodeDenied").Value).ToString()))) = "TRUE" Then
                        cboReasonCodeDen.Text = (RS.Fields("ReasonCodeDenied").Value).ToString()
                        cboReasonCodeDen.Enabled = True
                        cboReasonCodeDen.BackColor = Color.White
                    End If

                    If Not IsDBNull(Trim((RS.Fields("ReasonCodeDenied").Value).ToString())) And (UCase(Trim((RS.Fields("ReasonCodeDenied").Value).ToString()))) <> "TRUE" Then
                        cboReasonCodeDen.Text = (RS.Fields("ReasonCodeDenied").Value).ToString()
                        cboReasonCodeDen.Enabled = True
                        cboReasonCodeDen.BackColor = Color.White
                    End If

                    If (UCase(Trim((RS.Fields("ReasonCodeDenied").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("ReasonCodeDenied").Value).ToString())) Or (Trim((RS.Fields("ReasonCodeDenied").Value).ToString())) Is Nothing Then
                        cboReasonCodeDen.Enabled = False
                        cboReasonCodeDen.Text = Nothing
                        cboReasonCodeDen.BackColor = Color.Silver
                    End If

                    '==End

                    '====Frequent Flyer Number

                    If (UCase(Trim((RS.Fields("FFlyrNo").Value).ToString()))) = "TRUE" Then
                        cboFFLYRNo.Enabled = True
                        cboFFLYRNo.Text = (RS.Fields("FFlyrNo").Value).ToString()
                        cboFFLYRNo.BackColor = Color.White
                    End If

                    If Not IsDBNull(Trim((RS.Fields("FFlyrNo").Value).ToString())) And (UCase(Trim((RS.Fields("FFlyrNo").Value).ToString()))) <> "TRUE" Then
                        cboFFLYRNo.Text = (RS.Fields("FFlyrNo").Value).ToString()
                        cboFFLYRNo.Enabled = True
                        cboFFLYRNo.BackColor = Color.White

                    End If

                    If (UCase(Trim((RS.Fields("FFlyrNo").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("FFlyrNo").Value).ToString())) Or (Trim((RS.Fields("FFlyrNo").Value).ToString())) Is Nothing Then
                        cboFFLYRNo.Enabled = False
                        cboFFLYRNo.Text = Nothing
                        cboFFLYRNo.BackColor = Color.Silver
                    End If

                    '==End


                    '==Hotel Reason Code

                    If (UCase(Trim((RS.Fields("HotelReasonCode").Value).ToString()))) = "TRUE" Then
                        cboHotelReasonCode.Text = (RS.Fields("HotelReasonCode").Value).ToString()
                        cboHotelReasonCode.Enabled = True
                        cboHotelReasonCode.BackColor = Color.White

                    End If

                    If Not IsDBNull(Trim((RS.Fields("HotelReasonCode").Value).ToString())) And (UCase(Trim((RS.Fields("HotelReasonCode").Value).ToString()))) <> "TRUE" Then
                        cboHotelReasonCode.Text = (RS.Fields("HotelReasonCode").Value).ToString()
                        cboHotelReasonCode.Enabled = True
                        cboHotelReasonCode.BackColor = Color.White
                    End If

                    If (UCase(Trim((RS.Fields("HotelReasonCode").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("HotelReasonCode").Value).ToString())) Or (Trim((RS.Fields("HotelReasonCode").Value).ToString())) Is Nothing Then
                        cboHotelReasonCode.Text = Nothing
                        cboHotelReasonCode.Enabled = False
                        cboHotelReasonCode.BackColor = Color.Silver
                    End If
                    '==End


                    '==Hotel Booked Flag Code

                    If (UCase(Trim((RS.Fields("HotelBookedFlag").Value).ToString()))) = "TRUE" Then
                        cboHotelBookedFlag.Enabled = True
                        cboHotelBookedFlag.BackColor = Color.White
                        cboHotelBookedFlag.Text = (RS.Fields("HotelBookedFlag").Value).ToString()
                    End If

                    If Not IsDBNull(Trim((RS.Fields("HotelBookedFlag").Value).ToString())) And (UCase(Trim((RS.Fields("HotelBookedFlag").Value).ToString()))) <> "TRUE" Then
                        cboHotelBookedFlag.Text = (RS.Fields("HotelBookedFlag").Value).ToString()
                        cboHotelBookedFlag.Enabled = True
                        cboHotelBookedFlag.BackColor = Color.White
                    End If

                    If (UCase(Trim((RS.Fields("HotelBookedFlag").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("HotelBookedFlag").Value).ToString())) Or (Trim((RS.Fields("HotelBookedFlag").Value).ToString())) Is Nothing Then
                        cboHotelBookedFlag.Text = Nothing
                        cboHotelBookedFlag.Enabled = False
                        cboHotelBookedFlag.BackColor = Color.Silver
                    End If
                    '==End


                    '===Air No Accomodation Reason Code
                    If (UCase(Trim((RS.Fields("AirNoAccomodationReasconCode").Value).ToString()))) = "TRUE" Then
                        cboAirNoAccom.Enabled = True
                        cboAirNoAccom.Text = (RS.Fields("AirNoAccomodationReasconCode").Value).ToString()
                        cboAirNoAccom.BackColor = Color.White
                    End If

                    If Not IsDBNull(Trim((RS.Fields("AirNoAccomodationReasconCode").Value).ToString())) And (UCase(Trim((RS.Fields("AirNoAccomodationReasconCode").Value).ToString()))) <> "TRUE" Then
                        cboAirNoAccom.Text = (RS.Fields("AirNoAccomodationReasconCode").Value).ToString()
                        cboAirNoAccom.Enabled = True
                        cboAirNoAccom.BackColor = Color.White
                    End If

                    If (UCase(Trim((RS.Fields("AirNoAccomodationReasconCode").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("AirNoAccomodationReasconCode").Value).ToString())) Or (Trim((RS.Fields("AirNoAccomodationReasconCode").Value).ToString())) Is Nothing Then
                        cboAirNoAccom.Enabled = False
                        cboAirNoAccom.Text = Nothing
                        cboAirNoAccom.BackColor = Color.Silver
                    End If
                    '==End


                    '===Car Booked Flag
                    If (UCase(Trim((RS.Fields("CarBookedFlag").Value).ToString()))) = "TRUE" Then
                        cboCarBookedFlag.Text = (RS.Fields("CarBookedFlag").Value).ToString()
                        cboCarBookedFlag.Enabled = True
                        cboCarBookedFlag.BackColor = Color.White
                    End If

                    If Not IsDBNull(Trim((RS.Fields("CarBookedFlag").Value).ToString())) And (UCase(Trim((RS.Fields("CarBookedFlag").Value).ToString()))) <> "TRUE" Then
                        cboCarBookedFlag.Text = (RS.Fields("CarBookedFlag").Value).ToString()
                        cboCarBookedFlag.Enabled = True
                        cboCarBookedFlag.BackColor = Color.White
                    End If

                    If (UCase(Trim((RS.Fields("CarBookedFlag").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("CarBookedFlag").Value).ToString())) Or (Trim((RS.Fields("CarBookedFlag").Value).ToString())) Is Nothing Then
                        cboCarBookedFlag.Enabled = False
                        cboCarBookedFlag.Text = Nothing
                        cboCarBookedFlag.BackColor = Color.Silver
                    End If
                    '===End



                    '===Sales Channel

                    If (UCase(Trim((RS.Fields("SalesChannel").Value).ToString()))) = "TRUE" Then
                        cboSalesChannel.Enabled = True
                        cboSalesChannel.Text = (RS.Fields("SalesChannel").Value).ToString()
                        cboSalesChannel.BackColor = Color.White
                    End If

                    If Not IsDBNull(Trim((RS.Fields("SalesChannel").Value).ToString())) And (UCase(Trim((RS.Fields("SalesChannel").Value).ToString()))) <> "TRUE" Then
                        cboSalesChannel.Text = (RS.Fields("SalesChannel").Value).ToString()
                        cboSalesChannel.Enabled = True
                        cboSalesChannel.BackColor = Color.White
                    End If

                    If (UCase(Trim((RS.Fields("SalesChannel").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("SalesChannel").Value).ToString())) Or (Trim((RS.Fields("SalesChannel").Value).ToString())) Is Nothing Then
                        cboSalesChannel.Enabled = False
                        cboSalesChannel.Text = Nothing
                        cboSalesChannel.BackColor = Color.Silver
                    End If
                    '==End



                    '==Record Type

                    If (UCase(Trim((RS.Fields("RecordType").Value).ToString()))) = "TRUE" Then
                        cboRecordType.Enabled = True
                        cboRecordType.Text = (RS.Fields("RecordType").Value).ToString()
                        cboRecordType.BackColor = Color.White

                    End If

                    If Not IsDBNull(Trim((RS.Fields("RecordType").Value).ToString())) And (UCase(Trim((RS.Fields("RecordType").Value).ToString()))) <> "TRUE" Then
                        cboRecordType.Text = (RS.Fields("RecordType").Value).ToString()
                        cboRecordType.Enabled = True
                        cboRecordType.BackColor = Color.White
                    End If

                    If (UCase(Trim((RS.Fields("RecordType").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("RecordType").Value).ToString())) Or (Trim((RS.Fields("RecordType").Value).ToString())) Is Nothing Then
                        cboRecordType.Enabled = False
                        cboRecordType.Text = Nothing
                        cboRecordType.BackColor = Color.Silver
                    End If
                    'End


                    '===CS Data 1

                    If (UCase(Trim((RS.Fields("CSData1").Value).ToString()))) = "TRUE" Then
                        cboCSData1.Enabled = True
                        cboCSData1.Text = (RS.Fields("CSData1").Value).ToString()
                        cboCSData1.BackColor = Color.White
                    End If

                    If Not IsDBNull(Trim((RS.Fields("CSData1").Value).ToString())) And (UCase(Trim((RS.Fields("CSData1").Value).ToString()))) <> "TRUE" Then
                        cboCSData1.Text = (RS.Fields("CSData1").Value).ToString()
                        cboCSData1.Enabled = True
                        cboCSData1.BackColor = Color.White
                    End If

                    If (UCase(Trim((RS.Fields("CSData1").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("CSData1").Value).ToString())) Or (Trim((RS.Fields("CSData1").Value).ToString())) Is Nothing Then
                        cboCSData1.Enabled = False
                        cboCSData1.Text = Nothing
                        cboCSData1.BackColor = Color.Silver
                    End If
                    '==End



                    '==CS Data2

                    If (UCase(Trim((RS.Fields("CSData2").Value).ToString()))) = "TRUE" Then
                        cboCSData2.Enabled = True
                        cboCSData2.Text = (RS.Fields("CSData2").Value).ToString()
                        cboCSData2.BackColor = Color.White
                    End If

                    If Not IsDBNull(Trim((RS.Fields("CSData2").Value).ToString())) And (UCase(Trim((RS.Fields("CSData2").Value).ToString()))) <> "TRUE" Then
                        cboCSData2.Text = (RS.Fields("CSData2").Value).ToString()
                        cboCSData2.Enabled = True
                        cboCSData2.BackColor = Color.White
                    End If

                    If (UCase(Trim((RS.Fields("CSData2").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("CSData2").Value).ToString())) Or (Trim((RS.Fields("CSData2").Value).ToString())) Is Nothing Then
                        cboCSData2.Enabled = False
                        cboCSData2.Text = Nothing
                        cboCSData2.BackColor = Color.Silver
                    End If

                    '==End


                    '===CS Data 3
                    If (UCase(Trim((RS.Fields("CSData3").Value).ToString()))) = "TRUE" Then
                        cboCSData3.Enabled = True
                        cboCSData3.Text = (RS.Fields("CSData3").Value).ToString()
                        cboCSData3.BackColor = Color.White
                    End If

                    If Not IsDBNull(Trim((RS.Fields("CSData3").Value).ToString())) And (UCase(Trim((RS.Fields("CSData3").Value).ToString()))) <> "TRUE" Then
                        cboCSData3.Text = (RS.Fields("CSData3").Value).ToString()
                        cboCSData3.Enabled = True
                        cboCSData3.BackColor = Color.White
                    End If

                    If (UCase(Trim((RS.Fields("CSData3").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("CSData3").Value).ToString())) Or (Trim((RS.Fields("CSData3").Value).ToString())) Is Nothing Then
                        cboCSData3.Enabled = False
                        cboCSData3.Text = Nothing
                        cboCSData3.BackColor = Color.Silver
                    End If
                    '==End



                    '==CS Data 4

                    If (UCase(Trim((RS.Fields("CSData4").Value).ToString()))) = "TRUE" Then
                        cboCSData4.Text = (RS.Fields("CSData4").Value).ToString()
                        cboCSData4.Enabled = True
                        cboCSData4.BackColor = Color.White
                    End If

                    If Not IsDBNull(Trim((RS.Fields("CSData4").Value).ToString())) And (UCase(Trim((RS.Fields("CSData4").Value).ToString()))) <> "TRUE" Then
                        cboCSData4.Text = (RS.Fields("CSData4").Value).ToString()
                        cboCSData4.Enabled = True
                        cboCSData4.BackColor = Color.White
                    End If

                    If (UCase(Trim((RS.Fields("CSData4").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("CSData4").Value).ToString())) Or (Trim((RS.Fields("CSData4").Value).ToString())) Is Nothing Then
                        cboCSData4.Enabled = False
                        cboCSData4.Text = Nothing
                        cboCSData4.BackColor = Color.Silver
                    End If

                    '==End



                    '==CS Data 5

                    If (UCase(Trim((RS.Fields("CSData5").Value).ToString()))) = "TRUE" Then
                        cboCSData5.Text = (RS.Fields("CSData5").Value).ToString()
                        cboCSData5.Enabled = True
                        cboCSData5.BackColor = Color.White
                    End If

                    If Not IsDBNull(Trim((RS.Fields("CSData5").Value).ToString())) And (UCase(Trim((RS.Fields("CSData5").Value).ToString()))) <> "TRUE" Then
                        cboCSData5.Text = (RS.Fields("CSData5").Value).ToString()
                        cboCSData5.Enabled = True
                        cboCSData5.BackColor = Color.White
                    End If

                    If (UCase(Trim((RS.Fields("CSData5").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("CSData5").Value).ToString())) Or (Trim((RS.Fields("CSData5").Value).ToString())) Is Nothing Then
                        cboCSData5.Enabled = False
                        cboCSData5.Text = Nothing
                        cboCSData5.BackColor = Color.Silver
                    End If

                    '==End


                    '==CS Data 6

                    If (UCase(Trim((RS.Fields("CSData6").Value).ToString()))) = "TRUE" Then
                        cboCSData6.Text = (RS.Fields("CSData6").Value).ToString()
                        cboCSData6.Enabled = True
                        cboCSData6.BackColor = Color.White
                    End If

                    If Not IsDBNull(Trim((RS.Fields("CSData6").Value).ToString())) And (UCase(Trim((RS.Fields("CSData6").Value).ToString()))) <> "TRUE" Then
                        cboCSData6.Text = (RS.Fields("CSData6").Value).ToString()
                        cboCSData6.Enabled = True
                        cboCSData6.BackColor = Color.White
                    End If

                    If (UCase(Trim((RS.Fields("CSData6").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("CSData6").Value).ToString())) Or (Trim((RS.Fields("CSData6").Value).ToString())) Is Nothing Then
                        cboCSData6.Enabled = False
                        cboCSData6.Text = Nothing
                        cboCSData6.BackColor = Color.Silver
                    End If

                    '==End


                    '==CS Data 7

                    If (UCase(Trim((RS.Fields("CSData7").Value).ToString()))) = "TRUE" Then
                        cboCSData7.Text = (RS.Fields("CSData7").Value).ToString()
                        cboCSData7.Enabled = True
                        cboCSData7.BackColor = Color.White
                    End If

                    If Not IsDBNull(Trim((RS.Fields("CSData7").Value).ToString())) And (UCase(Trim((RS.Fields("CSData7").Value).ToString()))) <> "TRUE" Then
                        cboCSData7.Text = (RS.Fields("CSData7").Value).ToString()
                        cboCSData7.Enabled = True
                        cboCSData7.BackColor = Color.White
                    End If

                    If (UCase(Trim((RS.Fields("CSData7").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("CSData7").Value).ToString())) Or (Trim((RS.Fields("CSData7").Value).ToString())) Is Nothing Then
                        cboCSData7.Enabled = False
                        cboCSData7.Text = Nothing
                        cboCSData7.BackColor = Color.Silver
                    End If

                    '==End


                    '==CS Data 8

                    If (UCase(Trim((RS.Fields("CSData8").Value).ToString()))) = "TRUE" Then
                        cboCSData8.Text = (RS.Fields("CSData8").Value).ToString()
                        cboCSData8.Enabled = True
                        cboCSData8.BackColor = Color.White
                    End If

                    If Not IsDBNull(Trim((RS.Fields("CSData8").Value).ToString())) And (UCase(Trim((RS.Fields("CSData8").Value).ToString()))) <> "TRUE" Then
                        cboCSData8.Text = (RS.Fields("CSData8").Value).ToString()
                        cboCSData8.Enabled = True
                        cboCSData8.BackColor = Color.White
                    End If

                    If (UCase(Trim((RS.Fields("CSData8").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("CSData8").Value).ToString())) Or (Trim((RS.Fields("CSData8").Value).ToString())) Is Nothing Then
                        cboCSData8.Enabled = False
                        cboCSData8.Text = Nothing
                        cboCSData8.BackColor = Color.Silver
                    End If

                    '==End


                    '===CS Data 12

                    If (UCase(Trim((RS.Fields("CSData12").Value).ToString()))) = "TRUE" Then
                        cboCSData12.Text = (RS.Fields("CSData12").Value).ToString()
                        cboCSData12.Enabled = True
                        cboCSData12.BackColor = Color.White
                    End If

                    If Not IsDBNull(Trim((RS.Fields("CSData12").Value).ToString())) And (UCase(Trim((RS.Fields("CSData12").Value).ToString()))) <> "TRUE" Then
                        cboCSData12.Text = (RS.Fields("CSData12").Value).ToString()
                        cboCSData12.Enabled = True
                        cboCSData12.BackColor = Color.White
                    End If

                    If (UCase(Trim((RS.Fields("CSData12").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("CSData12").Value).ToString())) Or (Trim((RS.Fields("CSData12").Value).ToString())) Is Nothing Then
                        cboCSData12.Enabled = False
                        cboCSData12.Text = Nothing
                        cboCSData12.BackColor = Color.Silver
                    End If



                    '==Customer Specific Low Fare
                    If (UCase(Trim((RS.Fields("CustoSpecLF").Value).ToString()))) = "TRUE" Then
                        txtCusSpecLF.Text = (RS.Fields("CustoSpecLF").Value).ToString()
                        txtCusSpecLF.Enabled = True
                        txtCusSpecLF.BackColor = Color.White
                    End If

                    If Not IsDBNull(Trim((RS.Fields("CustoSpecLF").Value).ToString())) And (UCase(Trim((RS.Fields("CustoSpecLF").Value).ToString()))) <> "TRUE" Then
                        txtCusSpecLF.Text = (RS.Fields("CustoSpecLF").Value).ToString()
                        txtCusSpecLF.Enabled = True
                        txtCusSpecLF.BackColor = Color.White
                    End If

                    If (UCase(Trim((RS.Fields("CustoSpecLF").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("CustoSpecLF").Value).ToString())) Or (Trim((RS.Fields("CustoSpecLF").Value).ToString())) Is Nothing Then
                        txtCusSpecLF.Enabled = False
                        txtCusSpecLF.Text = Nothing
                        txtCusSpecLF.BackColor = Color.Silver
                    End If


                    '==Customer Specific Reference Fare Amount
                    If (UCase(Trim((RS.Fields("CustoSpecRFAmount").Value).ToString()))) = "TRUE" Then
                        txtCustSpecRFA.Text = (RS.Fields("CustoSpecRFAmount").Value).ToString()
                        txtCustSpecRFA.Enabled = True
                        txtCustSpecRFA.BackColor = Color.White
                    End If

                    If Not IsDBNull(Trim((RS.Fields("CustoSpecRFAmount").Value).ToString())) And (UCase(Trim((RS.Fields("CustoSpecRFAmount").Value).ToString()))) <> "TRUE" Then
                        txtCustSpecRFA.Text = (RS.Fields("CustoSpecRFAmount").Value).ToString()
                        txtCustSpecRFA.Enabled = True
                        txtCustSpecRFA.BackColor = Color.White
                    End If

                    If (UCase(Trim((RS.Fields("CustoSpecRFAmount").Value).ToString()))) = "" Or IsDBNull(Trim((RS.Fields("CustoSpecRFAmount").Value).ToString())) Or (Trim((RS.Fields("CustoSpecRFAmount").Value).ToString())) Is Nothing Then
                        txtCustSpecRFA.Enabled = False
                        txtCustSpecRFA.Text = Nothing
                        txtCustSpecRFA.BackColor = Color.Silver
                    End If


                    RS.MoveNext()

                End If

            End With

            RS.Close()

            Call MIDFields()

        End If



    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        CHECK_RS()

        SQL_QUERY = "Select * from BCDMIS..ClientSpecific where clientID  = '" & txtClientID.Text & "'"
        RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        With RS

            If Not RS.EOF Then

                res = MsgBox("Do you want to update existing record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                If res = MsgBoxResult.Yes Then

                    UPD_QUERY = "update BCDMIS..ClientSpecific set " _
                                   & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                   & ",ClientName = '" & Trim(txtClientName.Text) & "'" _
                                   & ",SMDID = '" & Trim(txtSMDID.Text) & "'" _
                                   & ",TSPID = '" & Trim(txtTSPID.Text) & "'" _
                                   & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                   & ",EmployeeNo = '" & Trim(cboEmployeeNo.Text) & "'" _
                                   & ",TravellerName = '" & Trim(cboTravellerName.Text) & "'" _
                                   & ",TravellerStatus = '" & Trim(cboTravellerStatus.Text) & "'" _
                                   & ",CostCenterCode= '" & Trim(cboCostCenter.Text) & "'" _
                                   & ",ProjectNo = '" & Trim(cboProjectNo.Text) & "'" _
                                   & ",DepartmentNo = '" & Trim(cboDeptNo.Text) & "'" _
                                   & ",OrderRef = '" & Trim(cboOrderRed.Text) & "'" _
                                   & ",Approver = '" & Trim(cboApprover.Text) & "'" _
                                   & ",ApprovalCode = '" & Trim(cboApproverCode.Text) & "'" _
                                   & ",LowFare = '" & Trim(txtLowFareAmount.Text) & "'" _
                                   & ",FullFare = '" & Trim(txtRefFareAmount.Text) & "'" _
                                   & ",MgrSuperior = '" & Trim(cboMgrSup.Text) & "'" _
                                   & ",ReasonofTrip = '" & Trim(cboReasonTrip.Text) & "'" _
                                   & ",MajorClass = '" & Trim(cboMajorClass.Text) & "'" _
                                   & ",StopOvrFlag = '" & Trim(cboStopOverFlag.Text) & "'" _
                                   & ",TourCode = '" & Trim(cboTourCode.Text) & "'" _
                                   & ",ReasonCode = '" & Trim(cboReasonCode.Text) & "'" _
                                   & ",ReasonCodeDenied = '" & Trim(cboReasonCodeDen.Text) & "'" _
                                   & ",FFlyrNo = '" & Trim(cboFFLYRNo.Text) & "'" _
                                   & ",HotelReasonCode = '" & Trim(cboHotelReasonCode.Text) & "'" _
                                   & ",HotelBookedFlag = '" & Trim(cboHotelBookedFlag.Text) & "'" _
                                   & ",AirNoAccomodationReasconCode = '" & Trim(cboAirNoAccom.Text) & "'" _
                                   & ",CarBookedFlag= '" & Trim(cboCarBookedFlag.Text) & "'" _
                                   & ",SalesChannel= '" & Trim(cboSalesChannel.Text) & "'" _
                                   & ",RecordType= '" & Trim(cboRecordType.Text) & "'" _
                                   & ",CSData1= '" & Trim(cboCSData1.Text) & "'" _
                                   & ",CSData2= '" & Trim(cboCSData2.Text) & "'" _
                                   & ",CSData3= '" & Trim(cboCSData3.Text) & "'" _
                                   & ",CSData4= '" & Trim(cboCSData4.Text) & "'" _
                                   & ",CSData5= '" & Trim(cboCSData5.Text) & "'" _
                                   & ",CSData6= '" & Trim(cboCSData6.Text) & "'" _
                                   & ",CSData7= '" & Trim(cboCSData7.Text) & "'" _
                                   & ",CSData8= '" & Trim(cboCSData8.Text) & "'" _
                                   & ",CSData12= '" & Trim(cboCSData12.Text) & "'" _
                                   & ",CustoSpecLF= '" & Trim(txtCusSpecLF.Text) & "'" _
                                   & ",CustoSpecRFAmount= '" & Trim(txtCustSpecRFA.Text) & "'" _
                                   & " where ClientID = '" & Trim(txtClientID.Text) & "'"

                    CNN.Execute(UPD_QUERY)

                    MsgBox("Record has been successfully updated..", , ":::Settings::")

                    Call InitBCDSet()
                    cboC_Name.Refresh()
                    ClientSpecCD.Clear()
                    Call load_ClientListMIS()

                    cboC_Name.Text = Nothing

                Else
                    Exit Sub
                End If

            End If


        End With
        RS.Close()

    End Sub



    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click

        res = MsgBox("Do you want to Add New Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

        If res = MsgBoxResult.Yes Then

            CHECK_RS()

            SQL_QUERY = "Select MAX(CLIENTID) AS CLIENTID from BCDMIS..ClientSpecific "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then

                    Call New_EditClientInit()
                    Call novalue()
                    cboC_Name.Text = Nothing
                    cboC_Name.Enabled = False
                    txtClientName.Text = Nothing
                    txtClientName.Enabled = True
                    txtClientName.BackColor = Color.White
                    txtClientName.Focus()
                    txtClientID.Text = ((RS.Fields("ClientID").Value) + 1)
                    RS.MoveNext()

                End If
            End With
            RS.Close()


        ElseIf res = MsgBoxResult.No Then

            Call InitBCDSet()
            cboC_Name.Text = Nothing
            cboC_Name.Enabled = True

        End If

    End Sub


    Private Sub btnSaveNEwClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveNEwClient.Click

        If Trim(cboGlobalCust.Text) <> "" And Trim(txtClientName.Text) <> "" Then

            res = MsgBox("Do you want to Add New Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")
            If res = MsgBoxResult.Yes Then

                INS_QUERY = "insert into BCDMIS..ClientSpecific(ClientID,ClientName,SMDID,TSPID,GlobalCustNo,LocalCustNo,EmployeeNo,TravellerName,TravellerStatus,CostCenterCode,ProjectNo,DepartmentNo,OrderRef,Approver,ApprovalCode,MgrSuperior,ReasonofTrip,MajorClass,StopOvrFlag,TourCode,ReasonCode,ReasonCodeDenied,FFlyrNo,HotelReasonCode,HotelBookedFlag,AirNoAccomodationReasconCode,CarBookedFlag,SalesChannel,RecordType,CSData1,CSData2,CSData3,CSData4,CSData5,CSData6,CSData7,CSData8,CSData12,CustoSpecLF,CustoSpecRFAmount,LowFare,FullFare  )" _
                & " values ('" & Trim(txtClientID.Text) & "','" & Trim(txtClientName.Text) & "','" & Trim(txtSMDID.Text) & "','" & Trim(txtTSPID.Text) & "','" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboEmployeeNo.Text) & "', '" & Trim(cboTravellerName.Text) & "','" & Trim(cboTravellerStatus.Text) & "','" & Trim(cboCostCenter.Text) & "','" & Trim(cboProjectNo.Text) & "','" & Trim(cboDeptNo.Text) & "','" & Trim(cboOrderRed.Text) & "', '" & Trim(cboApprover.Text) & "','" & Trim(cboApproverCode.Text) & "','" & Trim(cboMgrSup.Text) & "','" & Trim(cboReasonTrip.Text) & "','" & Trim(cboMajorClass.Text) & "','" & Trim(cboStopOverFlag.Text) & "','" & Trim(cboTourCode.Text) & "','" & Trim(cboReasonCode.Text) & "', '" & Trim(cboReasonCodeDen.Text) & "','" & Trim(cboFFLYRNo.Text) & "','" & Trim(cboHotelReasonCode.Text) & "','" & Trim(cboHotelBookedFlag.Text) & "','" & Trim(cboAirNoAccom.Text) & "','" & Trim(cboCarBookedFlag.Text) & "','" & Trim(cboSalesChannel.Text) & "','" & Trim(cboRecordType.Text) & "','" & Trim(cboCSData1.Text) & "','" & Trim(cboCSData2.Text) & "','" & Trim(cboCSData3.Text) & "','" & Trim(cboCSData4.Text) & "','" & Trim(cboCSData5.Text) & "','" & Trim(cboCSData6.Text) & "','" & Trim(cboCSData7.Text) & "','" & Trim(cboCSData8.Text) & "','" & Trim(cboCSData12.Text) & "','" & Trim(txtCusSpecLF.Text) & "','" & Trim(txtCustSpecRFA.Text) & "','" & Trim(txtLowFareAmount.Text) & "','" & Trim(txtRefFareAmount.Text) & "')"

                CNN.Execute(INS_QUERY)

                MsgBox("Record has been successfully added...", , "::: Settings ::")
                Call InitBCDSet()
                cboC_Name.Text = Nothing
                cboC_Name.Enabled = True
                Call load_ClientListMIS()
            Else
                Call InitBCDSet()
                cboC_Name.Enabled = True
                cboC_Name.Focus()

            End If

        Else
            MsgBox("Incomplete Details..", vbCritical + vbOKOnly, "::: Settings :::")
            cboC_Name.Focus()
        End If

    End Sub


    Private Sub btnAdd_TSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd_TSettings.Click

        Dim required As String = Nothing
        Dim reply As MsgBoxResult
        Dim replyRes As MsgBoxResult


        '===== Required Options ========

        If Trim(cboC_Name.Text) <> Nothing And Trim(cboGlobalCust.Text) <> Nothing And Trim(cboDataField.Text) <> Nothing And (rdTableSettings_M.Checked <> False Or rdTableSettings_O.Checked <> False Or rdTableSettings_C.Checked <> False) Then

            'And Trim(cboCOD.Text) <> Nothing 

            reply = MsgBox("Do you want to Add New Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If reply = MsgBoxResult.Yes Then

                If rdTableSettings_M.Checked = True Then
                    required = "Mandatory"
                ElseIf rdTableSettings_O.Checked = True Then
                    required = "Optional"
                ElseIf rdTableSettings_C.Checked = True Then
                    required = "Conditional"
                End If


                If Trim(cboDataField.Text) = "Low Fare" Then

                    CHECK_RS()

                    SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_LowFare where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                    RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With RS

                        If Not RS.EOF Then

                            replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                            If replyRes = MsgBoxResult.Yes Then

                                UPD_QUERY = "update BCDMIS..F_LowFare set " _
                                & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                & ",CODs = '" & Trim(cboCOD.Text) & "'" _
                                & ",Required = '" & Trim(required) & "'" _
                                & ",Remarks = '" & Trim(Remarks_TSettings.Text) & "'" _
                                & " where GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'"

                                CNN.Execute(UPD_QUERY)

                                MsgBox("Record has been successfully updated...", , "::: Settings ::")

                            End If


                        Else

                            INS_QUERY = "insert into BCDMIS..F_LowFare(GlobalCustNo,LocalCustNo,CODs,Required, Remarks)" _
                                        & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboCOD.Text) & "','" & Trim(required) & "','" & Trim(Remarks_TSettings.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")


                        End If
                    End With

                    RS.Close()

                End If



                If Trim(cboDataField.Text) = "Full Fare" Then

                    CHECK_RS()

                    SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_ReferenceFare where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                    RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With RS

                        If Not RS.EOF Then

                            replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                            If replyRes = MsgBoxResult.Yes Then

                                UPD_QUERY = "update BCDMIS..F_ReferenceFare set " _
                                & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                & ",CODs = '" & Trim(cboCOD.Text) & "'" _
                                & ",Required = '" & Trim(required) & "'" _
                                & ",Remarks = '" & Trim(Remarks_TSettings.Text) & "'" _
                                & " where GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'"

                                CNN.Execute(UPD_QUERY)

                                MsgBox("Record has been successfully updated...", , "::: Settings ::")

                            End If


                        Else

                            INS_QUERY = "insert into BCDMIS..F_ReferenceFare(GlobalCustNo,LocalCustNo,CODs,Required, Remarks)" _
                                        & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboCOD.Text) & "','" & Trim(required) & "','" & Trim(Remarks_TSettings.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")


                        End If
                    End With

                    RS.Close()

                End If







                If Trim(cboDataField.Text) = "Sales Channel" Then

                    CHECK_RS()

                    SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_SalesChannel where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                    RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With RS

                        If Not RS.EOF Then

                            replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                            If replyRes = MsgBoxResult.Yes Then

                                UPD_QUERY = "update BCDMIS..F_SalesChannel set " _
                                & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                & ",CODs = '" & Trim(cboCOD.Text) & "'" _
                                & ",Required = '" & Trim(required) & "'" _
                                & ",Remarks = '" & Trim(Remarks_TSettings.Text) & "'" _
                                & " where GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'"

                                CNN.Execute(UPD_QUERY)

                                MsgBox("Record has been successfully updated...", , "::: Settings ::")

                            End If


                        Else

                            INS_QUERY = "insert into BCDMIS..F_SalesChannel(GlobalCustNo,LocalCustNo,CODs,Required, Remarks)" _
                                        & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboCOD.Text) & "','" & Trim(required) & "','" & Trim(Remarks_TSettings.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")


                        End If
                    End With

                    RS.Close()

                End If



                If Trim(cboDataField.Text) = "Accomodatation Reason Code" Then

                    CHECK_RS()

                    SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_AccomodationReasonCD where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                    RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With RS

                        If Not RS.EOF Then

                            replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                            If replyRes = MsgBoxResult.Yes Then

                                UPD_QUERY = "update BCDMIS..F_AccomodationReasonCD set " _
                                & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                & ",CODs = '" & Trim(cboCOD.Text) & "'" _
                                & ",Required = '" & Trim(required) & "'" _
                                & ",Remarks = '" & Trim(Remarks_TSettings.Text) & "'" _
                                & " where GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'"

                                CNN.Execute(UPD_QUERY)

                                MsgBox("Record has been successfully updated...", , "::: Settings ::")

                            End If


                        Else

                            INS_QUERY = "insert into BCDMIS..F_AccomodationReasonCD(GlobalCustNo,LocalCustNo,CODs,Required, Remarks)" _
                                        & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboCOD.Text) & "','" & Trim(required) & "','" & Trim(Remarks_TSettings.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")


                        End If
                    End With

                    RS.Close()

                End If



                If Trim(cboDataField.Text) = "Approval Code" Then

                    CHECK_RS()

                    SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_ApprovalCode where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                    RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With RS

                        If Not RS.EOF Then

                            replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                            If replyRes = MsgBoxResult.Yes Then

                                UPD_QUERY = "update BCDMIS..F_ApprovalCode set " _
                                & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                & ",CODs = '" & Trim(cboCOD.Text) & "'" _
                                & ",Required = '" & Trim(required) & "'" _
                                & ",Remarks = '" & Trim(Remarks_TSettings.Text) & "'" _
                                & " where GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'"

                                CNN.Execute(UPD_QUERY)

                                MsgBox("Record has been successfully updated...", , "::: Settings ::")

                            End If


                        Else

                            INS_QUERY = "insert into BCDMIS..F_ApprovalCode(GlobalCustNo,LocalCustNo,CODs,Required, Remarks)" _
                                        & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboCOD.Text) & "','" & Trim(required) & "','" & Trim(Remarks_TSettings.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")


                        End If

                    End With
                    RS.Close()

                End If

                If Trim(cboDataField.Text) = "Approver" Then

                    CHECK_RS()

                    SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_Approver where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                    RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With RS

                        If Not RS.EOF Then

                            replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                            If replyRes = MsgBoxResult.Yes Then

                                UPD_QUERY = "update BCDMIS..F_Approver set " _
                                & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                & ",CODs = '" & Trim(cboCOD.Text) & "'" _
                                & ",Required = '" & Trim(required) & "'" _
                                & ",Remarks = '" & Trim(Remarks_TSettings.Text) & "'" _
                                & " where GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'"

                                CNN.Execute(UPD_QUERY)

                                MsgBox("Record has been successfully updated...", , "::: Settings ::")

                            End If


                        Else

                            INS_QUERY = "insert into BCDMIS..F_Approver(GlobalCustNo,LocalCustNo,CODs,Required, Remarks)" _
                                        & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboCOD.Text) & "','" & Trim(required) & "','" & Trim(Remarks_TSettings.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")


                        End If

                    End With
                    RS.Close()

                End If

                If Trim(cboDataField.Text) = "Car Booked Flag" Then

                    CHECK_RS()

                    SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_CarBookedFlag where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                    RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With RS

                        If Not RS.EOF Then

                            replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                            If replyRes = MsgBoxResult.Yes Then

                                UPD_QUERY = "update BCDMIS..F_CarBookedFlag set " _
                                & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                & ",CODs = '" & Trim(cboCOD.Text) & "'" _
                                & ",Required = '" & Trim(required) & "'" _
                                & ",Remarks = '" & Trim(Remarks_TSettings.Text) & "'" _
                                & " where GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'"

                                CNN.Execute(UPD_QUERY)

                                MsgBox("Record has been successfully updated...", , "::: Settings ::")

                            End If


                        Else

                            INS_QUERY = "insert into BCDMIS..F_CarBookedFlag(GlobalCustNo,LocalCustNo,CODs,Required, Remarks)" _
                                        & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboCOD.Text) & "','" & Trim(required) & "','" & Trim(Remarks_TSettings.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")


                        End If

                    End With
                    RS.Close()

                End If


                If Trim(cboDataField.Text) = "Hotel Booked Flag" Then

                    CHECK_RS()

                    SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_HotelBookedFlag where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                    RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With RS

                        If Not RS.EOF Then

                            replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                            If replyRes = MsgBoxResult.Yes Then

                                UPD_QUERY = "update BCDMIS..F_HotelBookedFlag set " _
                                & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                & ",CODs = '" & Trim(cboCOD.Text) & "'" _
                                & ",Required = '" & Trim(required) & "'" _
                                & ",Remarks = '" & Trim(Remarks_TSettings.Text) & "'" _
                                & " where GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'"

                                CNN.Execute(UPD_QUERY)

                                MsgBox("Record has been successfully updated...", , "::: Settings ::")

                            End If


                        Else

                            INS_QUERY = "insert into BCDMIS..F_HotelBookedFlag(GlobalCustNo,LocalCustNo,CODs,Required, Remarks)" _
                                        & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboCOD.Text) & "','" & Trim(required) & "','" & Trim(Remarks_TSettings.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")


                        End If

                    End With
                    RS.Close()

                End If




                If Trim(cboDataField.Text) = "Cost Center" Then

                    CHECK_RS()

                    SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_CostCenterCode where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                    RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With RS

                        If Not RS.EOF Then

                            replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                            If replyRes = MsgBoxResult.Yes Then

                                UPD_QUERY = "update BCDMIS..F_CostCenterCode set " _
                                & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                & ",CODs = '" & Trim(cboCOD.Text) & "'" _
                                & ",Required = '" & Trim(required) & "'" _
                                & ",Remarks = '" & Trim(Remarks_TSettings.Text) & "'" _
                                & " where GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'"

                                CNN.Execute(UPD_QUERY)

                                MsgBox("Record has been successfully updated...", , "::: Settings ::")

                            End If


                        Else

                            INS_QUERY = "insert into BCDMIS..F_CostCenterCode(GlobalCustNo,LocalCustNo,CODs,Required, Remarks)" _
                                        & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboCOD.Text) & "','" & Trim(required) & "','" & Trim(Remarks_TSettings.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")


                        End If

                    End With
                    RS.Close()

                End If



                If Trim(cboDataField.Text) = "Major Class" Then

                    CHECK_RS()

                    SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_MajorClass where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                    RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With RS

                        If Not RS.EOF Then

                            replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                            If replyRes = MsgBoxResult.Yes Then

                                UPD_QUERY = "update BCDMIS..F_MajorClass set " _
                                & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                & ",CODs = '" & Trim(cboCOD.Text) & "'" _
                                & ",Required = '" & Trim(required) & "'" _
                                & ",Remarks = '" & Trim(Remarks_TSettings.Text) & "'" _
                                & " where GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'"

                                CNN.Execute(UPD_QUERY)

                                MsgBox("Record has been successfully updated...", , "::: Settings ::")

                            End If


                        Else

                            INS_QUERY = "insert into BCDMIS..F_MajorClass(GlobalCustNo,LocalCustNo,CODs,Required, Remarks)" _
                                        & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboCOD.Text) & "','" & Trim(required) & "','" & Trim(Remarks_TSettings.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")


                        End If

                    End With
                    RS.Close()

                End If



                If Trim(cboDataField.Text) = "Tour Code" Then

                    CHECK_RS()

                    SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_TourCode where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                    RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With RS

                        If Not RS.EOF Then

                            replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                            If replyRes = MsgBoxResult.Yes Then

                                UPD_QUERY = "update BCDMIS..F_TourCode set " _
                                & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                & ",CODs = '" & Trim(cboCOD.Text) & "'" _
                                & ",Required = '" & Trim(required) & "'" _
                                & ",Remarks = '" & Trim(Remarks_TSettings.Text) & "'" _
                                & " where GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'"

                                CNN.Execute(UPD_QUERY)

                                MsgBox("Record has been successfully updated...", , "::: Settings ::")

                            End If


                        Else

                            INS_QUERY = "insert into BCDMIS..F_TourCode(GlobalCustNo,LocalCustNo,CODs,Required, Remarks)" _
                                        & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboCOD.Text) & "','" & Trim(required) & "','" & Trim(Remarks_TSettings.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")


                        End If
                    End With

                    RS.Close()

                End If



                If Trim(cboDataField.Text) = "Department No" Then

                    CHECK_RS()

                    SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_DepartmentNo where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                    RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With RS

                        If Not RS.EOF Then

                            replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                            If replyRes = MsgBoxResult.Yes Then

                                UPD_QUERY = "update BCDMIS..F_DepartmentNo set " _
                                & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                & ",CODs = '" & Trim(cboCOD.Text) & "'" _
                                & ",Required = '" & Trim(required) & "'" _
                                & ",Remarks = '" & Trim(Remarks_TSettings.Text) & "'" _
                                & " where GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'"

                                CNN.Execute(UPD_QUERY)

                                MsgBox("Record has been successfully updated...", , "::: Settings ::")

                            End If


                        Else

                            INS_QUERY = "insert into BCDMIS..F_DepartmentNo(GlobalCustNo,LocalCustNo,CODs,Required, Remarks)" _
                                        & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboCOD.Text) & "','" & Trim(required) & "','" & Trim(Remarks_TSettings.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")


                        End If

                    End With
                    RS.Close()

                End If



                If Trim(cboDataField.Text) = "Employee No" Then

                    CHECK_RS()

                    SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_EmployeeNo where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                    RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With RS

                        If Not RS.EOF Then

                            replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                            If replyRes = MsgBoxResult.Yes Then

                                UPD_QUERY = "update BCDMIS..F_EmployeeNo set " _
                                & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                & ",CODs = '" & Trim(cboCOD.Text) & "'" _
                                & ",Required = '" & Trim(required) & "'" _
                                & ",Remarks = '" & Trim(Remarks_TSettings.Text) & "'" _
                                & " where GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'"

                                CNN.Execute(UPD_QUERY)

                                MsgBox("Record has been successfully updated...", , "::: Settings ::")

                            End If


                        Else

                            INS_QUERY = "insert into BCDMIS..F_EmployeeNo(GlobalCustNo,LocalCustNo,CODs,Required, Remarks)" _
                                        & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboCOD.Text) & "','" & Trim(required) & "','" & Trim(Remarks_TSettings.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")


                        End If

                    End With
                    RS.Close()

                End If


                If Trim(cboDataField.Text) = "Manager Superior" Then

                    CHECK_RS()

                    SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_MgrSuperior where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                    RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With RS

                        If Not RS.EOF Then

                            replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                            If replyRes = MsgBoxResult.Yes Then

                                UPD_QUERY = "update BCDMIS..F_MgrSuperior set " _
                                & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                & ",CODs = '" & Trim(cboCOD.Text) & "'" _
                                & ",Required = '" & Trim(required) & "'" _
                                & ",Remarks = '" & Trim(Remarks_TSettings.Text) & "'" _
                                & " where GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'"

                                CNN.Execute(UPD_QUERY)

                                MsgBox("Record has been successfully updated...", , "::: Settings ::")

                            End If


                        Else

                            INS_QUERY = "insert into BCDMIS..F_MgrSuperior(GlobalCustNo,LocalCustNo,CODs,Required, Remarks)" _
                                        & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboCOD.Text) & "','" & Trim(required) & "','" & Trim(Remarks_TSettings.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")


                        End If

                    End With
                    RS.Close()

                End If



                If Trim(cboDataField.Text) = "Order Reference" Then

                    CHECK_RS()

                    SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_OrderReference where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                    RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With RS

                        If Not RS.EOF Then

                            replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                            If replyRes = MsgBoxResult.Yes Then

                                UPD_QUERY = "update BCDMIS..F_OrderReference set " _
                                & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                & ",CODs = '" & Trim(cboCOD.Text) & "'" _
                                & ",Required = '" & Trim(required) & "'" _
                                & ",Remarks = '" & Trim(Remarks_TSettings.Text) & "'" _
                                & " where GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'"

                                CNN.Execute(UPD_QUERY)

                                MsgBox("Record has been successfully updated...", , "::: Settings ::")

                            End If


                        Else

                            INS_QUERY = "insert into BCDMIS..F_OrderReference(GlobalCustNo,LocalCustNo,CODs,Required, Remarks)" _
                                        & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboCOD.Text) & "','" & Trim(required) & "','" & Trim(Remarks_TSettings.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")


                        End If

                    End With
                    RS.Close()

                End If



                If Trim(cboDataField.Text) = "Project Number" Then

                    CHECK_RS()

                    SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_ProjectNumber where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                    RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With RS

                        If Not RS.EOF Then

                            replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                            If replyRes = MsgBoxResult.Yes Then

                                UPD_QUERY = "update BCDMIS..F_ProjectNumber set " _
                                & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                & ",CODs = '" & Trim(cboCOD.Text) & "'" _
                                & ",Required = '" & Trim(required) & "'" _
                                & ",Remarks = '" & Trim(Remarks_TSettings.Text) & "'" _
                                & " where GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'"

                                CNN.Execute(UPD_QUERY)

                                MsgBox("Record has been successfully updated...", , "::: Settings ::")

                            End If


                        Else

                            INS_QUERY = "insert into BCDMIS..F_ProjectNumber(GlobalCustNo,LocalCustNo,CODs,Required, Remarks)" _
                                        & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboCOD.Text) & "','" & Trim(required) & "','" & Trim(Remarks_TSettings.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")


                        End If

                    End With
                    RS.Close()

                End If


                If Trim(cboDataField.Text) = "Reason of Trip" Then

                    CHECK_RS()

                    SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_ReasonOfTrip where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                    RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With RS

                        If Not RS.EOF Then

                            replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                            If replyRes = MsgBoxResult.Yes Then

                                UPD_QUERY = "update BCDMIS..F_ReasonOfTrip set " _
                                & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                & ",CODs = '" & Trim(cboCOD.Text) & "'" _
                                & ",Required = '" & Trim(required) & "'" _
                                & ",Remarks = '" & Trim(Remarks_TSettings.Text) & "'" _
                                & " where GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'"

                                CNN.Execute(UPD_QUERY)

                                MsgBox("Record has been successfully updated...", , "::: Settings ::")

                            End If


                        Else

                            INS_QUERY = "insert into BCDMIS..F_ReasonOfTrip(GlobalCustNo,LocalCustNo,CODs,Required, Remarks)" _
                                        & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboCOD.Text) & "','" & Trim(required) & "','" & Trim(Remarks_TSettings.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")


                        End If

                    End With
                    RS.Close()

                End If



                If Trim(cboDataField.Text) = "Reason Code" Then

                    CHECK_RS()

                    SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_ReasonCode where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                    RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With RS

                        If Not RS.EOF Then

                            replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                            If replyRes = MsgBoxResult.Yes Then

                                UPD_QUERY = "update BCDMIS..F_ReasonCode set " _
                                & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                & ",CODs = '" & Trim(cboCOD.Text) & "'" _
                                & ",Required = '" & Trim(required) & "'" _
                                & ",Remarks = '" & Trim(Remarks_TSettings.Text) & "'" _
                                & " where GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'"

                                CNN.Execute(UPD_QUERY)

                                MsgBox("Record has been successfully updated...", , "::: Settings ::")

                            End If


                        Else

                            INS_QUERY = "insert into BCDMIS..F_ReasonCode(GlobalCustNo,LocalCustNo,CODs,Required, Remarks)" _
                                        & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboCOD.Text) & "','" & Trim(required) & "','" & Trim(Remarks_TSettings.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")


                        End If

                    End With
                    RS.Close()

                End If



                If Trim(cboDataField.Text) = "Reason Code Denied" Then

                    CHECK_RS()

                    SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_ReasonCodeDenied where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                    RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With RS

                        If Not RS.EOF Then

                            replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                            If replyRes = MsgBoxResult.Yes Then

                                UPD_QUERY = "update BCDMIS..F_ReasonCodeDenied set " _
                                & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                & ",CODs = '" & Trim(cboCOD.Text) & "'" _
                                & ",Required = '" & Trim(required) & "'" _
                                & ",Remarks = '" & Trim(Remarks_TSettings.Text) & "'" _
                                & " where GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'"

                                CNN.Execute(UPD_QUERY)

                                MsgBox("Record has been successfully updated...", , "::: Settings ::")

                            End If


                        Else

                            INS_QUERY = "insert into BCDMIS..F_ReasonCodeDenied(GlobalCustNo,LocalCustNo,CODs,Required, Remarks)" _
                                        & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboCOD.Text) & "','" & Trim(required) & "','" & Trim(Remarks_TSettings.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")


                        End If

                    End With
                    RS.Close()

                End If


                If Trim(cboDataField.Text) = "Traveller Status" Then

                    CHECK_RS()

                    SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_TravellerStatus where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                    RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With RS

                        If Not RS.EOF Then

                            replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                            If replyRes = MsgBoxResult.Yes Then

                                UPD_QUERY = "update BCDMIS..F_TravellerStatus set " _
                                & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                & ",CODs = '" & Trim(cboCOD.Text) & "'" _
                                & ",Required = '" & Trim(required) & "'" _
                                & ",Remarks = '" & Trim(Remarks_TSettings.Text) & "'" _
                                & " where GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'"

                                CNN.Execute(UPD_QUERY)

                                MsgBox("Record has been successfully updated...", , "::: Settings ::")

                            End If


                        Else

                            INS_QUERY = "insert into BCDMIS..F_TravellerStatus(GlobalCustNo,LocalCustNo,CODs,Required, Remarks)" _
                                        & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboCOD.Text) & "','" & Trim(required) & "','" & Trim(Remarks_TSettings.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")


                        End If

                    End With
                    RS.Close()

                End If


                If Trim(cboDataField.Text) = "Record Type" Then

                    CHECK_RS()

                    SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_RecordType where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                    RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With RS

                        If Not RS.EOF Then

                            replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                            If replyRes = MsgBoxResult.Yes Then

                                UPD_QUERY = "update BCDMIS..F_RecordType set " _
                                & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                & ",CODs = '" & Trim(cboCOD.Text) & "'" _
                                & ",Required = '" & Trim(required) & "'" _
                                & ",Remarks = '" & Trim(Remarks_TSettings.Text) & "'" _
                                & " where GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'"

                                CNN.Execute(UPD_QUERY)

                                MsgBox("Record has been successfully updated...", , "::: Settings ::")

                            End If


                        Else

                            INS_QUERY = "insert into BCDMIS..F_RecordType(GlobalCustNo,LocalCustNo,CODs,Required, Remarks)" _
                                        & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboCOD.Text) & "','" & Trim(required) & "','" & Trim(Remarks_TSettings.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")


                        End If

                    End With
                    RS.Close()

                End If





                If Trim(cboDataField.Text) = "CS Data 1" Then

                    CHECK_RS()

                    SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_ClientData1 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                    RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With RS

                        If Not RS.EOF Then

                            replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                            If replyRes = MsgBoxResult.Yes Then

                                UPD_QUERY = "update BCDMIS..F_ClientData1 set " _
                                & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                & ",CODs = '" & Trim(cboCOD.Text) & "'" _
                                & ",Required = '" & Trim(required) & "'" _
                                & ",Remarks = '" & Trim(Remarks_TSettings.Text) & "'" _
                                & " where GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'"

                                CNN.Execute(UPD_QUERY)

                                MsgBox("Record has been successfully updated...", , "::: Settings ::")

                            End If


                        Else

                            INS_QUERY = "insert into BCDMIS..F_ClientData1(GlobalCustNo,LocalCustNo,CODs,Required, Remarks)" _
                                        & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboCOD.Text) & "','" & Trim(required) & "','" & Trim(Remarks_TSettings.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")


                        End If

                    End With

                    RS.Close()
                End If


                If Trim(cboDataField.Text) = "CS Data 2" Then

                    CHECK_RS()

                    SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_ClientData2 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                    RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With RS

                        If Not RS.EOF Then

                            replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                            If replyRes = MsgBoxResult.Yes Then

                                UPD_QUERY = "update BCDMIS..F_ClientData2 set " _
                                & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                & ",CODs = '" & Trim(cboCOD.Text) & "'" _
                                & ",Required = '" & Trim(required) & "'" _
                                & ",Remarks = '" & Trim(Remarks_TSettings.Text) & "'" _
                                & " where GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'"

                                CNN.Execute(UPD_QUERY)

                                MsgBox("Record has been successfully updated...", , "::: Settings ::")

                            End If


                        Else

                            INS_QUERY = "insert into BCDMIS..F_ClientData2(GlobalCustNo,LocalCustNo,CODs,Required, Remarks)" _
                                        & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboCOD.Text) & "','" & Trim(required) & "','" & Trim(Remarks_TSettings.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")


                        End If

                    End With

                    RS.Close()
                End If



                If Trim(cboDataField.Text) = "CS Data 3" Then

                    CHECK_RS()

                    SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_ClientData3 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                    RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With RS

                        If Not RS.EOF Then

                            replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                            If replyRes = MsgBoxResult.Yes Then

                                UPD_QUERY = "update BCDMIS..F_ClientData3 set " _
                                & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                & ",CODs = '" & Trim(cboCOD.Text) & "'" _
                                & ",Required = '" & Trim(required) & "'" _
                                & ",Remarks = '" & Trim(Remarks_TSettings.Text) & "'" _
                                & " where GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'"

                                CNN.Execute(UPD_QUERY)

                                MsgBox("Record has been successfully updated...", , "::: Settings ::")

                            End If


                        Else

                            INS_QUERY = "insert into BCDMIS..F_ClientData3(GlobalCustNo,LocalCustNo,CODs,Required, Remarks)" _
                                        & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboCOD.Text) & "','" & Trim(required) & "','" & Trim(Remarks_TSettings.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")


                        End If

                    End With
                    RS.Close()

                End If


                If Trim(cboDataField.Text) = "CS Data 4" Then

                    CHECK_RS()

                    SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_ClientData4 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                    RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With RS

                        If Not RS.EOF Then

                            replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                            If replyRes = MsgBoxResult.Yes Then

                                UPD_QUERY = "update BCDMIS..F_ClientData4 set " _
                                & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                & ",CODs = '" & Trim(cboCOD.Text) & "'" _
                                & ",Required = '" & Trim(required) & "'" _
                                & ",Remarks = '" & Trim(Remarks_TSettings.Text) & "'" _
                                & " where GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'"

                                CNN.Execute(UPD_QUERY)

                                MsgBox("Record has been successfully updated...", , "::: Settings ::")

                            End If


                        Else

                            INS_QUERY = "insert into BCDMIS..F_ClientData4(GlobalCustNo,LocalCustNo,CODs,Required, Remarks)" _
                                        & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboCOD.Text) & "','" & Trim(required) & "','" & Trim(Remarks_TSettings.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")

                        End If

                    End With

                    RS.Close()
                End If





                If Trim(cboDataField.Text) = "CS Data 5" Then

                    CHECK_RS()

                    SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_ClientData5 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                    RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With RS

                        If Not RS.EOF Then

                            replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                            If replyRes = MsgBoxResult.Yes Then

                                UPD_QUERY = "update BCDMIS..F_ClientData5 set " _
                                & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                & ",CODs = '" & Trim(cboCOD.Text) & "'" _
                                & ",Required = '" & Trim(required) & "'" _
                                & ",Remarks = '" & Trim(Remarks_TSettings.Text) & "'" _
                                & " where GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'"

                                CNN.Execute(UPD_QUERY)

                                MsgBox("Record has been successfully updated...", , "::: Settings ::")

                            End If


                        Else

                            INS_QUERY = "insert into BCDMIS..F_ClientData5(GlobalCustNo,LocalCustNo,CODs,Required, Remarks)" _
                                        & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboCOD.Text) & "','" & Trim(required) & "','" & Trim(Remarks_TSettings.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")

                        End If

                    End With

                    RS.Close()
                End If




                If Trim(cboDataField.Text) = "CS Data 6" Then

                    CHECK_RS()

                    SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_ClientData6 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                    RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With RS

                        If Not RS.EOF Then

                            replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                            If replyRes = MsgBoxResult.Yes Then

                                UPD_QUERY = "update BCDMIS..F_ClientData6 set " _
                                & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                & ",CODs = '" & Trim(cboCOD.Text) & "'" _
                                & ",Required = '" & Trim(required) & "'" _
                                & ",Remarks = '" & Trim(Remarks_TSettings.Text) & "'" _
                                & " where GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'"

                                CNN.Execute(UPD_QUERY)

                                MsgBox("Record has been successfully updated...", , "::: Settings ::")

                            End If


                        Else

                            INS_QUERY = "insert into BCDMIS..F_ClientData6(GlobalCustNo,LocalCustNo,CODs,Required, Remarks)" _
                                        & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboCOD.Text) & "','" & Trim(required) & "','" & Trim(Remarks_TSettings.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")

                        End If

                    End With

                    RS.Close()
                End If




                If Trim(cboDataField.Text) = "CS Data 7" Then

                    CHECK_RS()

                    SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_ClientData7 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                    RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With RS

                        If Not RS.EOF Then

                            replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                            If replyRes = MsgBoxResult.Yes Then

                                UPD_QUERY = "update BCDMIS..F_ClientData7 set " _
                                & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                & ",CODs = '" & Trim(cboCOD.Text) & "'" _
                                & ",Required = '" & Trim(required) & "'" _
                                & ",Remarks = '" & Trim(Remarks_TSettings.Text) & "'" _
                                & " where GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'"

                                CNN.Execute(UPD_QUERY)

                                MsgBox("Record has been successfully updated...", , "::: Settings ::")

                            End If


                        Else

                            INS_QUERY = "insert into BCDMIS..F_ClientData7(GlobalCustNo,LocalCustNo,CODs,Required, Remarks)" _
                                        & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboCOD.Text) & "','" & Trim(required) & "','" & Trim(Remarks_TSettings.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")

                        End If

                    End With

                    RS.Close()
                End If





                If Trim(cboDataField.Text) = "CS Data 8" Then

                    CHECK_RS()

                    SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_ClientData8 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                    RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With RS

                        If Not RS.EOF Then

                            replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                            If replyRes = MsgBoxResult.Yes Then

                                UPD_QUERY = "update BCDMIS..F_ClientData8 set " _
                                & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                & ",CODs = '" & Trim(cboCOD.Text) & "'" _
                                & ",Required = '" & Trim(required) & "'" _
                                & ",Remarks = '" & Trim(Remarks_TSettings.Text) & "'" _
                                & " where GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'"

                                CNN.Execute(UPD_QUERY)

                                MsgBox("Record has been successfully updated...", , "::: Settings ::")

                            End If


                        Else

                            INS_QUERY = "insert into BCDMIS..F_ClientData8(GlobalCustNo,LocalCustNo,CODs,Required, Remarks)" _
                                        & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboCOD.Text) & "','" & Trim(required) & "','" & Trim(Remarks_TSettings.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")

                        End If

                    End With

                    RS.Close()
                End If




                If Trim(cboDataField.Text) = "CS Data 12" Then

                    CHECK_RS()

                    SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_ClientData12 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                    RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With RS

                        If Not RS.EOF Then

                            replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                            If replyRes = MsgBoxResult.Yes Then

                                UPD_QUERY = "update BCDMIS..F_ClientData12 set " _
                                & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                & ",CODs = '" & Trim(cboCOD.Text) & "'" _
                                & ",Required = '" & Trim(required) & "'" _
                                & ",Remarks = '" & Trim(Remarks_TSettings.Text) & "'" _
                                & " where GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'"

                                CNN.Execute(UPD_QUERY)

                                MsgBox("Record has been successfully updated...", , "::: Settings ::")

                            End If


                        Else

                            INS_QUERY = "insert into BCDMIS..F_ClientData12(GlobalCustNo,LocalCustNo,CODs,Required, Remarks)" _
                                        & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboCOD.Text) & "','" & Trim(required) & "','" & Trim(Remarks_TSettings.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")

                        End If

                    End With

                    RS.Close()
                End If




                If Trim(cboDataField.Text) = "Customer Spec Low Fare" Then

                    CHECK_RS()

                    SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_CustoSpecLowFare where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                    RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With RS

                        If Not RS.EOF Then

                            replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                            If replyRes = MsgBoxResult.Yes Then

                                UPD_QUERY = "update BCDMIS..F_CustoSpecLowFare set " _
                                & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                & ",CODs = '" & Trim(cboCOD.Text) & "'" _
                                & ",Required = '" & Trim(required) & "'" _
                                & ",Remarks = '" & Trim(Remarks_TSettings.Text) & "'" _
                                & " where GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'"

                                CNN.Execute(UPD_QUERY)

                                MsgBox("Record has been successfully updated...", , "::: Settings ::")

                            End If


                        Else

                            INS_QUERY = "insert into BCDMIS..F_CustoSpecLowFare(GlobalCustNo,LocalCustNo,CODs,Required, Remarks)" _
                                        & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboCOD.Text) & "','" & Trim(required) & "','" & Trim(Remarks_TSettings.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")

                        End If

                    End With

                    RS.Close()
                End If

                '==Customer Spec Reference Fare Amount

                If Trim(cboDataField.Text) = "Customer Spec Reference Fare Amount" Then

                    CHECK_RS()

                    SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_CustomerSpecRefFareAmount where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                    RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With RS

                        If Not RS.EOF Then

                            replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                            If replyRes = MsgBoxResult.Yes Then

                                UPD_QUERY = "update BCDMIS..F_CustomerSpecRefFareAmount set " _
                                & " GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'" _
                                & ",LocalCustNo = '" & Trim(cboLocalCust.Text) & "'" _
                                & ",CODs = '" & Trim(cboCOD.Text) & "'" _
                                & ",Required = '" & Trim(required) & "'" _
                                & ",Remarks = '" & Trim(Remarks_TSettings.Text) & "'" _
                                & " where GlobalCustNo = '" & Trim(cboGlobalCust.Text) & "'"

                                CNN.Execute(UPD_QUERY)

                                MsgBox("Record has been successfully updated...", , "::: Settings ::")

                            End If


                        Else

                            INS_QUERY = "insert into BCDMIS..F_CustomerSpecRefFareAmount(GlobalCustNo,LocalCustNo,CODs,Required, Remarks)" _
                                        & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboLocalCust.Text) & "','" & Trim(cboCOD.Text) & "','" & Trim(required) & "','" & Trim(Remarks_TSettings.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")

                        End If

                    End With

                    RS.Close()
                End If




            Else
                Exit Sub

            End If
        Else
            MsgBox("Incomplete Details...", , "::: Settings::")


        End If









    End Sub

    Private Sub cboCOD_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCOD.DropDown

        cboCOD.Items.Clear()

        cboCOD.Items.Add("COD1")
        cboCOD.Items.Add("COD2")
        cboCOD.Items.Add("COD3")
        cboCOD.Items.Add("COD4")
        cboCOD.Items.Add("COD5")
        cboCOD.Items.Add("COD6")
        cboCOD.Items.Add("COD7")
        cboCOD.Items.Add("COD8")
        cboCOD.Items.Add("COD9")
        cboCOD.Items.Add("COD10")
        cboCOD.Items.Add("COD11")
        cboCOD.Items.Add("COD12")
        cboCOD.Items.Add("COD13")
        cboCOD.Items.Add("COD14")
        cboCOD.Items.Add("COD15")
        cboCOD.Items.Add("COD16")
        cboCOD.Items.Add("COD17")
        cboCOD.Items.Add("COD18")
        cboCOD.Items.Add("COD19")
        cboCOD.Items.Add("COD20")


    End Sub


    Private Sub cboDataField_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDataField.DropDown

        cboDataField.Items.Clear()

        cboDataField.Items.Add("Accomodatation Reason Code")
        cboDataField.Items.Add("Approval Code")
        cboDataField.Items.Add("Approver")
        cboDataField.Items.Add("Cost Center")
        cboDataField.Items.Add("Car Booked Flag")
        cboDataField.Items.Add("CS Data 1")
        cboDataField.Items.Add("CS Data 2")
        cboDataField.Items.Add("CS Data 3")
        cboDataField.Items.Add("CS Data 4")
        cboDataField.Items.Add("CS Data 5")
        cboDataField.Items.Add("CS Data 6")
        cboDataField.Items.Add("CS Data 7")
        cboDataField.Items.Add("CS Data 8")
        cboDataField.Items.Add("CS Data 12")
        cboDataField.Items.Add("Customer Spec Low Fare")
        cboDataField.Items.Add("Customer Spec Reference Fare Amount")
        cboDataField.Items.Add("Department No")
        cboDataField.Items.Add("Employee No")
        cboDataField.Items.Add("Full Fare")
        cboDataField.Items.Add("Hotel Booked Flag")
        cboDataField.Items.Add("Hotel Reason Code")
        cboDataField.Items.Add("Low Fare")
        cboDataField.Items.Add("Major Class")
        cboDataField.Items.Add("Manager Superior")
        cboDataField.Items.Add("Order Reference")
        cboDataField.Items.Add("Project Number")
        cboDataField.Items.Add("Reason of Trip")
        cboDataField.Items.Add("Reason Code")
        cboDataField.Items.Add("Reason Code Denied")
        cboDataField.Items.Add("Record Type")
        cboDataField.Items.Add("Sales Channel")
        cboDataField.Items.Add("Stop Over Flag")
        cboDataField.Items.Add("Tour Code")
        cboDataField.Items.Add("Traveller Status")



    End Sub


    Private Sub btnDelete_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete_Set.Click

        If Trim(cboDataField.Text) = "Low Fare" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_LowFare where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then

                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_LowFare where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If

                End If

            End With
            RS.Close()
        End If

        If Trim(cboDataField.Text) = "Full Fare" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_ReferenceFare where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then

                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_ReferenceFare where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If

                End If

            End With
            RS.Close()
        End If


        If Trim(cboDataField.Text) = "Customer Spec Low Fare" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_CustoSpecLowFareD where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then

                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_CustoSpecLowFare where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If

                End If

            End With
            RS.Close()
        End If

        If Trim(cboDataField.Text) = "Customer Spec Reference Fare Amount" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_CustomerSpecRefFareAmount where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then

                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_CustomerSpecRefFareAmount where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If

                End If

            End With
            RS.Close()
        End If

        If Trim(cboDataField.Text) = "Accomodatation Reason Code" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_AccomodationReasonCD where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then

                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_AccomodationReasonCD where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If

                End If

            End With
            RS.Close()
        End If


        If Trim(cboDataField.Text) = "Approval Code" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_ApprovalCode where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then

                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_ApprovalCode where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If


                End If

            End With
            RS.Close()

        End If


        If Trim(cboDataField.Text) = "Approver" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_Approver where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then

                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_Approver where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If


                End If

            End With
            RS.Close()

        End If

        If Trim(cboDataField.Text) = "Car Booked Flag" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_CarBookedFlag where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then

                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_CarBookedFlag where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If

                End If

            End With
            RS.Close()
        End If


        If Trim(cboDataField.Text) = "CS Data 1" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_ClientData1 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_ClientData1 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If
                End If



            End With
            RS.Close()

        End If


        If Trim(cboDataField.Text) = "CS Data 2" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_ClientData2 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_ClientData2 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If
                End If



            End With
            RS.Close()

        End If


        If Trim(cboDataField.Text) = "CS Data 3" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_ClientData3 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_ClientData3 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If
                End If


            End With
            RS.Close()

        End If


        If Trim(cboDataField.Text) = "CS Data 4" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_ClientData4 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_ClientData4 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If

                End If

            End With
            RS.Close()
        End If



        If Trim(cboDataField.Text) = "CS Data 5" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_ClientData5 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_ClientData5 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If

                End If

            End With
            RS.Close()
        End If




        If Trim(cboDataField.Text) = "CS Data 6" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_ClientData6 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_ClientData6 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If

                End If

            End With
            RS.Close()
        End If

        If Trim(cboDataField.Text) = "CS Data 7" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_ClientData7 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_ClientData7 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If

                End If

            End With
            RS.Close()
        End If


        If Trim(cboDataField.Text) = "CS Data 8" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_ClientData8 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_ClientData8 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If

                End If

            End With
            RS.Close()
        End If





        If Trim(cboDataField.Text) = "CS Data 12" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_ClientData12 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_ClientData12 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If

                End If

            End With
            RS.Close()
        End If



        If Trim(cboDataField.Text) = "Cost Center" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_CostCenterCode where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then

                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_CostCenterCode where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If


                End If

            End With

            RS.Close()

        End If

        If Trim(cboDataField.Text) = "Department No" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_DepartmentNo where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_DepartmentNo where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If

                End If


            End With
            RS.Close()

        End If



        If Trim(cboDataField.Text) = "Employee No" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_EmployeeNo where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_EmployeeNo where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If
                End If


            End With
            RS.Close()

        End If

        If Trim(cboDataField.Text) = "Hotel Booked Flag" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_HotelBookedFlag where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then

                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_HotelBookedFlag where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If

                End If

            End With
            RS.Close()
        End If



        If Trim(cboDataField.Text) = "Hotel Reason Code" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_HotelReasonCode where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then

                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_HotelReasonCode where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If

                End If

            End With
            RS.Close()
        End If




        If Trim(cboDataField.Text) = "Major Class" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_MajorClass where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then

                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_MajorClass where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If


                End If

            End With
            RS.Close()

        End If


        If Trim(cboDataField.Text) = "Manager Superior" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_MgrSuperior where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_MgrSuperior where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "' "
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If
                End If


            End With
            RS.Close()

        End If


        If Trim(cboDataField.Text) = "Order Reference" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_OrderReference where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_OrderReference where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If
                End If

            End With
            RS.Close()

        End If



        If Trim(cboDataField.Text) = "Project Number" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_ProjectNumber where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_ProjectNumber where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "' "
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If
                End If


            End With
            RS.Close()

        End If





        If Trim(cboDataField.Text) = "Reason Code" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNo from BCDMIS..F_ReasonCode where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_ReasonCode where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If
                End If


            End With
            RS.Close()

        End If

        If Trim(cboDataField.Text) = "Reason Code Denied" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_ReasonCodeDenied where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_ReasonCodeDenied where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If
                End If


            End With
            RS.Close()

        End If


        If Trim(cboDataField.Text) = "Reason of Trip" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_ReasonOfTrip where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "' "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_ReasonOfTrip where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "' "
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If
                End If


            End With
            RS.Close()

        End If



        If Trim(cboDataField.Text) = "Record Type" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNofrom BCDMIS..F_RecordType where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_RecordType where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If
                End If


            End With
            RS.Close()

        End If


        If Trim(cboDataField.Text) = "Sales Channel" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNofrom BCDMIS..F_SalesChannel where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_SalesChannel where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If
                End If


            End With
            RS.Close()

        End If




        If Trim(cboDataField.Text) = "Stop Over Flag" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNofrom BCDMIS..F_StopOverFlag where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_StopOverFlag where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If
                End If


            End With
            RS.Close()

        End If



        If Trim(cboDataField.Text) = "Tour Code" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNofrom BCDMIS..F_TourCode where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_TourCode where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If
                End If


            End With
            RS.Close()

        End If



        If Trim(cboDataField.Text) = "Traveller Status" Then

            CHECK_RS()

            SQL_QUERY = "Select GlobalCustNo, LocalCustNo from BCDMIS..F_TravellerStatus where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    res = MsgBox(" Delete Settings ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                        DEL_QUERY = "Delete from BCDMIS..F_TravellerStatus where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        cboDataField.Text = Nothing
                        rdTableSettings_M.Checked = False
                        rdTableSettings_O.Checked = False
                        cboCOD.Text = Nothing
                        Remarks_TSettings.Text = Nothing

                    Else
                        Exit Sub
                    End If
                End If


            End With
            RS.Close()

        End If



    End Sub

    Public Sub cboDataField_keydown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboDataField.KeyDown

        rdTableSettings_M.Checked = False
        rdTableSettings_O.Checked = False
        rdTableSettings_C.Checked = False
        Remarks_TSettings.Text = Nothing


    End Sub


    Private Sub cboDataField_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDataField.SelectedIndexChanged

        rdTableSettings_M.Checked = False
        rdTableSettings_O.Checked = False
        rdTableSettings_C.Checked = False

        cboCOD.Text = Nothing
        Remarks_TSettings.Text = Nothing

        If Trim(cboDataField.Text) = "Low Fare" Then

            CHECK_RS()

            SQL_QUERY = "Select * from BCDMIS..F_LowFare where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'" ' and LocalCustNo='" & Trim(cboLocalCust.Text) & "' "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then

                    If Trim((RS.Fields("Required").Value).ToString()) = "Mandatory" Then
                        rdTableSettings_M.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Optional" Then
                        rdTableSettings_O.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Conditional" Then
                        rdTableSettings_C.Checked = True
                    End If


                    If Not IsDBNull(Trim((RS.Fields("CODs").Value).ToString())) Then
                        cboCOD.Text = Trim((RS.Fields("CODs").Value)).ToString()
                    End If

                    If Not IsDBNull(Trim((RS.Fields("Remarks").Value).ToString())) Then
                        Remarks_TSettings.Text = Trim((RS.Fields("Remarks").Value)).ToString()
                    End If



                End If

            End With

            RS.Close()

        End If


        If Trim(cboDataField.Text) = "Full Fare" Then

            CHECK_RS()

            SQL_QUERY = "Select * from BCDMIS..F_ReferenceFare where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'" ' and LocalCustNo='" & Trim(cboLocalCust.Text) & "' "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then

                    If Trim((RS.Fields("Required").Value).ToString()) = "Mandatory" Then
                        rdTableSettings_M.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Optional" Then
                        rdTableSettings_O.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Conditional" Then
                        rdTableSettings_C.Checked = True
                    End If


                    If Not IsDBNull(Trim((RS.Fields("CODs").Value).ToString())) Then
                        cboCOD.Text = Trim((RS.Fields("CODs").Value)).ToString()
                    End If

                    If Not IsDBNull(Trim((RS.Fields("Remarks").Value).ToString())) Then
                        Remarks_TSettings.Text = Trim((RS.Fields("Remarks").Value)).ToString()
                    End If



                End If

            End With

            RS.Close()

        End If

        If Trim(cboDataField.Text) = "Customer Spec Low Fare" Then

            CHECK_RS()

            SQL_QUERY = "Select * from BCDMIS..F_CustoSpecLowFare where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'" ' and LocalCustNo='" & Trim(cboLocalCust.Text) & "' "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then

                    If Trim((RS.Fields("Required").Value).ToString()) = "Mandatory" Then
                        rdTableSettings_M.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Optional" Then
                        rdTableSettings_O.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Conditional" Then
                        rdTableSettings_C.Checked = True
                    End If


                    If Not IsDBNull(Trim((RS.Fields("CODs").Value).ToString())) Then
                        cboCOD.Text = Trim((RS.Fields("CODs").Value)).ToString()
                    End If

                    If Not IsDBNull(Trim((RS.Fields("Remarks").Value).ToString())) Then
                        Remarks_TSettings.Text = Trim((RS.Fields("Remarks").Value)).ToString()
                    End If



                End If

            End With

            RS.Close()

        End If

        If Trim(cboDataField.Text) = "Customer Spec Reference Fare Amount" Then

            CHECK_RS()

            SQL_QUERY = "Select * from BCDMIS..F_CustomerSpecRefFareAmount where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'" ' and LocalCustNo='" & Trim(cboLocalCust.Text) & "' "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then

                    If Trim((RS.Fields("Required").Value).ToString()) = "Mandatory" Then
                        rdTableSettings_M.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Optional" Then
                        rdTableSettings_O.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Conditional" Then
                        rdTableSettings_C.Checked = True
                    End If


                    If Not IsDBNull(Trim((RS.Fields("CODs").Value).ToString())) Then
                        cboCOD.Text = Trim((RS.Fields("CODs").Value)).ToString()
                    End If

                    If Not IsDBNull(Trim((RS.Fields("Remarks").Value).ToString())) Then
                        Remarks_TSettings.Text = Trim((RS.Fields("Remarks").Value)).ToString()
                    End If



                End If

            End With

            RS.Close()

        End If




        If Trim(cboDataField.Text) = "Accomodatation Reason Code" Then

            CHECK_RS()

            SQL_QUERY = "Select * from BCDMIS..F_AccomodationReasonCD where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'" ' and LocalCustNo='" & Trim(cboLocalCust.Text) & "' "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then

                    If Trim((RS.Fields("Required").Value).ToString()) = "Mandatory" Then
                        rdTableSettings_M.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Optional" Then
                        rdTableSettings_O.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Conditional" Then
                        rdTableSettings_C.Checked = True
                    End If


                    If Not IsDBNull(Trim((RS.Fields("CODs").Value).ToString())) Then
                        cboCOD.Text = Trim((RS.Fields("CODs").Value)).ToString()
                    End If

                    If Not IsDBNull(Trim((RS.Fields("Remarks").Value).ToString())) Then
                        Remarks_TSettings.Text = Trim((RS.Fields("Remarks").Value)).ToString()
                    End If



                End If

            End With

            RS.Close()

        End If



        If Trim(cboDataField.Text) = "Approval Code" Then

            CHECK_RS()

            SQL_QUERY = "Select * from BCDMIS..F_ApprovalCode where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'" ' and LocalCustNo='" & Trim(cboLocalCust.Text) & "' "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    If Trim((RS.Fields("Required").Value).ToString()) = "Mandatory" Then
                        rdTableSettings_M.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Optional" Then
                        rdTableSettings_O.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Conditional" Then
                        rdTableSettings_C.Checked = True
                    End If



                    If Not IsDBNull(Trim((RS.Fields("CODs").Value).ToString())) Then
                        cboCOD.Text = Trim((RS.Fields("CODs").Value)).ToString()
                    End If

                    If Not IsDBNull(Trim((RS.Fields("Remarks").Value).ToString())) Then
                        Remarks_TSettings.Text = Trim((RS.Fields("Remarks").Value)).ToString()
                    End If

                End If

            End With


        End If


        If Trim(cboDataField.Text) = "Approver" Then

            CHECK_RS()

            SQL_QUERY = "Select * from BCDMIS..F_Approver where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'" '"'  and LocalCustNo='" & Trim(cboLocalCust.Text) & "' "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    If Trim((RS.Fields("Required").Value).ToString()) = "Mandatory" Then
                        rdTableSettings_M.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Optional" Then
                        rdTableSettings_O.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Conditional" Then
                        rdTableSettings_C.Checked = True
                    End If


                    If Not IsDBNull(Trim((RS.Fields("CODs").Value).ToString())) Then
                        cboCOD.Text = Trim((RS.Fields("CODs").Value)).ToString()
                    End If

                    If Not IsDBNull(Trim((RS.Fields("Remarks").Value).ToString())) Then
                        Remarks_TSettings.Text = Trim((RS.Fields("Remarks").Value)).ToString()
                    End If

                End If

            End With


        End If

        If Trim(cboDataField.Text) = "Cost Center" Then

            CHECK_RS()

            SQL_QUERY = "Select * from BCDMIS..F_CostCenterCode where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'" ' and LocalCustNo='" & Trim(cboLocalCust.Text) & "' "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then

                    If Trim((RS.Fields("Required").Value).ToString()) = "Mandatory" Then
                        rdTableSettings_M.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Optional" Then
                        rdTableSettings_O.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Conditional" Then
                        rdTableSettings_C.Checked = True
                    End If


                    If Not IsDBNull(Trim((RS.Fields("CODs").Value).ToString())) Then
                        cboCOD.Text = Trim((RS.Fields("CODs").Value)).ToString()
                    End If

                    If Not IsDBNull(Trim((RS.Fields("Remarks").Value).ToString())) Then
                        Remarks_TSettings.Text = Trim((RS.Fields("Remarks").Value)).ToString()
                    End If

                End If

            End With


        End If


        If Trim(cboDataField.Text) = "Department No" Then

            CHECK_RS()

            SQL_QUERY = "Select * from BCDMIS..F_DepartmentNo where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'" ' and LocalCustNo='" & Trim(cboLocalCust.Text) & "' "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then

                    If Trim((RS.Fields("Required").Value).ToString()) = "Mandatory" Then
                        rdTableSettings_M.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Optional" Then
                        rdTableSettings_O.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Conditional" Then
                        rdTableSettings_C.Checked = True
                    End If


                    If Not IsDBNull(Trim((RS.Fields("CODs").Value).ToString())) Then
                        cboCOD.Text = Trim((RS.Fields("CODs").Value)).ToString()
                    End If

                    If Not IsDBNull(Trim((RS.Fields("Remarks").Value).ToString())) Then
                        Remarks_TSettings.Text = Trim((RS.Fields("Remarks").Value)).ToString()
                    End If

                End If

            End With

        End If



        If Trim(cboDataField.Text) = "Employee No" Then

            CHECK_RS()

            SQL_QUERY = "Select * from BCDMIS..F_EmployeeNo where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'" ' and LocalCustNo='" & Trim(cboLocalCust.Text) & "' "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    If Trim((RS.Fields("Required").Value).ToString()) = "Mandatory" Then
                        rdTableSettings_M.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Optional" Then
                        rdTableSettings_O.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Conditional" Then
                        rdTableSettings_C.Checked = True
                    End If

                    If Not IsDBNull(Trim((RS.Fields("CODs").Value).ToString())) Then
                        cboCOD.Text = Trim((RS.Fields("CODs").Value)).ToString()
                    End If

                    If Not IsDBNull(Trim((RS.Fields("Remarks").Value).ToString())) Then
                        Remarks_TSettings.Text = Trim((RS.Fields("Remarks").Value)).ToString()
                    End If
                End If


            End With


        End If


        If Trim(cboDataField.Text) = "Manager Superior" Then

            CHECK_RS()

            SQL_QUERY = "Select * from BCDMIS..F_MgrSuperior where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'" ' and LocalCustNo='" & Trim(cboLocalCust.Text) & "' "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    If Trim((RS.Fields("Required").Value).ToString()) = "Mandatory" Then
                        rdTableSettings_M.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Optional" Then
                        rdTableSettings_O.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Conditional" Then
                        rdTableSettings_C.Checked = True
                    End If

                    If Not IsDBNull(Trim((RS.Fields("CODs").Value).ToString())) Then
                        cboCOD.Text = Trim((RS.Fields("CODs").Value)).ToString()
                    End If

                    If Not IsDBNull(Trim((RS.Fields("Remarks").Value).ToString())) Then
                        Remarks_TSettings.Text = Trim((RS.Fields("Remarks").Value)).ToString()
                    End If
                End If


            End With


        End If

        If Trim(cboDataField.Text) = "Major Class" Then

            CHECK_RS()

            SQL_QUERY = "Select * from BCDMIS..F_MajorClass where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'" ' and LocalCustNo='" & Trim(cboLocalCust.Text) & "' "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    If Trim((RS.Fields("Required").Value).ToString()) = "Mandatory" Then
                        rdTableSettings_M.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Optional" Then
                        rdTableSettings_O.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Conditional" Then
                        rdTableSettings_C.Checked = True
                    End If
                    If Not IsDBNull(Trim((RS.Fields("CODs").Value).ToString())) Then
                        cboCOD.Text = Trim((RS.Fields("CODs").Value)).ToString()
                    End If

                    If Not IsDBNull(Trim((RS.Fields("Remarks").Value).ToString())) Then
                        Remarks_TSettings.Text = Trim((RS.Fields("Remarks").Value)).ToString()
                    End If
                End If


            End With


        End If




        If Trim(cboDataField.Text) = "Car Booked Flag" Then

            CHECK_RS()

            SQL_QUERY = "Select * from BCDMIS..F_CarBookedFlag where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'" ' and LocalCustNo='" & Trim(cboLocalCust.Text) & "' "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    If Trim((RS.Fields("Required").Value).ToString()) = "Mandatory" Then
                        rdTableSettings_M.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Optional" Then
                        rdTableSettings_O.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Conditional" Then
                        rdTableSettings_C.Checked = True
                    End If
                    If Not IsDBNull(Trim((RS.Fields("CODs").Value).ToString())) Then
                        cboCOD.Text = Trim((RS.Fields("CODs").Value)).ToString()
                    End If

                    If Not IsDBNull(Trim((RS.Fields("Remarks").Value).ToString())) Then
                        Remarks_TSettings.Text = Trim((RS.Fields("Remarks").Value)).ToString()
                    End If
                End If


            End With


        End If




        If Trim(cboDataField.Text) = "Hotel Booked Flag" Then

            CHECK_RS()

            SQL_QUERY = "Select * from BCDMIS..F_HotelBookedFlag where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'" ' and LocalCustNo='" & Trim(cboLocalCust.Text) & "' "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    If Trim((RS.Fields("Required").Value).ToString()) = "Mandatory" Then
                        rdTableSettings_M.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Optional" Then
                        rdTableSettings_O.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Conditional" Then
                        rdTableSettings_C.Checked = True
                    End If

                    If Not IsDBNull(Trim((RS.Fields("CODs").Value).ToString())) Then
                        cboCOD.Text = Trim((RS.Fields("CODs").Value)).ToString()
                    End If

                    If Not IsDBNull(Trim((RS.Fields("Remarks").Value).ToString())) Then
                        Remarks_TSettings.Text = Trim((RS.Fields("Remarks").Value)).ToString()
                    End If
                End If


            End With


        End If



        If Trim(cboDataField.Text) = "Order Reference" Then

            CHECK_RS()

            SQL_QUERY = "Select * from BCDMIS..F_OrderReference where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'" ' and LocalCustNo='" & Trim(cboLocalCust.Text) & "' "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    If Trim((RS.Fields("Required").Value).ToString()) = "Mandatory" Then
                        rdTableSettings_M.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Optional" Then
                        rdTableSettings_O.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Conditional" Then
                        rdTableSettings_C.Checked = True
                    End If

                    If Not IsDBNull(Trim((RS.Fields("CODs").Value).ToString())) Then
                        cboCOD.Text = Trim((RS.Fields("CODs").Value)).ToString()
                    End If

                    If Not IsDBNull(Trim((RS.Fields("Remarks").Value).ToString())) Then
                        Remarks_TSettings.Text = Trim((RS.Fields("Remarks").Value)).ToString()
                    End If
                End If



            End With


        End If



        If Trim(cboDataField.Text) = "Project Number" Then

            CHECK_RS()

            SQL_QUERY = "Select * from BCDMIS..F_ProjectNumber where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'" ' and LocalCustNo='" & Trim(cboLocalCust.Text) & "' "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    If Trim((RS.Fields("Required").Value).ToString()) = "Mandatory" Then
                        rdTableSettings_M.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Optional" Then
                        rdTableSettings_O.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Conditional" Then
                        rdTableSettings_C.Checked = True
                    End If

                    If Not IsDBNull(Trim((RS.Fields("CODs").Value).ToString())) Then
                        cboCOD.Text = Trim((RS.Fields("CODs").Value)).ToString()
                    End If

                    If Not IsDBNull(Trim((RS.Fields("Remarks").Value).ToString())) Then
                        Remarks_TSettings.Text = Trim((RS.Fields("Remarks").Value)).ToString()
                    End If
                End If


            End With


        End If


        If Trim(cboDataField.Text) = "Reason of Trip" Then

            CHECK_RS()

            SQL_QUERY = "Select * from BCDMIS..F_ReasonOfTrip where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'" ' and LocalCustNo='" & Trim(cboLocalCust.Text) & "' "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    If Trim((RS.Fields("Required").Value).ToString()) = "Mandatory" Then
                        rdTableSettings_M.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Optional" Then
                        rdTableSettings_O.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Conditional" Then
                        rdTableSettings_C.Checked = True
                    End If

                    If Not IsDBNull(Trim((RS.Fields("CODs").Value).ToString())) Then
                        cboCOD.Text = Trim((RS.Fields("CODs").Value)).ToString()
                    End If

                    If Not IsDBNull(Trim((RS.Fields("Remarks").Value).ToString())) Then
                        Remarks_TSettings.Text = Trim((RS.Fields("Remarks").Value)).ToString()
                    End If
                End If


            End With


        End If


        If Trim(cboDataField.Text) = "Traveller Status" Then

            CHECK_RS()

            SQL_QUERY = "Select * from BCDMIS..F_TravellerStatus where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'" ' and LocalCustNo='" & Trim(cboLocalCust.Text) & "' "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    If Trim((RS.Fields("Required").Value).ToString()) = "Mandatory" Then
                        rdTableSettings_M.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Optional" Then
                        rdTableSettings_O.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Conditional" Then
                        rdTableSettings_C.Checked = True
                    End If

                    If Not IsDBNull(Trim((RS.Fields("CODs").Value).ToString())) Then
                        cboCOD.Text = Trim((RS.Fields("CODs").Value)).ToString()
                    End If

                    If Not IsDBNull(Trim((RS.Fields("Remarks").Value).ToString())) Then
                        Remarks_TSettings.Text = Trim((RS.Fields("Remarks").Value)).ToString()
                    End If
                End If


            End With


        End If


        If Trim(cboDataField.Text) = "Reason Code" Then

            CHECK_RS()

            SQL_QUERY = "Select * from BCDMIS..F_ReasonCode where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'" ' and LocalCustNo='" & Trim(cboLocalCust.Text) & "' "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    If Trim((RS.Fields("Required").Value).ToString()) = "Mandatory" Then
                        rdTableSettings_M.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Optional" Then
                        rdTableSettings_O.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Conditional" Then
                        rdTableSettings_C.Checked = True
                    End If

                    If Not IsDBNull(Trim((RS.Fields("CODs").Value).ToString())) Then
                        cboCOD.Text = Trim((RS.Fields("CODs").Value)).ToString()
                    End If

                    If Not IsDBNull(Trim((RS.Fields("Remarks").Value).ToString())) Then
                        Remarks_TSettings.Text = Trim((RS.Fields("Remarks").Value)).ToString()
                    End If
                End If


            End With


        End If


        If Trim(cboDataField.Text) = "Reason Code Denied" Then

            CHECK_RS()

            SQL_QUERY = "Select * from BCDMIS..F_ReasonCodeDenied where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'" ' and LocalCustNo='" & Trim(cboLocalCust.Text) & "' "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    If Trim((RS.Fields("Required").Value).ToString()) = "Mandatory" Then
                        rdTableSettings_M.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Optional" Then
                        rdTableSettings_O.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Conditional" Then
                        rdTableSettings_C.Checked = True
                    End If

                    If Not IsDBNull(Trim((RS.Fields("CODs").Value).ToString())) Then
                        cboCOD.Text = Trim((RS.Fields("CODs").Value)).ToString()
                    End If

                    If Not IsDBNull(Trim((RS.Fields("Remarks").Value).ToString())) Then
                        Remarks_TSettings.Text = Trim((RS.Fields("Remarks").Value)).ToString()
                    End If
                End If


            End With


        End If




        If Trim(cboDataField.Text) = "CS Data 1" Then

            CHECK_RS()

            SQL_QUERY = "Select * from BCDMIS..F_ClientData1 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'" ' and LocalCustNo='" & Trim(cboLocalCust.Text) & "' "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    If Trim((RS.Fields("Required").Value).ToString()) = "Mandatory" Then
                        rdTableSettings_M.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Optional" Then
                        rdTableSettings_O.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Conditional" Then
                        rdTableSettings_C.Checked = True
                    End If

                    If Not IsDBNull(Trim((RS.Fields("CODs").Value).ToString())) Then
                        cboCOD.Text = Trim((RS.Fields("CODs").Value)).ToString()
                    End If

                    If Not IsDBNull(Trim((RS.Fields("Remarks").Value).ToString())) Then
                        Remarks_TSettings.Text = Trim((RS.Fields("Remarks").Value)).ToString()
                    End If
                End If



            End With


        End If


        If Trim(cboDataField.Text) = "CS Data 2" Then

            CHECK_RS()

            SQL_QUERY = "Select * from BCDMIS..F_ClientData2 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'" ' and LocalCustNo='" & Trim(cboLocalCust.Text) & "' "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    If Trim((RS.Fields("Required").Value).ToString()) = "Mandatory" Then
                        rdTableSettings_M.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Optional" Then
                        rdTableSettings_O.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Conditional" Then
                        rdTableSettings_C.Checked = True
                    End If

                    If Not IsDBNull(Trim((RS.Fields("CODs").Value).ToString())) Then
                        cboCOD.Text = Trim((RS.Fields("CODs").Value)).ToString()
                    End If

                    If Not IsDBNull(Trim((RS.Fields("Remarks").Value).ToString())) Then
                        Remarks_TSettings.Text = Trim((RS.Fields("Remarks").Value)).ToString()
                    End If
                End If

            End With


        End If


        If Trim(cboDataField.Text) = "CS Data 3" Then

            CHECK_RS()

            SQL_QUERY = "Select * from BCDMIS..F_ClientData3 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'" ' and LocalCustNo='" & Trim(cboLocalCust.Text) & "' "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    If Trim((RS.Fields("Required").Value).ToString()) = "Mandatory" Then
                        rdTableSettings_M.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Optional" Then
                        rdTableSettings_O.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Conditional" Then
                        rdTableSettings_C.Checked = True
                    End If

                    If Not IsDBNull(Trim((RS.Fields("CODs").Value).ToString())) Then
                        cboCOD.Text = Trim((RS.Fields("CODs").Value)).ToString()
                    End If

                    If Not IsDBNull(Trim((RS.Fields("Remarks").Value).ToString())) Then
                        Remarks_TSettings.Text = Trim((RS.Fields("Remarks").Value)).ToString()
                    End If
                End If


            End With


        End If


        If Trim(cboDataField.Text) = "CS Data 4" Then

            CHECK_RS()

            SQL_QUERY = "Select * from BCDMIS..F_ClientData4 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'" ' and LocalCustNo='" & Trim(cboLocalCust.Text) & "' "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    If Trim((RS.Fields("Required").Value).ToString()) = "Mandatory" Then
                        rdTableSettings_M.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Optional" Then
                        rdTableSettings_O.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Conditional" Then
                        rdTableSettings_C.Checked = True
                    End If

                    If Not IsDBNull(Trim((RS.Fields("CODs").Value).ToString())) Then
                        cboCOD.Text = Trim((RS.Fields("CODs").Value)).ToString()
                    End If

                    If Not IsDBNull(Trim((RS.Fields("Remarks").Value).ToString())) Then
                        Remarks_TSettings.Text = Trim((RS.Fields("Remarks").Value)).ToString()
                    End If

                End If

            End With

        End If


        If Trim(cboDataField.Text) = "CS Data 5" Then

            CHECK_RS()

            SQL_QUERY = "Select * from BCDMIS..F_ClientData5 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'" ' and LocalCustNo='" & Trim(cboLocalCust.Text) & "' "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    If Trim((RS.Fields("Required").Value).ToString()) = "Mandatory" Then
                        rdTableSettings_M.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Optional" Then
                        rdTableSettings_O.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Conditional" Then
                        rdTableSettings_C.Checked = True
                    End If

                    If Not IsDBNull(Trim((RS.Fields("CODs").Value).ToString())) Then
                        cboCOD.Text = Trim((RS.Fields("CODs").Value)).ToString()
                    End If

                    If Not IsDBNull(Trim((RS.Fields("Remarks").Value).ToString())) Then
                        Remarks_TSettings.Text = Trim((RS.Fields("Remarks").Value)).ToString()
                    End If

                End If

            End With

        End If



        If Trim(cboDataField.Text) = "CS Data 6" Then

            CHECK_RS()

            SQL_QUERY = "Select * from BCDMIS..F_ClientData6 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'" ' and LocalCustNo='" & Trim(cboLocalCust.Text) & "' "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    If Trim((RS.Fields("Required").Value).ToString()) = "Mandatory" Then
                        rdTableSettings_M.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Optional" Then
                        rdTableSettings_O.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Conditional" Then
                        rdTableSettings_C.Checked = True
                    End If

                    If Not IsDBNull(Trim((RS.Fields("CODs").Value).ToString())) Then
                        cboCOD.Text = Trim((RS.Fields("CODs").Value)).ToString()
                    End If

                    If Not IsDBNull(Trim((RS.Fields("Remarks").Value).ToString())) Then
                        Remarks_TSettings.Text = Trim((RS.Fields("Remarks").Value)).ToString()
                    End If

                End If

            End With

        End If


        If Trim(cboDataField.Text) = "CS Data 7" Then

            CHECK_RS()

            SQL_QUERY = "Select * from BCDMIS..F_ClientData7 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'" ' and LocalCustNo='" & Trim(cboLocalCust.Text) & "' "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    If Trim((RS.Fields("Required").Value).ToString()) = "Mandatory" Then
                        rdTableSettings_M.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Optional" Then
                        rdTableSettings_O.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Conditional" Then
                        rdTableSettings_C.Checked = True
                    End If

                    If Not IsDBNull(Trim((RS.Fields("CODs").Value).ToString())) Then
                        cboCOD.Text = Trim((RS.Fields("CODs").Value)).ToString()
                    End If

                    If Not IsDBNull(Trim((RS.Fields("Remarks").Value).ToString())) Then
                        Remarks_TSettings.Text = Trim((RS.Fields("Remarks").Value)).ToString()
                    End If

                End If

            End With

        End If


        If Trim(cboDataField.Text) = "CS Data 8" Then

            CHECK_RS()

            SQL_QUERY = "Select * from BCDMIS..F_ClientData8 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'" ' and LocalCustNo='" & Trim(cboLocalCust.Text) & "' "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    If Trim((RS.Fields("Required").Value).ToString()) = "Mandatory" Then
                        rdTableSettings_M.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Optional" Then
                        rdTableSettings_O.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Conditional" Then
                        rdTableSettings_C.Checked = True
                    End If

                    If Not IsDBNull(Trim((RS.Fields("CODs").Value).ToString())) Then
                        cboCOD.Text = Trim((RS.Fields("CODs").Value)).ToString()
                    End If

                    If Not IsDBNull(Trim((RS.Fields("Remarks").Value).ToString())) Then
                        Remarks_TSettings.Text = Trim((RS.Fields("Remarks").Value)).ToString()
                    End If

                End If

            End With

        End If


        If Trim(cboDataField.Text) = "CS Data 12" Then

            CHECK_RS()

            SQL_QUERY = "Select * from BCDMIS..F_ClientData12 where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'" ' and LocalCustNo='" & Trim(cboLocalCust.Text) & "' "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    If Trim((RS.Fields("Required").Value).ToString()) = "Mandatory" Then
                        rdTableSettings_M.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Optional" Then
                        rdTableSettings_O.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Conditional" Then
                        rdTableSettings_C.Checked = True
                    End If

                    If Not IsDBNull(Trim((RS.Fields("CODs").Value).ToString())) Then
                        cboCOD.Text = Trim((RS.Fields("CODs").Value)).ToString()
                    End If

                    If Not IsDBNull(Trim((RS.Fields("Remarks").Value).ToString())) Then
                        Remarks_TSettings.Text = Trim((RS.Fields("Remarks").Value)).ToString()
                    End If

                End If

            End With

        End If




        If Trim(cboDataField.Text) = "Customer Spec Low Fare" Then

            CHECK_RS()

            SQL_QUERY = "Select * from BCDMIS..F_CustoSpecLowFare where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'" ' and LocalCustNo='" & Trim(cboLocalCust.Text) & "' "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    If Trim((RS.Fields("Required").Value).ToString()) = "Mandatory" Then
                        rdTableSettings_M.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Optional" Then
                        rdTableSettings_O.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Conditional" Then
                        rdTableSettings_C.Checked = True
                    End If

                    If Not IsDBNull(Trim((RS.Fields("CODs").Value).ToString())) Then
                        cboCOD.Text = Trim((RS.Fields("CODs").Value)).ToString()
                    End If

                    If Not IsDBNull(Trim((RS.Fields("Remarks").Value).ToString())) Then
                        Remarks_TSettings.Text = Trim((RS.Fields("Remarks").Value)).ToString()
                    End If

                End If

            End With

        End If



        'Customer Spec Reference Fare Amount

        If Trim(cboDataField.Text) = "Customer Spec Reference Fare Amount" Then

            CHECK_RS()

            SQL_QUERY = "Select * from BCDMIS..F_CustomerSpecRefFareAmount where GlobalCustNo ='" & Trim(cboGlobalCust.Text) & "'" ' and LocalCustNo='" & Trim(cboLocalCust.Text) & "' "
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    If Trim((RS.Fields("Required").Value).ToString()) = "Mandatory" Then
                        rdTableSettings_M.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Optional" Then
                        rdTableSettings_O.Checked = True
                    End If

                    If Trim((RS.Fields("Required").Value).ToString()) = "Conditional" Then
                        rdTableSettings_C.Checked = True
                    End If

                    If Not IsDBNull(Trim((RS.Fields("CODs").Value).ToString())) Then
                        cboCOD.Text = Trim((RS.Fields("CODs").Value)).ToString()
                    End If

                    If Not IsDBNull(Trim((RS.Fields("Remarks").Value).ToString())) Then
                        Remarks_TSettings.Text = Trim((RS.Fields("Remarks").Value)).ToString()
                    End If

                End If

            End With

        End If

    End Sub





    Private Sub DGW_COD_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGW_COD.CellContentClick

        rdMandatory.Checked = False
        rdOptional.Checked = False
        rdConditional.Checked = False


        Dim strTemp As String

        strTemp = (DGW_COD.Item("GEMS", DGW_COD.CurrentCell.RowIndex).Value.ToString())


        CHECK_RS()

        SQL_QUERY = " Select * from BCDMIS..MIDFields where GEMS = '" & Trim(strTemp) & "' and clientGCN =  '" & Trim(cboGlobalCust.Text) & "'"
        RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        With RS
            If Not RS.EOF Then
                cboDataItem.Text = (RS.Fields("DataItem").Value).ToString()
                cboGems.Text = (RS.Fields("Gems").Value).ToString()
                cboList.Text = (RS.Fields("List").Value).ToString()
                txtLength.Text = (RS.Fields("Length").Value).ToString()
                txtDataType.Text = (RS.Fields("DataType").Value).ToString()
                txtCustomerFieldName.Text = (RS.Fields("CustomerFieldName").Value).ToString()

                If Trim((RS.Fields("Required").Value).ToString()) = "Mandatory" Then
                    rdMandatory.Checked = True
                End If

                If Trim((RS.Fields("Required").Value).ToString()) = "Optional" Then
                    rdOptional.Checked = True
                End If

                If Trim((RS.Fields("Required").Value).ToString()) = "Conditional" Then
                    rdConditional.Checked = True
                End If


                RS.MoveNext()


            End If
            RS.Close()
        End With

    End Sub


    Private Sub btnUpdateMidFields_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateMidFields.Click

        Dim rdM As String = Nothing
        If rdMandatory.Checked = True Then
            rdM = "Mandatory"
        End If

        If rdConditional.Checked = True Then
            rdM = "Conditional"
        End If

        If rdOptional.Checked = True Then
            rdM = "Optional"
        End If



        CHECK_RS()

        SQL_QUERY = "Select * from BCDMIS..MIDFields where GEMS  = '" & Trim(cboGems.Text) & "' and ClientGCN = '" & Trim(cboGlobalCust.Text) & "'"
        RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        With RS

            If Not RS.EOF Then

                res = MsgBox("Do you want to update existing record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                If res = MsgBoxResult.Yes Then

                    UPD_QUERY = "update BCDMIS..MIDFields set " _
                                   & " ClientGCN = '" & Trim(cboGlobalCust.Text) & "'" _
                                   & ",DataItem = '" & Trim(cboDataItem.Text) & "'" _
                                   & ",Gems = '" & Trim(cboGems.Text) & "'" _
                                   & ",Required = '" & Trim(rdM) & "'" _
                                   & ",List = '" & Trim(cboList.Text) & "'" _
                                   & ",DataType = '" & Trim(txtDataType.Text) & "'" _
                                   & ",Length = '" & Trim(txtLength.Text) & "'" _
                                   & ",CustomerFieldName = '" & Trim(txtCustomerFieldName.Text) & "'" _
                                   & " where GEMS  = '" & Trim(cboGems.Text) & "' and ClientGCN = '" & Trim(cboGlobalCust.Text) & "'"

                    CNN.Execute(UPD_QUERY)

                    MsgBox("Record has been successfully updated..", , ":::Settings::")

                    Call MIDFieldsInit()


                Else
                    Exit Sub
                End If

            End If

        End With
        RS.Close()

    End Sub


    Private Sub MIDFieldsInit()

        cboDataItem.Text = Nothing
        cboGems.Text = Nothing
        cboList.Text = Nothing
        txtLength.Text = Nothing
        txtDataType.Text = Nothing
        txtCustomerFieldName.Text = Nothing
        rdMandatory.Checked = False
        rdOptional.Checked = False
        rdConditional.Checked = False

    End Sub



    Private Sub cboDataItem_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboDataItem.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboGems_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboGems.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboList__KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboList.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtDatatype__KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDatatype.KeyPress
        e.Handled = True
    End Sub



    Private Sub btnAddMidFields_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddMidFields.Click

        Dim required As String = Nothing
        Dim reply As MsgBoxResult
        Dim replyRes As MsgBoxResult


        '===== Required Options ========

        If Trim(cboDataItem.Text) <> Nothing And Trim(cboGems.Text) <> Nothing And Trim(cboList.Text) <> Nothing And
            Trim(txtLength.Text) <> Nothing And Trim(txtCustomerFieldName.Text) <> Nothing And
            (rdMandatory.Checked <> False Or rdOptional.Checked <> False Or rdConditional.Checked <> False) Then

            reply = MsgBox("Do you want to Add New Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If reply = MsgBoxResult.Yes Then

                If rdMandatory.Checked = True Then
                    required = "Mandatory"
                ElseIf rdOptional.Checked = True Then
                    required = "Optional"
                ElseIf rdConditional.Checked = True Then
                    required = "Conditional"
                End If


                CHECK_RS()

                SQL_QUERY = "Select * from BCDMIS..MIDFields where GEMS  = '" & Trim(cboGems.Text) & "' and ClientGCN = '" & Trim(cboGlobalCust.Text) & "'"
                RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS

                    If Not RS.EOF Then

                        replyRes = MsgBox("Update Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

                        If replyRes = MsgBoxResult.Yes Then

                            UPD_QUERY = "update BCDMIS..MIDFields set " _
                                  & " ClientGCN = '" & Trim(cboGlobalCust.Text) & "'" _
                                  & ",DataItem = '" & Trim(cboDataItem.Text) & "'" _
                                  & ",Gems = '" & Trim(cboGems.Text) & "'" _
                                  & ",Required = '" & Trim(required) & "'" _
                                  & ",List = '" & Trim(cboList.Text) & "'" _
                                  & ",DataType = '" & Trim(txtDatatype.Text) & "'" _
                                  & ",Length = '" & Trim(txtLength.Text) & "'" _
                                  & ",CustomerFieldName = '" & Trim(txtCustomerFieldName.Text) & "'" _
                                  & " where GEMS  = '" & Trim(cboGems.Text) & "' and ClientGCN = '" & Trim(cboGlobalCust.Text) & "'"

                            CNN.Execute(UPD_QUERY)

                            MsgBox("Record has been successfully updated...", , "::: Settings ::")
                        End If



                    Else

                        INS_QUERY = "insert into BCDMIS..MIDFields(ClientGCN,DataItem,Gems,Required, List, DataType, Length,CustomerFieldName)" _
                                    & " values ('" & Trim(cboGlobalCust.Text) & "','" & Trim(cboDataItem.Text) & "','" & Trim(cboGems.Text) & "','" & Trim(required) & "','" & Trim(cboList.Text) & "','" & Trim(txtDatatype.Text) & "','" & Trim(txtLength.Text) & "','" & Trim(txtCustomerFieldName.Text) & "')"

                        CNN.Execute(INS_QUERY)

                        MsgBox("Record has been successfully added...", , "::: Settings ::")

                        Call MIDFields()
                        Call MIDFieldsInit()



                    End If


                End With

                RS.Close()


            End If



        Else
            MsgBox("Incomplete Details...", , "::: MID Field Settings::")
        End If


       

    End Sub

    Private Sub btnDelMidFields_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelMidFields.Click

        If Trim(cboDataItem.Text) <> Nothing And Trim(cboGems.Text) <> Nothing And Trim(cboList.Text) <> Nothing And
        Trim(txtLength.Text) <> Nothing And Trim(txtCustomerFieldName.Text) <> Nothing And
        (rdMandatory.Checked <> False Or rdOptional.Checked <> False Or rdConditional.Checked <> False) Then

         
            res = MsgBox(" Delete record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::SETTINGS::")

                    If res = MsgBoxResult.Yes Then

                DEL_QUERY = "Delete from BCDMIS..MIDFields where ClientGCN ='" & Trim(cboGlobalCust.Text) & "' and Gems = '" & Trim(cboGems.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Settings has been remove successfully..", , ":::SETTINGS::")

                        Call MIDFields()
                Call MIDFieldsInit()

                    Else
                        Exit Sub
                    End If


        Else
            MsgBox("Please select items from the list to delete..", , "::: MID Field Settings::")

        End If

    End Sub



   
End Class