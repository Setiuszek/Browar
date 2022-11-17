using Browar.Enties.Ingredients;

namespace Browar.Enties
{
    public static class Calc
    {
        public static float CalculateExtract(List<RecipeMalt> RecipeMalts, int Volume)
        {
            var sum = 0;

            foreach (RecipeMalt recipeMalt in RecipeMalts)
            {
                sum = sum + recipeMalt.Malt.Extractivity * recipeMalt.AmountInRecipe;
            }

            return sum / Volume;
        }

        public static int CalculateEBC(List<RecipeMalt> RecipeMalts, int Volume)
        {
            double sum = 0;
            foreach (RecipeMalt recipeMalt in RecipeMalts)
            {
                sum = sum + recipeMalt.Malt.EBC * recipeMalt.AmountInRecipe;
            }
            sum = 2.9396 * Math.Pow(sum / Volume, 0.6859);

            return (int)sum;
        }
    }
}
