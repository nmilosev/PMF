using PMF.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMF.Core.Interfaces
{
    public interface INewsSource
    {
        bool RequireConnection { get; }

        bool IsAvailable { get; }
        
        Task<News> News(string langCode);
    }
}
