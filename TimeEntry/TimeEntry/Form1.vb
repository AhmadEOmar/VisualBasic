'Ahmad Omar
'Time Entry Project

Public Class TimeEntry

    Private Sub SubmitTime_Click(sender As Object, e As EventArgs) Handles SubmitTime.Click

        'Allows user to input information

        If TimeListBox.Items.Count < 5 Then
            'Adds hours to the list

            TimeListBox.Items.Add(HourBox.Text)
            TimeListBox.ClearSelected()
            TimeListBox.Focus()
        End If

        If TimeListBox.Items.Count = 5 Then
            GetPayment.Enabled = True
            SubmitTime.Enabled = False
        End If


    End Sub

    Private Sub GetPayment_Click(sender As Object, e As EventArgs) Handles GetPayment.Click

        Dim total As Integer
        Dim TimeCount As Integer
        Dim GetPayment As Integer
        Dim Time As Integer

        total = 0
        TimeCount = 0

        Do While TimeCount < TimeListBox.Items.Count
            Time = TimeListBox.Items(TimeCount)
            total += Time
            TimeCount += 1
        Loop


        If TimeCount <> 0 Then
            GetPayment = total * TimeListBox.Items.Count

            PaymentLable.Text = "$" & GetPayment

        Else
            PaymentLable.Text = "No hours were entered"

            If Time <= 20 Then

                GetPayment = total * TimeListBox.Items.Count * 10
            End If


        End If


    End Sub

    Private Sub ClearTime_Click(sender As Object, e As EventArgs) Handles ClearTime.Click
        TimeListBox.Items.Clear()
        PaymentLable.Text = String.Empty
        SubmitTime.Enabled = True
        GetPayment.Enabled = False
    End Sub
End Class

