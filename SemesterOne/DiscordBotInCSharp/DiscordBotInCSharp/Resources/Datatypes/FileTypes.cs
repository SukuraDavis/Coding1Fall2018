using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordBotInCSharp.Resources.Datatypes
{
   public class Setting
   {
        public string Token { get; set; }
        public ulong Owner { get; set; }
        public List<ulong> Log { get; set; }
        public string Version { get; set; }
        public List<ulong> Banned { get; set; }

   }
}
