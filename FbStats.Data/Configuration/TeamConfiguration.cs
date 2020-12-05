using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using FbStats.Data.DataObjects;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FbStats.Data.Configuration
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.ToTable("tblTeams");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Code).IsRequired().HasColumnName("TeamCode").HasColumnType("varchar(5)").HasMaxLength(5);
            builder.Property(c => c.Id).IsRequired().HasColumnName("Id").HasColumnType("int").UseIdentityColumn();
            builder.Property(c => c.Name).IsRequired().HasColumnName("TeamName").HasColumnType("varchar(150)").HasMaxLength(150);
            builder.Property(c => c.TotalGames).HasColumnName("TotalGames").HasColumnType("int");
        }
    }
}
