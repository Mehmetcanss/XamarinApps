using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinRecipeApp.Models
{
    public class RecipeGrouping : List<Recipe>
    {
        public string Title { get; set; }

        public string ShortName { get; set; }

        public RecipeGrouping(string title, string shortname)
        {
            Title = title;
            ShortName = shortname;
        }
    }
}
