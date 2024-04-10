using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumAttendance.Objects
{
    /// <summary>
    /// API object which is used in Employee interface
    /// <para>JSON format:</para> 
    /// <para>date, dayNumber, dayInWeek, monthNumber, month[nominative, genitive], year, name, isHoliday, holidayName</para>
    /// </summary>
    public class SvatkyAPIObject
    {
        public DateTime date { get; set; }
        public string dayNumber { get; set; }
        public string dayInWeek { get; set; }
        public string monthNumber { get; set; }
        public MonthInfo month { get; set; }
        public string year { get; set; }
        public string name { get; set; }
        public bool isHoliday { get; set; }
        public string holidayName { get; set; }
    }

    /// <summary>
    /// Subclass for month 
    /// <para>JSON format:</para> 
    /// <para>nominative, genitive</para>
    /// </summary>
    public class MonthInfo
    {
        public string nominative { get; set; }
        public string genitive { get; set; }
    }
}
