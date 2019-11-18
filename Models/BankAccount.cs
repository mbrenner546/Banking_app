using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Final_Project_Team12.Models
{
    public enum AccountTypes { Savings, Checking, IRA, Stock_Portfolio };

    public class BankAccount
    {

        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal Balance { get; set; }

        public BankAccount()
        {
            Balance = 0;
        }

        public BankAccount(Decimal decBalance)
        {
            Balance = decBalance;
        }

        // See utilities class of relational data demo for example of how to autogenerate starting at certain value
        [Display(Name = "Account Number")]
        public Int32 BankAccountID { get; set; }

        [Required]
        [Display(Name = "Account Type")]
        public AccountTypes AccountType { get; set; }

        [Required]
        [Display(Name = "Account Name")]
        public string AccountName { get; set; }

        public AppUser User { get; set; }

     }
}
