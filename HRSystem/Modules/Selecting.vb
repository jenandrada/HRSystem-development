Imports System.Drawing.Imaging
Imports System.IO

Module Selecting

    Friend Function ImgToByteArray(img As Image, imgFormat As ImageFormat) As Byte()
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

    'Public Sub LoadListviewWritten(irno As String, listRule As ListView, listSection As ListView)
    '    Dim mysql As String = "Select * From SHOWCAUSE_COUNT WHERE IRNo = '" & irno & "'"
    '    Using ds As DataSet = LoadSQL(mysql, "SHOWCAUSE_COUNT")

    '        For Each dr As DataRow In ds.Tables(0).Rows
    '            With dr
    '                For x = 0 To listRule.Items.Count - 1
    '                    If listRule.Items(x).Text = .Item("RULENO") Then
    '                        listRule.Items(x).Selected = True
    '                        'listRule.Select()
    '                    End If

    '                    For ii As Integer = 0 To listSection.Items.Count - 1
    '                        If listSection.Items(ii).Text = .Item("SECTIONNO") Then
    '                            listSection.Items(ii).Selected = True
    '                            listSection.Select()
    '                        End If
    '                    Next
    '                Next


    '            End With
    '        Next

    '    End Using
    'End Sub

    Public Sub LoadListviewWritten(irno As String, listSection As ListView, rule As Label)
        Dim mysql As String = "Select * From SHOWCAUSE_COUNT INNER JOIN TBL_RULESECTIONLIST ON TBL_RULESECTIONLIST.SECTION = SHOWCAUSE_COUNT.SECTIONNO  WHERE SHOWCAUSE_COUNT.IRNo = '" & irno & "'"
        Using ds As DataSet = LoadSQL(mysql, "SHOWCAUSE_COUNT")

            For Each dr As DataRow In ds.Tables(0).Rows
                With dr
                    Dim lvitem As ListViewItem = listSection.Items.Add(.Item("SECTIONNO"))
                    lvitem.SubItems.Add(.Item("NATURE_OF_OFFENSES"))
                    rule.Text = .Item("RULE_NUMBER") & " " & .Item("RULE_DEFINITION")
                End With
            Next

        End Using
    End Sub


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


    Friend Sub PopulateExplaination(datagrid As DataGridView)
        datagrid.Rows.Clear()
        Dim mysql As String

        mysql = "Select * From SHOWCAUSE_RECORDS A inner join TBL_EMPLOYEE B on B.id = A.emp_id inner join IR_RECORDS C on C.irno = A.irno"
        Using ds As DataSet = LoadSQL(mysql, "SHOWCAUSE_RECORDS")
            If ds.Tables(0).Rows.Count > 0 Then
                For Each dr In ds.Tables(0).Rows
                    AddItem(dr, datagrid)
                Next

            End If
        End Using

    End Sub

    Public Sub AddItem(ByVal dr As DataRow, datagrid As DataGridView)

        With dr

            Dim datee As DateTime = CDate(.Item("DATE_DEADLINE"))

            Dim rowId As Integer = datagrid.Rows.Add()
            Dim row As DataGridViewRow = datagrid.Rows(rowId)
            row.Cells("IRNO_DGV").Value = Format(.Item("IRNO"), "00000")
            row.Cells("Name_DGV").Value = .Item("LASTNAME") & ", " & .Item("FIRSTNAME") & " " & .Item("MIDDLENAME")
            row.Cells("Company_DGV").Value = .Item("COMPANY")
            row.Cells("Deadline_DGV").Value = datee.ToString("D")
            row.Cells("IR_DGV").Value = "Open"
            row.Cells("IR_DGV").Tag = .Item("IR_PATH")
            row.Cells("File_DGV").Value = "Open"
            row.Cells("File_DGV").Tag = .Item("SC_PATH")

            If .Item("STATUS") = "PENDING" Then
                row.DefaultCellStyle.BackColor = Color.LightSalmon
                row.Cells("Explain_DGV").Value = "Upload"
            Else
                row.Cells("Explain_DGV").Value = "Open"
                row.Cells("Explain_DGV").Tag = .Item("EXPLAIN_PATH")
            End If

            row.Height = 35

        End With

    End Sub


    Friend Sub PopulateAcknowledge(datagrid As DataGridView)
        datagrid.Rows.Clear()
        Dim mysql As String

        mysql = "Select * From IR_REPRIMAND A 
                            inner join TBL_EMPLOYEE B on B.id = A.emp_id 
                            inner join IR_RECORDS C on C.irno = A.irno 
                            inner join SHOWCAUSE_RECORDS D on D.irno = A.irno
