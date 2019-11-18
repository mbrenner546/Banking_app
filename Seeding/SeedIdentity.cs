using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

//TODO: Change these using statements to match your project
using Final_Project_Team12.DAL;
using Final_Project_Team12.Models;

//TODO: Change this namespace to match your project
namespace Final_Project_Team12.Seeding
{
    //add identity data
    public static class SeedIdentity
    {
        public static async Task AddAdmin(IServiceProvider serviceProvider)
        {
            AppDbContext _db = serviceProvider.GetRequiredService<AppDbContext>();
            UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            //TODO: Add the needed roles
            //if role doesn't exist, add it
            if (await _roleManager.RoleExistsAsync("Manager") == false)
            {
                await _roleManager.CreateAsync(new IdentityRole("Manager"));
            }

            if (await _roleManager.RoleExistsAsync("Employee") == false)
            {
                await _roleManager.CreateAsync(new IdentityRole("Employee"));
            }

            if (await _roleManager.RoleExistsAsync("Customer") == false)
            {
                await _roleManager.CreateAsync(new IdentityRole("Customer"));
            }

            //check to see if the admin has been added
            AppUser newUser = _db.Users.FirstOrDefault(u => u.Email == "manager@example.com");

            //if admin hasn't been created, then add them
           
            if (newUser == null)
            {
                newUser = new AppUser();
                newUser.UserName = "manager@example.com";
                newUser.Email = "manager@example.com";
                newUser.FirstName = "Manager";
                newUser.LastName = "Manager";
                newUser.Street = "Street";
                newUser.City = "City";
                newUser.State = "State";
                newUser.Zip = "Zip";
             
                //TODO: Add additional fields that you created on the AppUser class

                //NOTE: This creates the user - "Abc123!" is the password for this user
                var result = await _userManager.CreateAsync(newUser, "Abc123!");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can't be added - " + result.ToString());
                }
                _db.SaveChanges();
                newUser = _db.Users.FirstOrDefault(u => u.UserName == "admin@example.com");
            }

            //Add the new user we just created to the Admin role
            if (await _userManager.IsInRoleAsync(newUser, "Manager") == false)
            {
                await _userManager.AddToRoleAsync(newUser, "Manager");
            }

            //save changes
            _db.SaveChanges();
        }

    }
}