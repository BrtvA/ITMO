using System;

namespace ITMO.CSharpCourse.Lab02.Exercise1.BankAccount
{
    public enum AccountType
    {
        Checking,
        Deposit
    }

    internal class Enum
    {
        static void Main(string[] args)
        {
            AccountType goldAccount;
            AccountType platinumAccount;

            goldAccount = AccountType.Checking;
            platinumAccount = AccountType.Deposit;

            Console.WriteLine("The Customer Account Type is {0}", goldAccount);
            Console.WriteLine("The Customer Account Type is {0}", platinumAccount);

            Console.ReadKey();
        }
    }
}