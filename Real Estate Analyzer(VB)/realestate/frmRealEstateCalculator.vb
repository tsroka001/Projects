Public Class frmRealEstateCalculator
    '====================================
    'Global Variables
    '====================================

    Dim intItems As Integer = 0
    Dim dblProperties(0) As Double
    Dim pntMouseOffset As Point

    '====================================
    'Button Click Events
    '====================================

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        AppExit()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    '====================================
    'Menu Item Click Events
    '====================================

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        AppExit()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        ClearForm()
    End Sub

    Private Sub ProgramInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramInfoToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub

    '====================================
    'Form Functions and Subroutines
    '====================================

    'This subroutine is called to close the application
    Private Sub AppExit()
        Application.Exit()
    End Sub

    'This subroutine is called to clear all form controls 
    'as well as the variable that holds the number of prices 
    'entered as well as the array that holds the prices
    Private Sub ClearForm()

        lbxInput.Items.Clear()
        lbxResults.Items.Clear()
        tbxMax.Clear()
        tbxMean.Clear()
        tbxMedian.Clear()
        tbxMin.Clear()
        tbxMode.Clear()
        tbxStDev.Clear()

        tbxPropValue.Focus()

        ReDim dblProperties(1)
        intItems = 0

    End Sub

    'This subroutine cycles through all of the the prices 
    'entered and adds them to the onscreen list box along with 
    'the total of the prices and the commision
    Private Sub DisplayArray(ByVal dblProperties() As Double)
        'clear the previous items in list box
        lbxResults.Items.Clear()
        'Cycle through the array and add all elements to the list box formatted as "C2"
        Dim intTempCount As Integer = 1

        For Each dblElement As Double In dblProperties
            If dblElement <> Nothing Then
                lbxResults.Items.Add(intTempCount & ". " & dblElement.ToString("C2"))
                intTempCount += 1
            End If
        Next
        'Add statistical info at the bottom of the list box
        lbxResults.Items.Add("______________________")
        lbxResults.Items.Add("Total: " & Sum().ToString("C2"))
        lbxResults.Items.Add("Commission: " & (Sum() * 0.03).ToString("C2"))

    End Sub

    'This subroutine calculates the statistics for the prices
    'entered as well as output them to the form's text boxes
    Private Sub CalculateStatistics()

        Dim dblTempMode As Double
        'calculate min
        tbxMin.Text = dblProperties(0).ToString("C2")
        'calculate max
        tbxMax.Text = dblProperties(UBound(dblProperties)).ToString("C2")
        'calculate median
        If (UBound(dblProperties) - 1) Mod 2 = 0 Then
            tbxMedian.Text = ((dblProperties(UBound(dblProperties) \ 2) + dblProperties(1 + UBound(dblProperties) \ 2)) / 2).ToString("C2")
        Else
            tbxMedian.Text = dblProperties(UBound(dblProperties) / 2).ToString("C2")
        End If
        'calculate mode
        dblTempMode = GetMode(dblProperties)
        If dblTempMode = 0 Then
            tbxMode.Text = "No Single Mode"
        Else
            tbxMode.Text = dblTempMode.ToString("C2")
        End If
        'calculate mean
        tbxMean.Text = (Sum() / dblProperties.Length).ToString("C2")
        'calculate standard deviation
        tbxStDev.Text = GetStDev().ToString("C2")
    End Sub

    'This function returns the sum of all of the elements in the
    '"dblProperties" array.
    Private Function Sum() As Double

        Dim Total As Double = 0

        For Each dblElement As Double In dblProperties
            Total += dblElement

        Next

        Return Total

    End Function

    'This function returns the mode (if any) of the given array
    'This function begins by checking the length of the given array
    'If the length is 1 then that single element is the mode
    'If it is not of length one then it compares each element 
    'of the sorted array against its neighboting element
    'If they are equal then the element is passed to a newly created 
    'array named "dblModeArray". Using recursion I then send my 
    'newly created array into this function. This repeats untill
    'the array is only 1 element long. That element is either 0 or
    'the mode. This distinction is made during the recursion process
    '(Note: I'm having a hard time explaining exactly what goes 
    ' on here but im sure you can figure it out)
    Private Function GetMode(ByVal dblNumList() As Double) As Double

        If dblNumList.Length = 1 Then
            Return dblNumList(0)
        End If

        Dim dblModeArray(0) As Double
        Dim intModeCounter As Integer = 0

        For i = 1 To UBound(dblNumList)
            If dblNumList(i) = dblNumList(i - 1) Then
                intModeCounter += 1
                Array.Resize(dblModeArray, intModeCounter)
                dblModeArray(intModeCounter - 1) = dblNumList(i)
            End If
        Next

        Return GetMode(dblModeArray)

    End Function

    'This function returns the standard deviation of the prices 
    'within the "dblProperties" array
    Private Function GetStDev() As Double

        Dim dblDev As Double = 0

        For Each dblElement As Double In dblProperties
            dblDev += ((dblElement - (Sum() / dblProperties.Length)) ^ 2)
        Next

        Return Math.Sqrt(dblDev / UBound(dblProperties))

    End Function

    '====================================
    'Misc Event Handler Functions
    '====================================

    'This subroutine determines how much to offset the mouse 
    'location in relation to the form.
    Private Sub Check_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        pntMouseOffset = New Point(-e.X, -e.Y)
    End Sub

    'This subroutine adjusts the form's location 
    'according to the changes in position of the mouse
    Private Sub Check_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        'Check to make sure the left mouse button is being held down
        If e.Button = MouseButtons.Left Then
            'Get the mouse position and store it in mousePos
            Dim pntMousePos As Point = Control.MousePosition
            'Offset the mouse in relation to the form
            pntMousePos.Offset(pntMouseOffset.X, pntMouseOffset.Y)
            'Move the form to the offset mouse position
            Me.Location = pntMousePos
        End If

    End Sub

    'This subroutine checks to see if the enter buttin has been pressed
    'within the "tbxPropValue" text box. If it has then it executes code
    'to update the secondary list box as well as to calculate the statistics
    Private Sub tbxPropValue_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxPropValue.KeyPress
        'check to see if enter button was pressed
        If (Asc(e.KeyChar) = 13) Then
            'validate that the entered data is numeric
            If Not IsNumeric(tbxPropValue.Text) Then
                MessageBox.Show("Please enter a valid numeric value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                'Increment number of items, update arrays, update list boxes, and calculate the statistical information
                intItems += 1
                lbxInput.Items.Add(intItems & ". " & Val(tbxPropValue.Text).ToString("C2"))
                Array.Resize(dblProperties, intItems)
                dblProperties(intItems - 1) = Val(tbxPropValue.Text)
                Array.Sort(dblProperties)
                DisplayArray(dblProperties)
                CalculateStatistics()
            End If
            'clear the text box so user can input next value without the need to manually erase
            tbxPropValue.Clear()
        End If

    End Sub

End Class