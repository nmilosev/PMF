using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMF.Core.Models
{
    public class Module
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Subject> ModuleSubjects { get; set; }
    }
}
