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
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(b => b.Name).IsRequired().HasColumnType("nvarchar(100)");
            builder.Property(b => b.ThemeId).HasColumnName("Id_Theme");
            builder.Property(b => b.CategoriseId).HasColumnName("Id_Category");
            builder.Property(b => b.AuthorId).HasColumnName("Id_Author");
            builder.Property(b => b.PresId).HasColumnName("Id_Press");
        }
    }
}
