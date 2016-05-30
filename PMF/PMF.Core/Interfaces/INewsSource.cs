﻿using PMF.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMF.Core.Interfaces
{
    public interface INewsSource : InterfaceBase
    {
        
        Task<News> News(string langCode);

    }
}
