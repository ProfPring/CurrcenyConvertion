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
    public class ConvertCurrencyToEURTests
    {
        [TestMethod()]
        public void ConvertGPDToEURTest()
        {
            try
            {
                ConvertCurrencyToEUR convertCurrencyToEUR = new ConvertCurrencyToEUR();
                IDictionary<string, float> dictionary = new Dictionary<string, float>();
                dictionary.Add("EUR", 0.92f);

                int userinput = 12;
                int expected = 11;
                //should return an int from the the userinput. take the user input input and convert to EUR 
                var actual = Math.Round(convertCurrencyToEUR.ConvertGPDToEUR(userinput, dictionary));

                if (expected == actual)
                {
                    return;
                }
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "");

            }

            Assert.Fail();
        }
    }
}