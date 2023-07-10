using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Model
{
    public class ApplicationContext : DbContext
    {
        public DbSet<MainTable> mainTabls { get; set; }
        public DbSet<TablOne> tablOne { get; set; }
        public DbSet<TablTwo> tablTwo { get; set; }
        public DbSet<TablThree> tablThree { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Tabls;Username=postgres;Password=2001Artem");
        }
    }
}
