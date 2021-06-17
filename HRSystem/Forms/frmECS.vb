Public Class frmECS

    Private Sub ECS_Search_TXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ECS_Search_TXT.KeyPress
        If IsEnter(e) Then
            SerchCombo()
        End If
    End Sub

    Private Sub ECS_Search_Combo_Click(sender As Object, e As EventArgs) Handles ECS_Search_Combo.Click
        LoadECSSearchName(ECS_Search_TXT.Text, lvECS)
    End Sub

    Private Sub ECS_Search_Combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ECS_Search_Combo.SelectedIndexChanged
        SerchCombo()
    End Sub

    Private Sub SerchCombo()
        If Not ECS_Search_TXT.Text = "" Then

            If ECS_Search_Combo.SelectedIndex = 1 Then
                LoadECSSearchName(ECS_Search_TXT.Text, lvECS)

            ElseIf ECS_Search_Combo.SelectedIndex = 2 Then
                LoadECSSearchIRNO(ECS_Search_TXT.Text, lvECS)

            ElseIf ECS_Search_Combo.SelectedIndex = 3 Then
                LoadECSSearchECSNO(ECS_Search_TXT.Text, lvECS)
            Else
                LoadECS(lvECS)
            End If
        Else
            LoadECS(lvECS)
        End If
    End Sub

    Private Sub frmECS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("1111")
        LoadECS(lvECS)
    End Sub

    Private Sub Close_BTN_Click(sender As Object, e As EventArgs) Handles Close_BTN.Click
        Close()
    End Sub
End Class