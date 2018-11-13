using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAndKioskStatus.Classes
{
    public class Kiosk
    {
        public int StoreId { get; set; }
        public string KioskId { get; set; }
        public string SerialNumber { get; set; }
        public bool SingleSided { get; set; }
        public bool DoubleSided { get; set; }
        public string IPAdress { get; set; }
        public string EFTSerialNumber1 { get; set; }
        public string EFTSerialNumber2 { get; set; }
        public string EFTSerialTID1 { get; set; }
        public string EFTSerialTID2 { get; set; }
        public string EFTMacAddress1 { get; set; }
        public string EFTMacAddress2 { get; set; }

    }
}
