Public Class frmrelieverreport

    Enum ReportType As Integer

        reliever = 0
        monthlyreliev = 1

    End Enum

    Friend FormType As ReportType = ReportType.reliever

    Private Sub frmrelieverreport_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadCompany()
    End Sub

    Private Sub LoadCompany()
        Dim mysql As String = "Select Distinct(CompanyName) From tbl_Branch"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Branch")

        cboCompany.Items.Clear()
        For Each dr In ds.Tables(0).Rows
            cboCompany.Items.Add(dr.item("CompanyName"))
        Next
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGenerate.Click
        If cboCompany.SelectedIndex = -1 Then Exit Sub
        Select Case FormType
            Case ReportType.reliever
                RelieverReport()
            Case ReportType.monthlyreliev
                monthlyrelievReport()

        End Select

    End Sub

    Private Sub monthlyrelievReport()
        Dim dsName As String, rptPath As String
        dsName = "dsReliever"
        rptPath = "HRSystem.rptReliever.rdlc"

        Dim mysql As String = "SELECT TBL_RELIEVE.RELIEVE_ID,TBL_EMPLOYEE.firstname||' ' ||TBL_EMPLOYEE.lastname AS Reliver_Name ,(SELECT TBL_EMPLOYEE.LASTNAME||' ' ||TBL_EMPLOYEE.FIRSTNAME ||' ' ||TBL_EMPLOYEE.FIRSTNAME FROM TBL_EMPLOYEE WHERE TBL_EMPLOYEE.ID=TBL_RELIEVE.W_EMPLOYEE_ID ) AS WHO_NAME,"
        mysql &= "COMPANYNAME,BRANCHNAME,BRANCHCODE,BRANCHAREA,R_POSITION,ASSIGN_DATE,NUMBER_OF_DAYS_ASSIGNED as NumOfDays"
        mysql &= " FROM TBL_EMPLOYEE INNER JOIN TBL_RELIEVE ON TBL_EMPLOYEE.ID=TBL_RELIEVE.R_EMPLOYEE_ID INNER JOIN TBL_BRANCH ON TBL_BRANCH.ID=TBL_RELIEVE.BRANCH_ID "

        mysql &= "Where TBL_RELIEVE.Assign_Date = '" & monCal.SelectionStart.ToShortDateString & "' "

        Dim addParameter As New Dictionary(Of String, String)
        ' addParameter.Add("txtMonthOf", "DATE : " & monCal.SelectionStart.ToString("MMMM dd, yyyy"))
        addParameter.Add("txtMonthOf", "FOR THE MONTH OF " + monCal.SelectionStart.ToString("MMMM yyyy"))

        'addParameter.Add("branchName", branchName)
        'addParameter.Add("txtUsername", POSuser.UserName)

        frmReport.ReportInit(mysql, dsName, rptPath, addParameter)

        frmReport.Show()
    End Sub

    Private Sub RelieverReport()
        Dim dsName As String, rptPath As String
        dsName = "dsReliever"
        rptPath = "HRSystem.rptReliever.rdlc"

        Dim mysql As String = "SELECT TBL_RELIEVE.RELIEVE_ID,TBL_EMPLOYEE.firstname||' ' ||TBL_EMPLOYEE.lastname AS Reliver_Name ,(SELECT TBL_EMPLOYEE.LASTNAME||' ' ||TBL_EMPLOYEE.FIRSTNAME ||' ' ||TBL_EMPLOYEE.FIRSTNAME FROM TBL_EMPLOYEE WHERE TBL_EMPLOYEE.ID=TBL_RELIEVE.W_EMPLOYEE_ID ) AS WHO_NAME,"
        mysql &= "COMPANYNAME,BRANCHNAME,BRANCHCODE,BRANCHAREA,R_POSITION,ASSIGN_DATE,NUMBER_OF_DAYS_ASSIGNED as NumOfDays"
        mysql &= " FROM TBL_EMPLOYEE INNER JOIN TBL_RELIEVE ON TBL_EMPLOYEE.ID=TBL_RELIEVE.R_EMPLOYEE_ID INNER JOIN TBL_BRANCH ON TBL_BRANCH.ID=TBL_RELIEVE.BRANCH_ID "

        mysql &= "Where TBL_RELIEVE.Assign_Date = '" & monCal.SelectionStart.ToShortDateString & "' "

        Dim addParameter As New Dictionary(Of String, String)
        addParameter.Add("txtMonthOf", "DATE : " & monCal.SelectionStart.ToString("MMMM dd, yyyy"))

        'addParameter.Add("branchName", branchName)
        'addParameter.Add("txtUsername", POSuser.UserName)

        frmReport.ReportInit(mysql, dsName, rptPath, addParameter)

        frmReport.Show()
    End Sub

End Class