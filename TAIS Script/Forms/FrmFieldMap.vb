Public Class FrmFieldMap


    Dim F_Result As String

    Private Sub btnAddEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddEdit.Click
        txtBCDEntry.Enabled = True
        txtFieldMapping.Enabled = True
        txtAbacusEntry.Enabled = True
        txtBCDEntry.Focus()
    End Sub


    Private Sub btnCloseField_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseField.Click

        Me.Hide()

        strLowFare = Nothing
        strCurrCode = Nothing
        strReasonCode = Nothing
        strtravName = Nothing
        strtravStatus = Nothing
        strCostCenter = Nothing
        strProjectNo = Nothing
        strDeptNo = Nothing
        strOrderRef = Nothing
        strApprover = Nothing
        strApproverCode = Nothing
        strMgrSup = Nothing
        strReasCode = Nothing
        strReasCodeDen = Nothing
        strFFLYNo = Nothing
        strHotelReasonCode = Nothing
        strHotelBookedFlag = Nothing
        strAirNoAccom = Nothing
        strCarBookedFlag = Nothing
        strSalesChannel = Nothing
        strRecordType = Nothing
        strCSData1 = Nothing
        strCSData2 = Nothing
        strCSData3 = Nothing
        strCSData4 = Nothing
        strCSData5 = Nothing
        strCSData6 = Nothing
        strCSData7 = Nothing
        strCSData8 = Nothing
        strCSData12 = Nothing


    End Sub


    Private Sub btnSaveMapping_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveMapping.Click




        '=====================
        '==Low Fare
        '=====================
        If strLowFare = "True" Then 'Or CtrlFieldEquivalent = 1 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then

                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_LowFare where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_LowFare set " _
                                       & " GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code = '" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_LowFare(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "', '" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"
                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If


                    End If

                End With

                RS1.Close()

            End If

        End If





        '=====================
        '==Curr Code
        '=====================
        If strCurrCode = "True" Then 'Or CtrlFieldEquivalent = 1 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then

                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_CurrCode where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_CurrCode set " _
                                       & " GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code = '" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_CurrCode(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "', '" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"
                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If


                    End If

                End With

                RS1.Close()

            End If

        End If



        '=====================
        '==Reason Code
        '=====================
        If strReasonCode = "True" Then 'Or CtrlFieldEquivalent = 1 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then

                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_ReasonCodeDen where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_ReasonCodeDen set " _
                                       & " GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code = '" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_ReasonCodeDen(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "', '" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"
                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If


                    End If

                End With

                RS1.Close()

            End If

        End If


        '=====================
        '==Emp No
        '=====================
        If strEmpNo = "True" Then 'Or CtrlFieldEquivalent = 1 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then

                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_EmpNo where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_EmpNo set " _
                                       & " GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code = '" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_EmpNo(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "', '" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"
                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If


                    End If

                End With

                RS1.Close()

            End If

        End If


        '===========================
        '===Traveller Name
        '===========================

        If strtravName = "True" Then 'Or CtrlFieldEquivalent = 2 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then


                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_TravaName where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_TravaName set " _
                                       & " GCN ='" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code ='" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_TravaName(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(txtBCDEntry.Text) & "','" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If

                    End If


                End With

                RS1.Close()


            End If

        End If



        '============================
        '   Traveller Status
        '============================

        If strtravStatus = "True" Then ' Or CtrlFieldEquivalent = 3 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then


                '==BCD Entry

                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_TravStatus where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_TravStatus set " _
                                       & "GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code ='" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_TravStatus(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "','" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If


                    End If


                End With

                RS1.Close()

            End If

        End If


        '============================
        '   Cost Center 
        '============================

        If strCostCenter = "True" Then 'Or CtrlFieldEquivalent = 4 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then


                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_CostCenter where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_CostCenter set " _
                                       & " GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code ='" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_CostCenter(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "','" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If
                    End If


                End With

                RS1.Close()


            End If

        End If




        '============================
        '   Project Number
        '============================

        If strProjectNo = "True" Then ' Or CtrlFieldEquivalent = 5 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then


                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_ProjNo where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_ProjNo set " _
                                       & " GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code ='" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_ProjNo(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "','" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"

                            CNN.Execute(INS_QUERY)
                            MsgBox("Record has been successfully added...", , "::: Settings ::")

                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If
                    End If

                End With

                RS1.Close()


            End If

        End If




        '============================
        '   Department Number
        '============================

        If strDeptNo = "True" Then 'Or CtrlFieldEquivalent = 6 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then


                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_DeptNo where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_DeptNo set " _
                                       & " GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code ='" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_DeptNo(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "','" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"

                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If
                    End If

                End With

                RS1.Close()


            End If

        End If



        '============================
        '   Order Reference Number
        '============================

        If strOrderRef = "True" Then ' Or CtrlFieldEquivalent = 7 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then

                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_OrderRef where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_OrderRef set " _
                                       & " GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code ='" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_OrderRef(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "','" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"
                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If
                    End If

                End With

                RS1.Close()


            End If

        End If



        '============================
        '   Approver
        '============================

        If strApprover = "True" Then 'Or CtrlFieldEquivalent = 8 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then

                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_Approver where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_Approver set " _
                                       & "GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code ='" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_Approver(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "','" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"
                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If
                    End If

                End With

                RS1.Close()

            End If

        End If




        '============================
        '   Approval Code
        '============================

        If strApproverCode = "True" Then ' Or CtrlFieldEquivalent = 9 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then

                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_ApprovalCode where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_ApprovalCode set " _
                                       & " GCN ='" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code ='" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_ApprovalCode(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "','" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"
                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If
                    End If

                End With

                RS1.Close()

            End If

        End If




        '=========================
        ' Manager Superior
        '=========================

        If strMgrSup = "True" Then 'Or CtrlFieldEquivalent = 10 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then

                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_MgrSup where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_MgrSup set " _
                                       & " GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code ='" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_MgrSup(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "','" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"
                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If
                    End If

                End With

                RS1.Close()

            End If

        End If



        '=========================
        ' Reason of Trip
        '=========================

        If strReasonOfTrip = "True" Then ' Or CtrlFieldEquivalent = 11 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then

                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_ReasonofTrip where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_ReasonofTrip set " _
                                       & " GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code ='" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_ReasonofTrip(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "','" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"
                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If
                    End If

                End With

                RS1.Close()

            End If

        End If




        '=========================
        '  Major Class
        '=========================

        If strMajorClass = "True" Then 'Or CtrlFieldEquivalent = 12 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then

                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_MajorClass where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_MajorClass set " _
                                       & " GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code ='" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_MajorClass(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "','" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"
                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If
                    End If

                End With

                RS1.Close()

            End If

        End If



        '=========================
        '  Stop Over Flag
        '=========================

        If strStopOverFlag = "True" Then 'Or CtrlFieldEquivalent = 13 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then

                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_StopOverFlag where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_StopOverFlag set " _
                                       & " GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code ='" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_StopOverFlag(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "','" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"
                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If
                    End If

                End With

                RS1.Close()

            End If

        End If


        '=====================
        '==Tour Code
        '=====================
        If strTourCode = "True" Then ' Or CtrlFieldEquivalent = 14 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then

                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_TourCode where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_TourCode set " _
                                       & " GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code ='" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_TourCode(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "','" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"
                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If
                    End If

                End With

                RS1.Close()

            End If

        End If




        '=====================
        '==Reason Code
        '=====================
        If strReasCode = "True" Then 'Or CtrlFieldEquivalent = 15 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then

                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_ReasonCode where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_ReasonCode set " _
                                       & " GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code ='" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_ReasonCode(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "','" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"
                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If
                    End If

                End With

                RS1.Close()

            End If

        End If



        '=====================
        '==Reason Code Denied
        '=====================
        If strReasCodeDen = "True" Then 'Or CtrlFieldEquivalent = 16 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then

                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_ReasonCodeDen where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_ReasonCodeDen set " _
                                       & " GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code ='" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_ReasonCodeDen(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "','" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"
                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If
                    End If

                End With

                RS1.Close()

            End If

        End If



        '=====================
        '==FFLYR No
        '=====================
        If strFFLYNo = "True" Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then

                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_FFlyrNo where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_FFlyrNo set " _
                                       & " GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code ='" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_FFlyrNo(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "','" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"
                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If
                    End If

                End With

                RS1.Close()

            End If

        End If





        '=====================
        '==Car Booked flag No
        '=====================
        If strCarBookedFlag = "True" Then 'Or CtrlFieldEquivalent = 20 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then

                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_CarBookedFlag where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_CarBookedFlag set " _
                                       & " GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code = '" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "" Then
                            INS_QUERY = "insert into BCDMIS..T_CarBookedFlag(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "','" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"
                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If
                    End If

                End With

                RS1.Close()

            End If

        End If



        '=====================
        '==Hotel Reason Code
        '=====================
        If strHotelReasonCode = "True" Then ' Or CtrlFieldEquivalent = 17 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then

                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_HotelReasonCode where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_HotelReasonCode set " _
                                       & " GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code ='" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_HotelReasonCode(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "','" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"
                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If
                    End If

                End With

                RS1.Close()

            End If

        End If



        '=====================
        '==Hotel Booked Flag
        '=====================
        If strHotelBookedFlag = "True" Then 'Or CtrlFieldEquivalent = 18 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then

                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_HotelBookedFlag where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_HotelBookedFlag set " _
                                       & " GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code ='" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "" Then
                            INS_QUERY = "insert into BCDMIS..T_HotelBookedFlag(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "','" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"
                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If
                    End If

                End With

                RS1.Close()

            End If

        End If



        '==============================
        '==Air No Accom Reason Code
        '==============================

        If strAirNoAccom = "True" Then 'Or CtrlFieldEquivalent = 19 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then

                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_AirNoAccomReasonCD where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then
                        UPD_QUERY = "update BCDMIS..T_AirNoAccomReasonCD set " _
                                       & " GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code ='" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)
                        MsgBox("Record has been successfully updated..", , ":::Settings::")
                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_AirNoAccomReasonCD(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "','" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"
                            CNN.Execute(INS_QUERY)
                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If
                    End If

                End With

                RS1.Close()

            End If

        End If



        '==============================
        '==Car Booked Flag
        '==============================

        If strCarBookedFlag = "True" Then 'Or CtrlFieldEquivalent = 20 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then

                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_CarBookedFlag where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_CarBookedFlag set " _
                                       & " GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code ='" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_CarBookedFlag(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "','" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"
                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If
                    End If

                End With

                RS1.Close()

            End If

        End If


        '==============================
        '==Sales Channel
        '==============================

        If strSalesChannel = "True" Then 'Or CtrlFieldEquivalent = 21 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then

                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_SalesChannel where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_SalesChannel set " _
                                       & " GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code ='" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_SalesChannel(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "','" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"
                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If
                    End If

                End With

                RS1.Close()

            End If

        End If


        '==============================
        '==Record Type
        '==============================

        If strRecordType = "True" Then 'Or CtrlFieldEquivalent = 22 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then

                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_RecordType where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_RecordType set " _
                                       & " GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code ='" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_RecordType(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "','" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"
                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If
                    End If

                End With

                RS1.Close()

            End If

        End If


        '==============================
        '==CS Data 1
        '==============================

        If strCSData1 = "True" Then 'Or CtrlFieldEquivalent = 23 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then

                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_ClientData1 where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_ClientData1 set " _
                                       & " GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code ='" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_ClientData1(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "','" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"
                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If
                    End If

                End With

                RS1.Close()

            End If

        End If



        '==============================
        '==CS Data 2
        '==============================

        If strCSData2 = "True" Then 'Or CtrlFieldEquivalent = 24 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then

                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_ClientData2 where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_ClientData2 set " _
                                       & " GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code ='" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_ClientData2(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "','" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"
                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If
                    End If

                End With

                RS1.Close()

            End If

        End If



        '==============================
        '==CS Data 3
        '==============================

        If strCSData3 = "True" Then 'Or CtrlFieldEquivalent = 25 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then

                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_ClientData3 where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_ClientData3 set " _
                                       & " GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code ='" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_ClientData3(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "','" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"
                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If
                    End If

                End With

                RS1.Close()

            End If

        End If


        '==============================
        '==CS Data 4
        '==============================

        If strCSData4 = "True" Then 'Or CtrlFieldEquivalent = 26 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then

                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_ClientData4 where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_ClientData4 set " _
                                       & " GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code ='" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_ClientData4(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "','" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"
                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If
                    End If

                End With

                RS1.Close()

            End If

        End If



        '==============================
        '==CS Data 5
        '==============================

        If strCSData5 = "True" Then 'Or CtrlFieldEquivalent = 23 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then

                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_ClientData5 where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_ClientData5 set " _
                                       & " GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code ='" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_ClientData5(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "','" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"
                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If
                    End If

                End With

                RS1.Close()

            End If

        End If



        '==============================
        '==CS Data 6
        '==============================

        If strCSData6 = "True" Then 'Or CtrlFieldEquivalent = 23 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then

                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_ClientData6 where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_ClientData6 set " _
                                       & " GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code ='" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_ClientData6(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "','" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"
                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If
                    End If

                End With

                RS1.Close()

            End If

        End If



        '==============================
        '==CS Data 7
        '==============================

        If strCSData7 = "True" Then 'Or CtrlFieldEquivalent = 23 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then

                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_ClientData7 where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_ClientData7 set " _
                                       & " GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code ='" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_ClientData7(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "','" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"
                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If
                    End If

                End With

                RS1.Close()

            End If

        End If



        '==============================
        '==CS Data 8
        '==============================

        If strCSData8 = "True" Then 'Or CtrlFieldEquivalent = 23 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then

                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_ClientData8 where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_ClientData8 set " _
                                       & " GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code ='" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_ClientData8(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "','" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"
                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If
                    End If

                End With

                RS1.Close()

            End If

        End If




        '==============================
        '==CS Data 12
        '==============================

        If strCSData12 = "True" Then 'Or CtrlFieldEquivalent = 27 Then

            F_Result = MsgBox("Do you want to add/update record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "::Settings::")

            If F_Result = MsgBoxResult.Yes Then

                CHECK_RS1()
                SQL_QUERY = "Select * from BCDMIS..T_ClientData12 where clientID  = '" & Trim(GlobalClientNo) & "'"
                RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS1

                    If Not RS1.EOF Then

                        UPD_QUERY = "update BCDMIS..T_ClientData12 set " _
                                       & " GCN = '" & Trim(GlobalCustNO) & "'" _
                                       & ",BCD_Code = '" & Trim(txtBCDEntry.Text) & "'" _
                                       & ",ABR_Code ='" & Trim(txtAbacusEntry.Text) & "'" _
                                       & ",FieldName = '" & Trim(txtFieldMapping.Text) & "'" _
                                       & " where ClientID = '" & Trim(GlobalClientNo) & "'"
                        CNN.Execute(UPD_QUERY)

                        MsgBox("Record has been successfully updated..", , ":::Settings::")

                        RS1.MoveNext()
                    Else
                        If (Trim(txtBCDEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Or (Trim(txtAbacusEntry.Text) <> "" And Trim(txtFieldMapping.Text) <> "") Then
                            INS_QUERY = "insert into BCDMIS..T_ClientData12(ClientID,GCN,BCD_Code,ABR_Code,FieldName)" _
                                        & " values ('" & Trim(GlobalClientNo) & "','" & Trim(GlobalCustNO) & "','" & Trim(txtBCDEntry.Text) & "','" & Trim(txtAbacusEntry.Text) & "','" & Trim(txtFieldMapping.Text) & "')"
                            CNN.Execute(INS_QUERY)

                            MsgBox("Record has been successfully added...", , "::: Settings ::")
                        Else
                            MsgBox("Incomplete Details...", , "::: Settings ::")
                        End If
                    End If

                End With

                RS1.Close()

            End If

        End If

    End Sub



End Class