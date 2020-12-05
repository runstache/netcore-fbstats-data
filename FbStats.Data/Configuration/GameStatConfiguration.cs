using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using FbStats.Data.DataObjects;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FbStats.Data.Configuration
{
    public class GameStatConfiguration : IEntityTypeConfiguration<GameStat>
    {
        public void Configure(EntityTypeBuilder<GameStat> builder)
        {
            builder.ToTable("tblGameStats");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.AvgPerCompletion).IsRequired().HasColumnName("AvgPerCompletion").HasColumnType("float");
            builder.Property(c => c.AvgPerRush).IsRequired().HasColumnName("AvgPerRush").HasColumnType("float");
            builder.Property(c => c.ConversionRate).IsRequired().HasColumnName("ConversionRate").HasColumnType("float");
            builder.Property(c => c.FieldGoals).IsRequired().HasColumnName("FieldGoals").HasColumnType("int");
            builder.Property(c => c.ForcedFumbles).IsRequired().HasColumnName("ForcedFumbles").HasColumnType("int");
            builder.Property(c => c.Id).IsRequired().HasColumnName("Id").HasColumnType("bigint").UseIdentityColumn();
            builder.Property(c => c.Interception).IsRequired().HasColumnName("Interception").HasColumnType("float");
            builder.Property(c => c.OpponentId).IsRequired().HasColumnName("OpponentId").HasColumnType("int");
            builder.Property(c => c.PassAttempts).IsRequired().HasColumnName("PassAttempts").HasColumnType("int");
            builder.Property(c => c.PassCompleted).IsRequired().HasColumnName("PassCompleted").HasColumnType("int");
            builder.Property(c => c.PassOverFifteen).IsRequired().HasColumnName("PassOverFifteen").HasColumnType("int");
            builder.Property(c => c.PassYards).IsRequired().HasColumnName("PassYards").HasColumnType("int");
            builder.Property(c => c.Penalties).IsRequired().HasColumnName("Penalties").HasColumnType("int");
            builder.Property(c => c.PenaltyYards).IsRequired().HasColumnName("PenaltyYards").HasColumnType("int");
            builder.Property(c => c.PointsAllowed).IsRequired().HasColumnName("PointsAllowed").HasColumnType("int");
            builder.Property(c => c.PointsScored).IsRequired().HasColumnName("PointsScored").HasColumnType("int");
            builder.Property(c => c.Punts).IsRequired().HasColumnName("Punts").HasColumnType("int");
            builder.Property(c => c.QuarterbackId).IsRequired().HasColumnName("QuarterbackId").HasColumnType("int");
            builder.Property(c => c.ReturnYards).IsRequired().HasColumnName("ReturnYards").HasColumnType("int");
            builder.Property(c => c.RushAttempts).IsRequired().HasColumnName("RushAttempts").HasColumnType("int");
            builder.Property(c => c.RushOverTen).IsRequired().HasColumnName("RushOverTen").HasColumnType("int");
            builder.Property(c => c.RushYards).IsRequired().HasColumnName("RushYards").HasColumnType("int");
            builder.Property(c => c.Sack).IsRequired().HasColumnName("Sack").HasColumnType("float");
            builder.Property(c => c.TackleForLoss).IsRequired().HasColumnName("TackleForLoss").HasColumnType("float");
            builder.Property(c => c.TeamId).IsRequired().HasColumnName("TeamId").HasColumnType("int");
            builder.Property(c => c.TotalPlays).IsRequired().HasColumnName("TotalPlays").HasColumnType("int");
            builder.Property(c => c.Touchdowns).IsRequired().HasColumnName("Touchdowns").HasColumnType("int");
            builder.Property(c => c.Turnovers).IsRequired().HasColumnName("Turnovers").HasColumnType("int");
            builder.Property(c => c.WeekNumber).IsRequired().HasColumnName("WeekNumber").HasColumnType("int");

        }
    }
}
