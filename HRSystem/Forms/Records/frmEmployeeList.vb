Public Class frmEmployeeList
    Dim fromOtherForm As Boolean = False
    Dim frmOrig As FormName
    Dim progressBar As ProgressBar = frmMainForm.AppProgressBar
    Dim int As Integer
    Private ReadOnly scr_val As Integer = 0
    Dim rowCount As Integer
    Dim idx As Integer
    Private WithEvents tmrStatus As New Timer With {.Interval = 100, .Enabled = True}

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click

        Select Case Status_CB.SelectedIndex
            Case 0 Or String.IsNullOrEmpty(Status_CB.Text)
                LoadEmployee(txtSearch.Text)
            Case 1
                LoadEmployee(txtSearch.Text, "PROBATIONARY")
            Case 2
                LoadEmployee(txtSearch.Text, "REGULAR")
            Case 3
                LoadEmployee(txtSearch.Text, "AWOL")
            Case 4
                LoadEmployee(txtSearch.Text, "RESIGNED")
            Case 5
                LoadEmployee(txtSearch.Text, "TERMINATED")
            Case 6
                LoadEmployee(txtSearch.Text, "SUSPENDED")
            Case 7
                LoadEmployee(txtSearch.Text, "APPOINTED")
            Case 8
                LoadEmployee(txtSearch.Text, "END OF PROBATIONARY")
        End Select

        'LoadEmployee(txtSearch.Text)
        ListViewGrouping(lvEmployee, 4)
    End Sub

    Private Sub LoadEmployee(Optional ByVal str As String = "", Optional status As String = "")
        Try
            Dim secured_str As String = str
            secured_str = DreadKnight(secured_str)
            Dim strWords As String() = secured_str.Split(New Char() {" "c})
            Dim name As String

            Dim mysql As String
            If status = "" Then

                If str.Length <> 0 Then
                    mysql = "Select * From tbl_Employee Where "
                    For Each name In strWords
                        mysql &= vbCr & " UPPER(LastName ||' '|| FirstName ||' '|| MiddleName) LIKE UPPER('%" & name & "%') and "
                        mysql &= vbCr & "UPPER(FirstName ||' '|| MiddleName ||' '|| LastName) LIKE UPPER('%" & name & "%') and "
                        If name Is strWords.Last Then
                            mysql &= vbCr & " UPPER(FirstName ||' '|| LastName ||' '|| MiddleName) LIKE UPPER('%" & name & "%')"
                            Exit For
                        End If
                    Next
                Else
                    mysql = "Select * From tbl_Employee"
                End If

            Else

                If str.Length <> 0 Then
                    mysql = "Select * From tbl_Employee Where status = '" & status & "' and "
                    For Each name In strWords
                        mysql &= vbCr & " UPPER(LastName ||' '|| FirstName ||' '|| MiddleName) LIKE UPPER('%" & name & "%') and "
                        mysql &= vbCr & "UPPER(FirstName ||' '|| MiddleName ||' '|| LastName) LIKE UPPER('%" & name & "%') and "
                        If name Is strWords.Last Then
                            mysql &= vbCr & " UPPER(FirstName ||' '|| LastName ||' '|| MiddleName) LIKE UPPER('%" & name & "%')"
                            Exit For
                        End If
                    Next
                Else
                    mysql = "Select * From tbl_Employee"
                End If


            End If

            Using ds As DataSet = LoadSQL(mysql, "tbl_Employee")
                rowCount = ds.Tables(0).Rows.Count
                Dim maxEntries As Integer = ds.Tables(0).Rows.Count
                frmMainForm.AppProgressBar.Maximum = maxEntries
                frmMainForm.AppProgressBar.Visible = True
                lvEmployee.Items.Clear()
                For Each dr In ds.Tables(0).Rows
                    AddItem(dr)
                    frmMainForm.AppProgressBar.Value += 1
                Next
            End Using

            Output_Lbl.Text = "Record(s) " & (scr_val + 1) & " of " & rowCount
            frmMainForm.AppProgressBar.Value = 0
            frmMainForm.AppProgressBar.Maximum = 1000
            frmMainForm.AppProgressBar.Visible = False
        Catch ex As Exception
            Log_Report(ex.ToString())
        End Try
    End Sub


    Private Sub LoadEmployeeTruComboBox(ByVal str As String)
        Try
            Dim secured_str As String = str
            secured_str = DreadKnight(secured_str)
            Dim strWords As String() = secured_str.Split(New Char() {" "c})

            Dim mysql As String
            If Not str = "" Then
                mysql = $"Select * From tbl_Employee Where STATUS = '{str}'"
            Else
                mysql = "Select * From tbl_Employee"
            End If

            Using ds As DataSet = LoadSQL(mysql, "tbl_Employee")
                rowCount = ds.Tables(0).Rows.Count
                Dim maxEntries As Integer = ds.Tables(0).Rows.Count
                frmMainForm.AppProgressBar.Maximum = maxEntries
                frmMainForm.AppProgressBar.Visible = True
                lvEmployee.Items.Clear()
                For Each dr In ds.Tables(0).Rows
                    AddItem(dr)
                    frmMainForm.AppProgressBar.Value += 1
                Next
            End Using

            Output_Lbl.Text = "Record(s) " & (scr_val + 1) & " of " & rowCount
            frmMainForm.AppProgressBar.Value = 0
            frmMainForm.AppProgressBar.Maximum = 1000
            frmMainForm.AppProgressBar.Visible = False
        Catch ex As Exception
            Log_Report(ex.ToString())
        End Try
    End Sub

    Private Sub AddItem(ByVal dr As DataRow)
        If lvEmployee.Items.Count <= 20 Then
            With dr
                Dim lv As ListViewItem = lvEmployee.Items.Add(.Item("ID"))
                lv.SubItems.Add(String.Format("{0}, {1} {2}", .Item("LastName"), .Item("FirstName"), .Item("MiddleName")))
                lv.SubItems.Add(.Item("ContactNo"))
                lv.SubItems.Add(.Item("EmailAdd"))
                lv.ImageKey = "imgMale"
                If .Item("Gender") = "Female" Then
                    lv.ImageKey = "imgFemale"
                End If

                Dim sql As String = "SELECT * FROM TBL_ADDRESS WHERE ID = " & .Item("PRESENT_ADDID") & ";"
                Dim ds As DataSet = LoadSQL(sql, "TBL_ADDRESS")
                For Each drx In ds.Tables(0).Rows
                    lv.SubItems.Add(drx.Item("CITYMUN"))
                Next

                lv.SubItems.Add(.Item("BIOMETRICID"))

            End With
        Else
            Exit Sub
        End If
    End Sub

    Private Sub AddItemNextPrev(ByVal dr As DataRow)
        With dr
            Dim lv As ListViewItem = lvEmployee.Items.Add(.Item("ID"))
            lv.SubItems.Add(String.Format("{0}, {1} {2}", .Item("LastName"), .Item("FirstName"), .Item("MiddleName")))
            lv.SubItems.Add(.Item("ContactNo"))
            lv.SubItems.Add(.Item("EmailAdd"))
            lv.ImageKey = "imgMale"
            If .Item("Gender") = "Female" Then
                lv.ImageKey = "imgFemale"
            End If

            Dim sql As String = "SELECT * FROM TBL_ADDRESS WHERE ID = " & .Item("PRESENT_ADDID") & ";"
            Dim ds As DataSet = LoadSQL(sql, "TBL_ADDRESS")
            For Each drx In ds.Tables(0).Rows
                lv.SubItems.Add(drx.Item("CITYMUN"))
            Next
        End With
    End Sub

    Private Sub frmEmployeeList_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadEmployee("")
        ListViewGrouping(lvEmployee, 4)
    End Sub

    Private Sub OpenEmployee(FormName As String, tmpEmp As Employee)

        Dim instForm As Form = Application.OpenForms.OfType(Of Form)().Where(Function(frm) frm.Name = FormName).SingleOrDefault()
        If instForm Is Nothing Then
            Dim frm As New frmEmployeeDetails
            frm = DirectCast(CreateObjectInstance(FormName), Form)
            frm.MdiParent = frmMainForm
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            frm.Dock = DockStyle.Fill
            frm.Show()
            frm.LoadEmployees(tmpEmp)
            frm.BringToFront()
        Else
            instForm.Select()
            instForm.Dock = DockStyle.Fill
            instForm.BringToFront()

        End If
    End Sub

    Private Sub lvEmployee_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles lvEmployee.DoubleClick

        If Not fromOtherForm Then
            btnView.PerformClick()
        Else
            btnSelect.PerformClick()
        End If

    End Sub

    'Friend Sub SearchSelectx(ByVal src As String, ByVal frmOrigin As FormName)
    '    fromOtherForm = True
    '    btnSelect.Visible = True
    '    txtSearch.Text = src
    '    frmOrig = frmOrigin

    '    btnAdd.Visible = False
    '    btnView.Visible = False
    'End Sub

    'Friend Sub SearchSelect(src As String, ByVal frmOrigin As FormName, Optional i As Integer = 0)
    '    fromOtherForm = True
    '    btnSelect.Visible = True
    '    'txtSearch.Text = src
    '    frmOrig = frmOrigin
    '    int = i
    '    btnAdd.Visible = False
    '    btnView.Visible = False
    'End Sub

    Private Sub BtnSelect_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSelect.Click

        If lvEmployee.Items.Count = 0 Then Exit Sub

        Dim idx As Integer = lvEmployee.FocusedItem.Text
        Dim tmpEmp As Employee
        tmpEmp = New Employee

        If txtSearch.Tag = "Assignment" Then

            tmpEmp.LoadEmployee(idx)
            ReloadFormFromSearch(frmOrig, tmpEmp, int)

        ElseIf txtSearch.Tag = "Reassignment" Then

            tmpEmp.LoadEmpLetter(idx)
            ReloadFormFromSearch(FormName.letter, tmpEmp, 1)

        ElseIf txtSearch.Tag = "Appointment" Then

            tmpEmp.LoadEmpLetter(idx)
            ReloadFormFromSearch(FormName.letter, tmpEmp, 2)

        ElseIf txtSearch.Tag = "Allowance-Individual-1" Then

            tmpEmp.LoadEmpLetter(idx)
            ReloadFormFromSearch(FormName.letter, tmpEmp, 3, "Individual")

        ElseIf txtSearch.Tag = "Allowance-Individual-2" Then

            tmpEmp.LoadEmpLetter(idx)
            ReloadFormFromSearch(FormName.letter, tmpEmp, 3, "Individua2")

        ElseIf txtSearch.Tag = "Allowance-List" Then

            tmpEmp.LoadEmpLetter(idx)

            If Label_Header.Tag = "Boarding_Allowance" Then

                ReloadFormFromSearch(FormName.letter, tmpEmp, 3, "Boarding_Allowance")

            ElseIf Label_Header.Tag = "CareKit_Allowance" Then

                ReloadFormFromSearch(FormName.letter, tmpEmp, 3, "CareKit_Allowance")

            ElseIf Label_Header.Tag = "Other_Allowance" Then

                ReloadFormFromSearch(FormName.letter, tmpEmp, 3, "Other_Allowance")

            End If

            'ElseIf txtSearch.Tag = "Compensation" Then

            '    tmpEmp.LoadCompensationALLOWDEDUC(idx)
            '    ReloadFormFromSearch(FormName.compensation, tmpEmp)  

        ElseIf txtSearch.Tag = "Corrective1" Then

            tmpEmp.LoadCorrectiveDetails(idx)
            ReloadFormFromSearch(FormName.corrective, tmpEmp, 1)

        ElseIf txtSearch.Tag = "Corrective2" Then

            tmpEmp.LoadCorrectiveDetails(idx)
            ReloadFormFromSearch(FormName.corrective, tmpEmp, 2)

        ElseIf txtSearch.Tag = "IR-Supervisor" Then

            tmpEmp.LoadIRSupervisor(idx)
            ReloadFormFromSearch(FormName.corrective, tmpEmp, 3)

        ElseIf txtSearch.Tag = "IR-Person" Then

            tmpEmp.LoadIRPerson(idx)
            ReloadFormFromSearch(FormName.corrective, tmpEmp, 3, "person")

        End If

        Close()
    End Sub

    Private Sub Next_BTN_Click(sender As Object, e As EventArgs) Handles Next_BTN.Click
        Dim sql As String = "Select * From tbl_Employee"
        Dim ds As DataSet = NextPage(sql, rowCount, Output_Lbl, "tbl_Employee")
        lvEmployee.Items.Clear()
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr As DataRow In ds.Tables(0).Rows
                AddItemNextPrev(dr)
            Next
        End If
        ListViewGrouping(lvEmployee, 4)
    End Sub

    Private Sub Previous_BTN_Click(sender As Object, e As EventArgs) Handles Previous_BTN.Click
        Dim sql As String = "Select * From tbl_Employee"
        Dim ds As DataSet = PreviousPage(sql, rowCount, Output_Lbl, "tbl_Employee")
        lvEmployee.Items.Clear()
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr As DataRow In ds.Tables(0).Rows
                AddItemNextPrev(dr)
            Next
        End If
        ListViewGrouping(lvEmployee, 4)
    End Sub

    Private Sub LvEmployee_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lvEmployee.ColumnClick
        SortingOrder(lvEmployee, e.Column)
    End Sub

    Private Sub Status_CB_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles Status_CB.SelectedIndexChanged
        txtSearch.Text = ""

        Select Case Status_CB.SelectedIndex
            Case 0
                LoadEmployeeTruComboBox("")
            Case 1
                LoadEmployeeTruComboBox("PROBATIONARY")
            Case 2
                LoadEmployeeTruComboBox("REGULAR")
            Case 3
                LoadEmployeeTruComboBox("AWOL")
            Case 4
                LoadEmployeeTruComboBox("RESIGNED")
            Case 5
                LoadEmployeeTruComboBox("TERMINATED")
            Case 6
                LoadEmployeeTruComboBox("SUSPENDED")
            Case 7
                LoadEmployeeTruComboBox("APPOINTED")
            Case 8
                LoadEmployeeTruComboBox("END OF PROBATIONARY")
        End Select
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Timer2.Start() 'SEEE Timer1.Tick
        progressBar.Visible = True
    End Sub

    Private Sub btnView_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnView.Click
        If lvEmployee.SelectedItems.Count = 0 Then Exit Sub

        idx = lvEmployee.FocusedItem.Text

        Timer1.Start() 'SEEE Timer1.Tick
        progressBar.Visible = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick  '-------------------For progressbar connected to btnView.Click    

        progressBar.Increment(50)

        idx = lvEmployee.FocusedItem.Text
        Dim tmpEmp As Employee
        tmpEmp = New Employee
        tmpEmp.LoadEmployee(idx)

        If progressBar.Value = 750 Then

            OpenEmployee("frmEmployeeDetails", tmpEmp)

            progressBar.Value = progressBar.Maximum

        ElseIf progressBar.Value = progressBar.Maximum Then

            Timer1.Stop()
            progressBar.Value = 0
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        progressBar.Increment(50)

        If progressBar.Value = 750 Then

            OpenWindowsForm("frmEmployeeDetails")
            progressBar.Value = progressBar.Maximum

        ElseIf progressBar.Value = progressBar.Maximum Then
            Timer2.Stop()
            progressBar.Value = 0
        End If
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If IsEnter(e) Then btnSearch.PerformClick()
    End Sub

End Class