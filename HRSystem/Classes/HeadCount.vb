Public Class HeadCount

#Region "Properties"

    Public Property ID() As Integer
    Public Property EmpID() As Integer
    Public Property BranchID() As Integer
    Public Property Attendance() As String
    Public Property DateEncoded() As String
    Public Property Remarks() As String
    Public Property NoteReason() As String
    Public Property Status() As Integer

#End Region

#Region "Methods and Functions"

    Friend Sub AddUpdateItems(dr As DataRow)
        With dr
            .Item("EMP_ID") = EmpID
            .Item("BRANCH_ID") = BranchID
            .Item("ATTENDANCE") = Attendance
            .Item("DATE_ENCODED") = DateEncoded
            .Item("REMARKS") = Remarks
            .Item("NOTE") = NoteReason
            .Item("STATUS") = Status
        End With
    End Sub

    'Friend Sub UpdateItems(dr As DataRow)
    '    With dr
    '        .Item("EMP_ID") = EmpID
    '        .Item("BRANCH_ID") = BranchID
    '        .Item("ATTENDANCE") = Attendance
    '        .Item("DATE_ENCODED") = DateEncoded
    '        .Item("REMARKS") = Remarks
    '        .Item("NOTE") = NoteReason
    '        .Item("STATUS") = Status
    '    End With
    'End Sub

    Friend Sub SaveAttendance()
        Dim sql As String = "select * from TBL_ATTENDANCE rows 1"
        Using ds As DataSet = LoadSQL(sql, "TBL_ATTENDANCE")
            Dim dsNew As DataRow = ds.Tables(0).NewRow
            With dsNew
                AddUpdateItems(dsNew)
            End With
            ds.Tables(0).Rows.Add(dsNew)
            SaveEntry(ds)
        End Using
    End Sub

    Friend Sub UpdateAttendance()

        Console.WriteLine("LOADRELIEVE ===" & EmpID)

        Dim sql As String = $"select * from TBL_ATTENDANCE WHERE EMP_ID = {EmpID}"
        Using ds As DataSet = LoadSQL(sql, "TBL_ATTENDANCE")
            Dim dr As DataRow = ds.Tables(0).Rows(0)
            With dr
                AddUpdateItems(dr)
            End With
            SaveEntry(ds, False)
        End Using
    End Sub

#End Region

End Class