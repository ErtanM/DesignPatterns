﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    public class Samsung : Company
    {
        public override string Pack()
        {
            return "Samsung CD";
        }

        public override int Price()
        {
            return 15;
        }
    }
}
