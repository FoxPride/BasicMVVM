using BasicMVVM.Core.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace BasicMVVM.Core.ViewModels
{
    /// <summary>
    ///     The view model locator. Retrieves view models from host container.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        ///     Retrieves main window view model.
        /// </summary>
        public MainWindowViewModel MainWindowModel => HostHelper.Host.Services.GetRequiredService<MainWindowViewModel>();

        /// <summary>
        ///     Retrieves second window view model.
        /// </summary>
        public SecondWindowViewModel SecondWindowModel => HostHelper.Host.Services.GetRequiredService<SecondWindowViewModel>();
    }
}