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
    public class FacultiesConfiguration : IEntityTypeConfiguration<Facultise>
    {
        public void Configure(EntityTypeBuilder<Facultise> builder)
        {
            builder.Property(f => f.Name).IsRequired().HasColumnType("nvarchar(20)");

        }
    }
}
