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
    public class CurrencyDictTests
    {
        CurrencyDict currencyDict = new CurrencyDict();
        [TestMethod()]
        public void AddElementsTest()
        {
            IDictionary<string, float> Currency_Dict = new Dictionary<string, float>();
            try
            {
                //add elements to the Currency_Dict
                currencyDict.AddElements();
                return;
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "");
            }


            Assert.Fail();
        }

        [TestMethod()]
        public void Currency_DictionaryTest()
        {
            IDictionary<string, float> Currency_Dict = new Dictionary<string, float>();
            try
            {
                //make a new public Dictionary
                var Currency_Dictionary = currencyDict.Currency_Dictionary();
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