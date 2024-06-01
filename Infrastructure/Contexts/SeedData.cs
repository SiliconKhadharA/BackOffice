using Infrastructure.Entites;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Contexts;

public static class SeedData
{
    public static async Task Initialize(IServiceProvider serviceProvider, UserManager<AdminUserEntity> userManager, RoleManager<IdentityRole> roleManager)
    {
        // Ensure the admin role exists
        string[] roleNames = { "Admin", "User" };
        IdentityResult roleResult;

        foreach (var roleName in roleNames)
        {
            var roleExist = await roleManager.RoleExistsAsync(roleName);
            if (!roleExist)
            {
                roleResult = await roleManager.CreateAsync(new IdentityRole(roleName));
            }
        }

        // Ensure there is an admin user
        var adminUser = new AdminUserEntity
        {
            UserName = "admin",
            Email = "admin@example.com",
            FullName = "Admin User",
            CreatedDate = DateTime.Now,
            LastModifiedDate = DateTime.Now,
            IsAdmin = true
        };

        string userPassword = "Admin@123";

        var user = await userManager.FindByEmailAsync(adminUser.Email);

        if (user == null)
        {
            var createPowerUser = await userManager.CreateAsync(adminUser, userPassword);
            if (createPowerUser.Succeeded)
            {
                // Assign the new user the "Admin" role
                await userManager.AddToRoleAsync(adminUser, "Admin");
            }
        }
    }
}
