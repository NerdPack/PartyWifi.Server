﻿using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace PartyWifi.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseUrls("http://*:80")
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
