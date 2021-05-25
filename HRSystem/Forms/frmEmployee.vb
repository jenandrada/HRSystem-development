Imports System.Globalization

Public Class frmEmployee
    Private tmpPresentAdd As Address
    Private tmpPermanentAdd As Address
    Private tmpEmployee As employee
    ' Private PresentAddressID As Integer = 0 Private PermanentAddressID As Integer = 0

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub txtBioID_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtBioID.KeyPress
        DigitOnly(e)
    End Sub

    Private Sub txtContactNum_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtContactNum.KeyPress
        DigitOnly(e)
    End Sub

    Private Sub frmEmployee_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadAddressPro()

        ' checklistreq()

    End Sub

    Private Sub LoadAddressPro()
        Dim mysql As String = "Select DISTINCT(Province) From tbl_Address"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Address")

        cboPermanentPro.Items.Clear()
        cboPresentPro.Items.Clear()

        For Each dr In ds.Tables(0).Rows
            cboPermanentPro.Items.Add(dr.item("Province"))
            cboPresentPro.Items.Add(dr.item("Province"))
        Next

    End Sub

    Private Sub cboPresentPro_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboPresentPro.SelectedIndexChanged
        Dim mysql As String = "Select DISTINCT(CityMun) From tbl_Address Where Province = '" & cboPresentPro.Text & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Address")

        cboPresentCityMun.Items.Clear()
        For Each dr In ds.Tables(0).Rows
            cboPresentCityMun.Items.Add(dr.item("CityMun"))
        Next

    End Sub

    Private Sub cboPresentCityMun_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboPresentCityMun.SelectedIndexChanged
        Dim mysql As String = "Select DISTINCT(Barangay) From tbl_Address Where CityMun = '" & cboPresentCityMun.Text & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Address")

        cboPresentBar.Items.Clear()
        For Each dr In ds.Tables(0).Rows
            cboPresentBar.Items.Add(dr.item("Barangay"))
        Next
    End Sub

    Private Sub cboPermanentPro_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboPermanentPro.SelectedIndexChanged
        Dim mysql As String = "Select DISTINCT(CityMun) From tbl_Address Where Province = '" & cboPermanentPro.Text & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Address")

        cboPermanentCityMun.Items.Clear()
        For Each dr In ds.Tables(0).Rows
            cboPermanentCityMun.Items.Add(dr.item("CityMun"))
        Next
    End Sub

    Private Sub cboPermanentCityMun_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboPermanentCityMun.SelectedIndexChanged
        Dim mysql As String = "Select DISTINCT(Barangay) From tbl_Address Where CityMun = '" & cboPermanentCityMun.Text & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Address")

        cboPermanentBar.Items.Clear()
        For Each dr In ds.Tables(0).Rows
            cboPermanentBar.Items.Add(dr.item("Barangay"))
        Next
    End Sub

    Private Sub cboPresentBar_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboPresentBar.SelectedIndexChanged
        Dim mysql As String = "Select * From tbl_Address Where Province = '" & cboPresentPro.Text & "' And CityMun = '" & cboPresentCityMun.Text & "' And Barangay = '" & cboPresentBar.Text & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Address")

        'For Each dr In ds.Tables(0).Rows
        '    PresentAddressID = dr.item("ID")
        'Next

        Dim tmpAdd As New Address
        tmpAdd.LoadAddress(ds.Tables(0).Rows(0).Item("ID"))

        tmpPresentAdd = tmpAdd
    End Sub

    Private Sub cboPermanentBar_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboPermanentBar.SelectedIndexChanged
        Dim mysql As String = "Select * From tbl_Address Where Province = '" & cboPermanentPro.Text & "' And CityMun = '" & cboPermanentCityMun.Text & "' And Barangay = '" & cboPermanentBar.Text & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_Address")

        'For Each dr In ds.Tables(0).Rows
        '    PermanentAddressID = dr.item("ID")
        'Next

        Dim tmpAdd As New Address
        tmpAdd.LoadAddress(ds.Tables(0).Rows(0).Item("ID"))

        tmpPermanentAdd = tmpAdd
    End Sub

    Private Sub Label12_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles Label12.DoubleClick
        cboPermanentPro.Text = cboPresentPro.Text
        cboPermanentCityMun.Text = cboPresentCityMun.Text
        cboPermanentBar.Text = cboPresentBar.Text
        txtPermanentStreet.Text = txtPresentStreet.Text
        'PermanentAddressID = PresentAddressID

        tmpPermanentAdd = tmpPresentAdd
    End Sub

    Private Sub ClearText()
        txtFirstname.Clear()
        txtMidname.Clear()
        txtLastName.Clear()
        txtSuffix.Clear()
        dtpDateofBirth.Value = Today
        dtpDateOfHired.Value = Today
        txtPermanentStreet.Clear()
        txtPresentStreet.Clear()
        txtBioID.Clear()
        txtContactNum.Clear()
        txtEmailAddress.Clear()
        txtSssNum.Clear()
        txtPhilHealth.Clear()
        txtTinNum.Clear()
        cboGender.SelectedIndex = -1
        cboPresentPro.Text = ""
        cboPresentCityMun.Text = ""
        cboPresentBar.Text = ""
        cboPermanentPro.Text = ""
        cboPermanentCityMun.Text = ""
        cboPermanentBar.Text = ""
        cboStatus.SelectedIndex = -1
        txtpagibig.Clear()

    End Sub

    Private Sub txtClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles txtClear.Click
        ClearText()
    End Sub

    Private Function isValidSave()
        If String.IsNullOrEmpty(txtFirstname.Text) Then MsgBox("Invalid Firstname", MsgBoxStyle.Critical, "Error") : Return False
        If String.IsNullOrEmpty(txtLastName.Text) Then MsgBox("Invalid Lastname", MsgBoxStyle.Critical, "Error") : Return False
        If String.IsNullOrEmpty(txtBioID.Text) Then MsgBox("Invalid Biometric ID", MsgBoxStyle.Critical, "Error") : Return False
        If String.IsNullOrEmpty(cboGender.Text) Then MsgBox("Invalid Gender", MsgBoxStyle.Critical, "Error") : Return False
        If txtEmailAddress.Text.Length <> 0 Then
            If Not (txtEmailAddress.Text.Contains("@") And txtEmailAddress.Text.Contains(".")) Then MsgBox("Invalid Email Address", MsgBoxStyle.Critical, "Error") : Return False
        End If
        'If cboPresentPro.Text <> "" Then
        '    If PresentAddressID = 0 Then MsgBox("Invalid Present Address", MsgBoxStyle.Critical, "Error") : Return False
        'End If

        If cboPermanentPro.Text.Length <> 0 Then
            If tmpPermanentAdd.ID = 0 Then MsgBox("Invalid Permanent Address", MsgBoxStyle.Critical, "Error") : Return False
        End If

        Return True
    End Function

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Dim tmpStatus As String = String.Empty
        Select Case cboStatus.Text
            Case "Probationary"
                tmpStatus = "RPO"
            Case "Regular"
                tmpStatus = "REG"
            Case "Awol"
                tmpStatus = "AWO"
            Case "Resigned"
                tmpStatus = "RES"
            Case "Terminated"
                tmpStatus = "TER"
            Case "Suspended"
                tmpStatus = "SUS"
            Case "Appointed"
                tmpStatus = "APP"
            Case "End of Probationary"
                tmpStatus = "END"
        End Select

        If btnSave.Text = "&Save" Then

            If Not isValidSave() Then Exit Sub
            tmpEmployee = New employee
            With tmpEmployee
                .FirstName = txtFirstname.Text.ToUpper(CultureInfo.CurrentCulture)
                .MiddleName = txtMidname.Text.ToUpper(CultureInfo.CurrentCulture)
                .LastName = txtLastName.Text.ToUpper(CultureInfo.CurrentCulture)
                .Suffix = txtSuffix.Text.ToUpper(CultureInfo.CurrentCulture)
                .DateofBirth = dtpDateofBirth.Value
                .PresentAddressID = tmpPresentAdd.ID
                .PresentStreet = txtPresentStreet.Text.ToUpper(CultureInfo.CurrentCulture)
                .PermanentAddressID = tmpPermanentAdd.ID
                .PermanentStreet = txtPermanentStreet.Text.ToUpper(CultureInfo.CurrentCulture)
                .Sex = cboGender.Text
                .EmailAddress = txtEmailAddress.Text
                .DateHired = dtpDateOfHired.Value
                .BiometricID = txtBioID.Text
                .ContactNumber = txtContactNum.Text
                .SSSNumber = txtSssNum.Text
                .PhilhealthNumber = txtPhilHealth.Text
                .TINNumber = txtTinNum.Text
                .Remarks = txtRemarks.Text
                .pagibignumber = txtpagibig.Text
                .Status = tmpStatus

                .SaveEmployee()
                Dim mySql As String = "SELECT MAX(ID) AS employid FROM TBL_employee"
                Using ds As DataSet = LoadSQL(mySql)
                    Dim a As Integer = CDbl(ds.Tables(0).Rows(0).Item("employid"))

                    '=============================== SAVE CHECK REQ LIST ================================================='

                    .employid = a
                End Using

                .PDS = IIf(chkPDS.Checked = True, 1, 0)
                .proba = IIf(chkProba.Checked = True, 1, 0)
                .moa = IIf(chkMoa.Checked = True, 1, 0)
                .idform = IIf(chkIDForm.Checked = True, 1, 0)
                .acknow = IIf(chkAckLetter.Checked = True, 1, 0)
                .barangay_C = IIf(chkBrgyClearance.Checked = True, 1, 0)
                .cedula = IIf(chkCedula.Checked = True, 1, 0)
                .NBI_C = IIf(chkNBI.Checked = True, 1, 0)
                .police_c = IIf(chkPoliceClearance.Checked = True, 1, 0)
                .health_C = IIf(chkHealthCard.Checked = True, 1, 0)
                .mayor_P = IIf(chkMayor.Checked = True, 1, 0)
                .sss = IIf(chkSSS.Checked = True, 1, 0)
                .health_C = 1 = IIf(chkPhilhealth.Checked = True, 1, 0)
                .pagIBIG = 1 = IIf(chkPagibig.Checked = True, 1, 0)
                .TIN = 1 = IIf(chkTin.Checked = True, 1, 0)
                .endorsement = IIf(chkendorsment.Checked = True, 1, 0)
                If .assignstatus = 1 Then
                Else

                End If

                '=============================== SAVE CHECK REQ LIST ================================================='

                Dim ChkBox As CheckBox = Nothing
                ' to unchecked all
                For Each xObject As Object In GroupBox1.Controls
                    If TypeOf xObject Is CheckBox Then
                        ChkBox = xObject
                        ChkBox.Checked = False
                    End If
                Next

                .SAVE_REQUIREMENTS()

            End With
            ClearText()
            MsgBox("New Record Added", MsgBoxStyle.Information, "Information")
        Else
            With tmpEmployee
                Console.Write(txtLastName.Text.ToUpper(CultureInfo.CurrentCulture))
                .LastName = txtLastName.Text.ToUpper(CultureInfo.CurrentCulture)

                .PresentAddressID = tmpPresentAdd.ID
                .PresentStreet = txtPresentStreet.Text.ToUpper(CultureInfo.CurrentCulture)
                .PermanentAddressID = tmpPermanentAdd.ID
                .PermanentStreet = txtPermanentStreet.Text.ToUpper(CultureInfo.CurrentCulture)
                .EmailAddress = txtEmailAddress.Text
                .ContactNumber = txtContactNum.Text
                .SSSNumber = txtSssNum.Text
                .PhilhealthNumber = txtPhilHealth.Text
                .TINNumber = txtTinNum.Text
                .Remarks = txtRemarks.Text
                .Status = tmpStatus
                .pagibignumber = txtpagibig.Text

                .UpdateEmployee()

                '=============================== UPDATE CHECK REQ LIST ================================================='

                .PDS = IIf(chkPDS.Checked = True, 1, 0)
                .proba = IIf(chkProba.Checked = True, 1, 0)
                .moa = IIf(chkMoa.Checked = True, 1, 0)
                .idform = IIf(chkIDForm.Checked = True, 1, 0)
                .acknow = IIf(chkAckLetter.Checked = True, 1, 0)
                .barangay_C = IIf(chkBrgyClearance.Checked = True, 1, 0)
                .cedula = IIf(chkCedula.Checked = True, 1, 0)
                .NBI_C = IIf(chkNBI.Checked = True, 1, 0)
                .police_c = IIf(chkPoliceClearance.Checked = True, 1, 0)
                .health_C = IIf(chkHealthCard.Checked = True, 1, 0)
                .mayor_P = IIf(chkMayor.Checked = True, 1, 0)
                .sss = IIf(chkSSS.Checked = True, 1, 0)
                .health_C = IIf(chkPhilhealth.Checked = True, 1, 0)
                .pagIBIG = IIf(chkPagibig.Checked = True, 1, 0)
                .TIN = IIf(chkTin.Checked = True, 1, 0)
                .endorsement = IIf(chkTin.Checked = True, 1, 0)

                .UPDATE_REQ()

                Dim ChkBox As CheckBox = Nothing
                ' to unchecked all
                For Each xObject As Object In GroupBox1.Controls
                    If TypeOf xObject Is CheckBox Then
                        ChkBox = xObject
                        ChkBox.Checked = False
                    End If
                Next
                '===============================CHECK REQ LIST ================================================='
            End With
            ClearText()
            btnSave.Text = "&Save"
            MsgBox("Record Updated", MsgBoxStyle.Information, "Information")
        End If
    End Sub

    Private Sub dtpDateofBirth_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dtpDateofBirth.ValueChanged
        ComputeBirthday()
    End Sub

    Private Sub ComputeBirthday()
        lblAge.Text = "N/A"
        lblAge.Text = GetCurrentAge(dtpDateofBirth.Value) & " years old"
    End Sub

    Friend Sub LoadEmployeeItem(ByVal emp As employee)
        txtFirstname.Text = emp.FirstName
        txtMidname.Text = emp.MiddleName
        txtLastName.Text = emp.LastName
        txtSuffix.Text = emp.Suffix
        txtContactNum.Text = emp.ContactNumber
        dtpDateofBirth.Value = IIf(emp.DateofBirth < dtpDateofBirth.MinDate.ToString, Date.Now.ToShortDateString, emp.DateofBirth)
        dtpDateOfHired.Value = IIf(emp.DateHired < dtpDateOfHired.MinDate.ToString, Date.Now.ToShortDateString, emp.DateHired)
        cboGender.Text = emp.Sex
        txtEmailAddress.Text = emp.EmailAddress
        txtSssNum.Text = emp.SSSNumber
        txtPhilHealth.Text = emp.PhilhealthNumber
        txtTinNum.Text = emp.TINNumber
        txtBioID.Text = emp.BiometricID
        txtpagibig.Text = emp.pagibignumber

        If Not emp.PresendAddress Is Nothing Then
            cboPresentPro.Text = IIf(String.IsNullOrEmpty(emp.PresendAddress.Province), "", emp.PresendAddress.Province)
            cboPresentCityMun.Text = IIf(String.IsNullOrEmpty(emp.PresendAddress.CityMun), "", emp.PresendAddress.CityMun)
            cboPresentBar.Text = IIf(String.IsNullOrEmpty(emp.PresendAddress.Barangay), "", emp.PresendAddress.Barangay)
            tmpPresentAdd = emp.PresendAddress
        End If
        txtPresentStreet.Text = emp.PresentStreet

        If Not emp.PermanentAddress Is Nothing Then
            cboPermanentPro.Text = IIf(String.IsNullOrEmpty(emp.PermanentAddress.Province), "", emp.PermanentAddress.Province)
            cboPermanentCityMun.Text = IIf(String.IsNullOrEmpty(emp.PermanentAddress.CityMun), "", emp.PermanentAddress.CityMun)
            cboPermanentBar.Text = IIf(String.IsNullOrEmpty(emp.PermanentAddress.Barangay), "", emp.PermanentAddress.Barangay)
        End If
        txtPermanentStreet.Text = emp.PermanentStreet

        lblAge.Text = GetCurrentAge(dtpDateofBirth.Value) & " years old"

        If emp.assignstatus = "1" Then
            lblstatwork.Text = "ASSIGNED"
            lblstatwork.BackColor = Color.Blue
            lblstatwork.ForeColor = Color.White
        Else
            lblstatwork.Text = "NEW"
        End If
        tmpPermanentAdd = emp.PermanentAddress
        tmpPresentAdd = emp.PresendAddress
        Select Case emp.Status
            Case "RPO"
                cboStatus.Text = "Probationary"
            Case "REG"
                cboStatus.Text = "Regular"
            Case "AWO"
                cboStatus.Text = "Awol"
            Case "RES"
                cboStatus.Text = "Resigned"
            Case "TER"
                cboStatus.Text = "Terminated"
            Case "SUS"
                cboStatus.Text = "Suspended"
            Case "APP"
                cboStatus.Text = "Appointed"
            Case "END"
                cboStatus.Text = "End of Probationary"
        End Select

        chkPDS.Checked = IIf(emp.PDS = 1, True, False)
        chkProba.Checked = IIf(emp.proba = 1, True, False)
        chkMoa.Checked = IIf(emp.moa = 1, True, False)
        chkIDForm.Checked = IIf(emp.idform = 1, True, False)
        chkAckLetter.Checked = IIf(emp.acknow = 1, True, False)
        chkBrgyClearance.Checked = IIf(emp.barangay_C = 1, True, False)
        chkCedula.Checked = IIf(emp.cedula = 1, True, False)
        chkPoliceClearance.Checked = IIf(emp.police_c = 1, True, False)
        chkNBI.Checked = IIf(emp.NBI_C = 1, True, False)
        chkHealthCard.Checked = IIf(emp.health_C = 1, True, False)
        chkPagibig.Checked = IIf(emp.pagIBIG = 1, True, False)
        chkTin.Checked = IIf(emp.TIN = 1, True, False)
        chkMayor.Checked = IIf(emp.mayor_P = 1, True, False)
        chkSSS.Checked = IIf(emp.sss = 1, True, False)
        chkendorsment.Checked = IIf(emp.endorsement = 1, True, False)

        Disable(False)
        tmpEmployee = emp
        btnSave.Text = "&Update"
    End Sub

    Private Sub Disable(ByVal st As Boolean)
        txtFirstname.Enabled = st
        txtMidname.Enabled = st
        txtSuffix.Enabled = st
        dtpDateofBirth.Enabled = st
        dtpDateOfHired.Enabled = st
        txtBioID.Enabled = st
        cboGender.Enabled = st
    End Sub

    Private Sub txtPhilHealth_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtPhilHealth.TextChanged
        If String.IsNullOrEmpty(txtPhilHealth.Text) Then
            chkPhilhealth.Checked = False
        Else
            chkPhilhealth.Checked = True
        End If
    End Sub

    Private Sub txtSssNum_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtSssNum.TextChanged
        If String.IsNullOrEmpty(txtSssNum.Text) Then
            chkSSS.Checked = False
        Else
            chkSSS.Checked = True
        End If
    End Sub

    Private Sub txtTinNum_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtTinNum.TextChanged
        If String.IsNullOrEmpty(txtTinNum.Text) Then
            chkTin.Checked = False
        Else
            chkTin.Checked = True
        End If
    End Sub

    Private Sub chkall_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkall.CheckedChanged
        If chkall.Checked = True Then

            For Each xObject As Object In GroupBox1.Controls
                If TypeOf xObject Is CheckBox Then
                    Dim ChkBox As CheckBox = xObject

                    ChkBox.Checked = True
                End If
            Next
        Else
            Dim ChkBox As CheckBox = Nothing
            ' to unchecked all
            For Each xObject As Object In GroupBox1.Controls
                If TypeOf xObject Is CheckBox Then
                    ChkBox = xObject
                    ChkBox.Checked = False
                End If
            Next
        End If

    End Sub

    Private Sub txtpagibig_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtpagibig.TextChanged
        If String.IsNullOrEmpty(txtpagibig.Text) Then
            chkPagibig.Checked = False
        Else
            chkPagibig.Checked = True
        End If
    End Sub

End Class