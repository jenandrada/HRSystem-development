Public Class EMPLIST_BRANCH

#Region "Properties"

    Public Property Name() As String

    Public Property Position() As String

    Public Property DateHired() As String

    Public Property Branch() As String

    Public Property BranchID() As String

#End Region

    Friend Sub LoadEMPLISTBRANCH(ByVal idx As Integer)
        Dim mysql As String = "SELECT * FROM EMPLIST_BRANCH where ID = '" & idx & "';"
        Using ds As DataSet = LoadSQL(mysql, "EMPLIST_BRANCH")
            If ds.Tables(0).Rows.Count > 0 Then
                Loademplistbranch(ds.Tables(0).Rows(0))
            End If
        End Using
    End Sub

    Private Sub Loademplistbranch(ByVal dr As DataRow)
        With dr
            Name = .Item("FULLNAME")
            Position = .Item("EMP_POSITION")
            DateHired = .Item("DATEHIRED")
            Branch = .Item("BRANCHNAME")
            BranchID = .Item("ID")
        End With

    End Sub

End Class

Public Class Empratings

#Region "Properties"

    Public Property ID() As String

    Public Property ManningID() As String

    Public Property Rate() As String

    Public Property Status() As String

    Public Property Comment() As String

#End Region

#Region "Functions"

    Friend Sub SaveRating()
        If Not String.IsNullOrEmpty(ManningID) And Not String.IsNullOrEmpty(Rate) And Not String.IsNullOrEmpty(Status) And Not String.IsNullOrEmpty(Comment) Then
            Dim sql As String = "Select * From TBL_RATE Rows 1"
            Using ds As DataSet = LoadSQL(sql, "TBL_RATE")

                Dim dsNewRow As DataRow
                dsNewRow = ds.Tables(0).NewRow
                With dsNewRow
                    .Item("MANNING_ID") = ManningID
                    .Item("RATE") = Rate
                    .Item("STATUS") = Status
                    .Item("COMMENT") = Comment
                End With
                ds.Tables(0).Rows.Add(dsNewRow)
                SaveEntry(ds)
            End Using
        End If
    End Sub

    Friend Sub UpdateRatings()
        If Not String.IsNullOrEmpty(ManningID) And Not String.IsNullOrEmpty(Rate) And Not String.IsNullOrEmpty(Status) And Not String.IsNullOrEmpty(Comment) Then
            Dim sql As String = "Select * From TBL_RATE Where ID = '" & ID & "'"
            Using ds As DataSet = LoadSQL(sql, "TBL_RATE")

                With ds.Tables(0).Rows(0)
                    .Item("MANNING_ID") = ManningID
                    .Item("RATE") = Rate
                    .Item("STATUS") = Status
                    .Item("COMMENT") = Comment
                End With
                SaveEntry(ds, False)
            End Using
        End If
    End Sub

#End Region

End Class