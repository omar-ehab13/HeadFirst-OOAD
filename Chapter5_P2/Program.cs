using System.Collections.Immutable;
using Chapter5_P2.Enums;
using Chapter5_P2;

Inventory inventory = new();
// InitializeInventory(inventory);

Dictionary<PropertyName, object> properties = new();

properties.Add(PropertyName.BUILDER, Builder.GIBSON);
properties.Add(PropertyName.BACK_WOOD, Wood.MAPLE);

var clientSpec = new InstrumentSpec(properties);

List<Instrument> matchingInstruments = inventory.Search(clientSpec);

if (matchingInstruments.Count == 0)
	Console.WriteLine("Sorry, we have nothing for you.");

else
{
	System.Console.WriteLine("You might like these instruments:");

	foreach (var instrument in matchingInstruments)
	{
		System.Console.WriteLine($"We have {instrument.Spec.GetPropery(PropertyName.INSTRUMENT_TYPE)} with the following properties:");
		
		foreach (var propName in instrument.Spec.Properties.Keys)
		{
			if (propName.Equals(PropertyName.INSTRUMENT_TYPE))
				continue;
				
			System.Console.WriteLine($"\t{propName}: {instrument.Spec.GetPropery(propName)}");
		}
		
		System.Console.WriteLine($"You can have this: {instrument.Spec.GetPropery(PropertyName.INSTRUMENT_TYPE)} for ${instrument.Price}\n---");
	}
}
