using GAMEAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GAMEAPI.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext>options):DbContext(options)
    {
        public DbSet<Character> Characters => Set<Character>();

    }
}
