Public Class FrmAgentList

    Private Sub DGW_AgentSet_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGW_AgentSet.CellContentClick

        Dim strTemp As String

        strTemp = (DGW_AgentSet.Item("GDS Sign-In", DGW_AgentSet.CurrentCell.RowIndex).Value.ToString())

        CHECK_RS()

        SQL_QUERY = " Select * from TAIS..ProfileAgentInfo where InitialSignIn = '" & Trim(strTemp) & "'"
        RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        With RS
            If Not RS.EOF Then
                FrmGeneral.txtGDS_AgentSet.Text = (RS.Fields("InitialSignIn").Value).ToString()
                FrmGeneral.txtFirstName_AgentSet.Text = (RS.Fields("First_Name").Value).ToString()
                FrmGeneral.txtLastName_AgentSet.Text = (RS.Fields("last_Name").Value).ToString()
                FrmGeneral.txtQueueNo_AgentSet.Text = (RS.Fields("QueueNo").Value).ToString()
                FrmGeneral.txtContactNo_AgentSet.Text = (RS.Fields("ContactNo").Value).ToString()
                FrmGeneral.txtGroup_AgentSet.Text = (RS.Fields("TeamGroup").Value).ToString()
                FrmGeneral.txtPhoneField1_AgentSet.Text = (RS.Fields("AP").Value).ToString()
                FrmGeneral.txtPhoneField2_AgentSet.Text = (RS.Fields("CompanyName").Value).ToString()
                FrmGeneral.txtRemarks_AgentSet.Text = (RS.Fields("Remarks").Value).ToString()
                FrmGeneral.txtOthers_AgentSet.Text = (RS.Fields("Others").Value).ToString()
                FrmGeneral.cboStatus_AgentSet.Text = (RS.Fields("Status").Value).ToString()
                FrmGeneral.cboLevel_AgentSet.Text = (RS.Fields("AccessLevel").Value).ToString()
                FrmGeneral.cboDiv_AgentSet.Text = (RS.Fields("Div").Value).ToString()
                FrmGeneral.txtCreditAccess.Text = (RS.Fields("CreditCardAccess").Value).ToString()
                FrmGeneral.txtGDSPassword.Text = (RS.Fields("GDSSignIn").Value).ToString()
                Me.Hide()

            End If
            RS.Close()
        End With

        FrmGeneral.txtFirstName_AgentSet.Enabled = False
        FrmGeneral.txtLastName_AgentSet.Enabled = False
        FrmGeneral.cboDiv_AgentSet.Enabled = False
        FrmGeneral.txtQueueNo_AgentSet.Enabled = False
        FrmGeneral.txtGroup_AgentSet.Enabled = False
        FrmGeneral.txtContactNo_AgentSet.Enabled = False
        FrmGeneral.txtGDS_AgentSet.Enabled = False
        FrmGeneral.cboStatus_AgentSet.Enabled = False
        FrmGeneral.txtPhoneField1_AgentSet.Enabled = False
        FrmGeneral.txtPhoneField2_AgentSet.Enabled = False
        FrmGeneral.txtRemarks_AgentSet.Enabled = False
        FrmGeneral.txtOthers_AgentSet.Enabled = False
        FrmGeneral.cboLevel_AgentSet.Enabled = False

    End Sub



    Public Sub createGridViewHeader_AgentList()

        DGW_AgentSet.ColumnCount = 3
        DGW_AgentSet.ColumnHeadersVisible = True

        ' Set the column header style.
        Dim columnHeaderStyle As New DataGridViewCellStyle()

        columnHeaderStyle.BackColor = Color.CadetBlue

        columnHeaderStyle.Font = New Font("Arial", 7, FontStyle.Regular)

        DGW_AgentSet.ColumnHeadersDefaultCellStyle = columnHeaderStyle
        DGW_AgentSet.RowTemplate.Height = 16
        DGW_AgentSet.RowsDefaultCellStyle.Font = New Font("Arial", 7, FontStyle.Regular)

        ' Set the column header names.
        DGW_AgentSet.Columns(0).Name = "GDS Sign-In"
        DGW_AgentSet.Columns(0).Width = 100

        DGW_AgentSet.Columns(1).Name = "First Name"
        DGW_AgentSet.Columns(1).Width = 100

        DGW_AgentSet.Columns(2).Name = "Last Name"
        DGW_AgentSet.Columns(2).Width = 100

    End Sub

    Private Sub btnExit_Agent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit_Agent.Click
        Me.Hide()
    End Sub

End Class