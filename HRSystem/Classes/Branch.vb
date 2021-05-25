Public Class Branch

#Region "Properties"

    Public Property ID() As Integer

    Public Property CompanyName() As String

    Public Property BranchName() As String

    Public Property BranchCode() As String

    Public Property BranchArea() As String

    Public Property Remarks() As String

    Public Property Status() As Integer

#End Region

#Region "Procedures"

    Friend Sub SaveBranch()
        Dim mysql As String = "Select * From tbl_Branch Rows 1"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Branch")

        Dim dsNewRow As DataRow
        dsNewRow = ds.Tables(0).NewRow
        With dsNewRow
            .Item("CompanyName") = CompanyName
            .Item("BranchName") = BranchName
            .Item("BranchCode") = BranchCode
            .Item("BranchArea") = BranchArea
            .Item("Remarks") = Remarks
            .Item("Status") = Status
        End With
        ds.Tables(0).Rows.Add(dsNewRow)
        SaveEntry(ds)
    End Sub

    Friend Sub UpdateBranch()
        Dim mysql As String = "Select * From tbl_Branch Where ID = '" & ID & "'"
        Using ds As DataSet = LoadSQL(mysql, "tbl_Branch")

            With ds.Tables(0).Rows(0)
                .Item("BranchCode") = BranchCode
                .Item("BranchArea") = BranchArea
                .Item("Remarks") = Remarks
                .Item("Status") = Status
            End With
            SaveEntry(ds, False)
        End Using
    End Sub

    Friend Sub LoadBranch(ByVal idx As String)
        Dim mysql As String = "Select * From tbl_Branch Where ID = '" & idx & "'"
        Using ds As DataSet = LoadSQL(mysql, "tbl_Branch")

            For Each dr In ds.Tables(0).Rows
                LoadByRows(dr)
            Next
        End Using
    End Sub

    Private Sub LoadByRows(ByVal dr As DataRow)
        With dr
            ID = .Item("ID")
            CompanyName = .Item("CompanyName")
            BranchName = .Item("BranchName")
            BranchCode = .Item("BranchCode")
            BranchArea = .Item("BranchArea")
            Remarks = .Item("Remarks")
            Status = .Item("Status")
        End With
    End Sub

#End Region

End Class