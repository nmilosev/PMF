using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMF.Core.Models
{
    public class NewsItem
    {
        private const int LIMIT = 200;
        private const string EXTENDED = "...";

        public int Id { get; set; }

        public string Title { get; set; }        

        public DateTime Time { get; set; }
        public string TimeFormatted => Time.ToString("dd.MM.yyyy. HH:mm:ss");

        public string Text { get; set; }
        public string Summary { get { return Text.Length > LIMIT ? Text.Substring(0, LIMIT).TrimEnd() + EXTENDED : Text; } }
        public string Category { get; set; }
        public string ImageURI { get; set; }
        public string Link { get; set; }    
        public string Color { get; set; }    
    }
}
