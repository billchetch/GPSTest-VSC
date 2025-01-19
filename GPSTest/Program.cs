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
        
        GPSManager gPSManager = new GPSManager();
        gPSManager.StartRecording();

        ConsoleHelper.PK("Press a key to end");

        gPSManager.StopRecording();
    }
}
