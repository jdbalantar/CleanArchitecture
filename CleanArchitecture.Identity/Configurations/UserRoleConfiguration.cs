using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Identity.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>()
                {
                    RoleId = "CD17265E-14A9-499C-82D4-9BA47A01C6E7",
                    UserId = "9EAB95F0-A08D-478B-A1CF-FD64779D359E"
                },
                new IdentityUserRole<string>()
                {
                    RoleId = "7E777C7E-FD97-4DD1-A4B4-5D2ED3398BE3",
                    UserId = "91081510-850F-4BFF-BAFE-1B52D0EC3B83"
                }
            );
        }
    }
}
