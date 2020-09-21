using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    interface IConvertToUSD
    {
        double ConvertGPDToUSD(int userinput, IDictionary<string, float> dictionary);
    }
}
