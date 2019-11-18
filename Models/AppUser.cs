using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Final_Project_Team12.Models
{
    public class AppUser : IdentityUser
    {

        //First name is provided as an example
        [Required(ErrorMessage = "First name is required.")]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        //
        [Display(Name = "Middle Initial")]
        public String MiddleInitial { get; set; }

        //
        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        //
        [Required(ErrorMessage = "Street is required.")]
        [Display(Name = "Street")]
        public String Street { get; set; }

        //
        [Required(ErrorMessage = "City is required.")]
        [Display(Name = "City")]
        public String City { get; set; }

        //
        [Required(ErrorMessage = "State is required.")]
        [Display(Name = "State")]
        public String State { get; set; }

        //
        [Required(ErrorMessage = "Zip code is required.")]
        [Display(Name = "Zip code")]
        public String Zip { get; set; }

        [Display(Name = "Accounts")]
        public List <BankAccount> Accounts { get; set; }

        [Display(Name = "Is user active?")]
        public Boolean IsActive { get; set; }
    }
}
