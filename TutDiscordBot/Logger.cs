using System;

namespace TutDiscordBot
{
    public class Logger : ILogger
    {

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}