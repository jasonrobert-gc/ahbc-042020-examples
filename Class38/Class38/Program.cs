using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Class38
{
    public class Program
    {
        // Application entry point.  Same as a console application.
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        // Creates the web host to "host" our application.
        // This is an example of an expression bodied method.
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
