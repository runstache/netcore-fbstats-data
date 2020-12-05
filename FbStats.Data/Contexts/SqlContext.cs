using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using FbStats.Data.DataObjects;
using FbStats.Data.Configuration;

namespace FbStats.Data.Contexts
{
    public class SqlContext : DbContext
    {
        public SqlContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        private string connectionString;

        public DbSet<GameStat> Stats { get; set; }
        public DbSet<Quarterback> Quarterbacks { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<ScheduleItem> ScheduleItems { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration<Team>(new TeamConfiguration());
            modelBuilder.ApplyConfiguration<ScheduleItem>(new ScheduleItemConfiguration());
            modelBuilder.ApplyConfiguration<Quarterback>(new QuaterbackConfiguration());
            modelBuilder.ApplyConfiguration<GameStat>(new GameStatConfiguration());
        }

    }
}
