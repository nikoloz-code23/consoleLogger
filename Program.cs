using System;

namespace ConsoleLogProject{
    class Program{
        static void Main(string[] args){
            ConsoleLogger consoleLogger = new ConsoleLogger();
            consoleLogger.LogMessage("");
            consoleLogger.LogMessage("This is a test!", LogType.INFO);
            try
            {
                throw new Exception("Something went wrong :(");
            }
            catch (Exception e)
            {
                consoleLogger.LogMessage(e.Message, LogType.ERROR);
            }

            Console.ReadKey();
        }
    }
}