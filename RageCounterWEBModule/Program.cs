﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace RageCounterWEBModule
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            string teste = "oifjdoisjfiodsj";
            //eu te odeio pok
            CreateWebHostBuilder(args).Build().Run();
            string teste2 = "OIJoifjdsoifsd";
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
