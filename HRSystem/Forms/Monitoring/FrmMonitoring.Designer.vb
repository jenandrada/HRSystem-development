<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMonitoring
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CloseWindow_BTN = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MonitoringWindow = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Brows_BTN = New System.Windows.Forms.Button()
        Me.Update_BTN = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateEncoded_DTP = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Save_BTN = New System.Windows.Forms.Button()
        Me.Remarks_TXT = New HRSystem.WaterMarkTextBox()
        Me.NoteReason_CHK = New System.Windows.Forms.CheckBox()
        Me.NoteReason_TXT = New HRSystem.WaterMarkTextBox()
        Me.Relieve_RBTN = New System.Windows.Forms.RadioButton()
        Me.Leave_RBTN = New System.Windows.Forms.RadioButton()
        Me.RestDay_RBTN = New System.Windows.Forms.RadioButton()
        Me.Absent_RBTN = New System.Windows.Forms.RadioButton()
        Me.Late_RBTN = New System.Windows.Forms.RadioButton()
        Me.Present_RBTN = New System.Windows.Forms.RadioButton()
        Me.EmpPosition_TXT = New HRSystem.WaterMarkTextBox()
        Me.EmpName_TXT = New HRSystem.WaterMarkTextBox()
        Me.Emp_List = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CompanyName_TXT = New HRSystem.WaterMarkTextBox()
        Me.BranchArea_TXT = New HRSystem.WaterMarkTextBox()
        Me.BranchName_TXT = New HRSystem.WaterMarkTextBox()
        Me.SelectBranch_BTN = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.L_DateEnded_DTP = New System.Windows.Forms.DateTimePicker()
        Me.L_Update_BTN = New System.Windows.Forms.Button()
        Me.L_Save_BTN = New System.Windows.Forms.Button()
        Me.L_Cancel_BTN = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.L_Type_CB = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.L_DateStarted_DTP = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.L_Information_TXT = New System.Windows.Forms.RichTextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Branch_List = New System.Windows.Forms.ListView()
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.L_SearchEmp_BTN = New System.Windows.Forms.Button()
        Me.L_EmpName_TXT = New HRSystem.WaterMarkTextBox()
        Me.L_Search_BTN = New System.Windows.Forms.Button()
        Me.L_Search_TXT = New System.Windows.Forms.TextBox()
        Me.Emp_Leave_LV = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MonitoringWindow.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CloseWindow_BTN)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1194, 40)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 40)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Monitoring"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CloseWindow_BTN
        '
        Me.CloseWindow_BTN.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseWindow_BTN.Dock = System.Windows.Forms.DockStyle.Right
        Me.CloseWindow_BTN.Image = Global.HRSystem.My.Resources.Resources.close_window_50px
        Me.CloseWindow_BTN.Location = New System.Drawing.Point(1154, 0)
        Me.CloseWindow_BTN.Name = "CloseWindow_BTN"
        Me.CloseWindow_BTN.Size = New System.Drawing.Size(40, 40)
        Me.CloseWindow_BTN.TabIndex = 5
        Me.CloseWindow_BTN.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.MonitoringWindow)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel2.Size = New System.Drawing.Size(1194, 663)
        Me.Panel2.TabIndex = 1
        '
        'MonitoringWindow
        '
        Me.MonitoringWindow.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.MonitoringWindow.Controls.Add(Me.TabPage1)
        Me.MonitoringWindow.Controls.Add(Me.TabPage2)
        Me.MonitoringWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MonitoringWindow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonitoringWindow.Location = New System.Drawing.Point(5, 5)
        Me.MonitoringWindow.Name = "MonitoringWindow"
        Me.MonitoringWindow.SelectedIndex = 0
        Me.MonitoringWindow.Size = New System.Drawing.Size(1184, 653)
        Me.MonitoringWindow.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1176, 617)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Head Count"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Emp_List)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1164, 605)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Attendance"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Brows_BTN)
        Me.GroupBox3.Controls.Add(Me.Update_BTN)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.DateEncoded_DTP)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Save_BTN)
        Me.GroupBox3.Controls.Add(Me.Remarks_TXT)
        Me.GroupBox3.Controls.Add(Me.NoteReason_CHK)
        Me.GroupBox3.Controls.Add(Me.NoteReason_TXT)
        Me.GroupBox3.Controls.Add(Me.Relieve_RBTN)
        Me.GroupBox3.Controls.Add(Me.Leave_RBTN)
        Me.GroupBox3.Controls.Add(Me.RestDay_RBTN)
        Me.GroupBox3.Controls.Add(Me.Absent_RBTN)
        Me.GroupBox3.Controls.Add(Me.Late_RBTN)
        Me.GroupBox3.Controls.Add(Me.Present_RBTN)
        Me.GroupBox3.Controls.Add(Me.EmpPosition_TXT)
        Me.GroupBox3.Controls.Add(Me.EmpName_TXT)
        Me.GroupBox3.Location = New System.Drawing.Point(480, 25)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(678, 400)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Count"
        '
        'Brows_BTN
        '
        Me.Brows_BTN.Location = New System.Drawing.Point(396, 347)
        Me.Brows_BTN.Name = "Brows_BTN"
        Me.Brows_BTN.Size = New System.Drawing.Size(75, 40)
        Me.Brows_BTN.TabIndex = 16
        Me.Brows_BTN.Text = "Browse"
        Me.Brows_BTN.UseVisualStyleBackColor = True
        '
        'Update_BTN
        '
        Me.Update_BTN.Location = New System.Drawing.Point(501, 347)
        Me.Update_BTN.Name = "Update_BTN"
        Me.Update_BTN.Size = New System.Drawing.Size(75, 40)
        Me.Update_BTN.TabIndex = 15
        Me.Update_BTN.Text = "Update"
        Me.Update_BTN.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Date Encoded"
        '
        'DateEncoded_DTP
        '
        Me.DateEncoded_DTP.Enabled = False
        Me.DateEncoded_DTP.Location = New System.Drawing.Point(10, 56)
        Me.DateEncoded_DTP.Name = "DateEncoded_DTP"
        Me.DateEncoded_DTP.Size = New System.Drawing.Size(662, 26)
        Me.DateEncoded_DTP.TabIndex = 13
        Me.DateEncoded_DTP.Value = New Date(2019, 10, 28, 0, 0, 0, 0)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(685, 347)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 40)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Save_BTN
        '
        Me.Save_BTN.Location = New System.Drawing.Point(596, 347)
        Me.Save_BTN.Name = "Save_BTN"
        Me.Save_BTN.Size = New System.Drawing.Size(75, 40)
        Me.Save_BTN.TabIndex = 11
        Me.Save_BTN.Text = "Save"
        Me.Save_BTN.UseVisualStyleBackColor = True
        '
        'Remarks_TXT
        '
        Me.Remarks_TXT.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Remarks_TXT.Location = New System.Drawing.Point(31, 267)
        Me.Remarks_TXT.Multiline = True
        Me.Remarks_TXT.Name = "Remarks_TXT"
        Me.Remarks_TXT.Size = New System.Drawing.Size(641, 74)
        Me.Remarks_TXT.TabIndex = 10
        Me.Remarks_TXT.WaterMarkColor = System.Drawing.Color.Gray
        Me.Remarks_TXT.WaterMarkText = "Remarks"
        '
        'NoteReason_CHK
        '
        Me.NoteReason_CHK.AutoSize = True
        Me.NoteReason_CHK.Enabled = False
        Me.NoteReason_CHK.Location = New System.Drawing.Point(10, 240)
        Me.NoteReason_CHK.Name = "NoteReason_CHK"
        Me.NoteReason_CHK.Size = New System.Drawing.Size(15, 14)
        Me.NoteReason_CHK.TabIndex = 9
        Me.NoteReason_CHK.UseVisualStyleBackColor = True
        '
        'NoteReason_TXT
        '
        Me.NoteReason_TXT.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.NoteReason_TXT.Location = New System.Drawing.Point(31, 232)
        Me.NoteReason_TXT.Name = "NoteReason_TXT"
        Me.NoteReason_TXT.ReadOnly = True
        Me.NoteReason_TXT.Size = New System.Drawing.Size(641, 29)
        Me.NoteReason_TXT.TabIndex = 8
        Me.NoteReason_TXT.WaterMarkColor = System.Drawing.Color.Gray
        Me.NoteReason_TXT.WaterMarkText = "Note/Reason"
        '
        'Relieve_RBTN
        '
        Me.Relieve_RBTN.AutoSize = True
        Me.Relieve_RBTN.Location = New System.Drawing.Point(574, 191)
        Me.Relieve_RBTN.Name = "Relieve_RBTN"
        Me.Relieve_RBTN.Size = New System.Drawing.Size(97, 24)
        Me.Relieve_RBTN.TabIndex = 7
        Me.Relieve_RBTN.Text = "RELIEVE"
        Me.Relieve_RBTN.UseVisualStyleBackColor = True
        '
        'Leave_RBTN
        '
        Me.Leave_RBTN.AutoSize = True
        Me.Leave_RBTN.Location = New System.Drawing.Point(488, 191)
        Me.Leave_RBTN.Name = "Leave_RBTN"
        Me.Leave_RBTN.Size = New System.Drawing.Size(80, 24)
        Me.Leave_RBTN.TabIndex = 6
        Me.Leave_RBTN.Text = "LEAVE"
        Me.Leave_RBTN.UseVisualStyleBackColor = True
        '
        'RestDay_RBTN
        '
        Me.RestDay_RBTN.AutoSize = True
        Me.RestDay_RBTN.Location = New System.Drawing.Point(374, 191)
        Me.RestDay_RBTN.Name = "RestDay_RBTN"
        Me.RestDay_RBTN.Size = New System.Drawing.Size(108, 24)
        Me.RestDay_RBTN.TabIndex = 5
        Me.RestDay_RBTN.Text = "REST DAY"
        Me.RestDay_RBTN.UseVisualStyleBackColor = True
        '
        'Absent_RBTN
        '
        Me.Absent_RBTN.AutoSize = True
        Me.Absent_RBTN.Location = New System.Drawing.Point(277, 191)
        Me.Absent_RBTN.Name = "Absent_RBTN"
        Me.Absent_RBTN.Size = New System.Drawing.Size(91, 24)
        Me.Absent_RBTN.TabIndex = 4
        Me.Absent_RBTN.Text = "ABSENT"
        Me.Absent_RBTN.UseVisualStyleBackColor = True
        '
        'Late_RBTN
        '
        Me.Late_RBTN.AutoSize = True
        Me.Late_RBTN.Location = New System.Drawing.Point(204, 191)
        Me.Late_RBTN.Name = "Late_RBTN"
        Me.Late_RBTN.Size = New System.Drawing.Size(67, 24)
        Me.Late_RBTN.TabIndex = 3
        Me.Late_RBTN.Text = "LATE"
        Me.Late_RBTN.UseVisualStyleBackColor = True
        '
        'Present_RBTN
        '
        Me.Present_RBTN.AutoSize = True
        Me.Present_RBTN.Checked = True
        Me.Present_RBTN.Location = New System.Drawing.Point(96, 191)
        Me.Present_RBTN.Name = "Present_RBTN"
        Me.Present_RBTN.Size = New System.Drawing.Size(102, 24)
        Me.Present_RBTN.TabIndex = 2
        Me.Present_RBTN.TabStop = True
        Me.Present_RBTN.Text = "PRESENT"
        Me.Present_RBTN.UseVisualStyleBackColor = True
        '
        'EmpPosition_TXT
        '
        Me.EmpPosition_TXT.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.EmpPosition_TXT.Location = New System.Drawing.Point(10, 151)
        Me.EmpPosition_TXT.Name = "EmpPosition_TXT"
        Me.EmpPosition_TXT.Size = New System.Drawing.Size(662, 29)
        Me.EmpPosition_TXT.TabIndex = 1
        Me.EmpPosition_TXT.WaterMarkColor = System.Drawing.Color.Gray
        Me.EmpPosition_TXT.WaterMarkText = "Position"
        '
        'EmpName_TXT
        '
        Me.EmpName_TXT.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.EmpName_TXT.Location = New System.Drawing.Point(10, 116)
        Me.EmpName_TXT.Name = "EmpName_TXT"
        Me.EmpName_TXT.Size = New System.Drawing.Size(662, 29)
        Me.EmpName_TXT.TabIndex = 0
        Me.EmpName_TXT.WaterMarkColor = System.Drawing.Color.Gray
        Me.EmpName_TXT.WaterMarkText = "Name"
        '
        'Emp_List
        '
        Me.Emp_List.CheckBoxes = True
        Me.Emp_List.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.Emp_List.FullRowSelect = True
        Me.Emp_List.HideSelection = False
        Me.Emp_List.Location = New System.Drawing.Point(6, 166)
        Me.Emp_List.Name = "Emp_List"
        Me.Emp_List.Size = New System.Drawing.Size(468, 433)
        Me.Emp_List.TabIndex = 2
        Me.Emp_List.UseCompatibleStateImageBehavior = False
        Me.Emp_List.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ID"
        Me.ColumnHeader3.Width = 80
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 230
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Position"
        Me.ColumnHeader2.Width = 174
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CompanyName_TXT)
        Me.GroupBox1.Controls.Add(Me.BranchArea_TXT)
        Me.GroupBox1.Controls.Add(Me.BranchName_TXT)
        Me.GroupBox1.Controls.Add(Me.SelectBranch_BTN)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(468, 135)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Branch"
        '
        'CompanyName_TXT
        '
        Me.CompanyName_TXT.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CompanyName_TXT.Location = New System.Drawing.Point(6, 95)
        Me.CompanyName_TXT.Name = "CompanyName_TXT"
        Me.CompanyName_TXT.ReadOnly = True
        Me.CompanyName_TXT.Size = New System.Drawing.Size(456, 29)
        Me.CompanyName_TXT.TabIndex = 4
        Me.CompanyName_TXT.WaterMarkColor = System.Drawing.Color.Gray
        Me.CompanyName_TXT.WaterMarkText = "Company"
        '
        'BranchArea_TXT
        '
        Me.BranchArea_TXT.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BranchArea_TXT.Location = New System.Drawing.Point(6, 60)
        Me.BranchArea_TXT.Name = "BranchArea_TXT"
        Me.BranchArea_TXT.ReadOnly = True
        Me.BranchArea_TXT.Size = New System.Drawing.Size(456, 29)
        Me.BranchArea_TXT.TabIndex = 3
        Me.BranchArea_TXT.WaterMarkColor = System.Drawing.Color.Gray
        Me.BranchArea_TXT.WaterMarkText = "Branch Area"
        '
        'BranchName_TXT
        '
        Me.BranchName_TXT.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BranchName_TXT.Location = New System.Drawing.Point(44, 25)
        Me.BranchName_TXT.Name = "BranchName_TXT"
        Me.BranchName_TXT.ReadOnly = True
        Me.BranchName_TXT.Size = New System.Drawing.Size(418, 29)
        Me.BranchName_TXT.TabIndex = 2
        Me.BranchName_TXT.WaterMarkColor = System.Drawing.Color.Gray
        Me.BranchName_TXT.WaterMarkText = "Branch Name"
        '
        'SelectBranch_BTN
        '
        Me.SelectBranch_BTN.Location = New System.Drawing.Point(6, 25)
        Me.SelectBranch_BTN.Name = "SelectBranch_BTN"
        Me.SelectBranch_BTN.Size = New System.Drawing.Size(32, 29)
        Me.SelectBranch_BTN.TabIndex = 1
        Me.SelectBranch_BTN.Text = "..."
        Me.SelectBranch_BTN.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.L_Search_BTN)
        Me.TabPage2.Controls.Add(Me.L_Search_TXT)
        Me.TabPage2.Controls.Add(Me.Emp_Leave_LV)
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1176, 617)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Leave"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.L_DateEnded_DTP)
        Me.GroupBox5.Controls.Add(Me.L_Update_BTN)
        Me.GroupBox5.Controls.Add(Me.L_Save_BTN)
        Me.GroupBox5.Controls.Add(Me.L_Cancel_BTN)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.L_Type_CB)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.L_DateStarted_DTP)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.L_Information_TXT)
        Me.GroupBox5.Location = New System.Drawing.Point(593, 274)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(577, 337)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Leave Details"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(292, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "To"
        '
        'L_DateEnded_DTP
        '
        Me.L_DateEnded_DTP.Location = New System.Drawing.Point(296, 61)
        Me.L_DateEnded_DTP.Name = "L_DateEnded_DTP"
        Me.L_DateEnded_DTP.Size = New System.Drawing.Size(275, 26)
        Me.L_DateEnded_DTP.TabIndex = 15
        Me.L_DateEnded_DTP.Value = New Date(2019, 10, 31, 0, 0, 0, 0)
        '
        'L_Update_BTN
        '
        Me.L_Update_BTN.Location = New System.Drawing.Point(313, 283)
        Me.L_Update_BTN.Name = "L_Update_BTN"
        Me.L_Update_BTN.Size = New System.Drawing.Size(82, 37)
        Me.L_Update_BTN.TabIndex = 14
        Me.L_Update_BTN.Text = "Update"
        Me.L_Update_BTN.UseVisualStyleBackColor = True
        '
        'L_Save_BTN
        '
        Me.L_Save_BTN.Enabled = False
        Me.L_Save_BTN.Location = New System.Drawing.Point(401, 283)
        Me.L_Save_BTN.Name = "L_Save_BTN"
        Me.L_Save_BTN.Size = New System.Drawing.Size(82, 37)
        Me.L_Save_BTN.TabIndex = 13
        Me.L_Save_BTN.Text = "Save"
        Me.L_Save_BTN.UseVisualStyleBackColor = True
        '
        'L_Cancel_BTN
        '
        Me.L_Cancel_BTN.Location = New System.Drawing.Point(489, 283)
        Me.L_Cancel_BTN.Name = "L_Cancel_BTN"
        Me.L_Cancel_BTN.Size = New System.Drawing.Size(82, 37)
        Me.L_Cancel_BTN.TabIndex = 12
        Me.L_Cancel_BTN.Text = "Cancel"
        Me.L_Cancel_BTN.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Leave Type"
        '
        'L_Type_CB
        '
        Me.L_Type_CB.FormattingEnabled = True
        Me.L_Type_CB.Location = New System.Drawing.Point(6, 237)
        Me.L_Type_CB.Name = "L_Type_CB"
        Me.L_Type_CB.Size = New System.Drawing.Size(565, 28)
        Me.L_Type_CB.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(2, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "From"
        '
        'L_DateStarted_DTP
        '
        Me.L_DateStarted_DTP.Location = New System.Drawing.Point(6, 61)
        Me.L_DateStarted_DTP.Name = "L_DateStarted_DTP"
        Me.L_DateStarted_DTP.Size = New System.Drawing.Size(284, 26)
        Me.L_DateStarted_DTP.TabIndex = 8
        Me.L_DateStarted_DTP.Value = New Date(2019, 10, 31, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Leave Infromation"
        '
        'L_Information_TXT
        '
        Me.L_Information_TXT.Location = New System.Drawing.Point(6, 117)
        Me.L_Information_TXT.Name = "L_Information_TXT"
        Me.L_Information_TXT.Size = New System.Drawing.Size(565, 94)
        Me.L_Information_TXT.TabIndex = 0
        Me.L_Information_TXT.Text = ""
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Branch_List)
        Me.GroupBox4.Controls.Add(Me.L_SearchEmp_BTN)
        Me.GroupBox4.Controls.Add(Me.L_EmpName_TXT)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 274)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(581, 337)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Employee Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Branches Assigned"
        '
        'Branch_List
        '
        Me.Branch_List.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader16, Me.ColumnHeader7, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.Branch_List.FullRowSelect = True
        Me.Branch_List.HideSelection = False
        Me.Branch_List.Location = New System.Drawing.Point(9, 112)
        Me.Branch_List.Name = "Branch_List"
        Me.Branch_List.ShowItemToolTips = True
        Me.Branch_List.Size = New System.Drawing.Size(562, 208)
        Me.Branch_List.TabIndex = 2
        Me.Branch_List.UseCompatibleStateImageBehavior = False
        Me.Branch_List.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "ID"
        Me.ColumnHeader16.Width = 35
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Company"
        Me.ColumnHeader7.Width = 162
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Branch"
        Me.ColumnHeader4.Width = 162
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Area"
        Me.ColumnHeader5.Width = 130
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Code"
        Me.ColumnHeader6.Width = 70
        '
        'L_SearchEmp_BTN
        '
        Me.L_SearchEmp_BTN.Location = New System.Drawing.Point(538, 47)
        Me.L_SearchEmp_BTN.Name = "L_SearchEmp_BTN"
        Me.L_SearchEmp_BTN.Size = New System.Drawing.Size(33, 31)
        Me.L_SearchEmp_BTN.TabIndex = 1
        Me.L_SearchEmp_BTN.Text = "..."
        Me.L_SearchEmp_BTN.UseVisualStyleBackColor = True
        '
        'L_EmpName_TXT
        '
        Me.L_EmpName_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.L_EmpName_TXT.Location = New System.Drawing.Point(9, 49)
        Me.L_EmpName_TXT.Name = "L_EmpName_TXT"
        Me.L_EmpName_TXT.Size = New System.Drawing.Size(523, 26)
        Me.L_EmpName_TXT.TabIndex = 0
        Me.L_EmpName_TXT.WaterMarkColor = System.Drawing.Color.Gray
        Me.L_EmpName_TXT.WaterMarkText = "Name"
        '
        'L_Search_BTN
        '
        Me.L_Search_BTN.Location = New System.Drawing.Point(1095, 15)
        Me.L_Search_BTN.Name = "L_Search_BTN"
        Me.L_Search_BTN.Size = New System.Drawing.Size(75, 28)
        Me.L_Search_BTN.TabIndex = 2
        Me.L_Search_BTN.Text = "Seacrh"
        Me.L_Search_BTN.UseVisualStyleBackColor = True
        '
        'L_Search_TXT
        '
        Me.L_Search_TXT.Location = New System.Drawing.Point(6, 16)
        Me.L_Search_TXT.Name = "L_Search_TXT"
        Me.L_Search_TXT.Size = New System.Drawing.Size(1083, 26)
        Me.L_Search_TXT.TabIndex = 1
        '
        'Emp_Leave_LV
        '
        Me.Emp_Leave_LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15})
        Me.Emp_Leave_LV.FullRowSelect = True
        Me.Emp_Leave_LV.HideSelection = False
        Me.Emp_Leave_LV.Location = New System.Drawing.Point(6, 48)
        Me.Emp_Leave_LV.Name = "Emp_Leave_LV"
        Me.Emp_Leave_LV.ShowItemToolTips = True
        Me.Emp_Leave_LV.Size = New System.Drawing.Size(1164, 220)
        Me.Emp_Leave_LV.TabIndex = 0
        Me.Emp_Leave_LV.UseCompatibleStateImageBehavior = False
        Me.Emp_Leave_LV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ID"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Branch"
        Me.ColumnHeader9.Width = 181
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Name"
        Me.ColumnHeader10.Width = 248
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Leave Type"
        Me.ColumnHeader11.Width = 167
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Date Started"
        Me.ColumnHeader12.Width = 275
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Date Ended"
        Me.ColumnHeader13.Width = 211
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Date Encoded"
        Me.ColumnHeader14.Width = 217
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Leave Details"
        Me.ColumnHeader15.Width = 367
        '
        'FrmMonitoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1194, 703)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMonitoring"
        Me.Text = "FrmMonitoring"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.MonitoringWindow.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents CloseWindow_BTN As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MonitoringWindow As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CompanyName_TXT As WaterMarkTextBox
    Friend WithEvents BranchArea_TXT As WaterMarkTextBox
    Friend WithEvents BranchName_TXT As WaterMarkTextBox
    Friend WithEvents SelectBranch_BTN As Button
    Friend WithEvents Emp_List As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Remarks_TXT As WaterMarkTextBox
    Friend WithEvents NoteReason_CHK As CheckBox
    Friend WithEvents NoteReason_TXT As WaterMarkTextBox
    Friend WithEvents Relieve_RBTN As RadioButton
    Friend WithEvents Leave_RBTN As RadioButton
    Friend WithEvents RestDay_RBTN As RadioButton
    Friend WithEvents Absent_RBTN As RadioButton
    Friend WithEvents Late_RBTN As RadioButton
    Friend WithEvents Present_RBTN As RadioButton
    Friend WithEvents EmpPosition_TXT As WaterMarkTextBox
    Friend WithEvents EmpName_TXT As WaterMarkTextBox
    Friend WithEvents Save_BTN As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents DateEncoded_DTP As DateTimePicker
    Friend WithEvents Brows_BTN As Button
    Friend WithEvents Update_BTN As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents L_Search_BTN As Button
    Friend WithEvents L_Search_TXT As TextBox
    Friend WithEvents Emp_Leave_LV As ListView
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents L_Information_TXT As RichTextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents L_SearchEmp_BTN As Button
    Friend WithEvents L_EmpName_TXT As WaterMarkTextBox
    Friend WithEvents L_Update_BTN As Button
    Friend WithEvents L_Save_BTN As Button
    Friend WithEvents L_Cancel_BTN As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents L_Type_CB As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents L_DateStarted_DTP As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents L_DateEnded_DTP As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents Branch_List As ListView
    Friend WithEvents ColumnHeader16 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
End Class
