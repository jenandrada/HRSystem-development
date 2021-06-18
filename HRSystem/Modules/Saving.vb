Module Saving

    Friend Sub SaveShowCause(emp_id As String, dateIssued As String, deadline As String, path As String, status As String, company As String, irno As String, violation As String)
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
                .Item("VIOLATION") = violation

            End With
            ds.Tables(0).Rows.Add(dsNewRow)
            SaveEntry(ds)
        End Using

    End Sub

    Friend Sub SaveWrittenReprimand(emp_id As String, daysSuspend As String, preparedBy As String, path As String, irno As String, dateCreated As String, status As String, correctiveAction As String)
        Dim mysql As String


        mysql = "Select * FROM IR_REPRIMAND where IRNO = '" & irno & "'"
        Dim dss As DataSet = LoadSQL(mysql, "IR_REPRIMAND")
        If dss.Tables(0).Rows.Count > 0 Then
            With dss.Tables(0).Rows(0)
                .Item("EMP_ID") = emp_id
                .Item("DAYSSUSPEND") = daysSuspend
                .Item("PREPAREDBY") = preparedBy
                .Item("WRITTEN_PATH") = path
                .Item("DATE_CREATED") = dateCreated
                .Item("WRITTEN_STATUS") = status
                .Item("CORRECTIVE_ACTION") = correctiveAction
                .Item("RECEIVE_ACTION") = "PENDING"
            End With
            SaveEntry(dss, False)

        Else

            mysql = "Select * From IR_REPRIMAND Rows 1"
            Using ds As DataSet = LoadSQL(mysql, "IR_REPRIMAND")

                Dim dsNewRow As DataRow = ds.Tables(0).NewRow
                With dsNewRow

                    .Item("IRNO") = irno
                    .Item("EMP_ID") = emp_id
                    .Item("DAYSSUSPEND") = daysSuspend
                    .Item("PREPAREDBY") = preparedBy
                    .Item("WRITTEN_PATH") = path
                    .Item("DATE_CREATED") = dateCreated
                    .Item("WRITTEN_STATUS") = status
                    .Item("CORRECTIVE_ACTION") = correctiveAction

                End With
                ds.Tables(0).Rows.Add(dsNewRow)
                SaveEntry(ds)
            End Using

        End If

    End Sub

    Friend Sub SaveCorrectiveAction(irno As String, actionStatus As String, path As String, dateCreated As String)
        Dim mysql As String

        mysql = "Select * FROM IR_REPRIMAND where IRNO = '" & irno & "'"
        Dim dss As DataSet = LoadSQL(mysql, "IR_REPRIMAND")
        If dss.Tables(0).Rows.Count > 0 Then
            With dss.Tables(0).Rows(0)
                .Item("CORRECTIVE_ACTION") = actionStatus
                .Item("CORRECTIVE_PATH") = path
                .Item("CORRECTIVE_DATE") = dateCreated
            End With
            SaveEntry(dss, False)
        End If

    End Sub
    'SaveECS(IRNoWritten_LBL.Text, WP_Name_TXT.Tag, Date.Now, ECSNo_TXT.Text, Charges_Numeric.Text, NoOFMonths_TXT.Text, AmountPerPayroll_TXT.Text)
    Friend Sub SaveECS(IRNo As String, person_ID As String, dateCreated As String, ecsno As String, amount As String, noOfMonths As String, perPayroll As String)
        Console.WriteLine("AAAAAAA " & noOfMonths)
        Dim mysql As String = "Select * From IR_ECS Rows 1"
        Using ds As DataSet = LoadSQL(mysql, "IR_ECS")

            Dim dsNewRow As DataRow = ds.Tables(0).NewRow
            With dsNewRow

                .Item("IRNo") = IRNo
                .Item("person_ID") = person_ID
                .Item("DATE_CREATED") = dateCreated
                .Item("ECSNO") = ecsno
                .Item("AMOUNT") = amount
                .Item("NO_OF_MONTHS") = noOfMonths
                .Item("AMOUNT_PER_PAYROLL") = perPayroll

            End With
            ds.Tables(0).Rows.Add(dsNewRow)
            SaveEntry(ds)
        End Using

    End Sub

    Friend Sub SaveIncidentReport(IRNo As String, suprvisor_ID As String, person_ID As String, incidentLoc As String,
                                  incidentDate As String, ReceivedDate As String, actionTaken As String, Description As String,
                                  preparedby As String, receivedby As String, reviewedby As String, path As String, evidenceImage As Byte(), EVIDENCE_PATH As String)

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
                .Item("RULEVIOLATED") = actionTaken
                .Item("Description") = Description
                .Item("preparedby") = preparedby
                .Item("receivedby") = receivedby
                .Item("reviewedby") = reviewedby
                .Item("IR_PATH") = path
                .Item("EVIDENCE_IMAGE") = evidenceImage
                .Item("EVIDENCE_PATH") = EVIDENCE_PATH

            End With
            ds.Tables(0).Rows.Add(dsNewRow)
            SaveEntry(ds)
        End Using

    End Sub

    Friend Sub SaveToPDF(irno As String, empid As String, pdf As Byte(), path As String, column As String, columnPath As String)

        Dim mysql As String = "Select * FROM IR_PDF where IRNO = '" & irno & "'"
        Dim dss As DataSet = LoadSQL(mysql, "IR_PDF")
        If dss.Tables(0).Rows.Count > 0 Then
            With dss.Tables(0).Rows(0)
                .Item("EMP_NAME") = empid
                .Item(column) = pdf
                .Item(columnPath) = path
            End With
            SaveEntry(dss, False)

        Else

            mysql = "Select * From IR_PDF Rows 1"
            Using ds As DataSet = LoadSQL(mysql, "IR_PDF")

                Dim dsNewRow As DataRow = ds.Tables(0).NewRow
                With dsNewRow

                    .Item("IRNO") = irno
                    .Item("EMP_NAME") = empid
                    .Item(column) = pdf
                    .Item(columnPath) = path

                End With
                ds.Tables(0).Rows.Add(dsNewRow)
                SaveEntry(ds)
            End Using

        End If


    End Sub

    Friend Sub ManpowerSave_AppointedDate(emp_id As String, datee As String)

        Dim mysql As String = "Select * FROM MANPOwER where emp_id = '" & emp_id & "'"
        Dim dss As DataSet = LoadSQL(mysql, "MANPOwER")
        If dss.Tables(0).Rows.Count > 0 Then
            With dss.Tables(0).Rows(0)
                .Item("DATE_APPOINTED") = datee
            End With
            SaveEntry(dss, False)

        Else

            mysql = "Select * From MANPOwER Rows 1"
            Using ds As DataSet = LoadSQL(mysql, "MANPOwER")

                Dim dsNewRow As DataRow = ds.Tables(0).NewRow
                With dsNewRow

                    .Item("emp_id") = emp_id
                    .Item("DATE_APPOINTED") = datee

                End With
                ds.Tables(0).Rows.Add(dsNewRow)
                SaveEntry(ds)
            End Using

        End If

    End Sub

    Friend Sub ManpowerSave_BranchColor(branchCode As String, color As String)

        Dim mysql As String = "Select * FROM MANPOwER_COLOR where BRANCHCODE = '" & branchCode & "'"
        Dim dss As DataSet = LoadSQL(mysql, "MANPOwER_COLOR")
        If dss.Tables(0).Rows.Count > 0 Then
            With dss.Tables(0).Rows(0)
                .Item("BRANCHCOLOR") = color
            End With
            SaveEntry(dss, False)

        Else

            mysql = "Select * From MANPOwER_COLOR Rows 1"
            Using ds As DataSet = LoadSQL(mysql, "MANPOwER_COLOR")

                Dim dsNewRow As DataRow = ds.Tables(0).NewRow
                With dsNewRow

                    .Item("BRANCHCOLOR") = color
                    .Item("BRANCHCODE") = branchCode

                End With
                ds.Tables(0).Rows.Add(dsNewRow)
                SaveEntry(ds)
            End Using

        End If

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
    End Sub


    Friend Sub RemarksSave(irno As String, remarks As String)
        Dim mysql As String = "Select * From SHOWCAUSE_RECORDS where IRNO = '" & irno & "'"
        Using ds As DataSet = LoadSQL(mysql, "SHOWCAUSE_RECORDS")

            With ds.Tables(0).Rows(0)
                .Item("EXPLAIN_REMARKS") = remarks
            End With
            SaveEntry(ds, False)
        End Using
    End Sub

    Friend Sub AcknowledgeSave(irno As String, pic As Byte(), status As String, path As String)

        Dim mysql As String = "Select * From IR_REPRIMAND where IRNO = '" & irno & "'"
        Using ds As DataSet = LoadSQL(mysql, "IR_REPRIMAND")

            With ds.Tables(0).Rows(0)
                .Item("WRITTEN_STATUS") = status
                .Item("ACKNO_IMAGE") = pic
                .Item("ACKNO_PATH") = path
            End With
            SaveEntry(ds, False)
        End Using

    End Sub

    Friend Sub ReceivedSave(irno As String, pic As Byte(), status As String, path As String)

        Dim mysql As String = "Select * From IR_REPRIMAND where IRNO = '" & irno & "'"
        Using ds As DataSet = LoadSQL(mysql, "IR_REPRIMAND")

            With ds.Tables(0).Rows(0)
                .Item("RECEIVE_ACTION") = status
                .Item("RECEIVE_IMAGE") = pic
                .Item("RECEIVE_PATH") = path
            End With
            SaveEntry(ds, False)
        End Using

    End Sub

    Friend Sub SaveTRANSACTIONHistory(USERNAME As String, NAME As String, ActionN As String, BranchN As String, STATUS As String, POSITION As String)
        Dim sql As String = "select * from USER_TRANSACTION rows 1"
        Using ds As DataSet = LoadSQL(sql, "USER_TRANSACTION")
            Dim data As DataRow
            data = ds.Tables(0).NewRow
            With data
                .Item("DATETRANSACTION") = DateTime.Now.ToString("f")
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
