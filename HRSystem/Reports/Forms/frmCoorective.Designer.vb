﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SCNo_LBL = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Optional_CHK = New System.Windows.Forms.CheckBox()
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
        Me.Explaination_TXT = New System.Windows.Forms.TextBox()
        Me.Position3_TXT = New System.Windows.Forms.TextBox()
        Me.BusinessUnitHead_TXT = New System.Windows.Forms.TextBox()
        Me.HRSupervisor_TXT = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AuditFindings_TXT = New System.Windows.Forms.RichTextBox()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LV_Rules = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LV_Sections = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Audit_CHK = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Location_TXT = New System.Windows.Forms.TextBox()
        Me.FromAuditDate_DTP = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.RptViewer_ShowCause = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CorrectiveWindow = New System.Windows.Forms.TabControl()
        Me.ShowCause_Page = New System.Windows.Forms.TabPage()
        Me.WrittenReprimand_Page = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NumberOfDays_TXT = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
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
        Me.Label14 = New System.Windows.Forms.Label()
        Me.WP_Incident_TXT = New System.Windows.Forms.RichTextBox()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.RulesTabPage = New System.Windows.Forms.TabPage()
        Me.WP_RulesList = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SectionsTabPage = New System.Windows.Forms.TabPage()
        Me.WP_SectionsList = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.Splitter2 = New System.Windows.Forms.Splitter()
        Me.RptViewer_WrittenReprimand = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Attachment_Page = New System.Windows.Forms.TabPage()
        Me.Modify_Panel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Close_Modify_BTN = New System.Windows.Forms.Button()
        Me.Check_BTN = New System.Windows.Forms.Button()
        Me.Finish_RB = New System.Windows.Forms.RadioButton()
        Me.Pending_RB = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SCNO_DGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name_DGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Company_DGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Deadline_DGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.File_DGV = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Explain_DGV = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Close_BTN = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.FbDataAdapter1 = New FirebirdSql.Data.FirebirdClient.FbDataAdapter()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Optional_Group.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.CorrectiveWindow.SuspendLayout()
        Me.ShowCause_Page.SuspendLayout()
        Me.WrittenReprimand_Page.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.NumberOfDays_TXT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl3.SuspendLayout()
        Me.RulesTabPage.SuspendLayout()
        Me.SectionsTabPage.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Attachment_Page.SuspendLayout()
        Me.Modify_Panel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.SCNo_LBL)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(518, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(649, 667)
        Me.Panel1.TabIndex = 0
        '
        'SCNo_LBL
        '
        Me.SCNo_LBL.AutoSize = True
        Me.SCNo_LBL.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SCNo_LBL.Location = New System.Drawing.Point(525, 20)
        Me.SCNo_LBL.Name = "SCNo_LBL"
        Me.SCNo_LBL.Size = New System.Drawing.Size(55, 21)
        Me.SCNo_LBL.TabIndex = 16
        Me.SCNo_LBL.Text = "00001"
        Me.SCNo_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(389, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(123, 21)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Show Cause No."
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Optional_CHK)
        Me.GroupBox3.Controls.Add(Me.Optional_Group)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.PS3_Btn)
        Me.GroupBox3.Controls.Add(Me.Save_BTN)
        Me.GroupBox3.Controls.Add(Me.PS1_Btn)
        Me.GroupBox3.Controls.Add(Me.OK_BTN)
        Me.GroupBox3.Controls.Add(Me.Position1_TXT)
        Me.GroupBox3.Controls.Add(Me.Explaination_TXT)
        Me.GroupBox3.Controls.Add(Me.Position3_TXT)
        Me.GroupBox3.Controls.Add(Me.BusinessUnitHead_TXT)
        Me.GroupBox3.Controls.Add(Me.HRSupervisor_TXT)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(27, 784)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(582, 488)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Explanation"
        '
        'Optional_CHK
        '
        Me.Optional_CHK.AutoSize = True
        Me.Optional_CHK.Location = New System.Drawing.Point(18, 230)
        Me.Optional_CHK.Name = "Optional_CHK"
        Me.Optional_CHK.Size = New System.Drawing.Size(89, 25)
        Me.Optional_CHK.TabIndex = 47
        Me.Optional_CHK.Text = "Optional"
        Me.Optional_CHK.UseVisualStyleBackColor = True
        '
        'Optional_Group
        '
        Me.Optional_Group.Controls.Add(Me.DateSent_DTP)
        Me.Optional_Group.Controls.Add(Me.Label20)
        Me.Optional_Group.Controls.Add(Me.SentVia_TXT)
        Me.Optional_Group.Controls.Add(Me.Label19)
        Me.Optional_Group.Location = New System.Drawing.Point(18, 252)
        Me.Optional_Group.Name = "Optional_Group"
        Me.Optional_Group.Size = New System.Drawing.Size(546, 133)
        Me.Optional_Group.TabIndex = 39
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
        Me.Label18.Location = New System.Drawing.Point(386, 127)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(102, 21)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "Approved By:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(14, 127)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(97, 21)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Prepared By:"
        '
        'PS3_Btn
        '
        Me.PS3_Btn.Location = New System.Drawing.Point(538, 150)
        Me.PS3_Btn.Name = "PS3_Btn"
        Me.PS3_Btn.Size = New System.Drawing.Size(26, 26)
        Me.PS3_Btn.TabIndex = 26
        Me.PS3_Btn.Text = "C"
        Me.PS3_Btn.UseVisualStyleBackColor = True
        '
        'Save_BTN
        '
        Me.Save_BTN.Location = New System.Drawing.Point(270, 423)
        Me.Save_BTN.Name = "Save_BTN"
        Me.Save_BTN.Size = New System.Drawing.Size(139, 46)
        Me.Save_BTN.TabIndex = 21
        Me.Save_BTN.Text = "Save/Export"
        Me.Save_BTN.UseVisualStyleBackColor = True
        '
        'PS1_Btn
        '
        Me.PS1_Btn.Location = New System.Drawing.Point(166, 150)
        Me.PS1_Btn.Name = "PS1_Btn"
        Me.PS1_Btn.Size = New System.Drawing.Size(26, 26)
        Me.PS1_Btn.TabIndex = 24
        Me.PS1_Btn.Text = "C"
        Me.PS1_Btn.UseVisualStyleBackColor = True
        '
        'OK_BTN
        '
        Me.OK_BTN.Location = New System.Drawing.Point(437, 423)
        Me.OK_BTN.Name = "OK_BTN"
        Me.OK_BTN.Size = New System.Drawing.Size(139, 46)
        Me.OK_BTN.TabIndex = 14
        Me.OK_BTN.Text = "Preview"
        Me.OK_BTN.UseVisualStyleBackColor = True
        '
        'Position1_TXT
        '
        Me.Position1_TXT.Location = New System.Drawing.Point(18, 150)
        Me.Position1_TXT.Name = "Position1_TXT"
        Me.Position1_TXT.ReadOnly = True
        Me.Position1_TXT.Size = New System.Drawing.Size(142, 28)
        Me.Position1_TXT.TabIndex = 21
        Me.Position1_TXT.Text = "HR Staff"
        '
        'Explaination_TXT
        '
        Me.Explaination_TXT.Location = New System.Drawing.Point(21, 30)
        Me.Explaination_TXT.Multiline = True
        Me.Explaination_TXT.Name = "Explaination_TXT"
        Me.Explaination_TXT.Size = New System.Drawing.Size(540, 78)
        Me.Explaination_TXT.TabIndex = 0
        '
        'Position3_TXT
        '
        Me.Position3_TXT.Location = New System.Drawing.Point(390, 150)
        Me.Position3_TXT.Name = "Position3_TXT"
        Me.Position3_TXT.ReadOnly = True
        Me.Position3_TXT.Size = New System.Drawing.Size(139, 28)
        Me.Position3_TXT.TabIndex = 23
        Me.Position3_TXT.Text = "HR Head"
        '
        'BusinessUnitHead_TXT
        '
        Me.BusinessUnitHead_TXT.Location = New System.Drawing.Point(390, 182)
        Me.BusinessUnitHead_TXT.Name = "BusinessUnitHead_TXT"
        Me.BusinessUnitHead_TXT.Size = New System.Drawing.Size(174, 28)
        Me.BusinessUnitHead_TXT.TabIndex = 17
        '
        'HRSupervisor_TXT
        '
        Me.HRSupervisor_TXT.Location = New System.Drawing.Point(18, 182)
        Me.HRSupervisor_TXT.Name = "HRSupervisor_TXT"
        Me.HRSupervisor_TXT.Size = New System.Drawing.Size(174, 28)
        Me.HRSupervisor_TXT.TabIndex = 15
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.AuditFindings_TXT)
        Me.GroupBox2.Controls.Add(Me.TabControl2)
        Me.GroupBox2.Controls.Add(Me.Audit_CHK)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Location_TXT)
        Me.GroupBox2.Controls.Add(Me.FromAuditDate_DTP)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(27, 244)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(582, 517)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rules Violated"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(457, 465)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 29)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AuditFindings_TXT
        '
        Me.AuditFindings_TXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AuditFindings_TXT.BulletIndent = 1
        Me.AuditFindings_TXT.Location = New System.Drawing.Point(21, 307)
        Me.AuditFindings_TXT.Name = "AuditFindings_TXT"
        Me.AuditFindings_TXT.Size = New System.Drawing.Size(540, 103)
        Me.AuditFindings_TXT.TabIndex = 21
        Me.AuditFindings_TXT.Text = ""
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Location = New System.Drawing.Point(21, 33)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(540, 237)
        Me.TabControl2.TabIndex = 20
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.LV_Rules)
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(532, 203)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Rules"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'LV_Rules
        '
        Me.LV_Rules.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.LV_Rules.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LV_Rules.FullRowSelect = True
        Me.LV_Rules.HideSelection = False
        Me.LV_Rules.Location = New System.Drawing.Point(3, 3)
        Me.LV_Rules.Name = "LV_Rules"
        Me.LV_Rules.Size = New System.Drawing.Size(526, 197)
        Me.LV_Rules.TabIndex = 21
        Me.LV_Rules.UseCompatibleStateImageBehavior = False
        Me.LV_Rules.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Rule Number"
        Me.ColumnHeader1.Width = 110
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Rule Definition"
        Me.ColumnHeader2.Width = 411
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LV_Sections)
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(532, 203)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Sections"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LV_Sections
        '
        Me.LV_Sections.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.LV_Sections.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LV_Sections.FullRowSelect = True
        Me.LV_Sections.HideSelection = False
        Me.LV_Sections.Location = New System.Drawing.Point(3, 3)
        Me.LV_Sections.Name = "LV_Sections"
        Me.LV_Sections.Size = New System.Drawing.Size(526, 197)
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
        Me.ColumnHeader4.Width = 383
        '
        'Audit_CHK
        '
        Me.Audit_CHK.AutoSize = True
        Me.Audit_CHK.Location = New System.Drawing.Point(496, 281)
        Me.Audit_CHK.Name = "Audit_CHK"
        Me.Audit_CHK.Size = New System.Drawing.Size(66, 25)
        Me.Audit_CHK.TabIndex = 19
        Me.Audit_CHK.Text = "Audit"
        Me.Audit_CHK.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 427)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 21)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Location"
        '
        'Location_TXT
        '
        Me.Location_TXT.Location = New System.Drawing.Point(94, 424)
        Me.Location_TXT.Name = "Location_TXT"
        Me.Location_TXT.Size = New System.Drawing.Size(460, 28)
        Me.Location_TXT.TabIndex = 17
        '
        'FromAuditDate_DTP
        '
        Me.FromAuditDate_DTP.CustomFormat = "ddd, MMMM dd , yyyy"
        Me.FromAuditDate_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromAuditDate_DTP.Location = New System.Drawing.Point(94, 466)
        Me.FromAuditDate_DTP.Name = "FromAuditDate_DTP"
        Me.FromAuditDate_DTP.Size = New System.Drawing.Size(357, 28)
        Me.FromAuditDate_DTP.TabIndex = 16
        Me.FromAuditDate_DTP.Value = New Date(2019, 9, 6, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 284)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 21)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Violation(s)"
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
        Me.GroupBox1.Location = New System.Drawing.Point(27, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(582, 164)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.EmpName_TXT)
        Me.GroupBox6.Location = New System.Drawing.Point(131, 25)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(386, 35)
        Me.GroupBox6.TabIndex = 15
        Me.GroupBox6.TabStop = False
        '
        'EmpName_TXT
        '
        Me.EmpName_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpName_TXT.Location = New System.Drawing.Point(4, 9)
        Me.EmpName_TXT.Name = "EmpName_TXT"
        Me.EmpName_TXT.Size = New System.Drawing.Size(379, 26)
        Me.EmpName_TXT.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name:"
        '
        'Position_TXT
        '
        Me.Position_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Position_TXT.Location = New System.Drawing.Point(136, 76)
        Me.Position_TXT.Name = "Position_TXT"
        Me.Position_TXT.Size = New System.Drawing.Size(379, 26)
        Me.Position_TXT.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(282, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Branch:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Positon: "
        '
        'Branch_TXT
        '
        Me.Branch_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Branch_TXT.Location = New System.Drawing.Point(352, 121)
        Me.Branch_TXT.Name = "Branch_TXT"
        Me.Branch_TXT.Size = New System.Drawing.Size(163, 26)
        Me.Branch_TXT.TabIndex = 8
        '
        'Company_TXT
        '
        Me.Company_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Company_TXT.Location = New System.Drawing.Point(136, 121)
        Me.Company_TXT.Name = "Company_TXT"
        Me.Company_TXT.Size = New System.Drawing.Size(140, 26)
        Me.Company_TXT.TabIndex = 5
        '
        'SearchEMP_BTN
        '
        Me.SearchEMP_BTN.Location = New System.Drawing.Point(521, 31)
        Me.SearchEMP_BTN.Name = "SearchEMP_BTN"
        Me.SearchEMP_BTN.Size = New System.Drawing.Size(35, 26)
        Me.SearchEMP_BTN.TabIndex = 7
        Me.SearchEMP_BTN.Text = "..."
        Me.SearchEMP_BTN.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Company:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Splitter1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.RptViewer_ShowCause)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1167, 667)
        Me.Panel2.TabIndex = 1
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(518, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 667)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'RptViewer_ShowCause
        '
        Me.RptViewer_ShowCause.Dock = System.Windows.Forms.DockStyle.Left
        Me.RptViewer_ShowCause.DocumentMapWidth = 1
        Me.RptViewer_ShowCause.LocalReport.ReportEmbeddedResource = "HRSystem.rpt_ShowCause.rdlc"
        Me.RptViewer_ShowCause.Location = New System.Drawing.Point(0, 0)
        Me.RptViewer_ShowCause.Name = "RptViewer_ShowCause"
        Me.RptViewer_ShowCause.ServerReport.BearerToken = Nothing
        Me.RptViewer_ShowCause.Size = New System.Drawing.Size(518, 667)
        Me.RptViewer_ShowCause.TabIndex = 0
        '
        'CorrectiveWindow
        '
        Me.CorrectiveWindow.Controls.Add(Me.ShowCause_Page)
        Me.CorrectiveWindow.Controls.Add(Me.WrittenReprimand_Page)
        Me.CorrectiveWindow.Controls.Add(Me.Attachment_Page)
        Me.CorrectiveWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CorrectiveWindow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CorrectiveWindow.Location = New System.Drawing.Point(0, 43)
        Me.CorrectiveWindow.Name = "CorrectiveWindow"
        Me.CorrectiveWindow.SelectedIndex = 0
        Me.CorrectiveWindow.Size = New System.Drawing.Size(1181, 706)
        Me.CorrectiveWindow.TabIndex = 2
        '
        'ShowCause_Page
        '
        Me.ShowCause_Page.Controls.Add(Me.Panel2)
        Me.ShowCause_Page.Location = New System.Drawing.Point(4, 29)
        Me.ShowCause_Page.Name = "ShowCause_Page"
        Me.ShowCause_Page.Padding = New System.Windows.Forms.Padding(3)
        Me.ShowCause_Page.Size = New System.Drawing.Size(1173, 673)
        Me.ShowCause_Page.TabIndex = 0
        Me.ShowCause_Page.Text = "   Show Cause Notice   "
        Me.ShowCause_Page.UseVisualStyleBackColor = True
        '
        'WrittenReprimand_Page
        '
        Me.WrittenReprimand_Page.Controls.Add(Me.Panel4)
        Me.WrittenReprimand_Page.Controls.Add(Me.Splitter2)
        Me.WrittenReprimand_Page.Controls.Add(Me.RptViewer_WrittenReprimand)
        Me.WrittenReprimand_Page.Location = New System.Drawing.Point(4, 29)
        Me.WrittenReprimand_Page.Name = "WrittenReprimand_Page"
        Me.WrittenReprimand_Page.Padding = New System.Windows.Forms.Padding(3)
        Me.WrittenReprimand_Page.Size = New System.Drawing.Size(1173, 673)
        Me.WrittenReprimand_Page.TabIndex = 1
        Me.WrittenReprimand_Page.Text = "   Written Reprimand Notice   "
        Me.WrittenReprimand_Page.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.Controls.Add(Me.GroupBox5)
        Me.Panel4.Controls.Add(Me.GroupBox4)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(548, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(622, 667)
        Me.Panel4.TabIndex = 2
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.NumberOfDays_TXT)
        Me.GroupBox5.Controls.Add(Me.CheckBox1)
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
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.WP_Incident_TXT)
        Me.GroupBox5.Controls.Add(Me.TabControl3)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(6, 181)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(584, 806)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Rule Violated"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(291, 641)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 21)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Approved By:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(292, 527)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 21)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Reviewed By:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 641)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 21)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Noted By:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 527)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 21)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Prepared By:"
        '
        'NumberOfDays_TXT
        '
        Me.NumberOfDays_TXT.Enabled = False
        Me.NumberOfDays_TXT.Location = New System.Drawing.Point(138, 479)
        Me.NumberOfDays_TXT.Name = "NumberOfDays_TXT"
        Me.NumberOfDays_TXT.Size = New System.Drawing.Size(309, 28)
        Me.NumberOfDays_TXT.TabIndex = 31
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(138, 449)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(304, 25)
        Me.CheckBox1.TabIndex = 30
        Me.CheckBox1.Text = "Manually set the no. of days suspension"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'WP_PS4_Btn
        '
        Me.WP_PS4_Btn.Location = New System.Drawing.Point(538, 664)
        Me.WP_PS4_Btn.Name = "WP_PS4_Btn"
        Me.WP_PS4_Btn.Size = New System.Drawing.Size(26, 26)
        Me.WP_PS4_Btn.TabIndex = 28
        Me.WP_PS4_Btn.Text = "C"
        Me.WP_PS4_Btn.UseVisualStyleBackColor = True
        '
        'WP_PS2_Btn
        '
        Me.WP_PS2_Btn.Location = New System.Drawing.Point(540, 550)
        Me.WP_PS2_Btn.Name = "WP_PS2_Btn"
        Me.WP_PS2_Btn.Size = New System.Drawing.Size(26, 26)
        Me.WP_PS2_Btn.TabIndex = 27
        Me.WP_PS2_Btn.Text = "C"
        Me.WP_PS2_Btn.UseVisualStyleBackColor = True
        '
        'WP_PS3_Btn
        '
        Me.WP_PS3_Btn.Location = New System.Drawing.Point(258, 664)
        Me.WP_PS3_Btn.Name = "WP_PS3_Btn"
        Me.WP_PS3_Btn.Size = New System.Drawing.Size(26, 26)
        Me.WP_PS3_Btn.TabIndex = 26
        Me.WP_PS3_Btn.Text = "C"
        Me.WP_PS3_Btn.UseVisualStyleBackColor = True
        '
        'WP_PS1_Btn
        '
        Me.WP_PS1_Btn.Location = New System.Drawing.Point(260, 550)
        Me.WP_PS1_Btn.Name = "WP_PS1_Btn"
        Me.WP_PS1_Btn.Size = New System.Drawing.Size(26, 26)
        Me.WP_PS1_Btn.TabIndex = 25
        Me.WP_PS1_Btn.Text = "C"
        Me.WP_PS1_Btn.UseVisualStyleBackColor = True
        '
        'WP_Position4_TXT
        '
        Me.WP_Position4_TXT.Location = New System.Drawing.Point(296, 664)
        Me.WP_Position4_TXT.Name = "WP_Position4_TXT"
        Me.WP_Position4_TXT.ReadOnly = True
        Me.WP_Position4_TXT.Size = New System.Drawing.Size(240, 28)
        Me.WP_Position4_TXT.TabIndex = 18
        Me.WP_Position4_TXT.Text = "Business Unit Head"
        '
        'WP_Position2_TXT
        '
        Me.WP_Position2_TXT.Location = New System.Drawing.Point(296, 550)
        Me.WP_Position2_TXT.Name = "WP_Position2_TXT"
        Me.WP_Position2_TXT.ReadOnly = True
        Me.WP_Position2_TXT.Size = New System.Drawing.Size(240, 28)
        Me.WP_Position2_TXT.TabIndex = 17
        Me.WP_Position2_TXT.Text = "HR Head"
        '
        'WP_Position3_TXT
        '
        Me.WP_Position3_TXT.Location = New System.Drawing.Point(12, 664)
        Me.WP_Position3_TXT.Name = "WP_Position3_TXT"
        Me.WP_Position3_TXT.ReadOnly = True
        Me.WP_Position3_TXT.Size = New System.Drawing.Size(240, 28)
        Me.WP_Position3_TXT.TabIndex = 16
        Me.WP_Position3_TXT.Text = "Operations Officer"
        '
        'WP_Position1_TXT
        '
        Me.WP_Position1_TXT.Location = New System.Drawing.Point(14, 550)
        Me.WP_Position1_TXT.Name = "WP_Position1_TXT"
        Me.WP_Position1_TXT.ReadOnly = True
        Me.WP_Position1_TXT.Size = New System.Drawing.Size(240, 28)
        Me.WP_Position1_TXT.TabIndex = 15
        Me.WP_Position1_TXT.Text = "HR Staff"
        '
        'SixDays_RBTN
        '
        Me.SixDays_RBTN.AutoSize = True
        Me.SixDays_RBTN.Location = New System.Drawing.Point(319, 413)
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
        Me.FourDays_RBTN.Location = New System.Drawing.Point(319, 383)
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
        Me.TwoDays_RBTN.Location = New System.Drawing.Point(74, 413)
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
        Me.WW_RBTN.Location = New System.Drawing.Point(74, 383)
        Me.WW_RBTN.Name = "WW_RBTN"
        Me.WW_RBTN.Size = New System.Drawing.Size(171, 25)
        Me.WW_RBTN.TabIndex = 11
        Me.WW_RBTN.TabStop = True
        Me.WW_RBTN.Text = "WRITTEN WARNING"
        Me.WW_RBTN.UseVisualStyleBackColor = True
        '
        'WP_Officer_Incharge_TXT
        '
        Me.WP_Officer_Incharge_TXT.Location = New System.Drawing.Point(12, 696)
        Me.WP_Officer_Incharge_TXT.Name = "WP_Officer_Incharge_TXT"
        Me.WP_Officer_Incharge_TXT.Size = New System.Drawing.Size(272, 28)
        Me.WP_Officer_Incharge_TXT.TabIndex = 10
        '
        'WP_HR_Sup_TXT
        '
        Me.WP_HR_Sup_TXT.Location = New System.Drawing.Point(296, 582)
        Me.WP_HR_Sup_TXT.Name = "WP_HR_Sup_TXT"
        Me.WP_HR_Sup_TXT.Size = New System.Drawing.Size(272, 28)
        Me.WP_HR_Sup_TXT.TabIndex = 8
        '
        'WP_BusinessHead_TXT
        '
        Me.WP_BusinessHead_TXT.Location = New System.Drawing.Point(296, 696)
        Me.WP_BusinessHead_TXT.Name = "WP_BusinessHead_TXT"
        Me.WP_BusinessHead_TXT.Size = New System.Drawing.Size(272, 28)
        Me.WP_BusinessHead_TXT.TabIndex = 8
        '
        'WP_Emp_Rel_TXT
        '
        Me.WP_Emp_Rel_TXT.Location = New System.Drawing.Point(14, 582)
        Me.WP_Emp_Rel_TXT.Name = "WP_Emp_Rel_TXT"
        Me.WP_Emp_Rel_TXT.Size = New System.Drawing.Size(272, 28)
        Me.WP_Emp_Rel_TXT.TabIndex = 6
        '
        'WP_Save_Btn
        '
        Me.WP_Save_Btn.Location = New System.Drawing.Point(363, 749)
        Me.WP_Save_Btn.Name = "WP_Save_Btn"
        Me.WP_Save_Btn.Size = New System.Drawing.Size(99, 51)
        Me.WP_Save_Btn.TabIndex = 4
        Me.WP_Save_Btn.Text = "Save"
        Me.WP_Save_Btn.UseVisualStyleBackColor = True
        '
        'WP_OK_BTN
        '
        Me.WP_OK_BTN.Location = New System.Drawing.Point(479, 749)
        Me.WP_OK_BTN.Name = "WP_OK_BTN"
        Me.WP_OK_BTN.Size = New System.Drawing.Size(99, 51)
        Me.WP_OK_BTN.TabIndex = 3
        Me.WP_OK_BTN.Text = "Preview"
        Me.WP_OK_BTN.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 237)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(235, 21)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "DESCRIPTION OF THE INCIDENT"
        '
        'WP_Incident_TXT
        '
        Me.WP_Incident_TXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WP_Incident_TXT.ForeColor = System.Drawing.SystemColors.Window
        Me.WP_Incident_TXT.Location = New System.Drawing.Point(14, 260)
        Me.WP_Incident_TXT.Name = "WP_Incident_TXT"
        Me.WP_Incident_TXT.Size = New System.Drawing.Size(563, 96)
        Me.WP_Incident_TXT.TabIndex = 1
        Me.WP_Incident_TXT.Text = ""
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.RulesTabPage)
        Me.TabControl3.Controls.Add(Me.SectionsTabPage)
        Me.TabControl3.Location = New System.Drawing.Point(6, 25)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(575, 193)
        Me.TabControl3.TabIndex = 0
        '
        'RulesTabPage
        '
        Me.RulesTabPage.Controls.Add(Me.WP_RulesList)
        Me.RulesTabPage.Location = New System.Drawing.Point(4, 30)
        Me.RulesTabPage.Name = "RulesTabPage"
        Me.RulesTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.RulesTabPage.Size = New System.Drawing.Size(567, 159)
        Me.RulesTabPage.TabIndex = 0
        Me.RulesTabPage.Text = "Rules"
        Me.RulesTabPage.UseVisualStyleBackColor = True
        '
        'WP_RulesList
        '
        Me.WP_RulesList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6})
        Me.WP_RulesList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WP_RulesList.FullRowSelect = True
        Me.WP_RulesList.HideSelection = False
        Me.WP_RulesList.Location = New System.Drawing.Point(3, 3)
        Me.WP_RulesList.Name = "WP_RulesList"
        Me.WP_RulesList.Size = New System.Drawing.Size(561, 153)
        Me.WP_RulesList.TabIndex = 0
        Me.WP_RulesList.UseCompatibleStateImageBehavior = False
        Me.WP_RulesList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Rule Number"
        Me.ColumnHeader5.Width = 110
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Rule Definition"
        Me.ColumnHeader6.Width = 411
        '
        'SectionsTabPage
        '
        Me.SectionsTabPage.Controls.Add(Me.WP_SectionsList)
        Me.SectionsTabPage.Location = New System.Drawing.Point(4, 30)
        Me.SectionsTabPage.Name = "SectionsTabPage"
        Me.SectionsTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.SectionsTabPage.Size = New System.Drawing.Size(567, 159)
        Me.SectionsTabPage.TabIndex = 1
        Me.SectionsTabPage.Text = "Sections"
        Me.SectionsTabPage.UseVisualStyleBackColor = True
        '
        'WP_SectionsList
        '
        Me.WP_SectionsList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8})
        Me.WP_SectionsList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WP_SectionsList.FullRowSelect = True
        Me.WP_SectionsList.HideSelection = False
        Me.WP_SectionsList.Location = New System.Drawing.Point(3, 3)
        Me.WP_SectionsList.Name = "WP_SectionsList"
        Me.WP_SectionsList.Size = New System.Drawing.Size(561, 153)
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
        Me.ColumnHeader8.Width = 383
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
        Me.GroupBox4.Location = New System.Drawing.Point(19, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(574, 145)
        Me.GroupBox4.TabIndex = 0
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
        'Splitter2
        '
        Me.Splitter2.Location = New System.Drawing.Point(545, 3)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(3, 667)
        Me.Splitter2.TabIndex = 1
        Me.Splitter2.TabStop = False
        '
        'RptViewer_WrittenReprimand
        '
        Me.RptViewer_WrittenReprimand.Dock = System.Windows.Forms.DockStyle.Left
        Me.RptViewer_WrittenReprimand.LocalReport.ReportEmbeddedResource = "HRSystem.rpt_WrittenReprimand.rdlc"
        Me.RptViewer_WrittenReprimand.Location = New System.Drawing.Point(3, 3)
        Me.RptViewer_WrittenReprimand.Name = "RptViewer_WrittenReprimand"
        Me.RptViewer_WrittenReprimand.ServerReport.BearerToken = Nothing
        Me.RptViewer_WrittenReprimand.Size = New System.Drawing.Size(542, 667)
        Me.RptViewer_WrittenReprimand.TabIndex = 0
        '
        'Attachment_Page
        '
        Me.Attachment_Page.Controls.Add(Me.Modify_Panel)
        Me.Attachment_Page.Controls.Add(Me.Finish_RB)
        Me.Attachment_Page.Controls.Add(Me.Pending_RB)
        Me.Attachment_Page.Controls.Add(Me.DataGridView1)
        Me.Attachment_Page.Location = New System.Drawing.Point(4, 29)
        Me.Attachment_Page.Name = "Attachment_Page"
        Me.Attachment_Page.Padding = New System.Windows.Forms.Padding(3)
        Me.Attachment_Page.Size = New System.Drawing.Size(1173, 673)
        Me.Attachment_Page.TabIndex = 2
        Me.Attachment_Page.Text = "   Attachment   "
        Me.Attachment_Page.UseVisualStyleBackColor = True
        '
        'Modify_Panel
        '
        Me.Modify_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Modify_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Modify_Panel.Controls.Add(Me.PictureBox1)
        Me.Modify_Panel.Controls.Add(Me.Close_Modify_BTN)
        Me.Modify_Panel.Controls.Add(Me.Check_BTN)
        Me.Modify_Panel.Location = New System.Drawing.Point(334, 119)
        Me.Modify_Panel.Name = "Modify_Panel"
        Me.Modify_Panel.Size = New System.Drawing.Size(412, 367)
        Me.Modify_Panel.TabIndex = 75
        Me.Modify_Panel.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(15, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(379, 297)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Close_Modify_BTN
        '
        Me.Close_Modify_BTN.Font = New System.Drawing.Font("Dubai", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Close_Modify_BTN.Location = New System.Drawing.Point(15, 324)
        Me.Close_Modify_BTN.Name = "Close_Modify_BTN"
        Me.Close_Modify_BTN.Size = New System.Drawing.Size(60, 35)
        Me.Close_Modify_BTN.TabIndex = 80
        Me.Close_Modify_BTN.Text = "X"
        Me.Close_Modify_BTN.UseVisualStyleBackColor = True
        '
        'Check_BTN
        '
        Me.Check_BTN.Font = New System.Drawing.Font("Dubai", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check_BTN.Location = New System.Drawing.Point(334, 324)
        Me.Check_BTN.Name = "Check_BTN"
        Me.Check_BTN.Size = New System.Drawing.Size(60, 35)
        Me.Check_BTN.TabIndex = 79
        Me.Check_BTN.Text = "√"
        Me.Check_BTN.UseVisualStyleBackColor = True
        '
        'Finish_RB
        '
        Me.Finish_RB.AutoSize = True
        Me.Finish_RB.Location = New System.Drawing.Point(1084, 16)
        Me.Finish_RB.Name = "Finish_RB"
        Me.Finish_RB.Size = New System.Drawing.Size(69, 24)
        Me.Finish_RB.TabIndex = 8
        Me.Finish_RB.Text = "Finish"
        Me.Finish_RB.UseVisualStyleBackColor = True
        '
        'Pending_RB
        '
        Me.Pending_RB.AutoSize = True
        Me.Pending_RB.Checked = True
        Me.Pending_RB.Location = New System.Drawing.Point(981, 16)
        Me.Pending_RB.Name = "Pending_RB"
        Me.Pending_RB.Size = New System.Drawing.Size(85, 24)
        Me.Pending_RB.TabIndex = 7
        Me.Pending_RB.TabStop = True
        Me.Pending_RB.Text = "Pending"
        Me.Pending_RB.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SCNO_DGV, Me.Name_DGV, Me.Company_DGV, Me.Deadline_DGV, Me.File_DGV, Me.Explain_DGV})
        Me.DataGridView1.Location = New System.Drawing.Point(9, 67)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.Size = New System.Drawing.Size(1156, 611)
        Me.DataGridView1.TabIndex = 6
        '
        'SCNO_DGV
        '
        Me.SCNO_DGV.HeaderText = "SC No."
        Me.SCNO_DGV.Name = "SCNO_DGV"
        Me.SCNO_DGV.ReadOnly = True
        Me.SCNO_DGV.Width = 130
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
        Me.Deadline_DGV.Width = 220
        '
        'File_DGV
        '
        Me.File_DGV.HeaderText = "   File Path"
        Me.File_DGV.Name = "File_DGV"
        Me.File_DGV.Width = 130
        '
        'Explain_DGV
        '
        Me.Explain_DGV.HeaderText = ""
        Me.Explain_DGV.Name = "Explain_DGV"
        Me.Explain_DGV.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Explain_DGV.Width = 140
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
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Optional_Group.ResumeLayout(False)
        Me.Optional_Group.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.CorrectiveWindow.ResumeLayout(False)
        Me.ShowCause_Page.ResumeLayout(False)
        Me.WrittenReprimand_Page.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.NumberOfDays_TXT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl3.ResumeLayout(False)
        Me.RulesTabPage.ResumeLayout(False)
        Me.SectionsTabPage.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Attachment_Page.ResumeLayout(False)
        Me.Attachment_Page.PerformLayout()
        Me.Modify_Panel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RptViewer_ShowCause As ReportViewer
    Friend WithEvents Close_BTN As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Company_TXT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Position_TXT As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents EmpName_TXT As TextBox
    Friend WithEvents SearchEMP_BTN As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Branch_TXT As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Explaination_TXT As TextBox
    Friend WithEvents OK_BTN As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Location_TXT As TextBox
    Friend WithEvents FromAuditDate_DTP As DateTimePicker
    Friend WithEvents CorrectiveWindow As TabControl
    Friend WithEvents ShowCause_Page As TabPage
    Friend WithEvents WrittenReprimand_Page As TabPage
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Audit_CHK As CheckBox
    Friend WithEvents BusinessUnitHead_TXT As TextBox
    Friend WithEvents HRSupervisor_TXT As TextBox
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents LV_Rules As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents LV_Sections As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents AuditFindings_TXT As RichTextBox
    Friend WithEvents Save_BTN As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Splitter2 As Splitter
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents WP_Branch_TXT As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents WP_Company_TXT As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents WP_Position_TXT As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents WP_Name_TXT As TextBox
    Friend WithEvents SearchWP_EMP_BTN As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents RulesTabPage As TabPage
    Friend WithEvents WP_RulesList As ListView
    Friend WithEvents SectionsTabPage As TabPage
    Friend WithEvents WP_SectionsList As ListView
    Friend WithEvents Label14 As Label
    Friend WithEvents WP_Incident_TXT As RichTextBox
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents WP_Officer_Incharge_TXT As TextBox
    Friend WithEvents WP_HR_Sup_TXT As TextBox
    Friend WithEvents WP_BusinessHead_TXT As TextBox
    Friend WithEvents WP_Emp_Rel_TXT As TextBox
    Friend WithEvents WP_Save_Btn As Button
    Friend WithEvents WP_OK_BTN As Button
    Friend WithEvents SixDays_RBTN As RadioButton
    Friend WithEvents FourDays_RBTN As RadioButton
    Friend WithEvents TwoDays_RBTN As RadioButton
    Friend WithEvents WW_RBTN As RadioButton
    Friend WithEvents PS3_Btn As Button
    Friend WithEvents PS1_Btn As Button
    Friend WithEvents Position1_TXT As TextBox
    Friend WithEvents Position3_TXT As TextBox
    Friend WithEvents WP_PS4_Btn As Button
    Friend WithEvents WP_PS2_Btn As Button
    Friend WithEvents WP_PS3_Btn As Button
    Friend WithEvents WP_PS1_Btn As Button
    Friend WithEvents WP_Position4_TXT As TextBox
    Friend WithEvents WP_Position2_TXT As TextBox
    Friend WithEvents WP_Position3_TXT As TextBox
    Friend WithEvents WP_Position1_TXT As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents NumberOfDays_TXT As NumericUpDown
    Friend WithEvents Label15 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Optional_Group As GroupBox
    Friend WithEvents Optional_CHK As CheckBox
    Friend WithEvents DateSent_DTP As DateTimePicker
    Friend WithEvents Label20 As Label
    Friend WithEvents SentVia_TXT As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents RptViewer_WrittenReprimand As ReportViewer
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents SCNo_LBL As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Attachment_Page As TabPage
    Friend WithEvents Finish_RB As RadioButton
    Friend WithEvents Pending_RB As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents FbDataAdapter1 As FirebirdSql.Data.FirebirdClient.FbDataAdapter
    Friend WithEvents SCNO_DGV As DataGridViewTextBoxColumn
    Friend WithEvents Name_DGV As DataGridViewTextBoxColumn
    Friend WithEvents Company_DGV As DataGridViewTextBoxColumn
    Friend WithEvents Deadline_DGV As DataGridViewTextBoxColumn
    Friend WithEvents File_DGV As DataGridViewButtonColumn
    Friend WithEvents Explain_DGV As DataGridViewImageColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Modify_Panel As Panel
    Friend WithEvents Close_Modify_BTN As Button
    Friend WithEvents Check_BTN As Button
End Class
