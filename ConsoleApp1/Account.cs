using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Account
    {   
        private int lastAccountNumber = 0;
        #region Constructor 
        public Account()
        {
            AccountNumber = ++lastAccountNumber;
        }
        #endregion
        #region properties 
        public int AccountNumber { get; private set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public decimal Balance { get; private set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        #endregion

        #region methods
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public decimal Withdraw(decimal amount)
        {
            Balance -= amount;
            return Balance; 
        }
        #endregion

        #region Constructor 
        
    }
}
