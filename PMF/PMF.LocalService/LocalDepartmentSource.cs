using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMF.Core.Interfaces;
using PMF.Core.Models;

namespace PMF.LocalService
{
    public class LocalDepartmentSource : IDepartmentsSource
    {
        public bool IsAvailable
        {
            get
            {
                return true;
            }
        }

        public bool IsDataValid
        {
            get { return true; }
        }

        public bool RequireConnection
        {
            get
            {
                return false;
            }
        }

        public async Task<List<Department>> Departments(string langCode)
        {
            await Task.Delay((int)(3000 * new Random().NextDouble()));
            return new List<Department>()
            {
                new Department()
                {
                    Id = 1,
                    Name = "Departman za matematiku i informatiku",
                    Color = "#9E8A95"
                },
                new Department()
                {
                    Id = 2,
                    Name = "Departman za fiziku",
                    Color = "#3C404A"
                }
            };
        }
    }
}
