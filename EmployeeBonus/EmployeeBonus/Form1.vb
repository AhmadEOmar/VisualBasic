'Employee bonus application
'Hong Cui 2/16/2014
Option Strict On  'all data conversion will be performed explicitly
Public Class Form1

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        'declare all input and output data
        Dim name As String = ""
        Dim salary As Decimal = 0D
        Dim year As Integer = 0
        Dim bonus As Decimal = 0D
        'call GetInoputs to get all input data and return these data
        GetInputs(name, salary, year)
        'call CalculateBonus function calculate and return bonus
        bonus = CalculateBonus(salary, year)
        'call DisplayResults method to display the output data
        DisplayResults(name, salary, year, bonus)
        'show controls of output view
        ResultListBox.Visible = True
        BackButton.Visible = True
        'Hide submit button
        SubmitButton.Visible = False
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        'hide controls of output view
        ResultListBox.Visible = False
        BackButton.Visible = False
        'show Submit button
        SubmitButton.Visible = True
        'clear the previous input data
        NameTextBox.Text = ""
        SalaryTextBox.Text = ""
        YearTextBox.Text = ""
    End Sub

    'method to get all input data and return to the caller
    '3 input data will be returned, so this could not be a function since function only returns 1 data 
    'sub does not have Return statement, so 3 ByRef parameters (memory locations) are needed 
    'input data will be saved in passed memory locations directly 
    Sub GetInputs(ByRef name As String, ByRef sal As Decimal, ByRef year As Integer)
        name = NameTextBox.Text
        sal = Convert.ToDecimal(Val(SalaryTextBox.Text))
        year = Convert.ToInt32(Val(YearTextBox.Text))
    End Sub

    'function to calculate and return bonus
    Function CalculateBonus(sal As Decimal, year As Integer) As Decimal
        Dim bonus As Decimal
        If sal < 50000 Then
            If year >= 10 Then
                bonus = Convert.ToDecimal(sal * 0.05)
            Else
                bonus = Convert.ToDecimal(sal * 0.03)
            End If
        Else
            bonus = 0D
        End If
        Return bonus
    End Function

    'method to display output ionformation
    'Only the copies of employee's data are needed, so ByVal (can be skipped) parameters are passed 
    Sub DisplayResults(name As String, sal As Decimal, year As Integer, bonus As Decimal)
        ResultListBox.Items.Clear() 'clear the previous outputs
        ResultListBox.Items.Add("Name: " & name)
        ResultListBox.Items.Add(String.Format("Salary: {0:c2}", sal))
        ResultListBox.Items.Add("Year: " & year)
        ResultListBox.Items.Add(String.Format("Bonus: {0:c2}", bonus))
    End Sub

  
   

End Class
