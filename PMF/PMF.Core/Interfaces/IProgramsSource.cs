using PMF.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMF.Core.Interfaces
{
    public interface IProgramsSource : InterfaceBase
    {
        Task<List<Program>> ForDepartment(int departmentId, string langCode);

        Task<Program> ForId(int programId, string langCode);
    }
}
