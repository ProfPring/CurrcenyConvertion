using Microsoft.VisualStudio.TestTools.UnitTesting;
using App1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Tests
{
    [TestClass()]
    public class AuditLoggingTests
    {
        [TestMethod()]
        public void writeLogsTest()
        {
            try
            {
                /*
                 * needs to write to a file in the internal file system. should not throw 
                 * any errors.
                */
                AuditLogging auditLogging = new AuditLogging();

                auditLogging.writeLogs("logMessage", "convertedTo");
                return;
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "");
                Assert.Fail();
            }
        }
    }
}