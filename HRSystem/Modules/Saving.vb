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

    Public Sub GetSCNo(SCNO As Label)

        Dim mysql As String = "Select MAX(ID) + 1  As Greatest FROM SHOWCAUSE_RECORDS"
        Using ds As DataSet = LoadSQL(mysql)

            Dim dr As DataRow = ds.Tables(0).Rows(0)
            If dr.Table.Rows.Count > 0 Then
                With dr
                    SCNO.Text = Format(.Item("Greatest"), "00000")

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
        Dim mysql As String = "Select * From SHOWCAUSE_RECORDS Where SCNO = '" & scno & "'"
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
