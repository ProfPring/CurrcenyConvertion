using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class setConversionRates 
    {

        protected float USD_rate;
        protected float EUR_rate;
        protected float AUD_rate;


        public float USD_Rate
        {
            get { return USD_rate; }
        }
        public virtual void setUSD_Rate(float USD_)
        {
            USD_rate = USD_;
        }

        public float EUR_Rate
        {
            get { return EUR_rate; }
        }
        public virtual void setEUR_Rate(float EUR_)
        {
            EUR_rate = EUR_;
        }

        public float AUD_Rate
        {
            get { return AUD_rate; }
        }
        public virtual void setAUD_Rate(float AUD_)
        {
            AUD_rate = AUD_;
        }
    }
}
