Imports System.Drawing.Imaging
Imports System.IO

Public Class Employee

#Region "Salary and Allowance"

    Public Property Monthly() As String

    Public Property Daily() As String

    Public Property Boarding() As String

    Public Property Carekit() As String

    Public Property Transportation() As String

    Public Property Medical() As String

    Public Property Positional() As String

    Public Property OtherAllowance() As String

    Public Property IDExist() As String

    Public Property Fix() As String

#End Region

#Region "Deduction"

    Public Property CashAdvance() As String

    Public Property Savings() As String

    Public Property Loans() As String

    Public Property Charges() As String

    Public Property Meal() As String

    Public Property OtherDeduction() As String

#End Region

#Region "Properties"

    Public Property IRNo() As Integer

    Public Property ID() As Integer

    Public Property FirstName() As String

    Public Property pagibignumber() As String

    Public Property MiddleName() As String

    Public Property LastName() As String

    Public Property Suffix() As String

    Public Property DateofBirth() As Date

    Public Property Sex() As String

    Public Property PresentAddressID() As Integer

    Public Property PermanentAddressID() As Integer

    Public Property PresendAddress() As Address

    Public Property PermanentAddress() As Address

    Public Property PresentStreet() As String

    Public Property PermanentStreet() As String

    Public Property EmailAddress() As String

    Public Property DateHired() As Date

    Public Property BiometricID() As Integer

    Public Property ContactNumber() As String

    Public Property SSSNumber() As String

    Public Property PhilhealthNumber() As String

    Public Property TINNumber() As String

    Public Property Status() As String

    Public Property Position() As String

    Public Property Branch() As String

    Public Property BranchID() As String

    Public Property Remarks() As String

    Public Property PDS() As Integer

    Public Property proba() As Integer

    Public Property moa() As Integer

    Public Property endorsement() As Integer

    Public Property acknow() As Integer

    Public Property idform() As Integer

    Public Property barangay_C() As Integer

    Public Property assignstatus() As String

    Public Property cedula() As Integer

    Public Property police_c() As Integer

    Public Property NBI_C() As Integer

    Public Property health_C() As Integer

    Public Property mayor_P() As Integer

    Public Property manp() As Integer

    Public Property sss() As Integer

    Public Property phihhealth() As Integer

    Public Property pagIBIG() As Integer

    Public Property TIN() As Integer

    Public Property employid() As Integer

    Public Property Appointed_Status() As String

    Public Property CivilStatus() As String

    Public Property BIRate() As Integer

    Public Property BIRemarks() As String

    Public Property LastDate() As Date

    Public Property Reason() As String

    Public Property pictureBox() As PictureBox

#End Region

#Region "ReqArchive"

    Public Property ReqID() As Integer
    Public Property SSS1 As Byte()
    Public Property PhilHealth1 As Byte()
    Public Property PagIbig1 As Byte()
    Public Property TIN1 As Byte()
    Public Property BarangayClearance1 As Byte()
    Public Property Cedula1 As Byte()
    Public Property PoliceClearance1 As Byte()
    Public Property NBICLEARANCE1 As Byte()
    Public Property HEALTHCARD1 As Byte()
    Public Property MAYORSPERMIT1 As Byte()
    Public Property PDS1 As Byte()
    Public Property PROBA1 As Byte()
    Public Property MOA1 As Byte()
    Public Property IDFORM1 As Byte()
    Public Property ACKNOWLEDGEMENTLETTER1 As Byte()
    Public Property ENDORSEMENTLETTER1 As Byte()

#End Region

#Region "EMP_History"

    Public Property IDhistory() As Integer
    Public Property Namehistory() As String
    Public Property CShistory() As String
    Public Property SChistory() As Integer
    Public Property Statushistory() As String
    Public Property DateUpdated() As Date

#End Region

