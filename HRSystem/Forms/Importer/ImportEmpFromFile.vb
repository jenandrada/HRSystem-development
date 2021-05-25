Imports System.Drawing.Imaging
Imports System.Globalization
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Threading.Tasks
Imports FirebirdSql.Data.FirebirdClient
Imports Microsoft.Office.Interop

Public Class ImportEmpFromFile
    Const FileIntegrity As String = "Iys1VyFQO26AVnU/1kqPRrn1uTgA1yUEd11xYfXmleif+xHxp/DGJa/2oICmWM8GNobpiCPRr0leiujSU4A1F8AA6+kB0hFpQsV2QgeMBp2uFF39TEVVNx1h47jEsX9/lgJb2/QINet7xQjTkH+AavDC89WceMEZOaJk7o4rMp4LC3feSjZV0dSKNi9iZkgMA0V6CUisOGxVzpVhn2td5dHCg1AQ/ktsU3AlKWvRJ+gFpKp4rXSZ31qxT3Zfsz2jDH1MW0ZZuIoM4frXyyw+R0i1M4tLq8BTARkA8rrh9n9wkN/uKmvkUWHKy03ncanze0GEpkijZqY="

    Dim oXL As New Excel.Application
    Dim oWB As Excel.Workbook = Nothing
    Dim oSheet As Excel.Worksheet = Nothing

    Private Function ExcelFilePath(ByVal filePath As String) As String
        DefaultFolder = Path.GetDirectoryName(filePath)
        TargetFile = filePath
        Return TargetFile
    End Function

    Private Sub OpenFile_BTN_Click(sender As Object, e As EventArgs) Handles OpenFile_BTN.Click
        Using f As New OpenFileDialog
            f.Filter = "Excel 2003|*.xls|Excel 2007|*.xlsx"
            If DialogResult.OK = f.ShowDialog() Then
                Path_TXT.Text = f.FileName
                ExcelFilePath(Path_TXT.Text)
            End If
        End Using

    End Sub

    Private Function TemplateIntegrityCheck(ByVal headers() As String) As Boolean
        Dim mergeHeaders As String = ""
        For Each head In headers

            mergeHeaders &= head

        Next
        If HashString(mergeHeaders) = FileIntegrity Then Return True
        Return False
    End Function

    Dim imgData As Byte()

    Private Function ImgToByteArray(img As Image, imgFormat As ImageFormat) As Byte()
        Dim tmpData As Byte()
        If img IsNot Nothing Then
            Dim BufferImage As Bitmap = New Bitmap(img)
            Dim ms As MemoryStream = New MemoryStream
            BufferImage.Save(ms, imgFormat)
            BufferImage.Dispose()
            tmpData = ms.ToArray
            ms.Dispose()
        End If
        Return tmpData
    End Function

    Private Sub Import_BTN_Click(sender As Object, e As EventArgs) Handles Import_BTN.Click

        Task.Run(
            Sub()
                imgData = ImgToByteArray(TempPictureBox.InitialImage, ImageFormat.Jpeg)
                If ExcelTargetDirectoryIsValid() = False Then Exit Sub

                Dim hash = InputBox("HOT CODE", "ENTER HOT CODE")

                If hash = "" Then
                    MsgBox("Template was tampered", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If

                If MatchHotCode(hash, Path_TXT.Text) = False Then
                    MsgBox("Invalid HOTCODE", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If

                oWB = oXL.Workbooks.Open(Path_TXT.Text)
                oSheet = oWB.Worksheets(1)
                oXL.Visible = False
                Try
                    Dim MaxColumn As Integer = oSheet.Cells(1, oSheet.Columns.Count).End(Excel.XlDirection.xlToLeft).column
                    Dim MaxEntries As Integer = oSheet.Cells(oSheet.Rows.Count, 1).End(Excel.XlDirection.xlUp).row

                    Dim checkHeaders(MaxColumn) As String
                    For cnt As Integer = 0 To MaxColumn
                        checkHeaders(cnt) = oSheet.Cells(1, cnt + 1).value
                    Next : checkHeaders(MaxColumn) = oWB.Worksheets(1).name

                    If TemplateIntegrityCheck(checkHeaders) Then
                        OpenFile_BTN.Invoke(
                        New Action(
                        Sub()
                            OpenFile_BTN.Enabled = False
                        End Sub))
                        Import_BTN.Invoke(
                        New Action(
                        Sub()
                            Import_BTN.Enabled = False
                        End Sub))
                        Path_TXT.Invoke(
                        New Action(
                        Sub()
                            Path_TXT.Enabled = False
                        End Sub))
                        For cnt = 2 To MaxEntries
                            ImportProgress_PB.Invoke(
                            New Action(
                            Sub()
                                ImportProgress_PB.Maximum = MaxEntries
                            End Sub))
                            Dim tmpEmp As New employee
                            With tmpEmp
                                Progress_LBL.Invoke(
                                New Action(
                                Sub()
                                    Progress_LBL.Text = $"Importing - {oSheet.Cells(cnt, 3).Value.ToString} {oSheet.Cells(cnt, 1).Value.ToString} {oSheet.Cells(cnt, 2).Value.ToString}"
                                End Sub))
                                If Not oSheet.Cells(cnt, 1).Value?.ToString = Nothing Then
                                    .FirstName = oSheet.Cells(cnt, 1).Value.ToString
                                ElseIf oSheet.Cells(cnt, 1).Value?.ToString = Nothing Then
                                    .FirstName = ""
                                End If
                                If Not oSheet.Cells(cnt, 2).Value?.ToString = Nothing Then
                                    .MiddleName = oSheet.Cells(cnt, 2).Value.ToString
                                ElseIf oSheet.Cells(cnt, 2).Value?.ToString = Nothing Then
                                    .MiddleName = ""
                                End If

                                If Not oSheet.Cells(cnt, 3).Value?.ToString = Nothing Then
                                    .LastName = oSheet.Cells(cnt, 3).Value.ToString
                                ElseIf oSheet.Cells(cnt, 3).Value?.ToString = Nothing Then
                                    .LastName = ""
                                End If

                                If Not oSheet.Cells(cnt, 4).Value?.ToString = Nothing Then
                                    .Suffix = oSheet.Cells(cnt, 4).Value.ToString
                                ElseIf oSheet.Cells(cnt, 4).Value?.ToString = Nothing Then
                                    .Suffix = ""
                                End If
                                If Not oSheet.Cells(cnt, 5).Value?.ToString = Nothing Then
                                    .DateofBirth = oSheet.Cells(cnt, 5).Value.ToString
                                ElseIf oSheet.Cells(cnt, 5).Value?.ToString = Nothing Then
                                    .DateofBirth = ""
                                End If
                                If oSheet.Cells(cnt, 6).Value?.ToString.ToUpper(CultureInfo.CurrentCulture) = "M" Then
                                    .Sex = "Male"
                                ElseIf oSheet.Cells(cnt, 6).Value?.ToString.ToUpper(CultureInfo.CurrentCulture) = "F" Then
                                    .Sex = "Female"
                                ElseIf Not oSheet.Cells(cnt, 6).Value?.ToString.ToUpper(CultureInfo.CurrentCulture) = "F" Or Not oSheet.Cells(cnt, 6).Value.ToString.ToUpper(CultureInfo.CurrentCulture) = "M" Then
                                    .Sex = ""
                                ElseIf oSheet.Cells(cnt, 6).Value?.ToString = Nothing Then
                                    .Sex = ""
                                End If

                                If oSheet.Cells(cnt, 7).Value?.ToString.ToUpper(CultureInfo.CurrentCulture) = "S" Then
                                    .CivilStatus = "Single"
                                ElseIf oSheet.Cells(cnt, 7).Value?.ToString.ToUpper(CultureInfo.CurrentCulture) = "W" Then
                                    .CivilStatus = "Widowed"
                                ElseIf oSheet.Cells(cnt, 7).Value?.ToString.ToUpper(CultureInfo.CurrentCulture) = "M" Then
                                    .CivilStatus = "Married"
                                ElseIf oSheet.Cells(cnt, 7).Value?.ToString.ToUpper(CultureInfo.CurrentCulture) = "D" Then
                                    .CivilStatus = "Divorced"
                                ElseIf Not oSheet.Cells(cnt, 7).Value?.ToString = Nothing Then
                                    .CivilStatus = oSheet.Cells(cnt, 7).Value?.ToString
                                ElseIf oSheet.Cells(cnt, 7).Value?.ToString = Nothing Then
                                    .CivilStatus = ""
                                End If
                                If Not oSheet.Cells(cnt, 8).Value?.ToString = Nothing Then
                                    .PermanentAddressID = oSheet.Cells(cnt, 8).Value.ToString
                                ElseIf oSheet.Cells(cnt, 8).Value?.ToString = Nothing Then
                                    .PermanentAddressID = 0
                                End If
                                If Not oSheet.Cells(cnt, 9).Value?.ToString = Nothing Then
                                    .PermanentStreet = oSheet.Cells(cnt, 9).Value.ToString
                                ElseIf oSheet.Cells(cnt, 9).Value?.ToString = Nothing Then
                                    .PermanentStreet = ""
                                End If
                                If Not oSheet.Cells(cnt, 10).Value?.ToString = Nothing Then
                                    .PresentAddressID = oSheet.Cells(cnt, 10).Value.ToString
                                ElseIf oSheet.Cells(cnt, 10).Value?.ToString = Nothing Then
                                    .PresentAddressID = 0
                                End If

                                If Not oSheet.Cells(cnt, 11).Value?.ToString = Nothing Then
                                    .PresentStreet = oSheet.Cells(cnt, 11).Value.ToString
                                ElseIf oSheet.Cells(cnt, 11).Value?.ToString = Nothing Then
                                    .PresentStreet = ""
                                End If
                                If Not oSheet.Cells(cnt, 12).Value?.ToString = Nothing Then
                                    .EmailAddress = oSheet.Cells(cnt, 12).Value.ToString
                                ElseIf oSheet.Cells(cnt, 12).Value?.ToString = Nothing Then
                                    .EmailAddress = ""
                                End If

                                If Not oSheet.Cells(cnt, 13).Value?.ToString = Nothing Then
                                    .DateHired = oSheet.Cells(cnt, 13).Value.ToString
                                ElseIf oSheet.Cells(cnt, 13).Value?.ToString = Nothing Then
                                    .DateHired = ""
                                End If

                                If Not oSheet.Cells(cnt, 14).Value?.ToString = Nothing Then
                                    .BiometricID = oSheet.Cells(cnt, 14).Value.ToString
                                ElseIf oSheet.Cells(cnt, 14).Value?.ToString = Nothing Then
                                    .BiometricID = 0
                                End If
                                If Not oSheet.Cells(cnt, 15).Value?.ToString = Nothing Then
                                    .ContactNumber = oSheet.Cells(cnt, 15).Value.ToString
                                ElseIf oSheet.Cells(cnt, 15).Value?.ToString Is Nothing Then
                                    .ContactNumber = ""
                                End If
                                If Not oSheet.Cells(cnt, 16).Value?.ToString Is Nothing Then
                                    .BIRate = oSheet.Cells(cnt, 16).Value.ToString
                                ElseIf oSheet.Cells(cnt, 16).Value?.ToString = Nothing Then
                                    .BIRate = 0
                                End If
                                If Not oSheet.Cells(cnt, 17).Value?.ToString = Nothing Then
                                    .BIRemarks = oSheet.Cells(cnt, 17).Value.ToString
                                ElseIf oSheet.Cells(cnt, 17).Value?.ToString = Nothing Then
                                    .BIRemarks = ""
                                End If
                                If Not oSheet.Cells(cnt, 18).Value?.ToString = Nothing Then
                                    .SSSNumber = oSheet.Cells(cnt, 18).Value.ToString
                                ElseIf oSheet.Cells(cnt, 18).Value?.ToString = Nothing Then
                                    .SSSNumber = ""
                                End If
                                If Not oSheet.Cells(cnt, 19).Value?.ToString = Nothing Then
                                    .PhilhealthNumber = oSheet.Cells(cnt, 19).Value.ToString
                                ElseIf oSheet.Cells(cnt, 19).Value?.ToString = Nothing Then
                                    .PhilhealthNumber = ""
                                End If
                                If Not oSheet.Cells(cnt, 20).Value?.ToString = Nothing Then
                                    .TINNumber = oSheet.Cells(cnt, 20).Value.ToString
                                ElseIf oSheet.Cells(cnt, 20).Value?.ToString = Nothing Then
                                    .TINNumber = ""
                                End If
                                If Not oSheet.Cells(cnt, 21).Value?.ToString = Nothing Then
                                    .Status = oSheet.Cells(cnt, 21).Value.ToString
                                ElseIf oSheet.Cells(cnt, 21).Value?.ToString = Nothing Then
                                    .Status = ""
                                End If
                                If Not oSheet.Cells(cnt, 22).Value?.ToString = Nothing Then
                                    .Remarks = oSheet.Cells(cnt, 22).Value.ToString
                                ElseIf oSheet.Cells(cnt, 22).Value?.ToString = Nothing Then
                                    .Remarks = ""
                                End If
                                If Not oSheet.Cells(cnt, 23).Value?.ToString = Nothing Then
                                    .pagibignumber = oSheet.Cells(cnt, 23).Value.ToString
                                ElseIf oSheet.Cells(cnt, 23).Value?.ToString = Nothing Then
                                    .pagibignumber = ""
                                End If

                                .SaveEmployee()

                                Dim mySql As String = "SELECT MAX(ID) AS employid FROM TBL_employee"
                                Using dsxx As DataSet = LoadSQL(mySql)
                                    Dim a As Integer = CDbl(dsxx.Tables(0).Rows(0).Item("employid"))

                                    .employid = a
                                    '.SaveProfilePic(a, imgData) '--------------jen
                                End Using

                                Dim i As New Integer
                                Dim ix As New Integer
                                Dim sql As String = "select max(ID) as ID from tbl_employee rows 1"
                                DbReaderOpen()
                                Using dr As FbDataReader = LoadSQL_byDataReader(sql)
                                    While dr.Read()
                                        If dr.HasRows Then
                                            With dr
                                                i = .Item(0).ToString
                                            End With
                                        End If
                                    End While
                                End Using

                                .employid = i
                                .SAVE_REQUIREMENTS()

                                Dim sqlx As String = "select max(REQ_ID) as REQ_ID from TBL_REQ rows 1"
                                DbReaderOpen()
                                Using drx As FbDataReader = LoadSQL_byDataReader(sqlx)
                                    While drx.Read()
                                        If drx.HasRows Then
                                            With drx
                                                ix = .Item("REQ_ID").ToString
                                            End With
                                        End If
                                    End While
                                End Using
                                .ReqID = ix
                                '.SaveReqArchive()
                            End With
                            ImportProgress_PB.Invoke(
                                 New Action(
                                 Sub()
                                     ImportProgress_PB.Value = cnt
                                     If ImportProgress_PB.Value = MaxEntries Then
                                         Progress_LBL.Invoke(
                                                    New Action(
                                                    Sub()
                                                        Progress_LBL.Text = "Done Importing!"
                                                        If MessageBox.Show("All data has been successfully imported", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
                                                            ImportProgress_PB.Value = 0
                                                            Progress_LBL.Text = ""
                                                        End If
                                                    End Sub))
                                     End If
                                 End Sub))
                        Next
                    End If

                    oSheet = Nothing
                    oWB.Close(True)
                    oXL.Quit()

                    ReleaseObject(oSheet)
                    ReleaseObject(oWB)
                    ReleaseObject(oXL)
                Catch ex As Exception

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Log_Report(ex.ToString)

                    oSheet = Nothing
                    oWB.Close(True)
                    oXL.Quit()

                    ReleaseObject(oSheet)
                    ReleaseObject(oWB)
                    ReleaseObject(oXL)

                End Try

            End Sub)
    End Sub

    Private Function MatchHotCode(ByVal str As String, ByVal path As String) As Boolean

        Dim fileByte() As Byte
        Dim tmp As String

        Dim fs As FileStream = File.OpenRead(path)
        fs.Position = 0

        fileByte = MD5.Create.ComputeHash(fs)
        tmp = Convert.ToBase64String(fileByte)
        fs.Dispose()
        fs.Close()

        If str = tmp Then Return True

        Return False

    End Function

    Private Function ReleaseObject(ByVal obj As Object) As Task

        Return Task.Run(
            Sub()
                Try
                    If obj IsNot Nothing Then
                        Marshal.ReleaseComObject(obj)
                        obj = Nothing
                    End If
                Catch ex As Exception
                    Log_Report(ex.ToString)
                    obj = Nothing
                    MessageBox.Show("Exception Occurred while releasing object " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    GC.Collect()
                End Try
            End Sub)

    End Function

    Private Sub ImportEmpFromFile_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        oSheet = Nothing
        oWB.Close(True)
        oXL.Quit()

        ReleaseObject(oSheet)
        ReleaseObject(oWB)
        ReleaseObject(oXL)
    End Sub

End Class