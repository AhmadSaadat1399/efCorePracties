using Microsoft.EntityFrameworkCore;
namespace efCorePracties.Controllers.Models
{

    public class PersonDbContext : DbContext
    {
        public PersonDbContext(DbContextOptions<PersonDbContext> options) : base(options)
        {

        }
        public DbSet<Person> people { get; set; }


    }
}