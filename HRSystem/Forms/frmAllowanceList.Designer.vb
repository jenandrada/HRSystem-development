<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAllowanceList
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label_Header = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TotalAllowance_LBL = New System.Windows.Forms.Label()
        Me.Name_LBL = New System.Windows.Forms.Label()
        Me.Select_BTN = New System.Windows.Forms.Button()
        Me.Search_TXT = New System.Windows.Forms.TextBox()
        Me.Search_BTN = New System.Windows.Forms.Button()
        Me.BHA_ListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label_Header)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1167, 64)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.HRSystem.My.Resources.Resources.close_window_50px
        Me.Button1.Location = New System.Drawing.Point(1136, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 30)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label_Header
        '
        Me.Label_Header.AutoSize = True
        Me.Label_Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Header.Location = New System.Drawing.Point(12, 9)
        Me.Label_Header.Name = "Label_Header"
        Me.Label_Header.Size = New System.Drawing.Size(599, 36)
        Me.Label_Header.TabIndex = 0
        Me.Label_Header.Text = "Employees With Boarding House Allowance"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TotalAllowance_LBL)
        Me.Panel2.Controls.Add(Me.Name_LBL)
        Me.Panel2.Controls.Add(Me.Select_BTN)
        Me.Panel2.Controls.Add(Me.Search_TXT)
        Me.Panel2.Controls.Add(Me.Search_BTN)
        Me.Panel2.Controls.Add(Me.BHA_ListView)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1167, 522)
        Me.Panel2.TabIndex = 1
        '
        'TotalAllowance_LBL
        '
        Me.TotalAllowance_LBL.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TotalAllowance_LBL.AutoSize = True
        Me.TotalAllowance_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAllowance_LBL.Location = New System.Drawing.Point(14, 494)
        Me.TotalAllowance_LBL.Name = "TotalAllowance_LBL"
        Me.TotalAllowance_LBL.Size = New System.Drawing.Size(190, 20)
        Me.TotalAllowance_LBL.TabIndex = 6
        Me.TotalAllowance_LBL.Text = "Total Allowance: 99.00"
        Me.TotalAllowance_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Name_LBL
        '
        Me.Name_LBL.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Name_LBL.AutoSize = True
        Me.Name_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_LBL.Location = New System.Drawing.Point(14, 467)
        Me.Name_LBL.Name = "Name_LBL"
        Me.Name_LBL.Size = New System.Drawing.Size(69, 20)
        Me.Name_LBL.TabIndex = 5
        Me.Name_LBL.Text = "GLENN"
        Me.Name_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Select_BTN
        '
        Me.Select_BTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Select_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Select_BTN.Location = New System.Drawing.Point(1068, 474)
        Me.Select_BTN.Name = "Select_BTN"
        Me.Select_BTN.Size = New System.Drawing.Size(87, 40)
        Me.Select_BTN.TabIndex = 3
        Me.Select_BTN.Text = "Select"
        Me.Select_BTN.UseVisualStyleBackColor = True
        '
        'Search_TXT
        '
        Me.Search_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search_TXT.Location = New System.Drawing.Point(12, 6)
        Me.Search_TXT.Name = "Search_TXT"
        Me.Search_TXT.Size = New System.Drawing.Size(1050, 26)
        Me.Search_TXT.TabIndex = 2
        '
        'Search_BTN
        '
        Me.Search_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search_BTN.Location = New System.Drawing.Point(1068, 2)
        Me.Search_BTN.Name = "Search_BTN"
        Me.Search_BTN.Size = New System.Drawing.Size(87, 34)
        Me.Search_BTN.TabIndex = 1
        Me.Search_BTN.Text = "Search"
        Me.Search_BTN.UseVisualStyleBackColor = True
        '
        'BHA_ListView
        '
        Me.BHA_ListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BHA_ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.BHA_ListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BHA_ListView.FullRowSelect = True
        Me.BHA_ListView.HideSelection = False
        Me.BHA_ListView.Location = New System.Drawing.Point(12, 38)
        Me.BHA_ListView.MultiSelect = False
        Me.BHA_ListView.Name = "BHA_ListView"
        Me.BHA_ListView.Size = New System.Drawing.Size(1143, 426)
        Me.BHA_ListView.TabIndex = 0
        Me.BHA_ListView.UseCompatibleStateImageBehavior = False
        Me.BHA_ListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 255
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Boarding House Allowance"
        Me.ColumnHeader3.Width = 224
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Care Kit Allowance"
        Me.ColumnHeader4.Width = 208
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Other Allowance"
        Me.ColumnHeader5.Width = 232
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Particulars"
        Me.ColumnHeader6.Width = 256
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Branch"
        Me.ColumnHeader7.Width = 188
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Area"
        Me.ColumnHeader8.Width = 184
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Status"
        '
        'frmAllowanceList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1167, 586)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAllowanceList"
        Me.Text = "frmAllowanceList"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label_Header As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Select_BTN As System.Windows.Forms.Button
    Friend WithEvents Search_TXT As System.Windows.Forms.TextBox
    Friend WithEvents Search_BTN As System.Windows.Forms.Button
    Friend WithEvents BHA_ListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Name_LBL As System.Windows.Forms.Label
    Friend WithEvents TotalAllowance_LBL As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader9 As ColumnHeader
End Class
