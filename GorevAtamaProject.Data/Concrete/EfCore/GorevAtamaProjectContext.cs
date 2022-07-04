using GorevAtamaProject.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevAtamaProject.Data.Concrete.EfCore
{
    public class GorevAtamaProjectContext : DbContext
    {
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Rol> Rols { get; set; }
        public DbSet<Islem> Islems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=GorevAtamaProjectDb");
        }
    }
}
