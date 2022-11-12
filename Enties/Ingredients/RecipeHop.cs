namespace Browar.Enties.Ingredients
{
    public class RecipeHop
    {
        public Hop Hop { get; set; }
        public int AmountInRecipe { get; set; }
        public String WhenAdded { get; set; }
        public int HowLong { get; set; }

        public RecipeHop(Hop hop, int amountInRecipe, string whenAdded, int howLong)
        {
            Hop = hop;
            AmountInRecipe = amountInRecipe;
            WhenAdded = whenAdded;
            HowLong = howLong;
        }
    }
}
