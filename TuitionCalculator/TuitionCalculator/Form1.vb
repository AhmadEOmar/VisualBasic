'Ahmad Omar
'TutitionCost
Option Strict On
Public Class TuitionCalculator

    Dim CreditHours As Integer = 0
    Dim TotalCost As Decimal = 0D
    Const A As Decimal = 100D
    Const B As Decimal = 500D

    Private Sub ButtonA_Click(sender As Object, e As EventArgs) Handles ButtonA.Click
        CreditHours = CInt(CreditHoursText.Text)
        TotalCost = CDec((CreditHours * (100)))
        TutionCost.Text = "$" & CStr(TotalCost)

    End Sub

    Private Sub ButtonB_Click(sender As Object, e As EventArgs) Handles ButtonB.Click
        CreditHours = CInt(CreditHoursText.Text)
        TotalCost = CDec((CreditHours * (500)))
        TutionCost.Text = "$" & CStr(TotalCost)
    End Sub

    Private Sub TutionCost_TextChanged(sender As Object, e As EventArgs) Handles TutionCost.TextChanged

    End Sub
End Class
