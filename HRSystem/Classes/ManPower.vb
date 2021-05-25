Public Class ManPower

#Region "Properties"

    Public Property ID() As Integer

    Public Property RelieveID() As Integer

    Public Property Assignstat() As Integer

    Public Property Employee() As employee

    Public Property Brnch() As Branch

    Public Property EmpID() As Integer

    Public Property BranchID() As Integer

    Public Property WBranchID() As Integer

    Public Property Position() As String

    Public Property Reason() As String

    Public Property Signstatus() As Integer

    Public Property AssignDate() As Date

    Public Property Remarks() As String

    Public Property CreatedDate() As Date

    Public Property Status() As Integer

    Public Property W_employee() As Integer

    Public Property W_remarks() As String

    Public Property Relieve_position() As String

    Public Property Firstname() As String

    Public Property Lastname() As String

    Public Property Middlename() As String

    Public Property Suffix() As String

    Public Property Gender() As String

    Public Property Presentaddres() As String

    Public Property Contactno() As String

    Public Property Companyname() As String

    Public Property Branchname() As String

    Public Property Branchcode() As String

    Public Property Weeklynotify() As String

    Public Property Monthlynotify() As String

    Public Property Brancharea() As String

    Public Property Manningid() As Integer

    Public Property Void() As String

    Public Property NumberOfDays() As Integer

    Public Property R_Branch_ID() As Integer
    Public Property Stat() As String


#End Region

