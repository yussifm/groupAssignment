<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sumForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sumLabel = New System.Windows.Forms.Label()
        Me.sumCtrlBtn = New System.Windows.Forms.Button()
        Me.sumExitBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(123, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sum of Series"
        '
        'sumLabel
        '
        Me.sumLabel.AutoSize = True
        Me.sumLabel.Location = New System.Drawing.Point(149, 51)
        Me.sumLabel.Name = "sumLabel"
        Me.sumLabel.Size = New System.Drawing.Size(0, 15)
        Me.sumLabel.TabIndex = 1
        '
        'sumCtrlBtn
        '
        Me.sumCtrlBtn.Location = New System.Drawing.Point(123, 114)
        Me.sumCtrlBtn.Name = "sumCtrlBtn"
        Me.sumCtrlBtn.Size = New System.Drawing.Size(75, 23)
        Me.sumCtrlBtn.TabIndex = 2
        Me.sumCtrlBtn.Text = "Clear All"
        Me.sumCtrlBtn.UseVisualStyleBackColor = True
        '
        'sumExitBtn
        '
        Me.sumExitBtn.Location = New System.Drawing.Point(234, 114)
        Me.sumExitBtn.Name = "sumExitBtn"
        Me.sumExitBtn.Size = New System.Drawing.Size(75, 23)
        Me.sumExitBtn.TabIndex = 3
        Me.sumExitBtn.Text = "Exit"
        Me.sumExitBtn.UseVisualStyleBackColor = True
        '
        'sumForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.ClientSize = New System.Drawing.Size(342, 149)
        Me.Controls.Add(Me.sumExitBtn)
        Me.Controls.Add(Me.sumCtrlBtn)
        Me.Controls.Add(Me.sumLabel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "sumForm"
        Me.Text = "sumForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents sumLabel As Label
    Friend WithEvents sumCtrlBtn As Button
    Friend WithEvents sumExitBtn As Button
End Class
