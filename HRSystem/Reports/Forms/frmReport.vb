Imports System.IO

Public Class frmReport

    Dim subReportPassing As Dictionary(Of String, String)

    Private Sub Form_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsRating.RATINGS_ALL' table. You can move, or remove it, as needed.
        'Me.RATINGS_ALLTableAdapter.Fill(Me.dsRating.RATINGS_ALL)
        'TODO: This line of code loads data into the 'dsRating.RATINGS_ALL' table. You can move, or remove it, as needed.

        'web_ads.AdsDisplay = webAds
        'web_ads.Ads_Initialization()
    End Sub

    Friend Sub MultiDbSetReport(ByVal mySql As Dictionary(Of String, String), ByVal rptUrl As String,
                                Optional ByVal addPara As Dictionary(Of String, String) = Nothing, Optional ByVal hasUser As Boolean = True,
                                Optional ByVal subReport As Dictionary(Of String, String) = Nothing)
        Dim dsName As String, ds As DataSet, cmd As String
        If Not subReport Is Nothing Then subReportPassing = subReport

        With rv_display
            '.ProcessingMode = ProcessingMode.Local
            .LocalReport.ReportEmbeddedResource = rptUrl
            .LocalReport.DataSources.Clear()

            For Each el In mySql
                dsName = el.Key : cmd = el.Value
                Console.WriteLine(String.Format("{0}: {1}", dsName, cmd))

                ds = LoadSQL(cmd, dsName)
                Dim rDS As New ReportDataSource
                rDS = New ReportDataSource(dsName, ds.Tables(dsName))
                .LocalReport.DataSources.Add(rDS)
            Next

            If hasUser Then
                Dim myPara As New ReportParameter
                myPara.Name = "txtUsername"
                'If POSuser.UserName Is Nothing Then POSuser.UserName = "Sample Eskie"
                'myPara.Values.Add(POSuser.FullName)
                rv_display.LocalReport.SetParameters(New ReportParameter() {myPara})
            End If

            If Not addPara Is Nothing Then
                For Each nPara In addPara
                    Dim tmpPara As New ReportParameter
                    tmpPara.Name = nPara.Key
                    tmpPara.Values.Add(nPara.Value)
                    .LocalReport.SetParameters(New ReportParameter() {tmpPara})
                Next
            End If

            If Not subReport Is Nothing Then
                AddHandler .LocalReport.SubreportProcessing, AddressOf SubReportLoader
            End If

            .RefreshReport()
        End With
    End Sub

    Private Sub SubReportLoader(ByVal sender As Object, ByVal e As SubreportProcessingEventArgs)
        Dim dsName As String, ds As DataSet

        For Each el In subReportPassing
            dsName = el.Key
            ds = LoadSQL(el.Value, dsName)
            e.DataSources.Add(New ReportDataSource(dsName, ds.Tables(dsName)))
        Next
    End Sub

    Friend Sub ReportInit(ByVal mySql As String, ByVal dsName As String, ByVal rptUrl As String,
                          Optional ByVal addPara As Dictionary(Of String, String) = Nothing)
        Try
            Dim ds As DataSet = LoadSQL(mySql, dsName)
            If ds Is Nothing Then Exit Sub

            Console.WriteLine("SQL: " & mySql)
            Console.WriteLine("Max: " & ds.Tables(dsName).Rows.Count)
            Console.WriteLine("Report is Existing? " & File.Exists(Application.StartupPath & "\" & rptUrl))
            With rv_display
                '.ProcessingMode = ProcessingMode.Local
                .LocalReport.ReportEmbeddedResource = rptUrl
                .LocalReport.DataSources.Clear()

                .LocalReport.DataSources.Add(New ReportDataSource(dsName, ds.Tables(dsName)))

                'If hasUser Then
                '    Dim myPara As New ReportParameter
                '    myPara.Name = "txtUsername"
                '    'If POSuser.UserName Is Nothing Then POSuser.UserName = "Sample Eskie"
                '    'myPara.Values.Add(POSuser.FullName)
                '    .LocalReport.SetParameters(New ReportParameter() {myPara})
                'End If

                If Not addPara Is Nothing Then
                    For Each nPara In addPara
                        Dim tmpPara As New ReportParameter
                        tmpPara.Name = nPara.Key
                        tmpPara.Values.Add(nPara.Value)
                        .LocalReport.SetParameters(New ReportParameter() {tmpPara})
                    Next
                End If

                .RefreshReport()
            End With
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "REPORT GENERATE ERROR")
            Log_Report("REPORT - " & ex.ToString)
        End Try
    End Sub

    Friend Sub ExportReport(ByVal mysql As String, ByVal dsName As String, ByVal rptUrl As String, ByVal SavePath As String,
                            Optional ByVal addPara As Dictionary(Of String, String) = Nothing, Optional ByVal hasUser As Boolean = True,
                            Optional ByVal ExtractTo As String = "PDF")
        Try
            Dim ds As DataSet = LoadSQL(mysql, dsName)

            Dim warnings As Warning() = Nothing
            Dim streamids As String() = Nothing
            Dim mimeType As String = Nothing
            Dim encoding As String = Nothing
            Dim extension As String = Nothing
            Dim deviceInfo As String = Nothing
            Dim bytes As Byte()

            Console.WriteLine("Process " & rv_display.ShowProgress)
            rv_display.Reset()
            With rv_display

                '.ProcessingMode = ProcessingMode.Local
                .LocalReport.ReportEmbeddedResource = rptUrl
                .LocalReport.DataSources.Clear()

                .LocalReport.DataSources.Add(New ReportDataSource(dsName, ds.Tables(dsName)))

                If hasUser Then
                    Dim myPara As New ReportParameter
                    myPara.Name = "txtUsername"
                    'If POSuser.UserName Is Nothing Then POSuser.UserName = "HOO JUN MAA"
                    'myPara.Values.Add(POSuser.FullName)
                    .LocalReport.SetParameters(New ReportParameter() {myPara})
                End If

                If Not addPara Is Nothing Then
                    For Each nPara In addPara
                        Dim tmpPara As New ReportParameter
                        tmpPara.Name = nPara.Key
                        tmpPara.Values.Add(nPara.Value)
                        .LocalReport.SetParameters(New ReportParameter() {tmpPara})
                    Next
                End If
                .RefreshReport()
            End With

            bytes = rv_display.LocalReport.Render(ExtractTo, "", mimeType, encoding, extension, streamids, warnings)

            Using Stream As New FileStream(SavePath, FileMode.Create)
                Stream.Write(bytes, 0, bytes.Length)
            End Using

            'Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Friend Sub ReportInit2(ByVal ds As DataSet, ByVal dsName As String, ByVal rptUrl As String,
                        Optional ByVal addPara As Dictionary(Of String, String) = Nothing)
        Try
            If ds Is Nothing Then Exit Sub

            With rv_display
                '.ProcessingMode = ProcessingMode.Local
                .LocalReport.ReportEmbeddedResource = rptUrl
                .LocalReport.DataSources.Clear()

                .LocalReport.DataSources.Add(New ReportDataSource(dsName, ds.Tables(0)))

                'If hasUser Then
                '    Dim myPara As New ReportParameter
                '    myPara.Name = "txtUsername"
                '    If POSuser.UserName Is Nothing Then POSuser.UserName = "Sample Eskie"
                '    myPara.Values.Add(POSuser.UserName)
                '    .LocalReport.SetParameters(New ReportParameter() {myPara})
                'End If

                If Not addPara Is Nothing Then
                    For Each nPara In addPara
                        Dim tmpPara As New ReportParameter
                        tmpPara.Name = nPara.Key
                        tmpPara.Values.Add(nPara.Value)
                        .LocalReport.SetParameters(New ReportParameter() {tmpPara})
                    Next
                End If

                .RefreshReport()
            End With
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "REPORT GENERATE ERROR")
        End Try
    End Sub

    Friend Sub ExportReport3(ByVal mysql As String, ByVal dsName As String, ByVal rptUrl As String, ByVal SavePath As String,
                           Optional ByVal addPara As Dictionary(Of String, String) = Nothing, Optional ByVal hasUser As Boolean = True,
                           Optional ByVal ExtractTo As String = "PDF", Optional ByVal subReport As Dictionary(Of String, String) = Nothing)
        Try
            If Not subReport Is Nothing Then subReportPassing = subReport

            Dim ds As DataSet = LoadSQL(mysql, dsName)

            Dim warnings As Warning() = Nothing
            Dim streamids As String() = Nothing
            Dim mimeType As String = Nothing
            Dim encoding As String = Nothing
            Dim extension As String = Nothing
            Dim deviceInfo As String = Nothing
            Dim bytes As Byte()

            Console.WriteLine("Process " & rv_display.ShowProgress)
            rv_display.Reset()
            With rv_display

                '.ProcessingMode = ProcessingMode.Local
                .LocalReport.ReportEmbeddedResource = rptUrl
                .LocalReport.DataSources.Clear()

                .LocalReport.DataSources.Add(New ReportDataSource(dsName, ds.Tables(dsName)))

                If hasUser Then
                    Dim myPara As New ReportParameter
                    myPara.Name = "txtUsername"
                    'If POSuser.UserName Is Nothing Then POSuser.UserName = "HOO JUN MAA"
                    'myPara.Values.Add(POSuser.UserName)
                    .LocalReport.SetParameters(New ReportParameter() {myPara})
                End If

                If Not addPara Is Nothing Then
                    For Each nPara In addPara
                        Dim tmpPara As New ReportParameter
                        tmpPara.Name = nPara.Key
                        tmpPara.Values.Add(nPara.Value)
                        .LocalReport.SetParameters(New ReportParameter() {tmpPara})
                    Next
                End If

                If Not subReport Is Nothing Then
                    AddHandler .LocalReport.SubreportProcessing, AddressOf SubReportLoader
                End If

                .RefreshReport()
            End With

            bytes = rv_display.LocalReport.Render(ExtractTo, "", mimeType, encoding, extension, streamids, warnings)

            Using Stream As New FileStream(SavePath, FileMode.Create)
                Stream.Write(bytes, 0, bytes.Length)
            End Using

            'Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Friend Sub ExportReportMulti(ByVal mySql As Dictionary(Of String, String), ByVal dsName As String, ByVal rptUrl As String, ByVal SavePath As String,
                          Optional ByVal addPara As Dictionary(Of String, String) = Nothing, Optional ByVal hasUser As Boolean = True,
                          Optional ByVal ExtractTo As String = "PDF", Optional ByVal subReport As Dictionary(Of String, String) = Nothing)
        Try
            If Not subReport Is Nothing Then subReportPassing = subReport

            Dim ds As DataSet, cmd As String

            Dim warnings As Warning() = Nothing
            Dim streamids As String() = Nothing
            Dim mimeType As String = Nothing
            Dim encoding As String = Nothing
            Dim extension As String = Nothing
            Dim deviceInfo As String = Nothing
            Dim bytes As Byte()

            Console.WriteLine("Process " & rv_display.ShowProgress)
            rv_display.Reset()
            With rv_display

                '.ProcessingMode = ProcessingMode.Local
                .LocalReport.ReportEmbeddedResource = rptUrl
                .LocalReport.DataSources.Clear()

                For Each el In mySql
                    dsName = el.Key : cmd = el.Value

                    ds = LoadSQL(cmd, dsName)
                    Dim rDS As New ReportDataSource
                    rDS = New ReportDataSource(dsName, ds.Tables(dsName))
                    .LocalReport.DataSources.Add(rDS)
                Next

                '.LocalReport.DataSources.Add(New ReportDataSource(dsName, ds.Tables(dsName)))

                If hasUser Then
                    Dim myPara As New ReportParameter
                    myPara.Name = "txtUsername"
                    'If POSuser.UserName Is Nothing Then POSuser.UserName = "HOO JUN MAA"
                    'myPara.Values.Add(POSuser.FullName)
                    .LocalReport.SetParameters(New ReportParameter() {myPara})
                End If

                If Not addPara Is Nothing Then
                    For Each nPara In addPara
                        Dim tmpPara As New ReportParameter
                        tmpPara.Name = nPara.Key
                        tmpPara.Values.Add(nPara.Value)
                        .LocalReport.SetParameters(New ReportParameter() {tmpPara})
                    Next
                End If

                If Not subReport Is Nothing Then
                    AddHandler .LocalReport.SubreportProcessing, AddressOf SubReportLoader
                End If

                .RefreshReport()
            End With

            bytes = rv_display.LocalReport.Render(ExtractTo, "", mimeType, encoding, extension, streamids, warnings)

            Using Stream As New FileStream(SavePath, FileMode.Create)
                Stream.Write(bytes, 0, bytes.Length)
            End Using

            'Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

End Class