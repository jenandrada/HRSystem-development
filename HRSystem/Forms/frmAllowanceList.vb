Imports System.Globalization

Public Class frmAllowanceList
    Dim frmOrig As FormName

    Friend Sub SearchSelect(src As String, frmOrigin As FormName)
        Search_TXT.Text = src
        frmOrig = frmOrigin
    End Sub

    Private Sub LoadBHA_ListView(str As String)
        Dim secured_str As String = str
        secured_str = DreadKnight(secured_str)
        Dim strWords As String() = secured_str.Split(New Char() {" "c})
        Dim Name As String
        Dim mysql As String
        Dim sql As String

        If str.Length <> 0 Then
            mysql = "SELECT * FROM BHOUSE_LIST WHERE "
            sql = "SELECT * FROM BHOUSE_LIST_APPOINTED WHERE "
            For Each Name In strWords
                mysql &= vbCr & " UPPER(FULLNAME) LIKE UPPER('%" & Name & "%') and "
                sql &= vbCr & " UPPER(FULLNAME) LIKE UPPER('%" & Name & "%') and "
                If Name Is strWords.Last Then
                    mysql &= vbCr & " UPPER(FULLNAME) LIKE UPPER('%" & Name & "%') "
                    sql &= vbCr & " UPPER(FULLNAME) LIKE UPPER('%" & Name & "%') "
                    Exit For
                End If
            Next
        Else
            mysql = "SELECT * FROM BHOUSE_LIST;"
            sql = "SELECT * FROM BHOUSE_LIST_APPOINTED;"
        End If
        Using ds As DataSet = LoadSQL(mysql, "BHOUSE_LIST")
            Using ds1 As DataSet = LoadSQL(sql, "BHOUSE_LIST_APPOINTED")
                For Each dr In ds.Tables(0).Rows
                    Addlist(dr, "ASSIGNED")
                Next
                For Each dr In ds1.Tables(0).Rows
                    Addlist(dr, "APPOINTED")
                Next
            End Using
        End Using
    End Sub

    Private Sub Addlist(dr As DataRow, status As String)
        Dim idx As String

        With dr
            Dim lvitem As ListViewItem = BHA_ListView.Items.Add(.Item("BH_ID"))
            lvitem.SubItems.Add(.Item("FULLNAME"))
            lvitem.SubItems.Add(String.Format(CultureInfo.InvariantCulture, "PHP {0:0,0.00}", .Item("ALLOWANCE")))
            If String.IsNullOrEmpty(.Item("CAREKIT_ID")) Then
                idx = 0
            Else
                idx = .Item("CAREKIT_ID").ToString
            End If
            Dim sql As String = "select * from TBL_CARE_KIT where ID = '" & idx & "';"
            Using ds As DataSet = LoadSQL(sql, "TBL_CARE_KIT")
                If ds.Tables(0).Rows.Count > 0 Then
                    With ds.Tables(0).Rows(0)
                        If String.IsNullOrEmpty(.Item("AMOUNT")) Then
                            lvitem.SubItems.Add(String.Format(CultureInfo.InvariantCulture, "PHP {0:0,0.00}", 0.0))
                        Else
                            lvitem.SubItems.Add(String.Format(CultureInfo.InvariantCulture, "PHP {0:0,0.00}", .Item("AMOUNT").ToString))
                        End If
                    End With
                Else
                    lvitem.SubItems.Add(String.Format(CultureInfo.InvariantCulture, "PHP {0:0,0.00}", 0.0))
                End If
            End Using
            lvitem.SubItems.Add(String.Format(CultureInfo.InvariantCulture, "PHP {0:0,0.00}", .Item("OTHER_ALLOWANCE")))
            lvitem.SubItems.Add(.Item("PARTICULARS").ToString)
            lvitem.SubItems.Add(.Item("BRANCHNAME"))
            lvitem.SubItems.Add(.Item("AREA_OF_ASSIGNMENT"))
            lvitem.SubItems.Add(status)
        End With
    End Sub

    Private Sub frmAllowanceList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBHA_ListView("")
        ListViewGrouping(BHA_ListView, 8)
    End Sub

    Private Sub BHA_ListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BHA_ListView.SelectedIndexChanged

        If BHA_ListView.SelectedItems.Count > 0 Then
            For Each item As ListViewItem In BHA_ListView.SelectedItems
                Dim ans As Decimal = CDec(CInt(item.SubItems(2).Text.Substring(4))) + CDec(CInt(item.SubItems(3).Text.Substring(4))) + CDec(CInt(item.SubItems(4).Text.Substring(4)))

                Dim ansFormated = String.Format(CultureInfo.InvariantCulture, "PHP {0:0,0.00}", ans)
                TotalAllowance_LBL.Text = String.Format("Total Allowance: {0}", ansFormated)
                Name_LBL.Text = item.SubItems(1).Text
            Next
        Else
            TotalAllowance_LBL.Text = String.Format("Total Allowance: {0}", 0.0)
            'Name_LBL.Text = "GLENN"
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Select_BTN_Click(sender As Object, e As EventArgs) Handles Select_BTN.Click

        'If BHA_ListView.Items.Count = 0 Then Exit Sub

        'If Search_TXT.Tag = "Letter3" Then

        '    Dim fullname As String = BHA_ListView.Items(BHA_ListView.FocusedItem.Index).SubItems(1).Text
        '    Dim bhouse As String = BHA_ListView.Items(BHA_ListView.FocusedItem.Index).SubItems(2).Text.Replace("PHP ", "")
        '    Dim carekit As String = BHA_ListView.Items(BHA_ListView.FocusedItem.Index).SubItems(3).Text.Replace("PHP ", "")
        '    Dim other As String = BHA_ListView.Items(BHA_ListView.FocusedItem.Index).SubItems(4).Text.Replace("PHP ", "")
        '    Dim particular As String = BHA_ListView.Items(BHA_ListView.FocusedItem.Index).SubItems(5).Text
        '    Dim branch As String = BHA_ListView.Items(BHA_ListView.FocusedItem.Index).SubItems(6).Text

        '    Dim tmpEmp As BhouseAllowance
        '    tmpEmp = New BhouseAllowance
        '    tmpEmp.GetDetailsJEN(fullname, bhouse, carekit, other, particular, branch)

        '    If Search_BTN.Tag = "Individual-2" Then
        '        RealoadfromBhouse(FormName.letter, tmpEmp, 3, 2)

        '    ElseIf Search_BTN.Tag = "LIST" Then

        '        If Label_Header.Tag = "Boarding_Allowance" Then

        '            RealoadfromBhouse(FormName.letter, tmpEmp, 3, 3, "Boarding_Allowance")

        '        ElseIf Label_Header.Tag = "CareKit_Allowance" Then

        '            RealoadfromBhouse(FormName.letter, tmpEmp, 3, 3, "CareKit_Allowance")

        '        ElseIf Label_Header.Tag = "Other_Allowance" Then

        '            RealoadfromBhouse(FormName.letter, tmpEmp, 3, 3, "Other_Allowance")

        '        End If
        '    Else
        '            RealoadfromBhouse(FormName.letter, tmpEmp, 3)
        '    End If

        'Else

        '    If BHA_ListView.SelectedItems.Count > 0 Then
        '        Dim idx As Integer = CInt(BHA_ListView.SelectedItems(0).SubItems(0).Text)
        '        Dim temp As New BhouseAllowance
        '        With temp
        '            .Allowance = BHA_ListView.SelectedItems(0).SubItems(2).Text.Substring(4)
        '            .LoadBhouseAllowance(idx, BHA_ListView.SelectedItems(0).SubItems(1).Text)
        '        End With
        '        RealoadfromBhouse(frmOrig, temp)

        '        Close()
        '    End If

        'End If

    End Sub

    Private Sub BHA_ListView_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles BHA_ListView.ColumnClick
        SortingOrder(BHA_ListView, e.Column)
    End Sub

End Class