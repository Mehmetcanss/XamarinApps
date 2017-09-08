using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinRecipeApp.Models
{
    public class Recipe
    {
        public string RecipeName { get; set; }

        public string PreparationTime { get; set; }

        public string CookTime { get; set; }

        public int NumberOfServings { get; set; }

        public bool WillMakeAgain { get; set; }

        public MealType MealType { get; set; }

        public Difficulty Difficulty { get; set; }

        public string Ingredients { get; set; }

        public string Directions { get; set; }

        public string ImageName { get; set; }
    }
}
