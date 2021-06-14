// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ViewModelLocator.cs" company="Monosnap Inc.">
//   Andrew Baiderin © 2021
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DefaultLibrary.ViewModels
{
    using Microsoft.Toolkit.Mvvm.DependencyInjection;

    /// <summary>
    /// The view model locator. Retrieves view models from IoC container.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Retrieves main window view model.
        /// </summary>
        public MainWindowViewModel MainWindowModel => Ioc.Default.GetService<MainWindowViewModel>();

        /// <summary>
        /// Retrieves second window view model.
        /// </summary>
        public SecondWindowViewModel SecondWindowModel => Ioc.Default.GetService<SecondWindowViewModel>();
    }
}