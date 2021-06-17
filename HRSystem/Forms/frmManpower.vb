Public Class frmManpower
    Private Sub BadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BadBranch_ToolStrip.Click
        Gensan_Panel.BackColor = Color.Maroon
        Console.WriteLine("SAVE TO DATABASE")
    End Sub

    Private Sub GoodToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoodBranch_ToolStrip.Click
        Gensan_Panel.BackColor = Color.Green
        Console.WriteLine("SAVE TO DATABASE")
    End Sub

    Private Sub ForCheckingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckingBranch_ToolStrip.Click
        Gensan_Panel.BackColor = Color.Yellow
        Console.WriteLine("SAVE TO DATABASE")
    End Sub

    Private Sub TabBranches_Gensan_MouseClick(sender As Object, e As MouseEventArgs)

        If e.Button = MouseButtons.Right Then
            TabBranches_Context.Show(Gensan_Panel, New Point(e.X, e.Y))
        End If

    End Sub

    Private Sub TabBranches_Gensan_SelectedIndexChanged(sender As Object, e As EventArgs)
        'If TabBranches_Gensan.SelectedIndex = TabBranches_Gensan.TabPages.IndexOf(ROG) Then
        '    Console.WriteLine("AAAAAAA ")
        'End If
    End Sub

    Private Sub GensanBranch_Combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GensanBranch_Combo.SelectedIndexChanged
        If GensanBranch_Combo.SelectedIndex = 0 Then
            Populate_MANPOWER(GensanBranch_Datagrid, "ROG", "GENSAN")
        End If
    End Sub

    Private Sub GensanBranch_Datagrid_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles GensanBranch_Datagrid.CellFormatting
        If e.RowIndex > 0 And e.ColumnIndex = 0 Then
            If GensanBranch_Datagrid.Item(0, e.RowIndex - 1).Value = e.Value Then
                e.Value = ""
            ElseIf e.RowIndex < GensanBranch_Datagrid.Rows.Count - 1 Then
                GensanBranch_Datagrid.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            End If
        End If
    End Sub

    Private Sub Close_BTN_Click(sender As Object, e As EventArgs) Handles Close_BTN.Click
        Close()
    End Sub
End Class