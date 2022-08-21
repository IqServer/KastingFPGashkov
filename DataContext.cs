using Microsoft.EntityFrameworkCore;
using Models;
using testnet;

namespace testnet
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Member> Members { get; set; }
        public DbSet<User> Users {get; set;}
        public DbSet<Firm> Firms {get; set;}
        public DbSet<Season> Seasons {get; set;}
        public DbSet<Kurator> Kurators {get; set;}
        public DbSet<Anketa> Anketas {get; set;}
        public DbSet<Job> Jobs {get; set;}
       
        public void  CreateBDNew()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //модификация таблиц в бд
        }

    }


}