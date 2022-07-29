Public Class medForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim resultMsg As DialogResult = MessageBox.Show("Are you sure, you want to exit",
                                                   "Important Question",
                                                   MessageBoxButtons.YesNo)
        If resultMsg = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim resultMsg As DialogResult = MessageBox.Show("Are you sure, you want to clear",
                                                      "Important Question",
                                                      MessageBoxButtons.YesNo)
    End Sub
End Class