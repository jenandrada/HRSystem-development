Imports System.Configuration
Imports System.Globalization

Imports CustomPrinting.PrintWorkList

Imports FirebirdSql.Data.FirebirdClient

Public Class frmAllowance
    Private tmpBhouse As BhouseAllowance
    Private tempID As Integer
    'Private ReadOnly careKitID As New Integer

    Private Sub frmAllowance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllowanceAssigned()

    End Sub

    Private Sub LoadAllowanceRelieved(Optional str As String = "")
        Dim secured_str As String = str
        secured_str = DreadKnight(secured_str)
        Dim strWords As String() = secured_str.Split(New Char() {" "c})
        Dim name As String
        Dim sql As String
        If str.Length <> 0 Then
            sql = "SELECT * FROM BHOUSE_LIST_RELIEVED WHERE "
            For Each name In strWords
                sql &= vbCr & " UPPER(FULLNAME) LIKE UPPER('%" & name & "%') and "
                sql &= vbCr & "UPPER(FULLNAME) LIKE UPPER('%" & name & "%') and "
                If name Is strWords.Last Then
                    sql &= vbCr & " UPPER(FULLNAME) LIKE UPPER('%" & name & "%') "
                    Exit For
                End If
            Next
        Else
            sql = "SELECT * FROM BHOUSE_LIST_RELIEVED"
        End If
        Using ds As DataSet = LoadSQL(sql, "BHOUSE_LIST_RELIEVED")
            LvBhouseList.Items.Clear()
            For Each dr In ds.Tables(0).Rows
                AddtoListRelieved(dr)
            Next
        End Using
    End Sub

    Private Sub LoadAllowanceAppointed(Optional str As String = "")
        Dim secured_str As String = str
        secured_str = DreadKnight(secured_str)
        Dim strWords As String() = secured_str.Split(New Char() {" "c})
        Dim name As String
        Dim sql As String
        If str.Length <> 0 Then
            sql = "SELECT * FROM BHOUSE_LIST_APPOINTED WHERE "
            For Each name In strWords
                sql &= vbCr & " UPPER(FULLNAME) LIKE UPPER('%" & name & "%') and "
                sql &= vbCr & "UPPER(FULLNAME) LIKE UPPER('%" & name & "%') and "
                If name Is strWords.Last Then
                    sql &= vbCr & " UPPER(FULLNAME) LIKE UPPER('%" & name & "%') "
                    Exit For
                End If
            Next
        Else
            sql = "SELECT * FROM BHOUSE_LIST_APPOINTED"
        End If
        Using ds As DataSet = LoadSQL(sql, "BHOUSE_LIST_APPOINTED")
            LvBhouseList.Items.Clear()
            For Each dr In ds.Tables(0).Rows
                AddtoListAppointed(dr)
            Next
        End Using
        If LvBhouseList.Columns.Count > 0 Then
            ListViewGrouping(LvBhouseList, 3)
        End If
    End Sub

    Private Sub LoadAllowanceAssigned(Optional str As String = "")
        Dim secured_str As String = str
        secured_str = DreadKnight(secured_str)
        Dim strWords As String() = secured_str.Split(New Char() {" "c})
        Dim name As String
        Dim sql As String
        If str.Length <> 0 Then

            sql = "SELECT * FROM BHOUSE_LIST WHERE "
            For Each name In strWords
                sql &= vbCr & " UPPER(FULLNAME) LIKE UPPER('%" & name & "%') and "
                sql &= vbCr & "UPPER(FULLNAME) LIKE UPPER('%" & name & "%') and "
                If name Is strWords.Last Then
                    sql &= vbCr & " UPPER(FULLNAME) LIKE UPPER('%" & name & "%') "
                    Exit For
                End If
            Next
        Else
            sql = "SELECT * FROM BHOUSE_LIST"
        End If
        Using ds As DataSet = LoadSQL(sql, "BHOUSE_LIST")
            LvBhouseList.Items.Clear()
            For Each dr In ds.Tables(0).Rows
                AddtoListAssigned(dr)
            Next
        End Using
        If LvBhouseList.Columns.Count > 0 Then
            ListViewGrouping(LvBhouseList, 3)
        End If
    End Sub

    Private Sub AddtoListAppointed(dr As DataRow)
        With dr
            Dim lvitem As ListViewItem = LvBhouseList.Items.Add(.Item("BH_ID"))
            lvitem.SubItems.Add(.Item("FULLNAME"))
            lvitem.SubItems.Add(.Item("CITYMUN"))
            lvitem.SubItems.Add(.Item("AREA_OF_ASSIGNMENT"))
            lvitem.SubItems.Add(.Item("BRANCHNAME"))
            lvitem.SubItems.Add(.Item("BRANCHCODE"))
            lvitem.SubItems.Add(.Item("COMPANYNAME"))
            lvitem.SubItems.Add(.Item("APPOINTED_POSITION"))
            Dim sql As String = "SELECT SUM(ALLOWANCE) AS TOTAL_ALLOWANCE FROM TBL_BHOUSE_ALLOWANCE WHERE VOID = 0"
            Dim ds As DataSet = LoadSQL(sql, "TBL_BHOUSE_ALLOWANCE")

            Dim drx As DataRow = ds.Tables(0).Rows(0)

            With drx
                Expense_TXT.Text = String.Format(CultureInfo.InvariantCulture, "PHP {0:0,0.00}", .Item("TOTAL_ALLOWANCE"))
            End With
        End With
    End Sub

    Private Sub AddtoListRelieved(dr As DataRow)
        With dr
            Dim lvitem As ListViewItem = LvBhouseList.Items.Add(.Item("BH_ID"))
            lvitem.SubItems.Add(.Item("FULLNAME"))
            lvitem.SubItems.Add(.Item("CURRENT_BRANCH"))
            lvitem.SubItems.Add(.Item("AREA_OF_ASSIGNMENT"))
            lvitem.SubItems.Add(.Item("BRANCHNAME"))
            lvitem.SubItems.Add(.Item("BRANCHCODE"))
            lvitem.SubItems.Add(.Item("COMPANYNAME"))
            lvitem.SubItems.Add(.Item("R_POSITION"))
            Dim sql As String = "SELECT SUM(ALLOWANCE) AS TOTAL_ALLOWANCE FROM TBL_BHOUSE_ALLOWANCE WHERE VOID = 0"
            Dim ds As DataSet = LoadSQL(sql, "TBL_BHOUSE_ALLOWANCE")

            Dim drx As DataRow = ds.Tables(0).Rows(0)

            With drx
                Expense_TXT.Text = String.Format(CultureInfo.InvariantCulture, "PHP {0:0,0.00}", .Item("TOTAL_ALLOWANCE"))
            End With
        End With
    End Sub

    Private Sub AddtoListAssigned(dr As DataRow)
        With dr
            Dim lvitem As ListViewItem = LvBhouseList.Items.Add(.Item("BH_ID"))
            lvitem.SubItems.Add(.Item("FULLNAME"))
            lvitem.SubItems.Add(.Item("CITYMUN"))
            lvitem.SubItems.Add(.Item("AREA_OF_ASSIGNMENT"))
            lvitem.SubItems.Add(.Item("BRANCHNAME"))
            lvitem.SubItems.Add(.Item("BRANCHCODE"))
            lvitem.SubItems.Add(.Item("COMPANYNAME"))
            lvitem.SubItems.Add(.Item("EMP_POSITION"))
            Dim sql As String = "SELECT SUM(ALLOWANCE + OTHER_ALLOWANCE) AS TOTAL_ALLOWANCE FROM TBL_BHOUSE_ALLOWANCE WHERE VOID = 0"
            Dim ds As DataSet = LoadSQL(sql, "TBL_BHOUSE_ALLOWANCE")

            Dim drx As DataRow = ds.Tables(0).Rows(0)

            With drx
                Expense_TXT.Text = String.Format(CultureInfo.InvariantCulture, "PHP {0:0,0.00}", .Item("TOTAL_ALLOWANCE"))
            End With
        End With
    End Sub

    Private Sub Clear_AllowanceDetails()
        CurrentAddress_TXT.Clear()
        Company_TXT.Clear()
        AssignedArea_TXT.Clear()
        Branch_TXT.Clear()
        BranchCode_TXT.Clear()
        Position_TXT.Clear()
        Allowance_TXT.Clear()
        Status_TXT.Clear()
        If All_Rbtn.Checked = True And LvBhouseList.Items.Count <= 0 Then
            Expense_TXT.Clear()
        ElseIf Appointed_Rbtn.Checked = True And LvBhouseList.Items.Count <= 0 Then
            Expense_TXT.Clear()
        ElseIf Assigned_Rbtn.Checked = True And LvBhouseList.Items.Count <= 0 Then
            Expense_TXT.Clear()
        End If
    End Sub

    Public Sub LoadOthers(bhouse As BhouseAllowance)
        'careKitID = bhouse.CareKit_ID
        If bhouse Is Nothing Then
            Exit Sub
        End If
        Name_TXT.Tag = bhouse.ID
        Name_TXT.Text = bhouse.FullName
        BH_Allowance_TXT.Text = String.Format(CultureInfo.InvariantCulture, "PHP {0:0,0.00}", bhouse.Allowance)
        OtherAllowance_TXT.Tag = bhouse.CareKit_ID
        Select Case bhouse.Status
            Case 0
                BH_Status_CB.Text = "PENDING, NEEDS HR'S APPROVAL"
            Case 1
                BH_Status_CB.Text = "APPROVED BUT NOT YET DELIVERED"
            Case 2
                BH_Status_CB.Text = "APPROVED AND DELIVERED"
        End Select
        OtherAllowance_TXT.Value = bhouse.Other_Allowance
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub LvBhouseList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvBhouseList.SelectedIndexChanged
        If LvBhouseList.SelectedItems.Count > 0 Then
            For Each item As ListViewItem In LvBhouseList.SelectedItems
                LoadDetails()
            Next
        End If
    End Sub

    Private Sub LoadDetails()
        tmpBhouse = New BhouseAllowance
        With tmpBhouse
            .GetDetails(LvBhouseList.SelectedItems(0).SubItems(0).Text)
            Allowance_TXT.Text = String.Format(CultureInfo.InvariantCulture, "PHP {0:0,0.00}", .Allowance)
            Others_TXT.Text = String.Format(CultureInfo.InvariantCulture, "PHP {0:0,0.00}", .Other_Allowance)
            CareKit_TXT.Text = String.Format(CultureInfo.InvariantCulture, "PHP {0:0,0.00}", .CareKit_Allowance)
            Select Case .Status
                Case 0
                    Status_TXT.Text = "PENDING, NEEDS HR'S APPROVAL"
                Case 1
                    Status_TXT.Text = "APPROVED BUT NOT YET DELIVERED"
                Case 2
                    Status_TXT.Text = "APPROVED AND DELIVERED"
            End Select

            CurrentAddress_TXT.Text = LvBhouseList.SelectedItems(0).SubItems(2).Text
            AssignedArea_TXT.Text = LvBhouseList.SelectedItems(0).SubItems(3).Text
            Branch_TXT.Text = LvBhouseList.SelectedItems(0).SubItems(4).Text
            BranchCode_TXT.Text = LvBhouseList.SelectedItems(0).SubItems(5).Text
            Company_TXT.Text = LvBhouseList.SelectedItems(0).SubItems(6).Text
            Position_TXT.Text = LvBhouseList.SelectedItems(0).SubItems(7).Text
            tempID = New Integer
            tempID = LvBhouseList.SelectedItems(0).SubItems(0).Text
        End With
    End Sub

    Private Sub Search_TXT_TextChanged(sender As Object, e As EventArgs) Handles Search_TXT.TextChanged
        LoadAllowanceAssigned(Search_TXT.Text)
    End Sub

    Private Sub Search_BTN_Click(sender As Object, e As EventArgs) Handles Search_BTN.Click
        LoadAllowanceAssigned(Search_TXT.Text)
        ListViewGrouping(LvBhouseList, 3)
    End Sub

    Private Sub Clear()
        Name_TXT.Clear()
        BH_Allowance_TXT.Clear()
        BH_Status_CB.SelectedIndex = 0
        OtherAllowance_TXT.Value = 0
        Particulars_TXT.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim secured_str As String = Name_TXT.Text
        secured_str = DreadKnight(secured_str)
        Dim frm As New frmAllowanceList
        If frmAllowanceList Is Nothing Then
            frm.MdiParent = frmMainForm
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            frm.SearchSelect(secured_str, FormName.BhouseAllowance)
            frm.Dock = DockStyle.Fill
            frm.Show()
            frm.BringToFront()
        Else
            frm.BringToFront()
        End If
        Close()
    End Sub

    Private Sub Save_BTN_Click(sender As Object, e As EventArgs) Handles Save_BTN.Click
        If String.IsNullOrEmpty(Particulars_TXT.Text) Then
            MessageBox.Show("Please put somthing in the particulars area.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Particulars_TXT.Text.Length < 10 Then
            MessageBox.Show("Particulars must atleast more than ten characters.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            tmpBhouse = New BhouseAllowance
            With tmpBhouse
                .ID = Name_TXT.Tag
                .Allowance = BH_Allowance_TXT.Text.Substring(4)
                .CareKit_ID = OtherAllowance_TXT.Tag
                If CareKit_RBTN.Checked = True Then
                    .CareKit_Allowance = OtherAllowance_TXT.Value
                Else
                    .Other_Allowance = OtherAllowance_TXT.Value
                End If

                .Status = BH_Status_CB.SelectedIndex
                .Particulars = Particulars_TXT.Text

                .UpdateAllowance(Name_TXT.Tag)

                MessageBox.Show("Additional allowance added to " + Name_TXT.Text, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Clear()
            End With
        End If

    End Sub

    Private Sub PrintAllowanceRelieved()
        Using rv_Assigned As New ReportViewer
            conStr = ConfigurationManager.ConnectionStrings("FbConString").ConnectionString.ToString
            con = New FbConnection(conStr)
            Dim sql As String = "SELECT * FROM PRINT_BHOUSE_ALLOWANCE_RELIEVED"
            rv_Assigned.LocalReport.DataSources.Clear()
            Using adapter As New FbDataAdapter(sql, con)
                Dim reports As New BHouse_AllowanceDataSet.AllowanceDetailsDataTable()
                adapter.Fill(reports)

                rv_Assigned.LocalReport.ReportEmbeddedResource = "HRSystem.rpt_BHouseAllowance.rdlc"
                Dim datasource As New ReportDataSource
                With datasource
                    .Name = "DataSet1"
                    .Value = reports
                End With
                Dim param As New ReportParameter(1)
                param = New ReportParameter("paramType", "(Reliever)")
                rv_Assigned.LocalReport.DataSources.Add(datasource)
                rv_Assigned.LocalReport.SetParameters(param)
            End Using
            PrintToPrinter(rv_Assigned.LocalReport)
        End Using
    End Sub

    Private Sub PrintAllowanceAppointed()
        Using rv_Assigned As New ReportViewer
            conStr = ConfigurationManager.ConnectionStrings("FbConString").ConnectionString.ToString
            con = New FbConnection(conStr)
            Dim sql As String = "SELECT * FROM PRINT_BHALLOWANCE_APPOINTED"
            rv_Assigned.LocalReport.DataSources.Clear()
            Using adapter As New FbDataAdapter(sql, con)
                Dim reports As New BHouse_AllowanceDataSet.AllowanceDetailsDataTable()
                adapter.Fill(reports)

                rv_Assigned.LocalReport.ReportEmbeddedResource = "HRSystem.rpt_BHouseAllowance.rdlc"
                Dim datasource As New ReportDataSource
                With datasource
                    .Name = "DataSet1"
                    .Value = reports
                End With
                Dim param As New ReportParameter(1)
                param = New ReportParameter("paramType", "(Appointed)")
                rv_Assigned.LocalReport.DataSources.Add(datasource)
                rv_Assigned.LocalReport.SetParameters(param)
            End Using
            PrintToPrinter(rv_Assigned.LocalReport)
        End Using
    End Sub

    Private Sub PrintAllowanceAssigned()
        Using rv_Assigned As New ReportViewer
            conStr = ConfigurationManager.ConnectionStrings("FbConString").ConnectionString.ToString
            con = New FbConnection(conStr)
            Dim sql As String = "SELECT * FROM PRINT_BHALLOWANCE_ASSIGNED"
            rv_Assigned.LocalReport.DataSources.Clear()
            Using adapter As New FbDataAdapter(sql, con)
                Dim reports As New BHouse_AllowanceDataSet.AllowanceDetailsDataTable()
                adapter.Fill(reports)

                rv_Assigned.LocalReport.ReportEmbeddedResource = "HRSystem.rpt_BHouseAllowance.rdlc"
                Dim datasource As New ReportDataSource
                With datasource
                    .Name = "DataSet1"
                    .Value = reports
                End With
                Dim param As New ReportParameter(1)
                param = New ReportParameter("paramType", "(Assigned)")
                rv_Assigned.LocalReport.DataSources.Add(datasource)
                rv_Assigned.LocalReport.SetParameters(param)
            End Using
            PrintToPrinter(rv_Assigned.LocalReport)
        End Using
    End Sub

    Private Sub Print_BTN_Click(sender As Object, e As EventArgs) Handles Print_BTN.Click

        If Assigned_Rbtn.Checked = True Then
            If MessageBox.Show("Do you want to print assigned records?", Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                MessageBox.Show($"Printing assigned records.{vbCrLf}Please wait for a moment.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                PrintAllowanceAssigned()
            Else
                MessageBox.Show("Request aborted.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        ElseIf Appointed_Rbtn.Checked = True Then
            If MessageBox.Show("Do you want to print appointed records?", Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                MessageBox.Show($"Printing appointed records.{vbCrLf}Please wait for a moment.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                PrintAllowanceAppointed()
            Else
                MessageBox.Show("Request aborted.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub Appointed_Rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles Appointed_Rbtn.CheckedChanged
        If Appointed_Rbtn.Checked = True Then
            LoadAllowanceAppointed()
            If LvBhouseList.Columns.Count > 0 Then
                LvBhouseList.Columns.Item(2).Text = "Current Address"
            End If
            Label2.Text = "Current Address:"
        End If
    End Sub

    Private Sub Assigned_Rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles Assigned_Rbtn.CheckedChanged
        If Assigned_Rbtn.Checked = True Then
            LoadAllowanceAssigned()
            If LvBhouseList.Columns.Count > 0 Then
                LvBhouseList.Columns.Item(2).Text = "Current Address"
            End If
            Label2.Text = "Current Address:"
        End If
    End Sub

    Private Sub Void_BTN_Click(sender As Object, e As EventArgs) Handles Void_BTN.Click
        If LvBhouseList.SelectedItems.Count <= 0 Then
            MessageBox.Show("No item(s) selected. Please select one item to proceed", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If MessageBox.Show($"Are you sure you want to remove {LvBhouseList.SelectedItems(0).SubItems(1).Text}{vbCrLf} from the list?{vbCrLf}Click Yes to continue and click No to abort the request", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                If Assigned_Rbtn.Checked = True Then
                    tmpBhouse = New BhouseAllowance
                    With tmpBhouse
                        .ID = tempID
                        .Void_Allowance()
                        MessageBox.Show(LvBhouseList.SelectedItems(0).SubItems(1).Text & " is removed from the list.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadAllowanceAssigned()
                        Clear_AllowanceDetails()
                    End With
                ElseIf Appointed_Rbtn.Checked = True Then
                    tmpBhouse = New BhouseAllowance
                    With tmpBhouse
                        .ID = tempID
                        .Void_Allowance()
                        MessageBox.Show($"{LvBhouseList.SelectedItems(0).SubItems(1).Text} is removed from the list.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadAllowanceRelieved()
                        Clear_AllowanceDetails()
                    End With
                End If
            Else
                MessageBox.Show("Request aborted.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub Edit_BTN_Click(sender As Object, e As EventArgs) Handles Edit_BTN.Click
        BH_Allowance_TXT.ReadOnly = False
        BH_Status_CB.Enabled = True
    End Sub

    Private Sub CareKit_RBTN_CheckedChanged(sender As Object, e As EventArgs) Handles CareKit_RBTN.CheckedChanged
        If CareKit_RBTN.Checked = True Then
            Note_TXT.Text = "This option is only avalable for employees that are more than 2 months working in this company."
        End If

    End Sub

    Private Sub LvBhouseList_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles LvBhouseList.ColumnClick
        SortingOrder(LvBhouseList, e.Column)
    End Sub

End Class