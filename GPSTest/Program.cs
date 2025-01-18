using System.Diagnostics;
using System.Text;
using System.Xml.Linq;
using System.Xml;
using Chetch.GPS;
using Chetch.Messaging;
using Chetch.Utilities;
using System.Runtime.CompilerServices;
using System.CodeDom.Compiler;


namespace GPSTest;

class Program
{
    /*class ArduinoBoard : Chetch.Utilities.SerialPortDevice
    {
        protected override string getPortName()
        {
            String portName;
            if(OperatingSystem.IsMacOS())
            {
                //searchFor = "u-blox 7 - GPS/GNSS Receiver";
                //searchKey = "USB Product Name";
                int pid = 0x0043;
                searchFor = pid.ToString();
                searchKey = "idProduct";
                return GetPortNameForDevice(pid, idProduct); 
            }
            else if(OperatingSystem.IsLinux())
            {
                //searchFor = "usb-u-blox"; //Full name: usb-u-blox_AG_-_www.u-blox.com_u-blox_7_-_GPS_GNSS_Receiver-if00 
                //searchFor = "usb-Arduino"; //Full name: usb-Arduino__www.arduino.cc__0043_55936343034351B0A061-if00
                searchFor = "usb-1a86_USB_Serial"; //Full name (generic arduino nano): usb-1a86_USB_Serial-if00-port0
                return GetPortNameForDevice(searchFor); 
            }
            else
            {
                throw new Exception(String.Format("Operation system {0} is not supported", Environment.OSVersion.Platform));
            }
            return null;
        }
    }*/


    static void Main(string[] args)
    {
        
        Console.WriteLine( "   Platform: {0,-15} Version: {1}",
            Environment.OSVersion.Platform, Environment.OSVersion.Version );
        
        GPSManager gPSManager = new GPSManager();
        gPSManager.StartRecording();

        ConsoleHelper.PK("Press a key to end");

        gPSManager.StopRecording();
    }
}
