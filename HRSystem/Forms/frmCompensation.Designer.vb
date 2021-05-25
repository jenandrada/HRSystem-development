<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompensation
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SaveSalary_BTN = New System.Windows.Forms.Button()
        Me.Monthly_TXT = New HRSystem.WaterMarkTextBox()
        Me.Fix_RB = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OtherDeduction_TXT = New HRSystem.WaterMarkTextBox()
        Me.MealDeduction_TXT = New HRSystem.WaterMarkTextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Charges_TXT = New HRSystem.WaterMarkTextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Loans_TXT = New HRSystem.WaterMarkTextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Savings_TXT = New HRSystem.WaterMarkTextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.CashAdvance_TXT = New HRSystem.WaterMarkTextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateHired_DTP = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Branch_S_TXT = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Company_S_TXT = New System.Windows.Forms.TextBox()
        Me.Position_S_TXT = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SelectSalary_BTN = New System.Windows.Forms.Button()
        Me.Name_S_TXT = New System.Windows.Forms.TextBox()
        Me.Daily_TXT = New HRSystem.WaterMarkTextBox()
        Me.NotFix_RB = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Positional_TXT = New HRSystem.WaterMarkTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OtherAllowance_TXT = New HRSystem.WaterMarkTextBox()
        Me.Medical_TXT = New HRSystem.WaterMarkTextBox()
        Me.Transportation_TXT = New HRSystem.WaterMarkTextBox()
        Me.CareKit_TXT = New HRSystem.WaterMarkTextBox()
        Me.Boarding_TXT = New HRSystem.WaterMarkTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.SaveSalary_BTN)
        Me.Panel2.Controls.Add(Me.Monthly_TXT)
        Me.Panel2.Controls.Add(Me.Fix_RB)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.Daily_TXT)
        Me.Panel2.Controls.Add(Me.NotFix_RB)
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(20)
        Me.Panel2.Size = New System.Drawing.Size(1146, 733)
        Me.Panel2.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Compensation"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Image = Global.HRSystem.My.Resources.Resources.close_window_50px
        Me.Button2.Location = New System.Drawing.Point(1116, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(30, 30)
        Me.Button2.TabIndex = 6
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SaveSalary_BTN
        '
        Me.SaveSalary_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveSalary_BTN.Location = New System.Drawing.Point(793, 669)
        Me.SaveSalary_BTN.Name = "SaveSalary_BTN"
        Me.SaveSalary_BTN.Size = New System.Drawing.Size(116, 44)
        Me.SaveSalary_BTN.TabIndex = 39
        Me.SaveSalary_BTN.Text = "Save"
        Me.SaveSalary_BTN.UseVisualStyleBackColor = True
        '
        'Monthly_TXT
        '
        Me.Monthly_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Monthly_TXT.Location = New System.Drawing.Point(229, 387)
        Me.Monthly_TXT.Name = "Monthly_TXT"
        Me.Monthly_TXT.Size = New System.Drawing.Size(208, 26)
        Me.Monthly_TXT.TabIndex = 50
        Me.Monthly_TXT.Visible = False
        Me.Monthly_TXT.WaterMarkColor = System.Drawing.Color.Gray
        Me.Monthly_TXT.WaterMarkText = "Monthly Amount"
        '
        'Fix_RB
        '
        Me.Fix_RB.AutoSize = True
        Me.Fix_RB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fix_RB.Location = New System.Drawing.Point(110, 389)
        Me.Fix_RB.Name = "Fix_RB"
        Me.Fix_RB.Size = New System.Drawing.Size(45, 22)
        Me.Fix_RB.TabIndex = 42
        Me.Fix_RB.Text = "Fix"
        Me.Fix_RB.UseVisualStyleBackColor = True
        Me.Fix_RB.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OtherDeduction_TXT)
        Me.GroupBox1.Controls.Add(Me.MealDeduction_TXT)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.Charges_TXT)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Loans_TXT)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.Savings_TXT)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.CashAdvance_TXT)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(619, 353)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 299)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Deduction"
        '
        'OtherDeduction_TXT
        '
        Me.OtherDeduction_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OtherDeduction_TXT.Location = New System.Drawing.Point(161, 259)
        Me.OtherDeduction_TXT.Name = "OtherDeduction_TXT"
        Me.OtherDeduction_TXT.Size = New System.Drawing.Size(245, 26)
        Me.OtherDeduction_TXT.TabIndex = 62
        Me.OtherDeduction_TXT.WaterMarkColor = System.Drawing.Color.Gray
        Me.OtherDeduction_TXT.WaterMarkText = "Amount"
        '
        'MealDeduction_TXT
        '
        Me.MealDeduction_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MealDeduction_TXT.Location = New System.Drawing.Point(161, 217)
        Me.MealDeduction_TXT.Name = "MealDeduction_TXT"
        Me.MealDeduction_TXT.Size = New System.Drawing.Size(245, 26)
        Me.MealDeduction_TXT.TabIndex = 61
        Me.MealDeduction_TXT.WaterMarkColor = System.Drawing.Color.Gray
        Me.MealDeduction_TXT.WaterMarkText = "Amount"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(38, 217)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(44, 21)
        Me.Label29.TabIndex = 3
        Me.Label29.Text = "Meal"
        '
        'Charges_TXT
        '
        Me.Charges_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Charges_TXT.Location = New System.Drawing.Point(161, 166)
        Me.Charges_TXT.Name = "Charges_TXT"
        Me.Charges_TXT.Size = New System.Drawing.Size(245, 26)
        Me.Charges_TXT.TabIndex = 60
        Me.Charges_TXT.WaterMarkColor = System.Drawing.Color.Gray
        Me.Charges_TXT.WaterMarkText = "Amount"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(38, 264)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(50, 21)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "Other"
        '
        'Loans_TXT
        '
        Me.Loans_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loans_TXT.Location = New System.Drawing.Point(161, 121)
        Me.Loans_TXT.Name = "Loans_TXT"
        Me.Loans_TXT.Size = New System.Drawing.Size(245, 26)
        Me.Loans_TXT.TabIndex = 59
        Me.Loans_TXT.WaterMarkColor = System.Drawing.Color.Gray
        Me.Loans_TXT.WaterMarkText = "Amount"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(38, 170)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(67, 21)
        Me.Label30.TabIndex = 2
        Me.Label30.Text = "Charges"
        '
        'Savings_TXT
        '
        Me.Savings_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Savings_TXT.Location = New System.Drawing.Point(161, 77)
        Me.Savings_TXT.Name = "Savings_TXT"
        Me.Savings_TXT.Size = New System.Drawing.Size(245, 26)
        Me.Savings_TXT.TabIndex = 58
        Me.Savings_TXT.Text = "250"
        Me.Savings_TXT.WaterMarkColor = System.Drawing.Color.Gray
        Me.Savings_TXT.WaterMarkText = "Amount"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(38, 82)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(64, 21)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "Savings"
        '
        'CashAdvance_TXT
        '
        Me.CashAdvance_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CashAdvance_TXT.Location = New System.Drawing.Point(161, 34)
        Me.CashAdvance_TXT.Name = "CashAdvance_TXT"
        Me.CashAdvance_TXT.Size = New System.Drawing.Size(245, 26)
        Me.CashAdvance_TXT.TabIndex = 57
        Me.CashAdvance_TXT.WaterMarkColor = System.Drawing.Color.Gray
        Me.CashAdvance_TXT.WaterMarkText = "Amount"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(38, 38)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(107, 21)
        Me.Label33.TabIndex = 7
        Me.Label33.Text = "Cash Advance"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(38, 125)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(51, 21)
        Me.Label31.TabIndex = 1
        Me.Label31.Text = "Loans"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateHired_DTP)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Branch_S_TXT)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Company_S_TXT)
        Me.GroupBox2.Controls.Add(Me.Position_S_TXT)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.SelectSalary_BTN)
        Me.GroupBox2.Controls.Add(Me.Name_S_TXT)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft New Tai Lue", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(23, 102)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(487, 264)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Employee"
        '
        'DateHired_DTP
        '
        Me.DateHired_DTP.Enabled = False
        Me.DateHired_DTP.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateHired_DTP.Location = New System.Drawing.Point(112, 79)
        Me.DateHired_DTP.Name = "DateHired_DTP"
        Me.DateHired_DTP.Size = New System.Drawing.Size(302, 28)
        Me.DateHired_DTP.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Branch"
        '
        'Branch_S_TXT
        '
        Me.Branch_S_TXT.Location = New System.Drawing.Point(112, 207)
        Me.Branch_S_TXT.Name = "Branch_S_TXT"
        Me.Branch_S_TXT.Size = New System.Drawing.Size(302, 27)
        Me.Branch_S_TXT.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Company"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 20)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Position"
        '
        'Company_S_TXT
        '
        Me.Company_S_TXT.Location = New System.Drawing.Point(112, 161)
        Me.Company_S_TXT.Name = "Company_S_TXT"
        Me.Company_S_TXT.Size = New System.Drawing.Size(302, 27)
        Me.Company_S_TXT.TabIndex = 36
        '
        'Position_S_TXT
        '
        Me.Position_S_TXT.Location = New System.Drawing.Point(112, 124)
        Me.Position_S_TXT.Name = "Position_S_TXT"
        Me.Position_S_TXT.Size = New System.Drawing.Size(302, 27)
        Me.Position_S_TXT.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 20)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Date Hired"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(27, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 20)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Name"
        '
        'SelectSalary_BTN
        '
        Me.SelectSalary_BTN.AutoSize = True
        Me.SelectSalary_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectSalary_BTN.Location = New System.Drawing.Point(431, 36)
        Me.SelectSalary_BTN.Name = "SelectSalary_BTN"
        Me.SelectSalary_BTN.Size = New System.Drawing.Size(41, 30)
        Me.SelectSalary_BTN.TabIndex = 2
        Me.SelectSalary_BTN.Text = "..."
        Me.SelectSalary_BTN.UseVisualStyleBackColor = True
        '
        'Name_S_TXT
        '
        Me.Name_S_TXT.Location = New System.Drawing.Point(112, 39)
        Me.Name_S_TXT.Name = "Name_S_TXT"
        Me.Name_S_TXT.Size = New System.Drawing.Size(302, 27)
        Me.Name_S_TXT.TabIndex = 0
        Me.Name_S_TXT.Tag = "7"
        '
        'Daily_TXT
        '
        Me.Daily_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Daily_TXT.Location = New System.Drawing.Point(229, 435)
        Me.Daily_TXT.Name = "Daily_TXT"
        Me.Daily_TXT.Size = New System.Drawing.Size(208, 26)
        Me.Daily_TXT.TabIndex = 51
        Me.Daily_TXT.Visible = False
        Me.Daily_TXT.WaterMarkColor = System.Drawing.Color.Gray
        Me.Daily_TXT.WaterMarkText = "Daily Amount"
        '
        'NotFix_RB
        '
        Me.NotFix_RB.AutoSize = True
        Me.NotFix_RB.Checked = True
        Me.NotFix_RB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotFix_RB.Location = New System.Drawing.Point(110, 435)
        Me.NotFix_RB.Name = "NotFix_RB"
        Me.NotFix_RB.Size = New System.Drawing.Size(73, 22)
        Me.NotFix_RB.TabIndex = 43
        Me.NotFix_RB.TabStop = True
        Me.NotFix_RB.Text = "Not Fix"
        Me.NotFix_RB.UseVisualStyleBackColor = True
        Me.NotFix_RB.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Positional_TXT)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.OtherAllowance_TXT)
        Me.GroupBox3.Controls.Add(Me.Medical_TXT)
        Me.GroupBox3.Controls.Add(Me.Transportation_TXT)
        Me.GroupBox3.Controls.Add(Me.CareKit_TXT)
        Me.GroupBox3.Controls.Add(Me.Boarding_TXT)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft New Tai Lue", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(619, 32)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(442, 303)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Allowances"
        '
        'Positional_TXT
        '
        Me.Positional_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Positional_TXT.Location = New System.Drawing.Point(161, 120)
        Me.Positional_TXT.Name = "Positional_TXT"
        Me.Positional_TXT.Size = New System.Drawing.Size(245, 26)
        Me.Positional_TXT.TabIndex = 58
        Me.Positional_TXT.WaterMarkColor = System.Drawing.Color.Gray
        Me.Positional_TXT.WaterMarkText = "Amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 18)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Positional"
        '
        'OtherAllowance_TXT
        '
        Me.OtherAllowance_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OtherAllowance_TXT.Location = New System.Drawing.Point(161, 269)
        Me.OtherAllowance_TXT.Name = "OtherAllowance_TXT"
        Me.OtherAllowance_TXT.Size = New System.Drawing.Size(245, 26)
        Me.OtherAllowance_TXT.TabIndex = 56
        Me.OtherAllowance_TXT.WaterMarkColor = System.Drawing.Color.Gray
        Me.OtherAllowance_TXT.WaterMarkText = "Amount"
        '
        'Medical_TXT
        '
        Me.Medical_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Medical_TXT.Location = New System.Drawing.Point(161, 216)
        Me.Medical_TXT.Name = "Medical_TXT"
        Me.Medical_TXT.Size = New System.Drawing.Size(245, 26)
        Me.Medical_TXT.TabIndex = 55
        Me.Medical_TXT.WaterMarkColor = System.Drawing.Color.Gray
        Me.Medical_TXT.WaterMarkText = "Amount"
        '
        'Transportation_TXT
        '
        Me.Transportation_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Transportation_TXT.Location = New System.Drawing.Point(161, 166)
        Me.Transportation_TXT.Name = "Transportation_TXT"
        Me.Transportation_TXT.Size = New System.Drawing.Size(245, 26)
        Me.Transportation_TXT.TabIndex = 54
        Me.Transportation_TXT.WaterMarkColor = System.Drawing.Color.Gray
        Me.Transportation_TXT.WaterMarkText = "Amount"
        '
        'CareKit_TXT
        '
        Me.CareKit_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CareKit_TXT.Location = New System.Drawing.Point(161, 76)
        Me.CareKit_TXT.Name = "CareKit_TXT"
        Me.CareKit_TXT.Size = New System.Drawing.Size(245, 26)
        Me.CareKit_TXT.TabIndex = 53
        Me.CareKit_TXT.WaterMarkColor = System.Drawing.Color.Gray
        Me.CareKit_TXT.WaterMarkText = "Amount"
        '
        'Boarding_TXT
        '
        Me.Boarding_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boarding_TXT.Location = New System.Drawing.Point(161, 28)
        Me.Boarding_TXT.Name = "Boarding_TXT"
        Me.Boarding_TXT.Size = New System.Drawing.Size(245, 26)
        Me.Boarding_TXT.TabIndex = 52
        Me.Boarding_TXT.WaterMarkColor = System.Drawing.Color.Gray
        Me.Boarding_TXT.WaterMarkText = "Amount"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(39, 269)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 18)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Other Allowance"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(39, 219)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(59, 18)
        Me.Label25.TabIndex = 41
        Me.Label25.Text = "Medical"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(39, 169)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(104, 18)
        Me.Label26.TabIndex = 40
        Me.Label26.Text = "Transportation"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(39, 76)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(62, 18)
        Me.Label27.TabIndex = 39
        Me.Label27.Text = "Care-Kit"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(39, 34)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(67, 18)
        Me.Label28.TabIndex = 38
        Me.Label28.Text = "Boarding"
        '
        'frmCompensation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1146, 733)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCompensation"
        Me.Text = "frmCompensation"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents SaveSalary_BTN As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DateHired_DTP As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Branch_S_TXT As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Company_S_TXT As TextBox
    Friend WithEvents Position_S_TXT As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents SelectSalary_BTN As Button
    Friend WithEvents Name_S_TXT As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents OtherAllowance_TXT As WaterMarkTextBox
    Friend WithEvents Medical_TXT As WaterMarkTextBox
    Friend WithEvents Transportation_TXT As WaterMarkTextBox
    Friend WithEvents CareKit_TXT As WaterMarkTextBox
    Friend WithEvents Boarding_TXT As WaterMarkTextBox
    Friend WithEvents Daily_TXT As WaterMarkTextBox
    Friend WithEvents Monthly_TXT As WaterMarkTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents NotFix_RB As RadioButton
    Friend WithEvents Fix_RB As RadioButton
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents OtherDeduction_TXT As WaterMarkTextBox
    Friend WithEvents MealDeduction_TXT As WaterMarkTextBox
    Friend WithEvents Charges_TXT As WaterMarkTextBox
    Friend WithEvents Loans_TXT As WaterMarkTextBox
    Friend WithEvents Savings_TXT As WaterMarkTextBox
    Friend WithEvents CashAdvance_TXT As WaterMarkTextBox
    Friend WithEvents Positional_TXT As WaterMarkTextBox
    Friend WithEvents Label2 As Label
End Class
