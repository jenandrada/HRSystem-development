Public Class frmappointment
    Dim appointid, employeeid, branchid, brandidx As String

    'Private tmpManPower As ManPower
    Private tmpappointment As appointment

    Private tmpbhouse As BhouseAllowance

    Private Sub BtnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub Btnwho_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnwho.Click
        Dim secured_str As String = txtWname.Text
        secured_str = DreadKnight(secured_str)

        If frmEmployeeList Is Nothing Then
            Dim frm As New frmEmployeeList With {
                .MdiParent = frmMainForm
            }
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            'frm.SearchSelect(secured_str, FormName.Appointment)
            frm.Dock = DockStyle.Fill
            frm.Show()
            frm.BringToFront()
        Else
            frmEmployeeList.BringToFront()
        End If
        Close()
    End Sub

    Friend Sub LoadPosition()
        Dim mysql As String = "Select Distinct(Emp_Position) From tblManning"
        Using ds As DataSet = LoadSQL(mysql, "tblManning")

            cboPosition.DataSource = ds.Tables(0)
        End Using
        cboPosition.DisplayMember = "Emp_Position"
        cboPosition.ValueMember = "Emp_Position"

    End Sub

    Friend Sub LoadAppointedLists(emp As appointment)
        With emp
            Appointed_Status.Text = Nothing
            Appointed_Status.Visible = True
            appointid = .ID
            employeeid = .employeid
            txtWname.Text = .LastName & " ," & .FirstName & "  " & .MiddleName & " " & .Suffix
            txtsex.Text = .gender
            txtcontact.Text = .contactno
            txtremarks.Text = .remarks
            txtcompanyname.Text = .companyname
            txtWArea.Text = .brancharea
            txtWcodebranch.Text = .branchcode
            dtpAssignDate.Text = .schedule
            branchid = .branchid
            Appointed_Status.Text = .Appointed_Status.ToString.Trim()
            Appointed_Status.ForeColor = Color.Green
            cboPosition.SelectedValue = .Emp_Position
            btnsave.Text = "Update"
        End With

    End Sub

    Friend Sub LoadAppointment(ByVal emp As Employee)

        With emp
            Appointed_Status.Text = Nothing
            Appointed_Status.Visible = True
            employeeid = .ID
            txtWname.Text = .LastName & ", " & .FirstName & "  " & .MiddleName & " " & .Suffix
            txtsex.Text = .Sex
            txtcontact.Text = .ContactNumber

            Dim mySql As String = "SELECT * from TBL_EMPLOYEE INNER JOIN TBLMANNING ON TBL_EMPLOYEE.ID=TBLMANNING.EMP_ID WHERE TBL_EMPLOYEE.ID ='" & .ID & "'  ORDER BY TBLMANNING.ID DESC"
            Dim ds As DataSet = LoadSQL(mySql, "TBLMANNING")

            If ds.Tables(0).Rows.Count > 0 Then
                For Each dr In ds.Tables(0).Rows
                    With dr
                        brandidx = .Item("BRANCH_ID")
                        branchid = .Item("BRANCH_ID")
                        cboPosition.SelectedValue = .Item("EMP_POSITION").ToString
                    End With

                Next

                Dim mysqlx As String = "SELECT * from TBL_BRANCH  WHERE ID ='" & brandidx & "'"
                Dim dsx As DataSet = LoadSQL(mysqlx, "TBL_BRANCH")

                For Each drx In dsx.Tables(0).Rows
                    With drx
                        branchid = (.item("ID"))
                        txtcompanyname.Text = (.item("COMPANYNAME"))
                        Branch_CB.SelectedValue = .item("ID")
                        txtWcodebranch.Text = (.item("BRANCHCODE"))
                        txtWArea.Text = (.item("BRANCHAREA"))
                    End With

                Next

            End If

        End With
    End Sub

    Private Sub btnsave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnsave.Click
        If btnsave.Text = "SAVE" Then
            If String.IsNullOrEmpty(txtWname.Text) And String.IsNullOrEmpty(txtremarks.Text) Then Exit Sub

            tmpappointment = New appointment
            With tmpappointment
                .employeid = employeeid
                .branchid = branchid
                .schedule = dtpAssignDate.Text
                .remarks = txtremarks.Text
                .Sign_Status = 1
                .Emp_Position = cboPosition.SelectedValue.ToString
                .Reason = ""
                .Week_Notify = dtpAssignDate.Value.AddDays(7)
                .Month_Notify = dtpAssignDate.Value.AddMonths(1)
                .SAVE_APPOINTMENT()
                If Yes_Rbtn.Checked = True And txtcompanyname.Text = "DALTON" Then
                    If cboPosition.Text = "TELLER" Or cboPosition.Text = "APPRAISER" Or cboPosition.Text = "OIC" Then
                        Dim sql As String = "select max(ID) as ID from tbl_appoint"
                        Using ds As DataSet = LoadSQL(sql, "tbl_appoint")

                            tmpbhouse = New BhouseAllowance
                            With tmpbhouse
                                .Manning_ID = ds.Tables(0).Rows(0).Item("ID")
                                If cboPosition.Text = "TELLER" Then
                                    .Allowance = 800.0
                                ElseIf cboPosition.Text = "APPRAISER" Then
                                    .Allowance = 1000.0
                                ElseIf cboPosition.Text = "OIC" Then
                                    .Allowance = 1200.0
                                End If
                                .Date_Notify = CurrentDate.AddMonths(2).ToShortDateString
                                .Status = 1
                                .SaveBAllowanceAppointed()
                            End With
                        End Using
                    Else
                        MsgBox("This feature is only applicable for Dalton Pawnshop Tellers, Appraisers, and Officer in Charge(OIC).", MsgBoxStyle.Exclamation, Application.ProductName)
                    End If
                Else
                    MsgBox("Boarding House Allowance Approval for " & vbCrLf & cboPosition.Text & ": " & txtWname.Text & " is denied.", MsgBoxStyle.Exclamation, Application.ProductName)
                End If
                MessageBox.Show("Appointment successfully" & vbCrLf & "recorded", Application.ProductName)
                cleartext()
            End With
            Exit Sub
        End If
        If btnsave.Text = "Update" Then
            If String.IsNullOrEmpty(txtWname.Text) And String.IsNullOrEmpty(txtremarks.Text) Then Exit Sub

            tmpappointment = New appointment
            With tmpappointment
                .ID = appointid
                .employeid = employeeid
                .branchid = branchid
                .schedule = dtpAssignDate.Text
                .remarks = txtremarks.Text
                .Uppdateappointment()
                MessageBox.Show("Appointment successfully" & vbCrLf & "recorded", Application.ProductName)
                cleartext()
            End With
            btnsave.Text = "SAVE"
            Exit Sub
        End If
    End Sub

    Private Sub cleartext()
        txtcompanyname.Clear()
        txtWArea.Clear()
        txtcontact.Clear()
        txtremarks.Clear()
        txtsex.Clear()
        txtWname.Clear()
        txtremarks.Clear()
        txtWcodebranch.Clear()
        Branch_CB.Enabled = False
        Appointed_Status.Text = ""
        Appointed_Status.Visible = False
    End Sub

    Private Sub Btnbrowse_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btnbrowse.Click
        Dim secured_str As String = txtWname.Text
        secured_str = DreadKnight(secured_str)

        If frmappointlist Is Nothing Then
            Dim frm As New frmappointlist
            frm.MdiParent = frmMainForm
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            'frm.SearchSelect(secured_str, FormName.appointmentlist)
            frm.Dock = DockStyle.Fill
            frm.Show()
            frm.BringToFront()
        Else
            frmappointlist.BringToFront()
        End If
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        cleartext()
    End Sub

    Private Sub frmappointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Branch_CB.Enabled = False
    End Sub

    Private Sub ChangeBranch_BTN_Click(sender As Object, e As EventArgs) Handles ChangeBranch_BTN.Click
        If txtWname.Text.Length > 10 Then
            Branch_CB.Enabled = True
        End If
    End Sub

    Friend Sub LoadBranches()
        Dim sql As String = "SELECT * FROM TBL_BRANCH"
        Using ds As DataSet = LoadSQL(sql, "TBL_BRANCH")

            Branch_CB.DataSource = ds.Tables(0)
        End Using
        Branch_CB.DisplayMember = "BRANCHNAME"
        Branch_CB.ValueMember = "ID"
    End Sub

    Private Sub Branch_CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Branch_CB.SelectedIndexChanged
        Dim sql As String = "SELECT * FROM TBL_BRANCH WHERE ID = '" & Branch_CB.SelectedValue.ToString & "';"
        Using ds As DataSet = LoadSQL(sql, "TBL_BRANCH")

            With ds.Tables(0).Rows(0)
                branchid = .Item("ID")
                brandidx = .Item("ID")
                txtcompanyname.Text = .Item("COMPANYNAME")
                txtWcodebranch.Text = .Item("BRANCHCODE")
                txtWArea.Text = (.Item("BRANCHAREA"))
            End With
        End Using
    End Sub

End Class