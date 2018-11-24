using System;
using TutDiscordBot.Discord;
using TutDiscordBot.Discord.Entities;

namespace TutDiscordBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Unity.RegisterType();
            Console.WriteLine("Hello World!");

            var discordBotConfig = new BotConfig()
            {
                Token = "ABD",
                SocketConfig = SocketConfig.GetDefualt()
            };

        }

    }
}
