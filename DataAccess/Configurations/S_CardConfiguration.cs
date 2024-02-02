using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entitys.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configurations
{
    public class S_CardConfiguration : IEntityTypeConfiguration<S_Card>
    {
        public void Configure(EntityTypeBuilder<S_Card> builder)
        {
            builder.Property(sc => sc.StudentId).HasColumnName("Id_Student");
            builder.Property(sc => sc.BookId).HasColumnName("Id_Book");
            builder.Property(sc => sc.LibId).HasColumnName("Id_Lib");

            builder.Property(sc=>sc.DateOut).HasColumnType("datetime").IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(sc=>sc.DateIn).HasColumnType("datetime").IsRequired(false);
        }
    }
}
