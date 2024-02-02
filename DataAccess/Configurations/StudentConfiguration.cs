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
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(a => a.FirstName).IsRequired().HasColumnType("nvarchar(15)");
            builder.Property(a => a.LastName).IsRequired().HasColumnType("nvarchar(25)");
            builder.Property(s => s.GroupId).HasColumnName("Id_Group");

        }
    }
}
