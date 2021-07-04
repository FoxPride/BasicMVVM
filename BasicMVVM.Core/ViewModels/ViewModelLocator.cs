using Microsoft.Toolkit.Mvvm.DependencyInjection;

namespace BasicMVVM.Core.ViewModels
{
    /// <summary>
    ///     The view model locator. Retrieves view models from IoC container.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        ///     Retrieves main window view model.
        /// </summary>
        public MainWindowViewModel MainWindowModel => Ioc.Default.GetService<MainWindowViewModel>();

        /// <summary>
        ///     Retrieves second window view model.
        /// </summary>
        public SecondWindowViewModel SecondWindowModel => Ioc.Default.GetService<SecondWindowViewModel>();
    }
}