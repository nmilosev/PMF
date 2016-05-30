using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMF.Core.Interfaces
{
    public interface InterfaceBase
    {
        bool RequireConnection { get; }

        bool IsAvailable { get; }

        bool IsDataValid { get; }
    }
}
