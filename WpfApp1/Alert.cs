using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace App1
{
    public class Alert
    {
        public string ShowMessage(string str)
        {
           MessageBox.Show(str);
            return str;
        }
    }
}
