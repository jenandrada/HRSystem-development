Imports System.Configuration
Imports System.Data.Odbc

Imports FirebirdSql.Data.FirebirdClient

Public Class ManPowerRV
    Dim dateHiredMonth As String
    Dim dateHiredYear As String
    Dim paramDateMoth As String
    Dim UserName As String = frmMainForm.UserName_LBL.Text

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateHiredDtp.Checked = False
        dateHiredMonth = Nothing
        RefreshRPT()
    End Sub

    Private Sub RefreshRPT()
        Dim sql As String = "select "
        sql &= "B.ID, "
        sql &= "A.ID AS EMPID, "
        sql &= "A.LASTNAME||', '||A.FIRSTNAME||' '||A.MIDDLENAME||' '||A.SUFFIX AS FullName, "
        sql &= "B.EMP_POSITION, "
        sql &= "C.BRANCHNAME AS Branch, "
        sql &= "C.BRANCHAREA AS Area, "
        sql &= "C.COMPANYNAME AS Company, "
        sql &= "A.DATEHIRED AS DateHired, "
        sql &= "Case A.Status "
        sql &= "When 'PRO' Then 'Probationary' "
        sql &= "When 'REG' Then 'Regular' "
        sql &= "When 'AWO' Then 'Awol' "
        sql &= "When 'RES' Then 'Resigned' "
        sql &= "When 'TER' Then 'Terminated' "
        sql &= "When 'SUS' Then 'Suspended' "
        sql &= "When 'APP' Then 'Appointed' "
        sql &= "When 'END' Then 'End of Probationary' End as Status, "
        sql &= "B.REMARKS, "
        sql &= "B.VOID, "
        sql &= "CASE A.BIRATE WHEN 1 THEN 'PASSED' WHEN 0 THEN 'FAILED' END AS BIRATE, "
        sql &= "A.BI_REMARKS AS BIRemarks, "
        sql &= "CASE B.WORK_STATUS WHEN 1 THEN 'ACTIVE' WHEN 0 THEN 'INACTIVE' END AS WORKSTATUS "
        sql &= "from tbl_employee A "
        sql &= "inner join tblmanning B "
        sql &= "on A.ID = B.emp_ID "
        sql &= "inner join TBL_BRANCH C "
        sql &= "on B.BRANCH_ID = C.ID "
        If Not String.IsNullOrEmpty(dateHiredMonth) Then
            sql &= $"where EXTRACT(YEAR FROM A.DATEHIRED) LIKE '%{dateHiredYear}%' AND "
            sql &= $"EXTRACT(MONTH FROM A.DATEHIRED) = '{dateHiredMonth}' AND "
        Else
            sql &= $"where EXTRACT(YEAR FROM A.DATEHIRED) LIKE '%{dateHiredYear}%' AND "
        End If
        If EMP_Name_TXT.TextLength <> 0 Then
            sql &= $"A.LASTNAME LIKE '%{EMP_Name_TXT.Text.ToUpperInvariant}%' OR "
            sql &= $"A.FIRSTNAME LIKE '%{EMP_Name_TXT.Text.ToUpperInvariant}%' OR "
            sql &= $"A.MIDDLENAME LIKE '%{EMP_Name_TXT.Text.ToUpperInvariant}%' AND "
        End If
        sql &= $"C.BRANCHNAME LIKE '%{Branch_TXT.Text.ToUpperInvariant}%' AND "
        sql &= $"C.BRANCHAREA LIKE '%{Area_TXT.Text.ToUpperInvariant}%' AND "
        sql &= $"C.COMPANYNAME LIKE '%{Company_TXT.Text.ToUpperInvariant}%' AND B.VOID = 0 AND A.ASSIGN_STATUS = 1 ORDER BY A.DATEHIRED DESC"
        conStr = ConfigurationManager.ConnectionStrings("FbConString").ConnectionString.ToString
        Dim con1 As FbConnection = New FbConnection(conStr)
        ReportViewer1.LocalReport.DataSources.Clear()
        Using dt As New FbDataAdapter(sql, con1)
            Dim reports As New ManPowerV1DataSet.ManPwrDTDataTable
            dt.Fill(reports)
            'Console.WriteLine(reports.Columns.Item(8).DefaultValue.ToString)
            Dim datasource As New ReportDataSource With {
                        .Name = "ManPowerDS",
                        .Value = reports
                    }
            Dim paramList As New List(Of ReportParameter) From {
            New ReportParameter("paramMothYear", paramDateMoth),
            New ReportParameter("paramPreparedBy", UserName),
            New ReportParameter("paramCompany", Company_TXT.Text)
            }
            ReportViewer1.LocalReport.DataSources.Add(datasource)
            ReportViewer1.LocalReport.SetParameters(paramList)
            AddHandler ReportViewer1.LocalReport.SubreportProcessing, AddressOf BHAllowanceSubReportProcessingEventHandler
            ReportViewer1.RefreshReport()
        End Using

    End Sub

    Private Sub BHAllowanceSubReportProcessingEventHandler(sender As Object, e As SubreportProcessingEventArgs)
        Dim constr As String = ConfigurationManager.ConnectionStrings("HRSystem.My.MySettings.SubReportUsingFireBird").ConnectionString.ToString
        Dim con As OdbcConnection = New OdbcConnection(constr)
        Dim sql As String = $"select * from TBL_BHOUSE_ALLOWANCE where MANNING_ID = '{e.Parameters(0).Values(0)}'"
        Dim adapter As New OdbcDataAdapter(sql, con)
        Dim report As New ManPowerV1DataSet.BHAllowanceDataTable()
        adapter.Fill(report)
        Dim datasource As New ReportDataSource With {
        .Name = "BHAllowanceDS",
        .Value = report
        }
        e.DataSources.Add(datasource)
    End Sub

    Private Sub DateHiredDtp_ValueChanged(sender As Object, e As EventArgs) Handles DateHiredDtp.ValueChanged
        If DateHiredDtp.Checked = False Then
            dateHiredMonth = Nothing
            dateHiredYear = Nothing
            paramDateMoth = Now.ToString("MMMM (yyyy)").ToUpperInvariant
            RefreshRPT()
        Else
            dateHiredMonth = DateHiredDtp.Value.Month.ToString
            dateHiredYear = DateHiredDtp.Value.Year.ToString
            paramDateMoth = DateHiredDtp.Value.ToString("MMMM (yyyy)").ToUpperInvariant
            RefreshRPT()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RefreshRPT()
    End Sub

    Private Sub ReportViewer1_Drillthrough(sender As Object, e As DrillthroughEventArgs) Handles ReportViewer1.Drillthrough
        Dim val = 0
        Dim report As LocalReport = CType(e.Report, LocalReport)
        Dim list As IList(Of ReportParameter) = report.OriginalParametersToDrillthrough
        For Each param As ReportParameter In list
            val = Convert.ToInt32(param.Values(0).ToString)
        Next
        Dim ds As dsappointmentDataSet = New dsappointmentDataSet
        ds.EnforceConstraints = False

        conStr = ConfigurationManager.ConnectionStrings("FbConString").ConnectionString.ToString
        Dim con1 As FbConnection = New FbConnection(conStr)
        Dim mysql As String = $"select TBL_EMPLOYEE.FirstName ||' ' ||TBL_EMPLOYEE.Lastname as EmpName,schedule,TBL_APPOINT.REMARKS,Companyname, TBL_BRANCH.BRANCHAREA AS AREA,BranchName,BRANCHCODE AS CODE,TBL_APPOINT.CREATED_DATE AS DATEENCODED FROM TBL_APPOINT INNER JOIN TBL_EMPLOYEE ON TBL_APPOINT.EMP_ID=TBL_EMPLOYEE.ID Inner Join tbl_Branch ON tbl_Branch.ID=TBL_APPOINT.BRANCH_ID WHERE TBL_EMPLOYEE.ID = {val}"
        Using dtx As New FbDataAdapter(mysql, con)
            Dim rpt As New dsappointmentDataSet.AppointmentDataTable()
            dtx.Fill(rpt)
            Dim datasource As New ReportDataSource With {
            .Name = "dsAppointment",
            .Value = rpt
            }
            report.DataSources.Add(datasource)
        End Using
    End Sub

End Class