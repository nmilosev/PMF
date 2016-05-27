using System.Collections.Generic;

namespace PMF.Core.Models
{
    public class Subject
    {
        public string Id { get; set; }
        public string Title { get; set; }
        
        public List<Staff> Professors { get; set; }
        public List<Staff> Assistaints { get; set; }
        public double ESPB { get; set; }
        public string Goal { get; set; }
        public string Outcome { get; set; }
        public string Contents { get; set; }
        public string Literature { get; set; }
        public string Method { get; set; }
        public string Classes { get; set; }

        public List<string> URLs { get; set; }
    }
}