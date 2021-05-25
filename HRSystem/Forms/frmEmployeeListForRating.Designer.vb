<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeListForRating
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
        Me.Search_BTN = New System.Windows.Forms.Button()
        Me.Search_TXT = New System.Windows.Forms.TextBox()
        Me.Select_BTN = New System.Windows.Forms.Button()
        Me.lvEmployee = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cancel_BTN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Assigned_RBTN = New System.Windows.Forms.RadioButton()
        Me.Appointed_RBTN = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Search_BTN
        '
        Me.Search_BTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Search_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search_BTN.Location = New System.Drawing.Point(627, 80)
        Me.Search_BTN.Name = "Search_BTN"
        Me.Search_BTN.Size = New System.Drawing.Size(80, 29)
        Me.Search_BTN.TabIndex = 0
        Me.Search_BTN.Text = "S&earch"
        Me.Search_BTN.UseVisualStyleBackColor = True
        '
        'Search_TXT
        '
        Me.Search_TXT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Search_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search_TXT.Location = New System.Drawing.Point(13, 80)
        Me.Search_TXT.Name = "Search_TXT"
        Me.Search_TXT.Size = New System.Drawing.Size(608, 29)
        Me.Search_TXT.TabIndex = 1
        '
        'Select_BTN
        '
        Me.Select_BTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Select_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Select_BTN.Location = New System.Drawing.Point(627, 473)
        Me.Select_BTN.Name = "Select_BTN"
        Me.Select_BTN.Size = New System.Drawing.Size(80, 29)
        Me.Select_BTN.TabIndex = 3
        Me.Select_BTN.Text = "&Select"
        Me.Select_BTN.UseVisualStyleBackColor = True
        '
        'lvEmployee
        '
        Me.lvEmployee.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvEmployee.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvEmployee.FullRowSelect = True
        Me.lvEmployee.GridLines = True
        Me.lvEmployee.HideSelection = False
        Me.lvEmployee.Location = New System.Drawing.Point(13, 115)
        Me.lvEmployee.Name = "lvEmployee"
        Me.lvEmployee.Size = New System.Drawing.Size(694, 352)
        Me.lvEmployee.TabIndex = 6
        Me.lvEmployee.UseCompatibleStateImageBehavior = False
        Me.lvEmployee.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Fullname"
        Me.ColumnHeader2.Width = 233
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Contact Number"
        Me.ColumnHeader3.Width = 111
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Email Address"
        Me.ColumnHeader4.Width = 285
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Position"
        '
        'Cancel_BTN
        '
        Me.Cancel_BTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_BTN.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_BTN.Location = New System.Drawing.Point(541, 473)
        Me.Cancel_BTN.Name = "Cancel_BTN"
        Me.Cancel_BTN.Size = New System.Drawing.Size(80, 29)
        Me.Cancel_BTN.TabIndex = 7
        Me.Cancel_BTN.Text = "&Cancel"
        Me.Cancel_BTN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "APPOINTED LIST"
        '
        'Assigned_RBTN
        '
        Me.Assigned_RBTN.AutoSize = True
        Me.Assigned_RBTN.Checked = True
        Me.Assigned_RBTN.Location = New System.Drawing.Point(6, 26)
        Me.Assigned_RBTN.Name = "Assigned_RBTN"
        Me.Assigned_RBTN.Size = New System.Drawing.Size(80, 17)
        Me.Assigned_RBTN.TabIndex = 9
        Me.Assigned_RBTN.TabStop = True
        Me.Assigned_RBTN.Text = "ASSIGNED"
        Me.Assigned_RBTN.UseVisualStyleBackColor = True
        '
        'Appointed_RBTN
        '
        Me.Appointed_RBTN.AutoSize = True
        Me.Appointed_RBTN.Location = New System.Drawing.Point(102, 26)
        Me.Appointed_RBTN.Name = "Appointed_RBTN"
        Me.Appointed_RBTN.Size = New System.Drawing.Size(87, 17)
        Me.Appointed_RBTN.TabIndex = 10
        Me.Appointed_RBTN.Text = "APPOINTED"
        Me.Appointed_RBTN.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Assigned_RBTN)
        Me.GroupBox1.Controls.Add(Me.Appointed_RBTN)
        Me.GroupBox1.Location = New System.Drawing.Point(421, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 62)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MODE"
        '
        'frmEmployeeListForRating
        '
        Me.AcceptButton = Me.Search_BTN
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_BTN
        Me.ClientSize = New System.Drawing.Size(720, 514)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancel_BTN)
        Me.Controls.Add(Me.lvEmployee)
        Me.Controls.Add(Me.Select_BTN)
        Me.Controls.Add(Me.Search_TXT)
        Me.Controls.Add(Me.Search_BTN)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEmployeeListForRating"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee List"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Search_BTN As System.Windows.Forms.Button
    Friend WithEvents Search_TXT As System.Windows.Forms.TextBox
    Friend WithEvents Select_BTN As System.Windows.Forms.Button
    Friend WithEvents lvEmployee As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cancel_BTN As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Assigned_RBTN As System.Windows.Forms.RadioButton
    Friend WithEvents Appointed_RBTN As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
End Class
