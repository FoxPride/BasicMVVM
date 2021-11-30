using BasicMVVM.Core.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace BasicMVVM.Core.ViewModels
{
    /// <summary>
    ///     The view model locator. Retrieves view models from host container.
    /// </summary>
    public class ViewModelLocator
    {
        public MainWindowViewModel MainWindowModel => HostHelper.Host.Services.GetRequiredService<MainWindowViewModel>();

        public HomeViewModel HomeViewModel => HostHelper.Host.Services.GetRequiredService<HomeViewModel>();

        public ChangeTitleViewModel ChangeTitleViewModel => HostHelper.Host.Services.GetRequiredService<ChangeTitleViewModel>();
    }
}