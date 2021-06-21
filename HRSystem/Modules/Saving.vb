Imports FirebirdSql.Data.FirebirdClient


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

    Friend Sub ImagesSaveEmployeeDetails(EMP_ID As String, profile As Byte(), sss As Byte(), philheath As Byte(),
                                         pagibig As Byte(), tin As Byte(), barangay As Byte(), cedula As Byte(),
                                         police As Byte(), nbi As Byte(), healthCard As Byte(), mayors As Byte(),
                                         pds As Byte(), proba As Byte(), moa As Byte(), idform As Byte(), aLetter As Byte(), eLetter As Byte())
        Dim reqID As String

        Dim mysql As String = "Select * FROM TBL_REQARCHIVE where EMP_ID = '" & EMP_ID & "'"
        Dim dss As DataSet = LoadSQL(mysql, "TBL_REQARCHIVE")
        If dss.Tables(0).Rows.Count > 0 Then
            With dss.Tables(0).Rows(0)

                .Item("SSS") = sss
                .Item("PHILHEALTH") = philheath
                .Item("PAGIBIG") = pagibig
                .Item("TIN") = tin
                .Item("BARANGAYCLEARANCE") = barangay
                .Item("CEDULA") = cedula
                .Item("POLICECLEARANCE") = police
                .Item("NBICLEARANCE") = nbi
                .Item("HEALTHCARD") = healthCard
                .Item("MAYORSPERMIT") = mayors
                .Item("PDS") = pds
                .Item("PROBA") = proba
                .Item("MOA") = moa
                .Item("IDFORM") = idform
                .Item("ACKNOWLEDGEMENTLETTER") = aLetter
                .Item("ENDORSEMENTLETTER") = eLetter

            End With
            SaveEntry(dss, False)


            Console.WriteLine("EMPID Update" & EMP_ID)

        Else

            Dim mysqll As String = "Select * FROM TBL_REQ where EMPLOYEE_ID = '" & EMP_ID & "'"
            Dim ds As DataSet = LoadSQL(mysqll, "TBL_REQ")
            If ds.Tables(0).Rows.Count > 0 Then
                Dim dr As DataRow = ds.Tables(0).Rows(0)
                With dr
                    reqID = .Item("REQ_ID")
                End With

                Console.WriteLine("REQID SAve NAA SA TB_REQ " & reqID)
            Else

                Dim sql As String = "select MAX(REQ_ID) + 1 AS GREATEST from TBL_REQ rows 1"
                DbReaderOpen()
                Using dr As FbDataReader = LoadSQL_byDataReader(sql)
                    While dr.Read()
                        If dr.HasRows Then
                            With dr
                                reqID = .Item("GREATEST").ToString
                            End With
                        End If
                    End While
                End Using

                Console.WriteLine("REQID SAve NEW the Greates " & reqID)
            End If


            Dim mysqlll As String = "Select * From TBL_REQARCHIVE Rows 1"
            Using dssss As DataSet = LoadSQL(mysqlll, "TBL_REQARCHIVE")

                Dim dsNewRow As DataRow = dssss.Tables(0).NewRow
                With dsNewRow

                    .Item("REQ_ID") = reqID
                    .Item("SSS") = sss
                    .Item("PHILHEALTH") = philheath
                    .Item("PAGIBIG") = pagibig
                    .Item("TIN") = tin
                    .Item("BARANGAYCLEARANCE") = barangay
                    .Item("CEDULA") = cedula
                    .Item("POLICECLEARANCE") = police
                    .Item("NBICLEARANCE") = nbi
                    .Item("HEALTHCARD") = healthCard
                    .Item("MAYORSPERMIT") = mayors
                    .Item("PDS") = pds
                    .Item("PROBA") = proba
                    .Item("MOA") = moa
                    .Item("IDFORM") = idform
                    .Item("ACKNOWLEDGEMENTLETTER") = aLetter
                    .Item("ENDORSEMENTLETTER") = eLetter
                    .Item("EMP_ID") = EMP_ID

                End With
                dssss.Tables(0).Rows.Add(dsNewRow)
                SaveEntry(dssss)

            End Using

        End If

        'Profile pic "select * from TBL_PROFILEPIC rows 1" ====================================

        mysql = "Select * FROM TBL_PROFILEPIC where EMP_ID = '" & EMP_ID & "'"
        Dim dsss As DataSet = LoadSQL(mysql, "TBL_PROFILEPIC")
        If dsss.Tables(0).Rows.Count > 0 Then
            With dsss.Tables(0).Rows(0)
                .Item("PROFILE_PIC") = profile
            End With
            SaveEntry(dsss, False)

        Else

            mysql = "Select * From TBL_PROFILEPIC Rows 1"
            Using ds As DataSet = LoadSQL(mysql, "TBL_PROFILEPIC")

                Dim dsNewRow As DataRow = ds.Tables(0).NewRow
                With dsNewRow
                    .Item("EMP_ID") = EMP_ID
                    .Item("PROFILE_PIC") = profile
                End With
                ds.Tables(0).Rows.Add(dsNewRow)
                SaveEntry(ds)
            End Using

        End If
    End Sub


End Module
