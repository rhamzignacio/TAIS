Public Class FrmListType

    Private rowSelected As Integer
    Private colSelected As Integer


    Dim ctr As Integer = 0

    Private Sub btnRCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRCode.Click
        If FrmGeneral.TabCAPI.SelectedIndex = 1 Then
            FrmGeneral.TabCAPI.SelectedIndex = 1
            Me.Hide()
        Else
            FrmGeneral.TabCAPI.SelectedIndex = 4
            Me.Hide()
        End If

    End Sub



    Public Sub frmListType()

        '==Clear all the products found in the list
        DGW1.Rows.Clear()
        DGW1.Columns.Clear()
        DGW1.ColumnHeadersVisible = False
        DGW1.RowHeadersVisible = False


        If Trim(GlobalCustNO) <> Nothing Then

            Call createGridViewHeader()

            CHECK_RS1()

            SQL_QUERY = "Select * from BCDMIS..C_AccommodationReasonCode where ClientID = '" & Trim(FrmGeneral.txtGlobalCustNo.Text) & "' "
            RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS1

                Do While Not RS1.EOF

                    If Not RS1.EOF Then

                        DGW1.Rows.Add()
                        ctr = DGW1.Rows.Count - 1

                        DGW1.Rows.Item(ctr).Cells(0).Value = Trim((RS1.Fields("Code").Value).ToString())
                        DGW1.Rows.Item(ctr).Cells(1).Value = Trim((RS1.Fields("Description").Value).ToString())

                        RS1.MoveNext()

                    End If

                Loop

            End With
            RS1.Close()
        End If

    End Sub


    Public Sub frmApprovalCode()

        '==Clear all the products found in the list
        DGW1.Rows.Clear()
        DGW1.Columns.Clear()
        DGW1.ColumnHeadersVisible = False
        DGW1.RowHeadersVisible = False


        If Trim(GlobalCustNO) <> Nothing Then

            Call createGridViewHeader()

            CHECK_RS1()

            SQL_QUERY = "Select * from BCDMIS..C_ApprovalCode where ClientID = '" & Trim(FrmGeneral.txtGlobalCustNo.Text) & "' "
            RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS1

                Do While Not RS1.EOF

                    If Not RS1.EOF Then

                        DGW1.Rows.Add()
                        ctr = DGW1.Rows.Count - 1

                        DGW1.Rows.Item(ctr).Cells(0).Value = Trim((RS1.Fields("Code").Value).ToString())
                        DGW1.Rows.Item(ctr).Cells(1).Value = Trim((RS1.Fields("Description").Value).ToString())

                        RS1.MoveNext()

                    End If

                Loop

            End With
            RS1.Close()
        End If

    End Sub



    Public Sub frmListMgrSuperior()

        '==Clear all the products found in the list
        DGW1.Rows.Clear()
        DGW1.Columns.Clear()
        DGW1.ColumnHeadersVisible = False
        DGW1.RowHeadersVisible = False


        If Trim(GlobalCustNO) <> Nothing Then

            Call createGridViewHeader()

            CHECK_RS1()

            SQL_QUERY = "Select * from BCDMIS..C_ManagerSuperior where ClientID = '" & Trim(FrmGeneral.txtGlobalCustNo.Text) & "' "
            RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS1

                Do While Not RS1.EOF

                    If Not RS1.EOF Then

                        DGW1.Rows.Add()
                        ctr = DGW1.Rows.Count - 1

                        DGW1.Rows.Item(ctr).Cells(0).Value = Trim((RS1.Fields("Code").Value).ToString())
                        DGW1.Rows.Item(ctr).Cells(1).Value = Trim((RS1.Fields("Description").Value).ToString())

                        RS1.MoveNext()

                    End If

                Loop

            End With
            RS1.Close()
        End If

    End Sub


    Public Sub frmListTravellerStatus()

        '==Clear all the products found in the list
        DGW1.Rows.Clear()
        DGW1.Columns.Clear()
        DGW1.ColumnHeadersVisible = False
        DGW1.RowHeadersVisible = False


        If Trim(GlobalCustNO) <> Nothing Then

            Call createGridViewHeader()

            CHECK_RS1()

            SQL_QUERY = "Select * from BCDMIS..C_TravellerStatus where ClientID = '" & Trim(FrmGeneral.txtGlobalCustNo.Text) & "' "
            RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS1

                Do While Not RS1.EOF

                    If Not RS1.EOF Then

                        DGW1.Rows.Add()
                        ctr = DGW1.Rows.Count - 1

                        DGW1.Rows.Item(ctr).Cells(0).Value = Trim((RS1.Fields("Code").Value).ToString())
                        DGW1.Rows.Item(ctr).Cells(1).Value = Trim((RS1.Fields("Description").Value).ToString())

                        RS1.MoveNext()

                    End If

                Loop

            End With
            RS1.Close()
        End If

    End Sub



    Public Sub frmListCostCenter()

        '==Clear all the products found in the list
        DGW1.Rows.Clear()
        DGW1.Columns.Clear()
        DGW1.ColumnHeadersVisible = False
        DGW1.RowHeadersVisible = False


        If Trim(GlobalCustNO) <> Nothing Then

            Call createGridViewHeader()

            CHECK_RS1()

            SQL_QUERY = "Select * from BCDMIS..C_CostCenterCode where ClientID = '" & Trim(FrmGeneral.txtGlobalCustNo.Text) & "' "
            RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS1

                Do While Not RS1.EOF

                    If Not RS1.EOF Then

                        DGW1.Rows.Add()
                        ctr = DGW1.Rows.Count - 1

                        DGW1.Rows.Item(ctr).Cells(0).Value = Trim((RS1.Fields("Code").Value).ToString())
                        DGW1.Rows.Item(ctr).Cells(1).Value = Trim((RS1.Fields("Description").Value).ToString())

                        RS1.MoveNext()

                    End If

                Loop

            End With
            RS1.Close()
        End If

    End Sub


    Public Sub frmListProjectNumber()

        '==Clear all the products found in the list
        DGW1.Rows.Clear()
        DGW1.Columns.Clear()
        DGW1.ColumnHeadersVisible = False
        DGW1.RowHeadersVisible = False


        If Trim(GlobalCustNO) <> Nothing Then

            Call createGridViewHeader()

            CHECK_RS1()

            SQL_QUERY = "Select * from BCDMIS..C_ProjectNumber where ClientID = '" & Trim(FrmGeneral.txtGlobalCustNo.Text) & "' "
            RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS1

                Do While Not RS1.EOF

                    If Not RS1.EOF Then

                        DGW1.Rows.Add()
                        ctr = DGW1.Rows.Count - 1

                        DGW1.Rows.Item(ctr).Cells(0).Value = Trim((RS1.Fields("Code").Value).ToString())
                        DGW1.Rows.Item(ctr).Cells(1).Value = Trim((RS1.Fields("Description").Value).ToString())

                        RS1.MoveNext()

                    End If

                Loop

            End With
            RS1.Close()
        End If

    End Sub


    Public Sub frmListDepartmentNumber()

        '==Clear all the products found in the list
        DGW1.Rows.Clear()
        DGW1.Columns.Clear()
        DGW1.ColumnHeadersVisible = False
        DGW1.RowHeadersVisible = False


        If Trim(GlobalCustNO) <> Nothing Then

            Call createGridViewHeader()

            CHECK_RS1()

            SQL_QUERY = "Select * from BCDMIS..C_DepartmentNumber where ClientID = '" & Trim(FrmGeneral.txtGlobalCustNo.Text) & "' "
            RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS1

                Do While Not RS1.EOF

                    If Not RS1.EOF Then

                        DGW1.Rows.Add()
                        ctr = DGW1.Rows.Count - 1

                        DGW1.Rows.Item(ctr).Cells(0).Value = Trim((RS1.Fields("Code").Value).ToString())
                        DGW1.Rows.Item(ctr).Cells(1).Value = Trim((RS1.Fields("Description").Value).ToString())

                        RS1.MoveNext()

                    End If

                Loop

            End With
            RS1.Close()
        End If

    End Sub


    Public Sub frmListOrderReference()

        '==Clear all the products found in the list
        DGW1.Rows.Clear()
        DGW1.Columns.Clear()
        DGW1.ColumnHeadersVisible = False
        DGW1.RowHeadersVisible = False

        If Trim(GlobalCustNO) <> Nothing Then

            Call createGridViewHeader()

            CHECK_RS1()

            SQL_QUERY = "Select * from BCDMIS..C_OrderReference where ClientID = '" & Trim(FrmGeneral.txtGlobalCustNo.Text) & "' "
            RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS1

                Do While Not RS1.EOF

                    If Not RS1.EOF Then

                        DGW1.Rows.Add()
                        ctr = DGW1.Rows.Count - 1

                        DGW1.Rows.Item(ctr).Cells(0).Value = Trim((RS1.Fields("Code").Value).ToString())
                        DGW1.Rows.Item(ctr).Cells(1).Value = Trim((RS1.Fields("Description").Value).ToString())

                        RS1.MoveNext()

                    End If

                Loop

            End With
            RS1.Close()
        End If

    End Sub


    Public Sub frmListApprover()

        '==Clear all the products found in the list
        DGW1.Rows.Clear()
        DGW1.Columns.Clear()
        DGW1.ColumnHeadersVisible = False
        DGW1.RowHeadersVisible = False


        If Trim(GlobalCustNO) <> Nothing Then

            Call createGridViewHeader()

            CHECK_RS1()

            SQL_QUERY = "Select * from BCDMIS..C_Approver where ClientID = '" & Trim(FrmGeneral.txtGlobalCustNo.Text) & "' "
            RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS1

                Do While Not RS1.EOF

                    If Not RS1.EOF Then

                        DGW1.Rows.Add()
                        ctr = DGW1.Rows.Count - 1

                        DGW1.Rows.Item(ctr).Cells(0).Value = Trim((RS1.Fields("Code").Value).ToString())
                        DGW1.Rows.Item(ctr).Cells(1).Value = Trim((RS1.Fields("Description").Value).ToString())

                        RS1.MoveNext()

                    End If

                Loop

            End With
            RS1.Close()
        End If

    End Sub


    Public Sub frmListReasonOfTrip()

        '==Clear all the products found in the list
        DGW1.Rows.Clear()
        DGW1.Columns.Clear()
        DGW1.ColumnHeadersVisible = False
        DGW1.RowHeadersVisible = False


        If Trim(GlobalCustNO) <> Nothing Then

            Call createGridViewHeader()

            CHECK_RS1()

            SQL_QUERY = "Select * from BCDMIS..C_ReasonOfTrip where ClientID = '" & Trim(FrmGeneral.txtGlobalCustNo.Text) & "' order by Code "
            RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS1

                Do While Not RS1.EOF

                    If Not RS1.EOF Then

                        DGW1.Rows.Add()
                        ctr = DGW1.Rows.Count - 1

                        DGW1.Rows.Item(ctr).Cells(0).Value = Trim((RS1.Fields("Code").Value).ToString())
                        DGW1.Rows.Item(ctr).Cells(1).Value = Trim((RS1.Fields("Description").Value).ToString())

                        RS1.MoveNext()

                    End If

                Loop

            End With
            RS1.Close()
        End If

    End Sub


    Public Sub frmListCSData1()

        '==Clear all the products found in the list
        DGW1.Rows.Clear()
        DGW1.Columns.Clear()
        DGW1.ColumnHeadersVisible = False
        DGW1.RowHeadersVisible = False


        If Trim(GlobalCustNO) <> Nothing Then

            Call createGridViewHeader()

            CHECK_RS1()

            SQL_QUERY = "Select * from BCDMIS..C_ClientData1 where ClientID = '" & Trim(FrmGeneral.txtGlobalCustNo.Text) & "' "
            RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS1

                Do While Not RS1.EOF

                    If Not RS1.EOF Then

                        DGW1.Rows.Add()
                        ctr = DGW1.Rows.Count - 1

                        DGW1.Rows.Item(ctr).Cells(0).Value = Trim((RS1.Fields("Code").Value).ToString())
                        DGW1.Rows.Item(ctr).Cells(1).Value = Trim((RS1.Fields("Description").Value).ToString())

                        RS1.MoveNext()

                    End If

                Loop

            End With
            RS1.Close()
        End If

    End Sub



    Public Sub frmListCSData2()

        '==Clear all the products found in the list
        DGW1.Rows.Clear()
        DGW1.Columns.Clear()
        DGW1.ColumnHeadersVisible = False
        DGW1.RowHeadersVisible = False


        If Trim(GlobalCustNO) <> Nothing Then

            Call createGridViewHeader()

            CHECK_RS1()

            SQL_QUERY = "Select * from BCDMIS..C_ClientData2 where ClientID = '" & Trim(FrmGeneral.txtGlobalCustNo.Text) & "' "
            RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS1

                Do While Not RS1.EOF

                    If Not RS1.EOF Then

                        DGW1.Rows.Add()
                        ctr = DGW1.Rows.Count - 1

                        DGW1.Rows.Item(ctr).Cells(0).Value = Trim((RS1.Fields("Code").Value).ToString())
                        DGW1.Rows.Item(ctr).Cells(1).Value = Trim((RS1.Fields("Description").Value).ToString())

                        RS1.MoveNext()

                    End If

                Loop

            End With
            RS1.Close()
        End If

    End Sub


    Public Sub frmListCSData3()

        '==Clear all the products found in the list
        DGW1.Rows.Clear()
        DGW1.Columns.Clear()
        DGW1.ColumnHeadersVisible = False
        DGW1.RowHeadersVisible = False


        If Trim(GlobalCustNO) <> Nothing Then

            Call createGridViewHeader()

            CHECK_RS1()

            SQL_QUERY = "Select * from BCDMIS..C_ClientData3 where ClientID = '" & Trim(FrmGeneral.txtGlobalCustNo.Text) & "' "
            RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS1

                Do While Not RS1.EOF

                    If Not RS1.EOF Then

                        DGW1.Rows.Add()
                        ctr = DGW1.Rows.Count - 1

                        DGW1.Rows.Item(ctr).Cells(0).Value = Trim((RS1.Fields("Code").Value).ToString())
                        DGW1.Rows.Item(ctr).Cells(1).Value = Trim((RS1.Fields("Description").Value).ToString())

                        RS1.MoveNext()

                    End If

                Loop

            End With
            RS1.Close()
        End If

    End Sub


    Public Sub frmListCSData4()

        '==Clear all the products found in the list
        DGW1.Rows.Clear()
        DGW1.Columns.Clear()
        DGW1.ColumnHeadersVisible = False
        DGW1.RowHeadersVisible = False


        If Trim(GlobalCustNO) <> Nothing Then

            Call createGridViewHeader()

            CHECK_RS1()

            SQL_QUERY = "Select * from BCDMIS..C_ClientData4 where ClientID = '" & Trim(FrmGeneral.txtGlobalCustNo.Text) & "' "
            RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS1

                Do While Not RS1.EOF

                    If Not RS1.EOF Then

                        DGW1.Rows.Add()
                        ctr = DGW1.Rows.Count - 1

                        DGW1.Rows.Item(ctr).Cells(0).Value = Trim((RS1.Fields("Code").Value).ToString())
                        DGW1.Rows.Item(ctr).Cells(1).Value = Trim((RS1.Fields("Description").Value).ToString())

                        RS1.MoveNext()

                    End If

                Loop

            End With
            RS1.Close()
        End If

    End Sub



    Public Sub frmListCSData5()

        '==Clear all the products found in the list
        DGW1.Rows.Clear()
        DGW1.Columns.Clear()
        DGW1.ColumnHeadersVisible = False
        DGW1.RowHeadersVisible = False


        If Trim(GlobalCustNO) <> Nothing Then

            Call createGridViewHeader()

            CHECK_RS1()

            SQL_QUERY = "Select * from BCDMIS..C_ClientData5 where ClientID = '" & Trim(FrmGeneral.txtGlobalCustNo.Text) & "' "
            RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS1

                Do While Not RS1.EOF

                    If Not RS1.EOF Then

                        DGW1.Rows.Add()
                        ctr = DGW1.Rows.Count - 1

                        DGW1.Rows.Item(ctr).Cells(0).Value = Trim((RS1.Fields("Code").Value).ToString())
                        DGW1.Rows.Item(ctr).Cells(1).Value = Trim((RS1.Fields("Description").Value).ToString())

                        RS1.MoveNext()

                    End If

                Loop

            End With
            RS1.Close()
        End If

    End Sub




    Public Sub frmListCSData6()

        '==Clear all the products found in the list
        DGW1.Rows.Clear()
        DGW1.Columns.Clear()
        DGW1.ColumnHeadersVisible = False
        DGW1.RowHeadersVisible = False


        If Trim(GlobalCustNO) <> Nothing Then

            Call createGridViewHeader()

            CHECK_RS1()

            SQL_QUERY = "Select * from BCDMIS..C_ClientData6 where ClientID = '" & Trim(FrmGeneral.txtGlobalCustNo.Text) & "' "
            RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS1

                Do While Not RS1.EOF

                    If Not RS1.EOF Then

                        DGW1.Rows.Add()
                        ctr = DGW1.Rows.Count - 1

                        DGW1.Rows.Item(ctr).Cells(0).Value = Trim((RS1.Fields("Code").Value).ToString())
                        DGW1.Rows.Item(ctr).Cells(1).Value = Trim((RS1.Fields("Description").Value).ToString())

                        RS1.MoveNext()

                    End If

                Loop

            End With
            RS1.Close()
        End If

    End Sub




    Public Sub frmListCSData7()

        '==Clear all the products found in the list
        DGW1.Rows.Clear()
        DGW1.Columns.Clear()
        DGW1.ColumnHeadersVisible = False
        DGW1.RowHeadersVisible = False


        If Trim(GlobalCustNO) <> Nothing Then

            Call createGridViewHeader()

            CHECK_RS1()

            SQL_QUERY = "Select * from BCDMIS..C_ClientData7 where ClientID = '" & Trim(FrmGeneral.txtGlobalCustNo.Text) & "' "
            RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS1

                Do While Not RS1.EOF

                    If Not RS1.EOF Then

                        DGW1.Rows.Add()
                        ctr = DGW1.Rows.Count - 1

                        DGW1.Rows.Item(ctr).Cells(0).Value = Trim((RS1.Fields("Code").Value).ToString())
                        DGW1.Rows.Item(ctr).Cells(1).Value = Trim((RS1.Fields("Description").Value).ToString())

                        RS1.MoveNext()

                    End If

                Loop

            End With
            RS1.Close()
        End If

    End Sub





    Public Sub frmListCSData8()

        '==Clear all the products found in the list
        DGW1.Rows.Clear()
        DGW1.Columns.Clear()
        DGW1.ColumnHeadersVisible = False
        DGW1.RowHeadersVisible = False


        If Trim(GlobalCustNO) <> Nothing Then

            Call createGridViewHeader()

            CHECK_RS1()

            SQL_QUERY = "Select * from BCDMIS..C_ClientData8 where ClientID = '" & Trim(FrmGeneral.txtGlobalCustNo.Text) & "' "
            RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS1

                Do While Not RS1.EOF

                    If Not RS1.EOF Then

                        DGW1.Rows.Add()
                        ctr = DGW1.Rows.Count - 1

                        DGW1.Rows.Item(ctr).Cells(0).Value = Trim((RS1.Fields("Code").Value).ToString())
                        DGW1.Rows.Item(ctr).Cells(1).Value = Trim((RS1.Fields("Description").Value).ToString())

                        RS1.MoveNext()

                    End If

                Loop

            End With
            RS1.Close()
        End If

    End Sub





    Public Sub frmListCSData12()

        '==Clear all the products found in the list
        DGW1.Rows.Clear()
        DGW1.Columns.Clear()
        DGW1.ColumnHeadersVisible = False
        DGW1.RowHeadersVisible = False


        If Trim(GlobalCustNO) <> Nothing Then

            Call createGridViewHeader()

            CHECK_RS1()

            SQL_QUERY = "Select * from BCDMIS..C_ClientData12 where ClientID = '" & Trim(FrmGeneral.txtGlobalCustNo.Text) & "' "
            RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS1

                Do While Not RS1.EOF

                    If Not RS1.EOF Then

                        DGW1.Rows.Add()
                        ctr = DGW1.Rows.Count - 1

                        DGW1.Rows.Item(ctr).Cells(0).Value = Trim((RS1.Fields("Code").Value).ToString())
                        DGW1.Rows.Item(ctr).Cells(1).Value = Trim((RS1.Fields("Description").Value).ToString())

                        RS1.MoveNext()

                    End If

                Loop

            End With
            RS1.Close()
        End If

    End Sub





    Public Sub frmListEmployeeNumber()

        '==Clear all the products found in the list
        DGW1.Rows.Clear()
        DGW1.Columns.Clear()
        DGW1.ColumnHeadersVisible = False
        DGW1.RowHeadersVisible = False


        If Trim(GlobalCustNO) <> Nothing Then

            Call createGridViewHeader()

            CHECK_RS1()

            SQL_QUERY = "Select * from BCDMIS..C_EmployeeNumber where ClientID = '" & Trim(FrmGeneral.txtGlobalCustNo.Text) & "' "
            RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS1

                Do While Not RS1.EOF

                    If Not RS1.EOF Then

                        DGW1.Rows.Add()
                        ctr = DGW1.Rows.Count - 1

                        DGW1.Rows.Item(ctr).Cells(0).Value = Trim((RS1.Fields("Code").Value).ToString())
                        DGW1.Rows.Item(ctr).Cells(1).Value = Trim((RS1.Fields("Description").Value).ToString())

                        RS1.MoveNext()

                    End If

                Loop

            End With
            RS1.Close()
        End If

    End Sub



    Public Sub frmListHotelReasonCode()

        '==Clear all the products found in the list
        DGW1.Rows.Clear()
        DGW1.Columns.Clear()
        DGW1.ColumnHeadersVisible = False
        DGW1.RowHeadersVisible = False


        If Trim(GlobalCustNO) <> Nothing Then

            Call createGridViewHeader()

            CHECK_RS1()

            SQL_QUERY = "Select * from BCDMIS..C_HotelReasonCode where ClientID = '" & Trim(FrmGeneral.txtGlobalCustNo.Text) & "' "
            RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS1

                Do While Not RS1.EOF

                    If Not RS1.EOF Then

                        DGW1.Rows.Add()
                        ctr = DGW1.Rows.Count - 1

                        DGW1.Rows.Item(ctr).Cells(0).Value = Trim((RS1.Fields("Code").Value).ToString())
                        DGW1.Rows.Item(ctr).Cells(1).Value = Trim((RS1.Fields("Description").Value).ToString())

                        RS1.MoveNext()

                    End If

                Loop

            End With
            RS1.Close()
        End If

    End Sub


    Public Sub frmListReasonCodes()

        '==Clear all the products found in the list
        DGW1.Rows.Clear()
        DGW1.Columns.Clear()
        DGW1.ColumnHeadersVisible = False
        DGW1.RowHeadersVisible = False


        If Trim(GlobalCustNO) <> Nothing Then

            Call createGridViewHeader_ReasonCode()

            CHECK_RS1()

            SQL_QUERY = "Select * from BCDMIS..C_ReasonCodes where ClientID = '" & Trim(FrmGeneral.txtGlobalCustNo.Text) & "' "
            RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS1

                Do While Not RS1.EOF

                    If Not RS1.EOF Then

                        DGW1.Rows.Add()
                        ctr = DGW1.Rows.Count - 1

                        DGW1.Rows.Item(ctr).Cells(0).Value = Trim((RS1.Fields("EC").Value).ToString())
                        DGW1.Rows.Item(ctr).Cells(1).Value = Trim((RS1.Fields("BC").Value).ToString())
                        DGW1.Rows.Item(ctr).Cells(2).Value = Trim((RS1.Fields("FC").Value).ToString())
                        DGW1.Rows.Item(ctr).Cells(3).Value = Trim((RS1.Fields("Description").Value).ToString())
                        DGW1.Rows.Item(ctr).Cells(4).Value = Trim((RS1.Fields("Comparison").Value).ToString())

                        RS1.MoveNext()

                    End If

                Loop

            End With
            RS1.Close()
        End If

    End Sub

    Public Sub frmListReasonCodeDenied()

        '==Clear all the products found in the list
        DGW1.Rows.Clear()
        DGW1.Columns.Clear()
        DGW1.ColumnHeadersVisible = False
        DGW1.RowHeadersVisible = False


        If Trim(GlobalCustNO) <> Nothing Then

            Call createGridViewHeader_denied()

            CHECK_RS1()

            SQL_QUERY = "Select * from BCDMIS..C_ReasonCodeDenied where ClientID = '" & Trim(FrmGeneral.txtGlobalCustNo.Text) & "'" ' and Description NOT Like '%Exchange%' "
            RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS1

                Do While Not RS1.EOF

                    If Not RS1.EOF Then

                        DGW1.Rows.Add()
                        ctr = DGW1.Rows.Count - 1

                        DGW1.Rows.Item(ctr).Cells(0).Value = Trim((RS1.Fields("Code").Value).ToString())
                        DGW1.Rows.Item(ctr).Cells(1).Value = Trim((RS1.Fields("Description").Value).ToString())
                        DGW1.Rows.Item(ctr).Cells(2).Value = Trim((RS1.Fields("Comparison").Value).ToString())

                        RS1.MoveNext()

                    End If

                Loop

            End With
            RS1.Close()
        End If

    End Sub


    Public Sub frmListMajorClass()

        '==Clear all the products found in the list
        DGW1.Rows.Clear()
        DGW1.Columns.Clear()
        DGW1.ColumnHeadersVisible = False
        DGW1.RowHeadersVisible = False


        If Trim(GlobalCustNO) <> Nothing Then

            Call createGridViewHeader()

            CHECK_RS1()

            SQL_QUERY = "Select * from BCDMIS..C_MajorClass where ClientID = '" & Trim(FrmGeneral.txtGlobalCustNo.Text) & "' "
            RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS1

                Do While Not RS1.EOF

                    If Not RS1.EOF Then

                        DGW1.Rows.Add()
                        ctr = DGW1.Rows.Count - 1

                        DGW1.Rows.Item(ctr).Cells(0).Value = Trim((RS1.Fields("Code").Value).ToString())
                        DGW1.Rows.Item(ctr).Cells(1).Value = Trim((RS1.Fields("Description").Value).ToString())

                        RS1.MoveNext()

                    End If

                Loop

            End With
            RS1.Close()
        End If

    End Sub




    Private Sub createGridViewHeader()

        DGW1.ColumnCount = 2
        DGW1.ColumnHeadersVisible = True

        ' Set the column header style.
        Dim columnHeaderStyle As New DataGridViewCellStyle()

        columnHeaderStyle.BackColor = Color.CadetBlue

        columnHeaderStyle.Font = New Font("Arial", 7, FontStyle.Regular)

        DGW1.ColumnHeadersDefaultCellStyle = columnHeaderStyle
        DGW1.RowTemplate.Height = 15
        DGW1.RowsDefaultCellStyle.Font = New Font("Arial", 7, FontStyle.Regular)

        ' Set the column header names.
        DGW1.Columns(0).Name = "GRO Code"
        DGW1.Columns(0).Width = 120

        DGW1.Columns(1).Name = "Description"
        DGW1.Columns(1).Width = 700

    End Sub


    Private Sub createGridViewHeader_ReasonCode()

        DGW1.ColumnCount = 5
        DGW1.ColumnHeadersVisible = True

        ' Set the column header style.
        Dim columnHeaderStyle As New DataGridViewCellStyle()

        columnHeaderStyle.BackColor = Color.CadetBlue

        columnHeaderStyle.Font = New Font("Arial", 7, FontStyle.Regular)

        DGW1.ColumnHeadersDefaultCellStyle = columnHeaderStyle
        DGW1.RowTemplate.Height = 15
        DGW1.RowsDefaultCellStyle.Font = New Font("Arial", 7, FontStyle.Regular)

        ' Set the column header names.

        DGW1.Columns(0).Name = "EC"
        DGW1.Columns(0).Width = 50

        DGW1.Columns(1).Name = "BC"
        DGW1.Columns(1).Width = 50

        DGW1.Columns(2).Name = "FC"
        DGW1.Columns(2).Width = 50

        DGW1.Columns(3).Name = "Description"
        DGW1.Columns(3).Width = 200

        DGW1.Columns(4).Name = "Ref Fare VS Fare Paid"
        DGW1.Columns(4).Width = 130


    End Sub



    Private Sub createGridViewHeader_Denied()

        DGW1.ColumnCount = 3
        DGW1.ColumnHeadersVisible = True

        ' Set the column header style.
        Dim columnHeaderStyle As New DataGridViewCellStyle()

        columnHeaderStyle.BackColor = Color.CadetBlue

        columnHeaderStyle.Font = New Font("Arial", 7, FontStyle.Regular)

        DGW1.ColumnHeadersDefaultCellStyle = columnHeaderStyle
        DGW1.RowTemplate.Height = 15
        DGW1.RowsDefaultCellStyle.Font = New Font("Arial", 7, FontStyle.Regular)

        ' Set the column header names.

        DGW1.Columns(0).Name = "GRO Code"
        DGW1.Columns(0).Width = 80

        DGW1.Columns(1).Name = "Description"
        DGW1.Columns(1).Width = 200

        DGW1.Columns(2).Name = "Low Fare VS Fare Paid"
        DGW1.Columns(2).Width = 130


    End Sub


    Private Sub DGW1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGW1.CellClick

        rowSelected = e.RowIndex
        colSelected = e.ColumnIndex



        If CtrlListType = 1 Then
            FrmGeneral.txtApproverCode.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
            FrmGeneral.txtApproverCode.Focus()

        End If

        If CtrlListType = 2 Then
            FrmGeneral.txtAirNoReasonCD.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
            FrmGeneral.txtAirNoReasonCD.Focus()

        End If

        If CtrlListType = 3 Then
            FrmGeneral.txtTravellerStat.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
            FrmGeneral.txtTravellerStat.Focus()

        End If

        If CtrlListType = 4 Then
            FrmGeneral.txtCostCenterCode.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
            FrmGeneral.txtCostCenterCode.Focus()

        End If

        If CtrlListType = 5 Then
            FrmGeneral.txtProjectNo.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
            FrmGeneral.txtProjectNo.Focus()


        End If

        If CtrlListType = 6 Then
            FrmGeneral.txtDeptNo.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
            FrmGeneral.txtDeptNo.Focus()
        End If

        If CtrlListType = 7 Then
            FrmGeneral.txtOrderRef.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
            FrmGeneral.txtOrderRef.Focus()

        End If

        If CtrlListType = 8 Then
            FrmGeneral.txtApprover.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
            FrmGeneral.txtApprover.Focus()

        End If

        If CtrlListType = 9 Then
            FrmGeneral.txtMgrSuperior.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
            FrmGeneral.txtMgrSuperior.Focus()

        End If

        If CtrlListType = 10 Then
            FrmGeneral.txtReasonofTrip.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
            FrmGeneral.txtReasonofTrip.Focus()

        End If

        If CtrlListType = 11 Then
            FrmGeneral.txtCSData1.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
            FrmGeneral.txtCSData1.Focus()


        End If

        If CtrlListType = 12 Then
            FrmGeneral.txtCSData2.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
            FrmGeneral.txtCSData2.Focus()

        End If


        If CtrlListType = 13 Then
            FrmGeneral.txtCSData3.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
            FrmGeneral.txtCSData3.Focus()

        End If

        If CtrlListType = 14 Then
            FrmGeneral.txtCSData4.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
            FrmGeneral.txtCSData4.Focus()

        End If

        If CtrlListType = 15 Then
            FrmGeneral.txtEmployeeNo.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
            FrmGeneral.txtEmployeeNo.Focus()

        End If

        If CtrlListType = 16 Then
            FrmGeneral.txtHotelReasonCD.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
            FrmGeneral.txtHotelReasonCD.Focus()
        End If

        If CtrlListType = 21 Then
            FrmGeneral.txtCSData8.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
            FrmGeneral.txtCSData8.Focus()
        End If

        If CtrlListType = 22 Then
            FrmGeneral.txtCSData7.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
            FrmGeneral.txtCSData7.Focus()
        End If

        If CtrlListType = 23 Then
            FrmGeneral.txtCSData6.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
            FrmGeneral.txtCSData6.Focus()
        End If

        If CtrlListType = 24 Then
            FrmGeneral.txtCSData5.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
            FrmGeneral.txtCSData5.Focus()
        End If

        If CtrlListType = 25 Then
            FrmGeneral.txtCSData12.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
            FrmGeneral.txtCSData12.Focus()
        End If

        '=============================================================
        '=================== Fare Type Accepted Code =================
        '===================      Condition          =================
        '=============================================================

        If CtrlListType = 17 Then


            If Trim(FrmGeneral.txtSellingFare.Text) <> Nothing Then

                CHECK_RSfares()

                SQL_QUERY = "Select * from BCDMIS..C_ReasonCodes where ClientID = '" & Trim(GlobalCustNO) & "' and (EC = '" & Trim(DGW1.Rows.Item(rowSelected).Cells(colSelected).Value) & "' or  BC = '" & Trim(DGW1.Rows.Item(rowSelected).Cells(colSelected).Value) & "' or  FC = '" & Trim(DGW1.Rows.Item(rowSelected).Cells(colSelected).Value) & "') "
                RSfares.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RSfares

                    If Not RSfares.EOF Then

                        'MsgBox((DGW1.Rows.Item(rowSelected).Cells(colSelected).Value))

                        'MsgBox(RSfares.Fields("Comparison").Value)
                   
                        If Trim((RSfares.Fields("Comparison").Value).ToString()) = "Higher Than" Then

                            If Trim(FrmGeneral.txtSellingFare.Text) = Nothing Then
                                MsgBox("Selling Fare must not be empty...", vbCritical + vbOKOnly, "Warning!")
                                FrmGeneral.txtSellingFare.Focus()
                            ElseIf Trim(FrmGeneral.txtRefFare.Text) = Nothing Then
                                MsgBox("Reference Fare must not be empty...", vbCritical + vbOKOnly, "Warning!")
                                FrmGeneral.txtRefFare.Focus()
                            ElseIf Val(FrmGeneral.txtRefFare.Text.Trim) <= Val(FrmGeneral.txtSellingFare.Text.Trim) Then
                                MsgBox("Reference Fare must be higher than Fare Paid or Selling Fare...", vbCritical + vbOKOnly, "Warning!")
                                ' FrmGeneral.txtRefFare.Text = Nothing
                                FrmGeneral.txtRefFare.Focus()
                            Else
                                FrmGeneral.txtReasonCode.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(colSelected).Value)
                                FrmGeneral.txtDescRCode.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(3).Value)
                            End If


                        ElseIf Trim((RSfares.Fields("Comparison").Value).ToString()) = "" Or Trim((RSfares.Fields("Comparison").Value).ToString()) = Nothing Then
                            FrmGeneral.txtReasonCode.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(colSelected).Value)
                            FrmGeneral.txtDescRCode.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(3).Value)

                        ElseIf Trim((RSfares.Fields("Comparison").Value).ToString()) = "Either" Then

                            If Trim(FrmGeneral.txtSellingFare.Text) = Nothing And Trim(FrmGeneral.txtRefFare.Text) = Nothing Then
                                MsgBox("Selling or Reference Fare must not be empty...", vbCritical + vbOKOnly, "Warning!")
                                FrmGeneral.txtSellingFare.Text = Nothing
                                FrmGeneral.txtRefFare.Text = Nothing
                                FrmGeneral.txtSellingFare.Focus()
                            ElseIf Trim(FrmGeneral.txtSellingFare.Text) <> Nothing And Trim(FrmGeneral.txtRefFare.Text) <> Nothing Then
                                MsgBox("It's Either Selling or Reference Fare only...", vbCritical + vbOKOnly, "Warning!")
                                FrmGeneral.txtSellingFare.Text = Nothing
                                FrmGeneral.txtRefFare.Text = Nothing
                                FrmGeneral.txtSellingFare.Focus()
                            ElseIf Trim(FrmGeneral.txtSellingFare.Text) = Nothing And Trim(FrmGeneral.txtRefFare.Text) <> Nothing Or
                                Trim(FrmGeneral.txtSellingFare.Text) <> Nothing And Trim(FrmGeneral.txtRefFare.Text) = Nothing Then
                                FrmGeneral.txtReasonCode.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(colSelected).Value)
                                FrmGeneral.txtDescRCode.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(3).Value)
                            End If

                        ElseIf Trim((RSfares.Fields("Comparison").Value).ToString()) = "Equal To" Then

                            If Trim(FrmGeneral.txtSellingFare.Text) = Nothing And Trim(FrmGeneral.txtRefFare.Text) = Nothing And UCase(Trim((RSfares.Fields("Description").Value).ToString())) = "EXCHANGE WITH VALUE" Then
                                MsgBox("Reference & Selling Fare must not be empty...", vbCritical + vbOKOnly, "Warning!")
                                FrmGeneral.txtSellingFare.Text = Nothing
                                FrmGeneral.txtRefFare.Text = Nothing
                                FrmGeneral.txtSellingFare.Focus()
                            ElseIf Trim(FrmGeneral.txtSellingFare.Text) <> Nothing And Trim(FrmGeneral.txtRefFare.Text) <> Nothing And UCase(Trim((RSfares.Fields("Description").Value).ToString())) = "EXCHANGE NO VALUE" Then
                                'MsgBox("Reference & Selling Fare must be zero...", vbCritical + vbOKOnly, "Warning!")
                                FrmGeneral.txtSellingFare.Text = 0
                                FrmGeneral.txtRefFare.Text = 0
                                FrmGeneral.txtReasonCode.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(colSelected).Value)
                                FrmGeneral.txtDescRCode.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(3).Value)
                            ElseIf Trim(FrmGeneral.txtSellingFare.Text) <> Nothing And Trim(FrmGeneral.txtRefFare.Text) = Nothing Or
                                 Trim(FrmGeneral.txtSellingFare.Text) = Nothing And Trim(FrmGeneral.txtRefFare.Text) <> Nothing Then
                                If Trim(FrmGeneral.txtSellingFare.Text) = Nothing And Trim(FrmGeneral.txtRefFare.Text) <> Nothing Then
                                    MsgBox("Selling Fare must not be empty...", vbCritical + vbOKOnly, "Warning!")
                                    FrmGeneral.txtSellingFare.Focus()
                                ElseIf Trim(FrmGeneral.txtSellingFare.Text) <> Nothing And Trim(FrmGeneral.txtRefFare.Text) = Nothing Then
                                    MsgBox("Reference Fare must not be empty...", vbCritical + vbOKOnly, "Warning!")
                                    FrmGeneral.txtRefFare.Focus()
                                End If
                            ElseIf (Trim(FrmGeneral.txtSellingFare.Text) = Nothing And Trim(FrmGeneral.txtRefFare.Text) = Nothing And UCase(Trim((RSfares.Fields("Description").Value).ToString())) <> "EXCHANGE WITH VALUE") Or
                                (Trim(FrmGeneral.txtSellingFare.Text) = Trim(FrmGeneral.txtRefFare.Text) And UCase(Trim((RSfares.Fields("Description").Value).ToString())) <> "EXCHANGE NO VALUE") Then
                                FrmGeneral.txtReasonCode.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(colSelected).Value)
                                FrmGeneral.txtDescRCode.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(3).Value)
                            ElseIf Val(FrmGeneral.txtSellingFare.Text.Trim) <> Val(FrmGeneral.txtRefFare.Text.Trim) And UCase(Trim((RSfares.Fields("Description").Value).ToString())) <> "EXCHANGE NO VALUE" Then
                                MsgBox("Reference Fare equals Selling Fare...", vbCritical + vbOKOnly, "Warning!")
                                ' FrmGeneral.txtRefFare.Text = FrmGeneral.txtSellingFare.Text
                                FrmGeneral.txtRefFare.Focus()
                            Else
                                FrmGeneral.txtReasonCode.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(colSelected).Value)
                                FrmGeneral.txtDescRCode.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(3).Value)

                            End If

                        End If


                    End If
                    RSfares.Close()
                End With

                If Trim(FrmGeneral.txtMajorClass.Text) <> Nothing Then

                    'If (FrmGeneral.txtReasonCode.Text).Substring(0, 1) = "1" And (Trim(FrmGeneral.txtMajorClass.Text) <> "Y") Then
                    '    MsgBox("Entry Does Not Match with Major Class", vbCritical + vbOKOnly, "Warning!")
                    '    FrmGeneral.txtMajorClass.Text = Nothing
                    '    FrmGeneral.txtReasonCode.Text = Nothing
                    '    FrmGeneral.txtReasonCode.Focus()
                    'ElseIf (FrmGeneral.txtReasonCode.Text).Substring(0, 1) = "2" And (Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value) <> "C" Or Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value) <> "L" Or Trim(FrmGeneral.txtMajorClass.Text) <> "T") Then
                    '    MsgBox("Entry Does Not Match with Major Class", vbCritical + vbOKOnly, "Warning!")
                    '    FrmGeneral.txtMajorClass.Text = Nothing
                    '    FrmGeneral.txtReasonCode.Text = Nothing
                    '    FrmGeneral.txtReasonCode.Focus()
                    'ElseIf (FrmGeneral.txtReasonCode.Text).Substring(0, 1) = "3" And (Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value) <> "F") Then
                    '    MsgBox("Entry Does Not Match with Major Class", vbCritical + vbOKOnly, "Warning!")
                    '    FrmGeneral.txtMajorClass.Text = Nothing
                    '    FrmGeneral.txtReasonCode.Text = Nothing
                    '    FrmGeneral.txtReasonCode.Focus()
                    'End If

                End If



            ElseIf Trim(FrmGeneral.txtSFSegment.Text) <> Nothing Then

                CHECK_RSfares()

                SQL_QUERY = "Select * from BCDMIS..C_ReasonCodes where ClientID = '" & Trim(GlobalCustNO) & "' and EC = '" & Trim(DGW1.Rows.Item(rowSelected).Cells(colSelected).Value) & "' or  BC = '" & Trim(DGW1.Rows.Item(rowSelected).Cells(colSelected).Value) & "' or  FC = '" & Trim(DGW1.Rows.Item(rowSelected).Cells(colSelected).Value) & "' "
                RSfares.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RSfares

                    If Not RSfares.EOF Then

                        If Trim((RSfares.Fields("Comparison").Value).ToString()) = "Higher Than" Then



                            If Trim(FrmGeneral.txtSFSegment.Text) = Nothing Then
                                MsgBox("Selling Fare must not be empty...", vbCritical + vbOKOnly, "Warning!")
                                FrmGeneral.txtSFSegment.Focus()
                            ElseIf Trim(FrmGeneral.txtRefFare.Text) = Nothing Then
                                MsgBox("Reference Fare must not be empty...", vbCritical + vbOKOnly, "Warning!")
                                FrmGeneral.txtRefFare.Focus()
                            ElseIf Val(FrmGeneral.txtRefFare.Text.Trim) <= Val(FrmGeneral.txtSFSegment.Text.Trim) Then
                                MsgBox("Reference Fare must be higher than Fare Paid or Selling Fare...", vbCritical + vbOKOnly, "Warning!")
                                '   FrmGeneral.txtRefFare.Text = Nothing
                                FrmGeneral.txtRefFare.Focus()
                            Else
                                FrmGeneral.txtReasonCode.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(colSelected).Value)
                                FrmGeneral.txtDescRCode.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(3).Value)
                            End If

                        ElseIf Trim((RSfares.Fields("Comparison").Value).ToString()) = "" Or Trim((RSfares.Fields("Comparison").Value).ToString()) = Nothing Then

                            FrmGeneral.txtReasonCode.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(colSelected).Value)
                            FrmGeneral.txtDescRCode.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(3).Value)

                        ElseIf Trim((RSfares.Fields("Comparison").Value).ToString()) = "Either" Then

                            If Trim(FrmGeneral.txtSFSegment.Text) = Nothing And Trim(FrmGeneral.txtRefFare.Text) = Nothing Then
                                MsgBox("Selling or Reference Fare must not be empty...", vbCritical + vbOKOnly, "Warning!")
                                FrmGeneral.txtSFSegment.Text = Nothing
                                FrmGeneral.txtRefFare.Text = Nothing
                                FrmGeneral.txtSFSegment.Focus()
                            ElseIf Trim(FrmGeneral.txtSFSegment.Text) <> Nothing And Trim(FrmGeneral.txtRefFare.Text) <> Nothing Then
                                MsgBox("It's Either Selling or Reference Fare only...", vbCritical + vbOKOnly, "Warning!")
                                FrmGeneral.txtSFSegment.Text = Nothing
                                FrmGeneral.txtRefFare.Text = Nothing
                                FrmGeneral.txtSFSegment.Focus()
                            ElseIf Trim(FrmGeneral.txtSFSegment.Text) = Nothing And Trim(FrmGeneral.txtRefFare.Text) <> Nothing Or
                                Trim(FrmGeneral.txtSFSegment.Text) <> Nothing And Trim(FrmGeneral.txtRefFare.Text) = Nothing Then
                                FrmGeneral.txtReasonCode.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(colSelected).Value)
                                FrmGeneral.txtDescRCode.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(3).Value)
                            End If


                        ElseIf Trim((RSfares.Fields("Comparison").Value).ToString()) = "Equal To" Then

                            If Trim(FrmGeneral.txtSFSegment.Text) = Nothing And Trim(FrmGeneral.txtRefFare.Text) = Nothing And UCase(Trim((RSfares.Fields("Description").Value).ToString())) <> "EXCHANGE NO VALUE" Then
                                MsgBox("Reference & Selling Fare must not be empty...", vbCritical + vbOKOnly, "Warning!")
                                FrmGeneral.txtSFSegment.Text = Nothing
                                FrmGeneral.txtRefFare.Text = Nothing
                                FrmGeneral.txtSFSegment.Focus()

                            ElseIf Trim(FrmGeneral.txtSFSegment.Text) <> Nothing And Trim(FrmGeneral.txtRefFare.Text) <> Nothing And UCase(Trim((RSfares.Fields("Description").Value).ToString())) = "EXCHANGE NO VALUE" Then
                                MsgBox("Reference & Selling Fare must be zero...", vbCritical + vbOKOnly, "Warning!")
                                FrmGeneral.txtSFSegment.Text = Nothing
                                FrmGeneral.txtRefFare.Text = Nothing
                                FrmGeneral.txtReasonCode.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(colSelected).Value)
                                FrmGeneral.txtDescRCode.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(3).Value)

                            ElseIf Trim(FrmGeneral.txtSFSegment.Text) <> Nothing And Trim(FrmGeneral.txtRefFare.Text) = Nothing Or
                                 Trim(FrmGeneral.txtSFSegment.Text) = Nothing And Trim(FrmGeneral.txtRefFare.Text) <> Nothing Then

                                If Trim(FrmGeneral.txtSFSegment.Text) = Nothing And Trim(FrmGeneral.txtRefFare.Text) <> Nothing Then
                                    MsgBox("Selling Fare must not be empty...", vbCritical + vbOKOnly, "Warning!")
                                    FrmGeneral.txtSFSegment.Focus()
                                ElseIf Trim(FrmGeneral.txtSFSegment.Text) <> Nothing And Trim(FrmGeneral.txtRefFare.Text) = Nothing Then
                                    MsgBox("Reference Fare must not be empty...", vbCritical + vbOKOnly, "Warning!")
                                    FrmGeneral.txtRefFare.Focus()
                                End If

                            ElseIf (Trim(FrmGeneral.txtSFSegment.Text) = Nothing And Trim(FrmGeneral.txtRefFare.Text) = Nothing And UCase(Trim((RSfares.Fields("Description").Value).ToString())) <> "EXCHANGE WITH VALUE") Or
                                (Trim(FrmGeneral.txtSFSegment.Text) = Trim(FrmGeneral.txtRefFare.Text) And UCase(Trim((RSfares.Fields("Description").Value).ToString())) <> "EXCHANGE NO VALUE") Then

                                FrmGeneral.txtReasonCode.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(colSelected).Value)
                                FrmGeneral.txtDescRCode.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(3).Value)

                            ElseIf Val(FrmGeneral.txtSFSegment.Text.Trim) <> Val(FrmGeneral.txtRefFare.Text.Trim) And UCase(Trim((RSfares.Fields("Description").Value).ToString())) <> "EXCHANGE NO VALUE" Then

                                MsgBox("Reference Fare equals Selling Fare...", vbCritical + vbOKOnly, "Warning!")
                                ' FrmGeneral.txtRefFare.Text = FrmGeneral.txtSellingFare.Text
                                FrmGeneral.txtRefFare.Focus()
                                'FrmGeneral.txtReasonCode.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(colSelected).Value)
                                'FrmGeneral.txtDescRCode.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(3).Value)
                            End If

                        End If

                    End If

                End With

                RSfares.Close()

            End If


        End If

        '=============================================================
        '===================   Reason Code Denied    =================
        '===================      Condition          =================
        '=============================================================

        If CtrlListType = 18 Then


            If Trim(FrmGeneral.txtSellingFare.Text) <> Nothing Then

                CHECK_RSfaresDenied()

                SQL_QUERY = "Select * from BCDMIS..C_ReasonCodeDenied where ClientID = '" & Trim(GlobalCustNO) & "' and  Code='" & Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value) & "'"
                RSfaresDenied.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RSfaresDenied

                    If Not RSfaresDenied.EOF Then

                        If Trim((RSfaresDenied.Fields("Comparison").Value).ToString()) = "Either" Then
                            If (Trim(FrmGeneral.txtSellingFare.Text) <> Nothing And Trim(FrmGeneral.txtLowFare.Text) = Nothing) Or
                               (Trim(FrmGeneral.txtSellingFare.Text) = Nothing And Trim(FrmGeneral.txtLowFare.Text) <> Nothing) Then
                                FrmGeneral.txtRCodeDenied.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
                            ElseIf (Trim(FrmGeneral.txtSellingFare.Text) = Nothing And Trim(FrmGeneral.txtLowFare.Text) = Nothing) Then
                                MsgBox("Either Selling or Low Fare must not be empty...", vbCritical + vbOKOnly, "Warning!")
                                FrmGeneral.txtSellingFare.Focus()
                            ElseIf (Trim(FrmGeneral.txtSellingFare.Text) <> Nothing And Trim(FrmGeneral.txtLowFare.Text) <> Nothing) Then
                                FrmGeneral.txtLowFare.Text = Nothing
                                FrmGeneral.txtRCodeDenied.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
                            End If

                        ElseIf Trim((RSfaresDenied.Fields("Comparison").Value).ToString()) = "Equal To" Then
                            If Trim(FrmGeneral.txtSellingFare.Text) = Nothing Then
                                MsgBox("Selling Fare must not be empty...", vbCritical + vbOKOnly, "Warning!")
                                FrmGeneral.txtSellingFare.Focus()
                            ElseIf Trim(FrmGeneral.txtLowFare.Text) = Nothing Then
                                MsgBox("Low Fare must not be empty...", vbCritical + vbOKOnly, "Warning!")
                                FrmGeneral.txtLowFare.Focus()
                            ElseIf (Trim(FrmGeneral.txtSellingFare.Text > Trim(FrmGeneral.txtLowFare.Text)) Or (Trim(FrmGeneral.txtLowFare.Text) > Trim(FrmGeneral.txtSellingFare.Text))) Then
                                MsgBox("Low Fare must be equal to Selling Fare...", vbCritical + vbOKOnly, "Warning!")
                                FrmGeneral.txtLowFare.Focus()
                            Else
                                '    FrmGeneral.txtLowFare.Text = FrmGeneral.txtSellingFare.Text
                                FrmGeneral.txtRCodeDenied.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
                            End If
                        ElseIf Trim((RSfaresDenied.Fields("Comparison").Value).ToString()) = "Less Than" Then
                            If Trim(FrmGeneral.txtSellingFare.Text) = Nothing Then
                                MsgBox("Selling Fare must not be empty...", vbCritical + vbOKOnly, "Warning!")
                                FrmGeneral.txtSellingFare.Focus()
                            ElseIf Trim(FrmGeneral.txtLowFare.Text) = Nothing Then
                                MsgBox("Low Fare must not be empty...", vbCritical + vbOKOnly, "Warning!")
                                FrmGeneral.txtLowFare.Focus()
                            ElseIf Val(FrmGeneral.txtLowFare.Text.Trim) >= Val(FrmGeneral.txtSellingFare.Text.Trim) Then
                                MsgBox("Selling Fare must be higher than Low Fare...", vbCritical + vbOKOnly, "Warning!")
                                ' FrmGeneral.txtLowFare.Text = Nothing
                                FrmGeneral.txtLowFare.Focus()
                            Else
                                FrmGeneral.txtRCodeDenied.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
                            End If

                        End If

                    End If

                End With

                RSfaresDenied.Close()


            ElseIf Trim(FrmGeneral.txtSFSegment.Text) <> Nothing Then


                CHECK_RSfaresDenied()

                SQL_QUERY = "Select * from BCDMIS..C_ReasonCodeDenied where ClientID = '" & Trim(GlobalCustNO) & "' and  Code='" & Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value) & "'"
                RSfaresDenied.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RSfaresDenied

                    If Not RSfaresDenied.EOF Then

                        If Trim((RSfaresDenied.Fields("Comparison").Value).ToString()) = "Either" Then

                            If (Trim(FrmGeneral.txtSFSegment.Text) <> Nothing And Trim(FrmGeneral.txtLowFare.Text) = Nothing) Or
                               (Trim(FrmGeneral.txtSFSegment.Text) = Nothing And Trim(FrmGeneral.txtLowFare.Text) <> Nothing) Then
                                FrmGeneral.txtRCodeDenied.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
                            ElseIf (Trim(FrmGeneral.txtSFSegment.Text) = Nothing And Trim(FrmGeneral.txtLowFare.Text) = Nothing) Then
                                MsgBox("Either Selling or Low Fare must not be empty...", vbCritical + vbOKOnly, "Warning!")
                                FrmGeneral.txtSFSegment.Focus()
                            ElseIf (Trim(FrmGeneral.txtSFSegment.Text) <> Nothing And Trim(FrmGeneral.txtLowFare.Text) <> Nothing) Then
                                FrmGeneral.txtLowFare.Text = Nothing
                                FrmGeneral.txtRCodeDenied.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
                            End If

                        ElseIf Trim((RSfaresDenied.Fields("Comparison").Value).ToString()) = "Equal To" Then

                            If Trim(FrmGeneral.txtSFSegment.Text) = Nothing Then
                                MsgBox("Selling Fare must not be empty...", vbCritical + vbOKOnly, "Warning!")
                                FrmGeneral.txtSFSegment.Focus()
                            ElseIf Trim(FrmGeneral.txtLowFare.Text) = Nothing Then
                                MsgBox("Low Fare must not be empty...", vbCritical + vbOKOnly, "Warning!")
                                FrmGeneral.txtSFSegment.Focus()
                            ElseIf (Trim(FrmGeneral.txtSFSegment.Text > Trim(FrmGeneral.txtLowFare.Text)) Or (Trim(FrmGeneral.txtLowFare.Text) > Trim(FrmGeneral.txtSFSegment.Text))) Then
                                MsgBox("Selling Fare must be equal to Low Fare...", vbCritical + vbOKOnly, "Warning!")
                                FrmGeneral.txtLowFare.Focus()
                            Else
                                '    FrmGeneral.txtLowFare.Text = FrmGeneral.txtSFSegment.Text
                                FrmGeneral.txtRCodeDenied.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
                            End If

                        ElseIf Trim((RSfaresDenied.Fields("Comparison").Value).ToString()) = "Less Than" Then

                            If Trim(FrmGeneral.txtSFSegment.Text) = Nothing Then
                                MsgBox("Selling Fare must not be empty...", vbCritical + vbOKOnly, "Warning!")
                                FrmGeneral.txtSFSegment.Focus()
                            ElseIf Trim(FrmGeneral.txtLowFare.Text) = Nothing Then
                                MsgBox("Low Fare must not be empty...", vbCritical + vbOKOnly, "Warning!")
                                FrmGeneral.txtLowFare.Focus()
                            ElseIf Val(FrmGeneral.txtLowFare.Text.Trim) >= Val(FrmGeneral.txtSFSegment.Text.Trim) Then
                                MsgBox("Selling Fare must be higher than Low Fare...", vbCritical + vbOKOnly, "Warning!")
                                ' FrmGeneral.txtLowFare.Text = Nothing
                                FrmGeneral.txtLowFare.Focus()
                            Else
                                FrmGeneral.txtRCodeDenied.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
                            End If

                        End If

                    End If

                End With

                RSfaresDenied.Close()

            End If


        End If


        If CtrlListType = 19 Then

            If (FrmGeneral.txtReasonCode.Text) <> Nothing Then
                FrmGeneral.txtMajorClass.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
                'If (FrmGeneral.txtReasonCode.Text).Substring(0, 1) = "1" And (Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value) = "Y" Or Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value) = "T") Then
                '    FrmGeneral.txtMajorClass.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
                'ElseIf (FrmGeneral.txtReasonCode.Text).Substring(0, 1) = "2" And (Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value) = "C" Or Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value) = "L" Or Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value) = "T") Then
                '    FrmGeneral.txtMajorClass.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
                'ElseIf (FrmGeneral.txtReasonCode.Text).Substring(0, 1) = "3" And (Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value) = "F" Or Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value) = "L") Then
                '    FrmGeneral.txtMajorClass.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
                'Else
                '    MsgBox("Entry Does Not Match with Reason Code", vbCritical + vbOKOnly, "Warning!")
                '    FrmGeneral.txtMajorClass.Text = Nothing
                '    FrmGeneral.txtMajorClass.Focus()

                'End If

            Else
                MsgBox("Reason Code must not be empty...", vbCritical + vbOKOnly, "Warning!")
                FrmGeneral.TabCAPI.SelectedIndex = 1
                FrmGeneral.txtReasonCode.Focus()

            End If


        End If










        Me.Hide()



    End Sub

End Class