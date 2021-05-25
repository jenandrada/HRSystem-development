<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReport))
        Me.RATINGS_ALLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsRating = New HRSystem.DsRatingDataSet()
        Me.rv_display = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.RATINGS_ALLTableAdapter = New HRSystem.dsRatingTableAdapters.RATINGS_ALLTableAdapter()
        CType(Me.RATINGS_ALLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsRating, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RATINGS_ALLBindingSource
        '
        Me.RATINGS_ALLBindingSource.DataMember = "RATINGS_ALL"
        Me.RATINGS_ALLBindingSource.DataSource = Me.dsRating
        '
        'dsRating
        '
        Me.dsRating.DataSetName = "dsRating"
        Me.dsRating.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rv_display
        '
        Me.rv_display.AutoSize = True
        Me.rv_display.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsrating"
        ReportDataSource1.Value = Me.RATINGS_ALLBindingSource
        Me.rv_display.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rv_display.LocalReport.ReportEmbeddedResource = "HRSystem.rpt_Rating.rdlc"
        Me.rv_display.Location = New System.Drawing.Point(0, 0)
        Me.rv_display.Name = "rv_display"
        Me.rv_display.ServerReport.BearerToken = Nothing
        Me.rv_display.Size = New System.Drawing.Size(1370, 657)
        Me.rv_display.TabIndex = 0
        '
        'RATINGS_ALLTableAdapter
        '
        Me.RATINGS_ALLTableAdapter.ClearBeforeFill = True
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 657)
        Me.Controls.Add(Me.rv_display)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Viewer"
        CType(Me.RATINGS_ALLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsRating, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rv_display As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RATINGS_ALLBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsRating As HRSystem.DsRatingDataSet
    Friend WithEvents RATINGS_ALLTableAdapter As HRSystem.dsRatingTableAdapters.RATINGS_ALLTableAdapter
End Class
