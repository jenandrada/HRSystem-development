Public Class frmSCList
    Private Sub Close_BTN_Click(sender As Object, e As EventArgs) Handles Close_BTN.Click
        Close()
    End Sub

    Private Sub lvEmployee_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvEmployee.MouseDoubleClick

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