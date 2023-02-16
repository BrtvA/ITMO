using System;

namespace ITMO.CSharp.Lab12.Exercise2.Bank
{
    public class AuditEventArgs : EventArgs
    {
        private readonly BankTransaction transData = null;

        public AuditEventArgs(BankTransaction transaction)
        {
            this.transData = transaction;
        }

        public BankTransaction getTransaction()
        {
            return this.transData;
        }
    }
}
