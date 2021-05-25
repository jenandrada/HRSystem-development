Imports System.Globalization
Imports System.Text.RegularExpressions

Public Class FormManagement
    Friend btnstatus As Integer
    Private tmpEmployee As Employee
    Private tmpbhouse As BhouseAllowance
    Private tmpBranch As Branch
    Dim tmpBranchName As String
    Private who_employeeid As String
    Private appointid, manningid, employeeid, branchid, relieveID, status As Integer
    Private tmpManPower As ManPower
    Private tmpappointment As appointment
    Dim tab As Integer

    Private Sub AR_Save_BTN_Click(sender As Object, e As EventArgs) Handles AR_Save_BTN.Click

        If AR_Save_BTN.Text = "Save" Then

            If IsNew() Then

                If Not IsEMPTY() Then Exit Sub

                tmpManPower = New ManPower

                With tmpManPower
                    .EmpID = employeeid
                    .Position = AR_Position_CB.Text.ToUpper(CultureInfo.CurrentCulture)
                    .BranchID = branchid
                    .AssignDate = AR_AssignDate_DTP.Value
                    .Remarks = AR_Remarks_TXT.Text.ToUpper(CultureInfo.CurrentCulture)
                    .Monthlynotify = AR_AssignDate_DTP.Value.AddMonths(1)
                    .Weeklynotify = AR_AssignDate_DTP.Value.AddDays(7)

                    If AR_Agree_RBTN.Checked = True Then
                        .Signstatus = 1
                    Else
                        .Signstatus = 0
                    End If

                    .Reason = AR_Reason_TXT.Text
                    .Assignstat = "1"
                    .SaveManPower()

                    If AR_Grant_RBTN.Checked = True Then
                        If AR_Position_CB.Text = "TELLER" Or AR_Position_CB.Text = "APPRAISER" Or AR_Position_CB.Text = "OIC" Then
                            Dim sql As String = "select max(ID) as ID from tblmanning"
                            Dim ds As DataSet = LoadSQL(sql, "tblmanning")

                            tmpbhouse = New BhouseAllowance
                            With tmpbhouse
                                .Manning_ID = ds.Tables(0).Rows(0).Item("ID")

                                If AR_Position_CB.Text = "TELLER" Then
                                    .Allowance = 800.0
                                ElseIf AR_Position_CB.Text = "APPRAISER" Then
                                    .Allowance = 1000.0
                                ElseIf AR_Position_CB.Text = "OIC" Then
                                    .Allowance = 1200.0
                                End If

                                .Date_Notify = CurrentDate.AddMonths(2).ToShortDateString
                                .Status = 1

                                If String.IsNullOrWhiteSpace(AR_OtherAllowance_TXT.Text) Then
                                    .Other_Allowance = 0
                                Else
                                    .Other_Allowance = AR_OtherAllowance_TXT.Text
                                End If

                                If String.IsNullOrWhiteSpace(AR_CareKit_TXT.Text) Then
                                    .CareKit_Allowance = 0
                                Else
                                    .CareKit_Allowance = AR_CareKit_TXT.Text
                                End If

                                .SaveBAllowance()
                                .UpdateFullAllowance()
                            End With
                        Else
                            MsgBox("This feature is only applicable for Dalton Pawnshop Tellers, Appraisers, and Officer in Charge(OIC).", MsgBoxStyle.Exclamation, Application.ProductName)
                        End If
                    ElseIf AR_Deny_RBTN.Checked = True And AR_Company_TXT.Text = "DALTON" Then
                        MsgBox("Boarding House Allowance Approval for " & vbCrLf & AR_Position_CB.Text & ": " & AR_EmpName_TXT.Text & " is denied.", MsgBoxStyle.Exclamation, Application.ProductName)
                    End If

                    AR_ClearText()
                    'Grpmode.Enabled = True
                    MessageBox.Show(AR_EmpName_TXT.Text & " ADDED SUCCESSFULLY ")
                End With
            Else
                MsgBox("Name Already Assigned! Please Click EDIT if you want to update Information", MsgBoxStyle.Critical, "Error")
            End If

            '-------------------Reassign through letter-------------

        ElseIf AR_Save_BTN.Text = "Update" Then

            tmpManPower = New ManPower
            With tmpManPower

                .Manningid = manningid
                .EmpID = employeeid
                .Position = AR_Position_CB.Text
                .Remarks = AR_Remarks_TXT.Text
                .AssignDate = AR_AssignDate_DTP.Value
                .BranchID = branchid
                .Monthlynotify = AR_AssignDate_DTP.Value.AddMonths(1)
                .Weeklynotify = AR_AssignDate_DTP.Value.AddDays(6)

                If AR_Branch_TXT.Text = tmpBranchName Then
                    status = 0
                Else
                    status = 1
                End If

                If AR_Agree_RBTN.Checked = True Then
                    .Signstatus = 1
                Else
                    .Signstatus = 0

                End If

                .Reason = AR_Reason_TXT.Text

                .UPDATEMANNING(employeeid)

                MessageBox.Show("SUCCESSFULLY UPDATED")
                AR_ClearText()

                'AR_Edit_BTN.Enabled = False
                'Grpmode.Enabled = True

            End With
        End If

    End Sub

    Private Function IsEMPTY()
        ' If tmpEmployee Is Nothing Then MsgBox("Invalid Employee", MsgBoxStyle.Critical, "Error") :
        ' Return False
        If tmpBranch Is Nothing Then MsgBox("Invalid Branch", MsgBoxStyle.Critical, "Error") : Return False
        If String.IsNullOrEmpty(AR_Position_CB.Text) Then MsgBox("Invalid Position", MsgBoxStyle.Critical, "Error") : Return False
        Return True
    End Function

    Private Function IsNew()

        Dim mysql As String = "SELECT * FROM tblmanning Where EMP_ID = '" & employeeid & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tblmanning")
        If ds.Tables(0).Rows.Count > 0 Then
            Return False
        End If
        Return True
    End Function


    Private Sub RE_SaveBTN_Click(sender As Object, e As EventArgs) Handles RE_SaveBTN.Click
        If RE_SaveBTN.Text = "Save" Then
            If String.IsNullOrEmpty(RE_WhoPosition_CB.Text) Then

                MsgBox("Invalid POSITION", MsgBoxStyle.Critical, "Error")
                Exit Sub

            End If
            tmpManPower = New ManPower
            With tmpManPower
                .RelieveID = employeeid
                .W_employee = who_employeeid
                .WBranchID = RE_WhoBranchName_TXT.Tag
                .AssignDate = RE_AssignDate_DTP.Value
                .W_remarks = RE_Remarks_TXT.Text
                .Relieve_position = RE_WhoPosition_CB.Text.ToUpper(CultureInfo.CurrentCulture)
                .NumberOfDays = RE_NumberOfDays_TXT.Value.ToString
                If RE_Agree_RBTN.Checked = True Then
                    .Signstatus = 1
                Else
                    .Signstatus = 0

                End If
                .Reason = RE_Reason_TXT.Text
                .R_Branch_ID = RE_BranchName_TXT.Tag
                .SAVERELIEVER()
                MessageBox.Show(RE_Name_TXT.Text & "" & " RELIEVE " & vbCrLf & " SUCCESSFULLY RECORDED")
                RE_ClearText()
                'Grpmode.Enabled = True
                'fieldsenable_true()
            End With

        ElseIf RE_SaveBTN.Text = "Update" Then
            tmpManPower = New ManPower
            With tmpManPower
                .RelieveID = relieveID
                .W_employee = who_employeeid
                .EmpID = employeeid
                .Position = RE_Position_CB.SelectedItem.ToString
                .AssignDate = RE_AssignDate_DTP.Value
                .Remarks = RE_Remarks_TXT.Text
                .NumberOfDays = RE_NumberOfDays_TXT.Value
                If RE_Agree_RBTN.Checked = True Then
                    .Signstatus = 1
                Else
                    .Signstatus = 0

                End If
                .Reason = RE_Reason_TXT.Text
                .Updatereleive()

                MessageBox.Show(RE_Name_TXT.Text & vbCrLf & "UPDATE RELIEVER ")
                RE_ClearText()
                RE_EditBTN.Enabled = False
                RE_SaveBTN.Text = "Save"

            End With
        End If
    End Sub



    Private Sub PRO_SaveBTN_Click(sender As Object, e As EventArgs) Handles PRO_SaveBTN.Click
        If PRO_SaveBTN.Text = "Save" Then
            If String.IsNullOrEmpty(PRO_Name_TXT.Text) And String.IsNullOrEmpty(PRO_Remarks_TXT.Text) Then Exit Sub

            tmpappointment = New appointment
            With tmpappointment
                .employeid = employeeid
                .branchid = branchid
                .schedule = PRO_PromotionDate_DTP.Text
                .remarks = PRO_Remarks_TXT.Text
                .Sign_Status = 1
                If PRO_Position_CB.SelectedItem = Nothing Then
                    .Emp_Position = PRO_Position_CB.Text
                Else
                    .Emp_Position = PRO_Position_CB.SelectedItem.ToString
                End If
                .Reason = ""
                .Week_Notify = PRO_PromotionDate_DTP.Value.AddDays(7)
                .Month_Notify = PRO_PromotionDate_DTP.Value.AddMonths(1)
                .SAVE_APPOINTMENT()
                If PRO_Grant_RBTN.Checked = True And PRO_Company_TXT.Text = "DALTON" Then
                    If PRO_Position_CB.Text = "TELLER" Or PRO_Position_CB.Text = "APPRAISER" Or PRO_Position_CB.Text = "OIC" Then
                        Dim sql As String = "select max(ID) as ID from tbl_appoint"
                        Using ds As DataSet = LoadSQL(sql, "tbl_appoint")

                            tmpbhouse = New BhouseAllowance
                            With tmpbhouse
                                .Manning_ID = ds.Tables(0).Rows(0).Item("ID")
                                If PRO_Position_CB.Text = "TELLER" Then
                                    .Allowance = 800.0
                                ElseIf PRO_Position_CB.Text = "APPRAISER" Then
                                    .Allowance = 1000.0
                                ElseIf PRO_Position_CB.Text = "OIC" Then
                                    .Allowance = 1200.0
                                End If
                                .Date_Notify = CurrentDate.AddMonths(2).ToShortDateString
                                .Status = 1
                                If String.IsNullOrWhiteSpace(PRO_OtherAllowance_TXT.Text) Then
                                    .Other_Allowance = 0
                                Else
                                    .Other_Allowance = PRO_OtherAllowance_TXT.Text
                                End If
                                If String.IsNullOrWhiteSpace(PRO_CareKit_TXT.Text) Then
                                    .CareKit_Allowance = 0
                                Else
                                    .CareKit_Allowance = PRO_CareKit_TXT.Text
                                End If
                                .SaveBAllowanceAppointed()
                            End With
                        End Using
                    Else
                        MsgBox("This feature is only applicable for Dalton Pawnshop Tellers, Appraisers, and Officer in Charge(OIC).", MsgBoxStyle.Exclamation, Application.ProductName)
                    End If
                Else
                    MsgBox("Boarding House Allowance Approval for " & vbCrLf & PRO_Position_CB.Text & ": " & PRO_Name_TXT.Text & " is denied.", MsgBoxStyle.Exclamation, Application.ProductName)
                End If
                MessageBox.Show("Appointment successfully" & vbCrLf & "recorded", Application.ProductName)
                'cleartext()
            End With
            Exit Sub
        End If
        If PRO_SaveBTN.Text = "Update" Then
            If String.IsNullOrEmpty(PRO_Name_TXT.Text) And String.IsNullOrEmpty(PRO_Remarks_TXT.Text) Then Exit Sub

            tmpappointment = New appointment
            With tmpappointment
                .ID = appointid
                .employeid = employeeid
                .branchid = branchid
                .schedule = PRO_PromotionDate_DTP.Text
                .remarks = PRO_Remarks_TXT.Text
                .Emp_Position = PRO_Position_CB.SelectedItem.ToString
                .Uppdateappointment()
                MessageBox.Show("Appointment successfully" & vbCrLf & "recorded", Application.ProductName)
                PRO_ClearText()
            End With
            PRO_EditBTN.Enabled = False
            PRO_SaveBTN.Text = "SAVE"
            Exit Sub
        End If
    End Sub


    Private Sub AR_ClearText()
        tmpBranch = Nothing
        tmpEmployee = Nothing
        AR_Company_TXT.Clear()
        AR_Branch_TXT.Clear()
        Status_TXT.Clear()
        'AR_BranchArea_TXT.Clear()
        'AR_BranchCode_TXT.Clear()
        AR_Reason_TXT.Clear()
        AR_EmpName_TXT.Clear()
        AR_Address_TXT.Clear()
        'AR_Gender_TXT.Clear()
        AR_Remarks_TXT.Clear()
        AR_MobileNUmber_TXT.Clear()
        AR_SearchBTN.Enabled = True
        AR_Deny_RBTN.Checked = True
        AR_OtherAllowance_CHK.Checked = False
        AR_CareKit_CHK.Checked = False
        AR_OtherAllowance_TXT.Clear()
        AR_CareKit_TXT.Clear()
        AR_Position_CB.Text = ""
        AR_Edit_BTN.BackColor = Color.White
        GroupBox3.Enabled = True
        AR_Save_BTN.Text = "Save"
    End Sub

    Private Sub RE_ClearText()
        RE_Name_TXT.Clear()
        RE_Address_TXT.Clear()
        'RE_Gender_TXT.Clear()
        RE_MobileNumber_TXT.Clear()
        RE_AssignDate_DTP.ResetText()
        RE_Remarks_TXT.Clear()
        RE_WhoName_TXT.Clear()
        'RE_WhoGender_TXT.Clear()
        RE_MobileNumber_TXT.Clear()
        RE_NumberOfDays_TXT.Value = 0
        RE_WhoRemarks_TXT.Clear()
        RE_BranchName_TXT.Clear()
        'RE_BranchCode_TXT.Clear()
        'RE_BranchArea_TXT.Clear()
        RE_Company_TXT.Clear()
        RE_Position_CB.SelectedIndex = 0
        RE_WhoBranchName_TXT.Clear()
        'RE_WhoBranchCode_TXT.Clear()
        'RE_WhoBranchArea_TXT.Clear()
        RE_WhoCompany_TXT.Clear()
        RE_WhoPosition_CB.SelectedIndex = 0
        RE_Reason_TXT.Clear()
    End Sub

    Private Sub PRO_ClearText()
        PRO_Name_TXT.Clear()
        PRO_Gender_TXT.Clear()
        PRO_MobileNumber_TXT.Clear()
        PRO_Company_TXT.Clear()
        PRO_BranchName_CB.SelectedIndex = 0
        PRO_BranchCode_TXT.Clear()
        PRO_BranchArea_TXT.Clear()
        PRO_Position_CB.SelectedIndex = 0
        PRO_PromotionDate_DTP.ResetText()
        PRO_Remarks_TXT.Clear()
        PRO_Reason_TXT.Clear()
        PRO_OtherAllowance_TXT.Clear()
        PRO_CareKit_TXT.Clear()
        PRO_Status_LBL.Text = "ASSIGNED"
    End Sub

    Private Sub FormManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AR_AssignDate_DTP.Value = Date.Now
        tab = 1
        Console.WriteLine(ManagementWindow.SelectedIndex.ToString)
    End Sub

    Private Sub NumberOfDays_TXT_ValueChanged(sender As Object, e As EventArgs) Handles RE_NumberOfDays_TXT.ValueChanged
        If RE_NumberOfDays_TXT.Value <= 0 Then
            RE_NumberOfDays_TXT.Value = 1
        End If
    End Sub

    Friend Sub LoadPosition()
        Dim mysql As String = "Select Distinct(Emp_Position) From tblManning"
        AR_Position_CB.Items.Clear()
        RE_Position_CB.Items.Clear()
        RE_WhoPosition_CB.Items.Clear()
        PRO_Position_CB.Items.Clear()

        Using ds As DataSet = LoadSQL(mysql, "tblManning")
            For Each dr As DataRow In ds.Tables(0).Rows
                AR_Position_CB.Items.Add(dr.Item("Emp_Position"))
                RE_Position_CB.Items.Add(dr.Item("Emp_Position"))
                RE_WhoPosition_CB.Items.Add(dr.Item("Emp_Position"))
                PRO_Position_CB.Items.Add(dr.Item("Emp_Position"))
            Next
        End Using
    End Sub

    Friend Sub LoadBranches()
        Dim sql As String = "SELECT BRANCHNAME FROM TBL_BRANCH"
        PRO_BranchName_CB.Items.Clear()
        Using ds As DataSet = LoadSQL(sql, "TBL_BRANCH")
            For Each dr As DataRow In ds.Tables(0).Rows
                With dr
                    PRO_BranchName_CB.Items.Add(.Item("BRANCHNAME"))
                End With
            Next
        End Using
    End Sub

    Private Sub AR_SearchBTN_Click(sender As Object, e As EventArgs) Handles AR_SearchBTN.Click
        Dim secured_str As String = AR_EmpName_TXT.Text
        secured_str = DreadKnight(secured_str)

        If frmEmployeeList Is Nothing Then
            Dim frm As New frmEmployeeList With {
                .MdiParent = frmMainForm
            }
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            'frm.SearchSelect(secured_str, FormName.Employee, 1)


            If AR_Edit_BTN.BackColor = Color.Red Then
                frm.txtSearch.Tag = "AssignmentEdit"
            Else
                frm.txtSearch.Tag = "Assignment"
            End If

            frm.Show()
            frm.Dock = DockStyle.Fill
            frm.BringToFront()
        Else
            frmEmployeeList.BringToFront()
        End If
    End Sub

    Public Sub LoadEmployeeInfo(ByVal emp As Employee, i As Integer)

        If emp Is Nothing Then
            Exit Sub
        End If

        If i = 1 Then

            employeeid = emp.ID

            'AR_EmpName_TXT.Tag = emp.ID
            ' tmpEmployee.ID = emp.ID
            AR_EmpName_TXT.Text = emp.FirstName & " " & emp.LastName
            AR_Address_TXT.Text = $"{ emp.PresentStreet } { emp.PresendAddress.Barangay } { emp.PresendAddress.CityMun } { emp.PresendAddress.Province }"
            AR_MobileNUmber_TXT.Text = emp.ContactNumber
            'AR_Gender_TXT.Text = emp.Sex
            AR_Remarks_TXT.Text = emp.Remarks
            AR_Branch_TXT.Text = emp.Branch
            AR_Branch_TXT.Tag = emp.BranchID
            AR_Position_CB.Text = emp.Position
            AR_Company_TXT.Text = emp.Company_Name

            Select Case emp.Status
                Case "RPO"
                    Status_TXT.Text = "PROBATIONARY"
                Case "REG"
                    Status_TXT.Text = "REGULAR"
                Case "AWO"
                    Status_TXT.Text = "AWOL"
                Case "RES"
                    Status_TXT.Text = "RESIGNED"
                Case "TER"
                    Status_TXT.Text = "TERMINATED"
                Case "SUS"
                    Status_TXT.Text = "SUSPENDED"
                Case "APP"
                    Status_TXT.Text = "APPOINTED"
                Case "End"
                    Status_TXT.Text = "END OF PROBATIONARY"
            End Select

        ElseIf i = 2 Then

            If btnstatus = 0 Then
                employeeid = emp.ID
                ' tmpEmployee.ID = emp.ID
                RE_Name_TXT.Text = emp.FirstName & " " & emp.LastName
                RE_Address_TXT.Text = $"{emp.PresentStreet } {emp.PresendAddress.Barangay } {emp.PresendAddress.CityMun } {emp.PresendAddress.Province }"
                RE_MobileNumber_TXT.Text = emp.ContactNumber
                'RE_Gender_TXT.Text = emp.Sex
                RE_Remarks_TXT.Text = emp.Remarks
                Try
                    Dim sql As String = $"Select TBL_BRANCH.ID, COMPANYNAME, BRANCHNAME, BRANCHCODE, BRANCHAREA, EMP_POSITION FROM TBLMANNING INNER JOIN TBL_BRANCH On TBLMANNING.BRANCH_ID = TBL_BRANCH.ID WHERE TBLMANNING.EMP_ID = {employeeid} ORDER BY ASSIGN_DATE DESC ROWS 1"
                    Using dsx As DataSet = LoadSQL(sql, "TBLMANNING")
                        If dsx.Tables(0).Rows.Count <= 0 Then
                            MessageBox.Show("this employee Is Not yet assigned", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Else
                            With dsx.Tables(0).Rows(0)
                                RE_BranchName_TXT.Tag = .Item("ID")
                                RE_BranchName_TXT.Text = .Item("BRANCHNAME")
                                'RE_BranchCode_TXT.Text = .Item("BRANCHCODE")
                                'RE_BranchArea_TXT.Text = .Item("BRANCHAREA")
                                RE_Company_TXT.Text = .Item("COMPANYNAME")
                                RE_Position_CB.SelectedItem = .Item("EMP_POSITION").ToString
                            End With
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            ElseIf btnstatus = 1 Then
                who_employeeid = emp.ID
                ' tmpEmployee.ID = emp.ID
                RE_WhoName_TXT.Text = emp.FirstName & " " & emp.LastName
                RE_WhoMobileNumber_TXT.Text = emp.ContactNumber
                'RE_WhoGender_TXT.Text = emp.Sex
                RE_WhoRemarks_TXT.Text = emp.Remarks
                Try
                    Dim sql As String = $"Select TBL_BRANCH.ID, COMPANYNAME, BRANCHNAME, BRANCHCODE, BRANCHAREA, EMP_POSITION FROM TBLMANNING INNER JOIN TBL_BRANCH On TBLMANNING.BRANCH_ID = TBL_BRANCH.ID WHERE TBLMANNING.EMP_ID = {who_employeeid} ORDER BY ASSIGN_DATE DESC ROWS 1"
                    Using dsxx As DataSet = LoadSQL(sql, "TBLMANNING")
                        If dsxx.Tables(0).Rows.Count <= 0 Then
                            MessageBox.Show("this employee Is Not yet assigned", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Else
                            With dsxx.Tables(0).Rows(0)
                                RE_WhoBranchName_TXT.Tag = .Item("ID")
                                RE_WhoBranchName_TXT.Text = .Item("BRANCHNAME")
                                'RE_WhoBranchCode_TXT.Text = .Item("BRANCHCODE")
                                'RE_WhoBranchArea_TXT.Text = .Item("BRANCHAREA")
                                RE_WhoCompany_TXT.Text = .Item("COMPANYNAME")
                                RE_WhoPosition_CB.SelectedItem = .Item("EMP_POSITION").ToString
                            End With
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        ElseIf i = 3 Then
            If btnstatus = 2 Then
                employeeid = emp.ID
                ' tmpEmployee.ID = emp.ID
                PRO_Name_TXT.Text = emp.FirstName & " " & emp.LastName
                PRO_MobileNumber_TXT.Text = emp.ContactNumber
                PRO_Gender_TXT.Text = emp.Sex
                Try
                    Dim sql As String = $"Select TBL_BRANCH.ID, COMPANYNAME, BRANCHNAME, BRANCHCODE, BRANCHAREA, EMP_POSITION FROM TBLMANNING INNER JOIN TBL_BRANCH On TBLMANNING.BRANCH_ID = TBL_BRANCH.ID WHERE TBLMANNING.EMP_ID = {employeeid} ORDER BY ASSIGN_DATE DESC ROWS 1"
                    Using ds As DataSet = LoadSQL(sql, "TBLMANNING")
                        If ds.Tables(0).Rows.Count <= 0 Then
                            MessageBox.Show("this employee Is Not yet assigned", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Else
                            With ds.Tables(0).Rows(0)
                                branchid = .Item("ID")
                                PRO_BranchName_CB.SelectedItem = .Item("BRANCHNAME")
                                PRO_BranchCode_TXT.Text = .Item("BRANCHCODE")
                                PRO_BranchArea_TXT.Text = .Item("BRANCHAREA")
                                PRO_Company_TXT.Text = .Item("COMPANYNAME")
                                PRO_Position_CB.SelectedItem = .Item("EMP_POSITION")
                            End With
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Friend Sub LoadAssigned(ByVal emp As ManPower)

        'AR_Status_LBL.Text = "REASSIGN"
        'AR_BranchCode_TXT.Text = emp.Branchcode
        'AR_BranchArea_TXT.Text = emp.Brancharea
        'AR_Gender_TXT.ReadOnly = True
        'AR_BranchCode_TXT.ReadOnly = True
        'AR_BranchArea_TXT.ReadOnly = True 
        'AR_Position_CB.Enabled = False
        'AR_Gender_TXT.Text = emp.Gendermybaswe
        'AR_BranchBTN.Enabled = False
        'GroupBox3.Enabled = False
        'txtreason.Enabled = False

        employeeid = emp.EmpID
        manningid = emp.Manningid
        AR_EmpName_TXT.Text = emp.Lastname & ", " & emp.Firstname & "  " & emp.Middlename & " " & emp.Suffix
        AR_Address_TXT.Text = emp.Presentaddres
        AR_Remarks_TXT.Text = emp.Remarks
        AR_Remarks_TXT.ReadOnly = True
        AR_MobileNUmber_TXT.Text = emp.Contactno
        AR_AssignDate_DTP.Value = emp.AssignDate
        AR_Position_CB.SelectedItem = emp.Position
        branchid = emp.BranchID
        AR_Reason_TXT.Text = emp.Reason
        If emp.Signstatus = 1 Then
            AR_Agree_RBTN.Checked = True
            AR_Declined_RBTN.Checked = False
        Else
            AR_Agree_RBTN.Checked = False
            AR_Declined_RBTN.Checked = True
        End If

        AR_Branch_TXT.Text = emp.Branchname
        tmpBranchName = emp.Branchname
        AR_Address_TXT.ReadOnly = True
        AR_Company_TXT.Text = emp.Companyname
        AR_MobileNUmber_TXT.ReadOnly = True
        AR_EmpName_TXT.ReadOnly = True
        AR_Branch_TXT.ReadOnly = True
        AR_SearchBTN.Enabled = False
        AR_Edit_BTN.Enabled = True
        AR_Company_TXT.ReadOnly = True

        Console.WriteLine("Position")

        Select Case emp.Stat
            Case ""
                Status_TXT.Text = ""
            Case "RPO"
                Status_TXT.Text = "PROBATIONARY"
            Case "REG"
                Status_TXT.Text = "REGULAR"
            Case "AWO"
                Status_TXT.Text = "AWOL"
            Case "RES"
                Status_TXT.Text = "RESIGNED"
            Case "TER"
                Status_TXT.Text = "TERMINATED"
            Case "SUS"
                Status_TXT.Text = "SUSPENDED"
            Case "APP"
                Status_TXT.Text = "APPOINTED"
            Case "End"
                Status_TXT.Text = "END OF PROBATIONARY"
        End Select

    End Sub

    Friend Sub LoadReleiverInfo(ByVal emp As ManPower)
        RE_Position_CB.Items.Clear()
        relieveID = emp.RelieveID
        employeeid = emp.ID

        manningid = emp.Manningid
        RE_Name_TXT.Text = emp.Lastname & ", " & emp.Firstname & "  " & emp.Middlename & " " & emp.Suffix
        RE_MobileNumber_TXT.Text = emp.Contactno
        RE_Address_TXT.Text = emp.Presentaddres
        RE_Remarks_TXT.Text = emp.Remarks
        'RE_Gender_TXT.Text = emp.Gender
        tmpBranchName = emp.Branchname
        RE_Position_CB.Items.Add(emp.Relieve_position)
        RE_Position_CB.SelectedIndex = 0
        who_employeeid = emp.W_employee
        RE_Reason_TXT.Text = emp.Reason

        If emp.Signstatus = 1 Then
            RE_Agree_RBTN.Checked = True
            RE_Decline_RBTN.Checked = False
        Else
            RE_Agree_RBTN.Checked = False
            RE_Decline_RBTN.Checked = True
        End If

        'SEARH WHO EMPLOYEE

        Try

            Dim mySql As String = "Select * from TBL_RELIEVE INNER JOIN TBL_EMPLOYEE On TBL_RELIEVE.W_EMPLOYEE_ID = TBL_EMPLOYEE.ID INNER JOIN TBL_BRANCH On TBL_RELIEVE.BRANCH_ID = TBL_BRANCH.ID WHERE TBL_EMPLOYEE.ID  = '" & emp.W_employee & "'"
            Dim ds As DataSet = LoadSQL(mySql)

            For Each drx In ds.Tables(0).Rows
                RE_WhoName_TXT.Text = drx.item("LASTNAME") & ", " & drx.item("FIRSTNAME") & " " & drx.item("MIDDLENAME") & " " & drx.item("SUFFIX")
                'RE_WhoGender_TXT.Text = drx.item("GENDER")
                RE_WhoMobileNumber_TXT.Text = drx.item("CONTACTNO")
                RE_Company_TXT.Text = drx.item("COMPANYNAME")
                RE_BranchName_TXT.Text = drx.item("BRANCHNAME")
                'RE_BranchCode_TXT.Text = drx.item("BRANCHCODE")
                'RE_BranchArea_TXT.Text = drx.item("BRANCHAREA")
                RE_WhoRemarks_TXT.Text = drx.item("REMARKS")
                RE_NumberOfDays_TXT.Value = drx.item("NUMBER_OF_DAYS_ASSIGNED")
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, Application.ProductName)
        End Try

        RE_WhoRemarks_TXT.ReadOnly = True
        RE_Name_TXT.ReadOnly = True
        RE_WhoName_TXT.ReadOnly = True
        RE_AssignDate_DTP.Enabled = False
        'RE_SearchBranchBTN.Enabled = False
        RE_SearchBTN.Enabled = False
        RE_Position_CB.Enabled = False
        RE_WhoPosition_CB.Enabled = False
        RE_WhoSearchBTN.Enabled = False
        GroupBox8.Enabled = False
        RE_EditBTN.Enabled = True
    End Sub

    Friend Sub LoadAppointedLists(emp As appointment)
        With emp
            PRO_Status_LBL.Text = Nothing
            PRO_Status_LBL.Visible = True
            appointid = .ID
            employeeid = .employeid
            PRO_Name_TXT.Text = .LastName & " ," & .FirstName & "  " & .MiddleName & " " & .Suffix
            PRO_Gender_TXT.Text = .gender
            PRO_MobileNumber_TXT.Text = .contactno
            PRO_Remarks_TXT.Text = .remarks
            PRO_Company_TXT.Text = .companyname
            PRO_BranchName_CB.SelectedItem = .branchname
            PRO_BranchArea_TXT.Text = .brancharea
            PRO_BranchCode_TXT.Text = .branchcode
            PRO_PromotionDate_DTP.Text = .schedule
            branchid = .branchid
            PRO_Status_LBL.Text = .Appointed_Status.ToString.Trim()
            PRO_Position_CB.SelectedItem = .Emp_Position
            PRO_EditBTN.Enabled = True
            GroupBox10.Enabled = False
            PRO_ChangeBranchBTN.Enabled = False
        End With

    End Sub

    Friend Sub LoadPosition_Appointed()
        Dim mysql As String = "Select Distinct(Emp_Position) From tblManning"
        PRO_Position_CB.Items.Clear()
        Using ds As DataSet = LoadSQL(mysql, "tblManning")
            For Each dr As DataRow In ds.Tables(0).Rows
                PRO_Position_CB.Items.Add(dr.Item("Emp_Position"))
            Next
        End Using
    End Sub

    Friend Sub LoadBranches_Appointed()
        Dim sql As String = "SELECT * FROM TBL_BRANCH"
        Dim ds As DataSet = LoadSQL(sql, "TBL_BRANCH")
        PRO_BranchName_CB.Items.Clear()

        For Each dr As DataRow In ds.Tables(0).Rows
            With dr
                PRO_BranchName_CB.Items.Add(.Item("BRANCHNAME"))
            End With
        Next

    End Sub

    Friend Sub LoadBranchInfo(ByVal brnch As Branch)
        branchid = brnch.ID
        AR_Branch_TXT.Text = brnch.BranchName
        'AR_BranchCode_TXT.Text = brnch.BranchCode
        'AR_BranchArea_TXT.Text = brnch.BranchArea
        AR_Company_TXT.Text = brnch.CompanyName

        tmpBranch = brnch
    End Sub

    Private Sub AR_BranchBTN_Click(sender As Object, e As EventArgs) Handles AR_BranchBTN.Click
        Dim secured_str As String = AR_Branch_TXT.Text
        secured_str = DreadKnight(secured_str)

        If frmBranchList Is Nothing Then
            Dim frm As New frmBranchList
            frm.MdiParent = frmMainForm
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            'frm.SearchSelect(secured_str, FormName.Branch)
            frm.Show()
            frm.BringToFront()
        Else
            frmBranchList.BringToFront()
        End If
    End Sub

    Private Sub RE_SearchBTN_Click(sender As Object, e As EventArgs) Handles RE_SearchBTN.Click
        btnstatus = 0
        Dim secured_str As String = RE_Name_TXT.Text
        secured_str = DreadKnight(secured_str)

        If frmEmployeeList Is Nothing Then
            Dim frm As New frmEmployeeList
            frm.MdiParent = frmMainForm
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            'frm.SearchSelect(secured_str, FormName.Employee, 2)
            'frm.txtSearch.Tag = "Relieve"
            frm.Show()
            frm.Dock = DockStyle.Fill
            frm.BringToFront()
        Else
            frmEmployeeList.BringToFront()
        End If
        Close()
    End Sub

    Private Sub RE_WhoSearchBTN_Click(sender As Object, e As EventArgs) Handles RE_WhoSearchBTN.Click
        btnstatus = 1
        Dim secured_str As String = RE_WhoName_TXT.Text
        secured_str = DreadKnight(secured_str)

        If frmEmployeeList Is Nothing Then
            Dim frm As New frmEmployeeList
            frm.MdiParent = frmMainForm
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            'frm.SearchSelect(secured_str, FormName.Employee, tab)
            frm.Show()
            frm.Dock = DockStyle.Fill
            frm.BringToFront()
        Else
            frmEmployeeList.BringToFront()
        End If
    End Sub

    Private Sub PRO_SearchBTN_Click(sender As Object, e As EventArgs) Handles PRO_SearchBTN.Click
        Dim secured_str As String = PRO_Name_TXT.Text
        secured_str = DreadKnight(secured_str)

        If frmEmployeeList Is Nothing Then
            Dim frm As New frmEmployeeList
            frm.MdiParent = frmMainForm
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            'frm.SearchSelect(secured_str, FormName.Employee, 3)
            frm.Show()
            frm.Dock = DockStyle.Fill
            frm.BringToFront()
        Else
            frmEmployeeList.BringToFront()
        End If
        Close()
    End Sub

    Private Sub PRO_OtherAllowance_TXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PRO_OtherAllowance_TXT.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not e.KeyChar = "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub PRO_OtherAllowance_TXT_TextChanged(sender As Object, e As EventArgs) Handles PRO_OtherAllowance_TXT.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        PRO_OtherAllowance_TXT.Text = digitsOnly.Replace(PRO_OtherAllowance_TXT.Text, "")
    End Sub

    Private Sub PRO_CareKit_TXT_TextChanged(sender As Object, e As EventArgs) Handles PRO_CareKit_TXT.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        PRO_CareKit_TXT.Text = digitsOnly.Replace(PRO_CareKit_TXT.Text, "")
    End Sub

    Private Sub PRO_CareKit_TXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PRO_CareKit_TXT.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not e.KeyChar = "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub AR_OtherAllowance_TXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AR_OtherAllowance_TXT.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not e.KeyChar = "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub AR_CareKit_TXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AR_CareKit_TXT.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not e.KeyChar = "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub AR_OtherAllowance_TXT_TextChanged(sender As Object, e As EventArgs) Handles AR_OtherAllowance_TXT.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        AR_OtherAllowance_TXT.Text = digitsOnly.Replace(AR_OtherAllowance_TXT.Text, "")
    End Sub

    Private Sub AR_CareKit_TXT_TextChanged(sender As Object, e As EventArgs) Handles AR_CareKit_TXT.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        AR_CareKit_TXT.Text = digitsOnly.Replace(AR_CareKit_TXT.Text, "")
    End Sub

    Private Sub AR_Browse_BTN_Click(sender As Object, e As EventArgs)
        'Dim secured_str As String = AR_EmpName_TXT.Text
        'secured_str = DreadKnight(secured_str)
        'If frmworklist Is Nothing Then
        '    Dim frm As New frmworklist With {
        '        .MdiParent = frmMainForm
        '    }
        '    frmMainForm.pNavigate.Controls.Add(frm)
        '    frmMainForm.pNavigate.Tag = frm
        '    'frm.chkassigned.Checked = True
        '    frm.SearchSelect(secured_str, FormName.Manpower, tab)
        '    frm.Dock = DockStyle.Fill
        '    frm.Show()
        '    frm.BringToFront()
        'Else
        '    frmworklist.BringToFront()
        'End If
        'Close()
    End Sub

    Private Sub RE_Browse_BTN_Click(sender As Object, e As EventArgs) Handles RE_Browse_BTN.Click
        Dim secured_str As String = RE_Name_TXT.Text
        secured_str = DreadKnight(secured_str)

        If frmworklist Is Nothing Then
            Dim frm As New frmworklist With {
                .MdiParent = frmMainForm
            }
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            'frm.RadioButton2.Checked = True
            'frm.SearchSelect(secured_str, FormName.Manpower, tab)
            frm.Dock = DockStyle.Fill
            frm.Show()
            frm.BringToFront()
        Else
            frmworklist.BringToFront()
        End If
        Close()
    End Sub

    Private Sub PRO_Browse_BTN_Click(sender As Object, e As EventArgs) Handles PRO_Browse_BTN.Click
        Dim secured_str As String = PRO_Name_TXT.Text
        secured_str = DreadKnight(secured_str)

        If frmappointlist Is Nothing Then
            Dim frm As New frmappointlist
            frm.MdiParent = frmMainForm
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            'frm.SearchSelect(secured_str, FormName.appointmentlist, tab)
            frm.Dock = DockStyle.Fill
            frm.Show()
            frm.BringToFront()
        Else
            frmappointlist.BringToFront()
        End If
        Close()
    End Sub

    Private Sub AR_Edit_BTN_Click(sender As Object, e As EventArgs) Handles AR_Edit_BTN.Click

        AR_Save_BTN.Text = "Update"
        AR_BranchBTN.Enabled = True
        AR_Grant_RBTN.Checked = False
        AR_Deny_RBTN.Checked = False

        Dim secured_str As String = AR_EmpName_TXT.Text
        secured_str = DreadKnight(secured_str)
        If frmworklist Is Nothing Then
            Dim frm As New frmworklist With {
                .MdiParent = frmMainForm
            }
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            'frm.chkassigned.Checked = True
            'frm.SearchSelect(secured_str, FormName.Manpower, 0)
            frm.txtSearch.Tag = "FormManagement1"
            frm.Dock = DockStyle.Fill
            frm.Show()
            frm.BringToFront()
        Else
            frmworklist.BringToFront()
        End If

    End Sub

    Private Sub AR_OtherAllowance_CHK_CheckedChanged(sender As Object, e As EventArgs) Handles AR_OtherAllowance_CHK.CheckedChanged
        If AR_OtherAllowance_CHK.Checked = True Then
            AR_OtherAllowance_TXT.ReadOnly = False
        ElseIf AR_OtherAllowance_CHK.Checked = False Then
            AR_OtherAllowance_TXT.ReadOnly = True
        End If
    End Sub

    Private Sub AR_CareKit_CHK_CheckedChanged(sender As Object, e As EventArgs) Handles AR_CareKit_CHK.CheckedChanged
        If AR_CareKit_CHK.Checked = True Then
            AR_CareKit_TXT.ReadOnly = False
        ElseIf AR_CareKit_CHK.Checked = False Then
            AR_CareKit_TXT.ReadOnly = True
        End If
    End Sub

    Private Sub AR_Set_BTN_Click(sender As Object, e As EventArgs) Handles AR_Set_BTN.Click
        If AR_Set_BTN.Text = "Set" Then
            AR_Grant_RBTN.Enabled = False
            AR_Deny_RBTN.Enabled = False
            AR_OtherAllowance_CHK.Enabled = False
            AR_CareKit_CHK.Enabled = False
            AR_OtherAllowance_TXT.Enabled = False
            AR_CareKit_TXT.Enabled = False
            AR_Particulars_TXT.Enabled = False
            AR_Set_BTN.Text = "Cancel"
        ElseIf AR_Set_BTN.Text = "Cancel" Then
            AR_Grant_RBTN.Enabled = True
            AR_Deny_RBTN.Enabled = True
            AR_OtherAllowance_CHK.Enabled = True
            AR_CareKit_CHK.Enabled = True
            AR_OtherAllowance_TXT.Enabled = True
            AR_CareKit_TXT.Enabled = True
            AR_Particulars_TXT.Enabled = True
            AR_Set_BTN.Text = "Set"
        End If
    End Sub

    Private Sub PRO_ClearAllBTN_Click(sender As Object, e As EventArgs) Handles PRO_ClearAllBTN.Click
        PRO_ClearText()
    End Sub

    Private Sub RE_ClearBTN_Click(sender As Object, e As EventArgs) Handles RE_ClearBTN.Click
        RE_ClearText()
    End Sub

    Private Sub AR_Clear_BTN_Click(sender As Object, e As EventArgs) Handles AR_Clear_BTN.Click
        AR_ClearText()
    End Sub

    Private Sub PRO_EditBTN_Click(sender As Object, e As EventArgs) Handles PRO_EditBTN.Click
        PRO_SaveBTN.Text = "Update"
        PRO_ChangeBranchBTN.Enabled = True
        GroupBox10.Enabled = True
    End Sub

    Private Sub PRO_ChangeBranchBTN_Click(sender As Object, e As EventArgs) Handles PRO_ChangeBranchBTN.Click
        PRO_BranchName_CB.Enabled = True
    End Sub

    Private Sub PRO_BranchName_CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PRO_BranchName_CB.SelectedIndexChanged
        Dim sql As String = $"SELECT * FROM TBL_BRANCH WHERE BRANCHNAME = '{PRO_BranchName_CB.SelectedItem.ToString}'"
        Dim ds As DataSet = LoadSQL(sql, "TBL_BRANCH")
        For Each dr As DataRow In ds.Tables(0).Rows
            With dr
                PRO_BranchCode_TXT.Text = .Item("BRANCHCODE")
                PRO_BranchArea_TXT.Text = .Item("BRANCHAREA")
                PRO_Company_TXT.Text = .Item("COMPANYNAME")
                branchid = .Item("ID")
            End With
        Next
    End Sub

    Private Sub PRO_OtherAllowance_CHK_CheckedChanged(sender As Object, e As EventArgs) Handles PRO_OtherAllowance_CHK.CheckedChanged
        If PRO_OtherAllowance_CHK.Checked = True Then
            PRO_OtherAllowance_TXT.ReadOnly = False
        ElseIf PRO_OtherAllowance_CHK.Checked = False Then
            PRO_OtherAllowance_TXT.ReadOnly = True
        End If
    End Sub

    Private Sub PRO_CareKit_CHK_CheckedChanged(sender As Object, e As EventArgs) Handles PRO_CareKit_CHK.CheckedChanged
        If PRO_CareKit_CHK.Checked = True Then
            PRO_CareKit_TXT.ReadOnly = False
        ElseIf PRO_CareKit_CHK.Checked = False Then
            PRO_CareKit_TXT.ReadOnly = True
        End If
    End Sub

    Private Sub PRO_SetBTN_Click(sender As Object, e As EventArgs) Handles PRO_SetBTN.Click
        If PRO_SetBTN.Text = "Set" Then
            PRO_Grant_RBTN.Enabled = False
            PRO_Deny_RBTN.Enabled = False
            PRO_OtherAllowance_CHK.Enabled = False
            PRO_CareKit_CHK.Enabled = False
            PRO_OtherAllowance_TXT.Enabled = False
            PRO_CareKit_TXT.Enabled = False
            PRO_Reason_TXT.Enabled = False
            PRO_SetBTN.Text = "Cancel"
        ElseIf PRO_SetBTN.Text = "Cancel" Then
            PRO_Grant_RBTN.Enabled = True
            PRO_Deny_RBTN.Enabled = True
            PRO_OtherAllowance_CHK.Enabled = True
            PRO_CareKit_CHK.Enabled = True
            PRO_OtherAllowance_TXT.Enabled = True
            PRO_CareKit_TXT.Enabled = True
            PRO_Reason_TXT.Enabled = True
            PRO_SetBTN.Text = "Set"
        End If
    End Sub

    Private Sub PRO_ClearBTN_Click(sender As Object, e As EventArgs) Handles PRO_ClearBTN.Click
        PRO_Grant_RBTN.Checked = False
        PRO_Deny_RBTN.Checked = True
        PRO_OtherAllowance_CHK.Checked = False
        PRO_CareKit_CHK.Checked = False
        PRO_OtherAllowance_TXT.Clear()
        PRO_CareKit_TXT.Clear()
        PRO_Reason_TXT.Clear()
    End Sub

    Private Sub AR_Clear_TXT_Click(sender As Object, e As EventArgs) Handles AR_Clear_TXT.Click
        AR_Grant_RBTN.Checked = False
        AR_Deny_RBTN.Checked = True
        AR_OtherAllowance_CHK.Checked = False
        AR_CareKit_CHK.Checked = False
        AR_OtherAllowance_TXT.Clear()
        AR_CareKit_TXT.Clear()
        AR_Reason_TXT.Clear()
        Status_TXT.Clear()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Close_BTN_Click(sender As Object, e As EventArgs) Handles Close_BTN.Click
        Close()
    End Sub

    Private Sub RE_EditBTN_Click(sender As Object, e As EventArgs) Handles RE_EditBTN.Click
        RE_AssignDate_DTP.Enabled = True
        RE_Remarks_TXT.Enabled = True
        RE_WhoSearchBTN.Enabled = True
        GroupBox8.Enabled = True
        RE_SaveBTN.Text = "Update"
    End Sub

    Private Sub AR_Cancel_BTN_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub RE_CancelBTN_Click(sender As Object, e As EventArgs) Handles RE_CancelBTN.Click
        Close()
    End Sub

    Private Sub PRO_CancelBTN_Click(sender As Object, e As EventArgs) Handles PRO_CancelBTN.Click
        Close()
    End Sub

End Class