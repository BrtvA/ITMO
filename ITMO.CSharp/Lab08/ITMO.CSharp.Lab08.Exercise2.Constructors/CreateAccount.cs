using System;

namespace ITMO.CSharp.Lab08.Exercise2.Constructors
{
    class CreateAccount
    {
        static void Main()
        {
            BankAccount acc1, acc2, acc3, acc4;

            acc1 = new BankAccount();
            acc2 = new BankAccount(AccountType.Deposit);
            acc3 = new BankAccount(100);
            acc4 = new BankAccount(AccountType.Deposit, 500);

            acc1.Deposit(100);
            acc1.Withdraw(20);
            acc2.Deposit(200);
            acc2.Withdraw(50);
            acc3.Deposit(300);
            acc3.Withdraw(100);
            acc4.Deposit(400);
            acc4.Withdraw(150);

            Write(acc1);
            Write(acc2);
            Write(acc3);
            Write(acc4);

            Console.ReadKey();
        }

        static void Write(BankAccount acc)
        {
            Console.WriteLine("Account number is {0}", acc.Number());
            Console.WriteLine("Account balance is {0}", acc.Balance());
            Console.WriteLine("Account type is {0}", acc.Type());
            Console.WriteLine("Transactions:");
            foreach (BankTransaction tran in acc.Transactions())
            {
                Console.WriteLine("Date/Time: {0}\tAmount: {1}", tran.When(), tran.Amount());
            }
            Console.WriteLine();
        }
    }
}
