// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Registrar.cs" company="Monosnap Inc.">
//   Andrew Baiderin © 2021
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DefaultMVVM.Helpers
{
    using DefaultLibrary.Services;
    using DefaultLibrary.Services.Interfaces;
    using DefaultLibrary.ViewModels;

    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// A <see langword="class"/> with helper methods to register services via dependency injection.
    /// </summary>
    internal static class Registrar
    {
        /// <summary>
        /// Registers services of the app.
        /// </summary>
        /// <param name="services">
        /// Specifies the contract for a collection of service descriptors.
        /// </param>
        /// <returns>
        /// The <see cref="IServiceCollection"/>.
        /// </returns>
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<ILogger, DebugLoggerService>();

            return services;
        }

        /// <summary>
        /// Registers view models of the app.
        /// </summary>
        /// <param name="services">
        /// The services.
        /// </param>
        /// <returns>
        /// The <see cref="IServiceCollection"/>.
        /// </returns>
        public static IServiceCollection RegisterViewModels(this IServiceCollection services)
        {
            services.AddSingleton<MainWindowViewModel>();
            services.AddSingleton<SecondWindowViewModel>();

            return services;
        }
    }
}