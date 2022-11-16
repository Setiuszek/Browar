using Browar.Enties;

namespace Browar.Services
{
    public class RecipeServices
    {
        public List<Recipe> Recipes;

        public RecipeServices()
        {
            Recipes = new List<Recipe>();
        }
        public void AddRecipe(Recipe recipe)
        {
           Recipes.Add(recipe); 
        }

        public Recipe GetRecipe(String name)
            => Recipes.FirstOrDefault(n => n.Name == name);
    }
}
