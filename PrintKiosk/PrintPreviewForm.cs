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
        private readonly PdfDocument Document;
        private readonly int NumberOfCopies;

        public PrintPreviewForm(PdfDocument document, int numberOfCopies)
        {
            InitializeComponent();
            Document = document;
            NumberOfCopies = numberOfCopies;
        }

        private void PrintPreviewForm_Load(object sender, EventArgs e)
        {
            pdfViewer.Document = Document;
            this.Text = $"Print Preview ({Document.PageCount} pages, {Document.PageCount * NumberOfCopies * 5} credits)";
        }
    }
}
