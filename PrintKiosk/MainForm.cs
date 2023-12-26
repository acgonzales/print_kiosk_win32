using MetroFramework.Controls;
using PdfiumViewer;
using PrintKiosk.Core;
using PrintKiosk.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintKiosk
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        private FileSource? selectedFileSource;

        private int NumberOfCopies = 1;

        private string SelectedFile;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnUsbSource_Click(object sender, EventArgs e)
        {
            selectedFileSource = FileSource.Usb;

            panelUsbBrowser.Visible = true;
            panelBluetooth.Visible = false;

            List<ExternalDriveInfo> drives = FileService.GetAvailableDrives();

            cbExternalDrive.Items.Clear();
            foreach (ExternalDriveInfo drive in drives)
            {
                cbExternalDrive.Items.Add(drive);
            }
        }

        private void btnBluetoothSource_Click(object sender, EventArgs e)
        {
            selectedFileSource = FileSource.Bluetooth;

            panelUsbBrowser.Visible = false;
            panelBluetooth.Visible = true;
        }

        private void cbExternalDrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExternalDriveInfo selectedDrive = (ExternalDriveInfo)cbExternalDrive.Items[cbExternalDrive.SelectedIndex];


            List<String> files;
            try
            {
                files = FileService.ListPrintableFiles(selectedDrive.driveInfo.RootDirectory.FullName);
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
                SelectedFile = path;
                btnPrint.Enabled = true;
            } else
            {
                btnPrint.Enabled = false;
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
                PrintPreviewForm printPreviewForm = new PrintPreviewForm(SelectedFile);
                DialogResult dialogResult = printPreviewForm.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    PrinterService.PrintPdf(SelectedFile, NumberOfCopies);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblDropboxHelp.Text = $"Click the button below to start receiving files. Make sure to save files in this directory: {BluetoothService.BluetoothDropboxPath}";
            btnUsbSource_Click(this, null);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            List<String> files;
            try
            {
                files = FileService.ListPrintableFiles(BluetoothService.BluetoothDropboxPath);
            }
            catch (Exception)
            {
                files = new List<String>();
            }

            lvBluetoothDropboxFiles.Items.Clear();
            foreach (String file in files)
            {
                lvBluetoothDropboxFiles.Items.Add(new ListViewItem(file));
            }
        }

        private void btnOpenPairingWizard_Click(object sender, EventArgs e)
        {
            BluetoothService.OpenPairingWizard();
        }

        private void btnReceiveFiles_Click(object sender, EventArgs e)
        {
            BluetoothService.OpenReceiveFileWizard();
        }

        private void lvBluetoothDropboxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBluetoothDropboxFiles.SelectedItems.Count >= 1)
            {
                string path = lvBluetoothDropboxFiles.SelectedItems[0].Text;
                SelectedFile = path;
                btnPrint.Enabled = true;
            }
            else
            {
                btnPrint.Enabled = false;
            }
        }
    }
}
