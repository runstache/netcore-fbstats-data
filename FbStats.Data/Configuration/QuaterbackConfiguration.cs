using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using FbStats.Data.DataObjects;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FbStats.Data.Configuration
{
    public class QuaterbackConfiguration : IEntityTypeConfiguration<Quarterback>
    {
        public void Configure(EntityTypeBuilder<Quarterback> builder)
        {
            builder.ToTable("tblQuaterbacks");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).IsRequired().HasColumnName("Id").HasColumnType("bigint").UseIdentityColumn();
            builder.Property(c => c.Name).IsRequired().HasColumnName("Name").HasColumnType("varchar(150)").HasMaxLength(150);
            builder.Property(c => c.Qbr).IsRequired().HasColumnName("Qbr").HasColumnType("float");
            builder.Property(c => c.TeamId).IsRequired().HasColumnName("TeamId").HasColumnType("int");
        }
    }
}
