namespace ENFOLL.Context
{
    using Microsoft.EntityFrameworkCore;
    using ENFOLL.Models;

    public class EnfollContext : DbContext
    {
        public EnfollContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Buyer>().HasKey("BuyerId");
        }


        public DbSet<Buyer> Buyer { get; set; }
        public DbSet<BuyOrder> BuyOrder { get; set; }
        public DbSet<ContactDetails> ContactDetails { get; set; }
        public DbSet<ImplementationOrder> ImplementationOrder { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<NGO> NGO { get; set; }
        public DbSet<NgoProjects> NgoProjects { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SellOrder> SellOrder { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
    }
}
