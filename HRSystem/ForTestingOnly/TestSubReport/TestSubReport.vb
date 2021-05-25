Imports System.Configuration
Imports System.Data.Odbc

Public Class TestSubReport

    Private Sub TestSubReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestSubReportDataset.Employee' table. You can move, or remove it, as needed.
        AddHandler ReportViewer1.LocalReport.SubreportProcessing, AddressOf ManPowerSubReportProcessingEventHandler
        AddHandler ReportViewer1.LocalReport.SubreportProcessing, AddressOf BranchesSubReportProcessingEventHandler

        LoadEmployees()

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub LoadEmployees()

        Dim constr As String = ConfigurationManager.ConnectionStrings("HRSystem.My.MySettings.TestForSubReportUsingFireBird").ConnectionString.ToString
        Dim con As OdbcConnection = New OdbcConnection(constr)
        Dim sql As String = "Select ID, LASTNAME||', '||FIRSTNAME||' '||MIDDLENAME||' '||SUFFIX AS FULLNAME, GENDER, CIVILSTATUS FROM TBL_EMPLOYEE WHERE FIRSTNAME = 'GLENN'"
        ReportViewer1.LocalReport.DataSources.Clear()
        Using adapter As New OdbcDataAdapter(sql, con)
            Dim reports As New TestSubReportDataset.EmployeeDataTable
            adapter.Fill(reports)
            ReportViewer1.LocalReport.ReportEmbeddedResource = "HRSystem.Employee.rdlc"
            Dim datasource As New ReportDataSource With {
                .Name = "EmployeeDS",
                .Value = reports
            }
            ReportViewer1.LocalReport.DataSources.Add(datasource)
            Me.ReportViewer1.RefreshReport()
        End Using
    End Sub

    Private Sub ManPowerSubReportProcessingEventHandler(ByVal sender As Object, ByVal e As SubreportProcessingEventArgs)

        Dim constr As String = ConfigurationManager.ConnectionStrings("HRSystem.My.MySettings.TestForSubReportUsingFireBird").ConnectionString.ToString
        Dim con As OdbcConnection = New OdbcConnection(constr)
        Dim sql As String = $"select * from tblmanning where EMP_ID = '{e.Parameters(0).Values(0)}'"
        Using adapter As New OdbcDataAdapter(sql, con)
            Using report As New TestSubReportDataset.ManPowerDataTable()
                adapter.Fill(report)
                Dim datasource As New ReportDataSource With
                {
                   .Name = "ManPowerDS",
                   .Value = report
                }
                e.DataSources.Add(datasource)
            End Using
        End Using
        Console.WriteLine("sub1: " & e.ReportPath)
    End Sub

    Private Sub BranchesSubReportProcessingEventHandler(ByVal sender As Object, ByVal e As SubreportProcessingEventArgs)
        Dim constr As String = ConfigurationManager.ConnectionStrings("HRSystem.My.MySettings.TestForSubReportUsingFireBird").ConnectionString.ToString
        Dim con As OdbcConnection = New OdbcConnection(constr)
        Dim sqlx As String = $"select * from tbl_branch where ID = '{e.Parameters(0).Values(0)}'"
        Using adapter As New OdbcDataAdapter(sqlx, con)
            Using report As New TestSubReportDataset.BranchDataTable()
                adapter.Fill(report)
                Dim datasource As New ReportDataSource With
                {
                    .Name = "BranchDataSet",
                    .Value = report
                }
                e.DataSources.Add(datasource)
            End Using
        End Using

        Console.WriteLine("sub2: " & e.ReportPath & " " & e.Parameters(0).Values(0))
    End Sub

End Class