public class GlassHouseBuilder : IHouseBuilder
{
    private House _house;
    public GlassHouseBuilder()
    {
        _house = new House();
    }
    
    public void BuildDoors() => _house.Doors = "Glass Doors";
    public void BuildRoof() => _house.Roof = "Glass Roof";
    public void BuildWalls() => _house.Walls = "Glass Walls";
    public void BuildWindows() => _house.Windows = "Glass Windows";
    public House GetHouse() => _house;
}