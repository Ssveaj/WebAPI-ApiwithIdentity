using Microsoft.EntityFrameworkCore;

namespace WebAPI_ApiwithIdentity.Entities
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }



    }
}
