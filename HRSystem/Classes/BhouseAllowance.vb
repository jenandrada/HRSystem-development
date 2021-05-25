Public Class BhouseAllowance

#Region "Properties"

    Public Property ID() As Integer

    Public Property Branch_ID() As Integer

    Public Property Manning_ID() As Integer

    Public Property RelieveID() As Integer

    Public Property AppointedID() As Integer

    Public Property Allowance() As Decimal

    Public Property Status() As String

    Public Property Position() As String

    Public Property Present_Address() As String

    Public Property Branch_Area() As String

    Public Property Branch_Code() As String

    Public Property Branch_Name() As String

    Public Property Company() As String

    Public Property Other_Allowance() As Decimal

    Public Property CareKit_ID() As Integer

    Public Property CareKit_Allowance() As Decimal

    Public Property Date_Notify() As Date

    Public Property Particulars() As String

    Public Property FullName() As String

    '-------------------String JEn----------

    Public Property Bhouse_String() As String

    Public Property Carekit_String() As String

    Public Property other_String() As String

    Public Property BranchName_String() As String

#End Region

#Region "Procedures"

    Public Sub LoadBhouseAllowance(idx As Integer, Optional str As String = "")
        Dim sql As String = "select * from TBL_BHOUSE_ALLOWANCE where ID = " & idx & ";"
        Using ds As DataSet = LoadSQL(sql, "TBL_BHOUSE_ALLOWANCE")

            If ds.Tables(0).Rows.Count > 0 Then
                GetBhouseAllowance(ds.Tables(0).Rows(0), str)
            End If
        End Using
    End Sub

    Private Sub GetBhouseAllowance(dr As DataRow, Optional str As String = "")
        Dim idx As String
        With dr
            FullName = str
            ID = CInt(.Item("ID"))
            If IsDBNull(.Item("MANNING_ID")) Then
                AppointedID = CInt(.Item("APPOINTED_ID"))
            ElseIf IsDBNull(.Item("APPOINTED_ID")) Then
                Manning_ID = CInt(.Item("MANNING_ID"))
            End If
            If String.IsNullOrEmpty(.Item("CAREKIT_ID")) Then
                CareKit_ID = 0
            Else
                CareKit_ID = CInt(.Item("CAREKIT_ID").ToString)
            End If
            idx = CType(CareKit_ID, String)
            Allowance = CDec(.Item("ALLOWANCE"))
            Other_Allowance = CDec(.Item("OTHER_ALLOWANCE"))
            Date_Notify = CDate(.Item("DATE_NOTIFY"))
            Status = CType(.Item("STATUS"), String)
            Particulars = .Item("PARTICULARS").ToString

        End With
        Dim sql As String = "select * from TBL_CARE_KIT where ID = " & idx & ";"
        Dim ds As DataSet = LoadSQL(sql, "TBL_CARE_KIT")

        If ds.Tables(0).Rows.Count > 0 Then
            CareKit_Allowance = CDec(ds.Tables(0).Rows(0).Item("AMOUNT"))
        Else
            CareKit_Allowance = 0
        End If
    End Sub

    Public Sub GetBasicInfo(Optional Id As String = "")
        Dim sql As String = "SELECT * FROM BHOUSE_LIST WHERE ID = " & Id & ";"
        Using ds As DataSet = LoadSQL(sql, "BHOUSE_LIST")

            If ds.Tables(0).Rows.Count > 0 Then
                GetRows(ds.Tables(0).Rows(0))
            Else
                Exit Sub
            End If
        End Using
    End Sub

    Private Sub GetRows(dr As DataRow)
        With dr
            ID = CInt(.Item("BH_ID"))
            Manning_ID = CInt(.Item("ID"))
            Present_Address = CType(.Item("CITYMUN"), String)
            Position = CType(.Item("EMP_POSITION"), String)
            Branch_Area = CType(.Item("AREA_OF_ASSIGNMENT"), String)
            Branch_Code = CType(.Item("BRANCHCODE"), String)
            Branch_Name = CType(.Item("BRANCHNAME"), String)
            Company = CType(.Item("COMPANYNAME"), String)
            Position = CType(.Item("EMP_POSITION"), String)
        End With
    End Sub

    Public Sub GetDetailsJEN(name As String, bhouse As String, carekit As String, other As String, particu As String, branch As String)

        Dim dr, drr As DataRow

        With dr
            FullName = name
            Bhouse_String = bhouse
            Carekit_String = carekit
            other_String = other
            Particulars = particu
            BranchName_String = branch
        End With

        Dim sql As String = "select * from TBL_BRANCH WHERE BRANCHNAME = '" & branch & "'"
        Using ds As DataSet = LoadSQL(sql, "TBL_BRANCH")

            drr = ds.Tables(0).Rows(0)

            With drr
                Company = .Item("COMPANYNAME")
            End With
        End Using

    End Sub

    Public Sub GetDetails(id As Integer)

        Dim sql As String = "select * from TBL_BHOUSE_ALLOWANCE WHERE ID = " & id & ";"
        Using ds As DataSet = LoadSQL(sql, "TBL_BHOUSE_ALLOWANCE")

            Dim dr As DataRow = ds.Tables(0).Rows(0)

            With dr
                DetailsRow(dr, id)
            End With
        End Using
    End Sub

    Private Sub DetailsRow(dr As DataRow, id As Integer)
        With dr
            Dim sql As String = "select AMOUNT from TBL_CARE_KIT WHERE ID = " & id & ";"
            Dim ds As DataSet = LoadSQL(sql, "TBL_CARE_KIT")
            Allowance = CDec(.Item("ALLOWANCE"))
            Other_Allowance = CDec(.Item("OTHER_ALLOWANCE"))
            For Each dr In ds.Tables(0).Rows
                CareKit_Allowance = CDec(dr.Item("AMOUNT"))
            Next
            Status = CType(.Item("STATUS"), String)
        End With
    End Sub


    'Private Sub DetailsRowJEN(dr As DataRow, id As Integer, namee As String, branch As String)
    '    With dr

    '        FullName = namee
    '        Company = branch
    '        Allowance = CDec(.Item("ALLOWANCE"))
    '        Other_Allowance = CDec(.Item("OTHER_ALLOWANCE"))


    '        Dim sql As String = "select AMOUNT from TBL_CARE_KIT WHERE ID = " & id & ";"
    '        Dim ds As DataSet = LoadSQL(sql, "TBL_CARE_KIT")

    '        For Each dr In ds.Tables(0).Rows
    '            CareKit_Allowance = CDec(dr.Item("AMOUNT"))
    '        Next

    '    End With
    'End Sub

    Public Sub SaveBAllowance()
        Dim sql As String = "SELECT * FROM TBL_BHOUSE_ALLOWANCE ROWS 1"
        Using ds As DataSet = LoadSQL(sql, "TBL_BHOUSE_ALLOWANCE")

            Dim dsNew As DataRow
            dsNew = ds.Tables(0).NewRow

            With dsNew
                .Item("MANNING_ID") = Manning_ID
                .Item("ALLOWANCE") = Allowance
                .Item("DATE_NOTIFY") = Date_Notify
                .Item("STATUS") = Status
                .Item("OTHER_ALLOWANCE") = Other_Allowance
            End With
            ds.Tables(0).Rows.Add(dsNew)
            SaveEntry(ds)
        End Using

        SaveCareKit()
        AddCareKit()
    End Sub

    Public Sub SaveBAllowanceRelieved()
        Dim sql As String = "SELECT * FROM TBL_BHOUSE_ALLOWANCE ROWS 1"
        Using ds As DataSet = LoadSQL(sql, "TBL_BHOUSE_ALLOWANCE")

            Dim dsNew As DataRow
            dsNew = ds.Tables(0).NewRow

            With dsNew
                .Item("RELIEVE_ID") = Manning_ID
                .Item("ALLOWANCE") = Allowance
                .Item("DATE_NOTIFY") = Date_Notify
                .Item("STATUS") = Status
            End With
            ds.Tables(0).Rows.Add(dsNew)
            SaveEntry(ds)
        End Using
        SaveCareKit()
        AddCareKitRelieved()
    End Sub

    Public Sub SaveBAllowanceAppointed()
        Dim sql As String = "SELECT * FROM TBL_BHOUSE_ALLOWANCE ROWS 1"
        Using ds As DataSet = LoadSQL(sql, "TBL_BHOUSE_ALLOWANCE")

            Dim dsNew As DataRow
            dsNew = ds.Tables(0).NewRow

            With dsNew
                .Item("APPOINTED_ID") = Manning_ID
                .Item("ALLOWANCE") = Allowance
                .Item("DATE_NOTIFY") = Date_Notify
                .Item("STATUS") = Status
            End With
            ds.Tables(0).Rows.Add(dsNew)
            SaveEntry(ds)
        End Using
        SaveCareKit()
        AddCareKitAppointed()
    End Sub

    Public Sub UpdateAllowance(idx As Integer)
        Dim sql As String = "select * from TBL_BHOUSE_ALLOWANCE where ID = " & idx & ";"
        Using ds As DataSet = LoadSQL(sql, "TBL_BHOUSE_ALLOWANCE")

            If ds.Tables(0).Rows.Count <= 0 Then
                MsgBox("No items found")
            Else
                With ds.Tables(0).Rows(0)
                    If Not Other_Allowance <= 0 Or Not Other_Allowance = Nothing Then
                        .Item("OTHER_ALLOWANCE") = Other_Allowance
                    End If
                    .Item("ALLOWANCE") = Allowance
                    .Item("STATUS") = Status
                    .Item("PARTICULARS") = Particulars
                    idx = CInt(.Item("CAREKIT_ID"))
                End With
                SaveEntry(ds, False)
            End If
        End Using

        Dim sqlx As String = "select * from TBL_CARE_KIT where ID = " & idx & ""
        Dim dsx As DataSet = LoadSQL(sqlx, "TBL_CARE_KIT")

        If dsx.Tables(0).Rows.Count > 0 Then
            With dsx.Tables(0).Rows(0)
                If Not CareKit_Allowance <= 0 Or Not CareKit_Allowance = Nothing Then
                    .Item("AMOUNT") = CareKit_Allowance
                End If
                .Item("STATUS") = 1
                .Item("NOTE") = Particulars
            End With
        End If
        SaveEntry(dsx, False)
    End Sub

    Public Sub SaveCareKit()
        Dim sql As String = "select * from TBL_CARE_KIT rows 1"
        Using ds As DataSet = LoadSQL(sql, "TBL_CARE_KIT")

            Dim dsNew As DataRow

            dsNew = ds.Tables(0).NewRow

            With dsNew
                .Item("AMOUNT") = CareKit_Allowance
                .Item("STATUS") = Status
                .Item("NOTE") = Particulars
            End With
            ds.Tables(0).Rows.Add(dsNew)
            SaveEntry(ds)
        End Using
    End Sub

    Private Sub AddCareKitAppointed()
        Dim i As New Integer
        Dim sql As String = "SELECT MAX(ID) as ID from TBL_CARE_KIT ROWS 1"
        Using ds As DataSet = LoadSQL(sql, "TBL_CARE_KIT")

            With ds.Tables(0).Rows(0)
                CareKit_ID = CInt(.Item("ID"))
            End With
        End Using

        Dim sql1 As String = "select MAX(ID) as ID from TBL_APPOINT ROWS 1"
        Using ds1 As DataSet = LoadSQL(sql1, "TBL_APPOINT")

            With ds1.Tables(0).Rows(0)
                i = CInt(.Item("ID"))
            End With
        End Using

        Dim mysql As String = "select * from TBL_BHOUSE_ALLOWANCE where APPOINTED_ID = " & i & ";"
        Using dsx As DataSet = LoadSQL(mysql, "TBL_BHOUSE_ALLOWANCE")
            If dsx.Tables(0).Rows.Count > 0 Then
                With dsx.Tables(0).Rows(0)
                    .Item("CAREKIT_ID") = CareKit_ID
                    .Item("PARTICULARS") = Particulars
                End With
            End If
            SaveEntry(dsx, False)
        End Using
    End Sub

    Private Sub AddCareKitRelieved()
        Dim i As New Integer
        Dim sql As String = "SELECT MAX(ID) as ID from TBL_CARE_KIT ROWS 1"
        Using ds As DataSet = LoadSQL(sql, "TBL_CARE_KIT")

            With ds.Tables(0).Rows(0)
                CareKit_ID = CInt(.Item("ID"))
            End With
        End Using

        Dim sql1 As String = "select MAX(RELIEVE_ID) as ID from TBL_RELIEVE ROWS 1"
        Using ds1 As DataSet = LoadSQL(sql1, "TBL_RELIEVE")

            With ds1.Tables(0).Rows(0)
                i = CInt(.Item("ID"))
            End With
        End Using

        Dim mysql As String = "select * from TBL_BHOUSE_ALLOWANCE where RELIEVE_ID = " & i & ";"
        Using dsx As DataSet = LoadSQL(mysql, "TBL_BHOUSE_ALLOWANCE")
            If dsx.Tables(0).Rows.Count > 0 Then
                With dsx.Tables(0).Rows(0)
                    .Item("CAREKIT_ID") = CareKit_ID
                    .Item("PARTICULARS") = Particulars
                End With
            End If
            SaveEntry(dsx, False)
        End Using
    End Sub

    Private Sub AddCareKit()
        Dim sql As String = "SELECT MAX(ID) as ID from TBL_CARE_KIT ROWS 1"
        Using ds As DataSet = LoadSQL(sql, "TBL_CARE_KIT")

            With ds.Tables(0).Rows(0)
                CareKit_ID = CInt(.Item("ID"))
            End With
        End Using

        Dim mysql As String = "select * from TBL_BHOUSE_ALLOWANCE where MANNING_ID = " & Manning_ID & ";"
        Using dsx As DataSet = LoadSQL(mysql, "TBL_BHOUSE_ALLOWANCE")
            If dsx.Tables(0).Rows.Count > 0 Then
                With dsx.Tables(0).Rows(0)
                    .Item("CAREKIT_ID") = CareKit_ID
                    .Item("PARTICULARS") = Particulars
                End With
            End If
            SaveEntry(dsx, False)
        End Using
    End Sub

    Public Sub UpdateFullAllowance()

        Dim sql As String = "SELECT MAX(ID) as ID from TBL_CARE_KIT ROWS 1"
        Using ds As DataSet = LoadSQL(sql, "TBL_CARE_KIT")

            With ds.Tables(0).Rows(0)
                CareKit_ID = CInt(.Item("ID"))
            End With
        End Using

        Dim mysql As String = "select * from TBL_BHOUSE_ALLOWANCE where ID = " & ID & ";"
        Using dsx As DataSet = LoadSQL(mysql, "TBL_BHOUSE_ALLOWANCE")
            If dsx.Tables(0).Rows.Count > 0 Then
                With dsx.Tables(0).Rows(0)
                    .Item("CAREKIT_ID") = CareKit_ID
                    .Item("AMOUNT") = CareKit_Allowance
                    .Item("PARTICULARS") = Particulars
                End With
            End If
            SaveEntry(dsx, False)
        End Using
    End Sub

    Public Sub UpdateOtherAllowance()
        Dim mysql As String = "select * from TBL_BHOUSE_ALLOWANCE where ID = " & ID & ";"
        Using dsx As DataSet = LoadSQL(mysql, "TBL_BHOUSE_ALLOWANCE")

            With dsx.Tables(0).Rows(0)
                .Item("OTHER_ALLOWANCE") = Other_Allowance
                .Item("PARTICULARS") = Particulars
            End With
            SaveEntry(dsx, False)
        End Using
    End Sub

    Public Sub Void_Allowance()
        Dim sql As String = "select * from TBL_BHOUSE_ALLOWANCE WHERE ID = " & ID & ";"
        Using ds As DataSet = LoadSQL(sql, "TBL_BHOUSE_ALLOWANCE")

            With ds.Tables(0).Rows(0)
                .Item("VOID") = 1
            End With
            SaveEntry(ds, False)
        End Using
    End Sub

    Public Sub LoadAllowanceNotify()
        Dim sql As String = $"select * from ALLOWANCE_NOTIFY WHERE DATE_NOTIFY BETWEEN '{Now.ToShortDateString}' AND '{Now.AddDays(5).ToShortDateString}'"
        Using ds = LoadSQL(sql, "ALLOWANCE_NOTIFY")
            If ds.Tables(0).Rows.Count > 0 Then
                LoadItems(ds.Tables(0).Rows(0))
            Else
                Exit Sub
            End If
        End Using
    End Sub

    Public Sub LoadItems(dr As DataRow)
        If dr Is Nothing Then
            Exit Sub
        End If
        With dr
            ID = .Item(0)
            FullName = .Item(1)
            CareKit_Allowance = .Item(2)
            Allowance = .Item(3)
            Other_Allowance = .Item(4)
            Status = .Item(5)
            Particulars = .Item(6)
        End With
    End Sub

#End Region

End Class