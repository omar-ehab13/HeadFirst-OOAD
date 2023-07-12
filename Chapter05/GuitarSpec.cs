using System.Collections.Immutable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chapter05.Enums;

namespace Chapter05
{
	public class GuitarSpec : InstrumentSpec
	{
		public int NumOfStrings { get; set; }

		public GuitarSpec(
			Builder builder, 
			string model, 
			Enums.Type type, 
			int numOfStrings, 
			Wood backWood, 
			Wood topWood)
			: base(builder, model, type, backWood, topWood)
		{
			this.NumOfStrings = numOfStrings;
		}

		// TODO: Check the type conversion when build and finsish develop v1
		public override bool Matches(InstrumentSpec otherSpec)
		{
			if (!base.Matches(otherSpec))
				return false;
			
			var guitarSpec = otherSpec as GuitarSpec;
			
			if (guitarSpec != null && this.NumOfStrings != guitarSpec.NumOfStrings)
				return false;

			return true;
		}
	}
}