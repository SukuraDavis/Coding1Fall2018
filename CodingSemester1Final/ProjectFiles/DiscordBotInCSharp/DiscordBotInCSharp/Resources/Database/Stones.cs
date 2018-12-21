using System.ComponentModel.DataAnnotations;

namespace DiscordBotInCSharp.Resources.Database
{
    
    public class Stone
    {
        [Key]
        public ulong UserId { get; set; }
        public int Amount { get; set; }
    }
}
