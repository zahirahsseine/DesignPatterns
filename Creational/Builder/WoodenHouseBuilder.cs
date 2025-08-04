public class WoodenHouseBuilder : IHouseBuilder
{
    private House _house;
    public WoodenHouseBuilder()
    {
        _house = new House();
    }

    public  void BuildRoof() => _house.Roof = "Wooden Roof";
    public  void BuildWalls() => _house.Walls = "Wooden Walls";
    public  void BuildWindows() => _house.Windows = "Wooden Windows";
    public  void BuildDoors() => _house.Doors = "Wooden Doors";
    public House GetHouse() => _house;
}