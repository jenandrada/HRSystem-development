Public Class frmSCList

    Dim rowCount As New Integer

    Private Sub Close_BTN_Click(sender As Object, e As EventArgs) Handles Close_BTN.Click
        Close()
    End Sub

    Private Sub lvEmployee_MouseDoubleClick(sender As Object, e As MouseEventArgs)

        If lvEmployee.Items.Count = 0 Then Exit Sub

        Dim idx As Integer = lvEmployee.FocusedItem.Text
        Dim tmpEmp As Employee
        tmpEmp = New Employee


        If txtSearch.Tag = "Written" Then

            tmpEmp.LoadCorrectiveDetails(idx)
            ReloadFormFromSearch(FormName.corrective, tmpEmp, 2)

        End If

        Close()

    End Sub

    Private Sub LoadShowCause(Optional ByVal str As String = "")

        Dim secured_str As String = str
        secured_str = DreadKnight(secured_str)
        Dim strWords As String() = secured_str.Split(New Char() {" "c})
        Dim name As String

        Dim mysql As String
        If str.Length <> 0 Then

            mysql = "SELECT * FROM SHOWCAUSE_RECORDS A INNER JOIN TBL_EMPLOYEE B ON B.ID = A.EMP_ID where"

            For Each name In strWords
                mysql &= $"{vbCr} UPPER(B.LastName ||' '|| B.FirstName ||' '|| B.MiddleName) LIKE UPPER('%{name}%') or "
                mysql &= $"{vbCr} UPPER(B.FirstName ||' '|| B.MiddleName ||' '|| B.LastName) LIKE UPPER('%{name}%') or "

                If name Is strWords.Last Then
                    mysql &= $"{vbCr} UPPER(B.FirstName ||' '|| B.LastName ||' '|| B.MiddleName) LIKE UPPER('%{name}%')"
                    Exit For
                End If
            Next

        Else
            mysql = "SELECT * FROM SHOWCAUSE_RECORDS A INNER JOIN TBL_EMPLOYEE B ON B.ID = A.EMP_ID "
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

            If .Item("STATUS") = "NO" Then
                lv.BackColor = Color.LightSalmon
            End If

        End With
    End Sub

    Private Sub LoadIRNo(str As String)

        Dim mysql As String
        If str.Length <> 0 Then
            mysql = "SELECT * FROM SHOWCAUSE_RECORDS A INNER JOIN TBL_EMPLOYEE B ON B.ID = A.EMP_ID where A.IRNO = '" & str & "'"
        Else
            mysql = "SELECT * FROM SHOWCAUSE_RECORDS A INNER JOIN TBL_EMPLOYEE B ON B.ID = A.EMP_ID "
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

    Private Sub frmSCList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadShowCause()
    End Sub

    Private Sub IRNo_BTN_Click(sender As Object, e As EventArgs) Handles IRNo_BTN.Click
        LoadIRNo(IRNo_TXT.Text)
        IRNo_TXT.Text = ""
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadShowCause(txtSearch.Text)
        txtSearch.Text = ""
    End Sub

    Private Sub lvEmployee_MouseDoubleClick_1(sender As Object, e As MouseEventArgs) Handles lvEmployee.MouseDoubleClick

        If lvEmployee.Items.Count = 0 Then Exit Sub

        Dim idx As Integer = lvEmployee.FocusedItem.Text
        Dim tmpEmp As Employee
        tmpEmp = New Employee

        If txtSearch.Tag = "Written" Then

            tmpEmp.LoadCorrectiveDetails(idx)
            ReloadFormFromSearch(FormName.corrective, tmpEmp, 2)

        End If

        Close()

    End Sub
End Class