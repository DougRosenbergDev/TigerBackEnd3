using Microsoft.EntityFrameworkCore;
using TigerPhoneAPI.Models;

namespace TigerPhoneAPI.Contexts
{
    public class TelecomContext : DbContext
    {
        public TelecomContext(DbContextOptions<TelecomContext> options)
            : base(options) { }

        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<Plan> Plans { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Plan>()
            //    .HasOne<User>(p => p.User)
            //    .WithMany(d => d.Plans)
            //    .HasForeignKey(f => f.UserId);

            //modelBuilder.Entity<Device>()
            //    .HasOne<Plan>(p => p.Plan)
            //    .WithMany(d => d.Devices)
            //    .HasForeignKey(f => f.PlanId);

            //modelBuilder.Entity<Device>()
            //    .HasIndex(p => p.PhoneNumber)
            //    .IsUnique();
            //modelBuilder.Entity<User>()
            //    .HasIndex(u => u.UserName)
            //    .IsUnique();
        }
    }
}
