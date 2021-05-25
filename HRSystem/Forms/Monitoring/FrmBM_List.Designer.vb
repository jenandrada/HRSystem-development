<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBM_List
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Glenn D. Boc", "Programmer", "MIS-Head Office"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Alver Malinog", "Technical support", "MIS-Head Office"}, -1)
        Me.BmList_LV = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cancel_Btn = New System.Windows.Forms.Button()
        Me.Select_BTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BmList_LV
        '
        Me.BmList_LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.BmList_LV.FullRowSelect = True
        Me.BmList_LV.HideSelection = False
        Me.BmList_LV.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2})
        Me.BmList_LV.Location = New System.Drawing.Point(15, 13)
        Me.BmList_LV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BmList_LV.MultiSelect = False
        Me.BmList_LV.Name = "BmList_LV"
        Me.BmList_LV.Size = New System.Drawing.Size(807, 293)
        Me.BmList_LV.TabIndex = 0
        Me.BmList_LV.UseCompatibleStateImageBehavior = False
        Me.BmList_LV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 380
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Position"
        Me.ColumnHeader2.Width = 224
        '
        'Cancel_Btn
        '
        Me.Cancel_Btn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Btn.Location = New System.Drawing.Point(710, 316)
        Me.Cancel_Btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Cancel_Btn.Name = "Cancel_Btn"
        Me.Cancel_Btn.Size = New System.Drawing.Size(112, 35)
        Me.Cancel_Btn.TabIndex = 1
        Me.Cancel_Btn.Text = "Cancel"
        Me.Cancel_Btn.UseVisualStyleBackColor = True
        '
        'Select_BTN
        '
        Me.Select_BTN.Location = New System.Drawing.Point(590, 316)
        Me.Select_BTN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Select_BTN.Name = "Select_BTN"
        Me.Select_BTN.Size = New System.Drawing.Size(112, 35)
        Me.Select_BTN.TabIndex = 2
        Me.Select_BTN.Text = "Select"
        Me.Select_BTN.UseVisualStyleBackColor = True
        '
        'FrmBM_List
        '
        Me.AcceptButton = Me.Select_BTN
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Btn
        Me.ClientSize = New System.Drawing.Size(836, 365)
        Me.Controls.Add(Me.Select_BTN)
        Me.Controls.Add(Me.Cancel_Btn)
        Me.Controls.Add(Me.BmList_LV)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmBM_List"
        Me.Text = "Branch Manage/OIC List"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BmList_LV As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Cancel_Btn As Button
    Friend WithEvents Select_BTN As Button
End Class
