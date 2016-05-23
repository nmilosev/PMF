using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMF.Core.Models
{
    public class News
    {
        public List<NewsItem> Items { get; set; }
        public DateTime Refreshed { get; set; }
        public int From { get; set; }
        public int To { get; set; }
    }
}
