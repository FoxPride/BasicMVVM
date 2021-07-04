namespace BasicMVVM.Core.Services.Interfaces
{
    /// <summary>
    /// The Logger interface.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Method to log message.
        /// </summary>
        /// <param name="text">
        /// The text.
        /// </param>
        void Log(string text);
    }
}