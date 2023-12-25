using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintKiosk.Core
{
    internal class ExternalDriveInfo
    {
        public readonly DriveInfo driveInfo;

        public ExternalDriveInfo(DriveInfo driveInfo)
        {
            this.driveInfo = driveInfo;
        }

        public override string ToString()
        {
            return $"{driveInfo.Name} - {driveInfo.VolumeLabel}";
        }
    }
}
