<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserLogs
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
        Me.UserLogs_ListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Search_BTN = New System.Windows.Forms.Button()
        Me.Search_TXT = New System.Windows.Forms.TextBox()
        Me.TextProgressBar1 = New DBConnect.CustomControls.TextProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Close_LBL = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UserLogs_ListView
        '
        Me.UserLogs_ListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserLogs_ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.UserLogs_ListView.FullRowSelect = True
        Me.UserLogs_ListView.HideSelection = False
        Me.UserLogs_ListView.Location = New System.Drawing.Point(13, 71)
        Me.UserLogs_ListView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UserLogs_ListView.Name = "UserLogs_ListView"
        Me.UserLogs_ListView.Size = New System.Drawing.Size(1162, 617)
        Me.UserLogs_ListView.TabIndex = 0
        Me.UserLogs_ListView.UseCompatibleStateImageBehavior = False
        Me.UserLogs_ListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Date Created"
        Me.ColumnHeader1.Width = 245
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "User Name"
        Me.ColumnHeader2.Width = 201
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Employee Name"
        Me.ColumnHeader3.Width = 270
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Action"
        Me.ColumnHeader9.Width = 320
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Branch"
        Me.ColumnHeader10.Width = 194
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Status"
        Me.ColumnHeader11.Width = 159
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Position"
        Me.ColumnHeader12.Width = 129
        '
        'Search_BTN
        '
        Me.Search_BTN.Location = New System.Drawing.Point(1063, 31)
        Me.Search_BTN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Search_BTN.Name = "Search_BTN"
        Me.Search_BTN.Size = New System.Drawing.Size(112, 35)
        Me.Search_BTN.TabIndex = 1
        Me.Search_BTN.Text = "Search"
        Me.Search_BTN.UseVisualStyleBackColor = True
        '
        'Search_TXT
        '
        Me.Search_TXT.Location = New System.Drawing.Point(13, 35)
        Me.Search_TXT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Search_TXT.Name = "Search_TXT"
        Me.Search_TXT.Size = New System.Drawing.Size(1042, 26)
        Me.Search_TXT.TabIndex = 2
        '
        'TextProgressBar1
        '
        Me.TextProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TextProgressBar1.CustomText = ""
        Me.TextProgressBar1.Location = New System.Drawing.Point(13, 692)
        Me.TextProgressBar1.Name = "TextProgressBar1"
        Me.TextProgressBar1.ProgressColor = System.Drawing.Color.Green
        Me.TextProgressBar1.RightToLeftLayout = True
        Me.TextProgressBar1.Size = New System.Drawing.Size(1163, 11)
        Me.TextProgressBar1.TabIndex = 3
        Me.TextProgressBar1.TextColor = System.Drawing.Color.Black
        Me.TextProgressBar1.TextFont = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TextProgressBar1.Visible = False
        Me.TextProgressBar1.VisualMode = DBConnect.CustomControls.ProgressBarDisplayMode.Percentage
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "User Logs"
        '
        'Close_LBL
        '
        Me.Close_LBL.AutoSize = True
        Me.Close_LBL.Location = New System.Drawing.Point(1141, 0)
        Me.Close_LBL.Name = "Close_LBL"
        Me.Close_LBL.Size = New System.Drawing.Size(49, 20)
        Me.Close_LBL.TabIndex = 5
        Me.Close_LBL.Text = "Close"
        '
        'frmUserLogs
        '
        Me.AcceptButton = Me.Search_BTN
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 711)
        Me.Controls.Add(Me.Close_LBL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextProgressBar1)
        Me.Controls.Add(Me.Search_TXT)
        Me.Controls.Add(Me.Search_BTN)
        Me.Controls.Add(Me.UserLogs_ListView)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmUserLogs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Logs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserLogs_ListView As ListView
    Friend WithEvents Search_BTN As Button
    Friend WithEvents Search_TXT As TextBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents TextProgressBar1 As DBConnect.CustomControls.TextProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Close_LBL As Label
End Class
