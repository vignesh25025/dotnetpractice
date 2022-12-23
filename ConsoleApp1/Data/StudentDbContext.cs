using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ConsoleApp1
{
    public class StudentDbContext : DbContext
    {
        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(
         builder =>
         {
             builder.AddConsole();
         }
        );

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(MyLoggerFactory)
                .EnableSensitiveDataLogging()
                .UseSqlServer(@"Data Source=WORKPC\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=True;TrustServerCertificate=True");
        }

        public DbSet<Student> Student { get; set; }
    }
}
