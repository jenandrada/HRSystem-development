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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Explanation_LBL = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Acknowledge_LBL = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Correction_LBL = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Pending_Panel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.Pending_Panel.Controls.Add(Me.Label7)
        Me.Pending_Panel.Controls.Add(Me.Explanation_LBL)
        Me.Pending_Panel.Controls.Add(Me.Label2)
        Me.Pending_Panel.Location = New System.Drawing.Point(92, 74)
        Me.Pending_Panel.Name = "Pending_Panel"
        Me.Pending_Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.Pending_Panel.Size = New System.Drawing.Size(212, 145)
        Me.Pending_Panel.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(57, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 23)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Explanation"
        '
        'Explanation_LBL
        '
        Me.Explanation_LBL.AutoSize = True
        Me.Explanation_LBL.Font = New System.Drawing.Font("Kristen ITC", 20.0!)
        Me.Explanation_LBL.Location = New System.Drawing.Point(91, 77)
        Me.Explanation_LBL.Name = "Explanation_LBL"
        Me.Explanation_LBL.Size = New System.Drawing.Size(31, 36)
        Me.Explanation_LBL.TabIndex = 1
        Me.Explanation_LBL.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Waiting for "
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
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.Thistle
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Acknowledge_LBL)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(394, 74)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(212, 145)
        Me.Panel1.TabIndex = 4
        '
        'Acknowledge_LBL
        '
        Me.Acknowledge_LBL.AutoSize = True
        Me.Acknowledge_LBL.Font = New System.Drawing.Font("Kristen ITC", 20.0!)
        Me.Acknowledge_LBL.Location = New System.Drawing.Point(91, 77)
        Me.Acknowledge_LBL.Name = "Acknowledge_LBL"
        Me.Acknowledge_LBL.Size = New System.Drawing.Size(31, 36)
        Me.Acknowledge_LBL.TabIndex = 1
        Me.Acknowledge_LBL.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(63, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Waiting to"
        '
        'Panel2
        '
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Correction_LBL)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(691, 74)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel2.Size = New System.Drawing.Size(212, 145)
        Me.Panel2.TabIndex = 4
        '
        'Correction_LBL
        '
        Me.Correction_LBL.AutoSize = True
        Me.Correction_LBL.Font = New System.Drawing.Font("Kristen ITC", 20.0!)
        Me.Correction_LBL.Location = New System.Drawing.Point(91, 77)
        Me.Correction_LBL.Name = "Correction_LBL"
        Me.Correction_LBL.Size = New System.Drawing.Size(31, 36)
        Me.Correction_LBL.TabIndex = 1
        Me.Correction_LBL.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(56, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Waiting for "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(54, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 23)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Acknowledge"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(35, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(159, 23)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Correction Action"
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 749)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Pending_Panel)
        Me.Controls.Add(Me.Close_BTN)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDashboard"
        Me.Text = "frmDashboard"
        Me.Pending_Panel.ResumeLayout(False)
        Me.Pending_Panel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Close_BTN As Button
    Friend WithEvents Pending_Panel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Explanation_LBL As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Acknowledge_LBL As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Correction_LBL As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
