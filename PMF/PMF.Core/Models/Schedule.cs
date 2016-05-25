using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMF.Core.Models
{
    public class Schedule
    {
        public int Id { get; set; }

        public DateTime Time { get; set; }
        public string TimeFormatted => Time.ToString("dd.MM.yyyy. HH:mm:ss");

        public string Title { get; set; }
        public string Description { get; set; }
        
        public List<ScheduleDay> Days { get; set; }
    }
}
