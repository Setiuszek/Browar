using Browar.Enties.Ingredients;
using System.Reflection.Metadata.Ecma335;

namespace Browar.Enties
{
    public class Recipe
    {
        List<RecipeHop> RecipeHops;
        List<RecipeMalt> RecipeMalts;
        RecipeYeast Yeast;
        List<MashingTime> MashingScheme;

        //Podawane przez usera
        public int Volume { get; set; }
        public int MashVolume { get; set; }

        //Obliczone
        public float Extract { get; set; }
        public int EBC { get; set; }

        public Recipe(List<RecipeHop> recipeHops, List<RecipeMalt> recipeMalts, RecipeYeast yeast, List<MashingTime> mashingScheme, int eBC, int volume, int mashVolume, float extract)
        {
            RecipeHops = recipeHops;
            RecipeMalts = recipeMalts;
            Yeast = yeast;
            MashingScheme = mashingScheme;
            Volume = volume;
            MashVolume = mashVolume;
        }
    }
}
