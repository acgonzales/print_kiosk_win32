using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintKiosk.Core
{
    internal class PrinterService
    {
        private static string SamplePdfFilename = @"C:\Users\Chazz\Downloads\blank.pdf";
        private static string PrinterName = "Canon G1020 series HTTP";

        public static bool PrintSamplePdf(int copies, string paperName = "A4")
        {
            return PrintPdf(SamplePdfFilename, copies, paperName);
        }

        public static bool PrintPdf(string pdfPath, int copies, string paperName = "A4") {
            try
            {
                var printerSettings = new PrinterSettings
                {
                    PrinterName = PrinterName,
                    Copies = (short) copies,
                };

                var pageSettings = new PageSettings(printerSettings)
                {
                    Margins = new Margins(0, 0, 0, 0),
                };
                foreach (PaperSize paperSize in printerSettings.PaperSizes)
                {
                    if (paperSize.PaperName == paperName)
                    {
                        pageSettings.PaperSize = paperSize;
                        break;
                    }
                }

                using (var document = PdfDocument.Load(pdfPath))
                {
                    using (var printDocument = document.CreatePrintDocument())
                    {
                        printDocument.PrinterSettings = printerSettings;
                        printDocument.DefaultPageSettings = pageSettings;
                        printDocument.PrintController = new StandardPrintController();
                        printDocument.Print();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
