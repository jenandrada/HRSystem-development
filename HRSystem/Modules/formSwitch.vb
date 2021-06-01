Module formSwitch

    Friend Enum ProcessPage As Integer
        WelcomePage = 0
        AddApplicants = 1
        ReviewApplicants = 2
        Interview = 3
        JobOffering = 4
        OnBoarding = 5
        Address
        Worklist
        MonitoringWindow
    End Enum

    Friend Enum FormName As Integer
        Employee = 0
        Branch = 1
        branch2 = 2
        Manpower = 3
        Appointment = 4
        appointmentlist = 5
        rateemployee = 6
        BhouseAllowance = 7
        Coorective = 8
        monitoring = 9
        letter = 10
        compensation = 11
        branch3 = 12
        corrective = 13
    End Enum

    Friend Sub NavigateToPages(ByVal gotoForm As FormName)
        Select Case gotoForm

            Case ProcessPage.WelcomePage

                frmRecruitmentDashboard.MdiParent = frmMainForm
                frmMainForm.pNavigate.Controls.Add(frmRecruitmentDashboard)
                frmMainForm.pNavigate.Tag = frmRecruitmentDashboard
                frmRecruitmentDashboard.Show()
                frmRecruitmentDashboard.Dock = DockStyle.Fill
                frmRecruitmentDashboard.BringToFront()

            Case ProcessPage.AddApplicants

                AddNewApplicants.MdiParent = frmMainForm
                frmMainForm.pNavigate.Controls.Add(AddNewApplicants)
                frmMainForm.pNavigate.Tag = AddNewApplicants
                AddNewApplicants.Show()
                AddNewApplicants.Dock = DockStyle.Fill
                AddNewApplicants.BringToFront()

            Case ProcessPage.ReviewApplicants

                ReviewApplicants.MdiParent = frmMainForm
                frmMainForm.pNavigate.Controls.Add(ReviewApplicants)
                frmMainForm.pNavigate.Tag = ReviewApplicants
                ReviewApplicants.Show()
                ReviewApplicants.Dock = DockStyle.Fill
                ReviewApplicants.BringToFront()

            Case ProcessPage.Address

                frmAddress.MdiParent = frmMainForm
                frmMainForm.pNavigate.Controls.Add(frmAddress)
                frmMainForm.pNavigate.Tag = frmAddress
                frmAddress.Show()
                frmAddress.Dock = DockStyle.Fill
                frmAddress.BringToFront()

            Case ProcessPage.Worklist

                frmworklist.MdiParent = frmMainForm
                frmMainForm.pNavigate.Controls.Add(frmworklist)
                frmMainForm.pNavigate.Tag = frmAddress
                frmworklist.Show()
                frmworklist.Dock = DockStyle.Fill
                frmworklist.BringToFront()

            Case ProcessPage.Interview

            Case ProcessPage.JobOffering

            Case ProcessPage.OnBoarding

        End Select
    End Sub

    Friend Sub ReloadFormFromSearch(ByVal gotoForm As FormName, cus As Employee, Optional tab As Integer = 0, Optional edit As String = "")
        Select Case gotoForm
            Case FormName.Employee
                FormManagement.MdiParent = frmMainForm
                frmMainForm.pNavigate.Controls.Add(FormManagement)
                frmMainForm.pNavigate.Tag = FormManagement
                FormManagement.LoadPosition()
                FormManagement.LoadBranches()
                FormManagement.Show()

                If tab = 1 Then
                    If edit = "EDIT" Then
                        FormManagement.ManagementWindow.SelectedIndex = 0
                        FormManagement.LoadEmployeeInfo(cus, tab)
                        FormManagement.AR_Edit_BTN.BackColor = Color.Red
                    Else
                        FormManagement.ManagementWindow.SelectedIndex = 0
                        FormManagement.LoadEmployeeInfo(cus, tab)
                    End If

                ElseIf tab = 2 Then
                    FormManagement.ManagementWindow.SelectedIndex = 1
                    FormManagement.LoadEmployeeInfo(cus, tab)
                ElseIf tab = 3 Then
                    FormManagement.ManagementWindow.SelectedIndex = 2
                    FormManagement.btnstatus = 2
                    FormManagement.LoadEmployeeInfo(cus, tab)
                End If
                FormManagement.Dock = DockStyle.Fill
                FormManagement.BringToFront()

            Case FormName.Appointment
                frmappointment.MdiParent = frmMainForm
                frmMainForm.pNavigate.Controls.Add(frmappointment)
                frmMainForm.pNavigate.Tag = frmappointment
                frmappointment.LoadBranches()
                frmappointment.LoadPosition()
                frmappointment.LoadAppointment(cus)
                frmappointment.Show()
                frmappointment.Activate()
                frmappointment.Refresh()
                frmappointment.Dock = DockStyle.Fill
                frmappointment.BringToFront()

            Case FormName.letter
                frmLetter.MdiParent = frmMainForm
                frmMainForm.pNavigate.Controls.Add(frmLetter)
                frmMainForm.pNavigate.Tag = frmLetter
                frmLetter.Show()
                If tab = 1 Then
                    frmLetter.LetterWindow.SelectedIndex = 0
                    frmLetter.LoadEmpReAssign(cus)

                ElseIf tab = 2 Then
                    frmLetter.LetterWindow.SelectedIndex = 1
                    frmLetter.LoadEmpAPPOINT(cus)
                End If

                frmLetter.Dock = DockStyle.Fill
                frmLetter.BringToFront()

            'Case FormName.compensation
            '    frmCompensation.MdiParent = frmMainForm
            '    frmMainForm.pNavigate.Controls.Add(frmCompensation)
            '    frmMainForm.pNavigate.Tag = frmCompensation
            '    frmCompensation.Show()
            '    frmCompensation.LoadEmpDETAILS(cus)
            '    frmCompensation.Dock = DockStyle.Fill
            '    frmCompensation.BringToFront()

            Case FormName.corrective
                frmCoorective.MdiParent = frmMainForm
                frmMainForm.pNavigate.Controls.Add(frmCoorective)
                frmMainForm.pNavigate.Tag = frmCoorective
                frmCoorective.Show()

                If tab = 1 Then
                    frmCoorective.CorrectiveWindow.SelectedIndex = 1
                    frmCoorective.LoadEmployeeShowCause(cus)

                ElseIf tab = 2 Then
                    frmCoorective.CorrectiveWindow.SelectedIndex = 3
                    frmCoorective.LoadEmployeeWritten(cus)

                ElseIf tab = 3 Then
                    If edit = "person" Then
                        frmCoorective.CorrectiveWindow.SelectedIndex = 0
                        frmCoorective.LoadIRPerson(cus)
                    Else
                        frmCoorective.CorrectiveWindow.SelectedIndex = 0
                        frmCoorective.LoadIRSupervisor(cus)
                    End If
                End If

                frmCoorective.Dock = DockStyle.Fill
                frmCoorective.BringToFront()
        End Select
    End Sub

    Friend Sub ReloadFormBranch(ByVal gotoForm As FormName, ByVal brnch As Branch)
        Select Case gotoForm

            Case FormName.Branch
                FormManagement.MdiParent = frmMainForm
                frmMainForm.pNavigate.Controls.Add(FormManagement)
                frmMainForm.pNavigate.Tag = FormManagement
                FormManagement.LoadBranchInfo(brnch)
                FormManagement.Show()
                FormManagement.Dock = DockStyle.Fill
                FormManagement.BringToFront()

            Case FormName.branch2
                FrmMonitoring.MdiParent = frmMainForm
                frmMainForm.pNavigate.Controls.Add(FrmMonitoring)
                frmMainForm.pNavigate.Tag = FrmMonitoring
                FrmMonitoring.LoadBranch(brnch)
                FrmMonitoring.Show()
                FrmMonitoring.Dock = DockStyle.Fill
                FrmMonitoring.BringToFront()
        End Select
    End Sub

    'Friend Sub ReloadRELIEVER(ByVal gotoForm As FormName, ByVal reliever As ManPower, Optional _isPage1 As Integer = 0)
    '    Select Case gotoForm
    '        Case FormName.Manpower
    '            FormManagement.MdiParent = frmMainForm
    '            frmMainForm.pNavigate.Controls.Add(FormManagement)
    '            frmMainForm.pNavigate.Tag = FormManagement
    '            FormManagement.Show()
    '            If _isPage1 = 2 Then
    '                FormManagement.ManagementWindow.SelectedIndex = 1
    '                FormManagement.LoadReleiverInfo(reliever)
    '            End If
    '            FormManagement.Dock = DockStyle.Fill
    '            FormManagement.BringToFront()

    '        Case FormName.Coorective
    '            frmCoorective.MdiParent = frmMainForm
    '            frmMainForm.pNavigate.Controls.Add(frmCoorective)
    '            frmMainForm.pNavigate.Tag = frmCoorective
    '            frmCoorective.isPage1 = _isPage1
    '            frmCoorective.LoadEmpRelieve(reliever)
    '            frmCoorective.Show()
    '            frmCoorective.Dock = DockStyle.Fill
    '            frmCoorective.BringToFront()

    '        Case FormName.monitoring
    '            FrmMonitoring.MdiParent = frmMainForm
    '            frmMainForm.pNavigate.Controls.Add(FrmMonitoring)
    '            frmMainForm.pNavigate.Tag = FrmMonitoring
    '            FrmMonitoring.Show()
    '            If _isPage1 = 2 Then
    '                FrmMonitoring.MonitoringWindow.SelectedIndex = 1
    '                FrmMonitoring.LoadEmpLeaveRelieve(reliever)

    '            ElseIf _isPage1 = 3 Then
    '                FrmMonitoring.MonitoringWindow.SelectedIndex = 1
    '                MessageBox.Show($"{reliever.Firstname & " " & reliever.Lastname} is already on leave now.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            End If

    '            FrmMonitoring.Dock = DockStyle.Fill
    '            FrmMonitoring.BringToFront()
    '    End Select
    'End Sub

    Friend Sub ReloadFormappointmentlist(ByVal gotoForm As FormName, ByVal AppMnt As appointment, Optional i As Integer = 0)
        Select Case gotoForm
            Case FormName.appointmentlist
                FormManagement.MdiParent = frmMainForm
                frmMainForm.pNavigate.Controls.Add(FormManagement)
                frmMainForm.pNavigate.Tag = FormManagement
                FormManagement.LoadBranches_Appointed()
                FormManagement.LoadPosition_Appointed()
                FormManagement.Show()
                If i = 3 Then
                    FormManagement.ManagementWindow.SelectedIndex = 2
                    FormManagement.LoadAppointedLists(AppMnt)
                End If
                FormManagement.Dock = DockStyle.Fill
                FormManagement.BringToFront()

        End Select
    End Sub

    Friend Sub ReloadFormRateEmp(ByVal gotoForm As FormName, ByVal emp As EMPLIST_BRANCH)
        Select Case gotoForm
            Case FormName.rateemployee
                frmRateEmp.MdiParent = frmMainForm
                frmMainForm.pNavigate.Controls.Add(frmRateEmp)
                frmMainForm.pNavigate.Tag = frmRateEmp
                frmRateEmp.LOADEMPLISTBRANCH(emp)
                frmRateEmp.Show()
                frmRateEmp.Dock = DockStyle.Fill
                frmRateEmp.BringToFront()
        End Select
    End Sub

    Friend Sub ReloadFormManPower(ByVal gotoForm As FormName, ByVal MnPwr As ManPower, Optional _isPage1 As Integer = 0)
        Select Case gotoForm

            Case FormName.Manpower
                FormManagement.MdiParent = frmMainForm
                frmMainForm.pNavigate.Controls.Add(FormManagement)
                frmMainForm.pNavigate.Tag = FormManagement
                FormManagement.LoadPosition()
                FormManagement.Show()
                If _isPage1 = 1 Then
                    FormManagement.ManagementWindow.SelectedIndex = 0
                    FormManagement.LoadAssigned(MnPwr)
                    FormManagement.AR_Save_BTN.Text = "Update"
                    FormManagement.AR_Edit_BTN.BackColor = Color.Red
                End If
                FormManagement.AR_Edit_BTN.Enabled = True
                FormManagement.Dock = DockStyle.Fill
                FormManagement.BringToFront()

            'Case FormName.Coorective
            '    frmCoorective.MdiParent = frmMainForm
            '    frmMainForm.pNavigate.Controls.Add(frmCoorective)
            '    frmMainForm.pNavigate.Tag = frmCoorective
            '    frmCoorective.isPage1 = _isPage1
            '    frmCoorective.LoadEmpMpower(MnPwr)
            '    frmCoorective.Show()
            '    frmCoorective.Dock = DockStyle.Fill
            '    frmCoorective.BringToFront()

            Case FormName.monitoring
                FrmMonitoring.MdiParent = frmMainForm
                frmMainForm.pNavigate.Controls.Add(FrmMonitoring)
                frmMainForm.pNavigate.Tag = FrmMonitoring
                FrmMonitoring.Show()
                If _isPage1 = 2 Then
                    FrmMonitoring.MonitoringWindow.SelectedIndex = 1
                    FrmMonitoring.LoadEmpLeave(MnPwr)

                ElseIf _isPage1 = 3 Then
                    FrmMonitoring.MonitoringWindow.SelectedIndex = 1
                    MessageBox.Show($"{MnPwr.Firstname & " " & MnPwr.Lastname} Succesfully Save.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                FrmMonitoring.Dock = DockStyle.Fill
                FrmMonitoring.BringToFront()

                'Case FormName.letter
                '    frmLetter.MdiParent = frmMainForm
                '    frmMainForm.pNavigate.Controls.Add(frmLetter)
                '    frmMainForm.pNavigate.Tag = frmLetter
                '    frmLetter.Show()
                '    If _isPage1 = 3 Then
                '        frmLetter.LetterWindow.SelectedIndex = 2
                '        frmLetter.LoadEmpAllowance(MnPwr)
                '    End If

                '    frmLetter.Dock = DockStyle.Fill
                '    frmLetter.BringToFront()

        End Select
    End Sub

    Friend Sub RealoadfromBhouse(gotoForm As FormName, bhouse As BhouseAllowance, Optional _isPage1 As Integer = 0, Optional employee As Integer = 0, Optional subject As String = "")
        Select Case gotoForm
            Case FormName.BhouseAllowance
                frmAllowance.MdiParent = frmMainForm
                frmMainForm.pNavigate.Controls.Add(frmAllowance)
                frmMainForm.pNavigate.Tag = frmAllowance
                frmAllowance.LoadOthers(bhouse)
                frmAllowance.Show()
                frmAllowance.Dock = DockStyle.Fill
                frmAllowance.BringToFront()

            Case FormName.letter
                frmLetter.MdiParent = frmMainForm
                frmMainForm.pNavigate.Controls.Add(frmLetter)
                frmMainForm.pNavigate.Tag = frmLetter

                If _isPage1 = 3 Then
                    If employee = 2 Then
                        frmLetter.LetterWindow.SelectedIndex = 2
                        frmLetter.LoadEmpAllowanceSECOND(bhouse)

                    ElseIf employee = 3 Then

                        If subject = "Boarding_Allowance" Then

                            frmLetter.LetterWindow.SelectedIndex = 2
                            frmLetter.LoadEmpAllowanceLIST(bhouse, 1)

                        ElseIf subject = "CareKit_Allowance" Then

                            frmLetter.LetterWindow.SelectedIndex = 2
                            frmLetter.LoadEmpAllowanceLIST(bhouse, 2)

                        ElseIf subject = "Other_Allowance" Then

                            frmLetter.LetterWindow.SelectedIndex = 2
                            frmLetter.LoadEmpAllowanceLIST(bhouse, 3)

                        End If
                    Else
                        frmLetter.LetterWindow.SelectedIndex = 2
                        frmLetter.LoadEmpAllowanceFIRST(bhouse)
                    End If
                End If

                frmLetter.Show()
                frmLetter.Dock = DockStyle.Fill
                frmLetter.BringToFront()
        End Select
    End Sub

End Module