using Final_Project_Team12.DAL;
using System;
using System.Linq;


namespace Final_Project_Team12.Utilities
{
    public static class GenerateNextBankAccountID
    {
        public static Int32 GetNextBankAccountID(AppDbContext _context)
        {
            Int32 intMaxBankAccountID; //the current maximum course ID
            Int32 intNextBankAccountID; //the course ID for the next class

            if (_context.BankAccounts.Count() == 0) //there are no bank accounts in the database yet
            {
                intMaxBankAccountID = 1000000000; //bank account IDs start at 1000000001
            }
            else
            {
                intMaxBankAccountID = _context.BankAccounts.Max(c => c.BankAccountID); //this is the highest ID in the database right now
            }

            //add one to the current max to find the next one
            intNextBankAccountID = intMaxBankAccountID + 1;

            //return the value
            return intNextBankAccountID;
        }

    }
}