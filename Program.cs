using System;

namespace ConsoleLogProject{
    class Program{
        static void Main(string[] args){
            ConsoleLogger consoleLogger = new ConsoleLogger();
            consoleLogger.LogMessage("");
            consoleLogger.LogMessage("This is a test!", LogType.INFO);
            consoleLogger.LogMessage("Shit something went wrong, god forbid I code again...", LogType.ERROR, '#');
            Console.ReadKey();
        }
    }
}