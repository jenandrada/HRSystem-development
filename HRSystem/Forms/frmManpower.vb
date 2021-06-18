Public Class frmManpower
    Private Sub BadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BadBranch_ToolStrip.Click
        Gensan_Panel.BackColor = Color.Maroon
        ColorME("Maroon")
    End Sub

    Private Sub GoodToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoodBranch_ToolStrip.Click
        Gensan_Panel.BackColor = Color.Green
        ColorME("Green")
    End Sub

    Private Sub ForCheckingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckingBranch_ToolStrip.Click
        Gensan_Panel.BackColor = Color.Yellow
        ColorME("Yellow")
    End Sub


    Private Sub ColorME(color As String)
        If GensanBranch_Combo.SelectedIndex = 0 Then
            ManpowerSave_BranchColor("ROG", color)
        ElseIf GensanBranch_Combo.SelectedIndex = 1 Then
            ManpowerSave_BranchColor("KCG", color)
        ElseIf GensanBranch_Combo.SelectedIndex = 2 Then
            ManpowerSave_BranchColor("LAG", color)
        ElseIf GensanBranch_Combo.SelectedIndex = 3 Then
            ManpowerSave_BranchColor("JC2", color)
        ElseIf GensanBranch_Combo.SelectedIndex = 4 Then
            ManpowerSave_BranchColor("PIO", color)
        ElseIf GensanBranch_Combo.SelectedIndex = 5 Then
            ManpowerSave_BranchColor("CAG", color)
        ElseIf GensanBranch_Combo.SelectedIndex = 6 Then
            ManpowerSave_BranchColor("SAN", color)
        ElseIf GensanBranch_Combo.SelectedIndex = 7 Then
            ManpowerSave_BranchColor("ROX", color)
        ElseIf GensanBranch_Combo.SelectedIndex = 8 Then
            ManpowerSave_BranchColor("PEN", color)
        ElseIf GensanBranch_Combo.SelectedIndex = 9 Then
            ManpowerSave_BranchColor("PGN", color)
        ElseIf GensanBranch_Combo.SelectedIndex = 10 Then
            ManpowerSave_BranchColor("PMA", color)
        ElseIf GensanBranch_Combo.SelectedIndex = 11 Then
            ManpowerSave_BranchColor("NUZ", color)
        ElseIf GensanBranch_Combo.SelectedIndex = 12 Then
            ManpowerSave_BranchColor("UHA", color)
        End If
    End Sub

    Private Sub GensanBranch_Combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GensanBranch_Combo.SelectedIndexChanged
        If GensanBranch_Combo.SelectedIndex = 0 Then
            GetBranchColor("ROG", Gensan_Panel)
            Populate_MANPOWER(GensanBranch_Datagrid, "ROG", "GENSAN")
        ElseIf GensanBranch_Combo.SelectedIndex = 1 Then
            GetBranchColor("KCG", Gensan_Panel)
            Populate_MANPOWER(GensanBranch_Datagrid, "KCG", "GENSAN")
        ElseIf GensanBranch_Combo.SelectedIndex = 2 Then
            GetBranchColor("LAG", Gensan_Panel)
            Populate_MANPOWER(GensanBranch_Datagrid, "LAG", "GENSAN")
        ElseIf GensanBranch_Combo.SelectedIndex = 3 Then
            GetBranchColor("JC2", Gensan_Panel)
            Populate_MANPOWER(GensanBranch_Datagrid, "JC2", "GENSAN")
        ElseIf GensanBranch_Combo.SelectedIndex = 4 Then
            GetBranchColor("PIO", Gensan_Panel)
            Populate_MANPOWER(GensanBranch_Datagrid, "PIO", "GENSAN")
        ElseIf GensanBranch_Combo.SelectedIndex = 5 Then
            GetBranchColor("CAG", Gensan_Panel)
            Populate_MANPOWER(GensanBranch_Datagrid, "CAG", "GENSAN")
        ElseIf GensanBranch_Combo.SelectedIndex = 6 Then
            GetBranchColor("SAN", Gensan_Panel)
            Populate_MANPOWER(GensanBranch_Datagrid, "SAN", "GENSAN")
        ElseIf GensanBranch_Combo.SelectedIndex = 7 Then
            GetBranchColor("ROX", Gensan_Panel)
            Populate_MANPOWER(GensanBranch_Datagrid, "ROX", "GENSAN")
        ElseIf GensanBranch_Combo.SelectedIndex = 8 Then
            GetBranchColor("PEN", Gensan_Panel)
            Populate_MANPOWER(GensanBranch_Datagrid, "PEN", "GENSAN")
        ElseIf GensanBranch_Combo.SelectedIndex = 9 Then
            GetBranchColor("PGN", Gensan_Panel)
            Populate_MANPOWER(GensanBranch_Datagrid, "PGN", "GENSAN")
        ElseIf GensanBranch_Combo.SelectedIndex = 10 Then
            GetBranchColor("PMA", Gensan_Panel)
            Populate_MANPOWER(GensanBranch_Datagrid, "PMA", "GENSAN")
        ElseIf GensanBranch_Combo.SelectedIndex = 11 Then
            GetBranchColor("NUZ", Gensan_Panel)
            Populate_MANPOWER(GensanBranch_Datagrid, "NUZ", "GENSAN")
        ElseIf GensanBranch_Combo.SelectedIndex = 12 Then
            GetBranchColor("UHA", Gensan_Panel)
            Populate_MANPOWER(GensanBranch_Datagrid, "UHA", "GENSAN")

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

    Private Sub City_TabControl_MouseClick(sender As Object, e As MouseEventArgs) Handles City_TabControl.MouseClick

        If e.Button = MouseButtons.Right Then
            TabBranches_Context.Show(Gensan_Panel, New Point(e.X, e.Y))
        End If

    End Sub

    Private Sub GensanBranch_Datagrid_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles GensanBranch_Datagrid.MouseDoubleClick
        DateAppointed_DTP.Visible = True
        DateAppointed_DTP.Location = New Point(e.X, e.Y)
    End Sub

    Private Sub GensanBranch_Datagrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GensanBranch_Datagrid.CellContentClick

        Dim grid = DirectCast(sender, DataGridView)
        Dim row As DataGridViewRow = GensanBranch_Datagrid.Rows(e.RowIndex)

        If TypeOf grid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then

            If grid.Columns(e.ColumnIndex).Name = "Gensa_DGV_Appointed" Then

                DateAppointed_DTP.Visible = True
                DateAppointed_DTP.Location = New Point(Cursor.Position.X - 300, Cursor.Position.Y - 130)
                DateAppointed_DTP.Select()

            End If
        End If
    End Sub

    Private Sub DateAppointed_DTP_CloseUp(sender As Object, e As EventArgs) Handles DateAppointed_DTP.CloseUp
        Dim i As Integer = GensanBranch_Datagrid.CurrentRow.Index
        DateAppointed_DTP.Visible = False
        ManpowerSave_AppointedDate(GensanBranch_Datagrid.Item(2, i).Tag, DateAppointed_DTP.Value)
        Populate_MANPOWER(GensanBranch_Datagrid, "ROG", "GENSAN")
    End Sub

    Private Sub Gensan_Panel_MouseClick(sender As Object, e As MouseEventArgs) Handles Gensan_Panel.MouseClick

        If e.Button = MouseButtons.Right Then
            TabBranches_Context.Show(Gensan_Panel, New Point(e.X, e.Y))
        End If

    End Sub
End Class