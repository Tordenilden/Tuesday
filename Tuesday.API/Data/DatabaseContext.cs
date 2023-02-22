using Microsoft.EntityFrameworkCore;
using Tuesday.API.Models;

namespace Tuesday.API.Data
{
    // this inherit the "EF settings etc.."
    public class DatabaseContext : DbContext
    {
        // table reference / handle
        public DbSet<Person> Person { get; set; }

        // hvis jeg glemmer denne, kommer der åbenbart ikke en tabel
        public DbSet<Car> Car { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=TEC-8220-LA0025;" +
                "Initial Catalog=testAPI;Integrated Security=True");
        }
    }
}
