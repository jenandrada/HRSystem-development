Public Class frmUserLogs

    Private Sub FrmUserLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Application.DoEvents()
        LoadUserLogs(Search_TXT.Text)
        ListViewGrouping(UserLogs_ListView, 4)
    End Sub

    Public Sub LoadUserLogs(str As String)
        Dim secured_str As String = str
        secured_str = DreadKnight(secured_str)
        Dim strWords As String() = secured_str.Split(New Char() {" "c})
        Dim name As String
        Dim sql As String
        If str.Length <> 0 Then
            'sql = "SELECT * FROM USER_LOGS WHERE "
            'For Each name In strWords
            '    sql &= $"{vbCr}UPPER(EMPLOYEE) LIKE UPPER('%{name}%') OR "
            '    sql &= $"{vbCr}UPPER(USERNAME) LIKE UPPER('%{name}%') and "

            '    If name Is strWords.Last Then
            '        sql &= $"{vbCr}UPPER(EMPLOYEE) LIKE UPPER('%{name}%') OR "
            '        sql &= $"{vbCr}UPPER(USERNAME) LIKE UPPER('%{name}%') "
            '        Exit For
            '    End If
            'Next

            sql = "SELECT * FROM USER_TRANSACTION WHERE "

            For Each name In strWords
                sql &= $"{vbCr}UPPER(EMPLOYEE) LIKE UPPER('%{name}%') OR "
                sql &= $"{vbCr}UPPER(USERNAME) LIKE UPPER('%{name}%') and "

                If name Is strWords.Last Then
                    sql &= $"{vbCr}UPPER(EMPLOYEE) LIKE UPPER('%{name}%') OR "
                    sql &= $"{vbCr}UPPER(USERNAME) LIKE UPPER('%{name}%') "
                    Exit For
                End If
            Next

        Else
            sql = "SELECT * FROM USER_TRANSACTION "
        End If
        Dim ds As DataSet = LoadSQL(sql, "USER_TRANSACTION")
        TextProgressBar1.Maximum = ds.Tables(0).Rows.Count
        TextProgressBar1.Visible = True
        UserLogs_ListView.Items.Clear()
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                With dr
                    GetUserLogs(dr)
                    TextProgressBar1.Value += 1
                End With
            Next
            TextProgressBar1.Visible = False
        Else
            Exit Sub
        End If
    End Sub

    Public Sub GetUserLogs(dr As DataRow)
        With dr
            'If IsDBNull(.Item("ASSIGNED")) And IsDBNull(.Item("RELIEVE")) Then
            '    Exit Sub
            'End If
            Dim i As ListViewItem = UserLogs_ListView.Items.Add(.Item("DATETRANSACTION"))
            i.SubItems.Add(.Item("USERNAME"))
            i.SubItems.Add(.Item("NAME").ToString)
            i.SubItems.Add(.Item("ACTION"))
            i.SubItems.Add(.Item("BRANCH"))
            i.SubItems.Add(.Item("STATUS"))
            i.SubItems.Add(.Item("POSITION"))
        End With
    End Sub

    Private Sub Search_BTN_Click(sender As Object, e As EventArgs) Handles Search_BTN.Click
        TextProgressBar1.Value = 0
        LoadUserLogs(Search_TXT.Text)
        ListViewGrouping(UserLogs_ListView, 4)
    End Sub

    Private Sub Search_TXT_TextChanged(sender As Object, e As EventArgs) Handles Search_TXT.TextChanged
        TextProgressBar1.Value = 0
        LoadUserLogs(Search_TXT.Text)
        ListViewGrouping(UserLogs_ListView, 4)
    End Sub

    Private Sub UserLogs_ListView_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles UserLogs_ListView.ColumnClick
        SortingOrder(UserLogs_ListView, e.Column)
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles Close_LBL.MouseEnter
        Close_LBL.ForeColor = Color.Red
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Close_LBL.MouseLeave
        Close_LBL.ForeColor = Color.Black
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close_LBL.Click
        Close()
    End Sub
End Class