using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chapter05
{
	public abstract class Instrument
	{
		public string SerialNumber { get; set; }
		public decimal Price { get; set; }
		public InstrumentSpec Spec { get; set; }

		public Instrument(string serialNumber, decimal price, InstrumentSpec spec)
		{
			this.SerialNumber = serialNumber;
			this.Price = price;
			this.Spec = spec;
		}

		public InstrumentSpec GetSpec()
		{
			return this.Spec;
		}

        public override string ToString()
        {
            return this.Spec.ToString();
        }
    
	}
}