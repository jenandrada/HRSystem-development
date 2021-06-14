Public Class frmDashboard

    Private Sub Close_BTN_Click(sender As Object, e As EventArgs) Handles Close_BTN.Click
        Close()
    End Sub

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If ThisHasRow("SHOWCAUSE_RECORDS") Then
            Pendings(Explanation_LBL, "SHOWCAUSE_RECORDS", "STATUS")
        End If

        If ThisHasRow("IR_REPRIMAND") Then
            PendingCorrective(Correction_LBL)
        End If

        If ThisHasRow("IR_REPRIMAND") Then
            Pendings(Acknowledge_LBL, "IR_REPRIMAND", "WRITTEN_STATUS")
        End If
    End Sub

    Private Sub Pending_Panel_MouseEnter(sender As Object, e As EventArgs) Handles Pending_Panel.MouseEnter
        '    Pending_Panel.Size = New Size(222, 155)
        Pending_Panel.BackColor = Color.PeachPuff
    End Sub

    Private Sub Pending_Panel_MouseLeave(sender As Object, e As EventArgs) Handles Pending_Panel.MouseLeave
        Pending_Panel.BackColor = Color.Pink
    End Sub

    Private Sub Pending_Panel_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Pending_Panel.MouseDoubleClick
        If frmIncidentReport Is Nothing Then
            Dim frm As New frmIncidentReport With {
                .MdiParent = frmMainForm
            }
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            frm.Show()
            frm.CorrectiveWindow.SelectedIndex = 2
            frm.Dock = DockStyle.Fill
            frm.BringToFront()

        Else
            frmIncidentReport.BringToFront()
        End If

        Close()

    End Sub

    Private Sub Panel1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDoubleClick
        If frmIncidentReport Is Nothing Then
            Dim frm As New frmIncidentReport With {
                .MdiParent = frmMainForm
            }
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            frm.Show()
            frm.CorrectiveWindow.SelectedIndex = 4
            frm.StatusACK_Combo.SelectedIndex = 2
            frm.Dock = DockStyle.Fill
            frm.BringToFront()

        Else
            frmIncidentReport.BringToFront()
        End If

        Close()
    End Sub

    Private Sub Panel2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDoubleClick

        If frmWRList Is Nothing Then
            Dim frm As New frmWRList With {
                .MdiParent = frmMainForm
            }
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            frm.Show()
            frm.txtSearch.Tag = "Corrective Action"
            frm.Dock = DockStyle.Fill
            frm.BringToFront()

        Else
            frmWRList.BringToFront()
        End If

    End Sub

End Class