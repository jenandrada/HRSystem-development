Module Saving

    Friend Sub SaveShowCause(emp_id As String, dateIssued As String, deadline As String, path As String, status As String, company As String, irno As String)
        Dim mysql As String = "Select * From SHOWCAUSE_RECORDS Rows 1"
        Using ds As DataSet = LoadSQL(mysql, "SHOWCAUSE_RECORDS")

            Dim dsNewRow As DataRow = ds.Tables(0).NewRow
            With dsNewRow

                .Item("EMP_ID") = emp_id
                .Item("DATE_ISSUED") = dateIssued
                .Item("DATE_DEADLINE") = deadline
                .Item("SC_PATH") = path
                .Item("STATUS") = status
                .Item("COMPANY") = company
                .Item("IRNO") = irno

            End With
            ds.Tables(0).Rows.Add(dsNewRow)
            SaveEntry(ds)
        End Using

    End Sub

    Friend Sub SaveWrittenReprimand(emp_id As String, dateSuspend As String, chargesAmount As String, preparedBy As String, path As String, irno As String)
        Dim mysql As String


        mysql = "Select * FROM IR_REPRIMAND where IRNO = '" & irno & "'"
        Dim dss As DataSet = LoadSQL(mysql, "IR_REPRIMAND")
        If dss.Tables(0).Rows.Count > 0 Then
            Console.WriteLine("NAA = UPDATE ")
            With dss.Tables(0).Rows(0)
                .Item("EMP_ID") = emp_id
                .Item("DAYSSUSPEND") = dateSuspend
                .Item("CHARGESAMOUNT") = chargesAmount
                .Item("PREPAREDBY") = preparedBy
                .Item("WRITTEN_PATH") = path
            End With
            SaveEntry(dss, False)

        Else

            Console.WriteLine("WALA = NEW ")

            mysql = "Select * From IR_REPRIMAND Rows 1"
            Using ds As DataSet = LoadSQL(mysql, "IR_REPRIMAND")

                Dim dsNewRow As DataRow = ds.Tables(0).NewRow
                With dsNewRow

                    .Item("IRNO") = irno
                    .Item("EMP_ID") = emp_id
                    .Item("DAYSSUSPEND") = dateSuspend
                    .Item("CHARGESAMOUNT") = chargesAmount
                    .Item("PREPAREDBY") = preparedBy
                    .Item("WRITTEN_PATH") = path

                End With
                ds.Tables(0).Rows.Add(dsNewRow)
                SaveEntry(ds)
            End Using

        End If

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
                .Item("reviewedby") = reviewedby
                .Item("IR_PATH") = path

            End With
            ds.Tables(0).Rows.Add(dsNewRow)
            SaveEntry(ds)
        End Using

    End Sub

    Friend Sub SaveRuleNoSectionnO(emp_id As String, rule As String, section As String, irno As String)

        Dim mysql As String = "Select * From SHOWCAUSE_COUNT Rows 1"
        Using ds As DataSet = LoadSQL(mysql, "SHOWCAUSE_COUNT")

            Dim dsNewRow As DataRow = ds.Tables(0).NewRow
            With dsNewRow

                .Item("EMP_ID") = emp_id
                .Item("RULENO") = rule
                .Item("SECTIONNO") = section
                .Item("IRNO") = irno


            End With
            ds.Tables(0).Rows.Add(dsNewRow)
            SaveEntry(ds)
        End Using

    End Sub


    Friend Sub ExplainationSave(irno As String, pic As Byte(), status As String, path As String)
        Dim mysql As String = "Select * From SHOWCAUSE_RECORDS where IRNO = '" & irno & "'"
        Using ds As DataSet = LoadSQL(mysql, "SHOWCAUSE_RECORDS")

            With ds.Tables(0).Rows(0)
                .Item("STATUS") = status
                .Item("IMAGEEXPLAIN") = pic
                .Item("EXPLAIN_PATH") = path
            End With
            SaveEntry(ds, False)
        End Using

        'If ThisHasRow("SHOWCAUSE_RECORDS") Then
        '    SCPendings(frmMainForm.PendingNo_LBL)
        'End If
    End Sub

    Friend Sub SaveTRANSACTIONHistory(USERNAME As String, NAME As String, ActionN As String, BranchN As String, STATUS As String, POSITION As String)
        Dim sql As String = "select * from USER_TRANSACTION rows 1"
        Using ds As DataSet = LoadSQL(sql, "USER_TRANSACTION")
            Dim data As DataRow
            data = ds.Tables(0).NewRow
            With data
                .Item("DATETRANSACTION") = Now.ToString("f")
                .Item("USERNAME") = USERNAME
                .Item("NAME") = NAME
                .Item("ACTION") = ActionN
                .Item("BRANCH") = BranchN
                .Item("STATUS") = STATUS
                .Item("POSITION") = POSITION
            End With
            ds.Tables(0).Rows.Add(data)

            SaveEntry(ds)
        End Using
    End Sub

End Module
