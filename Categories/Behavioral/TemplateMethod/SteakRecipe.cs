public class SteakRecipe : Recipe
{
    public override void PrepareDish()
    {
           Console.WriteLine("Grill the steak.");
    }

    public override void CookDish()
    {
        Console.WriteLine("Cook the steak.");
    }
}