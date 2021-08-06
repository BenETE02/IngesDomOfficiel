using IngesDom.Models;
using Microsoft.EntityFrameworkCore;

namespace IngesDom
{
    public class Datacontext : DbContext
    {
        public Datacontext()
        {

        }

       
        public Datacontext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
