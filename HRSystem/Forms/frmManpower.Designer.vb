<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmManpower
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManpower))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Close_BTN = New System.Windows.Forms.Button()
        Me.City_TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Gensan_Panel = New System.Windows.Forms.Panel()
        Me.DateAppointed_DTP = New System.Windows.Forms.DateTimePicker()
        Me.GensanBranch_Combo = New System.Windows.Forms.ComboBox()
        Me.GensanBranch_Datagrid = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.TabPage11 = New System.Windows.Forms.TabPage()
        Me.TabPage12 = New System.Windows.Forms.TabPage()
        Me.TabPage13 = New System.Windows.Forms.TabPage()
        Me.TabBranches_Context = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BadBranch_ToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoodBranch_ToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckingBranch_ToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.Gensan_DGV_Company = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gensan_DGV_Pos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gensan_DGV_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gensan_DGV_Started = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gensa_DGV_Appointed = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Gensan_DGV_LOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gensan_DGV_Remarks = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.City_TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Gensan_Panel.SuspendLayout()
        CType(Me.GensanBranch_Datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabBranches_Context.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Label21.Location = New System.Drawing.Point(-1, -2)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(129, 32)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "Manpower"
        '
        'Close_BTN
        '
        Me.Close_BTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Close_BTN.Image = CType(resources.GetObject("Close_BTN.Image"), System.Drawing.Image)
        Me.Close_BTN.Location = New System.Drawing.Point(1149, 0)
        Me.Close_BTN.Name = "Close_BTN"
        Me.Close_BTN.Size = New System.Drawing.Size(30, 30)
        Me.Close_BTN.TabIndex = 13
        Me.Close_BTN.UseVisualStyleBackColor = True
        '
        'City_TabControl
        '
        Me.City_TabControl.Controls.Add(Me.TabPage1)
        Me.City_TabControl.Controls.Add(Me.TabPage2)
        Me.City_TabControl.Controls.Add(Me.TabPage3)
        Me.City_TabControl.Controls.Add(Me.TabPage4)
        Me.City_TabControl.Controls.Add(Me.TabPage5)
        Me.City_TabControl.Controls.Add(Me.TabPage6)
        Me.City_TabControl.Controls.Add(Me.TabPage7)
        Me.City_TabControl.Controls.Add(Me.TabPage10)
        Me.City_TabControl.Controls.Add(Me.TabPage11)
        Me.City_TabControl.Controls.Add(Me.TabPage12)
        Me.City_TabControl.Controls.Add(Me.TabPage13)
        Me.City_TabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.City_TabControl.Location = New System.Drawing.Point(9, 41)
        Me.City_TabControl.Name = "City_TabControl"
        Me.City_TabControl.SelectedIndex = 0
        Me.City_TabControl.Size = New System.Drawing.Size(1162, 677)
        Me.City_TabControl.TabIndex = 15
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.Gensan_Panel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1154, 648)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "  Gensan City  "
        '
        'Gensan_Panel
        '
        Me.Gensan_Panel.Controls.Add(Me.DateAppointed_DTP)
        Me.Gensan_Panel.Controls.Add(Me.GensanBranch_Combo)
        Me.Gensan_Panel.Controls.Add(Me.GensanBranch_Datagrid)
        Me.Gensan_Panel.Controls.Add(Me.Label1)
        Me.Gensan_Panel.Location = New System.Drawing.Point(1, 1)
        Me.Gensan_Panel.Name = "Gensan_Panel"
        Me.Gensan_Panel.Size = New System.Drawing.Size(1153, 647)
        Me.Gensan_Panel.TabIndex = 3
        '
        'DateAppointed_DTP
        '
        Me.DateAppointed_DTP.Location = New System.Drawing.Point(595, 147)
        Me.DateAppointed_DTP.Name = "DateAppointed_DTP"
        Me.DateAppointed_DTP.Size = New System.Drawing.Size(158, 22)
        Me.DateAppointed_DTP.TabIndex = 3
        Me.DateAppointed_DTP.Visible = False
        '
        'GensanBranch_Combo
        '
        Me.GensanBranch_Combo.FormattingEnabled = True
        Me.GensanBranch_Combo.Items.AddRange(New Object() {"Robinsons (ROG)", "KCC (KCG)", "Lagao (LAG)", "J.Cat 2 (JC2)", "Pioneer (PIO)", "Cagampang (CAG)", "Santiago (SAN)", "Roxas (ROX)", "Pendatun (PEN)", "PG Bldg Nat'l HW (PGN)", "Prk. Malakas (PMA)", "Nuñes (NUZ)", "Fatima Uhaw (UHA)"})
        Me.GensanBranch_Combo.Location = New System.Drawing.Point(92, 14)
        Me.GensanBranch_Combo.Name = "GensanBranch_Combo"
        Me.GensanBranch_Combo.Size = New System.Drawing.Size(230, 24)
        Me.GensanBranch_Combo.TabIndex = 1
        '
        'GensanBranch_Datagrid
        '
        Me.GensanBranch_Datagrid.AllowUserToAddRows = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GensanBranch_Datagrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.GensanBranch_Datagrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.GensanBranch_Datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GensanBranch_Datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GensanBranch_Datagrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Gensan_DGV_Company, Me.Gensan_DGV_Pos, Me.Gensan_DGV_Name, Me.Gensan_DGV_Started, Me.Gensa_DGV_Appointed, Me.Gensan_DGV_LOS, Me.Gensan_DGV_Remarks})
        Me.GensanBranch_Datagrid.Location = New System.Drawing.Point(14, 44)
        Me.GensanBranch_Datagrid.Name = "GensanBranch_Datagrid"
        Me.GensanBranch_Datagrid.RowHeadersVisible = False
        Me.GensanBranch_Datagrid.Size = New System.Drawing.Size(1125, 582)
        Me.GensanBranch_Datagrid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Branch"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1154, 648)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "  Sarangani Province  "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1154, 648)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "  South Cotabato  "
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1154, 648)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "  Sultan Kudarat  "
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1154, 648)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "  Cotabato  "
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(1154, 648)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Maguindanao "
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'TabPage7
        '
        Me.TabPage7.Location = New System.Drawing.Point(4, 25)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(1154, 648)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "    North Cotabato  "
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'TabPage10
        '
        Me.TabPage10.Location = New System.Drawing.Point(4, 25)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Size = New System.Drawing.Size(1154, 648)
        Me.TabPage10.TabIndex = 7
        Me.TabPage10.Text = "   Davao Region  "
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'TabPage11
        '
        Me.TabPage11.Location = New System.Drawing.Point(4, 25)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Size = New System.Drawing.Size(1154, 648)
        Me.TabPage11.TabIndex = 8
        Me.TabPage11.Text = "   Surigao  "
        Me.TabPage11.UseVisualStyleBackColor = True
        '
        'TabPage12
        '
        Me.TabPage12.Location = New System.Drawing.Point(4, 25)
        Me.TabPage12.Name = "TabPage12"
        Me.TabPage12.Size = New System.Drawing.Size(1154, 648)
        Me.TabPage12.TabIndex = 9
        Me.TabPage12.Text = "Agusan Del Norte  "
        Me.TabPage12.UseVisualStyleBackColor = True
        '
        'TabPage13
        '
        Me.TabPage13.Location = New System.Drawing.Point(4, 25)
        Me.TabPage13.Name = "TabPage13"
        Me.TabPage13.Size = New System.Drawing.Size(1154, 648)
        Me.TabPage13.TabIndex = 10
        Me.TabPage13.Text = "   Misamis   "
        Me.TabPage13.UseVisualStyleBackColor = True
        '
        'TabBranches_Context
        '
        Me.TabBranches_Context.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BadBranch_ToolStrip, Me.GoodBranch_ToolStrip, Me.CheckingBranch_ToolStrip})
        Me.TabBranches_Context.Name = "TabBranches_Context"
        Me.TabBranches_Context.Size = New System.Drawing.Size(145, 70)
        '
        'BadBranch_ToolStrip
        '
        Me.BadBranch_ToolStrip.Name = "BadBranch_ToolStrip"
        Me.BadBranch_ToolStrip.Size = New System.Drawing.Size(144, 22)
        Me.BadBranch_ToolStrip.Text = "Bad"
        '
        'GoodBranch_ToolStrip
        '
        Me.GoodBranch_ToolStrip.Name = "GoodBranch_ToolStrip"
        Me.GoodBranch_ToolStrip.Size = New System.Drawing.Size(144, 22)
        Me.GoodBranch_ToolStrip.Text = "Good"
        '
        'CheckingBranch_ToolStrip
        '
        Me.CheckingBranch_ToolStrip.Name = "CheckingBranch_ToolStrip"
        Me.CheckingBranch_ToolStrip.Size = New System.Drawing.Size(144, 22)
        Me.CheckingBranch_ToolStrip.Text = "For Checking"
        '
        'Gensan_DGV_Company
        '
        Me.Gensan_DGV_Company.HeaderText = "Company"
        Me.Gensan_DGV_Company.Name = "Gensan_DGV_Company"
        Me.Gensan_DGV_Company.ReadOnly = True
        Me.Gensan_DGV_Company.Width = 70
        '
        'Gensan_DGV_Pos
        '
        Me.Gensan_DGV_Pos.HeaderText = "   Position"
        Me.Gensan_DGV_Pos.Name = "Gensan_DGV_Pos"
        Me.Gensan_DGV_Pos.ReadOnly = True
        '
        'Gensan_DGV_Name
        '
        Me.Gensan_DGV_Name.HeaderText = "Name"
        Me.Gensan_DGV_Name.Name = "Gensan_DGV_Name"
        Me.Gensan_DGV_Name.ReadOnly = True
        Me.Gensan_DGV_Name.Width = 300
        '
        'Gensan_DGV_Started
        '
        Me.Gensan_DGV_Started.HeaderText = "Date Started"
        Me.Gensan_DGV_Started.Name = "Gensan_DGV_Started"
        Me.Gensan_DGV_Started.ReadOnly = True
        Me.Gensan_DGV_Started.Width = 180
        '
        'Gensa_DGV_Appointed
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Gensa_DGV_Appointed.DefaultCellStyle = DataGridViewCellStyle5
        Me.Gensa_DGV_Appointed.HeaderText = "Date Appointed"
        Me.Gensa_DGV_Appointed.Name = "Gensa_DGV_Appointed"
        Me.Gensa_DGV_Appointed.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Gensa_DGV_Appointed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Gensa_DGV_Appointed.Width = 180
        '
        'Gensan_DGV_LOS
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Gensan_DGV_LOS.DefaultCellStyle = DataGridViewCellStyle6
        Me.Gensan_DGV_LOS.HeaderText = "LOS"
        Me.Gensan_DGV_LOS.Name = "Gensan_DGV_LOS"
        Me.Gensan_DGV_LOS.ReadOnly = True
        Me.Gensan_DGV_LOS.Width = 142
        '
        'Gensan_DGV_Remarks
        '
        Me.Gensan_DGV_Remarks.HeaderText = "Remarks"
        Me.Gensan_DGV_Remarks.Name = "Gensan_DGV_Remarks"
        Me.Gensan_DGV_Remarks.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Gensan_DGV_Remarks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Gensan_DGV_Remarks.Width = 150
        '
        'frmManpower
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1179, 730)
        Me.Controls.Add(Me.City_TabControl)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Close_BTN)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmManpower"
        Me.Text = "frmManpower"
        Me.City_TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Gensan_Panel.ResumeLayout(False)
        Me.Gensan_Panel.PerformLayout()
        CType(Me.GensanBranch_Datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabBranches_Context.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label21 As Label
    Friend WithEvents Close_BTN As Button
    Friend WithEvents City_TabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TabPage10 As TabPage
    Friend WithEvents TabPage11 As TabPage
    Friend WithEvents TabPage12 As TabPage
    Friend WithEvents TabPage13 As TabPage
    Friend WithEvents TabBranches_Context As ContextMenuStrip
    Friend WithEvents BadBranch_ToolStrip As ToolStripMenuItem
    Friend WithEvents GoodBranch_ToolStrip As ToolStripMenuItem
    Friend WithEvents CheckingBranch_ToolStrip As ToolStripMenuItem
    Friend WithEvents GensanBranch_Datagrid As DataGridView
    Friend WithEvents GensanBranch_Combo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Gensan_Panel As Panel
    Friend WithEvents DateAppointed_DTP As DateTimePicker
    Friend WithEvents Gensan_DGV_Company As DataGridViewTextBoxColumn
    Friend WithEvents Gensan_DGV_Pos As DataGridViewTextBoxColumn
    Friend WithEvents Gensan_DGV_Name As DataGridViewTextBoxColumn
    Friend WithEvents Gensan_DGV_Started As DataGridViewTextBoxColumn
    Friend WithEvents Gensa_DGV_Appointed As DataGridViewButtonColumn
    Friend WithEvents Gensan_DGV_LOS As DataGridViewTextBoxColumn
    Friend WithEvents Gensan_DGV_Remarks As DataGridViewButtonColumn
End Class
