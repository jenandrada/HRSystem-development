using Microsoft.Reporting.WinForms;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Text;

namespace CustomPrinting
{
    public static class PrintWorkList
    {
        private static int _mCurrentPageIndex;
        private static IList<Stream> _mStreams;
        private static PageSettings _mPageSettings;

        public static Stream CreateStream(string name,
          string fileNameExtension, Encoding encoding,
          string mimeType, bool willSeek)
        {
            Stream stream = new FileStream(Path.GetTempFileName(), FileMode.Create);
            _mStreams.Add(stream);
            return stream;
        }

        public static void Export(LocalReport report, bool print = true)
        {
            PaperSize paperSize = _mPageSettings.PaperSize;
            Margins margins = _mPageSettings.Margins;

            // The device info string defines the page range to print as well as the size of the
            // page. A start and end page of 0 means generate all pages.
            string deviceInfo = string.Format(
                CultureInfo.InvariantCulture,
                "<DeviceInfo>" +
                    "<OutputFormat>EMF</OutputFormat>" +
                    "<PageWidth>8.5in</PageWidth>" +
                    "<PageHeight>11in</PageHeight>" +
                    "<MarginTop>0in</MarginTop>" +
                    "<MarginLeft>0in</MarginLeft>" +
                    "<MarginRight>0in</MarginRight>" +
                    "<MarginBottom>0in</MarginBottom>" +
                "</DeviceInfo>");
            Warning[] warnings;
            _mStreams = new List<Stream>();
            report.Render("Image", deviceInfo, CreateStream,
               out warnings);
            foreach (Stream stream in _mStreams)
                stream.Position = 0;

            if (print)
            {
                Print();
            }
        }

        // Handler for PrintPageEvents
        public static void PrintPage(object sender, PrintPageEventArgs e)
        {
            Stream pageToPrint = _mStreams[_mCurrentPageIndex];
            pageToPrint.Position = 0;

            // Load each page into a Metafile to draw it.
            using (Metafile pageMetaFile = new Metafile(pageToPrint))
            {
                Rectangle adjustedRect = new Rectangle(
                        e.PageBounds.Left - (int)e.PageSettings.HardMarginX,
                        e.PageBounds.Top - (int)e.PageSettings.HardMarginY,
                        e.PageBounds.Width,
                        e.PageBounds.Height);

                // Draw a white background for the report
                e.Graphics.FillRectangle(Brushes.White, adjustedRect);

                // Draw the report content
                e.Graphics.DrawImage(pageMetaFile, adjustedRect);

                // Prepare for next page. Make sure we haven't hit the end.
                _mCurrentPageIndex++;
                e.HasMorePages = _mCurrentPageIndex < _mStreams.Count;
            }
        }

        public static void Print()
        {
            if (_mStreams == null || _mStreams.Count == 0)
                throw new Exception("Error: no stream to print.");
            PrintDocument printDoc = new PrintDocument();
            PrintController printController = new StandardPrintController();
            printDoc.PrintController = printController;
            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception("Error: cannot find the default printer.");
            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                _mCurrentPageIndex = 0;
                printDoc.Print();
            }
        }

        public static void PrintToPrinter(this LocalReport report)
        {
            _mPageSettings = new PageSettings();
            ReportPageSettings reportPageSettings = report.GetDefaultPageSettings();

            _mPageSettings.PaperSize = reportPageSettings.PaperSize;
            _mPageSettings.Margins = reportPageSettings.Margins;

            Export(report);
        }

        public static void DisposePrint()
        {
            if (_mStreams != null)
            {
                foreach (Stream stream in _mStreams)
                    stream.Close();
                _mStreams = null;
            }
        }

        private static string ToInches(int hundrethsOfInch)
        {
            double inches = hundrethsOfInch / 100.0;
            return inches.ToString(CultureInfo.InvariantCulture) + "in";
        }
    }
}