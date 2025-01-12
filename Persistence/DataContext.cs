using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options ) : base(options)
        {

        }

        public DbSet<User> Users {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasData(
                    new User {
                        Id = 1,
                        FirstName = "Human",
                        LastName = "Muzaffari",
                        Age = 29,
                        Gender = "Man",


                     }
                
                );
        }



    }
}
