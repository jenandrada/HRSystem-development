Public Class frmGenerate

    Enum ReportType As Integer
        Manpower = 0
        ManpowerMonthly = 1
        ActiveList = 2
        reliever = 3
        aggreeassigned = 4
        relieveaggree = 5
        monthaggreeassigned = 6
        monthaggreeagrrement = 7
        rating = 8
        ratingmontly = 9
        appointment = 10
        appointmentmonthly = 11
        bhouseallowanceMonthly = 12

    End Enum

    Friend FormType As ReportType = ReportType.Manpower

    Private Sub btnGenerate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGenerate.Click
        If cboCompany.SelectedIndex = -1 Then MessageBox.Show("No company selected.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Select Case FormType
            Case ReportType.Manpower
                ManPowerReport()
            Case ReportType.ManpowerMonthly
                ManPowerReportMonthly()
            Case ReportType.ActiveList
                ManPowerActiveList()
            Case ReportType.aggreeassigned
                aggreeassigned()
            Case ReportType.relieveaggree
                relieveaggrement()
            Case ReportType.monthaggreeassigned
                monthaggreeassign()
            Case ReportType.monthaggreeagrrement
                relieveaggrementmonthly()
            Case ReportType.rating
                rating()
            Case ReportType.ratingmontly
                ratingmonthly()
            Case ReportType.appointment
                appointment()
            Case ReportType.appointmentmonthly
                appointmentmontly()
            Case ReportType.bhouseallowanceMonthly
                BhouseAllowanceMonthly()
        End Select

    End Sub

    Private Sub ManPowerReport()
        Dim dsName As String, rptPath As String
        dsName = "dsManpower"
        rptPath = "HRSystem.rptManpower.rdlc"

        Dim mysql As String = "Select M.ID, E.FirstName ||' ' || E.Lastname as EmpName, M.Emp_Position as EmpPosition, "
        mysql &= "B.CompanyName, B.BranchName, M.Assign_Date, M.Remarks, "
        mysql &= "Case E.Status "
        mysql &= "When 'PRO' Then 'Probationary' "
        mysql &= "When 'REG' Then 'Regular' "
        mysql &= "When 'AWO' Then 'Awol' "
        mysql &= "When 'RES' Then 'Resigned' "
        mysql &= "When 'TER' Then 'Terminated' "
        mysql &= "When 'SUS' Then 'Suspended' "
        mysql &= "When 'APP' Then 'Appointed' "
        mysql &= "When 'END' Then 'End of Probationary' End as Status,"
        mysql &= "E.DateHired, B.Brancharea, B.BranchCode "
        mysql &= "From tblManning M "
        mysql &= "Inner Join tbl_Employee E ON E.ID = M.EMP_ID "
        mysql &= "Inner Join tbl_Branch B On B.ID = M.Branch_ID "
        mysql &= "Where M.Assign_Date = '" & monCal.SelectionStart.ToShortDateString & "' And B.CompanyName = '" & cboCompany.Text & "'"

        Dim addParameter As New Dictionary(Of String, String)
        addParameter.Add("txtMonthOf", "DATE : " & monCal.SelectionStart.ToString("MMMM dd, yyyy"))
        'addParameter.Add("branchName", branchName)
        'addParameter.Add("txtUsername", POSuser.UserName)

        frmReport.ReportInit(mysql, dsName, rptPath, addParameter)
        frmReport.Show()
    End Sub

    Private Sub aggreeassigned()
        Dim dsName As String, rptPath As String
        dsName = "dsagreement"
        rptPath = "HRSystem.rpt_aggreement.rdlc"

        Dim mysql As String = "SELECT TBL_EMPLOYEE.FirstName ||' ' ||TBL_EMPLOYEE.Lastname as EmpName,COMPANYNAME,BranchName,BRANCHCODE AS CODE,TBLMANNING.ASSIGN_DATE AS DATEASSIGNED,REASON,TBLMANNING.SIGNSTATUS  ,Case TBLMANNING.SIGNSTATUS  When '1' Then 'YES' When '0' Then 'NO' End as STATUS FROM TBLMANNING INNER JOIN TBL_EMPLOYEE ON TBLMANNING.EMP_ID=TBL_EMPLOYEE.ID Inner Join tbl_Branch ON tbl_Branch.ID=TBLMANNING.BRANCH_ID "

        mysql &= "Where TBLMANNING.Assign_Date = '" & monCal.SelectionStart.ToShortDateString & "' And tbl_Branch.CompanyName = '" & cboCompany.Text & "'"

        Dim addParameter As New Dictionary(Of String, String)
        addParameter.Add("txtMonthOf", "DATE : " & monCal.SelectionStart.ToString("MMMM dd, yyyy"))
        'addParameter.Add("branchName", branchName)
        'addParameter.Add("txtUsername", POSuser.UserName)

        frmReport.ReportInit(mysql, dsName, rptPath, addParameter)
        frmReport.Show()
    End Sub

    Private Sub monthaggreeassign()
        Dim dsName As String, rptPath As String
        Dim st As Date = GetFirstDate(monCal.SelectionStart)
        Dim en As Date = GetLastDate(monCal.SelectionEnd)
        dsName = "dsagreement"
        rptPath = "HRSystem.rpt_aggreement.rdlc"

        Dim mysql As String = "SELECT TBL_EMPLOYEE.FirstName ||' ' ||TBL_EMPLOYEE.Lastname as EmpName,COMPANYNAME,BranchName,BRANCHCODE AS CODE,TBLMANNING.ASSIGN_DATE AS DATEASSIGNED,REASON,TBLMANNING.SIGNSTATUS  ,Case TBLMANNING.SIGNSTATUS  When '1' Then 'YES' When '0' Then 'NO' End as STATUS FROM TBLMANNING INNER JOIN TBL_EMPLOYEE ON TBLMANNING.EMP_ID=TBL_EMPLOYEE.ID Inner Join tbl_Branch ON tbl_Branch.ID=TBLMANNING.BRANCH_ID "

        mysql &= "Where TBLMANNING.Assign_Date Between '" & st.ToShortDateString & "' AND '" & en.ToShortDateString & "' And tbl_Branch.CompanyName = '" & cboCompany.Text & "'"

        Dim addParameter As New Dictionary(Of String, String)
        addParameter.Add("txtMonthOf", "FOR THE MONTH OF " + st.ToString("MMMM yyyy"))    'addParameter.Add("branchName", branchName)
        'addParameter.Add("txtUsername", POSuser.UserName)

        frmReport.ReportInit(mysql, dsName, rptPath, addParameter)
        frmReport.Show()
    End Sub

    Private Sub relieveaggrement()
        Dim dsName As String, rptPath As String
        dsName = "dsRelieveAgree"

        rptPath = "HRSystem.rpt_agreementrelieved.rdlc"

        Dim mysql As String = "SELECT TBL_EMPLOYEE.FirstName ||' ' ||TBL_EMPLOYEE.Lastname as EmpName,(SELECT  TBL_EMPLOYEE.FirstName ||' ' ||TBL_EMPLOYEE.Lastname FROM TBL_RELIEVE INNER JOIN TBL_EMPLOYEE ON TBL_RELIEVE.W_EMPLOYEE_ID=TBL_EMPLOYEE.ID) AS WHONAME,Case SIGNINSTATUS When '1' Then 'YES' When '0' Then 'NO' End as STATUS ,REASON,tbl_Branch.BRANCHNAME,tbl_Branch.COMPANYNAME,tbl_Branch.BRANCHAREA AS AREA,tbl_Branch.BRANCHCODE AS CODE,TBL_RELIEVE.ASSIGN_DATE AS DATEASSIGNED FROM TBL_RELIEVE INNER JOIN TBL_EMPLOYEE ON TBL_RELIEVE.R_EMPLOYEE_ID=TBL_EMPLOYEE.ID Inner Join tbl_Branch ON tbl_Branch.ID=TBL_RELIEVE.BRANCH_ID "

        mysql &= "Where TBL_RELIEVE.ASSIGN_DATE = '" & monCal.SelectionStart.ToShortDateString & "' And tbl_Branch.CompanyName = '" & cboCompany.Text & "'"

        Dim addParameter As New Dictionary(Of String, String)
        addParameter.Add("txtMonthOf", "DATE : " & monCal.SelectionStart.ToString("MMMM dd, yyyy"))
        'addParameter.Add("branchName", branchName)
        'addParameter.Add("txtUsername", POSuser.UserName)

        frmReport.ReportInit(mysql, dsName, rptPath, addParameter)
        frmReport.Show()
    End Sub

    Private Sub appointment()
        Dim st As Date = GetFirstDate(monCal.SelectionStart)
        Dim en As Date = GetLastDate(monCal.SelectionEnd)
        Dim dsName As String, rptPath As String
        dsName = "dsAppointment"
        rptPath = "HRSystem.rpt_appointment.rdlc"

        Dim mysql As String = "select TBL_EMPLOYEE.FirstName ||' ' ||TBL_EMPLOYEE.Lastname as EmpName,schedule,TBL_APPOINT.REMARKS,Companyname, TBL_BRANCH.BRANCHAREA AS AREA,BranchName,BRANCHCODE AS CODE,TBL_APPOINT.CREATED_DATE AS DATEENCODED FROM TBL_APPOINT INNER JOIN TBL_EMPLOYEE ON TBL_APPOINT.EMP_ID=TBL_EMPLOYEE.ID Inner Join tbl_Branch ON tbl_Branch.ID=TBL_APPOINT.BRANCH_ID Where TBL_APPOINT.SCHEDULE= '" _
                              & monCal.SelectionStart.ToShortDateString _
                              & "' And tbl_Branch.CompanyName = '" _
                              & cboCompany.Text _
                              & "'"

        Dim addParameter As New Dictionary(Of String, String)
        addParameter.Add("txtMonthOf", "DATE : " & monCal.SelectionStart.ToString("MMMM dd, yyyy"))
        'addParameter.Add("branchName", branchName)
        'addParameter.Add("txtUsername", POSuser.UserName)

        frmReport.ReportInit(mysql, dsName, rptPath, addParameter)
        frmReport.Show()
    End Sub

    Private Sub appointmentmontly()
        Dim st As Date = GetFirstDate(monCal.SelectionStart)
        Dim en As Date = GetLastDate(monCal.SelectionEnd)
        Dim dsName As String, rptPath As String
        dsName = "dsAppointment"
        rptPath = "HRSystem.rpt_appointment.rdlc"

        Dim mysql As String = "select TBL_EMPLOYEE.FirstName ||' ' ||TBL_EMPLOYEE.Lastname as EmpName,schedule,TBL_APPOINT.REMARKS,Companyname, TBL_BRANCH.BRANCHAREA AS AREA,BranchName,BRANCHCODE AS CODE,TBL_APPOINT.CREATED_DATE AS DATEENCODED FROM TBL_APPOINT INNER JOIN TBL_EMPLOYEE ON TBL_APPOINT.EMP_ID=TBL_EMPLOYEE.ID Inner Join tbl_Branch ON tbl_Branch.ID=TBL_APPOINT.BRANCH_ID Where TBL_APPOINT.SCHEDULE Between '" & st.ToShortDateString & "' AND '" & en.ToShortDateString & "'And tbl_Branch.CompanyName = '" & cboCompany.Text & "'"

        Dim addParameter As New Dictionary(Of String, String)
        addParameter.Add("txtMonthOf", "FOR THE MONTH OF " + st.ToString("MMMM yyyy"))     'addParameter.Add("branchName", branchName)
        'addParameter.Add("txtUsername", POSuser.UserName)

        frmReport.ReportInit(mysql, dsName, rptPath, addParameter)
        frmReport.Show()
    End Sub

    Private Sub relieveaggrementmonthly()
        Dim st As Date = GetFirstDate(monCal.SelectionStart)
        Dim en As Date = GetLastDate(monCal.SelectionEnd)
        Dim dsName As String, rptPath As String
        dsName = "dsRelieveAgree"
        rptPath = "HRSystem.rpt_agreementrelieved.rdlc"

        Dim mysql As String = "SELECT TBL_EMPLOYEE.FirstName ||' ' ||TBL_EMPLOYEE.Lastname as EmpName,(SELECT  TBL_EMPLOYEE.FirstName ||' ' ||TBL_EMPLOYEE.Lastname FROM TBL_RELIEVE INNER JOIN TBL_EMPLOYEE ON TBL_RELIEVE.W_EMPLOYEE_ID=TBL_EMPLOYEE.ID) AS WHONAME,Case SIGNINSTATUS When '1' Then 'YES' When '0' Then 'NO' End as STATUS ,REASON,tbl_Branch.BRANCHNAME,tbl_Branch.COMPANYNAME,tbl_Branch.BRANCHAREA AS AREA,tbl_Branch.BRANCHCODE AS CODE,TBL_RELIEVE.ASSIGN_DATE AS DATEASSIGNED FROM TBL_RELIEVE INNER JOIN TBL_EMPLOYEE ON TBL_RELIEVE.R_EMPLOYEE_ID=TBL_EMPLOYEE.ID Inner Join tbl_Branch ON tbl_Branch.ID=TBL_RELIEVE.BRANCH_ID "

        mysql &= "Where TBL_RELIEVE.ASSIGN_DATE Between '" & st.ToShortDateString & "' AND '" & en.ToShortDateString & "'And tbl_Branch.CompanyName = '" & cboCompany.Text & "' "

        Dim addParameter As New Dictionary(Of String, String)
        addParameter.Add("txtMonthOf", "DATE : " & monCal.SelectionStart.ToString("MMMM dd, yyyy"))
        'addParameter.Add("branchName", branchName)
        'addParameter.Add("txtUsername", POSuser.UserName)

        frmReport.ReportInit(mysql, dsName, rptPath, addParameter)
        frmReport.Show()
    End Sub

    Private Sub rating()
        Dim st As Date = GetFirstDate(monCal.SelectionStart)
        Dim en As Date = GetLastDate(monCal.SelectionEnd)
        Dim dsName As String, rptPath As String
        dsName = "dsrating"
        rptPath = "HRSystem.rpt_Rating.rdlc"

        Dim mysql As String = "Select TBL_EMPLOYEE.FirstName ||' ' ||TBL_EMPLOYEE.Lastname as EMPLOYEE,Case RATE When '1' Then 'PASSED' When '0' Then 'FAILED' End as RATING ,tbl_Branch.BRANCHNAME,tbl_Branch.COMPANYNAME,tbl_Branch.BRANCHAREA AS AREA,tbl_Branch.BRANCHCODE AS CODE,DATERATING AS DATEENCODED from TBL_RATE INNER JOIN TBLMANNING ON TBL_RATE.MANNING_ID=TBLMANNING.ID INNER JOIN TBL_EMPLOYEE ON TBL_EMPLOYEE.ID=TBLMANNING.EMP_ID Inner Join tbl_Branch ON tbl_Branch.ID=TBLMANNING.BRANCH_ID Where TBL_RATE.DATERATING= '" & monCal.SelectionStart.ToShortDateString & "' And tbl_Branch.CompanyName = '" & cboCompany.Text & "'"

        Dim addParameter As New Dictionary(Of String, String)
        addParameter.Add("txtMonthOf", "DATE : " & monCal.SelectionStart.ToString("MMMM dd, yyyy"))
        'addParameter.Add("branchName", branchName)
        'addParameter.Add("txtUsername", POSuser.UserName)

        frmReport.ReportInit(mysql, dsName, rptPath, addParameter)
        frmReport.Show()
    End Sub

    Private Sub ratingmonthly()
        Dim st As Date = GetFirstDate(monCal.SelectionStart)
        Dim en As Date = GetLastDate(monCal.SelectionEnd)
        Dim dsName As String, rptPath As String
        dsName = "dsrating"
        rptPath = "HRSystem.rpt_Rating.rdlc"

        Dim mysql As String = "Select TBL_EMPLOYEE.FirstName ||' ' ||TBL_EMPLOYEE.Lastname as EMPLOYEE,Case RATE When '1' Then 'PASSED' When '0' Then 'FAILED' End as RATING ,tbl_Branch.BRANCHNAME,tbl_Branch.COMPANYNAME,tbl_Branch.BRANCHAREA AS AREA,tbl_Branch.BRANCHCODE AS CODE,DATERATING AS DATEENCODED from TBL_RATE INNER JOIN TBLMANNING ON TBL_RATE.MANNING_ID=TBLMANNING.ID INNER JOIN TBL_EMPLOYEE ON TBL_EMPLOYEE.ID=TBLMANNING.EMP_ID Inner Join tbl_Branch ON tbl_Branch.ID=TBLMANNING.BRANCH_ID Where TBL_RATE.DATERATING Between '" & st.ToShortDateString & "' AND '" & en.ToShortDateString & "'And tbl_Branch.CompanyName = '" & cboCompany.Text & "'"

        Dim addParameter As New Dictionary(Of String, String)
        addParameter.Add("txtMonthOf", "FOR THE MONTH OF " + st.ToString("MMMM yyyy"))    'addParameter.Add("branchName", branchName)
        'addParameter.Add("txtUsername", POSuser.UserName)

        frmReport.ReportInit(mysql, dsName, rptPath, addParameter)
        frmReport.Show()
    End Sub

    Private Sub ManPowerReportMonthly()
        Dim dsName As String, rptPath As String
        dsName = "dsManpower"
        rptPath = "HRSystem.rptManpower.rdlc"
        Dim st As Date = GetFirstDate(monCal.SelectionStart)
        Dim en As Date = GetLastDate(monCal.SelectionEnd)

        Dim mysql As String = "Select M.ID, E.FirstName ||' ' || E.Lastname as EmpName, M.Emp_Position as EmpPosition, "
        mysql &= "B.CompanyName, B.BranchName, M.Assign_Date, M.Remarks, "
        mysql &= "Case E.Status "
        mysql &= "When 'PRO' Then 'Probationary' "
        mysql &= "When 'REG' Then 'Regular' "
        mysql &= "When 'AWO' Then 'Awol' "
        mysql &= "When 'RES' Then 'Resigned' "
        mysql &= "When 'TER' Then 'Terminated' "
        mysql &= "When 'SUS' Then 'Suspended' "
        mysql &= "When 'APP' Then 'Appointed' "
        mysql &= "When 'END' Then 'End of Probationary' End as Status,"
        mysql &= "E.DateHired, B.Brancharea, B.BranchCode "
        mysql &= "From tblManning M "
        mysql &= "Inner Join tbl_Employee E ON E.ID = M.EMP_ID "
        mysql &= "Inner Join tbl_Branch B On B.ID = M.Branch_ID "
        mysql &= "Where M.Assign_Date Between '" & st.ToShortDateString & "' AND '" & en.ToShortDateString & "' And B.CompanyName = '" & cboCompany.Text & "' "
        ' mysql &= "And (M.Status <> 'PRO' OR M.Status <> 'REG' OR M.Status <> 'APP' OR M.Status <> 'SUS')"

        Dim addParameter As New Dictionary(Of String, String)
        addParameter.Add("txtMonthOf", "FOR THE MONTH OF " + st.ToString("MMMM yyyy"))
        'addParameter.Add("branchName", branchName)
        'addParameter.Add("txtUsername", POSuser.UserName)

        frmReport.ReportInit(mysql, dsName, rptPath, addParameter)
        frmReport.Show()
    End Sub

    Private Sub ManPowerActiveList()
        Dim dsName As String, rptPath As String
        dsName = "dsManpower"
        rptPath = "HRSystem.rptManpower.rdlc"
        Dim st As Date = GetFirstDate(monCal.SelectionStart)
        Dim en As Date = GetLastDate(monCal.SelectionEnd)

        Dim mysql As String = "Select M.ID, E.FirstName ||' ' || E.Lastname as EmpName, M.Emp_Position as EmpPosition, "
        mysql &= "B.CompanyName, B.BranchName, M.Assign_Date, M.Remarks, "
        mysql &= "Case E.Status "
        mysql &= "When 'PRO' Then 'Probationary' "
        mysql &= "When 'REG' Then 'Regular' "
        mysql &= "When 'AWO' Then 'Awol' "
        mysql &= "When 'RES' Then 'Resigned' "
        mysql &= "When 'TER' Then 'Terminated' "
        mysql &= "When 'SUS' Then 'Suspended' "
        mysql &= "When 'APP' Then 'Appointed' "
        mysql &= "When 'END' Then 'End of Probationary' End as Status,"
        mysql &= "E.DateHired, B.Brancharea, B.BranchCode "
        mysql &= "From tblManning M "
        mysql &= "Inner Join tbl_Employee E ON E.ID = M.EMP_ID "
        mysql &= "Inner Join tbl_Branch B On B.ID = M.Branch_ID "
        mysql &= "Where M.Assign_Date Between '" & st.ToShortDateString & "' AND '" & en.ToShortDateString & "' And B.CompanyName = '" & cboCompany.Text & "'"

        Dim addParameter As New Dictionary(Of String, String)
        addParameter.Add("txtMonthOf", "FOR THE MONTH OF " + st.ToString("MMMM yyyy"))
        'addParameter.Add("branchName", branchName)
        'addParameter.Add("txtUsername", POSuser.UserName)

        frmReport.ReportInit(mysql, dsName, rptPath, addParameter)
        frmReport.Show()
    End Sub

    Private Sub BhouseAllowanceMonthly()
        Dim dsName As String, rptPath As String
        dsName = "BhAllowanceMonthly_Dataset"
        rptPath = "HRSystem.rpt_BHAllowanceReport.rdlc"
        Dim st As Date = GetFirstDate(monCal.SelectionStart)
        Dim en As Date = GetLastDate(monCal.SelectionEnd)
        Dim mysql As String = "SELECT A.LASTNAME||', '||A.FIRSTNAME||' '||A.MIDDLENAME as FULLNAME, "
        mysql &= "B.EMP_POSITION, "
        mysql &= "CASE B.APPOINTED_STATUS "
        mysql &= "WHEN 1 "
        mysql &= "THEN (SELECT TBL_APPOINT.SCHEDULE FROM TBL_APPOINT WHERE TBL_APPOINT.EMP_ID = A.ID) "
        mysql &= "WHEN 0 "
        mysql &= "THEN '-' "
        mysql &= "End As DATEAPPOINTED, "
        mysql &= "Case B.RE_ASSIGN_STATUS "
        mysql &= "WHEN 1 "
        mysql &= "THEN DATEADD(MONTH, 3, B.DATE_CREATED) "
        mysql &= "End As STARTDATE, "
        mysql &= "D.BRANCHNAME, "
        mysql &= "E.CITYMUN, "
        mysql &= "C.ALLOWANCE, "
        mysql &= "C.PARTICULARS, "
        mysql &= "C.OTHER_ALLOWANCE, "
        mysql &= "F.AMOUNT "
        mysql &= "FROM "
        mysql &= "TBL_EMPLOYEE A "
        mysql &= "INNER Join  TBLMANNING B "
        mysql &= "On A.ID = B.EMP_ID "
        mysql &= "INNER Join TBL_BHOUSE_ALLOWANCE C "
        mysql &= "On B.ID = C.MANNING_ID "
        mysql &= "INNER Join TBL_BRANCH D "
        mysql &= "On B.BRANCH_ID = D.ID "
        mysql &= "INNER Join TBL_ADDRESS E "
        mysql &= "On A.PERMANENT_ADDID = E.ID "
        mysql &= "INNER JOIN TBL_CARE_KIT F "
        mysql &= "On C.CAREKIT_ID = F.ID "
        mysql &= "Where C.DATE_CREATED Between '" & st.ToShortDateString & "' AND '" & en.ToShortDateString & "' And D.CompanyName = '" & cboCompany.Text & "'"
        Dim addParameter As New Dictionary(Of String, String) From {
            {"paramMonth", st.ToString("MMMM yyyy")}
        }
        frmReport.ReportInit(mysql, dsName, rptPath, addParameter)
        frmReport.Show()
    End Sub

    Private Sub frmGenerate_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadCompany()
        If NoFilter() Then
            monCal.Enabled = False
        Else
            monCal.Enabled = True
        End If

    End Sub

    Private Function NoFilter() As Boolean
        Select Case FormType
            Case ReportType.ActiveList
                Return True
        End Select

        Return False
    End Function

    Private Sub LoadCompany()
        Dim mysql As String = "Select Distinct(CompanyName) From tbl_Branch"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Branch")

        cboCompany.Items.Clear()
        For Each dr In ds.Tables(0).Rows
            cboCompany.Items.Add(dr.item("CompanyName"))
        Next
    End Sub

End Class