"
        Using ds As DataSet = LoadSQL(mysql, "IR_REPRIMAND")
            If ds.Tables(0).Rows.Count > 0 Then
                For Each dr In ds.Tables(0).Rows
                    AddRowAckno(dr, datagrid)
                Next

            End If
        End Using

    End Sub

    Public Sub AddRowAckno(ByVal dr As DataRow, datagrid As DataGridView)

        With dr

            Dim datee As DateTime = CDate(.Item("DATE_DEADLINE"))

            Dim rowId As Integer = datagrid.Rows.Add()
            Dim row As DataGridViewRow = datagrid.Rows(rowId)
            row.Cells("IRNO_DGVV").Value = Format(.Item("IRNO"), "00000")
            row.Cells("Name_DGVV").Value = .Item("LASTNAME") & ", " & .Item("FIRSTNAME") & " " & .Item("MIDDLENAME")
            row.Cells("Company_DGVV").Value = .Item("COMPANY")
            row.Cells("IR_DGVV").Value = "Open"
            row.Cells("IR_DGVV").Tag = .Item("IR_PATH")
            row.Cells("SC_DGVV").Value = "Open"
            row.Cells("SC_DGVV").Tag = .Item("SC_PATH")
            row.Cells("Explain_DGVV").Value = "Open"
            row.Cells("Explain_DGVV").Tag = .Item("EXPLAIN_PATH")
            row.Cells("WRITTEN_DGVV").Value = "Open"
            row.Cells("WRITTEN_DGVV").Tag = .Item("WRITTEN_PATH")

            If .Item("WRITTEN_STATUS") = "PENDING" Then
                row.DefaultCellStyle.BackColor = Color.LightSalmon
                row.Cells("ACKNOW_DGVV").Value = "Upload"
            Else
                row.Cells("ACKNOW_DGVV").Value = "Open"
                row.Cells("ACKNOW_DGVV").Tag = .Item("ACKNO_PATH")
            End If

            row.Height = 35

        End With

    End Sub

    Friend Sub PopulateExplainationSTATUS(datagrid As DataGridView, status As String)
        datagrid.Rows.Clear()
        Dim mysql As String

        mysql = "Select * From SHOWCAUSE_RECORDS A inner join TBL_EMPLOYEE B on B.id = A.emp_id inner join IR_RECORDS C on C.irno = A.irno where A.STATUS = '" & status & "'"
        Using ds As DataSet = LoadSQL(mysql, "SHOWCAUSE_RECORDS")
            If ds.Tables(0).Rows.Count > 0 Then
                For Each dr In ds.Tables(0).Rows
                    AddItem(dr, datagrid)
                Next

            End If
        End Using
    End Sub

    Public Sub LoadExplainSearchName(search As String, datagrid As DataGridView)

        datagrid.Rows.Clear()
        Dim secured_str = DreadKnight(search)
        Dim mysql As String
        Dim strWords As String() = secured_str.Split(New Char() {" "c})


        If secured_str.Length <> 0 Then
            mysql = "Select * From SHOWCAUSE_RECORDS A inner join TBL_EMPLOYEE B on B.id = A.emp_id inner join IR_RECORDS C on C.irno = A.irno Where "

            For Each name In strWords
                mysql &= $"{vbCr} UPPER(B.LastName ||' '|| B.FirstName ||' '|| B.MiddleName) LIKE UPPER('%{name}%') or "
                mysql &= $"{vbCr} UPPER(B.FirstName ||' '|| B.MiddleName ||' '|| B.LastName) LIKE UPPER('%{name}%') or "

                If name Is strWords.Last Then
                    mysql &= $"{vbCr} UPPER(B.FirstName ||' '|| B.LastName ||' '|| B.MiddleName) LIKE UPPER('%{name}%')"
                    Exit For
                End If
            Next
        Else
            mysql = "Select * From SHOWCAUSE_RECORDS A inner join TBL_EMPLOYEE B on B.id = A.emp_id inner join IR_RECORDS C on C.irno = A.irno"
        End If

        Using ds As DataSet = LoadSQL(mysql, "SHOWCAUSE_RECORDS")
            If ds.Tables(0).Rows.Count > 0 Then

                For Each dr In ds.Tables(0).Rows
                    AddItem(dr, datagrid)
                Next

            End If
        End Using
    End Sub

    Public Sub LoadExplainSearchIRNO(irno As String, datagrid As DataGridView)

        Dim int As Integer

        If Double.TryParse(irno, int) Then

            datagrid.Rows.Clear()
            Dim secured_str = DreadKnight(irno)
            Dim mysql As String
            Dim strWords As String() = secured_str.Split(New Char() {" "c})


            If secured_str.Length <> 0 Then

                mysql = "Select * From SHOWCAUSE_RECORDS A inner join TBL_EMPLOYEE B on B.id = A.emp_id inner join IR_RECORDS C on C.irno = A.irno Where A.irno = '" & irno & "'"

            Else
                mysql = "Select * From SHOWCAUSE_RECORDS A inner join TBL_EMPLOYEE B on B.id = A.emp_id inner join IR_RECORDS C on C.irno = A.irno"
            End If

            Using ds As DataSet = LoadSQL(mysql, "SHOWCAUSE_RECORDS")
                If ds.Tables(0).Rows.Count > 0 Then

                    For Each dr In ds.Tables(0).Rows
                        AddItem(dr, datagrid)
                    Next
                End If
            End Using

        Else
            MsgBox("Invalid! You entered a Nonnumerical data.", MsgBoxStyle.Critical, "Error")
        End If

    End Sub


    Public Sub LoadACKNOWSearchName(search As String, datagrid As DataGridView)

        datagrid.Rows.Clear()
        Dim secured_str = DreadKnight(search)
        Dim mysql As String
        Dim strWords As String() = secured_str.Split(New Char() {" "c})


        If secured_str.Length <> 0 Then

            mysql = "Select * From IR_REPRIMAND A 
                            inner join TBL_EMPLOYEE B on B.id = A.emp_id 
                            inner join IR_RECORDS C on C.irno = A.irno 
                            inner join SHOWCAUSE_RECORDS D on D.irno = A.irno Where"

            For Each name In strWords
                mysql &= $"{vbCr} UPPER(B.LastName ||' '|| B.FirstName ||' '|| B.MiddleName) LIKE UPPER('%{name}%') or "
                mysql &= $"{vbCr} UPPER(B.FirstName ||' '|| B.MiddleName ||' '|| B.LastName) LIKE UPPER('%{name}%') or "

                If name Is strWords.Last Then
                    mysql &= $"{vbCr} UPPER(B.FirstName ||' '|| B.LastName ||' '|| B.MiddleName) LIKE UPPER('%{name}%')"
                    Exit For
                End If
            Next
        Else

            mysql = "Select * From IR_REPRIMAND A 
                            inner join TBL_EMPLOYEE B on B.id = A.emp_id 
                            inner join IR_RECORDS C on C.irno = A.irno 
                            inner join SHOWCAUSE_RECORDS D on D.irno = A.irno"
        End If

        Using ds As DataSet = LoadSQL(mysql, "IR_REPRIMAND")
            If ds.Tables(0).Rows.Count > 0 Then

                For Each dr In ds.Tables(0).Rows
                    AddRowAckno(dr, datagrid)
                Next

            End If
        End Using
    End Sub

    Public Sub LoadACKNOWSearchIRNO(irno As String, datagrid As DataGridView)

        Dim int As Integer

        If Double.TryParse(irno, int) Then

            datagrid.Rows.Clear()
            Dim secured_str = DreadKnight(irno)
            Dim mysql As String
            Dim strWords As String() = secured_str.Split(New Char() {" "c})


            If secured_str.Length <> 0 Then

                'mysql = "Select * From SHOWCAUSE_RECORDS A inner join TBL_EMPLOYEE B on B.id = A.emp_id inner join IR_RECORDS C on C.irno = A.irno Where A.irno = '" & irno & "'"

                mysql = "Select * From IR_REPRIMAND A 
                            inner join TBL_EMPLOYEE B on B.id = A.emp_id 
                            inner join IR_RECORDS C on C.irno = A.irno 
                            inner join SHOWCAUSE_RECORDS D on D.irno = A.irno Where A.irno = '" & irno & "'"

            Else
                'mysql = "Select * From SHOWCAUSE_RECORDS A inner join TBL_EMPLOYEE B on B.id = A.emp_id inner join IR_RECORDS C on C.irno = A.irno"

                mysql = "Select * From IR_REPRIMAND A 
                            inner join TBL_EMPLOYEE B on B.id = A.emp_id 
                            inner join IR_RECORDS C on C.irno = A.irno 
                            inner join SHOWCAUSE_RECORDS D on D.irno = A.irno"

            End If

            Using ds As DataSet = LoadSQL(mysql, "IR_REPRIMAND")
                If ds.Tables(0).Rows.Count > 0 Then

                    For Each dr In ds.Tables(0).Rows
                        AddRowAckno(dr, datagrid)
                    Next
                End If
            End Using

        Else
            MsgBox("Invalid! You entered a Nonnumerical data.", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Friend Sub PopulateACKNOWTATUS(datagrid As DataGridView, status As String)
        datagrid.Rows.Clear()
        Dim mysql As String

        mysql = "Select * From SHOWCAUSE_RECORDS A inner join TBL_EMPLOYEE B on B.id = A.emp_id inner join IR_RECORDS C on C.irno = A.irno where A.STATUS = '" & status & "'"

        mysql = "Select * From IR_REPRIMAND A 
                            inner join TBL_EMPLOYEE B on B.id = A.emp_id 
                            inner join IR_RECORDS C on C.irno = A.irno 
                            inner join SHOWCAUSE_RECORDS D on D.irno = A.irno Where A.WRITTEN_STATUS = '" & status & "'"

        Using ds As DataSet = LoadSQL(mysql, "IR_REPRIMAND")
            If ds.Tables(0).Rows.Count > 0 Then
                For Each dr In ds.Tables(0).Rows
                    AddRowAckno(dr, datagrid)
                Next

            End If
        End Using
    End Sub

End Module
