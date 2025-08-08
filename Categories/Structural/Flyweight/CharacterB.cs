 public class CharacterB : ICharacter
 {
     private readonly string _fontFamily;

     public CharacterB()
     {
         _fontFamily = "Arial";
         Console.WriteLine("Creating Character B");
     }

     public void Display(int x, int y)
     {
         Console.WriteLine($"Character B (Font: {_fontFamily}) at position ({x}, {y})");
     }
 }