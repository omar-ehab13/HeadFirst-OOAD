using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chapter05
{
    public class Mandolin : Instrument
    {
        public Mandolin(string serialNumber, decimal price, MandolinSpec spec)
            : base(serialNumber, price, spec)
        {
            
        }
    }
}