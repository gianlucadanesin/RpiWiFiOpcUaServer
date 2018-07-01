using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace netcoreapp
{
    class RaspbianTerm
    {
        public static List<WiFiDefinition> GetListOfWiFiSSIDs()
        {
            bool isWindows = System.Runtime.InteropServices.RuntimeInformation
                            .IsOSPlatform(OSPlatform.Windows);
            List<WiFiDefinition> rv = new List<WiFiDefinition>();
            if (!isWindows) run_cmd("nmcli", "device wifi rescan");

            string cmdResult = string.Empty;
            if (!isWindows)
            {
                try
                {
                    cmdResult = run_cmd("nmcli", "device wifi list");
                }
                catch (Exception) { }
            }
            else
            {
                cmdResult = "*  SSID            MODE   CHAN  RATE       SIGNAL  BARS  SECURITY \n" +
                            "   TEST_WIFI_SSID  Infra  11    54 Mbit/s  100     ▂▄▆█  WPA2     \n" +
                            "*  TEST_WIFI_SSID2 Infra  6     54 Mbit/s  30      ▂___  WPA2     \n" +
                            "   TESTWIFI        Infra  6     54 Mbit/s  30      ▂___  WPA2     \n" +
                            "   TESTWIFI2       Infra  6     54 Mbit/s  30      ▂___  WPA2     \n" +
                            "   TESTWIFI3       Infra  6     54 Mbit/s  30      ▂___  WPA2     \n" +
                            "   TESTWIFI4       Infra  6     54 Mbit/s  30      ▂___  WPA2     \n" +
                            "   TESTWIFI5       Infra  6     54 Mbit/s  30      ▂___  WPA2     \n" +
                            "   TESTWIFI6       Infra  6     54 Mbit/s  30      ▂___  WPA2     \n" +
                            "   TESTWIFI7       Infra  6     54 Mbit/s  30      ▂___  WPA2     \n" +
                            "   TESTWIFI8       Infra  6     54 Mbit/s  30      ▂___  WPA2     \n" +
                            "   TESTWIFI        Infra  6     54 Mbit/s  30      ▂___  WEP      \n";
            }
            string HeaderRow = cmdResult.Split(new char[] { '\n' })[0];
            int SSIDBegin = -1;
            int MODEBegin = -1;
            int CHANBegin = -1;
            int RATEBegin = -1;
            int SIGNALBegin = -1;
            int BARSBegin = -1;
            int SECURITYBegin = -1;
            int SECURITYEnd = -1;

            try
            {
                SSIDBegin = HeaderRow.IndexOf("SSID");
                MODEBegin = HeaderRow.IndexOf("MODE");
                CHANBegin = HeaderRow.IndexOf("CHAN");
                RATEBegin = HeaderRow.IndexOf("RATE");
                SIGNALBegin = HeaderRow.IndexOf("SIGNAL");
                BARSBegin = HeaderRow.IndexOf("BARS");
                SECURITYBegin = HeaderRow.IndexOf("SECURITY");
                SECURITYEnd = HeaderRow.Length;
            }
            catch (Exception) { }
            List<string> SSIDEntries = cmdResult.Split(new char[] { '\n' }).Skip(1).ToList<String>();
            /*
*  SSID            MODE   CHAN  RATE       SIGNAL  BARS  SECURITY 
   TEST_WIFI_SSID  Infra  11    54 Mbit/s  100     ▂▄▆█  WPA2     
*  TEST_WIFI_SSID2 Infra  11    54 Mbit/s  100     ▂▄▆█  WPA2     
   TEST_WIFI_SSID2 Infra  6     54 Mbit/s  40      ▂▄__  WPA2     

                */
            foreach (var SSIDEntry in SSIDEntries)
            {
                //List<string> Parts = SSIDEntry.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
                if (SSIDEntry.Length == HeaderRow.Length)
                {
                    string SSID = SSIDEntry.Substring(SSIDBegin, (MODEBegin - SSIDBegin)).Trim();
                    string Security = SSIDEntry.Substring(SECURITYBegin, (SECURITYEnd - SECURITYBegin)).Trim();
                    if (SSID != string.Empty & Security != string.Empty)
                    {
                        bool contains = rv.Any(client => client.SSID == SSID);
                        if (!contains) rv.Add(new WiFiDefinition() { SSID = SSID, Security = Security });
                    }
                }
            }
            return rv;
        }

        public static void DisconnectWiFi()
        {
            bool isWindows = System.Runtime.InteropServices.RuntimeInformation
                            .IsOSPlatform(OSPlatform.Windows);
            if (!isWindows)
            {
                try
                {
                    run_cmd("nmcli", $"device disconnect wlan0");
                    Console.Write("WiFi disconnected");
                }
                catch (Exception) { }
            }
        }

        public static void ConnectWiFi(string SelSSID, string SelPassword)
        {
            bool isWindows = System.Runtime.InteropServices.RuntimeInformation
                            .IsOSPlatform(OSPlatform.Windows);
            if (!isWindows)
            {
                try
                {
                    run_cmd("nmcli", $"device wifi connect \"{SelSSID}\" password \"{SelPassword}\"");
                    Console.Write($"Command received: connect to WiFi SSID \"{SelSSID}\" with pass \"{SelPassword}\"");
                }
                catch (Exception) {}
            }
        }

        public static string GetConnectedSSID()
        {
            bool isWindows = System.Runtime.InteropServices.RuntimeInformation
                            .IsOSPlatform(OSPlatform.Windows);
            string rv = string.Empty;
            string Status = string.Empty;
            if (!isWindows)
            {
                try
                {
                    Status = run_cmd("nmcli", "device status");
                }
                catch (Exception){}
                /*
DEVICE  TYPE      STATE      CONNECTION       
eth0    ethernet  connected  Ifupdown (eth0)  
wlan0   wifi      connected  TEST_WIFI_SSID 8 
lo      loopback  unmanaged  --               
 
                */

            }
            else
            {
                Status = "DEVICE  TYPE      STATE      CONNECTION       \n" +
                         "eth0    ethernet  connected  Ifupdown (eth0)  \n" +
                         "wlan0   wifi      connected  TEST_WIFI_SSID 8 \n" +
                         "lo      loopback  unmanaged  --               \n";
            }
            string HeaderRow = Status.Split(new char[] { '\n' })[0];
            int DEVICEBegin = HeaderRow.IndexOf("DEVICE");
            int TYPEBegin = HeaderRow.IndexOf("TYPE");
            int STATEBegin = HeaderRow.IndexOf("STATE");
            int CONNECTIONBegin = HeaderRow.IndexOf("CONNECTION");
            int CONNECTIONEnd = HeaderRow.Length;
            List<string> DeviceEntries = Status.Split(new char[] { '\n' }).Skip(1).ToList<String>();
            foreach (var Device in DeviceEntries)
            {
                if (Device.Length == HeaderRow.Length)
                {
                    string DeviceName = Device.Substring(DEVICEBegin, (TYPEBegin - DEVICEBegin)).Trim();
                    string State = Device.Substring(STATEBegin, (CONNECTIONBegin - STATEBegin)).Trim();
                    string SSID = Device.Substring(CONNECTIONBegin, (CONNECTIONEnd - CONNECTIONBegin)).Trim();
                    if (DeviceName.ToLower() == "wlan0")
                    {
                        if (State.ToLower() == "connected")
                        {
                            rv = SSID.Substring(0,SSID.Length-2).Trim();
                        }
                        break;
                    }
                }
            }
            return rv;
        }

        private static String run_cmd(string cmd, string args)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = cmd;
            start.Arguments = args;
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    return result;
                }
            }
        }

        public struct WiFiDefinition
        {
            public string SSID;
            public string Security;
        }
    }
}
