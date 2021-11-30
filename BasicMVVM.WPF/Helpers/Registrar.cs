using BasicMVVM.Core.Services.Interfaces;
using BasicMVVM.Core.ViewModels;
using BasicMVVM.Windows.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BasicMVVM.WPF.Helpers
{
    /// <summary>
    ///     A <see langword="class" /> with helper methods to register services via dependency injection.
    /// </summary>
    internal static class Registrar
    {
        /// <summary>
        ///     Registers services of the app.
        /// </summary>
        /// <param name="services">
        ///     Specifies the contract for a collection of service descriptors.
        /// </param>
        /// <returns>
        ///     The <see cref="IServiceCollection" />.
        /// </returns>
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<IUpdater, SquirrelUpdaterService>();

            return services;
        }

        /// <summary>
        ///     Registers view models of the app.
        /// </summary>
        /// <param name="services">
        ///     The services.
        /// </param>
        /// <returns>
        ///     The <see cref="IServiceCollection" />.
        /// </returns>
        public static IServiceCollection RegisterViewModels(this IServiceCollection services)
        {
            services.AddSingleton<MainWindowViewModel>();
            services.AddSingleton<HomeViewModel>();
            services.AddSingleton<ChangeTitleViewModel>();

            return services;
        }
    }
}