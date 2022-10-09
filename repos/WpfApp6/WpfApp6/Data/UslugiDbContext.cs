using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6.Data
{
    public class UslugiDbContext : DbContext
    {
        public UslugiDbContext(DbContextOptions<UslugiDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Uslugi> Uslugis { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Uslugi>().HasData(GetUslugis());
            base.OnModelCreating(modelBuilder);
        }

        private Uslugi[] GetUslugis()
        {
            return new Uslugi[]
            {
                new Uslugi {uslugiID = 1, u_opis = "Вакцинация", price = 1, vaj = "Важно"}
            };

        }
    }
}
