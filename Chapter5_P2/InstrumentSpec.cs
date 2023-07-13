using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chapter5_P2.Enums;

namespace Chapter5_P2
{
	public class InstrumentSpec
	{
		public Dictionary<PropertyName, object> Properties { get; private set; }
		

		public InstrumentSpec(Dictionary<PropertyName, object> properties)
		{
			this.Properties = properties;
		}
		
		public object GetPropery(PropertyName propertyName) => 
			Properties[propertyName];

		public bool Matches(InstrumentSpec otherSpec)
		{
			foreach (var propName in otherSpec.Properties.Keys)
			{
				if (!this.Properties[propName].Equals(otherSpec.Properties[propName]))
					return false;
			}
			
			return true;
		}
	}
}