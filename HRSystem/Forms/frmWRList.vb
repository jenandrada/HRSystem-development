Public Class frmWRList

    Dim rowCount As New Integer

    Private Sub Close_BTN_Click(sender As Object, e As EventArgs) Handles Close_BTN.Click
        Close()
    End Sub

    Private Sub frmWRList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadWritten()
    End Sub

    Private Sub LoadWritten(Optional ByVal str As String = "")

        Dim secured_str As String = str
        secured_str = DreadKnight(secured_str)
        Dim strWords As String() = secured_str.Split(New Char() {" "c})
        Dim name As String

        Dim mysql As String
        If str.Length <> 0 Then

            mysql = "SELECT * FROM SHOWCAUSE_RECORDS A 
                                INNER JOIN TBL_EMPLOYEE B ON B.ID = A.EMP_ID 
                                INNER JOIN IR_REPRIMAND C ON C.IRNO = A.IRNO where C.WRITTEN_STATUS = 'DONE' and "

            For Each name In strWords
                mysql &= $"{vbCr} UPPER(B.LastName ||' '|| B.FirstName ||' '|| B.MiddleName) LIKE UPPER('%{name}%') or "
                mysql &= $"{vbCr} UPPER(B.FirstName ||' '|| B.MiddleName ||' '|| B.LastName) LIKE UPPER('%{name}%') or "

                If name Is strWords.Last Then
                    mysql &= $"{vbCr} UPPER(B.FirstName ||' '|| B.LastName ||' '|| B.MiddleName) LIKE UPPER('%{name}%')"
                    Exit For
                End If
            Next

        Else
            'mysql = "SELECT * FROM SHOWCAUSE_RECORDS A INNER JOIN TBL_EMPLOYEE B ON B.ID = A.EMP_ID "

            mysql = "SELECT * FROM SHOWCAUSE_RECORDS A 
                                INNER JOIN TBL_EMPLOYEE B ON B.ID = A.EMP_ID 
                                INNER JOIN IR_REPRIMAND C ON C.IRNO = A.IRNO where C.WRITTEN_STATUS = 'DONE'"
        End If

        Dim ds As DataSet = LoadSQL(mysql, "SHOWCAUSE_RECORDS")
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

            Dim DateIssued As DateTime = CDate(.Item("DATE_ISSUED"))

            Dim lv As ListViewItem = lvEmployee.Items.Add(Format(.Item("IRNO"), "00000"))
            lv.SubItems.Add($"{ .Item("LastName") }, { .Item("FirstName") } { .Item("MiddleName") }")
            lv.SubItems.Add(DateIssued.ToString("MMMM d, yyyy"))
            lv.SubItems.Add(.Item("COMPANY"))
            lv.ImageKey = "imgMale"

            If .Item("Gender") = "Female" Then
                lv.ImageKey = "imgFemale"
            End If

        End With

    End Sub

    Private Sub lvEmployee_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvEmployee.MouseDoubleClick

        If lvEmployee.Items.Count = 0 Then Exit Sub

        Dim irno As Integer = lvEmployee.FocusedItem.Text
        Dim tmpEmp As Employee
        tmpEmp = New Employee

        If txtSearch.Tag = "Corrective Action" Then

            tmpEmp.LoadCorrectiveDetails(irno)
            ReloadFormFromSearch(FormName.incidentReport, tmpEmp, 2, "CORRECTIVE")

        End If

        Close()

    End Sub


    Private Sub LoadIRNo(str As String)

        Dim int As Integer
        Dim mysql As String

        If Double.TryParse(str, int) Then

            If str.Length <> 0 Then

                mysql = "SELECT * FROM SHOWCAUSE_RECORDS A 
                                INNER JOIN TBL_EMPLOYEE B ON B.ID = A.EMP_ID 
                                INNER JOIN IR_REPRIMAND C ON C.IRNO = A.IRNO where C.WRITTEN_STATUS = 'DONE' and A.IRNO = '" & str & "'"
            Else

                mysql = "SELECT * FROM SHOWCAUSE_RECORDS A 
                                INNER JOIN TBL_EMPLOYEE B ON B.ID = A.EMP_ID 
                                INNER JOIN IR_REPRIMAND C ON C.IRNO = A.IRNO where C.WRITTEN_STATUS = 'DONE' "
            End If

            Dim ds As DataSet = LoadSQL(mysql, "SHOWCAUSE_RECORDS")
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

        Else
            MsgBox("Invalid! You entered a Nonnumerical data.", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadWritten(txtSearch.Text)
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        btnSearch.PerformClick()
    End Sub

    Private Sub IRNo_TXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IRNo_TXT.KeyPress
        IRNo_BTN.PerformClick()
    End Sub

    Private Sub IRNo_BTN_Click(sender As Object, e As EventArgs) Handles IRNo_BTN.Click
        LoadIRNo(IRNo_TXT.Text)
    End Sub

End Class