#Region "Procedures"

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

    Friend Sub LoadImage(EpmName As String, pb As PictureBox, PictureName As String)

        Dim folder As String = "D:\HR Records\201\" & EpmName
        Dim filename As String = System.IO.Path.Combine(folder, PictureName & ".jpeg")

        Dim fileFolderDir As DirectoryInfo = New DirectoryInfo(folder)
        Dim filNameDir As DirectoryInfo = New DirectoryInfo(filename)

        If fileFolderDir.Exists Then

            If System.IO.File.Exists(filename) Then

                Try
                    Using fs As New System.IO.FileStream(filename, IO.FileMode.Open)
                        pb.Image = New Bitmap(Image.FromStream(fs))
                        pb.SizeMode = PictureBoxSizeMode.StretchImage
                        pb.Visible = True
                    End Using
                Catch ex As Exception
                    Dim msg As String = "Filename: " & filename &
                    Environment.NewLine & Environment.NewLine &
                    "Exception: " & ex.ToString
                    MessageBox.Show(msg, "Error Opening Image File")
                End Try
            Else
                Exit Sub
            End If

        Else
            Exit Sub
        End If
    End Sub

    Friend Sub SaveEmployee()
        Dim mysql As String = "Select * From tbl_Employee Rows 1"
        Using ds As DataSet = LoadSQL(mysql, "tbl_Employee")

            Dim dsNewRow As DataRow
            dsNewRow = ds.Tables(0).NewRow
            With dsNewRow
                .Item("FIRSTNAME") = FirstName
                .Item("MIDDLENAME") = MiddleName
                .Item("LASTNAME") = LastName
                .Item("SUFFIX") = Suffix
                .Item("DateOfBirth") = DateofBirth
                .Item("Gender") = Sex
                .Item("CIVILSTATUS") = CivilStatus
                .Item("PERMANENT_ADDID") = PermanentAddressID
                .Item("Permanent_Street") = PermanentStreet
                .Item("PRESENT_ADDID") = PresentAddressID
                .Item("Present_Street") = PresentStreet
                .Item("EmailAdd") = EmailAddress
                .Item("DateHired") = DateHired
                .Item("BiometricID") = BiometricID
                .Item("ContactNo") = ContactNumber
                .Item("SSSNo") = SSSNumber
                .Item("PHILHEALTHNO") = PhilhealthNumber
                .Item("TinNo") = TINNumber
                .Item("Status") = Status
                .Item("Remarks") = Remarks
                .Item("Pagibig") = pagibignumber
                .Item("BIRATE") = BIRate
                .Item("EMP_POSITION") = Position
                .Item("BRANCH_ID") = BranchID
                .Item("BI_REMARKS") = BIRemarks
            End With
            ds.Tables(0).Rows.Add(dsNewRow)
            SaveEntry(ds)
        End Using

        '---------------SELECT TBL_EMPLOYEE AND SAVE TO TBLMANNING FOR POSITION AND BRANCH-----------

        mysql = "SELECT * FROM tbl_employee Where Upper(FIRSTNAME) = Upper('" & FirstName & "') and
                                                    Upper(MIDDLENAME) = Upper('" & MiddleName & "') and
                                                    Upper(LASTNAME) = Upper('" & LastName & "')"
        Using ds As DataSet = LoadSQL(mysql)
            If ds.Tables(0).Rows.Count > 0 Then
                Dim dr As DataRow = ds.Tables(0).Rows(0)
                With dr
                    ID = .Item("ID")
                End With
            End If
        End Using

    End Sub

    Friend Sub SaveAllowanceDeduction()
        Dim mysql As String = "Select * From PAYROLL_ALLOW_DEDUC Rows 1"
        Using ds As DataSet = LoadSQL(mysql, "PAYROLL_ALLOW_DEDUC")

            Dim dsNewRow As DataRow
            dsNewRow = ds.Tables(0).NewRow
            With dsNewRow

                .Item("EMP_ID") = ID
                .Item("MONTHLY_SALARY") = Monthly
                .Item("DAILY_SALARY") = Daily
                .Item("BOARDING_ALLOWANCE") = Boarding
                .Item("CAREKIT_ALLOWANCE") = Carekit
                .Item("TRANSPO_ALLOWANCE") = Transportation
                .Item("MEDICAL_ALLOWANCE") = Medical
                .Item("POSITIONAL_ALLOWANCE") = Positional
                .Item("OTHER_ALLOWANCE") = OtherAllowance
                .Item("FIX_RATE") = Fix

                .Item("CASH_ADVANCE") = CashAdvance
                .Item("SAVINGS_DEDUCTION") = Savings
                .Item("LOANS_DEDUCTION") = Loans
                .Item("CHARGES_DEDUCTION") = Charges
                .Item("MEAL_DEDUCTION") = Meal
                .Item("OTHER_DEDUCTION") = OtherDeduction
            End With
            ds.Tables(0).Rows.Add(dsNewRow)
            SaveEntry(ds)
        End Using
    End Sub

    Friend Sub UpdateAllowanceDeduction()
        Dim mysql As String = "Select * From PAYROLL_ALLOW_DEDUC Where EMP_ID = '" & ID & "'"
        Using ds As DataSet = LoadSQL(mysql, "PAYROLL_ALLOW_DEDUC")

            With ds.Tables(0).Rows(0)
                .Item("MONTHLY_SALARY") = Monthly
                .Item("DAILY_SALARY") = Daily
                .Item("BOARDING_ALLOWANCE") = Boarding
                .Item("CAREKIT_ALLOWANCE") = Carekit
                .Item("TRANSPOR_ALLOWANCE") = Transportation
                .Item("MEDICAL_ALLOWANCE") = Medical
                .Item("POSITIONAL_ALLOWANCE") = Positional
                .Item("OTHER_ALLOWANCE") = OtherAllowance
                .Item("FIX_RATE") = Fix

                .Item("CASH_ADVANCE") = CashAdvance
                .Item("SAVINGS_DEDUCTION") = Savings
                .Item("LOANS_DEDUCTION") = Loans
                .Item("CHARGES_DEDUCTION") = Charges
                .Item("MEAL_DEDUCTION") = Meal
                .Item("OTHER_DEDUCTION") = OtherDeduction
            End With
            SaveEntry(ds, False)
        End Using

    End Sub

    Friend Sub SaveDEDUCTION()
        Dim mysql As String = "Select * From PAYROLL_DEDUCTION Rows 1"
        Using ds As DataSet = LoadSQL(mysql, "PAYROLL_DEDUCTION")

            Dim dsNewRow As DataRow
            dsNewRow = ds.Tables(0).NewRow
            With dsNewRow
                .Item("EMP_ID") = ID
                .Item("CASH_ADVANCE") = CashAdvance
                .Item("SAVINGS_DEDUCTION") = Savings
                .Item("LOANS_DEDUCTION") = Loans
                .Item("CHARGES_DEDUCTION") = Charges
                .Item("MEAL_DEDUCTION") = Meal
                .Item("OTHER_DEDUCTION") = OtherDeduction
            End With
            ds.Tables(0).Rows.Add(dsNewRow)
            SaveEntry(ds)
        End Using
    End Sub

    Friend Sub UpdateDEDUCTION()
        Dim mysql As String = "Select * From PAYROLL_DEDUCTION Where EMP_ID = '" & ID & "'"
        Using ds As DataSet = LoadSQL(mysql, "PAYROLL_DEDUCTION")

            With ds.Tables(0).Rows(0)
                .Item("CASH_ADVANCE") = CashAdvance
                .Item("SAVINGS_DEDUCTION") = Savings
                .Item("LOANS_DEDUCTION") = Loans
                .Item("CHARGES_DEDUCTION") = Charges
                .Item("MEAL_DEDUCTION") = Meal
                .Item("OTHER_DEDUCTION") = OtherDeduction
            End With
            SaveEntry(ds, False)
        End Using

    End Sub

    Friend Sub SAVE_REQUIREMENTS()
        Dim mysql As String = "Select * From tbl_REQ Rows 1"
        Using ds As DataSet = LoadSQL(mysql, "tbl_REQ")

            Dim dsNewRow As DataRow
            dsNewRow = ds.Tables(0).NewRow
            With dsNewRow
                .Item("PDS") = PDS
                .Item("PROBA") = proba
                .Item("EMPLOYEE_ID") = employid
                .Item("MOA") = moa
                .Item("ID_FORM") = idform
                .Item("ENDORSEMENT") = endorsement
                .Item("ACKNOW") = acknow
                .Item("BARANGAY_C") = barangay_C
                .Item("NBI_C") = NBI_C
                .Item("POLICE_C") = police_c
                .Item("HEALTHCARD") = health_C
                .Item("MAYOR_P") = mayor_P
                .Item("SSS") = sss
                .Item("MDR") = phihhealth
                .Item("TIN") = TIN
                .Item("HDMF") = pagIBIG
                .Item("CEDULA") = cedula
                .Item("Status") = "1"
            End With
            ds.Tables(0).Rows.Add(dsNewRow)
            SaveEntry(ds)
        End Using
    End Sub

    Friend Sub UpdateEmployee()
        Dim mysql As String = "Select * From tbl_Employee Where ID = '" & ID & "'"
        Using ds As DataSet = LoadSQL(mysql, "tbl_Employee")

            With ds.Tables(0).Rows(0)
                .Item("LastName") = LastName
                .Item("MIDDLENAME") = MiddleName
                .Item("CIVILSTATUS") = CivilStatus
                .Item("PERMANENT_ADDID") = PermanentAddressID
                .Item("Permanent_Street") = PermanentStreet
                .Item("PRESENT_ADDID") = PresentAddressID
                .Item("Present_Street") = PresentStreet
                .Item("EmailAdd") = EmailAddress
                .Item("ContactNo") = ContactNumber
                .Item("SSSNo") = SSSNumber
                .Item("PHILHEALTHNO") = PhilhealthNumber
                .Item("TinNo") = TINNumber
                .Item("Status") = Status
                .Item("Remarks") = Remarks
                .Item("Pagibig") = pagibignumber
                .Item("BIRATE") = BIRate
                .Item("EMP_POSITION") = Position
                .Item("BRANCH_ID") = BranchID
                .Item("BI_REMARKS") = BIRemarks
            End With
            SaveEntry(ds, False)
        End Using

        'mysql = "Select * From TBLMANNING Where  EMP_ID = '" & ID & "'"
        'Using ds As DataSet = LoadSQL(mysql, "TBLMANNING")

        '    If ds.Tables(0).Rows.Count > 0 Then
        '        With ds.Tables(0).Rows(0)
        '            .Item("Emp_Position") = Position
        '            .Item("Branch_ID") = BranchID
        '        End With
        '        SaveEntry(ds, False)
        '    End If

        'End Using

    End Sub

    Friend Sub SaveTOLASTDATE()
        Dim sql As String = "select * from tbl_lastdate rows 1"
        Using ds As DataSet = LoadSQL(sql, "tbl_lastdate")
            Dim data As DataRow
            data = ds.Tables(0).NewRow
            With data
                .Item("EMP_ID") = ID
                .Item("lastdate") = LastDate
                .Item("reason") = Remarks
            End With
            ds.Tables(0).Rows.Add(data)
            SaveEntry(ds)
        End Using
    End Sub

    Friend Sub SaveEmpHistory()
        Dim sql As String = "select * from tbl_emp_history rows 1"
        Using ds As DataSet = LoadSQL(sql, "tbl_emp_history")
            Dim data As DataRow
            data = ds.Tables(0).NewRow
            With data
                .Item("EMP_ID") = IDhistory
                .Item("NAME") = Namehistory
                .Item("PREVCIVILSTATUS") = CShistory
                .Item("SHOWCAUSECOUNT") = SChistory
                .Item("PREVSTATUS") = Statushistory
                .Item("DATEUPDATED") = Now.ToString
            End With
            ds.Tables(0).Rows.Add(data)

            SaveEntry(ds)
        End Using
    End Sub

    Friend Sub UPDATE_REQ()

        Dim mysql As String = $"Select * From TBL_REQ Where EMPLOYEE_ID = '{ID}'"
        Using ds As DataSet = LoadSQL(mysql, "TBL_REQ")

            With ds.Tables(0).Rows(0)
                ReqID = .Item("REQ_ID")
                .Item("PDS") = PDS
                .Item("PROBA") = proba
                .Item("MOA") = moa
                .Item("ID_FORM") = idform
                .Item("ENDORSEMENT") = endorsement
                .Item("ACKNOW") = acknow
                .Item("BARANGAY_C") = barangay_C
                .Item("NBI_C") = NBI_C
                .Item("MDR") = phihhealth
                .Item("POLICE_C") = police_c
                .Item("HEALTHCARD") = health_C
                .Item("MAYOR_P") = mayor_P
                .Item("SSS") = sss
                .Item("MDR") = phihhealth
                .Item("TIN") = TIN
                .Item("HDMF") = pagIBIG
                .Item("CEDULA") = cedula

            End With
            SaveEntry(ds, False)
        End Using
    End Sub

    Private Sub LoadByRows(ByVal dr As DataRow)

        With dr
            ID = .Item("ID")
            FirstName = .Item("FirstName")
            MiddleName = .Item("Middlename")
            LastName = .Item("LastName")
            Suffix = IIf(IsDBNull(.Item("Suffix")), "", .Item("Suffix"))
            DateofBirth = .Item("DateofBirth")
            Sex = .Item("GENDER")
            CivilStatus = .Item("CIVILSTATUS")

            If .Item("Present_ADDID") <> 0 Then
                PresendAddress = New Address
                PresendAddress.LoadAddress(.Item("Present_ADDID"))
            Else
                PresendAddress = Nothing
            End If

            If .Item("PERMANENT_ADDID") <> 0 Then
                PermanentAddress = New Address
                PermanentAddress.LoadAddress(.Item("PERMANENT_ADDID"))
            Else
                PermanentAddress = Nothing
            End If

            BIRate = .Item("BIRATE")
            BIRemarks = IIf(IsDBNull(.Item("BI_REMARKS")), "", .Item("BI_REMARKS"))
            PresentStreet = .Item("PERMANENT_STREET")
            PresentStreet = .Item("Present_STREET")
            EmailAddress = .Item("EmailAdd")
            DateHired = .Item("DateHired")
            BiometricID = .Item("BiometricID")
            ContactNumber = .Item("ContactNo")
            SSSNumber = .Item("SSSNo")
            PhilhealthNumber = .Item("PhilhealthNo")
            TINNumber = .Item("TinNo")
            Status = .Item("Status")

            Remarks = .Item("Remarks")
            pagibignumber = .Item("PAGIBIG").ToString
            assignstatus = .Item("ASSIGN_STATUS")

            Position = IIf(IsDBNull(.Item("Emp_Position")), "", .Item("Emp_Position"))
            BranchID = IIf(IsDBNull(.Item("Branch_id")), "", .Item("Branch_id"))

        End With
    End Sub

    Private Sub LoadREQ(ByVal dr As DataRow)

        With dr
            PDS = .Item("PDS")
            proba = .Item("PROBA")
            moa = .Item("MOA")
            idform = .Item("ID_FORM")
            endorsement = .Item("ENDORSEMENT")
            acknow = .Item("ACKNOW")
            barangay_C = .Item("BARANGAY_C")
            NBI_C = .Item("NBI_C")
            police_c = .Item("POLICE_C")
            health_C = .Item("HEALTHCARD")
            mayor_P = .Item("MAYOR_P")
            sss = .Item("SSS")
            phihhealth = .Item("MDR")
            TIN = .Item("TIN")
            pagIBIG = .Item("HDMF")
            cedula = .Item("CEDULA")

        End With
    End Sub

    Private Sub LoadBIO(ByVal dr As DataRow)
        With dr
            BiometricID = .Item("BIOMETRICID") + 1
        End With
    End Sub

    Private Sub LoadByRowsBranch(ByVal dr As DataRow)
        With dr
            Branch = .Item("Branchname")
            Company_Name = .Item("COMPANYNAME")
        End With
    End Sub

    Private Sub LoadReason(ByVal dr As DataRow)
        With dr
            LastDate = .Item("LASTDATE")
            Reason = .Item("REASON")
        End With
    End Sub

    Private Sub LoadByRowsAssigned(ByVal dr As DataRow)
        With dr
            ID = .Item("ID")
            FirstName = .Item("FirstName")
            MiddleName = .Item("Middlename")
            LastName = .Item("LastName")
            Suffix = IIf(IsDBNull(.Item("Suffix")), "", .Item("Suffix"))
            DateofBirth = .Item("DateofBirth")
            Sex = .Item("GENDER")

            If .Item("Present_ADDID") <> 0 Then
                PresendAddress = New Address
                PresendAddress.LoadAddress(.Item("Present_ADDID"))
            Else
                PresendAddress = Nothing
            End If

            If .Item("PERMANENT_ADDID") <> 0 Then
                PermanentAddress = New Address
                PermanentAddress.LoadAddress(.Item("PERMANENT_ADDID"))
            Else
                PermanentAddress = Nothing
            End If

            PresentStreet = .Item("PERMANENT_STREET")
            PresentStreet = .Item("Present_STREET")
            EmailAddress = .Item("EmailAdd")
            DateHired = .Item("DateHired")
            BiometricID = .Item("BiometricID")
            ContactNumber = .Item("ContactNo")
            SSSNumber = .Item("SSSNo")
            PhilhealthNumber = .Item("PhilhealthNo")
            TINNumber = .Item("TinNo")
            Status = .Item("Status")
            Remarks = .Item("Remarks")
            pagibignumber = .Item("PAGIBIG").ToString

            PDS = .Item("PDS")
            proba = .Item("PROBA")
            moa = .Item("MOA")
            idform = .Item("ID_FORM")
            endorsement = .Item("ENDORSEMENT")
            acknow = .Item("ACKNOW")
            barangay_C = .Item("BARANGAY_C")
            NBI_C = .Item("NBI_C")
            police_c = .Item("POLICE_C")
            health_C = .Item("HEALTHCARD")
            mayor_P = .Item("MAYOR_P")
            sss = .Item("SSS")
            phihhealth = .Item("MDR")
            TIN = .Item("TIN")
            pagIBIG = .Item("HDMF")
            cedula = .Item("CEDULA")
            assignstatus = .Item("ASSIGN_STATUS").ToString

        End With
    End Sub

