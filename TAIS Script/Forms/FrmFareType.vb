Public Class FrmFareType

    Private rowSelected As Integer
    Dim ctr As Integer = 0

    Public Sub frmFareType()

        '==Clear all the products found in the list
        DGW1.Rows.Clear()
        DGW1.Columns.Clear()
        DGW1.ColumnHeadersVisible = False
        DGW1.RowHeadersVisible = False


        If Trim(GlobalCustNO) <> Nothing Then

            Call createGridViewHeader()

            CHECK_RS1()

            SQL_QUERY = "Select * from BCDMIS..ReasonCode where GlobalCustNo = '" & Trim(GlobalCustNO) & "' "
            RS1.Open(SQL_QUERY, CNN, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With RS1

                Do While Not RS1.EOF

                    If Not RS1.EOF Then

                        DGW1.Rows.Add()
                        ctr = DGW1.Rows.Count - 1

                        DGW1.Rows.Item(ctr).Cells(0).Value = Trim((RS1.Fields("GroCode").Value).ToString())
                        DGW1.Rows.Item(ctr).Cells(1).Value = Trim((RS1.Fields("Description").Value).ToString())

                        RS1.MoveNext()

                    End If

                Loop

            End With

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


    Private Sub DGW1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGW1.CellClick
        rowSelected = e.RowIndex
        '  FrmBCDMIS.txtReasonCode.Text = Trim(DGW1.Rows.Item(rowSelected).Cells(0).Value)
    End Sub

    Private Sub btnRCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRCode.Click
        Me.Hide()
        ' FrmBCDMIS.Show()
    End Sub


End Class