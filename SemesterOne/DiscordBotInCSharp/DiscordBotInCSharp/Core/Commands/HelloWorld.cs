using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Discord;
using Discord.Commands;

namespace DiscordBotInCSharp.Core.Commands
{
    public class HelloWorld : ModuleBase<SocketCommandContext>
    {
        [Command("hello"), Alias("hello", "hi"), Summary("Hello command")]
        public async Task Screee()
        {
            await Context.Channel.SendMessageAsync("MAFIA MANIA & KNUCKLES! HELLOOOOOOO");

        }

        [Command("embed"), Summary("Embed text command")]
        public async Task Embed([Remainder]string Input = "none")
        {
            EmbedBuilder Embed = new EmbedBuilder();
            Embed.WithAuthor("Text embed", Context.User.GetAvatarUrl());
            Embed.WithColor(40, 200, 150);
            Embed.WithFooter("The footer of the embed", Context.Guild.Owner.GetAvatarUrl());
            Embed.WithDescription("This is a ''dummy'' description, with a cool link.\n" +
                "[Falco ;)](https://goo.gl/images/M1J5vZ)");

            Embed.AddInlineField("User input:", Input);

            await Context.Channel.SendMessageAsync("", false, Embed.Build());
        }
   }
}
