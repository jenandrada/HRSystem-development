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

    Public Sub GreatestECS(textbox As TextBox)

        Dim mysql As String = "Select MAX(ID) + 1  As Greatest FROM IR_ECS"
        Using ds As DataSet = LoadSQL(mysql)

            Dim dr As DataRow = ds.Tables(0).Rows(0)
            If dr.Table.Rows.Count > 0 Then
                With dr

                    Dim year As String = Date.Now.ToString("yy")
                    Dim month As String = Date.Now.ToString("MM")
                    textbox.Text = year & "0" & month & "" & Format(.Item("Greatest"), "000")


                End With
            Else
                Exit Sub
            End If

        End Using
    End Sub

    Public Sub Pendings(number As Label, table As String, statusName As String)

        Dim mysql As String = $"Select Count(ID) as CountME FROM { table } where { statusName } = 'PENDING'"
        Using ds As DataSet = LoadSQL(mysql)

            Dim dr As DataRow = ds.Tables(0).Rows(0)
            If dr.Table.Rows.Count > 0 Then
                With dr

                    number.Text = .Item("CountME")

                End With
            End If
        End Using

    End Sub

    Public Sub PendingCorrective(number As Label)

        Dim mysql As String = $"Select Count(ID) as CountME FROM IR_REPRIMAND where WRITTEN_STATUS = 'DONE' and CORRECTIVE_ACTION = 'PENDING' and DAYSSUSPEND <> 0"
        Using ds As DataSet = LoadSQL(mysql)

            Dim dr As DataRow = ds.Tables(0).Rows(0)
            If dr.Table.Rows.Count > 0 Then
                With dr

                    number.Text = .Item("CountME")

                End With
            End If
        End Using

    End Sub

    Friend Sub PopulateExplaination(datagrid As DataGridView)
        datagrid.Rows.Clear()
        Dim mysql As String = "Select * From SHOWCAUSE_RECORDS A inner join TBL_EMPLOYEE B on B.id = A.emp_id inner join IR_RECORDS C on C.irno = A.irno"
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


            If .Item("EXPLAIN_REMARKS").Equals(DBNull.Value) Or .Item("EXPLAIN_REMARKS").Equals("") Then
                row.Cells("Remarks_DGV").Value = "Add"

            Else
                row.Cells("Remarks_DGV").Value = "View"
                row.Cells("Remarks_DGV").Tag = .Item("EXPLAIN_REMARKS")
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
                            inner join SHOWCAUSE_RECORDS D on D.irno = A.irno"

        Using ds As DataSet = LoadSQL(mysql, "IR_REPRIMAND")
            If ds.Tables(0).Rows.Count > 0 Then
                For Each dr In ds.Tables(0).Rows
                    AddRowAckno(dr, datagrid)
                Next

            End If
        End Using

    End Sub

    Friend Sub PopulateACTIONByECS(datagrid As DataGridView)
        datagrid.Rows.Clear()
        Dim mysql As String

        mysql = "Select * From IR_ECS A 
                            inner join TBL_EMPLOYEE B on B.id = A.PERSON_ID 
                            inner join IR_RECORDS C on C.irno = A.irno 
                            inner join SHOWCAUSE_RECORDS D on D.irno = A.irno 
                            inner join IR_REPRIMAND E on E.irno = A.irno where A.irno = E.irno"

        Using ds As DataSet = LoadSQL(mysql, "IR_ECS")
            If ds.Tables(0).Rows.Count > 0 Then
                For Each dr In ds.Tables(0).Rows
                    AddRowACTION(dr, datagrid)
                Next
            End If
        End Using
    End Sub

    Friend Sub PopulateACTIONBySuspension(datagrid As DataGridView)
        datagrid.Rows.Clear()
        Dim mysql As String

        mysql = "Select * From IR_REPRIMAND A 
                            inner join TBL_EMPLOYEE B on B.id = A.emp_id 
                            inner join IR_RECORDS C on C.irno = A.irno 
                            inner join SHOWCAUSE_RECORDS D on D.irno = A.irno where A.WRITTEN_STATUS = 'DONE' and A.DAYSSUSPEND <> '0' "

        Using ds As DataSet = LoadSQL(mysql, "IR_REPRIMAND")
            If ds.Tables(0).Rows.Count > 0 Then
                For Each dr In ds.Tables(0).Rows
                    AddRowACTION(dr, datagrid)
                Next

            End If
        End Using

    End Sub

    Friend Sub PopulateACTIONByWrittenOnly(datagrid As DataGridView)
        datagrid.Rows.Clear()
        Dim mysql As String

        mysql = "Select * From IR_REPRIMAND A 
                            inner join TBL_EMPLOYEE B on B.id = A.emp_id 
                            inner join IR_RECORDS C on C.irno = A.irno 
                            inner join SHOWCAUSE_RECORDS D on D.irno = A.irno where A.CORRECTIVE_ACTION = 'WRITTEN'"

        Using ds As DataSet = LoadSQL(mysql, "IR_REPRIMAND")
            If ds.Tables(0).Rows.Count > 0 Then
                For Each dr In ds.Tables(0).Rows
                    AddRowACTION(dr, datagrid)
                Next

            End If
        End Using

    End Sub

    Friend Sub PopulateRecords(datagrid As DataGridView)
        datagrid.Rows.Clear()
        Dim mysql As String

        mysql = "Select * From IR_REPRIMAND A 
                            inner join TBL_EMPLOYEE B on B.id = A.emp_id 
                            inner join IR_RECORDS C on C.irno = A.irno 
                            inner join SHOWCAUSE_RECORDS D on D.irno = A.irno where A.WRITTEN_STATUS = 'DONE'"

        Using ds As DataSet = LoadSQL(mysql, "IR_REPRIMAND")
            If ds.Tables(0).Rows.Count > 0 Then
                For Each dr In ds.Tables(0).Rows
                    AddRowACTION(dr, datagrid)
                Next
            End If
        End Using

    End Sub

    Public Sub AddRowACTION(ByVal dr As DataRow, datagrid As DataGridView)

        With dr

            Dim rowId As Integer = datagrid.Rows.Add()
            Dim row As DataGridViewRow = datagrid.Rows(rowId)
            row.Cells("IRNO_COO").Value = Format(.Item("IRNO"), "00000")
            row.Cells("NAME_COO").Value = .Item("LASTNAME") & ", " & .Item("FIRSTNAME") & " " & .Item("MIDDLENAME")
            row.Cells("COMPANY_COO").Value = .Item("COMPANY")
            row.Cells("INCIDENT_COO").Value = "Open"
            row.Cells("INCIDENT_COO").Tag = .Item("IR_PATH")
            row.Cells("SC_COO").Value = "Open"
            row.Cells("SC_COO").Tag = .Item("SC_PATH")
            row.Cells("EXPLAIN_COO").Value = "Open"
            row.Cells("EXPLAIN_COO").Tag = .Item("EXPLAIN_PATH")
            row.Cells("WR_COO").Value = "Open"
            row.Cells("WR_COO").Tag = .Item("WRITTEN_PATH")

            row.Cells("ACKNO_COO").Value = "Open"
            row.Cells("ACKNO_COO").Tag = .Item("ACKNO_PATH")

            If .Item("RECEIVE_ACTION").Equals(DBNull.Value) Or .Item("RECEIVE_ACTION").Equals("") Then '============================== RECEIVED ANY WRITTEN REPRIMAND (WRITTEN, ECS, SUSPENSION)

                row.Cells("Receive_COO").Value = "Upload"
            Else
                row.Cells("Receive_COO").Value = "Open"
                row.Cells("Receive_COO").Tag = .Item("RECEIVE_PATH")

            End If

            If .Item("CORRECTIVE_ACTION") = "DONE" Then  '============================== CORRECTIVE ACTION NOTICE - Must come second to override RECEIVE Button
                row.Cells("ACTION_COO").Value = "Open"
                row.Cells("ACTION_COO").Tag = .Item("CORRECTIVE_PATH")

            ElseIf .Item("CORRECTIVE_ACTION") = "WRITTEN" Then
                row.Cells("ACTION_COO").Value = ""
                row.Cells("Receive_COO").Value = ""

            ElseIf .Item("CORRECTIVE_ACTION") = "ECS" Then
                row.Cells("ACTION_COO").Value = ""
                row.Cells("Receive_COO").Value = ""

            End If


            If .Item("EXPLAIN_REMARKS").Equals(DBNull.Value) Or .Item("EXPLAIN_REMARKS").Equals("") Then '========= EXPLANATION REMARKS
                row.Cells("REMARKS_COO").Value = ""

            Else
                row.Cells("REMARKS_COO").Value = "View"
                row.Cells("REMARKS_COO").Tag = .Item("EXPLAIN_REMARKS")
            End If

            row.Height = 35
        End With

    End Sub

    Friend Sub FETCH_PDF_FROM_DATABASE()
        Dim mysql As String

        mysql = "Select * From IR_PDF"

        Using ds As DataSet = LoadSQL(mysql, "IR_PDF")
            If ds.Tables(0).Rows.Count > 0 Then
                For Each dr In ds.Tables(0).Rows
                    With dr

                        Dim name As String = "IR No. " & Format(.Item("IRNO"), "00000") & " - " & .Item("EMP_NAME")
                        Console.WriteLine("NAAAME " & name)

                        If .Item("IR_PATH").Equals(DBNull.Value) Or .Item("IR_PATH").Equals("") Then
                        Else
                            SavePDF_IfNotExist(.Item("IR_PATH"), name, .Item("INCIDENTREPORT"))
                        End If

                        If .Item("SC_PATH").Equals(DBNull.Value) Or .Item("SC_PATH").Equals("") Then
                        Else
                            SavePDF_IfNotExist(.Item("SC_PATH"), name, .Item("SHOWCAUSE"))
                        End If

                        If .Item("EXPLAIN_PATH").Equals(DBNull.Value) Or .Item("EXPLAIN_PATH").Equals("") Then
                        Else
                            SavePDF_IfNotExist(.Item("EXPLAIN_PATH"), name, .Item("EXPLANATION"))
                        End If

                        If .Item("WRITTEN_PATH").Equals(DBNull.Value) Or .Item("WRITTEN_PATH").Equals("") Then
                        Else
                            SavePDF_IfNotExist(.Item("WRITTEN_PATH"), name, .Item("WRITTENREPRIMAND"))
                        End If

                        If .Item("ACKNOW_PATH").Equals(DBNull.Value) Or .Item("ACKNOW_PATH").Equals("") Then
                        Else
                            SavePDF_IfNotExist(.Item("ACKNOW_PATH"), name, .Item("ACKNOWLEDGMENT"))
                        End If

                        If .Item("CORRECTIVE_PATH").Equals(DBNull.Value) Or .Item("CORRECTIVE_PATH").Equals("") Then
                        Else
                            SavePDF_IfNotExist(.Item("CORRECTIVE_PATH"), name, .Item("CORRECTIVEACTION"))
                        End If

                        If .Item("RECEIVED_PATH").Equals(DBNull.Value) Or .Item("RECEIVED_PATH").Equals("") Then
                        Else
                            SavePDF_IfNotExist(.Item("RECEIVED_PATH"), name, .Item("RECEIVED"))
                        End If
                    End With

                Next
            End If
        End Using

    End Sub

    Public Sub SavePDF_IfNotExist(path As String, name As String, pdf As Byte())

        name = name.ToString.TrimEnd()

        Dim DirFolderToCreate As String = "D:\HR Records\Incident Report" & ""
        Dim folderName As DirectoryInfo = New DirectoryInfo(DirFolderToCreate)

        Dim DirEmployeeToCreate As String = "D:\HR Records\Incident Report\" & name & ""
        Dim employee As DirectoryInfo = New DirectoryInfo(DirEmployeeToCreate)


        If folderName.Exists Then

            If employee.Exists Then

                Dim databseToFolder As Byte() = pdf
                System.IO.File.WriteAllBytes(path, databseToFolder)

            Else
                employee.Create()
                Dim databseToFolder As Byte() = pdf
                System.IO.File.WriteAllBytes(path, databseToFolder)

            End If

        Else

            folderName.Create()
            If employee.Exists Then
                Dim databseToFolder As Byte() = pdf
                System.IO.File.WriteAllBytes(path, databseToFolder)

            Else
                employee.Create()
                Dim databseToFolder As Byte() = pdf
                System.IO.File.WriteAllBytes(path, databseToFolder)

            End If

        End If

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

        mysql = "Select * From SHOWCAUSE_RECORDS A inner join TBL_EMPLOYEE B On B.id = A.emp_id inner join IR_RECORDS C On C.irno = A.irno where A.STATUS = '" & status & "'"
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

                mysql = "Select * From IR_REPRIMAND A 
                            inner join TBL_EMPLOYEE B on B.id = A.emp_id 
                            inner join IR_RECORDS C on C.irno = A.irno 
                            inner join SHOWCAUSE_RECORDS D on D.irno = A.irno Where A.irno = '" & irno & "'"

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

        Else
            MsgBox("Invalid! You entered a Nonnumerical data.", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Friend Sub PopulateACKNOWTATUS(datagrid As DataGridView, status As String)
        datagrid.Rows.Clear()
        Dim mysql As String

        'mysql = "Select * From SHOWCAUSE_RECORDS A inner join TBL_EMPLOYEE B on B.id = A.emp_id inner join IR_RECORDS C on C.irno = A.irno where A.STATUS = '" & status & "'"

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

    Public Sub LoadACTIONSearchName(search As String, datagrid As DataGridView)

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
                    AddRowACTION(dr, datagrid)
                Next

            End If
        End Using
    End Sub

    Public Sub LoadACTIONSearchIRNO(irno As String, datagrid As DataGridView)

        Dim int As Integer

        If Double.TryParse(irno, int) Then

            datagrid.Rows.Clear()
            Dim secured_str = DreadKnight(irno)
            Dim mysql As String
            Dim strWords As String() = secured_str.Split(New Char() {" "c})


            If secured_str.Length <> 0 Then

                mysql = "Select * From IR_REPRIMAND A 
                            inner join TBL_EMPLOYEE B on B.id = A.emp_id 
                            inner join IR_RECORDS C on C.irno = A.irno 
                            inner join SHOWCAUSE_RECORDS D on D.irno = A.irno Where A.irno = '" & irno & "'"

            Else

                mysql = "Select * From IR_REPRIMAND A 
                            inner join TBL_EMPLOYEE B on B.id = A.emp_id 
                            inner join IR_RECORDS C on C.irno = A.irno 
                            inner join SHOWCAUSE_RECORDS D on D.irno = A.irno"

            End If

            Using ds As DataSet = LoadSQL(mysql, "IR_REPRIMAND")
                If ds.Tables(0).Rows.Count > 0 Then

                    For Each dr In ds.Tables(0).Rows
                        AddRowACTION(dr, datagrid)
                    Next
                End If
            End Using

        Else
            MsgBox("Invalid! You entered a Nonnumerical data.", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Public Sub LoadECSSearchName(search As String, listview As ListView)

        listview.Items.Clear()
        Dim secured_str = DreadKnight(search)
        Dim mysql As String
        Dim strWords As String() = secured_str.Split(New Char() {" "c})


        If secured_str.Length <> 0 Then

            mysql = "Select * From IR_ECS A inner join TBL_EMPLOYEE B on B.id = A.PERSON_ID Where"

            For Each name In strWords
                mysql &= $"{vbCr} UPPER(B.LastName ||' '|| B.FirstName ||' '|| B.MiddleName) LIKE UPPER('%{name}%') or "
                mysql &= $"{vbCr} UPPER(B.FirstName ||' '|| B.MiddleName ||' '|| B.LastName) LIKE UPPER('%{name}%') or "

                If name Is strWords.Last Then
                    mysql &= $"{vbCr} UPPER(B.FirstName ||' '|| B.LastName ||' '|| B.MiddleName) LIKE UPPER('%{name}%')"
                    Exit For
                End If
            Next
        Else

            mysql = "Select * From IR_ECS A inner join TBL_EMPLOYEE B on B.id = A.PERSON_ID"
        End If

        Using ds As DataSet = LoadSQL(mysql, "IR_ECS")
            If ds.Tables(0).Rows.Count > 0 Then

                For Each dr In ds.Tables(0).Rows
                    AddRowECS(dr, listview)
                Next

            End If
        End Using
    End Sub

    Public Sub LoadECSSearchIRNO(irno As String, listview As ListView)

        Dim int As Integer

        If Double.TryParse(irno, int) Then

            listview.Items.Clear()
            Dim secured_str = DreadKnight(irno)
            Dim mysql As String
            Dim strWords As String() = secured_str.Split(New Char() {" "c})


            If secured_str.Length <> 0 Then

                mysql = "Select * From IR_ECS A inner join TBL_EMPLOYEE B on B.id = A.PERSON_ID Where A.irno = '" & irno & "'"

            Else

                mysql = "Select * From IR_ECS A inner join TBL_EMPLOYEE B on B.id = A.PERSON_ID"

            End If

            Using ds As DataSet = LoadSQL(mysql, "IR_ECS")
                If ds.Tables(0).Rows.Count > 0 Then

                    For Each dr In ds.Tables(0).Rows
                        AddRowECS(dr, listview)
                    Next
                End If
            End Using

        Else
            MsgBox("Invalid! You entered a Nonnumerical data.", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Public Sub LoadECSSearchECSNO(ecsNo As String, listview As ListView)

        Dim int As Integer

        If Double.TryParse(ecsNo, int) Then

            listview.Items.Clear()
            Dim secured_str = DreadKnight(ecsNo)
            Dim mysql As String
            Dim strWords As String() = secured_str.Split(New Char() {" "c})


            If secured_str.Length <> 0 Then

                mysql = "Select * From IR_ECS A inner join TBL_EMPLOYEE B on B.id = A.PERSON_ID Where A.ecsno = '" & ecsNo & "'"

            Else

                mysql = "Select * From IR_ECS A inner join TBL_EMPLOYEE B on B.id = A.PERSON_ID"

            End If

            Using ds As DataSet = LoadSQL(mysql, "IR_ECS")
                If ds.Tables(0).Rows.Count > 0 Then

                    For Each dr In ds.Tables(0).Rows
                        AddRowECS(dr, listview)
                    Next
                End If
            End Using

        Else
            MsgBox("Invalid! You entered a Nonnumerical data.", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Public Sub LoadECS(listview As ListView)

        Try
            Dim mysql As String = "Select * From IR_ECS inner join tbl_Employee on tbl_Employee.id = IR_ECS.PERSON_ID "
            Console.WriteLine("2222")
            Dim rowCount As Integer
            Using ds As DataSet = LoadSQL(mysql, "IR_ECS")
                rowCount = ds.Tables(0).Rows.Count
                Dim maxEntries As Integer = ds.Tables(0).Rows.Count
                frmMainForm.AppProgressBar.Maximum = maxEntries
                frmMainForm.AppProgressBar.Visible = True
                listview.Items.Clear()
                For Each dr In ds.Tables(0).Rows
                    AddRowECS(dr, listview)
                    frmMainForm.AppProgressBar.Value += 1
                Next
            End Using

            frmMainForm.AppProgressBar.Value = 0
            frmMainForm.AppProgressBar.Maximum = 1000
            frmMainForm.AppProgressBar.Visible = False
        Catch ex As Exception
            Log_Report(ex.ToString())
        End Try
    End Sub

    Private Sub AddRowECS(ByVal dr As DataRow, listview As ListView)

        If listview.Items.Count <= 20 Then
            With dr
                Dim datee As DateTime = CDate(.Item("DATE_CREATED"))
                Dim amount As Double = CDbl(.Item("AMOUNT"))
                Dim perPayroll As Double = CDbl(.Item("AMOUNT_PER_PAYROLL"))


                Dim lv As ListViewItem = listview.Items.Add(Format(.Item("IRNO"), "00000"))
                lv.SubItems.Add(.Item("ECSNO"))
                lv.SubItems.Add(String.Format("{0}, {1} {2}", .Item("LastName"), .Item("FirstName"), .Item("MiddleName")))
                lv.SubItems.Add(datee.ToString("D"))
                lv.SubItems.Add(Decimal.Parse(amount).ToString("##,###0.00"))
                lv.SubItems.Add(.Item("NO_OF_MONTHS"))
                lv.SubItems.Add(Decimal.Parse(perPayroll).ToString("##,###0.00"))

            End With
        Else
            Exit Sub
        End If

    End Sub


End Module
