using System.Diagnostics;
using System.Text;
using System.Xml.Linq;
using System.Xml;
using Chetch.GPS;
using Chetch.Messaging;
using Chetch.Utilities;
using System.Runtime.CompilerServices;
using System.CodeDom.Compiler;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Chetch.Database;


namespace GPSTest;

class Program
{
    
    static void Main(string[] args)
    {
        //GPSManager gPSManager = new GPSManager();
        //gPSManager.StartRecording();

        ConsoleHelper.PK("Press a key to start service");
        GPSService.Run(args);
        ConsoleHelper.PK("Press a key to end service");

        //gPSManager.StopRecording();
    }
}
