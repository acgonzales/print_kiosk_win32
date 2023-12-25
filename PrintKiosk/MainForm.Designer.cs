namespace PrintKiosk
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.metroPanel6 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDecrementCopies = new MetroFramework.Controls.MetroTile();
            this.lblNumberOfCopies = new MetroFramework.Controls.MetroLabel();
            this.btnIncrementCopies = new MetroFramework.Controls.MetroTile();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.panelUsbBrowser = new MetroFramework.Controls.MetroPanel();
            this.panelFileSelection = new MetroFramework.Controls.MetroPanel();
            this.lvPrintableFiles = new MetroFramework.Controls.MetroListView();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lblNoPrintableFile = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cbExternalDrive = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnBluetoothSource = new MetroFramework.Controls.MetroTile();
            this.btnUsbSource = new MetroFramework.Controls.MetroTile();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblCredits = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel6.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelUsbBrowser.SuspendLayout();
            this.panelFileSelection.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnPrint);
            this.metroPanel1.Controls.Add(this.metroPanel6);
            this.metroPanel1.Controls.Add(this.panelUsbBrowser);
            this.metroPanel1.Controls.Add(this.metroPanel4);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Padding = new System.Windows.Forms.Padding(16);
            this.metroPanel1.Size = new System.Drawing.Size(920, 570);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(598, 101);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(307, 140);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "Preview and Print";
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // metroPanel6
            // 
            this.metroPanel6.AutoSize = true;
            this.metroPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel6.Controls.Add(this.metroLabel9);
            this.metroPanel6.Controls.Add(this.flowLayoutPanel1);
            this.metroPanel6.Controls.Add(this.metroLabel8);
            this.metroPanel6.HorizontalScrollbarBarColor = true;
            this.metroPanel6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel6.HorizontalScrollbarSize = 10;
            this.metroPanel6.Location = new System.Drawing.Point(362, 101);
            this.metroPanel6.Name = "metroPanel6";
            this.metroPanel6.Padding = new System.Windows.Forms.Padding(8);
            this.metroPanel6.Size = new System.Drawing.Size(230, 140);
            this.metroPanel6.TabIndex = 12;
            this.metroPanel6.VerticalScrollbarBarColor = true;
            this.metroPanel6.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel6.VerticalScrollbarSize = 10;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(11, 47);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(118, 19);
            this.metroLabel9.TabIndex = 11;
            this.metroLabel9.Text = "Number of copies:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.btnDecrementCopies);
            this.flowLayoutPanel1.Controls.Add(this.lblNumberOfCopies);
            this.flowLayoutPanel1.Controls.Add(this.btnIncrementCopies);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 73);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(206, 54);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // btnDecrementCopies
            // 
            this.btnDecrementCopies.ActiveControl = null;
            this.btnDecrementCopies.Location = new System.Drawing.Point(7, 7);
            this.btnDecrementCopies.Name = "btnDecrementCopies";
            this.btnDecrementCopies.Size = new System.Drawing.Size(60, 40);
            this.btnDecrementCopies.Style = MetroFramework.MetroColorStyle.Red;
            this.btnDecrementCopies.TabIndex = 10;
            this.btnDecrementCopies.Text = "-";
            this.btnDecrementCopies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDecrementCopies.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnDecrementCopies.UseSelectable = true;
            this.btnDecrementCopies.Click += new System.EventHandler(this.btnDecrementCopies_Click);
            // 
            // lblNumberOfCopies
            // 
            this.lblNumberOfCopies.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNumberOfCopies.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblNumberOfCopies.Location = new System.Drawing.Point(73, 4);
            this.lblNumberOfCopies.Name = "lblNumberOfCopies";
            this.lblNumberOfCopies.Size = new System.Drawing.Size(60, 40);
            this.lblNumberOfCopies.TabIndex = 7;
            this.lblNumberOfCopies.Text = "1";
            this.lblNumberOfCopies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIncrementCopies
            // 
            this.btnIncrementCopies.ActiveControl = null;
            this.btnIncrementCopies.Location = new System.Drawing.Point(139, 7);
            this.btnIncrementCopies.Name = "btnIncrementCopies";
            this.btnIncrementCopies.Size = new System.Drawing.Size(60, 40);
            this.btnIncrementCopies.Style = MetroFramework.MetroColorStyle.Green;
            this.btnIncrementCopies.TabIndex = 11;
            this.btnIncrementCopies.Text = "+";
            this.btnIncrementCopies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIncrementCopies.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnIncrementCopies.UseSelectable = true;
            this.btnIncrementCopies.Click += new System.EventHandler(this.btnIncrementCopies_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(8, 8);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(81, 25);
            this.metroLabel8.TabIndex = 6;
            this.metroLabel8.Text = "Settings";
            // 
            // panelUsbBrowser
            // 
            this.panelUsbBrowser.AutoSize = true;
            this.panelUsbBrowser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelUsbBrowser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUsbBrowser.Controls.Add(this.panelFileSelection);
            this.panelUsbBrowser.Controls.Add(this.lblNoPrintableFile);
            this.panelUsbBrowser.Controls.Add(this.metroLabel6);
            this.panelUsbBrowser.Controls.Add(this.cbExternalDrive);
            this.panelUsbBrowser.Controls.Add(this.metroLabel5);
            this.panelUsbBrowser.HorizontalScrollbarBarColor = true;
            this.panelUsbBrowser.HorizontalScrollbarHighlightOnWheel = false;
            this.panelUsbBrowser.HorizontalScrollbarSize = 10;
            this.panelUsbBrowser.Location = new System.Drawing.Point(7, 256);
            this.panelUsbBrowser.Name = "panelUsbBrowser";
            this.panelUsbBrowser.Size = new System.Drawing.Size(898, 304);
            this.panelUsbBrowser.TabIndex = 11;
            this.panelUsbBrowser.VerticalScrollbarBarColor = true;
            this.panelUsbBrowser.VerticalScrollbarHighlightOnWheel = false;
            this.panelUsbBrowser.VerticalScrollbarSize = 10;
            // 
            // panelFileSelection
            // 
            this.panelFileSelection.AutoSize = true;
            this.panelFileSelection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelFileSelection.Controls.Add(this.lvPrintableFiles);
            this.panelFileSelection.Controls.Add(this.metroLabel7);
            this.panelFileSelection.HorizontalScrollbarBarColor = true;
            this.panelFileSelection.HorizontalScrollbarHighlightOnWheel = false;
            this.panelFileSelection.HorizontalScrollbarSize = 10;
            this.panelFileSelection.Location = new System.Drawing.Point(7, 85);
            this.panelFileSelection.Name = "panelFileSelection";
            this.panelFileSelection.Size = new System.Drawing.Size(886, 214);
            this.panelFileSelection.TabIndex = 15;
            this.panelFileSelection.VerticalScrollbarBarColor = true;
            this.panelFileSelection.VerticalScrollbarHighlightOnWheel = false;
            this.panelFileSelection.VerticalScrollbarSize = 10;
            // 
            // lvPrintableFiles
            // 
            this.lvPrintableFiles.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvPrintableFiles.FullRowSelect = true;
            this.lvPrintableFiles.GridLines = true;
            this.lvPrintableFiles.Location = new System.Drawing.Point(3, 31);
            this.lvPrintableFiles.Name = "lvPrintableFiles";
            this.lvPrintableFiles.OwnerDraw = true;
            this.lvPrintableFiles.Size = new System.Drawing.Size(880, 180);
            this.lvPrintableFiles.TabIndex = 13;
            this.lvPrintableFiles.UseCompatibleStateImageBehavior = false;
            this.lvPrintableFiles.UseSelectable = true;
            this.lvPrintableFiles.View = System.Windows.Forms.View.List;
            this.lvPrintableFiles.SelectedIndexChanged += new System.EventHandler(this.lvPrintableFiles_SelectedIndexChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(0, 9);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(114, 19);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "Select file to print:";
            // 
            // lblNoPrintableFile
            // 
            this.lblNoPrintableFile.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblNoPrintableFile.Location = new System.Drawing.Point(10, 82);
            this.lblNoPrintableFile.Name = "lblNoPrintableFile";
            this.lblNoPrintableFile.Size = new System.Drawing.Size(876, 214);
            this.lblNoPrintableFile.Style = MetroFramework.MetroColorStyle.Red;
            this.lblNoPrintableFile.TabIndex = 13;
            this.lblNoPrintableFile.Text = "No applicable file found in the drive.\r\n\r\nSupported files are (.pdf).";
            this.lblNoPrintableFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(10, 45);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(90, 19);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Choose Drive:";
            // 
            // cbExternalDrive
            // 
            this.cbExternalDrive.FormattingEnabled = true;
            this.cbExternalDrive.ItemHeight = 23;
            this.cbExternalDrive.Location = new System.Drawing.Point(105, 41);
            this.cbExternalDrive.Name = "cbExternalDrive";
            this.cbExternalDrive.Size = new System.Drawing.Size(232, 29);
            this.cbExternalDrive.TabIndex = 11;
            this.cbExternalDrive.UseSelectable = true;
            this.cbExternalDrive.SelectedIndexChanged += new System.EventHandler(this.cbExternalDrive_SelectedIndexChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(5, 9);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(155, 25);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "USB File Browser";
            // 
            // metroPanel4
            // 
            this.metroPanel4.AutoSize = true;
            this.metroPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel4.Controls.Add(this.metroLabel4);
            this.metroPanel4.Controls.Add(this.btnBluetoothSource);
            this.metroPanel4.Controls.Add(this.btnUsbSource);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(7, 101);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Padding = new System.Windows.Forms.Padding(8);
            this.metroPanel4.Size = new System.Drawing.Size(347, 140);
            this.metroPanel4.TabIndex = 9;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(11, 8);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(167, 25);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Choose file source";
            // 
            // btnBluetoothSource
            // 
            this.btnBluetoothSource.ActiveControl = null;
            this.btnBluetoothSource.Location = new System.Drawing.Point(174, 40);
            this.btnBluetoothSource.Name = "btnBluetoothSource";
            this.btnBluetoothSource.Size = new System.Drawing.Size(160, 87);
            this.btnBluetoothSource.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnBluetoothSource.TabIndex = 3;
            this.btnBluetoothSource.Text = "Bluetooth";
            this.btnBluetoothSource.UseSelectable = true;
            this.btnBluetoothSource.Click += new System.EventHandler(this.btnBluetoothSource_Click);
            // 
            // btnUsbSource
            // 
            this.btnUsbSource.ActiveControl = null;
            this.btnUsbSource.Location = new System.Drawing.Point(7, 40);
            this.btnUsbSource.Name = "btnUsbSource";
            this.btnUsbSource.Size = new System.Drawing.Size(160, 87);
            this.btnUsbSource.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnUsbSource.TabIndex = 2;
            this.btnUsbSource.Text = "External storage (USB)";
            this.btnUsbSource.UseSelectable = true;
            this.btnUsbSource.Click += new System.EventHandler(this.btnUsbSource_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.AutoSize = true;
            this.metroPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.lblCredits);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(7, 14);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(318, 73);
            this.metroPanel2.TabIndex = 7;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(4, 30);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(164, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Price is 5 credits per sheet.";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(4, 54);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(311, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "You may insert a coin in the coin slot to add credits.";
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCredits.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblCredits.Location = new System.Drawing.Point(4, 0);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(176, 25);
            this.lblCredits.TabIndex = 4;
            this.lblCredits.Text = "You have 10 credits";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 650);
            this.ControlBox = false;
            this.Controls.Add(this.metroPanel1);
            this.Movable = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "Self-Service Printer Kiosk";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel6.ResumeLayout(false);
            this.metroPanel6.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelUsbBrowser.ResumeLayout(false);
            this.panelUsbBrowser.PerformLayout();
            this.panelFileSelection.ResumeLayout(false);
            this.panelFileSelection.PerformLayout();
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblCredits;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTile btnBluetoothSource;
        private MetroFramework.Controls.MetroPanel panelUsbBrowser;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox cbExternalDrive;
        private MetroFramework.Controls.MetroListView lvPrintableFiles;
        private MetroFramework.Controls.MetroPanel panelFileSelection;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel lblNoPrintableFile;
        private MetroFramework.Controls.MetroPanel metroPanel6;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroTile btnDecrementCopies;
        private MetroFramework.Controls.MetroLabel lblNumberOfCopies;
        private MetroFramework.Controls.MetroTile btnIncrementCopies;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton btnPrint;
        private MetroFramework.Controls.MetroTile btnUsbSource;
    }
}

