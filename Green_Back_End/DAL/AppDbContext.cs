using Green_Back_End.Models;
using Microsoft.EntityFrameworkCore;

namespace Green_Back_End.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<CardOne> CardOnes { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Servis> Services { get; set; }


    }
}
