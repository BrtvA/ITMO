﻿using ITMO.CSharp.Lab12.Exercise1.Bank;
using System;
using System.Collections;

namespace ITMO.CSharp.Lab12.Exercise1.TestHarness
{
    class CreateAccount
    {
        static void Main()
        {

            // Create two bank accounts. Use Bank.CreateAccount(...) with the same balance and type
            // Store the numbers of these two accounts in long variables accNo1 and accNo2
            long accNo1 = BankMethods.CreateAccount(AccountType.Checking, 100);
            long accNo2 = BankMethods.CreateAccount(AccountType.Checking, 100);

            // Create two BankAccount variables, acc1 and acc2. 
            // Use Bank.GetAccount() to populate them with the two accounts just created
            BankAccount acc1 = BankMethods.GetAccount(accNo1);
            BankAccount acc2 = BankMethods.GetAccount(accNo2);

            // ADD CODE HERE TO SET THE NAMES OF THE ACCOUNT HOLDERS
            acc1.Holder = "Sid";
            acc2.Holder = "Ted";
            // ADD CODE HERE TO GET THE NUMBER AND TYPE OF EACH ACCOUNT
            Console.WriteLine("Account Number is {0}, Account Type is {1}", acc1.Number, acc1.Type);
            Console.WriteLine("Account Number is {0}, Account Type is {1}", acc2.Number, acc2.Type);

            // Print the accounts, using ToString
            Console.WriteLine("acc1 - {0}", acc1);
            Console.WriteLine("acc2 - {0}", acc2);

            Console.ReadKey();
        }
    }
}