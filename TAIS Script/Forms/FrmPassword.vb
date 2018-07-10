Public Class FrmPassword

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Hide()
        FrmGeneral.ControlBox_Close.Visible = True
    End Sub


    Private Sub BtnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click

        If (Trim(txtId.Text) <> "" Or Trim(txtId.Text) <> Nothing) Then

            CHECK_RS1()

            SQL_QUERY = "Select * from TAIS..Users where UserId = '" & Trim(txtId.Text) & "'"
            RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS1

                If Not RS1.EOF Then

                    If (Trim(txtPassword.Text) <> "" Or Trim(txtPassword.Text) <> Nothing) Then

                        CHECK_RS2()

                        SQL_QUERY = "Select * from TAIS..Users where Password = '" & Trim(txtPassword.Text) & "'"
                        RS2.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                        With RS2
                            If Not RS2.EOF Then
                                Me.Hide()

                                ' Settings
                                FrmGeneral.ControlBox_Close.Visible = False
                                FrmGeneral.TabCAPI.SelectedIndex = 6

                            Else
                                MsgBox("Invalid Password..Please contact your admistrator..", , "LogIn Failed!")
                                FrmGeneral.ControlBox_Close.Visible = True
                                txtPassword.Text = ""
                                txtPassword.Focus()
                            End If

                        End With
                        RS2.Close()
                    Else
                        MsgBox("Password must not be empty..", , "Empty!")
                        FrmGeneral.ControlBox_Close.Visible = True
                        txtPassword.Text = ""
                        txtPassword.Focus()
                    End If

                Else
                    MsgBox("User ID not found..", , ":::Security Check::")
                    FrmGeneral.ControlBox_Close.Visible = True
                    txtId.Text = ""
                    txtId.Focus()
                End If

            End With
            RS1.Close()

        Else

            MsgBox("Admin ID must not be empty..", , ":::Security Check::")
            FrmGeneral.ControlBox_Close.Visible = True
            txtId.Focus()

        End If
    End Sub


    Private Sub Security_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtId.Text = ""
        txtPassword.Text = ""
        txtId.Focus()
    End Sub


End Class