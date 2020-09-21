using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace App1
{
    public class CurrencyDict : setConversionRates, ICurrencyDict
    {
        IDictionary<string, float> Currency_Dict = new Dictionary<string, float>();

        public void AddElements()
        {
            setUSD_Rate(1.29f);
            setEUR_Rate(0.92f);
            setAUD_Rate(1.09f);

            Currency_Dict.Add("USD", base.USD_Rate);
            Currency_Dict.Add("AUD", base.AUD_Rate);
            Currency_Dict.Add("EUR", base.EUR_Rate);
        }

        public IDictionary<string, float> Currency_Dictionary()
        {
            return Currency_Dict;
        }


    }
}
