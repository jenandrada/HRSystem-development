Imports System.Drawing.Imaging

Public Class Archive

    Private Sub SelectImg_BTN_Click(sender As Object, e As EventArgs) Handles SelectImg_BTN.Click
        Using OpenF As New OpenFileDialog
            Dim codecs As ImageCodecInfo() = ImageCodecInfo.GetImageEncoders()
            Dim sep As String = String.Empty
            With OpenF
                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                .Title = "Save As Image"
                .DefaultExt = ".JPG"
                .Filter = ""
                .FilterIndex = 2
                .RestoreDirectory = True
                .FileName = "*.JPG"
            End With
            For Each c As ImageCodecInfo In codecs
                Dim codecName As String = c.CodecName.Substring(8).Replace("Codec", "Files").Trim()
                OpenF.Filter = $"{OpenF.Filter }{sep }{codecName } ({c.FilenameExtension })|{c.FilenameExtension }"
                sep = "|"
            Next
            If OpenF.ShowDialog = DialogResult.OK Then
                Path_TXT.Text = OpenF.FileName
                ImageToSave.Image = Image.FromFile(Path_TXT.Text)
            End If
        End Using
    End Sub

    Private Sub SaveImage_BTN_Click(sender As Object, e As EventArgs) Handles SaveImage_BTN.Click
        Dim f As Form = Application.OpenForms("frmEmployeeDetails")
        Try
            Select Case Text
                Case "SSS ID Number"
                    CType(f, frmEmployeeDetails).SSSID_PB.Image = Image.FromFile(Path_TXT.Text)
                    CType(f, frmEmployeeDetails).SSSID_PB.Tag = Path_TXT.Text
                    CType(f, frmEmployeeDetails).SSSID_PB.SizeMode = PictureBoxSizeMode.StretchImage
                    CType(f, frmEmployeeDetails).SSSID_PB.Visible = True
                    CType(f, frmEmployeeDetails).SSSID_TXT.ReadOnly = False

                Case "PhilHealth ID Number"
                    CType(f, frmEmployeeDetails).PhilHealth_PB.Image = Image.FromFile(Path_TXT.Text)
                    CType(f, frmEmployeeDetails).PhilHealth_PB.Tag = Path_TXT.Text
                    CType(f, frmEmployeeDetails).PhilHealth_PB.SizeMode = PictureBoxSizeMode.StretchImage
                    CType(f, frmEmployeeDetails).PhilHealth_PB.Visible = True
                    CType(f, frmEmployeeDetails).PHealthID_TXT.ReadOnly = False

                Case "Pag-Ibig ID Number"
                    CType(f, frmEmployeeDetails).PagIbig_PB.Image = Image.FromFile(Path_TXT.Text)
                    CType(f, frmEmployeeDetails).PagIbig_PB.Tag = Path_TXT.Text
                    CType(f, frmEmployeeDetails).PagIbig_PB.SizeMode = PictureBoxSizeMode.StretchImage
                    CType(f, frmEmployeeDetails).PagIbig_PB.Visible = True
                    CType(f, frmEmployeeDetails).PIbigID_TXT.ReadOnly = False

                Case "Tax Identification Number"
                    CType(f, frmEmployeeDetails).TIN_PB.Image = Image.FromFile(Path_TXT.Text)
                    CType(f, frmEmployeeDetails).TIN_PB.Tag = Path_TXT.Text
                    CType(f, frmEmployeeDetails).TIN_PB.SizeMode = PictureBoxSizeMode.StretchImage
                    CType(f, frmEmployeeDetails).TIN_PB.Visible = True
                    CType(f, frmEmployeeDetails).TIN_TXT.ReadOnly = False

                Case "Barangay Clearance"
                    CType(f, frmEmployeeDetails).BClearance_PB.Image = Image.FromFile(Path_TXT.Text)
                    CType(f, frmEmployeeDetails).BClearance_PB.Tag = Path_TXT.Text
                    CType(f, frmEmployeeDetails).BClearance_PB.SizeMode = PictureBoxSizeMode.StretchImage
                    CType(f, frmEmployeeDetails).BClearance_PB.Visible = True
                    CType(f, frmEmployeeDetails).BrgClearance_CHK.Checked = True

                Case "Cedula"
                    CType(f, frmEmployeeDetails).Cedula_PB.Image = Image.FromFile(Path_TXT.Text)
                    CType(f, frmEmployeeDetails).Cedula_PB.Tag = Path_TXT.Text
                    CType(f, frmEmployeeDetails).Cedula_PB.SizeMode = PictureBoxSizeMode.StretchImage
                    CType(f, frmEmployeeDetails).Cedula_PB.Visible = True
                    CType(f, frmEmployeeDetails).Cedula_CHK.Checked = True

                Case "Police Clearance"
                    CType(f, frmEmployeeDetails).PClearance_PB.Image = Image.FromFile(Path_TXT.Text)
                    CType(f, frmEmployeeDetails).PClearance_PB.Tag = Path_TXT.Text
                    CType(f, frmEmployeeDetails).PClearance_PB.SizeMode = PictureBoxSizeMode.StretchImage
                    CType(f, frmEmployeeDetails).PClearance_PB.Visible = True
                    CType(f, frmEmployeeDetails).PClearance_CHK.Checked = True

                Case "NBI Clearance"
                    CType(f, frmEmployeeDetails).NBIClearance_PB.Image = Image.FromFile(Path_TXT.Text)
                    CType(f, frmEmployeeDetails).NBIClearance_PB.Tag = Path_TXT.Text
                    CType(f, frmEmployeeDetails).NBIClearance_PB.SizeMode = PictureBoxSizeMode.StretchImage
                    CType(f, frmEmployeeDetails).NBIClearance_PB.Visible = True
                    CType(f, frmEmployeeDetails).NBIClearance_CHK.Checked = True

                Case "Health Card"
                    CType(f, frmEmployeeDetails).HealthCard_PB.Image = Image.FromFile(Path_TXT.Text)
                    CType(f, frmEmployeeDetails).HealthCard_PB.Tag = Path_TXT.Text
                    CType(f, frmEmployeeDetails).HealthCard_PB.SizeMode = PictureBoxSizeMode.StretchImage
                    CType(f, frmEmployeeDetails).HealthCard_PB.Visible = True
                    CType(f, frmEmployeeDetails).HealthCard_CHK.Checked = True

                Case "Mayor's Permit"
                    CType(f, frmEmployeeDetails).MayorsPermit_PB.Image = Image.FromFile(Path_TXT.Text)
                    CType(f, frmEmployeeDetails).MayorsPermit_PB.Tag = Path_TXT.Text
                    CType(f, frmEmployeeDetails).MayorsPermit_PB.SizeMode = PictureBoxSizeMode.StretchImage
                    CType(f, frmEmployeeDetails).MayorsPermit_PB.Visible = True
                    CType(f, frmEmployeeDetails).MPermit_CHK.Checked = True

                Case "PDS"
                    CType(f, frmEmployeeDetails).PDS_PB.Image = Image.FromFile(Path_TXT.Text)
                    CType(f, frmEmployeeDetails).PDS_PB.Tag = Path_TXT.Text
                    CType(f, frmEmployeeDetails).PDS_PB.SizeMode = PictureBoxSizeMode.StretchImage
                    CType(f, frmEmployeeDetails).PDS_PB.Visible = True
                    CType(f, frmEmployeeDetails).PDS_CHK.Checked = True

                Case "PROBA"
                    CType(f, frmEmployeeDetails).PROBA_PB.Image = Image.FromFile(Path_TXT.Text)
                    CType(f, frmEmployeeDetails).PROBA_PB.Tag = Path_TXT.Text
                    CType(f, frmEmployeeDetails).PROBA_PB.SizeMode = PictureBoxSizeMode.StretchImage
                    CType(f, frmEmployeeDetails).PROBA_PB.Visible = True
                    CType(f, frmEmployeeDetails).PROBA_CHK.Checked = True

                Case "MOA"
                    CType(f, frmEmployeeDetails).MOA_PB.Image = Image.FromFile(Path_TXT.Text)
                    CType(f, frmEmployeeDetails).MOA_PB.Tag = Path_TXT.Text
                    CType(f, frmEmployeeDetails).MOA_PB.SizeMode = PictureBoxSizeMode.StretchImage
                    CType(f, frmEmployeeDetails).MOA_PB.Visible = True
                    CType(f, frmEmployeeDetails).MOA_CHK.Checked = True

                Case "ID Form"
                    CType(f, frmEmployeeDetails).IDForm_PB.Image = Image.FromFile(Path_TXT.Text)
                    CType(f, frmEmployeeDetails).IDForm_PB.Tag = Path_TXT.Text
                    CType(f, frmEmployeeDetails).IDForm_PB.SizeMode = PictureBoxSizeMode.StretchImage
                    CType(f, frmEmployeeDetails).IDForm_PB.Visible = True
                    CType(f, frmEmployeeDetails).IDForm_CHK.Checked = True

                Case "Acknowledgement Letter"
                    CType(f, frmEmployeeDetails).ALetter_PB.Image = Image.FromFile(Path_TXT.Text)
                    CType(f, frmEmployeeDetails).ALetter_PB.Tag = Path_TXT.Text
                    CType(f, frmEmployeeDetails).ALetter_PB.SizeMode = PictureBoxSizeMode.StretchImage
                    CType(f, frmEmployeeDetails).ALetter_PB.Visible = True
                    CType(f, frmEmployeeDetails).ALetter_CHK.Checked = True

                Case "Endorsement Letter"
                    CType(f, frmEmployeeDetails).ELetter_PB.Image = Image.FromFile(Path_TXT.Text)
                    CType(f, frmEmployeeDetails).ELetter_PB.Tag = Path_TXT.Text
                    CType(f, frmEmployeeDetails).ELetter_PB.SizeMode = PictureBoxSizeMode.StretchImage
                    CType(f, frmEmployeeDetails).ELetter_PB.Visible = True
                    CType(f, frmEmployeeDetails).ELetter_CHK.Checked = True

                Case "View Image"
                    CType(f, frmEmployeeDetails).EmpProfile_Pic.Image = Image.FromFile(Path_TXT.Text)
                    CType(f, frmEmployeeDetails).EmpProfile_Pic.Tag = Path_TXT.Text
                    CType(f, frmEmployeeDetails).EmpProfile_Pic.SizeMode = PictureBoxSizeMode.StretchImage
                    CType(f, frmEmployeeDetails).EmpProfile_Pic.Visible = True
            End Select
            Close()
        Catch ex As Exception
            MessageBox.Show($"{ex.Message}{vbCrLf} Please try again", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Path_TXT_TextChanged(sender As Object, e As EventArgs) Handles Path_TXT.TextChanged
        Try
            ImageToSave.Image = Image.FromFile(Path_TXT.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class