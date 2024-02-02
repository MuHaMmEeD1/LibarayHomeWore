using Microsoft.EntityFrameworkCore;
using Model.Entitys.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contexts
{
    internal class LibaryHomeWork : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source=DESKTOP-RV3QOTA\\SQLEXPRESS;Initial Catalog=\"LibraryHomeWork \";Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

            optionsBuilder.UseLazyLoadingProxies(true);
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }


        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Categorise> Categories { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Facultise> Facultises { get;set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Lib> Libs { get; set; }
        public virtual DbSet<Pres> Press { get; set; }
        public virtual DbSet<S_Card> S_Cards { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<T_Card> T_Cards { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Theme> Themes { get; set; }
    }
}
