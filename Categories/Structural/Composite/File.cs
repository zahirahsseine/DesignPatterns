  public class File(string name) : IComponent
  {
      public string Name  => name;


      public void Display(string curentPath)
      {
          Console.WriteLine(curentPath + name);
      }
  }