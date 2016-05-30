using System;
using System.Collections.Generic;

namespace PMF.Core.Models
{
    public class ScheduleItem
    {

        public int FromHour { get; set; }
        public int FromMinute { get; set; }

        public int ToHour { get; set; }
        public int ToMinute { get; set; }

        public string TimeFormatted
        {
            get
            {
                return $"{FromHour.ToString().PadLeft(2, '0')}:{FromMinute.ToString().PadLeft(2, '0')} - {ToHour.ToString().PadLeft(2, '0')}:{ToMinute.ToString().PadLeft(2, '0')}";
            }
        }

        public string SubjectId { get; set; }
        public string SubjectTitle { get; set; }
        
        public List<string> TeacherNames { get; set; }

        public string TeacherNamesFormatted => string.Join(", ", TeacherNames);

        public int LocationId { get; set; }
        public string Location { get; set; }
        
        public int Type { get; set; }

        public string Color { get; set; }

    }
}