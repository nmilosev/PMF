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
        public string Vocation { get; set; }

        public string URL { get; set; }
        public string Email { get; set; }

        public string ImageURL { get; set; }

        public string FullName => string.Join(" ", Title, FirstName, LastName);

        public List<Subject> Subjects { get; set; }
    }
}