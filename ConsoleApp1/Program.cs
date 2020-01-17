using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new Account();
            myAccount.AccountNumber = 12345;
            myAccount.AccountName = "Akewak";
            myAccount.AccountType = "checking";
            myAccount.Deposit(1001);
            Console.WriteLine($"A.Name: {myAccount.AccountName} AN: {myAccount.AccountNumber}, Balance: {myAccount.Balance}");
        }
    }
}
