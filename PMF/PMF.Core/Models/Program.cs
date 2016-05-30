using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMF.Core.Models
{
    public class Program
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ProgramType Type { get; set; }

        public int Years { get; set; }
        public string Title { get; set; }

        //lazy:
        public List<Subject> MandatorySubjects { get; set; }
        public List<Subject> OptionalSubjects { get; set; }
        public List<Module> Modules { get; set; }

        public string Image { get; set; }
        public string SmallImage { get; set; }

        public string Purpose { get; set; }

        public string Goals { get; set; }

    }
}
