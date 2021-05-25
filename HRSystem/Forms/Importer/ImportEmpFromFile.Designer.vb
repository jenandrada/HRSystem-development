<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ImportEmpFromFile
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
        Me.ImportProgress_PB = New DBConnect.CustomControls.TextProgressBar()
        Me.Progress_LBL = New System.Windows.Forms.Label()
        Me.OpenFile_BTN = New System.Windows.Forms.Button()
        Me.Import_BTN = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Path_TXT = New System.Windows.Forms.TextBox()
        Me.TempPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.TempPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImportProgress_PB
        '
        Me.ImportProgress_PB.CustomText = ""
        Me.ImportProgress_PB.Location = New System.Drawing.Point(12, 123)
        Me.ImportProgress_PB.Name = "ImportProgress_PB"
        Me.ImportProgress_PB.ProgressColor = System.Drawing.Color.LightGreen
        Me.ImportProgress_PB.Size = New System.Drawing.Size(714, 23)
        Me.ImportProgress_PB.TabIndex = 0
        Me.ImportProgress_PB.TextColor = System.Drawing.Color.Black
        Me.ImportProgress_PB.TextFont = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.ImportProgress_PB.VisualMode = DBConnect.CustomControls.ProgressBarDisplayMode.Percentage
        '
        'Progress_LBL
        '
        Me.Progress_LBL.AutoEllipsis = True
        Me.Progress_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Progress_LBL.Location = New System.Drawing.Point(12, 97)
        Me.Progress_LBL.Name = "Progress_LBL"
        Me.Progress_LBL.Size = New System.Drawing.Size(714, 23)
        Me.Progress_LBL.TabIndex = 1
        '
        'OpenFile_BTN
        '
        Me.OpenFile_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenFile_BTN.Location = New System.Drawing.Point(12, 7)
        Me.OpenFile_BTN.Name = "OpenFile_BTN"
        Me.OpenFile_BTN.Size = New System.Drawing.Size(100, 33)
        Me.OpenFile_BTN.TabIndex = 2
        Me.OpenFile_BTN.Text = "Open File"
        Me.OpenFile_BTN.UseVisualStyleBackColor = True
        '
        'Import_BTN
        '
        Me.Import_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Import_BTN.Location = New System.Drawing.Point(118, 7)
        Me.Import_BTN.Name = "Import_BTN"
        Me.Import_BTN.Size = New System.Drawing.Size(100, 33)
        Me.Import_BTN.TabIndex = 3
        Me.Import_BTN.Text = "Import"
        Me.Import_BTN.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Path"
        '
        'Path_TXT
        '
        Me.Path_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Path_TXT.Location = New System.Drawing.Point(12, 68)
        Me.Path_TXT.Name = "Path_TXT"
        Me.Path_TXT.Size = New System.Drawing.Size(714, 26)
        Me.Path_TXT.TabIndex = 5
        '
        'TempPictureBox
        '
        Me.TempPictureBox.Location = New System.Drawing.Point(626, 7)
        Me.TempPictureBox.Name = "TempPictureBox"
        Me.TempPictureBox.Size = New System.Drawing.Size(100, 50)
        Me.TempPictureBox.TabIndex = 6
        Me.TempPictureBox.TabStop = False
        Me.TempPictureBox.Visible = False
        '
        'ImportEmpFromFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 158)
        Me.Controls.Add(Me.TempPictureBox)
        Me.Controls.Add(Me.Path_TXT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Import_BTN)
        Me.Controls.Add(Me.OpenFile_BTN)
        Me.Controls.Add(Me.Progress_LBL)
        Me.Controls.Add(Me.ImportProgress_PB)
        Me.Name = "ImportEmpFromFile"
        Me.Text = "Import EmpFrom File"
        CType(Me.TempPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImportProgress_PB As DBConnect.CustomControls.TextProgressBar
    Friend WithEvents Progress_LBL As Label
    Friend WithEvents OpenFile_BTN As Button
    Friend WithEvents Import_BTN As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Path_TXT As TextBox
    Friend WithEvents TempPictureBox As PictureBox
End Class
