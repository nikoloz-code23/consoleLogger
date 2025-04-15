using System;

namespace ConsoleLogProject
{
    public class ConsoleAppender : IAppender
    {
        public void Print(string log)
        {
            Console.Write(log);
        }
    }
}