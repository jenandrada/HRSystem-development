Imports Microsoft.Office.Interop

Public Class frmUploadAddress
    Const INTEGRITY_CHECK As String = "g22+HZKQjjB8aGnE4MERrjci/PB4CbeQ9iV/Y+D/6C9ml9k+bbhOoA=="

    Private Sub btnUpload_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpload.Click
        'lvLayAway.Items.Clear()
        ofdAddress.ShowDialog()

        Dim fileName As String = ofdAddress.FileName
        Dim isDone As Boolean = False

        If String.IsNullOrEmpty(fileName) Then Exit Sub
        txtPath.Text = fileName

        'Load Excel
        Dim oXL As New Excel.Application
        Dim oWB As Excel.Workbook
        Dim oSheet As Excel.Worksheet

        oWB = oXL.Workbooks.Open(fileName)
        oSheet = oWB.Worksheets(1)

        Dim MaxColumn As Integer = oSheet.Cells(1, oSheet.Columns.Count).End(Excel.XlDirection.xlToLeft).column
        Dim MaxEntries As Integer = oSheet.Cells(oSheet.Rows.Count, 1).End(Excel.XlDirection.xlUp).row

        pbProgress.Maximum = MaxEntries
        Dim checkHeaders(MaxColumn) As String
        For cnt As Integer = 0 To MaxColumn - 1
            checkHeaders(cnt) = oSheet.Cells(1, cnt + 1).value
        Next : checkHeaders(MaxColumn) = oWB.Worksheets(1).name

        If Not TemplateCheck(checkHeaders) Then
            MsgBox("Wrong File or Template was tampered", MsgBoxStyle.Critical, "Error")
            GoTo unloadObj
        End If

        btnUpload.Enabled = False
        Dim tmpAddress As Address
        For cnt = 2 To MaxEntries
            tmpAddress = New Address
            With tmpAddress
                .Province = oSheet.Cells(cnt, 1).Value
                .CityMun = oSheet.Cells(cnt, 2).Value
                .Barangay = oSheet.Cells(cnt, 3).Value
                .SaveAddress()
            End With
            pbProgress.Value = cnt
            lblStatus.Text = String.Format("{0}%", ((pbProgress.Value / pbProgress.Maximum) * 100).ToString("F2"))
            Application.DoEvents()
        Next
        btnUpload.Enabled = True
        isDone = True

unloadObj:
        'Memory Unload
        oSheet = Nothing
        oWB = Nothing
        oXL.Quit()
        oXL = Nothing

        fileName = ""
        If isDone Then MsgBox("Address Loaded", MsgBoxStyle.Information, "System")
    End Sub

    Private Function TemplateCheck(ByVal headers() As String) As Boolean
        Dim mergeHeaders As String = ""
        For Each head In headers
            mergeHeaders &= head
        Next
        Console.WriteLine("Template " & HashString(mergeHeaders))
        If HashString(mergeHeaders) = INTEGRITY_CHECK Then Return True
        Return False
    End Function

End Class