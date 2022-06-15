using LeaveManagement.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities;
public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
{
   public void Configure(EntityTypeBuilder<IdentityRole> builder)
   {
      builder.HasData(
         new IdentityRole
         {
            Id = "8e4a4a43-9f07-4124-957d-c60bb846e7bf",
            Name = Roles.Administrator,
            NormalizedName = Roles.Administrator.ToUpper(),

         },
          new IdentityRole
          {
             Id = "8e4a43a43-9f07-4124-957cbbd-c60bb846e7abf",
             Name = Roles.User,
             NormalizedName = Roles.User.ToUpper()
          }
      );
   }
}