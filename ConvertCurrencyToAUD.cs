using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class ConvertCurrencyToAUD : Currency, IConvertGPDToAUD
    {

        public double ConvertGPDToAUD(int userinput, IDictionary<string, float> dictionary)
        {
            setGDP_(userinput);
            var conversionrate = dictionary["AUD"];
            return userinput * conversionrate;
        }


    }
}
