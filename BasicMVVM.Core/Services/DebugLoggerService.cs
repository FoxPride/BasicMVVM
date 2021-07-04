using System.Diagnostics;

using BasicMVVM.Core.Services.Interfaces;

namespace BasicMVVM.Core.Services
{
    /// <summary>
    /// The debug logger service.
    /// </summary>
    public class DebugLoggerService : ILogger
    {
        /// <summary>
        /// Logs inserted text in output window.
        /// </summary>
        /// <param name="text">
        /// The text.
        /// </param>
        public void Log(string text)
        {
            Debug.WriteLine(text);
        }
    }
}