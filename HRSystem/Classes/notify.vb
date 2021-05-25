Public Class notify

#Region "Properties"

    Public Property ID() As String

    Public Property ManningID() As String

    Public Property Rate() As String

    Public Property Status() As String

    Public Property Comment() As String

#End Region

#Region "Funtion"

    Friend Sub SAVENOTIFY()
        'Dim mysql As String = "Select * From tbl_RATE Rows 1"
        'Dim ds As DataSet = LoadSQL(mysql, "tbl_RATE")

        'Dim dsNewRow As DataRow
        'dsNewRow = ds.Tables(0).NewRow
        'With dsNewRow
        '    .Item("MANNING_ID") = _manningID
        '    .Item("RATE") = _Rating
        '    .Item("STATUS") = 1

        'End With
        'ds.Tables(0).Rows.Add(dsNewRow)
        'SaveEntry(ds)

        Dim sql As String = "Select * From TBL_RATE Rows 1"
        Dim ds As DataSet = LoadSQL(sql, "TBL_RATE")

        Dim dsNewRow As DataRow
        dsNewRow = ds.Tables(0).NewRow
        With dsNewRow
            .Item("MANNING_ID") = ManningID
            .Item("RATE") = Rate
            .Item("STATUS") = 1
            .Item("COMMENT") = "NO COMMENT YET."
        End With
        ds.Tables(0).Rows.Add(dsNewRow)
        SaveEntry(ds)
        UpdateRate_Status()
    End Sub

    Friend Sub UpdateRate_Status()
        Dim sql As String = "select * from TBLMANNING where ID = " & ManningID & ";"
        Dim ds As DataSet = LoadSQL(sql, "TBLMANNING")

        With ds.Tables(0).Rows(0)
            .Item("RATE_STATUS") = 1

        End With
        SaveEntry(ds, False)

    End Sub

    Friend Sub UpdateNotify()
        Dim mysql As String = "Select * From tbl_RATE Where MANNING_ID = '" & ManningID & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_RATE")

        With ds.Tables(0).Rows(0)
            .Item("RATE") = Rate

        End With
        SaveEntry(ds, False)
        UpdateRate_Status()
    End Sub

#End Region

End Class