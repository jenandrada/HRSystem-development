Imports System.Drawing.Imaging
Imports System.Globalization
Imports System.IO

Imports FirebirdSql.Data.FirebirdClient

Public Class frmEmployeeDetails
    Private tmpPermanentAdd As Address
    Private tmpPresentAdd As Address
    Private tmpEmployee As Employee
    Private BI_Remarks As String = ""

    Private Sub LoadAddressPro()
        Dim source As New AutoCompleteStringCollection()
        source.Clear()
        Dim sql As String = $"Select distinct(Province) From tbl_Address"
        DbReaderClose()
        Using rd As FbDataReader = LoadSQL_byDataReader(sql)
            While rd.Read()
                If rd.HasRows Then
                    With rd
                        source.Add(.Item(0).ToString)
                    End With
                End If
            End While
            rd.Close()
            rd.Dispose()
        End Using
        PreA_Province_TXT.AutoCompleteCustomSource = source
        PerA_Province_TXT.AutoCompleteCustomSource = source
        PreA_Province_TXT.AutoCompleteSource = AutoCompleteSource.CustomSource
        PerA_Province_TXT.AutoCompleteSource = AutoCompleteSource.CustomSource
        PreA_Province_TXT.AutoCompleteMode = AutoCompleteMode.Suggest
        PerA_Province_TXT.AutoCompleteMode = AutoCompleteMode.Suggest
        DbReaderClose()
    End Sub

    Private Sub LoadAddressCityMun()
        Dim source As New AutoCompleteStringCollection()
        Dim sql As String = $"Select distinct(CityMun) From tbl_Address Where Province = '{PreA_Province_TXT.Text}'"
        DbReaderOpen()
        Using rd As FbDataReader = LoadSQL_byDataReader(sql)

            While rd.Read()
                If rd.HasRows Then
                    With rd
                        source.Add(.Item(0).ToString)
                    End With
                End If
            End While
            rd.Close()
        End Using
        PreA_CityMun_TXT.AutoCompleteCustomSource = source
        PreA_CityMun_TXT.AutoCompleteMode = AutoCompleteMode.Suggest
        PreA_CityMun_TXT.AutoCompleteSource = AutoCompleteSource.CustomSource
    End Sub

    Private Sub LoadAddressBrg()
        Dim source As New AutoCompleteStringCollection()
        Dim sql As String = $"Select ID, Barangay From tbl_Address Where CityMun = '{PreA_CityMun_TXT.Text}'"
        DbReaderOpen()
        Using rd As FbDataReader = LoadSQL_byDataReader(sql)

            While rd.Read()
                If rd.HasRows Then
                    With rd
                        source.Add(.Item("Barangay").ToString)
                        Dim tmpAdd As New Address
                        tmpAdd.LoadAddress(.Item("ID"))
                        tmpPresentAdd = tmpAdd
                    End With
                End If
            End While
            rd.Close()
        End Using
        PreA_Barangay_TXT.AutoCompleteCustomSource = source
        PreA_Barangay_TXT.AutoCompleteMode = AutoCompleteMode.Suggest
        PreA_Barangay_TXT.AutoCompleteSource = AutoCompleteSource.CustomSource

    End Sub

    Private Sub LoadAddressPerCityMun()
        Dim source As New AutoCompleteStringCollection()
        Dim sql As String = $"Select distinct(CityMun) From tbl_Address Where Province = '{PerA_Province_TXT.Text}'"
        DbReaderOpen()
        Using rd As FbDataReader = LoadSQL_byDataReader(sql)

            While rd.Read()
                If rd.HasRows Then
                    With rd
                        source.Add(.Item(0).ToString)
                    End With
                End If
            End While
            rd.Close()
        End Using
        PerA_CityMun_TXT.AutoCompleteCustomSource = source
        PerA_CityMun_TXT.AutoCompleteMode = AutoCompleteMode.Suggest
        PerA_CityMun_TXT.AutoCompleteSource = AutoCompleteSource.CustomSource

    End Sub

    Private Sub LoadAddressPerBrg()
        Dim source As New AutoCompleteStringCollection()
        Dim sql As String = $"Select ID, Barangay From tbl_Address Where CityMun = '{PerA_CityMun_TXT.Text}'"
        DbReaderOpen()
        Using rd As FbDataReader = LoadSQL_byDataReader(sql)
            While rd.Read()
                If rd.HasRows Then
                    With rd
                        source.Add(.Item("Barangay").ToString)
                        Dim tmpAdd As New Address
                        tmpAdd.LoadAddress(.Item("ID"))

                        tmpPermanentAdd = tmpAdd
                    End With
                End If
            End While
            rd.Close()
        End Using
        PerA_Barangay_TXT.AutoCompleteCustomSource = source
        PerA_Barangay_TXT.AutoCompleteMode = AutoCompleteMode.Suggest
        PerA_Barangay_TXT.AutoCompleteSource = AutoCompleteSource.CustomSource

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles CloseWindow_BTN.Click
        Close()
    End Sub

    Private Sub PopulateComboBox(combo As ComboBox, table As String, column As String)
        Dim sql As String = $"select distinct({column}) from {table}"
        Dim rdr As FbDataReader = LoadSQL_byDataReader(sql)
        combo.Items.Clear()
        While rdr.Read()
            If rdr.HasRows Then
                With rdr
                    combo.Items.Add(rdr.Item(0).ToString)
                End With
            End If
        End While
    End Sub

    Private Sub frmEmployeeDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BioNumber_TXT.Region = New Region(New Rectangle(2, 2, BioNumber_TXT.Width - 4, BioNumber_TXT.Height - 4))

        LoadAddressPro()
        PopulateComboBox(Position_combo, "tbl_employee", "EMP_POSITION")
        PopulateComboBox(Branch_combo, "tbl_branch", "BRANCHNAME")

        If ThisHasRow("tbl_employee") Then
            GreatestBiometric(BioNumber_TXT)
        End If


    End Sub


    Private Sub EmpProfile_Pic_DoubleClick(sender As Object, e As EventArgs) Handles EmpProfile_Pic.DoubleClick
        Using openF As New OpenFileDialog()
            Dim codecs As ImageCodecInfo() = ImageCodecInfo.GetImageEncoders()
            Dim sep As String = String.Empty
            With openF
                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                .Title = "Save As Image"
                .DefaultExt = ".JPG"
                .Filter = ""
                .FilterIndex = 2
                .RestoreDirectory = True
                .FileName = "*.JPG"
            End With
            For Each c As ImageCodecInfo In codecs
                Dim codecName As String = c.CodecName.Substring(8).Replace("Codec", "Files").Trim()
                openF.Filter = $"{openF.Filter }{sep }{codecName } ({c.FilenameExtension })|{c.FilenameExtension }"
                sep = "|"
            Next
            If openF.ShowDialog = DialogResult.OK Then
                If Not Image.FromFile(openF.FileName).Size = EmpProfile_Pic.InitialImage.Size Then
                    EmpProfile_Pic.Image = Image.FromFile(openF.FileName)
                    EmpProfile_Pic.Tag = openF.FileName
                    EmpProfile_Pic.SizeMode = PictureBoxSizeMode.StretchImage
                Else
                    EmpProfile_Pic.Image = Image.FromFile(openF.FileName)
                    EmpProfile_Pic.Tag = openF.FileName
                    EmpProfile_Pic.SizeMode = PictureBoxSizeMode.CenterImage
                End If
            End If
        End Using
    End Sub

    Friend Sub LoadEmployees(emp As Employee)

        CivilStatus_CB.Enabled = False
        ChangeStatus_CHK.Enabled = True
        FirstName_TXT.Tag = emp.ID
        FirstName_TXT.Text = emp.FirstName
        MiddleName_TXT.Text = emp.MiddleName
        LastName_TXT.Text = emp.LastName
        Extension_TXT.Text = emp.Suffix
        Extension_TXT.Tag = $"{ emp.LastName}, { emp.FirstName} { emp.MiddleName} { emp.Suffix}"
        MobileNum_TXT.Text = emp.ContactNumber

        If emp.DateofBirth < DateOfBirth_DTP.MinDate.ToString Then
            DateOfBirth_DTP.Value = Date.Now.ToShortDateString
        Else
            DateOfBirth_DTP.Value = emp.DateofBirth
        End If

        If emp.DateHired < DateHired_DTP.MinDate.ToString Then
            DateHired_DTP.Value = Date.Now.ToShortDateString
        Else
            DateHired_DTP.Value = emp.DateHired
        End If

        Dim year As String = DateHired_DTP.Value.ToString("yy")
        Dim month As String = DateHired_DTP.Value.ToString("MM")

        Age_TXT.Text = $"{GetCurrentAge(DateOfBirth_DTP.Value)} years old"
        Gender_CB.SelectedItem = emp.Sex
        CivilStatus_CB.SelectedItem = emp.CivilStatus
        CivilStatus_CB.Tag = emp.CivilStatus
        EmailAddress_TXT.Text = emp.EmailAddress
        SSSID_TXT.Text = emp.SSSNumber
        PHealthID_TXT.Text = emp.PhilhealthNumber
        PIbigID_TXT.Text = emp.pagibignumber
        TIN_TXT.Text = emp.TINNumber
        BioNumber_TXT.Text = emp.BiometricID
        'BioNumber_TXT.Text = year & "-0" & month & "-" & emp.BiometricID
        BI_Remarks = emp.BIRemarks
        Passed_RBTN.Checked = IIf(emp.BIRate = 1, True, False)
        Failed_RBTN.Checked = IIf(emp.BIRate = 0, True, False)
        Remarks_TXT.Text = emp.Remarks

        If Not emp.PresendAddress Is Nothing Then
            PreA_Province_TXT.Text = IIf(String.IsNullOrEmpty(emp.PresendAddress.Province), "", emp.PresendAddress.Province)
            PreA_CityMun_TXT.Text = IIf(String.IsNullOrEmpty(emp.PresendAddress.CityMun), "", emp.PresendAddress.CityMun)
            PreA_Barangay_TXT.Text = IIf(String.IsNullOrEmpty(emp.PresendAddress.Barangay), "", emp.PresendAddress.Barangay)
            tmpPresentAdd = emp.PresendAddress
        End If
        PreA_StBlkLot_TXT.Text = emp.PresentStreet
        PerA_StBlkLot_TXT.Text = PreA_StBlkLot_TXT.Text
        tmpPermanentAdd = emp.PermanentAddress
        If Not emp.PermanentAddress Is Nothing Then
            PerA_Province_TXT.Text = IIf(String.IsNullOrEmpty(emp.PermanentAddress.Province), "", emp.PermanentAddress.Province)
            PerA_CityMun_TXT.Text = IIf(String.IsNullOrEmpty(emp.PermanentAddress.CityMun), "", emp.PermanentAddress.CityMun)
            PerA_Barangay_TXT.Text = IIf(String.IsNullOrEmpty(emp.PermanentAddress.Barangay), "", emp.PermanentAddress.Barangay)
        End If
        PerA_StBlkLot_TXT.Text = emp.PermanentStreet

        If emp.assignstatus = "1" Then
            Status_LBL.Text = "ASSIGNED"
            Status_LBL.BackColor = Color.Blue
            Status_LBL.ForeColor = Color.White
        Else
            Status_LBL.Text = "NEW"
            Status_LBL.BackColor = Color.LightGreen
        End If

        Status_CB.SelectedItem = emp.Status

        If Status_CB.SelectedIndex = 5 Or Status_CB.SelectedIndex = 7 Then

            If emp.LastDate < Last_date.MinDate.ToString Then
                Last_date.Value = Date.Now.ToShortDateString
            Else
                Last_date.Value = emp.LastDate
                Remarks_TXT.Text = emp.Reason
            End If
        End If

        Position_combo.Text = emp.Position
        Branch_combo.Text = emp.Branch
        Branch_combo.Tag = emp.BranchID
        PDS_CHK.Checked = IIf(emp.PDS = 1, True, False)
        PROBA_CHK.Checked = IIf(emp.proba = 1, True, False)
        MOA_CHK.Checked = IIf(emp.moa = 1, True, False)
        IDForm_CHK.Checked = IIf(emp.idform = 1, True, False)
        ALetter_CHK.Checked = IIf(emp.acknow = 1, True, False)
        BrgClearance_CHK.Checked = IIf(emp.barangay_C = 1, True, False)
        Cedula_CHK.Checked = IIf(emp.cedula = 1, True, False)
        PClearance_CHK.Checked = IIf(emp.police_c = 1, True, False)
        NBIClearance_CHK.Checked = IIf(emp.NBI_C = 1, True, False)
        HealthCard_CHK.Checked = IIf(emp.health_C = 1, True, False)
        MPermit_CHK.Checked = IIf(emp.mayor_P = 1, True, False)
        ELetter_CHK.Checked = IIf(emp.endorsement = 1, True, False)

        Dim namePic As String = ""

        'If MiddleName_TXT.Text = "" Then
        '    namePic = LastName_TXT.Text & ", " & FirstName_TXT.Text & " -"
        'Else
        '    namePic = LastName_TXT.Text & ", " & FirstName_TXT.Text & " " & MiddleName_TXT.Text
        'End If

        namePic = LastName_TXT.Text & ", " & FirstName_TXT.Text & " " & MiddleName_TXT.Text
        namePic = namePic.ToString.TrimEnd()

        emp.LoadImage(namePic, EmpProfile_Pic, "Profile")
        emp.LoadImage(namePic, SSSID_PB, "SSS")
        emp.LoadImage(namePic, PhilHealth_PB, "PhilHealth")
        emp.LoadImage(namePic, PagIbig_PB, "TIN")
        emp.LoadImage(namePic, TIN_PB, "PagIbig")
        emp.LoadImage(namePic, BClearance_PB, "Barangay Clearance")
        emp.LoadImage(namePic, Cedula_PB, "Cedula")
        emp.LoadImage(namePic, PClearance_PB, "Police Clearance")
        emp.LoadImage(namePic, NBIClearance_PB, "NBI Clearance")
        emp.LoadImage(namePic, HealthCard_PB, "Health Card")
        emp.LoadImage(namePic, MayorsPermit_PB, "Mayors Permit")
        emp.LoadImage(namePic, PDS_PB, "PDS")
        emp.LoadImage(namePic, PROBA_PB, "PROBA")
        emp.LoadImage(namePic, IDForm_PB, "ID Form")
        emp.LoadImage(namePic, ALetter_PB, "Acknowledgment Letter")
        emp.LoadImage(namePic, ELetter_PB, "Endorsement Letter")


        If Not EmpProfile_Pic.Image Is Nothing Then
            labelImage.Visible = False
        End If

        Disable(False)
        Save_BTN.Text = "&Update"
    End Sub

    Private Sub ClearText()
        FirstName_TXT.Clear()
        FirstName_TXT.Region = Nothing
        MiddleName_TXT.Clear()
        LastName_TXT.Clear()
        LastName_TXT.Region = Nothing
        Extension_TXT.Clear()
        DateOfBirth_DTP.Value = Today
        DateHired_DTP.Value = Today
        PerA_StBlkLot_TXT.Clear()
        PreA_StBlkLot_TXT.Clear()
        BioNumber_TXT.Text = ""
        MobileNum_TXT.Clear()
        MobileNum_TXT.Region = Nothing
        EmailAddress_TXT.Clear()
        EmailAddress_TXT.Region = Nothing
        SSSID_TXT.Clear()
        PHealthID_TXT.Clear()
        TIN_TXT.Clear()
        Gender_CB.SelectedIndex = 0
        Gender_CB.Region = Nothing
        PreA_Province_TXT.Clear()
        PreA_CityMun_TXT.Clear()
        PreA_Barangay_TXT.Clear()
        PerA_Barangay_TXT.Clear()
        PerA_CityMun_TXT.Clear()
        PerA_Province_TXT.Clear()
        Status_CB.SelectedIndex = 0
        Status_CB.Region = Nothing
        Position_combo.SelectedIndex = -1
        Branch_combo.SelectedIndex = -1
        CivilStatus_CB.SelectedIndex = 0
        CivilStatus_CB.Region = Nothing
        Remarks_TXT.Clear()
        Remarks_TXT.Region = Nothing
        PIbigID_TXT.Clear()
        EmpProfile_Pic.Image = My.Resources.add_image_50px
        EmpProfile_Pic.SizeMode = PictureBoxSizeMode.CenterImage
        labelImage.Visible = True
        For Each xObject As Object In Requirements_GB.Controls
            If TypeOf xObject Is CheckBox Then
                Dim ChkBox As CheckBox = xObject
                ChkBox.Checked = False
            End If
        Next
        Dim PB As PictureBox = Nothing
        For Each obj As Object In FlowLayoutPanel1.Controls
            If TypeOf obj Is PictureBox Then
                PB = obj
                PB.Image = Nothing
            End If
        Next

        GreatestBiometric(BioNumber_TXT)
    End Sub

    Private Sub Disable(ByVal st As Boolean)
        FirstName_TXT.Enabled = st
        MiddleName_TXT.Enabled = st
        Extension_TXT.Enabled = st
        DateOfBirth_DTP.Enabled = st
        DateHired_DTP.Enabled = st
        Gender_CB.Enabled = st
    End Sub

    Private Sub Remarks_TXT_TextChanged(sender As Object, e As EventArgs) Handles Remarks_TXT.TextChanged
        Remarks_TXT.ScrollToCaret()
        If Remarks_TXT.Text = "" Then
            Remarks_TXT.Region = New Region(New Rectangle(2, 2, Remarks_TXT.Width - 4, Remarks_TXT.Height - 4))
        Else
            Remarks_TXT.Region = Nothing
        End If

    End Sub

    Private Sub PreA_Province_TXT_TextChanged(sender As Object, e As EventArgs) Handles PreA_Province_TXT.TextChanged
        LoadAddressCityMun()
    End Sub

    Private Sub PreA_CityMun_TXT_TextChanged(sender As Object, e As EventArgs) Handles PreA_CityMun_TXT.TextChanged
        LoadAddressBrg()
    End Sub

    Private Sub PerA_Province_TXT_TextChanged(sender As Object, e As EventArgs) Handles PerA_Province_TXT.TextChanged
        LoadAddressPerCityMun()
    End Sub

    Private Sub PerA_CityMun_TXT_TextChanged(sender As Object, e As EventArgs) Handles PerA_CityMun_TXT.TextChanged
        LoadAddressPerBrg()
    End Sub

    Private Sub SelectAll_CHK_CheckedChanged(sender As Object, e As EventArgs) Handles SelectAll_CHK.CheckedChanged
        If SelectAll_CHK.Checked = True Then

            For Each xObject As Object In Requirements_GB.Controls
                If TypeOf xObject Is CheckBox Then
                    Dim ChkBox As CheckBox = xObject
                    ChkBox.Checked = True
                End If
            Next
        Else
            ' to unchecked all
            For Each xObject As Object In Requirements_GB.Controls
                If TypeOf xObject Is CheckBox Then
                    Dim ChkBox As CheckBox = xObject
                    ChkBox.Checked = False
                End If
            Next
        End If
    End Sub

    Private Sub DateOfBirth_DTP_ValueChanged(sender As Object, e As EventArgs) Handles DateOfBirth_DTP.ValueChanged
        If GetCurrentAge(DateOfBirth_DTP.Value) <= 17 Then
            Age_TXT.Text = ""
        Else
            Age_TXT.Text = $"{GetCurrentAge(DateOfBirth_DTP.Value)} years old"
        End If

    End Sub

    Private Function isValidSave()

        Dim mysql As String = "SELECT * FROM tbl_employee Where Upper(FIRSTNAME) = Upper('" & FirstName_TXT.Text & "') and Upper(LASTNAME) = Upper('" & LastName_TXT.Text & "')"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_employee")
        If ds.Tables(0).Rows.Count > 0 Then
            MsgBox("Name Already Exist", MsgBoxStyle.Critical, "Error")
            Return False

        ElseIf String.IsNullOrEmpty(PreA_Province_TXT.Text) Or String.IsNullOrEmpty(PreA_CityMun_TXT.Text) Or String.IsNullOrEmpty(PreA_Barangay_TXT.Text) Then
            MsgBox("Invalid Address", MsgBoxStyle.Critical, "Error")
            Return False

        ElseIf String.IsNullOrEmpty(FirstName_TXT.Text) Then
            FirstName_TXT.Region = New Region(New Rectangle(2, 2, FirstName_TXT.Width - 4, FirstName_TXT.Height - 4))
            Return False

        ElseIf String.IsNullOrEmpty(LastName_TXT.Text) Then
            LastName_TXT.Region = New Region(New Rectangle(2, 2, LastName_TXT.Width - 4, LastName_TXT.Height - 4))
            Return False

        ElseIf String.IsNullOrEmpty(Age_TXT.Text) Then
            DateOfBirth_DTP.Region = New Region(New Rectangle(2, 2, DateOfBirth_DTP.Width - 4, DateOfBirth_DTP.Height - 4))
            Return False

        ElseIf String.IsNullOrEmpty(Gender_CB.Text) Then
            Gender_CB.Region = New Region(New Rectangle(2, 2, Gender_CB.Width - 4, Gender_CB.Height - 4))
            Return False

        ElseIf EmailAddress_TXT.Text = "" Then
            EmailAddress_TXT.Region = New Region(New Rectangle(2, 2, EmailAddress_TXT.Width - 4, EmailAddress_TXT.Height - 4))
            Return False

        ElseIf Not (EmailAddress_TXT.Text.Contains("@") And EmailAddress_TXT.Text.Contains(".")) Then
            EmailAddress_TXT.Region = New Region(New Rectangle(2, 2, EmailAddress_TXT.Width - 4, EmailAddress_TXT.Height - 4))
            Return False

            'ElseIf String.IsNullOrEmpty(MobileNum_TXT.Text) Then
            '    MobileNum_TXT.Region = New Region(New Rectangle(2, 2, MobileNum_TXT.Width - 4, MobileNum_TXT.Height - 4))
            '    Return False

        ElseIf String.IsNullOrEmpty(CivilStatus_CB.Text) Then
            CivilStatus_CB.Region = New Region(New Rectangle(2, 2, CivilStatus_CB.Width - 4, CivilStatus_CB.Height - 4))
            Return False

        ElseIf String.IsNullOrEmpty(Position_combo.Text) Then
            Position_combo.Region = New Region(New Rectangle(2, 2, Position_combo.Width - 4, Position_combo.Height - 4))
            Return False

        ElseIf String.IsNullOrEmpty(Branch_combo.Text) Then
            Branch_combo.Region = New Region(New Rectangle(2, 2, Branch_combo.Width - 4, Branch_combo.Height - 4))
            Return False

        ElseIf String.IsNullOrEmpty(Status_CB.Text) Then
            Status_CB.Region = New Region(New Rectangle(2, 2, Status_CB.Width - 4, Status_CB.Height - 4))
            Return False

        End If

        Return True
    End Function

    Private Function isValidUpdate()

        If String.IsNullOrEmpty(PreA_Province_TXT.Text) Or String.IsNullOrEmpty(PreA_CityMun_TXT.Text) Or String.IsNullOrEmpty(PreA_Barangay_TXT.Text) Then
            MsgBox("Invalid Address", MsgBoxStyle.Critical, "Error")
            Return False

        ElseIf String.IsNullOrEmpty(LastName_TXT.Text) Then
            LastName_TXT.Region = New Region(New Rectangle(2, 2, LastName_TXT.Width - 4, LastName_TXT.Height - 4))
            Return False

        ElseIf String.IsNullOrEmpty(Age_TXT.Text) Then
            DateOfBirth_DTP.Region = New Region(New Rectangle(2, 2, DateOfBirth_DTP.Width - 4, DateOfBirth_DTP.Height - 4))
            Return False

        ElseIf String.IsNullOrEmpty(Gender_CB.Text) Then
            Gender_CB.Region = New Region(New Rectangle(2, 2, Gender_CB.Width - 4, Gender_CB.Height - 4))
            Return False

        ElseIf EmailAddress_TXT.Text = "" Then
            EmailAddress_TXT.Region = New Region(New Rectangle(2, 2, EmailAddress_TXT.Width - 4, EmailAddress_TXT.Height - 4))
            Return False

        ElseIf Not (EmailAddress_TXT.Text.Contains("@") And EmailAddress_TXT.Text.Contains(".")) Then
            EmailAddress_TXT.Region = New Region(New Rectangle(2, 2, EmailAddress_TXT.Width - 4, EmailAddress_TXT.Height - 4))
            Return False

            'ElseIf String.IsNullOrEmpty(MobileNum_TXT.Text) Then
            '    MobileNum_TXT.Region = New Region(New Rectangle(2, 2, MobileNum_TXT.Width - 4, MobileNum_TXT.Height - 4))
            '    Return False

        ElseIf String.IsNullOrEmpty(CivilStatus_CB.Text) Then
            CivilStatus_CB.Region = New Region(New Rectangle(2, 2, CivilStatus_CB.Width - 4, CivilStatus_CB.Height - 4))
            Return False

        ElseIf String.IsNullOrEmpty(Position_combo.Text) Then
            Position_combo.Region = New Region(New Rectangle(2, 2, Position_combo.Width - 4, Position_combo.Height - 4))
            Return False

        ElseIf String.IsNullOrEmpty(Branch_combo.Text) Then
            Branch_combo.Region = New Region(New Rectangle(2, 2, Branch_combo.Width - 4, Branch_combo.Height - 4))
            Return False

        ElseIf String.IsNullOrEmpty(Status_CB.Text) Then
            Status_CB.Region = New Region(New Rectangle(2, 2, Status_CB.Width - 4, Status_CB.Height - 4))
            Return False

        End If

        Return True
    End Function

    Private Function ValidStatus()
        If String.IsNullOrEmpty(Status_CB.Text) Then
            Status_CB.Region = New Region(New Rectangle(2, 2, Status_CB.Width - 4, Status_CB.Height - 4))
            Return False
        End If

        Return True
    End Function

    Private Function isNotExist()

        Dim mysql As String = "SELECT * FROM tbl_employee Where LASTNAME = '" & LastName_TXT.Text & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tbl_employee")
        If ds.Tables(0).Rows.Count > 0 Then
            MsgBox("Name Already Exist", MsgBoxStyle.Critical, "Error")
            Return False
        End If

        Return True

    End Function

    Private Sub Clear_BTN_Click(sender As Object, e As EventArgs) Handles Clear_BTN.Click
        ClearText()
        Save_BTN.Text = "&Save"
    End Sub

    Friend Sub ToFOLDER(ByVal Name As String, ByVal Folder As String, ByVal ImageName As String, ByVal picture As PictureBox)

        Name = Name.ToString.TrimEnd()

        Dim folderName As DirectoryInfo = New DirectoryInfo("D:\HR Records\" & Folder)
        Dim employee As DirectoryInfo = New DirectoryInfo("D:\HR Records\" & Folder & "\" & Name)

        If folderName.Exists Then

            If employee.Exists Then

                picture.Image.Save("D:\HR Records\" & Folder & "\" & Name & "\" & ImageName & ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg)
                picture.Dispose()
            Else
                employee.Create()
                picture.Image.Save("D:\HR Records\" & Folder & "\" & Name & "\" & ImageName & ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg)
                picture.Dispose()
            End If

        Else
            folderName.Create()
            If employee.Exists Then
                picture.Image.Save("D:\HR Records\" & Folder & "\" & Name & "\" & ImageName & ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg)
                picture.Dispose()
            Else
                employee.Create()
                picture.Image.Save("D:\HR Records\" & Folder & "\" & Name & "\" & ImageName & ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg)
                picture.Dispose()
            End If

        End If
    End Sub

    Friend Sub IfImageNothing(ByVal picture As PictureBox, ByVal nameOfPicture As String)

        Dim name As String = LastName_TXT.Text & ", " & FirstName_TXT.Text & " " & MiddleName_TXT.Text
        name = name.ToString.TrimEnd()

        If Not picture.Image Is Nothing Then
            ToFOLDER(name, "201", nameOfPicture, picture)
        End If

    End Sub

    Friend Sub saveImage()
        IfImageNothing(EmpProfile_Pic, "Profile")
        IfImageNothing(SSSID_PB, "SSS")
        IfImageNothing(PhilHealth_PB, "PhilHealth")
        IfImageNothing(TIN_PB, "TIN")
        IfImageNothing(PagIbig_PB, "PagIbig")
        IfImageNothing(BClearance_PB, "Barangay Clearance")
        IfImageNothing(Cedula_PB, "Cedula")
        IfImageNothing(PClearance_PB, "Police Clearance")
        IfImageNothing(NBIClearance_PB, "NBI Clearance")
        IfImageNothing(HealthCard_PB, "Health Card")
        IfImageNothing(MayorsPermit_PB, "Mayors Permit")
        IfImageNothing(PDS_PB, "PDS")
        IfImageNothing(PROBA_PB, "PROBA")
        IfImageNothing(IDForm_PB, "ID Form")
        IfImageNothing(ALetter_PB, "Acknowledgment Letter")
        IfImageNothing(ELetter_PB, "Endorsement Letter")
    End Sub


    Private Sub Save_BTN_Click(sender As Object, e As EventArgs) Handles Save_BTN.Click
        Console.WriteLine("sss")
        Dim tmpStatus As String = String.Empty

        If Save_BTN.Text = "&Save" Then

            If Not isValidSave() Then Exit Sub

            tmpEmployee = New Employee

            With tmpEmployee
                .FirstName = FirstName_TXT.Text.ToUpper(CultureInfo.CurrentCulture)
                .MiddleName = MiddleName_TXT.Text.ToUpper(CultureInfo.CurrentCulture)
                .LastName = LastName_TXT.Text.ToUpper(CultureInfo.CurrentCulture)
                .Suffix = Extension_TXT.Text.ToUpper(CultureInfo.CurrentCulture)
                .DateofBirth = DateOfBirth_DTP.Value
                .PresentAddressID = tmpPresentAdd.ID
                .PresentStreet = PreA_StBlkLot_TXT.Text.ToUpper(CultureInfo.CurrentCulture)
                .PermanentAddressID = tmpPermanentAdd.ID
                .PermanentStreet = PerA_StBlkLot_TXT.Text.ToUpper(CultureInfo.CurrentCulture)
                .Sex = Gender_CB.Text
                .CivilStatus = CivilStatus_CB.SelectedItem.ToString
                .EmailAddress = EmailAddress_TXT.Text
                .DateHired = DateHired_DTP.Value
                .BiometricID = Convert.ToInt32(BioNumber_TXT.Text)
                .ContactNumber = MobileNum_TXT.Text
                .SSSNumber = SSSID_TXT.Text
                .PhilhealthNumber = PHealthID_TXT.Text
                .TINNumber = TIN_TXT.Text
                .Remarks = Remarks_TXT.Text
                .pagibignumber = PIbigID_TXT.Text
                .Status = Status_CB.Text
                .BIRate = IIf(Passed_RBTN.Checked = True, 1, 0)
                .BIRemarks = BI_Remarks

                .Position = Position_combo.SelectedItem
                .BranchID = Branch_combo.Tag

                .SaveEmployee()

                saveImage()
                '=============================== SAVE CHECK REQ LIST ================================================='

                Dim mySql As String = "SELECT MAX(ID) AS employid FROM TBL_employee"
                Using ds As DataSet = LoadSQL(mySql)
                    Dim idx As Integer = CDbl(ds.Tables(0).Rows(0).Item("employid"))
                    .employid = idx
                End Using


                .PDS = IIf(PDS_CHK.Checked = True, 1, 0)
                .proba = IIf(PROBA_CHK.Checked = True, 1, 0)
                .moa = IIf(MOA_CHK.Checked = True, 1, 0)
                .idform = IIf(IDForm_CHK.Checked = True, 1, 0)
                .acknow = IIf(ALetter_CHK.Checked = True, 1, 0)
                .barangay_C = IIf(BrgClearance_CHK.Checked = True, 1, 0)
                .cedula = IIf(Cedula_CHK.Checked = True, 1, 0)
                .NBI_C = IIf(NBIClearance_CHK.Checked = True, 1, 0)
                .police_c = IIf(PClearance_CHK.Checked = True, 1, 0)
                .health_C = IIf(HealthCard_CHK.Checked = True, 1, 0)
                .mayor_P = IIf(MPermit_CHK.Checked = True, 1, 0)
                .sss = IIf(SSSID_TXT.Text.Length <> 0, 1, 0)
                .phihhealth = 1 = IIf(PHealthID_TXT.Text.Length <> 0, 1, 0)
                .pagIBIG = 1 = IIf(PIbigID_TXT.Text.Length <> 0, 1, 0)
                .TIN = 1 = IIf(TIN_TXT.Text.Length <> 0, 1, 0)
                .endorsement = IIf(ELetter_CHK.Checked = True, 1, 0)


                '=============================== SAVE CHECK REQ LIST ================================================='

                Dim ChkBox As CheckBox = Nothing
                ' to unchecked all
                For Each xObject As Object In GroupBox1.Controls
                    If TypeOf xObject Is CheckBox Then
                        ChkBox = xObject
                        ChkBox.Checked = False
                    End If
                Next

                Dim PB As PictureBox = Nothing
                For Each obj As Object In FlowLayoutPanel1.Controls
                    If TypeOf obj Is PictureBox Then
                        PB = obj
                        PB.Image = Nothing
                    End If
                Next

                .SAVE_REQUIREMENTS()
                '.SaveReqArchive() '------------------jen
            End With

            MsgBox("New Record Added", MsgBoxStyle.Information, "Information")
            ClearText()

        Else

            'If Not ValidStatus() Then Exit Sub

            If Not isValidUpdate() Then Exit Sub

            tmpEmployee = New Employee

            With tmpEmployee
                .ID = FirstName_TXT.Tag
                .LastName = LastName_TXT.Text
                .MiddleName = MiddleName_TXT.Text
                .CivilStatus = CivilStatus_CB.SelectedItem.ToString
                .PresentAddressID = tmpPresentAdd.ID
                .PresentStreet = PreA_StBlkLot_TXT.Text.ToUpper(CultureInfo.CurrentCulture)
                .PermanentAddressID = tmpPermanentAdd.ID
                .PermanentStreet = PerA_StBlkLot_TXT.Text.ToUpper(CultureInfo.CurrentCulture)
                .EmailAddress = EmailAddress_TXT.Text
                .ContactNumber = MobileNum_TXT.Text
                .SSSNumber = SSSID_TXT.Text
                .PhilhealthNumber = PHealthID_TXT.Text
                .TINNumber = TIN_TXT.Text
                .Remarks = Remarks_TXT.Text
                .Status = Status_CB.Text
                .Position = Position_combo.SelectedItem
                .BranchID = Branch_combo.Tag
                .pagibignumber = PIbigID_TXT.Text
                .BIRate = IIf(Passed_RBTN.Checked = True, 1, 0)
                .BIRemarks = BI_Remarks
                .UpdateEmployee()

                If Status_CB.SelectedIndex = 5 Or Status_CB.SelectedIndex = 7 Then
                    .LastDate = Last_date.Text
                    .SaveTOLASTDATE()
                End If


                'If Reason_Groupbox.Visible = True Then
                '    .LastDate = Last_date.Value
                '    .UpdateEmpLASTDATE()
                'End If

                'Dim a As Integer = FirstName_TXT.Tag
                '.UpdateProfilePic(a, imgData)              '-------------------jen

                '=============================== UPDATE CHECK REQ LIST ================================================='

                .PDS = IIf(PDS_CHK.Checked = True, 1, 0)
                .proba = IIf(PROBA_CHK.Checked = True, 1, 0)
                .moa = IIf(MOA_CHK.Checked = True, 1, 0)
                .idform = IIf(IDForm_CHK.Checked = True, 1, 0)
                .acknow = IIf(ALetter_CHK.Checked = True, 1, 0)
                .barangay_C = IIf(BrgClearance_CHK.Checked = True, 1, 0)
                .cedula = IIf(Cedula_CHK.Checked = True, 1, 0)
                .NBI_C = IIf(NBIClearance_CHK.Checked = True, 1, 0)
                .police_c = IIf(PClearance_CHK.Checked = True, 1, 0)
                .health_C = IIf(HealthCard_CHK.Checked = True, 1, 0)
                .mayor_P = IIf(MPermit_CHK.Checked = True, 1, 0)
                .sss = IIf(SSSID_TXT.Text.Length <> 0, 1, 0)
                .phihhealth = IIf(PHealthID_TXT.Text.Length <> 0, 1, 0)
                .pagIBIG = IIf(PIbigID_TXT.Text.Length <> 0, 1, 0)
                .TIN = IIf(TIN_TXT.Text.Length <> 0, 1, 0)
                .endorsement = IIf(ELetter_CHK.Checked = True, 1, 0)

                .UPDATE_REQ()

                saveImage()

                .IDhistory = FirstName_TXT.Tag
                .Namehistory = Extension_TXT.Tag
                .CShistory = CivilStatus_CB.Tag
                .Statushistory = Status_CB.Tag
                .SaveEmpHistory()

                Dim ChkBox As CheckBox = Nothing
                For Each xObject As Object In Requirements_GB.Controls
                    If TypeOf xObject Is CheckBox Then
                        ChkBox = xObject
                        ChkBox.Checked = False
                    End If
                Next
                'clear all picture boxes

                EmpProfile_Pic.Image = Nothing

                Dim PB As PictureBox = Nothing
                For Each obj As Object In FlowLayoutPanel1.Controls
                    If TypeOf obj Is PictureBox Then
                        PB = obj
                        PB.Image = Nothing
                    End If
                Next
                '===============================CHECK REQ LIST ================================================='
            End With
            ClearText()
            Save_BTN.Text = "&Save"
            MsgBox("Record Successfully Updated", MsgBoxStyle.Information, "Information")
            Close()
        End If
    End Sub

    Private Function ImgToByteArray(img As Image, imgFormat As ImageFormat) As Byte()
        Dim tmpData As Byte()
        If img IsNot Nothing Then
            Dim BufferImage As Bitmap = New Bitmap(img)
            Dim ms As MemoryStream = New MemoryStream
            BufferImage.Save(ms, imgFormat)
            BufferImage.Dispose()
            tmpData = ms.ToArray
            ms.Dispose()
        End If
        Return tmpData
    End Function

    Private Sub SSSID_BTN_Click(sender As Object, e As EventArgs) Handles SSSID_BTN.Click
        Using archv As New Archive
            archv.Text = "SSS ID Number"
            archv.Tag = archv.Text
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub PHealthID_BTN_Click(sender As Object, e As EventArgs) Handles PHealthID_BTN.Click
        Using archv As New Archive
            archv.Text = "PhilHealth ID Number"
            archv.Tag = archv.Text
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub PIbigID_BTN_Click(sender As Object, e As EventArgs) Handles PIbigID_BTN.Click
        Using archv As New Archive
            archv.Text = "Pag-Ibig ID Number"
            archv.Tag = archv.Text
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub TIN_BTN_Click(sender As Object, e As EventArgs) Handles TIN_BTN.Click
        Using archv As New Archive
            archv.Text = "Tax Identification Number"
            archv.Tag = archv.Text
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub BrgClearance_BTN_Click(sender As Object, e As EventArgs) Handles BrgClearance_BTN.Click
        Using archv As New Archive
            archv.Text = BrgClearance_BTN.Text
            archv.Tag = archv.Text
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub Cedula_BTN_Click(sender As Object, e As EventArgs) Handles Cedula_BTN.Click
        Using archv As New Archive
            archv.Text = Cedula_BTN.Text
            archv.Tag = archv.Text
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub PClearance_BTN_Click(sender As Object, e As EventArgs) Handles PClearance_BTN.Click
        Using archv As New Archive
            archv.Text = PClearance_BTN.Text
            archv.Tag = archv.Text
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub NBIClearance_BTN_Click(sender As Object, e As EventArgs) Handles NBIClearance_BTN.Click
        Using archv As New Archive
            archv.Text = NBIClearance_BTN.Text
            archv.Tag = archv.Text
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub HealthCard_BTN_Click(sender As Object, e As EventArgs) Handles HealthCard_BTN.Click
        Using archv As New Archive
            archv.Text = HealthCard_BTN.Text
            archv.Tag = archv.Text
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub MPermit_BTN_Click(sender As Object, e As EventArgs) Handles MPermit_BTN.Click
        Using archv As New Archive
            archv.Text = MPermit_BTN.Text
            archv.Tag = archv.Text
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub PDS_BTN_Click(sender As Object, e As EventArgs) Handles PDS_BTN.Click
        Using archv As New Archive
            archv.Text = PDS_BTN.Text
            archv.Tag = archv.Text
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub PROBA_BTN_Click(sender As Object, e As EventArgs) Handles PROBA_BTN.Click
        Using archv As New Archive
            archv.Text = PROBA_BTN.Text
            archv.Tag = archv.Text
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub MOA_BTN_Click(sender As Object, e As EventArgs) Handles MOA_BTN.Click
        Using archv As New Archive
            archv.Text = MOA_BTN.Text
            archv.Tag = archv.Text
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub IDForm_BTN_Click(sender As Object, e As EventArgs) Handles IDForm_BTN.Click
        Using archv As New Archive
            archv.Text = IDForm_BTN.Text
            archv.Tag = archv.Text
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub ViewImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewImageToolStripMenuItem.Click
        Using archv As New Archive
            archv.Text = ViewImageToolStripMenuItem.Text
            archv.Tag = archv.Text
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub ALetter_BTN_Click(sender As Object, e As EventArgs) Handles ALetter_BTN.Click
        Using archv As New Archive
            archv.Text = ALetter_BTN.Text
            archv.Tag = archv.Text
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub ELetter_BTN_Click(sender As Object, e As EventArgs) Handles ELetter_BTN.Click
        Using archv As New Archive
            archv.Text = ELetter_BTN.Text
            archv.Tag = archv.Text
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub ChangeStatus_CHK_CheckedChanged(sender As Object, e As EventArgs) Handles ChangeStatus_CHK.CheckedChanged
        If ChangeStatus_CHK.Checked = True Then
            MiddleName_TXT.ReadOnly = False
            MiddleName_TXT.Enabled = True
            CivilStatus_CB.Enabled = True
        ElseIf ChangeStatus_CHK.Checked = False Then
            MiddleName_TXT.ReadOnly = True
            MiddleName_TXT.Enabled = False
            CivilStatus_CB.Enabled = False
        End If
    End Sub

    Private Sub Passed_RBTN_CheckedChanged(sender As Object, e As EventArgs) Handles Passed_RBTN.CheckedChanged
        If Passed_RBTN.Checked = False Then
            Failed_RBTN.Checked = True
        Else
            Failed_RBTN.Checked = False
        End If
    End Sub

    Private Sub Passed_RBTN_Click(sender As Object, e As EventArgs) Handles Passed_RBTN.Click
        BI_Remarks = InputBox("Enter Remarks", "B.I. Remarks", "Enter Your Remarks Here")
    End Sub

    Private Sub Failed_RBTN_Click(sender As Object, e As EventArgs) Handles Failed_RBTN.Click
        BI_Remarks = InputBox("Enter Remarks", "B.I. Remarks", "Enter Your Remarks Here")
    End Sub

    Private Sub PreA_Barangay_TXT_TextChanged(sender As Object, e As EventArgs) Handles PreA_Barangay_TXT.TextChanged
        Dim sql As String = $"Select ID From tbl_Address Where Barangay = '{PreA_Barangay_TXT.Text}' AND CITYMUN = '{PreA_CityMun_TXT.Text}' and PROVINCE = '{PreA_Province_TXT.Text}'"
        DbReaderOpen()
        Using rd As FbDataReader = LoadSQL_byDataReader(sql)

            While rd.Read()
                If rd.HasRows Then
                    With rd
                        tmpPresentAdd.ID = .Item(0).ToString
                        Console.WriteLine("present" & .Item(0).ToString)
                    End With
                End If
            End While
            rd.Close()
        End Using
    End Sub

    Private Sub PerA_Barangay_TXT_TextChanged(sender As Object, e As EventArgs) Handles PerA_Barangay_TXT.TextChanged
        Dim sql As String = $"Select ID From tbl_Address Where Barangay = '{PerA_Barangay_TXT.Text}' AND CITYMUN = '{PerA_CityMun_TXT.Text}' and PROVINCE = '{PerA_Province_TXT.Text}'"
        DbReaderOpen()
        Using rd As FbDataReader = LoadSQL_byDataReader(sql)

            While rd.Read()
                If rd.HasRows Then
                    With rd
                        tmpPermanentAdd.ID = .Item(0).ToString
                        Console.WriteLine("permanent" & .Item(0).ToString)
                    End With
                End If
            End While
            rd.Close()
        End Using
    End Sub

    Private Sub PerA_StBlkLot_TXT_DoubleClick(sender As Object, e As EventArgs) Handles PerA_StBlkLot_TXT.DoubleClick
        PerA_Province_TXT.Text = PreA_Province_TXT.Text
        PerA_CityMun_TXT.Text = PreA_CityMun_TXT.Text
        PerA_Barangay_TXT.Text = PreA_Barangay_TXT.Text
        PerA_StBlkLot_TXT.Text = PreA_StBlkLot_TXT.Text
    End Sub

    Private Sub SSSID_PB_DoubleClick(sender As Object, e As EventArgs) Handles SSSID_PB.DoubleClick
        Using archv As New Archive
            archv.Text = "SSS ID Number"
            archv.Tag = archv.Text
            archv.ImageToSave.Image = SSSID_PB.Image
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub PhilHealth_PB_Click(sender As Object, e As EventArgs) Handles PhilHealth_PB.Click
        Using archv As New Archive
            archv.Text = "PhilHealth ID Number"
            archv.Tag = archv.Text
            archv.ImageToSave.Image = PhilHealth_PB.Image
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub PagIbig_PB_Click(sender As Object, e As EventArgs) Handles PagIbig_PB.Click
        Using archv As New Archive
            archv.Text = "Pag-Ibig ID Number"
            archv.Tag = archv.Text
            archv.ImageToSave.Image = PagIbig_PB.Image
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub TIN_PB_Click(sender As Object, e As EventArgs) Handles TIN_PB.Click
        Using archv As New Archive
            archv.Text = "Tax Identification Number"
            archv.Tag = archv.Text
            archv.ImageToSave.Image = TIN_PB.Image
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub BClearance_PB_Click(sender As Object, e As EventArgs) Handles BClearance_PB.Click
        Using archv As New Archive
            archv.Text = BrgClearance_BTN.Text
            archv.Tag = archv.Text
            archv.ImageToSave.Image = BClearance_PB.Image
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub Cedula_PB_Click(sender As Object, e As EventArgs) Handles Cedula_PB.Click
        Using archv As New Archive
            archv.Text = Cedula_BTN.Text
            archv.Tag = archv.Text
            archv.ImageToSave.Image = Cedula_PB.Image
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub PClearance_PB_Click(sender As Object, e As EventArgs) Handles PClearance_PB.Click
        Using archv As New Archive
            archv.Text = PClearance_BTN.Text
            archv.Tag = archv.Text
            archv.ImageToSave.Image = PClearance_PB.Image
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub NBIClearance_PB_Click(sender As Object, e As EventArgs) Handles NBIClearance_PB.Click
        Using archv As New Archive
            archv.Text = NBIClearance_BTN.Text
            archv.Tag = archv.Text
            archv.ImageToSave.Image = NBIClearance_PB.Image
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub HealthCard_PB_Click(sender As Object, e As EventArgs) Handles HealthCard_PB.Click
        Using archv As New Archive
            archv.Text = HealthCard_BTN.Text
            archv.Tag = archv.Text
            archv.ImageToSave.Image = HealthCard_PB.Image
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub MayorsPermit_PB_Click(sender As Object, e As EventArgs) Handles MayorsPermit_PB.Click
        Using archv As New Archive
            archv.Text = MPermit_BTN.Text
            archv.Tag = archv.Text
            archv.ImageToSave.Image = MayorsPermit_PB.Image
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub PDS_PB_Click(sender As Object, e As EventArgs) Handles PDS_PB.Click
        Using archv As New Archive
            archv.Text = PDS_BTN.Text
            archv.Tag = archv.Text
            archv.ImageToSave.Image = PDS_PB.Image
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub PROBA_PB_Click(sender As Object, e As EventArgs) Handles PROBA_PB.Click
        Using archv As New Archive
            archv.Text = PROBA_BTN.Text
            archv.Tag = archv.Text
            archv.ImageToSave.Image = PROBA_PB.Image
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub MOA_PB_Click(sender As Object, e As EventArgs) Handles MOA_PB.Click
        Using archv As New Archive
            archv.Text = MOA_BTN.Text
            archv.Tag = archv.Text
            archv.ImageToSave.Image = MOA_PB.Image
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub IDForm_PB_Click(sender As Object, e As EventArgs) Handles IDForm_PB.Click
        Using archv As New Archive
            archv.Text = IDForm_BTN.Text
            archv.Tag = archv.Text
            archv.ImageToSave.Image = IDForm_PB.Image
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub ALetter_PB_Click(sender As Object, e As EventArgs) Handles ALetter_PB.Click
        Using archv As New Archive
            archv.Text = ALetter_BTN.Text
            archv.Tag = archv.Text
            archv.ImageToSave.Image = ALetter_PB.Image
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub ELetter_PB_Click(sender As Object, e As EventArgs) Handles ELetter_PB.Click
        Using archv As New Archive
            archv.Text = ELetter_BTN.Text
            archv.Tag = archv.Text
            archv.ImageToSave.Image = ELetter_PB.Image
            archv.ShowDialog()
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(BI_Remarks, "B.I. Remarks", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub MobileNum_TXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MobileNum_TXT.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
                MobileNum_TXT.Region = Nothing
            Else
                e.Handled = True
                MobileNum_TXT.Region = New Region(New Rectangle(2, 2, MobileNum_TXT.Width - 4, MobileNum_TXT.Height - 4))
            End If
        End If
    End Sub

    Private Sub Label12_DoubleClick(sender As Object, e As EventArgs) Handles labelImage.DoubleClick
        Using openF As New OpenFileDialog()
            Dim codecs As ImageCodecInfo() = ImageCodecInfo.GetImageEncoders()
            Dim sep As String = String.Empty
            With openF
                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                .Title = "Save As Image"
                .DefaultExt = ".JPG"
                .Filter = ""
                .FilterIndex = 2
                .RestoreDirectory = True
                .FileName = "*.JPG"
            End With
            For Each c As ImageCodecInfo In codecs
                Dim codecName As String = c.CodecName.Substring(8).Replace("Codec", "Files").Trim()
                openF.Filter = $"{openF.Filter }{sep }{codecName } ({c.FilenameExtension })|{c.FilenameExtension }"
                sep = "|"
            Next
            If openF.ShowDialog = DialogResult.OK Then
                If Not Image.FromFile(openF.FileName).Size = EmpProfile_Pic.InitialImage.Size Then
                    EmpProfile_Pic.Image = Image.FromFile(openF.FileName)
                    EmpProfile_Pic.Tag = openF.FileName
                    EmpProfile_Pic.SizeMode = PictureBoxSizeMode.StretchImage
                    labelImage.Visible = False
                Else
                    EmpProfile_Pic.Image = Image.FromFile(openF.FileName)
                    EmpProfile_Pic.Tag = openF.FileName
                    EmpProfile_Pic.SizeMode = PictureBoxSizeMode.CenterImage
                    labelImage.Visible = False
                End If

            End If
        End Using
    End Sub

    '--------------------------------------------REASON RESIGN OR TERMINATE----------------------------------- 
    Private Sub Last_date_ValueChanged(sender As Object, e As EventArgs) Handles Last_date.ValueChanged
        Remarks_TXT.Region = New Region(New Rectangle(2, 2, Remarks_TXT.Width - 4, Remarks_TXT.Height - 4))
        Last_date.Region = Nothing
    End Sub

    Private Sub GroupBox11_Paint(sender As Object, e As PaintEventArgs) Handles GroupBox11.Paint
        Dim p As New Pen(Color.Red, 2)
        e.Graphics.DrawRectangle(p, New Rectangle(Remarks_TXT.Location + New Size(1, 1), Remarks_TXT.Size - New Size(2, 2)))
        p.Dispose()
    End Sub

    Private Sub Reason_Groupbox_Paint(sender As Object, e As PaintEventArgs) Handles Reason_Groupbox.Paint
        Dim p As New Pen(Color.Red, 2)
        e.Graphics.DrawRectangle(p, New Rectangle(Last_date.Location + New Size(1, 1), Last_date.Size - New Size(2, 2)))
        p.Dispose()
    End Sub

    '--------------------------------------------ID NUMBER-----------------------------------

    Private Sub Group_ID_Paint(sender As Object, e As PaintEventArgs)
        RedAlertText(FirstName_TXT, e)
    End Sub

    '--------------------------------------------DATE - AGE-----------------------------------
    Private Sub GroupBox5_Paint(sender As Object, e As PaintEventArgs) Handles GroupBox5.Paint
        Dim p As New Pen(Color.Red, 2)
        e.Graphics.DrawRectangle(p, New Rectangle(DateOfBirth_DTP.Location + New Size(1, 1), DateOfBirth_DTP.Size - New Size(2, 2)))
        p.Dispose()
    End Sub

    Private Sub Age_TXT_TextChanged(sender As Object, e As EventArgs) Handles Age_TXT.TextChanged
        'RedAlertText(Age_TXT, e)
        DateOfBirth_DTP.Region = Nothing
    End Sub

    '--------------------------------------------FIRSTNAME-----------------------------------
    Private Sub Group_firstName_Paint(sender As Object, e As PaintEventArgs) Handles Group_firstName.Paint
        RedAlertText(FirstName_TXT, e)
    End Sub

    Private Sub FirstName_TXT_TextChanged(sender As Object, e As EventArgs) Handles FirstName_TXT.TextChanged
        CheckIFEmpty(FirstName_TXT)
    End Sub

    '--------------------------------------------LASTNAME-----------------------------------
    Private Sub Group_Lastname_Paint(sender As Object, e As PaintEventArgs) Handles Group_Lastname.Paint
        RedAlertText(LastName_TXT, e)
    End Sub

    Private Sub LastName_TXT_TextChanged(sender As Object, e As EventArgs) Handles LastName_TXT.TextChanged
        CheckIFEmpty(LastName_TXT)
    End Sub

    '--------------------------------------------MOBILENUMBER-----------------------------------  
    Private Sub Group_Mobile_Paint(sender As Object, e As PaintEventArgs) Handles Group_Mobile.Paint
        RedAlertText(MobileNum_TXT, e)
    End Sub

    Private Sub MobileNum_TXT_TextChanged(sender As Object, e As EventArgs) Handles MobileNum_TXT.TextChanged
        If MobileNum_TXT.Text = "" Then
            MobileNum_TXT.Region = Nothing
        Else
            If Not MobileNum_TXT.TextLength >= 11 Then
                MobileNum_TXT.Region = New Region(New Rectangle(2, 2, MobileNum_TXT.Width - 4, MobileNum_TXT.Height - 4))
            Else
                MobileNum_TXT.Region = Nothing
            End If
        End If
    End Sub

    '--------------------------------------------EMAIL ADDRESS-----------------------------------
    Private Sub Group_email_Paint(sender As Object, e As PaintEventArgs) Handles Group_email.Paint
        RedAlertText(EmailAddress_TXT, e)
    End Sub

    Private Sub EmailAddress_TXT_TextChanged(sender As Object, e As EventArgs) Handles EmailAddress_TXT.TextChanged
        'If EmailAddress_TXT.Text = "" Then
        '    EmailAddress_TXT.Region = New Region(New Rectangle(2, 2, EmailAddress_TXT.Width - 4, EmailAddress_TXT.Height - 4))

        'ElseIf Not (EmailAddress_TXT.Text.Contains("@") And EmailAddress_TXT.Text.Contains(".")) Then
        '    EmailAddress_TXT.Region = New Region(New Rectangle(2, 2, EmailAddress_TXT.Width - 4, EmailAddress_TXT.Height - 4))
        'Else
        '    EmailAddress_TXT.Region = Nothing
        'End If

        If EmailAddress_TXT.Text = "" Then
            EmailAddress_TXT.Region = Nothing
        ElseIf Not (EmailAddress_TXT.Text.Contains("@") And EmailAddress_TXT.Text.Contains(".")) Then
            EmailAddress_TXT.Region = New Region(New Rectangle(2, 2, EmailAddress_TXT.Width - 4, EmailAddress_TXT.Height - 4))
        Else
            EmailAddress_TXT.Region = Nothing
        End If
    End Sub

    '--------------------------------------------GENDER-----------------------------------
    Private Sub Group_gender_Paint(sender As Object, e As PaintEventArgs) Handles Group_gender.Paint
        RedAlertCombo(Gender_CB, e)
    End Sub

    Private Sub Gender_CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Gender_CB.SelectedIndexChanged
        CheckCombo(Gender_CB)
    End Sub

    '--------------------------------------------CIVIL STATUS-----------------------------------
    Private Sub GroupBox14_Paint(sender As Object, e As PaintEventArgs) Handles GroupBox14.Paint
        RedAlertCombo(CivilStatus_CB, e)
    End Sub

    Private Sub CivilStatus_CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CivilStatus_CB.SelectedIndexChanged
        CheckCombo(CivilStatus_CB)
    End Sub

    '--------------------------------------------STATUS----------------------------------- 
    Private Sub GroupBox13_Paint(sender As Object, e As PaintEventArgs) Handles GroupBox13.Paint
        RedAlertCombo(Status_CB, e)
    End Sub

    Private Sub Status_CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Status_CB.SelectedIndexChanged
        CheckCombo(Status_CB)

        If Status_CB.SelectedIndex = 5 Or Status_CB.SelectedIndex = 7 Then
            GroupBox12.Visible = True
            Last_date.Region = New Region(New Rectangle(2, 2, Last_date.Width - 4, Last_date.Height - 4))
        Else
            GroupBox12.Visible = False
            Last_date.Region = Nothing
        End If
    End Sub

    '--------------------------------------------BRANCH-----------------------------------

    Private Sub Branch_combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Branch_combo.SelectedIndexChanged
        Dim mysql As String = "Select * FROM tbl_Branch where BRANCHNAME = '" & Branch_combo.Text & "'"
        Using ds As DataSet = LoadSQL(mysql)
            If ds.Tables(0).Rows.Count > 0 Then
                Dim dr As DataRow = ds.Tables(0).Rows(0)
                With dr
                    Branch_combo.Tag = .Item("ID")
                End With
            End If
        End Using
        Branch_combo.Region = Nothing
    End Sub

    Private Sub GroupBox16_Paint(sender As Object, e As PaintEventArgs) Handles GroupBox16.Paint
        RedAlertCombo(Branch_combo, e)
    End Sub

    '--------------------------------------------POSITION-----------------------------------

    Private Sub Position_combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Position_combo.SelectedIndexChanged
        Position_combo.Region = Nothing
    End Sub

    Private Sub GroupBox15_Paint(sender As Object, e As PaintEventArgs) Handles GroupBox15.Paint
        RedAlertCombo(Position_combo, e)
    End Sub

    '--------------------------------------------METHODS-----------------------------------
    Public Sub RedAlertText(textboxME As TextBox, e As PaintEventArgs)
        Dim p As New Pen(Color.Red, 2)
        e.Graphics.DrawRectangle(p, New Rectangle(textboxME.Location + New Size(1, 1), textboxME.Size - New Size(2, 2)))
        p.Dispose()
    End Sub

    Public Sub CheckIFEmpty(textboxME As TextBox)
        If textboxME.Text = "" Then
            textboxME.Region = New Region(New Rectangle(2, 2, textboxME.Width - 4, textboxME.Height - 4))
        Else
            textboxME.Region = Nothing
        End If
    End Sub

    Public Sub RedAlertCombo(combo As ComboBox, e As PaintEventArgs)
        Dim p As New Pen(Color.Red, 2)
        e.Graphics.DrawRectangle(p, New Rectangle(combo.Location + New Size(1, 1), combo.Size - New Size(2, 2)))
        p.Dispose()
    End Sub

    Public Sub CheckCombo(combo As ComboBox)
        If combo.Text = "" Then
            combo.Region = New Region(New Rectangle(2, 2, combo.Width - 4, combo.Height - 4))
        Else
            combo.Region = Nothing
        End If
    End Sub

End Class