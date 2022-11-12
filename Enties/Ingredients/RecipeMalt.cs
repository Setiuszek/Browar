namespace Browar.Enties.Ingredients
{
    public class RecipeMalt
    {
        public Malt Malt { get; set; }
        public String WhenAdded { get; set; }
        public int AmountInRecipe { get; set; }

        public RecipeMalt(Malt malt, string whenAdded, int amountInRecipe)
        {
            Malt = malt;
            WhenAdded = whenAdded;
            AmountInRecipe = amountInRecipe;
        }
    }
}
