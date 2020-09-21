using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class getLogsAuditFile 
    {

        string path = @".\logs.txt";


        public string[] auditlogs()
        {
         return System.IO.File.ReadAllLines(path);
        }
        
        public IDictionary<DateTime,string> getalllogdates()
        {
            var auditlogs = this.auditlogs();
            IDictionary <DateTime, string> DatesandDataDict = new Dictionary<DateTime, string> ();

            string value = "";
            foreach (var audit in auditlogs)
            {
                if (audit.StartsWith("Conversion"))
                {
                    value = audit;
                }
                try
                {
                    DateTime date = DateTime.Parse(audit);
                    DatesandDataDict.Add(date, value);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return DatesandDataDict; 
        }

        public List<string> getLogsspecified(string startdate, string enddate)
        {
            var listofalldates = this.getalllogdates();
            List<string> listofspecifieddates = new List<string>();

            foreach (var date in listofalldates)
            {
                DateTime StartDate = DateTime.Parse(startdate);
                DateTime EndDate = DateTime.Parse(enddate);
                
                if(date.Key <= EndDate && date.Key >= StartDate)
                {
                    listofspecifieddates.Add(date.Value);    
                }
            }
            return listofspecifieddates;
        }
    }
}
