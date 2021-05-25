<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrintRatings
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Relieve_CHK = New System.Windows.Forms.CheckBox()
        Me.Assigned_CHK = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EMP_NameCB = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dsRating = New HRSystem.DsRatingDataSet()
        Me.RATINGS_ALLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RATINGS_ALLTableAdapter = New HRSystem.dsRatingTableAdapters.RATINGS_ALLTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dsRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RATINGS_ALLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Relieve_CHK)
        Me.Panel1.Controls.Add(Me.Assigned_CHK)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.EMP_NameCB)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1211, 45)
        Me.Panel1.TabIndex = 0
        '
        'Relieve_CHK
        '
        Me.Relieve_CHK.AutoSize = True
        Me.Relieve_CHK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Relieve_CHK.Location = New System.Drawing.Point(875, 10)
        Me.Relieve_CHK.Name = "Relieve_CHK"
        Me.Relieve_CHK.Size = New System.Drawing.Size(80, 24)
        Me.Relieve_CHK.TabIndex = 2
        Me.Relieve_CHK.Text = "Relieve"
        Me.Relieve_CHK.UseVisualStyleBackColor = True
        '
        'Assigned_CHK
        '
        Me.Assigned_CHK.AutoSize = True
        Me.Assigned_CHK.Checked = True
        Me.Assigned_CHK.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Assigned_CHK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Assigned_CHK.Location = New System.Drawing.Point(760, 10)
        Me.Assigned_CHK.Name = "Assigned_CHK"
        Me.Assigned_CHK.Size = New System.Drawing.Size(94, 24)
        Me.Assigned_CHK.TabIndex = 1
        Me.Assigned_CHK.Text = "Assigned"
        Me.Assigned_CHK.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search By Name: "
        '
        'EMP_NameCB
        '
        Me.EMP_NameCB.DisplayMember = "FULLNAME"
        Me.EMP_NameCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EMP_NameCB.FormattingEnabled = True
        Me.EMP_NameCB.Location = New System.Drawing.Point(154, 8)
        Me.EMP_NameCB.Name = "EMP_NameCB"
        Me.EMP_NameCB.Size = New System.Drawing.Size(558, 28)
        Me.EMP_NameCB.TabIndex = 0
        Me.EMP_NameCB.ValueMember = "ID"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ReportViewer2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 45)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1211, 531)
        Me.Panel2.TabIndex = 1
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer1.TabIndex = 0
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.RATINGS_ALLBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "HRSystem.Ratings.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(1211, 531)
        Me.ReportViewer2.TabIndex = 0
        '
        'dsRating
        '
        Me.dsRating.DataSetName = "dsRating"
        Me.dsRating.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RATINGS_ALLBindingSource
        '
        Me.RATINGS_ALLBindingSource.DataMember = "RATINGS_ALL"
        Me.RATINGS_ALLBindingSource.DataSource = Me.dsRating
        '
        'RATINGS_ALLTableAdapter
        '
        Me.RATINGS_ALLTableAdapter.ClearBeforeFill = True
        '
        'frmPrintRatings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1211, 576)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmPrintRatings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrintRatings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dsRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RATINGS_ALLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Relieve_CHK As CheckBox
    Friend WithEvents Assigned_CHK As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents EMP_NameCB As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RATINGS_ALLBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsRating As HRSystem.DsRatingDataSet
    Friend WithEvents RATINGS_ALLTableAdapter As HRSystem.dsRatingTableAdapters.RATINGS_ALLTableAdapter
End Class
