Module Saving

    Friend Sub SaveShowCause(emp_id As String, dateIssued As String, deadline As String, path As String, status As String, company As String, scno As String)
        Dim mysql As String = "Select * From SHOWCAUSE_RECORDS Rows 1"
        Using ds As DataSet = LoadSQL(mysql, "SHOWCAUSE_RECORDS")

            Dim dsNewRow As DataRow = ds.Tables(0).NewRow
            With dsNewRow

                .Item("EMP_ID") = emp_id
                .Item("DATE_ISSUED") = dateIssued
                .Item("DATE_DEADLINE") = deadline
                .Item("PATH") = path
                .Item("STATUS") = status
                .Item("COMPANY") = company
                .Item("SCNO") = scno

            End With
            ds.Tables(0).Rows.Add(dsNewRow)
            SaveEntry(ds)
        End Using

    End Sub

    Friend Sub SaveIncidentReport(IRNo As String, suprvisor_ID As String, person_ID As String, incidentLoc As String,
                                  incidentDate As String, ReceivedDate As String, actionTaken As String, Description As String,
                                  preparedby As String, receivedby As String, reviewedby As String, path As String)

        Dim mysql As String = "Select * From IR_RECORDS Rows 1"
        Using ds As DataSet = LoadSQL(mysql, "IR_RECORDS")

            Dim dsNewRow As DataRow = ds.Tables(0).NewRow
            With dsNewRow

                .Item("IRNo") = IRNo
                .Item("suprvisor_ID") = suprvisor_ID
                .Item("person_ID") = person_ID
                .Item("incidentLoc") = incidentLoc
                .Item("incidentDate") = incidentDate
                .Item("ReceivedDate") = ReceivedDate
                .Item("actionTaken") = actionTaken
                .Item("Description") = Description
                .Item("preparedby") = preparedby
                .Item("receivedby") = receivedby
                .Item("path") = path

            End With
            ds.Tables(0).Rows.Add(dsNewRow)
            SaveEntry(ds)
        End Using

    End Sub

    Friend Sub SaveRuleNoSectionnO(emp_id As String, rule As String, section As String)
        Dim mysql As String = "Select * From SHOWCAUSE_COUNT Rows 1"
        Using ds As DataSet = LoadSQL(mysql, "SHOWCAUSE_COUNT")

            Dim dsNewRow As DataRow = ds.Tables(0).NewRow
            With dsNewRow

                .Item("EMP_ID") = emp_id
                .Item("RULENO") = rule
                .Item("SECTIONNO") = section

            End With
            ds.Tables(0).Rows.Add(dsNewRow)
            SaveEntry(ds)
        End Using

    End Sub


    'Friend Sub SaveExplaination(ID As Integer, p As Byte())

    '    Dim sql As String = "select * from TBL_PROFILEPIC rows 1"
    '    Using ds As DataSet = LoadSQL(sql, "TBL_PROFILEPIC")
    '        Dim dsNew As DataRow = ds.Tables(0).NewRow

    '        With dsNew
    '            .Item("EMP_ID") = ID
    '            .Item("PROFILE_PIC") = p
    '        End With
    '        ds.Tables(0).Rows.Add(dsNew)
    '        SaveEntry(ds)
    '    End Using
    'End Sub

    Friend Sub ExplainationSave(scno As String, pic As Byte(), status As String)
        Dim mysql As String = "Select * From SHOWCAUSE_RECORDS "
        Using ds As DataSet = LoadSQL(mysql, "SHOWCAUSE_RECORDS")

            With ds.Tables(0).Rows(0)
                .Item("STATUS") = status
                .Item("IMAGEEXPLAIN") = pic
            End With
            SaveEntry(ds, False)
        End Using

        MsgBox("Succesfully Saved!", MsgBoxStyle.Information, "Information")

        If ThisHasRow("SHOWCAUSE_RECORDS") Then
            SCPendings(frmMainForm.PendingNo_LBL)
        End If
    End Sub

End Module
