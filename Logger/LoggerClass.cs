using System;
using System.IO;

/**
 * Basic logger class that can be utilized as a parent-class for future loggers.
 * @author ltrlynick
 */

namespace ConsoleLogProject
{
    public class ConsoleLogger
    {
        /**
         * This will be the time at which the message has been called from.
         */
        private string time = DateTime.Now.ToLongTimeString();
        private static string PatternLayout = "[{type} {time}]: {message}{newLine}";
        private static List<IAppender> APPENDERS = new List<IAppender>() { new FileAppender(), new ConsoleAppender() };

        /**
         * @param message The text that you want to display.
         * @param type The log type of the message, DEBUG by default.
         * @param newLine By default, '\n', however, you can choose what symbol you want to be displayed at the end of the string.
         */
        public void LogMessage(string message, LogType type = LogType.DEBUG, char newLine = '\n')
        {
            try
            {
                /**
                 * Generic print method that takes logging level along with the message.
                 * 
                 * @param message
                 * @throws Will throw an error if message is empty, null or a white-space.
                 */
                if (String.IsNullOrEmpty(message) || String.IsNullOrWhiteSpace(message)) 
                { 
                    throw new Exception("String can't be Null, Empty or a Whitespace."); 
                }
                APPENDERS.ForEach(appender => appender.Print(ConstructMessage(message, type, newLine)));
            }
            catch (Exception e) 
            {
                Console.WriteLine($"[EXCEPTION ERROR]: {e.Message}");
            }
        }

        private string ConstructMessage(string message, LogType type, char newLine)
        {
            string Result = PatternLayout;
            Result = Result.Replace("{type}", type.ToString());
            Result = Result.Replace("{time}", time);
            Result = Result.Replace("{message}", message);
            Result = Result.Replace("{newLine}", newLine.ToString());
            return Result;
        }
    }
}
