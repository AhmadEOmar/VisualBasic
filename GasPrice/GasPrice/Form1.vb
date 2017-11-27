Public Class GasPrice

    Dim array(11) As Decimal

    Dim Counter As Integer = 0


    Private Sub EnterButton_Click(sender As Object, e As EventArgs) Handles EnterButton.Click

        If Counter < 12 Then

            array(Counter) = Convert.ToInt32(PriceLocation.Text)

            PriceLocation.Text = String.Empty

            Counter += 1
        End If
        If Counter = 12 Then
            PriceLocation.Enabled = False
            EnterButton.Enabled = False
        End If

    End Sub

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        For Each value In array
            ListView.Text &= Convert.ToString(value) & vbCrLf
        Next
    End Sub
End Class
