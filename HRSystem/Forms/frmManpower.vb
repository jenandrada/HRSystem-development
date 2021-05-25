Imports System.Globalization

Public Class frmManpower
    Private tmpbhouse As BhouseAllowance
    Private tmpEmployee As Employee
    Private tmpBranch As Branch
    Private tmpManPower As ManPower
    Dim who_employeeid As String
    Private btnstatus As String
    Private manningid, employeeid, branchid, relieveID As Integer

    'Dim frmOrig As FormName
    Dim brandidx As Integer

    Dim tmpBranchName As String
    Dim status As Integer

    Private Sub btnSearchName_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearchName.Click
        Dim secured_str As String = txtName.Text
        secured_str = DreadKnight(secured_str)

        If frmEmployeeList Is Nothing Then
            Dim frm As New frmEmployeeList
            frm.MdiParent = frmMainForm
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            'frm.SearchSelect(secured_str, FormName.Employee, IIf(chkassigned.Checked = True, 1, 0))
            frm.Show()
            frm.Dock = DockStyle.Fill
            frm.BringToFront()
        Else
            frmEmployeeList.BringToFront()
        End If
        btnstatus = 0
        Close()
    End Sub

    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtName.KeyPress
        If IsEnter(e) Then btnSearchName.PerformClick()

    End Sub

    Friend Sub LOADRELIEVERIFO(ByVal emp As ManPower)
        relieveID = emp.RelieveID
        employeeid = emp.ID

        manningid = emp.Manningid
        txtName.Text = emp.Lastname & " ," & emp.Firstname & "  " & emp.Middlename & " " & emp.Suffix
        txtAddress.Text = emp.Presentaddres
        txtRemarks.Text = emp.Remarks
        txtSex.Text = emp.Gender
        txtAddress.Text = emp.Presentaddres
        txtCompany.Text = emp.Companyname
        txtBranch.Text = emp.Branchname
        tmpBranchName = emp.Branchname
        txtCode.Text = emp.Branchcode
        txtArea.Text = emp.Brancharea
        cboPosition.Text = emp.Relieve_position

        who_employeeid = emp.W_employee
        txtreason.Text = emp.Reason
        If emp.Signstatus = 1 Then
            radioYES.Checked = True
            RadioDEC.Checked = False
        Else
            radioYES.Checked = False
            RadioDEC.Checked = True
        End If
        'SEARH WHO EMPLOYEE
        Try

            Dim mySql As String = "SELECT * from TBL_RELIEVE  INNER JOIN TBL_EMPLOYEE ON TBL_RELIEVE.W_EMPLOYEE_ID =TBL_EMPLOYEE.ID INNER JOIN TBL_BRANCH ON TBL_RELIEVE.BRANCH_ID =TBL_BRANCH.ID WHERE TBL_EMPLOYEE.ID  ='" & emp.W_employee & "'"
            Dim ds As DataSet = LoadSQL(mySql)

            For Each drx In ds.Tables(0).Rows

                txtWname.Text = (drx.item("LASTNAME") & "," & drx.item("FIRSTNAME") & " " & drx.item("MIDDLENAME") & " " & drx.item("SUFFIX"))
                txtWsex.Text = (drx.item("GENDER"))
                txtwcontact.Text = (drx.item("CONTACTNO"))
                txtcompanyname.Text = (drx.item("COMPANYNAME"))
                txtWbranch.Text = (drx.item("BRANCHNAME"))
                txtWcodebranch.Text = (drx.item("BRANCHCODE"))
                txtWArea.Text = (drx.item("BRANCHAREA"))
                txtWremarks.Text = (drx.item("REMARKS"))
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, Application.ProductName)
        End Try

        txtWremarks.ReadOnly = True
        txtRemarks.ReadOnly = True
        txtName.ReadOnly = True
        txtWname.ReadOnly = True
        lblmode.Text = "UPDATE RELIEVER"
        dtpAssignDate.Enabled = False
        btnSave.Text = "&Edit"
        btnSearchBranch.Enabled = False
        btnSearchName.Enabled = False
        dtpAssignDate.Enabled = False
        cboPosition.Enabled = False
        Grpmode.Enabled = False
        txtContactNo.Text = emp.Contactno
        chkrelieve.Checked = True
        btnwho.Enabled = False
        txtWremarks.ReadOnly = True
        txtreason.Enabled = False
    End Sub

    '========================================DISPLAY RELIEVER =============================================
    Friend Sub LOADASSIGGGN(ByVal emp As ManPower)

        employeeid = emp.EmpID

        manningid = emp.Manningid
        txtName.Text = emp.Lastname & ", " & emp.Firstname & "  " & emp.Middlename & " " & emp.Suffix
        txtAddress.Text = emp.Presentaddres
        txtRemarks.Text = emp.Remarks
        txtSex.Text = emp.Gender
        txtRemarks.ReadOnly = True
        txtContactNo.Text = emp.Contactno
        dtpAssignDate.Text = emp.AssignDate
        cboPosition.Text = emp.Position
        branchid = emp.BranchID
        txtreason.Text = emp.Reason
        If emp.Signstatus = 1 Then
            radioYES.Checked = True
            RadioDEC.Checked = False
        Else
            radioYES.Checked = False
            RadioDEC.Checked = True
        End If

        txtBranch.Text = emp.Branchname
        tmpBranchName = emp.Branchname
        txtCode.Text = emp.Branchcode
        txtArea.Text = emp.Brancharea
        txtCompany.Text = emp.Companyname

        txtName.ReadOnly = True
        txtBranch.ReadOnly = True
        txtCode.ReadOnly = True
        txtCompany.ReadOnly = True
        cboPosition.Enabled = False
        btnSave.Text = "&Edit"
        btnSearchBranch.Enabled = False
        btnSearchName.Enabled = False
        Grpmode.Enabled = False
        txtWremarks.ReadOnly = True
        txtreason.Enabled = False

    End Sub

    Public Sub LoadEmployeeInfo(ByVal emp As Employee, i As Integer)
        If i = 1 Then
            If emp Is Nothing Then
                Exit Sub
            End If
            If btnstatus = 0 Then

                employeeid = emp.ID
                ' tmpEmployee.ID = emp.ID
                txtName.Text = emp.FirstName & " " & emp.LastName
                txtAddress.Text = String.Format("{0} {1} {2}", emp.PresentStreet, emp.PresendAddress.Barangay, emp.PresendAddress.CityMun)
                txtContactNo.Text = emp.ContactNumber
                txtSex.Text = emp.Sex
                txtRemarks.Text = emp.Remarks

                txtRemarks.ReadOnly = True

            End If

            If btnstatus = 1 Then
                'chkrelieve.Checked = True
                Try
                    who_employeeid = emp.employid
                    txtWname.Text = emp.FirstName & " " & emp.LastName
                    txtWsex.Text = emp.Sex
                    who_employeeid = emp.ID
                    txtwcontact.Text = emp.ContactNumber
                    tmpManPower = New ManPower
                    With tmpManPower

                        Dim mySql As String = "  SELECT * from TBL_EMPLOYEE INNER JOIN TBLMANNING ON TBL_EMPLOYEE.ID=TBLMANNING.EMP_ID WHERE TBL_EMPLOYEE.ID ='" & who_employeeid & "' ORDER BY TBLMANNING.ID DESC"
                        Using ds As DataSet = LoadSQL(mySql)

                            brandidx = CDbl(ds.Tables(0).Rows(0).Item("BRANCH_ID"))
                        End Using

                        Dim mysqlx As String = "SELECT * from TBL_BRANCH  WHERE ID ='" & brandidx & "'"
                        Using dsx As DataSet = LoadSQL(mysqlx, "TBL_BRANCH")

                            For Each drx In dsx.Tables(0).Rows
                                branchid = (drx.item("ID"))
                                txtcompanyname.Text = (drx.item("COMPANYNAME"))
                                txtWbranch.Text = (drx.item("BRANCHNAME"))
                                txtWcodebranch.Text = (drx.item("BRANCHCODE"))
                                txtWArea.Text = (drx.item("BRANCHAREA"))

                            Next
                        End Using
                        .WBranchID = branchid
                    End With
                Catch ex As Exception
                    MessageBox.Show(txtWname.Text + "  " + "  NOT YET ASSIGNED.",
               "NOTICE",
               MessageBoxButtons.OK,
               MessageBoxIcon.Exclamation,
               MessageBoxDefaultButton.Button1)
                    txtWname.Clear()
                    txtWsex.Clear()
                    txtwcontact.Clear()

                End Try

            End If
        Else
            chkrelieve.Checked = True
            If btnstatus = 0 Then
                If emp Is Nothing Then
                    Exit Sub
                End If
                employeeid = emp.ID
                ' tmpEmployee.ID = emp.ID
                txtName.Text = emp.FirstName & " " & emp.LastName
                txtAddress.Text = String.Format("{0} {1} {2}", emp.PresentStreet, emp.PresendAddress.Barangay, emp.PresendAddress.CityMun)
                txtContactNo.Text = emp.ContactNumber
                txtSex.Text = emp.Sex
                txtRemarks.Text = emp.Remarks

                txtRemarks.ReadOnly = True

            End If

            If btnstatus = 1 Then
                Try
                    If emp Is Nothing Then
                        Exit Sub
                    End If
                    who_employeeid = emp.employid
                    txtWname.Text = emp.FirstName & " " & emp.LastName
                    txtWsex.Text = emp.Sex
                    who_employeeid = emp.ID
                    txtwcontact.Text = emp.ContactNumber
                    tmpManPower = New ManPower
                    With tmpManPower

                        Dim mySql As String = "  SELECT * from TBL_EMPLOYEE INNER JOIN TBLMANNING ON TBL_EMPLOYEE.ID=TBLMANNING.EMP_ID WHERE TBL_EMPLOYEE.ID ='" & who_employeeid & "' ORDER BY TBLMANNING.ID DESC"
                        Using ds As DataSet = LoadSQL(mySql)

                            brandidx = CDbl(ds.Tables(0).Rows(0).Item("BRANCH_ID"))
                        End Using

                        Dim mysqlx As String = "SELECT * from TBL_BRANCH  WHERE ID ='" & brandidx & "'"
                        Using dsx As DataSet = LoadSQL(mysqlx, "TBL_BRANCH")

                            For Each drx In dsx.Tables(0).Rows
                                branchid = (drx.item("ID"))
                                txtcompanyname.Text = (drx.item("COMPANYNAME"))
                                txtWbranch.Text = (drx.item("BRANCHNAME"))
                                txtWcodebranch.Text = (drx.item("BRANCHCODE"))
                                txtWArea.Text = (drx.item("BRANCHAREA"))

                            Next
                        End Using
                        .WBranchID = branchid
                    End With
                Catch ex As Exception
                    MessageBox.Show(txtWname.Text + "  " + "  NOT YET ASSIGNED.",
               "NOTICE",
               MessageBoxButtons.OK,
               MessageBoxIcon.Exclamation,
               MessageBoxDefaultButton.Button1)
                    txtWname.Clear()
                    txtWsex.Clear()
                    txtwcontact.Clear()

                End Try

            End If
        End If

    End Sub

    Friend Sub LoadCurrentBranch(dr As DataRow)
        With dr
            txtBranch.Tag = .Item("ID")
            txtBranch.Text = .Item("BRANCHNAME")
            txtCode.Text = .Item("BRANCHCODE")
            txtArea.Text = .Item("BRANCHAREA")
            txtCompany.Text = .Item("COMPANYNAME")
            tmpBranchName = .Item("BRANCHNAME")
        End With
    End Sub

    Friend Sub LoadBranchInfo(ByVal brnch As Branch)
        branchid = brnch.ID
        txtBranch.Text = brnch.BranchName
        txtCode.Text = brnch.BranchCode
        txtArea.Text = brnch.BranchArea
        txtCompany.Text = brnch.CompanyName

        tmpBranch = brnch
    End Sub

    Private Sub btnSearchBranch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearchBranch.Click
        Dim secured_str As String = txtBranch.Text
        secured_str = DreadKnight(secured_str)

        If frmBranchList Is Nothing Then
            Dim frm As New frmBranchList
            frm.MdiParent = frmMainForm
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            frm.SearchSelect(secured_str, FormName.Branch)
            frm.Show()
            frm.BringToFront()
        Else
            frmBranchList.BringToFront()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click

        If btnSave.Text = "&Save" And lblmode.Text = "ASSIGNED" Then
            If Not IsValid() Then Exit Sub

            tmpManPower = New ManPower
            With tmpManPower

                ' If Not isValid() Then Exit Sub
                .EmpID = employeeid
                .Position = cboPosition.Text.ToUpper(CultureInfo.CurrentCulture)
                .BranchID = branchid
                .AssignDate = dtpAssignDate.Text
                .Remarks = txtRemarks.Text.ToUpper(CultureInfo.CurrentCulture)
                .Monthlynotify = dtpAssignDate.Value.AddMonths(1)
                .Weeklynotify = dtpAssignDate.Value.AddDays(7)

                If radioYES.Checked = True Then
                    .Signstatus = 1
                Else
                    .Signstatus = 0

                End If
                .Reason = txtreason.Text
                .Assignstat = "1"
                .SaveManPower()
                If Yes_RBTN.Checked = True Then
                    If cboPosition.Text = "TELLER" Or cboPosition.Text = "APPRAISER" Or cboPosition.Text = "OIC" Then
                        Dim sql As String = "select max(ID) as ID from tblmanning"
                        Dim ds As DataSet = LoadSQL(sql, "tblmanning")

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
                            .SaveBAllowance()
                            '.UpdateFullAllowance()
                        End With
                    Else
                        MsgBox("This feature is only applicable for Dalton Pawnshop Tellers, Appraisers, and Officer in Charge(OIC).", MsgBoxStyle.Exclamation, Application.ProductName)
                    End If
                ElseIf No_RBTN.Checked = True And txtCompany.Text = "DALTON" Then
                    MsgBox("Boarding House Allowance Approval for " & vbCrLf & cboPosition.Text & ": " & txtName.Text & " is denied.", MsgBoxStyle.Exclamation, Application.ProductName)
                End If
                ClearText()
                Grpmode.Enabled = True
                MessageBox.Show(txtName.Text & " ADDED SUCCESSFULLY ")
            End With

        End If

        If btnSave.Text = "&Save" And lblmode.Text = "RELIEVE" Then

            If String.IsNullOrEmpty(cboPosition.Text) Then

                MsgBox("Invalid POSITION", MsgBoxStyle.Critical, "Error")
                Exit Sub

            End If
            tmpManPower = New ManPower
            With tmpManPower
                .RelieveID = employeeid
                .W_employee = who_employeeid
                .WBranchID = branchid
                .AssignDate = dtpAssignDate.Text
                .W_remarks = txtWremarks.Text
                .Relieve_position = cboPosition.Text.ToUpper(CultureInfo.CurrentCulture)
                .NumberOfDays = NumberOfDays_TXT.Value.ToString
                If radioYES.Checked = True Then
                    .Signstatus = 1
                Else
                    .Signstatus = 0

                End If
                .Reason = txtreason.Text
                .R_Branch_ID = txtBranch.Tag
                .SAVERELIEVER()
                If Yes_RBTN.Checked = True Then
                    If cboPosition.Text = "TELLER" Or cboPosition.Text = "APPRAISER" Or cboPosition.Text = "OIC" Then
                        Dim sql As String = "select max(RELIEVE_ID) as ID from tbl_relieve"
                        Using ds As DataSet = LoadSQL(sql, "tbl_relieve")

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
                                .SaveBAllowanceRelieved()
                            End With
                        End Using
                    Else
                        MsgBox("This feature is only applicable for Dalton Pawnshop Tellers, Appraisers, and Officer in Charge(OIC).", MsgBoxStyle.Exclamation, Application.ProductName)
                    End If
                ElseIf No_RBTN.Checked = True And txtCompany.Text = "DALTON" Then
                    MsgBox("Boarding House Allowance Approval for " & vbCrLf & cboPosition.Text & ": " & txtName.Text & " is denied.", MsgBoxStyle.Exclamation, Application.ProductName)
                End If
                MessageBox.Show(txtName.Text & "" & " RELIEVE " & vbCrLf & " SUCCESSFULLY RECORDED")
                ClearText()
                Grpmode.Enabled = True
                fieldsenable_true()
            End With

            Exit Sub

        End If

        If btnSave.Text = "&Edit" And lblmode.Text = "ASSIGNED" Then

            fieldsenable_true()
            btnSave.Text = "&Update"
            lblmode.Text = "UPDATE ASSIGNED"
            txtreason.Enabled = True
            Exit Sub
        ElseIf btnSave.Text = "&Edit" And lblmode.Text = "RELIEVE" Then

            fieldsenable_true()
            btnSave.Text = "&Update"
            lblmode.Text = "UPDATE RELIEVER"
            btnSearchBranch.Enabled = False
            txtreason.Enabled = True
            btnwho.Enabled = True
            Exit Sub

        ElseIf btnSave.Text = "&Update" And lblmode.Text = "UPDATE ASSIGNED" Then

            btnSave.Text = "&Save"
            tmpManPower = New ManPower
            With tmpManPower
                If lblmode.Text = "UPDATE ASSIGNED" Then
                    .Manningid = manningid
                    .EmpID = employeeid
                    .Position = cboPosition.Text
                    .Remarks = txtRemarks.Text
                    .AssignDate = dtpAssignDate.Text
                    .BranchID = branchid
                    .Monthlynotify = dtpAssignDate.Value.AddMonths(1)
                    .Weeklynotify = dtpAssignDate.Value.AddDays(6)
                    If txtBranch.Text = tmpBranchName Then
                        status = 0
                    Else
                        status = 1
                    End If
                    If radioYES.Checked = True Then
                        .Signstatus = 1
                    Else
                        .Signstatus = 0

                    End If
                    .Reason = txtreason.Text

                    .UPDATEMANNING(status)
                    If Yes_RBTN.Checked = True Then
                        If cboPosition.Text = "TELLER" Or cboPosition.Text = "APPRAISER" Or cboPosition.Text = "OIC" Then

                            tmpbhouse = New BhouseAllowance
                            With tmpbhouse
                                .Manning_ID = manningid
                                If cboPosition.Text = "TELLER" Then
                                    .Allowance = 800.0
                                ElseIf cboPosition.Text = "APPRAISER" Then
                                    .Allowance = 1000.0
                                ElseIf cboPosition.Text = "OIC" Then
                                    .Allowance = 1200.0
                                End If
                                .Date_Notify = CurrentDate.AddDays(10).ToShortDateString
                                .Status = 1
                                .SaveBAllowance()
                            End With
                        Else
                            MsgBox("This feature is only applicable for Dalton Pawnshop Tellers, Appraisers, and Officer in Charge(OIC).", MsgBoxStyle.Exclamation, Application.ProductName)
                        End If
                    ElseIf No_RBTN.Checked = True And txtCompany.Text = "DALTON" Then
                        MsgBox("Boarding House Allowance Approval for " & vbCrLf & cboPosition.Text & ": " & txtName.Text & " is denied.", MsgBoxStyle.Exclamation, Application.ProductName)
                    End If
                    MessageBox.Show("SUCCESSFULLY UPDATED")

                    lblmode.Text = "ASSIGNED"
                    ClearText()
                    btnSave.Text = "&SAVE"
                    Grpmode.Enabled = True
                Else

                End If

            End With

            Exit Sub

        ElseIf btnSave.Text = "&Update" And lblmode.Text = "UPDATE RELIEVER" Then
            tmpManPower = New ManPower
            With tmpManPower
                .RelieveID = relieveID
                .W_employee = who_employeeid
                .EmpID = employeeid
                .Position = cboPosition.Text
                .AssignDate = dtpAssignDate.Text
                .Remarks = txtRemarks.Text
                .NumberOfDays = NumberOfDays_TXT.Value
                If radioYES.Checked = True Then
                    .Signstatus = 1
                Else
                    .Signstatus = 0

                End If
                .Reason = txtreason.Text
                .Updatereleive()

                MessageBox.Show(txtName.Text & vbCrLf & "UPDATE RELIEVER ")
                ClearText()
                Grpmode.Enabled = True
                btnSave.Text = "&SAVE"

            End With
        End If

    End Sub

    Private Sub fieldsenable_true()
        txtName.ReadOnly = False

        cboPosition.Enabled = True

        txtRemarks.ReadOnly = False
        dtpAssignDate.Enabled = True
        btnSearchBranch.Enabled = True
        btnSearchName.Enabled = True

    End Sub

    Private Function IsValid()
        ' If tmpEmployee Is Nothing Then MsgBox("Invalid Employee", MsgBoxStyle.Critical, "Error") :
        ' Return False

        If chkassigned.Checked = False Then
        Else
            If tmpBranch Is Nothing Then MsgBox("Invalid Branch", MsgBoxStyle.Critical, "Error") : Return False
        End If

        If String.IsNullOrEmpty(cboPosition.Text) Then MsgBox("Invalid Position", MsgBoxStyle.Critical, "Error") : Return False

        Return True
    End Function

    Private Sub ClearText()
        tmpBranch = Nothing
        tmpEmployee = Nothing
        txtcompanyname.Clear()
        txtWbranch.Clear()
        txtWArea.Clear()
        txtWcodebranch.Clear()
        txtreason.Clear()
        NumberOfDays_TXT.Value = 0
        txtName.Clear()
        txtAddress.Clear()
        txtSex.Clear()
        txtCompany.Clear()
        txtBranch.Clear()
        txtCode.Clear()
        txtArea.Clear()
        txtCompany.Clear()
        txtRemarks.Clear()
        txtContactNo.Clear()
        'cboPosition.Text = ""
        txtWArea.Clear()
        txtWcodebranch.Clear()
        txtWsex.Clear()
        txtWname.Clear()
        txtWremarks.Clear()
    End Sub

    Private Sub BtnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        ClearText()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub FrmManpower_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadPosition()
    End Sub

    Private Sub LoadPosition()
        Dim mysql As String = "Select Distinct(Emp_Position) From tblManning"
        Dim ds As DataSet = LoadSQL(mysql, "tblManning")

        cboPosition.Items.Clear()

        For Each dr In ds.Tables(0).Rows
            cboPosition.Items.Add(dr.item("Emp_Position"))
        Next
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkassigned.CheckedChanged
        lblmode.Text = IIf(chkassigned.Checked = True, "ASSIGNED", "RELIEVE")
        grpinfo.Text = IIf(chkassigned.Checked = True, "INFORMATION", "RELIEVER INFORMATION")
        GrpWho.Visible = IIf(chkassigned.Checked = True, False, True)
        txtBranch.ReadOnly = IIf(chkassigned.Checked = True, False, True)

        btnSearchBranch.Enabled = IIf(chkassigned.Checked = True, True, False)
        If lblmode.Text = "ASSIGNED" Then
            btnSave.Text = "&Save"

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnwho.Click
        Dim secured_str As String = txtName.Text
        secured_str = DreadKnight(secured_str)

        If frmEmployeeList Is Nothing Then
            Dim frm As New frmEmployeeList With {
                .MdiParent = frmMainForm
            }
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            'frm.SearchSelect(secured_str, FormName.Employee, IIf(chkrelieve.Checked = True, 0, 1))
            frm.Dock = DockStyle.Fill
            frm.Show()
            frm.BringToFront()
        Else
            frmEmployeeList.BringToFront()
        End If
        btnstatus = 1
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Dim secured_str As String = txtName.Text
        secured_str = DreadKnight(secured_str)

        If frmworklist Is Nothing Then
            Dim frm As New frmworklist With {
                .MdiParent = frmMainForm
            }
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            'frm.SearchSelect(secured_str, FormName.Manpower)
            frm.Dock = DockStyle.Fill
            frm.Show()
            frm.BringToFront()
        Else
            frmworklist.BringToFront()
        End If
        Close()
    End Sub

    Private Sub Btnreopen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnreopen.Click
        ClearText()
        Grpmode.Enabled = True
        fieldsenable_true()
    End Sub

    Friend Sub LoadRelieveBranch(idx As Integer)
        Dim mySql As String = "select A.ID AS MID, B.ID, A.ASSIGN_DATE, B.BRANCHNAME, B.BRANCHCODE, B.BRANCHAREA, COMPANYNAME from TBLMANNING AS A INNER JOIN TBL_BRANCH AS B " +
            "ON A.BRANCH_ID = B.ID WHERE A.EMP_ID = " & idx & " ORDER BY A.ASSIGN_DATE DESC ROWS 1"
        Using ds As DataSet = LoadSQL(mySql)

            Dim dr As DataRow
            dr = ds.Tables(0).Rows(0)
            If dr.Table.Rows.Count > 0 Then
                LoadCurrentBranch(dr)
            Else
                Exit Sub
            End If
        End Using
    End Sub

    Private Sub TxtName_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtName.TextChanged
        Dim sql As String = "select * FROM EMP_ID_SEARCH where NAME = '" & txtName.Text & "';"
        Using ds As DataSet = LoadSQL(sql, "tbl_employee")
            tmpEmployee = New Employee
            If String.IsNullOrEmpty(txtName.Text) Then
            Else
                If lblmode.Text = "RELIEVE" Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        With ds.Tables(0).Rows(0)
                            LoadRelieveBranch(.Item("ID"))
                        End With
                    End If
                End If
                Grpmode.Enabled = True
            End If
        End Using
    End Sub

    Private Sub RadioYES_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioYES.CheckedChanged
        txtreason.Enabled = IIf(radioYES.Checked = True, False, True)
    End Sub

    Private Sub NumberOfDays_TXT_ValueChanged(sender As Object, e As EventArgs) Handles NumberOfDays_TXT.ValueChanged
        If NumberOfDays_TXT.Value > CDec(15) Then
            GroupBox2.Enabled = True
        End If
    End Sub

    Private Sub Chkrelieve_CheckedChanged(sender As Object, e As EventArgs) Handles chkrelieve.CheckedChanged
        GroupBox2.Enabled = False
    End Sub

End Class