<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSpecSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnAddClientList = New System.Windows.Forms.Button()
        Me.btnDeleteClient = New System.Windows.Forms.Button()
        Me.BtnCloseClient = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSpeClientName = New System.Windows.Forms.ComboBox()
        Me.ClientList = New System.Windows.Forms.DataGridView()
        Me.txtClientNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtClientID = New System.Windows.Forms.TextBox()
        CType(Me.ClientList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnAddClientList
        '
        Me.BtnAddClientList.Location = New System.Drawing.Point(232, 37)
        Me.BtnAddClientList.Name = "BtnAddClientList"
        Me.BtnAddClientList.Size = New System.Drawing.Size(59, 24)
        Me.BtnAddClientList.TabIndex = 1
        Me.BtnAddClientList.Text = "&Add"
        Me.BtnAddClientList.UseVisualStyleBackColor = True
        '
        'btnDeleteClient
        '
        Me.btnDeleteClient.Location = New System.Drawing.Point(233, 161)
        Me.btnDeleteClient.Name = "btnDeleteClient"
        Me.btnDeleteClient.Size = New System.Drawing.Size(59, 24)
        Me.btnDeleteClient.TabIndex = 3
        Me.btnDeleteClient.Text = "&Delete"
        Me.btnDeleteClient.UseVisualStyleBackColor = True
        '
        'BtnCloseClient
        '
        Me.BtnCloseClient.Location = New System.Drawing.Point(233, 306)
        Me.BtnCloseClient.Name = "BtnCloseClient"
        Me.BtnCloseClient.Size = New System.Drawing.Size(59, 22)
        Me.BtnCloseClient.TabIndex = 4
        Me.BtnCloseClient.Text = "Close"
        Me.BtnCloseClient.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Please Select Client Name :"
        '
        'txtSpeClientName
        '
        Me.txtSpeClientName.FormattingEnabled = True
        Me.txtSpeClientName.Location = New System.Drawing.Point(12, 39)
        Me.txtSpeClientName.Name = "txtSpeClientName"
        Me.txtSpeClientName.Size = New System.Drawing.Size(214, 21)
        Me.txtSpeClientName.TabIndex = 6
        '
        'ClientList
        '
        Me.ClientList.AllowUserToAddRows = False
        Me.ClientList.AllowUserToResizeColumns = False
        Me.ClientList.AllowUserToResizeRows = False
        Me.ClientList.BackgroundColor = System.Drawing.Color.White
        Me.ClientList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ClientList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ClientList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientList.GridColor = System.Drawing.Color.SteelBlue
        Me.ClientList.Location = New System.Drawing.Point(13, 161)
        Me.ClientList.Name = "ClientList"
        Me.ClientList.ReadOnly = True
        Me.ClientList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.ClientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ClientList.Size = New System.Drawing.Size(214, 210)
        Me.ClientList.TabIndex = 470
        '
        'txtClientNumber
        '
        Me.txtClientNumber.Location = New System.Drawing.Point(12, 126)
        Me.txtClientNumber.Name = "txtClientNumber"
        Me.txtClientNumber.ReadOnly = True
        Me.txtClientNumber.Size = New System.Drawing.Size(213, 20)
        Me.txtClientNumber.TabIndex = 471
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 472
        Me.Label2.Text = "Client Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 473
        Me.Label3.Text = "Client ID"
        '
        'txtClientID
        '
        Me.txtClientID.Location = New System.Drawing.Point(14, 85)
        Me.txtClientID.Name = "txtClientID"
        Me.txtClientID.ReadOnly = True
        Me.txtClientID.Size = New System.Drawing.Size(211, 20)
        Me.txtClientID.TabIndex = 474
        '
        'FrmSpecSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(299, 379)
        Me.Controls.Add(Me.txtClientID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtClientNumber)
        Me.Controls.Add(Me.ClientList)
        Me.Controls.Add(Me.txtSpeClientName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCloseClient)
        Me.Controls.Add(Me.btnDeleteClient)
        Me.Controls.Add(Me.BtnAddClientList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmSpecSettings"
        Me.Text = "Special Settings"
        CType(Me.ClientList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAddClientList As System.Windows.Forms.Button
    Friend WithEvents btnDeleteClient As System.Windows.Forms.Button
    Friend WithEvents BtnCloseClient As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSpeClientName As System.Windows.Forms.ComboBox
    Friend WithEvents ClientList As System.Windows.Forms.DataGridView
    Friend WithEvents txtClientNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtClientID As System.Windows.Forms.TextBox
End Class
