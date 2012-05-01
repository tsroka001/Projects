        'Dim dblMode As Double = 0
        'Dim dblOldMode As Double = 0
        'Dim intCount As Integer = 0
        'Dim intOldCount As Integer = 0

        'If dblProperties.Length = 1 Then
        '    Return dblProperties(0)
        'End If

        'For i = 1 To UBound(dblProperties)
        '    If dblProperties(i) = dblProperties(i - 1) Then
        '        intCount += 1
        '        dblMode = dblProperties(i)
        '    Else
        '        If intCount >= intOldCount Then
        '            intOldCount = intCount
        '            dblOldMode = dblMode
        '        ElseIf intCount < intOldCount Then
        '            intCount = 0
        '        End If


        '    End If

        'Next

        'Return dblOldMode

        Dim stkModes As New Stack
        Dim dblModeArray(0) As Double
        Dim intCount As Integer = 1

        If UBound(dblNumList) = 0 Then
            Return dblNumList(0)
        End If

        For i = 1 To UBound(dblNumList)
            If dblProperties(i) = dblNumList(i - 1) Then
                stkModes.Push(dblProperties(i))
                intCount += 1
            End If
        Next

        stkModes.CopyTo(dblModeArray, 0)

        If UBound(dblModeArray) = 0 Then
            Return 0
        ElseIf UBound(dblModeArray) = 1 Then
            Return dblModeArray(0)
        Else
            Array.Sort(dblModeArray)
            Return GetMode(dblModeArray)
        End If


        'Dim stkModes As Stack
        'If UBound(dblNumList) = 0 Then
        '    Return dblNumList(0)
        'End If

        'For i = 1 To UBound(dblNumList)
        '    stkModes.
        'Next


http://msdn.microsoft.com/en-us/library/exc45z53.aspx