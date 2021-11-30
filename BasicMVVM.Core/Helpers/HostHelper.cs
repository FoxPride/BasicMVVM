using Microsoft.Extensions.Hosting;

namespace BasicMVVM.Core.Helpers
{
    /// <summary>   A helper <see langword="class"/> for sharing host of the app. </summary>
    public static class HostHelper
    {
        /// <summary>   Provides host for application where all DI happens. </summary>
        public static IHost Host;
    }
}