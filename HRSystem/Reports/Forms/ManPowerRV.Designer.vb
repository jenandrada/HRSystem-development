<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManPowerRV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManPowerRV))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EMP_Name_TXT = New System.Windows.Forms.TextBox()
        Me.DateHiredDtp = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Area_TXT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Branch_TXT = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Company_TXT = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "HRSystem.ManPowerV2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 40)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1244, 640)
        Me.ReportViewer1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.EMP_Name_TXT)
        Me.Panel1.Controls.Add(Me.DateHiredDtp)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Area_TXT)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Branch_TXT)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Company_TXT)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1244, 40)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1163, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 27)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(855, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Name"
        '
        'EMP_Name_TXT
        '
        Me.EMP_Name_TXT.Location = New System.Drawing.Point(912, 7)
        Me.EMP_Name_TXT.Name = "EMP_Name_TXT"
        Me.EMP_Name_TXT.Size = New System.Drawing.Size(245, 26)
        Me.EMP_Name_TXT.TabIndex = 7
        '
        'DateHiredDtp
        '
        Me.DateHiredDtp.CustomFormat = ""
        Me.DateHiredDtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateHiredDtp.Location = New System.Drawing.Point(3, 7)
        Me.DateHiredDtp.Name = "DateHiredDtp"
        Me.DateHiredDtp.ShowCheckBox = True
        Me.DateHiredDtp.ShowUpDown = True
        Me.DateHiredDtp.Size = New System.Drawing.Size(214, 26)
        Me.DateHiredDtp.TabIndex = 2
        Me.DateHiredDtp.Value = New Date(2019, 10, 14, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(661, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Area"
        '
        'Area_TXT
        '
        Me.Area_TXT.Location = New System.Drawing.Point(710, 7)
        Me.Area_TXT.Name = "Area_TXT"
        Me.Area_TXT.Size = New System.Drawing.Size(139, 26)
        Me.Area_TXT.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(450, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Branch"
        '
        'Branch_TXT
        '
        Me.Branch_TXT.Location = New System.Drawing.Point(516, 7)
        Me.Branch_TXT.Name = "Branch_TXT"
        Me.Branch_TXT.Size = New System.Drawing.Size(139, 26)
        Me.Branch_TXT.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(223, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Company"
        '
        'Company_TXT
        '
        Me.Company_TXT.Location = New System.Drawing.Point(305, 7)
        Me.Company_TXT.Name = "Company_TXT"
        Me.Company_TXT.Size = New System.Drawing.Size(139, 26)
        Me.Company_TXT.TabIndex = 3
        '
        'ManPowerRV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 680)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ManPowerRV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Man Power Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As ReportViewer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Area_TXT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Branch_TXT As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Company_TXT As TextBox
    Friend WithEvents DateHiredDtp As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents EMP_Name_TXT As TextBox
    Friend WithEvents Button1 As Button
End Class
