'AverageApplication
'Ahmad Omar
'09/03/2015


Public Class AverageApplication

    Private Sub Average_Click(sender As Object, e As EventArgs) Handles Average.Click

        'Declaring Variables 
        Dim Test1Score As Integer = 0
        Dim Test2Score As Integer = 0
        Dim Test3Score As Integer = 0
        Dim AverageScore As Integer = 0

        'Gathering Input
        Test1Score = TextBox1.Text
        Test2Score = TextBox2.Text
        Test3Score = TextBox3.Text

        'Calculate input
        AverageScore = (Test1Score + Test2Score + Test3Score) / 3

        'Display Output
        AverageOutput.Text = AverageScore

    End Sub
End Class
