using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Creation.Builder
{
    public class MealBuilder
    {
        public Meal PrepareVegMeal()
        {
            var meal = new Meal();
            meal.Add(new VegBurger());
            meal.Add(new Coke());
            return meal;
        }

        public Meal PrepareNonVegMeal()
        {
            var meal = new Meal();
            meal.Add(new ChickenBurger());
            meal.Add(new Pepsi());
            return meal;
        }
    }
}
