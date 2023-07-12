using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chapter05.Enums;

namespace Chapter05
{
	public abstract class InstrumentSpec
	{
		public Builder Builder { get ; set;}
		public string Model { get; set;}
		public Enums.Type Type { get; set; }
		public Wood BackWood { get; set; }
		public Wood TopWood { get; set; }
		

		public InstrumentSpec(Builder builder, string model, Enums.Type type, Wood backWood, Wood topWood)
		{
			this.Builder = builder;
			this.Model = model;
			this.Type = type;
			this.BackWood = backWood;
			this.TopWood = topWood;
		}

		public virtual bool Matches(InstrumentSpec otherSpec)
		{
			if (this.Builder != otherSpec.Builder)
				return false;
			
			if (!String.IsNullOrEmpty(this.Model) && !this.Model.Equals(otherSpec.Model))
				return false;
			
			if (this.Type != otherSpec.Type)
				return false;
			
			if (this.TopWood != otherSpec.TopWood)
				return false;
			
			if (this.BackWood != otherSpec.BackWood)
				return false;

			return true;
		}
		
		public override string ToString()
        {
            return $"{Builder} {Model} {this.Type} {BackWood} back and sides, {TopWood} top.";
        }
	}
}