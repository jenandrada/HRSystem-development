<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmworklist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmworklist))
        Me.lvEmployee = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.imgClient = New System.Windows.Forms.ImageList(Me.components)
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblmode = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Relieve_RBTN = New System.Windows.Forms.RadioButton()
        Me.chkassigned = New System.Windows.Forms.RadioButton()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.Print_BTN = New System.Windows.Forms.Button()
        Me.Void_BTN = New System.Windows.Forms.Button()
        Me.Next_BTN = New System.Windows.Forms.Button()
        Me.Previous_BTN = New System.Windows.Forms.Button()
        Me.Output_Lbl = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvEmployee
        '
        Me.lvEmployee.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lvEmployee.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader7, Me.ColumnHeader6, Me.ColumnHeader8, Me.ColumnHeader10, Me.ColumnHeader9})
        Me.lvEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvEmployee.FullRowSelect = True
        Me.lvEmployee.GridLines = True
        Me.lvEmployee.HideSelection = False
        Me.lvEmployee.LargeImageList = Me.imgClient
        Me.lvEmployee.Location = New System.Drawing.Point(21, 119)
        Me.lvEmployee.Name = "lvEmployee"
        Me.lvEmployee.Size = New System.Drawing.Size(1113, 492)
        Me.lvEmployee.SmallImageList = Me.imgClient
        Me.lvEmployee.TabIndex = 9
        Me.lvEmployee.UseCompatibleStateImageBehavior = False
        Me.lvEmployee.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 87
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "FULL NAME"
        Me.ColumnHeader2.Width = 521
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "WHO ?"
        Me.ColumnHeader3.Width = 418
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "STATUS"
        Me.ColumnHeader4.Width = 119
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "POSITION"
        Me.ColumnHeader5.Width = 275
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "COMPANY"
        Me.ColumnHeader7.Width = 141
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "BRANCH"
        Me.ColumnHeader6.Width = 281
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "CODE"
        Me.ColumnHeader8.Width = 128
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "AREA"
        Me.ColumnHeader10.Width = 176
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "DATE DESIGNATE"
        Me.ColumnHeader9.Width = 288
        '
        'imgClient
        '
        Me.imgClient.ImageStream = CType(resources.GetObject("imgClient.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgClient.TransparentColor = System.Drawing.Color.Transparent
        Me.imgClient.Images.SetKeyName(0, "imgMale")
        Me.imgClient.Images.SetKeyName(1, "imgFemale")
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(1023, 80)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(111, 35)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(21, 82)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(996, 31)
        Me.txtSearch.TabIndex = 7
        '
        'lblmode
        '
        Me.lblmode.AutoSize = True
        Me.lblmode.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmode.Location = New System.Drawing.Point(45, 27)
        Me.lblmode.Name = "lblmode"
        Me.lblmode.Size = New System.Drawing.Size(272, 31)
        Me.lblmode.TabIndex = 6
        Me.lblmode.Text = "Search WORK LIST"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Relieve_RBTN)
        Me.GroupBox4.Controls.Add(Me.chkassigned)
        Me.GroupBox4.Enabled = False
        Me.GroupBox4.Location = New System.Drawing.Point(801, 27)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(216, 41)
        Me.GroupBox4.TabIndex = 52
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Mode"
        '
        'Relieve_RBTN
        '
        Me.Relieve_RBTN.AutoSize = True
        Me.Relieve_RBTN.Location = New System.Drawing.Point(109, 18)
        Me.Relieve_RBTN.Name = "Relieve_RBTN"
        Me.Relieve_RBTN.Size = New System.Drawing.Size(70, 17)
        Me.Relieve_RBTN.TabIndex = 1
        Me.Relieve_RBTN.Text = "RELIEVE"
        Me.Relieve_RBTN.UseVisualStyleBackColor = True
        '
        'chkassigned
        '
        Me.chkassigned.AutoSize = True
        Me.chkassigned.Checked = True
        Me.chkassigned.Location = New System.Drawing.Point(17, 18)
        Me.chkassigned.Name = "chkassigned"
        Me.chkassigned.Size = New System.Drawing.Size(80, 17)
        Me.chkassigned.TabIndex = 0
        Me.chkassigned.TabStop = True
        Me.chkassigned.Text = "ASSIGNED"
        Me.chkassigned.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.Location = New System.Drawing.Point(1119, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(36, 35)
        Me.btnClose.TabIndex = 53
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(1035, 617)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(99, 52)
        Me.btnSelect.TabIndex = 54
        Me.btnSelect.Text = "&Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'Print_BTN
        '
        Me.Print_BTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Print_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Print_BTN.Location = New System.Drawing.Point(930, 617)
        Me.Print_BTN.Name = "Print_BTN"
        Me.Print_BTN.Size = New System.Drawing.Size(99, 52)
        Me.Print_BTN.TabIndex = 55
        Me.Print_BTN.Text = "&Print"
        Me.Print_BTN.UseVisualStyleBackColor = True
        '
        'Void_BTN
        '
        Me.Void_BTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Void_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Void_BTN.Location = New System.Drawing.Point(825, 617)
        Me.Void_BTN.Name = "Void_BTN"
        Me.Void_BTN.Size = New System.Drawing.Size(99, 52)
        Me.Void_BTN.TabIndex = 56
        Me.Void_BTN.Text = "&VOID"
        Me.Void_BTN.UseVisualStyleBackColor = True
        '
        'Next_BTN
        '
        Me.Next_BTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Next_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Next_BTN.Location = New System.Drawing.Point(126, 617)
        Me.Next_BTN.Name = "Next_BTN"
        Me.Next_BTN.Size = New System.Drawing.Size(99, 36)
        Me.Next_BTN.TabIndex = 62
        Me.Next_BTN.Text = "Next"
        Me.Next_BTN.UseVisualStyleBackColor = True
        '
        'Previous_BTN
        '
        Me.Previous_BTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Previous_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Previous_BTN.Location = New System.Drawing.Point(21, 617)
        Me.Previous_BTN.Name = "Previous_BTN"
        Me.Previous_BTN.Size = New System.Drawing.Size(99, 36)
        Me.Previous_BTN.TabIndex = 61
        Me.Previous_BTN.Text = "Previous"
        Me.Previous_BTN.UseVisualStyleBackColor = True
        '
        'Output_Lbl
        '
        Me.Output_Lbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Output_Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Output_Lbl.Location = New System.Drawing.Point(443, 614)
        Me.Output_Lbl.Name = "Output_Lbl"
        Me.Output_Lbl.Size = New System.Drawing.Size(272, 23)
        Me.Output_Lbl.TabIndex = 63
        Me.Output_Lbl.Text = "Label2"
        Me.Output_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmworklist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1158, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.Output_Lbl)
        Me.Controls.Add(Me.Next_BTN)
        Me.Controls.Add(Me.Previous_BTN)
        Me.Controls.Add(Me.Void_BTN)
        Me.Controls.Add(Me.Print_BTN)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.lvEmployee)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblmode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmworklist"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvEmployee As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents imgClient As System.Windows.Forms.ImageList
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblmode As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Relieve_RBTN As System.Windows.Forms.RadioButton
    Friend WithEvents chkassigned As System.Windows.Forms.RadioButton
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Print_BTN As System.Windows.Forms.Button
    Friend WithEvents Void_BTN As System.Windows.Forms.Button
    Friend WithEvents Next_BTN As System.Windows.Forms.Button
    Friend WithEvents Previous_BTN As System.Windows.Forms.Button
    Friend WithEvents Output_Lbl As System.Windows.Forms.Label
End Class
