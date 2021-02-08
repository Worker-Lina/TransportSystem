using System;

namespace Service
{
    public class ConsoleLogger : ILogger
    {
        public void LogInformation(string logMessage)
        {
            var logTime = new DateTime();

            Console.WriteLine($"{logTime.Date} => {logMessage}");
        }
    }
}
