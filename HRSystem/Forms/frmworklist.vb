Imports System.Configuration

Imports CustomPrinting.PrintWorkList

Imports FirebirdSql.Data.FirebirdClient

Public Class frmworklist
    Dim temp As ManPower
    'Dim fromOtherForm As Boolean = False
    'Dim frmOrig As FormName
    'Dim isPage1 As Integer
    Dim rowCount As New Integer
    Dim rowCountRelieve As New Integer

    Private Sub frmworklist_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadEmployee()
        ListViewGrouping(lvEmployee, 3)
    End Sub

    'Friend Sub SearchSelect(ByVal src As String, ByVal frmOrigin As FormName, Optional i As Integer = 0)
    '    fromOtherForm = True
    '    btnSelect.Visible = True
    '    'txtSearch.Text = src
    '    frmOrig = frmOrigin
    '    isPage1 = i
    'End Sub

    'Friend Sub SearchSelectCorrective(ByVal src As String, ByVal frmOrigin As FormName, Optional _isPage1 As Integer = 0)
    '    fromOtherForm = True
    '    btnSelect.Visible = True
    '    txtSearch.Text = src
    '    frmOrig = frmOrigin
    '    isPage1 = _isPage1
    'End Sub

    Private Sub Loadreliever(Optional ByVal str As String = "")
        Dim secured_str As String = str
        secured_str = DreadKnight(secured_str)
        Dim strWords As String() = secured_str.Split(New Char() {" "c})
        Dim name As String

        Dim mysql As String
        If str.Length <> 0 Then
            mysql = "SELECT * FROM TBL_RELIEVE INNER JOIN TBL_EMPLOYEE ON TBL_RELIEVE.R_EMPLOYEE_ID=TBL_EMPLOYEE.id  INNER JOIN TBL_BRANCH ON TBL_RELIEVE.BRANCH_ID =TBL_BRANCH.ID Where TBL_RELIEVE.STATUS='1' AND TBL_RELIEVE.VOID = 0 AND "
            For Each name In strWords
                'mysql &= $"{vbCr} UPPER(LastName ||' '|| FirstName ||' '|| MiddleName) LIKE UPPER('%{name}%') and "
                'mysql &= $"{vbCr}UPPER(FirstName ||' '|| MiddleName ||' '|| LastName) LIKE UPPER('%{name}%') and "
                If name Is strWords.Last Then
                    mysql &= $"{vbCr} UPPER(FirstName ||' '|| LastName ||' '|| MiddleName) LIKE UPPER('%{name}%') "
                    Exit For
                End If
            Next
        Else
            mysql = "SELECT * FROM TBL_RELIEVE INNER JOIN TBL_EMPLOYEE ON TBL_RELIEVE.R_EMPLOYEE_ID=TBL_EMPLOYEE.id  INNER JOIN TBL_BRANCH ON TBL_RELIEVE.BRANCH_ID =TBL_BRANCH.ID  Where  TBL_RELIEVE.STATUS='1' AND TBL_RELIEVE.VOID = 0 ORDER BY CREATED_DATE DESC"

        End If
        Dim ds As DataSet = LoadSQL(mysql, "TBL_RELIEVE")
        rowCountRelieve = ds.Tables(0).Rows.Count
        Dim maxEntries As Integer = ds.Tables(0).Rows.Count
        frmMainForm.AppProgressBar.Maximum = maxEntries
        frmMainForm.AppProgressBar.Visible = True
        lvEmployee.Items.Clear()
        For Each dr In ds.Tables(0).Rows
            relieveadditem(dr)
            frmMainForm.AppProgressBar.Value += 1
        Next
        Output_Lbl.Text = "Record(s) 1" & " of " & rowCountRelieve
        frmMainForm.AppProgressBar.Value = 0
        frmMainForm.AppProgressBar.Visible = False
    End Sub

    Private Sub LoadEmployee(Optional ByVal str As String = "")
        Dim secured_str As String = str
        secured_str = DreadKnight(secured_str)
        Dim strWords As String() = secured_str.Split(New Char() {" "c})
        Dim name As String

        Dim mysql As String
        If str.Length <> 0 Then
            mysql = "SELECT * from TBL_EMPLOYEE 
                            INNER JOIN TBL_BRANCH ON TBLMANNING.BRANCH_ID =TBL_BRANCH.ID  
                                         Where WORK_STATUS = '1' and VOID <> 1 and "

            'INNER JOIN TBLMANNING ON TBL_EMPLOYEE.ID = TBLMANNING.EMP_ID 

            For Each name In strWords
                mysql &= $"{vbCr} UPPER(LastName ||' '|| FirstName ||' '|| MiddleName) LIKE UPPER('%{name}%') or "
                mysql &= $"{vbCr}UPPER(FirstName ||' '|| MiddleName ||' '|| LastName) LIKE UPPER('%{name}%') or "
                If name Is strWords.Last Then
                    mysql &= $"{vbCr} UPPER(FirstName ||' '|| LastName ||' '|| MiddleName) LIKE UPPER('%{name}%') "
                    Exit For
                End If
            Next
        Else
            mysql = "SELECT * from TBL_EMPLOYEE INNER JOIN TBL_BRANCH ON TBLMANNING.BRANCH_ID =TBL_BRANCH.ID WHERE TBLMANNING.WORK_STATUS = 1 AND TBLMANNING.VOID <> '1' ORDER BY TBLMANNING.Emp_ID DESC"
        End If

        'Dim mysql As String
        'If str.Length <> 0 Then
        '    mysql = "SELECT * from TBL_EMPLOYEE 
        '                        INNER JOIN TBLMANNING ON TBL_EMPLOYEE.ID = TBLMANNING.EMP_ID 
        '                        INNER JOIN TBL_BRANCH ON TBLMANNING.BRANCH_ID = TBL_BRANCH.ID  
        '                            Where  TBLMANNING.WORK_STATUS = '1' AND TBLMANNING.VOID <> 1
        '                                    AND  Upper(FIRSTNAME) = Upper('" & str & "') or Upper(LASTNAME) = Upper('" & str & "')  "
        'For Each name In strWords
        '    mysql &= $"{vbCr} UPPER(LastName ||' '|| FirstName ||' '|| MiddleName) LIKE UPPER('%{name}%') and "
        '    mysql &= $"{vbCr}UPPER(FirstName ||' '|| MiddleName ||' '|| LastName) LIKE UPPER('%{name}%') and "
        '    If name Is strWords.Last Then
        '        mysql &= $"{vbCr} UPPER(FirstName ||' '|| LastName ||' '|| MiddleName) LIKE UPPER('%{name}%') "
        '        Exit For
        '    End If
        'Next

        'Else
        '    mysql = "SELECT * from TBL_EMPLOYEE INNER JOIN TBLMANNING ON TBL_EMPLOYEE.ID=TBLMANNING.EMP_ID  INNER JOIN TBL_BRANCH ON TBLMANNING.BRANCH_ID =TBL_BRANCH.ID WHERE WORK_STATUS='1' AND TBLMANNING.VOID <> 1 ORDER BY TBLMANNING.Emp_ID DESC"
        'End If

        Dim ds As DataSet = LoadSQL(mysql, "tbl_Employee")
        Dim maxEntries As New Integer

        rowCount = ds.Tables(0).Rows.Count
        maxEntries = ds.Tables(0).Rows.Count
        frmMainForm.AppProgressBar.Maximum = maxEntries
        frmMainForm.AppProgressBar.Visible = True
        lvEmployee.Items.Clear()

        For Each dr In ds.Tables(0).Rows
            AddItem(dr)
            frmMainForm.AppProgressBar.Value += 1
        Next

        Output_Lbl.Text = "Record(s) 1" & " of " & rowCount

        frmMainForm.AppProgressBar.Value = 0
        frmMainForm.AppProgressBar.Visible = False

    End Sub

    Private Sub AddItem(ByVal dr As DataRow)
        With dr
            Dim lv As ListViewItem = lvEmployee.Items.Add(.Item("ID1"))
            lv.SubItems.Add($"{ .Item("LastName") }, { .Item("FirstName") } { .Item("MiddleName") }")
            lv.SubItems.Add("_")

            If IsDBNull(.Item("APPOINTED_STATUS")) Then
                lv.SubItems.Add("ASSIGNED")

            ElseIf .Item("APPOINTED_STATUS") = 0 Then
                lv.SubItems.Add("ASSIGNED")

            Else
                lv.SubItems.Add("APPOINTED")
            End If

            lv.SubItems.Add(.Item("EMP_POSITION"))
            lv.SubItems.Add(.Item("COMPANYNAME"))
            lv.SubItems.Add(.Item("BRANCHNAME"))
            lv.SubItems.Add(.Item("BRANCHCODE"))
            lv.SubItems.Add(.Item("BRANCHAREA"))
            'lv.SubItems.Add(.Item("ASSIGN_DATE"))
            lv.ImageKey = "imgMale"

            If .Item("Gender") = "Female" Then
                lv.ImageKey = "imgFemale"
            End If
        End With
    End Sub

    Private Sub relieveadditem(ByVal dr As DataRow)
        With dr
            Dim lv As ListViewItem = lvEmployee.Items.Add(.Item("RELIEVE_ID"))
            lv.SubItems.Add($"{ .Item("LastName") }, { .Item("FirstName") } { .Item("MiddleName") }")

            Dim mysql As String = "Select * From tbl_employee Where ID = '" & .Item("W_EMPLOYEE_ID") & "'"
            Dim ds As DataSet = LoadSQL(mysql, "tbl_employee")

            For Each dr In ds.Tables(0).Rows
                lv.SubItems.Add(dr.Item("LASTNAME") & "," & dr.Item("FIRSTNAME") & " " & dr.Item("MIDDLENAME"))
            Next
            lv.SubItems.Add("RELIEVE")

            lv.SubItems.Add(.Item("R_POSITION"))
            lv.SubItems.Add(.Item("COMPANYNAME"))
            lv.SubItems.Add(.Item("BRANCHNAME"))
            lv.SubItems.Add(.Item("BRANCHCODE"))
            lv.SubItems.Add(.Item("BRANCHAREA"))
            lv.SubItems.Add(.Item("ASSIGN_DATE"))
            lv.ImageKey = "imgMale"
            If .Item("Gender") = "Female" Then
                lv.ImageKey = "imgFemale"
            End If
        End With
    End Sub

    Private Sub chkassigned_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkassigned.CheckedChanged
        If chkassigned.Checked = True Then
            LoadEmployee()
            lblmode.Text = "SEARCH ASSIGNED"
            ListViewGrouping(lvEmployee, 3)
        Else
            Loadreliever()
            lblmode.Text = " SEARCH RELIEVE"
            ListViewGrouping(lvEmployee, 6)
        End If

    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        If chkassigned.Checked = True Then
            LoadEmployee(txtSearch.Text)
        Else
            Loadreliever(txtSearch.Text)
        End If

    End Sub

    Private Sub BtnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub BtnSelect_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSelect.Click

        Dim idx As Integer = lvEmployee.FocusedItem.Text
        Dim tmpEmp As ManPower
        tmpEmp = New ManPower
        tmpEmp.LOADMANNIG(idx)

        If lvEmployee.Items.Count = 0 Then Exit Sub

        If txtSearch.Tag = "Corrective1" Then

            ReloadFormManPower(FormName.Coorective, tmpEmp, 0)

        ElseIf txtSearch.Tag = "Corrective2" Then

            ReloadFormManPower(FormName.Coorective, tmpEmp, 1)

        ElseIf txtSearch.Tag = "Leave" Then

            ReloadFormManPower(FormName.monitoring, tmpEmp, 2)

        ElseIf txtSearch.Tag = "FormManagement1" Then

            ReloadFormManPower(FormName.Manpower, tmpEmp, 1)

        ElseIf txtSearch.Tag = "Letter3" Then

            ReloadFormManPower(FormName.letter, tmpEmp, 3)

        End If

        Close()
    End Sub

    Friend Sub SetLabelOpen(ByVal open As String, ByVal relieve As Boolean)
        txtSearch.Tag = open
        Console.WriteLine("TAG=======" & open)
        Relieve_RBTN.Enabled = relieve
    End Sub

    Private Sub Prnt(str As String, type As String)
        If type = "Assigned" Then
            Using rv_Assigned As New ReportViewer
                conStr = ConfigurationManager.ConnectionStrings("FbConString").ConnectionString.ToString
                con = New FbConnection(conStr)
                Dim sql As String = $"SELECT * FROM PRINT_WORKLIST WHERE FULLNAME LIKE '%{str.ToUpperInvariant}%'"
                rv_Assigned.LocalReport.DataSources.Clear()
                Using adapter As New FbDataAdapter(sql, con)
                    Dim reports As New WorkListDataSet.WorkList_TBLDataTable()
                    adapter.Fill(reports)
                    frmMainForm.AppProgressBar.Maximum = reports.Rows.Count
                    frmMainForm.AppProgressBar.Visible = True
                    For Each item In reports.Rows
                        frmMainForm.AppProgressBar.Value += 1
                    Next
                    rv_Assigned.LocalReport.ReportEmbeddedResource = "HRSystem.rpt_PrintWorkList.rdlc"
                    Dim datasource As New ReportDataSource With {
                        .Name = "workList",
                        .Value = reports
                    }
                    Dim param As ReportParameter = New ReportParameter("TYPE", type)
                    rv_Assigned.LocalReport.DataSources.Add(datasource)
                    rv_Assigned.LocalReport.SetParameters(param)
                End Using
                PrintToPrinter(rv_Assigned.LocalReport)
            End Using
            frmMainForm.AppProgressBar.Value = 0
            frmMainForm.AppProgressBar.Visible = False
        Else
            Using rv_Relieved As New ReportViewer
                conStr = ConfigurationManager.ConnectionStrings("FbConString").ConnectionString.ToString
                con = New FbConnection(conStr)
                Dim sql As String = $"SELECT * FROM PRINT_WORKLIST_RELIEVED WHERE FULLNAME LIKE '%{str.ToUpperInvariant}%';"
                rv_Relieved.LocalReport.DataSources.Clear()
                Using adapter As New FbDataAdapter(sql, con)
                    Dim reports As New WorkListDataSet.WorkList_Relieved_TBLDataTable()
                    adapter.Fill(reports)

                    frmMainForm.AppProgressBar.Maximum = reports.Rows.Count
                    frmMainForm.AppProgressBar.Visible = True
                    For Each item In reports.Rows
                        frmMainForm.AppProgressBar.Value += 1
                    Next
                    rv_Relieved.LocalReport.ReportEmbeddedResource = "HRSystem.rpt_PrintWorklist_Relieved.rdlc"
                    Dim datasource As New ReportDataSource With {
                    .Name = "workList_Relieved",
                    .Value = reports
                }

                    Dim param As ReportParameter = New ReportParameter("TYPE", type)
                    rv_Relieved.LocalReport.DataSources.Add(datasource)
                    rv_Relieved.LocalReport.SetParameters(param)
                End Using
                PrintToPrinter(rv_Relieved.LocalReport)
            End Using
            frmMainForm.AppProgressBar.Value = 0
            frmMainForm.AppProgressBar.Visible = False
        End If

    End Sub

    Private Sub Print_BTN_Click(sender As Object, e As EventArgs) Handles Print_BTN.Click
        If MsgBox("Are you Done?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Saving...") = MsgBoxResult.Yes Then
            Prnt(txtSearch.Text, IIf(chkassigned.Checked = True, "Assigned", "Relieved"))
        End If
        Exit Sub
    End Sub

    Private Sub Void_BTN_Click(sender As Object, e As EventArgs) Handles Void_BTN.Click
        If lvEmployee.SelectedItems.Count > 0 Then
            If chkassigned.Checked Then
                temp = New ManPower
                With temp
                    If MsgBox("Are you sure you want to continue?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, Application.ProductName) = MsgBoxResult.Yes Then
                        For Each item As ListViewItem In lvEmployee.SelectedItems
                            .ID = lvEmployee.SelectedItems(0).SubItems(0).Text
                        Next
                        .VoidAssigned()

                        MsgBox($"Position: {vbCrLf}{lvEmployee.SelectedItems(0).SubItems(4).Text}{vbCrLf}Name:{vbCrLf}{lvEmployee.SelectedItems(0).SubItems(1).Text}{vbCrLf}has been voided.", MsgBoxStyle.Information, Application.ProductName)
                        LoadEmployee()
                    End If

                End With
                ListViewGrouping(lvEmployee, 3)
            Else
                temp = New ManPower
                With temp
                    If MsgBox("Are you sure you want to continue?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, Application.ProductName) = MsgBoxResult.Yes Then
                        For Each item As ListViewItem In lvEmployee.SelectedItems
                            .ID = lvEmployee.SelectedItems(0).SubItems(0).Text
                        Next
                        .VoidReliever()

                        MsgBox($"Position: {vbCrLf}{lvEmployee.SelectedItems(0).SubItems(4).Text}{vbCrLf}Name:{vbCrLf}{lvEmployee.SelectedItems(0).SubItems(1).Text}{vbCrLf}has been voided.", MsgBoxStyle.Information, Application.ProductName)
                        Loadreliever()
                    End If

                End With
                ListViewGrouping(lvEmployee, 6)
            End If
        End If
    End Sub

    Private Sub Next_BTN_Click(sender As Object, e As EventArgs) Handles Next_BTN.Click
        If chkassigned.Checked = True Then
            Dim sql As String = "SELECT * from TBL_EMPLOYEE INNER JOIN TBLMANNING ON TBL_EMPLOYEE.ID=TBLMANNING.EMP_ID  INNER JOIN TBL_BRANCH ON TBLMANNING.BRANCH_ID =TBL_BRANCH.ID WHERE WORK_STATUS='1' AND TBLMANNING.VOID = 0 ORDER BY TBLMANNING.ID DESC"
            Dim ds As DataSet = NextPage(sql, rowCount, Output_Lbl, "TBL_EMPLOYEE")
            lvEmployee.Items.Clear()
            If ds.Tables(0).Rows.Count > 0 Then
                For Each dr As DataRow In ds.Tables(0).Rows
                    AddItem(dr)
                Next
            End If
            ListViewGrouping(lvEmployee, 3)
        Else
            Dim sql As String = "SELECT * FROM TBL_RELIEVE INNER JOIN TBL_EMPLOYEE ON TBL_RELIEVE.R_EMPLOYEE_ID=TBL_EMPLOYEE.id  INNER JOIN TBL_BRANCH ON TBL_RELIEVE.BRANCH_ID =TBL_BRANCH.ID  Where  TBL_RELIEVE.STATUS='1' AND TBL_RELIEVE.VOID = 0 ORDER BY CREATED_DATE DESC"
            Dim ds As DataSet = NextPage(sql, rowCountRelieve, Output_Lbl, "TBL_RELIEVE")
            lvEmployee.Items.Clear()
            If ds.Tables(0).Rows.Count > 0 Then
                For Each dr As DataRow In ds.Tables(0).Rows
                    relieveadditem(dr)
                Next
            End If
            ListViewGrouping(lvEmployee, 6)
        End If
    End Sub

    Private Sub Previous_BTN_Click(sender As Object, e As EventArgs) Handles Previous_BTN.Click
        If chkassigned.Checked = True Then
            Dim sql As String = "SELECT * from TBL_EMPLOYEE INNER JOIN TBLMANNING ON TBL_EMPLOYEE.ID=TBLMANNING.EMP_ID  INNER JOIN TBL_BRANCH ON TBLMANNING.BRANCH_ID =TBL_BRANCH.ID WHERE WORK_STATUS='1' AND TBLMANNING.VOID = 0 ORDER BY TBLMANNING.ID DESC"
            Dim ds As DataSet = PreviousPage(sql, rowCount, Output_Lbl, "TBL_EMPLOYEE")
            lvEmployee.Items.Clear()
            If ds.Tables(0).Rows.Count > 0 Then
                For Each dr As DataRow In ds.Tables(0).Rows
                    AddItem(dr)
                Next
            End If
            ListViewGrouping(lvEmployee, 3)
        Else
            Dim sql As String = "SELECT * FROM TBL_RELIEVE INNER JOIN TBL_EMPLOYEE ON TBL_RELIEVE.R_EMPLOYEE_ID=TBL_EMPLOYEE.id  INNER JOIN TBL_BRANCH ON TBL_RELIEVE.BRANCH_ID =TBL_BRANCH.ID  Where  TBL_RELIEVE.STATUS='1' AND TBL_RELIEVE.VOID = 0 ORDER BY CREATED_DATE DESC"
            Dim ds As DataSet = PreviousPage(sql, rowCountRelieve, Output_Lbl, "TBL_RELIEVE")
            lvEmployee.Items.Clear()
            If ds.Tables(0).Rows.Count > 0 Then
                For Each dr As DataRow In ds.Tables(0).Rows
                    relieveadditem(dr)
                Next
            End If
            ListViewGrouping(lvEmployee, 6)
        End If
    End Sub

    Private Sub LvEmployee_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lvEmployee.ColumnClick
        SortingOrder(lvEmployee, e.Column)
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch.PerformClick()
        End If
    End Sub

    Private Sub lvEmployee_DoubleClick(sender As Object, e As EventArgs) Handles lvEmployee.DoubleClick
        btnSelect.PerformClick()
    End Sub
End Class