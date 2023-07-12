using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chapter05
{
    public class Guitar : Instrument
    {
        public Guitar(string serialNumber, decimal price, GuitarSpec spec)
            : base(serialNumber, price, spec)
        {
            
        }
    }
}