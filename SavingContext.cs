using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkChallenge
{
    public class SavingContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public DbSet<SavingAccount> SavingAccount { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LOCALHOST\SQLEXPRESS;Database=Savings;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        }
    }
}
