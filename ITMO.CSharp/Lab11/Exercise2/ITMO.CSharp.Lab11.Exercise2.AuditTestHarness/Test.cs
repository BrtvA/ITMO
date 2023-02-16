using ITMO.CSharp.Lab11.Exercise2.Audit;
using System;

namespace ITMO.CSharp.Lab11.Exercise2.AuditTestHarness
{
    /// <summary>
    ///    Test Harness for the Audit Class.
    /// </summary>
    public class Test
    {
        public static void Main()
        {
            AuditMethods testAudit = new AuditMethods("AuditTrail.dat");
            BankTransaction testTran = new BankTransaction(500);
            AuditEventArgs testArg = new AuditEventArgs(testTran);
            testAudit.RecordTransaction(null, testArg);

            BankTransaction testTran2 = new BankTransaction(-200);
            AuditEventArgs testArg2 = new AuditEventArgs(testTran2);
            testAudit.RecordTransaction(null, testArg2);

            testAudit.Close();

            Console.ReadKey();
        }
    }
}
