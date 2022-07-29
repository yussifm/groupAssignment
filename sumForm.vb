'CopyRight CodedGroup (UG0268821,UG0297821, UG0447521, UG0442621, UG0388421)

Public Class sumForm
    Private Sub sumForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sumLabel.Text = ""

    End Sub

    Private Sub sumCtrlBtn_Click(sender As Object, e As EventArgs) Handles sumCtrlBtn.Click
        Dim resultMsg As DialogResult = MessageBox.Show("Are you sure, you want to clear",
                                                      "Important Question",
                                                      MessageBoxButtons.YesNo)
        If resultMsg = DialogResult.Yes Then
            sumLabel.Text = " "
        End If

    End Sub

    Private Sub sumExitBtn_Click(sender As Object, e As EventArgs) Handles sumExitBtn.Click
        Dim resultMsg As DialogResult = MessageBox.Show("Are you sure, you want to exit",
                                                    "Important Question",
                                                    MessageBoxButtons.YesNo)
        If resultMsg = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub
End Class