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
    sealed partial class App
    {
        /// <summary>
        ///     Initializes the singleton application object. This is the first line of authored code
        ///     executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Ioc.Default.ConfigureServices(
                new ServiceCollection().RegisterViewModels().RegisterServices().BuildServiceProvider());

            DesignerProperties.IsDesignMode = false;
        }
    }
}