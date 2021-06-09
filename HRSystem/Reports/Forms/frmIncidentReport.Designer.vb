<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncidentReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIncidentReport))
        Me.Label21 = New System.Windows.Forms.Label()
        Me.CorrectiveWindow = New System.Windows.Forms.TabControl()
        Me.IR_Page = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.RptViewer_IncidentReport = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.SaveIR_BTN = New System.Windows.Forms.Button()
        Me.ClearIR_BTN = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PreviewIR_BTN = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.PreparedBy_TXT = New System.Windows.Forms.TextBox()
        Me.ReviewedBy_TXT = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Received_TXT = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Description_RichText = New System.Windows.Forms.RichTextBox()
        Me.Supervisor_BTN = New System.Windows.Forms.Button()
        Me.DateReceive_DTP = New System.Windows.Forms.DateTimePicker()
        Me.DateIncident_DTP = New System.Windows.Forms.DateTimePicker()
        Me.Action_CB = New System.Windows.Forms.ComboBox()
        Me.Supervisor_TXT = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.PositionS_TXT = New System.Windows.Forms.TextBox()
        Me.Person_BTN = New System.Windows.Forms.Button()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Person_TXT = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.IncidentLoc_TXT = New System.Windows.Forms.TextBox()
        Me.PositionP_TXT = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Department_TXT = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.IRNo_LBL = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.ShowCause_Page = New System.Windows.Forms.TabPage()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.SCNo_LBL = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.RptViewer_ShowCause = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.EmpName_TXT = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Position_TXT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Branch_TXT = New System.Windows.Forms.TextBox()
        Me.Company_TXT = New System.Windows.Forms.TextBox()
        Me.SearchEMP_BTN = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Optional_Group = New System.Windows.Forms.GroupBox()
        Me.DateSent_DTP = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.SentVia_TXT = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PS3_Btn = New System.Windows.Forms.Button()
        Me.Save_BTN = New System.Windows.Forms.Button()
        Me.PS1_Btn = New System.Windows.Forms.Button()
        Me.OK_BTN = New System.Windows.Forms.Button()
        Me.Position1_TXT = New System.Windows.Forms.TextBox()
        Me.Position3_TXT = New System.Windows.Forms.TextBox()
        Me.BusinessUnitHead_TXT = New System.Windows.Forms.TextBox()
        Me.HRSupervisor_TXT = New System.Windows.Forms.TextBox()
        Me.RuleViolated_GB = New System.Windows.Forms.GroupBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.SC_IncidentDate_RichB = New System.Windows.Forms.RichTextBox()
        Me.SCRuleNo_LBL = New System.Windows.Forms.Label()
        Me.LV_Sections = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AuditFindings_TXT = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Location_TXT = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Explanation_Page = New System.Windows.Forms.TabPage()
        Me.Status_Combo = New System.Windows.Forms.ComboBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.SearchBy_Combo = New System.Windows.Forms.ComboBox()
        Me.Modify_Panel = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Close_Modify_BTN = New System.Windows.Forms.Button()
        Me.Check_BTN = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Explain_datagrid = New System.Windows.Forms.DataGridView()
        Me.IRNO_DGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name_DGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Company_DGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Deadline_DGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IR_DGV = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.File_DGV = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Explain_DGV = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.RptViewer_Explanation = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.WrittenReprimand_Page = New System.Windows.Forms.TabPage()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.IRNoWritten_LBL = New System.Windows.Forms.Label()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.RptViewer_WrittenReprimand = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.WP_DateIncident_DTP = New System.Windows.Forms.RichTextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.WPRule_LBL = New System.Windows.Forms.Label()
        Me.WP_SectionsList = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.WP_Incident_TXT = New System.Windows.Forms.RichTextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ECS_GB = New System.Windows.Forms.GroupBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.NoOfMONTHS_TXT = New System.Windows.Forms.TextBox()
        Me.Charges_Numeric = New System.Windows.Forms.TextBox()
        Me.ECSNo_TXT = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.AmountCharges_CB = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NumberOfDays_TXT = New System.Windows.Forms.NumericUpDown()
        Me.NoDaysSuspend_CB = New System.Windows.Forms.CheckBox()
        Me.WP_PS4_Btn = New System.Windows.Forms.Button()
        Me.WP_PS2_Btn = New System.Windows.Forms.Button()
        Me.WP_PS3_Btn = New System.Windows.Forms.Button()
        Me.WP_PS1_Btn = New System.Windows.Forms.Button()
        Me.WP_Position4_TXT = New System.Windows.Forms.TextBox()
        Me.WP_Position2_TXT = New System.Windows.Forms.TextBox()
        Me.WP_Position3_TXT = New System.Windows.Forms.TextBox()
        Me.WP_Position1_TXT = New System.Windows.Forms.TextBox()
        Me.SixDays_RBTN = New System.Windows.Forms.RadioButton()
        Me.FourDays_RBTN = New System.Windows.Forms.RadioButton()
        Me.TwoDays_RBTN = New System.Windows.Forms.RadioButton()
        Me.WW_RBTN = New System.Windows.Forms.RadioButton()
        Me.WP_Officer_Incharge_TXT = New System.Windows.Forms.TextBox()
        Me.WP_HR_Sup_TXT = New System.Windows.Forms.TextBox()
        Me.WP_BusinessHead_TXT = New System.Windows.Forms.TextBox()
        Me.WP_Emp_Rel_TXT = New System.Windows.Forms.TextBox()
        Me.WP_Save_Btn = New System.Windows.Forms.Button()
        Me.WP_OK_BTN = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.SearchWP_EMP_BTN = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.WP_Branch_TXT = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.WP_Company_TXT = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.WP_Position_TXT = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.WP_Name_TXT = New System.Windows.Forms.TextBox()
        Me.Acknowledg_Page = New System.Windows.Forms.TabPage()
        Me.Ack_Panel = New System.Windows.Forms.Panel()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CancelAck_BTN = New System.Windows.Forms.Button()
        Me.SaveAck_BTN = New System.Windows.Forms.Button()
        Me.Ack_Datagrid = New System.Windows.Forms.DataGridView()
        Me.IRNO_DGVV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name_DGVV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Company_DGVV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IR_DGVV = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.SC_DGVV = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Explain_DGVV = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.WRITTEN_DGVV = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ACKNOW_DGVV = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.StatusACK_Combo = New System.Windows.Forms.ComboBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.SearchAck_Combo = New System.Windows.Forms.ComboBox()
        Me.SearchAck_TXT = New System.Windows.Forms.TextBox()
        Me.RptViewer_Acknowledge = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Corrective_Page = New System.Windows.Forms.TabPage()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.RptViewer_Corrective = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Coo_DateIncident_RB = New System.Windows.Forms.RichTextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Coo_Rule_LBL = New System.Windows.Forms.Label()
        Me.Coo_SectionList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Coo_Description_RB = New System.Windows.Forms.RichTextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.ClearDateSuspension_BTN = New System.Windows.Forms.Button()
        Me.DateSuspension_DPT = New System.Windows.Forms.DateTimePicker()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Coo_NoOfDays_Numeric = New System.Windows.Forms.NumericUpDown()
        Me.Change4_BTN = New System.Windows.Forms.Button()
        Me.Change2_BTN = New System.Windows.Forms.Button()
        Me.Change3_BTN = New System.Windows.Forms.Button()
        Me.Change1_BTN = New System.Windows.Forms.Button()
        Me.Coo_Noted_Pos_TXT = New System.Windows.Forms.TextBox()
        Me.Coo_Rev_Pos1_TXT = New System.Windows.Forms.TextBox()
        Me.Coo_Rev_Pos2_TXT = New System.Windows.Forms.TextBox()
        Me.Coo_Pre_Pos_TXT = New System.Windows.Forms.TextBox()
        Me.Coo_Rev_Name2_TXT = New System.Windows.Forms.TextBox()
        Me.Coo_Rev_Name1_TXT = New System.Windows.Forms.TextBox()
        Me.Coo_Noted_Name_TXT = New System.Windows.Forms.TextBox()
        Me.Coo_Pre_Name_TXT = New System.Windows.Forms.TextBox()
        Me.SaveCOR_BTN = New System.Windows.Forms.Button()
        Me.PreviewCOR_BTN = New System.Windows.Forms.Button()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.Coo_Emp_BTN = New System.Windows.Forms.Button()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Coo_Branch_TXT = New System.Windows.Forms.TextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Coo_Company_TXT = New System.Windows.Forms.TextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Coo_Position_TXT = New System.Windows.Forms.TextBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Coo_Name_TXT = New System.Windows.Forms.TextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.IRNoCOO_LBL = New System.Windows.Forms.Label()
        Me.Close_BTN = New System.Windows.Forms.Button()
        Me.Coo_Violation = New System.Windows.Forms.RichTextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Coo_SCDate_LBL = New System.Windows.Forms.Label()
        Me.Coo_WRDate_LBL = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.SCViolation_RichB = New System.Windows.Forms.RichTextBox()
        Me.CorrectiveWindow.SuspendLayout()
        Me.IR_Page.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.ShowCause_Page.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Optional_Group.SuspendLayout()
        Me.RuleViolated_GB.SuspendLayout()
        Me.Explanation_Page.SuspendLayout()
        Me.Modify_Panel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Explain_datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WrittenReprimand_Page.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.ECS_GB.SuspendLayout()
        CType(Me.NumberOfDays_TXT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.Acknowledg_Page.SuspendLayout()
        Me.Ack_Panel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ack_Datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Corrective_Page.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.Coo_NoOfDays_Numeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox11.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Label21.Location = New System.Drawing.Point(2, 8)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(123, 32)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "Corrective"
        '
        'CorrectiveWindow
        '
        Me.CorrectiveWindow.Controls.Add(Me.IR_Page)
        Me.CorrectiveWindow.Controls.Add(Me.ShowCause_Page)
        Me.CorrectiveWindow.Controls.Add(Me.Explanation_Page)
        Me.CorrectiveWindow.Controls.Add(Me.WrittenReprimand_Page)
        Me.CorrectiveWindow.Controls.Add(Me.Acknowledg_Page)
        Me.CorrectiveWindow.Controls.Add(Me.Corrective_Page)
        Me.CorrectiveWindow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CorrectiveWindow.Location = New System.Drawing.Point(1, 47)
        Me.CorrectiveWindow.Name = "CorrectiveWindow"
        Me.CorrectiveWindow.SelectedIndex = 0
        Me.CorrectiveWindow.Size = New System.Drawing.Size(1175, 700)
        Me.CorrectiveWindow.TabIndex = 11
        '
        'IR_Page
        '
        Me.IR_Page.Controls.Add(Me.SplitContainer1)
        Me.IR_Page.Controls.Add(Me.IRNo_LBL)
        Me.IR_Page.Controls.Add(Me.Label23)
        Me.IR_Page.Location = New System.Drawing.Point(4, 29)
        Me.IR_Page.Name = "IR_Page"
        Me.IR_Page.Padding = New System.Windows.Forms.Padding(3)
        Me.IR_Page.Size = New System.Drawing.Size(1167, 667)
        Me.IR_Page.TabIndex = 3
        Me.IR_Page.Text = "   Incident Report   "
        Me.IR_Page.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 34)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.RptViewer_IncidentReport)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel6)
        Me.SplitContainer1.Size = New System.Drawing.Size(1160, 627)
        Me.SplitContainer1.SplitterDistance = 506
        Me.SplitContainer1.TabIndex = 64
        '
        'RptViewer_IncidentReport
        '
        Me.RptViewer_IncidentReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RptViewer_IncidentReport.LocalReport.ReportEmbeddedResource = "HRSystem.rpt_IncidentReport.rdlc"
        Me.RptViewer_IncidentReport.Location = New System.Drawing.Point(0, 0)
        Me.RptViewer_IncidentReport.Name = "RptViewer_IncidentReport"
        Me.RptViewer_IncidentReport.ServerReport.BearerToken = Nothing
        Me.RptViewer_IncidentReport.Size = New System.Drawing.Size(506, 627)
        Me.RptViewer_IncidentReport.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(29, 1035)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(592, 30)
        Me.Panel1.TabIndex = 63
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.SaveIR_BTN)
        Me.Panel6.Controls.Add(Me.ClearIR_BTN)
        Me.Panel6.Controls.Add(Me.Button1)
        Me.Panel6.Controls.Add(Me.PreviewIR_BTN)
        Me.Panel6.Controls.Add(Me.Label24)
        Me.Panel6.Controls.Add(Me.Label32)
        Me.Panel6.Controls.Add(Me.GroupBox7)
        Me.Panel6.Controls.Add(Me.Description_RichText)
        Me.Panel6.Controls.Add(Me.Supervisor_BTN)
        Me.Panel6.Controls.Add(Me.DateReceive_DTP)
        Me.Panel6.Controls.Add(Me.DateIncident_DTP)
        Me.Panel6.Controls.Add(Me.Action_CB)
        Me.Panel6.Controls.Add(Me.Supervisor_TXT)
        Me.Panel6.Controls.Add(Me.Label37)
        Me.Panel6.Controls.Add(Me.Label28)
        Me.Panel6.Controls.Add(Me.Label35)
        Me.Panel6.Controls.Add(Me.PositionS_TXT)
        Me.Panel6.Controls.Add(Me.Person_BTN)
        Me.Panel6.Controls.Add(Me.Label30)
        Me.Panel6.Controls.Add(Me.Person_TXT)
        Me.Panel6.Controls.Add(Me.Label36)
        Me.Panel6.Controls.Add(Me.Label29)
        Me.Panel6.Controls.Add(Me.IncidentLoc_TXT)
        Me.Panel6.Controls.Add(Me.PositionP_TXT)
        Me.Panel6.Controls.Add(Me.Label34)
        Me.Panel6.Controls.Add(Me.Label31)
        Me.Panel6.Controls.Add(Me.Department_TXT)
        Me.Panel6.Controls.Add(Me.Label33)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(633, 1065)
        Me.Panel6.TabIndex = 62
        '
        'SaveIR_BTN
        '
        Me.SaveIR_BTN.Location = New System.Drawing.Point(438, 965)
        Me.SaveIR_BTN.Name = "SaveIR_BTN"
        Me.SaveIR_BTN.Size = New System.Drawing.Size(139, 46)
        Me.SaveIR_BTN.TabIndex = 21
        Me.SaveIR_BTN.Text = "Save"
        Me.SaveIR_BTN.UseVisualStyleBackColor = True
        '
        'ClearIR_BTN
        '
        Me.ClearIR_BTN.Location = New System.Drawing.Point(43, 965)
        Me.ClearIR_BTN.Name = "ClearIR_BTN"
        Me.ClearIR_BTN.Size = New System.Drawing.Size(139, 46)
        Me.ClearIR_BTN.TabIndex = 62
        Me.ClearIR_BTN.Text = "Clear"
        Me.ClearIR_BTN.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(564, 384)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 26)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PreviewIR_BTN
        '
        Me.PreviewIR_BTN.Location = New System.Drawing.Point(246, 964)
        Me.PreviewIR_BTN.Name = "PreviewIR_BTN"
        Me.PreviewIR_BTN.Size = New System.Drawing.Size(139, 46)
        Me.PreviewIR_BTN.TabIndex = 14
        Me.PreviewIR_BTN.Text = "Preview"
        Me.PreviewIR_BTN.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(15, 554)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(168, 20)
        Me.Label24.TabIndex = 59
        Me.Label24.Text = "Description of Incident"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(14, 43)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(163, 20)
        Me.Label32.TabIndex = 18
        Me.Label32.Text = "Immediate Supervisor"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label38)
        Me.GroupBox7.Controls.Add(Me.PreparedBy_TXT)
        Me.GroupBox7.Controls.Add(Me.ReviewedBy_TXT)
        Me.GroupBox7.Controls.Add(Me.Label39)
        Me.GroupBox7.Controls.Add(Me.Received_TXT)
        Me.GroupBox7.Controls.Add(Me.Label40)
        Me.GroupBox7.Location = New System.Drawing.Point(8, 797)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(605, 100)
        Me.GroupBox7.TabIndex = 61
        Me.GroupBox7.TabStop = False
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(15, 33)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(94, 20)
        Me.Label38.TabIndex = 53
        Me.Label38.Text = "Prepared by"
        '
        'PreparedBy_TXT
        '
        Me.PreparedBy_TXT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PreparedBy_TXT.Location = New System.Drawing.Point(15, 65)
        Me.PreparedBy_TXT.Name = "PreparedBy_TXT"
        Me.PreparedBy_TXT.Size = New System.Drawing.Size(174, 26)
        Me.PreparedBy_TXT.TabIndex = 51
        '
        'ReviewedBy_TXT
        '
        Me.ReviewedBy_TXT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ReviewedBy_TXT.Location = New System.Drawing.Point(423, 65)
        Me.ReviewedBy_TXT.Name = "ReviewedBy_TXT"
        Me.ReviewedBy_TXT.Size = New System.Drawing.Size(174, 26)
        Me.ReviewedBy_TXT.TabIndex = 52
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(215, 33)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(95, 20)
        Me.Label39.TabIndex = 54
        Me.Label39.Text = "Received by"
        '
        'Received_TXT
        '
        Me.Received_TXT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Received_TXT.Location = New System.Drawing.Point(219, 65)
        Me.Received_TXT.Name = "Received_TXT"
        Me.Received_TXT.Size = New System.Drawing.Size(174, 26)
        Me.Received_TXT.TabIndex = 55
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(419, 33)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(98, 20)
        Me.Label40.TabIndex = 56
        Me.Label40.Text = "Reviewed by"
        '
        'Description_RichText
        '
        Me.Description_RichText.Location = New System.Drawing.Point(206, 554)
        Me.Description_RichText.Name = "Description_RichText"
        Me.Description_RichText.Size = New System.Drawing.Size(354, 206)
        Me.Description_RichText.TabIndex = 60
        Me.Description_RichText.Text = ""
        '
        'Supervisor_BTN
        '
        Me.Supervisor_BTN.Location = New System.Drawing.Point(568, 40)
        Me.Supervisor_BTN.Name = "Supervisor_BTN"
        Me.Supervisor_BTN.Size = New System.Drawing.Size(35, 26)
        Me.Supervisor_BTN.TabIndex = 19
        Me.Supervisor_BTN.Text = "..."
        Me.Supervisor_BTN.UseVisualStyleBackColor = True
        '
        'DateReceive_DTP
        '
        Me.DateReceive_DTP.Location = New System.Drawing.Point(206, 436)
        Me.DateReceive_DTP.Name = "DateReceive_DTP"
        Me.DateReceive_DTP.Size = New System.Drawing.Size(354, 26)
        Me.DateReceive_DTP.TabIndex = 57
        '
        'DateIncident_DTP
        '
        Me.DateIncident_DTP.Location = New System.Drawing.Point(206, 385)
        Me.DateIncident_DTP.Name = "DateIncident_DTP"
        Me.DateIncident_DTP.Size = New System.Drawing.Size(354, 26)
        Me.DateIncident_DTP.TabIndex = 58
        '
        'Action_CB
        '
        Me.Action_CB.FormattingEnabled = True
        Me.Action_CB.Items.AddRange(New Object() {"", "RULE I     ATTENDANCE,PUNCTUALITY & DISCIPLINE", "RULE II    DISORDERLY CONDUCT/WORK BEHAVIOR", "RULE III   SECURITY, SAFETY AND PUBLIC HEALTH", "RULE IV   COMPETENCE", "RULE V    ACTS AGAINST COMPANY INTEREST OR PROPERTY", "RULE VI   MORALITY"})
        Me.Action_CB.Location = New System.Drawing.Point(206, 488)
        Me.Action_CB.Name = "Action_CB"
        Me.Action_CB.Size = New System.Drawing.Size(354, 28)
        Me.Action_CB.TabIndex = 40
        '
        'Supervisor_TXT
        '
        Me.Supervisor_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supervisor_TXT.Location = New System.Drawing.Point(206, 40)
        Me.Supervisor_TXT.Name = "Supervisor_TXT"
        Me.Supervisor_TXT.Size = New System.Drawing.Size(354, 26)
        Me.Supervisor_TXT.TabIndex = 17
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(15, 490)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(73, 20)
        Me.Label37.TabIndex = 39
        Me.Label37.Text = "Category"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(19, 88)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(65, 20)
        Me.Label28.TabIndex = 21
        Me.Label28.Text = "Position"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(15, 436)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(98, 20)
        Me.Label35.TabIndex = 37
        Me.Label35.Text = "Date receive"
        '
        'PositionS_TXT
        '
        Me.PositionS_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PositionS_TXT.Location = New System.Drawing.Point(206, 88)
        Me.PositionS_TXT.Name = "PositionS_TXT"
        Me.PositionS_TXT.Size = New System.Drawing.Size(354, 26)
        Me.PositionS_TXT.TabIndex = 20
        '
        'Person_BTN
        '
        Me.Person_BTN.Location = New System.Drawing.Point(568, 155)
        Me.Person_BTN.Name = "Person_BTN"
        Me.Person_BTN.Size = New System.Drawing.Size(35, 26)
        Me.Person_BTN.TabIndex = 24
        Me.Person_BTN.Text = "..."
        Me.Person_BTN.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(14, 154)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(162, 20)
        Me.Label30.TabIndex = 23
        Me.Label30.Text = "Person involved in the"
        '
        'Person_TXT
        '
        Me.Person_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Person_TXT.Location = New System.Drawing.Point(206, 155)
        Me.Person_TXT.Name = "Person_TXT"
        Me.Person_TXT.Size = New System.Drawing.Size(354, 26)
        Me.Person_TXT.TabIndex = 22
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(15, 391)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(123, 20)
        Me.Label36.TabIndex = 35
        Me.Label36.Text = "Date of Incident"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(16, 215)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(65, 20)
        Me.Label29.TabIndex = 26
        Me.Label29.Text = "Position"
        '
        'IncidentLoc_TXT
        '
        Me.IncidentLoc_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IncidentLoc_TXT.Location = New System.Drawing.Point(206, 327)
        Me.IncidentLoc_TXT.Name = "IncidentLoc_TXT"
        Me.IncidentLoc_TXT.Size = New System.Drawing.Size(354, 26)
        Me.IncidentLoc_TXT.TabIndex = 30
        '
        'PositionP_TXT
        '
        Me.PositionP_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PositionP_TXT.Location = New System.Drawing.Point(206, 209)
        Me.PositionP_TXT.Name = "PositionP_TXT"
        Me.PositionP_TXT.Size = New System.Drawing.Size(354, 26)
        Me.PositionP_TXT.TabIndex = 25
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(15, 333)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(149, 20)
        Me.Label34.TabIndex = 31
        Me.Label34.Text = "Location of Incident"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(16, 174)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(64, 20)
        Me.Label31.TabIndex = 27
        Me.Label31.Text = "incident"
        '
        'Department_TXT
        '
        Me.Department_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Department_TXT.Location = New System.Drawing.Point(206, 259)
        Me.Department_TXT.Name = "Department_TXT"
        Me.Department_TXT.Size = New System.Drawing.Size(354, 26)
        Me.Department_TXT.TabIndex = 28
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(15, 265)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(149, 20)
        Me.Label33.TabIndex = 29
        Me.Label33.Text = "Branch/Department"
        '
        'IRNo_LBL
        '
        Me.IRNo_LBL.AutoSize = True
        Me.IRNo_LBL.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IRNo_LBL.Location = New System.Drawing.Point(1026, 15)
        Me.IRNo_LBL.Name = "IRNo_LBL"
        Me.IRNo_LBL.Size = New System.Drawing.Size(65, 23)
        Me.IRNo_LBL.TabIndex = 16
        Me.IRNo_LBL.Text = "00001"
        Me.IRNo_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(966, 15)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(60, 23)
        Me.Label23.TabIndex = 15
        Me.Label23.Text = "IR No."
        '
        'ShowCause_Page
        '
        Me.ShowCause_Page.AutoScroll = True
        Me.ShowCause_Page.Controls.Add(Me.Label17)
        Me.ShowCause_Page.Controls.Add(Me.SCNo_LBL)
        Me.ShowCause_Page.Controls.Add(Me.SplitContainer2)
        Me.ShowCause_Page.Location = New System.Drawing.Point(4, 29)
        Me.ShowCause_Page.Name = "ShowCause_Page"
        Me.ShowCause_Page.Padding = New System.Windows.Forms.Padding(3)
        Me.ShowCause_Page.Size = New System.Drawing.Size(1167, 667)
        Me.ShowCause_Page.TabIndex = 0
        Me.ShowCause_Page.Text = "   Show Cause Notice   "
        Me.ShowCause_Page.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(966, 7)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 23)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "IR No."
        '
        'SCNo_LBL
        '
        Me.SCNo_LBL.AutoSize = True
        Me.SCNo_LBL.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SCNo_LBL.Location = New System.Drawing.Point(1032, 7)
        Me.SCNo_LBL.Name = "SCNo_LBL"
        Me.SCNo_LBL.Size = New System.Drawing.Size(0, 23)
        Me.SCNo_LBL.TabIndex = 19
        Me.SCNo_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 37)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.RptViewer_ShowCause)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer2.Panel2.Controls.Add(Me.RuleViolated_GB)
        Me.SplitContainer2.Size = New System.Drawing.Size(1160, 627)
        Me.SplitContainer2.SplitterDistance = 498
        Me.SplitContainer2.TabIndex = 16
        '
        'RptViewer_ShowCause
        '
        Me.RptViewer_ShowCause.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RptViewer_ShowCause.DocumentMapWidth = 1
        Me.RptViewer_ShowCause.LocalReport.ReportEmbeddedResource = "HRSystem.rpt_ShowCause.rdlc"
        Me.RptViewer_ShowCause.Location = New System.Drawing.Point(0, 0)
        Me.RptViewer_ShowCause.Name = "RptViewer_ShowCause"
        Me.RptViewer_ShowCause.ServerReport.BearerToken = Nothing
        Me.RptViewer_ShowCause.Size = New System.Drawing.Size(498, 627)
        Me.RptViewer_ShowCause.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Position_TXT)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Branch_TXT)
        Me.GroupBox1.Controls.Add(Me.Company_TXT)
        Me.GroupBox1.Controls.Add(Me.SearchEMP_BTN)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(21, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(595, 167)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.EmpName_TXT)
        Me.GroupBox6.Location = New System.Drawing.Point(115, 25)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(414, 35)
        Me.GroupBox6.TabIndex = 15
        Me.GroupBox6.TabStop = False
        '
        'EmpName_TXT
        '
        Me.EmpName_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpName_TXT.Location = New System.Drawing.Point(4, 9)
        Me.EmpName_TXT.Name = "EmpName_TXT"
        Me.EmpName_TXT.Size = New System.Drawing.Size(409, 26)
        Me.EmpName_TXT.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name:"
        '
        'Position_TXT
        '
        Me.Position_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Position_TXT.Location = New System.Drawing.Point(120, 76)
        Me.Position_TXT.Name = "Position_TXT"
        Me.Position_TXT.Size = New System.Drawing.Size(409, 26)
        Me.Position_TXT.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(284, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Branch:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Positon: "
        '
        'Branch_TXT
        '
        Me.Branch_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Branch_TXT.Location = New System.Drawing.Point(351, 121)
        Me.Branch_TXT.Name = "Branch_TXT"
        Me.Branch_TXT.Size = New System.Drawing.Size(177, 26)
        Me.Branch_TXT.TabIndex = 8
        '
        'Company_TXT
        '
        Me.Company_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Company_TXT.Location = New System.Drawing.Point(120, 121)
        Me.Company_TXT.Name = "Company_TXT"
        Me.Company_TXT.Size = New System.Drawing.Size(158, 26)
        Me.Company_TXT.TabIndex = 5
        '
        'SearchEMP_BTN
        '
        Me.SearchEMP_BTN.Location = New System.Drawing.Point(542, 31)
        Me.SearchEMP_BTN.Name = "SearchEMP_BTN"
        Me.SearchEMP_BTN.Size = New System.Drawing.Size(35, 26)
        Me.SearchEMP_BTN.TabIndex = 7
        Me.SearchEMP_BTN.Text = "..."
        Me.SearchEMP_BTN.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Company:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Optional_Group)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.PS3_Btn)
        Me.GroupBox3.Controls.Add(Me.Save_BTN)
        Me.GroupBox3.Controls.Add(Me.PS1_Btn)
        Me.GroupBox3.Controls.Add(Me.OK_BTN)
        Me.GroupBox3.Controls.Add(Me.Position1_TXT)
        Me.GroupBox3.Controls.Add(Me.Position3_TXT)
        Me.GroupBox3.Controls.Add(Me.BusinessUnitHead_TXT)
        Me.GroupBox3.Controls.Add(Me.HRSupervisor_TXT)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(21, 1183)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(614, 474)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Authorize"
        '
        'Optional_Group
        '
        Me.Optional_Group.Controls.Add(Me.DateSent_DTP)
        Me.Optional_Group.Controls.Add(Me.Label20)
        Me.Optional_Group.Controls.Add(Me.SentVia_TXT)
        Me.Optional_Group.Controls.Add(Me.Label19)
        Me.Optional_Group.Location = New System.Drawing.Point(18, 210)
        Me.Optional_Group.Name = "Optional_Group"
        Me.Optional_Group.Size = New System.Drawing.Size(546, 133)
        Me.Optional_Group.TabIndex = 48
        Me.Optional_Group.TabStop = False
        '
        'DateSent_DTP
        '
        Me.DateSent_DTP.Location = New System.Drawing.Point(30, 65)
        Me.DateSent_DTP.Name = "DateSent_DTP"
        Me.DateSent_DTP.Size = New System.Drawing.Size(258, 28)
        Me.DateSent_DTP.TabIndex = 42
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(290, 42)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 21)
        Me.Label20.TabIndex = 41
        Me.Label20.Text = "Sent via"
        '
        'SentVia_TXT
        '
        Me.SentVia_TXT.Location = New System.Drawing.Point(294, 65)
        Me.SentVia_TXT.Name = "SentVia_TXT"
        Me.SentVia_TXT.Size = New System.Drawing.Size(226, 28)
        Me.SentVia_TXT.TabIndex = 40
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(26, 42)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(161, 21)
        Me.Label19.TabIndex = 39
        Me.Label19.Text = "Explanation Date Sent"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(386, 47)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(102, 21)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "Approved By:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(14, 47)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(97, 21)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Prepared By:"
        '
        'PS3_Btn
        '
        Me.PS3_Btn.Location = New System.Drawing.Point(571, 81)
        Me.PS3_Btn.Name = "PS3_Btn"
        Me.PS3_Btn.Size = New System.Drawing.Size(26, 26)
        Me.PS3_Btn.TabIndex = 26
        Me.PS3_Btn.Text = "C"
        Me.PS3_Btn.UseVisualStyleBackColor = True
        '
        'Save_BTN
        '
        Me.Save_BTN.Location = New System.Drawing.Point(248, 386)
        Me.Save_BTN.Name = "Save_BTN"
        Me.Save_BTN.Size = New System.Drawing.Size(139, 46)
        Me.Save_BTN.TabIndex = 21
        Me.Save_BTN.Text = "Save"
        Me.Save_BTN.UseVisualStyleBackColor = True
        '
        'PS1_Btn
        '
        Me.PS1_Btn.Location = New System.Drawing.Point(192, 79)
        Me.PS1_Btn.Name = "PS1_Btn"
        Me.PS1_Btn.Size = New System.Drawing.Size(26, 26)
        Me.PS1_Btn.TabIndex = 24
        Me.PS1_Btn.Text = "C"
        Me.PS1_Btn.UseVisualStyleBackColor = True
        '
        'OK_BTN
        '
        Me.OK_BTN.Location = New System.Drawing.Point(415, 386)
        Me.OK_BTN.Name = "OK_BTN"
        Me.OK_BTN.Size = New System.Drawing.Size(139, 46)
        Me.OK_BTN.TabIndex = 14
        Me.OK_BTN.Text = "Preview"
        Me.OK_BTN.UseVisualStyleBackColor = True
        '
        'Position1_TXT
        '
        Me.Position1_TXT.Location = New System.Drawing.Point(18, 79)
        Me.Position1_TXT.Name = "Position1_TXT"
        Me.Position1_TXT.ReadOnly = True
        Me.Position1_TXT.Size = New System.Drawing.Size(167, 28)
        Me.Position1_TXT.TabIndex = 21
        Me.Position1_TXT.Text = "HR Staff"
        '
        'Position3_TXT
        '
        Me.Position3_TXT.Location = New System.Drawing.Point(390, 79)
        Me.Position3_TXT.Name = "Position3_TXT"
        Me.Position3_TXT.ReadOnly = True
        Me.Position3_TXT.Size = New System.Drawing.Size(176, 28)
        Me.Position3_TXT.TabIndex = 23
        Me.Position3_TXT.Text = "HR Head"
        '
        'BusinessUnitHead_TXT
        '
        Me.BusinessUnitHead_TXT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BusinessUnitHead_TXT.Location = New System.Drawing.Point(390, 111)
        Me.BusinessUnitHead_TXT.Name = "BusinessUnitHead_TXT"
        Me.BusinessUnitHead_TXT.Size = New System.Drawing.Size(207, 28)
        Me.BusinessUnitHead_TXT.TabIndex = 17
        '
        'HRSupervisor_TXT
        '
        Me.HRSupervisor_TXT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.HRSupervisor_TXT.Location = New System.Drawing.Point(18, 111)
        Me.HRSupervisor_TXT.Name = "HRSupervisor_TXT"
        Me.HRSupervisor_TXT.Size = New System.Drawing.Size(199, 28)
        Me.HRSupervisor_TXT.TabIndex = 15
        '
        'RuleViolated_GB
        '
        Me.RuleViolated_GB.Controls.Add(Me.SCViolation_RichB)
        Me.RuleViolated_GB.Controls.Add(Me.Label63)
        Me.RuleViolated_GB.Controls.Add(Me.Label41)
        Me.RuleViolated_GB.Controls.Add(Me.Label27)
        Me.RuleViolated_GB.Controls.Add(Me.SC_IncidentDate_RichB)
        Me.RuleViolated_GB.Controls.Add(Me.SCRuleNo_LBL)
        Me.RuleViolated_GB.Controls.Add(Me.LV_Sections)
        Me.RuleViolated_GB.Controls.Add(Me.AuditFindings_TXT)
        Me.RuleViolated_GB.Controls.Add(Me.Label5)
        Me.RuleViolated_GB.Controls.Add(Me.Location_TXT)
        Me.RuleViolated_GB.Controls.Add(Me.Label8)
        Me.RuleViolated_GB.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RuleViolated_GB.Location = New System.Drawing.Point(21, 213)
        Me.RuleViolated_GB.Name = "RuleViolated_GB"
        Me.RuleViolated_GB.Size = New System.Drawing.Size(614, 929)
        Me.RuleViolated_GB.TabIndex = 17
        Me.RuleViolated_GB.TabStop = False
        Me.RuleViolated_GB.Text = "Rules Violated"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(23, 695)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(65, 21)
        Me.Label41.TabIndex = 43
        Me.Label41.Text = "Incident"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(21, 674)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(60, 21)
        Me.Label27.TabIndex = 42
        Me.Label27.Text = "Date of"
        '
        'SC_IncidentDate_RichB
        '
        Me.SC_IncidentDate_RichB.Location = New System.Drawing.Point(134, 677)
        Me.SC_IncidentDate_RichB.Name = "SC_IncidentDate_RichB"
        Me.SC_IncidentDate_RichB.ReadOnly = True
        Me.SC_IncidentDate_RichB.Size = New System.Drawing.Size(425, 57)
        Me.SC_IncidentDate_RichB.TabIndex = 41
        Me.SC_IncidentDate_RichB.Text = ""
        '
        'SCRuleNo_LBL
        '
        Me.SCRuleNo_LBL.AutoSize = True
        Me.SCRuleNo_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SCRuleNo_LBL.Location = New System.Drawing.Point(17, 37)
        Me.SCRuleNo_LBL.Name = "SCRuleNo_LBL"
        Me.SCRuleNo_LBL.Size = New System.Drawing.Size(46, 20)
        Me.SCRuleNo_LBL.TabIndex = 40
        Me.SCRuleNo_LBL.Text = "Rule "
        '
        'LV_Sections
        '
        Me.LV_Sections.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.LV_Sections.FullRowSelect = True
        Me.LV_Sections.HideSelection = False
        Me.LV_Sections.Location = New System.Drawing.Point(21, 72)
        Me.LV_Sections.Name = "LV_Sections"
        Me.LV_Sections.Size = New System.Drawing.Size(576, 349)
        Me.LV_Sections.TabIndex = 0
        Me.LV_Sections.UseCompatibleStateImageBehavior = False
        Me.LV_Sections.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Section Number"
        Me.ColumnHeader3.Width = 137
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Nature Of Offenses"
        Me.ColumnHeader4.Width = 2500
        '
        'AuditFindings_TXT
        '
        Me.AuditFindings_TXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AuditFindings_TXT.BulletIndent = 1
        Me.AuditFindings_TXT.Location = New System.Drawing.Point(26, 491)
        Me.AuditFindings_TXT.Name = "AuditFindings_TXT"
        Me.AuditFindings_TXT.ReadOnly = True
        Me.AuditFindings_TXT.Size = New System.Drawing.Size(540, 103)
        Me.AuditFindings_TXT.TabIndex = 21
        Me.AuditFindings_TXT.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 632)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 21)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Location"
        '
        'Location_TXT
        '
        Me.Location_TXT.Location = New System.Drawing.Point(134, 629)
        Me.Location_TXT.Name = "Location_TXT"
        Me.Location_TXT.ReadOnly = True
        Me.Location_TXT.Size = New System.Drawing.Size(425, 28)
        Me.Location_TXT.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 468)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(166, 21)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Description of Incident"
        '
        'Explanation_Page
        '
        Me.Explanation_Page.Controls.Add(Me.Status_Combo)
        Me.Explanation_Page.Controls.Add(Me.Label43)
        Me.Explanation_Page.Controls.Add(Me.SearchBy_Combo)
        Me.Explanation_Page.Controls.Add(Me.Modify_Panel)
        Me.Explanation_Page.Controls.Add(Me.txtSearch)
        Me.Explanation_Page.Controls.Add(Me.Explain_datagrid)
        Me.Explanation_Page.Controls.Add(Me.RptViewer_Explanation)
        Me.Explanation_Page.Location = New System.Drawing.Point(4, 29)
        Me.Explanation_Page.Name = "Explanation_Page"
        Me.Explanation_Page.Padding = New System.Windows.Forms.Padding(3)
        Me.Explanation_Page.Size = New System.Drawing.Size(1167, 667)
        Me.Explanation_Page.TabIndex = 2
        Me.Explanation_Page.Text = "   Explanation   "
        Me.Explanation_Page.UseVisualStyleBackColor = True
        '
        'Status_Combo
        '
        Me.Status_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Status_Combo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status_Combo.FormattingEnabled = True
        Me.Status_Combo.Items.AddRange(New Object() {"All", "Done", "Pending"})
        Me.Status_Combo.Location = New System.Drawing.Point(977, 29)
        Me.Status_Combo.Name = "Status_Combo"
        Me.Status_Combo.Size = New System.Drawing.Size(174, 28)
        Me.Status_Combo.TabIndex = 83
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(915, 35)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(56, 20)
        Me.Label43.TabIndex = 82
        Me.Label43.Text = "Status"
        '
        'SearchBy_Combo
        '
        Me.SearchBy_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SearchBy_Combo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBy_Combo.FormattingEnabled = True
        Me.SearchBy_Combo.Items.AddRange(New Object() {"Search by Name", "Search by IR No."})
        Me.SearchBy_Combo.Location = New System.Drawing.Point(371, 30)
        Me.SearchBy_Combo.Name = "SearchBy_Combo"
        Me.SearchBy_Combo.Size = New System.Drawing.Size(158, 28)
        Me.SearchBy_Combo.TabIndex = 81
        '
        'Modify_Panel
        '
        Me.Modify_Panel.AutoSize = True
        Me.Modify_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Modify_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Modify_Panel.Controls.Add(Me.Label22)
        Me.Modify_Panel.Controls.Add(Me.PictureBox1)
        Me.Modify_Panel.Controls.Add(Me.Close_Modify_BTN)
        Me.Modify_Panel.Controls.Add(Me.Check_BTN)
        Me.Modify_Panel.Location = New System.Drawing.Point(121, 65)
        Me.Modify_Panel.Name = "Modify_Panel"
        Me.Modify_Panel.Size = New System.Drawing.Size(855, 595)
        Me.Modify_Panel.TabIndex = 75
        Me.Modify_Panel.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(18, 6)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(315, 20)
        Me.Label22.TabIndex = 81
        Me.Label22.Text = "Double Click the box below to upload image"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(22, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(811, 501)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Close_Modify_BTN
        '
        Me.Close_Modify_BTN.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Close_Modify_BTN.Location = New System.Drawing.Point(23, 536)
        Me.Close_Modify_BTN.Name = "Close_Modify_BTN"
        Me.Close_Modify_BTN.Size = New System.Drawing.Size(93, 44)
        Me.Close_Modify_BTN.TabIndex = 80
        Me.Close_Modify_BTN.Text = "Cancel"
        Me.Close_Modify_BTN.UseVisualStyleBackColor = True
        '
        'Check_BTN
        '
        Me.Check_BTN.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check_BTN.Location = New System.Drawing.Point(733, 536)
        Me.Check_BTN.Name = "Check_BTN"
        Me.Check_BTN.Size = New System.Drawing.Size(93, 44)
        Me.Check_BTN.TabIndex = 79
        Me.Check_BTN.Text = "Save"
        Me.Check_BTN.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(8, 31)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(357, 27)
        Me.txtSearch.TabIndex = 76
        '
        'Explain_datagrid
        '
        Me.Explain_datagrid.AllowUserToAddRows = False
        Me.Explain_datagrid.AllowUserToResizeRows = False
        Me.Explain_datagrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.Explain_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Explain_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Explain_datagrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IRNO_DGV, Me.Name_DGV, Me.Company_DGV, Me.Deadline_DGV, Me.IR_DGV, Me.File_DGV, Me.Explain_DGV})
        Me.Explain_datagrid.Location = New System.Drawing.Point(9, 94)
        Me.Explain_datagrid.Name = "Explain_datagrid"
        Me.Explain_datagrid.RowHeadersVisible = False
        Me.Explain_datagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Explain_datagrid.Size = New System.Drawing.Size(1156, 567)
        Me.Explain_datagrid.TabIndex = 6
        '
        'IRNO_DGV
        '
        Me.IRNO_DGV.HeaderText = "IR No."
        Me.IRNO_DGV.Name = "IRNO_DGV"
        Me.IRNO_DGV.ReadOnly = True
        Me.IRNO_DGV.Width = 130
        '
        'Name_DGV
        '
        Me.Name_DGV.HeaderText = "Name"
        Me.Name_DGV.Name = "Name_DGV"
        Me.Name_DGV.ReadOnly = True
        Me.Name_DGV.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Name_DGV.Width = 300
        '
        'Company_DGV
        '
        Me.Company_DGV.HeaderText = "Company"
        Me.Company_DGV.Name = "Company_DGV"
        Me.Company_DGV.ReadOnly = True
        Me.Company_DGV.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Company_DGV.Width = 230
        '
        'Deadline_DGV
        '
        Me.Deadline_DGV.HeaderText = "Deadline"
        Me.Deadline_DGV.Name = "Deadline_DGV"
        Me.Deadline_DGV.ReadOnly = True
        Me.Deadline_DGV.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Deadline_DGV.Width = 180
        '
        'IR_DGV
        '
        Me.IR_DGV.HeaderText = "   IR"
        Me.IR_DGV.Name = "IR_DGV"
        Me.IR_DGV.Width = 95
        '
        'File_DGV
        '
        Me.File_DGV.HeaderText = "   SC"
        Me.File_DGV.Name = "File_DGV"
        Me.File_DGV.Width = 95
        '
        'Explain_DGV
        '
        Me.Explain_DGV.HeaderText = "   Explanation"
        Me.Explain_DGV.Name = "Explain_DGV"
        Me.Explain_DGV.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Explain_DGV.Width = 125
        '
        'RptViewer_Explanation
        '
        Me.RptViewer_Explanation.LocalReport.EnableExternalImages = True
        Me.RptViewer_Explanation.LocalReport.ReportEmbeddedResource = "HRSystem.rpt_Explanation.rdlc"
        Me.RptViewer_Explanation.Location = New System.Drawing.Point(1012, 6)
        Me.RptViewer_Explanation.Name = "RptViewer_Explanation"
        Me.RptViewer_Explanation.ServerReport.BearerToken = Nothing
        Me.RptViewer_Explanation.Size = New System.Drawing.Size(153, 51)
        Me.RptViewer_Explanation.TabIndex = 78
        Me.RptViewer_Explanation.Visible = False
        '
        'WrittenReprimand_Page
        '
        Me.WrittenReprimand_Page.Controls.Add(Me.Label25)
        Me.WrittenReprimand_Page.Controls.Add(Me.IRNoWritten_LBL)
        Me.WrittenReprimand_Page.Controls.Add(Me.SplitContainer3)
        Me.WrittenReprimand_Page.Location = New System.Drawing.Point(4, 29)
        Me.WrittenReprimand_Page.Name = "WrittenReprimand_Page"
        Me.WrittenReprimand_Page.Padding = New System.Windows.Forms.Padding(3)
        Me.WrittenReprimand_Page.Size = New System.Drawing.Size(1167, 667)
        Me.WrittenReprimand_Page.TabIndex = 1
        Me.WrittenReprimand_Page.Text = "  Written Reprimand Notice   "
        Me.WrittenReprimand_Page.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(997, 10)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(60, 23)
        Me.Label25.TabIndex = 20
        Me.Label25.Text = "IR No."
        '
        'IRNoWritten_LBL
        '
        Me.IRNoWritten_LBL.AutoSize = True
        Me.IRNoWritten_LBL.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IRNoWritten_LBL.Location = New System.Drawing.Point(1063, 10)
        Me.IRNoWritten_LBL.Name = "IRNoWritten_LBL"
        Me.IRNoWritten_LBL.Size = New System.Drawing.Size(0, 23)
        Me.IRNoWritten_LBL.TabIndex = 21
        Me.IRNoWritten_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Location = New System.Drawing.Point(3, 43)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.RptViewer_WrittenReprimand)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.AutoScroll = True
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox8)
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox5)
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer3.Size = New System.Drawing.Size(1167, 627)
        Me.SplitContainer3.SplitterDistance = 544
        Me.SplitContainer3.TabIndex = 0
        '
        'RptViewer_WrittenReprimand
        '
        Me.RptViewer_WrittenReprimand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RptViewer_WrittenReprimand.LocalReport.ReportEmbeddedResource = "HRSystem.rpt_WrittenReprimand.rdlc"
        Me.RptViewer_WrittenReprimand.Location = New System.Drawing.Point(0, 0)
        Me.RptViewer_WrittenReprimand.Name = "RptViewer_WrittenReprimand"
        Me.RptViewer_WrittenReprimand.ServerReport.BearerToken = Nothing
        Me.RptViewer_WrittenReprimand.Size = New System.Drawing.Size(544, 627)
        Me.RptViewer_WrittenReprimand.TabIndex = 2
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.WP_DateIncident_DTP)
        Me.GroupBox8.Controls.Add(Me.Label26)
        Me.GroupBox8.Controls.Add(Me.Label14)
        Me.GroupBox8.Controls.Add(Me.WPRule_LBL)
        Me.GroupBox8.Controls.Add(Me.WP_SectionsList)
        Me.GroupBox8.Controls.Add(Me.WP_Incident_TXT)
        Me.GroupBox8.Location = New System.Drawing.Point(22, 173)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(574, 688)
        Me.GroupBox8.TabIndex = 39
        Me.GroupBox8.TabStop = False
        '
        'WP_DateIncident_DTP
        '
        Me.WP_DateIncident_DTP.Location = New System.Drawing.Point(17, 600)
        Me.WP_DateIncident_DTP.Name = "WP_DateIncident_DTP"
        Me.WP_DateIncident_DTP.ReadOnly = True
        Me.WP_DateIncident_DTP.Size = New System.Drawing.Size(542, 70)
        Me.WP_DateIncident_DTP.TabIndex = 43
        Me.WP_DateIncident_DTP.Text = ""
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(15, 566)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(123, 20)
        Me.Label26.TabIndex = 42
        Me.Label26.Text = "Date of Incident"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 369)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(168, 20)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Description of Incident"
        '
        'WPRule_LBL
        '
        Me.WPRule_LBL.AutoSize = True
        Me.WPRule_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WPRule_LBL.Location = New System.Drawing.Point(15, 30)
        Me.WPRule_LBL.Name = "WPRule_LBL"
        Me.WPRule_LBL.Size = New System.Drawing.Size(46, 20)
        Me.WPRule_LBL.TabIndex = 39
        Me.WPRule_LBL.Text = "Rule "
        '
        'WP_SectionsList
        '
        Me.WP_SectionsList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8})
        Me.WP_SectionsList.FullRowSelect = True
        Me.WP_SectionsList.HideSelection = False
        Me.WP_SectionsList.Location = New System.Drawing.Point(19, 72)
        Me.WP_SectionsList.Name = "WP_SectionsList"
        Me.WP_SectionsList.Size = New System.Drawing.Size(546, 264)
        Me.WP_SectionsList.TabIndex = 0
        Me.WP_SectionsList.UseCompatibleStateImageBehavior = False
        Me.WP_SectionsList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Section"
        Me.ColumnHeader7.Width = 137
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Nature Of Offenses"
        Me.ColumnHeader8.Width = 2500
        '
        'WP_Incident_TXT
        '
        Me.WP_Incident_TXT.Location = New System.Drawing.Point(19, 399)
        Me.WP_Incident_TXT.Name = "WP_Incident_TXT"
        Me.WP_Incident_TXT.ReadOnly = True
        Me.WP_Incident_TXT.Size = New System.Drawing.Size(542, 138)
        Me.WP_Incident_TXT.TabIndex = 38
        Me.WP_Incident_TXT.Text = ""
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ECS_GB)
        Me.GroupBox5.Controls.Add(Me.AmountCharges_CB)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.NumberOfDays_TXT)
        Me.GroupBox5.Controls.Add(Me.NoDaysSuspend_CB)
        Me.GroupBox5.Controls.Add(Me.WP_PS4_Btn)
        Me.GroupBox5.Controls.Add(Me.WP_PS2_Btn)
        Me.GroupBox5.Controls.Add(Me.WP_PS3_Btn)
        Me.GroupBox5.Controls.Add(Me.WP_PS1_Btn)
        Me.GroupBox5.Controls.Add(Me.WP_Position4_TXT)
        Me.GroupBox5.Controls.Add(Me.WP_Position2_TXT)
        Me.GroupBox5.Controls.Add(Me.WP_Position3_TXT)
        Me.GroupBox5.Controls.Add(Me.WP_Position1_TXT)
        Me.GroupBox5.Controls.Add(Me.SixDays_RBTN)
        Me.GroupBox5.Controls.Add(Me.FourDays_RBTN)
        Me.GroupBox5.Controls.Add(Me.TwoDays_RBTN)
        Me.GroupBox5.Controls.Add(Me.WW_RBTN)
        Me.GroupBox5.Controls.Add(Me.WP_Officer_Incharge_TXT)
        Me.GroupBox5.Controls.Add(Me.WP_HR_Sup_TXT)
        Me.GroupBox5.Controls.Add(Me.WP_BusinessHead_TXT)
        Me.GroupBox5.Controls.Add(Me.WP_Emp_Rel_TXT)
        Me.GroupBox5.Controls.Add(Me.WP_Save_Btn)
        Me.GroupBox5.Controls.Add(Me.WP_OK_BTN)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(3, 924)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(593, 808)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Action"
        '
        'ECS_GB
        '
        Me.ECS_GB.Controls.Add(Me.Label46)
        Me.ECS_GB.Controls.Add(Me.NoOfMONTHS_TXT)
        Me.ECS_GB.Controls.Add(Me.Charges_Numeric)
        Me.ECS_GB.Controls.Add(Me.ECSNo_TXT)
        Me.ECS_GB.Controls.Add(Me.Label44)
        Me.ECS_GB.Controls.Add(Me.Label45)
        Me.ECS_GB.Location = New System.Drawing.Point(225, 194)
        Me.ECS_GB.Name = "ECS_GB"
        Me.ECS_GB.Size = New System.Drawing.Size(307, 126)
        Me.ECS_GB.TabIndex = 44
        Me.ECS_GB.TabStop = False
        Me.ECS_GB.Visible = False
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(6, 90)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(109, 21)
        Me.Label46.TabIndex = 47
        Me.Label46.Text = "No. of Months"
        '
        'NoOfMONTHS_TXT
        '
        Me.NoOfMONTHS_TXT.Location = New System.Drawing.Point(126, 86)
        Me.NoOfMONTHS_TXT.Name = "NoOfMONTHS_TXT"
        Me.NoOfMONTHS_TXT.Size = New System.Drawing.Size(175, 28)
        Me.NoOfMONTHS_TXT.TabIndex = 46
        Me.NoOfMONTHS_TXT.Text = "0"
        '
        'Charges_Numeric
        '
        Me.Charges_Numeric.Location = New System.Drawing.Point(126, 52)
        Me.Charges_Numeric.Name = "Charges_Numeric"
        Me.Charges_Numeric.Size = New System.Drawing.Size(175, 28)
        Me.Charges_Numeric.TabIndex = 45
        Me.Charges_Numeric.Text = "0"
        '
        'ECSNo_TXT
        '
        Me.ECSNo_TXT.Location = New System.Drawing.Point(126, 20)
        Me.ECSNo_TXT.Name = "ECSNo_TXT"
        Me.ECSNo_TXT.Size = New System.Drawing.Size(175, 28)
        Me.ECSNo_TXT.TabIndex = 44
        Me.ECSNo_TXT.Text = "0"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(6, 22)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(65, 21)
        Me.Label44.TabIndex = 42
        Me.Label44.Text = "ECS No."
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(6, 56)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(66, 21)
        Me.Label45.TabIndex = 43
        Me.Label45.Text = "Amount"
        '
        'AmountCharges_CB
        '
        Me.AmountCharges_CB.AutoSize = True
        Me.AmountCharges_CB.Location = New System.Drawing.Point(48, 212)
        Me.AmountCharges_CB.Name = "AmountCharges_CB"
        Me.AmountCharges_CB.Size = New System.Drawing.Size(83, 25)
        Me.AmountCharges_CB.TabIndex = 36
        Me.AmountCharges_CB.Text = "For ECS"
        Me.AmountCharges_CB.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(312, 559)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 21)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Approved By:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(311, 437)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 21)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Reviewed By:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 559)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 21)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Noted By:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 437)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 21)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Prepared By:"
        '
        'NumberOfDays_TXT
        '
        Me.NumberOfDays_TXT.Enabled = False
        Me.NumberOfDays_TXT.Location = New System.Drawing.Point(351, 161)
        Me.NumberOfDays_TXT.Name = "NumberOfDays_TXT"
        Me.NumberOfDays_TXT.Size = New System.Drawing.Size(176, 28)
        Me.NumberOfDays_TXT.TabIndex = 31
        '
        'NoDaysSuspend_CB
        '
        Me.NoDaysSuspend_CB.AutoSize = True
        Me.NoDaysSuspend_CB.Location = New System.Drawing.Point(48, 161)
        Me.NoDaysSuspend_CB.Name = "NoDaysSuspend_CB"
        Me.NoDaysSuspend_CB.Size = New System.Drawing.Size(189, 25)
        Me.NoDaysSuspend_CB.TabIndex = 30
        Me.NoDaysSuspend_CB.Text = "No. of days suspension"
        Me.NoDaysSuspend_CB.UseVisualStyleBackColor = True
        '
        'WP_PS4_Btn
        '
        Me.WP_PS4_Btn.Location = New System.Drawing.Point(538, 584)
        Me.WP_PS4_Btn.Name = "WP_PS4_Btn"
        Me.WP_PS4_Btn.Size = New System.Drawing.Size(26, 26)
        Me.WP_PS4_Btn.TabIndex = 28
        Me.WP_PS4_Btn.Text = "C"
        Me.WP_PS4_Btn.UseVisualStyleBackColor = True
        '
        'WP_PS2_Btn
        '
        Me.WP_PS2_Btn.Location = New System.Drawing.Point(533, 460)
        Me.WP_PS2_Btn.Name = "WP_PS2_Btn"
        Me.WP_PS2_Btn.Size = New System.Drawing.Size(26, 26)
        Me.WP_PS2_Btn.TabIndex = 27
        Me.WP_PS2_Btn.Text = "C"
        Me.WP_PS2_Btn.UseVisualStyleBackColor = True
        '
        'WP_PS3_Btn
        '
        Me.WP_PS3_Btn.Location = New System.Drawing.Point(235, 582)
        Me.WP_PS3_Btn.Name = "WP_PS3_Btn"
        Me.WP_PS3_Btn.Size = New System.Drawing.Size(26, 26)
        Me.WP_PS3_Btn.TabIndex = 26
        Me.WP_PS3_Btn.Text = "C"
        Me.WP_PS3_Btn.UseVisualStyleBackColor = True
        '
        'WP_PS1_Btn
        '
        Me.WP_PS1_Btn.Location = New System.Drawing.Point(235, 462)
        Me.WP_PS1_Btn.Name = "WP_PS1_Btn"
        Me.WP_PS1_Btn.Size = New System.Drawing.Size(26, 26)
        Me.WP_PS1_Btn.TabIndex = 25
        Me.WP_PS1_Btn.Text = "C"
        Me.WP_PS1_Btn.UseVisualStyleBackColor = True
        '
        'WP_Position4_TXT
        '
        Me.WP_Position4_TXT.Location = New System.Drawing.Point(315, 582)
        Me.WP_Position4_TXT.Name = "WP_Position4_TXT"
        Me.WP_Position4_TXT.ReadOnly = True
        Me.WP_Position4_TXT.Size = New System.Drawing.Size(217, 28)
        Me.WP_Position4_TXT.TabIndex = 18
        Me.WP_Position4_TXT.Text = "Business Unit Head"
        '
        'WP_Position2_TXT
        '
        Me.WP_Position2_TXT.Location = New System.Drawing.Point(316, 460)
        Me.WP_Position2_TXT.Name = "WP_Position2_TXT"
        Me.WP_Position2_TXT.ReadOnly = True
        Me.WP_Position2_TXT.Size = New System.Drawing.Size(211, 28)
        Me.WP_Position2_TXT.TabIndex = 17
        Me.WP_Position2_TXT.Text = "HR Head"
        '
        'WP_Position3_TXT
        '
        Me.WP_Position3_TXT.Location = New System.Drawing.Point(18, 582)
        Me.WP_Position3_TXT.Name = "WP_Position3_TXT"
        Me.WP_Position3_TXT.ReadOnly = True
        Me.WP_Position3_TXT.Size = New System.Drawing.Size(211, 28)
        Me.WP_Position3_TXT.TabIndex = 16
        Me.WP_Position3_TXT.Text = "Operations Officer"
        '
        'WP_Position1_TXT
        '
        Me.WP_Position1_TXT.Location = New System.Drawing.Point(18, 460)
        Me.WP_Position1_TXT.Name = "WP_Position1_TXT"
        Me.WP_Position1_TXT.ReadOnly = True
        Me.WP_Position1_TXT.Size = New System.Drawing.Size(211, 28)
        Me.WP_Position1_TXT.TabIndex = 15
        Me.WP_Position1_TXT.Text = "HR Staff"
        '
        'SixDays_RBTN
        '
        Me.SixDays_RBTN.AutoSize = True
        Me.SixDays_RBTN.Location = New System.Drawing.Point(353, 90)
        Me.SixDays_RBTN.Name = "SixDays_RBTN"
        Me.SixDays_RBTN.Size = New System.Drawing.Size(179, 25)
        Me.SixDays_RBTN.TabIndex = 14
        Me.SixDays_RBTN.TabStop = True
        Me.SixDays_RBTN.Text = "6 DAYS SUSPENSION"
        Me.SixDays_RBTN.UseVisualStyleBackColor = True
        '
        'FourDays_RBTN
        '
        Me.FourDays_RBTN.AutoSize = True
        Me.FourDays_RBTN.Location = New System.Drawing.Point(353, 38)
        Me.FourDays_RBTN.Name = "FourDays_RBTN"
        Me.FourDays_RBTN.Size = New System.Drawing.Size(179, 25)
        Me.FourDays_RBTN.TabIndex = 13
        Me.FourDays_RBTN.TabStop = True
        Me.FourDays_RBTN.Text = "4 DAYS SUSPENSION"
        Me.FourDays_RBTN.UseVisualStyleBackColor = True
        '
        'TwoDays_RBTN
        '
        Me.TwoDays_RBTN.AutoSize = True
        Me.TwoDays_RBTN.Location = New System.Drawing.Point(48, 90)
        Me.TwoDays_RBTN.Name = "TwoDays_RBTN"
        Me.TwoDays_RBTN.Size = New System.Drawing.Size(183, 25)
        Me.TwoDays_RBTN.TabIndex = 12
        Me.TwoDays_RBTN.TabStop = True
        Me.TwoDays_RBTN.Text = "2 DAYS SUSPENSION "
        Me.TwoDays_RBTN.UseVisualStyleBackColor = True
        '
        'WW_RBTN
        '
        Me.WW_RBTN.AutoSize = True
        Me.WW_RBTN.Location = New System.Drawing.Point(48, 38)
        Me.WW_RBTN.Name = "WW_RBTN"
        Me.WW_RBTN.Size = New System.Drawing.Size(171, 25)
        Me.WW_RBTN.TabIndex = 11
        Me.WW_RBTN.TabStop = True
        Me.WW_RBTN.Text = "WRITTEN WARNING"
        Me.WW_RBTN.UseVisualStyleBackColor = True
        '
        'WP_Officer_Incharge_TXT
        '
        Me.WP_Officer_Incharge_TXT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.WP_Officer_Incharge_TXT.Location = New System.Drawing.Point(18, 614)
        Me.WP_Officer_Incharge_TXT.Name = "WP_Officer_Incharge_TXT"
        Me.WP_Officer_Incharge_TXT.Size = New System.Drawing.Size(211, 28)
        Me.WP_Officer_Incharge_TXT.TabIndex = 10
        '
        'WP_HR_Sup_TXT
        '
        Me.WP_HR_Sup_TXT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.WP_HR_Sup_TXT.Location = New System.Drawing.Point(316, 492)
        Me.WP_HR_Sup_TXT.Name = "WP_HR_Sup_TXT"
        Me.WP_HR_Sup_TXT.Size = New System.Drawing.Size(211, 28)
        Me.WP_HR_Sup_TXT.TabIndex = 8
        '
        'WP_BusinessHead_TXT
        '
        Me.WP_BusinessHead_TXT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.WP_BusinessHead_TXT.Location = New System.Drawing.Point(315, 614)
        Me.WP_BusinessHead_TXT.Name = "WP_BusinessHead_TXT"
        Me.WP_BusinessHead_TXT.Size = New System.Drawing.Size(217, 28)
        Me.WP_BusinessHead_TXT.TabIndex = 8
        '
        'WP_Emp_Rel_TXT
        '
        Me.WP_Emp_Rel_TXT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.WP_Emp_Rel_TXT.Location = New System.Drawing.Point(18, 492)
        Me.WP_Emp_Rel_TXT.Name = "WP_Emp_Rel_TXT"
        Me.WP_Emp_Rel_TXT.Size = New System.Drawing.Size(211, 28)
        Me.WP_Emp_Rel_TXT.TabIndex = 6
        '
        'WP_Save_Btn
        '
        Me.WP_Save_Btn.Location = New System.Drawing.Point(242, 706)
        Me.WP_Save_Btn.Name = "WP_Save_Btn"
        Me.WP_Save_Btn.Size = New System.Drawing.Size(130, 51)
        Me.WP_Save_Btn.TabIndex = 4
        Me.WP_Save_Btn.Text = "Save"
        Me.WP_Save_Btn.UseVisualStyleBackColor = True
        '
        'WP_OK_BTN
        '
        Me.WP_OK_BTN.Location = New System.Drawing.Point(402, 702)
        Me.WP_OK_BTN.Name = "WP_OK_BTN"
        Me.WP_OK_BTN.Size = New System.Drawing.Size(130, 51)
        Me.WP_OK_BTN.TabIndex = 3
        Me.WP_OK_BTN.Text = "Preview"
        Me.WP_OK_BTN.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.SearchWP_EMP_BTN)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.WP_Branch_TXT)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.WP_Company_TXT)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.WP_Position_TXT)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.WP_Name_TXT)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(22, 22)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(574, 145)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Employee"
        '
        'SearchWP_EMP_BTN
        '
        Me.SearchWP_EMP_BTN.Location = New System.Drawing.Point(533, 23)
        Me.SearchWP_EMP_BTN.Name = "SearchWP_EMP_BTN"
        Me.SearchWP_EMP_BTN.Size = New System.Drawing.Size(35, 26)
        Me.SearchWP_EMP_BTN.TabIndex = 8
        Me.SearchWP_EMP_BTN.Text = "..."
        Me.SearchWP_EMP_BTN.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(297, 102)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 21)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Branch: "
        '
        'WP_Branch_TXT
        '
        Me.WP_Branch_TXT.Location = New System.Drawing.Point(367, 99)
        Me.WP_Branch_TXT.Name = "WP_Branch_TXT"
        Me.WP_Branch_TXT.Size = New System.Drawing.Size(160, 28)
        Me.WP_Branch_TXT.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(33, 102)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 21)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Comapny: "
        '
        'WP_Company_TXT
        '
        Me.WP_Company_TXT.Location = New System.Drawing.Point(125, 99)
        Me.WP_Company_TXT.Name = "WP_Company_TXT"
        Me.WP_Company_TXT.Size = New System.Drawing.Size(171, 28)
        Me.WP_Company_TXT.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 21)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Position: "
        '
        'WP_Position_TXT
        '
        Me.WP_Position_TXT.Location = New System.Drawing.Point(125, 61)
        Me.WP_Position_TXT.Name = "WP_Position_TXT"
        Me.WP_Position_TXT.Size = New System.Drawing.Size(402, 28)
        Me.WP_Position_TXT.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(58, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 21)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Name: "
        '
        'WP_Name_TXT
        '
        Me.WP_Name_TXT.Location = New System.Drawing.Point(125, 23)
        Me.WP_Name_TXT.Name = "WP_Name_TXT"
        Me.WP_Name_TXT.Size = New System.Drawing.Size(402, 28)
        Me.WP_Name_TXT.TabIndex = 0
        '
        'Acknowledg_Page
        '
        Me.Acknowledg_Page.Controls.Add(Me.Ack_Panel)
        Me.Acknowledg_Page.Controls.Add(Me.Ack_Datagrid)
        Me.Acknowledg_Page.Controls.Add(Me.StatusACK_Combo)
        Me.Acknowledg_Page.Controls.Add(Me.Label42)
        Me.Acknowledg_Page.Controls.Add(Me.SearchAck_Combo)
        Me.Acknowledg_Page.Controls.Add(Me.SearchAck_TXT)
        Me.Acknowledg_Page.Controls.Add(Me.RptViewer_Acknowledge)
        Me.Acknowledg_Page.Location = New System.Drawing.Point(4, 29)
        Me.Acknowledg_Page.Name = "Acknowledg_Page"
        Me.Acknowledg_Page.Padding = New System.Windows.Forms.Padding(3)
        Me.Acknowledg_Page.Size = New System.Drawing.Size(1167, 667)
        Me.Acknowledg_Page.TabIndex = 4
        Me.Acknowledg_Page.Text = "   Acknowledgment   "
        Me.Acknowledg_Page.UseVisualStyleBackColor = True
        '
        'Ack_Panel
        '
        Me.Ack_Panel.AutoSize = True
        Me.Ack_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Ack_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Ack_Panel.Controls.Add(Me.Label47)
        Me.Ack_Panel.Controls.Add(Me.PictureBox2)
        Me.Ack_Panel.Controls.Add(Me.CancelAck_BTN)
        Me.Ack_Panel.Controls.Add(Me.SaveAck_BTN)
        Me.Ack_Panel.Location = New System.Drawing.Point(156, 65)
        Me.Ack_Panel.Name = "Ack_Panel"
        Me.Ack_Panel.Size = New System.Drawing.Size(855, 590)
        Me.Ack_Panel.TabIndex = 90
        Me.Ack_Panel.Visible = False
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(18, 6)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(315, 20)
        Me.Label47.TabIndex = 81
        Me.Label47.Text = "Double Click the box below to upload image"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(22, 28)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(811, 501)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'CancelAck_BTN
        '
        Me.CancelAck_BTN.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelAck_BTN.Location = New System.Drawing.Point(23, 536)
        Me.CancelAck_BTN.Name = "CancelAck_BTN"
        Me.CancelAck_BTN.Size = New System.Drawing.Size(93, 44)
        Me.CancelAck_BTN.TabIndex = 80
        Me.CancelAck_BTN.Text = "Cancel"
        Me.CancelAck_BTN.UseVisualStyleBackColor = True
        '
        'SaveAck_BTN
        '
        Me.SaveAck_BTN.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveAck_BTN.Location = New System.Drawing.Point(733, 536)
        Me.SaveAck_BTN.Name = "SaveAck_BTN"
        Me.SaveAck_BTN.Size = New System.Drawing.Size(93, 44)
        Me.SaveAck_BTN.TabIndex = 79
        Me.SaveAck_BTN.Text = "Save"
        Me.SaveAck_BTN.UseVisualStyleBackColor = True
        '
        'Ack_Datagrid
        '
        Me.Ack_Datagrid.AllowUserToAddRows = False
        Me.Ack_Datagrid.AllowUserToResizeRows = False
        Me.Ack_Datagrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.Ack_Datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Ack_Datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Ack_Datagrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IRNO_DGVV, Me.Name_DGVV, Me.Company_DGVV, Me.IR_DGVV, Me.SC_DGVV, Me.Explain_DGVV, Me.WRITTEN_DGVV, Me.ACKNOW_DGVV})
        Me.Ack_Datagrid.Location = New System.Drawing.Point(5, 92)
        Me.Ack_Datagrid.Name = "Ack_Datagrid"
        Me.Ack_Datagrid.RowHeadersVisible = False
        Me.Ack_Datagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Ack_Datagrid.Size = New System.Drawing.Size(1156, 567)
        Me.Ack_Datagrid.TabIndex = 89
        '
        'IRNO_DGVV
        '
        Me.IRNO_DGVV.HeaderText = "IR No."
        Me.IRNO_DGVV.Name = "IRNO_DGVV"
        Me.IRNO_DGVV.ReadOnly = True
        Me.IRNO_DGVV.Width = 130
        '
        'Name_DGVV
        '
        Me.Name_DGVV.HeaderText = "Name"
        Me.Name_DGVV.Name = "Name_DGVV"
        Me.Name_DGVV.ReadOnly = True
        Me.Name_DGVV.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Name_DGVV.Width = 300
        '
        'Company_DGVV
        '
        Me.Company_DGVV.HeaderText = "Company"
        Me.Company_DGVV.Name = "Company_DGVV"
        Me.Company_DGVV.ReadOnly = True
        Me.Company_DGVV.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Company_DGVV.Width = 230
        '
        'IR_DGVV
        '
        Me.IR_DGVV.HeaderText = "     IR"
        Me.IR_DGVV.Name = "IR_DGVV"
        Me.IR_DGVV.Width = 80
        '
        'SC_DGVV
        '
        Me.SC_DGVV.HeaderText = "     SC"
        Me.SC_DGVV.Name = "SC_DGVV"
        Me.SC_DGVV.Width = 80
        '
        'Explain_DGVV
        '
        Me.Explain_DGVV.HeaderText = "   Explanation"
        Me.Explain_DGVV.Name = "Explain_DGVV"
        Me.Explain_DGVV.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Explain_DGVV.Width = 125
        '
        'WRITTEN_DGVV
        '
        Me.WRITTEN_DGVV.HeaderText = "     WR"
        Me.WRITTEN_DGVV.Name = "WRITTEN_DGVV"
        Me.WRITTEN_DGVV.Width = 80
        '
        'ACKNOW_DGVV
        '
        Me.ACKNOW_DGVV.HeaderText = "   Acknowledge"
        Me.ACKNOW_DGVV.Name = "ACKNOW_DGVV"
        Me.ACKNOW_DGVV.Width = 130
        '
        'StatusACK_Combo
        '
        Me.StatusACK_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StatusACK_Combo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusACK_Combo.FormattingEnabled = True
        Me.StatusACK_Combo.Items.AddRange(New Object() {"All", "Done", "Pending"})
        Me.StatusACK_Combo.Location = New System.Drawing.Point(976, 33)
        Me.StatusACK_Combo.Name = "StatusACK_Combo"
        Me.StatusACK_Combo.Size = New System.Drawing.Size(174, 28)
        Me.StatusACK_Combo.TabIndex = 88
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(914, 39)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(56, 20)
        Me.Label42.TabIndex = 87
        Me.Label42.Text = "Status"
        '
        'SearchAck_Combo
        '
        Me.SearchAck_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SearchAck_Combo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchAck_Combo.FormattingEnabled = True
        Me.SearchAck_Combo.Items.AddRange(New Object() {"Search by Name", "Search by IR No."})
        Me.SearchAck_Combo.Location = New System.Drawing.Point(370, 34)
        Me.SearchAck_Combo.Name = "SearchAck_Combo"
        Me.SearchAck_Combo.Size = New System.Drawing.Size(158, 28)
        Me.SearchAck_Combo.TabIndex = 86
        '
        'SearchAck_TXT
        '
        Me.SearchAck_TXT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchAck_TXT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SearchAck_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchAck_TXT.Location = New System.Drawing.Point(7, 35)
        Me.SearchAck_TXT.Name = "SearchAck_TXT"
        Me.SearchAck_TXT.Size = New System.Drawing.Size(357, 27)
        Me.SearchAck_TXT.TabIndex = 84
        '
        'RptViewer_Acknowledge
        '
        Me.RptViewer_Acknowledge.LocalReport.EnableExternalImages = True
        Me.RptViewer_Acknowledge.LocalReport.ReportEmbeddedResource = "HRSystem.rpt_Explanation.rdlc"
        Me.RptViewer_Acknowledge.Location = New System.Drawing.Point(1011, 10)
        Me.RptViewer_Acknowledge.Name = "RptViewer_Acknowledge"
        Me.RptViewer_Acknowledge.ServerReport.BearerToken = Nothing
        Me.RptViewer_Acknowledge.Size = New System.Drawing.Size(153, 51)
        Me.RptViewer_Acknowledge.TabIndex = 85
        Me.RptViewer_Acknowledge.Visible = False
        '
        'Corrective_Page
        '
        Me.Corrective_Page.Controls.Add(Me.SplitContainer4)
        Me.Corrective_Page.Controls.Add(Me.Label61)
        Me.Corrective_Page.Controls.Add(Me.IRNoCOO_LBL)
        Me.Corrective_Page.Location = New System.Drawing.Point(4, 29)
        Me.Corrective_Page.Name = "Corrective_Page"
        Me.Corrective_Page.Padding = New System.Windows.Forms.Padding(3)
        Me.Corrective_Page.Size = New System.Drawing.Size(1167, 667)
        Me.Corrective_Page.TabIndex = 5
        Me.Corrective_Page.Text = "   Corrective Action Report"
        Me.Corrective_Page.UseVisualStyleBackColor = True
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 35)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.RptViewer_Corrective)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.AutoScroll = True
        Me.SplitContainer4.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer4.Panel2.Controls.Add(Me.GroupBox9)
        Me.SplitContainer4.Panel2.Controls.Add(Me.GroupBox11)
        Me.SplitContainer4.Size = New System.Drawing.Size(1167, 627)
        Me.SplitContainer4.SplitterDistance = 544
        Me.SplitContainer4.TabIndex = 22
        '
        'RptViewer_Corrective
        '
        Me.RptViewer_Corrective.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RptViewer_Corrective.LocalReport.ReportEmbeddedResource = "HRSystem.CorrectiveAction.rdlc"
        Me.RptViewer_Corrective.Location = New System.Drawing.Point(0, 0)
        Me.RptViewer_Corrective.Name = "RptViewer_Corrective"
        Me.RptViewer_Corrective.ServerReport.BearerToken = Nothing
        Me.RptViewer_Corrective.Size = New System.Drawing.Size(544, 627)
        Me.RptViewer_Corrective.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Coo_WRDate_LBL)
        Me.GroupBox2.Controls.Add(Me.Coo_SCDate_LBL)
        Me.GroupBox2.Controls.Add(Me.Label54)
        Me.GroupBox2.Controls.Add(Me.Label53)
        Me.GroupBox2.Controls.Add(Me.Coo_Violation)
        Me.GroupBox2.Controls.Add(Me.Label50)
        Me.GroupBox2.Controls.Add(Me.Coo_DateIncident_RB)
        Me.GroupBox2.Controls.Add(Me.Label48)
        Me.GroupBox2.Controls.Add(Me.Label49)
        Me.GroupBox2.Controls.Add(Me.Coo_Rule_LBL)
        Me.GroupBox2.Controls.Add(Me.Coo_SectionList)
        Me.GroupBox2.Controls.Add(Me.Coo_Description_RB)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 188)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(574, 969)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        '
        'Coo_DateIncident_RB
        '
        Me.Coo_DateIncident_RB.Location = New System.Drawing.Point(17, 600)
        Me.Coo_DateIncident_RB.Name = "Coo_DateIncident_RB"
        Me.Coo_DateIncident_RB.ReadOnly = True
        Me.Coo_DateIncident_RB.Size = New System.Drawing.Size(542, 70)
        Me.Coo_DateIncident_RB.TabIndex = 43
        Me.Coo_DateIncident_RB.Text = ""
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(15, 566)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(123, 20)
        Me.Label48.TabIndex = 42
        Me.Label48.Text = "Date of Incident"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(15, 369)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(168, 20)
        Me.Label49.TabIndex = 40
        Me.Label49.Text = "Description of Incident"
        '
        'Coo_Rule_LBL
        '
        Me.Coo_Rule_LBL.AutoSize = True
        Me.Coo_Rule_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Coo_Rule_LBL.Location = New System.Drawing.Point(15, 30)
        Me.Coo_Rule_LBL.Name = "Coo_Rule_LBL"
        Me.Coo_Rule_LBL.Size = New System.Drawing.Size(46, 20)
        Me.Coo_Rule_LBL.TabIndex = 39
        Me.Coo_Rule_LBL.Text = "Rule "
        '
        'Coo_SectionList
        '
        Me.Coo_SectionList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.Coo_SectionList.FullRowSelect = True
        Me.Coo_SectionList.HideSelection = False
        Me.Coo_SectionList.Location = New System.Drawing.Point(19, 72)
        Me.Coo_SectionList.Name = "Coo_SectionList"
        Me.Coo_SectionList.Size = New System.Drawing.Size(546, 264)
        Me.Coo_SectionList.TabIndex = 0
        Me.Coo_SectionList.UseCompatibleStateImageBehavior = False
        Me.Coo_SectionList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Section"
        Me.ColumnHeader1.Width = 137
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nature Of Offenses"
        Me.ColumnHeader2.Width = 2500
        '
        'Coo_Description_RB
        '
        Me.Coo_Description_RB.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Coo_Description_RB.Location = New System.Drawing.Point(19, 399)
        Me.Coo_Description_RB.Name = "Coo_Description_RB"
        Me.Coo_Description_RB.ReadOnly = True
        Me.Coo_Description_RB.Size = New System.Drawing.Size(542, 138)
        Me.Coo_Description_RB.TabIndex = 38
        Me.Coo_Description_RB.Text = ""
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.ClearDateSuspension_BTN)
        Me.GroupBox9.Controls.Add(Me.DateSuspension_DPT)
        Me.GroupBox9.Controls.Add(Me.Label52)
        Me.GroupBox9.Controls.Add(Me.Label51)
        Me.GroupBox9.Controls.Add(Me.Label55)
        Me.GroupBox9.Controls.Add(Me.Label56)
        Me.GroupBox9.Controls.Add(Me.Label57)
        Me.GroupBox9.Controls.Add(Me.Coo_NoOfDays_Numeric)
        Me.GroupBox9.Controls.Add(Me.Change4_BTN)
        Me.GroupBox9.Controls.Add(Me.Change2_BTN)
        Me.GroupBox9.Controls.Add(Me.Change3_BTN)
        Me.GroupBox9.Controls.Add(Me.Change1_BTN)
        Me.GroupBox9.Controls.Add(Me.Coo_Noted_Pos_TXT)
        Me.GroupBox9.Controls.Add(Me.Coo_Rev_Pos1_TXT)
        Me.GroupBox9.Controls.Add(Me.Coo_Rev_Pos2_TXT)
        Me.GroupBox9.Controls.Add(Me.Coo_Pre_Pos_TXT)
        Me.GroupBox9.Controls.Add(Me.Coo_Rev_Name2_TXT)
        Me.GroupBox9.Controls.Add(Me.Coo_Rev_Name1_TXT)
        Me.GroupBox9.Controls.Add(Me.Coo_Noted_Name_TXT)
        Me.GroupBox9.Controls.Add(Me.Coo_Pre_Name_TXT)
        Me.GroupBox9.Controls.Add(Me.SaveCOR_BTN)
        Me.GroupBox9.Controls.Add(Me.PreviewCOR_BTN)
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(3, 1189)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(593, 803)
        Me.GroupBox9.TabIndex = 4
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Action"
        '
        'ClearDateSuspension_BTN
        '
        Me.ClearDateSuspension_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearDateSuspension_BTN.Location = New System.Drawing.Point(531, 118)
        Me.ClearDateSuspension_BTN.Name = "ClearDateSuspension_BTN"
        Me.ClearDateSuspension_BTN.Size = New System.Drawing.Size(56, 26)
        Me.ClearDateSuspension_BTN.TabIndex = 66
        Me.ClearDateSuspension_BTN.Text = "Clear"
        Me.ClearDateSuspension_BTN.UseVisualStyleBackColor = True
        '
        'DateSuspension_DPT
        '
        Me.DateSuspension_DPT.Location = New System.Drawing.Point(205, 117)
        Me.DateSuspension_DPT.Name = "DateSuspension_DPT"
        Me.DateSuspension_DPT.Size = New System.Drawing.Size(320, 28)
        Me.DateSuspension_DPT.TabIndex = 65
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(45, 121)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(144, 21)
        Me.Label52.TabIndex = 64
        Me.Label52.Text = "Date of Suspension"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(43, 42)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(90, 21)
        Me.Label51.TabIndex = 44
        Me.Label51.Text = "No. of Days"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(45, 341)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(101, 21)
        Me.Label55.TabIndex = 34
        Me.Label55.Text = "Reviewed By:"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(45, 547)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(77, 21)
        Me.Label56.TabIndex = 33
        Me.Label56.Text = "Noted By:"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(45, 236)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(97, 21)
        Me.Label57.TabIndex = 32
        Me.Label57.Text = "Prepared By:"
        '
        'Coo_NoOfDays_Numeric
        '
        Me.Coo_NoOfDays_Numeric.Location = New System.Drawing.Point(205, 45)
        Me.Coo_NoOfDays_Numeric.Name = "Coo_NoOfDays_Numeric"
        Me.Coo_NoOfDays_Numeric.Size = New System.Drawing.Size(320, 28)
        Me.Coo_NoOfDays_Numeric.TabIndex = 31
        '
        'Change4_BTN
        '
        Me.Change4_BTN.Location = New System.Drawing.Point(531, 574)
        Me.Change4_BTN.Name = "Change4_BTN"
        Me.Change4_BTN.Size = New System.Drawing.Size(26, 26)
        Me.Change4_BTN.TabIndex = 28
        Me.Change4_BTN.Text = "C"
        Me.Change4_BTN.UseVisualStyleBackColor = True
        '
        'Change2_BTN
        '
        Me.Change2_BTN.Location = New System.Drawing.Point(531, 378)
        Me.Change2_BTN.Name = "Change2_BTN"
        Me.Change2_BTN.Size = New System.Drawing.Size(26, 26)
        Me.Change2_BTN.TabIndex = 27
        Me.Change2_BTN.Text = "C"
        Me.Change2_BTN.UseVisualStyleBackColor = True
        '
        'Change3_BTN
        '
        Me.Change3_BTN.Location = New System.Drawing.Point(531, 470)
        Me.Change3_BTN.Name = "Change3_BTN"
        Me.Change3_BTN.Size = New System.Drawing.Size(26, 26)
        Me.Change3_BTN.TabIndex = 26
        Me.Change3_BTN.Text = "C"
        Me.Change3_BTN.UseVisualStyleBackColor = True
        '
        'Change1_BTN
        '
        Me.Change1_BTN.Location = New System.Drawing.Point(531, 269)
        Me.Change1_BTN.Name = "Change1_BTN"
        Me.Change1_BTN.Size = New System.Drawing.Size(26, 26)
        Me.Change1_BTN.TabIndex = 25
        Me.Change1_BTN.Text = "C"
        Me.Change1_BTN.UseVisualStyleBackColor = True
        '
        'Coo_Noted_Pos_TXT
        '
        Me.Coo_Noted_Pos_TXT.Location = New System.Drawing.Point(205, 573)
        Me.Coo_Noted_Pos_TXT.Name = "Coo_Noted_Pos_TXT"
        Me.Coo_Noted_Pos_TXT.ReadOnly = True
        Me.Coo_Noted_Pos_TXT.Size = New System.Drawing.Size(319, 28)
        Me.Coo_Noted_Pos_TXT.TabIndex = 18
        Me.Coo_Noted_Pos_TXT.Text = "Business Unit Head"
        '
        'Coo_Rev_Pos1_TXT
        '
        Me.Coo_Rev_Pos1_TXT.Location = New System.Drawing.Point(205, 376)
        Me.Coo_Rev_Pos1_TXT.Name = "Coo_Rev_Pos1_TXT"
        Me.Coo_Rev_Pos1_TXT.ReadOnly = True
        Me.Coo_Rev_Pos1_TXT.Size = New System.Drawing.Size(318, 28)
        Me.Coo_Rev_Pos1_TXT.TabIndex = 17
        Me.Coo_Rev_Pos1_TXT.Text = "HR Supervisor"
        '
        'Coo_Rev_Pos2_TXT
        '
        Me.Coo_Rev_Pos2_TXT.Location = New System.Drawing.Point(205, 468)
        Me.Coo_Rev_Pos2_TXT.Name = "Coo_Rev_Pos2_TXT"
        Me.Coo_Rev_Pos2_TXT.ReadOnly = True
        Me.Coo_Rev_Pos2_TXT.Size = New System.Drawing.Size(318, 28)
        Me.Coo_Rev_Pos2_TXT.TabIndex = 16
        Me.Coo_Rev_Pos2_TXT.Text = "Operations Officer"
        '
        'Coo_Pre_Pos_TXT
        '
        Me.Coo_Pre_Pos_TXT.Location = New System.Drawing.Point(205, 267)
        Me.Coo_Pre_Pos_TXT.Name = "Coo_Pre_Pos_TXT"
        Me.Coo_Pre_Pos_TXT.ReadOnly = True
        Me.Coo_Pre_Pos_TXT.Size = New System.Drawing.Size(318, 28)
        Me.Coo_Pre_Pos_TXT.TabIndex = 15
        Me.Coo_Pre_Pos_TXT.Text = "Employee Relations"
        '
        'Coo_Rev_Name2_TXT
        '
        Me.Coo_Rev_Name2_TXT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Coo_Rev_Name2_TXT.Location = New System.Drawing.Point(205, 434)
        Me.Coo_Rev_Name2_TXT.Name = "Coo_Rev_Name2_TXT"
        Me.Coo_Rev_Name2_TXT.Size = New System.Drawing.Size(318, 28)
        Me.Coo_Rev_Name2_TXT.TabIndex = 10
        '
        'Coo_Rev_Name1_TXT
        '
        Me.Coo_Rev_Name1_TXT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Coo_Rev_Name1_TXT.Location = New System.Drawing.Point(205, 338)
        Me.Coo_Rev_Name1_TXT.Name = "Coo_Rev_Name1_TXT"
        Me.Coo_Rev_Name1_TXT.Size = New System.Drawing.Size(318, 28)
        Me.Coo_Rev_Name1_TXT.TabIndex = 8
        '
        'Coo_Noted_Name_TXT
        '
        Me.Coo_Noted_Name_TXT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Coo_Noted_Name_TXT.Location = New System.Drawing.Point(205, 539)
        Me.Coo_Noted_Name_TXT.Name = "Coo_Noted_Name_TXT"
        Me.Coo_Noted_Name_TXT.Size = New System.Drawing.Size(319, 28)
        Me.Coo_Noted_Name_TXT.TabIndex = 8
        Me.Coo_Noted_Name_TXT.Text = "DARREN Y. UY"
        '
        'Coo_Pre_Name_TXT
        '
        Me.Coo_Pre_Name_TXT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Coo_Pre_Name_TXT.Location = New System.Drawing.Point(205, 233)
        Me.Coo_Pre_Name_TXT.Name = "Coo_Pre_Name_TXT"
        Me.Coo_Pre_Name_TXT.Size = New System.Drawing.Size(318, 28)
        Me.Coo_Pre_Name_TXT.TabIndex = 6
        '
        'SaveCOR_BTN
        '
        Me.SaveCOR_BTN.Location = New System.Drawing.Point(288, 698)
        Me.SaveCOR_BTN.Name = "SaveCOR_BTN"
        Me.SaveCOR_BTN.Size = New System.Drawing.Size(130, 51)
        Me.SaveCOR_BTN.TabIndex = 4
        Me.SaveCOR_BTN.Text = "Save"
        Me.SaveCOR_BTN.UseVisualStyleBackColor = True
        '
        'PreviewCOR_BTN
        '
        Me.PreviewCOR_BTN.Location = New System.Drawing.Point(448, 694)
        Me.PreviewCOR_BTN.Name = "PreviewCOR_BTN"
        Me.PreviewCOR_BTN.Size = New System.Drawing.Size(130, 51)
        Me.PreviewCOR_BTN.TabIndex = 3
        Me.PreviewCOR_BTN.Text = "Preview"
        Me.PreviewCOR_BTN.UseVisualStyleBackColor = True
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Coo_Emp_BTN)
        Me.GroupBox11.Controls.Add(Me.Label58)
        Me.GroupBox11.Controls.Add(Me.Coo_Branch_TXT)
        Me.GroupBox11.Controls.Add(Me.Label59)
        Me.GroupBox11.Controls.Add(Me.Coo_Company_TXT)
        Me.GroupBox11.Controls.Add(Me.Label60)
        Me.GroupBox11.Controls.Add(Me.Coo_Position_TXT)
        Me.GroupBox11.Controls.Add(Me.Label62)
        Me.GroupBox11.Controls.Add(Me.Coo_Name_TXT)
        Me.GroupBox11.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox11.Location = New System.Drawing.Point(22, 37)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(574, 145)
        Me.GroupBox11.TabIndex = 3
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Employee"
        '
        'Coo_Emp_BTN
        '
        Me.Coo_Emp_BTN.Location = New System.Drawing.Point(533, 23)
        Me.Coo_Emp_BTN.Name = "Coo_Emp_BTN"
        Me.Coo_Emp_BTN.Size = New System.Drawing.Size(35, 26)
        Me.Coo_Emp_BTN.TabIndex = 8
        Me.Coo_Emp_BTN.Text = "..."
        Me.Coo_Emp_BTN.UseVisualStyleBackColor = True
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(297, 102)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(65, 21)
        Me.Label58.TabIndex = 7
        Me.Label58.Text = "Branch: "
        '
        'Coo_Branch_TXT
        '
        Me.Coo_Branch_TXT.Location = New System.Drawing.Point(367, 99)
        Me.Coo_Branch_TXT.Name = "Coo_Branch_TXT"
        Me.Coo_Branch_TXT.Size = New System.Drawing.Size(160, 28)
        Me.Coo_Branch_TXT.TabIndex = 6
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(33, 102)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(84, 21)
        Me.Label59.TabIndex = 5
        Me.Label59.Text = "Comapny: "
        '
        'Coo_Company_TXT
        '
        Me.Coo_Company_TXT.Location = New System.Drawing.Point(125, 99)
        Me.Coo_Company_TXT.Name = "Coo_Company_TXT"
        Me.Coo_Company_TXT.Size = New System.Drawing.Size(171, 28)
        Me.Coo_Company_TXT.TabIndex = 4
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(44, 64)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(73, 21)
        Me.Label60.TabIndex = 3
        Me.Label60.Text = "Position: "
        '
        'Coo_Position_TXT
        '
        Me.Coo_Position_TXT.Location = New System.Drawing.Point(125, 61)
        Me.Coo_Position_TXT.Name = "Coo_Position_TXT"
        Me.Coo_Position_TXT.Size = New System.Drawing.Size(402, 28)
        Me.Coo_Position_TXT.TabIndex = 2
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(58, 26)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(59, 21)
        Me.Label62.TabIndex = 1
        Me.Label62.Text = "Name: "
        '
        'Coo_Name_TXT
        '
        Me.Coo_Name_TXT.Location = New System.Drawing.Point(125, 23)
        Me.Coo_Name_TXT.Name = "Coo_Name_TXT"
        Me.Coo_Name_TXT.Size = New System.Drawing.Size(402, 28)
        Me.Coo_Name_TXT.TabIndex = 0
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(954, 10)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(60, 23)
        Me.Label61.TabIndex = 20
        Me.Label61.Text = "IR No."
        '
        'IRNoCOO_LBL
        '
        Me.IRNoCOO_LBL.AutoSize = True
        Me.IRNoCOO_LBL.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IRNoCOO_LBL.Location = New System.Drawing.Point(1020, 10)
        Me.IRNoCOO_LBL.Name = "IRNoCOO_LBL"
        Me.IRNoCOO_LBL.Size = New System.Drawing.Size(0, 23)
        Me.IRNoCOO_LBL.TabIndex = 21
        Me.IRNoCOO_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Close_BTN
        '
        Me.Close_BTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Close_BTN.Image = CType(resources.GetObject("Close_BTN.Image"), System.Drawing.Image)
        Me.Close_BTN.Location = New System.Drawing.Point(1150, 2)
        Me.Close_BTN.Name = "Close_BTN"
        Me.Close_BTN.Size = New System.Drawing.Size(30, 30)
        Me.Close_BTN.TabIndex = 10
        Me.Close_BTN.UseVisualStyleBackColor = True
        '
        'Coo_Violation
        '
        Me.Coo_Violation.Location = New System.Drawing.Point(19, 741)
        Me.Coo_Violation.Name = "Coo_Violation"
        Me.Coo_Violation.Size = New System.Drawing.Size(542, 70)
        Me.Coo_Violation.TabIndex = 45
        Me.Coo_Violation.Text = ""
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(17, 707)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(82, 20)
        Me.Label50.TabIndex = 44
        Me.Label50.Text = "Violation/s"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(17, 859)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(264, 20)
        Me.Label53.TabIndex = 46
        Me.Label53.Text = "Show Cause Notice Issued               :"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(17, 907)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(263, 20)
        Me.Label54.TabIndex = 47
        Me.Label54.Text = "Written Reprimand Notice Issued    :"
        '
        'Coo_SCDate_LBL
        '
        Me.Coo_SCDate_LBL.AutoSize = True
        Me.Coo_SCDate_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Coo_SCDate_LBL.Location = New System.Drawing.Point(297, 861)
        Me.Coo_SCDate_LBL.Name = "Coo_SCDate_LBL"
        Me.Coo_SCDate_LBL.Size = New System.Drawing.Size(15, 20)
        Me.Coo_SCDate_LBL.TabIndex = 48
        Me.Coo_SCDate_LBL.Text = "-"
        '
        'Coo_WRDate_LBL
        '
        Me.Coo_WRDate_LBL.AutoSize = True
        Me.Coo_WRDate_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Coo_WRDate_LBL.Location = New System.Drawing.Point(297, 906)
        Me.Coo_WRDate_LBL.Name = "Coo_WRDate_LBL"
        Me.Coo_WRDate_LBL.Size = New System.Drawing.Size(15, 20)
        Me.Coo_WRDate_LBL.TabIndex = 49
        Me.Coo_WRDate_LBL.Text = "-"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(21, 775)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(72, 21)
        Me.Label63.TabIndex = 44
        Me.Label63.Text = "Violation"
        '
        'SCViolation_RichB
        '
        Me.SCViolation_RichB.Location = New System.Drawing.Point(134, 779)
        Me.SCViolation_RichB.Name = "SCViolation_RichB"
        Me.SCViolation_RichB.ReadOnly = True
        Me.SCViolation_RichB.Size = New System.Drawing.Size(420, 96)
        Me.SCViolation_RichB.TabIndex = 45
        Me.SCViolation_RichB.Text = ""
        '
        'frmIncidentReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 749)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Close_BTN)
        Me.Controls.Add(Me.CorrectiveWindow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmIncidentReport"
        Me.Text = "frmIncidentReport"
        Me.CorrectiveWindow.ResumeLayout(False)
        Me.IR_Page.ResumeLayout(False)
        Me.IR_Page.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ShowCause_Page.ResumeLayout(False)
        Me.ShowCause_Page.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Optional_Group.ResumeLayout(False)
        Me.Optional_Group.PerformLayout()
        Me.RuleViolated_GB.ResumeLayout(False)
        Me.RuleViolated_GB.PerformLayout()
        Me.Explanation_Page.ResumeLayout(False)
        Me.Explanation_Page.PerformLayout()
        Me.Modify_Panel.ResumeLayout(False)
        Me.Modify_Panel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Explain_datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WrittenReprimand_Page.ResumeLayout(False)
        Me.WrittenReprimand_Page.PerformLayout()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ECS_GB.ResumeLayout(False)
        Me.ECS_GB.PerformLayout()
        CType(Me.NumberOfDays_TXT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Acknowledg_Page.ResumeLayout(False)
        Me.Acknowledg_Page.PerformLayout()
        Me.Ack_Panel.ResumeLayout(False)
        Me.Ack_Panel.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ack_Datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Corrective_Page.ResumeLayout(False)
        Me.Corrective_Page.PerformLayout()
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.Coo_NoOfDays_Numeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label21 As Label
    Friend WithEvents Close_BTN As Button
    Friend WithEvents CorrectiveWindow As TabControl
    Friend WithEvents IR_Page As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents RptViewer_IncidentReport As ReportViewer
    Friend WithEvents Panel6 As Panel
    Friend WithEvents SaveIR_BTN As Button
    Friend WithEvents ClearIR_BTN As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PreviewIR_BTN As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label38 As Label
    Friend WithEvents PreparedBy_TXT As TextBox
    Friend WithEvents ReviewedBy_TXT As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents Received_TXT As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents Description_RichText As RichTextBox
    Friend WithEvents Supervisor_BTN As Button
    Friend WithEvents DateReceive_DTP As DateTimePicker
    Friend WithEvents DateIncident_DTP As DateTimePicker
    Friend WithEvents Action_CB As ComboBox
    Friend WithEvents Supervisor_TXT As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents PositionS_TXT As TextBox
    Friend WithEvents Person_BTN As Button
    Friend WithEvents Label30 As Label
    Friend WithEvents Person_TXT As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents IncidentLoc_TXT As TextBox
    Friend WithEvents PositionP_TXT As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Department_TXT As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents IRNo_LBL As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents ShowCause_Page As TabPage
    Friend WithEvents Label17 As Label
    Friend WithEvents SCNo_LBL As Label
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents RptViewer_ShowCause As ReportViewer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents EmpName_TXT As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Position_TXT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Branch_TXT As TextBox
    Friend WithEvents Company_TXT As TextBox
    Friend WithEvents SearchEMP_BTN As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Optional_Group As GroupBox
    Friend WithEvents DateSent_DTP As DateTimePicker
    Friend WithEvents Label20 As Label
    Friend WithEvents SentVia_TXT As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PS3_Btn As Button
    Friend WithEvents Save_BTN As Button
    Friend WithEvents PS1_Btn As Button
    Friend WithEvents OK_BTN As Button
    Friend WithEvents Position1_TXT As TextBox
    Friend WithEvents Position3_TXT As TextBox
    Friend WithEvents BusinessUnitHead_TXT As TextBox
    Friend WithEvents HRSupervisor_TXT As TextBox
    Friend WithEvents RuleViolated_GB As GroupBox
    Friend WithEvents Label41 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents SC_IncidentDate_RichB As RichTextBox
    Friend WithEvents SCRuleNo_LBL As Label
    Friend WithEvents LV_Sections As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents AuditFindings_TXT As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Location_TXT As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Explanation_Page As TabPage
    Friend WithEvents Status_Combo As ComboBox
    Friend WithEvents Label43 As Label
    Friend WithEvents SearchBy_Combo As ComboBox
    Friend WithEvents Modify_Panel As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Close_Modify_BTN As Button
    Friend WithEvents Check_BTN As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Explain_datagrid As DataGridView
    Friend WithEvents IRNO_DGV As DataGridViewTextBoxColumn
    Friend WithEvents Name_DGV As DataGridViewTextBoxColumn
    Friend WithEvents Company_DGV As DataGridViewTextBoxColumn
    Friend WithEvents Deadline_DGV As DataGridViewTextBoxColumn
    Friend WithEvents IR_DGV As DataGridViewButtonColumn
    Friend WithEvents File_DGV As DataGridViewButtonColumn
    Friend WithEvents Explain_DGV As DataGridViewButtonColumn
    Friend WithEvents RptViewer_Explanation As ReportViewer
    Friend WithEvents WrittenReprimand_Page As TabPage
    Friend WithEvents Label25 As Label
    Friend WithEvents IRNoWritten_LBL As Label
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents RptViewer_WrittenReprimand As ReportViewer
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents WP_DateIncident_DTP As RichTextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents WPRule_LBL As Label
    Friend WithEvents WP_SectionsList As ListView
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents WP_Incident_TXT As RichTextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents ECS_GB As GroupBox
    Friend WithEvents Label46 As Label
    Friend WithEvents NoOfMONTHS_TXT As TextBox
    Friend WithEvents Charges_Numeric As TextBox
    Friend WithEvents ECSNo_TXT As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents AmountCharges_CB As CheckBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents NumberOfDays_TXT As NumericUpDown
    Friend WithEvents NoDaysSuspend_CB As CheckBox
    Friend WithEvents WP_PS4_Btn As Button
    Friend WithEvents WP_PS2_Btn As Button
    Friend WithEvents WP_PS3_Btn As Button
    Friend WithEvents WP_PS1_Btn As Button
    Friend WithEvents WP_Position4_TXT As TextBox
    Friend WithEvents WP_Position2_TXT As TextBox
    Friend WithEvents WP_Position3_TXT As TextBox
    Friend WithEvents WP_Position1_TXT As TextBox
    Friend WithEvents SixDays_RBTN As RadioButton
    Friend WithEvents FourDays_RBTN As RadioButton
    Friend WithEvents TwoDays_RBTN As RadioButton
    Friend WithEvents WW_RBTN As RadioButton
    Friend WithEvents WP_Officer_Incharge_TXT As TextBox
    Friend WithEvents WP_HR_Sup_TXT As TextBox
    Friend WithEvents WP_BusinessHead_TXT As TextBox
    Friend WithEvents WP_Emp_Rel_TXT As TextBox
    Friend WithEvents WP_Save_Btn As Button
    Friend WithEvents WP_OK_BTN As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents SearchWP_EMP_BTN As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents WP_Branch_TXT As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents WP_Company_TXT As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents WP_Position_TXT As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents WP_Name_TXT As TextBox
    Friend WithEvents Acknowledg_Page As TabPage
    Friend WithEvents Corrective_Page As TabPage
    Friend WithEvents Ack_Panel As Panel
    Friend WithEvents Label47 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents CancelAck_BTN As Button
    Friend WithEvents SaveAck_BTN As Button
    Friend WithEvents Ack_Datagrid As DataGridView
    Friend WithEvents IRNO_DGVV As DataGridViewTextBoxColumn
    Friend WithEvents Name_DGVV As DataGridViewTextBoxColumn
    Friend WithEvents Company_DGVV As DataGridViewTextBoxColumn
    Friend WithEvents IR_DGVV As DataGridViewButtonColumn
    Friend WithEvents SC_DGVV As DataGridViewButtonColumn
    Friend WithEvents Explain_DGVV As DataGridViewButtonColumn
    Friend WithEvents WRITTEN_DGVV As DataGridViewButtonColumn
    Friend WithEvents ACKNOW_DGVV As DataGridViewButtonColumn
    Friend WithEvents StatusACK_Combo As ComboBox
    Friend WithEvents Label42 As Label
    Friend WithEvents SearchAck_Combo As ComboBox
    Friend WithEvents SearchAck_TXT As TextBox
    Friend WithEvents RptViewer_Acknowledge As ReportViewer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer4 As SplitContainer
    Friend WithEvents RptViewer_Corrective As ReportViewer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Coo_DateIncident_RB As RichTextBox
    Friend WithEvents Label48 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Coo_Rule_LBL As Label
    Friend WithEvents Coo_SectionList As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Coo_Description_RB As RichTextBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Label55 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents Coo_NoOfDays_Numeric As NumericUpDown
    Friend WithEvents Change4_BTN As Button
    Friend WithEvents Change2_BTN As Button
    Friend WithEvents Change3_BTN As Button
    Friend WithEvents Change1_BTN As Button
    Friend WithEvents Coo_Noted_Pos_TXT As TextBox
    Friend WithEvents Coo_Rev_Pos1_TXT As TextBox
    Friend WithEvents Coo_Rev_Pos2_TXT As TextBox
    Friend WithEvents Coo_Pre_Pos_TXT As TextBox
    Friend WithEvents Coo_Rev_Name2_TXT As TextBox
    Friend WithEvents Coo_Rev_Name1_TXT As TextBox
    Friend WithEvents Coo_Noted_Name_TXT As TextBox
    Friend WithEvents Coo_Pre_Name_TXT As TextBox
    Friend WithEvents SaveCOR_BTN As Button
    Friend WithEvents PreviewCOR_BTN As Button
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents Coo_Emp_BTN As Button
    Friend WithEvents Label58 As Label
    Friend WithEvents Coo_Branch_TXT As TextBox
    Friend WithEvents Label59 As Label
    Friend WithEvents Coo_Company_TXT As TextBox
    Friend WithEvents Label60 As Label
    Friend WithEvents Coo_Position_TXT As TextBox
    Friend WithEvents Label62 As Label
    Friend WithEvents Coo_Name_TXT As TextBox
    Friend WithEvents Label61 As Label
    Friend WithEvents IRNoCOO_LBL As Label
    Friend WithEvents ClearDateSuspension_BTN As Button
    Friend WithEvents DateSuspension_DPT As DateTimePicker
    Friend WithEvents Label52 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents Coo_Violation As RichTextBox
    Friend WithEvents Label50 As Label
    Friend WithEvents Coo_SCDate_LBL As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents Coo_WRDate_LBL As Label
    Friend WithEvents SCViolation_RichB As RichTextBox
    Friend WithEvents Label63 As Label
End Class
