using System.Collections.Generic;

namespace PMF.Core.Models
{
    public class Staff
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ContactData { get; set; }

        public List<Subject> Subjects { get; set; }
    }
}