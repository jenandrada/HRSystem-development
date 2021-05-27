Imports System.IO
Imports FirebirdSql.Data.FirebirdClient

Public Class frmCoorective

    Friend isPage1 As Integer
    Dim chkStatus As Integer
    Dim dateIssued As String = Now.ToShortDateString
    'Dim Sectionlist As New ArrayList

    Private Sub FrmCoorective_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetSCNo(SCNo_LBL)

        Dim tmpRule As New Lists
        'tmpRule.RuleDataTable()
        _console.Clear()
        LV_Rules.Items.Clear()
        WP_RulesList.Items.Clear()
        Optional_Group.Enabled = False
        With tmpRule
            For Each item In .List()
                Dim lvitem As ListViewItem = LV_Rules.Items.Add(item.RuleNumber)
                lvitem.SubItems.Add(item.RuleDefinition)
                Dim wplvitem As ListViewItem = WP_RulesList.Items.Add(item.RuleNumber)
                wplvitem.SubItems.Add(item.RuleDefinition)
            Next
        End With
        chkStatus = 0
    End Sub

    Private Sub Close_BTN_Click(sender As Object, e As EventArgs) Handles Close_BTN.Click
        Close()
    End Sub

    Private Sub SearchEMP_BTN_Click(sender As Object, e As EventArgs) Handles SearchEMP_BTN.Click

        If frmEmployeeList Is Nothing Then
            Dim frm As New frmEmployeeList With {
                .MdiParent = frmMainForm
            }
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            frm.Show()
            frm.btnView.Visible = False
            frm.btnAdd.Visible = False
            frm.btnSelect.Visible = True
            frm.txtSearch.Tag = "Corrective1"
            frm.Dock = DockStyle.Fill
            frm.BringToFront()

        Else
            frmEmployeeList.BringToFront()
        End If

        Close()
    End Sub


    Friend Sub LoadEmployeeShowCause(mPower As Employee)

        With mPower
            EmpName_TXT.Text = String.Format($"{ .LastName}, { .FirstName} { .MiddleName}")
            EmpName_TXT.Tag = .ID
            Position_TXT.Text = .Position
            Company_TXT.Text = .Company_Name
            Branch_TXT.Text = .Branch_Name
        End With

    End Sub

    Friend Sub LoadEmployeeWritten(mPower As Employee)

        With mPower
            WP_Name_TXT.Text = String.Format($"{ .LastName}, { .FirstName} { .MiddleName}")
            WP_Name_TXT.Tag = .ID
            WP_Position_TXT.Text = .Position
            WP_Company_TXT.Text = .Company_Name
            WP_Branch_TXT.Text = .Branch_Name
        End With

    End Sub

    'Friend Sub LoadEmpRelieve(mPower As ManPower)
    '    With mPower
    '        If isPage1 = 0 Then
    '            EmpName_TXT.Text = String.Format($"{ .Lastname}, { .Firstname} { .Middlename}")
    '            EmpName_TXT.Tag = .EmpID
    '            Position_TXT.Text = .Position
    '            Company_TXT.Text = .Companyname
    '            Branch_TXT.Text = .Branchname
    '            CorrectiveWindow.SelectedIndex = 0

    '        ElseIf isPage1 = 1 Then
    '            WP_Name_TXT.Text = String.Format($"{ .Lastname}, { .Firstname} { .Middlename}")
    '            WP_Name_TXT.Tag = .EmpID
    '            WP_Position_TXT.Text = .Position
    '            WP_Company_TXT.Text = .Companyname
    '            WP_Branch_TXT.Text = .Branchname
    '            CorrectiveWindow.SelectedIndex = 1
    '        End If
    '    End With

    'End Sub

    Private Sub LoadShowCauseReport()
        Dim datesent As String
        If Optional_Group.Enabled = True Then
            datesent = DateSent_DTP.Value.ToString("dd-MM-yy")
        Else
            datesent = ""
        End If

        Dim tmp As New Lists
        Dim tbl As New Rules_SectionsDataSet.RS_DataTableDataTable()
        RptViewer_ShowCause.LocalReport.DataSources.Clear()
        Dim paramList As New List(Of ReportParameter) From {
            New ReportParameter("paramName", EmpName_TXT.Text, True),
            New ReportParameter("paramPosition", Position_TXT.Text, True),
            New ReportParameter("paramCompany", Company_TXT.Text, True),
            New ReportParameter("paramBranch", Branch_TXT.Text, True),
            New ReportParameter("paramDate", dateIssued),
            New ReportParameter("paramExplaination", Explaination_TXT.Text),
            New ReportParameter("paramDateofAudit", _console.Text),
            New ReportParameter("paramLocation", Location_TXT.Text),
            New ReportParameter("paramAuditFindings", AuditFindings_TXT.Text),
            New ReportParameter("paramChecked", chkStatus),
            New ReportParameter("paramHRSupervisor", HRSupervisor_TXT.Text),
            New ReportParameter("paramBusinessUnitHead", BusinessUnitHead_TXT.Text),
            New ReportParameter("paramPosition1", Position1_TXT.Text),
            New ReportParameter("paramPosition3", Position3_TXT.Text),
            New ReportParameter("paramReplySent", datesent),
            New ReportParameter("paramSentVia", SentVia_TXT.Text)
        }


        Try
            For Each itemsec As ListViewItem In LV_Sections.SelectedItems
                Dim sql As String = "select * from TBL_RULESECTIONLIST where SECTION = '" & itemsec.SubItems(0).Text & "';"
                Using adapter As New FbDataAdapter(sql, con)
                    adapter.Fill(tbl)
                End Using
            Next

            Dim datasource As New ReportDataSource With
            {
                .Name = "DataSet1",
                .Value = tbl
            }

            RptViewer_ShowCause.LocalReport.DataSources.Add(datasource)
            RptViewer_ShowCause.LocalReport.SetParameters(paramList)
            RptViewer_ShowCause.RefreshReport()
        Catch ex As Exception
            Log_Report(ex.ToString)
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub LoadWrittenReprimandReport()
        Dim tmp As New Lists
        Dim tbl As New Rules_SectionsDataSet.RS_DataTableDataTable
        If WW_RBTN.Checked = True Then
            chkStatus = 1
        ElseIf TwoDays_RBTN.Checked = True Then
            chkStatus = 2
        ElseIf FourDays_RBTN.Checked = True Then
            chkStatus = 3
        ElseIf SixDays_RBTN.Checked = True Then
            chkStatus = 4
        End If
        RptViewer_WrittenReprimand.LocalReport.DataSources.Clear()
        Dim paramList As New List(Of ReportParameter) From {
            New ReportParameter("paramName", WP_Name_TXT.Text, True),
            New ReportParameter("paramPosition", WP_Position_TXT.Text, True),
            New ReportParameter("paramCompany", WP_Company_TXT.Text, True),
            New ReportParameter("paramBranch", WP_Branch_TXT.Text, True),
            New ReportParameter("paramDate", dateIssued),
            New ReportParameter("paramIncident", WP_Incident_TXT.Text),
            New ReportParameter("paramStatus", chkStatus),
            New ReportParameter("paramHRSupervisor", WP_HR_Sup_TXT.Text),
            New ReportParameter("paramEmployeeRelations", WP_Emp_Rel_TXT.Text),
            New ReportParameter("paramDiningOfficerIn_charge", WP_Officer_Incharge_TXT.Text),
            New ReportParameter("paramBusinessUnitHead", WP_BusinessHead_TXT.Text),
            New ReportParameter("paramPosition1", WP_Position1_TXT.Text),
            New ReportParameter("paramPosition2", WP_Position2_TXT.Text),
            New ReportParameter("paramPosition3", WP_Position3_TXT.Text),
            New ReportParameter("paramPosition4", WP_Position4_TXT.Text),
            New ReportParameter("paramManuallNumDaysSuspension", NumberOfDays_TXT.Text)
        }
        Try
            For Each itemsec As ListViewItem In WP_SectionsList.SelectedItems
                Dim sql As String = "select * from TBL_RULESECTIONLIST where SECTION = '" & itemsec.SubItems(0).Text & "';"
                Using adapter As New FbDataAdapter(sql, con)
                    adapter.Fill(tbl)
                End Using
            Next
            Dim datasource As New ReportDataSource With
            {
                .Name = "WP_DataSet1",
                .Value = tbl
            }
            RptViewer_WrittenReprimand.LocalReport.DataSources.Add(datasource)
            RptViewer_WrittenReprimand.LocalReport.SetParameters(paramList)

            RptViewer_WrittenReprimand.RefreshReport()
        Catch ex As Exception
            Log_Report(ex.ToString)
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub OK_BTN_Click(sender As Object, e As EventArgs) Handles OK_BTN.Click
        If EmpName_TXT.Text = "" Or IsNothing(Me.LV_Sections.FocusedItem) Then
            If EmpName_TXT.Text = "" Then
                MessageBox.Show($"Please select employee name.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf IsNothing(Me.LV_Sections.FocusedItem) Then
                MessageBox.Show($"Please select section number.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            LoadShowCauseReport()
        End If

    End Sub

    Private Sub Audit_CHK_CheckedChanged(sender As Object, e As EventArgs) Handles Audit_CHK.CheckedChanged
        If Audit_CHK.Checked = True Then
            chkStatus = 1
        ElseIf Audit_CHK.Checked = False Then
            chkStatus = 0
        End If
    End Sub

    Private Sub SearchWP_EMP_BTN_Click(sender As Object, e As EventArgs) Handles SearchWP_EMP_BTN.Click
        'Dim secured_str As String = EmpName_TXT.Text
        'secured_str = DreadKnight(secured_str)

        If frmEmployeeList Is Nothing Then
            Dim frm As New frmEmployeeList With {
                .MdiParent = frmMainForm
            }
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            frm.Show()
            frm.btnView.Visible = False
            frm.btnAdd.Visible = False
            frm.btnSelect.Visible = True
            frm.txtSearch.Tag = "Corrective2"
            frm.Dock = DockStyle.Fill
            frm.BringToFront()

        Else
            frmEmployeeList.BringToFront()
        End If

        Close()
    End Sub

    Private Sub LV_Rules_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LV_Rules.SelectedIndexChanged
        'RuleNoList.Add(LV_Rules.Items(LV_Rules.FocusedItem.Index).SubItems(0).Text)
        Dim tmp As New Lists
        LV_Sections.Items.Clear()
        For Each i As ListViewItem In LV_Rules.SelectedItems
            If i.SubItems(0).Text = "RULE I" Then
                For Each item In tmp.Rule1Sections()
                    Dim lvitem As ListViewItem = LV_Sections.Items.Add(item.Section)
                    lvitem.SubItems.Add(item.NatureOfOffenses)
                    'Dim sql As String = "select * from TBL_RULESECTIONLIST"
                    'Dim ds As DataSet = LoadSQL(sql, "TBL_RULESECTIONLIST")
                    'Dim dsNew As DataRow
                    'dsNew = ds.Tables(0).NewRow
                    'With dsNew
                    '    .Item(1) = i.SubItems(0).Text
                    '    .Item(2) = i.SubItems(1).Text
                    '    .Item(3) = item.Section
                    '    .Item(4) = item.NatureOfOffenses
                    'End With
                    'ds.Tables(0).Rows.Add(dsNew)
                    'SaveEntry(ds)
                Next
            ElseIf i.SubItems(0).Text = "RULE II" Then
                For Each item In tmp.Rule2Sections()
                    Dim lvitem As ListViewItem = LV_Sections.Items.Add(item.Section)
                    lvitem.SubItems.Add(item.NatureOfOffenses)
                    'Dim sql As String = "select * from TBL_RULESECTIONLIST"
                    'Dim ds As DataSet = LoadSQL(sql, "TBL_RULESECTIONLIST")
                    'Dim dsNew As DataRow
                    'dsNew = ds.Tables(0).NewRow
                    'With dsNew
                    '    .Item(1) = i.SubItems(0).Text
                    '    .Item(2) = i.SubItems(1).Text
                    '    .Item(3) = item.Section
                    '    .Item(4) = item.NatureOfOffenses
                    'End With
                    'ds.Tables(0).Rows.Add(dsNew)
                    'SaveEntry(ds)
                Next
            ElseIf i.SubItems(0).Text = "RULE III" Then
                For Each item In tmp.Rule3Sections()
                    Dim lvitem As ListViewItem = LV_Sections.Items.Add(item.Section)
                    lvitem.SubItems.Add(item.NatureOfOffenses)
                    'Dim sql As String = "select * from TBL_RULESECTIONLIST"
                    'Dim ds As DataSet = LoadSQL(sql, "TBL_RULESECTIONLIST")
                    'Dim dsNew As DataRow
                    'dsNew = ds.Tables(0).NewRow
                    'With dsNew
                    '    .Item(1) = i.SubItems(0).Text
                    '    .Item(2) = i.SubItems(1).Text
                    '    .Item(3) = item.Section
                    '    .Item(4) = item.NatureOfOffenses
                    'End With
                    'ds.Tables(0).Rows.Add(dsNew)
                    'SaveEntry(ds)
                Next
            ElseIf i.SubItems(0).Text = "RULE IV" Then
                For Each item In tmp.Rule4Sections()
                    Dim lvitem As ListViewItem = LV_Sections.Items.Add(item.Section)
                    lvitem.SubItems.Add(item.NatureOfOffenses)
                    'Dim sql As String = "select * from TBL_RULESECTIONLIST"
                    'Dim ds As DataSet = LoadSQL(sql, "TBL_RULESECTIONLIST")
                    'Dim dsNew As DataRow
                    'dsNew = ds.Tables(0).NewRow
                    'With dsNew
                    '    .Item(1) = i.SubItems(0).Text
                    '    .Item(2) = i.SubItems(1).Text
                    '    .Item(3) = item.Section
                    '    .Item(4) = item.NatureOfOffenses
                    'End With
                    'ds.Tables(0).Rows.Add(dsNew)
                    'SaveEntry(ds)
                Next
            ElseIf i.SubItems(0).Text = "RULE V" Then
                For Each item In tmp.Rule5Sections()
                    Dim lvitem As ListViewItem = LV_Sections.Items.Add(item.Section)
                    lvitem.SubItems.Add(item.NatureOfOffenses)
                    'Dim sql As String = "select * from TBL_RULESECTIONLIST"
                    'Dim ds As DataSet = LoadSQL(sql, "TBL_RULESECTIONLIST")
                    'Dim dsNew As DataRow
                    'dsNew = ds.Tables(0).NewRow
                    'With dsNew
                    '    .Item(1) = i.SubItems(0).Text
                    '    .Item(2) = i.SubItems(1).Text
                    '    .Item(3) = item.Section
                    '    .Item(4) = item.NatureOfOffenses
                    'End With
                    'ds.Tables(0).Rows.Add(dsNew)
                    'SaveEntry(ds)
                Next
            ElseIf i.SubItems(0).Text = "RULE VI" Then
                For Each item In tmp.Rule6Sections()
                    Dim lvitem As ListViewItem = LV_Sections.Items.Add(item.Section)
                    lvitem.SubItems.Add(item.NatureOfOffenses)
                    'Dim sql As String = "select * from TBL_RULESECTIONLIST"
                    'Dim ds As DataSet = LoadSQL(sql, "TBL_RULESECTIONLIST")
                    'Dim dsNew As DataRow
                    'dsNew = ds.Tables(0).NewRow
                    'With dsNew
                    '    .Item(1) = i.SubItems(0).Text
                    '    .Item(2) = i.SubItems(1).Text
                    '    .Item(3) = item.Section
                    '    .Item(4) = item.NatureOfOffenses
                    'End With
                    'ds.Tables(0).Rows.Add(dsNew)
                    'SaveEntry(ds)
                Next

            End If
        Next
    End Sub

    Private Sub WP_OK_BTN_Click(sender As Object, e As EventArgs) Handles WP_OK_BTN.Click

        If WP_Name_TXT.Text = "" Or IsNothing(Me.WP_SectionsList.FocusedItem) Then
            If WP_Name_TXT.Text = "" Then
                MessageBox.Show($"Please select employee name.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf IsNothing(Me.WP_SectionsList.FocusedItem) Then
                MessageBox.Show($"Please select section number.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            LoadWrittenReprimandReport()
        End If
    End Sub

    Private Sub WP_RulesList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WP_RulesList.SelectedIndexChanged

        Dim tmp As New Lists
        WP_SectionsList.Items.Clear()
        For Each i As ListViewItem In WP_RulesList.SelectedItems
            If i.SubItems(0).Text = "RULE I" Then
                For Each item In tmp.Rule1Sections()
                    Dim lvitem As ListViewItem = WP_SectionsList.Items.Add(item.Section)
                    lvitem.SubItems.Add(item.NatureOfOffenses)
                Next

            ElseIf i.SubItems(0).Text = "RULE II" Then
                For Each item In tmp.Rule2Sections()
                    Dim lvitem As ListViewItem = WP_SectionsList.Items.Add(item.Section)
                    lvitem.SubItems.Add(item.NatureOfOffenses)
                Next

            ElseIf i.SubItems(0).Text = "RULE III" Then
                For Each item In tmp.Rule3Sections()
                    Dim lvitem As ListViewItem = WP_SectionsList.Items.Add(item.Section)
                    lvitem.SubItems.Add(item.NatureOfOffenses)
                Next

            ElseIf i.SubItems(0).Text = "RULE IV" Then
                For Each item In tmp.Rule4Sections()
                    Dim lvitem As ListViewItem = WP_SectionsList.Items.Add(item.Section)
                    lvitem.SubItems.Add(item.NatureOfOffenses)
                Next

            ElseIf i.SubItems(0).Text = "RULE V" Then
                For Each item In tmp.Rule5Sections()
                    Dim lvitem As ListViewItem = WP_SectionsList.Items.Add(item.Section)
                    lvitem.SubItems.Add(item.NatureOfOffenses)
                Next

            ElseIf i.SubItems(0).Text = "RULE VI" Then
                For Each item In tmp.Rule6Sections()
                    Dim lvitem As ListViewItem = WP_SectionsList.Items.Add(item.Section)
                    lvitem.SubItems.Add(item.NatureOfOffenses)
                Next

            End If
        Next
    End Sub

    Public Function AddImage(ByRef dir As String, ByRef img As String) As System.Drawing.Image
        Dim temp As Image = Image.FromFile(dir & "\" & img & ".jpg")

        Return temp

    End Function

    Friend Sub ToPDF(ByRef Name As String, ByRef Folder As String, ByRef report As ReportViewer, ByRef listview As ListView)

        Dim DirFolderToCreate As String = "D:\HR Records\" & Folder & ""
        Dim folderName As DirectoryInfo = New DirectoryInfo(DirFolderToCreate)

        Dim DirEmployeeToCreate As String = "D:\HR Records\" & Folder & "\" & Name
        Dim employee As DirectoryInfo = New DirectoryInfo(DirEmployeeToCreate)

        Dim byteViewer As Byte() = report.LocalReport.Render("PDF")
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "*PDF files (*.pdf)|*.pdf"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True

        If folderName.Exists Then

            If employee.Exists Then
                Dim newFile As New FileStream("D:\HR Records\" & Folder & "\" & Name & "\" & listview.Items(listview.FocusedItem.Index).SubItems(0).Text & ".pdf", FileMode.Create)
                newFile.Write(byteViewer, 0, byteViewer.Length)
                newFile.Close()
            Else
                employee.Create()
                Dim newFile As New FileStream("D:\HR Records\" & Folder & "\" & Name & "\" & listview.Items(listview.FocusedItem.Index).SubItems(0).Text & ".pdf", FileMode.Create)
                newFile.Write(byteViewer, 0, byteViewer.Length)
                newFile.Close()
            End If

        Else
            folderName.Create()
            If employee.Exists Then
                Dim newFile As New FileStream("D:\HR Records\" & Folder & "\" & Name & "\" & listview.Items(listview.FocusedItem.Index).SubItems(0).Text & ".pdf", FileMode.Create)
                newFile.Write(byteViewer, 0, byteViewer.Length)
                newFile.Close()
            Else
                employee.Create()
                Dim newFile As New FileStream("D:\HR Records\" & Folder & "\" & Name & "\" & listview.Items(listview.FocusedItem.Index).SubItems(0).Text & ".pdf", FileMode.Create)
                newFile.Write(byteViewer, 0, byteViewer.Length)
                newFile.Close()
            End If

        End If

        Dim str As String = "D:\HR Records\" & Folder & "\" & Name & "\" & listview.Items(listview.FocusedItem.Index).SubItems(0).Text & ".pdf"

        SaveShowCause(EmpName_TXT.Tag, DateSent_DTP.Value, DateSent_DTP.Value.AddDays(5), str, "NO", Company_TXT.Text)

        MessageBox.Show($"{Name} successfully saved to D:\HR Records\{Folder}", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Process.Start(str)
    End Sub

    Private Sub Save_BTN_Click(sender As Object, e As EventArgs) Handles Save_BTN.Click

        If Not EmpName_TXT.Text = "" Then

            ToPDF(EmpName_TXT.Text, "Show Cause Notice", RptViewer_ShowCause, LV_Rules)

            For Each itemsec As ListViewItem In LV_Sections.SelectedItems
                Dim sql As String = "select * from TBL_RULESECTIONLIST where SECTION = '" & itemsec.SubItems(0).Text & "';"
                Using adapter As New FbDataAdapter(sql, con)
                    SaveRuleNoSectionnO(EmpName_TXT.Tag, LV_Rules.FocusedItem.SubItems(0).Text, itemsec.SubItems(0).Text)
                End Using
            Next

        Else
            MessageBox.Show($"Click Preview before saving", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub WP_Save_Btn_Click(sender As Object, e As EventArgs) Handles WP_Save_Btn.Click

        If Not WP_Name_TXT.Text = "" Then
            ToPDF(WP_Name_TXT.Text, "Written Reprimand Notice", RptViewer_WrittenReprimand, WP_RulesList)
        Else
            MessageBox.Show($"Click Preview before saving", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub PS1_Btn_Click(sender As Object, e As EventArgs) Handles PS1_Btn.Click
        Position1_TXT.ReadOnly = False
    End Sub

    Private Sub PS3_Btn_Click(sender As Object, e As EventArgs) Handles PS3_Btn.Click
        Position3_TXT.ReadOnly = False
    End Sub

    Private Sub WP_PS1_Btn_Click(sender As Object, e As EventArgs) Handles WP_PS1_Btn.Click
        WP_Position1_TXT.ReadOnly = False
    End Sub

    Private Sub WP_PS2_Btn_Click(sender As Object, e As EventArgs) Handles WP_PS2_Btn.Click
        WP_Position2_TXT.ReadOnly = False
    End Sub

    Private Sub WP_PS3_Btn_Click(sender As Object, e As EventArgs) Handles WP_PS3_Btn.Click
        WP_Position3_TXT.ReadOnly = False
    End Sub

    Private Sub WP_PS4_Btn_Click(sender As Object, e As EventArgs) Handles WP_PS4_Btn.Click
        WP_Position4_TXT.ReadOnly = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            NumberOfDays_TXT.Enabled = True
            WW_RBTN.Checked = False
            TwoDays_RBTN.Checked = False
            FourDays_RBTN.Checked = False
            SixDays_RBTN.Checked = False
            chkStatus = 0
        Else
            NumberOfDays_TXT.Enabled = False
        End If
    End Sub

    Private Sub WW_RBTN_CheckedChanged(sender As Object, e As EventArgs) Handles WW_RBTN.CheckedChanged
        If WW_RBTN.Checked = True Then
            CheckBox1.Checked = False
            NumberOfDays_TXT.Value = 0
        End If
    End Sub

    Private Sub TwoDays_RBTN_CheckedChanged(sender As Object, e As EventArgs) Handles TwoDays_RBTN.CheckedChanged
        If TwoDays_RBTN.Checked = True Then
            CheckBox1.Checked = False
            NumberOfDays_TXT.Value = 0
        End If
    End Sub

    Private Sub FourDays_RBTN_CheckedChanged(sender As Object, e As EventArgs) Handles FourDays_RBTN.CheckedChanged
        If FourDays_RBTN.Checked = True Then
            CheckBox1.Checked = False
            NumberOfDays_TXT.Value = 0
        End If
    End Sub

    Private Sub SixDays_RBTN_CheckedChanged(sender As Object, e As EventArgs) Handles SixDays_RBTN.CheckedChanged
        If SixDays_RBTN.Checked = True Then
            CheckBox1.Checked = False
            NumberOfDays_TXT.Value = 0
        End If
    End Sub

    Private Sub Optional_CHK_CheckedChanged(sender As Object, e As EventArgs) Handles Optional_CHK.CheckedChanged
        If Optional_CHK.Checked Then
            Optional_Group.Enabled = True
        Else
            Optional_Group.Enabled = False
        End If
    End Sub

    Private ReadOnly _console As New RichTextBox

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        _console.Clear()
    End Sub

    Private Sub FromAuditDate_DTP_CloseUp(sender As Object, e As EventArgs) Handles FromAuditDate_DTP.CloseUp
        _console.AppendText(FromAuditDate_DTP.Value & ", ")
    End Sub

    Private Sub LV_Rules_Click(sender As Object, e As EventArgs)
        Alert()
    End Sub


    Private Sub GroupBox6_Paint(sender As Object, e As PaintEventArgs) Handles GroupBox6.Paint
        Dim p As New Pen(Color.Red, 2)
        e.Graphics.DrawRectangle(p, New Rectangle(EmpName_TXT.Location + New Size(1, 1), EmpName_TXT.Size - New Size(2, 2)))
        p.Dispose()
    End Sub


    Private Sub EmpName_TXT_TextChanged(sender As Object, e As EventArgs) Handles EmpName_TXT.TextChanged
        If EmpName_TXT.Text = "" Then
            EmpName_TXT.Region = New Region(New Rectangle(2, 2, EmpName_TXT.Width - 4, EmpName_TXT.Height - 4))
        Else
            EmpName_TXT.Region = Nothing
        End If
    End Sub


    Private Sub LV_Sections_Click(sender As Object, e As EventArgs) Handles LV_Sections.Click
        Alert()
    End Sub

    Private Sub Alert()
        If EmpName_TXT.Text = "" Then
            MessageBox.Show($"Please select employee name.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf IsNothing(Me.LV_Sections.FocusedItem) Then
            MessageBox.Show($"Please select section number.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub AuditFindings_TXT_TextChanged(sender As Object, e As EventArgs) Handles AuditFindings_TXT.TextChanged
        Alert()
    End Sub

    Private Sub Location_TXT_TextChanged(sender As Object, e As EventArgs) Handles Location_TXT.TextChanged
        Alert()
    End Sub

    Private Sub Explaination_TXT_TextChanged(sender As Object, e As EventArgs) Handles Explaination_TXT.TextChanged
        Alert()
    End Sub

    'Private ReadOnly _section As New RichTextBox

    'Private Sub LV_Sections_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LV_Sections.SelectedIndexChanged, LV_Rules.Click
    '    Sectionlist.Add(LV_Sections.Items(LV_Sections.FocusedItem.Index).SubItems(0).Text)
    'End Sub

End Class