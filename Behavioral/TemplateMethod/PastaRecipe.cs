public class PastaRecipe : Recipe
{
    public override void PrepareDish()
    {
        Console.WriteLine("Boil water and cook pasta.");
    }
   
    public override void CookDish()
    {
        Console.WriteLine("Cook the cooked pasta.");
    }
}