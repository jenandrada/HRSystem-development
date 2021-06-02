Imports FirebirdSql.Data.FirebirdClient

Public Class FrmMonitoring
    Dim branchid As Integer
    Dim empID As Integer
    Dim L_ID As Integer
    Dim att As String
    Dim attendance As HeadCount
    Dim tab As Integer


    Private Sub SelectBranch_BTN_Click(sender As Object, e As EventArgs) Handles SelectBranch_BTN.Click
        Dim secured_str As String = BranchName_TXT.Text
        secured_str = DreadKnight(secured_str)

        If frmBranchList Is Nothing Then
            Dim frm As New frmBranchList With {
                .MdiParent = frmMainForm
            }
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            frm.SearchSelect(secured_str, FormName.branch2)
            frm.Show()
            frm.BringToFront()
        Else
            frmBranchList.BringToFront()
        End If
        Close()
    End Sub

    Public Sub LoadEmpPerBranch(ByVal branchID)

        Dim sql As String = "select * from tblmanning A inner join tbl_employee B on A.EMP_ID = B.ID where  A.BRANCH_ID = '" & branchID & "' ORDER BY '" & branchID & "' ASC;"
        Using rdr As FbDataReader = LoadSQL_byDataReader(sql)
            Emp_List.Items.Clear()

            While rdr.Read()
                If rdr.HasRows Then
                    With rdr
                        Dim i As ListViewItem = Emp_List.Items.Add(.Item("EMP_ID"))
                        i.SubItems.Add($"{ .Item("LASTNAME")}, { .Item("FIRSTNAME")} { .Item("MIDDLENAME")} { .Item("SUFFIX")}")
                        i.SubItems.Add(.Item("EMP_POSITION"))
                    End With
                End If
            End While
        End Using
    End Sub

    Public Sub LoadBranch(ByVal brnch As Branch)
        branchid = brnch.ID
        BranchName_TXT.Text = brnch.BranchName
        BranchArea_TXT.Text = brnch.BranchArea
        CompanyName_TXT.Text = brnch.CompanyName
        LoadEmpPerBranch(branchid) 'ADDED BY ME
    End Sub

    Private Sub CloseWindow_BTN_Click(sender As Object, e As EventArgs) Handles CloseWindow_BTN.Click
        Close()
    End Sub

    Private Sub Late_RBTN_CheckedChanged(sender As Object, e As EventArgs) Handles Late_RBTN.CheckedChanged
        If Late_RBTN.Checked = True Then
            NoteReason_CHK.Enabled = True
            att = Late_RBTN.Text
        End If
    End Sub

    Private Sub Present_RBTN_CheckedChanged(sender As Object, e As EventArgs) Handles Present_RBTN.CheckedChanged
        If Present_RBTN.Checked = True Then
            NoteReason_CHK.Enabled = False
            att = Present_RBTN.Text
        End If
    End Sub

    Private Sub Absent_RBTN_CheckedChanged(sender As Object, e As EventArgs) Handles Absent_RBTN.CheckedChanged
        If Absent_RBTN.Checked = True Then
            NoteReason_CHK.Enabled = True
            att = Absent_RBTN.Text
        End If
    End Sub

    Private Sub Leave_RBTN_CheckedChanged(sender As Object, e As EventArgs) Handles Leave_RBTN.CheckedChanged
        If Leave_RBTN.Checked = True Then
            NoteReason_CHK.Enabled = True
            att = Leave_RBTN.Text
        End If
    End Sub

    Private Sub Relieve_RBTN_CheckedChanged(sender As Object, e As EventArgs) Handles Relieve_RBTN.CheckedChanged
        If Relieve_RBTN.Checked = True Then
            NoteReason_CHK.Enabled = True
            att = Relieve_RBTN.Text
        End If
    End Sub

    Private Sub RestDay_RBTN_CheckedChanged(sender As Object, e As EventArgs) Handles RestDay_RBTN.CheckedChanged
        If RestDay_RBTN.Checked = True Then
            NoteReason_CHK.Enabled = False
            att = RestDay_RBTN.Text
        End If
    End Sub

    Private Sub NoteReason_CHK_CheckedChanged(sender As Object, e As EventArgs) Handles NoteReason_CHK.CheckedChanged
        If NoteReason_CHK.Checked = True Then
            NoteReason_TXT.ReadOnly = False
        ElseIf NoteReason_CHK.Checked = False Then
            NoteReason_TXT.ReadOnly = True
        End If
    End Sub

    Private Sub Emp_List_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Emp_List.SelectedIndexChanged
        If Not IsIDExist() Then

            For Each item As ListViewItem In Emp_List.SelectedItems
                EmpName_TXT.Tag = item.SubItems(0).Text
                EmpName_TXT.Text = item.SubItems(1).Text
                EmpPosition_TXT.Text = item.SubItems(2).Text
            Next

            Save_BTN.Enabled = True
            Update_BTN.Enabled = False

            NoteReason_TXT.Clear()
            Remarks_TXT.Clear()
        Else

            FetchDataForUpdate()

            Update_BTN.Enabled = True
            Save_BTN.Enabled = False
        End If

    End Sub

    Friend Function IsIDExist() As Boolean
        Dim mysql As String = "Select * From tbl_attendance Where emp_id = '" & Emp_List.Items(Emp_List.FocusedItem.Index).SubItems(0).Text & "'
                                and DATE_ENCODED = '" & DateEncoded_DTP.Value.ToShortDateString & "'"
        Using ds As DataSet = LoadSQL(mysql, "tbl_attendance")

            If ds.Tables Is Nothing Then Return False
            If ds.Tables(0).Rows.Count <= 0 Then Return False
        End Using
        Return True
    End Function

    Friend Sub FetchDataForUpdate()

        For Each item As ListViewItem In Emp_List.SelectedItems
            EmpName_TXT.Tag = item.SubItems(0).Text
            EmpName_TXT.Text = item.SubItems(1).Text
            EmpPosition_TXT.Text = item.SubItems(2).Text
        Next

        Dim sqlx As String = "Select * From tbl_attendance Where emp_id = '" & Emp_List.Items(Emp_List.FocusedItem.Index).SubItems(0).Text & "'"
        Using rdrx As FbDataReader = LoadSQL_byDataReader(sqlx)
            While rdrx.Read()
                If rdrx.HasRows Then
                    With rdrx
                        NoteReason_TXT.Text = .Item("NOTE")
                        Remarks_TXT.Text = .Item("REMARKS")
                    End With
                End If
            End While
        End Using

    End Sub

    Private Sub Save_BTN_Click(sender As Object, e As EventArgs) Handles Save_BTN.Click
        attendance = New HeadCount
        With attendance
            .EmpID = Emp_List.Items(Emp_List.FocusedItem.Index).SubItems(0).Text
            .BranchID = branchid
            .Attendance = att
            .DateEncoded = DateEncoded_DTP.Value.ToShortDateString
            .Remarks = Remarks_TXT.Text
            .NoteReason = NoteReason_TXT.Text
            .Status = 1

            .SaveAttendance()
            MessageBox.Show($"Attendance for {EmpName_TXT.Text} is successfully added.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            For Each i As ListViewItem In Emp_List.Items
                If i.Text = EmpName_TXT.Tag Then
                    i.Checked = True
                End If
            Next
            ClearAll()
        End With
    End Sub


    Private Sub Brows_BTN_Click(sender As Object, e As EventArgs) Handles Brows_BTN.Click
        Using fa As New FrmAttendanceList
            fa.ShowDialog()
        End Using
    End Sub

    Private Sub FrmMonitoring_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Update_BTN.Enabled = False
        tab = 1
        If Present_RBTN.Checked = True Then
            NoteReason_CHK.Enabled = False
            att = Present_RBTN.Text
        End If
        DateEncoded_DTP.Value = DateTime.Now
        L_DateStarted_DTP.Value = DateTime.Now
        L_DateEnded_DTP.Value = DateTime.Now

        'L_DateStarted_DTP.MinDate = Date.Today
        'L_DateEnded_DTP.MinDate = Date.Today
        LoadLeaveLists()
    End Sub

    Private Sub Update_BTN_Click(sender As Object, e As EventArgs) Handles Update_BTN.Click
        attendance = New HeadCount
        With attendance
            .ID = EmpPosition_TXT.Tag
            .EmpID = Emp_List.Items(Emp_List.SelectedIndices(0)).Text
            .BranchID = branchid
            .Attendance = att
            .DateEncoded = DateEncoded_DTP.Value.ToShortDateString
            .Remarks = Remarks_TXT.Text
            .NoteReason = NoteReason_TXT.Text
            .Status = 1

            .UpdateAttendance()
            MessageBox.Show($"Attendance for {EmpName_TXT.Text} is successfully updated.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearAll()
        End With
    End Sub

    Private Sub L_SearchEmp_BTN_Click(sender As Object, e As EventArgs) Handles L_SearchEmp_BTN.Click
        Dim secured_str As String = L_EmpName_TXT.Text
        secured_str = DreadKnight(secured_str)
        If frmworklist Is Nothing Then
            Dim frm As New frmworklist With {
                .MdiParent = frmMainForm
            }
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            'frm.chkassigned.Checked = True
            'frm.SearchSelect(secured_str, FormName.monitoring, tab)
            frm.Dock = DockStyle.Fill
            frm.SetLabelOpen("Leave", False)
            frm.Show()
            frm.BringToFront()
        Else
            frmworklist.BringToFront()
        End If
        Close()
    End Sub

    Private Sub MonitoringWindow_Selected(sender As Object, e As TabControlEventArgs) Handles MonitoringWindow.Selected
        If MonitoringWindow.SelectedTab.TabIndex = 0 Then
            tab = 1
        ElseIf MonitoringWindow.SelectedTab.TabIndex = 1 Then
            tab = 2
        End If
    End Sub

    Public Sub LoadEmpLeave(mPower As ManPower)
        With mPower
            L_EmpName_TXT.Tag = .EmpID
            L_EmpName_TXT.Text = $"{ .Lastname}, { .Firstname} { .Middlename} { .Suffix}"
            Dim i As ListViewItem = Branch_List.Items.Add(.BranchID)
            i.SubItems.Add(.Companyname)
            i.SubItems.Add(.Branchname)
            i.SubItems.Add(.Brancharea)
            i.SubItems.Add(.Branchcode)

            'i.Tag = .BranchID
        End With
        Dim sql As String = "select distinct(LEAVE_TYPE) as LeaveType from tbl_leave"
        Dim rdr As FbDataReader = LoadSQL_byDataReader(sql)
        L_Type_CB.Items.Clear()
        While rdr.Read()
            If rdr.HasRows Then
                With rdr
                    L_Type_CB.Items.Add(rdr.Item(0).ToString)
                End With
            End If
        End While
    End Sub

    Public Sub LoadLeaveLists()
        Dim sql As String = "select * from tbl_leave A inner join tbl_employee B on A.EMP_ID = B.ID inner join tbl_branch C on A.BRANCH_ID = C.ID"

        Using rdr As FbDataReader = LoadSQL_byDataReader(sql)
            Emp_Leave_LV.Items.Clear()

            While rdr.Read()
                If rdr.HasRows Then
                    With rdr
                        Dim i As ListViewItem = Emp_Leave_LV.Items.Add(.Item("ID"))
                        i.SubItems.Add(.Item("BRANCHNAME"))
                        i.SubItems.Add($"{ .Item("LASTNAME")}, { .Item("FIRSTNAME")} { .Item("MIDDLENAME")} { .Item("SUFFIX")}")
                        i.SubItems.Add(.Item("LEAVE_TYPE"))
                        i.SubItems.Add(.Item("L_DATE_STARTED"))
                        i.SubItems.Add(.Item("L_DATE_ENDED"))
                        i.SubItems.Add(.Item("DATE_ENCODED"))
                        i.SubItems.Add(.Item("NOTES"))
                    End With
                End If
            End While
        End Using

    End Sub

    Public Sub ClearAll()
        Branch_List.Items.Clear()
        L_Type_CB.Items.Clear()
        L_EmpName_TXT.Clear()
        L_Information_TXT.Clear()
        L_Save_BTN.Enabled = True
        L_Update_BTN.Enabled = False
        L_DateStarted_DTP.Value = DateTime.Now
        L_DateEnded_DTP.Value = DateTime.Now

        BranchName_TXT.Clear()
        CompanyName_TXT.Clear()
        BranchArea_TXT.Clear()
        Emp_List.Clear()
        EmpName_TXT.Clear()
        EmpPosition_TXT.Clear()
        NoteReason_TXT.Clear()
        Remarks_TXT.Clear()
        DateEncoded_DTP.Value = DateTime.Now
    End Sub

    Private Sub L_Save_BTN_Click(sender As Object, e As EventArgs) Handles L_Save_BTN.Click
        Try
            If SameDateLEave() Then
                MessageBox.Show("Employee name is already saved. You can update the date range", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If L_EmpName_TXT.TextLength <> 0 Then
                    Dim L_Mngt As New LeaveMngt
                    With L_Mngt
                        .BranchID = Branch_List.Items(0).SubItems(0).Text
                        .EmpID = L_EmpName_TXT.Tag
                        .Type = L_Type_CB.Text
                        .Started = L_DateStarted_DTP.Value.ToShortDateString
                        .Ended = L_DateEnded_DTP.Value.ToShortDateString
                        .Encoded = Now.ToShortDateString
                        .Notes = L_Information_TXT.Text
                        .Status = 1
                        .SaveLeave()
                    End With
                    'Dim a As String = $"{L_EmpName_TXT.Text} Is On {L_Type_CB.Text} starting {L_DateStarted_DTP.Value.ToShortDateString} To {L_DateEnded_DTP.Value.ToShortDateString}"

                    MessageBox.Show("Successfully Recorded", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadLeaveLists()
                    ClearAll()
                Else
                    MessageBox.Show("Nothing to save.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show($"Something went wrong, please try again{vbCrLf}{ex.Message}", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Friend Function SameDateLEave() As Boolean
        Dim mysql As String = "Select * From tbl_leave Where emp_id = '" & L_EmpName_TXT.Tag & "' and L_DATE_STARTED = '" & L_DateStarted_DTP.Value.ToShortDateString & "'"
        Using ds As DataSet = LoadSQL(mysql, "tbl_leave")

            If ds.Tables Is Nothing Then Return False
            If ds.Tables(0).Rows.Count <= 0 Then Return False
        End Using
        Return True
    End Function

    Private Sub L_EmpName_TXT_TextChanged(sender As Object, e As EventArgs) Handles L_EmpName_TXT.TextChanged
        If L_EmpName_TXT.TextLength < 5 Then
            L_Save_BTN.Enabled = False
        Else
            L_Save_BTN.Enabled = True
        End If
    End Sub

    Private Sub Emp_Leave_LV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Emp_Leave_LV.SelectedIndexChanged

        If Emp_Leave_LV.SelectedItems.Count > 0 Then
            For Each item As ListViewItem In Emp_Leave_LV.SelectedItems
                L_ID = item.SubItems(0).Text
                Dim sql As String = $"select * from tbl_branch where branchname = '{item.SubItems(1).Text}'"
                Branch_List.Items.Clear()
                Using rdr As FbDataReader = LoadSQL_byDataReader(sql)
                    While rdr.Read()
                        If rdr.HasRows Then
                            With rdr
                                Dim i As ListViewItem = Branch_List.Items.Add(.Item("ID"))
                                'i.Tag = .Item("ID"  
                                i.SubItems.Add(.Item("COMPANYNAME"))
                                i.SubItems.Add(.Item("BRANCHNAME"))
                                i.SubItems.Add(.Item("BRANCHAREA"))
                                i.SubItems.Add(.Item("BRANCHCODE"))
                            End With
                        End If
                    End While
                End Using

                Dim sqlx As String = $"select ID from tbl_employee where LASTNAME||', '||FIRSTNAME||' '||MIDDLENAME||' '||SUFFIX AS FULLNAME = '{item.SubItems(2).Text}'"
                Using rdrx As FbDataReader = LoadSQL_byDataReader(sql)
                    While rdrx.Read()
                        If rdrx.HasRows Then
                            With rdrx
                                empID = .Item("ID")
                            End With
                        End If
                    End While
                End Using
                L_EmpName_TXT.Text = item.SubItems(2).Text
                L_Information_TXT.Text = item.SubItems(7).Text
                L_DateStarted_DTP.Value = item.SubItems(4).Text
                L_DateEnded_DTP.Value = item.SubItems(5).Text

                If L_DateStarted_DTP.Value.Date <= DateTime.Today And L_DateEnded_DTP.Value.Date >= DateTime.Today Then
                    L_Save_BTN.Enabled = False
                    L_Update_BTN.Enabled = True

                ElseIf L_DateStarted_DTP.Value.Date >= DateTime.Today And L_DateEnded_DTP.Value.Date >= DateTime.Today Then
                    L_Save_BTN.Enabled = False
                    L_Update_BTN.Enabled = True
                Else
                    L_Save_BTN.Enabled = False
                    L_Update_BTN.Enabled = False
                End If

                Dim sqlxx As String = "select distinct(LEAVE_TYPE) as LeaveType from tbl_leave"
                Dim rdrxx As FbDataReader = LoadSQL_byDataReader(sqlxx)
                L_Type_CB.Items.Clear()
                While rdrxx.Read()
                    If rdrxx.HasRows Then
                        With rdrxx
                            L_Type_CB.Items.Add(rdrxx.Item(0).ToString)
                        End With
                    End If
                End While
                L_Type_CB.Text = item.SubItems(3).Text


            Next


        Else
            L_Update_BTN.Enabled = False
        End If
    End Sub

    Private Sub L_Update_BTN_Click(sender As Object, e As EventArgs) Handles L_Update_BTN.Click
        Try
            If L_EmpName_TXT.TextLength <> 0 Then
                Dim L_Mngt As New LeaveMngt
                With L_Mngt
                    .ID = L_ID
                    .BranchID = Branch_List.Items(0).SubItems(0).Text
                    .EmpID = empID
                    .Type = L_Type_CB.Text
                    .Started = L_DateStarted_DTP.Value.ToShortDateString
                    .Ended = L_DateEnded_DTP.Value.ToShortDateString
                    .Encoded = Now.ToShortDateString
                    .Notes = L_Information_TXT.Text
                    .Status = 1
                    .UpdateLeave()
                End With
                MessageBox.Show($"Leave record for {L_EmpName_TXT.Text} has been updated", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadLeaveLists()
                ClearAll()
            Else
                MessageBox.Show("Nothing to update.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show($"Something went wrong, please try again{vbCrLf}{ex.Message}", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub LoadLeaveSearch(ByVal search)

        Dim secured_str = DreadKnight(search)
        Dim mysql As String
        If secured_str.Length <> 0 Then
            mysql = "select * from tbl_leave A inner join tbl_employee B on A.EMP_ID = B.ID inner join tbl_branch C on A.BRANCH_ID = C.ID 
                    Where Upper(b.firstname) Like Upper('%" & secured_str & "%') OR Upper(b.lastname) Like Upper('%" & secured_str & "%') 
                    OR Upper(c.branchname) Like Upper('%" & secured_str & "%')  OR Upper(a.leave_type) Like Upper('%" & secured_str & "%')"
        Else
            mysql = "select * from tbl_leave A inner join tbl_employee B on A.EMP_ID = B.ID inner join tbl_branch C on A.BRANCH_ID = C.ID"
        End If

        Using ds As FbDataReader = LoadSQL_byDataReader(mysql)

            Emp_Leave_LV.Items.Clear()

            AddItem(ds)

        End Using
    End Sub

    Private Sub L_Search_BTN_Click(sender As Object, e As EventArgs) Handles L_Search_BTN.Click
        LoadLeaveSearch(L_Search_TXT.Text)
    End Sub

    Private Sub L_Search_TXT_TextChanged(sender As Object, e As EventArgs) Handles L_Search_TXT.TextChanged
        LoadLeaveSearch(L_Search_TXT.Text)
    End Sub

    Private Sub AddItem(ByVal dr As FbDataReader)
        While dr.Read()
            If dr.HasRows Then
                With dr
                    Dim i As ListViewItem = Emp_Leave_LV.Items.Add(.Item("ID"))
                    i.SubItems.Add(.Item("BRANCHNAME"))
                    i.SubItems.Add($"{ .Item("LASTNAME")}, { .Item("FIRSTNAME")} { .Item("MIDDLENAME")} { .Item("SUFFIX")}")
                    i.SubItems.Add(.Item("LEAVE_TYPE"))
                    i.SubItems.Add(.Item("L_DATE_STARTED"))
                    i.SubItems.Add(.Item("L_DATE_ENDED"))
                    i.SubItems.Add(.Item("DATE_ENCODED"))
                    i.SubItems.Add(.Item("NOTES"))
                End With
            End If
        End While
    End Sub

    Private Sub L_Cancel_BTN_Click(sender As Object, e As EventArgs) Handles L_Cancel_BTN.Click
        ClearAll()
    End Sub

    Friend Function SameDate() As Boolean
        Dim mysql As String = "Select * From tbl_leave Where L_DATE_STARTED = '" & L_DateStarted_DTP.Value.ToShortDateString & "' 
                                and L_DATE_ENDED = '" & L_DateEnded_DTP.Value.ToShortDateString & "'"
        Using ds As DataSet = LoadSQL(mysql, "tbl_leave")

            If ds.Tables Is Nothing Then Return False
            If ds.Tables(0).Rows.Count <= 0 Then Return False
        End Using
        Return True
    End Function
End Class