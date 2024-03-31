using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumAttendance.Objects
{
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
    public class MonthInfo
    {
        public string nominative { get; set; }
        public string genitive { get; set; }
    }
}
