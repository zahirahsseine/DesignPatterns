public abstract class Recipe
{
    public void MakeDish()
    {
        PrepareDish();
        CookDish();
        ServeDish();
    }
    public abstract void PrepareDish();
    public abstract void CookDish();
    
    // Optional common step
    public virtual void ServeDish()
    {
        Console.WriteLine("Serve on a plate.");
    }
}