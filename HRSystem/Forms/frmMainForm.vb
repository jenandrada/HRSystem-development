Imports System.Globalization
Imports System.IO
Imports DBConnect
Imports DBConnect.Tools
Imports FirebirdSql.Data.FirebirdClient

Public Class frmMainForm
    Dim mPower As ManPower
    Dim bh As BhouseAllowance

    Private Sub btnManageEmployee_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnManageEmployee.Click
        OpenWindowsForm("frmEmployeeList")

    End Sub

    Private Sub frmMainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Panel_Maintenance.Visible = False
        AppTimer.Start()
        AppDateTime.Text = Date.Now.ToString("dddd, MMMM dd, yyyy hh:mm:ss tt", CultureInfo.CurrentCulture)
        Text = Text & " | Version " & [GetType].Assembly.GetName.Version.ToString
        NotYetLogin(False)
        If NavagationPanel.VerticalScroll.Visible = True Then
            NavagationPanel.Width = 192
        Else
            NavagationPanel.Width = 176
        End If

    End Sub

    Private Sub AddressToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        OpenWindowsForm("frmAddress")
        'NavigateToPages(ProcessPage.Address)
    End Sub

    Private Sub btnWorkManage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnWorkManage.Click
        'OpenWindowsForm("FormManagement")
        'FormManagement.BringToFront()
    End Sub

    Private Sub BranchToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        OpenWindowsForm("frmBranch")
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        AboutUs.Show()
    End Sub

    Private Sub ManPowerToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ManPowerToolStripMenuItem.Click
        frmGenerate.FormType = frmGenerate.ReportType.Manpower
        frmGenerate.Show()
    End Sub

    Friend Sub NotYetLogin(ByVal st As Boolean, Optional idx As String = "", Optional username As String = "")
        For Each obj As Object In NavagationPanel.Controls
            If TypeOf obj Is Button Then
                Dim btn As Button = obj
                btn.Enabled = st
            End If
        Next
        'MaintenanceToolStripMenuItem.Enabled = st
        ReportsToolStripMenuItem.Enabled = st
        ImportEployeeFromFileToolStripMenuItem.Enabled = st
        If Not st Then
            LoginToolStripMenuItem.Text = "&Login"
        Else
            LoginToolStripMenuItem.Text = "&Logout"
            If UserName_LBL.Text = "LYN MARY LEGASPI" Then
                NotifyRatings()
                NotifyBhAllowance()
            End If
        End If
        ID_LBL.Text = idx
        UserName_LBL.Text = username
    End Sub

    Public Sub NotifyRatings()
        Dim weekNotify As New Date
        Dim monthNotify As New Date

        mPower = New ManPower
        mPower.LOADMANNIGRatings()
        With mPower
            If String.IsNullOrEmpty(.Weeklynotify) Then
                weekNotify = Date.Now.ToShortDateString
            Else
                weekNotify = .Weeklynotify
                monthNotify = .Monthlynotify
            End If

            Dim startDate As Date = weekNotify
            Dim stopDate As Date = weekNotify.AddDays(7)
            Dim interval As Integer = 1

            If startDate <= Date.Now.ToShortDateString Then
                startDate = Date.Now.ToShortDateString
            Else
                Exit Sub
            End If
            If startDate <= stopDate Then
                startDate += TimeSpan.FromDays(interval)
                OpenWindowsForm("frmnotify")

            Else
                Exit Sub
            End If
        End With
    End Sub

    Private Sub NotifyBhAllowance()
        Dim dateNotify = New Date
        bh = New BhouseAllowance
        bh.LoadAllowanceNotify()
        With bh
            If String.IsNullOrEmpty(.Date_Notify) Then
                dateNotify = Date.Now.ToShortDateString
            Else
                dateNotify = .Date_Notify
            End If
            Dim startDate As Date = dateNotify
            Dim stopDate As Date = dateNotify.AddDays(5)
            Dim interval As Integer = 1
            If startDate <= Date.Now.ToShortDateString Then
                startDate = Date.Now.ToShortDateString
            Else
                Exit Sub
            End If
            If startDate <= stopDate Then
                startDate += TimeSpan.FromDays(interval)
                OpenWindowsForm("frmAllowanceNotify")
            Else
                Exit Sub
            End If
        End With
    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LoginToolStripMenuItem.Click
        If LoginToolStripMenuItem.Text = "&Login" Then
            frmLogin.Show()
        Else
            Close()
        End If

    End Sub

    Private Sub UserManagementToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        OpenWindowsForm("frmUser")
    End Sub

    Private Sub ManPowerToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ManPowerToolStripMenuItem1.Click
        frmGenerate.FormType = frmGenerate.ReportType.ManpowerMonthly
        frmGenerate.Show()
    End Sub

    Private Sub ManPowerActiveListToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ManPowerActiveListToolStripMenuItem.Click
        frmGenerate.FormType = frmGenerate.ReportType.ActiveList
        frmGenerate.Show()
    End Sub

    Private Sub RelieverToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RelieverToolStripMenuItem.Click
        frmrelieverreport.FormType = frmrelieverreport.ReportType.reliever
        frmrelieverreport.Show()
    End Sub

    Private Sub RelieverToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RelieverToolStripMenuItem1.Click
        frmrelieverreport.FormType = frmrelieverreport.ReportType.monthlyreliev
        frmrelieverreport.Show()
    End Sub

    Private Sub DeclinedToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DeclinedToolStripMenuItem.Click
        frmGenerate.FormType = frmGenerate.ReportType.aggreeassigned
        frmGenerate.Show()
    End Sub

    Private Sub DeclinedToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DeclinedToolStripMenuItem1.Click
        frmGenerate.FormType = frmGenerate.ReportType.relieveaggree
        frmGenerate.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        OpenWindowsForm("frmappointment")
    End Sub

    Private Sub MontlyAggreeAssignToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MontlyAggreeAssignToolStripMenuItem.Click
        frmGenerate.FormType = frmGenerate.ReportType.monthaggreeassigned
        frmGenerate.Show()
    End Sub

    Private Sub RelievedAgreementToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RelievedAgreementToolStripMenuItem.Click
        frmGenerate.FormType = frmGenerate.ReportType.monthaggreeagrrement
        frmGenerate.Show()
    End Sub

    Private Sub AssesmentToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AssesmentToolStripMenuItem1.Click
        frmGenerate.FormType = frmGenerate.ReportType.rating
        frmGenerate.Show()
    End Sub

    Private Sub AssesmentToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AssesmentToolStripMenuItem.Click
        frmGenerate.FormType = frmGenerate.ReportType.ratingmontly
        frmGenerate.Show()
    End Sub

    Private Sub AppointmentToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AppointmentToolStripMenuItem.Click
        frmGenerate.FormType = frmGenerate.ReportType.appointment
        frmGenerate.Show()
    End Sub

    Private Sub AppointmentToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AppointmentToolStripMenuItem1.Click
        frmGenerate.FormType = frmGenerate.ReportType.appointmentmonthly
        frmGenerate.Show()
    End Sub

    Private Sub RateEMP_BTN_Click(sender As Object, e As EventArgs) Handles RateEMP_BTN.Click
        'OpenWindowsForm("frmRateEmp")
    End Sub

    Private Sub BHouseAllowance_BTN_Click(sender As Object, e As EventArgs) Handles Compensation_BTN.Click
        'OpenWindowsForm("frmCompensation")
    End Sub

    Private Sub AppTimer_Tick(sender As Object, e As EventArgs) Handles AppTimer.Tick
        AppDateTime.Text = Now.ToString("dddd, MMMM dd, yyyy hh:mm:ss tt")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Coorective_BTN.Click
        OpenWindowsForm("frmCoorective")
    End Sub

    Private Sub BhouseAllowanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BhouseAllowanceToolStripMenuItem.Click
        frmGenerate.FormType = frmGenerate.ReportType.bhouseallowanceMonthly
        frmGenerate.Show()
    End Sub

    Private Sub ConnectToDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectToDatabaseToolStripMenuItem.Click
        Using conSettings As New ServerSettings
            conSettings.ShowDialog()
        End Using
    End Sub

    Private Sub BackupToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Using backup As New Backup
            backup.ShowDialog()
        End Using
    End Sub

    Private Sub UserLogsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Using logs As New frmUserLogs
            logs.ShowDialog()
        End Using
    End Sub

    Private Sub Dashboard_BTN_Click(sender As Object, e As EventArgs) Handles Dashboard_BTN.Click
        'OpenWindowsForm("frmRecruitmentDashboard")
    End Sub

    Private Sub ManPowerReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManPowerReportToolStripMenuItem.Click
        Dim mpr As New ManPowerRV
        mpr.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'OpenWindowsForm("FrmMonitoring")
    End Sub

    Private Sub ImportEployeeFromFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportEployeeFromFileToolStripMenuItem.Click
        Dim f As New ImportEmpFromFile
        f.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.ExitThread()
    End Sub

    Private Sub Exit_lbl_Click(sender As Object, e As EventArgs) Handles Exit_lbl.Click
        Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles minimize_lbl.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    '-------------------------------------------------Mouse ENTER/ Mouse EXIT--------------------------------------

    Private Sub btnManageEmployee_MouseEnter(sender As Object, e As EventArgs) Handles btnManageEmployee.MouseEnter
        btnManageEmployee.BackColor = Color.DimGray
        Panel_Maintenance.Visible = False
    End Sub

    Private Sub btnManageEmployee_MouseLeave(sender As Object, e As EventArgs) Handles btnManageEmployee.MouseLeave
        btnManageEmployee.BackColor = Color.Black
    End Sub

    Private Sub btnWorkManage_MouseEnter(sender As Object, e As EventArgs) Handles btnWorkManage.MouseEnter
        btnWorkManage.BackColor = Color.DimGray
        Panel_Maintenance.Visible = False
    End Sub

    Private Sub btnWorkManage_MouseLeave(sender As Object, e As EventArgs) Handles btnWorkManage.MouseLeave
        btnWorkManage.BackColor = Color.Black
    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.BackColor = Color.DimGray
        Panel_Maintenance.Visible = False
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.Black
    End Sub

    Private Sub BHouseAllowance_BTN_MouseEnter(sender As Object, e As EventArgs) Handles Compensation_BTN.MouseEnter
        Compensation_BTN.BackColor = Color.DimGray
        Panel_Maintenance.Visible = False
    End Sub

    Private Sub BHouseAllowance_BTN_MouseLeave(sender As Object, e As EventArgs) Handles Compensation_BTN.MouseLeave
        Compensation_BTN.BackColor = Color.Black
    End Sub

    Private Sub RateEMP_BTN_MouseEnter(sender As Object, e As EventArgs) Handles RateEMP_BTN.MouseEnter
        RateEMP_BTN.BackColor = Color.DimGray
        Panel_Maintenance.Visible = False
    End Sub

    Private Sub RateEMP_BTN_MouseLeave(sender As Object, e As EventArgs) Handles RateEMP_BTN.MouseLeave
        RateEMP_BTN.BackColor = Color.Black
    End Sub

    Private Sub Coorective_BTN_MouseEnter(sender As Object, e As EventArgs) Handles Coorective_BTN.MouseEnter
        Coorective_BTN.BackColor = Color.DimGray
        Panel_Maintenance.Visible = False
    End Sub

    Private Sub Coorective_BTN_MouseLeave(sender As Object, e As EventArgs) Handles Coorective_BTN.MouseLeave
        Coorective_BTN.BackColor = Color.Black
    End Sub

    Private Sub Dashboard_BTN_MouseEnter(sender As Object, e As EventArgs) Handles Dashboard_BTN.MouseEnter
        Dashboard_BTN.BackColor = Color.DimGray
        Panel_Maintenance.Visible = False
    End Sub

    Private Sub Dashboard_BTN_MouseLeave(sender As Object, e As EventArgs) Handles Dashboard_BTN.MouseLeave
        Dashboard_BTN.BackColor = Color.Black
    End Sub

    Private Sub btn_AboutUs_MouseEnter(sender As Object, e As EventArgs) Handles btn_Letter.MouseEnter
        btn_Letter.BackColor = Color.DimGray
        Panel_Maintenance.Visible = False
    End Sub

    Private Sub btn_AboutUs_MouseLeave(sender As Object, e As EventArgs) Handles btn_Letter.MouseLeave
        btn_Letter.BackColor = Color.Black
    End Sub

    Private Sub Exit_lbl_MouseEnter(sender As Object, e As EventArgs) Handles Exit_lbl.MouseEnter
        Exit_lbl.ForeColor = Color.Red
        Panel_Maintenance.Visible = False
    End Sub

    Private Sub Exit_lbl_MouseLeave(sender As Object, e As EventArgs) Handles Exit_lbl.MouseLeave
        Exit_lbl.ForeColor = Color.Black
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles minimize_lbl.MouseEnter
        minimize_lbl.ForeColor = Color.Red
        Panel_Maintenance.Visible = False
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles minimize_lbl.MouseLeave
        minimize_lbl.ForeColor = Color.Black
    End Sub

    Private Sub lbl_Address_MouseEnter(sender As Object, e As EventArgs) Handles lbl_Address.MouseEnter
        lbl_Address.ForeColor = Color.Red
    End Sub

    Private Sub lbl_Address_MouseLeave(sender As Object, e As EventArgs) Handles lbl_Address.MouseLeave
        lbl_Address.ForeColor = Color.Black
    End Sub

    Private Sub lbl_Branch_MouseEnter(sender As Object, e As EventArgs) Handles lbl_Branch.MouseEnter
        Panel_Maintenance.Capture = True
        lbl_Branch.ForeColor = Color.Red
    End Sub

    Private Sub lbl_Branch_MouseLeave(sender As Object, e As EventArgs) Handles lbl_Branch.MouseLeave
        Panel_Maintenance.Capture = False
        lbl_Branch.ForeColor = Color.Black
    End Sub

    Private Sub lbl_UserManage_MouseEnter(sender As Object, e As EventArgs) Handles lbl_UserManage.MouseEnter
        lbl_UserManage.ForeColor = Color.Red
    End Sub
    Private Sub lbl_UserManage_MouseLeave(sender As Object, e As EventArgs) Handles lbl_UserManage.MouseLeave
        lbl_UserManage.ForeColor = Color.Black
    End Sub

    Private Sub lbl_UserLogs_MouseEnter(sender As Object, e As EventArgs) Handles lbl_UserLogs.MouseEnter
        lbl_UserLogs.ForeColor = Color.Red
    End Sub
    Private Sub lbl_UserLogs_MouseLeave(sender As Object, e As EventArgs) Handles lbl_UserLogs.MouseLeave
        lbl_UserLogs.ForeColor = Color.Black
    End Sub

    Private Sub lbl_Backup_MouseEnter(sender As Object, e As EventArgs) Handles lbl_Backup.MouseEnter
        lbl_Backup.ForeColor = Color.Red
    End Sub

    Private Sub lbl_Backup_MouseLeave(sender As Object, e As EventArgs) Handles lbl_Backup.MouseLeave
        lbl_Backup.ForeColor = Color.Black
    End Sub

    Private Sub lbl_Address_Click(sender As Object, e As EventArgs) Handles lbl_Address.Click
        OpenWindowsForm("frmAddress")
        Panel_Maintenance.Visible = False
    End Sub

    Private Sub lbl_Branch_Click(sender As Object, e As EventArgs) Handles lbl_Branch.Click
        OpenWindowsForm("frmBranch")
        Panel_Maintenance.Visible = False
    End Sub


    Private Sub lbl_UserManage_Click(sender As Object, e As EventArgs) Handles lbl_UserManage.Click
        OpenWindowsForm("frmUser")
        Panel_Maintenance.Visible = False
    End Sub

    Private Sub lbl_UserLogs_Click(sender As Object, e As EventArgs) Handles lbl_UserLogs.Click
        Panel_Maintenance.Visible = False
        'Using logs As New frmUserLogs
        '    logs.ShowDialog()
        'End Using
        OpenWindowsForm("frmUserLogs")
    End Sub

    Private Sub lbl_Backup_Click(sender As Object, e As EventArgs) Handles lbl_Backup.Click
        Panel_Maintenance.Visible = False
        Using backup As New Backup
            backup.ShowDialog()
        End Using
    End Sub

    Private Sub btn_Maintenance_Panel_Click(sender As Object, e As EventArgs) Handles btn_Maintenance_Panel.Click
        Panel_Maintenance.Visible = True
        Panel_Maintenance.BringToFront()
    End Sub

    Private Sub btn_Maintenance_Panel_MouseEnter(sender As Object, e As EventArgs) Handles btn_Maintenance_Panel.MouseEnter
        btn_Maintenance_Panel.BackColor = Color.DimGray
    End Sub

    Private Sub btn_Maintenance_Panel_MouseLeave(sender As Object, e As EventArgs) Handles btn_Maintenance_Panel.MouseLeave
        btn_Maintenance_Panel.BackColor = Color.Black
    End Sub

    Private Sub Panel_Maintenance_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_Maintenance.MouseMove
        Dim pt As New Point(e.X, e.Y)

        If Not Panel_Maintenance.ClientRectangle.Contains(pt) Then
            Panel_Maintenance.Visible = False
            Panel_Maintenance.Capture = False
        Else
            Panel_Maintenance.Visible = True
        End If
    End Sub

    Private Sub Panel_Maintenance_MouseEnter(sender As Object, e As EventArgs) Handles Panel_Maintenance.MouseEnter
        Panel_Maintenance.Capture = True
    End Sub

    Private Sub Panel_Maintenance_MouseLeave(sender As Object, e As EventArgs) Handles Panel_Maintenance.MouseLeave
        Panel_Maintenance.Capture = False
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        AboutUs.Show()
    End Sub

    Private Sub btn_Letter_Click(sender As Object, e As EventArgs) Handles btn_Letter.Click
        OpenWindowsForm("frmLetter")
        frmLetter.BringToFront()
    End Sub

    Private Sub Question_lbl_Click(sender As Object, e As EventArgs) Handles Question_lbl.Click
        AboutUs.Show()
    End Sub

    Private Sub ExportImagesToFolderToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'LoadREquirementsPictures()
    End Sub

    Friend Sub LoadREquirementsPictures()

        Dim mysql As String = "select A.*, c.Lastname, c.Firstname, c.Middlename, c.id as emp_id, d.PROFILE_PIC from TBL_REQARCHIVE A 
                                inner join tbl_req B on A.REQ_ID = B.REQ_ID 
                                inner join tbl_employee C on B.EMPLOYEE_ID = C.ID
                                inner join TBL_Profilepic D on C.ID = D.Emp_ID"

        Dim emptyByte() = New Byte() {1}
        Using ds As DataSet = LoadSQL(mysql)

            For Each dr In ds.Tables(0).Rows
                Dim name As String = dr("Lastname") & ", " & dr("Firstname") & " " & dr("Middlename")

                Console.WriteLine("NAME === " & name & " Req_ID === " & dr("REQ_ID") & "     ID === " & dr("emp_id"))

                FromDatabaseToFolder(IIf(IsDBNull(dr("PROFILE_PIC")), emptyByte, dr("PROFILE_PIC")), "Profile", name)
                FromDatabaseToFolder(IIf(IsDBNull(dr("SSS")), emptyByte, dr("SSS")), "SSS", name)
                FromDatabaseToFolder(IIf(IsDBNull(dr("PHILHEALTH")), emptyByte, dr("PHILHEALTH")), "PhilHealth", name)
                FromDatabaseToFolder(IIf(IsDBNull(dr("PAGIBIG")), emptyByte, dr("PAGIBIG")), "PagIbig", name)
                FromDatabaseToFolder(IIf(IsDBNull(dr("TIN")), emptyByte, dr("TIN")), "TIN", name)
                FromDatabaseToFolder(IIf(IsDBNull(dr("BARANGAYCLEARANCE")), emptyByte, dr("BARANGAYCLEARANCE")), "Barangay Clearance", name)
                FromDatabaseToFolder(IIf(IsDBNull(dr("CEDULA")), emptyByte, dr("CEDULA")), "Cedula", name)
                FromDatabaseToFolder(IIf(IsDBNull(dr("POLICECLEARANCE")), emptyByte, dr("POLICECLEARANCE")), "Police Clearance", name)
                FromDatabaseToFolder(IIf(IsDBNull(dr("NBICLEARANCE")), emptyByte, dr("NBICLEARANCE")), "NBI Clearance", name)
                FromDatabaseToFolder(IIf(IsDBNull(dr("HEALTHCARD")), emptyByte, dr("HEALTHCARD")), "Health Card", name)
                FromDatabaseToFolder(IIf(IsDBNull(dr("MAYORSPERMIT")), emptyByte, dr("MAYORSPERMIT")), "Mayors Permit", name)
                FromDatabaseToFolder(IIf(IsDBNull(dr("PDS")), emptyByte, dr("PDS")), "PDS", name)
                FromDatabaseToFolder(IIf(IsDBNull(dr("PROBA")), emptyByte, dr("PROBA")), "PROBA", name)
                FromDatabaseToFolder(IIf(IsDBNull(dr("MOA")), emptyByte, dr("MOA")), "MOA", name)
                FromDatabaseToFolder(IIf(IsDBNull(dr("IDFORM")), emptyByte, dr("IDFORM")), "ID Form", name)
                FromDatabaseToFolder(IIf(IsDBNull(dr("ACKNOWLEDGEMENTLETTER")), emptyByte, dr("ACKNOWLEDGEMENTLETTER")), "Acknowledgment Letter", name)
                FromDatabaseToFolder(IIf(IsDBNull(dr("ENDORSEMENTLETTER")), emptyByte, dr("ENDORSEMENTLETTER")), "Endorsement Letter", name)
            Next
        End Using

    End Sub

    'Sub AddDirectorySecurity(ByVal FileName As String, ByVal Account As String, ByVal Rights As FileSystemRights, ByVal ControlType As AccessControlType)
    '    ' Create a new DirectoryInfoobject.
    '    Dim dInfo As New DirectoryInfo(FileName)

    '    ' Get a DirectorySecurity object that represents the
    '    ' current security settings.
    '    Dim dSecurity As DirectorySecurity = dInfo.GetAccessControl()

    '    ' Add the FileSystemAccessRule to the security settings.
    '    dSecurity.AddAccessRule(New FileSystemAccessRule(Account, Rights, ControlType))

    '    ' Set the new access settings.
    '    dInfo.SetAccessControl(dSecurity)

    'End Sub

    Public Sub FromDatabaseToFolder(emp As Byte(), ImageName As String, Optional name As String = "")

        Dim folder As String = "201"
        Dim ms As New MemoryStream(emp)
        Dim folderName As DirectoryInfo = New DirectoryInfo("D:\" & folder)
        Dim employee As DirectoryInfo = New DirectoryInfo("D:\" & folder & "\" & name)

        Dim key As Integer = emp.Length
        Try

            If key < 800 Then
                Exit Sub
            Else

                If Not folderName.Exists Then

                    folderName.Create()

                    If Not employee.Exists Then

                        employee.Create()

                        Using img As Image = New Bitmap(Image.FromStream(ms))
                            img.Save("D:\201\" & name & "\" & ImageName & ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg)
                        End Using

                    Else

                        Using img As Image = New Bitmap(Image.FromStream(ms))
                            img.Save("D:\201\" & name & "\" & ImageName & ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg)
                        End Using

                    End If

                Else
                    If Not employee.Exists Then

                        employee.Create()

                        Using img As Image = New Bitmap(Image.FromStream(ms))
                            img.Save("D:\201\" & name & "\" & ImageName & ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg)
                        End Using

                    Else

                        Using img As Image = New Bitmap(Image.FromStream(ms))
                            img.Save("D:\201\" & name & "\" & ImageName & ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg)
                        End Using
                    End If

                End If
            End If

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            ms.Close()
            ms.Dispose()
        End Try
    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        Using cods As New DeveloperCode
            cods.ShowDialog()
            cods.BringToFront()
        End Using
    End Sub

    Private Sub pNavigate_Paint(sender As Object, e As PaintEventArgs) Handles pNavigate.Paint

    End Sub
End Class