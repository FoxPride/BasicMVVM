namespace DefaultMVVM.Helpers
{
    using DefaultLibrary.Services;
    using DefaultLibrary.Services.Interfaces;
    using DefaultLibrary.ViewModels;

    using Microsoft.Extensions.DependencyInjection;

    internal static class Registrar
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<ILogger, DebugLoggerService>();

            return services;
        }

        public static IServiceCollection RegisterViewModels(this IServiceCollection services)
        {
            services.AddSingleton<MainWindowViewModel>();

            return services;
        }
    }
}