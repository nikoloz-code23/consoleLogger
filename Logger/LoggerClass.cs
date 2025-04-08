using System;

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
        string time = DateTime.Now.ToLongTimeString();

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
                Console.Write($"[{type} {time}]: {message}{newLine}");
            }
            catch (Exception e) 
            {
                Console.WriteLine($"[EXCEPTION ERROR]: {e.Message}");
            }
        }
    }
}
