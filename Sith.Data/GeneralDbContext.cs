using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sith.Data.Models;

namespace Sith.Data
{
    public class GeneralDbContext : IdentityDbContext<ApplicationUser>
    {
        public GeneralDbContext(DbContextOptions<GeneralDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>()
                .HasOne(u => u.Store)
                .WithOne(ps => ps.Owner)
                .HasForeignKey<PasswordStore>(ps => ps.StoreId)
                .IsRequired();
            builder.Entity<PasswordStore>()
                .HasMany(ps => ps.Passwords)
                .WithOne(p => p.Store)
                .IsRequired();
        }
    }
}