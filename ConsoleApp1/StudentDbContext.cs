using Microsoft.EntityFrameworkCore;


namespace ConsoleApp1
{
    public class StudentDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            optionsBuilder.UseSqlServer(@"Data Source=WORKPC\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=True;TrustServerCertificate=True");
        }

        public DbSet<Student> Student { get; set; }
    }
}
