using Chapter05;
using Chapter05.Enums;

Inventory inventory = new();
InitializeInventory(inventory);

#region Search for guitar
GuitarSpec whatErinLikes = new GuitarSpec(Builder.FENDER, "Stratocastor", Chapter05.Enums.Type.ELECTRIC, 12, Wood.ALDER, Wood.ALDER);
List<Guitar> guitars = inventory.Search(whatErinLikes);

if (guitars.Count == 0)
	Console.WriteLine("Sorry, we have nothing for you.");

else
{
	foreach (var guitar in guitars)
	{
		Console.WriteLine($"You might like this {guitar} and number of stirngs:.\nYou can have it for only {guitar.Price}!");
		Console.WriteLine("---------------------------------------------------------------------");
	}
}
#endregion
System.Console.WriteLine("===============================================================================");
#region Search for mandolin
MandolinSpec whatOmarLikes = new MandolinSpec(Builder.FENDER, "Stratocastor", Chapter05.Enums.Type.ELECTRIC, Style.F, Wood.ALDER, Wood.ALDER);
List<Mandolin> mandolins = inventory.Search(whatOmarLikes);

if (mandolins.Count == 0)
	Console.WriteLine("Sorry, we have nothing for you.");

else
{
	foreach (var mandolin in mandolins)
	{
		Console.WriteLine($"You might like this {mandolin}.\nYou can have it for only {mandolin.Price}!");
		Console.WriteLine("---------------------------------------------------------------------");
	}
}
#endregion

 static void InitializeInventory(Inventory inventory)
{
	inventory.AddInstrument("V95693", 1499.95m, new GuitarSpec(Builder.FENDER, "Stratocastor", Chapter05.Enums.Type.ELECTRIC, 12, Wood.ALDER, Wood.ALDER));
	inventory.AddInstrument("V9512", 1549.95m, new GuitarSpec(Builder.FENDER, "Stratocastor", Chapter05.Enums.Type.ELECTRIC, 12, Wood.ALDER, Wood.ALDER));
	inventory.AddInstrument("V9513", 1549.95m, new MandolinSpec(Builder.FENDER, "Stratocastor", Chapter05.Enums.Type.ELECTRIC, Style.A, Wood.ALDER, Wood.ALDER));
	inventory.AddInstrument("V9514", 1549.95m, new MandolinSpec(Builder.FENDER, "Stratocastor", Chapter05.Enums.Type.ELECTRIC, Style.F, Wood.ALDER, Wood.ALDER));
	inventory.AddInstrument("V9515", 1549.95m, new MandolinSpec(Builder.FENDER, "Stratocastor", Chapter05.Enums.Type.ELECTRIC, Style.F, Wood.ALDER, Wood.ALDER));
	inventory.AddInstrument("V9516", 1549.95m, new GuitarSpec(Builder.FENDER, "Stratocastor", Chapter05.Enums.Type.ELECTRIC, 12, Wood.ALDER, Wood.ALDER));
}
