using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chapter05.Enums;

namespace Chapter05
{
	public class MandolinSpec : InstrumentSpec
	{
		public Style Style { get; set; }

		public MandolinSpec(
			Builder builder, 
			string model, 
			Enums.Type type, 
			Style style, 
			Wood backWood, 
			Wood topWood)
			: base(builder, model, type, backWood, topWood)
		{
			this.Style = style;
		}

		// TODO: Check the type conversion when build and finsish develop v1
		public override bool Matches(InstrumentSpec otherSpec)
		{
			if (!base.Matches(otherSpec))
				return false;
			
			var mandolinSpec = otherSpec as MandolinSpec;
			
			if (mandolinSpec != null && this.Style != mandolinSpec.Style)
				return false;

			return true;
		}
	}
}