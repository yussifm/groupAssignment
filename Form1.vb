'CopyRight CodedGroup (UG0268821,UG0297821, UG0447521, UG0442621, UG0388421)

Public Class Form1
    'Variables
    Dim n, t1, t2, sum As Integer
    Dim resultSum As Integer = 0
    Dim arrdata As Double() = {}

    Public Shared Function Median(data As Double()) As Double
        Array.Sort(data)

        If data.Length Mod 2 = 0 Then
            Return (data(data.Length \ 2 - 1) + data(data.Length \ 2)) / 2
        Else
            Return data(data.Length \ 2)
        End If
    End Function

    Private Sub FibonnaciSeriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FibonnaciSeriesToolStripMenuItem.Click
        Dim fibChildForm As New fibForm()
        fibChildForm.MdiParent = Me
        fibChildForm.Show()
    End Sub

    Private Sub ReverseSeriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReverseSeriesToolStripMenuItem.Click
        Dim revChildForm As New revForm()
        revChildForm.MdiParent = Me
        revChildForm.Show()
    End Sub

    Private Sub MedianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MedianToolStripMenuItem.Click
        Dim medChildForm As New medForm()
        medChildForm.MdiParent = Me
        medChildForm.Show()
    End Sub

    Private Sub SumToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SumToolStripMenuItem.Click


        Dim sumChildForm As New sumForm()
        sumChildForm.MdiParent = Me
        If (IsNumeric(limitTextBox.Text)) Then
            n = limitTextBox.Text
            For i = 0 To n
                If i = 0 Then
                    fibComboBox1.Items.Add(t1)

                ElseIf i = 2 Then
                    fibComboBox1.Items.Add(t2)

                Else
                    fibComboBox1.Items.Add(i)
                    sum = t1 + t2
                    t1 = t2
                    t2 = sum

                End If
            Next
        End If
        sumChildForm.sumLabel.Text = sum
        sumChildForm.sumLabel.Refresh()

        sumChildForm.Show()

    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        Dim resultMsg As DialogResult = MessageBox.Show("Are you sure, you want to clear",
                                                      "Important Question",
                                                      MessageBoxButtons.YesNo)
        If resultMsg = DialogResult.Yes Then
            limitTextBox.Text = " "
            sumLabel.Text = " "
            medLabel.Text = " "
            fibComboBox1.Items.Clear()
            reverseComboBox.Items.Clear()
            fibComboBox1.Refresh()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim resultMsg As DialogResult = MessageBox.Show("Are you sure, you want to exit",
                                                     "Important Question",
                                                     MessageBoxButtons.YesNo)
        If resultMsg = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Dim resultMsg As DialogResult = MessageBox.Show("Are you sure, you want to exit",
                                                    "Important Question",
                                                    MessageBoxButtons.YesNo)
        If resultMsg = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub crlBtn_Click(sender As Object, e As EventArgs) Handles crlBtn.Click
        Dim resultMsg As DialogResult = MessageBox.Show("Are you sure, you want to clear",
                                                    "Important Question",
                                                    MessageBoxButtons.YesNo)
        If resultMsg = DialogResult.Yes Then
            limitTextBox.Text = " "
            sumLabel.Text = " "
            medLabel.Text = " "
            fibComboBox1.Items.Clear()
            reverseComboBox.Items.Clear()
            reverseComboBox.Refresh()
            fibComboBox1.Refresh()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        t1 = 0
        t2 = 1
        sum = 0
        n = 0
        If (IsNumeric(limitTextBox.Text)) Then
            n = limitTextBox.Text
            For i = 0 To n
                If i = 0 Then
                    fibComboBox1.Items.Add(t1)
                    fibComboBox1.Refresh()
                ElseIf i = 2 Then
                    fibComboBox1.Items.Add(t2)
                    fibComboBox1.Refresh()
                Else
                    fibComboBox1.Items.Add(i)
                    sum = t1 + t2
                    t1 = t2
                    t2 = sum
                    fibComboBox1.Refresh()
                End If
            Next
        End If
    End Sub

    Private Sub sumBtn_Click(sender As Object, e As EventArgs) Handles sumBtn.Click
        If (IsNumeric(limitTextBox.Text)) Then
            n = limitTextBox.Text
            For i = 0 To n
                If i = 0 Then
                    sumLabel.Text = t1
                    sumLabel.Refresh()
                ElseIf i = 2 Or 1 Then
                    sumLabel.Text = t2
                    sumLabel.Refresh()
                Else
                    sum = t1 + t2
                    t1 = t2
                    t2 = sum

                    resultSum += sum
                    sumLabel.Text = resultSum
                    sumLabel.Refresh()

                End If
            Next
        End If
    End Sub

    Private Sub revSeriesBtn_Click(sender As Object, e As EventArgs) Handles revSeriesBtn.Click
        If (IsNumeric(limitTextBox.Text)) Then
            n = limitTextBox.Text
            For i = 0 To n
                ReDim arrdata(i)
                If i = 0 Then
                    reverseComboBox.Items.Add(t1)
                    reverseComboBox.Refresh()
                ElseIf i = 2 Then
                    reverseComboBox.Items.Add(t2)
                    reverseComboBox.Refresh()
                Else

                    sum = t1 + t2
                    t1 = t2
                    t2 = sum
                    arrdata.Append(sum)
                    Dim result = arrdata.Reverse()
                    For Each revNum In result
                        reverseComboBox.Items.Add(result)
                        reverseComboBox.Refresh()
                    Next



                End If
            Next
        End If
    End Sub

    Private Sub medBtn_Click(sender As Object, e As EventArgs) Handles medBtn.Click
        If (IsNumeric(limitTextBox.Text)) Then
            n = limitTextBox.Text
            For i = 0 To n
                If i = 0 Then
                    medLabel.Text = t1
                ElseIf i = 2 Or 1 Then
                    medLabel.Text = t2
                Else
                    sum = t1 + t2
                    t1 = t2
                    t2 = sum
                    arrdata.Append(sum)
                    Dim result = Median(arrdata)
                    medLabel.Text = result
                    medLabel.Refresh()

                End If
            Next
        End If
    End Sub

    Private Sub GroupMembersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GroupMembersToolStripMenuItem.Click
        Dim resultMsg As DialogResult = MessageBox.Show("UG0268821" & vbCrLf & "UG0388421" & vbCrLf & "UG0442621" & vbCrLf & "UG0447521" & vbCrLf & "UG0297821" & vbCrLf & "UG0456021" & vbCrLf & "UG0344821" & vbCrLf & "UG0297721" & vbCrLf & "UG0344321" & vbCrLf & "UG0422121",
                                                   "Members ID",
                                                   MessageBoxButtons.OK
                                                   )
    End Sub

    Private Sub fibSeriesBtn_Click(sender As Object, e As EventArgs) Handles fibSeriesBtn.Click
        If (IsNumeric(limitTextBox.Text)) Then
            n = limitTextBox.Text
            For i = 0 To n
                If i = 0 Then
                    fibComboBox1.Items.Add(t1)
                    fibComboBox1.Refresh()
                ElseIf i = 2 Then
                    fibComboBox1.Items.Add(t2)
                    fibComboBox1.Refresh()
                Else

                    sum = t1 + t2
                    t1 = t2
                    t2 = sum
                    fibComboBox1.Items.Add(sum)
                    fibComboBox1.Refresh()

                End If
            Next
        End If

    End Sub

    Private Sub fibComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles fibComboBox1.SelectedIndexChanged

    End Sub

    Private Sub limitTextBox_TextChanged(sender As Object, e As EventArgs) Handles limitTextBox.TextChanged

    End Sub
End Class
