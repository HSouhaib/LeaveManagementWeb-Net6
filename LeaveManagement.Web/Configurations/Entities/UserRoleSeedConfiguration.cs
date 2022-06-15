using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities;
public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
{

   public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
   {
      builder.HasData(
          new IdentityUserRole<string>
          {
             RoleId = "8e4a4a43-9f07-4124-957d-c60bb846e7bf",
             UserId = "654dae5c-6726-4c62-8f4a-70933c2951a6"
          }       
          );
   }
}