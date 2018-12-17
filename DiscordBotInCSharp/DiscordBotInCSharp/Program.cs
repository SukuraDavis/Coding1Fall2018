using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Linq;

using Newtonsoft.Json;

using Discord;
using Discord.WebSocket;
using Discord.Commands;

using DiscordBotInCSharp.Resources.Datatypes;
using DiscordBotInCSharp.Resources.Settings;

namespace DiscordBotInCSharp
{
    class Program
    {
        private DiscordSocketClient Client;
        private CommandService Commands;


        static void Main(string[] args)
        => new Program().MainAsync().GetAwaiter().GetResult();

        private async Task MainAsync()
        {
            string JSON = "";
            string SettingsLocation = Assembly.GetEntryAssembly().Location.Replace(@"bin\Debug\netcoreapp2.1", @"Data\Settings.json");
            using (var Stream = new FileStream(SettingsLocation, FileMode.Open, FileAccess.Read))
            using (var ReadSettings = new StreamReader(Stream))
            {
                JSON = ReadSettings.ReadToEnd();
            }


            Setting Settings = JsonConvert.DeserializeObject<Setting>(JSON);
            ESettings.Banned = Settings.Banned;
            ESettings.Log = Settings.Log;
            ESettings.Owner = Settings.Owner;
            ESettings.Token = Settings.Token;
            ESettings.Version = Settings.Version;


            Client = new DiscordSocketClient(new DiscordSocketConfig
            {
                LogLevel = LogSeverity.Info
            });

            //help help HELP heLp
            Commands = new CommandService(new CommandServiceConfig
            {
                CaseSensitiveCommands = true,
                DefaultRunMode = RunMode.Async,
                LogLevel = LogSeverity.Debug

            });

            Client.MessageReceived += Client_MessageReceived;
            await Commands.AddModulesAsync(Assembly.GetEntryAssembly());

            Client.Ready += Client_Ready;
            Client.Log += Client_Log;

            string Token = "";
            using (var Stream = new FileStream((Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)).Replace(@"bin\Debug\netcoreapp2.0", @"Data\Token.txt"), FileMode.Open, FileAccess.Read))
            using (var ReadToken = new StreamReader(Stream))
            {
                Token = ReadToken.ReadToEnd();
            }
            await Client.LoginAsync(TokenType.Bot, Token);
            await Client.StartAsync();

            await Task.Delay(-1);
        }

        private async Task Client_Log(LogMessage Message)
        {
           Console.WriteLine($"{DateTime.Now} at {Message.Source}] {Message.Message}");
            try
            {
                SocketGuild Guild = Client.Guilds.Where(x => x.Id == ESettings.Log[0]).FirstOrDefault();
                SocketTextChannel Channel = Guild.Channels.Where(x => x.Id == ESettings.Log[1]).FirstOrDefault() as SocketTextChannel;
                await Channel.SendMessageAsync($"{DateTime.Now} at {Message.Source}] {Message.Message}");
            } catch
            {

            }
        }

        private async Task Client_Ready()
        {
            //Name of bot game in ""
            //(bot name: The Des Bot)
            await Client.SetGameAsync("Des-Kuun DISCO", "http://www.google.com/", StreamType.NotStreaming);
        }

        private async Task Client_MessageReceived(SocketMessage MessageParam)
        {
            var Message = MessageParam as SocketUserMessage;
            var Context = new SocketCommandContext(Client, Message);

            if (Context.Message == null || Context.Message.Content == "") return;
            if (Context.User.IsBot) return;

            int ArgPos = 0;

            if (!(Message.HasStringPrefix("falco!", ref ArgPos) || Message.HasMentionPrefix(Client.CurrentUser, ref ArgPos))) return;

            var Result = await Commands.ExecuteAsync(Context, ArgPos);
            if (!Result.IsSuccess)
                Console.WriteLine($"{DateTime.Now} at Commands] Something went wrong with executing a command. Text: {Context.Message.Content} | Error: {Result.ErrorReason}");

        }
        
    }
}
