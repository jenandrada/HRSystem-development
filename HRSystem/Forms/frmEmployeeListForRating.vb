Public Class frmEmployeeListForRating
    'Dim lst As New EMPLIST_BRANCH
    Dim fromOtherForm As Boolean = False
    Dim frmOrig As FormName

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Search_BTN.Click
        LoadEmployee(Search_TXT.Text, IIf(Assigned_RBTN.Checked = True, "ASSIGNED", "APPOINTED"))
        ListViewGrouping(lvEmployee, 4)
    End Sub

    Private Sub LoadEmployee(Optional ByVal str As String = "", Optional ByVal mode As String = "")
        Dim secured_str As String = str
        secured_str = DreadKnight(secured_str)
        Dim strWords As String() = secured_str.Split(New Char() {" "c})
        Dim name As String

        Dim mysql As String
        If mode = "ASSIGNED" Then
            If str.Length <> 0 Then
                mysql = "Select * From APPOINTED_VIEW Where APPOINTED_STATUS = 0 AND "
                For Each name In strWords
                    mysql &= vbCr & " UPPER(LastName ||' '|| FirstName ||' '|| MiddleName) LIKE UPPER('%" & name & "%') and "
                    mysql &= vbCr & "UPPER(FirstName ||' '|| MiddleName ||' '|| LastName) LIKE UPPER('%" & name & "%') and "
                    If name Is strWords.Last Then
                        mysql &= vbCr & " UPPER(FirstName ||' '|| LastName ||' '|| MiddleName) LIKE UPPER('%" & name & "%') "
                        Exit For
                    End If
                Next
            Else
                mysql = "Select * From APPOINTED_VIEW WHERE APPOINTED_STATUS = 0"
            End If
            Dim ds As DataSet = LoadSQL(mysql, "APPOINTED_VIEW")

            lvEmployee.Items.Clear()
            For Each dr In ds.Tables(0).Rows
                AddItemASSIGNED(dr)
            Next
        ElseIf mode = "APPOINTED" Then
            If str.Length <> 0 Then
                mysql = "Select * From APPOINTED_VIEW Where APPOINTED_STATUS = 1 AND "
                For Each name In strWords
                    mysql &= vbCr & " UPPER(LastName ||' '|| FirstName ||' '|| MiddleName) LIKE UPPER('%" & name & "%') and "
                    mysql &= vbCr & "UPPER(FirstName ||' '|| MiddleName ||' '|| LastName) LIKE UPPER('%" & name & "%') and "
                    If name Is strWords.Last Then
                        mysql &= vbCr & " UPPER(FirstName ||' '|| LastName ||' '|| MiddleName) LIKE UPPER('%" & name & "%') "
                        Exit For
                    End If
                Next
            Else
                mysql = "Select * From APPOINTED_VIEW WHERE APPOINTED_STATUS = 1"
            End If
            Dim ds As DataSet = LoadSQL(mysql, "APPOINTED_VIEW")

            lvEmployee.Items.Clear()
            For Each dr In ds.Tables(0).Rows
                AddItemAPPOINTED(dr)
            Next
        End If

    End Sub

    Private Sub AddItemASSIGNED(ByVal dr As DataRow)
        With dr
            Dim lv As ListViewItem = lvEmployee.Items.Add(.Item("MID"))
            lv.SubItems.Add(String.Format("{0}, {1} {2}", .Item("LASTNAME"), .Item("FIRSTNAME"), .Item("MIDDLENAME")))
            lv.SubItems.Add(.Item("ContactNo"))
            lv.SubItems.Add(.Item("EmailAdd"))
            lv.SubItems.Add(.Item("EMP_POSITION"))
            lvEmployee.Columns(4).Text = "Assigned As"
        End With
    End Sub

    Private Sub AddItemAPPOINTED(ByVal dr As DataRow)
        With dr
            Dim lv As ListViewItem = lvEmployee.Items.Add(.Item("MID"))
            lv.SubItems.Add(String.Format("{0}, {1} {2}", .Item("LastName"), .Item("FirstName"), .Item("MiddleName")))
            lv.SubItems.Add(.Item("ContactNo"))
            lv.SubItems.Add(.Item("EmailAdd"))
            lv.SubItems.Add(.Item("EMP_POSITION"))
            lvEmployee.Columns(4).Text = "Appointed As"
        End With
    End Sub

    Private Sub frmEmployeeListForRating_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployee()
    End Sub

    Private Sub Search_TXT_TextChanged(sender As Object, e As EventArgs) Handles Search_TXT.TextChanged
        LoadEmployee(Search_TXT.Text, IIf(Assigned_RBTN.Checked = True, "ASSIGNED", "APPOINTED"))
        ListViewGrouping(lvEmployee, 4)
    End Sub

    Private Sub Select_BTN_Click(sender As Object, e As EventArgs) Handles Select_BTN.Click
        If lvEmployee.Items.Count = 0 And lvEmployee.SelectedItems.Count = 0 Then Exit Sub

        If lvEmployee.SelectedItems.Count > 0 Then
            Dim idx As Integer = CInt(lvEmployee.SelectedItems(0).SubItems(0).Text)
            Dim tmpEmp As EMPLIST_BRANCH
            tmpEmp = New EMPLIST_BRANCH
            tmpEmp.LoadEMPLISTBRANCH(idx)
            ReloadFormRateEmp(frmOrig, tmpEmp)

            Close()
        End If
    End Sub

    Friend Sub SearchSelect(ByVal src As String, ByVal frmOrigin As FormName)
        fromOtherForm = True
        Select_BTN.Visible = True
        Search_TXT.Text = src
        frmOrig = frmOrigin
    End Sub

    Private Sub Cancel_BTN_Click(sender As Object, e As EventArgs) Handles Cancel_BTN.Click
        Close()
    End Sub

    Private Sub Assigned_RBTN_CheckedChanged(sender As Object, e As EventArgs) Handles Assigned_RBTN.CheckedChanged
        LoadEmployee(Search_TXT.Text, IIf(Assigned_RBTN.Checked = True, "ASSIGNED", "APPOINTED"))
        Label1.Text = IIf(Assigned_RBTN.Checked = True, "ASSIGNED", "APPOINTED") + " LIST"
        ListViewGrouping(lvEmployee, 4)
    End Sub

    Private Sub LvEmployee_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lvEmployee.ColumnClick
        SortingOrder(lvEmployee, e.Column)
    End Sub

End Class