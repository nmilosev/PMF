using PMF.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMF.Core.Interfaces
{
    public interface ISubjectsSource
    {
        Task<Subject> ForId(int id, string langCode);

        bool RequireConnection { get; }
        
        bool IsModelValid { get; }

        bool IsAvailable { get; }
    }
}
