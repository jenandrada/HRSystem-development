<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIRList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIRList))
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Close_BTN = New System.Windows.Forms.Button()
        Me.lvEmployee = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Label21.Location = New System.Drawing.Point(1, -2)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(220, 32)
        Me.Label21.TabIndex = 10
        Me.Label21.Text = "Incident Report List"
        '
        'Close_BTN
        '
        Me.Close_BTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Close_BTN.Image = CType(resources.GetObject("Close_BTN.Image"), System.Drawing.Image)
        Me.Close_BTN.Location = New System.Drawing.Point(1153, -2)
        Me.Close_BTN.Name = "Close_BTN"
        Me.Close_BTN.Size = New System.Drawing.Size(30, 30)
        Me.Close_BTN.TabIndex = 11
        Me.Close_BTN.UseVisualStyleBackColor = True
        '
        'lvEmployee
        '
        Me.lvEmployee.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvEmployee.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6})
        Me.lvEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvEmployee.FullRowSelect = True
        Me.lvEmployee.GridLines = True
        Me.lvEmployee.HideSelection = False
        Me.lvEmployee.Location = New System.Drawing.Point(30, 110)
        Me.lvEmployee.Name = "lvEmployee"
        Me.lvEmployee.Size = New System.Drawing.Size(1116, 614)
        Me.lvEmployee.TabIndex = 56
        Me.lvEmployee.UseCompatibleStateImageBehavior = False
        Me.lvEmployee.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "IR No."
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Fullname"
        Me.ColumnHeader2.Width = 400
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Date of Incident"
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Action Taken"
        Me.ColumnHeader4.Width = 200
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Prepared by"
        Me.ColumnHeader6.Width = 210
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(656, 56)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(106, 34)
        Me.btnSearch.TabIndex = 58
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(30, 57)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(617, 31)
        Me.txtSearch.TabIndex = 57
        '
        'frmIRList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 749)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lvEmployee)
        Me.Controls.Add(Me.Close_BTN)
        Me.Controls.Add(Me.Label21)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmIRList"
        Me.Text = "IRList"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label21 As Label
    Friend WithEvents Close_BTN As Button
    Friend WithEvents lvEmployee As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
End Class
