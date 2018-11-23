using Discord.WebSocket;

namespace TutDiscordBot.Discord.Entities
{
    public class BotConfig
    {
        public string Token { get; set; }

        public DiscordSocketConfig SocketConfig { get; set; }
    }
}