using DefaultLibrary.Services;
using DefaultLibrary.Services.Interfaces;
using DefaultLibrary.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace DefaultMVVM.Helpers
{
    internal static class Registrar
    {
        public static IServiceCollection RegisterViewModels(this IServiceCollection services)
        {
            services.AddSingleton<MainWindowViewModel>();

            return services;
        }

        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<ILogger, DebugLoggerService>();

            return services;
        }
    }
}
