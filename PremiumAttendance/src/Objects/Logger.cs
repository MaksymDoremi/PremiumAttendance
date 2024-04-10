using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumAttendance.Objects
{
    /// <summary>
    /// Logger object, can log messages and errors
    /// </summary>
    public class Logger
    {
        private static readonly object _lock = new object();

        /// <summary>
        /// Writes program logs to file specidied in App.config at "logFilePath"
        /// </summary>
        /// <param name="message">Message to be logged</param>
        /// <param name="error">Marks it as ERROR log</param>
        public static void WriteLog(string message, bool error)
        {
            lock (_lock)
            {
                string logMessage = string.Empty;
                if (!error)
                {
                    logMessage = $"LOG [{DateTime.Now}]: {message}\n";

                }
                else
                {
                    logMessage = $"ERROR [{DateTime.Now}]: {message}\n";
                }

                File.AppendAllText(ConfigurationManager.AppSettings["logFilePath"], logMessage);
            }
        }
    }
}
