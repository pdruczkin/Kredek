using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using PatrykRuczkinLab4PracDom.Models;

namespace PatrykRuczkinLab4PracDom.Services
{
    public interface IHomeService
    {
        List<RecipeViewModel> GetAllRecipes();
        RecipeViewModel GetRecipeById(int id);
        void AddRecipe(CreateRecipeDto recipe);
    }

    public class HomeService : IHomeService
    {
        private List<RecipeViewModel> _recipes;

        public HomeService()
        {
            _recipes = new List<RecipeViewModel>
            {
                new RecipeViewModel(1,"Pizza Salami", "Pizza na cienkim cieściez ciągnącym się serem i włoskim salami",
                    28, "~/pizza_cheese_salami.jpg"),
                new RecipeViewModel(2,"Pizza Margherita", "Klasyk nad klasykami, ciasto, sos pomidorowy i ser z odrobiną bazylii",25,"~/pizza_margherita.jpg")
            };

        }

        public List<RecipeViewModel> GetAllRecipes()
        {
            return _recipes;
        }

        public RecipeViewModel GetRecipeById(int id)
        {
            var recipe = _recipes.FirstOrDefault(r => r.Id == id);
            return recipe;
        }

        public void AddRecipe(CreateRecipeDto recipe)
        {
            // następny przepis będzie miał index o wartości wielkości listy przepisów + 1
            int id = _recipes.Count + 1;
            var recipeToAdd = new RecipeViewModel(id, recipe.Name, recipe.Description, recipe.Price, $"~/{recipe.Photo}");
            _recipes.Add(recipeToAdd);
        }
    }
}