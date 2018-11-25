using System;
using System.Threading.Tasks;
using TutDiscordBot.DataStorage;
using TutDiscordBot.Discord;
using TutDiscordBot.Discord.Entities;

namespace TutDiscordBot
{
    class Program
    {
        private static async Task Main()
        {
            
            Unity.RegisterType();
            Console.WriteLine("Hello World!");

            var storage = Unity.Resolve<IDataStorage>();
            var connection = Unity.Resolve<Connection>();
            

            await connection.ConnectionAsync(new BotConfig
            {
                Token = storage.RestoreObject<string>("Config/BotToken"),
            });


            
            
            Console.ReadKey();

        }

    }
}
