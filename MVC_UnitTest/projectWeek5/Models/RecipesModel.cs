using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectWeek5.Models
{
    public class RecipesModel
    {
        public int recipe_Id { set; get; }
        public string recipe_Name { set; get; }
        public string recipe_Category { set; get; }
        public string recipe_Description { set; get; }
        public string recipe_Ingredients { set; get; }
        public string Image { set; get; }

    }
}
