Public Class Address

#Region "Properties"

    Public Property ID() As Integer

    Public Property Province() As String

    Public Property CityMun() As String

    Public Property Barangay() As String

#End Region

#Region "Procedures"

    Friend Sub SaveAddress()
        Dim mysql As String = "Select * From tbl_Address Rows 1"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Address")

        Dim dsNewRow As DataRow
        dsNewRow = ds.Tables(0).NewRow
        With dsNewRow
            .Item("Province") = Province
            .Item("CityMun") = CityMun
            .Item("Barangay") = Barangay
        End With
        ds.Tables(0).Rows.Add(dsNewRow)
        SaveEntry(ds)
    End Sub

    Friend Sub UpdateAddress()
        Dim mysql As String = "Select * From tbl_Address Where ID = '" & ID & "'"
        Using ds As DataSet = LoadSQL(mysql, "tbl_Address")

            With ds.Tables(0).Rows(0)
                .Item("Province") = Province
                .Item("CityMun") = CityMun
                .Item("Barangay") = Barangay
            End With
            SaveEntry(ds, False)
        End Using
    End Sub

    Friend Sub LoadAddress(ByVal idx As Integer)
        Dim mysql As String = "Select * From tbl_Address Where ID = '" & idx & "'"
        Using ds As DataSet = LoadSQL(mysql, "tbl_Address")

            LoadByRows(ds.Tables(0).Rows(0))
        End Using
    End Sub

    Private Sub LoadByRows(ByVal dr As DataRow)
        With dr
            ID = .Item("ID")
            Province = .Item("Province")
            CityMun = .Item("CityMun")
            Barangay = .Item("Barangay")
        End With
    End Sub

#End Region

End Class