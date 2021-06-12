using System.Diagnostics;
using DefaultLibrary.Services.Interfaces;

namespace DefaultLibrary.Services
{
    public class DebugLoggerService : ILogger
    {
        public void Log(string text) => Debug.WriteLine(text);
    }
}
