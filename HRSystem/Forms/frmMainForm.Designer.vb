<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainForm))
        Me.pNavigate = New System.Windows.Forms.Panel()
        Me.Pending_Panel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PendingNo_LBL = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel_Maintenance = New System.Windows.Forms.Panel()
        Me.lbl_Address = New System.Windows.Forms.Label()
        Me.lbl_UserManage = New System.Windows.Forms.Label()
        Me.lbl_Branch = New System.Windows.Forms.Label()
        Me.lbl_UserLogs = New System.Windows.Forms.Label()
        Me.lbl_Backup = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectToDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImportEployeeFromFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DailyReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManPowerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelieverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeclinedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeclinedToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssesmentToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AppointmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthlyReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManPowerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelieverToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MontlyAggreeAssignToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelievedAgreementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssesmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AppointmentToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BhouseAllowanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManPowerActiveListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManPowerReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AppTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AppDateTime = New System.Windows.Forms.Label()
        Me.AppProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Question_lbl = New System.Windows.Forms.Label()
        Me.minimize_lbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Exit_lbl = New System.Windows.Forms.Label()
        Me.BHouse_AllowanceDataSet1 = New HRSystem.BHouse_AllowanceDataSet()
        Me.NavagationPanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ID_LBL = New System.Windows.Forms.Label()
        Me.UserName_LBL = New System.Windows.Forms.Label()
        Me.Dashboard_BTN = New System.Windows.Forms.Button()
        Me.Coorective_BTN = New System.Windows.Forms.Button()
        Me.btn_Letter = New System.Windows.Forms.Button()
        Me.btnWorkManage = New System.Windows.Forms.Button()
        Me.btn_Maintenance_Panel = New System.Windows.Forms.Button()
        Me.btnManageEmployee = New System.Windows.Forms.Button()
        Me.Monitoring_BTN = New System.Windows.Forms.Button()
        Me.Compensation_BTN = New System.Windows.Forms.Button()
        Me.RateEMP_BTN = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.pNavigate.SuspendLayout()
        Me.Pending_Panel.SuspendLayout()
        Me.Panel_Maintenance.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.BHouse_AllowanceDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavagationPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pNavigate
        '
        Me.pNavigate.AllowDrop = True
        Me.pNavigate.AutoSize = True
        Me.pNavigate.BackColor = System.Drawing.Color.Silver
        Me.pNavigate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pNavigate.Controls.Add(Me.Pending_Panel)
        Me.pNavigate.Controls.Add(Me.Panel_Maintenance)
        Me.pNavigate.Location = New System.Drawing.Point(179, 45)
        Me.pNavigate.Name = "pNavigate"
        Me.pNavigate.Size = New System.Drawing.Size(1188, 718)
        Me.pNavigate.TabIndex = 1
        '
        'Pending_Panel
        '
        Me.Pending_Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Pending_Panel.BackColor = System.Drawing.Color.Pink
        Me.Pending_Panel.Controls.Add(Me.Label2)
        Me.Pending_Panel.Controls.Add(Me.PendingNo_LBL)
        Me.Pending_Panel.Controls.Add(Me.Label3)
        Me.Pending_Panel.Location = New System.Drawing.Point(169, 32)
        Me.Pending_Panel.Name = "Pending_Panel"
        Me.Pending_Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.Pending_Panel.Size = New System.Drawing.Size(178, 123)
        Me.Pending_Panel.TabIndex = 5
        Me.Pending_Panel.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kristen ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pendings"
        '
        'PendingNo_LBL
        '
        Me.PendingNo_LBL.AutoSize = True
        Me.PendingNo_LBL.Font = New System.Drawing.Font("Kristen ITC", 20.0!)
        Me.PendingNo_LBL.Location = New System.Drawing.Point(79, 79)
        Me.PendingNo_LBL.Name = "PendingNo_LBL"
        Me.PendingNo_LBL.Size = New System.Drawing.Size(31, 36)
        Me.PendingNo_LBL.TabIndex = 1
        Me.PendingNo_LBL.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kristen ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Show Cause"
        '
        'Panel_Maintenance
        '
        Me.Panel_Maintenance.BackColor = System.Drawing.Color.LightGray
        Me.Panel_Maintenance.Controls.Add(Me.lbl_Address)
        Me.Panel_Maintenance.Controls.Add(Me.lbl_UserManage)
        Me.Panel_Maintenance.Controls.Add(Me.lbl_Branch)
        Me.Panel_Maintenance.Controls.Add(Me.lbl_UserLogs)
        Me.Panel_Maintenance.Controls.Add(Me.lbl_Backup)
        Me.Panel_Maintenance.Location = New System.Drawing.Point(-1, 32)
        Me.Panel_Maintenance.Name = "Panel_Maintenance"
        Me.Panel_Maintenance.Size = New System.Drawing.Size(133, 156)
        Me.Panel_Maintenance.TabIndex = 0
        Me.Panel_Maintenance.Visible = False
        '
        'lbl_Address
        '
        Me.lbl_Address.AutoSize = True
        Me.lbl_Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Address.Location = New System.Drawing.Point(37, 12)
        Me.lbl_Address.Name = "lbl_Address"
        Me.lbl_Address.Size = New System.Drawing.Size(59, 16)
        Me.lbl_Address.TabIndex = 0
        Me.lbl_Address.Text = "Address"
        '
        'lbl_UserManage
        '
        Me.lbl_UserManage.AutoSize = True
        Me.lbl_UserManage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_UserManage.Location = New System.Drawing.Point(11, 68)
        Me.lbl_UserManage.Name = "lbl_UserManage"
        Me.lbl_UserManage.Size = New System.Drawing.Size(119, 16)
        Me.lbl_UserManage.TabIndex = 2
        Me.lbl_UserManage.Text = "User Management"
        '
        'lbl_Branch
        '
        Me.lbl_Branch.AutoSize = True
        Me.lbl_Branch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Branch.Location = New System.Drawing.Point(41, 41)
        Me.lbl_Branch.Name = "lbl_Branch"
        Me.lbl_Branch.Size = New System.Drawing.Size(50, 16)
        Me.lbl_Branch.TabIndex = 1
        Me.lbl_Branch.Text = "Branch"
        '
        'lbl_UserLogs
        '
        Me.lbl_UserLogs.AutoSize = True
        Me.lbl_UserLogs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_UserLogs.Location = New System.Drawing.Point(32, 99)
        Me.lbl_UserLogs.Name = "lbl_UserLogs"
        Me.lbl_UserLogs.Size = New System.Drawing.Size(70, 16)
        Me.lbl_UserLogs.TabIndex = 3
        Me.lbl_UserLogs.Text = "User Logs"
        '
        'lbl_Backup
        '
        Me.lbl_Backup.AutoSize = True
        Me.lbl_Backup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Backup.Location = New System.Drawing.Point(37, 127)
        Me.lbl_Backup.Name = "lbl_Backup"
        Me.lbl_Backup.Size = New System.Drawing.Size(54, 16)
        Me.lbl_Backup.TabIndex = 4
        Me.lbl_Backup.Text = "Backup"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.AboutUsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(-5, 49)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(172, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.ConnectToDatabaseToolStripMenuItem, Me.ToolStripSeparator1, Me.ImportEployeeFromFileToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.LoginToolStripMenuItem.Text = "&Login"
        '
        'ConnectToDatabaseToolStripMenuItem
        '
        Me.ConnectToDatabaseToolStripMenuItem.Name = "ConnectToDatabaseToolStripMenuItem"
        Me.ConnectToDatabaseToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.ConnectToDatabaseToolStripMenuItem.Text = "&Connect to Database"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(214, 6)
        '
        'ImportEployeeFromFileToolStripMenuItem
        '
        Me.ImportEployeeFromFileToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.ImportEployeeFromFileToolStripMenuItem.Name = "ImportEployeeFromFileToolStripMenuItem"
        Me.ImportEployeeFromFileToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.ImportEployeeFromFileToolStripMenuItem.Text = "Import Employee From File"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(214, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DailyReportToolStripMenuItem, Me.MonthlyReportToolStripMenuItem, Me.ManPowerActiveListToolStripMenuItem, Me.ManPowerReportToolStripMenuItem})
        Me.ReportsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "&Reports"
        '
        'DailyReportToolStripMenuItem
        '
        Me.DailyReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManPowerToolStripMenuItem, Me.RelieverToolStripMenuItem, Me.DeclinedToolStripMenuItem, Me.DeclinedToolStripMenuItem1, Me.AssesmentToolStripMenuItem1, Me.AppointmentToolStripMenuItem})
        Me.DailyReportToolStripMenuItem.Name = "DailyReportToolStripMenuItem"
        Me.DailyReportToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.DailyReportToolStripMenuItem.Text = "Daily Report"
        '
        'ManPowerToolStripMenuItem
        '
        Me.ManPowerToolStripMenuItem.Name = "ManPowerToolStripMenuItem"
        Me.ManPowerToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ManPowerToolStripMenuItem.Text = "Man Power"
        '
        'RelieverToolStripMenuItem
        '
        Me.RelieverToolStripMenuItem.Name = "RelieverToolStripMenuItem"
        Me.RelieverToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.RelieverToolStripMenuItem.Text = "Reliever"
        '
        'DeclinedToolStripMenuItem
        '
        Me.DeclinedToolStripMenuItem.Name = "DeclinedToolStripMenuItem"
        Me.DeclinedToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.DeclinedToolStripMenuItem.Text = "Assigned Agreement"
        '
        'DeclinedToolStripMenuItem1
        '
        Me.DeclinedToolStripMenuItem1.Name = "DeclinedToolStripMenuItem1"
        Me.DeclinedToolStripMenuItem1.Size = New System.Drawing.Size(184, 22)
        Me.DeclinedToolStripMenuItem1.Text = "Relieved Agreement"
        '
        'AssesmentToolStripMenuItem1
        '
        Me.AssesmentToolStripMenuItem1.Name = "AssesmentToolStripMenuItem1"
        Me.AssesmentToolStripMenuItem1.Size = New System.Drawing.Size(184, 22)
        Me.AssesmentToolStripMenuItem1.Text = "Assesment"
        '
        'AppointmentToolStripMenuItem
        '
        Me.AppointmentToolStripMenuItem.Name = "AppointmentToolStripMenuItem"
        Me.AppointmentToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.AppointmentToolStripMenuItem.Text = "Appointment"
        '
        'MonthlyReportToolStripMenuItem
        '
        Me.MonthlyReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManPowerToolStripMenuItem1, Me.RelieverToolStripMenuItem1, Me.MontlyAggreeAssignToolStripMenuItem, Me.RelievedAgreementToolStripMenuItem, Me.AssesmentToolStripMenuItem, Me.AppointmentToolStripMenuItem1, Me.BhouseAllowanceToolStripMenuItem})
        Me.MonthlyReportToolStripMenuItem.Name = "MonthlyReportToolStripMenuItem"
        Me.MonthlyReportToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.MonthlyReportToolStripMenuItem.Text = "Monthly Report"
        '
        'ManPowerToolStripMenuItem1
        '
        Me.ManPowerToolStripMenuItem1.Name = "ManPowerToolStripMenuItem1"
        Me.ManPowerToolStripMenuItem1.Size = New System.Drawing.Size(184, 22)
        Me.ManPowerToolStripMenuItem1.Text = "Man Power"
        '
        'RelieverToolStripMenuItem1
        '
        Me.RelieverToolStripMenuItem1.Name = "RelieverToolStripMenuItem1"
        Me.RelieverToolStripMenuItem1.Size = New System.Drawing.Size(184, 22)
        Me.RelieverToolStripMenuItem1.Text = "Reliever"
        '
        'MontlyAggreeAssignToolStripMenuItem
        '
        Me.MontlyAggreeAssignToolStripMenuItem.Name = "MontlyAggreeAssignToolStripMenuItem"
        Me.MontlyAggreeAssignToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.MontlyAggreeAssignToolStripMenuItem.Text = "Assigned Agreement"
        '
        'RelievedAgreementToolStripMenuItem
        '
        Me.RelievedAgreementToolStripMenuItem.Name = "RelievedAgreementToolStripMenuItem"
        Me.RelievedAgreementToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.RelievedAgreementToolStripMenuItem.Text = "Relieved Agreement"
        '
        'AssesmentToolStripMenuItem
        '
        Me.AssesmentToolStripMenuItem.Name = "AssesmentToolStripMenuItem"
        Me.AssesmentToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.AssesmentToolStripMenuItem.Text = "Assesment"
        '
        'AppointmentToolStripMenuItem1
        '
        Me.AppointmentToolStripMenuItem1.Name = "AppointmentToolStripMenuItem1"
        Me.AppointmentToolStripMenuItem1.Size = New System.Drawing.Size(184, 22)
        Me.AppointmentToolStripMenuItem1.Text = "Appointment"
        '
        'BhouseAllowanceToolStripMenuItem
        '
        Me.BhouseAllowanceToolStripMenuItem.Name = "BhouseAllowanceToolStripMenuItem"
        Me.BhouseAllowanceToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.BhouseAllowanceToolStripMenuItem.Text = "Bhouse Allowance"
        '
        'ManPowerActiveListToolStripMenuItem
        '
        Me.ManPowerActiveListToolStripMenuItem.Name = "ManPowerActiveListToolStripMenuItem"
        Me.ManPowerActiveListToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ManPowerActiveListToolStripMenuItem.Text = "Man Power Active List"
        '
        'ManPowerReportToolStripMenuItem
        '
        Me.ManPowerReportToolStripMenuItem.Name = "ManPowerReportToolStripMenuItem"
        Me.ManPowerReportToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ManPowerReportToolStripMenuItem.Text = "Man Power Report"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.AboutUsToolStripMenuItem.Text = "About Us"
        '
        'AppTimer
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.AppDateTime)
        Me.Panel1.Controls.Add(Me.AppProgressBar)
        Me.Panel1.Controls.Add(Me.Question_lbl)
        Me.Panel1.Controls.Add(Me.minimize_lbl)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Exit_lbl)
        Me.Panel1.Location = New System.Drawing.Point(179, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1188, 46)
        Me.Panel1.TabIndex = 20
        '
        'AppDateTime
        '
        Me.AppDateTime.AutoSize = True
        Me.AppDateTime.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppDateTime.ForeColor = System.Drawing.Color.Black
        Me.AppDateTime.Location = New System.Drawing.Point(0, 4)
        Me.AppDateTime.Name = "AppDateTime"
        Me.AppDateTime.Size = New System.Drawing.Size(34, 13)
        Me.AppDateTime.TabIndex = 19
        Me.AppDateTime.Text = "  0:00"
        '
        'AppProgressBar
        '
        Me.AppProgressBar.Location = New System.Drawing.Point(0, 42)
        Me.AppProgressBar.Maximum = 1000
        Me.AppProgressBar.Name = "AppProgressBar"
        Me.AppProgressBar.Size = New System.Drawing.Size(1186, 3)
        Me.AppProgressBar.TabIndex = 7
        '
        'Question_lbl
        '
        Me.Question_lbl.AutoSize = True
        Me.Question_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Question_lbl.ForeColor = System.Drawing.Color.Black
        Me.Question_lbl.Location = New System.Drawing.Point(1112, -2)
        Me.Question_lbl.Name = "Question_lbl"
        Me.Question_lbl.Size = New System.Drawing.Size(32, 32)
        Me.Question_lbl.TabIndex = 6
        Me.Question_lbl.Text = "?"
        '
        'minimize_lbl
        '
        Me.minimize_lbl.AutoSize = True
        Me.minimize_lbl.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minimize_lbl.ForeColor = System.Drawing.Color.Black
        Me.minimize_lbl.Location = New System.Drawing.Point(1138, -1)
        Me.minimize_lbl.Name = "minimize_lbl"
        Me.minimize_lbl.Size = New System.Drawing.Size(24, 27)
        Me.minimize_lbl.TabIndex = 5
        Me.minimize_lbl.Text = "_"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(418, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Human Resource Management System"
        '
        'Exit_lbl
        '
        Me.Exit_lbl.AutoSize = True
        Me.Exit_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_lbl.ForeColor = System.Drawing.Color.Black
        Me.Exit_lbl.Location = New System.Drawing.Point(1159, 3)
        Me.Exit_lbl.Name = "Exit_lbl"
        Me.Exit_lbl.Size = New System.Drawing.Size(27, 25)
        Me.Exit_lbl.TabIndex = 4
        Me.Exit_lbl.Text = "X"
        '
        'BHouse_AllowanceDataSet1
        '
        Me.BHouse_AllowanceDataSet1.DataSetName = "BHouse_AllowanceDataSet"
        Me.BHouse_AllowanceDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NavagationPanel
        '
        Me.NavagationPanel.BackColor = System.Drawing.Color.White
        Me.NavagationPanel.Controls.Add(Me.Panel2)
        Me.NavagationPanel.Controls.Add(Me.Dashboard_BTN)
        Me.NavagationPanel.Controls.Add(Me.Coorective_BTN)
        Me.NavagationPanel.Controls.Add(Me.btn_Letter)
        Me.NavagationPanel.Controls.Add(Me.btnWorkManage)
        Me.NavagationPanel.Controls.Add(Me.btn_Maintenance_Panel)
        Me.NavagationPanel.Controls.Add(Me.btnManageEmployee)
        Me.NavagationPanel.Controls.Add(Me.Monitoring_BTN)
        Me.NavagationPanel.Controls.Add(Me.Compensation_BTN)
        Me.NavagationPanel.Controls.Add(Me.RateEMP_BTN)
        Me.NavagationPanel.Location = New System.Drawing.Point(0, 2)
        Me.NavagationPanel.Name = "NavagationPanel"
        Me.NavagationPanel.Size = New System.Drawing.Size(176, 762)
        Me.NavagationPanel.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Controls.Add(Me.ID_LBL)
        Me.Panel2.Controls.Add(Me.UserName_LBL)
        Me.Panel2.Location = New System.Drawing.Point(0, -2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(184, 78)
        Me.Panel2.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HRSystem.My.Resources.Resources.home3
        Me.PictureBox1.Location = New System.Drawing.Point(5, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'ID_LBL
        '
        Me.ID_LBL.AutoSize = True
        Me.ID_LBL.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_LBL.ForeColor = System.Drawing.Color.White
        Me.ID_LBL.Location = New System.Drawing.Point(160, 6)
        Me.ID_LBL.Name = "ID_LBL"
        Me.ID_LBL.Size = New System.Drawing.Size(13, 15)
        Me.ID_LBL.TabIndex = 16
        Me.ID_LBL.Text = "0"
        Me.ID_LBL.Visible = False
        '
        'UserName_LBL
        '
        Me.UserName_LBL.AutoSize = True
        Me.UserName_LBL.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserName_LBL.ForeColor = System.Drawing.Color.White
        Me.UserName_LBL.Location = New System.Drawing.Point(33, 16)
        Me.UserName_LBL.Name = "UserName_LBL"
        Me.UserName_LBL.Size = New System.Drawing.Size(16, 15)
        Me.UserName_LBL.TabIndex = 17
        Me.UserName_LBL.Text = "   "
        '
        'Dashboard_BTN
        '
        Me.Dashboard_BTN.BackColor = System.Drawing.Color.Black
        Me.Dashboard_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Dashboard_BTN.FlatAppearance.BorderSize = 0
        Me.Dashboard_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Dashboard_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dashboard_BTN.ForeColor = System.Drawing.Color.White
        Me.Dashboard_BTN.Image = Global.HRSystem.My.Resources.Resources.details_50px
        Me.Dashboard_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Dashboard_BTN.Location = New System.Drawing.Point(-1, 687)
        Me.Dashboard_BTN.Name = "Dashboard_BTN"
        Me.Dashboard_BTN.Size = New System.Drawing.Size(177, 75)
        Me.Dashboard_BTN.TabIndex = 10
        Me.Dashboard_BTN.Text = "               Under Deve.."
        Me.Dashboard_BTN.UseVisualStyleBackColor = False
        '
        'Coorective_BTN
        '
        Me.Coorective_BTN.BackColor = System.Drawing.Color.Black
        Me.Coorective_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Coorective_BTN.FlatAppearance.BorderSize = 0
        Me.Coorective_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Coorective_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Coorective_BTN.ForeColor = System.Drawing.Color.White
        Me.Coorective_BTN.Image = Global.HRSystem.My.Resources.Resources.report_card_50px
        Me.Coorective_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Coorective_BTN.Location = New System.Drawing.Point(0, 307)
        Me.Coorective_BTN.Name = "Coorective_BTN"
        Me.Coorective_BTN.Size = New System.Drawing.Size(177, 75)
        Me.Coorective_BTN.TabIndex = 12
        Me.Coorective_BTN.Text = "         &Corrective"
        Me.Coorective_BTN.UseVisualStyleBackColor = False
        '
        'btn_Letter
        '
        Me.btn_Letter.BackColor = System.Drawing.Color.Black
        Me.btn_Letter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Letter.FlatAppearance.BorderSize = 0
        Me.btn_Letter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Letter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Letter.ForeColor = System.Drawing.Color.White
        Me.btn_Letter.Image = Global.HRSystem.My.Resources.Resources._21
        Me.btn_Letter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Letter.Location = New System.Drawing.Point(0, 231)
        Me.btn_Letter.Name = "btn_Letter"
        Me.btn_Letter.Size = New System.Drawing.Size(177, 75)
        Me.btn_Letter.TabIndex = 11
        Me.btn_Letter.Text = "   Letter"
        Me.btn_Letter.UseVisualStyleBackColor = False
        '
        'btnWorkManage
        '
        Me.btnWorkManage.BackColor = System.Drawing.Color.Black
        Me.btnWorkManage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWorkManage.FlatAppearance.BorderSize = 0
        Me.btnWorkManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWorkManage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWorkManage.ForeColor = System.Drawing.Color.White
        Me.btnWorkManage.Image = Global.HRSystem.My.Resources.Resources.business_50px
        Me.btnWorkManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWorkManage.Location = New System.Drawing.Point(-1, 611)
        Me.btnWorkManage.Name = "btnWorkManage"
        Me.btnWorkManage.Size = New System.Drawing.Size(177, 75)
        Me.btnWorkManage.TabIndex = 4
        Me.btnWorkManage.Text = "               Under Deve.."
        Me.btnWorkManage.UseVisualStyleBackColor = False
        '
        'btn_Maintenance_Panel
        '
        Me.btn_Maintenance_Panel.BackColor = System.Drawing.Color.Black
        Me.btn_Maintenance_Panel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Maintenance_Panel.FlatAppearance.BorderSize = 0
        Me.btn_Maintenance_Panel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Maintenance_Panel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Maintenance_Panel.ForeColor = System.Drawing.Color.White
        Me.btn_Maintenance_Panel.Image = Global.HRSystem.My.Resources.Resources._17
        Me.btn_Maintenance_Panel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Maintenance_Panel.Location = New System.Drawing.Point(0, 79)
        Me.btn_Maintenance_Panel.Name = "btn_Maintenance_Panel"
        Me.btn_Maintenance_Panel.Size = New System.Drawing.Size(177, 75)
        Me.btn_Maintenance_Panel.TabIndex = 3
        Me.btn_Maintenance_Panel.Text = "               Maintenance     >"
        Me.btn_Maintenance_Panel.UseVisualStyleBackColor = False
        '
        'btnManageEmployee
        '
        Me.btnManageEmployee.BackColor = System.Drawing.Color.Black
        Me.btnManageEmployee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManageEmployee.FlatAppearance.BorderSize = 0
        Me.btnManageEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageEmployee.ForeColor = System.Drawing.Color.White
        Me.btnManageEmployee.Image = Global.HRSystem.My.Resources.Resources.employee_card_50px
        Me.btnManageEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManageEmployee.Location = New System.Drawing.Point(-1, 155)
        Me.btnManageEmployee.Name = "btnManageEmployee"
        Me.btnManageEmployee.Size = New System.Drawing.Size(177, 75)
        Me.btnManageEmployee.TabIndex = 2
        Me.btnManageEmployee.Text = "       &Records"
        Me.btnManageEmployee.UseVisualStyleBackColor = False
        '
        'Monitoring_BTN
        '
        Me.Monitoring_BTN.BackColor = System.Drawing.Color.Black
        Me.Monitoring_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Monitoring_BTN.FlatAppearance.BorderSize = 0
        Me.Monitoring_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Monitoring_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Monitoring_BTN.ForeColor = System.Drawing.Color.White
        Me.Monitoring_BTN.Image = Global.HRSystem.My.Resources.Resources.attendance_mark_50px
        Me.Monitoring_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Monitoring_BTN.Location = New System.Drawing.Point(0, 383)
        Me.Monitoring_BTN.Name = "Monitoring_BTN"
        Me.Monitoring_BTN.Size = New System.Drawing.Size(177, 75)
        Me.Monitoring_BTN.TabIndex = 13
        Me.Monitoring_BTN.Text = "               Under Deve.."
        Me.Monitoring_BTN.UseVisualStyleBackColor = False
        '
        'Compensation_BTN
        '
        Me.Compensation_BTN.BackColor = System.Drawing.Color.Black
        Me.Compensation_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Compensation_BTN.FlatAppearance.BorderSize = 0
        Me.Compensation_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Compensation_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Compensation_BTN.ForeColor = System.Drawing.Color.White
        Me.Compensation_BTN.Image = Global.HRSystem.My.Resources.Resources.receive_cash_50px1
        Me.Compensation_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Compensation_BTN.Location = New System.Drawing.Point(0, 459)
        Me.Compensation_BTN.Name = "Compensation_BTN"
        Me.Compensation_BTN.Size = New System.Drawing.Size(177, 75)
        Me.Compensation_BTN.TabIndex = 8
        Me.Compensation_BTN.Text = "               Under Deve.."
        Me.Compensation_BTN.UseVisualStyleBackColor = False
        '
        'RateEMP_BTN
        '
        Me.RateEMP_BTN.BackColor = System.Drawing.Color.Black
        Me.RateEMP_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RateEMP_BTN.FlatAppearance.BorderSize = 0
        Me.RateEMP_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RateEMP_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RateEMP_BTN.ForeColor = System.Drawing.Color.White
        Me.RateEMP_BTN.Image = Global.HRSystem.My.Resources.Resources.combo_chart_50px
        Me.RateEMP_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RateEMP_BTN.Location = New System.Drawing.Point(0, 535)
        Me.RateEMP_BTN.Name = "RateEMP_BTN"
        Me.RateEMP_BTN.Size = New System.Drawing.Size(177, 75)
        Me.RateEMP_BTN.TabIndex = 7
        Me.RateEMP_BTN.Text = "               Under Deve.."
        Me.RateEMP_BTN.UseVisualStyleBackColor = False
        '
        'frmMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1367, 766)
        Me.Controls.Add(Me.NavagationPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pNavigate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1386, 788)
        Me.MinimumSize = New System.Drawing.Size(1364, 726)
        Me.Name = "frmMainForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Human Resource Management System Main Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pNavigate.ResumeLayout(False)
        Me.Pending_Panel.ResumeLayout(False)
        Me.Pending_Panel.PerformLayout()
        Me.Panel_Maintenance.ResumeLayout(False)
        Me.Panel_Maintenance.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BHouse_AllowanceDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavagationPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pNavigate As System.Windows.Forms.Panel
    Friend WithEvents btnManageEmployee As System.Windows.Forms.Button
    Friend WithEvents btnWorkManage As System.Windows.Forms.Button
    Friend WithEvents RateEMP_BTN As System.Windows.Forms.Button
    Friend WithEvents Compensation_BTN As System.Windows.Forms.Button
    Friend WithEvents Dashboard_BTN As System.Windows.Forms.Button
    Friend WithEvents Coorective_BTN As System.Windows.Forms.Button
    Friend WithEvents AppTimer As System.Windows.Forms.Timer
    Friend WithEvents Monitoring_BTN As Button
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConnectToDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ImportEployeeFromFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DailyReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManPowerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelieverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeclinedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeclinedToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AssesmentToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AppointmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonthlyReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManPowerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RelieverToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MontlyAggreeAssignToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelievedAgreementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AssesmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AppointmentToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BhouseAllowanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManPowerActiveListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManPowerReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Exit_lbl As Label
    Friend WithEvents BHouse_AllowanceDataSet1 As BHouse_AllowanceDataSet
    Friend WithEvents minimize_lbl As Label
    Friend WithEvents NavagationPanel As Panel
    Friend WithEvents btn_Maintenance_Panel As Button
    Friend WithEvents lbl_UserManage As Label
    Friend WithEvents lbl_Branch As Label
    Friend WithEvents lbl_Address As Label
    Friend WithEvents lbl_Backup As Label
    Friend WithEvents lbl_UserLogs As Label
    Friend WithEvents btn_Letter As Button
    Friend WithEvents Panel_Maintenance As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Question_lbl As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents UserName_LBL As Label
    Friend WithEvents ID_LBL As Label
    Friend WithEvents AppProgressBar As ProgressBar
    Friend WithEvents AppDateTime As Label
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Pending_Panel As Panel
    Friend WithEvents PendingNo_LBL As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
