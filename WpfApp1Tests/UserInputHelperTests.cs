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
    public class UserInputHelperTests
    {
        UserInputHelper userInputHelper = new UserInputHelper();
        [TestMethod()]
        public void IsNumberTestFalse()
        {
            try
            {
                string inputText = "hello";
                bool expected = false;

                /*
                 * needs to check if the userinout is a number and not a word of some sort
                 * returns a bool depending on if the input is a number or not
                 */
                var actual = userInputHelper.IsNumber(inputText);

                if (actual == expected)
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
        [TestMethod()]
        public void IsNumberTestTrue()
        {
            try
            {
                string inputText = "12";
                bool expected = true;

                var actual = userInputHelper.IsNumber(inputText);

                if (actual == expected)
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



        [TestMethod()]
        public void IsUserInputNumberOrEmpptyTest()
        {

            try
            {
                string userinput = "";
                bool expected = true;
                /*
                 *  this method makes sure the user input is not null or empty
                 */

                var actual =userInputHelper.IsUserInputNumberOrEmppty(userinput);

                if (actual == expected)
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

        [TestMethod()]
        public void ConvertUserInputTest()
        {
            try
            {
                string userinput = "12";
                int expected = 12;

                //convert the userinput to an int to the calculation
                var actual = userInputHelper.ConvertUserInput(userinput);

                if(actual == expected)
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
        public void IsUserInputDateTime()
        {
            try
            {
                string userinput = "21 September 2020";

                //should return true if the userinput is datetime
                var actual = userInputHelper.IsUserInputDateTime(userinput);

                if (actual)
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