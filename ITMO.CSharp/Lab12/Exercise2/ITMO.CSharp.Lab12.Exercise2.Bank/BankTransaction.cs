using System;
using System.IO;

namespace ITMO.CSharp.Lab12.Exercise2.Bank
{
    public class BankTransaction
    {
        private readonly decimal amount;
        private readonly DateTime when;

        public BankTransaction(decimal tranAmount)
        {
            amount = tranAmount;
            when = DateTime.Now;
        }

        public decimal Amount
        {
            get { return amount; }
        }

        public DateTime When
        {
            get { return when; }
        }
    }
}
