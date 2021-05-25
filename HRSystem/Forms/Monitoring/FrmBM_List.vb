Imports FirebirdSql.Data.FirebirdClient

Public Class FrmBM_List

    Public Sub New(title As String)
        InitializeComponent()
        Text = $"{Text} ({title})"
        Select_BTN.DialogResult = DialogResult.OK
        Cancel_Btn.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub Select_BTN_Click(sender As Object, e As EventArgs) Handles Select_BTN.Click
        Dim f As Form = Application.OpenForms("FrmMonitoring")
        CType(f, FrmMonitoring).BM_Name_TXT.Text = BmList_LV.SelectedItems(0).SubItems(0).Text
        CType(f, FrmMonitoring).BM_Position_TXT.Text = BmList_LV.SelectedItems(0).SubItems(1).Text
        Close()
    End Sub

    Public Sub LoadBmList(idx As Integer)
        Dim sql As String = $"select B.LASTNAME||', '||B.FIRSTNAME||' '||B.MIDDLENAME||' '||B.SUFFIX AS FullName,A.EMP_POSITION from tblmanning A inner join TBL_EMPLOYEE B on A.EMP_ID = B.ID where BRANCH_ID = {idx} and EMP_POSITION = 'OIC'"
        BmList_LV.Items.Clear()
        Using rdr As FbDataReader = LoadSQL_byDataReader(sql)
            While rdr.Read()
                If rdr.HasRows Then
                    Dim i As ListViewItem = BmList_LV.Items.Add(rdr.Item(0).ToString)
                    i.SubItems.Add(rdr.Item(1).ToString)
                End If
            End While
        End Using
    End Sub

End Class