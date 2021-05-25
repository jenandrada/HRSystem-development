Public Class frmUser
    Private ComUser As EmpUser

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        Cleatext()
    End Sub

    Private Sub Cleatext()
        txtUserName.Clear()
        txtPassword.Clear()
        txtRetype.Clear()
        txtFirstname.Clear()
        txtMiddlename.Clear()
        txtLastName.Clear()
        cbStatus.Checked = True
        btnSave.Text = "&Save"
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        If btnSave.Text = "&Save" Then
            If Not isValidUser() Then Exit Sub
            ComUser = New EmpUser
            With ComUser
                .UserName = txtUserName.Text
                .UserPass = EncryptString(txtPassword.Text)
                .FirstName = txtFirstname.Text.ToUpperInvariant
                .MiddleName = txtMiddlename.Text.ToUpperInvariant
                .LastName = txtLastName.Text.ToUpperInvariant
                .SaveUser()
            End With
            MsgBox("New User Added", MsgBoxStyle.Information, "Information")
        Else
            With ComUser
                .UserPass = EncryptString(txtPassword.Text)
                .Status = IIf(cbStatus.Checked = True, 1, 0)
                .UpdateUser()
            End With
            MsgBox("User Updated", MsgBoxStyle.Information, "Information")
        End If
        LoadUser()
        Cleatext()
    End Sub

    Private Function isValidUser()
        If String.IsNullOrWhiteSpace(txtUserName.Text) Then MsgBox("Invalid UserName", MsgBoxStyle.Critical, "Error") : Return False
        If String.IsNullOrWhiteSpace(txtPassword.Text) Then MsgBox("Invalid Password", MsgBoxStyle.Critical, "Error") : Return False
        If String.IsNullOrWhiteSpace(txtFirstname.Text) Then MsgBox("Invalid Firstname", MsgBoxStyle.Critical, "Error") : Return False
        If String.IsNullOrWhiteSpace(txtLastName.Text) Then MsgBox("Invalid Lastname", MsgBoxStyle.Critical, "Error") : Return False
        If txtPassword.Text <> txtRetype.Text Then MsgBox("Password Not Match", MsgBoxStyle.Critical, "Error") : Return False
        Return True
        End Function

    Private Sub txtSearch_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If IsEnter(e) Then btnSearch.PerformClick()
    End Sub

    Private Sub lvUser_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles lvUser.DoubleClick
        If lvUser.SelectedItems.Count = 0 Then Exit Sub

        Dim idx As Integer = lvUser.FocusedItem.Text
        Dim ComUser As EmpUser
        ComUser = New EmpUser
        ComUser.LoadUser(idx)
        LoadUserInfo(ComUser)
    End Sub

    Private Sub LoadUserInfo(ByVal tmp As EmpUser)
        With tmp
            txtUserName.Text = .UserName
            txtFirstname.Text = .FirstName
            txtMiddlename.Text = .MiddleName
            txtLastName.Text = .LastName
            cbStatus.Checked = .Status
            btnSave.Text = "&Update"
        End With
        ComUser = tmp
    End Sub

    Private Sub frmUser_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadUser()
    End Sub

    Private Sub LoadUser(Optional ByVal str As String = "")
        Dim mysql As String
        Dim secured_str As String = str
        secured_str = DreadKnight(secured_str)

        If str.Length <> 0 Then
            mysql = "Select * From tblUser Where Upper(FirstName) Like Upper('%" & secured_str & "%') Or Upper(LastName) Like Upper('%" & secured_str & "%')"
        Else
            mysql = "Select * From tblUser"
        End If
        Dim ds As DataSet = LoadSQL(mysql, "tblUser")

        lvUser.Items.Clear()
        For Each dr In ds.Tables(0).Rows
            LoadItem(dr)
        Next
    End Sub

    Private Sub LoadItem(ByVal dr As DataRow)
        Dim tmpStatus As String
        With dr
            Dim lv As ListViewItem = lvUser.Items.Add(.Item("ID"))
            lv.SubItems.Add(.Item("UserName"))
            lv.SubItems.Add(.Item("FirstName") & " " & .Item("LastName"))
            If .Item("Status") = 1 Then
                tmpStatus = "Active"
            Else
                tmpStatus = "Inactive"
            End If

            lv.SubItems.Add(tmpStatus)
        End With
    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        LoadUser(txtSearch.Text)
    End Sub

End Class