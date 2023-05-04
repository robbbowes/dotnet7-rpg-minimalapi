using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Character> Characters { get; set; }
    }
}
