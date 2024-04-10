using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace Bot
{
    internal class Bot
    {
        private static readonly string Key;

        private static TelegramBotClient client;
        static Bot()
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets<Program>()
                .Build();
            Key = config["Key"];
        }

        public static async Task<TelegramBotClient> Get()
        {
            if (client != null)
            {
                return client;
            }
            client = new TelegramBotClient(Key);

            return client;
        }
    }
}
