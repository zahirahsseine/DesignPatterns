public class ConstructionEngineer
{
    public IHouseBuilder _houseBuilder;
    public ConstructionEngineer(IHouseBuilder houseBuilder) => _houseBuilder = houseBuilder;

    public House ConstructHouse()
    {
        _houseBuilder.BuildDoors();
        _houseBuilder.BuildWalls();
        _houseBuilder.BuildWindows();
        _houseBuilder.BuildRoof();
        return _houseBuilder.GetHouse();
    }
}