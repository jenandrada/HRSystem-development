Public Class frmDashboard
    Private Sub Close_BTN_Click(sender As Object, e As EventArgs) Handles Close_BTN.Click
        Close()
    End Sub

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ThisHasRow("SHOWCAUSE_RECORDS") Then
            SCPendings(PendingNo_LBL)
        End If
    End Sub

    Private Sub Pending_Panel_MouseEnter(sender As Object, e As EventArgs) Handles Pending_Panel.MouseEnter
        '    Pending_Panel.Size = New Size(222, 155)
        Pending_Panel.BackColor = Color.PeachPuff
    End Sub

    Private Sub Pending_Panel_MouseLeave(sender As Object, e As EventArgs) Handles Pending_Panel.MouseLeave
        Pending_Panel.BackColor = Color.Pink
    End Sub

    Private Sub Pending_Panel_DoubleClick(sender As Object, e As EventArgs) Handles Pending_Panel.DoubleClick

        If frmCoorective Is Nothing Then
            Dim frm As New frmCoorective With {
                .MdiParent = frmMainForm
            }
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            frm.Show()
            frm.CorrectiveWindow.SelectedIndex = 2
            frm.Pending_RB.Checked = True
            frm.Dock = DockStyle.Fill
            frm.BringToFront()

        Else
            frmEmployeeList.BringToFront()
        End If

        Close()

    End Sub

End Class