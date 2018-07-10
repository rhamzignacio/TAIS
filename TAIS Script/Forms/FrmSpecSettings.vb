Public Class FrmSpecSettings
    '==========TOEG==================================
    Dim SpecialClient As New AutoCompleteStringCollection


    Private Sub BtnCloseClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCloseClient.Click
        Me.Hide()
    End Sub


    Public Sub SelectClientList()

        CHECK_RS()

        SQL_QUERY = "Select * from TRAVCOM..PROFILES where profiletype= 0 and ProfileNumber not like '%100%' and Phonenumber4<>'' "
        RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        With RS
            Do While Not RS.EOF
                SpecialClient.Add(RS.Fields("FullName").Value).ToString()
                RS.MoveNext()
            Loop
        End With

        txtSpeClientName.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtSpeClientName.AutoCompleteCustomSource = SpecialClient
        txtSpeClientName.AutoCompleteMode = AutoCompleteMode.Suggest

    End Sub


    Private Sub BtnAddClientList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddClientList.Click

        Dim res As MsgBoxResult

        If Trim(txtClientNumber.Text) <> Nothing Or Trim(txtClientNumber.Text) <> "" Then

            res = MsgBox(" Do you want to Add New Record ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, " ::Settings:;")

            If res = MsgBoxResult.Yes Then

                CHECK_RS()

                SQL_QUERY = "Select * from BCDMIS..S_TOEG where clientNumber  = '" & Trim(txtClientNumber.Text) & "'"
                RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With RS
                    If Not RS.EOF Then
                        MsgBox("Error : Client is already in the list..", , " :: Settings :: ")
                        txtSpeClientName.Text = Nothing
                        txtClientNumber.Text = Nothing
                    Else


                        INS_QUERY = " Insert into BCDMIS..S_TOEG (ClientID, ClientNumber, Description)" _
                           & " values ('" & Trim(txtClientID.Text) & "','" & Trim(txtClientNumber.Text) & "','" & Trim(txtSpeClientName.Text) & "')"

                        CNN.Execute(INS_QUERY)

                        MsgBox("Record has been successfully added..", , " :: Settings :: ")
                        txtClientID.Text = Nothing
                        txtClientNumber.Text = Nothing
                        txtSpeClientName.Text = Nothing

                        Call SpecClients()

                    End If

                End With
                RS.Close()
            End If

        End If

    End Sub

    'Private Sub AddFields()


    '    Dim i As Integer

    '    If Trim(strClientNumber) <> Nothing Then
    '        createGridViewHeader_COD()
    '        i = ClientList.Rows.Add
    '        ClientList.Rows.Item(i).Cells(0).Value = Trim(txtClientNumber.Text)

    '    End If


    'End Sub

    Private Sub createGridViewHeader_COD()

        ClientList.ColumnCount = 1
        ClientList.ColumnHeadersVisible = True

        ' Set the column header style.
        Dim columnHeaderStyle As New DataGridViewCellStyle()

        columnHeaderStyle.BackColor = Color.CadetBlue

        columnHeaderStyle.Font = New Font("Arial", 7, FontStyle.Regular)

        ClientList.ColumnHeadersDefaultCellStyle = columnHeaderStyle
        ClientList.RowTemplate.Height = 20
        ClientList.RowsDefaultCellStyle.Font = New Font("Arial", 7, FontStyle.Regular)

        ' Set the column header names.
        ClientList.Columns(0).Name = "Client Number"
        ClientList.Columns(0).Width = 150


    End Sub


    Public Sub SpecClients()

        ClientList.Rows.Clear()
        ClientList.Columns.Clear()

        Dim xy As Integer = 0

        CHECK_RS1()

        SQL_QUERY = "Select * from BCDMIS..S_TOEG order by ClientNumber"
        RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        With RS1
            If Not RS1.EOF Then

                Call createGridViewHeader_COD()

                While Not RS1.EOF
                    ClientList.Rows.Add()
                    xy = ClientList.Rows.Count - 1
                    ClientList.Rows.Item(xy).Cells(0).Value = RS1.Fields("ClientNumber").Value.ToString
                    RS1.MoveNext()
                    xy = xy + 1
                End While

            End If

            RS1.Close()

        End With


    End Sub

  

    Private Sub txtSpeClientName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSpeClientName.KeyDown

        txtClientNumber.Text = Nothing
        txtClientID.Text = Nothing



        If e.KeyCode = 13 Then

            strCommand = Trim(txtSpeClientName.SelectedText)

            CHECK_RS()

            SQL_QUERY = "Select * from TRAVCOM..PROFILES where profiletype= 0 and fullname = '" & strCommand & "' and PhoneNumber4<>''"
            RS.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS

                If Not RS.EOF Then
                    txtClientNumber.Text = Trim(((RS.Fields("ProfileNumber").Value)))
                    txtClientID.Text = Trim(RS.Fields("PhoneNumber4").Value)

                End If

            End With

            RS.Close()

        End If

    End Sub


    Private Sub btnDeleteClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteClient.Click

        Dim Response As MsgBoxResult

        If ClientList.Rows.Count <> 0 Then

            Response = MsgBox("Delete ? Yes/No ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, ":::DELETE:::")

            If Response = MsgBoxResult.Yes Then

                If Not ClientList.CurrentRow.IsNewRow Then
                    ClientList.Rows.Remove(ClientList.CurrentRow)

                    If Trim(txtClientNumber.Text) <> Nothing Or Trim(txtClientNumber.Text) <> " " Then
                        DEL_QUERY = "Delete from BCDMIS..S_TOEG where ClientNumber ='" & Trim(txtClientNumber.Text) & "'"
                        CNN.Execute(DEL_QUERY)

                        MsgBox(" Client Number  has been remove successfully..", , ":::SETTINGS::")
                        Call SpecClients()
                        txtClientNumber.Text = Nothing
                        txtClientID.Text = Nothing
                        txtSpeClientName.Text = Nothing

                    End If
                    


                End If


               

            End If



        End If

       

    End Sub


    Private Sub ClientList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ClientList.CellContentClick

        If Me.ClientList.RowCount > 0 Then
            txtClientNumber.Text = ClientList.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        End If

    End Sub



End Class