#Region "BRANCH"

    Public Property Manning_ID() As Integer

    Public Property Branch_ID() As Integer

    Public Property Branch_Name() As String

    Public Property Branch_Area() As String

    Public Property Branch_Code() As String

    Public Property Company_Name() As String

#End Region

    Private Sub LoadBranchesRelieved(dr As DataRow)
        With dr
            Manning_ID = .Item("MID")
            Branch_ID = .Item("ID")
            Branch_Name = .Item("BRANCHNAME")
            Branch_Area = .Item("BRANCHAREA")
            Branch_Code = .Item("BRANCHCODE")
            Company_Name = .Item("COMPANYNAME")
        End With
    End Sub

    Friend Sub LoadEmployee(ByVal idx As Integer)
        Dim mysql As String = "Select * From tbl_Employee WHERE tbl_Employee.id= '" & idx & "'"
        Using ds As DataSet = LoadSQL(mysql, "tbl_Employee")
            If ds.Tables(0).Rows.Count > 0 Then
                LoadByRows(ds.Tables(0).Rows(0))
            End If
        End Using

        mysql = "Select * From TBL_REQ WHERE EMPLOYEE_ID = '" & idx & "'"
        Using ds As DataSet = LoadSQL(mysql, "TBL_REQ")
            If ds.Tables(0).Rows.Count > 0 Then
                LoadREQ(ds.Tables(0).Rows(0))
            End If
        End Using

        mysql = "Select * From tbl_Employee INNER JOIN TBL_BRANCH ON tbl_Employee.BRANCH_ID=TBL_BRANCH.ID  WHERE tbl_Employee.id= '" & idx & "'"
        Using ds As DataSet = LoadSQL(mysql, "tbl_Employee")
            If ds.Tables(0).Rows.Count > 0 Then
                LoadByRowsBranch(ds.Tables(0).Rows(0))
            End If
        End Using

        mysql = "Select * From TBL_LASTDATE WHERE emp_id= '" & idx & "'"
        Using ds As DataSet = LoadSQL(mysql, "TBL_LASTDATE")
            If ds.Tables(0).Rows.Count > 0 Then
                LoadReason(ds.Tables(0).Rows(0))
            End If
        End Using

    End Sub

    Friend Sub LoadEmpLetter(ByVal idx As Integer)
        Dim mysql As String = "Select * From tbl_Employee  where id = '" & idx & "'"
        Using ds As DataSet = LoadSQL(mysql, "tbl_Employee")

            If ds.Tables(0).Rows.Count > 0 Then

                Dim dr As DataRow = ds.Tables(0).Rows(0)
                With dr
                    ID = .Item("id")
                    FirstName = .Item("FIRSTNAME")
                    MiddleName = .Item("MIDDLENAME")
                    Console.WriteLine("IDDDDDD=== " & MiddleName)
                    LastName = .Item("LASTNAME")
                    Suffix = .Item("SUFFIX")
                    Sex = .Item("GENDER")
                    Position = IIf(IsDBNull(.Item("Emp_Position")), "", .Item("Emp_Position"))
                    BranchID = IIf(IsDBNull(.Item("BRANCH_ID")), "", .Item("BRANCH_ID"))
                End With
            End If
        End Using

        If Not BranchID = Nothing Then
            Dim sql As String = "Select * From TBL_BRANCH  where id = '" & BranchID & "'"
            Using dss As DataSet = LoadSQL(sql, "TBL_BRANCH")

                If dss.Tables(0).Rows.Count > 0 Then
                    Dim drr As DataRow = dss.Tables(0).Rows(0)
                    With drr
                        Company_Name = .Item("COMPANYNAME")
                        Branch_Name = .Item("BRANCHNAME")
                    End With
                End If

            End Using
        End If

    End Sub

    'Friend Sub LoadCompensationALLOWDEDUC(ByVal idx As Integer)
    'Dim mysql As String

    'mysql = "Select * From tbl_employee INNER JOIN TBL_BRANCH ON tbl_Employee.BRANCH_id=TBL_BRANCH.ID WHERE tbl_Employee.id = '" & idx & "'"
    'Using ds As DataSet = LoadSQL(mysql, "tbl_employee")

    '    If ds.Tables(0).Rows.Count > 0 Then

    '        Dim dr As DataRow
    '        dr = ds.Tables(0).Rows(0)
    '        With dr
    '            ID = .Item("id")
    '            FirstName = .Item("FIRSTNAME")
    '            MiddleName = .Item("MIDDLENAME")
    '            LastName = .Item("LASTNAME")
    '            Suffix = .Item("SUFFIX")
    '            DateHired = .Item("DATEHIRED")
    '            Position = .Item("EMP_POSITION")
    '            Company_Name = .Item("COMPANYNAME")
    '            Branch_Name = .Item("BRANCHNAME")
    '        End With

    '    End If
    'End Using

    'mysql = "Select * From PAYROLL_ALLOW_DEDUC WHERE EMP_ID = '" & idx & "'"
    'Using ds As DataSet = LoadSQL(mysql, "PAYROLL_ALLOW_DEDUC")
    '    If ds.Tables(0).Rows.Count > 0 Then

    '        Dim dr As DataRow
    '        dr = ds.Tables(0).Rows(0)
    '        With dr
    '            Monthly = .Item("MONTHLY_SALARY")
    '            Daily = .Item("DAILY_SALARY")
    '            Boarding = .Item("BOARDING_ALLOWANCE")
    '            Carekit = .Item("CAREKIT_ALLOWANCE")
    '            Transportation = .Item("TRANSPO_ALLOWANCE")
    '            Medical = .Item("MEDICAL_ALLOWANCE")
    '            Positional = .Item("POSITIONAL_ALLOWANCE")
    '            OtherAllowance = .Item("OTHER_ALLOWANCE")
    '            IDExist = "YES"

    '            CashAdvance = .Item("CASH_ADVANCE")
    '            Savings = .Item("SAVINGS_DEDUCTION")
    '            Loans = .Item("LOANS_DEDUCTION")
    '            Charges = .Item("CHARGES_DEDUCTION")
    '            Meal = .Item("MEAL_DEDUCTION")
    '            OtherDeduction = .Item("OTHER_DEDUCTION")
    '            IDExist = "YES"
    '        End With

    '    End If
    'End Using

    'End Sub

    Friend Sub LoadCorrectiveDetails(ByVal IR As Integer)
        Dim mysql As String

        mysql = "Select * From IR_RECORDS inner join tbl_employee on tbl_employee.id = IR_RECORDS.PERSON_ID WHERE IR_RECORDS.IRNo = '" & IR & "'"
        Using ds As DataSet = LoadSQL(mysql, "tbl_employee")

            If ds.Tables(0).Rows.Count > 0 Then

                Dim dr As DataRow = ds.Tables(0).Rows(0)
                With dr
                    ID = .Item("id")
                    FirstName = .Item("FIRSTNAME")
                    MiddleName = .Item("MIDDLENAME")
                    LastName = .Item("LASTNAME")
                    Suffix = .Item("SUFFIX")
                    Position = IIf(IsDBNull(.Item("Emp_Position")), "", .Item("Emp_Position"))
                    BranchID = IIf(IsDBNull(.Item("BRANCH_ID")), "", .Item("BRANCH_ID"))
                    IRNo = Format(.Item("IRNO"), "00000")

                End With

            End If
        End Using

        If Not BranchID = "" Then
            mysql = "Select * From TBL_BRANCH WHERE id = '" & BranchID & "'"
            Using ds As DataSet = LoadSQL(mysql, "TBL_BRANCH")

                If ds.Tables(0).Rows.Count > 0 Then

                    Dim dr As DataRow = ds.Tables(0).Rows(0)
                    With dr
                        Company_Name = .Item("COMPANYNAME")
                        Branch_Name = .Item("BRANCHNAME")
                    End With

                End If
            End Using
        End If

    End Sub

    Friend Sub LoadIRSupervisor(ByVal idx As Integer)
        Dim mysql As String

        mysql = "Select * From tbl_employee where id = '" & idx & "'"
        Using ds As DataSet = LoadSQL(mysql, "tbl_employee")

            If ds.Tables(0).Rows.Count > 0 Then

                Dim dr As DataRow = ds.Tables(0).Rows(0)
                With dr
                    ID = .Item("id")
                    FirstName = .Item("FIRSTNAME")
                    MiddleName = .Item("MIDDLENAME")
                    LastName = .Item("LASTNAME")
                    Suffix = .Item("SUFFIX")
                    Position = IIf(IsDBNull(.Item("Emp_Position")), "", .Item("Emp_Position"))
                End With

            End If
        End Using

    End Sub

    Friend Sub LoadIRPerson(ByVal idx As Integer)
        Dim mysql As String

        mysql = "Select * From tbl_employee WHERE id = '" & idx & "'"
        Using ds As DataSet = LoadSQL(mysql, "tbl_employee")

            If ds.Tables(0).Rows.Count > 0 Then

                Dim dr As DataRow = ds.Tables(0).Rows(0)
                With dr
                    ID = .Item("id")
                    FirstName = .Item("FIRSTNAME")
                    MiddleName = .Item("MIDDLENAME")
                    LastName = .Item("LASTNAME")
                    Suffix = .Item("SUFFIX")
                    Position = IIf(IsDBNull(.Item("Emp_Position")), "", .Item("Emp_Position"))
                    BranchID = .Item("BRANCH_ID")
                End With

            End If
        End Using

        mysql = "Select * From TBL_BRANCH WHERE id = '" & BranchID & "'"
        Using ds As DataSet = LoadSQL(mysql, "TBL_BRANCH")

            If ds.Tables(0).Rows.Count > 0 Then

                Dim dr As DataRow = ds.Tables(0).Rows(0)
                With dr
                    Branch_Name = .Item("BRANCHNAME")
                    Company_Name = .Item("COMPANYNAME")
                End With

            End If
        End Using

    End Sub


    Friend Sub LoadEmployeeAssigned(ByVal idx As Integer)
        Dim mysql As String = "Select * From tbl_Employee INNER JOIN TBL_REQ ON tbl_Employee.id=TBL_REQ.EMPLOYEE_ID WHERE tbl_Employee.id= '" & idx & "'"
        Using ds As DataSet = LoadSQL(mysql, "tbl_Employee")
            If ds.Tables(0).Rows.Count > 0 Then
                LoadByRowsAssigned(ds.Tables(0).Rows(0))
            End If
        End Using
    End Sub

    Friend Sub LoadRelieveBranch(idx As Integer)
        Dim mySql As String = "select A.ID AS MID, B.ID, A.ASSIGN_DATE, B.BRANCHNAME, B.BRANCHCODE, B.BRANCHAREA, COMPANYNAME from TBLMANNING AS A INNER JOIN TBL_BRANCH AS B " +
            "ON A.BRANCH_ID = B.ID WHERE A.EMP_ID = " & idx & " ORDER BY A.ASSIGN_DATE DESC ROWS 1"
        Using ds As DataSet = LoadSQL(mySql)

            Dim dr As DataRow
            dr = ds.Tables(0).Rows(0)
            If dr.Table.Rows.Count > 0 Then
                LoadBranchesRelieved(dr)
            Else
                Exit Sub
            End If
        End Using
    End Sub

#End Region

End Class