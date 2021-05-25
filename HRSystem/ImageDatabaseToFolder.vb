Imports System.Drawing.Imaging
Imports System.IO
Imports FirebirdSql.Data.FirebirdClient

Public Class ImageDatabaseToFolder

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

    Friend Sub LoadImageToFolder()
        Dim imgData As Byte()
        Dim pb As New PictureBox
        Dim img As Image
        img = pb.ErrorImage
        imgData = ImgToByteArray(img, ImageFormat.Jpeg)
        Dim sql As String = "select * from TBL_REQARCHIVE A inner join tbl_employee B on A.REQ_ID = B.ID"
        DbReaderOpen()
        Dim rdr As FbDataReader = LoadSQL_byDataReader(sql)
        If rdr.Read() Then

            If rdr.HasRows Then
                With rdr
                    SSS1 = IIf(IsDBNull(.Item("SSS")), imgData, .Item("SSS"))
                    PhilHealth1 = IIf(IsDBNull(.Item("PHILHEALTH")), imgData, .Item("PHILHEALTH"))
                    PagIbig1 = IIf(IsDBNull(.Item("PAGIBIG")), imgData, .Item("PAGIBIG"))
                    TIN1 = IIf(IsDBNull(.Item("TIN")), imgData, .Item("TIN"))
                    BarangayClearance1 = IIf(IsDBNull(.Item("BARANGAYCLEARANCE")), imgData, .Item("BARANGAYCLEARANCE"))
                    Cedula1 = IIf(IsDBNull(.Item("CEDULA")), imgData, .Item("CEDULA"))
                    PoliceClearance1 = IIf(IsDBNull(.Item("POLICECLEARANCE")), imgData, .Item("POLICECLEARANCE"))
                    NBICLEARANCE1 = IIf(IsDBNull(.Item("NBICLEARANCE")), imgData, .Item("NBICLEARANCE"))
                    HEALTHCARD1 = IIf(IsDBNull(.Item("HEALTHCARD")), imgData, .Item("HEALTHCARD"))
                    MAYORSPERMIT1 = IIf(IsDBNull(.Item("MAYORSPERMIT")), imgData, .Item("MAYORSPERMIT"))
                    PDS1 = IIf(IsDBNull(.Item("PDS")), imgData, .Item("PDS"))
                    PROBA1 = IIf(IsDBNull(.Item("PROBA")), imgData, .Item("PROBA"))
                    MOA1 = IIf(IsDBNull(.Item("MOA")), imgData, .Item("MOA"))
                    IDFORM1 = IIf(IsDBNull(.Item("IDFORM")), imgData, .Item("IDFORM"))
                    ACKNOWLEDGEMENTLETTER1 = IIf(IsDBNull(.Item("ACKNOWLEDGEMENTLETTER")), imgData, .Item("ACKNOWLEDGEMENTLETTER"))
                    ENDORSEMENTLETTER1 = IIf(IsDBNull(.Item("ENDORSEMENTLETTER")), imgData, .Item("ENDORSEMENTLETTER"))
                End With
            End If
        Else
            SSS1 = imgData
            PhilHealth1 = imgData
            PagIbig1 = imgData
            TIN1 = imgData
            BarangayClearance1 = imgData
            Cedula1 = imgData
            PoliceClearance1 = imgData
            NBICLEARANCE1 = imgData
            HEALTHCARD1 = imgData
            MAYORSPERMIT1 = imgData
            PDS1 = imgData
            PROBA1 = imgData
            MOA1 = imgData
            IDFORM1 = imgData
            ACKNOWLEDGEMENTLETTER1 = imgData
            ENDORSEMENTLETTER1 = imgData
        End If
    End Sub

End Class
