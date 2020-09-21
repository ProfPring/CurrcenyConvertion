using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class ConvertCurrencyToUSD : Currency, IConvertToUSD
    {
        public double ConvertGPDToUSD(int userinput, IDictionary<string, float> dictionary)
        {
            setGDP_(userinput);
            var conversionrate = dictionary["USD"];
            return  userinput * conversionrate;
        }
    }
}
