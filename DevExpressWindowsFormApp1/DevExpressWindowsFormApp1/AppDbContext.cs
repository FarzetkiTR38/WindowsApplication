using Microsoft.EntityFrameworkCore;

namespace DevExpressWindowsFormApp1
{
    public class AppDbContext : DbContext
    {
        // Bu bizim MSSQL'deki tablomuz olacak
        public DbSet<Kullanici> Kullanicilar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // MSSQL Bağlantı cümlen (Server ismini kendi bilgisayarındaki SQL adıyla değiştirmelisin)
            // SQL adın genelde '.' veya '.\SQLEXPRESS' şeklindedir.
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=BenimProjemDB;Trusted_Connection=True;";// Server=(localdb)\\MSSQLLocalDB;Database=InanilmazYemeklerDb;Trusted_Connection=True;TrustServerCertificate=True;"
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
