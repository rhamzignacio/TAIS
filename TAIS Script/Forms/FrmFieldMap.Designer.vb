<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFieldMap
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
        Me.btnCloseField = New System.Windows.Forms.Button()
        Me.btnSaveMapping = New System.Windows.Forms.Button()
        Me.btnAddEdit = New System.Windows.Forms.Button()
        Me.txtFieldMapping = New System.Windows.Forms.TextBox()
        Me.txtBCDEntry = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAbacusEntry = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCloseField
        '
        Me.btnCloseField.Location = New System.Drawing.Point(265, 178)
        Me.btnCloseField.Name = "btnCloseField"
        Me.btnCloseField.Size = New System.Drawing.Size(92, 23)
        Me.btnCloseField.TabIndex = 6
        Me.btnCloseField.Text = "&Close"
        Me.btnCloseField.UseVisualStyleBackColor = True
        '
        'btnSaveMapping
        '
        Me.btnSaveMapping.Location = New System.Drawing.Point(175, 178)
        Me.btnSaveMapping.Name = "btnSaveMapping"
        Me.btnSaveMapping.Size = New System.Drawing.Size(92, 23)
        Me.btnSaveMapping.TabIndex = 5
        Me.btnSaveMapping.Text = "&Save"
        Me.btnSaveMapping.UseVisualStyleBackColor = True
        '
        'btnAddEdit
        '
        Me.btnAddEdit.Location = New System.Drawing.Point(70, 178)
        Me.btnAddEdit.Name = "btnAddEdit"
        Me.btnAddEdit.Size = New System.Drawing.Size(106, 23)
        Me.btnAddEdit.TabIndex = 4
        Me.btnAddEdit.Text = "&Add/Edit"
        Me.btnAddEdit.UseVisualStyleBackColor = True
        '
        'txtFieldMapping
        '
        Me.txtFieldMapping.Enabled = False
        Me.txtFieldMapping.Location = New System.Drawing.Point(29, 141)
        Me.txtFieldMapping.Name = "txtFieldMapping"
        Me.txtFieldMapping.Size = New System.Drawing.Size(345, 20)
        Me.txtFieldMapping.TabIndex = 3
        '
        'txtBCDEntry
        '
        Me.txtBCDEntry.Enabled = False
        Me.txtBCDEntry.Location = New System.Drawing.Point(29, 42)
        Me.txtBCDEntry.Name = "txtBCDEntry"
        Me.txtBCDEntry.Size = New System.Drawing.Size(345, 20)
        Me.txtBCDEntry.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(27, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Field Mapping/Equivalent :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(28, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "BCD/SMD Entry :"
        '
        'txtAbacusEntry
        '
        Me.txtAbacusEntry.Enabled = False
        Me.txtAbacusEntry.Location = New System.Drawing.Point(29, 90)
        Me.txtAbacusEntry.Name = "txtAbacusEntry"
        Me.txtAbacusEntry.Size = New System.Drawing.Size(345, 20)
        Me.txtAbacusEntry.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(28, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Abacus Entry :"
        '
        'FrmFieldMap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(407, 221)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtAbacusEntry)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCloseField)
        Me.Controls.Add(Me.btnSaveMapping)
        Me.Controls.Add(Me.btnAddEdit)
        Me.Controls.Add(Me.txtFieldMapping)
        Me.Controls.Add(Me.txtBCDEntry)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmFieldMap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Field Mapping"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCloseField As System.Windows.Forms.Button
    Friend WithEvents btnSaveMapping As System.Windows.Forms.Button
    Friend WithEvents btnAddEdit As System.Windows.Forms.Button
    Friend WithEvents txtFieldMapping As System.Windows.Forms.TextBox
    Friend WithEvents txtBCDEntry As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAbacusEntry As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
