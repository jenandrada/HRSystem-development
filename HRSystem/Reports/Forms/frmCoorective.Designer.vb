<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCoorective
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCoorective))
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
        Me.Reports_Page = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Close_BTN = New System.Windows.Forms.Button()
        Me.FbDataAdapter1 = New FirebirdSql.Data.FirebirdClient.FbDataAdapter()
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
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'CorrectiveWindow
        '
        Me.CorrectiveWindow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CorrectiveWindow.Controls.Add(Me.IR_Page)
        Me.CorrectiveWindow.Controls.Add(Me.ShowCause_Page)
        Me.CorrectiveWindow.Controls.Add(Me.Explanation_Page)
        Me.CorrectiveWindow.Controls.Add(Me.WrittenReprimand_Page)
        Me.CorrectiveWindow.Controls.Add(Me.Acknowledg_Page)
        Me.CorrectiveWindow.Controls.Add(Me.Reports_Page)
        Me.CorrectiveWindow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CorrectiveWindow.Location = New System.Drawing.Point(2, 45)
        Me.CorrectiveWindow.Name = "CorrectiveWindow"
        Me.CorrectiveWindow.SelectedIndex = 0
        Me.CorrectiveWindow.Size = New System.Drawing.Size(1175, 700)
        Me.CorrectiveWindow.TabIndex = 2
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
        Me.IRNo_LBL.Location = New System.Drawing.Point(1026, 5)
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
        Me.Label23.Location = New System.Drawing.Point(966, 5)
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
        Me.GroupBox1.Location = New System.Drawing.Point(21, 53)
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
        Me.GroupBox3.Location = New System.Drawing.Point(21, 1027)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(614, 458)
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
        Me.RuleViolated_GB.Location = New System.Drawing.Point(21, 249)
        Me.RuleViolated_GB.Name = "RuleViolated_GB"
        Me.RuleViolated_GB.Size = New System.Drawing.Size(614, 765)
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
        Me.Label8.Size = New System.Drawing.Size(89, 21)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Violation(s)"
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
        Me.Acknowledg_Page.Location = New System.Drawing.Point(4, 29)
        Me.Acknowledg_Page.Name = "Acknowledg_Page"
        Me.Acknowledg_Page.Padding = New System.Windows.Forms.Padding(3)
        Me.Acknowledg_Page.Size = New System.Drawing.Size(1167, 667)
        Me.Acknowledg_Page.TabIndex = 4
        Me.Acknowledg_Page.Text = "   Acknowledgment   "
        Me.Acknowledg_Page.UseVisualStyleBackColor = True
        '
        'Reports_Page
        '
        Me.Reports_Page.Location = New System.Drawing.Point(4, 29)
        Me.Reports_Page.Name = "Reports_Page"
        Me.Reports_Page.Padding = New System.Windows.Forms.Padding(3)
        Me.Reports_Page.Size = New System.Drawing.Size(1167, 667)
        Me.Reports_Page.TabIndex = 5
        Me.Reports_Page.Text = "   Reports   "
        Me.Reports_Page.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.Close_BTN)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1181, 43)
        Me.Panel3.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Label21.Location = New System.Drawing.Point(3, 6)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(123, 32)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "Corrective"
        '
        'Close_BTN
        '
        Me.Close_BTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Close_BTN.Image = CType(resources.GetObject("Close_BTN.Image"), System.Drawing.Image)
        Me.Close_BTN.Location = New System.Drawing.Point(1151, 0)
        Me.Close_BTN.Name = "Close_BTN"
        Me.Close_BTN.Size = New System.Drawing.Size(30, 30)
        Me.Close_BTN.TabIndex = 0
        Me.Close_BTN.UseVisualStyleBackColor = True
        '
        'frmCoorective
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 749)
        Me.Controls.Add(Me.CorrectiveWindow)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCoorective"
        Me.Text = "frmCoorective"
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
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Close_BTN As Button
    Friend WithEvents CorrectiveWindow As TabControl
    Friend WithEvents Explanation_Page As TabPage
    Friend WithEvents Explain_datagrid As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents FbDataAdapter1 As FirebirdSql.Data.FirebirdClient.FbDataAdapter
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Modify_Panel As Panel
    Friend WithEvents Close_Modify_BTN As Button
    Friend WithEvents Check_BTN As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label24 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents PreviewIR_BTN As Button
    Friend WithEvents SaveIR_BTN As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label38 As Label
    Friend WithEvents PreparedBy_TXT As TextBox
    Friend WithEvents ReviewedBy_TXT As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents Received_TXT As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Description_RichText As RichTextBox
    Friend WithEvents IRNo_LBL As Label
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
    Friend WithEvents RptViewer_IncidentReport As ReportViewer
    Friend WithEvents ClearIR_BTN As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents RptViewer_Explanation As ReportViewer
    Friend WithEvents ShowCause_Page As TabPage
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents RptViewer_ShowCause As ReportViewer
    Friend WithEvents Label17 As Label
    Friend WithEvents SCNo_LBL As Label
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
    Friend WithEvents AuditFindings_TXT As RichTextBox
    Friend WithEvents LV_Sections As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Label5 As Label
    Friend WithEvents Location_TXT As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Optional_Group As GroupBox
    Friend WithEvents DateSent_DTP As DateTimePicker
    Friend WithEvents Label20 As Label
    Friend WithEvents SentVia_TXT As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents IRNO_DGV As DataGridViewTextBoxColumn
    Friend WithEvents Name_DGV As DataGridViewTextBoxColumn
    Friend WithEvents Company_DGV As DataGridViewTextBoxColumn
    Friend WithEvents Deadline_DGV As DataGridViewTextBoxColumn
    Friend WithEvents IR_DGV As DataGridViewButtonColumn
    Friend WithEvents File_DGV As DataGridViewButtonColumn
    Friend WithEvents Explain_DGV As DataGridViewButtonColumn
    Friend WithEvents Label22 As Label
    Friend WithEvents WrittenReprimand_Page As TabPage
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents RptViewer_WrittenReprimand As ReportViewer
    Friend WithEvents GroupBox5 As GroupBox
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
    Friend WithEvents WP_SectionsList As ListView
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
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
    Friend WithEvents AmountCharges_CB As CheckBox
    Friend WithEvents Label25 As Label
    Friend WithEvents IRNoWritten_LBL As Label
    Friend WithEvents WP_Incident_TXT As RichTextBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents WPRule_LBL As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents SCRuleNo_LBL As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents SC_IncidentDate_RichB As RichTextBox
    Friend WithEvents WP_DateIncident_DTP As RichTextBox
    Friend WithEvents IR_Page As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SearchBy_Combo As ComboBox
    Friend WithEvents Status_Combo As ComboBox
    Friend WithEvents Label43 As Label
    Friend WithEvents Acknowledg_Page As TabPage
    Friend WithEvents Reports_Page As TabPage
    Friend WithEvents ECS_GB As GroupBox
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents NoOfMONTHS_TXT As TextBox
    Friend WithEvents Charges_Numeric As TextBox
    Friend WithEvents ECSNo_TXT As TextBox
End Class
