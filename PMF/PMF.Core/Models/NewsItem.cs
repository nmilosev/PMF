using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMF.Core.Models
{
    public class NewsItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Summary => Title.Substring(0, 200);
        public string Category { get; set; }
        public string ImageURI { get; set; }
        public string ImageThumbnailURI { get; set; }
        public string LanguageCode { get; set; }
    }
}
