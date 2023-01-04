using FirstPages.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstPages.Data;

public class ApplicationDbContext: DbContext
{
    public virtual DbSet<UserModel> Users { get; set; }
    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));

        optionsBuilder
            .UseMySql("server=b9bxlfuyjuumvhbrurtw-mysql.services.clever-cloud.com;port=3306;user=u5zvjnhpym4rv0rh;password=tLybJDNUW8vQVGfsA1ZB;database=b9bxlfuyjuumvhbrurtw", serverVersion)
            .UseLoggerFactory(LoggerFactory.Create(b => b
                    .AddConsole()
                    .AddFilter(level => level >= LogLevel.Information)
                )
            )
            .EnableSensitiveDataLogging()
            .EnableDetailedErrors();
    }
}