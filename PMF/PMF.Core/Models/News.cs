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
        public string RefreshedFormatted => Refreshed.ToString("dd.MM.yyyy. HH:mm:ss");
        
        public bool IsDataValid { get; set; }
    }
}
