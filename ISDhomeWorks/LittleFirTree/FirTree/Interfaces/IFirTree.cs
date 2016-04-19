﻿using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTree.Interfaces
{
    public interface IFirTree 
    {
        Color State { get; }
        Shape Form { get; }
        double Height { get; }
        double Age { get; }
    }
}
