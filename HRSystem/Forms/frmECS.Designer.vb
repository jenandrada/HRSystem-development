<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmECS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmECS))
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Close_BTN = New System.Windows.Forms.Button()
        Me.ECS_Search_Combo = New System.Windows.Forms.ComboBox()
        Me.ECS_Search_TXT = New System.Windows.Forms.TextBox()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ECS_Page = New System.Windows.Forms.TabPage()
        Me.lvECS = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ECSWindow = New System.Windows.Forms.TabControl()
        Me.ECS_Page.SuspendLayout()
        Me.ECSWindow.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Label21.Location = New System.Drawing.Point(-1, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(101, 32)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "Charges"
        '
        'Close_BTN
        '
        Me.Close_BTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Close_BTN.Image = CType(resources.GetObject("Close_BTN.Image"), System.Drawing.Image)
        Me.Close_BTN.Location = New System.Drawing.Point(1150, 2)
        Me.Close_BTN.Name = "Close_BTN"
        Me.Close_BTN.Size = New System.Drawing.Size(30, 30)
        Me.Close_BTN.TabIndex = 13
        Me.Close_BTN.UseVisualStyleBackColor = True
        '
        'ECS_Search_Combo
        '
        Me.ECS_Search_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ECS_Search_Combo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ECS_Search_Combo.FormattingEnabled = True
        Me.ECS_Search_Combo.Items.AddRange(New Object() {"", "Search by Name", "Search by IR No.", "Search by ECS No."})
        Me.ECS_Search_Combo.Location = New System.Drawing.Point(370, 29)
        Me.ECS_Search_Combo.Name = "ECS_Search_Combo"
        Me.ECS_Search_Combo.Size = New System.Drawing.Size(194, 28)
        Me.ECS_Search_Combo.TabIndex = 83
        '
        'ECS_Search_TXT
        '
        Me.ECS_Search_TXT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ECS_Search_TXT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ECS_Search_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ECS_Search_TXT.Location = New System.Drawing.Point(7, 30)
        Me.ECS_Search_TXT.Name = "ECS_Search_TXT"
        Me.ECS_Search_TXT.Size = New System.Drawing.Size(357, 27)
        Me.ECS_Search_TXT.TabIndex = 82
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.DisplayIndex = 0
        Me.ColumnHeader5.Text = "IR No."
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.DisplayIndex = 1
        Me.ColumnHeader6.Text = "ECS No."
        Me.ColumnHeader6.Width = 140
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.DisplayIndex = 2
        Me.ColumnHeader9.Text = "Name"
        Me.ColumnHeader9.Width = 340
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.DisplayIndex = 3
        Me.ColumnHeader10.Text = "Date Created"
        Me.ColumnHeader10.Width = 200
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.DisplayIndex = 4
        Me.ColumnHeader11.Text = "Full Amount"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader11.Width = 115
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.DisplayIndex = 5
        Me.ColumnHeader12.Text = "No. of months"
        Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader12.Width = 130
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.DisplayIndex = 6
        Me.ColumnHeader13.Text = "Amount/payroll"
        Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader13.Width = 130
        '
        'ECS_Page
        '
        Me.ECS_Page.Controls.Add(Me.lvECS)
        Me.ECS_Page.Controls.Add(Me.ECS_Search_Combo)
        Me.ECS_Page.Controls.Add(Me.ECS_Search_TXT)
        Me.ECS_Page.Location = New System.Drawing.Point(4, 29)
        Me.ECS_Page.Name = "ECS_Page"
        Me.ECS_Page.Padding = New System.Windows.Forms.Padding(3)
        Me.ECS_Page.Size = New System.Drawing.Size(1167, 667)
        Me.ECS_Page.TabIndex = 7
        Me.ECS_Page.Text = "  ECS Records    "
        Me.ECS_Page.UseVisualStyleBackColor = True
        '
        'lvECS
        '
        Me.lvECS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvECS.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader14})
        Me.lvECS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvECS.FullRowSelect = True
        Me.lvECS.GridLines = True
        Me.lvECS.HideSelection = False
        Me.lvECS.Location = New System.Drawing.Point(6, 89)
        Me.lvECS.Name = "lvECS"
        Me.lvECS.Size = New System.Drawing.Size(1154, 570)
        Me.lvECS.TabIndex = 84
        Me.lvECS.UseCompatibleStateImageBehavior = False
        Me.lvECS.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "IR No."
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ECS No."
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Name"
        Me.ColumnHeader3.Width = 360
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Date Created"
        Me.ColumnHeader4.Width = 200
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Full Amount"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 115
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "No. of months"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 130
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Amount/payroll"
        Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader14.Width = 130
        '
        'ECSWindow
        '
        Me.ECSWindow.Controls.Add(Me.ECS_Page)
        Me.ECSWindow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ECSWindow.Location = New System.Drawing.Point(3, 47)
        Me.ECSWindow.Name = "ECSWindow"
        Me.ECSWindow.SelectedIndex = 0
        Me.ECSWindow.Size = New System.Drawing.Size(1175, 700)
        Me.ECSWindow.TabIndex = 15
        '
        'frmECS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 749)
        Me.Controls.Add(Me.ECSWindow)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Close_BTN)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmECS"
        Me.Text = "frmECS"
        Me.ECS_Page.ResumeLayout(False)
        Me.ECS_Page.PerformLayout()
        Me.ECSWindow.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label21 As Label
    Friend WithEvents Close_BTN As Button
    Friend WithEvents ECS_Search_Combo As ComboBox
    Friend WithEvents ECS_Search_TXT As TextBox
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ECS_Page As TabPage
    Friend WithEvents ECSWindow As TabControl
    Friend WithEvents lvECS As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
End Class
