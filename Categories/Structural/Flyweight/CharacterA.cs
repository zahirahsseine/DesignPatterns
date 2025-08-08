public class CharacterA : ICharacter
{
    private readonly string _fontFamily;
    public CharacterA()
    {
        _fontFamily = "Arial"; // intrinsic (shared)
        Console.WriteLine("Creating Character A");
    }
    
    public void Display(int x, int y)
    {
       Console.WriteLine($"Character A (Font: {_fontFamily}) at position ({x}, {y})");
    }
}