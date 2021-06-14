// --------------------------------------------------------------------------------------------------------------------
// <copyright file="App.xaml.cs" company="Monosnap Inc.">
//   Andrew Baiderin © 2021
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DefaultMVVM
{
    using System.Windows;

    using DefaultLibrary.Helpers;

    using DefaultMVVM.Helpers;

    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Toolkit.Mvvm.DependencyInjection;

    /// <summary>
    ///     Provides application-specific behavior to supplement the default <see cref="Application" /> class.
    /// </summary>
    public sealed partial class App
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class.
        /// This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Overridden startup method for registering services and marking that the application is no longer in designer mode.
        /// </summary>
        /// <param name="e">
        /// Contains the arguments for the Startup event.
        /// </param>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Ioc.Default.ConfigureServices(
                new ServiceCollection().RegisterViewModels().RegisterServices().BuildServiceProvider());

            DesignerProperties.IsDesignMode = false;
        }
    }
}