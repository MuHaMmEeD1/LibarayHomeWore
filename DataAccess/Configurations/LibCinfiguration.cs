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
    public class LibCinfiguration : IEntityTypeConfiguration<Lib>
    {
        public void Configure(EntityTypeBuilder<Lib> builder)
        {
            builder.Property(a => a.FirstName).IsRequired().HasColumnType("nvarchar(15)");
            builder.Property(a => a.LastName).IsRequired().HasColumnType("nvarchar(25)");
        }
    }
}
