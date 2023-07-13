using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chapter5_P2
{
	public class Instrument
	{
		public string SerialNumber { get; private set; }
		public decimal Price { get; private set; }
		public InstrumentSpec Spec { get; private set; }

		public Instrument(string serialNumber, decimal price, InstrumentSpec spec)
		{
			this.SerialNumber = serialNumber;
			this.Price = price;
			this.Spec = spec;
		}
	}
}