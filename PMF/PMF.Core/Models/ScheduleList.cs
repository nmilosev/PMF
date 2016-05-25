using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMF.Core.Models
{
    public class ScheduleList
    {
        public List<Schedule> Schedules{ get; set; }
        public bool IsDataValid { get; set; }
    }
}
