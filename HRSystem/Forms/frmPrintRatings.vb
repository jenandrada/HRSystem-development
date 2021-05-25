Imports FirebirdSql.Data.FirebirdClient

Public Class frmPrintRatings

    Private Sub frmPrintRatings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsRating.RATINGS_ALL' table. You can move, or remove it, as needed.
        RATINGS_ALLTableAdapter.Fill(dsRating.RATINGS_ALL)
        'TODO: This line of code loads data into the 'dsRating.RATINGS_ALL' table. You can move, or remove it, as needed.
        'Me.ReportViewer1.RefreshReport()
        GenerateEmpList()
        LoadRatingsAll()
        ' Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub GenerateEmpList()
        conStr = "DRIVER=Firebird/InterBase(r) driver; User=" & fbUser & ";Password=" & fbPass & ";Database=" & dbName & ";"
        'con = New OdbcConnection(conStr)
        'Dim sql As String = "SELECT ID, FIRSTNAME|| ' '|| MIDDLENAME|| '. '|| LASTNAME AS FULLNAME FROM TBL_EMPLOYEE;"
        'Dim ds As DataSet = LoadSQL(sql, "TBL_EMPLOYEE")
        'EMP_NameCB.Items.Clear()

        'For Each dr In ds.Tables(0).Rows
        '    EMP_NameCB.Items.Add(dr)
        '    EMP_NameCB.DisplayMember = "FULLNAME"
        '    EMP_NameCB.ValueMember = "ID"
        'Next

        Dim sql As String = "SELECT ID, FIRSTNAME|| ' '|| MIDDLENAME|| '. '|| LASTNAME AS FULLNAME FROM TBL_EMPLOYEE ORDER BY FULLNAME ASC;"
        Dim da As FbDataAdapter
        Dim dt As New DataTable
        da = New FbDataAdapter(sql, con)
        da.Fill(dt)

        'EMP_NameCB.Items.Clear()
        EMP_NameCB.DataSource = dt
        EMP_NameCB.DisplayMember = "FULLNAME"
        EMP_NameCB.ValueMember = "ID"
    End Sub

    Private Sub LoadRatingsAll()
        EMP_NameCB.SelectedIndex = 0
        conStr = "DRIVER=Firebird/InterBase(r) driver; User=" & fbUser & ";Password=" & fbPass & ";Database=" & dbName & ";"
        con = New FbConnection(conStr)
        Dim sql As String = "SELECT TBL_RATE.ID, TBL_EMPLOYEE.FIRSTNAME||' '|| TBL_EMPLOYEE.MIDDLENAME||'. '||TBL_EMPLOYEE.LASTNAME AS EMPLOYEENAME, TBL_RATE.RATE, TBL_BRANCH.COMPANYNAME, TBL_BRANCH.BRANCHNAME, TBL_BRANCH.BRANCHCODE, TBL_BRANCH.BRANCHAREA, TBLMANNING.DATE_CREATED  FROM TBL_RATE  INNER JOIN TBLMANNING  ON TBL_RATE.MANNING_ID = TBLMANNING.ID INNER JOIN TBL_EMPLOYEE  ON TBLMANNING.EMP_ID = TBL_EMPLOYEE.ID INNER JOIN TBL_BRANCH  ON TBLMANNING.BRANCH_ID = TBL_BRANCH.ID ORDER BY EMPLOYEENAME ASC;"
        ReportViewer2.LocalReport.DataSources.Clear()
        Dim adapter As New FbDataAdapter(sql, con)
        Dim reports As New DsRatingDataSet.RATINGS_ALLDataTable()
        adapter.Fill(reports)
        ReportViewer2.LocalReport.ReportEmbeddedResource = "HRSystem.Ratings.rdlc"
        Dim datasource As New ReportDataSource With {
            .Name = "DataSet1",
            .Value = reports
        }

        ReportViewer2.LocalReport.DataSources.Add(datasource)
        ReportViewer2.RefreshReport()
    End Sub

    Sub LoadRatingsByName()
        conStr = "DRIVER=Firebird/InterBase(r) driver; User=" & fbUser & ";Password=" & fbPass & ";Database=" & dbName & ";"
        con = New FbConnection(conStr)
        Dim sql As String = "SELECT TBL_RATE.ID, TBL_EMPLOYEE.FIRSTNAME||' '|| TBL_EMPLOYEE.MIDDLENAME||'. '||TBL_EMPLOYEE.LASTNAME AS EMPLOYEENAME, TBL_RATE.RATE, TBL_BRANCH.COMPANYNAME, TBL_BRANCH.BRANCHNAME, TBL_BRANCH.BRANCHCODE, TBL_BRANCH.BRANCHAREA, TBLMANNING.DATE_CREATED  FROM TBL_RATE  INNER JOIN TBLMANNING  ON TBL_RATE.MANNING_ID = TBLMANNING.ID INNER JOIN TBL_EMPLOYEE  ON TBLMANNING.EMP_ID = TBL_EMPLOYEE.ID INNER JOIN TBL_BRANCH  ON TBLMANNING.BRANCH_ID = TBL_BRANCH.ID WHERE TBL_EMPLOYEE.ID = '" & EMP_NameCB.SelectedValue.ToString & "' ORDER BY EMPLOYEENAME ASC;"
        ReportViewer2.LocalReport.DataSources.Clear()
        Dim adapter As New FbDataAdapter(sql, con)
        Dim reports As New DsRatingDataSet.RATINGS_ALLDataTable()
        adapter.Fill(reports)
        ReportViewer2.LocalReport.ReportEmbeddedResource = "HRSystem.Ratings.rdlc"
        Dim datasource As New ReportDataSource With {
            .Name = "DataSet1",
            .Value = reports
        }

        ReportViewer2.LocalReport.DataSources.Add(datasource)
        ReportViewer2.RefreshReport()
    End Sub

    Private Sub EMP_NameCB_DropDown(sender As Object, e As EventArgs) Handles EMP_NameCB.DropDown

    End Sub

    Private Sub EMP_NameCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EMP_NameCB.SelectedIndexChanged
        LoadRatingsByName()
    End Sub

    Private Sub EMP_NameCB_SelectedValueChanged(sender As Object, e As EventArgs) Handles EMP_NameCB.SelectedValueChanged

    End Sub

End Class