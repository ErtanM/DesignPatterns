﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesign
{
    public interface IPrototype
    {
        IPrototype GetClone();
    }
}
