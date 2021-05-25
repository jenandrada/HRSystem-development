
Public Class frmCompensation
    Private tmpEmployee As Employee

    Private Sub SelectSalary_BTN_Click(sender As Object, e As EventArgs) Handles SelectSalary_BTN.Click
        If frmEmployeeList Is Nothing Then
            Dim frm As New frmEmployeeList With {
                .MdiParent = frmMainForm
            }
            frmMainForm.pNavigate.Controls.Add(frm)
            frmMainForm.pNavigate.Tag = frm
            frm.Show()
            frm.btnView.Visible = False
            frm.btnAdd.Visible = False
            frm.btnSelect.Visible = True
            frm.txtSearch.Tag = "Compensation"
            frm.Dock = DockStyle.Fill
            frm.BringToFront()

        Else
            frmEmployeeList.BringToFront()
        End If

        Close()
    End Sub

    Public Sub LoadEmpDETAILS(mPower As Employee)
        With mPower

            Dim MI As String

            If .IDExist = "YES" Then
                SaveSalary_BTN.Text = "Update"
            End If

            If String.IsNullOrEmpty(.MiddleName) Then
                MI = ""
            Else
                MI = .MiddleName.Substring(0, 1) & "."
            End If

            Name_S_TXT.Tag = .ID
            Name_S_TXT.Text = $"{ .FirstName} { MI } { .LastName} { .Suffix}"
            DateHired_DTP.Text = .DateHired
            Position_S_TXT.Text = .Position
            Company_S_TXT.Text = .Company_Name
            Branch_S_TXT.Text = .Branch_Name

            Monthly_TXT.Text = .Monthly
            Daily_TXT.Text = .Daily
            Boarding_TXT.Text = .Boarding
            CareKit_TXT.Text = .Carekit
            Transportation_TXT.Text = .Transportation
            Medical_TXT.Text = .Medical
            OtherAllowance_TXT.Text = .OtherAllowance

            CashAdvance_TXT.Text = .CashAdvance
            Savings_TXT.Text = .Savings
            Loans_TXT.Text = .Loans
            Charges_TXT.Text = .Charges
            MealDeduction_TXT.Text = .Meal
            OtherDeduction_TXT.Text = .OtherDeduction

        End With
    End Sub

    'Public Sub LoadEmpDEDUCTION(mPower As Employee)
    '    With mPower

    '        Dim MI As String

    '        If .IDExist = "YES" Then
    '            SaveDeduction_BTN.Text = "Update"
    '        End If

    '        If String.IsNullOrEmpty(.MiddleName) Then
    '            MI = ""
    '        Else
    '            MI = .MiddleName.Substring(0, 1) & "."
    '        End If

    '        Name_D_TXT.Tag = .ID
    '        Name_D_TXT.Text = $"{ .FirstName} { MI } { .LastName} { .Suffix}"
    '        DateHired_D_DTP.Text = .DateHired
    '        Position_D_TXT.Text = .Position
    '        Company_D_TXT.Text = .Company_Name
    '        Branch_D_TXT.Text = .Branch_Name

    '        CashAdvance_TXT.Text = .CashAdvance
    '        Savings_TXT.Text = .Savings
    '        Loans_TXT.Text = .Loans
    '        Charges_TXT.Text = .Charges
    '        MealDeduction_TXT.Text = .Meal
    '        OtherDeduction_TXT.Text = .OtherDeduction

    '    End With
    'End Sub

    Private Sub SaveSalary_BTN_Click(sender As Object, e As EventArgs) Handles SaveSalary_BTN.Click
        If Fix_RB.Checked = True Then
            Fix_RB.Tag = "YES"
        Else
            Fix_RB.Tag = "NO"
        End If

        If SaveSalary_BTN.Text = "Update" Then

            If Name_S_TXT.Text = "" Then
                MsgBox("Kindly Check Employee's Name", vbCritical, "Cannot Update!")
            Else

                tmpEmployee = New Employee

                With tmpEmployee

                    .ID = Name_S_TXT.Tag
                    .Monthly = Monthly_TXT.Text
                    .Daily = Daily_TXT.Text
                    .Boarding = Boarding_TXT.Text
                    .Carekit = CareKit_TXT.Text
                    .Transportation = Transportation_TXT.Text
                    .Medical = Medical_TXT.Text
                    .Positional = Positional_TXT.Text
                    .OtherAllowance = OtherAllowance_TXT.Text
                    .Fix = Fix_RB.Tag

                    .CashAdvance = CashAdvance_TXT.Text
                    .Savings = Savings_TXT.Text
                    .Loans = Loans_TXT.Text
                    .Charges = Charges_TXT.Text
                    .Meal = MealDeduction_TXT.Text
                    .OtherDeduction = OtherDeduction_TXT.Text

                    .UpdateAllowanceDeduction()
                End With

                MsgBox("Successfully Updated!", MsgBoxStyle.Information, "Information")
                SaveSalary_BTN.Text = "Save"
                ClearText()

            End If

        Else

            If Name_S_TXT.Text = "" Then
                MsgBox("Kindly Check Employee's Name", vbCritical, "Cannot Save!")
            Else

                tmpEmployee = New Employee

                With tmpEmployee
                    .ID = Name_S_TXT.Tag
                    .Monthly = Monthly_TXT.Text
                    .Daily = Daily_TXT.Text
                    .Boarding = Boarding_TXT.Text
                    .Carekit = CareKit_TXT.Text
                    .Transportation = Transportation_TXT.Text
                    .Medical = Medical_TXT.Text
                    .Positional = Positional_TXT.Text
                    .OtherAllowance = OtherAllowance_TXT.Text
                    .Fix = Fix_RB.Tag

                    .CashAdvance = CashAdvance_TXT.Text
                    .Savings = Savings_TXT.Text
                    .Loans = Loans_TXT.Text
                    .Charges = Charges_TXT.Text
                    .Meal = MealDeduction_TXT.Text
                    .OtherDeduction = OtherDeduction_TXT.Text

                    .SaveAllowanceDeduction()
                End With
                MsgBox("New Record Added", MsgBoxStyle.Information, "Information")
                ClearText()

            End If
        End If
    End Sub

    Private Sub ClearText()
        Name_S_TXT.Clear()
        Monthly_TXT.Clear()
        Daily_TXT.Clear()
        Boarding_TXT.Clear()
        CareKit_TXT.Clear()
        Transportation_TXT.Clear()
        Medical_TXT.Clear()
        Position_S_TXT.Clear()
        OtherAllowance_TXT.Clear()

        DateHired_DTP.Value = Date.Now
        Position_S_TXT.Clear()
        Company_S_TXT.Clear()
        Branch_S_TXT.Clear()

        CashAdvance_TXT.Clear()
        Savings_TXT.Clear()
        Loans_TXT.Clear()
        Charges_TXT.Clear()
        MealDeduction_TXT.Clear()
        OtherDeduction_TXT.Clear()

    End Sub

    'Private Sub ClearTextDEDUCTION()

    '    'Name_D_TXT.Clear()
    '    'DateHired_D_DTP.Value = Date.Now
    '    'Position_D_TXT.Clear()
    '    'Company_D_TXT.Clear()
    '    'Branch_D_TXT.Clear()

    'End Sub

    'Private Sub SelectDeduction_BTN_Click(sender As Object, e As EventArgs)
    '    If frmEmployeeList Is Nothing Then
    '        Dim frm As New frmEmployeeList With {
    '            .MdiParent = frmMainForm
    '        }
    '        frmMainForm.pNavigate.Controls.Add(frm)
    '        frmMainForm.pNavigate.Tag = frm
    '        frm.Show()
    '        frm.btnView.Visible = False
    '        frm.btnAdd.Visible = False
    '        frm.btnSelect.Visible = True
    '        frm.txtSearch.Tag = "Compensation2"
    '        frm.Dock = DockStyle.Fill
    '        frm.BringToFront()

    '    Else
    '        frmEmployeeList.BringToFront()
    '    End If
    '    Close()
    'End Sub

    'Private Sub SaveDeduction_BTN_Click(sender As Object, e As EventArgs)

    '    If SaveDeduction_BTN.Text = "Update" Then

    '        If Name_D_TXT.Text = "" Then
    '            MsgBox("Kindly Check Employee's Name", vbCritical, "Cannot Update!")
    '        Else

    '            tmpEmployee = New Employee

    '            With tmpEmployee

    '                .ID = Name_D_TXT.Tag
    '                .CashAdvance = CashAdvance_TXT.Text
    '                .Savings = Savings_TXT.Text
    '                .Loans = Loans_TXT.Text
    '                .Charges = Charges_TXT.Text
    '                .Meal = MealDeduction_TXT.Text
    '                .OtherDeduction = OtherDeduction_TXT.Text

    '                .UpdateDEDUCTION()
    '            End With

    '            MsgBox("Successfully Updated!", MsgBoxStyle.Information, "Information")
    '            SaveDeduction_BTN.Text = "Save"
    '            ClearTextDEDUCTION()
    '        End If

    '    Else

    '        If Name_D_TXT.Text = "" Then
    '            MsgBox("Kindly Check Employee's Name", vbCritical, "Cannot Save!")
    '        Else

    '            tmpEmployee = New Employee

    '            With tmpEmployee

    '                .ID = Name_D_TXT.Tag
    '                .CashAdvance = CashAdvance_TXT.Text
    '                .Savings = Savings_TXT.Text
    '                .Loans = Loans_TXT.Text
    '                .Charges = Charges_TXT.Text
    '                .Meal = MealDeduction_TXT.Text
    '                .OtherDeduction = OtherDeduction_TXT.Text

    '                .SaveDEDUCTION()
    '            End With
    '            MsgBox("New Record Added", MsgBoxStyle.Information, "Information")
    '            ClearTextDEDUCTION()

    '        End If

    '    End If
    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel2_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Fix_RB_CheckedChanged(sender As Object, e As EventArgs) Handles Fix_RB.CheckedChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label29_Click(sender As Object, e As EventArgs) Handles Label29.Click

    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click

    End Sub

    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click

    End Sub

    Private Sub Label32_Click(sender As Object, e As EventArgs) Handles Label32.Click

    End Sub

    Private Sub Label33_Click(sender As Object, e As EventArgs) Handles Label33.Click

    End Sub

    Private Sub Label31_Click(sender As Object, e As EventArgs) Handles Label31.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub DateHired_DTP_ValueChanged(sender As Object, e As EventArgs) Handles DateHired_DTP.ValueChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Branch_S_TXT_TextChanged(sender As Object, e As EventArgs) Handles Branch_S_TXT.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Company_S_TXT_TextChanged(sender As Object, e As EventArgs) Handles Company_S_TXT.TextChanged

    End Sub

    Private Sub Position_S_TXT_TextChanged(sender As Object, e As EventArgs) Handles Position_S_TXT.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Boarding_TXT_TextChanged(sender As Object, e As EventArgs) Handles Boarding_TXT.TextChanged

    End Sub

    Private Sub Name_S_TXT_TextChanged(sender As Object, e As EventArgs) Handles Name_S_TXT.TextChanged

    End Sub

    Private Sub NotFix_RB_CheckedChanged(sender As Object, e As EventArgs) Handles NotFix_RB.CheckedChanged

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click

    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click

    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click

    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Monthly_TXT_TextChanged(sender As Object, e As EventArgs) Handles Monthly_TXT.TextChanged

    End Sub

    Private Sub OtherDeduction_TXT_TextChanged(sender As Object, e As EventArgs) Handles OtherDeduction_TXT.TextChanged

    End Sub

    Private Sub MealDeduction_TXT_TextChanged(sender As Object, e As EventArgs) Handles MealDeduction_TXT.TextChanged

    End Sub

    Private Sub Charges_TXT_TextChanged(sender As Object, e As EventArgs) Handles Charges_TXT.TextChanged

    End Sub

    Private Sub Loans_TXT_TextChanged(sender As Object, e As EventArgs) Handles Loans_TXT.TextChanged

    End Sub

    Private Sub Savings_TXT_TextChanged(sender As Object, e As EventArgs) Handles Savings_TXT.TextChanged

    End Sub

    Private Sub CashAdvance_TXT_TextChanged(sender As Object, e As EventArgs) Handles CashAdvance_TXT.TextChanged

    End Sub

    Private Sub Daily_TXT_TextChanged(sender As Object, e As EventArgs) Handles Daily_TXT.TextChanged

    End Sub

    Private Sub Positional_TXT_TextChanged(sender As Object, e As EventArgs) Handles Positional_TXT.TextChanged

    End Sub

    Private Sub OtherAllowance_TXT_TextChanged(sender As Object, e As EventArgs) Handles OtherAllowance_TXT.TextChanged

    End Sub

    Private Sub Medical_TXT_TextChanged(sender As Object, e As EventArgs) Handles Medical_TXT.TextChanged

    End Sub

    Private Sub Transportation_TXT_TextChanged(sender As Object, e As EventArgs) Handles Transportation_TXT.TextChanged

    End Sub

    Private Sub CareKit_TXT_TextChanged(sender As Object, e As EventArgs) Handles CareKit_TXT.TextChanged

    End Sub
End Class