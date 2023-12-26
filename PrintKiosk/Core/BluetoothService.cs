using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintKiosk.Core
{
    internal class BluetoothService
    {
        public static string BluetoothDropboxPath = @"C:\Users\iChico\Documents\BluetoothDropbox";

        public static void OpenReceiveFileWizard()
        {
            Process fSquirtProcess = new Process();
            fSquirtProcess.StartInfo.FileName = "fsquirt.exe";
            fSquirtProcess.StartInfo.Arguments = "-receive";
            fSquirtProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            fSquirtProcess.Start();
            fSquirtProcess.WaitForExit();

        }

        public static void OpenPairingWizard()
        {
            Process pairingProcess = new Process();
            pairingProcess.StartInfo.FileName = @"C:\Windows\System32\DevicePairingWizard.exe";
            pairingProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            pairingProcess.Start();
            pairingProcess.WaitForExit();
        }
    }
}
