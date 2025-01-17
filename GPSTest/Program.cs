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
    static void Main(string[] args)
    {
        
        Console.WriteLine( "   Platform: {0,-15} Version: {1}",
            Environment.OSVersion.Platform, Environment.OSVersion.Version );

        //String searchFor = "Arduino";
        //String searchKey =  "USB Vendor Name";
        
        String searchFor = "u-blox 7 - GPS/GNSS Receiver";
        String searchKey = "USB Product Name";
        String portName = Chetch.Utilities.SerialPortDevice.GetPortNameForDevice(searchFor, searchKey);

        //String portName = "/dev/cu.usbmodem1401"; //apple
        //String portName = "/dev/ttyACM0"; //raspberry pi
        
        ConsoleHelper.PK(String.Format("Press a key to connect {0}...", portName));
        
        GPSDevice device = new GPSDevice(portName);

        try
        {
            device.StartListening();
            ConsoleHelper.PK("Press a key to end");
            device.StopListening();
        }
        catch (Exception e){
            Console.WriteLine(e.Message);
        }
    }
}
