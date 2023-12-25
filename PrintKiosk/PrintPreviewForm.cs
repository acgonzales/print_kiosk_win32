using MetroFramework.Forms;
using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintKiosk
{
    public partial class PrintPreviewForm : MetroForm
    {
        private readonly string PathToPrint;
        private readonly PdfDocument Document;


        public PrintPreviewForm(string pathToPrint)
        {
            InitializeComponent();
            PathToPrint = pathToPrint;
            Document = PdfDocument.Load(pathToPrint);
        }

        private void PrintPreviewForm_Load(object sender, EventArgs e)
        {
            pdfViewer.Document = Document;
            this.Text = $"Print Preview ({Document.PageCount} pages, {Document.PageCount * 5} credits)";
        }
    }
}
