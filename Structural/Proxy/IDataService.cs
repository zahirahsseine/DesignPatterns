public interface IDataService
{
    Task<List<string>> GetData();
    void InsertData(string item);
}