using System.Collections.Generic;

namespace PMF.Core.Models
{
    public class ScheduleDay
    {
        public List<ScheduleItem> Items { get; set; }

        public int DayOfTheWeek { get; set; }

        public bool HasNoItems {
            get { return Items == null || Items.Count == 0; }
        }

    }
}