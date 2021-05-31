Imports System.IO
Imports System.Reflection

Module mod_system
    ''' <summary>
    ''' This region declare the neccessary variable in this system.
    ''' </summary>
    ''' <remarks></remarks>

#Region "Global Variables"

    'ReadOnly frmCollection As New FormCollection()
    Public DEV_MODE As Boolean = False
    Public PROTOTYPE As Boolean = False
    Public ComUser As New EmpUser
    Public CurrentDate As Date = Now

#End Region

    Public Function CommandPrompt(ByVal app As String, ByVal args As String) As String
        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo(app, args)
        oStartInfo.UseShellExecute = False
        oStartInfo.RedirectStandardOutput = True
        oStartInfo.WindowStyle = ProcessWindowStyle.Hidden
        oStartInfo.CreateNoWindow = True
        oProcess.StartInfo = oStartInfo

        oProcess.Start()

        Dim sOutput As String
        Using oStreamReader As StreamReader = oProcess.StandardOutput
            sOutput = oStreamReader.ReadToEnd()
        End Using

        Return sOutput
    End Function

    Friend Sub CreateEsk(ByVal url As String, ByVal data As Hashtable)
        If File.Exists(url) Then File.Delete(url)

        Dim fsEsk As New FileStream(url, FileMode.CreateNew)
        Dim refNum As String, transDate As String, branchCode As String, amount As Double, remarks As String
        Dim checkSum As String

        With data
            refNum = data(0) '0 - as RefNum
            transDate = data(1) 'transDate
            branchCode = data(2) 'branchCode
            amount = data(3) 'Amount
            remarks = data(4) 'Remarks
        End With
        checkSum = HashString(refNum & transDate & branchCode & amount & remarks)
        data.Add(5, checkSum) 'CheckSum

        Dim esk As New Runtime.Serialization.Formatters.Binary.BinaryFormatter
        esk.Serialize(fsEsk, data)
        fsEsk.Close()
    End Sub

    Friend Function LoadEsk(ByVal url) As Hashtable
        If Not File.Exists(url) Then Return Nothing

        Using fsEsk As New FileStream(url, FileMode.Open)
            Dim bf As New Runtime.Serialization.Formatters.Binary.BinaryFormatter

            Dim hashTable As New Hashtable
            Try
                hashTable = bf.Deserialize(fsEsk)
            Catch ex As Exception
                Console.WriteLine("It seems the file is being tampered.")
                Return Nothing
            End Try
            fsEsk.Close()

            Dim isValid As Boolean = False
            If hashTable(5) = HashString(hashTable(0) & hashTable(1) & hashTable(2) & hashTable(3) & hashTable(4)) Then
                isValid = True
            End If

            If isValid Then Return hashTable
        End Using
        Return Nothing
    End Function

    Friend Function DigitOnly(ByVal e As KeyPressEventArgs, Optional ByVal isWhole As Boolean = False)
        Console.WriteLine("char: " & e.KeyChar & " -" & Char.IsDigit(e.KeyChar))
        If e.KeyChar <> ControlChars.Back Then
            If isWhole Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            End If

        End If

        Return Not (Char.IsDigit(e.KeyChar))
    End Function

    Friend Function CheckNumeric(ByVal txt As TextBox) As Boolean
        If IsNumeric(txt.Text) Then
            Return True
        End If

        Return False
    End Function

    Friend Function DreadKnight(ByVal str As String, Optional ByVal special As String = Nothing) As String
        str = str.Replace("'", "''")
        str = str.Replace("""", """""")

        If special <> Nothing Then
            str = str.Replace(special, "")
        End If

        Return str
    End Function

    Friend Function IsEnter(ByVal e As KeyPressEventArgs) As Boolean
        If Asc(e.KeyChar) = 13 Then
            Return True
        End If
        Return False
    End Function

    Friend Function GetCurrentAge(ByVal dob As Date) As Integer
        Dim age As Integer
        age = Today.Year - dob.Year
        If (dob > Today.AddYears(-age)) Then age -= 1
        Return age
    End Function

    Friend Function IsMoney(ByVal txtBox As TextBox) As Boolean
        Dim isGood As Boolean = False

        If Double.TryParse(txtBox.Text, 0.0) Then
            isGood = True
        End If

        Return isGood
    End Function

    Friend Function GetFirstDate(ByVal curDate As Date) As Date
        Dim firstDay = DateSerial(curDate.Year, curDate.Month, 1)
        Return firstDay
    End Function

    Friend Function GetLastDate(ByVal curDate As Date) As Date
        Dim original As Date = curDate  ' The date you want to get the last day of the month for
        Dim lastOfMonth As Date = original.Date.AddDays(-(original.Day - 1)).AddMonths(1).AddDays(-1)

        Return lastOfMonth
    End Function

    Private Sub InsertArrayElement(Of T)(
          ByRef sourceArray() As T,
          ByVal insertIndex As Integer,
          ByVal newValue As T)

        Dim newPosition As Integer
        Dim counter As Integer

        newPosition = insertIndex
        If (newPosition < 0) Then newPosition = 0
        If (newPosition > sourceArray.Length) Then _
           newPosition = sourceArray.Length

        Array.Resize(sourceArray, sourceArray.Length + 1)

        For counter = sourceArray.Length - 2 To newPosition Step -1
            sourceArray(counter + 1) = sourceArray(counter)
        Next counter

        sourceArray(newPosition) = newValue
    End Sub

    ' HASHTABLE FUNCTIONS
    Public Function GetIDbyName(ByVal name As String, ByVal ht As Hashtable) As Integer
        For Each dt As DictionaryEntry In ht
            If dt.Value = name Then
                Return dt.Key
            End If
        Next

        Return 0
    End Function

    Public Function GetNameByID(ByVal id As Integer, ByVal ht As Hashtable) As String
        For Each dt As DictionaryEntry In ht
            If dt.Key = id Then
                Return dt.Value
            End If
        Next

        Return "ES" & "KIE GWA" & "PO"
    End Function

    Friend Sub PhoneSeparator(ByVal PhoneField As TextBox, ByVal e As KeyPressEventArgs, Optional ByVal isPhone As Boolean = False)
        Dim charPos() As Integer = {}
        If PhoneField.Text = Nothing Then Return

        Select Case PhoneField.Text.Substring(0, 1)
            Case "0"
                charPos = {4, 8}
            Case "9"
                charPos = {3, 7} '922-797-7559
            Case "+"
                charPos = {3, 7, 11} '+63-919-797-7559
            Case "6"
                charPos = {2, 6, 10} '63-919-797-7559
        End Select
        If isPhone Then
            Select Case PhoneField.Text.Substring(0, 1)
                Case "0"
                    charPos = {3, 7}
                Case Else
                    charPos = {2, 6}
            End Select
        End If

        For Each pos In charPos
            If PhoneField.TextLength = pos And Not e.KeyChar = vbBack Then
                PhoneField.Text &= "-"
                PhoneField.SelectionStart = pos + 1
            End If
        Next
    End Sub

    Private Sub SampleWord(ByVal Reason As String)
        Dim strPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        Dim tmpPath As String = String.Format("IR{1}{0}", CurrentDate.ToString("yyyyMMdd"), ".doc")
        Dim verified_url As String
        verified_url = strPath & "/" & tmpPath

        Using sw As StreamWriter = File.CreateText(verified_url)
            sw.WriteLine(CurrentDate.ToString("MM/dd/yyyy"))
            sw.WriteLine(Reason)
        End Using

    End Sub

    Friend Sub OpenWindowsForm(ByVal FormName As String)

        Try
            Dim instForm As Form = Application.OpenForms.OfType(Of Form)().Where(Function(frm) frm.Name = FormName).SingleOrDefault()
            If instForm Is Nothing Then
                Dim frm As Form
                frm = DirectCast(CreateObjectInstance(FormName), Form)
                frm.MdiParent = frmMainForm
                frmMainForm.pNavigate.Controls.Add(frm)
                frmMainForm.pNavigate.Tag = frm
                frm.Show()
                frm.Dock = DockStyle.Fill
                frm.BringToFront()
            Else
                instForm.BringToFront()
            End If

        Catch ex As Exception

        End Try

    End Sub

    Public Function CreateObjectInstance(ByVal objectName As String) As Object
        Dim obj As Object
        Try
            If objectName.LastIndexOf(".") = -1 Then
                objectName = [Assembly].GetEntryAssembly.GetName.Name & "." & objectName
            End If

            obj = [Assembly].GetEntryAssembly.CreateInstance(objectName)
        Catch ex As Exception
            obj = Nothing
        End Try
        Return obj

    End Function

#Region "Log Module"

    Const LOG_FILE As String = "syslog.txt"

    Private Sub CreateLog()
        Dim fsEsk As New FileStream(LOG_FILE, FileMode.CreateNew)
        fsEsk.Close()
    End Sub

    Friend Sub Log_Report(ByVal str As String)
        If Not File.Exists(LOG_FILE) Then CreateLog()

        Dim recorded_log As String = $"[{Now.ToString("MM/dd/yyyy HH:mm:ss") }] - {str }"

        Dim fs As New FileStream(LOG_FILE, FileMode.Append, FileAccess.Write)
        Dim fw As New StreamWriter(fs)
        fw.WriteLine(recorded_log)
        fw.Close()
        fs.Close()
        Console.WriteLine("Recorded")
    End Sub

#End Region

End Module