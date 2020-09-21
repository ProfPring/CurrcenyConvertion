using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public abstract class Currency
    {
        protected int GDP;

        public int GDP_
        {
            get { return GDP; }
        }

        public virtual void setGDP_(int GDP_)
        {
            GDP = GDP_;
        }
    }
}
