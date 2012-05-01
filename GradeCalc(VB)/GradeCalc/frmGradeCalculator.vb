Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        'Check whether the user has provided valid numeric information
        'If the information is invalid execution will stop and an error message is displayed.

        If Not IsNumeric(tbxTest1.Text) Then
            MessageBox.Show("Invalid numeric data entered!", "ERROR!?!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbxTest1.Focus()
            Return
        End If

        If Not IsNumeric(tbxTest2.Text) Then
            MessageBox.Show("Invalid numeric data entered!", "ERROR!?!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            tbxTest2.Focus()
            Return
        End If

        If Not IsNumeric(tbxTest3.Text) Then
            MessageBox.Show("Invalid numeric data entered!", "ERROR!?!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            tbxTest3.Focus()
            Return
        End If

        'Declare variables
        Dim dblTest1, dblTest2, dblTest3, dblAverage As Double

        'Assign values in text boxes to variables
        dblTest1 = Convert.ToDouble(tbxTest1.Text)
        dblTest2 = Convert.ToDouble(tbxTest2.Text)
        dblTest3 = Convert.ToDouble(tbxTest3.Text)

        'Calculate Grade
        If cbxDropLowestGrade.Checked Then
            dblAverage = (dblTest1 + dblTest2 + dblTest3 - Math.Min(Math.Min(dblTest1, dblTest2), dblTest3)) / 2
        Else
            dblAverage = (dblTest1 + dblTest2 + dblTest3) / 3
        End If

        'Round the average to 1 deciaml point
        dblAverage = Math.Round(dblAverage, 1)

        'Determine letter grade and display it to the screen
        If dblAverage > 97.0 Then
            tbxLetterGrade.Text = "A+"
        ElseIf dblAverage < 96.9 And dblAverage >= 94.0 Then
            tbxLetterGrade.Text = "A"
        ElseIf dblAverage < 93.9 And dblAverage >= 90.0 Then
            tbxLetterGrade.Text = "A-"
        ElseIf dblAverage < 89.9 And dblAverage >= 87.0 Then
            tbxLetterGrade.Text = "B+"
        ElseIf dblAverage < 86.9 And dblAverage >= 84.0 Then
            tbxLetterGrade.Text = "B"
        ElseIf dblAverage < 83.9 And dblAverage >= 80.0 Then
            tbxLetterGrade.Text = "B-"
        ElseIf dblAverage < 79.9 And dblAverage >= 77.0 Then
            tbxLetterGrade.Text = "C+"
        ElseIf dblAverage < 76.9 And dblAverage >= 74.0 Then
            tbxLetterGrade.Text = "C"
        ElseIf dblAverage < 73.9 And dblAverage >= 70.0 Then
            tbxLetterGrade.Text = "C-"
        ElseIf dblAverage < 69.9 And dblAverage >= 67.0 Then
            tbxLetterGrade.Text = "D+"
        ElseIf dblAverage < 66.9 And dblAverage >= 64.0 Then
            tbxLetterGrade.Text = "D"
        ElseIf dblAverage < 63.9 And dblAverage >= 60.0 Then
            tbxLetterGrade.Text = "D-"
        Else
            tbxLetterGrade.Text = "F"
        End If

        tbxAverage.Text = Convert.ToString(dblAverage)

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'Exit the Applcation
        Application.Exit()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Clear all contents on screen
        cbxDropLowestGrade.Checked = False
        tbxAverage.Clear()
        tbxLetterGrade.Clear()
        tbxTest1.Clear()
        tbxTest2.Clear()
        tbxTest3.Clear()
    End Sub
End Class
