using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    interface IConvertGPDToAUD
    {
        double ConvertGPDToAUD(int userinput, IDictionary<string, float> dictionary);
    }
}
