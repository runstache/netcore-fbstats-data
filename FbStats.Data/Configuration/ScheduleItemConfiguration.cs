using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using FbStats.Data.DataObjects;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FbStats.Data.Configuration
{
    public class ScheduleItemConfiguration : IEntityTypeConfiguration<ScheduleItem>
    {
        public void Configure(EntityTypeBuilder<ScheduleItem> builder)
        {
            builder.ToTable("tblSchedule");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.HomeTeamId).IsRequired().HasColumnName("HomeTeamId").HasColumnType("int");
            builder.Property(c => c.Id).IsRequired().HasColumnName("Id").HasColumnType("bigint").UseIdentityColumn();
            builder.Property(c => c.VisitorTeamId).IsRequired().HasColumnName("VisitorTeamId").HasColumnType("int");
            builder.Property(c => c.WeekNumber).IsRequired().HasColumnName("WeekNumber").HasColumnType("int");
            builder.Property(c => c.YearValue).IsRequired().HasColumnName("YearValue").HasColumnType("int");
        }
    }
}
