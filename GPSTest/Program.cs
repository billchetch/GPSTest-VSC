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
        
        Console.WriteLine( "   Platform: {0,-15} Version: {1}",
            Environment.OSVersion.Platform, Environment.OSVersion.Version );
        

        var configBuilder = new ConfigurationBuilder().AddJsonFile("appsettings.local.json", false);
        var config = configBuilder.Build();

        ChetchDbContext.Config = config;

        using(var context = new SysLogDBContext("gps"))
        {
            foreach(var si in context.SysInfoTable){
                Console.WriteLine(si.DataName);
            }
        }

        /*GPSManager gPSManager = new GPSManager();
        gPSManager.StartRecording();

        ConsoleHelper.PK("Press a key to end");

        gPSManager.StopRecording();*/
    }
}
