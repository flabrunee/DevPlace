﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP
{
    internal interface IOperaciones
    {
        double num1; { get; set; }
        double num2; { get; set; }
        public double Operar();
    }
}
