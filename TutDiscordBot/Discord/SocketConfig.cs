using Discord;
using Discord.WebSocket;

namespace TutDiscordBot.Discord
{
    public static class SocketConfig
    {
        public static DiscordSocketConfig GetDefualt()
        {
            return new DiscordSocketConfig()
            {
                LogLevel = LogSeverity.Verbose
            };
        }

        public static DiscordSocketConfig GetNew()
        {
            return new DiscordSocketConfig();
        }
    }
}