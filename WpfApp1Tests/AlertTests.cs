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
    public class AlertTests
    {
        [TestMethod()]
        public void ShowMessageTest()
        {
            try
            {
                string message = "hello";
                Alert alert = new Alert();
                //show a message to the user
                alert.ShowMessage(message);
                return;
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "");
            }

            Assert.Fail("no exceoption thrown");


        }
    }
}