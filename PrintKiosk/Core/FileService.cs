﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintKiosk.Core
{
    internal class FileService
    {
        private static string[] AcceptedExtensions = new string[] { ".pdf", ".docx" };

        public static List<ExternalDriveInfo> GetAvailableDrives()
        {
            return DriveInfo.GetDrives()
                .Where(x => (x.DriveType == DriveType.Removable || x.DriveType == DriveType.Fixed)  && !x.RootDirectory.FullName.StartsWith("C:"))
                .Select(x => new ExternalDriveInfo(x))
                .ToList();
        }

        public static List<string> ListPrintableFiles(string path)
        {
            return Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories).Where(f => AcceptedExtensions.Any(ext => ext.Equals(Path.GetExtension(f), StringComparison.OrdinalIgnoreCase) )).ToList();
        }

        public static string SupportedFilesString()
        {
            return String.Join(", ", AcceptedExtensions);
        }
    }
}
