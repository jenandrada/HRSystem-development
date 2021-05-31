Imports System.Drawing.Imaging
Imports System.IO

Module Selecting

    Dim imgData As Byte()

    Public Function ImgToByteArray(img As Image, imgFormat As ImageFormat) As Byte()
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

    Public Function ThisHasRow(table As String)
        Dim mysql As String = "Select * FROM " & table & ""
        Dim ds As DataSet = LoadSQL(mysql, table)
        If ds.Tables(0).Rows.Count > 0 Then
            Return True
        End If
        Return False
    End Function


    Public Sub GetLastNo(lastNo As Label, table As String, column As String)

        Dim mysql As String = $"Select MAX({column}) + 1  As Greatest FROM  { table }"
        Using ds As DataSet = LoadSQL(mysql)

            Dim dr As DataRow = ds.Tables(0).Rows(0)
            If dr.Table.Rows.Count > 0 Then
                With dr
                    lastNo.Text = Format(.Item("Greatest"), "00000")

                End With
            End If
        End Using
    End Sub


    Public Sub GreatestBiometric(textbox As TextBox)

        Dim mysql As String = "Select MAX(BIOMETRICID) + 1  As Greatest FROM tbl_Employee"
        Using ds As DataSet = LoadSQL(mysql)

            Dim dr As DataRow = ds.Tables(0).Rows(0)
            If dr.Table.Rows.Count > 0 Then
                With dr

                    'Dim year As String = DateHired_DTP.Value.ToString("yy")
                    'Dim month As String = DateHired_DTP.Value.ToString("MM")
                    'BioNumber_TXT.Text = year & "-0" & month & "-" & .Item("Greatest")
                    'BioNumber_TXT.Tag = .Item("Greatest")

                    textbox.Text = .Item("Greatest")
                End With
            Else
                Exit Sub
            End If
        End Using
    End Sub

    Public Sub SCPendings(SCNO As Label)

        Dim mysql As String = "Select Count(ID) as CountME FROM SHOWCAUSE_RECORDS where status = 'NO'"
        Using ds As DataSet = LoadSQL(mysql)

            Dim dr As DataRow = ds.Tables(0).Rows(0)
            If dr.Table.Rows.Count > 0 Then
                With dr
                    'Dim idx As Long = Format(.Item("Greatest"), "00000")
                    SCNO.Text = .Item("CountME")

                End With
            End If
        End Using

    End Sub


    Friend Sub Attachment(datagrid As DataGridView, status As String)
        datagrid.Rows.Clear()
        Dim mysql As String = "Select * From SHOWCAUSE_RECORDS inner join TBL_EMPLOYEE on TBL_EMPLOYEE.id = SHOWCAUSE_RECORDS.emp_id where SHOWCAUSE_RECORDS.status = '" & status & "'"
        Using ds As DataSet = LoadSQL(mysql, "SHOWCAUSE_RECORDS")
            If ds.Tables(0).Rows.Count > 0 Then
                For Each dr In ds.Tables(0).Rows
                    AddItem(dr, datagrid)
                Next

            End If
        End Using

    End Sub


    Public Sub AddItem(ByVal dr As DataRow, datagrid As DataGridView)

        Dim pb As New PictureBox
        Dim img As Image
        img = pb.ErrorImage
        imgData = ImgToByteArray(img, ImageFormat.Jpeg)

        With dr
            Dim MI As String
            If String.IsNullOrEmpty(.Item("MIDDLENAME")) Then
                MI = ""
            Else
                MI = .Item("MIDDLENAME").Substring(0, 1) & "."
            End If

            Dim datee As DateTime = CDate(.Item("DATE_DEADLINE"))
            'Dim num As Integer = .Item("SCNO")

            Dim rowId As Integer = datagrid.Rows.Add()
            Dim row As DataGridViewRow = datagrid.Rows(rowId)
            row.Cells("SCNO_DGV").Value = Format(.Item("SCNO"), "00000")
            row.Cells("Name_DGV").Value = .Item("LASTNAME") & ", " & .Item("FIRSTNAME") & " " & MI
            row.Cells("Company_DGV").Value = .Item("COMPANY")
            row.Cells("Deadline_DGV").Value = datee.ToString("D")
            row.Cells("File_DGV").Value = "Open"
            row.Cells("File_DGV").Tag = .Item("PATH")
            row.Cells("Explain_DGV").Value = IIf(IsDBNull(.Item("IMAGEEXPLAIN")), imgData, .Item("IMAGEEXPLAIN"))

        End With

        For i = 0 To datagrid.Rows.Count - 1
            Dim r As DataGridViewRow = datagrid.Rows(i)
            r.Height = 35
        Next

    End Sub

End Module
