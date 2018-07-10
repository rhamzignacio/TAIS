<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFareType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFareType))
        Me.DGW1 = New System.Windows.Forms.DataGridView()
        Me.btnRCode = New System.Windows.Forms.Button()
        CType(Me.DGW1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGW1
        '
        Me.DGW1.AllowUserToAddRows = False
        Me.DGW1.AllowUserToResizeColumns = False
        Me.DGW1.AllowUserToResizeRows = False
        Me.DGW1.BackgroundColor = System.Drawing.Color.White
        Me.DGW1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGW1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DGW1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGW1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGW1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGW1.GridColor = System.Drawing.Color.SteelBlue
        Me.DGW1.Location = New System.Drawing.Point(12, 12)
        Me.DGW1.Name = "DGW1"
        Me.DGW1.ReadOnly = True
        Me.DGW1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGW1.Size = New System.Drawing.Size(456, 250)
        Me.DGW1.TabIndex = 53
        '
        'btnRCode
        '
        Me.btnRCode.BackColor = System.Drawing.Color.White
        Me.btnRCode.BackgroundImage = CType(resources.GetObject("btnRCode.BackgroundImage"), System.Drawing.Image)
        Me.btnRCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRCode.ForeColor = System.Drawing.Color.White
        Me.btnRCode.Location = New System.Drawing.Point(432, 259)
        Me.btnRCode.Name = "btnRCode"
        Me.btnRCode.Size = New System.Drawing.Size(46, 45)
        Me.btnRCode.TabIndex = 52
        Me.btnRCode.UseVisualStyleBackColor = False
        '
        'FrmFareType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(478, 316)
        Me.Controls.Add(Me.DGW1)
        Me.Controls.Add(Me.btnRCode)
        Me.Name = "FrmFareType"
        Me.Text = "List"
        CType(Me.DGW1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGW1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnRCode As System.Windows.Forms.Button
End Class
