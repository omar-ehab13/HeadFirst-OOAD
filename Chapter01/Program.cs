using Chapter01;

Inventory inventory = new Inventory();
InitializeInventory(inventory);

GuitarSpecification whatErinLikes = new GuitarSpecification(Builder.FENDER, "Stratocastor", GuitarType.ELECTRIC, Wood.ALDER, Wood.ALDER, 12);
List<Guitar> guitars = inventory.Search(whatErinLikes);

if (guitars.Count == 0)
    Console.WriteLine("Sorry, we have nothing for you.");

else
{
    foreach (var guitar in guitars)
    {
        Console.WriteLine($"You might like this {guitar}.\nYou can have it for only {guitar.Price}!");
        Console.WriteLine("---------------------------------------------------------------------");
    }
}

 static void InitializeInventory(Inventory inventory)
{
    inventory.AddGuitar(new Guitar("V95693", 1499.95m, new GuitarSpecification(Builder.FENDER, "Stratocastor", GuitarType.ELECTRIC, Wood.ALDER, Wood.ALDER, 12)));
    inventory.AddGuitar(new Guitar("V9512", 1549.95m, new GuitarSpecification(Builder.FENDER, "Stratocastor", GuitarType.ELECTRIC, Wood.ALDER, Wood.ALDER, 12)));
}
