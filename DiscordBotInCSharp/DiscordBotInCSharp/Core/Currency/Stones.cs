using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

using Discord;
using Discord.Commands;
using Discord.WebSocket;

using DiscordBotInCSharp.Core.Data;
using DiscordBotInCSharp.Resources.Database;

namespace DiscordBotInCSharp.Core.Currency
{
   public class Stones : ModuleBase<SocketCommandContext>
   {
        //currency/shop place

        [Group("stone"), Alias("stones"), Summary("Group to manage stuff to do with stones")]
        public class StonesGroup : ModuleBase<SocketCommandContext>
        {
            [Command(""), Alias("me", "my"), Summary("Shows all your current stones")]
            public async Task Me(IUser User = null)
            {
                if (User == null)
                    //The user wants to see his/her own stones
                    await Context.Channel.SendMessageAsync($"{Context.User.Username}, you have {Data.Data.GetStones(Context.User.Id)} stones!");
                else
                    await Context.Channel.SendMessageAsync($"{User.Username}, you have {Data.Data.GetStones(User.Id)} stones!");
            }

            [Command("give"), Alias("gift"), Summary("Used to give people stones")]
            public async Task Give(IUser User = null, int Amount = 0)
            {
                //stones give <parameter> 1000
                //stones give @Snow Girl 1000
                //group cmd user amount

                //checks
                //does the user have permission?
                //does the user have enough stones?
                if (User == null)
                {
                    //the executer has not mentioned a user
                    await Context.Channel.SendMessageAsync(":eyes: You didn't mention a user to give the stones to! Please use this syntax: falco!stones give **<@user>** <amount>");
                    return;
                }
                
                //at this point, we made sure that a user has been pinged
                if (User.IsBot)
                {
                    await Context.Channel.SendMessageAsync(":eyes: Bots can't use me, so don't you dare try to give me stones to a bot!");
                    return;
                }

                //at this point, we made sure that a user has been pinged AND that the user is not a bot
                if (Amount == 0)
                {
                    await Context.Channel.SendMessageAsync($"Oh falc------ Ahem, :eyes: You need to specify a valid amount of stones that I need to give to {User.Username}! Please use this syntax: falco!stones give <@user> **<amount>**");
                    return;
                }

                

                //Execution
                //Calculations (games)
                //telling the user what he/she has gotten
                await Context.Channel.SendMessageAsync($":tada: {User.Mention} you have recieved **{Amount}** stones from {Context.User.Username}!");

                //saving the data
                //save the data to the database
                //save a file
                await Data.Data.SaveStones(User.Id, Amount);

                
            }

            [Command("reset"), Summary("resets the user's entire progress. ***MUAH HA HA----*** *I wasn't thinking about anything!*")]
            public async Task Reset(IUser User = null)
            {
                //Checks
                if (User == null)
                {//14:20 
                    await Context.Channel.SendMessageAsync($":eyes: You need to quickly tell me which user you want to reset the stones of before falco walks into the room! For example: falco!stones reset {Context.User.Mention}");
                    return;
                }
                
                if (User.IsBot)
                {
                    await Context.Channel.SendMessageAsync(":eyes: Bots can't use me, so you can't reset the progress of bots! :robot:");
                    return;
                }

                SocketGuildUser User1 = Context.User as SocketGuildUser;
                if (!User1.GuildPermissions.Administrator)
                {
                    await Context.Channel.SendMessageAsync($":eyes: You don't have admisistrator permissions in this discord server! Ask a moderator or the owner to execute this command! ~~***Is it falco...?***~~");
                    return;
                }

                //Execution
                await Context.Channel.SendMessageAsync($"MUAH HA HA HAA!!! {User.Mention}, you have been reset by {Context.User.Username}! This means you have lost all of your stones!");


                //Saving the data
                using ( var DbContext = new SqliteDbContext())
                {
                    DbContext.Stones.RemoveRange(DbContext.Stones.Where(x => x.UserId == User.Id));
                    await DbContext.SaveChangesAsync();
                }
            }
        }
   }
}
