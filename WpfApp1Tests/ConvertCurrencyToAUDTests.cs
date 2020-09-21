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
    public class ConvertCurrencyToAUDTests
    {
        [TestMethod()]
        public void ConvertGPDToAUDTest()
        {
            try
            {
                ConvertCurrencyToAUD convertCurrencyToAUD = new ConvertCurrencyToAUD();

                IDictionary<string, float> dictionary = new Dictionary<string, float>();
                dictionary.Add("AUD", 1.09f);

                int userinput = 12;
                int expected = 13;
                //should return an int from the the userinput. take the user input input and convert to AUD
                var actual = Math.Round(convertCurrencyToAUD.ConvertGPDToAUD(userinput, dictionary));

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