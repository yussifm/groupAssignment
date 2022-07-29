<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FibonnaciSeriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReverseSeriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupMembersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.limitTextBox = New System.Windows.Forms.TextBox()
        Me.fibSeriesBtn = New System.Windows.Forms.Button()
        Me.crlBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.fibComboBox1 = New System.Windows.Forms.ComboBox()
        Me.revSeriesBtn = New System.Windows.Forms.Button()
        Me.sumBtn = New System.Windows.Forms.Button()
        Me.medBtn = New System.Windows.Forms.Button()
        Me.reverseComboBox = New System.Windows.Forms.ComboBox()
        Me.sumLabel = New System.Windows.Forms.Label()
        Me.medLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(1191, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FibonnaciSeriesToolStripMenuItem, Me.ReverseSeriesToolStripMenuItem, Me.MedianToolStripMenuItem, Me.SumToolStripMenuItem, Me.ClearAllToolStripMenuItem, Me.ExitToolStripMenuItem, Me.GroupMembersToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(42, 21)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'FibonnaciSeriesToolStripMenuItem
        '
        Me.FibonnaciSeriesToolStripMenuItem.Name = "FibonnaciSeriesToolStripMenuItem"
        Me.FibonnaciSeriesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FibonnaciSeriesToolStripMenuItem.Text = "Fibonnaci series"
        '
        'ReverseSeriesToolStripMenuItem
        '
        Me.ReverseSeriesToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.ReverseSeriesToolStripMenuItem.Name = "ReverseSeriesToolStripMenuItem"
        Me.ReverseSeriesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReverseSeriesToolStripMenuItem.Text = "Reverse series"
        '
        'MedianToolStripMenuItem
        '
        Me.MedianToolStripMenuItem.Name = "MedianToolStripMenuItem"
        Me.MedianToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MedianToolStripMenuItem.Text = "Median"
        '
        'SumToolStripMenuItem
        '
        Me.SumToolStripMenuItem.Name = "SumToolStripMenuItem"
        Me.SumToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SumToolStripMenuItem.Text = "Sum"
        '
        'ClearAllToolStripMenuItem
        '
        Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
        Me.ClearAllToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClearAllToolStripMenuItem.Text = "Clear All"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'GroupMembersToolStripMenuItem
        '
        Me.GroupMembersToolStripMenuItem.Name = "GroupMembersToolStripMenuItem"
        Me.GroupMembersToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GroupMembersToolStripMenuItem.Text = "Group Members"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(484, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter Limit of sequence"
        '
        'limitTextBox
        '
        Me.limitTextBox.Location = New System.Drawing.Point(695, 129)
        Me.limitTextBox.Name = "limitTextBox"
        Me.limitTextBox.Size = New System.Drawing.Size(100, 23)
        Me.limitTextBox.TabIndex = 4
        '
        'fibSeriesBtn
        '
        Me.fibSeriesBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.fibSeriesBtn.Location = New System.Drawing.Point(484, 216)
        Me.fibSeriesBtn.Name = "fibSeriesBtn"
        Me.fibSeriesBtn.Size = New System.Drawing.Size(171, 23)
        Me.fibSeriesBtn.TabIndex = 5
        Me.fibSeriesBtn.Text = "Fibonnaci Series"
        Me.fibSeriesBtn.UseVisualStyleBackColor = True
        '
        'crlBtn
        '
        Me.crlBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.crlBtn.Location = New System.Drawing.Point(989, 382)
        Me.crlBtn.Name = "crlBtn"
        Me.crlBtn.Size = New System.Drawing.Size(75, 23)
        Me.crlBtn.TabIndex = 6
        Me.crlBtn.Text = "Clear All"
        Me.crlBtn.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.exitBtn.Location = New System.Drawing.Point(1079, 382)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(75, 23)
        Me.exitBtn.TabIndex = 7
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'fibComboBox1
        '
        Me.fibComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.fibComboBox1.FormattingEnabled = True
        Me.fibComboBox1.Location = New System.Drawing.Point(484, 264)
        Me.fibComboBox1.Name = "fibComboBox1"
        Me.fibComboBox1.Size = New System.Drawing.Size(171, 23)
        Me.fibComboBox1.TabIndex = 8
        '
        'revSeriesBtn
        '
        Me.revSeriesBtn.Location = New System.Drawing.Point(695, 216)
        Me.revSeriesBtn.Name = "revSeriesBtn"
        Me.revSeriesBtn.Size = New System.Drawing.Size(181, 23)
        Me.revSeriesBtn.TabIndex = 10
        Me.revSeriesBtn.Text = "Reverse Series"
        Me.revSeriesBtn.UseVisualStyleBackColor = True
        '
        'sumBtn
        '
        Me.sumBtn.Location = New System.Drawing.Point(960, 216)
        Me.sumBtn.Name = "sumBtn"
        Me.sumBtn.Size = New System.Drawing.Size(75, 23)
        Me.sumBtn.TabIndex = 11
        Me.sumBtn.Text = "Sum"
        Me.sumBtn.UseVisualStyleBackColor = True
        '
        'medBtn
        '
        Me.medBtn.Location = New System.Drawing.Point(1063, 216)
        Me.medBtn.Name = "medBtn"
        Me.medBtn.Size = New System.Drawing.Size(75, 23)
        Me.medBtn.TabIndex = 12
        Me.medBtn.Text = "Median"
        Me.medBtn.UseVisualStyleBackColor = True
        '
        'reverseComboBox
        '
        Me.reverseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.reverseComboBox.FormattingEnabled = True
        Me.reverseComboBox.Location = New System.Drawing.Point(695, 264)
        Me.reverseComboBox.Name = "reverseComboBox"
        Me.reverseComboBox.Size = New System.Drawing.Size(181, 23)
        Me.reverseComboBox.TabIndex = 13
        '
        'sumLabel
        '
        Me.sumLabel.AutoSize = True
        Me.sumLabel.Location = New System.Drawing.Point(972, 267)
        Me.sumLabel.Name = "sumLabel"
        Me.sumLabel.Size = New System.Drawing.Size(0, 15)
        Me.sumLabel.TabIndex = 14
        '
        'medLabel
        '
        Me.medLabel.AutoSize = True
        Me.medLabel.Location = New System.Drawing.Point(1079, 267)
        Me.medLabel.Name = "medLabel"
        Me.medLabel.Size = New System.Drawing.Size(0, 15)
        Me.medLabel.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumPurple
        Me.ClientSize = New System.Drawing.Size(1191, 450)
        Me.Controls.Add(Me.medLabel)
        Me.Controls.Add(Me.sumLabel)
        Me.Controls.Add(Me.reverseComboBox)
        Me.Controls.Add(Me.medBtn)
        Me.Controls.Add(Me.sumBtn)
        Me.Controls.Add(Me.revSeriesBtn)
        Me.Controls.Add(Me.fibComboBox1)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.crlBtn)
        Me.Controls.Add(Me.fibSeriesBtn)
        Me.Controls.Add(Me.limitTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Coded Group Fib"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FibonnaciSeriesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReverseSeriesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SumToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents limitTextBox As TextBox
    Friend WithEvents fibSeriesBtn As Button
    Friend WithEvents crlBtn As Button
    Friend WithEvents exitBtn As Button
    Friend WithEvents fibComboBox1 As ComboBox
    Friend WithEvents revSeriesBtn As Button
    Friend WithEvents sumBtn As Button
    Friend WithEvents medBtn As Button
    Friend WithEvents reverseComboBox As ComboBox
    Friend WithEvents sumLabel As Label
    Friend WithEvents medLabel As Label
    Friend WithEvents GroupMembersToolStripMenuItem As ToolStripMenuItem
End Class
