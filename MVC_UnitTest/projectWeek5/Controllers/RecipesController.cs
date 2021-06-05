using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projectWeek5.Models;

namespace projectWeek5.Controllers
{
    public class RecipesController : Controller
    {
        List<RecipesModel> recipes = new List<RecipesModel>()
    {
        new RecipesModel(){ recipe_Id =1, recipe_Name="Asian Chicken and Vegetable Soup",recipe_Category="Soup",
            recipe_Ingredients="canola oil 1/2 tbsp, shallots, finely chopped 1/2, soybean sprouts	1 1/2 cup, green onions/scallions, thinly sliced, rice sticks (noodles), chicken for Chinese fondue," +
            "water	1 cup, dried chili peppers, minced	1/2	",
            recipe_Description="1.Heat the oil in a saucepan over medium-low heat. Add the shallot, then sauté 2-3 min. Add the garlic, ginger and chili pepper. Sauté 3 min with stirring. Pour in the broth and water, then add the fish sauce and a little salt and pepper. Bring to a boil, then lower the heat and simmer a few minutes. Adjust the seasoning. " +
            "Add the chicken slices, warm up the broth 1 min, then take the saucepan off the heat."+
            " 2.Meanwhile, cook the rice sticks for about 4 min in a large pot of salted boiling water. Drain in a colander, then rinse and drain again. Set aside. " +
            " 3. Prepare the vegetables: Grate the carrots, then thinly slice the green onions and mushrooms. Portion out the vegetables into individual serving bowls. Add the soybean sprouts and cooked rice sticks. Pour in the hot broth and serve",Image="https://media.soscuisine.com/images/recettes/large/3628.jpg"},
        new RecipesModel(){recipe_Id=2, recipe_Name="Quinoa and Lentil Bowl", recipe_Category="Saled",
        recipe_Ingredients="quinoa 1 1/4 cup, lentils (canned), rinsed and drained 2 3/4 cups, yellow or red sweet peppers, finely diced,shallots, finely chopped, arugula, coarsely chopped 1/2 bunch, " + "carrots, grated, lemon juice, freshly squeezed	",
         recipe_Description="1.Cook the quinoa then let it cool down 10 minutes."+" 2.Rinse and drain the lentils. Set aside." +" 3.Prepare the vegetables: Seed, core and dice the pepper; finely chop the shallot; coarsely chop the arugula; grate the carrot.Place the vegetables in a large bowl.Add the lentils and quinoa to the bowl."+
        " 4.In a small bowl, whisk together the oil, lemon juice, mustard, salt, and pepper. Pour over the salad. Gently toss to combine. Coarsely crumble the feta cheese and add it on top of the salad.Sprinkle with the finely chopped mint and pumpkin seeds then serve.",Image="https://media.soscuisine.com/images/recettes/large/3996.jpg"},
        new RecipesModel(){recipe_Id=3, recipe_Name="Blueberry and Lemon Muffins",recipe_Category="Dessert", recipe_Ingredients="brown rice flour 1 cup, tapioca flour/starch , almond meal, guar gum, or xanthan, baking powder, salt, margarine non-hydrogenated, sucanat, almond beverage, unsweetened, fortified, eggs, blueberries"
        ,recipe_Description="1.Preheat the oven to 350°F (180°C). Grease a 12-cup muffin pan.  2.Combine the flours, almond meal, guar gum or xanthan, baking powder and salt in a bowl." +
            " 3.In another bowl, mix the margarine, sugar and lemon zest with a mixer. While whisking, add the eggs one at a same time, and then the lemon juice. Stir in the dry ingredients and milk alternately. Add the blueberries to the mixture." +
            " 4.Fill the prepared muffin pan three-quarters of the way. Dust with raw sugar and decorate with 3 or 4 large blueberries.\n 5.Bake for 35 to 40 minutes.",Image="https://media.soscuisine.com/images/recettes/large/2267.jpg"},
        new RecipesModel(){recipe_Id=4, recipe_Name="Marinated Salmon",recipe_Category="Main Dish",recipe_Ingredients="green onions/scallions, finely chopped, garlic, minced," +
            "gingerroot, grated, soy sauce,	Hoisin sauce, olive oil, lemon juice, freshly squeezed, salmon fillet",
            recipe_Description="1.Finely chop the scallion, mince the garlic, then put them in a shallow dish. Add the grated ginger, soy sauce, Hoisin sauce, oil, lemon juice, and pepper. Whisk using a fork to combine the ingredients. It is not necessary to add any salt since the soy and Hoisin sauces are already rather salty." +
            " 2.Put the salmon in the dish and turn it to coat with the marinade. Cover and let stand either 30 min at room temperature or overnight in the refrigerato \n 3.Preheat the oven to 190ºC/375ºF." +
            " 4.Remove the salmon from the marinade, letting the excess marinade drip off, then transfer it to a baking sheet, skin side down. Bake in the middle of the oven about 20 min. Alternatively, the salmon may be cooked on an outdoor grill." +
            " 5.Check with a fork to see if the fish is cooked through. Separate and lift the salmon from the skin with a metal spatula and serve (discard skin).",Image="https://media.soscuisine.com/images/recettes/large/460.jpg"},
        new RecipesModel(){recipe_Id=5, recipe_Name="Carrots and Leeks with Fresh Mint",recipe_Category="Side dishes",recipe_Ingredients="carrots, cut into 1 cm rounds, leeks, cut into 2 cm pieces, olive oil, gingerroot, grated, fresh mint",
            recipe_Description="1.Preheat the oven to 195°C/375°F.  2.Prepare the carrots and cut them into rounds about 1 cm thick. Prepare the leeks, remove about ¼ of the dark-green part, and cut them into 2 cm pieces." +
            " 3.Transfer the vegetables to a baking sheet or dish (do not choose one that is too large, since the vegetables will reduce considerably in size while cooking). Add the oil, minced ginger, salt and pepper. Mix well to coat thoroughly with oil, then put in the oven and bake about 35 min." +
            " 4.Finely chop half of the mint leaves then add them to the dish, mix and continue baking for about 15 min more. Garnish with the remaining mint leaves and serve", Image="https://media.soscuisine.com/images/recettes/large/208.jpg"},
        new RecipesModel(){recipe_Id=6, recipe_Name=" Cauliflower \"Popcorn\"",recipe_Category="Side dishes",recipe_Ingredients="olive oil, wine vinegar, paprika,cauliflower, cut into small, equal-size florets",
            recipe_Description="1.Preheat the oven to 230°C/450°F. Line a large baking sheet with parchment paper.  2.Add the oil, vinegar, spices, and salt to a large bowl. Whisk well." +
            " 3.Cut the cauliflower into equal-size small florets, then add them to the vinaigrette bowl. Toss to coat well. Spread the florets in single layer on the prepared baking sheet." +
            " 4.Roast in the middle of the oven until golden and tender-crisp, stirring occasionally, about 25-30 min.  5.Serve warm or at room temperature.",Image="https://media.soscuisine.com/images/recettes/large/2759.jpg"},

   };
       
        public IActionResult Index()
        {
            ViewData["recipes"] = recipes;
            return View("Index");
        }
        public IActionResult Details(int? id)
        {
            RecipesModel recipe = recipes.Find(recipe => recipe.recipe_Id == id);
            if (recipe == null)
            {
                return Content("Not found recipe");
            }
            else
            {
                ViewData["recipe"] = recipe;
                return View();
            }
        }
    }
}


