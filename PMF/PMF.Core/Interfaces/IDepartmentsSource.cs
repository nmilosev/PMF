using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMF.Core.Models;

namespace PMF.Core.Interfaces
{
    public interface IDepartmentsSource : InterfaceBase
    {
        Task<List<Department>> Departments(string langCode);
    }
}
