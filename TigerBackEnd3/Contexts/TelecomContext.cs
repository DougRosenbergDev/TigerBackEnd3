using Microsoft.EntityFrameworkCore;
using TigerPhoneAPI.Models;

namespace TigerPhoneAPI.Contexts
{
    public class TelecomContext : DbContext
    {
        public TelecomContext(DbContextOptions<TelecomContext> options)
            : base(options){}

        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<Plan> Plans { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
