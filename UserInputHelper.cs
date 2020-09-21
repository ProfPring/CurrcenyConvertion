using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Windows.UI.Xaml.Controls;

namespace App1
{
    public class UserInputHelper 
    {
        public bool IsNumber(string inputText)
        {
            bool isNumber = int.TryParse(inputText, out int n);
            return isNumber;
        }

       public bool IsUserInputNumberOrEmppty(string userInput)
       {
            if (!IsNumber(userInput) || string.IsNullOrEmpty(userInput))
            {
                return true;
            }
            return false;
       }

        public int ConvertUserInput(string userInput)
        {
            return (int)Convert.ToInt64(userInput);
        }

        public bool IsUserInputDateTime(string userinput)
        {
            return DateTime.TryParse(userinput, out DateTime result);
        }


    }
}
