Public Class frmnotify
    Private tmpnotify As notify
    Dim manningid, rating As Integer
    'Private ReadOnly rateGroup As ListViewGroup

    Private Sub frmnotify_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadEmployee()
        ListViewGrouping(lvEmployee, 4)
        If lvEmployee.Items.Count <= 0 Then
            Close()
        End If
    End Sub

    Private Sub LoadEmployee(Optional ByVal str As String = "", Optional ByVal i As String = "ASSIGNED")
        Dim secured_str As String = str
        secured_str = DreadKnight(secured_str)
        Dim strWords As String() = secured_str.Split(New Char() {" "c})
        Dim name As String

        Dim mysql As String

        If i = "APPOINTED" Then
            If str.Length <> 0 Then
                mysql = "SELECT * from TBL_EMPLOYEE INNER JOIN TBLMANNING ON TBL_EMPLOYEE.ID=TBLMANNING.EMP_ID" +
                    " INNER JOIN TBL_BRANCH ON TBLMANNING.BRANCH_ID =TBL_BRANCH.ID INNER JOIN TBL_APPOINT ON TBL_EMPLOYEE.ID = TBL_APPOINT.EMP_ID " +
                    " Where TBLMANNING.RATE_STATUS = 0 AND  WORK_STATUS = 1 AND APPOINTED_STATUS = 1 AND VOID = 0 AND WEEK_NOTIFY BETWEEN '" & Date.Now.ToString("MM/dd/yyyy") & "' AND '" & Date.Now.AddDays(7).ToShortDateString & "' AND "
                For Each name In strWords
                    mysql &= vbCr & " UPPER(LastName ||' '|| FirstName ||' '|| MiddleName) LIKE UPPER('%" & name & "%') and "
                    mysql &= vbCr & "UPPER(FirstName ||' '|| MiddleName ||' '|| LastName) LIKE UPPER('%" & name & "%') and "
                    If name Is strWords.Last Then
                        mysql &= vbCr & " UPPER(FirstName ||' '|| LastName ||' '|| MiddleName) LIKE UPPER('%" & name & "%') "
                        Exit For
                    End If
                Next
            Else
                mysql = "SELECT * from TBL_EMPLOYEE INNER JOIN TBLMANNING ON TBL_EMPLOYEE.ID=TBLMANNING.EMP_ID  INNER JOIN TBL_BRANCH " +
                    "ON TBLMANNING.BRANCH_ID =TBL_BRANCH.ID INNER JOIN TBL_APPOINT ON TBL_EMPLOYEE.ID = TBL_APPOINT.EMP_ID " +
                    "WHERE TBLMANNING.RATE_STATUS = 0 AND WORK_STATUS = 1 AND APPOINTED_STATUS = 1 AND VOID = 0 AND WEEK_NOTIFY BETWEEN '" & Date.Now.ToString("MM/dd/yyyy") & "' AND '" & Date.Now.AddDays(7).ToShortDateString & "' " +
                    "or WORK_STATUS='1' AND MONTH_NOTIFY BETWEEN '" & Date.Now.ToShortDateString & "' AND '" & Date.Now.AddMonths(1).ToShortDateString & "' ORDER BY TBLMANNING.ID DESC"
            End If
            Using ds As DataSet = LoadSQL(mysql)
                Dim RowCount As New Integer
                RowCount = ds.Tables(0).Rows.Count
                frmMainForm.AppProgressBar.Maximum = RowCount
                frmMainForm.AppProgressBar.Visible = True
                lvEmployee.Items.Clear()
                For Each dr In ds.Tables(0).Rows
                    AddItem(dr, "APPOINTED")
                    frmMainForm.AppProgressBar.Value += 1

                Next
            End Using
            frmMainForm.AppProgressBar.Value = 0
            frmMainForm.AppProgressBar.Visible = False
        ElseIf i = "ASSIGNED" Then
            If str.Length <> 0 Then
                mysql = "SELECT * from TBL_EMPLOYEE INNER JOIN TBLMANNING ON TBL_EMPLOYEE.ID=TBLMANNING.EMP_ID" +
                    " INNER JOIN TBL_BRANCH ON TBLMANNING.BRANCH_ID =TBL_BRANCH.ID " +
                    " Where TBLMANNING.RATE_STATUS = 0 AND WORK_STATUS = 1 AND APPOINTED_STATUS = 0 AND VOID = 0 AND WEEK_NOTIFY BETWEEN '" & Date.Now.ToString("MM/dd/yyyy") & "' AND '" & Date.Now.AddDays(7).ToShortDateString & "' AND " +
                    " MONTH_NOTIFY BETWEEN '" & Date.Now.ToShortDateString & "' AND '" & Date.Now.AddMonths(1).ToShortDateString & "' AND "
                For Each name In strWords
                    mysql &= vbCr & " UPPER(LastName ||' '|| FirstName ||' '|| MiddleName) LIKE UPPER('%" & name & "%') and "
                    mysql &= vbCr & "UPPER(FirstName ||' '|| MiddleName ||' '|| LastName) LIKE UPPER('%" & name & "%') and "
                    If name Is strWords.Last Then
                        mysql &= vbCr & " UPPER(FirstName ||' '|| LastName ||' '|| MiddleName) LIKE UPPER('%" & name & "%') "
                        Exit For
                    End If
                Next
            Else
                mysql = "SELECT * from TBL_EMPLOYEE INNER JOIN TBLMANNING ON TBL_EMPLOYEE.ID=TBLMANNING.EMP_ID  INNER JOIN TBL_BRANCH " +
                    "ON TBLMANNING.BRANCH_ID =TBL_BRANCH.ID " +
                    "WHERE TBLMANNING.RATE_STATUS = 0 AND WORK_STATUS = 1 AND APPOINTED_STATUS = 0 AND VOID = 0 AND WEEK_NOTIFY BETWEEN '" & Date.Now.ToString("MM/dd/yyyy") & "' AND '" & Date.Now.AddDays(7).ToShortDateString & "' " +
                "or WORK_STATUS='1' AND MONTH_NOTIFY BETWEEN '" & Date.Now.ToShortDateString & "' AND '" & Date.Now.AddMonths(1).ToShortDateString & "' ORDER BY TBLMANNING.ID DESC"
            End If
            Using ds As DataSet = LoadSQL(mysql)
                Dim RowCount As Integer = ds.Tables(0).Rows.Count
                frmMainForm.AppProgressBar.Value = 0
                frmMainForm.AppProgressBar.Maximum = RowCount
                frmMainForm.AppProgressBar.Visible = True
                lvEmployee.Items.Clear()
                For Each dr In ds.Tables(0).Rows
                    AddItem(dr, "ASSIGNED")
                    frmMainForm.AppProgressBar.Value += 1

                Next
            End Using
            frmMainForm.AppProgressBar.Value = 0
            frmMainForm.AppProgressBar.Visible = False
        End If

    End Sub

    Private Sub AddItem(ByVal dr As DataRow, Optional str As String = "")
        With dr
            If .Item("APPOINTED_STATUS") = 0 Then
                If .Item("RATE_STATUS") = 1 Or .Item("VOID") = 1 Then
                    Exit Sub
                End If

                Dim lv As ListViewItem = lvEmployee.Items.Add(.Item("ID1"))
                lv.SubItems.Add(String.Format("{0}, {1} {2}", .Item("LastName"), .Item("FirstName"), .Item("MiddleName")))

                lv.SubItems.Add(.Item("EMP_POSITION"))
                lv.SubItems.Add(.Item("COMPANYNAME"))
                lv.SubItems.Add(.Item("BRANCHNAME"))
                lv.SubItems.Add(.Item("BRANCHCODE"))
                lv.SubItems.Add(.Item("BRANCHAREA"))

                lv.SubItems.Add(.Item("ASSIGN_DATE"))
                lv.ImageKey = "imgMale"
                If .Item("Gender") = "Female" Then
                    lv.ImageKey = "imgFemale"
                End If

                Dim mySql As String = "SELECT * from TBL_RATE  WHERE TBL_RATE.MANNING_ID  ='" & .Item("ID1") & "'"
                Dim ds As DataSet = LoadSQL(mySql)
                If ds.Tables(0).Rows.Count = 0 Then
                    lv.SubItems.Add("RATE ME")
                Else
                    For Each drx In ds.Tables(0).Rows

                        If drx.item("RATE").ToString() = "1" Then
                            lv.SubItems.Add("PASS")
                        ElseIf drx.item("RATE").ToString() = "0" Then
                            lv.SubItems.Add("FAILED")
                        End If

                    Next
                End If
                lv.SubItems.Add(str)
            ElseIf .Item("APPOINTED_STATUS") = 1 Then
                If .Item("RATE_STATUS") = 1 Or .Item("VOID") = 1 Then
                    Exit Sub
                End If

                Dim lv As ListViewItem = lvEmployee.Items.Add(.Item("ID1"))
                lv.SubItems.Add(String.Format("{0}, {1} {2}", .Item("LastName"), .Item("FirstName"), .Item("MiddleName")))

                lv.SubItems.Add(.Item("EMP_POSITION"))
                lv.SubItems.Add(.Item("COMPANYNAME"))
                lv.SubItems.Add(.Item("BRANCHNAME"))
                lv.SubItems.Add(.Item("BRANCHCODE"))
                lv.SubItems.Add(.Item("BRANCHAREA"))

                lv.SubItems.Add(.Item("ASSIGN_DATE"))
                lv.ImageKey = "imgMale"
                If .Item("Gender") = "Female" Then
                    lv.ImageKey = "imgFemale"
                End If

                Dim mySql As String = "SELECT * from TBL_RATE  WHERE TBL_RATE.MANNING_ID  ='" & .Item("ID1") & "'"
                Using ds As DataSet = LoadSQL(mySql)
                    If ds.Tables(0).Rows.Count = 0 Then
                        lv.SubItems.Add("RATE ME")
                    Else
                        For Each drx In ds.Tables(0).Rows

                            If drx.item("RATE").ToString() = "1" Then
                                lv.SubItems.Add("PASS")
                            ElseIf drx.item("RATE").ToString() = "0" Then
                                lv.SubItems.Add("FAILED")
                            End If

                        Next
                    End If
                End Using
                lv.SubItems.Add(str)
            End If

        End With
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        If manningid = 0 Then Exit Sub

        tmpnotify = New notify
        With tmpnotify
            .ManningID = manningid

            If rdioPass.Checked = True Then
                rating = 1
            Else
                rating = 0

            End If
            .Rate = rating

            Dim mySql As String = "SELECT * from TBL_RATE  WHERE TBL_RATE.MANNING_ID  ='" & manningid & "'"
            Using ds As DataSet = LoadSQL(mySql)

                If ds.Tables(0).Rows.Count = 1 Then
                    .UpdateNotify()
                    MessageBox.Show(txtname.Text & "SUCCESSFULLY UPDATED")
                Else

                    .SAVENOTIFY()
                    MessageBox.Show(txtname.Text & "SUCCESSFULLY RATE")

                End If
            End Using

            manningid = 0
            txtname.Text = "VAL RULETE"
            LoadEmployee()
        End With
        ListViewGrouping(lvEmployee, 4)
    End Sub

    Private Sub lvEmployee_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lvEmployee.DoubleClick
        manningid = lvEmployee.SelectedItems(0).SubItems(0).Text
        txtname.Text = lvEmployee.SelectedItems(0).SubItems(1).Text
        If lvEmployee.SelectedItems(0).SubItems(8).Text = "PASS" Then
            rdioPass.Checked = True
            rdioFailed.Checked = False

        ElseIf lvEmployee.SelectedItems(0).SubItems(1).Text = "FAILED" Then
            rdioPass.Checked = False
            rdioFailed.Checked = True
        End If
    End Sub

    Private Sub Assigned_RBTN_CheckedChanged(sender As Object, e As EventArgs) Handles Assigned_RBTN.CheckedChanged
        LoadEmployee(Search_TXT.Text, IIf(Assigned_RBTN.Checked = True, "ASSIGNED", "APPOINTED"))
        ListViewGrouping(lvEmployee, 4)
    End Sub

    Private Sub LvEmployee_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lvEmployee.ColumnClick
        SortingOrder(lvEmployee, e.Column)
    End Sub

    Private Sub Search_TXT_TextChanged(sender As Object, e As EventArgs) Handles Search_TXT.TextChanged
        LoadEmployee(Search_TXT.Text, IIf(Assigned_RBTN.Checked = True, "ASSIGNED", "APPOINTED"))
        ListViewGrouping(lvEmployee, 4)
    End Sub

End Class