using Microsoft.EntityFrameworkCore;

namespace ParsingTestTask.Model
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Offer> Offer { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }

}
