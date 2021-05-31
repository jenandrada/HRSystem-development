﻿Public Class frmIRList

    Dim rowCount As New Integer

    Private Sub IRList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployee()
    End Sub

    Private Sub LoadEmployee(Optional ByVal str As String = "")

        Dim secured_str As String = str
        secured_str = DreadKnight(secured_str)
        Dim strWords As String() = secured_str.Split(New Char() {" "c})
        Dim name As String

        Dim mysql As String
        If str.Length <> 0 Then
            mysql = "SELECT * from IR_RECORDS INNER JOIN TBL_EMPLOYEE ON TBL_EMPLOYEE.ID = IR_RECORDS.PERSON_ID"

            For Each name In strWords
                mysql &= $"{vbCr} UPPER(LastName ||' '|| FirstName ||' '|| MiddleName) LIKE UPPER('%{name}%') or "
                mysql &= $"{vbCr}UPPER(FirstName ||' '|| MiddleName ||' '|| LastName) LIKE UPPER('%{name}%') or "
                If name Is strWords.Last Then
                    mysql &= $"{vbCr} UPPER(FirstName ||' '|| LastName ||' '|| MiddleName) LIKE UPPER('%{name}%') "
                    Exit For
                End If
            Next
        Else
            mysql = "SELECT * from IR_RECORDS INNER JOIN TBL_EMPLOYEE ON TBL_EMPLOYEE.ID = IR_RECORDS.PERSON_ID"
        End If

        Dim ds As DataSet = LoadSQL(mysql, "IR_RECORDS")
        Dim maxEntries As New Integer

        rowCount = ds.Tables(0).Rows.Count
        maxEntries = ds.Tables(0).Rows.Count
        frmMainForm.AppProgressBar.Maximum = maxEntries
        frmMainForm.AppProgressBar.Visible = True
        lvEmployee.Items.Clear()

        For Each dr In ds.Tables(0).Rows
            AddItem(dr)
            frmMainForm.AppProgressBar.Value += 1
        Next

        frmMainForm.AppProgressBar.Value = 0
        frmMainForm.AppProgressBar.Visible = False

    End Sub

    Private Sub AddItem(ByVal dr As DataRow)
        With dr

            Dim DateIncident As Date = .Item("INCIDENTDATE")
            DateIncident.ToString("MMMM dd, yyyy")

            Dim lv As ListViewItem = lvEmployee.Items.Add(Format(.Item("IRNO"), "00000"))
            lv.SubItems.Add($"{ .Item("LastName") }, { .Item("FirstName") } { .Item("MiddleName") }")
            lv.SubItems.Add(DateIncident)
            lv.SubItems.Add(.Item("ACTIONTAKEN"))
            lv.SubItems.Add(.Item("PREPAREDBY"))
            lv.ImageKey = "imgMale"

            If .Item("Gender") = "Female" Then
                lv.ImageKey = "imgFemale"
            End If

        End With
    End Sub

    Private Sub lvEmployee_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvEmployee.MouseDoubleClick

        If lvEmployee.Items.Count = 0 Then Exit Sub

        Dim idx As Integer = lvEmployee.FocusedItem.Text
        Dim tmpEmp As Employee
        tmpEmp = New Employee


        If txtSearch.Tag = "ShowCause" Then

            tmpEmp.LoadCorrectiveDetails(idx)
            ReloadFormFromSearch(FormName.corrective, tmpEmp, 1)

        End If

        Close()
    End Sub

End Class