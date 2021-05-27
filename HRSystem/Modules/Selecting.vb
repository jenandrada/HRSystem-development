Module Selecting
    Public Function ThisHasRow(table As String)
        Dim mysql As String = "Select * FROM " & table & ""
        Dim ds As DataSet = LoadSQL(mysql, table)
        If ds.Tables(0).Rows.Count > 0 Then
            Return True
        End If
        Return False
    End Function


    Friend Sub Attachment(datagrid As DataGridView, status As String)
        Dim mysql As String = "Select * From SHOWCAUSE_RECORDS inner join TBL_EMPLOYEE on TBL_EMPLOYEE.id = SHOWCAUSE_RECORDS.emp_id where SHOWCAUSE_RECORDS.status = '" & status & "'"
        Using ds As DataSet = LoadSQL(mysql, "SHOWCAUSE_RECORDS")
            If ds.Tables(0).Rows.Count > 0 Then
                For Each dr In ds.Tables(0).Rows
                    AddItem(dr, datagrid)
                Next

            End If
        End Using

    End Sub


    Public Sub AddItem(ByVal dr As DataRow, datagrid As DataGridView)

        With dr
            Dim MI As String
            If String.IsNullOrEmpty(.Item("MIDDLENAME")) Then
                MI = ""
            Else
                MI = .Item("MIDDLENAME").Substring(0, 1) & "."
            End If

            Dim datee As DateTime = CDate(.Item("DATE_DEADLINE"))
            'Dim num As Integer = .Item("SCNO")

            Dim rowId As Integer = datagrid.Rows.Add()
            Dim row As DataGridViewRow = datagrid.Rows(rowId)
            row.Cells("SCNO_DGV").Value = Format(.Item("SCNO"), "00000")
            row.Cells("Name_DGV").Value = .Item("LASTNAME") & ", " & .Item("FIRSTNAME") & " " & MI
            row.Cells("Company_DGV").Value = .Item("COMPANY")
            row.Cells("Deadline_DGV").Value = datee.ToString("D")
            row.Cells("File_DGV").Value = "Open"
            row.Cells("File_DGV").Tag = .Item("PATH")
            row.Cells("Explain_DGV").Value = .Item("IMAGEEXPLAIN")

        End With

        For i = 0 To datagrid.Rows.Count - 1
            Dim r As DataGridViewRow = datagrid.Rows(i)
            r.Height = 35
        Next

    End Sub

End Module
