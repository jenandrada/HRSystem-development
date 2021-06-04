Public Class frmLogin
    'Dim images As ImageDatabaseToFolder

    ' TODO: Insert code to perform custom authentication using the provided username and password
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339). The custom principal can then be attached
    ' to the current thread's principal as follows: My.User.CurrentPrincipal = CustomPrincipal where
    ' CustomPrincipal is the IPrincipal implementation used to perform authentication. Subsequently,
    ' My.User will return identity information encapsulated in the CustomPrincipal object such as the
    ' username, display name, etc.

    Private Sub OK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OK.Click
        Static wrongLogin As Integer

        Dim user As String = DreadKnight(txtUsername.Text)
        'Dim user As String = txtUser.Text
        Dim pass As String = txtPassword.Text

        Dim loginUser As New EmpUser
        If Not loginUser.LoginUser(user, pass) Then
            wrongLogin += 1
            If wrongLogin >= 3 Then
                MsgBox("You have reached the MAXIMUM logins. This is a recording.", MsgBoxStyle.Critical, "WARNING")
                End
            End If
            MsgBox("Invalid Username and password", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        ' Success!
        ComUser = loginUser
        MsgBox(loginUser.FirstName & " " & loginUser.LastName, MsgBoxStyle.Information, "WELCOME")

        'frmMain.Show()
        'frmMain.NotYetLogin(False)
        'frmMain.CheckStoreStatus()
        Dim idx As String = loginUser.ID
        Dim username As String = loginUser.FirstName + " " + loginUser.LastName
        frmMainForm.NotYetLogin(True, idx, username)
        'updateStatus()
        Close()
    End Sub


    Private Sub updateStatus()

        Dim mysql As String = "Select * From tbl_Employee where status = 'PROBATIONARY'"
        Using ds As DataSet = LoadSQL(mysql, "tbl_Employee")

            For Each dr As DataRow In ds.Tables(0).Rows
                With dr
                    If Not IsDBNull(.Item("ASSIGN_STATUS")) Then
                        If MonthDifference(dr("datehired"), Date.Now) >= 6 Then
                            .Item("STATUS") = "REGULAR"
                            SaveEntry(ds, False)
                        End If
                    End If
                End With
            Next

        End Using
    End Sub

    Public Shared Function MonthDifference(ByVal first As DateTime, ByVal second As DateTime) As Integer
        Return Math.Abs((first.Month - second.Month) + 12 * (first.Year - second.Year))
    End Function

    Private Sub FrmLogin_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Text = Text & " | Version " & [GetType].Assembly.GetName.Version.ToString
    End Sub

End Class