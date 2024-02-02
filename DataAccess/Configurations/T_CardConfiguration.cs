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
    public class T_CardConfiguration : IEntityTypeConfiguration<T_Card>
    {
        public void Configure(EntityTypeBuilder<T_Card> builder)
        {
            builder.Property(sc => sc.TeacherId).HasColumnName("Id_Teacher");
            builder.Property(sc => sc.BookId).HasColumnName("Id_Book");
            builder.Property(sc => sc.LibId).HasColumnName("Id_Lib");

            builder.Property(sc => sc.DateOut).HasColumnType("datetime").IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(sc => sc.DateIn).HasColumnType("datetime").IsRequired(false);
        }
    }
}
