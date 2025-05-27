using System;
using System.IO;

namespace ConsoleLogProject{
    class Program{
        static void Main(string[] args){
            ConsoleLogger consoleLogger = new ConsoleLogger();
            PersonGenerator personGenerator = new PersonGenerator();

            string person1 = personGenerator.GeneratePerson();
            string person2 = personGenerator.GeneratePerson();
            string person3 = personGenerator.GeneratePerson();
            string person4 = personGenerator.GeneratePerson();
            string person5 = personGenerator.GeneratePerson();
            string person6 = personGenerator.GeneratePerson();

            consoleLogger.LogMessage(person1, LogType.TRACE);
            consoleLogger.LogMessage(person2, LogType.TRACE);
            consoleLogger.LogMessage(person3, LogType.TRACE);
            consoleLogger.LogMessage(person4, LogType.TRACE);
            consoleLogger.LogMessage(person5, LogType.TRACE);
            consoleLogger.LogMessage(person6, LogType.TRACE);

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