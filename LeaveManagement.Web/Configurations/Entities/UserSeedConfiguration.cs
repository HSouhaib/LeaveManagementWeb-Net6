using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities;
public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
{
   public void Configure(EntityTypeBuilder<Employee> builder)
   {
      var hasher = new PasswordHasher<Employee>();
      builder.HasData(
        
          new Employee
          {
             Id = "654dae5c-6726-4c62-8f4a-70933c2951a6",
             Email = "admin@localhot.com",
             NormalizedEmail= "ADMIN@LOCALHOST.COM",
             NormalizedUserName= "ADMIN@LOCALHOST.COM",
             UserName= "admin@localhot.com",
             FirstName = "System",
             LastName = "Admin",
             PasswordHash  = hasher.HashPassword(null, "P@ssword1"),
             EmailConfirmed=true
          }
        );
   }
}