using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinRecipeApp.Models;
using XamarinRecipeApp.ViewCells;

namespace XamarinRecipeApp.DataTemplateSelectors
{
    public class RecipeDataTemplateSelector : DataTemplateSelector
    {

        DataTemplate recipeTemplate;
        DataTemplate recommendedTemplate;

        public RecipeDataTemplateSelector()
        {
            recipeTemplate = new DataTemplate(typeof(RecipeCell));
            recommendedTemplate = new DataTemplate(typeof(RecommendedRecipeCell));
        }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var recipe = item as Recipe;
            if (recipe == null) return null;
            return recipe.Recommended ? recommendedTemplate : recipeTemplate;
                
        }
    }
}
