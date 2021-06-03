Imports System.IO
Imports FirebirdSql.Data.FirebirdClient


Public Class frmLetter

    Friend isPage1 As Integer
    Dim lastname, gender, branch1, branch2, status1, status2, position1, position2 As String

    Private Sub OK_BTN_Click(sender As Object, e As EventArgs) Handles OK_BTN.Click
        LoadReassignmentLetter()
    End Sub

    Private Sub LoadReassignmentLetter()

        Dim DateIssued, DateTrans As String
        DateIssued = R_DateIssued_DTP.Value.ToString("MMMM dd, yyyy")
        DateTrans = DateTrans_DTP.Value.ToString("MMMM dd, yyyy")

        rpt_Reassignment.LocalReport.DataSources.Clear()

        Dim paramList As New List(Of ReportParameter) From {
            New ReportParameter("paramDateToday", DateIssued, True),
            New ReportParameter("paramName", R_EmpName_TXT.Text, True),
            New ReportParameter("paramPosition", R_Position_TXT.Text, True),
            New ReportParameter("paramBranchFrom", R_FromBranch_TXT.Text),
            New ReportParameter("paramBranchTo", R_ToBranch_CB.Text),
            New ReportParameter("paramAsPosition", R_PositionAs_CB.Text),
            New ReportParameter("paramDateOn", DateTrans),
            New ReportParameter("paramPreparedPosition", Position1_TXT.Text),
            New ReportParameter("paramPreparedBy", PreparedBy_TXT.Text),
            New ReportParameter("paramNotedPosition", Position2_TXT.Text),
            New ReportParameter("paramNotedBy", NotedBy_TXT.Text),
            New ReportParameter("paramCompany", R_Company_TXT.Text)
        }

        Try
            rpt_Reassignment.LocalReport.SetParameters(paramList)
            rpt_Reassignment.RefreshReport()

        Catch ex As Exception
            Log_Report(ex.ToString)
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadAppointmentLetter()

        Dim DateON, DateIssued As String
        DateIssued = AP_DateIssued_DP.Value.ToString("MMMM dd, yyyy")
        DateON = AP_DateON_DP.Value.ToString("MMMM dd, yyyy")

        rpt_Appointment.LocalReport.DataSources.Clear()

        Dim paramList As New List(Of ReportParameter) From {
            New ReportParameter("paramDateToday", DateIssued, True),
            New ReportParameter("paramName", AP_Name_TXT.Text, True),
            New ReportParameter("paramPosition", AP_Position_TXT.Text, True),
            New ReportParameter("paramPositionAs", AP_PositionAs_CB.Text, True),
            New ReportParameter("paramSurname", lastname),
            New ReportParameter("paramMSMR", gender),
            New ReportParameter("paramBranch", AP_ToBranch_CB.Text),
            New ReportParameter("paramDateON", DateON),
            New ReportParameter("paramPreparedPosition", AP_Position1_TXT.Text),
            New ReportParameter("paramPreparedBy", AP_PreparedBy_TXT.Text),
            New ReportParameter("paramReviewedPosition", AP_Position2_TXT.Text),
            New ReportParameter("paramReviewedBy", AP_ReviewedBy_TXT.Text),
            New ReportParameter("paramCompany", AP_Company_TXT.Text)
        }

        Try
            rpt_Appointment.LocalReport.SetParameters(paramList)
            rpt_Appointment.RefreshReport()

        Catch ex As Exception
            Log_Report(ex.ToString)
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub frmLetter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PopulateComboBox(R_PositionAs_CB, "tbl_Employee", "EMP_POSITION")
        PopulateComboBox(R_ToBranch_CB, "tbl_branch", "BRANCHNAME")
        PopulateComboBox(AP_PositionAs_CB, "tbl_Employee", "EMP_POSITION")
        PopulateComboBox(AP_ToBranch_CB, "tbl_branch", "BRANCHNAME")
        AP_DateIssued_DP.Value = DateTime.Now
        R_DateIssued_DTP.Value = DateTime.Now
        Allow_DTP_List.Value = DateTime.Now
        Allow_DTP_Indi.Value = DateTime.Now
        Allow_Company_Combo.SelectedIndex = 1

    End Sub

    Private Sub Save_BTN_Click(sender As Object, e As EventArgs) Handles Save_BTN.Click
        Dim dt As String = $" - {R_DateIssued_DTP.Value.ToString("MMMM dd, yyyy")} "

        If R_EmpName_TXT.Text = "" Or R_ToBranch_CB.Text = "" Or R_PositionAs_CB.Text = "" Then

            MsgBox("Some input is empty", MsgBoxStyle.Critical, "Error")

        Else
            ToPDF(R_EmpName_TXT.Text & dt, "Letter", "Reassignment", rpt_Reassignment)

            SaveTRANSACTIONHistory(frmMainForm.UserName_LBL.Text, R_EmpName_TXT.Text, "Reassignment", R_FromBranch_TXT.Text, R_Position_TXT.Tag, R_Position_TXT.Text)

            UpdateREASSIGN()
            SaveReassignHISTORY()
            ClearREASSign()
        End If
    End Sub


    Private Sub SaveReassignHISTORY()

        If isNotExist() Then
            Dim mysql As String = "Select * From TBL_REASSIGN_HISTORY Rows 1"
            Using ds As DataSet = LoadSQL(mysql, "TBL_REASSIGN_HISTORY")

                Dim dsNewRow As DataRow
                dsNewRow = ds.Tables(0).NewRow
                With dsNewRow
                    .Item("EMP_ID") = R_EmpName_TXT.Tag
                    .Item("PREV_BRANCHNAME") = R_FromBranch_TXT.Text
                    .Item("PREV_POSITION") = R_Position_TXT.Text
                    .Item("DATE_REAASIGN") = DateTrans_DTP.Value
                    .Item("PREPARED_BY") = PreparedBy_TXT.Text
                    .Item("NOTED_BY") = NotedBy_TXT.Text
                    .Item("REMARKS") = R_Remarks_RichText.Text

                    ds.Tables(0).Rows.Add(dsNewRow)
                End With
                SaveEntry(ds)
            End Using

        Else

            Dim mysql As String = "Select * From TBL_REASSIGN_HISTORY Where EMP_ID = '" & R_EmpName_TXT.Tag & "'"
            Using ds As DataSet = LoadSQL(mysql, "TBL_REASSIGN_HISTORY")

                With ds.Tables(0).Rows(0)
                    .Item("PREV_BRANCHNAME") = R_FromBranch_TXT.Text
                    .Item("PREV_POSITION") = R_Position_TXT.Text
                    .Item("DATE_REAASIGN") = DateTrans_DTP.Value
                    .Item("PREPARED_BY") = PreparedBy_TXT.Text
                    .Item("NOTED_BY") = NotedBy_TXT.Text
                    .Item("REMARKS") = R_Remarks_RichText.Text

                End With
                SaveEntry(ds, False)
            End Using
        End If
    End Sub

    Private Function isNotExist()
        Dim mysql As String = "SELECT * FROM TBL_REASSIGN_HISTORY Where EMP_ID  = '" & R_EmpName_TXT.Tag & "'"
        Dim ds As DataSet = LoadSQL(mysql, "TBL_REASSIGN_HISTORY")
        If ds.Tables(0).Rows.Count > 0 Then
            Return False
        End If

        Return True
    End Function

    Friend Sub ToPDF(Name As String, Folder As String, letterOF As String, report As ReportViewer)

        Dim DirFolderToCreate As String = "D:\HR Records\" & Folder & "\" & letterOF & ""
        Dim folderName As DirectoryInfo = New DirectoryInfo(DirFolderToCreate)

        Dim DirEmployeeToCreate As String = "D:\HR Records\" & Folder & "\" & letterOF
        Dim employee As DirectoryInfo = New DirectoryInfo(DirEmployeeToCreate)

        Dim byteViewer As Byte() = report.LocalReport.Render("PDF")
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "*PDF files (*.pdf)|*.pdf"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True

        If folderName.Exists Then

            If employee.Exists Then
                'Dim newFile As New FileStream("D:\" & Folder & "\" & Name & "\" & dt & ".pdf", FileMode.Create)

                Dim newFile As New FileStream("D:\HR Records\" & Folder & "\" & letterOF & "\" & Name & ".pdf", FileMode.Create)
                newFile.Write(byteViewer, 0, byteViewer.Length)
                newFile.Close()
            Else
                employee.Create()
                Dim newFile As New FileStream("D:\HR Records\" & Folder & "\" & letterOF & "\" & Name & ".pdf", FileMode.Create)
                newFile.Write(byteViewer, 0, byteViewer.Length)
                newFile.Close()
            End If

        Else
            folderName.Create()
            If employee.Exists Then
                Dim newFile As New FileStream("D:\HR Records\" & Folder & "\" & letterOF & "\" & Name & ".pdf", FileMode.Create)
                newFile.Write(byteViewer, 0, byteViewer.Length)
                newFile.Close()
            Else
                employee.Create()
                Dim newFile As New FileStream("D:\HR Records\" & Folder & "\" & letterOF & "\" & Name & ".pdf", FileMode.Create)
                newFile.Write(byteViewer, 0, byteViewer.Length)
                newFile.Close()
            End If

        End If

        MessageBox.Show($"{Name} successfully saved to D:\HR Records\{Folder}", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub SearchEMP_BTN_Click(sender As Object, e As EventArgs) Handles SearchEMP_BTN.Click
        'Dim secured_str As String = R_EmpName_TXT.Text
        'secured_str = DreadKnight(secured_str)
        'isPage1 = 1
        'If frmworklist Is Nothing Then
        '    Dim frm As New frmworklist With {
        '        .MdiParent = frmMainForm
        '    }
        '    frmMainForm.pNavigate.Controls.Add(frm)
        '    frmMainForm.pNavigate.Tag = frm
        '    frm.SearchSelectCorrective(secured_str, FormName.Coorective, isPage1)
        '    frm.Dock = DockStyle.Fill
        '    frm.SetLabelOpen("Letter1", False)
        '    frm.Show()
        '    frm.BringToFront()
        'Else
        '    frmworklist.BringToFront()
        'End If
        'Close() 

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
            frm.txtSearch.Tag = "Reassignment"
            frm.Dock = DockStyle.Fill
            frm.BringToFront()

        Else
            frmEmployeeList.BringToFront()
        End If

        Close()
    End Sub

    Public Sub LoadEmpReAssign(mPower As Employee)
        With mPower

            Dim MI As String

            If String.IsNullOrEmpty(.MiddleName) Then
                MI = ""
            Else
                MI = .MiddleName.Substring(0, 1) & "."
            End If

            R_EmpName_TXT.Tag = .ID
            R_EmpName_TXT.Text = $"{ .FirstName} { MI } { .LastName} { .Suffix}"
            R_Position_TXT.Text = .Position
            R_Company_TXT.Text = .Company_Name
            R_FromBranch_TXT.Text = .Branch_Name
            R_Position_TXT.Tag = .Status

        End With
    End Sub


    'Public Sub LoadEmpAllowanceFIRST(mPower As BhouseAllowance)

    '    With mPower

    '        Dim pos As Integer = .FullName.IndexOf(",")
    '        Dim substring As String = .FullName.Substring(0, pos)

    '        'Allow_Name_txt.Tag = .EmpID
    '        Allow_Name_txt.Text = .FullName
    '        Allow_Name_txt.Tag = substring
    '        Allow_Company_txt.Text = .Company
    '        Allow_Particular_TXT.Text = .Particulars
    '        BH_TXT.Text = .Bhouse_String

    '        Dim CK As Decimal = Decimal.Parse(.Carekit_String).ToString("##,###0.00")
    '        CareKit_TXT.Text = CK

    '        Dim other As Decimal = Decimal.Parse(.other_String).ToString("##,###0.00")
    '        Other_TXT.Text = other
    '    End With

    'End Sub

    'Public Sub LoadEmpAllowanceSECOND(mPower As BhouseAllowance)

    '    With mPower

    '        Dim pos As Integer = .FullName.IndexOf(",")
    '        Dim substring As String = .FullName.Substring(0, pos)

    '        'Allow_Name_txt.Tag = .EmpID
    '        Allow_Name_txt1.Text = .FullName
    '        Allow_Name_txt1.Tag = substring
    '        Allow_Company_txt1.Text = .Company
    '        Allow_Particular_TXT1.Text = .Particulars
    '        BH_TXT1.Text = .Bhouse_String

    '        Dim CK As Decimal = Decimal.Parse(.Carekit_String).ToString("##,###0.00")
    '        CareKit_TXT1.Text = CK

    '        Dim other As Decimal = Decimal.Parse(.other_String).ToString("##,###0.00")
    '        Other_TXT1.Text = other

    '    End With
    'End Sub

    Public Function GetSubTotal() As Decimal

        Dim amount As Decimal = 0

        If DataGridView1.RowCount > 0 Then
            For index = 0 To DataGridView1.Rows.Count - 1
                amount += Convert.ToDecimal(DataGridView1.Rows(index).Cells(3).Value)
            Next
            Allow_total_List.Text = amount
        End If

        Return amount
    End Function

    Public Sub LoadEmpAllowanceLIST(mPower As BhouseAllowance, Optional subject As String = "")
        List_Radio.Checked = True
        PreviousBranch()

        If subject = 1 Then

            With mPower

                Dim rowId As Integer = DataGridView1.Rows.Add()
                Dim row As DataGridViewRow = DataGridView1.Rows(rowId)
                row.Cells("Name_DataGrid").Value = .FullName
                row.Cells("Current_DataGrid").Value = .BranchName_String
                row.Cells("Amount_DataGrid").Value = .Bhouse_String
                Subject_Combo.SelectedIndex = 1

            End With

        ElseIf subject = 2 Then

            With mPower
                Dim rowId As Integer = DataGridView1.Rows.Add()
                Dim row As DataGridViewRow = DataGridView1.Rows(rowId)
                row.Cells("Name_DataGrid").Value = .FullName
                row.Cells("Current_DataGrid").Value = .BranchName_String
                row.Cells("Amount_DataGrid").Value = .Carekit_String
                Subject_Combo.SelectedIndex = 2
            End With

        ElseIf subject = 3 Then

            With mPower
                Dim rowId As Integer = DataGridView1.Rows.Add()
                Dim row As DataGridViewRow = DataGridView1.Rows(rowId)
                row.Cells("Name_DataGrid").Value = .FullName
                row.Cells("Current_DataGrid").Value = .BranchName_String
                row.Cells("Amount_DataGrid").Value = .other_String
                Subject_Combo.SelectedIndex = 3
            End With

        End If

        GetSubTotal()
    End Sub

    Public Sub LoadEmpAPPOINT(mPower As Employee)
        With mPower
            Dim MI As String

            If String.IsNullOrEmpty(.MiddleName) Then
                MI = ""
            Else
                MI = .MiddleName.Substring(0, 1) & "."
            End If

            AP_Name_TXT.Tag = .ID
            AP_Name_TXT.Text = $"{ .FirstName} { MI } { .LastName} { .Suffix}"
            AP_Position_TXT.Text = .Position
            AP_Company_TXT.Text = .Company_Name
            AP_Branch_TXT.Text = .Branch_Name
            AP_Position_TXT.Tag = .Status

            lastname = .LastName

            If .Sex = "Female" Then
                gender = "Ms"
            Else
                gender = "Mr"
            End If

        End With
    End Sub

    Public Sub LoadEmpAllowanceFIRST(mPower As Employee)

        With mPower

            Dim MI As String

            If String.IsNullOrEmpty(.MiddleName) Then
                MI = ""
            Else
                MI = .MiddleName.Substring(0, 1) & "."
            End If

            Allow_Name_txt.Text = $"{ .FirstName} { MI } { .LastName} { .Suffix}"
            Allow_Name_txt.Tag = .ID
            Allow_Company_txt.Text = .Company_Name
            branch1 = .Branch_Name
            status1 = .Status
            position1 = .Position

            'Dim CK As Decimal = Decimal.Parse(.Carekit_String).ToString("##,###0.00")
            'CareKit_TXT.Text = CK

            'Dim other As Decimal = Decimal.Parse(.other_String).ToString("##,###0.00")
            'Other_TXT.Text = other
        End With

    End Sub

    Public Sub LoadEmpAllowanceSECOND(mPower As Employee)

        With mPower
            Dim MI As String

            If String.IsNullOrEmpty(.MiddleName) Then
                MI = ""
            Else
                MI = .MiddleName.Substring(0, 1) & "."
            End If

            Allow_Name_txt1.Text = $"{ .FirstName} { MI } { .LastName} { .Suffix}"
            Allow_Name_txt1.Tag = .ID
            Allow_Company_txt1.Text = .Company_Name
            branch2 = .Branch_Name
            status2 = .Status
            position2 = .Position

            'Dim CK As Decimal = Decimal.Parse(.Carekit_String).ToString("##,###0.00")
            'CareKit_TXT1.Text = CK

            'Dim other As Decimal = Decimal.Parse(.other_String).ToString("##,###0.00")
            'Other_TXT1.Text = other

        End With
    End Sub

    Public Sub UpdateREASSIGN()
        Dim id As String = R_EmpName_TXT.Tag
        Dim mysql As String = "Select * From tbl_employee Where id = '" & id & "'"
        Using ds As DataSet = LoadSQL(mysql, "tbl_employee")
            If ds.Tables(0).Rows.Count > 0 Then
                With ds.Tables(0).Rows(0)
                    .Item("BRANCH_ID") = R_ToBranch_CB.Tag
                    .Item("EMP_POSITION") = R_PositionAs_CB.Text
                    SaveEntry(ds, False)
                End With
            End If
        End Using
    End Sub

    Public Sub UpdateAPPOINT()
        Dim id As String = AP_Name_TXT.Tag
        Dim mysql As String = "Select * From tbl_employee Where id = '" & id & "'"
        Using ds As DataSet = LoadSQL(mysql, "tbl_employee")
            If ds.Tables(0).Rows.Count > 0 Then
                With ds.Tables(0).Rows(0)
                    .Item("BRANCH_ID") = AP_ToBranch_CB.Tag
                    .Item("EMP_POSITION") = AP_PositionAs_CB.Text

                    SaveEntry(ds, False)
                End With
            End If
        End Using
    End Sub

    Private Sub PopulateComboBox(combo As ComboBox, table As String, column As String)
        Dim sql As String = $"select distinct({column}) from {table}"
        Dim rdr As FbDataReader = LoadSQL_byDataReader(sql)
        combo.Items.Clear()
        While rdr.Read()
            If rdr.HasRows Then
                With rdr
                    combo.Items.Add(rdr.Item(0).ToString)
                End With
            End If
        End While
    End Sub

    Private Sub R_ToBranch_CB_SelectedValueChanged(sender As Object, e As EventArgs) Handles R_ToBranch_CB.SelectedValueChanged
        GetBranchID(R_ToBranch_CB.Text, R_ToBranch_CB)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles AP_Preview_BTN.Click
        LoadAppointmentLetter()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AP_EMPLOYEE_BTN.Click
        Dim secured_str As String = R_EmpName_TXT.Text
        secured_str = DreadKnight(secured_str)
        isPage1 = 1
        'If frmworklist Is Nothing Then
        '    Dim frm As New frmworklist With {
        '        .MdiParent = frmMainForm
        '    }
        '    frmMainForm.pNavigate.Controls.Add(frm)
        '    frmMainForm.pNavigate.Tag = frm
        '    frm.SearchSelectCorrective(secured_str, FormName.letter, isPage1)
        '    frm.Dock = DockStyle.Fill
        '    frm.SetLabelOpen("Letter2", False)
        '    frm.Show()
        '    frm.BringToFront()
        'Else
        '    frmworklist.BringToFront()
        'End If
        'Close()

        If frmEmployeeList Is Nothing Then
            Dim frm As New frmEmployeeList With {
                .MdiParent = frmMainForm
            }
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            'frm.SearchSelect(secured_str, FormName.Employee, 1)
            frm.Show()
            frm.btnView.Visible = False
            frm.btnAdd.Visible = False
            frm.btnSelect.Visible = True
            frm.txtSearch.Tag = "Appointment"
            frm.Dock = DockStyle.Fill
            frm.BringToFront()

        Else
            frmEmployeeList.BringToFront()
        End If
        Close()
    End Sub

    Private Sub AP_Save_BTN_Click(sender As Object, e As EventArgs) Handles AP_Save_BTN.Click
        Dim dt As String = $" - {AP_DateIssued_DP.Value.ToString("MMMM dd, yyyy")} "

        If AP_Name_TXT.Text = "" Or AP_ToBranch_CB.Text = "" Or AP_PositionAs_CB.Text = "" Then

            MsgBox("Some input is empty!", MsgBoxStyle.Critical, "Error")

        Else

            ToPDF(AP_Name_TXT.Text & dt, "Letter", "Appointment", rpt_Appointment)

            SaveTRANSACTIONHistory(frmMainForm.UserName_LBL.Text, AP_Name_TXT.Text, "Appointment", AP_Branch_TXT.Text, AP_Position_TXT.Tag, AP_Position_TXT.Text)

            UpdateAPPOINT()
            ClearAPPOINT()
        End If
    End Sub

    Private Sub ClearREASSign()
        R_EmpName_TXT.Clear()
        R_Position_TXT.Clear()
        R_Company_TXT.Clear()
        R_FromBranch_TXT.Clear()
        R_ToBranch_CB.Text = ""
        R_PositionAs_CB.Text = ""
        R_Remarks_RichText.Clear()
        DateTrans_DTP.Value = Date.UtcNow
        R_DateIssued_DTP.Value = Date.UtcNow
        PreparedBy_TXT.Clear()
        NotedBy_TXT.Clear()
        rpt_Reassignment.Clear()
    End Sub

    Private Sub ClearAPPOINT()
        AP_Name_TXT.Clear()
        AP_Position_TXT.Clear()
        AP_Company_TXT.Clear()
        AP_Branch_TXT.Clear()
        AP_ToBranch_CB.Text = ""
        AP_PositionAs_CB.Text = ""
        AP_DateON_DP.Value = Date.UtcNow
        AP_DateIssued_DP.Value = Date.UtcNow
        AP_PreparedBy_TXT.Clear()
        AP_ReviewedBy_TXT.Clear()
        rpt_Appointment.Clear()
    End Sub


    'Public Function EmptyME_RE()

    '    If R_EmpName_TXT.Text = "" Then
    '        Return True
    '    End If

    '    If R_ToBranch_CB.Text = "" Then
    '        Return True
    '    End If

    '    If R_PositionAs_CB.Text = "" Then
    '        Return True
    '    End If

    '    Return True
    'End Function

    'Public Function EmptyME_AP()
    '    If AP_Name_TXT.Text = "" Then
    '        Return True
    '    End If

    '    If AP_ToBranch_CB.Text = "" Then
    '        Return True
    '    End If

    '    If AP_PositionAs_CB.Text = "" Then
    '        Return True
    '    End If

    '    Return True
    'End Function 

    Private Sub CloseWindow_BTN_Click(sender As Object, e As EventArgs) Handles CloseWindow_BTN.Click
        Close()
    End Sub

    Private Sub AP_ToBranch_CB_SelectedValueChanged(sender As Object, e As EventArgs) Handles AP_ToBranch_CB.SelectedValueChanged
        GetBranchID(AP_ToBranch_CB.Text, AP_ToBranch_CB)
    End Sub

    Public Sub GetBranchID(branchName As String, combo As ComboBox)
        Dim sql As String = "Select * From tbl_branch Where BRANCHNAME = '" & branchName & "'"
        DbReaderOpen()
        Using rd As FbDataReader = LoadSQL_byDataReader(sql)

            While rd.Read()
                combo.Tag = rd.Item("ID")
            End While
            rd.Close()
        End Using
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Search_btn1.Click

        'Dim secured_str As String = Allow_Name_txt.Text
        'secured_str = DreadKnight(secured_str)

        'If frmAllowanceList Is Nothing Then
        '    Dim frm As New frmAllowanceList With {
        '        .MdiParent = frmMainForm
        '    }
        '    frmMainForm.pNavigate.Controls.Add(frm)
        '    frmMainForm.pNavigate.Tag = frm
        '    frm.Search_TXT.Tag = "Letter3"
        '    frm.Dock = DockStyle.Fill
        '    frm.Show()
        '    frm.BringToFront()
        'Else
        '    frmAllowanceList.BringToFront()
        'End If

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
            frm.txtSearch.Tag = "Allowance-Individual"
            frm.Dock = DockStyle.Fill
            frm.BringToFront()

        Else
            frmEmployeeList.BringToFront()
        End If
        Close()

    End Sub

    Private Sub Allow_Preview_Click(sender As Object, e As EventArgs) Handles Allow_Preview.Click
        LoadAllowanceLetterSingle()
    End Sub

    Private Sub LoadAllowanceLetterSingle()

        Dim bh As Double = CDbl(BH_TXT.Text)
        Dim ck As Double = CDbl(CareKit_TXT.Text)
        Dim other As Double = CDbl(Other_TXT.Text)
        Dim total As Decimal = bh + ck + other

        Dim bh1 As Double = CDbl(BH_TXT1.Text)
        Dim ck1 As Double = CDbl(CareKit_TXT1.Text)
        Dim other1 As Double = CDbl(Other_TXT1.Text)
        Dim total1 As Decimal = bh1 + ck1 + other1

        Dim DateIssued, peso As String
        DateIssued = Allow_DTP_Indi.Value.ToString("MMMM dd, yyyy")
        peso = "₱"


        rpt_Allowance.LocalReport.ReportEmbeddedResource = "HRSystem.Letter_SD.rdlc"
        rpt_Allowance.LocalReport.DataSources.Clear()

        Dim paramList As New List(Of ReportParameter) From {
            New ReportParameter("paramDate", DateIssued),
            New ReportParameter("paramPaidTo", Allow_Name_txt.Text),
            New ReportParameter("paramCompany", Allow_Company_txt.Text),
            New ReportParameter("paramParticular", Allow_Particular_TXT.Text),
            New ReportParameter("paramTotal", Decimal.Parse(total).ToString("##,###0.00")),
            New ReportParameter("paramPaidTo1", Allow_Name_txt1.Text),
            New ReportParameter("paramCompany1", Allow_Company_txt1.Text),
            New ReportParameter("paramParticular1", Allow_Particular_TXT1.Text),
            New ReportParameter("paramTotal1", Decimal.Parse(total1).ToString("##,###0.00")),
            New ReportParameter("paramNotedBy", Allow_NotedBy_TXT.Text),
            New ReportParameter("paramNotedPosition", Allow_NotedPos_TXT.Text),
            New ReportParameter("paramPreparedBy", Allow_PreparedBy_TXT.Text),
            New ReportParameter("paramPreparedPosition", Allow_PreparedPos_TXT.Text),
            New ReportParameter("paramPreparedBy", AP_ReviewedBy_TXT.Text)
        }

        Try

            Dim dt As New DataTable("dt1")
            With dt
                .Columns.Add("Bhouse")
                .Columns.Add("Carekit")
                .Columns.Add("Other")
                .Columns.Add("Bhouse1")
                .Columns.Add("Carekit1")
                .Columns.Add("Other1")
            End With

            Dim bhouse As String = If(Not (BH_TXT.Text = 0.00), BH_TXT.Text, 0)
            Dim carekit As String = If(Not (CareKit_TXT.Text = 0.00), CareKit_TXT.Text, 0)
            Dim otherr As String = If(Not (Other_TXT.Text = 0.00), Other_TXT.Text, 0)
            Dim bhouse1 As String = If(Not (BH_TXT1.Text = 0.00), BH_TXT1.Text, 0)
            Dim carekit1 As String = If(Not (CareKit_TXT1.Text = 0.00), CareKit_TXT1.Text, 0)
            Dim otherr1 As String = If(Not (Other_TXT1.Text = 0.00), Other_TXT1.Text, 0)

            dt.Rows.Add(bhouse, carekit, otherr, bhouse1, carekit1, otherr1)

            Dim rds As New ReportDataSource("DataSetIndi", dt)
            rpt_Allowance.LocalReport.DataSources.Add(rds)

            rpt_Allowance.LocalReport.SetParameters(paramList)
            rpt_Allowance.RefreshReport()

        Catch ex As Exception
            Log_Report(ex.ToString)
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Search_btn2_Click(sender As Object, e As EventArgs) Handles Search_btn2.Click
        'Dim secured_str As String = Allow_Name_txt.Text
        'secured_str = DreadKnight(secured_str)

        'If frmAllowanceList Is Nothing Then
        '    Dim frm As New frmAllowanceList With {
        '        .MdiParent = frmMainForm
        '    }
        '    frmMainForm.pNavigate.Controls.Add(frm)
        '    frmMainForm.pNavigate.Tag = frm
        '    frm.Search_TXT.Tag = "Letter3"
        '    frm.Search_BTN.Tag = "Individual-2"
        '    frm.Dock = DockStyle.Fill
        '    frm.Show()
        '    frm.BringToFront()
        'Else
        '    frmAllowanceList.BringToFront()
        'End If
    End Sub

    Private Sub Clear_BTN_Click(sender As Object, e As EventArgs) Handles Clear_BTN.Click
        Allow_Name_txt.Clear()
        Allow_Company_txt.Clear()
        Allow_Particular_TXT.Clear()
        BH_TXT.Text = 0
        CareKit_TXT.Text = 0
        Other_TXT.Text = 0
    End Sub

    Private Sub Clear_BTN1_Click(sender As Object, e As EventArgs) Handles Clear_BTN1.Click
        Allow_Name_txt1.Clear()
        Allow_Company_txt1.Clear()
        Allow_Particular_TXT1.Clear()
        BH_TXT1.Text = 0
        CareKit_TXT1.Text = 0
        Other_TXT1.Text = 0
    End Sub

    Private Sub Allow_Export_Click(sender As Object, e As EventArgs) Handles Allow_Export.Click

        Dim dt As String = $" - {Allow_DTP_Indi.Value.ToString("MMMM dd, yyyy")} "

        If Allow_Name_txt.Text = "" And Allow_Name_txt1.Text = "" Then

            MsgBox("Nothing to save.", MsgBoxStyle.Critical, "Error")

        Else

            ToPDF(Allow_Name_txt.Tag & " , " & Allow_Name_txt1.Tag, "Allowance", dt, rpt_Allowance) 'branch1, branch2, status1, status2, position1, position2

            SaveTRANSACTIONHistory(frmMainForm.UserName_LBL.Text, Allow_Name_txt.Tag & " , " & Allow_Name_txt1.Tag, "Allowance", branch1 & " , " & branch2, status1 & " , " & status2, position1 & " , " & position2)

        End If
    End Sub

    Private Sub More_Radio_CheckedChanged(sender As Object, e As EventArgs) Handles List_Radio.CheckedChanged
        Group_Individual.Visible = False
        Group_List.Visible = True
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles Individual_RB.CheckedChanged
        Group_Individual.Visible = True
        Group_List.Visible = False
    End Sub

    Private Sub Allow_Select_List_Click(sender As Object, e As EventArgs) Handles Allow_Select_List.Click

        If Subject_Combo.Text = "" Then
            Subject_Combo.Region = New Region(New Rectangle(2, 2, Subject_Combo.Width - 4, Subject_Combo.Height - 4))
        Else
            Subject_Combo.Region = Nothing

            If frmAllowanceList Is Nothing Then
                Dim frm As New frmAllowanceList With {
                .MdiParent = frmMainForm
            }
                frmMainForm.pNavigate.Controls.Add(frm)
                frmMainForm.pNavigate.Tag = frm
                frm.Search_TXT.Tag = "Letter3"
                frm.Search_BTN.Tag = "LIST"

                If Subject_Combo.SelectedIndex = 1 Then
                    frm.Label_Header.Tag = "Boarding_Allowance"
                ElseIf Subject_Combo.SelectedIndex = 2 Then
                    frm.Label_Header.Tag = "CareKit_Allowance"
                ElseIf Subject_Combo.SelectedIndex = 3 Then
                    frm.Label_Header.Tag = "Other_Allowance"
                End If

                frm.Dock = DockStyle.Fill
                frm.Show()
                frm.BringToFront()
            Else
                frmAllowanceList.BringToFront()
            End If
        End If

    End Sub

    Private Sub Allow_Clear_List_Click(sender As Object, e As EventArgs) Handles Allow_Clear_List.Click
        Dim result As DialogResult = MessageBox.Show("The selected data will be deleted, Proceed anyway?", "Warning", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Subject_Combo.SelectedIndex = 0
            Allow_Company_Combo.SelectedIndex = 1
            DataGridView1.Rows.Clear()
            Allow_total_List.Text = 0
        End If

    End Sub

    Public Sub PreviousBranch()

        Dim sql As String = $"select distinct(BRANCHNAME) from TBL_BRANCH"
        Dim rdr As FbDataReader = LoadSQL_byDataReader(sql)
        Previous_DataGrid.Items.Clear()
        While rdr.Read()
            If rdr.HasRows Then
                With rdr
                    Previous_DataGrid.Items.Add(rdr.Item(0).ToString)
                End With
            End If
        End While

    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick

        If e.Button = MouseButtons.Right Then
            Dim i As Integer = DataGridView1.CurrentRow.Index
            If Not String.IsNullOrEmpty(CStr(DataGridView1.Item(0, i).Value)) Then
                ContextMenu_Remove.Show(DataGridView1, New Point(e.X, e.Y))
            End If
        End If

    End Sub


    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        Dim i As Integer = DataGridView1.CurrentRow.Index
        DataGridView1.Rows.RemoveAt(i)
        GetSubTotal()
    End Sub

    Private Sub Subject_Combo_SelectedValueChanged(sender As Object, e As EventArgs) Handles Subject_Combo.SelectedValueChanged

        If DataGridView1.RowCount > 1 Then
            Dim result As DialogResult = MessageBox.Show("The selected data will be deleted, Proceed anyway?", "Warning", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DataGridView1.Rows.Clear()
                Allow_total_List.Text = 0
            End If
        End If

        If Subject_Combo.Text = "" Then
            Subject_Combo.Region = New Region(New Rectangle(2, 2, Subject_Combo.Width - 4, Subject_Combo.Height - 4))
        Else
            Subject_Combo.Region = Nothing
        End If


    End Sub

    Private Sub Allow_Preview_List_Click(sender As Object, e As EventArgs) Handles Allow_Preview_List.Click
        LoadAllowanceLetterLIST()
        'rpt_Allowance.LocalReport.ReportPath = "Letter_List.rdlc"
    End Sub

    Private Sub LoadAllowanceLetterLIST()

        rpt_Allowance.LocalReport.ReportEmbeddedResource = "HRSystem.Letter_List.rdlc"

        Dim DateIssued, peso As String
        DateIssued = Allow_DTP_List.Value.ToString("MMMM dd, yyyy")
        peso = "₱"
        'company = Allow_Company_Combo.Tag

        rpt_Allowance.LocalReport.DataSources.Clear()
        Dim tbl As New AllowanceList.AllowanceListDataTable()

        Dim paramList As New List(Of ReportParameter) From {
            New ReportParameter("paramDate", DateIssued),
            New ReportParameter("paramSubject", Subject_Combo.Text),
            New ReportParameter("paramCompany", Allow_Company_Combo.Text),
            New ReportParameter("paramNote", Allow_Note_List.Text),
            New ReportParameter("paramTotal", Allow_total_List.Text),
            New ReportParameter("paramNotedBy", Allow_NotedBy_List.Text),
            New ReportParameter("paramNotedPosition", Allow_NotedPos_List.Text),
            New ReportParameter("paramPreparedBy", Allow_PreparedBy_List.Text),
            New ReportParameter("paramPreparedPosition", Allow_PreparedPos_List.Text)
        }

        Try

            Dim dt As New DataTable("dt1")
            With dt
                .Columns.Add("Name")
                .Columns.Add("Previous")
                .Columns.Add("Current")
                .Columns.Add("Amount")
            End With

            For Each dr As DataGridViewRow In DataGridView1.Rows
                dt.Rows.Add(dr.Cells("Name_DataGrid").Value, dr.Cells("Previous_DataGrid").Value, dr.Cells("Current_DataGrid").Value, dr.Cells("Amount_DataGrid").Value)
            Next

            Dim rds As New ReportDataSource("DataSetList", dt)
            rpt_Allowance.LocalReport.DataSources.Add(rds)

            rpt_Allowance.LocalReport.SetParameters(paramList)
            rpt_Allowance.RefreshReport()

        Catch ex As Exception
            Log_Report(ex.ToString)
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GroupBox8_Paint(sender As Object, e As PaintEventArgs) Handles GroupBox_Subject.Paint
        Dim p As New Pen(Color.Red, 2)
        e.Graphics.DrawRectangle(p, New Rectangle(Subject_Combo.Location + New Size(1, 1), Subject_Combo.Size - New Size(2, 2)))
        p.Dispose()
    End Sub

    Private Sub Allow_Save_List_Click(sender As Object, e As EventArgs) Handles Allow_Save_List.Click

        Dim dt As String = $" - {Allow_DTP_List.Value.ToString("MMMM dd, yyyy")} "

        If Subject_Combo.Text = "" Then
            Subject_Combo.Region = New Region(New Rectangle(2, 2, Subject_Combo.Width - 4, Subject_Combo.Height - 4))
        Else
            Subject_Combo.Region = Nothing

            If DataGridView1.Rows.Count <= 0 Then
                DataGridView1.Region = New Region(New Rectangle(2, 2, DataGridView1.Width - 4, DataGridView1.Height - 4))
            Else
                DataGridView1.Region = Nothing

                LoadAllowanceLetterLIST()

                ToPDF(Subject_Combo.Text & " - " & Allow_Company_Combo.Text, "Allowance", dt, rpt_Allowance)

                'SaveTRANSACTIONHistory(frmMainForm.UserName_LBL.Text, AP_Name_TXT.Text, Subject_Combo.Text, AP_Branch_TXT.Text, AP_Position_TXT.Tag, AP_Position_TXT.Text)
            End If
        End If

    End Sub

    Private Sub GroupBox_Datagrid_Paint(sender As Object, e As PaintEventArgs) Handles GroupBox_Datagrid.Paint
        Dim p As New Pen(Color.Red, 2)
        e.Graphics.DrawRectangle(p, New Rectangle(DataGridView1.Location + New Size(1, 1), DataGridView1.Size - New Size(2, 2)))
        p.Dispose()
    End Sub

End Class