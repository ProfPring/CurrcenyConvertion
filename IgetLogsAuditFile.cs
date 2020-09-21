using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    interface IgetLogsAuditFile
    {
        IDictionary<DateTime, string> getalllogdates();

        List<string> getLogsspecified(string startdate, string enddate);

    }
}
