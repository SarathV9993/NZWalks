using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NzWalksDbContext : DbContext
    {
        public NzWalksDbContext(DbContextOptions<NzWalksDbContext> options): base(options)
        {

        }
        // By creating properties like this we are telling Entity Framework that 
        // if a table doesn't exists then please create a table.
        // This is a connection and a property that tells you that you can
        // talk to Regions table
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
}
