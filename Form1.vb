Public Class formLinearArray

    Dim strNames() As String 'Declares the non static (dynamic) array for use

    Private Sub btnInitiateArray_Click(sender As Object, e As EventArgs) Handles btnInitiateArray.Click

        ReDim strNames(3)

        strNames(0) = "John"
        strNames(1) = "Mark"
        strNames(2) = "Jill"
        strNames(3) = "Jess"
        MsgBox("Array populated!") 'Preset array values are created upon button press and display that they have been added

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim bFound As Boolean 'Declared to check if text input is in the array
        Dim iReply As Integer ' Declared to check if the new nae should be added to the list

        Dim strFind As String 'Declared to search for names in the array
        strFind = Me.txtFind.Text

        For iCount As Integer = 0 To 3
            If UCase(strNames(iCount)) = UCase(strFind) Then 'Checks input in uppercase with uppercase array
                bFound = True
                Exit For
            End If
        Next 'Interating through each name in array to check for match

        If bFound = True Then
            MsgBox("Found " & strFind) 'Searches for a match
        Else
            iReply = MsgBox(strFind & " not found. Would you like to add them to the record?", MsgBoxStyle.YesNo) 'Displays message and yes no for name addition
            If iReply = vbYes Then
                ReDim Preserve strNames(UBound(strNames) + 1)
                strNames(UBound(strNames)) = strFind
                MsgBox(strFind & " has been added to the records.")
            End If
        End If 'If match is not found, prompted to add name into the record

    End Sub
    'John Calverley
End Class