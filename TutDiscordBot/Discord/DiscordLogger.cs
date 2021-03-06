﻿using System.Threading.Tasks;
using Discord;

namespace TutDiscordBot.Discord
{
    public class DiscordLogger
    {

        private readonly ILogger _logger;
        public DiscordLogger(ILogger logger)
        {
            _logger = logger;
        }


        public Task Log(LogMessage logMsg) 
        {
            _logger.Log(logMsg.Message);
            return Task.CompletedTask;
            
        }

       
    }
}