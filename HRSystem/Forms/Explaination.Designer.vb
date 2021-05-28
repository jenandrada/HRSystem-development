<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Explaination
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
        Me.Close_Modify_BTN = New System.Windows.Forms.Button()
        Me.Check_BTN = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Close_Modify_BTN
        '
        Me.Close_Modify_BTN.Font = New System.Drawing.Font("Dubai", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Close_Modify_BTN.Location = New System.Drawing.Point(29, 530)
        Me.Close_Modify_BTN.Name = "Close_Modify_BTN"
        Me.Close_Modify_BTN.Size = New System.Drawing.Size(93, 44)
        Me.Close_Modify_BTN.TabIndex = 83
        Me.Close_Modify_BTN.Text = "X"
        Me.Close_Modify_BTN.UseVisualStyleBackColor = True
        '
        'Check_BTN
        '
        Me.Check_BTN.Font = New System.Drawing.Font("Dubai", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check_BTN.Location = New System.Drawing.Point(747, 530)
        Me.Check_BTN.Name = "Check_BTN"
        Me.Check_BTN.Size = New System.Drawing.Size(93, 44)
        Me.Check_BTN.TabIndex = 82
        Me.Check_BTN.Text = "√"
        Me.Check_BTN.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(27, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(811, 502)
        Me.PictureBox1.TabIndex = 81
        Me.PictureBox1.TabStop = False
        '
        'Explaination
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 587)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Close_Modify_BTN)
        Me.Controls.Add(Me.Check_BTN)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Explaination"
        Me.Text = "Explaination"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Close_Modify_BTN As Button
    Friend WithEvents Check_BTN As Button
End Class
