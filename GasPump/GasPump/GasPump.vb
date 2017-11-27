'Gas Pump application
'Hong Cui
Option Strict On 'require to convert data type explicitly
Public Class GasPump

    'global variables are declred outside any nethods
    'they are used by two or more methods
    Dim gallons As Integer = 0 ' number of gallons
    Dim total As Decimal = 0D 'initializa decimal value using letter D 
    Const REGULAR As Decimal = 2.69D
    Const SPECIAL As Decimal = 2.79D
    Const SUPER As Decimal = 2.89D

    ' handles Regular Button's Click event
    Private Sub regularButton_Click(ByVal sender As System.Object,
       ByVal e As System.EventArgs) Handles regularButton.Click
        'get input gallons, convert type exlicitly
        gallons = Convert.ToInt32(gallonsTextBox.Text)
        ' call function to calculate total price
        ' second argument is Button's Text
        total = Calculate(gallons, regularButton.Text)
        totalResultLabel.Text = String.Format("{0:C}", total)
    End Sub ' regularButton_Click

    ' handles Special Button's Click event
    Private Sub specialButton_Click(ByVal sender As System.Object,
       ByVal e As System.EventArgs) Handles specialButton.Click
        gallons = Convert.ToInt32(gallonsTextBox.Text)
        ' call function to calculate total price
        total = Calculate(gallons, specialButton.Text)
        totalResultLabel.Text = String.Format("{0:C}", total)
    End Sub ' specialButton_Click

    ' handles Super Button's Click event
    Private Sub superButton_Click(ByVal sender As System.Object,
       ByVal e As System.EventArgs) Handles superButton.Click
        gallons = Convert.ToInt32(gallonsTextBox.Text)
        ' call procedure to calculate total price
        total = Calculate(gallons, superButton.Text)
        totalResultLabel.Text = String.Format("{0:C}", total)
    End Sub ' superButton_Click

    ' calculate total cost of gas
    Function Calculate(gallons As Integer, grade As String) As Decimal
        ' determine grade selected and output total
        Dim totalPrice As Decimal = 0D
        Select Case grade
            Case "Regular"
                totalPrice = Convert.ToDecimal(REGULAR * gallons)
            Case "Special"
                totalPrice = Convert.ToDecimal(SPECIAL * gallons)
            Case "Super"
                totalPrice = Convert.ToDecimal(SUPER * gallons)
        End Select
        Return totalPrice
    End Function
End Class

