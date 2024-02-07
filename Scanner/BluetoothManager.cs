using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InTheHand.Bluetooth;

namespace WABBA.Scanner
{
    internal static class BluetoothManager
    {
        public static void init()
        {
            
        }
        public static bool Scan()
        {
            return Bluetooth.GetAvailabilityAsync().Result;
        }
    }

 
}
