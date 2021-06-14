// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DebugLoggerService.cs" company="Monosnap Inc.">
//   Andrew Baiderin © 2021
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DefaultLibrary.Services
{
    using System.Diagnostics;

    using DefaultLibrary.Services.Interfaces;

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