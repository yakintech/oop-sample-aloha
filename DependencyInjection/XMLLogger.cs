using System;
namespace DependencyInjection
{
    public class XMLLogger : ILogger
    {
        public void PrintLog()
        {
            Console.WriteLine("XML logger...");
        }
    }
}

