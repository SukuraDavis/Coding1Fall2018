using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace DiscordBotInCSharp.Resources.Database
{
   public class SqliteDbContext : DbContext
   {
        public DbSet<Stone> Stones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder Options)
        {
            string DbLocation = Assembly.GetEntryAssembly().Location.Replace(@"bin\Debug\netcoreapp2.0", @"Data\");
            Options.UseSqlite($"Data Source={DbLocation}Database.sqlite");
        }
   }
}
