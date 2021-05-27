<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.Close_BTN = New System.Windows.Forms.Button()
        Me.Pending_Panel = New System.Windows.Forms.Panel()
        Me.PendingNo_LBL = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pending_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Close_BTN
        '
        Me.Close_BTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Close_BTN.Image = CType(resources.GetObject("Close_BTN.Image"), System.Drawing.Image)
        Me.Close_BTN.Location = New System.Drawing.Point(1150, 1)
        Me.Close_BTN.Name = "Close_BTN"
        Me.Close_BTN.Size = New System.Drawing.Size(30, 30)
        Me.Close_BTN.TabIndex = 1
        Me.Close_BTN.UseVisualStyleBackColor = True
        '
        'Pending_Panel
        '
        Me.Pending_Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Pending_Panel.BackColor = System.Drawing.Color.Pink
        Me.Pending_Panel.Controls.Add(Me.PendingNo_LBL)
        Me.Pending_Panel.Controls.Add(Me.Label2)
        Me.Pending_Panel.Location = New System.Drawing.Point(92, 74)
        Me.Pending_Panel.Name = "Pending_Panel"
        Me.Pending_Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.Pending_Panel.Size = New System.Drawing.Size(212, 145)
        Me.Pending_Panel.TabIndex = 3
        '
        'PendingNo_LBL
        '
        Me.PendingNo_LBL.AutoSize = True
        Me.PendingNo_LBL.Font = New System.Drawing.Font("Kristen ITC", 20.0!)
        Me.PendingNo_LBL.Location = New System.Drawing.Point(91, 77)
        Me.PendingNo_LBL.Name = "PendingNo_LBL"
        Me.PendingNo_LBL.Size = New System.Drawing.Size(31, 36)
        Me.PendingNo_LBL.TabIndex = 1
        Me.PendingNo_LBL.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Show Cause Pendings"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(0, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 37)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Dashboard"
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 749)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Pending_Panel)
        Me.Controls.Add(Me.Close_BTN)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDashboard"
        Me.Text = "frmDashboard"
        Me.Pending_Panel.ResumeLayout(False)
        Me.Pending_Panel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Close_BTN As Button
    Friend WithEvents Pending_Panel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PendingNo_LBL As Label
End Class
