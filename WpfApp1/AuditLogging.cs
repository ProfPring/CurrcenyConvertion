using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1;

namespace App1
{
    public class AuditLogging : IAuditLogging
    {
       

        public void writeLogs(string logMessage, string convertedTo)
        {
            string path = @".\logs.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine("Conversion made from GBP to: "+ convertedTo + " " + logMessage);
                    writer.WriteLine(DateTime.Now.ToLongDateString());
                    writer.WriteLine("-------------------------------");
                }
            }
        }
        
    }
}
