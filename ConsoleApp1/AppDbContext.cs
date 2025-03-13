using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //sdsdsdsd
            // sdsdd
            int a = 12; int x = 123;
            Console.WriteLine("Salam Miri  Qismet Ehmed");
            optionsBuilder.UseSqlServer("Server=CAHID\\MY_DB;Database=DB_EF;User Id=sa;Password=2016;TrustServerCertificate=True;");
        }
    }
}
