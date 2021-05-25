Imports System.Configuration

Imports FirebirdSql.Data.FirebirdClient

''' <summary>
''' This module declare the connection of the database.
''' </summary>
''' <remarks></remarks>
Friend Module database

    'Public con As OdbcConnection
    Public con As FbConnection

    'Public ReaderCon As OdbcConnection
    Public ReaderCon As FbConnection

    Private reader As FbDataReader = Nothing
    Friend dbName As String = "1M4N4G3YU0.FDB" 'Final
    Friend fbUser As String = "SYSDBA"
    Friend fbPass As String = "masterkey"
    Friend fbDataSet As New DataSet
    Friend conStr As String = String.Empty
    'Dim ds1 As DataSet

    'Dim da1 As OdbcDataAdapter
    Dim scr_val As Integer

    Private DBversion As String = "1.5.2" 'Database version.

    Private language() As String =
        {"Connection error failed."} 'verification if the database is connected.

    Public Sub DbOpen()
        'conStr = "DRIVER=Firebird/InterBase(r) driver; User=" & fbUser & ";Password=" & fbPass & ";Database=" & dbName & ";"
        conStr = ConfigurationManager.ConnectionStrings("FbConString").ConnectionString.ToString

        Try
            con = New FbConnection(conStr)
            con.Open()
        Catch ex As FbException
            MsgBox(language(0) & ex.ErrorCode & vbCrLf & ex.Message.ToString, vbCritical, "Connecting Error")
            Log_Report(ex.Message.ToString)
            Log_Report(String.Format("User: {0}", fbUser))
            Log_Report(String.Format("Database: {0}", dbName))
            con.Dispose()
            Exit Sub
        Catch ex As Exception
            MsgBox(language(0) & ex.HResult & vbCrLf & ex.Message.ToString, vbCritical, "Connecting Error")
            Log_Report(ex.Message.ToString)
            Log_Report(String.Format("User: {0}", fbUser))
            Log_Report(String.Format("Database: {0}", dbName))
            con.Dispose()
            Exit Sub
        End Try
    End Sub

    Public Sub DbClose()
        con.Close()
    End Sub

    Friend Function IsReady() As Boolean
        Dim ready As Boolean

        Try
            DbOpen()
            ready = True
        Catch ex As Exception
            Console.WriteLine("[ERROR] " & ex.Message.ToString)
            Return False
        End Try

        Return ready
    End Function

    Friend Function SaveEntry(ByVal dsEntry As DataSet, Optional ByVal isNew As Boolean = True) As Boolean
        Try
            If dsEntry Is Nothing Then
                Return False
            End If

            DbOpen()

            Dim da As FbDataAdapter
            Dim mySql As String, fillData As String
            Dim ds As DataSet = dsEntry

            'Save all tables in the dataset
            For Each dsTable As DataTable In dsEntry.Tables
                fillData = dsTable.TableName
                mySql = "SELECT * FROM " & fillData
                If Not isNew Then
                    Dim colName As String = dsTable.Columns(0).ColumnName
                    Dim idx As Integer = dsTable.Rows(0).Item(0)
                    mySql &= String.Format(" WHERE {0} = {1}", colName, idx)

                    Console.WriteLine("ModifySQL: " & mySql)
                End If

                da = New FbDataAdapter(mySql, con)
                Dim cb As New FbCommandBuilder(da) 'Required in Saving/Update to Database
                cb.ConflictOption = ConflictOption.CompareRowVersion
                da.Update(ds, fillData)
            Next

            DbClose()
            Return True
        Catch ex As FbException
            MessageBox.Show($"[{ex.ErrorCode.ToString}] - {ex.Message}", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function


    Friend Sub SQLCommand(ByVal sql As String)
        conStr = "DRIVER=Firebird/InterBase(r) driver;User=" & fbUser & ";Password=" & fbPass & ";Database=" & dbName & ";"
        con = New FbConnection(conStr)

        Dim cmd As FbCommand
        cmd = New FbCommand(sql, con)

        Try
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
            Log_Report(String.Format("[{0}] - ", sql) & ex.ToString)
            con.Dispose()
            Exit Sub
        End Try

        Threading.Thread.Sleep(1000)
    End Sub

    Friend Function DBCompatibilityCheck() As Boolean
        Console.WriteLine("Checking database compatibility...")
        Dim strDB As String = GetOption("DBVersion")

        If DBversion = strDB Then
            Console.WriteLine("Success!")
            Return True
        Else
            Console.WriteLine("Database Version didn't match... " & strDB)
            Return False
        End If
    End Function

    Friend Function LoadSQL(ByVal mySql As String, Optional ByVal tblName As String = "QuickSQL") As DataSet
        Dim da As FbDataAdapter
        Dim ds As New DataSet, fillData As String = tblName
        Try
            DbOpen() 'open the database.

            Try
                da = New FbDataAdapter(mySql, con)
                da.Fill(ds, fillData)
            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

            DbClose()

            Return ds
        Catch ex As FbException
            Console.WriteLine(">>>>>" & mySql)
            MessageBox.Show($"[{ex.ErrorCode.ToString}] - {ex.Message}", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log_Report("LoadSQL - " & ex.ToString)
            ds = Nothing
            Return ds
        End Try
    End Function

    Friend Function PreviousPage(sql As String, rowCount As Integer, lbl As Label, Optional ByVal tblName As String = "QuickSQL") As DataSet
        scr_val -= 20
        DbOpen() 'open the database.
        Dim da As FbDataAdapter
        Dim ds As New DataSet, fillData As String = tblName
        Try
            da = New FbDataAdapter(sql, con)
            If scr_val <= 0 Then
                scr_val = 0
            End If
            da.Fill(ds, scr_val, 20, fillData)
        Catch ex As Exception
            Console.WriteLine(">>>>>" & sql)
            MsgBox(ex.ToString)
            Log_Report("PreviousPage - " & ex.ToString)
        End Try
        lbl.Text = "Record(s) " & (scr_val + 1) & " of " & rowCount
        DbClose()
        Return ds
    End Function

    Friend Function NextPage(sql As String, rowCount As Integer, lbl As Label, Optional ByVal tblName As String = "QuickSQL") As DataSet
        scr_val += 20
        DbOpen() 'open the database.
        Dim da As FbDataAdapter
        Dim ds As New DataSet, fillData As String = tblName
        Try
            da = New FbDataAdapter(sql, con)
            If scr_val >= rowCount Then
                scr_val = rowCount - 1
            End If
            da.Fill(ds, scr_val, 20, fillData)
        Catch ex As Exception
            Console.WriteLine(">>>>>" & sql)
            MsgBox(ex.ToString)
            Log_Report("NextPage - " & ex.ToString)
        End Try
        lbl.Text = "Record(s) " & (scr_val + 1) & " of " & rowCount
        DbClose()
        Return ds
    End Function

    Friend Function LoadSQL_byDataReader(ByVal mySql As String) As FbDataReader
        DbReaderOpen()
        Dim myCom As FbCommand = New FbCommand(mySql, con)
        Try
            reader = myCom.ExecuteReader()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            FbConnection.ClearPool(con)
        Finally
            FbConnection.ClearPool(con)
        End Try
        Return reader
    End Function

    Public Sub DbReaderOpen()

        conStr = ConfigurationManager.ConnectionStrings("FbConString").ConnectionString.ToString

        con = New FbConnection(conStr)
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            ElseIf con.State = ConnectionState.Closed Then
                con.Open() 'open the database.
            End If
        Catch ex As Exception
            con.Dispose()
            MsgBox(language(0) + vbCrLf + ex.Message.ToString, vbCritical, "Connecting Error")
            Log_Report(ex.Message.ToString)
            Exit Sub
        End Try
    End Sub

    Public Sub DbReaderClose()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub

    Friend Function GetOption(ByVal keys As String) As String
        Dim mySql As String = "SELECT * FROM tblmaintenance WHERE opt_keys = '" & keys & "'"
        Dim ret As String
        Try
            Dim ds As DataSet = LoadSQL(mySql)
            ret = ds.Tables(0).Rows(0).Item("opt_values")
        Catch ex As Exception
            ret = " "
        End Try

        Return ret
    End Function

    '-----------------------------------JEN  

    Public Sub RunCommand(ByVal sql As String)

        conStr = ConfigurationManager.ConnectionStrings("FbConString").ConnectionString.ToString

        con = New FbConnection(conStr)

        Dim cmd As FbCommand
        cmd = New FbCommand(sql, con)

        Try
            con.Open()
            cmd.ExecuteNonQuery()
            Console.WriteLine("DONEEEEEEEE==")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
            Log_Report(String.Format("[{0}] - ", sql) & ex.ToString)
            con.Dispose()
            Exit Sub
        End Try
    End Sub

End Module