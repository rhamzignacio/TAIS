<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgentList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgentList))
        Me.DGW_AgentSet = New System.Windows.Forms.DataGridView()
        Me.btnExit_Agent = New System.Windows.Forms.Button()
        CType(Me.DGW_AgentSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGW_AgentSet
        '
        Me.DGW_AgentSet.AllowUserToAddRows = False
        Me.DGW_AgentSet.AllowUserToResizeColumns = False
        Me.DGW_AgentSet.AllowUserToResizeRows = False
        Me.DGW_AgentSet.BackgroundColor = System.Drawing.Color.White
        Me.DGW_AgentSet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGW_AgentSet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGW_AgentSet.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGW_AgentSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGW_AgentSet.GridColor = System.Drawing.Color.SteelBlue
        Me.DGW_AgentSet.Location = New System.Drawing.Point(12, 12)
        Me.DGW_AgentSet.Name = "DGW_AgentSet"
        Me.DGW_AgentSet.ReadOnly = True
        Me.DGW_AgentSet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGW_AgentSet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGW_AgentSet.Size = New System.Drawing.Size(375, 348)
        Me.DGW_AgentSet.TabIndex = 49
        '
        'btnExit_Agent
        '
        Me.btnExit_Agent.BackgroundImage = CType(resources.GetObject("btnExit_Agent.BackgroundImage"), System.Drawing.Image)
        Me.btnExit_Agent.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit_Agent.Location = New System.Drawing.Point(353, 366)
        Me.btnExit_Agent.Name = "btnExit_Agent"
        Me.btnExit_Agent.Size = New System.Drawing.Size(34, 32)
        Me.btnExit_Agent.TabIndex = 50
        Me.btnExit_Agent.UseVisualStyleBackColor = True
        '
        'FrmAgentList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(401, 414)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit_Agent)
        Me.Controls.Add(Me.DGW_AgentSet)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAgentList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DGW_AgentSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGW_AgentSet As System.Windows.Forms.DataGridView
    Friend WithEvents btnExit_Agent As System.Windows.Forms.Button
End Class
