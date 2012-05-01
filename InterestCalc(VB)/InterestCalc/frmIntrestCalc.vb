Public Class frmInterestCalc

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'Validate input to be numberic in all boxes
        If Not IsNumeric(tbxDeposit.Text) Then
            MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbxDeposit.Focus()
            Return
        ElseIf Not IsNumeric(tbxInterest.Text) Then
            MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbxInterest.Focus()
            Return
        ElseIf Not IsNumeric(tbxMonths.Text) Then
            MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbxMonths.Focus()
            Return
        ElseIf Not IsNumeric(tbxAmount.Text) Then
            MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbxAmount.Focus()
            Return
        End If

        'Declare Variables
        Dim dblDeposit As Double
        Dim dblInterest As Double
        Dim intMonths As Integer
        Dim dblGoal As Double
        Dim dblInterestRate As Double
        Dim intCount As Integer = 1

        'Initialize variables to have the input data
        dblDeposit = Val(tbxDeposit.Text)
        dblInterest = Val(tbxInterest.Text)
        intMonths = Val(tbxMonths.Text)
        dblGoal = Val(tbxAmount.Text)

        'Calculate the interest rate
        dblInterestRate = (dblInterest / 100) / 12

        Do While intCount <= intMonths
            'calculate the amount of interest gained
            dblInterest = dblDeposit * dblInterestRate
            'adjust deposit accroding to interest gained
            dblDeposit = dblInterest + dblDeposit
            'Output calculated data to list box      
            lbxResults.Items.Add(Convert.ToString(intCount) & " " & dblDeposit.ToString("C2"))
            'increment counter counting the number of months already calculated
            intCount += 1
        Loop

        'Reinitialize variables due to previous calculations for reuse
        dblDeposit = Val(tbxDeposit.Text)
        intCount = 0

        Do While dblGoal >= dblDeposit
            'calculate the amount of interest gained
            dblInterest = dblDeposit * dblInterestRate
            'adjust deposit accroding to interest gained
            dblDeposit = dblInterest + dblDeposit
            'increment counter counting the number of months already calculated
            intCount += 1
        Loop
        'Output calcualte number of months to reach goal
        tbxGoal.Text = Convert.ToDouble(intCount)

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lbxResults.Items.Clear()
        tbxAmount.Clear()
        tbxDeposit.Clear()
        tbxGoal.Clear()
        tbxInterest.Clear()
        tbxMonths.Clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
