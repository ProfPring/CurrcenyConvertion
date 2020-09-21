using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Tests
{
    [TestClass()]
    public class getLogsAuditFileTests
    {
        getLogsAuditFile GetLogsAuditFile = new getLogsAuditFile();

        [TestMethod()]
        public void auditlogsTest()
        {

            try
            {
                //should get the audit log file.
                GetLogsAuditFile.auditlogs();
                return;
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "");
            }
            Assert.Fail();
        }

        [TestMethod()]
        public void getalllogdatesTest()
        {

            try
            {
                /*
                 * should return a dictionary of key value pairs to be used 
                 * to get the date concerned with the given data for that given date
                 */

                GetLogsAuditFile.getalllogdates();
                return;
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "");
            }
            Assert.Fail();
        }

        [TestMethod()]
        public void getLogsspecifiedTest()
        {
            try
            {
                /*
                 * should return a list of data concered with the dates from 
                 * the audit log files
                 */
                string startdate = "21 September 2020";
                string enddate = "30 September 2020";

                GetLogsAuditFile.getLogsspecified(startdate, enddate);

                return;
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "");
            }
            Assert.Fail();

            Assert.Fail();
        }
    }
}