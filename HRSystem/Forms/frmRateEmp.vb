Public Class frmRateEmp
    Private tempEmpratings As Empratings

    Dim RateID As New Integer
    Dim MID As New Integer

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub frmRateEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRatingList(IIf(Appointed_RBTN.Checked = True, 1, 0))
        ListViewGrouping(RatingListView, 5)
    End Sub

    Private Sub LoadRatingList(Optional status As Integer = 0, Optional ByVal str As String = "")
        Dim secured_str As String = str
        secured_str = DreadKnight(secured_str)
        Dim strWords As String() = secured_str.Split(New Char() {" "c})
        Dim name As String
        Dim mysql As String
        If status = 0 Then
            If str.Length <> 0 Then
                mysql = "SELECT * FROM RATINGLIST Where APPOINTED_STATUS = 0 AND VOID = 0 AND"
                For Each name In strWords
                    mysql &= vbCr & " UPPER(FULLNAME) LIKE UPPER('%" & name & "%') and "
                    mysql &= vbCr & "UPPER(FULLNAME) LIKE UPPER('%" & name & "%') and "
                    If name Is strWords.Last Then
                        mysql &= vbCr & " UPPER(FULLNAME) LIKE UPPER('%" & name & "%') ORDER BY FULLNAME ASC"
                        Exit For
                    End If
                Next
            Else
                mysql = "SELECT * FROM RATINGLIST Where APPOINTED_STATUS = 0 AND VOID = 0 ORDER BY FULLNAME ASC"
            End If
            Dim ds As DataSet = LoadSQL(mysql, "RATINGLIST")

            RatingListView.Items.Clear()
            For Each dr In ds.Tables(0).Rows
                AddItem(dr)
            Next
        Else
            If str.Length <> 0 Then
                mysql = "SELECT * FROM RATINGLIST  Where Appointed_status = 1 AND VOID = 0 AND"
                For Each name In strWords
                    mysql &= vbCr & " UPPER(FULLNAME) LIKE UPPER('%" & name & "%') and "
                    mysql &= vbCr & "UPPER(FULLNAME) LIKE UPPER('%" & name & "%') and "
                    If name Is strWords.Last Then
                        mysql &= vbCr & " UPPER(FULLNAME) LIKE UPPER('%" & name & "%') ORDER BY FULLNAME ASC"
                        Exit For
                    End If
                Next
            Else
                mysql = "SELECT * FROM RATINGLIST  Where Appointed_status = 1 AND VOID = 0 ORDER BY FULLNAME ASC"
            End If
            Dim ds As DataSet = LoadSQL(mysql, "RATINGLIST")

            RatingListView.Items.Clear()
            For Each dr In ds.Tables(0).Rows
                AddItem_Appointed(dr)
            Next
        End If

    End Sub

    Private Sub AddItem(ByVal dr As DataRow)
        With dr
            If .Item("APPOINTED_STATUS") = 0 Then
                Dim lv As ListViewItem = RatingListView.Items.Add(.Item("ID").ToString)
                lv.SubItems.Add(.Item("MID").ToString)
                lv.SubItems.Add(.Item("FULLNAME").ToString)
                lv.SubItems.Add(CDate(.Item("DATEHIRED")).ToString("MMMM dd, yyyy"))
                lv.SubItems.Add(.Item("EMP_POSITION").ToString)
                lv.SubItems.Add(.Item("BRANCHNAME").ToString)
                lv.SubItems.Add(.Item("RATING").ToString)
                lv.SubItems.Add(.Item("COMMENT").ToString)
            Else
                Exit Sub
            End If
        End With
    End Sub

    Private Sub AddItem_Appointed(ByVal dr As DataRow)
        With dr
            If .Item("APPOINTED_STATUS") = 1 Then
                Dim lv As ListViewItem = RatingListView.Items.Add(.Item("ID"))
                lv.SubItems.Add(.Item("MID"))
                lv.SubItems.Add(.Item("FULLNAME"))
                lv.SubItems.Add(CDate(.Item("DATEHIRED")).ToString("MMMM dd, yyyy"))
                lv.SubItems.Add(.Item("EMP_POSITION"))
                lv.SubItems.Add(.Item("BRANCHNAME"))
                lv.SubItems.Add(.Item("RATING"))
                lv.SubItems.Add(.Item("COMMENT"))
            Else
                Exit Sub
            End If
        End With
    End Sub

    Private Sub Search_BTN_Click(sender As Object, e As EventArgs) Handles Search_BTN.Click
        LoadRatingList(IIf(Appointed_RBTN.Checked = True, 1, 0), Search_TXT.Text)
        ListViewGrouping(RatingListView, 5)
    End Sub

    Friend Sub LOADEMPLISTBRANCH(ByVal emp As EMPLIST_BRANCH)
        If Not String.IsNullOrEmpty(emp.DateHired) Then
            Name_TXT.Text = emp.Name
            Position_TXT.Text = emp.Position
            DateHired_TXT.Text = CDate(emp.DateHired).ToString("MMMM dd, yyyy")
            Branch_TXT.Text = emp.Branch
            Branch_TXT.Tag = emp.BranchID
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim secured_str As String = Name_TXT.Text
        secured_str = DreadKnight(secured_str)
        If frmEmployeeListForRating Is Nothing Then
            Dim frm As New frmEmployeeListForRating With {
                .MdiParent = frmMainForm
            }
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            frm.SearchSelect(secured_str, FormName.rateemployee)
            frm.Show()
            frm.BringToFront()
        Else
            frmEmployeeListForRating.BringToFront()
        End If
        Close()
    End Sub

    Private Sub Clear()
        Name_TXT.Clear()
        Position_TXT.Clear()
        DateHired_TXT.Clear()
        Branch_TXT.Tag = ""
        Branch_TXT.Clear()
        Passed_RadioBTN.Checked = True
        Comment_TXT.Clear()
    End Sub

    Private Sub SaveRating_BTN_Click(sender As Object, e As EventArgs) Handles SaveRating_BTN.Click
        If SaveRating_BTN.Text = "&Save" Then
            If String.IsNullOrEmpty(Comment_TXT.Text) Or Branch_TXT.Tag Is Nothing Then
                MsgBox("Please fill all the required fields to continue.", MsgBoxStyle.Exclamation, "Error")
            Else
                tempEmpratings = New Empratings
                With tempEmpratings
                    .ManningID = Branch_TXT.Tag
                    .Rate = IIf(Passed_RadioBTN.Checked = True, 1, 0)
                    .Status = 1
                    .Comment = Comment_TXT.Text
                    .SaveRating()
                End With
                Clear()
                MsgBox("New Rating Added", MsgBoxStyle.Information, "Information")
                LoadRatingList()
            End If
            ListViewGrouping(RatingListView, 5)
        End If
    End Sub

    'Friend Sub LoadEMPLISTBRANCH(ByVal str As String)
    '    Dim mysql As String = "SELECT * FROM EMPLIST_BRANCH where FULLNAME LIKE '%" & str & "%';"
    '    Dim ds As DataSet = LoadSQL(mysql, "EMPLIST_BRANCH")
    '    If ds.Tables(0).Rows.Count > 0 Then
    '        Loademplistbranch1(ds.Tables(0).Rows(0))
    '    End If
    'End Sub

    Private Sub Load_EMPLISTBRANCH()

        Name_TXT.Text = RatingListView.SelectedItems(0).SubItems(2).Text
        Position_TXT.Text = RatingListView.SelectedItems(0).SubItems(4).Text
        If Appointed_RBTN.Checked = True Then
            DateHired_TXT.Text = RatingListView.SelectedItems(0).SubItems(3).Text
        End If
        Branch_TXT.Text = RatingListView.SelectedItems(0).SubItems(5).Text
        RateID = RatingListView.SelectedItems(0).SubItems(0).Text
        MID = RatingListView.SelectedItems(0).SubItems(1).Text

        Dim sql As String = "select * from tblmanning WHERE ID = " & MID & ";"
        Dim ds As DataSet = LoadSQL(sql)

        Dim dr As DataRow = ds.Tables(0).Rows(0)

        With dr
            If Appointed_RBTN.Checked = True Then
                DateAppointed_TXT.Text = CDate(.Item("ASSIGN_DATE")).ToString("MMMM dd, yyyy")
            End If
        End With
    End Sub

    Private Sub RatingListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RatingListView.SelectedIndexChanged

        If RatingListView.SelectedItems.Count > 0 Then
            UpdateRating_Btn.Visible = True
            SaveRating_BTN.Enabled = False
            SaveRating_BTN.Visible = False
            For Each item As ListViewItem In RatingListView.SelectedItems
                Load_EMPLISTBRANCH()
            Next
        Else
            Clear()
            SaveRating_BTN.Visible = True
            UpdateRating_Btn.Visible = False
        End If
    End Sub

    Private Sub UpdateRating_Btn_Click(sender As Object, e As EventArgs) Handles UpdateRating_Btn.Click
        If RatingListView.SelectedItems(0).Index > -1 Then
            If String.IsNullOrEmpty(Comment_TXT.Text) Or MID = 0 Then
                MsgBox("Please fill all the required fields to continue.", MsgBoxStyle.Exclamation, "Error")
            Else
                tempEmpratings = New Empratings
                With tempEmpratings
                    .ID = RateID
                    .ManningID = MID
                    .Rate = IIf(Passed_RadioBTN.Checked = True, 1, 0)
                    .Status = 1
                    .Comment = Comment_TXT.Text
                    .UpdateRatings()
                End With
                Clear()
                MsgBox("Rating Updated", MsgBoxStyle.Information, "Information")
                UpdateRating_Btn.Visible = False
                SaveRating_BTN.Enabled = False
                SaveRating_BTN.Visible = True
                LoadRatingList()
            End If
            ListViewGrouping(RatingListView, 5)
        End If
    End Sub

    Private Sub Clear_BTN_Click(sender As Object, e As EventArgs) Handles Clear_BTN.Click
        Clear()
    End Sub

    Private Sub Assigned_RBTN_CheckedChanged(sender As Object, e As EventArgs) Handles Assigned_RBTN.CheckedChanged
        LoadRatingList(IIf(Appointed_RBTN.Checked = True, 1, 0))
        RatingListView.Columns(3).Text = IIf(Appointed_RBTN.Checked = False, "Date Hired", "Date Appointed")
        ListViewGrouping(RatingListView, 5)
        If Assigned_RBTN.Checked = True Then
            DateAppointed_TXT.Clear()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Comment_TXT_TextChanged(sender As Object, e As EventArgs) Handles Comment_TXT.TextChanged
        If Comment_TXT.Text.Length > 5 Then
            SaveRating_BTN.Enabled = True
        Else
            SaveRating_BTN.Enabled = False
        End If
    End Sub

    Private Sub Search_TXT_TextChanged(sender As Object, e As EventArgs) Handles Search_TXT.TextChanged
        LoadRatingList(IIf(Appointed_RBTN.Checked = True, 1, 0), Search_TXT.Text)
        ListViewGrouping(RatingListView, 5)
    End Sub

    Private Sub RatingListView_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles RatingListView.ColumnClick
        SortingOrder(RatingListView, e.Column)
    End Sub

End Class