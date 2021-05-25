<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRateEmp
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
        Me.RatingListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Name_TXT = New System.Windows.Forms.TextBox()
        Me.Position_TXT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateHired_TXT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Comment_TXT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Failed_RadioBTN = New System.Windows.Forms.RadioButton()
        Me.Passed_RadioBTN = New System.Windows.Forms.RadioButton()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.UpdateRating_Btn = New System.Windows.Forms.Button()
        Me.SaveRating_BTN = New System.Windows.Forms.Button()
        Me.Clear_BTN = New System.Windows.Forms.Button()
        Me.Search_TXT = New System.Windows.Forms.TextBox()
        Me.Search_BTN = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Branch_TXT = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Assigned_RBTN = New System.Windows.Forms.RadioButton()
        Me.Appointed_RBTN = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateAppointed_TXT = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RatingListView
        '
        Me.RatingListView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RatingListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader8, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.RatingListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RatingListView.FullRowSelect = True
        Me.RatingListView.HideSelection = False
        Me.RatingListView.Location = New System.Drawing.Point(21, 102)
        Me.RatingListView.Name = "RatingListView"
        Me.RatingListView.Size = New System.Drawing.Size(1212, 265)
        Me.RatingListView.TabIndex = 0
        Me.RatingListView.UseCompatibleStateImageBehavior = False
        Me.RatingListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 67
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "MANNING_ID"
        Me.ColumnHeader8.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 375
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Date Hired"
        Me.ColumnHeader3.Width = 196
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Position"
        Me.ColumnHeader4.Width = 182
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Branch"
        Me.ColumnHeader5.Width = 222
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Rating"
        Me.ColumnHeader6.Width = 113
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Comment"
        Me.ColumnHeader7.Width = 348
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 394)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name: "
        '
        'Name_TXT
        '
        Me.Name_TXT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Name_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_TXT.Location = New System.Drawing.Point(143, 391)
        Me.Name_TXT.Name = "Name_TXT"
        Me.Name_TXT.ReadOnly = True
        Me.Name_TXT.Size = New System.Drawing.Size(611, 26)
        Me.Name_TXT.TabIndex = 0
        '
        'Position_TXT
        '
        Me.Position_TXT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Position_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Position_TXT.Location = New System.Drawing.Point(143, 446)
        Me.Position_TXT.Name = "Position_TXT"
        Me.Position_TXT.ReadOnly = True
        Me.Position_TXT.Size = New System.Drawing.Size(611, 26)
        Me.Position_TXT.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 449)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Position:"
        '
        'DateHired_TXT
        '
        Me.DateHired_TXT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateHired_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateHired_TXT.Location = New System.Drawing.Point(143, 504)
        Me.DateHired_TXT.Name = "DateHired_TXT"
        Me.DateHired_TXT.ReadOnly = True
        Me.DateHired_TXT.Size = New System.Drawing.Size(235, 26)
        Me.DateHired_TXT.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 507)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Date Hired: "
        '
        'Comment_TXT
        '
        Me.Comment_TXT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Comment_TXT.Location = New System.Drawing.Point(876, 451)
        Me.Comment_TXT.Multiline = True
        Me.Comment_TXT.Name = "Comment_TXT"
        Me.Comment_TXT.Size = New System.Drawing.Size(357, 79)
        Me.Comment_TXT.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(784, 449)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Comment: "
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Failed_RadioBTN)
        Me.GroupBox1.Controls.Add(Me.Passed_RadioBTN)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(876, 391)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 54)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rating"
        '
        'Failed_RadioBTN
        '
        Me.Failed_RadioBTN.AutoSize = True
        Me.Failed_RadioBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Failed_RadioBTN.Location = New System.Drawing.Point(186, 27)
        Me.Failed_RadioBTN.Name = "Failed_RadioBTN"
        Me.Failed_RadioBTN.Size = New System.Drawing.Size(76, 24)
        Me.Failed_RadioBTN.TabIndex = 4
        Me.Failed_RadioBTN.Text = "Failed"
        Me.Failed_RadioBTN.UseVisualStyleBackColor = True
        '
        'Passed_RadioBTN
        '
        Me.Passed_RadioBTN.AutoSize = True
        Me.Passed_RadioBTN.Checked = True
        Me.Passed_RadioBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passed_RadioBTN.Location = New System.Drawing.Point(94, 27)
        Me.Passed_RadioBTN.Name = "Passed_RadioBTN"
        Me.Passed_RadioBTN.Size = New System.Drawing.Size(86, 24)
        Me.Passed_RadioBTN.TabIndex = 3
        Me.Passed_RadioBTN.TabStop = True
        Me.Passed_RadioBTN.Text = "Passed"
        Me.Passed_RadioBTN.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.Controls.Add(Me.UpdateRating_Btn)
        Me.FlowLayoutPanel1.Controls.Add(Me.SaveRating_BTN)
        Me.FlowLayoutPanel1.Controls.Add(Me.Clear_BTN)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(876, 536)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(357, 35)
        Me.FlowLayoutPanel1.TabIndex = 10
        '
        'UpdateRating_Btn
        '
        Me.UpdateRating_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateRating_Btn.Location = New System.Drawing.Point(3, 3)
        Me.UpdateRating_Btn.Name = "UpdateRating_Btn"
        Me.UpdateRating_Btn.Size = New System.Drawing.Size(91, 30)
        Me.UpdateRating_Btn.TabIndex = 6
        Me.UpdateRating_Btn.Text = "&Update"
        Me.UpdateRating_Btn.UseVisualStyleBackColor = True
        Me.UpdateRating_Btn.Visible = False
        '
        'SaveRating_BTN
        '
        Me.SaveRating_BTN.Enabled = False
        Me.SaveRating_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveRating_BTN.Location = New System.Drawing.Point(100, 3)
        Me.SaveRating_BTN.Name = "SaveRating_BTN"
        Me.SaveRating_BTN.Size = New System.Drawing.Size(91, 30)
        Me.SaveRating_BTN.TabIndex = 7
        Me.SaveRating_BTN.Text = "&Save"
        Me.SaveRating_BTN.UseVisualStyleBackColor = True
        '
        'Clear_BTN
        '
        Me.Clear_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear_BTN.Location = New System.Drawing.Point(197, 3)
        Me.Clear_BTN.Name = "Clear_BTN"
        Me.Clear_BTN.Size = New System.Drawing.Size(91, 30)
        Me.Clear_BTN.TabIndex = 8
        Me.Clear_BTN.Text = "&Clear"
        Me.Clear_BTN.UseVisualStyleBackColor = True
        '
        'Search_TXT
        '
        Me.Search_TXT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Search_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search_TXT.Location = New System.Drawing.Point(21, 68)
        Me.Search_TXT.Name = "Search_TXT"
        Me.Search_TXT.Size = New System.Drawing.Size(1107, 26)
        Me.Search_TXT.TabIndex = 11
        '
        'Search_BTN
        '
        Me.Search_BTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Search_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search_BTN.Location = New System.Drawing.Point(1134, 66)
        Me.Search_BTN.Name = "Search_BTN"
        Me.Search_BTN.Size = New System.Drawing.Size(99, 30)
        Me.Search_BTN.TabIndex = 12
        Me.Search_BTN.Text = "S&earch"
        Me.Search_BTN.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Image = Global.HRSystem.My.Resources.Resources.close_window_50px
        Me.Button4.Location = New System.Drawing.Point(1223, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(30, 30)
        Me.Button4.TabIndex = 13
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(256, 36)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Employee Ratings"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(760, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 30)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Branch_TXT
        '
        Me.Branch_TXT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Branch_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Branch_TXT.Location = New System.Drawing.Point(143, 556)
        Me.Branch_TXT.Name = "Branch_TXT"
        Me.Branch_TXT.ReadOnly = True
        Me.Branch_TXT.Size = New System.Drawing.Size(611, 26)
        Me.Branch_TXT.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 559)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Current Branch: "
        '
        'Assigned_RBTN
        '
        Me.Assigned_RBTN.AutoSize = True
        Me.Assigned_RBTN.Checked = True
        Me.Assigned_RBTN.Location = New System.Drawing.Point(18, 23)
        Me.Assigned_RBTN.Name = "Assigned_RBTN"
        Me.Assigned_RBTN.Size = New System.Drawing.Size(76, 17)
        Me.Assigned_RBTN.TabIndex = 17
        Me.Assigned_RBTN.TabStop = True
        Me.Assigned_RBTN.Text = "Assigned"
        Me.Assigned_RBTN.UseVisualStyleBackColor = True
        '
        'Appointed_RBTN
        '
        Me.Appointed_RBTN.AutoSize = True
        Me.Appointed_RBTN.Location = New System.Drawing.Point(100, 23)
        Me.Appointed_RBTN.Name = "Appointed_RBTN"
        Me.Appointed_RBTN.Size = New System.Drawing.Size(82, 17)
        Me.Appointed_RBTN.TabIndex = 18
        Me.Appointed_RBTN.Text = "Appionted"
        Me.Appointed_RBTN.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Appointed_RBTN)
        Me.GroupBox2.Controls.Add(Me.Assigned_RBTN)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(927, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(201, 53)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MODE"
        '
        'DateAppointed_TXT
        '
        Me.DateAppointed_TXT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateAppointed_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateAppointed_TXT.Location = New System.Drawing.Point(519, 504)
        Me.DateAppointed_TXT.Name = "DateAppointed_TXT"
        Me.DateAppointed_TXT.ReadOnly = True
        Me.DateAppointed_TXT.Size = New System.Drawing.Size(235, 26)
        Me.DateAppointed_TXT.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(384, 507)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 20)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Date Appointed: "
        '
        'frmRateEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 597)
        Me.Controls.Add(Me.DateAppointed_TXT)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Branch_TXT)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Search_BTN)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Search_TXT)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Comment_TXT)
        Me.Controls.Add(Me.DateHired_TXT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Position_TXT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Name_TXT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RatingListView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRateEmp"
        Me.Text = "frmRateEmp"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RatingListView As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Name_TXT As System.Windows.Forms.TextBox
    Friend WithEvents Position_TXT As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateHired_TXT As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Comment_TXT As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Failed_RadioBTN As System.Windows.Forms.RadioButton
    Friend WithEvents Passed_RadioBTN As System.Windows.Forms.RadioButton
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents UpdateRating_Btn As System.Windows.Forms.Button
    Friend WithEvents SaveRating_BTN As System.Windows.Forms.Button
    Friend WithEvents Clear_BTN As System.Windows.Forms.Button
    Friend WithEvents Search_TXT As System.Windows.Forms.TextBox
    Friend WithEvents Search_BTN As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Branch_TXT As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Assigned_RBTN As System.Windows.Forms.RadioButton
    Friend WithEvents Appointed_RBTN As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DateAppointed_TXT As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
