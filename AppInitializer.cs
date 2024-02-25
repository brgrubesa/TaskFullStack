using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace TaskFullStack
{
    public static class AppInitializer
    {
        public static void InitializeRoles(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            string[] roleNames = { "Admin", "User" };

            foreach (var roleName in roleNames)
            {
                var roleExist = roleManager.RoleExistsAsync(roleName).GetAwaiter().GetResult();
                if (!roleExist)
                {
                    // Create the roles and seed them to the database
                    var result = roleManager.CreateAsync(new IdentityRole(roleName)).GetAwaiter().GetResult();
                    if (!result.Succeeded)
                    {
                        throw new Exception($"Error creating role '{roleName}'.");
                    }
                }
            }
        }
    }
}
