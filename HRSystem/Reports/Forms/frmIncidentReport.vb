﻿Imports System.Drawing.Imaging
Imports System.IO
Imports FirebirdSql.Data.FirebirdClient


Public Class frmIncidentReport

    Friend isPage1 As Integer
    Dim chkStatus As Integer
    Dim dateIssued As String = Now.ToString("MMMM dd, yyyy")
    Dim imgData As Byte()
    Dim FolderPath As String
    Dim ExpalanationPath As String
    Dim NoOfDaysSuspend As Integer

    Private ReadOnly _console, _corrective As New RichTextBox

    'Dim Sectionlist As New ArrayList

    Private Sub frmIncidentReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If ThisHasRow("IR_RECORDS") Then
            GetLastNo(IRNo_LBL, "IR_RECORDS", "IRNO")
        End If

        _console.Clear()
        _corrective.Clear()

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
            Position_TXT.Tag = .Status
            RuleViolated_GB.Tag = .RuleViolated
            SCRuleNo_LBL.Text = .RuleViolated & " " & .RuleDescription
            SC_IncidentDate_RichB.Text = .IncidentDate '
            Location_TXT.Text = .IncidentLocation
            AuditFindings_TXT.Text = .Incident_Description

            LoadSectionList()
        End With

    End Sub

    Friend Sub LoadEmployeeWritten(mPower As Employee, Optional WrittenORCorrective As String = "")

        With mPower


            If WrittenORCorrective = "CORRECTIVE" Then

                Coo_Name_TXT.Text = String.Format($"{ .LastName}, { .FirstName} { .MiddleName}")
                Coo_Name_TXT.Tag = .ID
                Coo_Position_TXT.Text = .Position
                Coo_Position_TXT.Tag = .Status
                Coo_Company_TXT.Text = .Company_Name
                Coo_Branch_TXT.Text = .Branch_Name

                IRNoCOO_LBL.Text = Format(.IRNo, "00000")
                Coo_Description_RB.Text = .Incident_Description
                Coo_DateIncident_RB.Text = .IncidentDate
                Coo_SCDate_LBL.Text = .SCDate.ToString("MMMM dd, yyyy")
                Coo_WRDate_LBL.Text = .WRDate.ToString("MMMM dd, yyyy")
                Coo_Violation.Text = .Violation
                Coo_NoOfDays_Numeric.Text = .NoOFDaysSuspend

                LoadListviewWritten(.IRNo, Coo_SectionList, Coo_Rule_LBL)  'SELECTING 

            Else

                WP_Name_TXT.Text = String.Format($"{ .LastName}, { .FirstName} { .MiddleName}")
                WP_Name_TXT.Tag = .ID
                WP_Position_TXT.Text = .Position
                WP_Company_TXT.Text = .Company_Name
                WP_Branch_TXT.Text = .Branch_Name
                IRNoWritten_LBL.Text = Format(.IRNo, "00000")
                WP_Incident_TXT.Text = .Incident_Description
                WP_Position_TXT.Tag = .Status
                WP_DateIncident_DTP.Text = .IncidentDate
                WR_Violation_RichB.Text = .Violation

                LoadListviewWritten(.IRNo, WP_SectionsList, WPRule_LBL)  'SELECTING 

            End If

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
            Department_TXT.Tag = .Status
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
        _corrective.Clear()
        HRSupervisor_TXT.Clear()
        BusinessUnitHead_TXT.Clear()
        SentVia_TXT.Clear()
        DateSent_DTP.Value = Date.UtcNow
        SCRuleNo_LBL.Text = "RULE"
        LV_Sections.Clear()
        SC_IncidentDate_RichB.Clear()
        SCViolation_RichB.Clear()
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
            New ReportParameter("paramDateofAudit", SC_IncidentDate_RichB.Text),
            New ReportParameter("paramLocation", Location_TXT.Text),
            New ReportParameter("paramAuditFindings", SCViolation_RichB.Text),
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
        ElseIf AmountCharges_CB.Checked = True Then
            chkStatus = 5
        End If

        Dim AMOUNT As String
        AMOUNT = Decimal.Parse(Charges_Numeric.Text).ToString("##,###0.00")

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
            New ReportParameter("paramECSNo", ECSNo_TXT.Text),
            New ReportParameter("paramCharges", AMOUNT),
            New ReportParameter("paramMonths", AmountPerPayroll_TXT.Text),
            New ReportParameter("paramSCNO", IRNoWritten_LBL.Text)
        }

        Try
            For Each itemsec As ListViewItem In WP_SectionsList.Items
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

    Function NumberToText(ByVal n As Integer) As String

        Select Case n
            Case 0
                Return ""

            Case 1 To 19
                Dim arr() As String = {"One", "Two", "Three", "Four", "Five", "Six", "Seven",
                                        "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen",
                                          "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                Return arr(n - 1) & " "

            Case Else
                Return n
        End Select

    End Function

    Private Sub LoadCorrectiveAction()

        Dim tmp As New Lists
        Dim tbl As New Rules_SectionsDataSet.RS_DataTableDataTable

        Dim word As String = NumberToText(Coo_NoOfDays_Numeric.Text) & "(" & Coo_NoOfDays_Numeric.Text & ")"
        Console.WriteLine("AAAAA " & word)

        If _corrective.TextLength <> 0 Then
            _corrective.Text = _corrective.Text & Now.ToString("yyyy")
        End If

        RptViewer_Corrective.LocalReport.DataSources.Clear()

        Dim paramList As New List(Of ReportParameter) From {
            New ReportParameter("paramName", Coo_Name_TXT.Text),
            New ReportParameter("paramCompany", Coo_Company_TXT.Text),
            New ReportParameter("paramDateToday", dateIssued),
            New ReportParameter("paramViolation", Coo_Violation.Text),
            New ReportParameter("paramRule", Coo_Rule_LBL.Text),
            New ReportParameter("paramSCDate", Coo_SCDate_LBL.Text),
            New ReportParameter("paramWRDate", Coo_WRDate_LBL.Text),
            New ReportParameter("paramNoOfSuspension", word),
            New ReportParameter("paramDateSuspend", _corrective.Text),
            New ReportParameter("paramPreparedName", Coo_Pre_Name_TXT.Text),
            New ReportParameter("paramPreparedPos", Coo_Pre_Pos_TXT.Text),
            New ReportParameter("paramRevByName1", Coo_Rev_Name1_TXT.Text),
            New ReportParameter("paramRevPos1", Coo_Rev_Pos1_TXT.Text),
            New ReportParameter("paramRevByName2", Coo_Rev_Name2_TXT.Text),
            New ReportParameter("paramRevPos2", Coo_Rev_Pos2_TXT.Text),
            New ReportParameter("paramNotedBy", Coo_Noted_Name_TXT.Text),
            New ReportParameter("paramNotedPos", Coo_Noted_Pos_TXT.Text)
        }

        Try
            For Each itemsec As ListViewItem In Coo_SectionList.Items
                Dim sql As String = "select * from TBL_RULESECTIONLIST where SECTION = '" & itemsec.SubItems(0).Text & "';"
                Using adapter As New FbDataAdapter(sql, con)
                    adapter.Fill(tbl)
                End Using
            Next

            Dim datasource As New ReportDataSource With
            {
                .Name = "Coo_DataSet1",
                .Value = tbl
            }
            RptViewer_Corrective.LocalReport.DataSources.Add(datasource)
            RptViewer_Corrective.LocalReport.SetParameters(paramList)

            RptViewer_Corrective.RefreshReport()
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
            New ReportParameter("paramDateIncident", _console.Text),
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

        SaveIncidentReport(IRNo_LBL.Text, Supervisor_TXT.Tag, Person_TXT.Tag, IncidentLoc_TXT.Text, _console.Text, DateReceive_DTP.Value, Action_CB.Tag, Description_RichText.Text, PreparedBy_TXT.Text, Received_TXT.Text, ReviewedBy_TXT.Text, str)

        SaveTRANSACTIONHistory(frmMainForm.UserName_LBL.Text, Person_TXT.Text, "Incident Report IR No. " & IRNo_LBL.Text, Department_TXT.Text, Department_TXT.Tag, PositionP_TXT.Text)

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

        _console.Clear()

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

        If Not PictureBox1.Tag = Nothing Then
            imgData = ImgToByteArray(Image.FromFile(PictureBox1.Tag), ImageFormat.Jpeg)
        Else
            imgData = ImgToByteArray(PictureBox1.InitialImage, ImageFormat.Jpeg)
        End If

        LoadUploadToReportViewer(Explain_datagrid.Item(0, i).Value, Explain_datagrid.Item(1, i).Value, RptViewer_Explanation, "Explanation")

        ToPDF("IR No. " & Explain_datagrid.Item(0, i).Value & " - " & Explain_datagrid.Item(1, i).Value, "Incident Report", RptViewer_Explanation, "Explanation")

        ExplainationSave(Explain_datagrid.Item(0, i).Value, imgData, "DONE", FolderPath)

        SaveTRANSACTIONHistory(frmMainForm.UserName_LBL.Text, Explain_datagrid.Item(1, i).Value, "Uploaded Explanation for IR No. " & Explain_datagrid.Item(0, i).Value, "-", "-", "-")

        Modify_Panel.Visible = False
        PictureBox1.Image = Nothing

        PopulateExplaination(Explain_datagrid)

    End Sub

    Private Sub LoadUploadToReportViewer(scnooo As String, name As String, report As ReportViewer, headerName As String)

        Dim Datee As Date = Date.UtcNow
        Dim dateee As String = Datee.ToString("MMMM dd, yyyy")

        'Dim arrPic As Byte() = ImgToByteArray(PictureBox1.Image, ImageFormat.Jpeg)
        'Dim sIMGBASE64 As String = Convert.ToBase64String(arrPic)

        Dim Path As String = "file:///" & ExpalanationPath & ""

        report.LocalReport.DataSources.Clear()

        Dim paramList As New List(Of ReportParameter) From {
            New ReportParameter("paramHeaderName", headerName),
            New ReportParameter("paramImage", Path),
            New ReportParameter("paramDate", dateee),
            New ReportParameter("paramName", name),
            New ReportParameter("paramSCNO", scnooo)
        }

        Try
            report.LocalReport.SetParameters(paramList)
            report.RefreshReport()

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

    Private Sub LoadSectionList()
        Dim tmp As New Lists

        LV_Sections.Items.Clear()

        If RuleViolated_GB.Tag = "RULE I" Then
            For Each item In tmp.Rule1Sections()
                Dim lvitem As ListViewItem = LV_Sections.Items.Add(item.Section)
                lvitem.SubItems.Add(item.NatureOfOffenses)
            Next
        ElseIf RuleViolated_GB.Tag = "RULE II" Then
            For Each item In tmp.Rule2Sections()
                Dim lvitem As ListViewItem = LV_Sections.Items.Add(item.Section)
                lvitem.SubItems.Add(item.NatureOfOffenses)
            Next
        ElseIf RuleViolated_GB.Tag = "RULE III" Then
            For Each item In tmp.Rule3Sections()
                Dim lvitem As ListViewItem = LV_Sections.Items.Add(item.Section)
                lvitem.SubItems.Add(item.NatureOfOffenses)
            Next
        ElseIf RuleViolated_GB.Tag = "RULE IV" Then
            For Each item In tmp.Rule4Sections()
                Dim lvitem As ListViewItem = LV_Sections.Items.Add(item.Section)
                lvitem.SubItems.Add(item.NatureOfOffenses)
            Next
        ElseIf RuleViolated_GB.Tag = "RULE V" Then
            For Each item In tmp.Rule5Sections()
                Dim lvitem As ListViewItem = LV_Sections.Items.Add(item.Section)
                lvitem.SubItems.Add(item.NatureOfOffenses)
            Next
        ElseIf RuleViolated_GB.Tag = "RULE VI" Then
            For Each item In tmp.Rule6Sections()
                Dim lvitem As ListViewItem = LV_Sections.Items.Add(item.Section)
                lvitem.SubItems.Add(item.NatureOfOffenses)
            Next

        End If
    End Sub

    Private Sub LV_Rules_SelectedIndexChanged_1(sender As Object, e As EventArgs)

        Dim tmp As New Lists

        LV_Sections.Items.Clear()

        If RuleViolated_GB.Tag = "RULE I" Then
            For Each item In tmp.Rule1Sections()
                Dim lvitem As ListViewItem = LV_Sections.Items.Add(item.Section)
                lvitem.SubItems.Add(item.NatureOfOffenses)
            Next
        ElseIf RuleViolated_GB.Tag = "RULE II" Then
            For Each item In tmp.Rule2Sections()
                Dim lvitem As ListViewItem = LV_Sections.Items.Add(item.Section)
                lvitem.SubItems.Add(item.NatureOfOffenses)
            Next
        ElseIf RuleViolated_GB.Tag = "RULE III" Then
            For Each item In tmp.Rule3Sections()
                Dim lvitem As ListViewItem = LV_Sections.Items.Add(item.Section)
                lvitem.SubItems.Add(item.NatureOfOffenses)
            Next
        ElseIf RuleViolated_GB.Tag = "RULE IV" Then
            For Each item In tmp.Rule4Sections()
                Dim lvitem As ListViewItem = LV_Sections.Items.Add(item.Section)
                lvitem.SubItems.Add(item.NatureOfOffenses)
            Next
        ElseIf RuleViolated_GB.Tag = "RULE V" Then
            For Each item In tmp.Rule5Sections()
                Dim lvitem As ListViewItem = LV_Sections.Items.Add(item.Section)
                lvitem.SubItems.Add(item.NatureOfOffenses)
            Next
        ElseIf RuleViolated_GB.Tag = "RULE VI" Then
            For Each item In tmp.Rule6Sections()
                Dim lvitem As ListViewItem = LV_Sections.Items.Add(item.Section)
                lvitem.SubItems.Add(item.NatureOfOffenses)
            Next

        End If

        'For Each i As ListViewItem In LV_Rules.SelectedItems
        '    If i.SubItems(0).Text = "RULE I" Then
        '        For Each item In tmp.Rule1Sections()
        '            Dim lvitem As ListViewItem = LV_Sections.Items.Add(item.Section)
        '            lvitem.SubItems.Add(item.NatureOfOffenses)
        '        Next
        '    ElseIf i.SubItems(0).Text = "RULE II" Then
        '        For Each item In tmp.Rule2Sections()
        '            Dim lvitem As ListViewItem = LV_Sections.Items.Add(item.Section)
        '            lvitem.SubItems.Add(item.NatureOfOffenses)
        '        Next
        '    ElseIf i.SubItems(0).Text = "RULE III" Then
        '        For Each item In tmp.Rule3Sections()
        '            Dim lvitem As ListViewItem = LV_Sections.Items.Add(item.Section)
        '            lvitem.SubItems.Add(item.NatureOfOffenses)
        '        Next
        '    ElseIf i.SubItems(0).Text = "RULE IV" Then
        '        For Each item In tmp.Rule4Sections()
        '            Dim lvitem As ListViewItem = LV_Sections.Items.Add(item.Section)
        '            lvitem.SubItems.Add(item.NatureOfOffenses)
        '        Next
        '    ElseIf i.SubItems(0).Text = "RULE V" Then
        '        For Each item In tmp.Rule5Sections()
        '            Dim lvitem As ListViewItem = LV_Sections.Items.Add(item.Section)
        '            lvitem.SubItems.Add(item.NatureOfOffenses)
        '        Next
        '    ElseIf i.SubItems(0).Text = "RULE VI" Then
        '        For Each item In tmp.Rule6Sections()
        '            Dim lvitem As ListViewItem = LV_Sections.Items.Add(item.Section)
        '            lvitem.SubItems.Add(item.NatureOfOffenses)
        '        Next

        '    End If
        'Next
    End Sub

    Private Sub PS1_Btn_Click(sender As Object, e As EventArgs) Handles PS1_Btn.Click
        Position1_TXT.ReadOnly = False
    End Sub

    Private Sub PS3_Btn_Click(sender As Object, e As EventArgs) Handles PS3_Btn.Click
        Position3_TXT.ReadOnly = False
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
                SaveRuleNoSectionnO(EmpName_TXT.Tag, RuleViolated_GB.Tag, itemsec.SubItems(0).Text, SCNo_LBL.Text)
            Next

            SaveShowCause(EmpName_TXT.Tag, DateSent_DTP.Value, DateSent_DTP.Value.AddDays(5), FolderPath, "PENDING", Company_TXT.Text, SCNo_LBL.Text, SCViolation_RichB.Text)

            SaveTRANSACTIONHistory(frmMainForm.UserName_LBL.Text, EmpName_TXT.Text, "Show Cause Notice IR No. " & SCNo_LBL.Text, Branch_TXT.Text, Position_TXT.Tag, Position_TXT.Text)

            ClearShowCause()

            'SCPendings(frmMainForm.PendingNo_LBL)

        Else
            MessageBox.Show($"Click Preview before saving", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub LV_Rules_MouseClick(sender As Object, e As MouseEventArgs)

        If EmpName_TXT.Text = "" Then
            MessageBox.Show($"Please select employee name.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub CorrectiveWindow_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CorrectiveWindow.SelectedIndexChanged

        If CorrectiveWindow.SelectedIndex = 2 Then

            SearchBy_Combo.SelectedIndex = 0
            Status_Combo.SelectedIndex = 0

            PopulateExplaination(Explain_datagrid)

        ElseIf CorrectiveWindow.SelectedIndex = 4 Then

            SearchAck_Combo.SelectedIndex = 0
            StatusACK_Combo.SelectedIndex = 0


        ElseIf CorrectiveWindow.SelectedIndex = 6 Then

            Coo_Search_CB.SelectedIndex = 0

            PopulateACTION(ACTION_Datagrid)

        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)

        LoadExplainSearchName(txtSearch.Text, Explain_datagrid)

    End Sub

    Private Sub WP_OK_BTN_Click_1(sender As Object, e As EventArgs) Handles WP_OK_BTN.Click

        If Not isValid() Then Exit Sub

        LoadWrittenReprimandReport()

    End Sub

    Private Function isValid()

        Dim num1 = Val(ECSNo_TXT.Text)
        Dim num2 = Val(Charges_Numeric.Text)
        Dim num3 = Val(AmountPerPayroll_TXT.Text)
        Dim num4 = Val(NoOFPayroll_TXT.Text)

        If String.IsNullOrEmpty(WP_Name_TXT.Text) Then
            MessageBox.Show($"Please select employee name.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False

        ElseIf Not Double.TryParse(ECSNo_TXT.Text, num1) Or String.IsNullOrEmpty(ECSNo_TXT.Text) Then
            ECSNo_TXT.Region = New Region(New Rectangle(2, 2, ECSNo_TXT.Width - 4, ECSNo_TXT.Height - 4))
            Return False

        ElseIf Not Double.TryParse(Charges_Numeric.Text, num2) Or String.IsNullOrEmpty(Charges_Numeric.Text) Then
            Charges_Numeric.Region = New Region(New Rectangle(2, 2, Charges_Numeric.Width - 4, Charges_Numeric.Height - 4))
            Return False

        ElseIf Not Double.TryParse(AmountPerPayroll_TXT.Text, num3) Or String.IsNullOrEmpty(AmountPerPayroll_TXT.Text) Then
            AmountPerPayroll_TXT.Region = New Region(New Rectangle(2, 2, AmountPerPayroll_TXT.Width - 4, AmountPerPayroll_TXT.Height - 4))
            Return False

        ElseIf Not Double.TryParse(NoOFPayroll_TXT.Text, num4) Or String.IsNullOrEmpty(NoOFPayroll_TXT.Text) Then
            NoOFPayroll_TXT.Region = New Region(New Rectangle(2, 2, NoOFPayroll_TXT.Width - 4, NoOFPayroll_TXT.Height - 4))
            Return False
        End If

        Return True
    End Function

    Private Sub WP_Save_Btn_Click_1(sender As Object, e As EventArgs) Handles WP_Save_Btn.Click

        If Not WP_Name_TXT.Text = "" Then

            ToPDF("IR No. " & IRNoWritten_LBL.Text & " - " & WP_Name_TXT.Text, "Incident Report", RptViewer_WrittenReprimand, "Written Reprimand Notice")

            SaveWrittenReprimand(WP_Name_TXT.Tag, NoOfDaysSuspend, WP_Emp_Rel_TXT.Text, FolderPath, IRNoWritten_LBL.Text, Date.Now, "PENDING")

            SaveTRANSACTIONHistory(frmMainForm.UserName_LBL.Text, WP_Name_TXT.Text, "Written Reprimand for IR No. " & IRNoWritten_LBL.Text, WP_Branch_TXT.Text, WP_Position_TXT.Tag, WP_Position_TXT.Text)

            If Not ECSNo_TXT.Text = "" And Not Charges_Numeric.Text = "" And Not AmountPerPayroll_TXT.Text = "" Then

                SaveECS(IRNoWritten_LBL.Text, WP_Name_TXT.Tag, Date.Now, ECSNo_TXT.Text, Charges_Numeric.Text, AmountPerPayroll_TXT.Text)

            End If

            ClearWRITTEN()

        Else
            MessageBox.Show($"Click Preview before saving", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub ClearWRITTEN()

        RptViewer_WrittenReprimand.Clear()
        WP_Name_TXT.Clear()
        WP_Position_TXT.Clear()
        WP_Company_TXT.Clear()
        WP_Branch_TXT.Clear()
        WP_SectionsList.Clear()
        WPRule_LBL.Text = "Rule"
        WP_Incident_TXT.Clear()
        WP_DateIncident_DTP.Clear()

        WW_RBTN.Checked = False
        TwoDays_RBTN.Checked = False
        FourDays_RBTN.Checked = False
        SixDays_RBTN.Checked = False

        NoDaysSuspend_CB.Checked = False
        AmountCharges_CB.Checked = False

        WP_Emp_Rel_TXT.Clear()
        WP_HR_Sup_TXT.Clear()
        WP_Officer_Incharge_TXT.Clear()
        WP_BusinessHead_TXT.Clear()

    End Sub

    Private Sub ClearCorrective()
        IRNoCOO_LBL.Text = ""
        RptViewer_Corrective.Clear()
        Coo_Name_TXT.Clear()
        Coo_Position_TXT.Clear()
        Coo_Company_TXT.Clear()
        Coo_Branch_TXT.Clear()
        Coo_SectionList.Clear()
        Coo_Rule_LBL.Text = "Rule"
        Coo_Description_RB.Clear()
        Coo_DateIncident_RB.Clear()

        Coo_Violation.Clear()
        Coo_SCDate_LBL.Text = "-"
        Coo_WRDate_LBL.Text = "-"

        Coo_NoOfDays_Numeric.Text = "-"
        _corrective.Clear()

        Coo_Pre_Name_TXT.Clear()
        Coo_Rev_Name1_TXT.Clear()

        Coo_Rev_Name2_TXT.Clear()
        Coo_Noted_Name_TXT.Clear()

    End Sub

    Private Sub NoDaysSuspend_CB_CheckedChanged(sender As Object, e As EventArgs) Handles NoDaysSuspend_CB.CheckedChanged
        If NoDaysSuspend_CB.Checked = True Then
            NumberOfDays_TXT.Enabled = True
            WW_RBTN.Checked = False
            TwoDays_RBTN.Checked = False
            FourDays_RBTN.Checked = False
            SixDays_RBTN.Checked = False
            chkStatus = 0

            AmountCharges_CB.Checked = False
            ECS_GB.Visible = False
            Charges_Numeric.Text = 0
            ECSNo_TXT.Text = 0
            AmountPerPayroll_TXT.Text = 0
        Else
            NumberOfDays_TXT.Text = 0
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
            NoOfDaysSuspend = 2

            AmountCharges_CB.Checked = False
            Charges_Numeric.Text = 0
        Else
            NoOfDaysSuspend = 0
        End If
    End Sub

    Private Sub FourDays_RBTN_CheckedChanged_1(sender As Object, e As EventArgs) Handles FourDays_RBTN.CheckedChanged
        If FourDays_RBTN.Checked = True Then
            NoDaysSuspend_CB.Checked = False
            NumberOfDays_TXT.Value = 0
            NoOfDaysSuspend = 4

            AmountCharges_CB.Checked = False
            Charges_Numeric.Text = 0
        Else
            NoOfDaysSuspend = 0
        End If
    End Sub

    Private Sub SixDays_RBTN_CheckedChanged_1(sender As Object, e As EventArgs) Handles SixDays_RBTN.CheckedChanged
        If SixDays_RBTN.Checked = True Then
            NoDaysSuspend_CB.Checked = False
            NumberOfDays_TXT.Value = 0
            NoOfDaysSuspend = 6


            AmountCharges_CB.Checked = False
            Charges_Numeric.Text = 0
        Else
            NoOfDaysSuspend = 0
        End If
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

    Private Sub AmountCharges_CB_CheckedChanged(sender As Object, e As EventArgs) Handles AmountCharges_CB.CheckedChanged

        If AmountCharges_CB.Checked = True Then
            WW_RBTN.Checked = False
            TwoDays_RBTN.Checked = False
            FourDays_RBTN.Checked = False
            SixDays_RBTN.Checked = False
            ECS_GB.Visible = True
            NoDaysSuspend_CB.Checked = False
            chkStatus = 0

            ECSNo_TXT.Region = New Region(New Rectangle(2, 2, ECSNo_TXT.Width - 4, ECSNo_TXT.Height - 4))
            Charges_Numeric.Region = New Region(New Rectangle(2, 2, Charges_Numeric.Width - 4, Charges_Numeric.Height - 4))

        Else

            ECSNo_TXT.Region = Nothing
            Charges_Numeric.Region = Nothing

            ECS_GB.Visible = False
            Charges_Numeric.Text = 0
        End If

    End Sub

    Private Sub NumberOfDays_TXT_ValueChanged(sender As Object, e As EventArgs) Handles NumberOfDays_TXT.ValueChanged

        NoOfDaysSuspend = NumberOfDays_TXT.Text

    End Sub

    Private Sub Action_CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Action_CB.SelectedIndexChanged
        If Action_CB.SelectedIndex = 1 Then

            Action_CB.Tag = "RULE I"

        ElseIf Action_CB.SelectedIndex = 2 Then

            Action_CB.Tag = "RULE II"

        ElseIf Action_CB.SelectedIndex = 3 Then

            Action_CB.Tag = "RULE III"

        ElseIf Action_CB.SelectedIndex = 4 Then

            Action_CB.Tag = "RULE IV"

        ElseIf Action_CB.SelectedIndex = 5 Then

            Action_CB.Tag = "RULE V"

        ElseIf Action_CB.SelectedIndex = 6 Then

            Action_CB.Tag = "RULE VI"

        End If
    End Sub

    Private Sub DateIncident_DTP_CloseUp(sender As Object, e As EventArgs) Handles DateIncident_DTP.CloseUp
        _console.AppendText(DateIncident_DTP.Value.ToString("MMMM dd, yyyy") & ", ")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        _console.Clear()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SearchBy_Combo.SelectedIndexChanged

        If SearchBy_Combo.SelectedIndex = 0 Then
            LoadExplainSearchName(txtSearch.Text, Explain_datagrid)
        Else
            LoadExplainSearchIRNO(txtSearch.Text, Explain_datagrid)
        End If

    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress

        If IsEnter(e) Then

            If SearchBy_Combo.SelectedIndex = 0 Then
                LoadExplainSearchName(txtSearch.Text, Explain_datagrid)
            Else
                LoadExplainSearchIRNO(txtSearch.Text, Explain_datagrid)
            End If

        End If

    End Sub

    Private Sub Status_Combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Status_Combo.SelectedIndexChanged

        If Status_Combo.SelectedIndex = 0 Then

            PopulateExplaination(Explain_datagrid)

        ElseIf Status_Combo.SelectedIndex = 1 Then

            PopulateExplainationSTATUS(Explain_datagrid, "DONE")

        ElseIf Status_Combo.SelectedIndex = 2 Then

            PopulateExplainationSTATUS(Explain_datagrid, "PENDING")

        End If

    End Sub


    Private Sub ECS_GB_Paint(sender As Object, e As PaintEventArgs) Handles ECS_GB.Paint

        Dim txtbox As TextBox = Nothing
        For Each xObject As Object In ECS_GB.Controls
            If TypeOf xObject Is TextBox Then
                txtbox = xObject
                Dim p As New Pen(Color.Red, 2)
                e.Graphics.DrawRectangle(p, New Rectangle(txtbox.Location + New Size(1, 1), txtbox.Size - New Size(2, 2)))
                p.Dispose()
            End If
        Next

    End Sub

    Private Sub ECSNo_TXT_TextChanged(sender As Object, e As EventArgs) Handles ECSNo_TXT.TextChanged

        Dim num = Val(ECSNo_TXT.Text)

        If Not Double.TryParse(ECSNo_TXT.Text, num) Or String.IsNullOrEmpty(ECSNo_TXT.Text) Then
            ECSNo_TXT.Region = New Region(New Rectangle(2, 2, ECSNo_TXT.Width - 4, ECSNo_TXT.Height - 4))
        Else
            ECSNo_TXT.Region = Nothing
        End If

    End Sub

    Private Sub Charges_Numeric_TextChanged(sender As Object, e As EventArgs) Handles Charges_Numeric.TextChanged

        Dim num = Val(Charges_Numeric.Text)

        If Not Double.TryParse(Charges_Numeric.Text, num) Or String.IsNullOrEmpty(Charges_Numeric.Text) Then
            Charges_Numeric.Region = New Region(New Rectangle(2, 2, Charges_Numeric.Width - 4, Charges_Numeric.Height - 4))

            AmountPerPayroll_TXT.ReadOnly = True
            NoOFPayroll_TXT.ReadOnly = True
        Else
            Charges_Numeric.Region = Nothing

            AmountPerPayroll_TXT.ReadOnly = False
            NoOFPayroll_TXT.ReadOnly = False
        End If

    End Sub


    Private Sub PictureBox2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDoubleClick

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
                If Not Image.FromFile(openF.FileName).Size = PictureBox2.InitialImage.Size Then
                    PictureBox2.Image = Image.FromFile(openF.FileName)
                    PictureBox2.Tag = openF.FileName
                    PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
                Else
                    PictureBox2.Image = Image.FromFile(openF.FileName)
                    PictureBox2.Tag = openF.FileName
                    PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
                End If
                ExpalanationPath = openF.FileName
            End If

        End Using
    End Sub


    Private Sub Ack_Datagrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Ack_Datagrid.CellContentClick

        Dim grid = DirectCast(sender, DataGridView)
        Dim row As DataGridViewRow = Ack_Datagrid.Rows(e.RowIndex)

        If TypeOf grid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then

            If grid.Columns(e.ColumnIndex).Name = "IR_DGVV" Then
                Process.Start(row.Cells("IR_DGVV").Tag)

            ElseIf grid.Columns(e.ColumnIndex).Name = "SC_DGVV" Then
                Process.Start(row.Cells("SC_DGVV").Tag)

            ElseIf grid.Columns(e.ColumnIndex).Name = "Explain_DGVV" Then
                Process.Start(row.Cells("Explain_DGVV").Tag)

            ElseIf grid.Columns(e.ColumnIndex).Name = "WRITTEN_DGVV" Then
                Process.Start(row.Cells("WRITTEN_DGVV").Tag)

            ElseIf grid.Columns(e.ColumnIndex).Name = "ACKNOW_DGVV" Then

                If row.Cells("ACKNOW_DGVV").Value = "Upload" Then

                    Ack_Panel.Visible = True
                    Ack_Panel.Location = New Point(124, 48)

                Else
                    Process.Start(row.Cells("ACKNOW_DGVV").Tag)
                End If


            End If

        End If

    End Sub

    Private Sub CancelAck_BTN_Click(sender As Object, e As EventArgs) Handles CancelAck_BTN.Click
        Ack_Panel.Visible = False
        PictureBox2.Image = Nothing
    End Sub

    Private Sub SaveAck_BTN_Click(sender As Object, e As EventArgs) Handles SaveAck_BTN.Click

        Dim i As Integer = Ack_Datagrid.CurrentRow.Index

        If Not PictureBox2.Tag = Nothing Then
            imgData = ImgToByteArray(Image.FromFile(PictureBox2.Tag), ImageFormat.Jpeg)
        Else
            imgData = ImgToByteArray(PictureBox2.InitialImage, ImageFormat.Jpeg)
        End If

        LoadUploadToReportViewer(Ack_Datagrid.Item(0, i).Value, Ack_Datagrid.Item(1, i).Value, RptViewer_Acknowledge, "Acknowledgment")

        ToPDF("IR No. " & Ack_Datagrid.Item(0, i).Value & " - " & Ack_Datagrid.Item(1, i).Value, "Incident Report", RptViewer_Acknowledge, "Acknowledgment")

        AcknowledgeSave(Ack_Datagrid.Item(0, i).Value, imgData, "DONE", FolderPath)

        SaveTRANSACTIONHistory(frmMainForm.UserName_LBL.Text, Ack_Datagrid.Item(1, i).Value, "Acknowledgment IR No. " & Ack_Datagrid.Item(0, i).Value, "-", "-", "-")

        Ack_Panel.Visible = False
        PictureBox2.Image = Nothing

        PopulateAcknowledge(Ack_Datagrid)

    End Sub


    Private Sub SearchAck_TXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SearchAck_TXT.KeyPress
        If IsEnter(e) Then

            If SearchAck_Combo.SelectedIndex = 0 Then
                LoadACKNOWSearchName(SearchAck_TXT.Text, Ack_Datagrid)
            Else
                LoadACKNOWSearchIRNO(SearchAck_TXT.Text, Ack_Datagrid)
            End If

        End If
    End Sub

    Private Sub StatusACK_Combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StatusACK_Combo.SelectedIndexChanged

        If StatusACK_Combo.SelectedIndex = 0 Then

            PopulateAcknowledge(Ack_Datagrid)

        ElseIf StatusACK_Combo.SelectedIndex = 1 Then

            PopulateACKNOWTATUS(Ack_Datagrid, "DONE")

        ElseIf StatusACK_Combo.SelectedIndex = 2 Then

            PopulateACKNOWTATUS(Ack_Datagrid, "PENDING")

        End If

    End Sub

    Private Sub Coo_Emp_BTN_Click(sender As Object, e As EventArgs) Handles Coo_Emp_BTN.Click

        If frmWRList Is Nothing Then
            Dim frm As New frmWRList With {
                .MdiParent = frmMainForm
            }
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            frm.Show()
            frm.txtSearch.Tag = "Corrective Action"
            frm.Dock = DockStyle.Fill
            frm.BringToFront()

        Else
            frmWRList.BringToFront()
        End If

    End Sub

    Private Sub ClearDateSuspension_BTN_Click(sender As Object, e As EventArgs) Handles ClearDateSuspension_BTN.Click
        _corrective.Clear()
    End Sub

    Private Sub DateSuspension_DPT_CloseUp(sender As Object, e As EventArgs) Handles DateSuspension_DPT.CloseUp
        _corrective.AppendText(DateSuspension_DPT.Value.ToString("M") & ", ")
    End Sub

    Private Sub PreviewCOR_BTN_Click(sender As Object, e As EventArgs) Handles PreviewCOR_BTN.Click
        LoadCorrectiveAction()
    End Sub

    Private Sub Coo_Clear_BTN_Click(sender As Object, e As EventArgs) Handles Coo_Clear_BTN.Click
        ClearCorrective()
    End Sub

    Private Sub ACTION_Datagrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ACTION_Datagrid.CellContentClick

        Dim grid = DirectCast(sender, DataGridView)
        Dim row As DataGridViewRow = ACTION_Datagrid.Rows(e.RowIndex)

        If TypeOf grid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then

            If grid.Columns(e.ColumnIndex).Name = "INCIDENT_COO" Then
                Process.Start(row.Cells("INCIDENT_COO").Tag)

            ElseIf grid.Columns(e.ColumnIndex).Name = "SC_COO" Then
                Process.Start(row.Cells("SC_COO").Tag)

            ElseIf grid.Columns(e.ColumnIndex).Name = "EXPLAIN_COO" Then
                Process.Start(row.Cells("EXPLAIN_COO").Tag)

            ElseIf grid.Columns(e.ColumnIndex).Name = "WR_COO" Then
                Process.Start(row.Cells("WR_COO").Tag)

            ElseIf grid.Columns(e.ColumnIndex).Name = "ACKNO_COO" Then
                Process.Start(row.Cells("ACKNO_COO").Tag)

            ElseIf grid.Columns(e.ColumnIndex).Name = "ACTION_COO" Then
                Process.Start(row.Cells("ACTION_COO").Tag)

            End If

        End If

    End Sub

    Private Sub Coo_Search_TXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Coo_Search_TXT.KeyPress
        If IsEnter(e) Then

            If Coo_Search_CB.SelectedIndex = 0 Then
                LoadACTIONSearchName(Coo_Search_TXT.Text, ACTION_Datagrid)
            Else
                LoadACTIONSearchIRNO(Coo_Search_TXT.Text, ACTION_Datagrid)
            End If

        End If
    End Sub

    Private Sub AmountPerPayroll_TXT_KeyPress(sender As Object, e As KeyPressEventArgs)

        If e.KeyChar <> ChrW(Keys.Back) Then

            If Char.IsNumber(e.KeyChar) Or e.KeyChar = "." Then
            Else
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub AmountPerPayroll_TXT_TextChanged_1(sender As Object, e As EventArgs) Handles AmountPerPayroll_TXT.TextChanged

        Dim charge = Val(Charges_Numeric.Text)
        Dim perPayroll = Val(AmountPerPayroll_TXT.Text)
        Dim NoOFPayroll = charge / perPayroll
        Dim noOFMonths = NoOFPayroll / 2

        If Not Double.TryParse(AmountPerPayroll_TXT.Text, perPayroll) Or String.IsNullOrEmpty(AmountPerPayroll_TXT.Text) Then
            AmountPerPayroll_TXT.Region = New Region(New Rectangle(2, 2, AmountPerPayroll_TXT.Width - 4, AmountPerPayroll_TXT.Height - 4))
            NoOFPayroll_TXT.Text = ""
        Else
            AmountPerPayroll_TXT.Region = Nothing

            NoOFPayroll_TXT.Text = CStr(NoOFPayroll)

            If noOFMonths > 0 Then

                NoOFMonths_TXT.Text = noOFMonths

            End If
        End If

    End Sub

    Private Sub NoOFPayroll_TXT_TextChanged(sender As Object, e As EventArgs) Handles NoOFPayroll_TXT.TextChanged

        Dim charge = Val(Charges_Numeric.Text)
        Dim noOFPayroll = Val(NoOFPayroll_TXT.Text)
        Dim perPayroll = charge / noOFPayroll
        Dim noOFMonths = noOFPayroll / 2

        If Not Double.TryParse(NoOFPayroll_TXT.Text, noOFPayroll) Or String.IsNullOrEmpty(NoOFPayroll_TXT.Text) Then
            NoOFPayroll_TXT.Region = New Region(New Rectangle(2, 2, NoOFPayroll_TXT.Width - 4, NoOFPayroll_TXT.Height - 4))
            AmountPerPayroll_TXT.Text = ""
            NoOFMonths_TXT.Text = ""
        Else
            NoOFPayroll_TXT.Region = Nothing

            AmountPerPayroll_TXT.Text = CStr(perPayroll)

            If noOFMonths > 0 Then

                NoOFMonths_TXT.Text = noOFMonths

            End If
        End If

    End Sub

    Private Sub SaveCOR_BTN_Click(sender As Object, e As EventArgs) Handles SaveCOR_BTN.Click
        If Not Coo_Name_TXT.Text = "" Then

            ToPDF("IR No. " & IRNoCOO_LBL.Text & " - " & Coo_Name_TXT.Text, "Incident Report", RptViewer_Corrective, "Corrective Action Notice")

            SaveCorrectiveAction(IRNoCOO_LBL.Text, "DONE", FolderPath, Date.Now)

            SaveTRANSACTIONHistory(frmMainForm.UserName_LBL.Text, Coo_Name_TXT.Text, "Corrective Action for IR No. " & IRNoCOO_LBL.Text, Coo_Branch_TXT.Text, Coo_Position_TXT.Tag, Coo_Position_TXT.Text)

            ClearCorrective()

        Else
            MessageBox.Show($"Click Preview before saving", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


End Class