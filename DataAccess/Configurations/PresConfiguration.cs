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
    public class PresConfiguration : IEntityTypeConfiguration<Pres>
    {
        public void Configure(EntityTypeBuilder<Pres> builder)
        {
            builder.Property(c => c.Name).IsRequired().HasColumnType("nvarchar(30)");
        }
    }
}
