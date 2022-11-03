using API.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class MingleDBContext : IdentityDbContext<AppUser, AppRole, int, IdentityUserClaim<int>, AppUserRole, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
{
  public MingleDBContext(DbContextOptions options) : base(options)
  {
  }

  protected override void OnModelCreating(ModelBuilder builder)
  {
    base.OnModelCreating(builder);
    builder.Entity<AppUser>()
    .HasMany(Ur => Ur.UserRoles)
    .WithOne(Ur => Ur.User)
    .HasForeignKey();

    builder.Entity<AppRole>()
    .HasMany(Ur => Ur.UserRoles)
    .WithOne(ur => ur.Role)
    .HasForeignKey(ur => ur.RoleId)
    .IsRequired();
  }
}