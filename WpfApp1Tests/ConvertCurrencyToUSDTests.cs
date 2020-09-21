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
    public class ConvertCurrencyToUSDTests
    {
        [TestMethod()]
        public void ConvertGPDToUSDTest()
        {
            try
            {
                ConvertCurrencyToUSD convertCurrencyToUSD = new ConvertCurrencyToUSD();
                IDictionary<string, float> dictionary = new Dictionary<string, float>();
                dictionary.Add("USD", 1.29f);

                int userinput = 12;
                int expected = 15;

                //convert the user input to USD should return an int
                var acutal =Math.Round(convertCurrencyToUSD.ConvertGPDToUSD(userinput, dictionary));
                
                
                if (acutal == expected)
                {
                    return;
                }
                
                
                return;
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "");
            }


            Assert.Fail();
        }
    }
}