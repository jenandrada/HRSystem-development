<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Archive
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SaveImage_BTN = New System.Windows.Forms.Button()
        Me.Path_TXT = New System.Windows.Forms.TextBox()
        Me.SelectImg_BTN = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ImageToSave = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ImageToSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SaveImage_BTN)
        Me.Panel1.Controls.Add(Me.Path_TXT)
        Me.Panel1.Controls.Add(Me.SelectImg_BTN)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(840, 43)
        Me.Panel1.TabIndex = 0
        '
        'SaveImage_BTN
        '
        Me.SaveImage_BTN.Location = New System.Drawing.Point(10, 6)
        Me.SaveImage_BTN.Name = "SaveImage_BTN"
        Me.SaveImage_BTN.Size = New System.Drawing.Size(110, 30)
        Me.SaveImage_BTN.TabIndex = 2
        Me.SaveImage_BTN.Text = "Save Image"
        Me.SaveImage_BTN.UseVisualStyleBackColor = True
        '
        'Path_TXT
        '
        Me.Path_TXT.Location = New System.Drawing.Point(276, 8)
        Me.Path_TXT.Name = "Path_TXT"
        Me.Path_TXT.Size = New System.Drawing.Size(552, 26)
        Me.Path_TXT.TabIndex = 0
        '
        'SelectImg_BTN
        '
        Me.SelectImg_BTN.Location = New System.Drawing.Point(126, 6)
        Me.SelectImg_BTN.Name = "SelectImg_BTN"
        Me.SelectImg_BTN.Size = New System.Drawing.Size(144, 30)
        Me.SelectImg_BTN.TabIndex = 1
        Me.SelectImg_BTN.Text = "Select Image"
        Me.SelectImg_BTN.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.ImageToSave)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 43)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(840, 676)
        Me.Panel2.TabIndex = 1
        '
        'ImageToSave
        '
        Me.ImageToSave.InitialImage = Global.HRSystem.My.Resources.Resources.add_image_50px
        Me.ImageToSave.Location = New System.Drawing.Point(11, 11)
        Me.ImageToSave.Name = "ImageToSave"
        Me.ImageToSave.Size = New System.Drawing.Size(818, 654)
        Me.ImageToSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ImageToSave.TabIndex = 0
        Me.ImageToSave.TabStop = False
        '
        'Archive
        '
        Me.AcceptButton = Me.SaveImage_BTN
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 719)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Archive"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Archive"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ImageToSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SelectImg_BTN As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ImageToSave As PictureBox
    Friend WithEvents Path_TXT As TextBox
    Friend WithEvents SaveImage_BTN As Button
End Class
