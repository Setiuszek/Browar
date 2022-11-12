namespace Browar.Enties.Ingredients
{
    public class RecipeYeast
    {
        public Yeast Yeast { get; set; }
        public int AmountInRecipe { get; set; }

        public RecipeYeast(Yeast yeast, int amountInRecipe)
        {
            Yeast = yeast;
            AmountInRecipe = amountInRecipe;
        }
    }
}
