<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAttendanceList
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
        Me.Attendance_LV = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Search_TXT = New System.Windows.Forms.TextBox()
        Me.Search_BTN = New System.Windows.Forms.Button()
        Me.Print_BTN = New System.Windows.Forms.Button()
        Me.Select_BTN = New System.Windows.Forms.Button()
        Me.Void_BTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Attendance_LV
        '
        Me.Attendance_LV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Attendance_LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.Attendance_LV.FullRowSelect = True
        Me.Attendance_LV.GridLines = True
        Me.Attendance_LV.HideSelection = False
        Me.Attendance_LV.Location = New System.Drawing.Point(13, 50)
        Me.Attendance_LV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Attendance_LV.Name = "Attendance_LV"
        Me.Attendance_LV.Size = New System.Drawing.Size(1183, 423)
        Me.Attendance_LV.TabIndex = 0
        Me.Attendance_LV.UseCompatibleStateImageBehavior = False
        Me.Attendance_LV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 50
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 491
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Branch"
        Me.ColumnHeader3.Width = 195
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Attendance"
        Me.ColumnHeader4.Width = 205
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Date Encoded"
        Me.ColumnHeader5.Width = 231
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Not/Reason"
        Me.ColumnHeader6.Width = 282
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Remarks"
        Me.ColumnHeader7.Width = 262
        '
        'Search_TXT
        '
        Me.Search_TXT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Search_TXT.Location = New System.Drawing.Point(13, 14)
        Me.Search_TXT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Search_TXT.Name = "Search_TXT"
        Me.Search_TXT.Size = New System.Drawing.Size(1101, 26)
        Me.Search_TXT.TabIndex = 1
        '
        'Search_BTN
        '
        Me.Search_BTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Search_BTN.Location = New System.Drawing.Point(1121, 12)
        Me.Search_BTN.Name = "Search_BTN"
        Me.Search_BTN.Size = New System.Drawing.Size(75, 30)
        Me.Search_BTN.TabIndex = 2
        Me.Search_BTN.Text = "Search"
        Me.Search_BTN.UseVisualStyleBackColor = True
        '
        'Print_BTN
        '
        Me.Print_BTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Print_BTN.Location = New System.Drawing.Point(1121, 481)
        Me.Print_BTN.Name = "Print_BTN"
        Me.Print_BTN.Size = New System.Drawing.Size(75, 30)
        Me.Print_BTN.TabIndex = 3
        Me.Print_BTN.Text = "Print"
        Me.Print_BTN.UseVisualStyleBackColor = True
        '
        'Select_BTN
        '
        Me.Select_BTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Select_BTN.Location = New System.Drawing.Point(1039, 481)
        Me.Select_BTN.Name = "Select_BTN"
        Me.Select_BTN.Size = New System.Drawing.Size(75, 30)
        Me.Select_BTN.TabIndex = 4
        Me.Select_BTN.Text = "Select"
        Me.Select_BTN.UseVisualStyleBackColor = True
        '
        'Void_BTN
        '
        Me.Void_BTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Void_BTN.Location = New System.Drawing.Point(13, 481)
        Me.Void_BTN.Name = "Void_BTN"
        Me.Void_BTN.Size = New System.Drawing.Size(75, 30)
        Me.Void_BTN.TabIndex = 5
        Me.Void_BTN.Text = "Void"
        Me.Void_BTN.UseVisualStyleBackColor = True
        '
        'FrmAttendanceList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1209, 523)
        Me.Controls.Add(Me.Void_BTN)
        Me.Controls.Add(Me.Select_BTN)
        Me.Controls.Add(Me.Print_BTN)
        Me.Controls.Add(Me.Search_BTN)
        Me.Controls.Add(Me.Search_TXT)
        Me.Controls.Add(Me.Attendance_LV)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmAttendanceList"
        Me.Text = "Attendance List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Attendance_LV As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents Search_TXT As TextBox
    Friend WithEvents Search_BTN As Button
    Friend WithEvents Print_BTN As Button
    Friend WithEvents Select_BTN As Button
    Friend WithEvents Void_BTN As Button
End Class
