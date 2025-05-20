using System;
using System.Text;

namespace ConsoleLogProject
{
    public class PersonGenerator
    {
        private string[] firstNames = [
            "John", "Maria", "James", "Lewis", "Peter"
        ];
        
        private string[] lastNames = [
            "Lee", "Smith", "Griffin", "Bond", "Hopps"
        ];

        public string GeneratePerson()
        {
            Random random = new Random();
            return firstNames[random.Next(0, firstNames.Length)] + " " + lastNames[random.Next(0, lastNames.Length)];
        }
    }
}
