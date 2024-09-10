using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Logger
{
    internal class Logger
    {

        // Log the message in the document
        public static void log_message(string fileName, string message, Severity severity)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string logMessage = $"[{timestamp}] [{severity}] {message}";
            using (StreamWriter writer = new StreamWriter(fileName, append: true))
            {
                writer.WriteLine(logMessage);
            }
            LogToConsole(logMessage, severity);
        }


        // Print the message in the console with its respective color based on the severity
        private static void LogToConsole(string message, Severity severity)
        {
            Console.ForegroundColor = severity switch
            {
                Severity.INFO => ConsoleColor.Cyan,
                Severity.WARNING => ConsoleColor.Yellow,
                Severity.CRITICAL => ConsoleColor.Red,
                _ => Console.ForegroundColor
            };

            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
