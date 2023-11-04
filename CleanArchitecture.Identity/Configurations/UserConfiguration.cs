using CleanArchitecture.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Identity.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            builder.HasData(
                new ApplicationUser()
                {
                    Id = "9EAB95F0-A08D-478B-A1CF-FD64779D359E",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "admin@localhost.com",
                    Nombre = "Admin",
                    Apellidos = "Admin",
                    UserName = "admin",
                    NormalizedUserName = "admin",
                    PasswordHash = hasher.HashPassword(null, "Admin123$"),
                    EmailConfirmed = true,
                },

                new ApplicationUser()
                {
                    Id = "91081510-850F-4BFF-BAFE-1B52D0EC3B83",
                    Email = "jdbalantar@localhost.com",
                    NormalizedEmail = "jdbalantar@localhost.com",
                    Nombre = "David",
                    Apellidos = "Balanta",
                    UserName = "jdbalantar",
                    NormalizedUserName = "jdbalantar",
                    PasswordHash = hasher.HashPassword(null, "Admin123$"),
                    EmailConfirmed = true,
                });
        }
    }
}
