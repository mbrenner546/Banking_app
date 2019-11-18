using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Final_Project_Team12.Models;


namespace Final_Project_Team12.DAL
{
    //NOTE: This class definition references the user class for this project.  
    //If your User class is called something other than AppUser, you will need
    //to change it in the line below
    public class AppDbContext: IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }

        //TODO: Add Dbsets here.  Remember, IdentityDbContext provides a DbSet for AppUsers 
        //This DbSet is called Users
        public DbSet<BankAccount> BankAccounts { get; set; }
      
    }
}
