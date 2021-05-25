<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmnotify
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmnotify))
        Me.lvEmployee = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtname = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdioFailed = New System.Windows.Forms.RadioButton()
        Me.rdioPass = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Assigned_RBTN = New System.Windows.Forms.RadioButton()
        Me.Appointed_RBTN = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Search_TXT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvEmployee
        '
        Me.lvEmployee.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader5, Me.ColumnHeader7, Me.ColumnHeader6, Me.ColumnHeader8, Me.ColumnHeader10, Me.ColumnHeader9, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvEmployee.FullRowSelect = True
        Me.lvEmployee.GridLines = True
        Me.lvEmployee.HideSelection = False
        Me.lvEmployee.Location = New System.Drawing.Point(19, 107)
        Me.lvEmployee.MultiSelect = False
        Me.lvEmployee.Name = "lvEmployee"
        Me.lvEmployee.Size = New System.Drawing.Size(1122, 424)
        Me.lvEmployee.TabIndex = 10
        Me.lvEmployee.UseCompatibleStateImageBehavior = False
        Me.lvEmployee.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 67
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "FULL NAME"
        Me.ColumnHeader2.Width = 435
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "POSITION"
        Me.ColumnHeader5.Width = 183
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "COMPANY"
        Me.ColumnHeader7.Width = 164
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "BRANCH"
        Me.ColumnHeader6.Width = 202
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "CODE"
        Me.ColumnHeader8.Width = 123
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "AREA"
        Me.ColumnHeader10.Width = 140
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "DATE DESIGNATE"
        Me.ColumnHeader9.Width = 221
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Assestment"
        Me.ColumnHeader3.Width = 172
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "RATE US"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.Location = New System.Drawing.Point(1118, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(36, 35)
        Me.btnClose.TabIndex = 63
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtname
        '
        Me.txtname.AutoSize = True
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(222, 562)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(111, 25)
        Me.txtname.TabIndex = 64
        Me.txtname.Text = "Val Rulete"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdioFailed)
        Me.GroupBox1.Controls.Add(Me.rdioPass)
        Me.GroupBox1.Location = New System.Drawing.Point(611, 551)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 47)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Assestment"
        '
        'rdioFailed
        '
        Me.rdioFailed.AutoSize = True
        Me.rdioFailed.Location = New System.Drawing.Point(91, 19)
        Me.rdioFailed.Name = "rdioFailed"
        Me.rdioFailed.Size = New System.Drawing.Size(62, 17)
        Me.rdioFailed.TabIndex = 1
        Me.rdioFailed.Text = "FAILED"
        Me.rdioFailed.UseVisualStyleBackColor = True
        '
        'rdioPass
        '
        Me.rdioPass.AutoSize = True
        Me.rdioPass.Checked = True
        Me.rdioPass.Location = New System.Drawing.Point(15, 19)
        Me.rdioPass.Name = "rdioPass"
        Me.rdioPass.Size = New System.Drawing.Size(53, 17)
        Me.rdioPass.TabIndex = 0
        Me.rdioPass.TabStop = True
        Me.rdioPass.Text = "PASS"
        Me.rdioPass.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(858, 570)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 66
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Assigned_RBTN
        '
        Me.Assigned_RBTN.AutoSize = True
        Me.Assigned_RBTN.Checked = True
        Me.Assigned_RBTN.Location = New System.Drawing.Point(13, 19)
        Me.Assigned_RBTN.Name = "Assigned_RBTN"
        Me.Assigned_RBTN.Size = New System.Drawing.Size(80, 17)
        Me.Assigned_RBTN.TabIndex = 67
        Me.Assigned_RBTN.TabStop = True
        Me.Assigned_RBTN.Text = "ASSIGNED"
        Me.Assigned_RBTN.UseVisualStyleBackColor = True
        '
        'Appointed_RBTN
        '
        Me.Appointed_RBTN.AutoSize = True
        Me.Appointed_RBTN.Location = New System.Drawing.Point(109, 19)
        Me.Appointed_RBTN.Name = "Appointed_RBTN"
        Me.Appointed_RBTN.Size = New System.Drawing.Size(87, 17)
        Me.Appointed_RBTN.TabIndex = 68
        Me.Appointed_RBTN.TabStop = True
        Me.Appointed_RBTN.Text = "APPOINTED"
        Me.Appointed_RBTN.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Assigned_RBTN)
        Me.GroupBox2.Controls.Add(Me.Appointed_RBTN)
        Me.GroupBox2.Location = New System.Drawing.Point(932, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(209, 47)
        Me.GroupBox2.TabIndex = 69
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MODE"
        '
        'Search_TXT
        '
        Me.Search_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search_TXT.Location = New System.Drawing.Point(99, 75)
        Me.Search_TXT.Name = "Search_TXT"
        Me.Search_TXT.Size = New System.Drawing.Size(827, 26)
        Me.Search_TXT.TabIndex = 70
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "SEARCH"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Status"
        '
        'frmnotify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1155, 682)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Search_TXT)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvEmployee)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmnotify"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvEmployee As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtname As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdioFailed As System.Windows.Forms.RadioButton
    Friend WithEvents rdioPass As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Assigned_RBTN As System.Windows.Forms.RadioButton
    Friend WithEvents Appointed_RBTN As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Search_TXT As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class
