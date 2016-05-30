using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMF.Core.Models
{
    public class FAQ
    {
        public bool IsDataValid { get; set; }
        public List<QA> QuestionsAndAnswers { get; set; }
    }
}
