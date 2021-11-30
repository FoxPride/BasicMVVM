using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;

namespace BasicMVVM.WPF
{
    /// <summary>   Main startup class for this application. </summary>
    public static class Program
    {
        /// <summary>   Main entry-point for this application. </summary>
        [STAThread]
        public static void Main()
        {
            var app = new App();
            app.InitializeComponent();
            app.Run();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Creates host builder. </summary>
        ///
        /// <param name="Args"> The arguments. </param>
        ///
        /// <returns>   The new host builder. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static IHostBuilder CreateHostBuilder(string[] Args) =>
            Host.CreateDefaultBuilder(Args)
               .UseContentRoot(App.CurrentDirectory)
               .ConfigureAppConfiguration((host, cfg) => cfg
                   .SetBasePath(App.CurrentDirectory)
                   .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                   .AddEnvironmentVariables())
               .UseSerilog((hostingContext, loggerConfiguration) => loggerConfiguration
                   .ReadFrom.Configuration(hostingContext.Configuration))
               .ConfigureServices(App.ConfigureServices);
    }
}