#Region "Procedures"

    Property pressent_Street As String

    Friend Sub SaveManPower()
        Dim mysql As String = "Select * From tblManning Rows 1"
        Using ds As DataSet = LoadSQL(mysql, "tblManning")
            Dim dsNewRow As DataRow = ds.Tables(0).NewRow
            With dsNewRow
                .Item("Emp_ID") = EmpID
                .Item("Emp_Position") = Position
                .Item("Branch_ID") = BranchID
                .Item("Assign_Date") = AssignDate
                .Item("WEEK_NOTIFY") = Weeklynotify
                .Item("MONTH_NOTIFY") = Monthlynotify
                .Item("Remarks") = Remarks
                .Item("Status") = "1"
                .Item("WORK_STATUS") = "1"
                .Item("SIGNSTATUS") = Signstatus
                .Item("REASON") = Reason
                Action = 1
            End With
            ds.Tables(0).Rows.Add(dsNewRow)
            SaveEntry(ds)
        End Using

        Dim Sql As String = "Select MAX(ID) as ID from tblManning rows 1"
        Using dsx As DataSet = LoadSQL(Sql, "tblManning")

            With dsx.Tables(0).Rows(0)
                Manning_ID = .Item("ID")
                EMP_Status = "ASSIGNED"
                SaveHistory()
            End With
        End Using

        mysql = "SELECT * FROM tbl_Employee  Where ID = '" & EmpID & "'"
        Using ds As DataSet = LoadSQL(mysql, "tbl_Employee")

            With ds.Tables(0).Rows(0)
                .Item("ASSIGN_STATUS") = Assignstat
            End With
            SaveEntry(ds, False)
        End Using

    End Sub

    Friend Sub SAVERELIEVER()
        Dim mysql As String = "Select * From TBL_RELIEVE Rows 1"
        Using ds As DataSet = LoadSQL(mysql, "TBL_RELIEVE")
            Dim dsNewRow As DataRow = ds.Tables(0).NewRow
            With dsNewRow
                .Item("R_EMPLOYEE_ID") = RelieveID
                .Item("W_EMPLOYEE_ID") = W_employee
                .Item("BRANCH_ID") = WBranchID
                .Item("R_POSITION") = Relieve_position
                .Item("REMARKS") = W_remarks
                .Item("STATUS") = 1
                .Item("SIGNINSTATUS") = Signstatus
                .Item("REASON") = Reason
                .Item("NUMBER_OF_DAYS_ASSIGNED") = NumberOfDays - 1
                .Item("R_BRANCH_ID") = R_Branch_ID
                .Item("ASSIGN_DATE") = AssignDate
                Position = .Item("R_POSITION")
            End With
            ds.Tables(0).Rows.Add(dsNewRow)
            SaveEntry(ds)
        End Using

        Dim Sql As String = "Select MAX(RELIEVE_ID) as ID from TBL_RELIEVE rows 1"
        Using dsx As DataSet = LoadSQL(Sql, "TBL_RELIEVE")

            With dsx.Tables(0).Rows(0)
                Relieve_ID = .Item("ID")
                EMP_Status = "RELIEVE"
                BranchID = R_Branch_ID
                Action = 1
                SaveHistoryFromRelieve()
            End With
        End Using
    End Sub

    Friend Sub LoadManPower(ByVal idx As Integer)
        Dim mysql As String = "Select * From tblManning Where ID = '" & idx & "'"
        Using ds As DataSet = LoadSQL(mysql, "tblManning")

            LoadByRows(ds.Tables(0).Rows(0))
        End Using
    End Sub

    Private Sub LOADassigneROWS(ByVal dr As DataRow)
        With dr

            EmpID = CInt(.Item("ID"))

            Firstname = .Item("FIRSTNAME")
            Middlename = .Item("MIDDLENAME")
            Lastname = .Item("LASTNAME")
            Suffix = .Item("SUFFIX") 
            Presentaddres = .Item("PROVINCE") & "" & .Item("CITYMUN") & " " & .Item("BARANGAY") & "  " & .Item("PRESENT_STREET")
            Gender = .Item("gender")
            Contactno = .Item("CONTACTNO")
            AssignDate = .Item("ASSIGN_DATE")

            'CheckDBNull(.Item("REMARKS1"), Remarks)
            'CheckDBNull(.Item("BRANCH_ID"), BranchID)
            'CheckDBNull(.Item("EMP_POSITION"), Position)
            'CheckDBNull(.Item("STATUS"), Stat)

            If IsDBNull(.Item("REMARKS1")) Then
                Remarks = ""
            Else
                Remarks = .Item("REMARKS1")
            End If

            If IsDBNull(.Item("BRANCH_ID")) Then
                BranchID = 0
            Else
                BranchID = .Item("BRANCH_ID")
            End If

            If IsDBNull(.Item("EMP_POSITION")) Then
                Position = ""
            Else
                Position = .Item("EMP_POSITION")
            End If

            If IsDBNull(.Item("STATUS")) Then
                Stat = ""
            Else
                Stat = .Item("STATUS")
            End If

            Companyname = .Item("COMPANYNAME")

            Branchname = .Item("BRANCHNAME")
            Branchcode = .Item("BRANCHCODE")
            Brancharea = .Item("BRANCHAREA")

            Manningid = .Item("id1")
            Signstatus = .Item("SIGNSTATUS")
            Reason = .Item("REASON").ToString
            Weeklynotify = .Item("WEEK_NOTIFY")
            Monthlynotify = .Item("MONTH_NOTIFY")
        End With

    End Sub

    Private Sub CheckDBNull(column As String, info As String)
        If IsDBNull(column) Then
            info = ""
        Else
            info = column
        End If
    End Sub

    Private Sub LOADAllowance(ByVal dr As DataRow)
        With dr

            EmpID = CInt(.Item("ID"))
            Firstname = .Item("FIRSTNAME")
            Middlename = .Item("MIDDLENAME")
            Lastname = .Item("LASTNAME")
            Suffix = .Item("SUFFIX")
            Gender = .Item("gender")
            Contactno = .Item("CONTACTNO")
            AssignDate = .Item("ASSIGN_DATE")

            If IsDBNull(.Item("BRANCH_ID")) Then
                BranchID = 0
            Else
                BranchID = .Item("BRANCH_ID")
            End If
            Companyname = .Item("COMPANYNAME")

            Branchname = .Item("BRANCHNAME")
            Branchcode = .Item("BRANCHCODE")
            Brancharea = .Item("BRANCHAREA")

            If IsDBNull(.Item("EMP_POSITION")) Then
                Position = ""
            Else
                Position = .Item("EMP_POSITION")
            End If

            Manningid = .Item("id1")
            Signstatus = .Item("SIGNSTATUS")
            Reason = .Item("REASON").ToString
            Weeklynotify = .Item("WEEK_NOTIFY")
            Monthlynotify = .Item("MONTH_NOTIFY")
        End With

    End Sub

    Private Sub LOADRELIEVEROWS(ByVal dr As DataRow)
        With dr
            RelieveID = .Item("RELIEVE_ID")

            ID = .Item("ID")
            Firstname = .Item("FIRSTNAME")
            Middlename = .Item("MIDDLENAME")
            Lastname = .Item("LASTNAME")
            Suffix = .Item("SUFFIX")
            Remarks = .Item("REMARKS1")
            Presentaddres = .Item("PROVINCE") & "" & .Item("CITYMUN") & " " & .Item("BARANGAY") & "  " & .Item("PRESENT_STREET")

            Gender = .Item("gender")
            Contactno = .Item("CONTACTNO")
            AssignDate = .Item("ASSIGN_DATE")
            Relieve_position = .Item("R_POSITION")

            W_employee = .Item("W_EMPLOYEE_ID")
            WBranchID = .Item("ID2")
            Signstatus = .Item("SIGNINSTATUS")
            Reason = .Item("REASON").ToString
        End With
    End Sub

    Friend Sub LOADMANNIG(Optional ByVal idx As Integer = 0)

        Dim mysql As String = "SELECT * from TBL_EMPLOYEE 
                                        INNER JOIN TBLMANNING ON TBL_EMPLOYEE.ID = TBLMANNING.EMP_ID  
                                        INNER JOIN TBL_BRANCH ON TBLMANNING.BRANCH_ID = TBL_BRANCH.ID 
                                        INNER JOIN TBL_ADDRESS ON TBL_EMPLOYEE.PRESENT_ADDID=TBL_ADDRESS.ID   
                                                   WHERE tblmanning.id = '" & idx & "'"

        Using ds As DataSet = LoadSQL(mysql, "tbl_Employee")
            LOADassigneROWS(ds.Tables(0).Rows(0))
        End Using

    End Sub

    Friend Sub LOADMANNIGRatings()
        Dim mysql As String = "SELECT * from TBL_EMPLOYEE INNER JOIN TBLMANNING ON TBL_EMPLOYEE.ID=TBLMANNING.EMP_ID  INNER JOIN TBL_BRANCH ON TBLMANNING.BRANCH_ID =TBL_BRANCH.ID INNER JOIN TBL_ADDRESS ON TBL_EMPLOYEE.PRESENT_ADDID=TBL_ADDRESS.ID  WHERE WEEK_NOTIFY BETWEEN '" _
                              & Now.ToShortDateString() _
                              & "' AND '" _
                              & Now.AddDays(7).ToShortDateString() _
                              & "' AND WORK_STATUS='1' AND TBLMANNING.VOID = 0"
        Using ds As DataSet = LoadSQL(mysql, "tbl_Employee")

            If ds.Tables(0).Rows.Count > 0 Then
                LOADassigneROWS(ds.Tables(0).Rows(0))
            End If
        End Using

    End Sub

    Friend Sub LOADRELIEVE(ByVal idx As Integer)
        Dim mysql As String = "SELECT * FROM TBL_RELIEVE INNER JOIN TBL_EMPLOYEE  ON TBL_RELIEVE.R_EMPLOYEE_ID=TBL_EMPLOYEE.id  INNER JOIN TBL_ADDRESS ON TBL_EMPLOYEE.ID=TBL_ADDRESS.ID INNER JOIN TBL_BRANCH ON TBL_RELIEVE.BRANCH_ID =TBL_BRANCH.ID  WHERE TBL_RELIEVE.RELIEVE_ID= '" _
                              & idx _
                              & "' AND TBL_RELIEVE.VOID = 0"
        Using ds As DataSet = LoadSQL(mysql, "TBL_RELIEVE")
            If ds.Tables(0).Rows.Count > 0 Then
                LOADRELIEVEROWS(ds.Tables(0).Rows(0))
            End If
        End Using
    End Sub

    Friend Sub Updatereleive()

        Dim mysql As String = "SELECT * FROM tbl_RELIEVE  Where RELIEVE_ID = '" & RelieveID & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_RELIEVE")

        With ds.Tables(0).Rows(0)
            .Item("R_EMPLOYEE_ID") = EmpID
            .Item("W_EMPLOYEE_ID") = W_employee
            .Item("R_POSITION") = Position
            .Item("ASSIGN_DATE") = AssignDate
            .Item("SIGNINSTATUS") = Signstatus
            .Item("REASON") = Reason
            .Item("NUMBER_OF_DAYS_ASSIGNED") = NumberOfDays - 1
        End With
        SaveEntry(ds, False)
        Relieve_ID = RelieveID
        EMP_Status = "RELIEVE"
        Action = 2
        SaveHistoryFromUpdateRelieve()
    End Sub

    Friend Sub UPDATEMANNING(idx As Integer)
        Dim mysql As String = "Select * From tblManning  WHERE EMP_ID = '" & idx & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tblManning")

        With ds.Tables(0).Rows(0)

            .Item("ID") = Manningid
            .Item("EMP_ID") = EmpID

            .Item("EMP_POSITION") = Position
            .Item("BRANCH_ID") = BranchID
            .Item("ASSIGN_DATE") = AssignDate
            .Item("WEEK_NOTIFY") = Weeklynotify
            .Item("MONTH_NOTIFY") = Monthlynotify
            .Item("REMARKS") = Remarks
            .Item("SIGNSTATUS") = Signstatus
            .Item("REASON") = Reason
            .Item("RE_ASSIGN_STATUS") = Status

            Action = 2

            If Status = 0 Then
                EMP_Status = "ASSIGNED"
            Else
                EMP_Status = "REASSIGNED"
            End If

        End With

        SaveEntry(ds, False)
        SaveHistoryFromUpdate(Manningid)
    End Sub

    Public Sub VoidAssigned()
        Dim mysql As String = "Select * From tblManning  WHERE ID = '" & ID & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tblManning")
        If ds.Tables(0).Rows.Count > 0 Then
            With ds.Tables(0).Rows(0)
                .Item("VOID") = 1
                Position = .Item("EMP_POSITION")
                BranchID = .Item("BRANCH_ID")
            End With
            SaveEntry(ds, False)
        End If
        Manning_ID = ID
        Action = 3
        EMP_Status = "ASSIGNED"
        SaveHistoryFromVAssigned()
    End Sub

    Public Sub VoidReliever()
        Dim mysql As String = "SELECT * FROM tbl_RELIEVE  Where RELIEVE_ID = '" & ID & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_RELIEVE")
        If ds.Tables(0).Rows.Count > 0 Then
            With ds.Tables(0).Rows(0)
                .Item("VOID") = 1
                Position = .Item("R_POSITION")
                R_Branch_ID = .Item("R_BRANCH_ID")
            End With
            SaveEntry(ds, False)
        End If
        Relieve_ID = ID
        Action = 3
        EMP_Status = "RELIEVE"
        SaveHistoryFromVRelieve()
    End Sub

    Private Sub LoadByRows(ByVal dr As DataRow)
        With dr
            ID = CInt(.Item("ID"))
            EmpID = .Item("Emp_ID")
            Position = .Item("Emp_Position")
            BranchID = .Item("Branch_ID")
            AssignDate = .Item("Assign_Date")
            Remarks = .Item("Remarks")
            Status = .Item("Status")
        End With
    End Sub

