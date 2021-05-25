Public Class FrmAllowanceNotify
    Public Sub LoadAllowanceNotify()
        Dim sql As String = $"select * from allowance_notify where DATE_NOTIFY between '{Now.ToShortDateString}' and DATEADD(10 day to DATE_NOTIFY)"
        Using ds As DataSet = LoadSQL(sql, "allowance_notify")
            If ds.Tables(0).Rows.Count > 0 Then
                For Each dr As DataRow In ds.Tables(0).Rows
                    GetItems(dr)
                Next
            Else
                Exit Sub
            End If
        End Using
    End Sub

    Public Sub GetItems(dr As DataRow)
        If dr Is Nothing Then
            Exit Sub
        End If
        With dr
            Dim lvitem As ListViewItem = AllowanceNotify_List.Items.Add(.Item("ID"))
            lvitem.SubItems.Add(.Item("EMP_NAME"))
            lvitem.SubItems.Add(.Item("CARE_KIT"))
            lvitem.SubItems.Add(.Item("ALLOWANCE"))
            lvitem.SubItems.Add(.Item("OTHER_ALLOWANCE"))
            lvitem.SubItems.Add(.Item("PARTICULARS").ToString)
        End With
    End Sub

    Private Sub FrmAllowanceNotify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllowanceNotify()
    End Sub
End Class