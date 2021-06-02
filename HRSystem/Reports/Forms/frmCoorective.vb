Imports System.Drawing.Imaging
Imports System.IO
Imports FirebirdSql.Data.FirebirdClient

Public Class frmCoorective

    Friend isPage1 As Integer
    Dim chkStatus As Integer
    Dim dateIssued As String = Now.ToShortDateString
    Dim imgData As Byte()
    Dim FolderPath As String
    Dim ExpalanationPath As String
    Dim scno_local As Integer

    'Dim Sectionlist As New ArrayList

    Private Sub FrmCoorective_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'If ThisHasRow("SHOWCAUSE_RECORDS") Then
        '    GetLastNo(SCNo_LBL, "SHOWCAUSE_RECORDS", "ID")
        'End If

        If ThisHasRow("IR_RECORDS") Then
            GetLastNo(IRNo_LBL, "IR_RECORDS", "IRNO")
        End If

        Dim tmpRule As New Lists
        'tmpRule.RuleDataTable()
        _console.Clear()
        LV_Rules.Items.Clear()
        WP_RulesList.Items.Clear()
        'Optional_Group.Enabled = False

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


    Friend Sub LoadEmployeeShowCause(mPower As Employee)

        With mPower

            EmpName_TXT.Text = String.Format($"{ .LastName}, { .FirstName} { .MiddleName}")
            EmpName_TXT.Tag = .ID
            Position_TXT.Text = .Position
            Company_TXT.Text = .Company_Name
            Branch_TXT.Text = .Branch_Name
            SCNo_LBL.Text = Format(.IRNo, "00000")

        End With

    End Sub

    Friend Sub LoadEmployeeWritten(mPower As Employee)

        With mPower
            WP_Name_TXT.Text = String.Format($"{ .LastName}, { .FirstName} { .MiddleName}")
            WP_Name_TXT.Tag = .ID
            WP_Position_TXT.Text = .Position
            WP_Company_TXT.Text = .Company_Name
            WP_Branch_TXT.Text = .Branch_Name
            IRNoWritten_LBL.Text = Format(.IRNo, "00000")
            WP_Incident_TXT.Text = .Incident_Description

            LoadListviewWritten(.IRNo, WP_RulesList, WP_SectionsList)
            Violation_TAB.SelectedIndex = 1

        End With

    End Sub

    Friend Sub LoadIRSupervisor(mPower As Employee)

        With mPower
            Supervisor_TXT.Text = String.Format($"{ .LastName}, { .FirstName} { .MiddleName}")
            Supervisor_TXT.Tag = .ID
            PositionS_TXT.Text = .Position
        End With

    End Sub

    Friend Sub LoadIRPerson(mPower As Employee)

        With mPower
            Person_TXT.Text = String.Format($"{ .LastName}, { .FirstName} { .MiddleName}")
            Person_TXT.Tag = .ID
            PositionP_TXT.Text = .Position
            Department_TXT.Text = .Branch_Name
            PositionP_TXT.Tag = .Company_Name
        End With

    End Sub


    Private Sub ClearShowCause()

        RptViewer_ShowCause.Clear()
        EmpName_TXT.Clear()
        Position_TXT.Clear()
        Company_TXT.Clear()
        Branch_TXT.Clear()
        AuditFindings_TXT.Clear()
        Location_TXT.Clear()
        _console.Clear()
        HRSupervisor_TXT.Clear()
        BusinessUnitHead_TXT.Clear()
        SentVia_TXT.Clear()
        DateSent_DTP.Value = Date.UtcNow

    End Sub

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
            New ReportParameter("paramDateofAudit", _console.Text),
            New ReportParameter("paramLocation", Location_TXT.Text),
            New ReportParameter("paramAuditFindings", AuditFindings_TXT.Text),
            New ReportParameter("paramChecked", chkStatus),
            New ReportParameter("paramHRSupervisor", HRSupervisor_TXT.Text),
            New ReportParameter("paramBusinessUnitHead", BusinessUnitHead_TXT.Text),
            New ReportParameter("paramPosition1", Position1_TXT.Text),
            New ReportParameter("paramPosition3", Position3_TXT.Text),
            New ReportParameter("paramReplySent", datesent),
            New ReportParameter("paramSCNO", SCNo_LBL.Text),
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
            New ReportParameter("paramManuallNumDaysSuspension", NumberOfDays_TXT.Text),
            New ReportParameter("paramCharges", Charges_Numeric.Text)
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

    Private Sub LoadIncidentReport()

        Dim DateIncident, DateReceive As String
        DateIncident = DateIncident_DTP.Value.ToString("MMMM dd, yyyy")
        DateReceive = DateReceive_DTP.Value.ToString("MMMM dd, yyyy")
        Dim company As String = PositionP_TXT.Tag

        RptViewer_IncidentReport.LocalReport.DataSources.Clear()

        Dim paramList As New List(Of ReportParameter) From {
            New ReportParameter("paramCompany", company, True),
            New ReportParameter("paramSupervisor", Supervisor_TXT.Text, True),
            New ReportParameter("paramPositionS", PositionS_TXT.Text, True),
            New ReportParameter("paramPerson", Person_TXT.Text),
            New ReportParameter("paramPositionP", PositionP_TXT.Text),
            New ReportParameter("paramBranch", Department_TXT.Text),
            New ReportParameter("paramDateReceived", DateReceive),
            New ReportParameter("paramLocation", IncidentLoc_TXT.Text),
            New ReportParameter("paramDateIncident", DateIncident),
            New ReportParameter("paramDescription", Description_RichText.Text),
            New ReportParameter("paramActionTaken", Action_CB.Text),
            New ReportParameter("paramIRNo", IRNo_LBL.Text),
            New ReportParameter("paramPreparedBy", PreparedBy_TXT.Text),
            New ReportParameter("paramReceivedBy", Received_TXT.Text),
            New ReportParameter("paramReviewedBy", ReviewedBy_TXT.Text)
        }

        Try
            RptViewer_IncidentReport.LocalReport.SetParameters(paramList)
            RptViewer_IncidentReport.RefreshReport()

        Catch ex As Exception
            Log_Report(ex.ToString)
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Public Function AddImage(ByRef dir As String, ByRef img As String) As System.Drawing.Image
        Dim temp As Image = Image.FromFile(dir & "\" & img & ".jpg")

        Return temp

    End Function

    Friend Sub ToPDF(ByRef Name As String, ByRef Folder As String, ByRef report As ReportViewer, ByRef letterName As String)

        Name = Name.ToString.TrimEnd()

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
                Dim newFile As New FileStream("D:\HR Records\" & Folder & "\" & Name & "\" & letterName & ".pdf", FileMode.Create)
                newFile.Write(byteViewer, 0, byteViewer.Length)
                newFile.Close()
            Else
                employee.Create()
                Dim newFile As New FileStream("D:\HR Records\" & Folder & "\" & Name & "\" & letterName & ".pdf", FileMode.Create)
                newFile.Write(byteViewer, 0, byteViewer.Length)
                newFile.Close()
            End If

        Else
            folderName.Create()
            If employee.Exists Then
                Dim newFile As New FileStream("D:\HR Records\" & Folder & "\" & Name & "\" & letterName & ".pdf", FileMode.Create)
                newFile.Write(byteViewer, 0, byteViewer.Length)
                newFile.Close()
            Else
                employee.Create()
                Dim newFile As New FileStream("D:\HR Records\" & Folder & "\" & Name & "\" & letterName & ".pdf", FileMode.Create)
                newFile.Write(byteViewer, 0, byteViewer.Length)
                newFile.Close()
            End If

        End If

        FolderPath = "D:\HR Records\" & Folder & "\" & Name & "\" & letterName & ".pdf"

        MessageBox.Show($"{Name} successfully saved to D:\HR Records\{Folder}", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Friend Sub IRSoftCopy(ByRef Name As String, ByRef Folder As String, ByRef report As ReportViewer, IRNo As String)

        Name = Name.ToString.TrimEnd()

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
                Dim newFile As New FileStream("D:\HR Records\" & Folder & "\" & Name & "\IR No. " & IRNo & ".pdf", FileMode.Create)
                newFile.Write(byteViewer, 0, byteViewer.Length)
                newFile.Close()
            Else
                employee.Create()
                Dim newFile As New FileStream("D:\HR Records\" & Folder & "\" & Name & "\IR No. " & IRNo & ".pdf", FileMode.Create)
                newFile.Write(byteViewer, 0, byteViewer.Length)
                newFile.Close()
            End If

        Else

            folderName.Create()
            If employee.Exists Then
                Dim newFile As New FileStream("D:\HR Records\" & Folder & "\" & Name & "\IR No. " & IRNo & ".pdf", FileMode.Create)
                newFile.Write(byteViewer, 0, byteViewer.Length)
                newFile.Close()
            Else
                employee.Create()
                Dim newFile As New FileStream("D:\HR Records\" & Folder & "\" & Name & "\IR No. " & IRNo & ".pdf", FileMode.Create)
                newFile.Write(byteViewer, 0, byteViewer.Length)
                newFile.Close()
            End If

        End If

        Dim str As String = "D:\HR Records\" & Folder & "\" & Name & "\IR No. " & IRNo & ".pdf"

        SaveIncidentReport(IRNo_LBL.Text, Supervisor_TXT.Tag, Person_TXT.Tag, IncidentLoc_TXT.Text, DateIncident_DTP.Value, DateReceive_DTP.Value, Action_CB.Text, Description_RichText.Text, PreparedBy_TXT.Text, Received_TXT.Text, ReviewedBy_TXT.Text, str)

        ClearIR()

        MessageBox.Show($"{Name} successfully saved to D:\HR Records\{Folder}", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub ClearIR()

        GetLastNo(IRNo_LBL, "IR_RECORDS", "IRNO")
        RptViewer_IncidentReport.Clear()
        Supervisor_TXT.Clear()
        PositionS_TXT.Clear()
        Person_TXT.Clear()
        PositionP_TXT.Clear()
        Department_TXT.Clear()
        IncidentLoc_TXT.Clear()
        Action_CB.SelectedIndex = 0
        Description_RichText.Clear()
        PreparedBy_TXT.Clear()
        Received_TXT.Clear()
        ReviewedBy_TXT.Clear()
        DateIncident_DTP.Value = Date.UtcNow
        DateReceive_DTP.Value = Date.UtcNow

    End Sub


    Private ReadOnly _console As New RichTextBox

    Private Sub Alert()
        If EmpName_TXT.Text = "" Then
            MessageBox.Show($"Please select employee name.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf IsNothing(Me.LV_Sections.FocusedItem) Then
            MessageBox.Show($"Please select section number.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Explain_datagrid.CellContentClick

        Dim grid = DirectCast(sender, DataGridView)
        Dim row As DataGridViewRow = Explain_datagrid.Rows(e.RowIndex)

        If TypeOf grid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then

            If grid.Columns(e.ColumnIndex).Name = "IR_DGV" Then
                Process.Start(row.Cells("IR_DGV").Tag)

            ElseIf grid.Columns(e.ColumnIndex).Name = "File_DGV" Then
                Process.Start(row.Cells("File_DGV").Tag)

            ElseIf grid.Columns(e.ColumnIndex).Name = "Explain_DGV" Then

                If row.Cells("Explain_DGV").Value = "Upload" Then

                    Modify_Panel.Visible = True
                    Modify_Panel.Location = New Point(124, 48)

                Else
                    Process.Start(row.Cells("Explain_DGV").Tag)
                End If


            End If

        End If
    End Sub

    Private Sub PictureBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDoubleClick

        Using openF As New OpenFileDialog()
            Dim codecs As ImageCodecInfo() = ImageCodecInfo.GetImageEncoders()
            Dim sep As String = String.Empty
            With openF
                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                .Title = "Save As Image"
                .DefaultExt = ".JPG"
                .Filter = ""
                .FilterIndex = 2
                .RestoreDirectory = True
                .FileName = "*.JPG"
            End With
            For Each c As ImageCodecInfo In codecs
                Dim codecName As String = c.CodecName.Substring(8).Replace("Codec", "Files").Trim()
                openF.Filter = $"{openF.Filter }{sep }{codecName } ({c.FilenameExtension })|{c.FilenameExtension }"
                sep = "|"
            Next
            If openF.ShowDialog = DialogResult.OK Then
                If Not Image.FromFile(openF.FileName).Size = PictureBox1.InitialImage.Size Then
                    PictureBox1.Image = Image.FromFile(openF.FileName)
                    PictureBox1.Tag = openF.FileName
                    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                Else
                    PictureBox1.Image = Image.FromFile(openF.FileName)
                    PictureBox1.Tag = openF.FileName
                    PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
                End If
                ExpalanationPath = openF.FileName
            End If
        End Using
    End Sub

    Private Sub Close_Modify_BTN_Click(sender As Object, e As EventArgs) Handles Close_Modify_BTN.Click
        Modify_Panel.Visible = False
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Check_BTN_Click(sender As Object, e As EventArgs) Handles Check_BTN.Click

        Dim i As Integer = Explain_datagrid.CurrentRow.Index
        scno_local = i

        If Not PictureBox1.Tag = Nothing Then
            imgData = ImgToByteArray(Image.FromFile(PictureBox1.Tag), ImageFormat.Jpeg)
        Else
            imgData = ImgToByteArray(PictureBox1.InitialImage, ImageFormat.Jpeg)
        End If

        LoadExplanation()

        ToPDF("IR No. " & Explain_datagrid.Item(0, i).Value & " - " & Explain_datagrid.Item(1, i).Value, "Incident Report", RptViewer_Explanation, "Explanation")

        ExplainationSave(Explain_datagrid.Item(0, i).Value, imgData, "YES", FolderPath)

        Modify_Panel.Visible = False
        PictureBox1.Image = Nothing

        PopulateExplaination(Explain_datagrid)

    End Sub

    Private Sub LoadExplanation()

        Dim Datee As Date = Date.UtcNow
        Dim dateee As String = Datee.ToString("MMMM dd, yyyy")
        Dim scnooo As String = Explain_datagrid.Item(0, scno_local).Value
        Dim name As String = Explain_datagrid.Item(1, scno_local).Value

        'Dim arrPic As Byte() = ImgToByteArray(PictureBox1.Image, ImageFormat.Jpeg)
        'Dim sIMGBASE64 As String = Convert.ToBase64String(arrPic)

        Dim Path As String = "file:///" & ExpalanationPath & ""

        RptViewer_Explanation.LocalReport.DataSources.Clear()

        Dim paramList As New List(Of ReportParameter) From {
            New ReportParameter("paramImage", Path),
            New ReportParameter("paramDate", dateee),
            New ReportParameter("paramName", name),
            New ReportParameter("paramSCNO", scnooo)
        }

        Try
            RptViewer_Explanation.LocalReport.SetParameters(paramList)
            RptViewer_Explanation.RefreshReport()

        Catch ex As Exception
            Log_Report(ex.ToString)
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Supervisor_BTN_Click(sender As Object, e As EventArgs) Handles Supervisor_BTN.Click
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
            frm.txtSearch.Tag = "IR-Supervisor"
            frm.Dock = DockStyle.Fill
            frm.BringToFront()

        Else
            frmEmployeeList.BringToFront()
        End If
        'Close()
    End Sub

    Private Sub Person_BTN_Click(sender As Object, e As EventArgs) Handles Person_BTN.Click

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
            frm.txtSearch.Tag = "IR-Person"
            frm.Dock = DockStyle.Fill
            frm.BringToFront()

        Else
            frmEmployeeList.BringToFront()
        End If

    End Sub

    Private Sub SaveIR_BTN_Click(sender As Object, e As EventArgs) Handles SaveIR_BTN.Click

        If Not Supervisor_TXT.Text = "" Or Not Person_TXT.Text = "" Then

            IRSoftCopy("IR No. " & IRNo_LBL.Text & " - " & Person_TXT.Text, "Incident Report", RptViewer_IncidentReport, IRNo_LBL.Text)

        Else
            MessageBox.Show($"Click Preview before saving", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub PreviewIR_BTN_Click(sender As Object, e As EventArgs) Handles PreviewIR_BTN.Click

        If Supervisor_TXT.Text = "" Or Person_TXT.Text = "" Then
            MessageBox.Show($"Please Complete employee's name.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            LoadIncidentReport()
        End If
    End Sub

    Private Sub ClearIR_BTN_Click(sender As Object, e As EventArgs) Handles ClearIR_BTN.Click
        ClearIR()
    End Sub


    Private Sub SearchEMP_BTN_Click_2(sender As Object, e As EventArgs) Handles SearchEMP_BTN.Click

        If frmIRList Is Nothing Then
            Dim frm As New frmIRList With {
                .MdiParent = frmMainForm
            }
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            frm.Show()
            frm.txtSearch.Tag = "ShowCause"
            frm.Dock = DockStyle.Fill
            frm.BringToFront()

        Else
            frmIRList.BringToFront()
        End If

        'Close()
    End Sub


    Private Sub LV_Rules_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles LV_Rules.SelectedIndexChanged
        Dim tmp As New Lists
        LV_Sections.Items.Clear()
        For Each i As ListViewItem In LV_Rules.SelectedItems
            If i.SubItems(0).Text = "RULE I" Then
                For Each item In tmp.Rule1Sections()
                    Dim lvitem As ListViewItem = LV_Sections.Items.Add(item.Section)
                    lvitem.SubItems.Add(item.NatureOfOffenses)
                Next
            ElseIf i.SubItems(0).Text = "RULE II" Then
                For Each item In tmp.Rule2Sections()
                    Dim lvitem As ListViewItem = LV_Sections.Items.Add(item.Section)
                    lvitem.SubItems.Add(item.NatureOfOffenses)
                Next
            ElseIf i.SubItems(0).Text = "RULE III" Then
                For Each item In tmp.Rule3Sections()
                    Dim lvitem As ListViewItem = LV_Sections.Items.Add(item.Section)
                    lvitem.SubItems.Add(item.NatureOfOffenses)
                Next
            ElseIf i.SubItems(0).Text = "RULE IV" Then
                For Each item In tmp.Rule4Sections()
                    Dim lvitem As ListViewItem = LV_Sections.Items.Add(item.Section)
                    lvitem.SubItems.Add(item.NatureOfOffenses)
                Next
            ElseIf i.SubItems(0).Text = "RULE V" Then
                For Each item In tmp.Rule5Sections()
                    Dim lvitem As ListViewItem = LV_Sections.Items.Add(item.Section)
                    lvitem.SubItems.Add(item.NatureOfOffenses)
                Next
            ElseIf i.SubItems(0).Text = "RULE VI" Then
                For Each item In tmp.Rule6Sections()
                    Dim lvitem As ListViewItem = LV_Sections.Items.Add(item.Section)
                    lvitem.SubItems.Add(item.NatureOfOffenses)
                Next

            End If
        Next
    End Sub

    Private Sub FromAuditDate_DTP_CloseUp(sender As Object, e As EventArgs) Handles FromAuditDate_DTP.CloseUp
        _console.AppendText(FromAuditDate_DTP.Value & ", ")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        _console.Clear()
    End Sub

    Private Sub PS1_Btn_Click(sender As Object, e As EventArgs) Handles PS1_Btn.Click
        Position1_TXT.ReadOnly = False
    End Sub

    Private Sub PS3_Btn_Click(sender As Object, e As EventArgs) Handles PS3_Btn.Click
        Position3_TXT.ReadOnly = False
    End Sub

    Private Sub Optional_CHK_CheckedChanged(sender As Object, e As EventArgs) Handles Optional_CHK.CheckedChanged
        If Optional_CHK.Checked Then
            Optional_Group.Enabled = True
        Else
            Optional_Group.Enabled = False
        End If
    End Sub

    Private Sub OK_BTN_Click_1(sender As Object, e As EventArgs) Handles OK_BTN.Click
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


    Private Sub Save_BTN_Click(sender As Object, e As EventArgs) Handles Save_BTN.Click
        If Not EmpName_TXT.Text = "" Then

            ToPDF("IR No. " & SCNo_LBL.Text & " - " & EmpName_TXT.Text, "Incident Report", RptViewer_ShowCause, "Show Cause Notice")

            For Each itemsec As ListViewItem In LV_Sections.SelectedItems
                SaveRuleNoSectionnO(EmpName_TXT.Tag, LV_Rules.FocusedItem.SubItems(0).Text, itemsec.SubItems(0).Text, SCNo_LBL.Text)
            Next

            SaveShowCause(EmpName_TXT.Tag, DateSent_DTP.Value, DateSent_DTP.Value.AddDays(5), FolderPath, "NO", Company_TXT.Text, SCNo_LBL.Text)

            ClearShowCause()

            'SCPendings(frmMainForm.PendingNo_LBL)

        Else
            MessageBox.Show($"Click Preview before saving", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub AuditFindings_TXT_TextChanged(sender As Object, e As EventArgs) Handles AuditFindings_TXT.TextChanged
        Alert()
    End Sub

    Private Sub Location_TXT_TextChanged(sender As Object, e As EventArgs) Handles Location_TXT.TextChanged
        Alert()
    End Sub

    Private Sub LV_Rules_MouseClick(sender As Object, e As MouseEventArgs) Handles LV_Rules.MouseClick

        If EmpName_TXT.Text = "" Then
            MessageBox.Show($"Please select employee name.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub CorrectiveWindow_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CorrectiveWindow.SelectedIndexChanged

        If CorrectiveWindow.SelectedIndex = 2 Then

            PopulateExplaination(Explain_datagrid)

        End If

    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If IsEnter(e) Then btnSearch.PerformClick()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        LoadExplainSearchName(txtSearch.Text, Explain_datagrid)

    End Sub

    Private Sub WP_OK_BTN_Click_1(sender As Object, e As EventArgs) Handles WP_OK_BTN.Click
        If WP_Name_TXT.Text = "" Then
            If WP_Name_TXT.Text = "" Then
                MessageBox.Show($"Please select employee name.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            LoadWrittenReprimandReport()
        End If
    End Sub

    Private Sub WP_Save_Btn_Click_1(sender As Object, e As EventArgs) Handles WP_Save_Btn.Click

        If Not WP_Name_TXT.Text = "" Then
            ToPDF(WP_Name_TXT.Text, "Written Reprimand Notice", RptViewer_WrittenReprimand, "Written Reprimand Notice")
        Else
            MessageBox.Show($"Click Preview before saving", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub NoDaysSuspend_CB_CheckedChanged(sender As Object, e As EventArgs) Handles NoDaysSuspend_CB.CheckedChanged
        If NoDaysSuspend_CB.Checked = True Then
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

    Private Sub WP_PS1_Btn_Click_1(sender As Object, e As EventArgs) Handles WP_PS1_Btn.Click
        WP_Position1_TXT.ReadOnly = False
    End Sub

    Private Sub WP_PS2_Btn_Click_1(sender As Object, e As EventArgs) Handles WP_PS2_Btn.Click
        WP_Position2_TXT.ReadOnly = False
    End Sub

    Private Sub WP_PS3_Btn_Click_1(sender As Object, e As EventArgs) Handles WP_PS3_Btn.Click
        WP_Position3_TXT.ReadOnly = False
    End Sub

    Private Sub WP_PS4_Btn_Click_1(sender As Object, e As EventArgs) Handles WP_PS4_Btn.Click
        WP_Position4_TXT.ReadOnly = False
    End Sub

    Private Sub WW_RBTN_CheckedChanged_1(sender As Object, e As EventArgs) Handles WW_RBTN.CheckedChanged
        If WW_RBTN.Checked = True Then
            NoDaysSuspend_CB.Checked = False
            NumberOfDays_TXT.Value = 0
        End If
    End Sub

    Private Sub TwoDays_RBTN_CheckedChanged_1(sender As Object, e As EventArgs) Handles TwoDays_RBTN.CheckedChanged
        If TwoDays_RBTN.Checked = True Then
            NoDaysSuspend_CB.Checked = False
            NumberOfDays_TXT.Value = 0
        End If
    End Sub

    Private Sub FourDays_RBTN_CheckedChanged_1(sender As Object, e As EventArgs) Handles FourDays_RBTN.CheckedChanged
        If FourDays_RBTN.Checked = True Then
            NoDaysSuspend_CB.Checked = False
            NumberOfDays_TXT.Value = 0
        End If
    End Sub

    Private Sub SixDays_RBTN_CheckedChanged_1(sender As Object, e As EventArgs) Handles SixDays_RBTN.CheckedChanged
        If SixDays_RBTN.Checked = True Then
            NoDaysSuspend_CB.Checked = False
            NumberOfDays_TXT.Value = 0
        End If
    End Sub

    Private Sub Audit_CHK_CheckedChanged(sender As Object, e As EventArgs) Handles Audit_CHK.CheckedChanged
        If Audit_CHK.Checked = True Then
            chkStatus = 1
        ElseIf Audit_CHK.Checked = False Then
            chkStatus = 0
        End If
    End Sub

    Private Sub WP_RulesList_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles WP_RulesList.SelectedIndexChanged
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


    Private Sub SearchWP_EMP_BTN_Click(sender As Object, e As EventArgs) Handles SearchWP_EMP_BTN.Click

        If frmSCList Is Nothing Then
            Dim frm As New frmSCList With {
                .MdiParent = frmMainForm
            }
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            frm.Show()
            frm.txtSearch.Tag = "Written"
            frm.Dock = DockStyle.Fill
            frm.BringToFront()

        Else
            frmSCList.BringToFront()
        End If

    End Sub

    Private Sub IRNo_BTN_Click(sender As Object, e As EventArgs) Handles IRNo_BTN.Click
        LoadExplainSearchIRNO(IRNo_TXT.Text, Explain_datagrid)
    End Sub

    Private Sub IRNo_TXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IRNo_TXT.KeyPress
        If IsEnter(e) Then IRNo_BTN.PerformClick()
    End Sub

    Private Sub AmountCharges_CB_CheckedChanged(sender As Object, e As EventArgs) Handles AmountCharges_CB.CheckedChanged
        If AmountCharges_CB.Checked = True Then
            Charges_Numeric.Enabled = True
            WW_RBTN.Checked = False
            TwoDays_RBTN.Checked = False
            FourDays_RBTN.Checked = False
            SixDays_RBTN.Checked = False
            'chkStatus = 0
        Else
            Charges_Numeric.Enabled = False
        End If
    End Sub
End Class