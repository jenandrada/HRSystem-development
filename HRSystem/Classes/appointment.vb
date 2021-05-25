Public Class appointment

#Region "PROPERTIES"

    Public Property ID() As Integer

    Public Property employeid() As Integer

    Public Property FirstName() As String

    Public Property MiddleName() As String

    Public Property LastName() As String

    Public Property Suffix() As String

    Public Property branchid() As String

    Public Property schedule() As String

    Public Property remarks() As String

    Public Property gender() As String

    Public Property contactno() As String

    Public Property companyname() As String

    Public Property branchname() As String

    Public Property branchcode() As String

    Public Property brancharea() As String

    Public Property Appointed_Status() As String

    Public Property Emp_Position() As String

    Public Property Date_Created() As String

    Public Property Work_Status() As String

    Public Property Sign_Status() As String

    Public Property Reason() As String

    Public Property Week_Notify() As String

    Public Property Month_Notify() As String

    Public Property Assign_Status() As String

    Public Property ManID() As String

#End Region

#Region "FUNCTION"

    Friend Sub Loadappointlist(ByVal idx As Integer)
        Dim mysql As String = "select * from TBL_APPOINT INNER JOIN TBL_EMPLOYEE ON TBL_APPOINT.EMP_ID=TBL_EMPLOYEE.ID  INNER JOIN TBL_BRANCH ON TBL_APPOINT.BRANCH_ID =TBL_BRANCH.ID INNER JOIN TBLMANNING ON TBL_EMPLOYEE.ID = TBLMANNING.EMP_ID WHERE TBL_APPOINT.id= '" & idx & "' AND APPOINTED_STATUS = 1"
        Using ds As DataSet = LoadSQL(mysql, "TBL_APPOINT")
            If ds.Tables(0).Rows.Count > 0 Then
                Loadappointment(ds.Tables(0).Rows(0))
                LoadAppoitedList()
            End If
        End Using

    End Sub

    Friend Sub LoadAppoitedList()
        Dim mysql As String = "select case APPOINTED_STATUS WHEN '1' THEN 'APPOINTED' WHEN '0' THEN 'NOT APPOINTED' END AS APPOINTED_STATUS from TBLMANNING WHERE ID = " & ManID & ";"
        Using ds As DataSet = LoadSQL(mysql, "TBLMANNING")

            Loadappointedlist(ds.Tables(0).Rows(0))
        End Using
    End Sub

    Private Sub Loadappointedlist(dr As DataRow)
        With dr
            Appointed_Status = .Item("APPOINTED_STATUS")
        End With
    End Sub

    Friend Sub Uppdateappointment()
        Dim mysql As String = "Select * From TBL_APPOINT Where ID = '" & ID & "'"
        Dim ds As DataSet = LoadSQL(mysql, "TBL_APPOINT")

        With ds.Tables(0).Rows(0)
            .Item("EMP_ID") = employeid
            .Item("Schedule") = schedule
            .Item("Remarks") = remarks
            .Item("BRANCH_ID") = branchid
            .Item("APPOINTED_POSITION") = Emp_Position
        End With
        SaveEntry(ds, False)
    End Sub

    Private Sub Loadappointment(ByVal dr As DataRow)
        With dr
            If Not IsDBNull(.Item("ASSIGN_STATUS")) Then
                ID = .Item("ID")
                employeid = .Item("EMP_ID")
                FirstName = .Item("FIRSTNAME")
                MiddleName = .Item("MIDDLENAME")
                LastName = .Item("LASTNAME")
                Suffix = .Item("SUFFIX")
                remarks = .Item("REMARKS")
                branchid = .Item("BRANCH_ID")
                gender = .Item("GENDER")
                contactno = .Item("CONTACTNO")
                schedule = .Item("SCHEDULE")
                companyname = .Item("COMPANYNAME")
                branchid = .Item("BRANCH_ID")
                branchname = .Item("BRANCHNAME")
                branchcode = .Item("BRANCHCODE")
                brancharea = .Item("BRANCHAREA")
                If IsDBNull(.Item("APPOINTED_POSITION")) Then
                    Emp_Position = ""
                Else
                    Emp_Position = .Item("APPOINTED_POSITION")
                End If
                Assign_Status = .Item("ASSIGN_STATUS")
                ManID = .Item("ID3")
            Else
                Exit Sub
            End If
        End With

    End Sub

    Friend Sub SAVE_APPOINTMENT()
        Dim mysql As String = "Select * From tbl_APPOINT Rows 1"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_APPOINT")

        Dim dsNewRow As DataRow
        dsNewRow = ds.Tables(0).NewRow
        With dsNewRow
            .Item("EMP_ID") = employeid
            .Item("SCHEDULE") = schedule
            .Item("REMARKS") = remarks
            .Item("STATUS") = 1
            .Item("BRANCH_ID") = branchid
            .Item("APPOINTED_POSITION") = Emp_Position
        End With
        ds.Tables(0).Rows.Add(dsNewRow)
        SaveEntry(ds)

        Dim query As String = "Select * From TBLMANNING Rows 1"
        Dim dataset As DataSet = LoadSQL(query, "TBLMANNING")
        Dim dsNewRowManning As DataRow
        dsNewRowManning = dataset.Tables(0).NewRow
        With dsNewRowManning
            .Item("Emp_ID") = employeid
            .Item("Emp_Position") = Emp_Position
            .Item("Branch_ID") = branchid
            .Item("Assign_Date") = schedule
            .Item("WEEK_NOTIFY") = Week_Notify
            .Item("MONTH_NOTIFY") = Month_Notify
            .Item("Remarks") = remarks
            .Item("Status") = "1"
            .Item("WORK_STATUS") = "1"
            .Item("SIGNSTATUS") = Sign_Status
            .Item("REASON") = Reason
            .Item("APPOINTED_STATUS") = 1
            .Item("VOID") = 0
        End With
        dataset.Tables(0).Rows.Add(dsNewRowManning)
        SaveEntry(dataset)
    End Sub

#End Region

End Class