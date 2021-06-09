<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWRList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWRList))
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Close_BTN = New System.Windows.Forms.Button()
        Me.Status_Combo = New System.Windows.Forms.ComboBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.SearchBy_Combo = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lvEmployee = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Label21.Location = New System.Drawing.Point(-1, -1)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(258, 32)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "Written Reprimand List"
        '
        'Close_BTN
        '
        Me.Close_BTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Close_BTN.Image = CType(resources.GetObject("Close_BTN.Image"), System.Drawing.Image)
        Me.Close_BTN.Location = New System.Drawing.Point(1147, 4)
        Me.Close_BTN.Name = "Close_BTN"
        Me.Close_BTN.Size = New System.Drawing.Size(30, 30)
        Me.Close_BTN.TabIndex = 15
        Me.Close_BTN.UseVisualStyleBackColor = True
        '
        'Status_Combo
        '
        Me.Status_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Status_Combo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status_Combo.FormattingEnabled = True
        Me.Status_Combo.Items.AddRange(New Object() {"All", "Pending", "Acknowleged"})
        Me.Status_Combo.Location = New System.Drawing.Point(979, 49)
        Me.Status_Combo.Name = "Status_Combo"
        Me.Status_Combo.Size = New System.Drawing.Size(174, 28)
        Me.Status_Combo.TabIndex = 87
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(917, 54)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(56, 20)
        Me.Label43.TabIndex = 86
        Me.Label43.Text = "Status"
        '
        'SearchBy_Combo
        '
        Me.SearchBy_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SearchBy_Combo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBy_Combo.FormattingEnabled = True
        Me.SearchBy_Combo.Items.AddRange(New Object() {"Search by Name", "Search by IR No."})
        Me.SearchBy_Combo.Location = New System.Drawing.Point(373, 50)
        Me.SearchBy_Combo.Name = "SearchBy_Combo"
        Me.SearchBy_Combo.Size = New System.Drawing.Size(158, 28)
        Me.SearchBy_Combo.TabIndex = 85
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(10, 51)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(357, 27)
        Me.txtSearch.TabIndex = 84
        '
        'lvEmployee
        '
        Me.lvEmployee.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvEmployee.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5})
        Me.lvEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvEmployee.FullRowSelect = True
        Me.lvEmployee.GridLines = True
        Me.lvEmployee.HideSelection = False
        Me.lvEmployee.Location = New System.Drawing.Point(10, 127)
        Me.lvEmployee.Name = "lvEmployee"
        Me.lvEmployee.Size = New System.Drawing.Size(1143, 614)
        Me.lvEmployee.TabIndex = 88
        Me.lvEmployee.UseCompatibleStateImageBehavior = False
        Me.lvEmployee.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "IR No."
        Me.ColumnHeader1.Width = 125
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Fullname"
        Me.ColumnHeader2.Width = 400
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Date Issued"
        Me.ColumnHeader3.Width = 300
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Company"
        Me.ColumnHeader5.Width = 310
        '
        'frmWRList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 749)
        Me.Controls.Add(Me.lvEmployee)
        Me.Controls.Add(Me.Status_Combo)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.SearchBy_Combo)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Close_BTN)
        Me.Controls.Add(Me.Label21)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmWRList"
        Me.Text = "frmWRList"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Close_BTN As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents Status_Combo As ComboBox
    Friend WithEvents Label43 As Label
    Friend WithEvents SearchBy_Combo As ComboBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lvEmployee As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
End Class
