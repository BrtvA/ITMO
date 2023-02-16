using System;
using System.IO;

namespace ITMO.CSharp.Lab11.Exercise2.Audit
{
    public class AuditMethods
    {
        private string filename;
        private StreamWriter auditFile;
        private bool closed = false;

        public AuditMethods(string fileToUse)
        {
            this.filename = fileToUse;
            this.auditFile = File.AppendText(fileToUse);
        }

        public void RecordTransaction(object sender, AuditEventArgs eventData)
        {
            BankTransaction tempTrans = eventData.getTransaction();
            if (tempTrans != null)
                this.auditFile.WriteLine("Amount: {0}\tDate: {1}",
                tempTrans.Amount(), tempTrans.When());
        }

        public void Close()
        {
            if (!closed)
            {
                this.auditFile.Close();
                closed = true;
            }
        }
    }
}
