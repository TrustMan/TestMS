using System.ComponentModel.DataAnnotations.Schema; //add line
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MusicStore.Models
{
    public class ApplicationUser : IdentityUser 
	{
        [Column(TypeName = "datetime")] //add lines
        public override DateTimeOffset? LockoutEnd { get; set; }
    }

    public class MusicStoreContext : IdentityDbContext<ApplicationUser>
    {
        public MusicStoreContext(DbContextOptions<MusicStoreContext> options)
            : base(options)
        {
            // TODO: #639
            //ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}