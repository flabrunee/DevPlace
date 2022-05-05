using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP
{
    internal interface IOperaciones
    {
        protected double num1 { get; set; }
        protected double num2 { get; set; }
        public double Operar();
    }
}
