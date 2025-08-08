// See https://aka.ms/new-console-template for more information
Console.WriteLine("Construction of wooden house:");
var woodenHouse = new ConstructionEngineer(new WoodenHouseBuilder()).ConstructHouse();
woodenHouse.Show();;

Console.WriteLine("Construction of glass house:");
var glassHouse = new ConstructionEngineer(new GlassHouseBuilder()).ConstructHouse();
glassHouse.Show();
Console.ReadLine();
