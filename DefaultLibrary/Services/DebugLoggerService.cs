namespace DefaultLibrary.Services
{
    using System.Diagnostics;

    using DefaultLibrary.Services.Interfaces;

    public class DebugLoggerService : ILogger
    {
        public void Log(string text)
        {
            Debug.WriteLine(text);
        }
    }
}