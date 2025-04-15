using System;

namespace ConsoleLogProject
{ 
    public interface IAppender
    {
        public void Print(string log);
    }
}