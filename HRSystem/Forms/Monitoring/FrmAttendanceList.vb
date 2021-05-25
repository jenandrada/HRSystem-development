Imports FirebirdSql.Data.FirebirdClient

Public Class FrmAttendanceList

    Public Sub LoadAttendanceLists()
        Dim sql As String = "select "
        sql &= "A.ID AS ATTID, "
        sql &= "B.ID, "
        sql &= "B.LASTNAME||', '||B.FIRSTNAME||' '||B.MIDDLENAME||' '||B.SUFFIX AS FullName, "
        sql &= "C.BRANCHNAME, "
        sql &= "A.ATTENDANCE, "
        sql &= "A.DATE_ENCODED, "
        sql &= "A.NOTE, "
        sql &= "A.REMARKS "
        sql &= "From TBL_ATTENDANCE A "
        sql &= "inner Join TBL_EMPLOYEE B "
        sql &= "On A.EMP_ID = B.ID "
        sql &= "inner Join  TBL_BRANCH C "
        sql &= "On A.BRANCH_ID = C.ID"

        Dim rdr As FbDataReader = LoadSQL_byDataReader(sql)
        While rdr.Read()
            If rdr.HasRows Then
                With rdr
                    Dim i As ListViewItem = Attendance_LV.Items.Add(.Item("ID").ToString)
                    i.Tag = .Item("ATTID").ToString
                    i.SubItems.Add(.Item("FullName").ToString)
                    i.SubItems.Add(.Item("BranchName").ToString)
                    i.SubItems.Add(.Item("ATTENDANCE").ToString)
                    i.SubItems.Add(CDate(.Item("DATE_ENCODED").ToString).ToShortDateString)
                    i.SubItems.Add(.Item("NOTE").ToString)
                    i.SubItems.Add(.Item("REMARKS").ToString)

                End With
            End If
        End While
    End Sub

    Private Sub FrmAttendanceList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAttendanceLists()
    End Sub

    Private Sub Select_BTN_Click(sender As Object, e As EventArgs) Handles Select_BTN.Click
        Dim f As Form = Application.OpenForms("FrmMonitoring")
        Dim sql As String = $"select * from tbl_branch where branchname = '{Attendance_LV.SelectedItems(0).SubItems(2).Text}'"
        Dim rdr As FbDataReader = LoadSQL_byDataReader(sql)
        While rdr.Read()
            If rdr.HasRows Then
                With rdr
                    CType(f, FrmMonitoring).BranchName_TXT.Tag = rdr.Item("ID").ToString
                    CType(f, FrmMonitoring).BranchName_TXT.Text = rdr.Item("BRANCHNAME").ToString
                    CType(f, FrmMonitoring).BranchArea_TXT.Text = rdr.Item("BRANCHAREA").ToString
                    CType(f, FrmMonitoring).CompanyName_TXT.Text = rdr.Item("COMPANYNAME").ToString
                End With
            End If
        End While
        CType(f, FrmMonitoring).DateEncoded_DTP.Value = Attendance_LV.SelectedItems(0).SubItems(4).Text
        CType(f, FrmMonitoring).EmpName_TXT.Text = Attendance_LV.SelectedItems(0).SubItems(1).Text
        CType(f, FrmMonitoring).EmpName_TXT.Tag = Attendance_LV.SelectedItems(0).SubItems(0).Text
        CType(f, FrmMonitoring).EmpPosition_TXT.Tag = Attendance_LV.SelectedItems(0).Tag
        CType(f, FrmMonitoring).EmpName_TXT.ReadOnly = True
        Dim sqlx As String = $"select EMP_POSITION from tblmanning where EMP_ID = '{Attendance_LV.SelectedItems(0).SubItems(0).Text}'"
        Dim rdrx As FbDataReader = LoadSQL_byDataReader(sqlx)
        While rdrx.Read()
            If rdrx.HasRows Then
                With rdrx
                    CType(f, FrmMonitoring).EmpPosition_TXT.Text = rdrx.Item("EMP_POSITION").ToString
                    CType(f, FrmMonitoring).EmpPosition_TXT.ReadOnly = True
                End With
            End If
        End While
        CType(f, FrmMonitoring).Present_RBTN.Checked = IIf(Attendance_LV.SelectedItems(0).SubItems(3).Text = "PRESENT", True, False)
        CType(f, FrmMonitoring).Late_RBTN.Checked = IIf(Attendance_LV.SelectedItems(0).SubItems(3).Text = "LATE", True, False)
        CType(f, FrmMonitoring).Absent_RBTN.Checked = IIf(Attendance_LV.SelectedItems(0).SubItems(3).Text = "ABSENT", True, False)
        CType(f, FrmMonitoring).RestDay_RBTN.Checked = IIf(Attendance_LV.SelectedItems(0).SubItems(3).Text = "REST DAY", True, False)
        CType(f, FrmMonitoring).Leave_RBTN.Checked = IIf(Attendance_LV.SelectedItems(0).SubItems(3).Text = "LEAVE", True, False)
        CType(f, FrmMonitoring).Relieve_RBTN.Checked = IIf(Attendance_LV.SelectedItems(0).SubItems(3).Text = "RELIEVE", True, False)
        CType(f, FrmMonitoring).NoteReason_CHK.Checked = IIf(String.IsNullOrWhiteSpace(Attendance_LV.SelectedItems(0).SubItems(5).Text), False, True)
        CType(f, FrmMonitoring).NoteReason_TXT.Text = Attendance_LV.SelectedItems(0).SubItems(5).Text
        CType(f, FrmMonitoring).Remarks_TXT.Text = Attendance_LV.SelectedItems(0).SubItems(6).Text
        CType(f, FrmMonitoring).Save_BTN.Enabled = False
        CType(f, FrmMonitoring).Update_BTN.Enabled = True
        Close()
    End Sub

    Private Sub Void_BTN_Click(sender As Object, e As EventArgs) Handles Void_BTN.Click
        For Each i As ListViewItem In Attendance_LV.SelectedItems
            Dim result As DialogResult = MessageBox.Show($"Do you want to void the attendance for{vbCrLf}{i.SubItems(1).Text}?{vbCrLf}Once you continue, the action cannot be undone.{vbCrLf}{vbCrLf}   Click 'OK' to continue{vbCrLf}   Click 'Cancel' to abort", Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            If result = DialogResult.OK Then
                MessageBox.Show($"Attendance for {i.SubItems(1).Text} has been voided", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Action aborted", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Next
    End Sub

End Class