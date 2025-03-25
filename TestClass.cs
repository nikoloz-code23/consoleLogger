using System;

namespace ConsoleLogProject
{
    public enum LogType
    {
        DEBUG,
        INFO,
        ERROR,
    }

    public class ConsoleLogger
    {
        string time = DateTime.Now.ToLongTimeString();
        public void LogMessage(string message, LogType type = LogType.DEBUG, char newLine = '\n')
        {
            try
            {
                if (String.IsNullOrEmpty(message) || String.IsNullOrWhiteSpace(message)) 
                { 
                    throw new Exception("String can't be Null, Empty or a Whitespace."); 
                }
                Console.Write($"[{type} {time}]: {message}{newLine}");
            }
            catch (Exception e) 
            {
                Console.WriteLine($"[EXCEPTION ERROR]: {e.ToString()}");
            }
        }
    }
}
