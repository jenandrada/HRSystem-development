Public Class frmRecruitmentDashboard

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NavigateToPages(ProcessPage.AddApplicants)
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

End Class