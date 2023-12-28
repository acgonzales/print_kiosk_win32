using IronPdf;
using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintKiosk.Core
{
    internal class PrinterService
    {
        private static string PrinterName = "Canon G1020 series HTTP";
        private static readonly string ConvertedPdfPath = @"C:\Users\iChico\Documents\ConvertedDocx";

        public static PdfiumViewer.PdfDocument ConvertToPdfDocument(string path)
        {
            string extension = Path.GetExtension(path).ToLower();

            switch (extension)
            {
                case ".pdf":
                    return PdfiumViewer.PdfDocument.Load(path);
                case ".docx":
                    string tempPdfPath = Path.Combine(ConvertedPdfPath, Path.GetFileNameWithoutExtension(path) + ".pdf");
                    DocxToPdfRenderer renderer = new DocxToPdfRenderer();
                    IronPdf.PdfDocument pdf = renderer.RenderDocxAsPdf(path);
                    pdf.SaveAs(tempPdfPath);
                    return PdfiumViewer.PdfDocument.Load(tempPdfPath);
                default:
                    throw new Exception("Unsupported extension.");
            }
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

                using (var document = PdfiumViewer.PdfDocument.Load(pdfPath))
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
