using MyApp.Core.Interfaces;
using System;

namespace MyApp.Infrastructure
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string input)
        {
            Console.WriteLine(input);
        }
    }
}
