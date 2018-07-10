Public Class FrmPasswordMIS

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Hide()
        buttonFalse()
        FrmGeneral.TabCAPI.SelectedIndex = 4
        FrmGeneral.initAccess()
        FrmGeneral.AgentSet_MainInit()
        FrmGeneral.AgentSet_AccessInit()

    End Sub


    Private Sub BtnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click

        If (Trim(txtId.Text) <> "" Or Trim(txtId.Text) <> Nothing) Then

            CHECK_RS3()

            SQL_QUERY = "Select * from TAIS..Users where UserId = '" & Trim(txtId.Text) & "'"
            RS3.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS3

                If Not RS3.EOF Then

                    If (Trim(txtPassword.Text) <> "" Or Trim(txtPassword.Text) <> Nothing) Then

                        CHECK_RS2()

                        SQL_QUERY = "Select * from TAIS..Users where Password = '" & Trim(txtPassword.Text) & "'"
                        RS2.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                        With RS2
                            If Not RS2.EOF Then
                                Me.Hide()
                                FrmGeneral.initAccess()
                                FrmGeneral.AgentSet_MainInit()
                                FrmGeneral.AgentSet_AccessInit()
                                FrmMISSettings.Show()
                                buttonTrue()
                                FrmGeneral.TabCAPI.SelectedIndex = 4

                            Else
                                MsgBox("Invalid Password..Please contact your admistrator..", , "LogIn Failed!")
                                FrmGeneral.TabCAPI.SelectedIndex = 4
                                txtPassword.Text = ""
                                txtPassword.Focus()
                                buttonFalse()
                            End If

                        End With

                    Else
                        MsgBox("Password must not be empty..", , "Empty!")
                        FrmGeneral.TabCAPI.SelectedIndex = 4
                        txtPassword.Text = ""
                        txtPassword.Focus()
                        buttonFalse()
                    End If

                Else
                    MsgBox("User ID not found..", , ":::Security Check::")
                    FrmGeneral.TabCAPI.SelectedIndex = 4
                    txtId.Text = ""
                    txtId.Focus()
                    buttonFalse()
                End If

            End With

        Else
            MsgBox("Admin ID must not be empty..", , ":::Security Check::")
            FrmGeneral.TabCAPI.SelectedIndex = 4
            buttonFalse()
            txtId.Focus()
        End If

        RS3.Close()
        RS2.Close()

    End Sub


    Private Sub Security_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtId.Text = ""
        txtPassword.Text = ""
        txtId.Focus()

    End Sub


    Private Sub buttonTrue()

        FrmGeneral.btnRCdes.Enabled = True
        FrmGeneral.btnLFare.Enabled = True
        FrmGeneral.btnCurrCode.Enabled = True
        FrmGeneral.btnEmployeeNo.Enabled = True
        FrmGeneral.btnTravName.Enabled = True
        FrmGeneral.btnTravStatus.Enabled = True
        FrmGeneral.btnCostCenter.Enabled = True
        FrmGeneral.btnProjNo.Enabled = True
        FrmGeneral.btnDeptNo.Enabled = True
        FrmGeneral.btnOrderRef.Enabled = True
        FrmGeneral.btnApprover.Enabled = True
        FrmGeneral.btnApproverCode.Enabled = True
        FrmGeneral.btnMgrSup.Enabled = True
        FrmGeneral.btnReasonTrip.Enabled = True
        FrmGeneral.btnMajorClass.Enabled = True
        FrmGeneral.btnStopOverFlag.Enabled = True
        FrmGeneral.btnTourCode.Enabled = True
        FrmGeneral.btnReasonCode.Enabled = True
        FrmGeneral.btnRCode.Enabled = True
        FrmGeneral.btnHotlReasonCd.Enabled = True
        FrmGeneral.btnHotelBookedFlag.Enabled = True
        FrmGeneral.btnAReasonCD.Enabled = True
        FrmGeneral.btnCarBookedFlag.Enabled = True
        FrmGeneral.btnSalesChannel.Enabled = True
        FrmGeneral.btnRecordType.Enabled = True
        FrmGeneral.btnCSData1.Enabled = True
        FrmGeneral.btnCSData2.Enabled = True
        FrmGeneral.btnCSData3.Enabled = True
        FrmGeneral.btnCSData4.Enabled = True
        FrmGeneral.btnCSData5.Enabled = True
        FrmGeneral.btnCSData6.Enabled = True
        FrmGeneral.btnCSData7.Enabled = True
        FrmGeneral.btnCSData8.Enabled = True
        FrmGeneral.btnCSData12.Enabled = True
        FrmGeneral.btnAddClient.Enabled = True

    End Sub



    Public Sub buttonFalse()

        FrmGeneral.btnRCdes.Enabled = False
        FrmGeneral.btnLFare.Enabled = False
        FrmGeneral.btnCurrCode.Enabled = False
        FrmGeneral.btnEmployeeNo.Enabled = False
        FrmGeneral.btnTravName.Enabled = False
        FrmGeneral.btnTravStatus.Enabled = False
        FrmGeneral.btnCostCenter.Enabled = False
        FrmGeneral.btnProjNo.Enabled = False
        FrmGeneral.btnDeptNo.Enabled = False
        FrmGeneral.btnOrderRef.Enabled = False
        FrmGeneral.btnApprover.Enabled = False
        FrmGeneral.btnApproverCode.Enabled = False
        FrmGeneral.btnMgrSup.Enabled = False
        FrmGeneral.btnReasonTrip.Enabled = False
        FrmGeneral.btnMajorClass.Enabled = False
        FrmGeneral.btnStopOverFlag.Enabled = False
        FrmGeneral.btnTourCode.Enabled = False
        FrmGeneral.btnReasonCode.Enabled = False
        FrmGeneral.btnRCode.Enabled = False
        FrmGeneral.btnHotlReasonCd.Enabled = False
        FrmGeneral.btnHotelBookedFlag.Enabled = False
        FrmGeneral.btnAReasonCD.Enabled = False
        FrmGeneral.btnCarBookedFlag.Enabled = False
        FrmGeneral.btnSalesChannel.Enabled = False
        FrmGeneral.btnRecordType.Enabled = False
        FrmGeneral.btnCSData1.Enabled = False
        FrmGeneral.btnCSData2.Enabled = False
        FrmGeneral.btnCSData3.Enabled = False
        FrmGeneral.btnCSData4.Enabled = False
        FrmGeneral.btnCSData5.Enabled = False
        FrmGeneral.btnCSData6.Enabled = False
        FrmGeneral.btnCSData7.Enabled = False
        FrmGeneral.btnCSData8.Enabled = False
        FrmGeneral.btnCSData12.Enabled = False
        FrmGeneral.btnAddClient.Enabled = False

    End Sub

End Class