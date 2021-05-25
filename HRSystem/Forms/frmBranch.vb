Imports System.Globalization

Public Class frmBranch
    Private tmpBranch As Branch

    Private Sub frmBranch_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadCompany()
        LoadBranch()
        ListViewGrouping(lvBranch, 4)
    End Sub

    Private Sub LoadCompany()
        Dim mysql As String = "Select DISTINCT(CompanyName) From tbl_Branch"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Branch")

        cboCompany.Items.Clear()
        For Each dr In ds.Tables(0).Rows
            cboCompany.Items.Add(dr.item("CompanyName"))
        Next
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        If btnSave.Text = "&Save" Then
            If Not isValid() Then Exit Sub
            If Not BranchisValid() Then MsgBox("Invalid Branch", MsgBoxStyle.Critical, "Error") : Exit Sub
            tmpBranch = New Branch
            With tmpBranch
                .CompanyName = cboCompany.Text.ToUpper(CultureInfo.CurrentCulture)
                .BranchName = txtName.Text.ToUpper(CultureInfo.CurrentCulture)
                .BranchCode = txtCode.Text.ToUpper(CultureInfo.CurrentCulture)
                .BranchArea = txtArea.Text.ToUpper(CultureInfo.CurrentCulture)
                .Remarks = txtRemarks.Text.ToUpper(CultureInfo.CurrentCulture)
                .Status = IIf(cbStatus.Checked = True, 1, 0)
                .SaveBranch()
            End With
            ClearText()
            MsgBox("New Branch Added", MsgBoxStyle.Information, "Information")
        Else
            With tmpBranch
                .CompanyName = cboCompany.Text.ToUpper(CultureInfo.CurrentCulture)
                .BranchName = txtName.Text.ToUpper(CultureInfo.CurrentCulture)
                .BranchCode = txtCode.Text.ToUpper(CultureInfo.CurrentCulture)
                .BranchArea = txtArea.Text.ToUpper(CultureInfo.CurrentCulture)
                .Remarks = txtRemarks.Text.ToUpper(CultureInfo.CurrentCulture)
                .Status = IIf(cbStatus.Checked = True, 1, 0)
                .UpdateBranch()
            End With
            ClearText()
            MsgBox("Branch Updated", MsgBoxStyle.Information, "Information")
        End If
        LoadBranch()
        ListViewGrouping(lvBranch, 4)
    End Sub

    Private Function isValid()
        If String.IsNullOrEmpty(cboCompany.Text) Then
            MsgBox("Invalid Company Name", MsgBoxStyle.Critical, "Error")
            Return False
        End If
        If String.IsNullOrEmpty(txtName.Text) Then
            MsgBox("Invalid Branch Name", MsgBoxStyle.Critical, "Error")
            Return False
        End If
        If String.IsNullOrEmpty(txtCode.Text) Then
            MsgBox("Invalid Branch Code", MsgBoxStyle.Critical, "Error")
            Return False
        End If
        If String.IsNullOrEmpty(txtArea.Text) Then
            MsgBox("Invalid Branch Area", MsgBoxStyle.Critical, "Error")
            Return False
        End If

        Return True
    End Function

    Private Sub LoadBranch(Optional ByVal str As String = "")
        Dim mysql As String
        Dim secured_str As String = str
        secured_str = DreadKnight(secured_str)
        If str.Length <> 0 Then
            mysql = "Select * From tbl_Branch Where Upper(BranchName) Like Upper('%" & secured_str & "%')"
        Else
            mysql = "Select * From tbl_Branch"
        End If
        Using ds As DataSet = LoadSQL(mysql, "tbl_Branch")

            lvBranch.Items.Clear()
            For Each dr In ds.Tables(0).Rows
                AddItem(dr)
            Next
        End Using

    End Sub

    Private Sub AddItem(ByVal dr As DataRow)
        With dr
            Dim lv As ListViewItem = lvBranch.Items.Add(.Item("ID"))
            lv.SubItems.Add(.Item("CompanyName"))
            lv.SubItems.Add(.Item("BranchName"))
            lv.SubItems.Add(.Item("BranchCode"))
            lv.SubItems.Add(.Item("BranchArea"))
        End With
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        ClearText()
    End Sub

    Private Sub ClearText()
        cboCompany.Text = ""
        txtName.Clear()
        txtArea.Clear()
        txtCode.Clear()
        txtRemarks.Clear()
        cbStatus.Checked = True
    End Sub

    Private Sub LoadBranchInfo(ByVal brnch As Branch)
        With brnch
            cboCompany.Text = .CompanyName
            txtName.Text = .BranchName
            txtCode.Text = .BranchCode
            txtArea.Text = .BranchArea
            txtRemarks.Text = .Remarks
            cbStatus.Checked = IIf(.Status = 1, True, False)
        End With
        DisableFields(False)
        btnSave.Text = "&Update"
        tmpBranch = brnch
    End Sub

    Private Sub DisableFields(ByVal st As Boolean)
        cboCompany.Enabled = st
        txtName.Enabled = st
        txtCode.Enabled = st
    End Sub

    Private Sub lvBranch_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles lvBranch.DoubleClick
        If lvBranch.SelectedItems.Count = 0 Then Exit Sub

        Dim idx As Integer = lvBranch.FocusedItem.Text
        Dim tmp As New Branch
        tmp.LoadBranch(idx)
        LoadBranchInfo(tmp)
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        LoadBranch(txtSearch.Text)
        ListViewGrouping(lvBranch, 4)
    End Sub

    Private Sub txtSearch_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If IsEnter(e) Then btnSearch.PerformClick()
        ListViewGrouping(lvBranch, 4)
    End Sub

    Private Function BranchisValid()
        Dim mysql As String = "Select * From tbl_Branch Where Upper(BranchName) = Upper('" & txtName.Text & "')"
        Using ds As DataSet = LoadSQL(mysql, "tbl_Branch")

            If ds.Tables(0).Rows.Count = 0 Then Return True
        End Using

        Return False
    End Function

    Private Sub LvBranch_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lvBranch.ColumnClick
        SortingOrder(lvBranch, e.Column)
    End Sub

End Class