#End Region

#Region "History"

#Region "Propeties"

    Public Property Manning_ID() As Integer

    Public Property UserID() As Integer

    Public Property Action() As Integer

    Public Property EMP_Status() As String

    Public Property Relieve_ID() As Integer

#End Region

#Region "Function & Methods"

    Dim userIDx As String = frmMainForm.ID_LBL.Text

    Public Sub SaveHistory()
        Dim sql As String = "Select * From TBL_MANNING_HISTORY Rows 1"
        Dim ds As DataSet = LoadSQL(sql, "TBL_MANNING_HISTORY")

        Dim dsNewrow As DataRow
        dsNewrow = ds.Tables(0).NewRow

        With dsNewrow
            .Item("USER_ID") = userIDx
            .Item("MANNING_ID") = Manning_ID
            .Item("BRANCH_ID") = BranchID
            .Item("EMP_POSITION") = Position
            .Item("EMP_STATUS") = EMP_Status
            .Item("ACTION") = Action
        End With
        ds.Tables(0).Rows.Add(dsNewrow)
        SaveEntry(ds)
    End Sub

    Public Sub SaveHistoryFromUpdate(idx As Integer)
        Dim sql As String = "Select * From TBL_MANNING_HISTORY Rows 1"
        Dim ds As DataSet = LoadSQL(sql, "TBL_MANNING_HISTORY")

        Dim dsNewrow As DataRow
        dsNewrow = ds.Tables(0).NewRow

        With dsNewrow
            .Item("USER_ID") = userIDx
            .Item("MANNING_ID") = idx
            .Item("BRANCH_ID") = BranchID
            .Item("EMP_POSITION") = Position
            .Item("EMP_STATUS") = EMP_Status
            .Item("ACTION") = Action
        End With
        ds.Tables(0).Rows.Add(dsNewrow)
        SaveEntry(ds)
    End Sub

    Public Sub SaveHistoryFromRelieve()
        Dim sql As String = "Select * From TBL_MANNING_HISTORY Rows 1"
        Dim ds As DataSet = LoadSQL(sql, "TBL_MANNING_HISTORY")

        Dim dsNewrow As DataRow
        dsNewrow = ds.Tables(0).NewRow

        With dsNewrow
            .Item("USER_ID") = userIDx
            .Item("RELIEVE_ID") = Relieve_ID
            .Item("BRANCH_ID") = BranchID
            .Item("EMP_POSITION") = Position
            .Item("EMP_STATUS") = EMP_Status
            .Item("ACTION") = Action
        End With
        ds.Tables(0).Rows.Add(dsNewrow)
        SaveEntry(ds)
    End Sub

    Public Sub SaveHistoryFromUpdateRelieve()
        Dim sql As String = "Select * From TBL_MANNING_HISTORY Rows 1"
        Dim ds As DataSet = LoadSQL(sql, "TBL_MANNING_HISTORY")

        Dim dsNewrow As DataRow
        dsNewrow = ds.Tables(0).NewRow

        With dsNewrow
            .Item("USER_ID") = userIDx
            .Item("RELIEVE_ID") = Relieve_ID
            .Item("BRANCH_ID") = R_Branch_ID
            .Item("EMP_POSITION") = Position
            .Item("EMP_STATUS") = EMP_Status
            .Item("ACTION") = Action
        End With
        ds.Tables(0).Rows.Add(dsNewrow)
        SaveEntry(ds)
    End Sub

    Public Sub SaveHistoryFromVAssigned()
        Dim sql As String = "Select * From TBL_MANNING_HISTORY Rows 1"
        Dim ds As DataSet = LoadSQL(sql, "TBL_MANNING_HISTORY")

        Dim dsNewrow As DataRow
        dsNewrow = ds.Tables(0).NewRow

        With dsNewrow
            .Item("USER_ID") = userIDx
            .Item("MANNING_ID") = Manning_ID
            .Item("BRANCH_ID") = BranchID
            .Item("EMP_POSITION") = Position
            .Item("EMP_STATUS") = EMP_Status
            .Item("ACTION") = Action
        End With
        ds.Tables(0).Rows.Add(dsNewrow)
        SaveEntry(ds)
    End Sub

    Public Sub SaveHistoryFromVRelieve()
        Dim sql As String = "Select * From TBL_MANNING_HISTORY Rows 1"
        Dim ds As DataSet = LoadSQL(sql, "TBL_MANNING_HISTORY")

        Dim dsNewrow As DataRow
        dsNewrow = ds.Tables(0).NewRow

        With dsNewrow
            .Item("USER_ID") = userIDx
            .Item("RELIEVE_ID") = Relieve_ID
            .Item("BRANCH_ID") = R_Branch_ID
            .Item("EMP_POSITION") = Position
            .Item("EMP_STATUS") = EMP_Status
            .Item("ACTION") = Action
        End With
        ds.Tables(0).Rows.Add(dsNewrow)
        SaveEntry(ds)
    End Sub

#End Region

#End Region

End Class