using $ext_safeprojectname$.Core.Helpers;
using $ext_safeprojectname$.Core.Services.Interfaces;
using $ext_safeprojectname$.WPF.Helpers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;

namespace $ext_safeprojectname$.WPF
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// Provides application-specific behavior to supplement the default <see cref="Application" />
    /// class.
    /// </summary>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public sealed partial class App
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class. This is the first line of authored
        /// code executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public App()
        {
            InitializeComponent();
            HostHelper.Host = Program.CreateHostBuilder(Environment.GetCommandLineArgs()).Build();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Overridden startup method for registering services and marking that the application is no
        /// longer in designer mode.
        /// </summary>
        ///
        /// <param name="e">    Contains the arguments for the Startup event. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        protected override async void OnStartup(StartupEventArgs e)
        {
            await HostHelper.Host.StartAsync().ConfigureAwait(false);

            base.OnStartup(e);

            HostHelper.Host.Services.GetRequiredService<IUpdater>().StartActions();

            DesignerProperties.IsDesignMode = false;

            LocalizationHelper.LoadLanguages();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Overridden exit method to stop and dispose host. </summary>
        ///
        /// <param name="e">    Contains the arguments for the Exit event. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        protected override async void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);

            await HostHelper.Host.StopAsync().ConfigureAwait(false);
            HostHelper.Host.Dispose();
            HostHelper.Host = null;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Configures services with a help of <see cref="Registrar"/> class. </summary>
        ///
        /// <param name="host">     The host. </param>
        /// <param name="services"> The services. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static void ConfigureServices(HostBuilderContext host, IServiceCollection services) => services
            .RegisterServices()
            .RegisterViewModels()
            .RegisterStores();

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets current working directory for app. </summary>
        ///
        /// <value> The pathname of the current directory. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static string CurrentDirectory => DesignerProperties.IsDesignMode
            ? Path.GetDirectoryName(GetSourceCodePath())
            : Environment.CurrentDirectory;

        private static string GetSourceCodePath([CallerFilePath] string path = null) => path;
    }
}