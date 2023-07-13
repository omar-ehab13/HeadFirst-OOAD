using System.Net.Sockets;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chapter5_P2
{
	public class Inventory
	{
		private List<Instrument> _inventory;

		public Inventory() => _inventory = new();

		public void AddInstrument(string serialNumber, decimal price, InstrumentSpec spec) =>
			_inventory.Add(new(serialNumber, price, spec));

		public Instrument? Get(string serialNumber)
		{
			foreach (var instrument in _inventory)
			{
				if (instrument.SerialNumber.Equals(serialNumber))
					return instrument;
			}

			return null;
		}

		public List<Instrument> Search(InstrumentSpec searchSpec)
		{
			var selected = new List<Instrument>();
			
			foreach (var instrument in _inventory)
			{
				if (instrument.Spec.Matches(searchSpec))
					selected.Add(instrument);
			}
			
			return selected;
		}
	}
}