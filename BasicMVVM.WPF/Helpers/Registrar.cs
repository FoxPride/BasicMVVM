using $ext_safeprojectname$.Core.Services.Interfaces;
using $ext_safeprojectname$.Core.Stores;
using $ext_safeprojectname$.Core.ViewModels;
using $ext_safeprojectname$.Windows.Services;
using Microsoft.Extensions.DependencyInjection;

namespace $ext_safeprojectname$.WPF.Helpers
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// A <see langword="class" /> with helper methods to register services via dependency injection.
    /// </summary>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    internal static class Registrar
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Registers services of the app. </summary>
        ///
        /// <param name="services"> Specifies the contract for a collection of service descriptors. </param>
        ///
        /// <returns>   The <see cref="IServiceCollection" />. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<IUpdater, SquirrelUpdaterService>();

            return services;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Registers view models of the app. </summary>
        ///
        /// <param name="services"> The services. </param>
        ///
        /// <returns>   The <see cref="IServiceCollection" />. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static IServiceCollection RegisterViewModels(this IServiceCollection services)
        {
            services.AddSingleton<MainWindowViewModel>();
            services.AddSingleton<HomeViewModel>();
            services.AddSingleton<ChangeTitleViewModel>();

            return services;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Registers stores of the app. </summary>
        ///
        /// <param name="services"> The services. </param>
        ///
        /// <returns>   The <see cref="IServiceCollection" />. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static IServiceCollection RegisterStores(this IServiceCollection services)
        {
            services.AddSingleton<NavigationStore>();

            return services;
        }
    }
}