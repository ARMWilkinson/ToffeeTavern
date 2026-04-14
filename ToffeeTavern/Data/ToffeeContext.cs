using Microsoft.EntityFrameworkCore;
using ToffeeTavern.Models;

namespace ToffeeTavern.Data
{
    public class ToffeeContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<Quest> Quests { get; set; }

        public ToffeeContext(DbContextOptions options) : base(options)
        {
        }
    }
}
