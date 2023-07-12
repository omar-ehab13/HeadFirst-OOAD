using System.Net.Sockets;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chapter05
{
	public class Inventory
	{
		private List<Instrument> instruments;

		public Inventory()
		{
			instruments = new();
		}

		public void AddInstrument(string serialNumber, decimal price, InstrumentSpec spec)
		{
			Instrument? instrument = null;

			if (spec is GuitarSpec)
				instrument = new Guitar(serialNumber, price, (GuitarSpec)spec);

			else if (spec is MandolinSpec)
				instrument = new Mandolin(serialNumber, price, (MandolinSpec)spec);
			
			this.instruments.Add(instrument);
		}

		public Instrument Get(string serialNumber)
		{
			foreach (var i in this.instruments)
			{
				if (i.SerialNumber.Equals(serialNumber))
					return i;
			}

			return null;
		}

		public List<Guitar> Search(GuitarSpec searchSpec)
		{
			List<Guitar> selected = new();

			foreach (var instrument in instruments)
			{
				var guitar = instrument as Guitar;

				if (guitar is null) continue;

				if (instrument.Spec.Matches(searchSpec))
				{
					selected.Add(guitar);
				}
					
			}

			return selected;
		}

		public List<Mandolin> Search(MandolinSpec searchSpec)
		{
			List<Mandolin> selected = new();

			foreach (var instrument in instruments)
			{
				var mandolin = instrument as Mandolin;

				if (mandolin is null) continue;

				if (mandolin.Spec.Matches(searchSpec))
					selected.Add(mandolin);
			}

			return selected;
		}
	}
}