﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace LoginAPIService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
            //CreateWebHostBuilder(args).UseUrls("http://localhost:6001").Build().Run();

        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

    }
}
