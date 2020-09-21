using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class ConvertCurrencyToEUR: Currency, IConvertCurrencyToEUR
    {
        public double ConvertGPDToEUR(int userinput, IDictionary<string, float> dictionary)
        {
            setGDP_(userinput);
            var conversionrate = dictionary["EUR"];
            return userinput * conversionrate;
        }
    }
}
