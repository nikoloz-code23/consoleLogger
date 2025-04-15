using System;
using System.IO;

namespace ConsoleLogProject
{
    public class FileAppender : IAppender
    {
        public void Print(string log)
        {
            string directory = Directory.GetParent(Environment.CurrentDirectory).ToString();

            StreamWriter outputFile = new StreamWriter(Path.Combine(directory, "output.log"), true);
            outputFile.Write(log);
            outputFile.Close();
        }
    }
}