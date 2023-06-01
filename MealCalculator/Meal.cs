using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealCalculator
{
    public enum MealType
    {
        Breakfast,
        Lunch,
        Dinner,
    }

    public class Meal
    {
        private MealType Type;
        private string Name;
        private Array Ingredients;

        public Meal(MealType type, string name, Array ingredients)
        {
            this.Type = type;
            this.Name = name;
            this.Ingredients = ingredients;
        }

        public MealType getMealType() { return Type; }
        public string getName() { return Name; }
        public Array getIngredients() {  return Ingredients; }
    }
}
