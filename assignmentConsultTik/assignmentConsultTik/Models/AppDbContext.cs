using Microsoft.EntityFrameworkCore;

namespace assignmentConsultTik.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }
        public DbSet<PurchaseOrderLine> PurchaseOrderLines { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Currency> Currencies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<PurchaseOrderHeader>()
                .HasOne(p => p.VendorDetails)
                .WithMany(v => v.PurchaseOrderHeaders)
                .HasForeignKey(p => p.Vendor);

            modelBuilder.Entity<PurchaseOrderHeader>()
                .HasOne(p => p.CurrencyDetails)
                .WithMany(c => c.PurchaseOrderHeaders)
                .HasForeignKey(p => p.CurrencyCode);

            modelBuilder.Entity<PurchaseOrderLine>()
                .HasOne(p => p.PurchaseOrderHeader)
                .WithMany(h => h.PurchaseOrderLines)
                .HasForeignKey(p => p.PurchId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
