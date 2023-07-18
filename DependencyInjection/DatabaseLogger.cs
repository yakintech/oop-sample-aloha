using System;
namespace DependencyInjection
{
    public class DatabaseLogger : ILogger
    {

        public void PrintLog()
        {
            Console.WriteLine("Database logger...");
        }
    }
}

