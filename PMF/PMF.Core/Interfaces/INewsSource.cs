using PMF.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMF.Core.Interfaces
{
    interface INewsSource
    {
        bool RequireConnection { get; }

        bool IsAvailable { get; }

        List<NewsItem> NewsItems { get; set; }
    }
}
