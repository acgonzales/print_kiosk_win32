using MetroFramework.Controls;
using PdfiumViewer;
using PrintKiosk.Core;
using PrintKiosk.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintKiosk
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private static int MaximumAllowedCopies = 10;

        private PrinterService printerService;

        private FileSource? selectedFileSource;

        private int NumberOfCopies = 1;

        private string SelectedFile;

        public Form1()
        {
            InitializeComponent();
            printerService = new PrinterService();
        }

        private void btnUsbSource_Click(object sender, EventArgs e)
        {
            selectedFileSource = FileSource.Usb;

            List<DriveInfo> drives = FileService.GetAvailableDrives();

            cbExternalDrive.Items.Clear();
            foreach (DriveInfo drive in drives)
            {
                cbExternalDrive.Items.Add(drive);
            }
        }

        private void btnBluetoothSource_Click(object sender, EventArgs e)
        {
            selectedFileSource = FileSource.Bluetooth;
        }

        private void cbExternalDrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            DriveInfo selectedDrive = (DriveInfo)cbExternalDrive.Items[cbExternalDrive.SelectedIndex];


            List<String> files;
            try
            {
                files = FileService.ListPrintableFiles(selectedDrive.RootDirectory.FullName);
            } catch (Exception)
            { 
                files = new List<String>();
            }


            lvPrintableFiles.Items.Clear();

            if (files.Count == 0)
            {
                panelFileSelection.Visible = false;
                panelFileSelection.Enabled = false;

                lblNoPrintableFile.Visible = true;
                lblNoPrintableFile.Text = $"No applicable file found in the selected drive.\r\n\r\nSupported files are {FileService.SupportedFilesString()}.";
            } else
            {
                lblNoPrintableFile.Visible = false;


                foreach (String file in files)
                {
                    lvPrintableFiles.Items.Add(new ListViewItem(file));
                }

                panelFileSelection.Visible = true;
                panelFileSelection.Enabled = true;
            }
        }

        private void lvPrintableFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPrintableFiles.SelectedItems.Count >= 1)
            {
                string path = lvPrintableFiles.SelectedItems[0].Text;
                pdfViewer.Document = PdfDocument.Load(path);
                SelectedFile = path;
            }
        }

        private void UpdateNumberOfCopies()
        {
            lblNumberOfCopies.Text = NumberOfCopies.ToString();
            btnDecrementCopies.Enabled = NumberOfCopies > 1;
        }

        private void btnDecrementCopies_Click(object sender, EventArgs e)
        {
            NumberOfCopies--;
            UpdateNumberOfCopies();
        }

        private void btnIncrementCopies_Click(object sender, EventArgs e)
        {
            NumberOfCopies++;
            UpdateNumberOfCopies();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (SelectedFile != null)
            {
                printerService.PrintPdf(SelectedFile, NumberOfCopies);
            }
        }
    }
}
