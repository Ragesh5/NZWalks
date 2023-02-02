using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;
using System.Reflection.Metadata.Ecma335;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext:DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> options): base(options)
        {
       
        }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDificulty> WalkDificulty { get; set; }
    }
}
