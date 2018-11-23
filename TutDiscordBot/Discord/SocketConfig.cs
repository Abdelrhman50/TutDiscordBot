using Discord.WebSocket;

namespace TutDiscordBot.Discord
{
    public static class SocketConfig
    {
        public static DiscordSocketConfig GetDefualt()
        {
            return new DiscordSocketConfig();
        }

        public static DiscordSocketConfig Generete()
        {
            return new DiscordSocketConfig()
            {

            };
        }
    }
}