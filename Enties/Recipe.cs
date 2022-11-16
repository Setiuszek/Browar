﻿using Browar.Enties.Ingredients;
using System.Reflection.Metadata.Ecma335;

namespace Browar.Enties
{
    public class Recipe
    {
        public String Name;
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

        public Recipe(String name, List<RecipeHop> recipeHops, List<RecipeMalt> recipeMalts, RecipeYeast yeast, List<MashingTime> mashingScheme, int eBC, int volume, int mashVolume, float extract)
        {
            Name = name;

            RecipeHops = recipeHops;
            RecipeMalts = recipeMalts;
            Yeast = yeast;
            MashingScheme = mashingScheme;
            Volume = volume;
            MashVolume = mashVolume;

            Extract = CalculateExtract();   
        }
        public float CalculateExtract()
        {
            var sum = 0;

            foreach (RecipeMalt recipeMalt in RecipeMalts)
            {
                sum = sum + recipeMalt.Malt.Extractivity * recipeMalt.AmountInRecipe;
            }

            return sum / Volume;
        }

        public int CalculateEBC()
        {
            double sum = 0;
            foreach (RecipeMalt recipeMalt in RecipeMalts)
            {
                sum = sum + recipeMalt.Malt.EBC * recipeMalt.AmountInRecipe;
            }
            sum = 2.9396 * Math.Pow(sum, 0.6859);

            return (int) sum;
        }
    }
}
