Public Class LeaveMngt

#Region "Properties"

    Public Property ID() As Integer
    Public Property BranchID() As Integer
    Public Property EmpID() As Integer
    Public Property Type() As String
    Public Property Started() As String
    Public Property Ended() As String
    Public Property Encoded() As String
    Public Property Notes() As String
    Public Property Status() As Integer

#End Region

#Region "Functions and Procedures"

    Public Sub SaveLeave()
        Dim sql As String = "select * from tbl_leave"
        Dim ds As DataSet = LoadSQL(sql, "tbl_leave")

        Dim dsNew As DataRow
        dsNew = ds.Tables(0).NewRow

        With dsNew

            .Item("BRANCH_ID") = BranchID
            .Item("EMP_ID") = EmpID
            .Item("LEAVE_TYPE") = Type
            .Item("L_DATE_STARTED") = Started
            .Item("L_DATE_ENDED") = Ended
            .Item("DATE_ENCODED") = Encoded
            .Item("NOTES") = Notes
            .Item("STATUS") = Status

        End With

        ds.Tables(0).Rows.Add(dsNew)
        SaveEntry(ds)
    End Sub

    Public Sub UpdateLeave()
        Dim sql As String = $"select * from tbl_leave where ID = {ID}"
        Dim ds As DataSet = LoadSQL(sql, "tbl_leave")

        Dim dr As DataRow
        dr = ds.Tables(0).Rows(0)

        With dr

            .Item("BRANCH_ID") = BranchID
            .Item("LEAVE_TYPE") = Type
            .Item("L_DATE_STARTED") = Started
            .Item("L_DATE_ENDED") = Ended
            .Item("DATE_ENCODED") = Encoded
            .Item("NOTES") = Notes
            .Item("STATUS") = Status

        End With
        SaveEntry(ds, False)
    End Sub

#End Region

End Class