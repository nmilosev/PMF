using System.Collections.Generic;

namespace PMF.Core.Models
{
    public class Subject
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public List<Staff> Professors { get; set; }
        public List<Staff> Assitaints { get; set; }
    }
}