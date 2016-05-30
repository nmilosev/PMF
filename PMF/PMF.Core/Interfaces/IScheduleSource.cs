using PMF.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMF.Core.Interfaces
{
    public interface IScheduleSource : InterfaceBase
    {

        Task<ScheduleList> Schedules(string langCode);

    }
}
