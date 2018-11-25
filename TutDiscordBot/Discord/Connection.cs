using System.Threading.Tasks;
using Discord.WebSocket;
using TutDiscordBot.Discord.Entities;

namespace TutDiscordBot.Discord
{
    public class Connection
    {
        private readonly DiscordSocketClient _client;

        private readonly DiscordLogger _logger;

        public Connection(DiscordLogger logger, DiscordSocketClient client)
        {
            _logger = logger;
            _client = client;

        }

        public async Task ConnectionAsync(BotConfig config)
        {            
             _client.Log += _logger.Log;
        }
    }
}