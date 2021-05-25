Public Class frmappointlist
    Dim fromOtherForm As Boolean = False
    Dim frmOrig As FormName
    Dim int As Integer

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub frmappointlist_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadEmployee()
        ListViewGrouping(lvEmployee, 5)
    End Sub

    Friend Sub SearchSelect(ByVal src As String, ByVal frmOrigin As FormName, Optional i As Integer = 0)
        fromOtherForm = True
        btnSelect.Visible = True
        txtSearch.Text = src
        int = i
        frmOrig = frmOrigin

    End Sub

    Private Sub LoadEmployee(Optional ByVal str As String = "")
        Dim secured_str As String = str
        secured_str = DreadKnight(secured_str)
        Dim strWords As String() = secured_str.Split(New Char() {" "c})
        Dim name As String

        Dim mysql As String
        If str.Length <> 0 Then
            mysql = "select * from APPOINTED_LIST Where "
            For Each name In strWords
                mysql &= vbCr & " UPPER(LastName ||' '|| FirstName ||' '|| MiddleName) LIKE UPPER('%" & name & "%') and "
                mysql &= vbCr & "UPPER(FirstName ||' '|| MiddleName ||' '|| LastName) LIKE UPPER('%" & name & "%') and "
                If name Is strWords.Last Then
                    mysql &= vbCr & " UPPER(FirstName ||' '|| LastName ||' '|| MiddleName) LIKE UPPER('%" & name & "%') "
                    Exit For
                End If
            Next
        Else
            mysql = "select * from APPOINTED_LIST"
        End If
        Using ds As DataSet = LoadSQL(mysql, "APPOINTED_LIST")

            lvEmployee.Items.Clear()
            If ds.Tables(0).Rows.Count > 0 Then
                For Each dr In ds.Tables(0).Rows
                    AddItem(dr)
                Next
            End If
        End Using

    End Sub

    Private Sub AddItem(ByVal dr As DataRow)
        With dr
            Dim lv As ListViewItem = lvEmployee.Items.Add(.Item("ID"))
            lv.SubItems.Add(String.Format("{0}, {1} {2}", .Item("LastName"), .Item("FirstName"), .Item("MiddleName")))
            lv.SubItems.Add(.Item("schedule"))
            lv.SubItems.Add(.Item("Remarks"))
            lv.SubItems.Add(.Item("Created_Date"))
            lv.SubItems.Add(.Item("APPOINTED_POSITION").ToString)
            lv.ImageKey = "user_male"
            If .Item("Gender") = "Female" Then
                lv.ImageKey = "user_female"
            End If
        End With
    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        LoadEmployee(txtSearch.Text)
    End Sub

    Private Sub btnSelect_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSelect.Click
        If lvEmployee.Items.Count = 0 Then Exit Sub

        Dim idx As Integer = CInt(lvEmployee.FocusedItem.Text)
        Dim tmpEmp As appointment
        tmpEmp = New appointment
        tmpEmp.Loadappointlist(idx)
        ReloadFormappointmentlist(frmOrig, tmpEmp, int)

        Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadEmployee(txtSearch.Text)
        ListViewGrouping(lvEmployee, 5)
    End Sub

    Private Sub LvEmployee_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lvEmployee.ColumnClick
        SortingOrder(lvEmployee, e.Column)
    End Sub

End Class