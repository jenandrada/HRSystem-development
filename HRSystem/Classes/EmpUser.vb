Public Class EmpUser

#Region "Properties"

    Private _id As Integer

    Public Property ID() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Public Property UserName() As String

    Public Property UserPass() As String

    Public Property FirstName() As String

    Public Property MiddleName() As String

    Public Property LastName() As String

    Public Property Status() As Integer

    Public Property CreatedDate() As Date

#End Region

#Region "Procedures"

    Friend Sub SaveUser()
        Dim mysql As String = "Select * From tblUser Rows 1"
        Using ds As DataSet = LoadSQL(mysql, "tblUser")

            Dim dsNewRow As DataRow
            dsNewRow = ds.Tables(0).NewRow
            With dsNewRow
                .Item("UserName") = UserName
                .Item("UserPass") = UserPass
                .Item("FirstName") = FirstName
                .Item("MiddleName") = MiddleName
                .Item("LastName") = LastName
                .Item("Status") = 1
            End With
            ds.Tables(0).Rows.Add(dsNewRow)
            SaveEntry(ds)
        End Using
    End Sub

    Friend Sub LoadUser(ByVal idx As Integer)
        Dim mysql As String = "Select * From tblUser Where ID = '" & idx & "'"
        Using ds As DataSet = LoadSQL(mysql, "tblUser")

            For Each dr In ds.Tables(0).Rows
                LoadByRows(dr)
            Next
        End Using
    End Sub

    Private Sub LoadByRows(ByVal dr As DataRow)
        With dr
            _id = .Item("ID")
            UserName = .Item("UserName")
            UserPass = .Item("UserPass")
            FirstName = .Item("FirstName")
            MiddleName = .Item("MiddleName")
            LastName = .Item("LastName")
            Status = .Item("Status")
            CreatedDate = .Item("Createdate")
        End With
    End Sub

    Friend Function LoginUser(ByVal tmpUser As String, ByVal tmpPass As String) As Boolean
        Dim mysql As String = "Select * From tblUser Where Upper(UserName) = Upper('" & tmpUser & "') And UserPass = '" & EncryptString(tmpPass) & "' And Status <> 0"
        Using ds As DataSet = LoadSQL(mysql, "tblUser")

            If ds.Tables Is Nothing Then Return False
            If ds.Tables(0).Rows.Count <= 0 Then Return False

            LoadUser(ds.Tables(0).Rows(0).Item("ID"))
        End Using
        Return True
    End Function

    Friend Sub UpdateUser()
        Dim mysql As String = "Select * From tblUser Where ID = '" & _id & "'"
        Using ds As DataSet = LoadSQL(mysql, "tblUser")
            With ds.Tables(0).Rows(0)
                .Item("UserPass") = UserPass
                .Item("Status") = Status
            End With
            SaveEntry(ds, False)
        End Using
    End Sub

#End Region

End Class