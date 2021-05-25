Imports FirebirdSql.Data.FirebirdClient

Public Class frmBranchList
    Dim fromOtherForm As Boolean = False
    Dim frmOrig As FormName

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSelect_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSelect.Click
        If lvBranch.Items.Count = 0 Then Exit Sub

        Dim idx As Integer = CInt(lvBranch.FocusedItem.Text)
        Dim tmpBranch As Branch
        tmpBranch = New Branch
        tmpBranch.LoadBranch(idx)

        ReloadFormBranch(frmOrig, tmpBranch)

        Close()
    End Sub

    Private Sub LoadBranch(Optional ByVal str As String = "")
        Dim secured_str As String = str
        secured_str = DreadKnight(secured_str)
        Dim mysql As String
        If str.Length <> 0 Then
            mysql = "Select * From tbl_Branch Where Upper(CompanyName) Like Upper('%" & secured_str & "%') OR Upper(BranchName) Like Upper('%" & secured_str & "%') And Status <> 0"
        Else
            mysql = "Select * From tbl_Branch"
        End If
        Using ds As FbDataReader = LoadSQL_byDataReader(mysql)

            lvBranch.Items.Clear()

            AddItem(ds)

        End Using
    End Sub

    Private Sub AddItem(ByVal dr As FbDataReader)
        While dr.Read()
            If dr.HasRows Then
                With dr
                    Dim lv As ListViewItem = lvBranch.Items.Add(.Item("ID"))
                    lv.SubItems.Add(.Item("CompanyName"))
                    lv.SubItems.Add(.Item("BranchName"))
                    lv.SubItems.Add(.Item("BranchCode"))
                    lv.SubItems.Add(.Item("BranchArea"))
                End With
            End If
        End While
    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        LoadBranch(txtSearch.Text)
        ListViewGrouping(lvBranch, 4)
    End Sub

    Friend Sub SearchSelect(ByVal src As String, ByVal frmOrigin As FormName)
        fromOtherForm = True
        btnSelect.Visible = True
        txtSearch.Text = src
        frmOrig = frmOrigin
    End Sub

    Private Sub lvBranch_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles lvBranch.DoubleClick
        btnSelect.PerformClick()
    End Sub

    Private Sub frmBranchList_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadBranch()
        ListViewGrouping(lvBranch, 4)
    End Sub

    Private Sub txtSearch_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If IsEnter(e) Then btnSearch.PerformClick()
        ListViewGrouping(lvBranch, 4)
    End Sub

    Private Sub LvBranch_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lvBranch.ColumnClick
        SortingOrder(lvBranch, e.Column)
    End Sub

End Class