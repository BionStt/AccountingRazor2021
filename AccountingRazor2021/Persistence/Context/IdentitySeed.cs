﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using AccountingRazor2021.Domain;
namespace AccountingRazor2021.Persistence.Context
{
    public class IdentitySeed
    {
        public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new IdentityRole(Domain.Enums.Roles.SuperAdmin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Domain.Enums.Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Domain.Enums.Roles.Moderator.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Domain.Enums.Roles.Basic.ToString()));
        }
        public static async Task SeedSuperAdminAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Default User
            var defaultUser = new ApplicationUser
            {
                UserName = "superadmin",
                Email = "sutanto.gasali@gmail.com",
                FirstName = "Sutanto",
                LastName = "Gasali",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "123Pa$$word.");
                    await userManager.AddToRoleAsync(defaultUser, Domain.Enums.Roles.Basic.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Domain.Enums.Roles.Moderator.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Domain.Enums.Roles.Admin.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Domain.Enums.Roles.SuperAdmin.ToString());
                }

            }
        }
        public static async Task SeedBasicUserAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            var defaultUser = new ApplicationUser
            {
                UserName = "basic",
                Email = "basic@gmail.com",
                FirstName = "John",
                LastName = "Doe",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "123Pa$$word.");
                    await userManager.AddToRoleAsync(defaultUser, Domain.Enums.Roles.Basic.ToString());
                }

            }
        }
    }
}
